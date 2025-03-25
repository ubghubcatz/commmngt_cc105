Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub






    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnNew.Click

        ' Close any existing child form before opening a new one
        For Each child In MdiChildren
            child.Close()
        Next

        ' Create and configure Form3 to be fullscreen inside Form1
        Dim newForm As New Form3
        newForm.MdiParent = Me ' Set Form1 as the parent
        newForm.FormBorderStyle = FormBorderStyle.None ' Remove borders
        newForm.Dock = DockStyle.Fill ' Make Form3 take the entire Form1
        newForm.Show()
    End Sub

    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click

        ' Close any existing child form before opening a new one
        For Each child In MdiChildren
            child.Close()
        Next

        ' Create and configure Form2 to be fullscreen inside Form1
        Dim recordsForm As New Form2
        recordsForm.MdiParent = Me ' Set Form1 as the parent
        recordsForm.FormBorderStyle = FormBorderStyle.None ' Remove borders
        recordsForm.Dock = DockStyle.Fill ' Make Form2 take the entire Form1
        recordsForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Close any existing child form before opening a new one
        For Each child In MdiChildren
            child.Close()
        Next

        ' Create and configure Form2 to be fullscreen inside Form1
        Dim recordsForm As New Form4
        recordsForm.MdiParent = Me ' Set Form1 as the parent
        recordsForm.FormBorderStyle = FormBorderStyle.None ' Remove borders
        recordsForm.Dock = DockStyle.Fill ' Make Form2 take the entire Form1
        recordsForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLostandFound.Click


        Dim newForm As New Form5()
        newForm.MdiParent = Me ' Set Form1 as the parent of Form5
        newForm.Dock = DockStyle.Fill ' Make it fill the entire space
        newForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnLostandFrecords.Click

        If Form6 IsNot Nothing AndAlso Form6.LostAndFoundRecords IsNot Nothing Then
            Dim incidentNumber As String = (Form6.LostAndFoundRecords.Count + 1).ToString("00") & " Lost Item Report"
            ' Continue processing
        Else
            MessageBox.Show("LostAndFoundRecords is not initialized.")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class

