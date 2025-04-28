Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Open Seminar Creator Form
    Private Sub btnSeminar_Click(sender As Object, e As EventArgs) Handles btnSeminar.Click
        Dim seminarForm As New SeminarForm()
        seminarForm.Show()
    End Sub

    ' Open Assistance Registration Form
    Private Sub btnAssistance_Click(sender As Object, e As EventArgs) Handles btnAssistance.Click
        Dim assistanceForm As New AssistanceForm()
        assistanceForm.Show()
    End Sub

    ' Open Donation System Form
    Private Sub btnDonation_Click(sender As Object, e As EventArgs) Handles btnDonation.Click
        Dim donationForm As New DonationForm()
        donationForm.Show()
    End Sub

End Class
