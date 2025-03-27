Imports ZXing
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports Microsoft.Data.SqlClient
Imports ZXing.Windows.Compatibility

Public Class Attendance
    Dim conn As New SqlConnection("Data Source=commngtcc105.mssql.somee.com;Initial Catalog=commngtcc105;User ID=ublipa_SQLLogin_1;Password=nktg6ikffl;TrustServerCertificate=True")
    Dim captureDevice As FilterInfoCollection
    Dim videoSource As VideoCaptureDevice
    Private WithEvents scanTimer As New Timer()


    ' Automatically start scanning when the form loads
    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        captureDevice = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If captureDevice.Count > 0 Then
            videoSource = New VideoCaptureDevice(captureDevice(0).MonikerString)
            AddHandler videoSource.NewFrame, AddressOf CaptureFrame
            videoSource.Start()
            scanTimer.Start()
        Else
            MessageBox.Show("No webcam detected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Capture and process QR code from the camera feed
    Private Sub CaptureFrame(sender As Object, eventArgs As NewFrameEventArgs)
        Try
            Dim frame As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)

            ' Flip the image horizontally (mirror effect)
            frame.RotateFlip(RotateFlipType.RotateNoneFlipX)

            ' Display mirrored image in PictureBox
            pbCamera.Image = frame
        Catch ex As Exception
            MessageBox.Show("Error capturing frame: " & ex.Message, "Camera Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Timer to check for QR codes
    Sub scanTimer_Tick(sender As Object, e As EventArgs) Handles scanTimer.Tick
        ' Check if the PictureBox contains an image
        If pbCamera.Image Is Nothing Then
            Exit Sub ' Exit if there's no image
        End If

        Try
            ' Convert PictureBox image to Bitmap
            Dim bitmap As New Bitmap(pbCamera.Image)

            ' Flip the image if necessary (mirrored input)
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX)

            ' Create a BarcodeReader instance
            Dim Reader As New BarcodeReader()

            ' Decode the QR code from the Bitmap
            Dim result As Result = Reader.Decode(bitmap)

            If result Is Nothing Then
                Exit Sub ' Prevents the error if no QR code is found
            End If

            Dim empID As String = result.Text.Trim()
            scanTimer.Stop()
            ProcessAttendance(empID)

        Catch ex As Exception
            MessageBox.Show("Error decoding QR code: " & ex.Message, "QR Code Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Process Attendance based on Employee ID from QR
    Private Sub ProcessAttendance(empID As String)
        Try
            conn.Open()

            ' Retrieve employee details
            Dim query As String = "SELECT e.PhotoPath, ed.EmployeeName, ed.Position, ed.EmployeeID 
                                   FROM g4_EmployeeDetails ed 
                                   INNER JOIN g4_EmployeesInfo e ON ed.EmployeeID = e.EmployeeID 
                                   WHERE ed.EmployeeID = @empID"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@empID", empID)

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                lblName.Text = reader("EmployeeName").ToString()
                lblPosition.Text = reader("Position").ToString()
                lblID.Text = reader("EmployeeID").ToString()

                Dim imgPath As String = reader("PhotoPath").ToString()
                If imgPath.StartsWith("http") Then
                    Try
                        Dim client As New System.Net.WebClient()
                        Dim imgStream As New IO.MemoryStream(client.DownloadData(imgPath))
                        pbEmployeePhoto.Image = Image.FromStream(imgStream)
                        pbEmployeePhoto.SizeMode = PictureBoxSizeMode.Zoom
                    Catch ex As Exception
                        pbEmployeePhoto.Image = Nothing
                        MessageBox.Show("Failed to load employee photo.", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End Try
                ElseIf IO.File.Exists(imgPath) Then
                    pbEmployeePhoto.Image = Image.FromFile(imgPath)
                    pbEmployeePhoto.SizeMode = PictureBoxSizeMode.Zoom
                Else
                    pbEmployeePhoto.Image = Nothing
                End If

            Else
                MessageBox.Show("Employee not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                reader.Close()
                conn.Close()
                scanTimer.Start()
                Return
            End If
            reader.Close()

            ' Retrieve last Time In and Time Out
            Dim timeQuery As String = "SELECT ScanTime, ScanType FROM g4_EmployeeAttendance WHERE EmployeeID = @empID ORDER BY ScanTime DESC"
            Dim timeCmd As New SqlCommand(timeQuery, conn)
            timeCmd.Parameters.AddWithValue("@empID", empID)

            Dim timeReader As SqlDataReader = timeCmd.ExecuteReader()
            Dim lastTimeIn As String = "N/A"
            Dim lastTimeOut As String = "N/A"
            Dim lastScanType As String = ""

            While timeReader.Read()
                Dim scanTime As DateTime = Convert.ToDateTime(timeReader("ScanTime"))
                Dim scanType As String = timeReader("ScanType").ToString()

                If scanType = "IN" AndAlso lastTimeIn = "N/A" Then
                    lastTimeIn = scanTime.ToString("hh:mm:ss tt")
                ElseIf scanType = "OUT" AndAlso lastTimeOut = "N/A" Then
                    lastTimeOut = scanTime.ToString("hh:mm:ss tt")
                End If

                If lastScanType = "" Then
                    lastScanType = scanType
                End If
            End While
            timeReader.Close()

            ' Display last recorded Time In and Time Out
            lblTimeIn.Text = lastTimeIn
            lblTimeOut.Text = lastTimeOut

            ' Determine next scan type (toggle between IN and OUT)
            Dim newScanType As String = If(lastScanType = "IN", "OUT", "IN")

            ' Insert new time record
            Dim insertQuery As String = "INSERT INTO g4_EmployeeAttendance (EmployeeID, ScanTime, ScanType) VALUES (@empID, GETDATE(), @scanType)"
            Dim insertCmd As New SqlCommand(insertQuery, conn)
            insertCmd.Parameters.AddWithValue("@empID", empID)
            insertCmd.Parameters.AddWithValue("@scanType", newScanType)
            insertCmd.ExecuteNonQuery()

            ' Update labels with new scan time
            If newScanType = "IN" Then
                lblTimeIn.Text = DateTime.Now.ToString("hh:mm:ss tt")
                lblTimeOut.Text = "N/A"
                MessageBox.Show("Time In recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                lblTimeOut.Text = DateTime.Now.ToString("hh:mm:ss tt")
                MessageBox.Show("Time Out recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
            scanTimer.Start()
        End Try
    End Sub

    ' Stop camera when form is closed
    Private Sub Attendance_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
            videoSource.SignalToStop()
        End If
    End Sub
End Class
