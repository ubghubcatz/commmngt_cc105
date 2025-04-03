Imports System.Runtime.CompilerServices
Imports Microsoft.Data.SqlClient
Imports Microsoft.Identity.Client.ApiConfig

Public Class AddNoteForm

    ' Declare a class-level variable to hold the reference to CallDetails
    Private detailsForm As CallDetails
    Private connectionString As String = "Server=commngtcc105.mssql.somee.com;Database=commngtcc105;
                                     User Id=ublipa_SQLLogin_1;Password=nktg6ikffl;TrustServerCertificate=True;"
    Dim con As New SqlConnection("Server=commngtcc105.mssql.somee.com;Database=commngtcc105;
                                     User Id=ublipa_SQLLogin_1;Password=nktg6ikffl;TrustServerCertificate=True;")

    Private employeeNames As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase) ' Prevents duplicates automatically

    Private Sub LoadEmployeeNamesByPrefix(employeePrefix As String)
        Using con As New SqlConnection(connectionString),
              cmd As New SqlCommand("SELECT FirstName, LastName FROM g4_EmployeesInfo WHERE EmployeeID LIKE @Prefix + '%'", con)
            cmd.Parameters.AddWithValue("@Prefix", employeePrefix)

            Try
                con.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        employeeNames.Add($"{reader("FirstName")} {reader("LastName")}")
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub SaveDataToCallersTables()
        Dim detailsForm As New CallDetails()
        Try
            ' Load Call Notes into DataGridView **AFTER** fetching call details
            Dim notesQuery As String = "SELECT CallID, NoteID, NoteText, AddedBy, TimeStamp 
                                    FROM g3_CallNotes 
                                    WHERE CallID = @CallID"

            Using con As New SqlConnection(connectionString)
                con.Open() ' Open the connection

                Dim cmd As New SqlCommand("INSERT INTO g3_CallNotes (CallId, NoteText, AddedBy, Timestamp) VALUES (@CallId, @NoteText, @AddedBy, @Timestamp)", con)

                cmd.Parameters.AddWithValue("@NoteText", Note_TextBox.Text)
                cmd.Parameters.AddWithValue("@AddedBy", AddedByTxtBox.Text)
                cmd.Parameters.AddWithValue("@Timestamp", DateTime.Now)

                cmd.Parameters.AddWithValue("@CallId", CInt(CallId_Label.Text))

                ' Execute the insert command
                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles AddedByTxtBox.TextChanged
        Dim searchQuery As String = AddedByTxtBox.Text.Trim().ToLower()
        HandlerResultsListBox.Items.Clear()

        If String.IsNullOrEmpty(searchQuery) Then
            HandlerResultsListBox.Visible = False
            Exit Sub
        End If

        employeeNames.Clear()
        For Each prefix In {"INOS"}
            LoadEmployeeNamesByPrefix(prefix)
        Next

        Dim filteredResults = employeeNames.Where(Function(name) name.ToLower().Contains(searchQuery)).ToList()

        If filteredResults.Any() Then
            HandlerResultsListBox.Items.AddRange(filteredResults.ToArray())
            HandlerResultsListBox.Visible = True
        Else
            HandlerResultsListBox.Visible = False
        End If

    End Sub

    Private Sub ResultsListBox_Click(sender As Object, e As EventArgs) Handles HandlerResultsListBox.Click
        If HandlerResultsListBox.SelectedItem IsNot Nothing Then
            AddedByTxtBox.Text = HandlerResultsListBox.SelectedItem.ToString
            HandlerResultsListBox.Visible = False
        End If
    End Sub

    Private Sub AddNoteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HandlerResultsListBox.Visible = False

    End Sub

    Private Sub ConfirmNotes_Btn_Click(sender As Object, e As EventArgs) Handles ConfirmNotes_Btn.Click
        SaveDataToCallersTables()
        Me.Close()
    End Sub
End Class