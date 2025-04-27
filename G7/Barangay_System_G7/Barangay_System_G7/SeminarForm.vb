Public Class SeminarForm
    Private SeminarList As New List(Of String)()
    Private SpeakerList As New List(Of String)

    Private Sub SeminarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ListView Styling
        lvSeminars.View = View.Details
        lvSeminars.Columns.Add("Coordinator", 180)
        lvSeminars.Columns.Add("Title", 150)
        lvSeminars.Columns.Add("Date", 100)
        lvSeminars.Columns.Add("Location", 150)
        lvSeminars.Columns.Add("Speakers", 150)
        lvSeminars.Columns.Add("Description", 200)
        lvSeminars.Columns.Add("Status", 100)
        lvSeminars.FullRowSelect = True
        lvSeminars.GridLines = True
    End Sub

    ' Add a new seminar
    Private Sub btnAddSeminar_Click(sender As Object, e As EventArgs) Handles btnAddSeminar.Click
        ' Coordinator Name
        Dim lastName As String = txtCoordinatorLastName.Text.Trim()
        Dim firstName As String = txtCoordinatorFirstName.Text.Trim()
        Dim middleInitial As String = txtCoordinatorMiddleInitial.Text.Trim()
        Dim coordinatorName As String = $"{lastName}, {firstName} {middleInitial}."

        Dim seminarTitle As String = txtSeminarTitle.Text.Trim()
        Dim dateTime As String = dtpSeminarDate.Value.ToString("yyyy-MM-dd")
        Dim location As String = txtLocation.Text.Trim()
        Dim details As String = txtDescription.Text.Trim()

        If seminarTitle <> "" And location <> "" And SpeakerList.Count > 0 And details <> "" Then
            ' Combine speakers into one string
            Dim speakersCombined As String = String.Join(", ", SpeakerList)

            Dim item As New ListViewItem(coordinatorName)
            item.SubItems.Add(seminarTitle)
            item.SubItems.Add(dateTime)
            item.SubItems.Add(location)
            item.SubItems.Add(speakersCombined)
            item.SubItems.Add(details)
            item.SubItems.Add("Pending")
            lvSeminars.Items.Add(item)

            ' Clear input fields after adding
            ClearSeminarFields()
        Else
            MessageBox.Show("Please complete all seminar details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Add Speaker
    Private Sub btnAddSpeaker_Click(sender As Object, e As EventArgs) Handles btnAddSpeaker.Click
        Dim speakerName As String = txtAddSpeaker.Text.Trim()

        If speakerName <> "" Then
            SpeakerList.Add(speakerName)
            lstSpeakers.Items.Add(speakerName)
            txtAddSpeaker.Clear()
        Else
            MessageBox.Show("Please enter a speaker name.")
        End If
    End Sub

    ' Approve Seminar
    Private Sub btnApproveSeminar_Click(sender As Object, e As EventArgs) Handles btnApproveSeminar.Click
        If lvSeminars.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lvSeminars.SelectedItems(0)
            selectedItem.SubItems(6).Text = "Approved"
            btnApproveSeminar.Enabled = False
            MessageBox.Show("The seminar has been approved successfully.", "Approval Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Please select a seminar to approve.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Delete Selected Seminar
    Private Sub btnDeleteSeminar_Click(sender As Object, e As EventArgs) Handles btnDeleteSeminar.Click
        If lvSeminars.SelectedItems.Count > 0 Then
            lvSeminars.Items.Remove(lvSeminars.SelectedItems(0))

        Else
            MessageBox.Show("Please select a seminar to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Function to clear input fields
    Private Sub ClearSeminarFields()
        txtCoordinatorLastName.Clear()
        txtCoordinatorFirstName.Clear()
        txtCoordinatorMiddleInitial.Clear()
        txtSeminarTitle.Clear()
        txtDescription.Clear()
        txtLocation.Clear()
        txtAddSpeaker.Clear()
        SpeakerList.Clear()
        lstSpeakers.Items.Clear()
        dtpSeminarDate.Value = DateTime.Now
    End Sub
End Class
