Imports Azure.Core.HttpHeader
Imports Microsoft.Data.SqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Public Class formMenu
    Dim connectionString As String = "Server=commngtcc105.mssql.somee.com;Database=commngtcc105;
                                     
User Id=ublipa_SQLLogin_1;Password=nktg6ikffl;TrustServerCertificate=True;"
    Private Sub formMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGridView()
    End Sub
    Private Sub LoadDataGridView()
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT ID, Name, Lname, Contact, Email, EventName, Attendees, Type, Venue, DateBooked, StartTime, EndTime FROM g6_Pending"
            Using cmd As New SqlCommand(query, conn)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    Dim dt As New DataTable()
                    dt.Load(reader)
                    DataGridView1.DataSource = dt
                End Using
            End Using
        End Using
    End Sub
    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        ' User info
        Dim name = nameInfo.Text
        Dim lname = LastName.Text
        Dim contact = conInfo.Text
        Dim email = emailInfo.Text
        ' Event info
        Dim eventN = eventName.Text
        Dim attendee = attendeeCo.Text
        Dim eventType = cmbType.SelectedItem.ToString()
        Dim venue = cmbvenue.SelectedItem.ToString()
        ' Schedule
        Dim dateSche = dtpDate.Value
        Dim startT = TimeOnly.FromDateTime(DateTimePicker1.Value)
        Dim endT = TimeOnly.FromDateTime(DateTimePicker2.Value)

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim transaction = conn.BeginTransaction()

            Try
                ' Check for existing bookings
                Dim checkQuery = "SELECT COUNT(*) FROM g6_BookedVenue WHERE Venue = @Venue AND DateBooked = @DateBooked AND ((StartTime < @EndTime) AND (EndTime > @StartTime))"
                Using checkCmd As New SqlCommand(checkQuery, conn, transaction)
                    checkCmd.Parameters.AddWithValue("@Venue", venue)
                    checkCmd.Parameters.AddWithValue("@DateBooked", dateSche)
                    checkCmd.Parameters.AddWithValue("@StartTime", startT)
                    checkCmd.Parameters.AddWithValue("@EndTime", endT)

                    Dim count = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("This venue is already booked for the selected time. Please choose a different time.")
                        transaction.Rollback()
                        Return
                    End If
                End Using

                ' Proceed with the insertions if no conflicts
                Dim queries As New List(Of String) From {
            "INSERT INTO g6_userInfo (Name, Lname, Contact, Email) VALUES (@name, @lname, @contact, @email)",
            "INSERT INTO g6_venueInfo (EventName, Attendees, Type, Venue) VALUES (@eventN, @attendee, @eventType, @venue)",
            "INSERT INTO g6_schedule (DateBooked, StartTime, EndTime) VALUES (@dateSche, @startT, @endT)",
            "INSERT INTO g6_BookedVenue (EventName, Venue, DateBooked, StartTime, EndTime) VALUES (@eventN, @venue, @dateSche, @startT, @endT)",
            "INSERT INTO g6_Pending (Name, Lname, Contact, Email, EventName, Venue, Attendees, Type, DateBooked, StartTime, EndTime) VALUES (@name, @lname, @contact, @email, @eventN, @venue, @attendee, @eventType, @dateSche, @startT, @endT)"
        }

                For Each query In queries
                    Using cmd As New SqlCommand(query, conn, transaction)
                        ' Add parameters based on the specific query
                        If query.Contains("g6_userInfo") Then
                            cmd.Parameters.AddWithValue("@name", name)
                            cmd.Parameters.AddWithValue("@lname", lname)
                            cmd.Parameters.AddWithValue("@contact", contact)
                            cmd.Parameters.AddWithValue("@email", email)
                        ElseIf query.Contains("g6_venueInfo") Then
                            cmd.Parameters.AddWithValue("@eventN", eventN)
                            cmd.Parameters.AddWithValue("@attendee", attendee)
                            cmd.Parameters.AddWithValue("@eventType", eventType)
                            cmd.Parameters.AddWithValue("@venue", venue)
                        ElseIf query.Contains("g6_schedule") Then
                            cmd.Parameters.AddWithValue("@dateSche", dateSche)
                            cmd.Parameters.AddWithValue("@startT", startT)
                            cmd.Parameters.AddWithValue("@endT", endT)
                        ElseIf query.Contains("g6_BookedVenue") Then
                            cmd.Parameters.AddWithValue("@eventN", eventN)
                            cmd.Parameters.AddWithValue("@venue", venue)
                            cmd.Parameters.AddWithValue("@dateSche", dateSche)
                            cmd.Parameters.AddWithValue("@startT", startT)
                            cmd.Parameters.AddWithValue("@endT", endT)
                        ElseIf query.Contains("g6_Pending") Then
                            cmd.Parameters.AddWithValue("@name", name)
                            cmd.Parameters.AddWithValue("@lname", lname)
                            cmd.Parameters.AddWithValue("@contact", contact)
                            cmd.Parameters.AddWithValue("@email", email)
                            cmd.Parameters.AddWithValue("@eventN", eventN)
                            cmd.Parameters.AddWithValue("@venue", venue)
                            cmd.Parameters.AddWithValue("@attendee", attendee)
                            cmd.Parameters.AddWithValue("@eventType", eventType)
                            cmd.Parameters.AddWithValue("@dateSche", dateSche)
                            cmd.Parameters.AddWithValue("@startT", startT)
                            cmd.Parameters.AddWithValue("@endT", endT)
                        End If

                        ' Execute the query
                        cmd.ExecuteNonQuery()
                    End Using
                Next

                transaction.Commit()
                MessageBox.Show("Submission successful! Barangay Personel will contact you if any problems arise.")
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
        nameInfo.Clear()
        LastName.Clear()
        conInfo.Clear()
        emailInfo.Clear()
        eventName.Clear()
        attendeeCo.Clear()
        cmbType.SelectedIndex = -1
        cmbvenue.SelectedIndex = -1
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadDataGridView()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' User info
        Dim name = nameInfo.Text
        Dim lname = LastName.Text
        Dim contact = conInfo.Text
        ' Event info
        Dim eventN As String = eventName.Text
        Dim attendee = attendeeCo.Text
        Dim eventType = cmbType.SelectedItem.ToString()
        Dim venue = cmbvenue.SelectedItem.ToString()
        ' Schedule
        Dim dateSche = dtpDate.Value
        Dim startT = TimeOnly.FromDateTime(DateTimePicker1.Value)
        Dim endT = TimeOnly.FromDateTime(DateTimePicker2.Value)

        ' Get the selected row's ID
        Dim selectedRow As DataGridViewRow = DataGridView1.CurrentRow
        If selectedRow Is Nothing Then
            MessageBox.Show("Please select a row to update.")
            Return
        End If

        Dim selectedID As Integer = Convert.ToInt32(selectedRow.Cells("ID").Value)

        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim transaction = con.BeginTransaction()

            Try
                ' Update the Pending
                Dim updatePendingQuery As String = "UPDATE g6_Pending SET Name = @name, Lname = @lname, Contact = @contact, EventName = @eventN, Attendees = @attendee, Type = @eventType, Venue = @venue, DateBooked = @dateSche, StartTime = @startT, EndTime = @endT WHERE ID = @ID"
                Using updatePendingCmd As New SqlCommand(updatePendingQuery, con, transaction)
                    updatePendingCmd.Parameters.AddWithValue("@name", name)
                    updatePendingCmd.Parameters.AddWithValue("@lname", lname)
                    updatePendingCmd.Parameters.AddWithValue("@contact", contact)
                    updatePendingCmd.Parameters.AddWithValue("@attendee", attendee)
                    updatePendingCmd.Parameters.AddWithValue("@eventN", eventN)
                    updatePendingCmd.Parameters.AddWithValue("@eventType", eventType)
                    updatePendingCmd.Parameters.AddWithValue("@venue", venue)
                    updatePendingCmd.Parameters.AddWithValue("@dateSche", dateSche)
                    updatePendingCmd.Parameters.AddWithValue("@startT", startT)
                    updatePendingCmd.Parameters.AddWithValue("@endT", endT)
                    updatePendingCmd.Parameters.AddWithValue("@ID", selectedID) ' Add the ID parameter

                    updatePendingCmd.ExecuteNonQuery()
                End Using

                transaction.Commit()
                MessageBox.Show("Update successful! Barangay Personel will contact you if any problems arise.")
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Load data into form fields
            nameInfo.Text = selectedRow.Cells("Name").Value.ToString()
            conInfo.Text = selectedRow.Cells("Contact").Value.ToString()
            LastName.Text = selectedRow.Cells("Lname").Value.ToString()
            eventName.Text = selectedRow.Cells("eventName").Value.ToString()
            emailInfo.Text = selectedRow.Cells("Email").Value.ToString()
            attendeeCo.Text = selectedRow.Cells("Attendees").Value.ToString()
            cmbType.SelectedItem = selectedRow.Cells("Type").Value.ToString()
            cmbvenue.SelectedItem = selectedRow.Cells("Venue").Value.ToString()
        End If
    End Sub
End Class