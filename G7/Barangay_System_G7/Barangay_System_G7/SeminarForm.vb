Imports System.Data.SqlClient

Public Class SeminarForm
    Private connectionString As String = "Data Source=commngtcc105.mssql.somee.com;Initial Catalog=commngtcc105;User ID=ublipa_SQLLogin_1;Password=nktg6ikffl;TrustServerCertificate=True"

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

            ' Get seminar details
            Dim coordinatorName As String = selectedItem.SubItems(0).Text
            Dim seminarTitle As String = selectedItem.SubItems(1).Text
            Dim seminarDate As Date = Date.Parse(selectedItem.SubItems(2).Text)
            Dim location As String = selectedItem.SubItems(3).Text
            Dim speakers As String = selectedItem.SubItems(4).Text
            Dim description As String = selectedItem.SubItems(5).Text

            ' Save to database
            Try
                Using conn As New SqlConnection(connectionString)
                    conn.Open()
                    Dim query As String = "INSERT INTO approved_seminars (coordinator_name, title, seminar_date, location, speakers, description) VALUES (@coordinator, @title, @date, @location, @speakers, @description)"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@coordinator", coordinatorName)
                        cmd.Parameters.AddWithValue("@title", seminarTitle)
                        cmd.Parameters.AddWithValue("@date", seminarDate)
                        cmd.Parameters.AddWithValue("@location", location)
                        cmd.Parameters.AddWithValue("@speakers", speakers)
                        cmd.Parameters.AddWithValue("@description", description)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                ' After inserting, remove from ListView
                lvSeminars.Items.Remove(selectedItem)

                MessageBox.Show("The seminar has been approved and moved to the Approved Seminars database.", "Approval Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error while saving to database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else
            MessageBox.Show("Please select a seminar to approve.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    'View Approved Seminar
    Private Sub btnViewApprovedSeminars_Click(sender As Object, e As EventArgs) Handles btnViewApprovedSeminars.Click
        Dim approvedForm As New ApprovedSeminarsForm()
        approvedForm.ShowDialog()
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
