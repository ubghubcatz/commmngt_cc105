Imports Microsoft.Data.SqlClient
Imports System.IO
Imports Windows.Win32.System


Public Class OfficersAvailabiltyForm

    Private connectionString As String = "Server=commngtcc105.mssql.somee.com;Database=commngtcc105;
                                     User Id=ublipa_SQLLogin_1;Password=nktg6ikffl;TrustServerCertificate=True;"



    Private Sub Refresh_Btn_Click(sender As Object, e As EventArgs) Handles Refresh_Btn.Click
        Dim selectQuery As String = "
        SELECT i.EmployeeID, d.EmployeeName, i.Position
        FROM g4_EmployeesInfo i
        INNER JOIN g4_EmployeeDetails d ON i.EmployeeID = d.EmployeeID
        WHERE NOT EXISTS (
            SELECT 1 FROM g3_OfficerAvailability x WHERE x.officerid = i.EmployeeID
        );"

        Dim insertQuery As String = "
        MERGE g3_OfficerAvailability AS target
        USING (
            SELECT 
                e.EmployeeID AS officerid,
                e.EmployeeName AS officername,
                i.Position AS PositionName
            FROM g4_EmployeeDetails e
            INNER JOIN g4_EmployeesInfo i ON e.EmployeeID = i.EmployeeID
            WHERE e.EmployeeID = @officerid
        ) AS source
        ON target.officerid = source.officerid
        WHEN MATCHED THEN
            UPDATE SET 
                target.officername = source.officername, 
                target.PositionName = source.PositionName
        WHEN NOT MATCHED THEN
            INSERT (officerid, officername, PositionName, maxcases, availablecases)
            VALUES (source.officerid, source.officername, source.PositionName, 2, 2);"

        Dim officers As New List(Of String)

        ' Open database connection
        Using conn As New SqlConnection(connectionString)
            conn.Open()

            ' Fetch officer IDs not already in g3_OfficerAvailability
            Using selectCmd As New SqlCommand(selectQuery, conn)
                Using reader As SqlDataReader = selectCmd.ExecuteReader()
                    While reader.Read()
                        Dim officerid As String = reader("EmployeeID").ToString()
                        officers.Add(officerid)
                    End While
                End Using
            End Using

            ' Insert or update officers
            For Each officerid In officers
                Using insertCmd As New SqlCommand(insertQuery, conn)
                    insertCmd.Parameters.AddWithValue("@officerid", officerid)
                    insertCmd.ExecuteNonQuery()
                End Using
            Next
        End Using

        ' Reload the DataGridView after updating records
        LoadOfficerAvailabilityData()
        SearchOfficers_TextBox.Text = ""
    End Sub


    Private Sub LoadOfficerAvailabilityData()
        Dim query As String = "
        SELECT 
            a.officerid, 
            d.EmployeeName AS officername, 
            i.Position AS PositionName, 
            a.maxcases, 
            a.availablecases
        FROM g3_OfficerAvailability a
        INNER JOIN g4_EmployeeDetails d ON a.officerid = d.EmployeeID
        INNER JOIN g4_EmployeesInfo i ON a.officerid = i.EmployeeID
    "

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                Using adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    OfficersCases_DataGridView.DataSource = dt ' Bind data to DataGridView
                End Using
            End Using
        End Using

        ' Formatting the DataGridView
        With OfficersCases_DataGridView
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .ReadOnly = True
            .EnableHeadersVisualStyles = False
            .AllowUserToResizeRows = False
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With

        ' Adjust column properties
        For Each column As DataGridViewColumn In OfficersCases_DataGridView.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable
            column.Resizable = DataGridViewTriState.False
            column.MinimumWidth = 100
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            column.DefaultCellStyle.Font = New Font(OfficersCases_DataGridView.Font.FontFamily, CSng(OfficersCases_DataGridView.Font.Size - 1), FontStyle.Bold)
        Next
        OfficersCases_DataGridView.AllowUserToAddRows = False
        ' Header styling
        With OfficersCases_DataGridView.ColumnHeadersDefaultCellStyle
            .BackColor = Color.DarkGreen
            .ForeColor = Color.White
            .Font = New Font(OfficersCases_DataGridView.Font.FontFamily, OfficersCases_DataGridView.Font.Size, FontStyle.Bold)
            .Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        With OfficersCases_DataGridView
            .Columns("officerid").HeaderText = "Officer ID"
            .Columns("officername").HeaderText = "Officer Name"
            .Columns("PositionName").HeaderText = "Position"
            .Columns("maxcases").HeaderText = "Max Cases"
            .Columns("availablecases").HeaderText = "Available Cases"
        End With
    End Sub

    Private Sub CallLog_Table_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles OfficersCases_DataGridView.CellFormatting
        If e.RowIndex < 0 Then Exit Sub ' Skip header row

        e.CellStyle.BackColor = Color.Honeydew

        ' Apply status color formatting only to "CallStatus" column
        If OfficersCases_DataGridView.Columns(e.ColumnIndex).Name = "availablecases" Then
            Select Case OfficersCases_DataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value?.ToString()
                Case "2" : e.CellStyle.ForeColor = Color.Green
                Case "0" : e.CellStyle.ForeColor = Color.Red
                Case "1" : e.CellStyle.ForeColor = Color.Orange
                Case Else : e.CellStyle.ForeColor = Color.Black
            End Select
        End If
    End Sub

    Private Sub OfficersAvailabiltyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOfficerAvailabilityData()
    End Sub

    Private Sub SearchOfficers_TextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchOfficers_TextBox.TextChanged
        Dim bs As New BindingSource()
        bs.DataSource = OfficersCases_DataGridView.DataSource

        ' Get user input and ensure proper formatting
        Dim searchText As String = SearchOfficers_TextBox.Text.Trim()

        ' Define the columns you want to search
        Dim searchColumns As String() = {"officerid", "officername", "PositionName"}

        ' Build the filter string dynamically for multiple columns
        Dim filterParts As New List(Of String)

        For Each col As String In searchColumns

            filterParts.Add($"{col} LIKE '%{searchText}%'")

        Next

        Dim filter As String = String.Join(" OR ", filterParts)

        bs.Filter = filter
        OfficersCases_DataGridView.DataSource = bs
    End Sub
End Class