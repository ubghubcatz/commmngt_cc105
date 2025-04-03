Imports Microsoft.Data.SqlClient

Public Class frmRECORDS
    ' Update with your actual database connection details
    Dim connectionString As String = "Server=commngtcc105.mssql.somee.com;Database=commngtcc105;User Id=ublipa_SQLLogin_1;Password=nktg6ikffl;TrustServerCertificate=True;"

    Private Sub frmRECORDS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load records when form opens
        LoadRecords()
    End Sub

    Private Sub LoadRecords()
        Try
            ' Create SQL connection
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "SELECT * FROM g5_Disasters" ' Update table name if needed
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()

                ' Fill DataTable with query result
                adapter.Fill(dt)

                ' Bind DataTable to DataGridView
                dgvRecords.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCLOSE_Click(sender As Object, e As EventArgs) Handles btnCLOSE.Click
        ' Close the current form
        Me.Close()
    End Sub
End Class
