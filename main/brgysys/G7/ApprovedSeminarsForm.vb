Imports System.Data.SqlClient

Public Class ApprovedSeminarsForm
    Private connectionString As String = "Data Source=commngtcc105.mssql.somee.com;Initial Catalog=commngtcc105;User ID=ublipa_SQLLogin_1;Password=nktg6ikffl;TrustServerCertificate=True"

    Private Sub ApprovedSeminarsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ListView Styling
        lvApprovedSeminars.View = View.Details
        lvApprovedSeminars.Columns.Add("Coordinator", 180)
        lvApprovedSeminars.Columns.Add("Title", 150)
        lvApprovedSeminars.Columns.Add("Date", 100)
        lvApprovedSeminars.Columns.Add("Location", 150)
        lvApprovedSeminars.Columns.Add("Speakers", 150)
        lvApprovedSeminars.Columns.Add("Description", 200)
        lvApprovedSeminars.FullRowSelect = True
        lvApprovedSeminars.GridLines = True

        LoadApprovedSeminars()
    End Sub

    Private Sub LoadApprovedSeminars()
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT * FROM approved_seminars"
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim item As New ListViewItem(reader("coordinator_name").ToString())
                            item.SubItems.Add(reader("title").ToString())
                            item.SubItems.Add(Convert.ToDateTime(reader("seminar_date")).ToString("yyyy-MM-dd"))
                            item.SubItems.Add(reader("location").ToString())
                            item.SubItems.Add(reader("speakers").ToString())
                            item.SubItems.Add(reader("description").ToString())
                            lvApprovedSeminars.Items.Add(item)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading approved seminars: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
