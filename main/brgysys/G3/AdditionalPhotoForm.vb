Imports System.Drawing.Imaging
Imports System.IO

Public Class AdditionalPhotoForm

    Dim AdditionalImagePath As String
    Dim imageBytes As Byte() = Nothing
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' Select Image
        Using ofd As New OpenFileDialog
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If ofd.ShowDialog = DialogResult.OK Then
                AdditionalImagePath = ofd.FileName
                ' Convert and compress the image to byte array
                imageBytes = CompressImage(AdditionalImagePath, 50L) ' Adjust quality as needed

                ' Load and display the image in the PictureBox
                PictureBox1.Image = Image.FromFile(AdditionalImagePath)
            Else
                MessageBox.Show("No image selected.")
                Exit Sub
            End If
        End Using
    End Sub

    Private Function CompressImage(imagePath As String, quality As Long) As Byte()
        Dim imageBytes As Byte() = Nothing
        Using img As Image = Image.FromFile(imagePath)
            Dim jpgEncoder As ImageCodecInfo = ImageCodecInfo.GetImageEncoders().FirstOrDefault(Function(codec) codec.FormatID = ImageFormat.Jpeg.Guid)
            If jpgEncoder IsNot Nothing Then
                Dim encoderParams As New EncoderParameters(1)
                encoderParams.Param(0) = New EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality)
                Using ms As New MemoryStream()
                    img.Save(ms, jpgEncoder, encoderParams)
                    imageBytes = ms.ToArray()
                End Using
            End If
        End Using
        Return imageBytes
    End Function

    Private Sub AddPic_Btn_Click(sender As Object, e As EventArgs) Handles AddPic_Btn.Click
        If String.IsNullOrWhiteSpace(PhotoDescription_TxtBox.Text) Then
            MessageBox.Show("Please enter a description.")
            Exit Sub
        End If

        If imageBytes Is Nothing Then
            MessageBox.Show("Please select an image first.")
            Exit Sub
        End If

        ' Convert imageBytes back to an Image
        Dim ms As New MemoryStream(imageBytes)
        Dim img As Image = Image.FromStream(ms)

        ' Find the open CaseRecordForm and call the AddAditionalPicture method
        For Each f As Form In Application.OpenForms
            If TypeOf f Is CaseRecordForm Then
                Dim mainForm As CaseRecordForm = CType(f, CaseRecordForm)
                ' Check if max photos reached
                If mainForm.AdditionalPhotos_FlowLayoutPanel.Controls.Count >= 6 Then
                    MessageBox.Show("You can only add up to 6 photos.")
                    Exit Sub
                End If
                Dim description As String = PhotoDescription_TxtBox.Text ' Store the description in Tag
                mainForm.AddAditionalPicture(img, description) ' Call the method to add the PictureBox
                Me.Close()
                Exit For
            End If
        Next
    End Sub

    Private Sub AdditionalPhotoForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        For Each f As Form In Application.OpenForms
            If TypeOf f Is CaseRecordForm Then
                f.BringToFront()
                f.Activate()
                Exit For
            End If
        Next
    End Sub

End Class