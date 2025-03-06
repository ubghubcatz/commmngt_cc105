Imports Microsoft.Data.SqlClient
Imports System.IO
Imports QRCoder

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

End Class
