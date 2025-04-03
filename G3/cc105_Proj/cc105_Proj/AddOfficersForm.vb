Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Data.SqlClient

Public Class AddOfficersForm

    Private connectionString As String = "Server=commngtcc105.mssql.somee.com;Database=commngtcc105;
                                     User Id=ublipa_SQLLogin_1;Password=nktg6ikffl;TrustServerCertificate=True;"

    Private employeeNames As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase) ' Stores officer info with ID as key
    Dim extractedOfficerName As String = ""
    Dim extractedPosition As String = ""
    Private Sub AddOfficersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OfficialsResultsListBox.Visible = False
        officerId_Label.Text = "" ' Ensure it starts empty
    End Sub

    Private Sub LoadEmployeeNamesByPrefix(employeePrefix As String)
        Using con As New SqlConnection(connectionString),
              cmd As New SqlCommand("SELECT EmployeeName, EmployeeID, Position FROM g4_EmployeeDetails WHERE EmployeeID LIKE @Prefix + '%'", con)
            cmd.Parameters.AddWithValue("@Prefix", employeePrefix)

            Try
                con.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim officerId As String = reader("EmployeeID").ToString()
                        Dim officerName As String = reader("EmployeeName").ToString()
                        Dim position As String = reader("Position").ToString()
                        Dim displayText As String = $"{officerName} | {position}"

                        ' Store both the display text and ID
                        If Not employeeNames.ContainsKey(displayText) Then
                            employeeNames.Add(displayText, officerId)
                        End If
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub ResultsListBox_Click(sender As Object, e As EventArgs) Handles OfficialsResultsListBox.Click
        If OfficialsResultsListBox.SelectedItem IsNot Nothing Then
            Dim selectedText As String = OfficialsResultsListBox.SelectedItem.ToString()
            Officer_TextBox.Text = selectedText
            Dim parts() As String = selectedText.Split(" | ")
            extractedOfficerName = parts(0)
            extractedPosition = parts(1)

            ' If the selected text exists in the dictionary, set the ID label
            If employeeNames.ContainsKey(selectedText) Then
                officerId_Label.Text = employeeNames(selectedText)
            Else
                officerId_Label.Text = "" ' Clear if not found
            End If

            OfficialsResultsListBox.Visible = False
        End If
    End Sub

    Private Sub Officer_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Officer_TextBox.TextChanged
        Dim searchQuery As String = Officer_TextBox.Text.Trim().ToLower()
        OfficialsResultsListBox.Items.Clear()
        OfficialsResultsListBox.Visible = True
        officerId_Label.Text = "" ' Reset if input is changed

        If String.IsNullOrEmpty(searchQuery) Then
            OfficialsResultsListBox.Visible = False
            Exit Sub
        End If

        employeeNames.Clear()
        For Each prefix In {"INOS"} ' Add more prefixes if needed
            LoadEmployeeNamesByPrefix(prefix)
        Next

        Dim filteredResults = employeeNames.Keys.Where(Function(name) name.ToLower().Contains(searchQuery)).ToList()

        If filteredResults.Any() Then
            OfficialsResultsListBox.Items.AddRange(filteredResults.ToArray())
            OfficialsResultsListBox.Visible = True
        Else
            OfficialsResultsListBox.Visible = False
        End If
    End Sub

    Private Sub ConfirmOfficer_Btn_Click(sender As Object, e As EventArgs) Handles ConfirmOfficer_Btn.Click
        If String.IsNullOrWhiteSpace(officerId_Label.Text) Then
            MessageBox.Show("Please select a valid officer before confirming.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            saveOfficersToDataGridView(extractedOfficerName, extractedPosition)
            Officer_TextBox.Text = ""
        End If
    End Sub

    Private Sub saveOfficersToDataGridView(name As String, position As String)
        Dim caseForm As CaseRecordForm = Application.OpenForms.OfType(Of CaseRecordForm)().FirstOrDefault()

        ' Check if the officer ID already exists in the DataGridView
        For Each row As DataGridViewRow In caseForm.OfficersSent_DataGridView.Rows
            If row.Cells(0).Value IsNot Nothing AndAlso row.Cells(0).Value.ToString() = officerId_Label.Text.Trim() Then
                MessageBox.Show("This officer has already been added!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        Next

        ' First check the database for availablecases
        Dim availableCases As Integer = -1
        Dim query As String = "SELECT availablecases FROM g3_OfficerAvailability WHERE officerid = @officerid"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@officerid", officerId_Label.Text.Trim())
                conn.Open()
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Integer.TryParse(result.ToString(), availableCases) Then
                    If availableCases = 0 Then
                        MessageBox.Show("This officer has no available case slots!", "Unavailable Officer", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("Unable to check officer availability.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End Using
        End Using


        ' If the officer ID is not found, add it to the DataGridView
        caseForm.OfficersSent_DataGridView.Rows.Add(officerId_Label.Text.Trim(), name.Trim(), position.Trim())
        MessageBox.Show("Officer Added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
