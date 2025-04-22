Imports System.DirectoryServices.ActiveDirectory

Public Class AddPersonInvolvedFormvb

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Find the existing CaseRecordForm
        Dim caseForm As CaseRecordForm = Application.OpenForms.OfType(Of CaseRecordForm)().FirstOrDefault()

        ' Ensure form exists
        If caseForm IsNot Nothing Then
            If Name_TxtBox.Text IsNot Nothing AndAlso num.Text.Length() = 11 AndAlso IsNumeric(num.Text) AndAlso ComboBox1.SelectedItem IsNot Nothing Then
                ' Ensure columns exist before adding rows
                If caseForm.CasePeople_DataGridView1.Columns.Count = 0 Then
                    With caseForm.CasePeople_DataGridView1.Columns
                        .Add("NameColumn", "Person Name")
                        .Add("PhoneColumn", "Phone Number")
                        .Add("TypeColumn", "Person Type")
                    End With
                End If

                ' Cell styling (Semi-Bold)
                Dim semiBoldFont As New Font(caseForm.CasePeople_DataGridView1.Font.FontFamily, CSng(caseForm.CasePeople_DataGridView1.Font.Size - 1), FontStyle.Bold)
                For Each column As DataGridViewColumn In caseForm.CasePeople_DataGridView1.Columns
                    column.MinimumWidth = 100
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    column.DefaultCellStyle.Font = semiBoldFont ' Semi-bold effect
                Next

                ' Add data to the existing CaseRecordForm DataGridView
                caseForm.CasePeople_DataGridView1.Rows.Add(Name_TxtBox.Text.Trim(), num.Text.Trim(), ComboBox1.SelectedItem.ToString())

                ' Clear input fields
                Name_TxtBox.Clear()
                num.Clear()
                ComboBox1.SelectedIndex = -1
            Else
                MessageBox.Show("Please enter a valid Name, 11-digit Number, and select a Type.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("CaseRecordForm is not open!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class