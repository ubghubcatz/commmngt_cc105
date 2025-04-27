
Imports Microsoft.Data.SqlClient

Public Class g3CommandCenter_Form

    ' Establish connection to the SQL Server database
    Dim con As New SqlConnection("Server=commngtcc105.mssql.somee.com;Database=commngtcc105;
                                 User Id=ublipa_SQLLogin_1;Password=nktg6ikffl;TrustServerCertificate=True;")

    ' Define the connection string to the database
    Dim connectionString As String = "Server=commngtcc105.mssql.somee.com;Database=commngtcc105;
                                         User Id=ublipa_SQLLogin_1;Password=nktg6ikffl;TrustServerCertificate=True;"

    ' Declare global form instances to track opened forms
    Public CaseRecordForm As CaseRecordTable = Nothing
    Public CallLogForm As CallLog_Tables = Nothing
    Public OfficersForm As OfficersAvailabiltyForm = Nothing

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Dynamically set the form size to fit within the available screen space (excluding taskbar)
        Dim workingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.Width = workingArea.Width
        Me.Height = workingArea.Height
        Me.Size = Me.MinimumSize

        ' Set tab control appearance and size as needed
        TabControl1.Appearance = TabAppearance.Normal
        TabControl1.ItemSize = New Size(0, 1) ' Shrink tabs to 1 pixel
        TabControl1.SizeMode = TabSizeMode.Fixed
        TabControl1.DrawMode = TabDrawMode.OwnerDrawFixed ' Enable custom drawing for tabs

        ' Ensure the form stays on top
        Me.TopMost = True

        ' Maintain maximize and minimize options
        With Me
            .MaximizeBox = True
            .MinimizeBox = True ' Optionally keep minimize enabled
        End With

        Try
            con.Open()
            MessageBox.Show("Connection Successful!") ' Inform user of successful connection
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message) ' Display error if connection fails
        End Try

        Timer1.Interval = 10000 ' Refresh every 10 seconds
        Timer1.Enabled = True
    End Sub

    ' Custom draw tab items to hide borders and make them look clean
    Private Sub TabControl1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TabControl1.DrawItem
        ' Hide borders by drawing a blank background
        e.Graphics.FillRectangle(New SolidBrush(TabControl1.BackColor), e.Bounds)
    End Sub

    ' Resize event to handle form resizing
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        LayoutManager.ResizeFormLayout(Me) ' Adjust layout on form resize
        CountCases()
    End Sub
    Public Sub OpenOrRestoreForm(ByRef formInstance As Form, formType As Type)
        ' Check if the form instance already exists and is not disposed
        If formInstance IsNot Nothing AndAlso Not formInstance.IsDisposed Then
            ' Restore if minimized and bring to front
            If formInstance.WindowState = FormWindowState.Minimized Then
                formInstance.WindowState = FormWindowState.Normal
            End If
            formInstance.BringToFront()
            formInstance.Activate()
        Else
            ' Create new instance and ensure it's fixed single form
            formInstance = CType(Activator.CreateInstance(formType), Form)
            With formInstance
                .TopMost = True
                .FormBorderStyle = FormBorderStyle.FixedSingle
                .MaximizeBox = False ' Disable maximize button
                .MinimizeBox = True  ' Optionally keep minimize enabled
            End With
            formInstance.Show()
        End If
    End Sub

    Public Sub CountCases()
        Dim query As String = "SELECT casestatus, COUNT(*) AS StatusCount
                           FROM g3_CaseRecords
                           GROUP BY casestatus;"

        Try
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        Dim status As String = reader("CaseStatus").ToString()
                        Dim count As Integer = Convert.ToInt32(reader("StatusCount"))

                        Select Case status
                            Case "Open"
                                OpenCasesCount_Label.Text = count.ToString()
                            Case "Resolved"
                                ResolvedCasesCount_Label.Text = count.ToString()
                            Case "Pending"
                                PendingCasesCount_Label.Text = count.ToString()
                            Case "In Progress"
                                InProgressCasesCount_Label.Text = count.ToString()
                        End Select
                    End While

                    reader.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub CaseRecords_Btn_Click(sender As Object, e As EventArgs) Handles CaseRecords_Btn.Click
        OpenOrRestoreForm(CaseRecordForm, GetType(CaseRecordTable))
    End Sub

    Private Sub CallLogging_Btn_Click(sender As Object, e As EventArgs) Handles CallLogging_Btn.Click
        OpenOrRestoreForm(CallLogForm, GetType(CallLog_Tables))
    End Sub

    Private Sub OfficersAvailability_Btn_Click(sender As Object, e As EventArgs) Handles OfficersAvailability_Btn.Click
        OpenOrRestoreForm(OfficersForm, GetType(OfficersAvailabiltyForm))
    End Sub


    ' Format the Call Log DataGridView cells to improve appearance
    Private Sub ActiveCases_DataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        If e.RowIndex < 0 Then Exit Sub ' Skip header row

        ' Set the background color for data rows
        e.CellStyle.BackColor = Color.Honeydew
    End Sub

    ' Style the DataGridView (called by InsertTable) for better readability
    Public Sub StyleDataGridView(ByRef dgv As DataGridView)
        dgv.Columns(0).Visible = False ' Hide the first column (CaseID)
        With dgv
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ' Auto size columns to fill the available width
            .ReadOnly = True ' Make the DataGridView read-only
            .EnableHeadersVisualStyles = False ' Disable default header styles
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells ' Auto resize rows
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True ' Enable text wrapping
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Center-align text
            .DefaultCellStyle.Font = New Font(dgv.Font.FontFamily, dgv.Font.Size, FontStyle.Bold) ' Make text bold
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing ' Disable resizing row headers
            .AllowUserToResizeRows = False ' Prevent row resizing
            .AllowUserToResizeColumns = False ' Prevent column resizing
        End With
        ' Style column headers
        With dgv.ColumnHeadersDefaultCellStyle
            .BackColor = Color.DarkGreen ' Set background color for headers
            .ForeColor = Color.White ' Set font color for headers
            .Font = New Font(dgv.Font.FontFamily, dgv.Font.Size, FontStyle.Bold) ' Make header text bold
            .Alignment = DataGridViewContentAlignment.MiddleCenter ' Center-align header text
        End With

        ' Prevent column resizing and sorting
        For Each col As DataGridViewColumn In dgv.Columns
            col.Resizable = DataGridViewTriState.False ' Disable column resizing
            col.SortMode = DataGridViewColumnSortMode.NotSortable ' Disable sorting on columns
        Next
        dgv.AllowUserToAddRows = False ' Prevent adding rows manually

    End Sub

End Class

