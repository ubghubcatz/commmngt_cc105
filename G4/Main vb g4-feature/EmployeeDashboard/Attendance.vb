Imports Microsoft.Data.SqlClient

Public Class Attendance
    Dim conn As New SqlConnection("Data Source=commngtcc105.mssql.somee.com;Initial Catalog=commngtcc105;User ID=ublipa_SQLLogin_1;Password=nktg6ikffl;TrustServerCertificate=True")

    'Method para sa button para mag automatic Time in and Time out
    Private Sub btnTimeInOut_Click(sender As Object, e As EventArgs) Handles btnTimeInOut.Click
        Dim empID As String = txtEmployeeID.Text.Trim()

        If empID = "" Then
            MessageBox.Show("Please enter an Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

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

                If IO.File.Exists(imgPath) Then
                    Dim img As Image = Image.FromFile(imgPath)
                    pbEmployeePhoto.SizeMode = PictureBoxSizeMode.Zoom
                    pbEmployeePhoto.Image = img
                Else
                    pbEmployeePhoto.Image = Nothing ' No image found
                    pbEmployeePhoto.SizeMode = PictureBoxSizeMode.Normal
                End If
            Else
                MessageBox.Show("Employee not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                reader.Close()
                conn.Close()
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
        End Try
    End Sub
End Class
