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
            Dim query As String = "SELECT Name, Contact, Email, EventName, Attendees, Type, Venue, DateBooked, StartTime, EndTime FROM g6_History"
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
            "INSERT INTO g6_userInfo (Name, Contact, Email) VALUES (@name, @contact, @email)",
            "INSERT INTO g6_venueInfo (EventName, Attendees, Type, Venue) VALUES (@eventN, @attendee, @eventType, @venue)",
            "INSERT INTO g6_schedule (DateBooked, StartTime, EndTime) VALUES (@dateSche, @startT, @endT)",
            "INSERT INTO g6_BookedVenue (EventName, Venue, DateBooked, StartTime, EndTime) VALUES (@eventN, @venue, @dateSche, @startT, @endT)",
            "INSERT INTO g6_History (Name, Contact, Email, EventName, Venue, Attendees, Type, DateBooked, StartTime, EndTime) VALUES (@name, @contact, @email, @eventN, @venue, @attendee, @eventType, @dateSche, @startT, @endT)"
        }

                For Each query In queries
                    Using cmd As New SqlCommand(query, conn, transaction)
                        ' Add parameters based on the specific query
                        If query.Contains("g6_userInfo") Then
                            cmd.Parameters.AddWithValue("@name", name)
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
                        ElseIf query.Contains("g6_History") Then
                            cmd.Parameters.AddWithValue("@name", name)
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
                MessageBox.Show("Submission successful!")
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
        nameInfo.Text = ""
        conInfo.Text = ""
        emailInfo.Text = ""
        eventName.Text = ""
        attendeeCo.Text = ""
        cmbType.SelectedIndex = -1
        cmbvenue.SelectedIndex = -1
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadDataGridView()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' User info
        Dim name = nameInfo.Text
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

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim transaction = conn.BeginTransaction()

            Try
                ' Check for existing bookings, but skip the current user's booking
                Dim checkQuery As String = "SELECT COUNT(*) FROM g6_BookedVenue WHERE Venue = @Venue AND DateBooked = @DateBooked AND ((StartTime < @EndTime) AND (EndTime > @StartTime))"
                Using checkCmd As New SqlCommand(checkQuery, conn, transaction)
                    checkCmd.Parameters.AddWithValue("@venue", venue)
                    checkCmd.Parameters.AddWithValue("@dateSche", dateSche)
                    checkCmd.Parameters.AddWithValue("@startT", startT)
                    checkCmd.Parameters.AddWithValue("@endT", endT)

                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("This venue is already booked for the selected time by another user. Please choose a different time.")
                        transaction.Rollback()
                        Return
                    End If
                End Using

                ' Update the user information
                Dim updateQuery As String = "UPDATE g6_userInfo SET name = @Name, contact = @Contact"
                Using updateCmd As New SqlCommand(updateQuery, conn, transaction)
                    updateCmd.Parameters.AddWithValue("@Name", name)
                    updateCmd.Parameters.AddWithValue("@Contact", contact)
                    updateCmd.ExecuteNonQuery()
                End Using

                ' Update the venue information
                Dim updateVenueQuery As String = "UPDATE g6_venueInfo SET attendee = @Attendees, eventType = @Type, venue = @Venue"
                Using updateVenueCmd As New SqlCommand(updateVenueQuery, conn, transaction)
                    updateVenueCmd.Parameters.AddWithValue("@attendee", attendee)
                    updateVenueCmd.Parameters.AddWithValue("@eventType", eventType)
                    updateVenueCmd.Parameters.AddWithValue("@venue", venue)
                    updateVenueCmd.ExecuteNonQuery()
                End Using

                ' Update the schedule
                Dim updateScheduleQuery As String = "UPDATE g6_schedule SET dateSche = @DateBooked, startT = @StartTime, endT = @EndTime"
                Using updateScheduleCmd As New SqlCommand(updateScheduleQuery, conn, transaction)
                    updateScheduleCmd.Parameters.AddWithValue("@dateSche", dateSche)
                    updateScheduleCmd.Parameters.AddWithValue("@startT", startT)
                    updateScheduleCmd.Parameters.AddWithValue("@endT", endT)
                    updateScheduleCmd.ExecuteNonQuery()
                End Using

                ' Update the history
                Dim updateHistoryQuery As String = "UPDATE g6_History SET name = @Name, contact = @Contact, attendee = @Attendees, eventType = @Type, venue = @Venue, dateSche = @DateBooked, startT = @StartTime, endT = @EndTime"
                Using updateHistoryCmd As New SqlCommand(updateHistoryQuery, conn, transaction)
                    updateHistoryCmd.Parameters.AddWithValue("@Name", name)
                    updateHistoryCmd.Parameters.AddWithValue("@Contact", contact)
                    updateHistoryCmd.Parameters.AddWithValue("@attendee", attendee)
                    updateHistoryCmd.Parameters.AddWithValue("@eventType", eventType)
                    updateHistoryCmd.Parameters.AddWithValue("@venue", venue)
                    updateHistoryCmd.Parameters.AddWithValue("@dateSche", dateSche)
                    updateHistoryCmd.Parameters.AddWithValue("@startT", startT)
                    updateHistoryCmd.Parameters.AddWithValue("@endT", endT)
                    updateHistoryCmd.ExecuteNonQuery()
                End Using

                transaction.Commit()
                MessageBox.Show("Update successful!")
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private userId As Integer
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Load data into form fields
            nameInfo.Text = selectedRow.Cells("Name").Value.ToString()
            conInfo.Text = selectedRow.Cells("Contact").Value.ToString()
            attendeeCo.Text = selectedRow.Cells("Attendees").Value.ToString()
            cmbType.SelectedItem = selectedRow.Cells("Type").Value.ToString()
            cmbvenue.SelectedItem = selectedRow.Cells("Venue").Value.ToString()
        End If
    End Sub
End Class