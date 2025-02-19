Public Class List

    Private Sub btnviewID_Click(sender As Object, e As EventArgs) Handles btnviewID.Click
        ' Get the reference to the main form
        Dim mainForm As Form1 = Me.ParentForm

        ' Check if mainForm exists and has the childform method
        If mainForm IsNot Nothing Then
            mainForm.childform(New IDcard())
        End If
    End Sub

End Class