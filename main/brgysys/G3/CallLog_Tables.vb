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
            Dim query As String = "
    SELECT l.CallID, 
           CONCAT(c.CallerFirstName, ' ', c.CallerLastName) AS FullName,  -- Combine first and last name
           c.CallerEmail, 
           c.CallerNumber, 
            FORMAT(l.DateAndTime, 'MM/dd/yyyy hh:mm tt') AS FormattedCallDate,
           l.Purpose, 
           l.ZoneName,
           l.CommStatus,
           l.caseIDString,
           l.CallType,
           l.CommType,
           e.EmployeeName
    FROM g3_BrgyCallLogs l
    INNER JOIN g3_Callers c ON l.CallerID = c.CallerID
    INNER JOIN g4_EmployeeDetails e ON l.HandlerID = e.EmployeeID"


            Dim adapter As New SqlDataAdapter(New SqlCommand(query, con))
            Dim table As New DataTable()
            adapter.Fill(table)
            CallLog_Table.DataSource = table
            For Each row As DataGridViewRow In CallLog_Table.Rows
                If Not row.IsNewRow Then
                    CallLog_Table.Columns("CallID").Visible = False
                    CallLog_Table.Columns("caseIDString").Visible = False
                    CallLog_Table.Columns("CallType").Visible = False
                    CallLog_Table.Columns("EmployeeName").Visible = False
                    CallLog_Table.Columns("Purpose").Visible = False

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
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = CallLog_Table.Rows(e.RowIndex)
            Dim selectedCallID As Integer = Convert.ToInt32(row.Cells("CallID").Value)

            ' Pass the row and ID to the detail loader
            LoadCallDetails(selectedCallID, row)
        End If
    End Sub

    Private Sub LoadCallDetails(callID As Integer, row As DataGridViewRow)
        Dim detailsForm As New CallDetails()
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()

                ' Load call notes
                Dim notesQuery As String = "SELECT CallID, NoteID, NoteText, AddedBy, TimeStamp 
                                        FROM g3_CallNotes 
                                        WHERE CallID = @CallID"

                Using notesCmd As New SqlCommand(notesQuery, con)
                    notesCmd.Parameters.AddWithValue("@CallID", callID)

                    Dim notesAdapter As New SqlDataAdapter(notesCmd)
                    Dim notesTable As New DataTable()
                    notesAdapter.Fill(notesTable)

                    detailsForm.CallNotes_Table.DataSource = notesTable
                    detailsForm.CallNotes_Table.Refresh()
                End Using
            End Using

            ' Now fill in call details from the clicked row
            detailsForm.Number_TxtBox.Text = row.Cells("CallerNumber").Value.ToString()
            detailsForm.Name_Text.Text = row.Cells("FullName").Value.ToString()
            detailsForm.Email_TextBox.Text = row.Cells("CallerEmail").Value.ToString()
            detailsForm.CallDate_TxtBox.Text = Convert.ToDateTime(row.Cells("DateAndTime").Value).ToString("yyyy-MM-dd HH:mm")
            detailsForm.Status_TxtBox.Text = row.Cells("CommStatus").Value.ToString()
            detailsForm.CallType_TxtBox.Text = row.Cells("CallType").Value.ToString()
            detailsForm.Handler_TxtBox.Text = row.Cells("EmployeeName").Value.ToString()
            detailsForm.Purpose_Txbox.Text = row.Cells("Purpose").Value.ToString()
            detailsForm.CallId_Label.Text = row.Cells("CallID").Value.ToString()
            detailsForm.CallZone_TxtBox.Text = row.Cells("ZoneName").Value.ToString()
            detailsForm.ConnectedCase_Label.Text = row.Cells("caseIDString").Value.ToString()

            ' Show the form embedded in the parent
            detailsForm.TopLevel = False
            detailsForm.Location = New Point(0, 0)
            Me.Controls.Add(detailsForm)
            detailsForm.BringToFront()
            detailsForm.Show()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub



    Private Sub CallLog_Table_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles CallLog_Table.CellFormatting
        If e.RowIndex < 0 Then Exit Sub ' Skip header row

        e.CellStyle.BackColor = Color.Honeydew
        Select Case CallLog_Table.Rows(e.RowIndex).Cells(e.ColumnIndex).Value?.ToString()
            Case "Responded" : e.CellStyle.ForeColor = Color.Green
            Case "Missed" : e.CellStyle.ForeColor = Color.Red
            Case "Declined" : e.CellStyle.ForeColor = Color.Orange
            Case "Queued" : e.CellStyle.ForeColor = Color.Yellow
            Case "Incoming" : e.CellStyle.ForeColor = Color.DarkGreen
            Case "Outcoming" : e.CellStyle.ForeColor = Color.DarkBlue
            Case "Through Call" : e.CellStyle.ForeColor = Color.Maroon
            Case "Through Text" : e.CellStyle.ForeColor = Color.DarkGoldenrod
            Case "Through Email" : e.CellStyle.ForeColor = Color.DarkSalmon
            Case "Through Social Media" : e.CellStyle.ForeColor = Color.DarkOrange
            Case "Walk-in" : e.CellStyle.ForeColor = Color.BlueViolet
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