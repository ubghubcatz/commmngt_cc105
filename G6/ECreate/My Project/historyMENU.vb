Imports Microsoft.Data.SqlClient
Public Class historyMENU
    Dim connectionString As String = "Server=commngtcc105.mssql.somee.com;Database=commngtcc105;
                                     
User Id=ublipa_SQLLogin_1;Password=nktg6ikffl;TrustServerCertificate=True;"
    Private Sub historyMENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData1()
    End Sub

    Private Sub LoadData1()
        ' Define the SQL query to retrieve data
        Dim query As String = "SELECT * FROM g6_History" ' Replace with your table name

        ' Create a SqlConnection and SqlDataAdapter
        Using connection As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim dataTable As New DataTable()

            Try
                ' Open the connection
                connection.Open()

                ' Fill the DataTable with data from the database
                adapter.Fill(dataTable)

                ' Bind the DataTable to the DataGridView
                DataGridView1.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadData1()
    End Sub
End Class