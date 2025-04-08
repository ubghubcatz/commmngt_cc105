Imports Microsoft.Data.SqlClient
Imports Windows.Win32.System

Public Class CallLog_Tables

    Dim con As New SqlConnection("Server=commngtcc105.mssql.somee.com;Database=commngtcc105;
                                     User Id=ublipa_SQLLogin_1;Password=nktg6ikffl;TrustServerCertificate=True;")
    Private connectionString As String = "Server=commngtcc105.mssql.somee.com;Database=commngtcc105;
                                     User Id=ublipa_SQLLogin_1;Password=nktg6ikffl;TrustServerCertificate=True;"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True ' Keep the form on top
        Me.MaximizeBox = False  ' Disable maximize button
        Timer1.Interval = 5000 ' Refresh every 5 seconds
        Timer1.Enabled = True
        LoadCallLogData()
    End Sub
    Private Sub LoadCallLogData()
        Try
            con.Open()
            Dim query As String = "SELECT l.CallID, c.CallerNumber, l.CallDate, l.CallTime, l.Duration, l.Purpose, l.ZoneName,
                                      d.CallType, s.Status, h.HandlerName
                               FROM g3_BrgyCallLogs l
                               INNER JOIN g3_CallStatuses s ON l.StatusID = s.StatusID
                               INNER JOIN g3_Callers c ON l.CallerID = c.CallerID
                               INNER JOIN g3_CallTypes d ON l.CallTypeID = d.CallTypeID
                               INNER JOIN g3_Handlers h ON l.HandledByID = h.HandlerID"

            Dim adapter As New SqlDataAdapter(New SqlCommand(query, con))
            Dim table As New DataTable()
            adapter.Fill(table)
            CallLog_Table.DataSource = table
            For Each row As DataGridViewRow In CallLog_Table.Rows
                If Not row.IsNewRow Then
                    ' Format CallTime to hh:mm
                    Dim timeSpanValue As TimeSpan
                    If TimeSpan.TryParse(row.Cells("CallTime").Value?.ToString(), timeSpanValue) Then
                        row.Cells("CallTime").Value = timeSpanValue.ToString("hh\:mm")
                    End If

                    CallLog_Table.Columns("CallID").Visible = False

                    ' Format Duration for display using DataGridView CellFormatting event
                    Dim durationSeconds As Integer
                    If Integer.TryParse(row.Cells("Duration").Value?.ToString(), durationSeconds) Then
                        row.Cells("Duration").Tag = durationSeconds ' Store original integer value
                    End If
                End If
            Next
            StyleDataGridView(CallLog_Table)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub StyleDataGridView(ByRef dgv As DataGridView)
        For Each column As DataGridViewColumn In dgv.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable
            column.Resizable = DataGridViewTriState.False
            column.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Next
        dgv.AllowUserToResizeRows = False
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.ReadOnly = True
        dgv.EnableHeadersVisualStyles = False

        ' Header styling
        With dgv.ColumnHeadersDefaultCellStyle
            .BackColor = Color.DarkGreen
            .ForeColor = Color.White
            .Font = New Font(dgv.Font.FontFamily, dgv.Font.Size, FontStyle.Bold)
            .Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        ' Cell styling (Semi-Bold)
        Dim semiBoldFont As New Font(dgv.Font.FontFamily, CSng(dgv.Font.Size - 1), FontStyle.Bold)
        For Each column As DataGridViewColumn In dgv.Columns
            column.MinimumWidth = 100
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            column.DefaultCellStyle.Font = semiBoldFont
        Next
        dgv.AllowUserToAddRows = False ' Prevent adding rows manually
    End Sub

    Private Sub CallLogsGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles CallLog_Table.CellDoubleClick
        ' Ensure the user double-clicked a valid row (not the header)
        If e.RowIndex >= 0 Then
            ' Retrieve CallID from the selected row
            Dim selectedCallID As Integer = Convert.ToInt32(CallLog_Table.Rows(e.RowIndex).Cells("CallID").Value)

            ' Load call details using the CallID
            LoadCallDetails(selectedCallID)
        End If
    End Sub

    Private Sub LoadCallDetails(callID As Integer)
        Dim detailsForm As New CallDetails()
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()

                ' Query to fetch call details
                Dim query As String = "SELECT l.CallID, c.CallerNumber, l.CallDate, l.CallTime, l.Purpose, l.ZoneName,
                                          d.CallType, s.Status, h.HandlerName
                                   FROM g3_BrgyCallLogs l
                                   INNER JOIN g3_CallStatuses s ON l.StatusID = s.StatusID
                                   INNER JOIN g3_Callers c ON l.CallerID = c.CallerID
                                   INNER JOIN g3_CallTypes d ON l.CallTypeID = d.CallTypeID
                                   INNER JOIN g3_Handlers h ON l.HandledByID = h.HandlerID
                                   WHERE l.CallID = @CallID"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@CallID", callID)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then ' Ensure only one matching record is loaded
                            detailsForm.Number_TxtBox.Text = reader("CallerNumber").ToString()
                            detailsForm.CallDate_TxtBox.Text = Convert.ToDateTime(reader("CallDate")).ToString("yyyy-MM-dd")
                            detailsForm.CallTime_TxtBox.Text = TimeSpan.Parse(reader("CallTime").ToString()).ToString("hh\:mm")
                            detailsForm.Status_TxtBox.Text = reader("Status").ToString()
                            detailsForm.CallType_TxtBox.Text = reader("CallType").ToString()
                            detailsForm.Handler_TxtBox.Text = reader("HandlerName").ToString()
                            detailsForm.Purpose_Txbox.Text = reader("Purpose").ToString()
                            detailsForm.CallId_Label.Text = reader("CallID").ToString()
                            detailsForm.CallZone_TxtBox.Text = reader("ZoneName").ToString()
                        Else
                            MessageBox.Show("No matching call details found for CallID: " & callID)
                            Exit Sub
                        End If
                    End Using
                End Using

                ' Load Call Notes into DataGridView **AFTER** fetching call details
                Dim notesQuery As String = "SELECT CallID, NoteID, NoteText, AddedBy, TimeStamp 
                                        FROM g3_CallNotes 
                                        WHERE CallID = @CallID"

                Using notesCmd As New SqlCommand(notesQuery, con)
                    notesCmd.Parameters.AddWithValue("@CallID", callID)

                    Dim notesAdapter As New SqlDataAdapter(notesCmd)
                    Dim notesTable As New DataTable()
                    notesAdapter.Fill(notesTable)

                    ' Assign data to DataGridView
                    detailsForm.CallNotes_Table.DataSource = notesTable
                    detailsForm.CallNotes_Table.Refresh()
                End Using

                ' Show the form after all data is loaded
                detailsForm.TopLevel = False ' Set the form as non-top level
                detailsForm.Location = New Point(0, 0) ' Position at the top-left corner
                Me.Controls.Add(detailsForm) ' Add directly to the parent form
                detailsForm.BringToFront() ' Ensure it overlaps everything
                detailsForm.Show() ' Show the form

            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub



    Private Sub CallLog_Table_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles CallLog_Table.CellFormatting
        If e.RowIndex < 0 Then Exit Sub ' Skip header row

        e.CellStyle.BackColor = Color.Honeydew
        Select Case CallLog_Table.Rows(e.RowIndex).Cells(e.ColumnIndex).Value?.ToString()
            Case "Answered" : e.CellStyle.ForeColor = Color.Green
            Case "Missed" : e.CellStyle.ForeColor = Color.Red
            Case "Declined" : e.CellStyle.ForeColor = Color.Orange
            Case "Incoming" : e.CellStyle.ForeColor = Color.DarkGreen
            Case "Outcoming" : e.CellStyle.ForeColor = Color.DarkBlue
            Case Else : e.CellStyle.ForeColor = Color.Black
        End Select

        If CallLog_Table.Columns(e.ColumnIndex).Name = "Duration" AndAlso e.Value IsNot Nothing Then
            Dim durationSeconds As Integer
            If Integer.TryParse(e.Value.ToString(), durationSeconds) Then
                Dim durationTime As TimeSpan = TimeSpan.FromSeconds(durationSeconds)
                e.Value = durationTime.ToString("hh\:mm\:ss")
                e.FormattingApplied = True
            End If
        End If
    End Sub

    ' Timer tick event to refresh the table
    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        LoadCallLogData() ' Reload the data
    End Sub

    ' Declare a global variable at the class level to track the Call_Log instance
    Private callLogForm As Call_Log = Nothing

    Private Sub AddCallLog_Btn_Click(sender As Object, e As EventArgs) Handles AddCallLog_Btn.Click

        Dim childForm As New Call_Log() ' Create an instance of the child form
        childForm.TopLevel = False ' Set the form as non-top level
        childForm.Location = New Point(0, 0) ' Position at the top-left corner
        Me.Controls.Add(childForm) ' Add directly to the parent form
        childForm.BringToFront() ' Ensure it overlaps everything
        childForm.Show() ' Show the form
    End Sub
    Private Sub SearchCallLog_TxtField_TextChanged(sender As Object, e As EventArgs) Handles SearchCallLog_TxtField.TextChanged
        Dim bs As New BindingSource()
        bs.DataSource = CallLog_Table.DataSource

        ' Get user input and ensure proper formatting
        Dim searchText As String = SearchCallLog_TxtField.Text.Trim()

        ' Define the columns you want to search
        Dim searchColumns As String() = {"CallerNumber", "CallDate", "HandlerName", "ZoneName"} ' Replace with actual column names

        ' Build the filter string dynamically for multiple columns
        Dim filterParts As New List(Of String)

        For Each col As String In searchColumns
            If col = "CallDate" Then
                ' Convert DateTime to a string for filtering
                filterParts.Add($"CONVERT({col}, 'System.String') LIKE '%{searchText}%'")

            Else
                filterParts.Add($"{col} LIKE '%{searchText}%'")
            End If
        Next

        Dim filter As String = String.Join(" OR ", filterParts)

        bs.Filter = filter
        CallLog_Table.DataSource = bs
    End Sub




End Class