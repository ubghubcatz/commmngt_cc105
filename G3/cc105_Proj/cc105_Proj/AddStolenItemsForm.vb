Public Class AddStolenItemsForm
    Private Sub SaveItem_Btn_Click(sender As Object, e As EventArgs) Handles SaveItem_Btn.Click

        Dim caseForm As CaseRecordForm = Application.OpenForms.OfType(Of CaseRecordForm)().FirstOrDefault()

        ' Validate input fields
        If String.IsNullOrWhiteSpace(ItemName_TextBox.Text) OrElse
           String.IsNullOrWhiteSpace(ItemDesc_TextBox.Text) OrElse
           String.IsNullOrWhiteSpace(Price_TextBox.Text) Then
            MessageBox.Show("Please fill in all fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validate if Price is a valid float
        Dim price As Decimal
        If Not Decimal.TryParse(Price_TextBox.Text.Trim(), price) Then
            MessageBox.Show("Please enter a valid numeric value for the price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Add valid data to the DataGridView
        caseForm.ItemDescription_DataGridView.Rows.Add(ItemName_TextBox.Text.Trim(), ItemDesc_TextBox.Text.Trim(), price.ToString("F2"))

        ' Clear the textboxes after successful entry
        ItemName_TextBox.Text = ""
        ItemDesc_TextBox.Text = ""
        Price_TextBox.Text = ""
    End Sub

End Class