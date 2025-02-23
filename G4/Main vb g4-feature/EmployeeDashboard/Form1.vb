Imports System.Runtime.CompilerServices

Public Class Form1

    Sub Childform(ByVal panel As Form)
        pnlMain.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        pnlMain.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub ListBtn_Click(sender As Object, e As EventArgs) Handles ListBtn.Click
        Childform(List)
    End Sub

    Private Sub EncodeBtn_Click(sender As Object, e As EventArgs) Handles AttendanceBtn.Click
        Childform(Attendance)
    End Sub

    Private Sub SchedBtn_Click(sender As Object, e As EventArgs) Handles SchedBtn.Click
        Childform(Schedule)

    End Sub

End Class
