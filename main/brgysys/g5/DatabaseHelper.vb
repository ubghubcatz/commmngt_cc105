'Imports MySql.Data.MySqlClient

'Public Class DatabaseHelper
'    Private ReadOnly connectionString As String = "Server=commngtcc105.mssql.somee.com;Database=commngtcc105;User Id=ublipa_AQLLogin_1;Password=nktg6ikffl;"

'    Private Function GetConnection() As MySqlConnection
'        Return New MySqlConnection(connectionString)
'    End Function

'    Public Sub InsertData(name As String, recordDate As DateTime, location As String, contact As String, itemType As String, description As String)
'        Try
'            Using conn As MySqlConnection = GetConnection()
'                conn.Open()
'                Dim query As String = "INSERT INTO records (DisasterName, DisasterDate, Location, ResidentPhoneNumber, Incident, Description, CreatedAt) " &
'                                      "VALUES (@name, @recordDate, @location, @contact, @itemType, @description, NOW())"

'                Using cmd As New MySqlCommand(query, conn)
'                    cmd.Parameters.AddWithValue("@name", name)
'                    cmd.Parameters.AddWithValue("@recordDate", recordDate)
'                    cmd.Parameters.AddWithValue("@location", location)
'                    cmd.Parameters.AddWithValue("@contact", contact)
'                    cmd.Parameters.AddWithValue("@itemType", itemType)
'                    cmd.Parameters.AddWithValue("@description", description)

'                    cmd.ExecuteNonQuery()
'                End Using
'            End Using
'        Catch ex As MySqlException
'            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try
'    End Sub
'End Class
