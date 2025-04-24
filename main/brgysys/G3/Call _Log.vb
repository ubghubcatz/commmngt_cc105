Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Security
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock
Imports Microsoft.Data.SqlClient
Public Class Call_Log
    Private connectionString As String = "Server=commngtcc105.mssql.somee.com;Database=commngtcc105;
                                     User Id=ublipa_SQLLogin_1;Password=nktg6ikffl;TrustServerCertificate=True;"

    Private employeeNames As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase) ' Prevents duplicates automatically
    Private callers As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
    Private callerDetails As New Dictionary(Of String, (Email As String, Number As String))(StringComparer.OrdinalIgnoreCase)
    Dim ID As String
    Dim splitString As String()
    Dim CallerEmail, CallerNumber As String
    Private Sub Call_Log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HandlerResultsListBox.Visible = False
        ListBox2.Visible = False
        ListBox1.Visible = False
        Button1.Visible = False
        Button2.Visible = False
    End Sub

    Private Sub ConfirnCallLog_Btn_Click(sender As Object, e As EventArgs) Handles ConfirnCallLog_Btn.Click
        Dim ZoneName As String = ""
        If HandlerResultsListBox.Items.Count = 0 Then
            MsgBox("No handler selected!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
        End If

        If Handled_TxtBox.Text.Length < 0 AndAlso Status_ComboBox.Text = "Missed" Then
            MsgBox("Invalid Handler!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
        End If

        If Purok_Picker.SelectedIndex = -1 AndAlso Status_ComboBox.Text IsNot "Missed" Then
            MsgBox("Invalid Call Zone!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
        End If

        Dim phoneNumber As String = PhoneNum_TxtBox.Text.Trim()
        If Not (phoneNumber.Length = 11 AndAlso IsNumeric(phoneNumber) AndAlso phoneNumber.StartsWith("09")) Then
            MsgBox("Invalid Phone Number!", MsgBoxStyle.Exclamation, "Invalid Input") : Exit Sub
        End If

        Dim callTypeTxt As String = TryCast(CallType_ComboBox.SelectedItem, String)?.Trim()
        Dim callStatusTxt As String = TryCast(Status_ComboBox.SelectedItem, String)?.Trim()
        Dim commTypetxt As String = TryCast(CommType_ComboBox.SelectedItem, String)?.Trim()

        If commTypetxt = "" Then
            MsgBox("Communication Type is required!", MsgBoxStyle.Exclamation, "Invalid Input") : Exit Sub
        End If
        If String.IsNullOrWhiteSpace(callTypeTxt) OrElse String.IsNullOrWhiteSpace(callStatusTxt) Then
            MsgBox("Call Type and Status are required!", MsgBoxStyle.Exclamation, "Invalid Input") : Exit Sub
        End If
        If Purok_Picker.SelectedIndex = -1 AndAlso Status_ComboBox.Text Is "Missed" Then
            ZoneName = "Unknown"
        Else
            ZoneName = TryCast(Purok_Picker.SelectedItem, String)?.Trim()
        End If
        Dim callDate As DateTime = CallDate_DtePicker.Value
        If callDate > Date.Today Then MsgBox("Invalid Date!", MsgBoxStyle.Exclamation, "Invalid Input") : Exit Sub

        Dim purpose As String = Purpose_TxtBox.Text.Trim()
        If callStatusTxt = "Answered" AndAlso String.IsNullOrWhiteSpace(purpose) Then
            MsgBox("Purpose is required!", MsgBoxStyle.Exclamation, "Invalid Input") : Exit Sub
        End If
        splitString = Handled_TxtBox.Text.Split(" | ")
        Dim handlername As String = splitString(1)
        Dim firstName As String = FirstName_TxtBox.Text.Trim()
        Dim lastName As String = LastName_TxtBox.Text.Trim()
        Dim email As String = CallerEmail_TxtBox.Text.Trim()
        Try
            SaveDataToCallersTables(phoneNumber, handlername, callStatusTxt, callTypeTxt, callDate, purpose, ZoneName, ID, commTypetxt, firstName, lastName, email, "N/A")
            MsgBox("Data saved successfully!", MsgBoxStyle.Information, "Success") : Me.Close()
        Catch ex As Exception
            MsgBox("Failed to save data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub SaveDataToCallersTables(Phone_Num As String, HandlerName As String, CallStatus As String, CallType As String,
                                        CallDate As DateTime, Purpose As String, ZoneName As String, HandlerID As String, CommType As String, FirstName As String,
                                        LastName As String, Email As String, caseIDString As String)
        Using con As New SqlConnection(connectionString)
            con.Open() ' Open the connection
            Using cmd1 As New SqlCommand("
IF NOT EXISTS (SELECT 1 FROM g3_Callers 
               WHERE CallerFirstName = @CallerFirstName 
                 AND CallerLastName = @CallerLastName 
                 AND CallerNumber = @CallerNumber 
                 AND CallerEmail = @CallerEmail)
BEGIN
    INSERT INTO g3_Callers (CallerFirstName, CallerLastName, CallerEmail, CallerNumber)
    VALUES (@CallerFirstName, @CallerLastName, @CallerEmail, @CallerNumber)
END", con)
                cmd1.Parameters.AddWithValue("@CallerFirstName", FirstName)
                cmd1.Parameters.AddWithValue("@CallerLastName", LastName)
                cmd1.Parameters.AddWithValue("@CallerEmail", Email)
                cmd1.Parameters.AddWithValue("@CallerNumber", Phone_Num)

                cmd1.ExecuteNonQuery()
            End Using
            ' Get CallerID
            Dim CallerID As Integer
            Using cmdGetCaller As New SqlCommand("SELECT CallerID FROM g3_Callers WHERE CallerFirstName = @CallerFirstName AND CallerLastName = @CallerLastName", con)
                cmdGetCaller.Parameters.AddWithValue("@CallerFirstName", FirstName)
                cmdGetCaller.Parameters.AddWithValue("@CallerLastName", LastName)
                Dim result = cmdGetCaller.ExecuteScalar()
                If result IsNot Nothing Then CallerID = Convert.ToInt32(result)
            End Using

            ' Insert into g3_CallType (if it’s meant to be another entry, otherwise it should be another table)
            Using cmd5 As New SqlCommand("
               INSERT INTO g3_BrgyCallLogs (DateAndTime, Purpose, CommType, CallerID, ZoneName, HandlerID, CommStatus, CaseIDString, CallType)
               VALUES (@DateAndTime, @Purpose, @CommType, @CallerID, @ZoneName, @HandlerID, @CommStatus, @CaseIDString, @CallType)", con)

                cmd5.Parameters.AddWithValue("@DateAndTime", CallDate)
                cmd5.Parameters.AddWithValue("@Purpose", Purpose)
                cmd5.Parameters.AddWithValue("@CallerID", CallerID)
                cmd5.Parameters.AddWithValue("@ZoneName", ZoneName)
                cmd5.Parameters.AddWithValue("@HandlerID", HandlerID)
                cmd5.Parameters.AddWithValue("@CommType", CommType)
                cmd5.Parameters.AddWithValue("@CommStatus", CallStatus)
                cmd5.Parameters.AddWithValue("@CaseIDString", caseIDString)
                cmd5.Parameters.AddWithValue("@CallType", CallType)

                cmd5.ExecuteNonQuery()
            End Using

        End Using

        Try
            Using con As New SqlConnection(connectionString)
                con.Open()

                ' Retrieve CallID (make sure it's the correct one)
                Dim callID As Integer = 0
                Dim query As String = "SELECT TOP 1 CallID FROM g3_BrgyCallLogs ORDER BY CallID DESC" ' Get the latest call

                Using cmd As New SqlCommand(query, con)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            callID = reader("CallID") ' Get the first result
                        Else
                            MessageBox.Show("No call records found.")
                            Exit Sub ' Stop execution if no data is found
                        End If
                    End Using
                End Using

                Dim query2 As String = "INSERT INTO g3_CallNotes (CallID, NoteText, AddedBy, Timestamp) VALUES (@CallID, @NoteText, @AddedBy, @Timestamp)"
                Using cmd As New SqlCommand(query2, con)
                    cmd.Parameters.AddWithValue("@CallID", callID)
                    cmd.Parameters.AddWithValue("@NoteText", NotesTxtox.Text)
                    cmd.Parameters.AddWithValue("@AddedBy", HandlerName)
                    cmd.Parameters.AddWithValue("@Timestamp", DateTime.Now)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Note added successfully!")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub LoadEmployeeNamesByPrefix(employeePrefix As String)
        Using con As New SqlConnection(connectionString),
              cmd As New SqlCommand("SELECT FirstName, LastName, EmployeeID FROM g4_EmployeesInfo WHERE EmployeeID LIKE @Prefix + '%'", con)
            cmd.Parameters.AddWithValue("@Prefix", employeePrefix)

            Try
                con.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        employeeNames.Add($"{reader("EmployeeID")} | {reader("FirstName")} {reader("LastName")}")
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles Handled_TxtBox.TextChanged
        Dim searchQuery As String = Handled_TxtBox.Text.Trim().ToLower()
        HandlerResultsListBox.Items.Clear()

        If String.IsNullOrEmpty(searchQuery) Then
            HandlerResultsListBox.Visible = False
            Exit Sub
        End If

        employeeNames.Clear()
        For Each prefix In {"INOS1"} ' Add more prefixes if needed
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
            Handled_TxtBox.Text = HandlerResultsListBox.SelectedItem.ToString
            splitString = Handled_TxtBox.Text.Split(" | ")
            ID = splitString(0)
            HandlerResultsListBox.Visible = False
        End If
    End Sub
    Public Sub LoadCallersByFirstNamePrefix(firstNamePrefix As String, callers As HashSet(Of String))
        callers.Clear()
        callerDetails.Clear()

        Dim query As String = "
        SELECT CallerFirstName, CallerLastName, CallerEmail, CallerNumber, CallerID
        FROM g3_Callers
        WHERE (CallerFirstName LIKE @FirstNamePrefix + '%')"

        Using con As New SqlConnection(connectionString),
          cmd As New SqlCommand(query, con)

            cmd.Parameters.AddWithValue("@FirstNamePrefix", firstNamePrefix)

            Try
                con.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim firstName As String = reader("CallerFirstName").ToString()
                        Dim lastName As String = reader("CallerLastName").ToString()
                        Dim number As String = reader("CallerNumber").ToString()
                        Dim fullName As String = $"{firstName} {lastName} - {number}"

                        If callers.Add(fullName) Then
                            Dim email As String = reader("CallerEmail").ToString()
                            callerDetails(fullName) = (email, number)
                        End If
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Sub LoadCallersByLastNamePrefix(lastNamePrefix As String, callers As HashSet(Of String))
        callers.Clear()
        callerDetails.Clear()

        Dim query As String = "
        SELECT CallerFirstName, CallerLastName, CallerEmail, CallerNumber, CallerID
        FROM g3_Callers
        WHERE (CallerLastName LIKE @LastNamePrefix + '%')"

        Using con As New SqlConnection(connectionString),
          cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@LastNamePrefix", lastNamePrefix)

            Try
                con.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim firstName As String = reader("CallerFirstName").ToString()
                        Dim lastName As String = reader("CallerLastName").ToString()
                        Dim number As String = reader("CallerNumber").ToString()
                        Dim fullName As String = $"{firstName} {lastName} - {number}"

                        If callers.Add(fullName) Then
                            Dim email As String = reader("CallerEmail").ToString()
                            callerDetails(fullName) = (email, number)
                        End If
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub


    Public Sub FilterCallersByName(textBox As TextBox, listBox As ListBox, but As Button)
        Dim searchQuery As String = textBox.Text.Trim().ToLower()
        listBox.Items.Clear()
        FilterCallers()

        Dim filteredResults = callers.Where(Function(name) name.ToLower().Contains(searchQuery)).ToList()

        If filteredResults.Any() Then
            listBox.Items.AddRange(filteredResults.ToArray())
            listBox.Visible = True
            but.Visible = True
        Else
            listBox.Visible = False
            but.Visible = False
        End If
    End Sub

    Private Sub FirstName_TxtBox_TextChanged(sender As Object, e As EventArgs) Handles FirstName_TxtBox.TextChanged
        FilterCallersByName(FirstName_TxtBox, ListBox1, Button2)
    End Sub

    Private Sub LastName_TxtBox_TextChanged(sender As Object, e As EventArgs) Handles LastName_TxtBox.TextChanged
        FilterCallersByName(LastName_TxtBox, ListBox2, Button1)

    End Sub

    Private Sub FilterCallers()
        Dim firstNamePrefix As String = FirstName_TxtBox.Text.Trim()
        Dim lastNamePrefix As String = LastName_TxtBox.Text.Trim()

        LoadCallersByFirstNamePrefix(firstNamePrefix, callers)
        LoadCallersByLastNamePrefix(lastNamePrefix, callers)
    End Sub

    Public Sub PopulateCallerDetailsFromListBox(selectedItem As Object, emailTxt As TextBox, numTxt As TextBox, firstName_Txt As TextBox, lstNane As TextBox)
        If selectedItem Is Nothing Then Exit Sub

        Dim selectedName As String = selectedItem.ToString()
        Dim splitNames As String() = selectedName.Split(" "c)

        If callerDetails.ContainsKey(selectedName) Then
            Dim details = callerDetails(selectedName)
            emailTxt.Text = details.Item1 ' Email
            numTxt.Text = details.Item2     ' Number
            firstName_Txt.Text = splitNames(0)
            lstNane.Text = If(splitNames.Length > 1, splitNames(1), "")

        End If
    End Sub


    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        PopulateCallerDetailsFromListBox(ListBox1.SelectedItem, CallerEmail_TxtBox, PhoneNum_TxtBox, FirstName_TxtBox, LastName_TxtBox)
        ListBox1.Visible = False
        ListBox2.Visible = False
        Button1.Visible = False
        Button2.Visible = False
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        PopulateCallerDetailsFromListBox(ListBox2.SelectedItem, CallerEmail_TxtBox, PhoneNum_TxtBox, FirstName_TxtBox, LastName_TxtBox)
        ListBox1.Visible = False
        ListBox2.Visible = False
        Button1.Visible = False
        Button2.Visible = False
    End Sub

    Private Sub CommType_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CommType_ComboBox.SelectedIndexChanged
        If CommType_ComboBox.SelectedItem.ToString() = "Walk-in" Then
            Status_ComboBox.SelectedIndex = 1
            CallType_ComboBox.SelectedIndex = 1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False
        Button2.Visible = False
        ListBox1.Visible = False
        ListBox2.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Visible = False
        Button2.Visible = False
        ListBox1.Visible = False
        ListBox2.Visible = False
    End Sub
End Class