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
        PictureBox1.Image = Image.FromFile("bottomLeft.png")
        PictureBox2.Image = Image.FromFile("bottomRight.png")
        PictureBox3.Image = Image.FromFile("topLeft.png")
        PictureBox4.Image = Image.FromFile("topRight.png")
        PictureBox5.Image = Image.FromFile("topright.png")
        PictureBox6.Image = Image.FromFile("bottomRight.png")
        PictureBox7.Image = Image.FromFile("topLeft.png")
        PictureBox8.Image = Image.FromFile("bottomLeft.png")
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
End Class