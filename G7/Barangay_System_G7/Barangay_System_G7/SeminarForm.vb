Public Class SeminarForm
    Private SeminarList As New List(Of String)()
    Private Sub SeminarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form Styling
        Me.BackColor = Color.FromArgb(227, 242, 253) ' Light Blue

        ' ListView Styling
        lvSeminars.View = View.Details
        lvSeminars.Columns.Add("Title", 150)
        lvSeminars.Columns.Add("Date", 100)
        lvSeminars.Columns.Add("Location", 150)
        lvSeminars.Columns.Add("Speaker", 150)
        lvSeminars.Columns.Add("Description", 200)
        lvSeminars.FullRowSelect = True
        lvSeminars.GridLines = True
    End Sub

    ' Add a new seminar
    Private Sub btnAddSeminar_Click(sender As Object, e As EventArgs) Handles btnAddSeminar.Click
        Dim seminarTitle As String = txtSeminarTitle.Text
        Dim dateTime As String = dtpSeminarDate.Value.ToString("yyyy-MM-dd")
        Dim location As String = txtLocation.Text
        Dim speaker As String = txtSpeaker.Text

        If seminarTitle <> "" And location <> "" And speaker <> "" Then
            Dim item As New ListViewItem(seminarTitle)
            item.SubItems.Add(dateTime)
            item.SubItems.Add(location)
            item.SubItems.Add(speaker)
            lvSeminars.Items.Add(item)
        Else
            MessageBox.Show("Please complete all seminar details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

End Class