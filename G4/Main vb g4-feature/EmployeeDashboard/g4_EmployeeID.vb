Imports Microsoft.Data.SqlClient
Imports System.IO
Imports QRCoder
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms


Public Class g4_EmployeeID

    Dim conn As New SqlConnection("Data Source=commngtcc105.mssql.somee.com;Initial Catalog=commngtcc105;User ID=ublipa_SQLLogin_1;Password=nktg6ikffl;TrustServerCertificate=True")

    ' Accept Employee ID from List form
    Public Sub LoadEmployeeDetails(employeeID As String)
        idNumber.Text = employeeID
    End Sub

    Private Sub BtnloadDetails_Click(sender As Object, e As EventArgs) Handles btnloadDetails.Click
        Try
            ' Debugging: Check if Employee ID is passed correctly
            If String.IsNullOrEmpty(idNumber.Text.Trim()) Then
                MessageBox.Show("Please enter an Employee ID before loading details.")
                Exit Sub
            End If

            conn.Open()

            Dim sql As String = "SELECT e.EmployeeID, e.FirstName, e.MiddleName, e.LastName, e.Position, e.ContactNumber, e.PhotoPath, d.FullAddress 
                     FROM g4_EmployeesInfo e 
                     INNER JOIN g4_EmployeeDetails d ON e.EmployeeID = d.EmployeeID
                     WHERE e.EmployeeID = @EmployeeID"

            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@EmployeeID", idNumber.Text.Trim())

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                IDNumberlbl.Text = reader("EmployeeID").ToString()
                lblFullName.Text = $"{reader("FirstName")} {reader("MiddleName")} {reader("LastName")}"
                lblPosition.Text = reader("Position").ToString()
                lblContactNo.Text = reader("ContactNumber").ToString()
                lblFullAddress.Text = reader("FullAddress").ToString()

                ' Load Photo
                Dim photoPath As String = reader("PhotoPath").ToString()
                If Not String.IsNullOrEmpty(photoPath) AndAlso File.Exists(photoPath) Then
                    idPic.Image = Image.FromFile(photoPath)
                    idPic.SizeMode = PictureBoxSizeMode.Zoom
                Else
                    MessageBox.Show("Photo not found: " & photoPath)
                    idPic.Image = Nothing
                End If

                ' Generate QR Code
                Dim qrData As String = $"ID: {reader("EmployeeID")}, Name: {reader("FirstName")} {reader("MiddleName")} {reader("LastName")}, Position: {reader("Position")}"
                GenerateQRCode(qrData)

            Else
                MessageBox.Show("Employee not found.")
                IDNumberlbl.Text = ""
                lblFullName.Text = ""
                lblPosition.Text = ""
                idPic.Image = Nothing
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub GenerateQRCode(qrText As String)
        Try
            Dim qrGenerator As New QRCodeGenerator()
            Dim qrData As QRCodeData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q)
            Dim qrCode As New QRCode(qrData)
            Dim qrBitmap As Bitmap = qrCode.GetGraphic(20)

            QRpbox.Image = qrBitmap
        Catch ex As Exception
            MessageBox.Show("Error generating QR code: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSaveQR_Click(sender As Object, e As EventArgs) Handles btnSaveQR.Click
        If QRpbox.Image IsNot Nothing Then
            Dim saveDialog As New SaveFileDialog With {
                .Filter = "PNG Image|*.png",
                .Title = "Save QR Code",
                .FileName = "EmployeeQR_" & IDNumberlbl.Text
            }

            If saveDialog.ShowDialog = DialogResult.OK Then
                QRpbox.Image.Save(saveDialog.FileName, Imaging.ImageFormat.Png)
                MessageBox.Show("QR Code saved successfully!")
            End If
        Else
            MessageBox.Show("No QR Code to save.")
        End If
    End Sub

    'Method to print the ID or save as Image
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            ' Capture the front and back panels as images
            Dim frontImage As Bitmap = CapturePanel(frontPanel)
            Dim backImage As Bitmap = CapturePanel(backPanel)

            ' Merge both images into one
            Dim finalImage As New Bitmap(frontPanel.Width * 2, frontPanel.Height) ' Width * 2 to fit both images
            Using g As Graphics = Graphics.FromImage(finalImage)
                g.DrawImage(frontImage, 0, 0) ' Draw front panel
                g.DrawImage(backImage, frontPanel.Width, 0) ' Draw back panel beside it
            End Using

            ' Print the final image
            Dim printDoc As New Printing.PrintDocument()
            AddHandler printDoc.PrintPage, Sub(senderObj, ev)
                                               ev.Graphics.DrawImage(finalImage, 0, 0)
                                           End Sub

            ' Show print preview before printing
            Dim printPreview As New PrintPreviewDialog() With {
            .Document = printDoc
        }
            printPreview.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Error printing ID: " & ex.Message)
        End Try
    End Sub

    'Function of the Capture of Panel from btnPrint

    Private Function CapturePanel(panel As Panel) As Bitmap
        Dim bmp As New Bitmap(panel.Width, panel.Height)
        panel.DrawToBitmap(bmp, New Rectangle(0, 0, panel.Width, panel.Height))
        Return bmp
    End Function




End Class
