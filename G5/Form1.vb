Public Class Form1
    Private ReadOnly panel3 As Object

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnNEW_Click(sender As Object, e As EventArgs) Handles btnNEW.Click
        ' Create an instance of FrmNEW
        Dim newForm As New FrmNEW()
        ' Show the new form
        newForm.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Create an instance of frmRECORDS
        Dim recordsForm As New frmRECORDS()
        ' Show the new form
        recordsForm.Show()
    End Sub
End Class
