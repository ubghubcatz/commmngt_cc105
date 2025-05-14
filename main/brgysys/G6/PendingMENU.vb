Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Data.SqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Public Class PendingMENU
    Dim connectionString As String = "Server=commngtcc105.mssql.somee.com;Database=commngtcc105;
                                     
User Id=ublipa_SQLLogin_1;Password=nktg6ikffl;TrustServerCertificate=True;"
    Private Sub PendingMENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT ID, Firstname, Lastname, Contact, Email, EventName, Attendees, Type, Venue, DateBooked, StartTime, EndTime FROM g6_BookedPending"
            Using cmd As New SqlCommand(query, conn)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    Dim dt As New DataTable()
                    dt.Load(reader)
                    DataGridView1.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            nameinf.Text = selectedRow.Cells("Firstname").Value.ToString()
            lname.Text = selectedRow.Cells("Lastname").Value.ToString()
            con.Text = selectedRow.Cells("Contact").Value.ToString()
            email.Text = selectedRow.Cells("Email").Value.ToString()
            eventname.Text = selectedRow.Cells("EventName").Value.ToString()
            attend.Text = selectedRow.Cells("Attendees").Value.ToString()
            type.Text = selectedRow.Cells("Type").Value.ToString()
            venue.Text = selectedRow.Cells("Venue").Value.ToString()
            datesche.Text = selectedRow.Cells("DateBooked").Value.ToString()
            startsche.Text = selectedRow.Cells("StartTime").Value.ToString()
            endsche.Text = selectedRow.Cells("EndTime").Value.ToString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using conn As New SqlConnection(connectionString)
            Dim selectedRow = DataGridView1.CurrentRow
            If selectedRow Is Nothing Then
                MessageBox.Show("Please select a row.")
                Return
            End If

            ' Optionally, confirm deletion
            Dim result = MessageBox.Show("Reject?", "Confirm", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ' Get the ID of the selected row (replace "ID" with your actual primary key column name)
                Dim id = Convert.ToInt32(selectedRow.Cells("ID").Value)

                Dim cmd As New SqlCommand("INSERT INTO g6_History (Firstname, Lastname, Contact, Email, EventName, Venue, Attendees, Type, DateBooked, StartTime, EndTime, EventStatus) VALUES (@name, @Lastname, @contact, @email, @eventN, @venue, @attendee, @eventType, @dateSche, @startT, @endT, @status)", conn)

                ' Add parameters to the command
                cmd.Parameters.AddWithValue("@Firstname", nameinf.Text)
                cmd.Parameters.AddWithValue("@Lastname", lname.Text)
                cmd.Parameters.AddWithValue("@contact", con.Text)
                cmd.Parameters.AddWithValue("@email", email.Text)
                cmd.Parameters.AddWithValue("@eventN", eventname.Text)
                cmd.Parameters.AddWithValue("@venue", venue.Text)
                cmd.Parameters.AddWithValue("@attendee", attend.Text)
                cmd.Parameters.AddWithValue("@eventType", type.Text)
                cmd.Parameters.AddWithValue("@dateSche", datesche.Text)
                cmd.Parameters.AddWithValue("@startT", startsche.Text)
                cmd.Parameters.AddWithValue("@endT", endsche.Text)
                cmd.Parameters.AddWithValue("@status", "Rejected") ' Adding the "approved" string

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Rejected!")
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    conn.Close()
                End Try

                ' Remove the selected row from the DataGridView
                DataGridView1.Rows.Remove(selectedRow)

                ' Remove the row from the database
                DeleteRowFromDatabase(id)
            End If
        End Using


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using conn As New SqlConnection(connectionString)
            Dim selectedRow As DataGridViewRow = DataGridView1.CurrentRow
            If selectedRow Is Nothing Then
                MessageBox.Show("Please select a row.")
                Return
            End If

            ' Optionally, confirm deletion
            Dim result As DialogResult = MessageBox.Show("Approve?", "sure?", MessageBoxButtons.OK)
            If result = DialogResult.Yes Then
                Dim id As Integer = Convert.ToInt32(selectedRow.Cells("Id").Value)

                ' Dim cmd As New SqlCommand("INSERT INTO g6_Approved (Firstname, Lastname, Contact, Email, EventName, Venue, Attendees, Type, DateBooked, StartTime, EndTime, EventStatus) VALUES (@name, @lname, @contact, @email, @eventN, @venue, @attendee, @eventType, @dateSche, @startT, @endT, @status)", conn)
                Dim cmd As New SqlCommand("UPDATE g6_BookedPending SET Status = 'A' WHERE Id = " & id & " ", conn)
                ' Add parameters to the command
                'cmd.Parameters.AddWithValue("@Firstname", nameinf.Text)
                'cmd.Parameters.AddWithValue("@Lastname", lname.Text)
                'cmd.Parameters.AddWithValue("@contact", con.Text)
                'cmd.Parameters.AddWithValue("@email", email.Text)
                'cmd.Parameters.AddWithValue("@eventN", eventname.Text)
                'cmd.Parameters.AddWithValue("@venue", venue.Text)
                'cmd.Parameters.AddWithValue("@attendee", attend.Text)
                'cmd.Parameters.AddWithValue("@eventType", type.Text)
                'cmd.Parameters.AddWithValue("@dateSche", datesche.Text)
                'cmd.Parameters.AddWithValue("@startT", startsche.Text)
                'cmd.Parameters.AddWithValue("@endT", endsche.Text)
                'cmd.Parameters.AddWithValue("@status", "Approved") ' Adding the "approved" string

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Approved!")
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    conn.Close()
                End Try

                ' Remove the selected row from the DataGridView
                DataGridView1.Rows.Remove(selectedRow)

                ' Remove the row from the database
                DeleteRowFromDatabase(id)
            End If
        End Using

    End Sub

    Private Sub DeleteRowFromDatabase(id As Integer)
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "DELETE FROM g6_BookedPending WHERE id = @id" ' Replace "ID" with your actual primary key column name
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@ID", id)

            connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT ID, Firstname, Lastname, Contact, Email, EventName, Attendees, Type, Venue, DateBooked, StartTime, EndTime FROM g6_BookedPending"
            Using cmd As New SqlCommand(query, conn)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    Dim dt As New DataTable()
                    dt.Load(reader)
                    DataGridView1.DataSource = dt
                End Using
            End Using
        End Using
    End Sub
End Class

