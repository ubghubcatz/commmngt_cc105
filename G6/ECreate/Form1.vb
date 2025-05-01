Imports Microsoft.Data.SqlClient



Public Class Form1

    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        switchPanel(historyMENU)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        switchPanel(formMenu)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        switchPanel(PendingMENU)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        switchPanel(ApprovedMENU)
    End Sub
End Class
