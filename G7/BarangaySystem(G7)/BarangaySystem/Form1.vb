Public Class Form1
    ' Lists to store data
    Private SeminarList As New List(Of String)()
    Private AssistanceList As New List(Of String)()
    Private PayoutList As New List(Of String)()

    ' Add a new seminar
    Private Sub btnAddSeminar_Click(sender As Object, e As EventArgs) Handles btnAddSeminar.Click
        Dim seminarName As String = txtSeminarName.Text
        If seminarName <> "" Then
            SeminarList.Add(seminarName)
            lstSeminars.Items.Add(seminarName)
            txtSeminarName.Clear()
        Else
            MessageBox.Show("Please enter a seminar name.")
        End If
    End Sub

    ' Register for assistance
    Private Sub btnRegisterAssistance_Click(sender As Object, e As EventArgs) Handles btnRegisterAssistance.Click
        Dim residentName As String = txtResidentName.Text
        Dim assistanceType As String = cmbAssistanceType.Text

        If residentName <> "" AndAlso assistanceType <> "" Then
            Dim request As String = residentName & " - " & assistanceType
            AssistanceList.Add(request)
            lstAssistance.Items.Add(request)
            txtResidentName.Clear()
            cmbAssistanceType.SelectedIndex = -1
        Else
            MessageBox.Show("Please enter resident name and select assistance type.")
        End If
    End Sub

    ' Process Payout
    Private Sub btnProcessPayout_Click(sender As Object, e As EventArgs) Handles btnProcessPayout.Click
        If lstAssistance.SelectedIndex <> -1 Then
            Dim selectedRequest As String = lstAssistance.SelectedItem.ToString()
            PayoutList.Add(selectedRequest)
            lstPayouts.Items.Add(selectedRequest)
            lstAssistance.Items.Remove(selectedRequest)
            MessageBox.Show("Payout processed for: " & selectedRequest)
        Else
            MessageBox.Show("Please select an assistance request to process payout.")
        End If
    End Sub
End Class
