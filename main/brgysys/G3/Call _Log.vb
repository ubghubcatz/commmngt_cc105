Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock
Imports Microsoft.Data.SqlClient
Public Class Call_Log
    Private connectionString As String = "Server=commngtcc105.mssql.somee.com;Database=commngtcc105;
                                     User Id=ublipa_SQLLogin_1;Password=nktg6ikffl;TrustServerCertificate=True;"

    Private employeeNames As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase) ' Prevents duplicates automatically
    Private phoneNumbers As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)  ' Prevents duplicates automatically

    Private Sub Call_Log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CallDuration_TimePicker.Value = Date.Today ' Default time set to 00:00:00
        HandlerResultsListBox.Visible = False
        PhoneNumResultsListBox.Visible = False

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

        If String.IsNullOrWhiteSpace(callTypeTxt) OrElse String.IsNullOrWhiteSpace(callStatusTxt) Then
            MsgBox("Call Type and Status are required!", MsgBoxStyle.Exclamation, "Invalid Input") : Exit Sub
        End If
        If Purok_Picker.SelectedIndex = -1 AndAlso Status_ComboBox.Text Is "Missed" Then
            ZoneName = "Unknown"
        Else
            ZoneName = TryCast(Purok_Picker.SelectedItem, String)?.Trim()
        End If
        Dim callDate As Date = CallDate_DtePicker.Value.Date
        If callDate > Date.Today Then MsgBox("Invalid Date!", MsgBoxStyle.Exclamation, "Invalid Input") : Exit Sub

        Dim callTime As DateTime = CallStart_TimePicker.Value
        If callTime > DateTime.Now Then MsgBox("Invalid Time!", MsgBoxStyle.Exclamation, "Invalid Input") : Exit Sub

        Dim purpose As String = Purpose_TxtBox.Text.Trim()
        If callStatusTxt = "Answered" AndAlso String.IsNullOrWhiteSpace(purpose) Then
            MsgBox("Purpose is required!", MsgBoxStyle.Exclamation, "Invalid Input") : Exit Sub
        End If

        Dim dur As Integer = (CallDuration_TimePicker.Value.Hour * 3600) +
                         (CallDuration_TimePicker.Value.Minute * 60) +
                         CallDuration_TimePicker.Value.Second

        If (callStatusTxt = "Answered" AndAlso dur <= 0) OrElse
       (callStatusTxt <> "Answered" AndAlso dur > 0) OrElse
       ((callStatusTxt = "Declined" OrElse callStatusTxt = "Missed") AndAlso purpose.Length > 0) Then
            MsgBox("Invalid Call Details!", MsgBoxStyle.Exclamation, "Invalid Input") : Exit Sub
        End If

        Try
            SaveDataToCallersTables(phoneNumber, Handled_TxtBox.Text, callStatusTxt, callTypeTxt, callDate, dur, callTime, purpose, ZoneName)
            MsgBox("Data saved successfully!", MsgBoxStyle.Information, "Success") : Me.Close()
        Catch ex As Exception
            MsgBox("Failed to save data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub SaveDataToCallersTables(Phone_Num As String, HandlerName As String, CallStatus As String, CallType As String,
                                        CallDate As Date, Duration As Integer, CallTime As DateTime, Purpose As String, ZoneName As String)
        Using con As New SqlConnection(connectionString)
            con.Open() ' Open the connection

            ' Insert into g3_Callers only if the number doesn't exist
            Using cmd1 As New SqlCommand("
            IF NOT EXISTS (SELECT 1 FROM g3_Callers WHERE CallerNumber = @CallerNumber)
            BEGIN
                INSERT INTO g3_Callers (CallerNumber) VALUES (@CallerNumber)
            END", con)
                cmd1.Parameters.AddWithValue("@CallerNumber", Phone_Num)
                cmd1.ExecuteNonQuery()
            End Using

            ' Insert into g3_Handlers only if the handler doesn't exist
            Using cmd2 As New SqlCommand("
            IF NOT EXISTS (SELECT 1 FROM g3_Handlers WHERE HandlerName = @HandlerName)
            BEGIN
                INSERT INTO g3_Handlers (HandlerName) VALUES (@HandlerName)
            END", con)
                cmd2.Parameters.AddWithValue("@HandlerName", HandlerName)
                cmd2.ExecuteNonQuery()
            End Using

            ' Insert into g3_CallStatuses
            Using cmd3 As New SqlCommand("
                IF NOT EXISTS (SELECT 1 FROM g3_CallStatuses WHERE Status = @Status)
                INSERT INTO g3_CallStatuses (Status) VALUES (@Status)", con)
                cmd3.Parameters.AddWithValue("@Status", CallStatus)
                cmd3.ExecuteNonQuery()
            End Using


            ' Insert into g3_CallType
            Using cmd4 As New SqlCommand("
                IF NOT EXISTS (SELECT 1 FROM g3_CallTypes WHERE CallType = @CallType)
                INSERT INTO g3_CallTypes (CallType) VALUES (@CallType)", con)
                cmd4.Parameters.AddWithValue("@CallType", CallType)
                cmd4.ExecuteNonQuery()
            End Using

            ' Get CallTypeID
            Dim CallTypeID As Integer
            Using cmdGetCallType As New SqlCommand("SELECT CallTypeID FROM g3_CallTypes WHERE CallType = @CallType", con)
                cmdGetCallType.Parameters.AddWithValue("@CallType", CallType)
                Dim result = cmdGetCallType.ExecuteScalar()
                If result IsNot Nothing Then CallTypeID = Convert.ToInt32(result)
            End Using

            ' Get CallerID
            Dim CallerID As Integer
            Using cmdGetCaller As New SqlCommand("SELECT CallerID FROM g3_Callers WHERE CallerNumber = @CallerNumber", con)
                cmdGetCaller.Parameters.AddWithValue("@CallerNumber", Phone_Num)
                Dim result = cmdGetCaller.ExecuteScalar()
                If result IsNot Nothing Then CallerID = Convert.ToInt32(result)
            End Using

            ' Get StatusID
            Dim StatusID As Integer
            Using cmdGetStatus As New SqlCommand("SELECT StatusID FROM g3_CallStatuses WHERE Status = @Status", con)
                cmdGetStatus.Parameters.AddWithValue("@Status", CallStatus)
                Dim result = cmdGetStatus.ExecuteScalar()
                If result IsNot Nothing Then StatusID = Convert.ToInt32(result)
            End Using

            ' Get HandlerID
            Dim HandlerID As Integer
            Using cmdGetStatus As New SqlCommand("SELECT HandlerId FROM g3_Handlers WHERE HandlerName = @HandlerName", con)
                cmdGetStatus.Parameters.AddWithValue("@HandlerName", HandlerName)
                Dim result = cmdGetStatus.ExecuteScalar()
                If result IsNot Nothing Then HandlerID = Convert.ToInt32(result)
            End Using

            ' Insert into g3_CallType (if it’s meant to be another entry, otherwise it should be another table)
            Using cmd5 As New SqlCommand("
               INSERT INTO g3_BrgyCallLogs (CallDate, CallTime, Duration, Purpose, CallTypeID, CallerID, StatusID, HandledByID, ZoneName)
               VALUES (@CallDate, @CallTime, @Duration, @Purpose, @CallTypeID, @CallerID, @StatusID, @HandledByID, @ZoneName)", con)

                cmd5.Parameters.AddWithValue("@CallDate", CallDate)
                cmd5.Parameters.AddWithValue("@CallTime", CallTime)
                cmd5.Parameters.AddWithValue("@Duration", Duration)
                cmd5.Parameters.AddWithValue("@Purpose", Purpose)
                cmd5.Parameters.AddWithValue("@CallTypeID", CallTypeID)
                cmd5.Parameters.AddWithValue("@CallerID", CallerID)
                cmd5.Parameters.AddWithValue("@StatusID", StatusID)
                cmd5.Parameters.AddWithValue("@HandledByID", HandlerID)
                cmd5.Parameters.AddWithValue("@ZoneName", ZoneName)
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

                ' ✅ Now the reader is closed, and we can insert data
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

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles Handled_TxtBox.TextChanged
        Dim searchQuery As String = Handled_TxtBox.Text.Trim().ToLower()
        HandlerResultsListBox.Items.Clear()

        If String.IsNullOrEmpty(searchQuery) Then
            HandlerResultsListBox.Visible = False
            Exit Sub
        End If

        employeeNames.Clear()
        For Each prefix In {"INOS1", "INOS2"} ' Add more prefixes if needed
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

    Private Sub LoadSavedPhoneNumbers(Phone_Num As String)
        Using con As New SqlConnection(connectionString),
      cmd As New SqlCommand("SELECT CallerNumber FROM g3_Callers WHERE CallerNumber LIKE @Prefix + '%'", con)
            cmd.Parameters.AddWithValue("@Prefix", Phone_Num)

            Try
                con.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        employeeNames.Add(reader("CallerNumber"))
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub PhoneNum_TxtBox_TextChanged(sender As Object, e As EventArgs) Handles PhoneNum_TxtBox.TextChanged
        Dim searchQuery As String = PhoneNum_TxtBox.Text.Trim()
        PhoneNumResultsListBox.Items.Clear()

        If String.IsNullOrEmpty(searchQuery) Then
            PhoneNumResultsListBox.Visible = False
            Exit Sub
        End If

        phoneNumbers.Clear()

        LoadSavedPhoneNumbers(searchQuery)

        Dim filteredResults = employeeNames.Where(Function(num) num.ToLower().Contains(searchQuery)).ToList()

        If filteredResults.Any() Then
            PhoneNumResultsListBox.Items.AddRange(filteredResults.ToArray())
            PhoneNumResultsListBox.Visible = True
        Else
            PhoneNumResultsListBox.Visible = False
        End If
    End Sub


    Private Sub ResultsListBox_Click(sender As Object, e As EventArgs) Handles HandlerResultsListBox.Click
        If HandlerResultsListBox.SelectedItem IsNot Nothing Then
            Handled_TxtBox.Text = HandlerResultsListBox.SelectedItem.ToString
            HandlerResultsListBox.Visible = False
        End If
    End Sub

    Private Sub PhoneNumResultsListBox_Click(sender As Object, e As EventArgs) Handles PhoneNumResultsListBox.Click
        If PhoneNumResultsListBox.SelectedItem IsNot Nothing Then
            PhoneNum_TxtBox.Text = PhoneNumResultsListBox.SelectedItem.ToString
            PhoneNumResultsListBox.Visible = False
        End If
    End Sub

End Class