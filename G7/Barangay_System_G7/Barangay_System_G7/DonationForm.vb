Public Class DonationForm
    Private DonationList As New List(Of String)()

    Private Sub DonationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ListView Styling
        lvDonations.View = View.Details
        lvDonations.Columns.Add("Donor Name", 150)
        lvDonations.Columns.Add("Donation Type", 200)
        lvDonations.Columns.Add("Donation Mode", 150)
        lvDonations.Columns.Add("Amount", 100)
        lvDonations.Columns.Add("Status", 100)
        lvDonations.FullRowSelect = True
    End Sub

    Private Sub rdoCashDropOff_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCashDropOff.CheckedChanged
        txtGCashNumber.Enabled = Not rdoCashDropOff.Checked
    End Sub

    Private Sub rdoGCash_CheckedChanged(sender As Object, e As EventArgs) Handles rdoGCash.CheckedChanged
        txtGCashNumber.Enabled = rdoGCash.Checked
    End Sub

    ' Process Donation
    Private Sub btnProcessDonation_Click(sender As Object, e As EventArgs) Handles btnProcessDonation.Click
        Dim lastName As String = txtResidentLastName.Text.Trim()
        Dim firstName As String = txtResidentFirstName.Text.Trim()
        Dim middleInitial As String = txtResidentMiddleInitial.Text.Trim()
        Dim fullName As String = $"{lastName}, {firstName} {middleInitial}."

        Dim donationType As String = cmbDonationType.Text
        Dim donationAmount As String = txtAmount.Text
        Dim donationMode As String = If(rdoCashDropOff.Checked, "Cash Drop-off", "GCash Transfer")

        ' Validate fields
        If lastName = "" Or firstName = "" Or middleInitial = "" Or donationType = "" Or donationAmount = "" Then
            MessageBox.Show("Please complete all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validate GCash number if GCash selected
        If rdoGCash.Checked AndAlso (txtGCashNumber.Text.Length <> 11 OrElse Not IsNumeric(txtGCashNumber.Text)) Then
            MessageBox.Show("Please enter a valid 11-digit GCash number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Add to ListView
        Dim item As New ListViewItem(fullName)
        item.SubItems.Add(donationType)
        item.SubItems.Add(donationMode)
        item.SubItems.Add("₱" & donationAmount)
        item.SubItems.Add("Pending")
        lvDonations.Items.Add(item)

        ' Clear Form after processing
        ClearForm()
    End Sub

    ' Approve Donation
    Private Sub btnApproveDonation_Click(sender As Object, e As EventArgs) Handles btnApproveDonation.Click
        If lvDonations.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lvDonations.SelectedItems(0)
            selectedItem.SubItems(4).Text = "Acknowledged"

            ' Receipt Display
            Dim fullName As String = selectedItem.SubItems(0).Text
            Dim donationType As String = selectedItem.SubItems(1).Text
            Dim donationMode As String = selectedItem.SubItems(2).Text
            Dim amount As String = selectedItem.SubItems(3).Text

            ' Show Receipt Message
            MessageBox.Show(
                $"Donation Receipt:" & vbCrLf &
                $"Donor Name: {fullName}" & vbCrLf &
                $"Donation Type: {donationType}" & vbCrLf &
                $"Donation Mode: {donationMode}" & vbCrLf &
                $"Amount: {amount}",
                "Donation Receipt",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            MessageBox.Show("The donation has been acknowledged successfully.", "Acknowledgement Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            lvDonations.SelectedItems.Clear()
        Else
            MessageBox.Show("Please select a donation to acknowledge.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Handle enabling/disabling Approve button depending on selection
    Private Sub lvDonationRequests_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDonations.SelectedIndexChanged
        btnApproveDonation.Enabled = lvDonations.SelectedItems.Count > 0
    End Sub

    ' Remove Donation
    Private Sub btnRemoveDonation_Click(sender As Object, e As EventArgs) Handles btnRemoveDonation.Click
        If lvDonations.SelectedItems.Count > 0 Then
            Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to remove this donation?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirm = DialogResult.Yes Then
                lvDonations.Items.Remove(lvDonations.SelectedItems(0))
                MessageBox.Show("The donation has been removed successfully.", "Removal Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Please select a donation to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ClearForm()
        txtResidentLastName.Clear()
        txtResidentFirstName.Clear()
        txtResidentMiddleInitial.Clear()
        cmbDonationType.SelectedIndex = -1
        txtAmount.Clear()
        txtGCashNumber.Clear()
        rdoCashDropOff.Checked = True
    End Sub
End Class
