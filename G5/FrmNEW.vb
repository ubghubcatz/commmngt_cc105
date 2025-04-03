Imports Microsoft.Data.SqlClient

Public Class FrmNEW

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCLOSE.Click
        ' Close the current form
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Retrieve values from textboxes
        Dim name As String = DisasterName.Text
        Dim location As String = txtLocation.Text
        Dim contactNumber As String = ResidentPhoneNumber.Text
        Dim typeOfItem As String = Incident.Text
        Dim description As String = Me.Description.Text
        Dim dateAdded As Date = DisasterDate.Value.Date ' Assuming DATIME is a DateTimePicker

        ' Validate if all fields are filled
        If name = "" Or location = "" Or contactNumber = "" Or typeOfItem = "" Or description = "" Then
            MessageBox.Show("Please fill in all fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' SQL Server connection string (update with your actual server details)
        Dim connectionString As String = "Server=commngtcc105.mssql.somee.com;Database=commngtcc105;User Id=ublipa_SQLLogin_1;Password=nktg6ikffl;TrustServerCertificate=True;"

        ' SQL query to insert data
        Dim query As String = "INSERT INTO g5_Disasters (DisasterName, DisasterDate, Location, ResidentPhoneNumber, Incident, Description) " &
                              "VALUES (@DisasterName, @DisasterDate, @Location, @ResidentPhoneNumber, @Incident, @Description)"

        Try
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    ' Add parameters to prevent SQL Injection
                    cmd.Parameters.AddWithValue("@DisasterName", name)
                    cmd.Parameters.AddWithValue("@DisasterDate", dateAdded)
                    cmd.Parameters.AddWithValue("@Location", location)
                    cmd.Parameters.AddWithValue("@ResidentPhoneNumber", contactNumber)
                    cmd.Parameters.AddWithValue("@Incident", typeOfItem)
                    cmd.Parameters.AddWithValue("@Description", description)

                    ' Open the connection and execute the query
                    conn.Open()
                    cmd.ExecuteNonQuery()

                    ' Show success message
                    MessageBox.Show("Information Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Optionally, clear the form fields after saving
                    DisasterName.Clear()
                    txtLocation.Clear()
                    ResidentPhoneNumber.Clear()
                    Incident.Clear()
                    Me.Description.Clear()
                End Using
            End Using
        Catch ex As Exception
            ' Handle errors
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmNEW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form load event (you can add any initialization code here)
    End Sub

    Private Sub txtLocation_TextChanged(sender As Object, e As EventArgs) Handles txtLocation.TextChanged

    End Sub
End Class
