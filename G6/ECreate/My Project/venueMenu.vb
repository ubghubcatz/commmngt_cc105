Public Class venueMenu
    Sub switchPanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub courtB_Click(sender As Object, e As EventArgs) Handles courtB.Click
        switchPanel(courtVENUE)
    End Sub

    Private Sub denovoB_Click(sender As Object, e As EventArgs) Handles denovoB.Click
        switchPanel(denovoVENUE)
    End Sub

    Private Sub dvgB_Click(sender As Object, e As EventArgs) Handles dvgB.Click
        switchPanel(dvgVENUE)
    End Sub

    Private Sub aquaB_Click(sender As Object, e As EventArgs) Handles aquaB.Click
        switchPanel(aquaVENUE)
    End Sub

    Private Sub penaB_Click(sender As Object, e As EventArgs) Handles penaB.Click
        switchPanel(penaVENUE)
    End Sub
    Private Sub blueB_Click(sender As Object, e As EventArgs) Handles blueB.Click
        switchPanel(blueVENUE)
    End Sub

    Private Sub privateB_Click(sender As Object, e As EventArgs) Handles privateB.Click
        switchPanel(privateVENUE)
    End Sub

    Private Sub pacitaB_Click(sender As Object, e As EventArgs) Handles pacitaB.Click
        switchPanel(pacitaVENUE)
    End Sub

    Private Sub venueMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class