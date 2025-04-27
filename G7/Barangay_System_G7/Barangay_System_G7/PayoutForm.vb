Public Class PayoutForm
    Private PayoutList As New List(Of String)()

    Private Sub PayoutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ListView Styling
        lvPayoutRequests.View = View.Details
        lvPayoutRequests.Columns.Add("Resident Name", 150)
        lvPayoutRequests.Columns.Add("Assistance Type", 200)
        lvPayoutRequests.Columns.Add("Payout Mode", 150)
        lvPayoutRequests.Columns.Add("Amount", 100)
        lvPayoutRequests.Columns.Add("Status", 100)
        lvPayoutRequests.FullRowSelect = True
    End Sub

    Private Sub rdoCashPickup_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCashPickup.CheckedChanged
        txtGCashNumber.Enabled = Not rdoCashPickup.Checked
    End Sub

    Private Sub rdoGCash_CheckedChanged(sender As Object, e As EventArgs) Handles rdoGCash.CheckedChanged
        txtGCashNumber.Enabled = rdoGCash.Checked
    End Sub

    ' Process Payout
    Private Sub btnProcessPayout_Click(sender As Object, e As EventArgs) Handles btnProcessPayout.Click
        Dim lastName As String = txtResidentLastName.Text.Trim()
        Dim firstName As String = txtResidentFirstName.Text.Trim()
        Dim middleInitial As String = txtResidentMiddleInitial.Text.Trim()
        Dim fullName As String = $"{lastName}, {firstName} {middleInitial}."

        Dim assistanceType As String = cmbAssistanceType.Text
        Dim payoutAmount As String = txtAmount.Text
        Dim payoutMode As String = If(rdoCashPickup.Checked, "Cash Pickup", "GCash Transfer")

        ' Validate fields
        If lastName = "" Or firstName = "" Or middleInitial = "" Or assistanceType = "" Or payoutAmount = "" Then
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
        item.SubItems.Add(assistanceType)
        item.SubItems.Add(payoutMode)
        item.SubItems.Add("₱" & payoutAmount)
        item.SubItems.Add("Pending")
        lvPayoutRequests.Items.Add(item)

        'Clear Form after processing
        ClearForm()
    End Sub

    ' Approve Payout
    Private Sub btnApprovePayout_Click(sender As Object, e As EventArgs) Handles btnApprovePayout.Click
        If lvPayoutRequests.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lvPayoutRequests.SelectedItems(0)
            selectedItem.SubItems(4).Text = "Approved"

            ' Receipt Display
            Dim fullName As String = selectedItem.SubItems(0).Text
            Dim assistanceType As String = selectedItem.SubItems(1).Text
            Dim payoutMode As String = selectedItem.SubItems(2).Text
            Dim amount As String = selectedItem.SubItems(3).Text

            ' Show Receipt Message
            MessageBox.Show(
                $"Receipt:" & vbCrLf &
                $"Name: {fullName}" & vbCrLf &
                $"Assistance: {assistanceType}" & vbCrLf &
                $"Payout Mode: {payoutMode}" & vbCrLf &
                $"Amount: {amount}",
                "Payout Receipt",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            ' Disable Approve button after approving
            btnApprovePayout.Enabled = False

            MessageBox.Show("The payment request has been approved successfully.", "Approval Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Please select a payout request to approve.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ClearForm()
        txtResidentLastName.Clear()
        txtResidentFirstName.Clear()
        txtResidentMiddleInitial.Clear()
        cmbAssistanceType.SelectedIndex = -1
        txtAmount.Clear()
        txtGCashNumber.Clear()
        rdoCashPickup.Checked = True
    End Sub
End Class
