Imports System.Runtime.CompilerServices

Public Class Form1

    Sub childform(ByVal panel As Form)
        pnlMain.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        pnlMain.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub ListBtn_Click(sender As Object, e As EventArgs) Handles ListBtn.Click
        childform(List)
    End Sub

    Private Sub encodeBtn_Click(sender As Object, e As EventArgs) Handles attendanceBtn.Click
        childform(Encode)
    End Sub

    Private Sub schedBtn_Click(sender As Object, e As EventArgs) Handles schedBtn.Click
        childform(Schedule)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
