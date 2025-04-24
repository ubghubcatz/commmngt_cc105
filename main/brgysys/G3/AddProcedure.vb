Public Class AddProcedure

    Private Sub AddProcedure_Btn_Click(sender As Object, e As EventArgs) Handles AddProcedure_Btn.Click
        Dim caseForm As CaseRecordForm = Application.OpenForms.OfType(Of CaseRecordForm)().FirstOrDefault()

        If Procedures_ComboBox.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a procedure before continuing.", "Missing Procedure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim procedure As String = Procedures_ComboBox.SelectedItem.ToString()
        Dim remark As String = Remarks_TxtBox.Text.Trim()
        Dim dateTime = "none"


        ' Create a new ListViewItem
        Dim item As New ListViewItem(procedure)
        item.SubItems.Add(remark)
        item.SubItems.Add(dateTime)
        ' Add to the ListView on the CaseRecordForm
        caseForm.Procedure_ListView.Items.Add(item)

        ' Optionally clear inputs after adding
        Procedures_ComboBox.SelectedIndex = -1
        Remarks_TxtBox.Clear()
    End Sub
End Class