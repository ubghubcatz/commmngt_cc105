Public Class AssistanceForm

    Private AssistanceList As New List(Of String)()

    Private Sub AssistanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ListView Styling
        lvAssistanceRequests.View = View.Details
        lvAssistanceRequests.Columns.Add("Last Name", 100)
        lvAssistanceRequests.Columns.Add("First Name", 100)
        lvAssistanceRequests.Columns.Add("M.I.", 50)
        lvAssistanceRequests.Columns.Add("Assistance Type", 200)
        lvAssistanceRequests.Columns.Add("Status", 100)
        lvAssistanceRequests.FullRowSelect = True
        lvAssistanceRequests.GridLines = True
    End Sub

    ' View Requirements
    Private Sub btnViewRequirements_Click(sender As Object, e As EventArgs) Handles btnViewRequirements.Click
        ' Check if an assistance type is selected
        If cmbAssistanceType.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an Assistance Type first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedType As String = cmbAssistanceType.SelectedItem.ToString()

        Select Case selectedType
            Case "Burial Assistance"
                Dim burialForm As New BurialRequirementsForm()
                burialForm.ShowDialog()
            Case "Educational Assistance"
                Dim educationalForm As New EducationalRequirementsForm()
                educationalForm.ShowDialog()
            Case Else
                MessageBox.Show("Requirements form for this assistance type is not yet available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub

    ' Register Assistance
    Private Sub btnRegisterAssistance_Click(sender As Object, e As EventArgs) Handles btnRegisterAssistance.Click
        Dim residentLastName As String = txtResidentLastName.Text.Trim()
        Dim residentFirstName As String = txtResidentFirstName.Text.Trim()
        Dim residentMiddleInitial As String = txtResidentMiddleInitial.Text.Trim()
        Dim assistanceType As String = cmbAssistanceType.Text

        ' Basic field validation
        If residentFirstName = "" OrElse residentLastName = "" OrElse residentMiddleInitial = "" OrElse assistanceType = "" Then
            MessageBox.Show("Please complete the assistance registration details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Check uploaded documents (based on selected assistance type)
        Dim documentsUploaded As Boolean = False

        Select Case assistanceType
            Case "Burial Assistance"
                ' Check if all required documents for Burial Assistance are uploaded
                If BurialRequirementsForm.IsAllDocumentsUploaded() Then
                    documentsUploaded = True
                End If
            Case "Educational Assistance"
                ' Check if all required documents for Educational Assistance are uploaded
                If EducationalRequirementsForm.IsAllDocumentsUploaded() Then
                    documentsUploaded = True
                End If
            Case Else
                MessageBox.Show("Requirements for this assistance type are not yet supported.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
        End Select

        ' If documents are not uploaded, show error
        If Not documentsUploaded Then
            MessageBox.Show("Please upload the required documents in the Requirements Form before registering.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Add to ListView if validation passed
        Dim item As New ListViewItem(residentLastName)
        item.SubItems.Add(residentFirstName)
        item.SubItems.Add(residentMiddleInitial)
        item.SubItems.Add(assistanceType)
        item.SubItems.Add("Pending")
        lvAssistanceRequests.Items.Add(item)

        ' Clear fields after successful registration
        ClearAssistanceFields()

        ' Reset DocumentsUploaded flag
        If assistanceType = "Burial Assistance" Then
            BurialRequirementsForm.ResetDocumentFlags()
        ElseIf assistanceType = "Educational Assistance" Then
            EducationalRequirementsForm.ResetDocumentFlags()
        End If
    End Sub

    ' Approve Assistance
    Private Sub btnApproveAssistance_Click(sender As Object, e As EventArgs) Handles btnApproveAssistance.Click
        If lvAssistanceRequests.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lvAssistanceRequests.SelectedItems(0)
            selectedItem.SubItems(4).Text = "Approved"
            btnApproveAssistance.Enabled = False
            MessageBox.Show("The assistance request has been approved successfully.", "Approval Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Please select an assistance request to approve.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Remove Assistance Request
    Private Sub btnRemoveAssistance_Click(sender As Object, e As EventArgs) Handles btnRemoveAssistance.Click
        If lvAssistanceRequests.SelectedItems.Count > 0 Then
            lvAssistanceRequests.Items.Remove(lvAssistanceRequests.SelectedItems(0))
        Else
            MessageBox.Show("Please select request to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Clear Fields
    Private Sub ClearAssistanceFields()
        txtResidentLastName.Clear()
        txtResidentFirstName.Clear()
        txtResidentMiddleInitial.Clear()
        cmbAssistanceType.SelectedIndex = -1
    End Sub
End Class
