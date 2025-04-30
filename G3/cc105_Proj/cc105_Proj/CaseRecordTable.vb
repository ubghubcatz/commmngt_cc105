Imports System.DirectoryServices.ActiveDirectory
Imports System.Globalization
Imports System.IO
Imports Microsoft.Data.SqlClient

Public Class CaseRecordTable
    Private connectionString As String = "Server=commngtcc105.mssql.somee.com;Database=commngtcc105;
                                     User Id=ublipa_SQLLogin_1;Password=nktg6ikffl;TrustServerCertificate=True;"
    ' Declare a global variable at the class level to track the Call_Log instance
    Private Form2 As CaseRecordForm = Nothing
    Private caseShow As CaseRecordShowForm = Nothing
    Private viewer As ImageViewer = Nothing
    Dim mainFormRef As g3CommandCenter_Form = TryCast(Application.OpenForms("g3CommandCenter_Form"), g3CommandCenter_Form)


    Private Sub OpenCaseReportForm()
        ' Check if the form already exists
        If Form2 IsNot Nothing AndAlso Not Form2.IsDisposed Then

            ' Re-add if it's minimized and hidden
            If Form2.WindowState = FormWindowState.Minimized OrElse Not Form2.Visible Then

                If Not Form2.Visible Then Form2.Show()
                If Form2.WindowState = FormWindowState.Minimized Then
                    Form2.WindowState = FormWindowState.Normal
                End If
                Form2.BringToFront()
                Form2.Activate()
                Form2.TopMost = True ' Ensure visibility
            End If
        Else
            ' If the form is not open or was closed, create a new instance
            Form2 = New CaseRecordForm()

            Form2.Show()
            Form2.BringToFront()
            Form2.Activate()
            Form2.TopMost = True ' Ensure visibility
        End If
    End Sub

    Public Sub InsertTable()
        Dim query As String = "
                             SELECT 
                                 sd.caseid,
                                 sd.caseIDString,
                                 sd.casename,
                                 sd.casetype,                               
                                 cr.casestatus,
                                 STRING_AGG(emp.EmployeeName, ', ') AS AssignedOfficers,
                                 cr.ExpectedDateFinish,
                                 cr.ResolvedDate
                             FROM g3_SpecificCaseDetails sd
                             LEFT JOIN g3_CaseRecords cr ON sd.caseid = cr.caseid
                             LEFT JOIN g3_OfficerCaseAssignments oca ON sd.caseid = oca.caseid
                             LEFT JOIN g4_EmployeeDetails emp ON oca.officerid = emp.EmployeeID
                             GROUP BY sd.caseid, caseIDString, sd.casename, sd.casetype, cr.casestatus, cr.ExpectedDateFinish, cr.ResolvedDate
                             "

        Try
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    ActiveCases_DataGridView.DataSource = table
                End Using
            End Using

            g3CommandCenter_Form.StyleDataGridView(ActiveCases_DataGridView)

            For Each row As DataGridViewRow In ActiveCases_DataGridView.Rows
                If Not row.IsNewRow Then
                    If String.IsNullOrEmpty(row.Cells("AssignedOfficers").Value?.ToString()) Then
                        row.Cells("AssignedOfficers").Style.BackColor = Color.LightPink
                    End If

                    If String.IsNullOrEmpty(row.Cells("ResolvedDate").Value?.ToString()) Then
                        row.Cells("ResolvedDate").Style.BackColor = Color.LightPink
                    End If

                    Dim expectedDateObj = row.Cells("ExpectedDateFinish").Value
                    If expectedDateObj IsNot DBNull.Value AndAlso expectedDateObj IsNot Nothing Then
                        Dim expectedDate As DateTime
                        If DateTime.TryParse(expectedDateObj.ToString(), expectedDate) Then
                            If expectedDate < DateTime.Today AndAlso row.Cells("casestatus").Value.ToString() <> "Resolved" Then
                                row.Cells("ExpectedDateFinish").Style.BackColor = Color.Red
                                row.Cells("ExpectedDateFinish").Style.ForeColor = Color.White
                            ElseIf (expectedDate - DateTime.Today).TotalDays <= 5 Then
                                row.Cells("ExpectedDateFinish").Style.BackColor = Color.Orange
                                row.Cells("ExpectedDateFinish").Style.ForeColor = Color.White
                            ElseIf expectedDate >= DateTime.Today AndAlso row.Cells("casestatus").Value.ToString() = "Resolved" Then
                                row.Cells("ExpectedDateFinish").Style.BackColor = Color.DarkGreen
                                row.Cells("ExpectedDateFinish").Style.ForeColor = Color.White
                            End If
                        End If
                    Else
                        row.Cells("ExpectedDateFinish").Style.BackColor = Color.LightPink
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    ' Handle double-click on DataGridView row to open case details
    Private Sub DataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ActiveCases_DataGridView.CellDoubleClick
        Dim caseShow As New CaseRecordTable
        Dim caseName As String = ""

        If ActiveCases_DataGridView.CurrentRow IsNot Nothing Then
            caseName = ActiveCases_DataGridView.CurrentRow.Cells(1).Value.ToString() ' Get case name from clicked row
            caseShow.loadCaseData(caseName) ' Load the case data into the new form
        End If
    End Sub

    Private Sub Add_Btn_Click(sender As Object, e As EventArgs) Handles AddCaseRecord_Btn.Click
        OpenCaseReportForm()
    End Sub

    Private Sub Search_Btn_Click(sender As Object, e As EventArgs) Handles Search_Btn.Click
        loadCaseData(Search_Field.Text.Trim())

    End Sub

    Public Sub loadCaseData(searchQuery As String)
        ' Loop through all open forms in the application to check if the case is already open
        For Each openForm As Form In Application.OpenForms
            ' Check if the current open form is of type CaseRecordShowForm
            If TypeOf openForm Is CaseRecordShowForm Then
                ' Cast the form to CaseRecordShowForm to access its properties and methods
                Dim crsf As CaseRecordShowForm = DirectCast(openForm, CaseRecordShowForm)

                ' Check if the loaded CaseID in the open form matches the one we are searching for
                If crsf.LoadedCaseID = GetCaseIDByName(searchQuery) Then
                    ' Show message box to inform the user
                    MessageBox.Show("This case is already open.", "Case Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' If the case is already open, reload the case data into the form
                    ReloadCaseDataIntoForm(openForm, searchQuery)

                    ' Re-add if it's minimized and hidden
                    If crsf.WindowState = FormWindowState.Minimized OrElse Not crsf.Visible Then

                        ' Make sure the form is visible and restored from minimized state
                        If Not crsf.Visible Then crsf.Show()
                        If crsf.WindowState = FormWindowState.Minimized Then crsf.WindowState = FormWindowState.Normal

                        ' Bring it to front and focus it properly
                        crsf.TopMost = True
                        crsf.BringToFront()
                        crsf.Activate() ' Force it to receive focus
                    End If
                    Return
                End If
            End If
        Next

        ' Prepare the form
        Dim newForm As New CaseRecordShowForm()
        initiateTables(newForm)
        ReloadCaseDataIntoForm(newForm, searchQuery)

        If IsNumeric(newForm.HiddenCaseID.Text.Trim()) Then
            ' Set window state and topmost BEFORE showing
            newForm.WindowState = FormWindowState.Normal
            newForm.TopMost = True

            ' Show as dialog AFTER preparing the form
            newForm.Show()
        End If

    End Sub
    Private Function GetCaseIDByName(caseName As String) As String
        Dim query As String = "SELECT TOP 1 CaseID FROM g3_SpecificCaseDetails WHERE casename = @input OR caseIDString = @input"

        Try
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@input", caseName)

                    conn.Open()
                    Dim result = cmd.ExecuteScalar()

                    If result IsNot Nothing Then
                        Return result.ToString()
                    Else
                        Return ""
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return ""
        End Try
    End Function



    ' This function reloads case data into the form based on a search query.
    Private Sub ReloadCaseDataIntoForm(caseShow As CaseRecordShowForm, searchQuery As String)
        Dim caseDetails As String = ""
        Dim officers As String = ""
        Dim caseIDString As String
        Dim query As String =
"SELECT sd.specificdetails, sd.caseimage, sd.casetype, sd.CaseID, sd.casename, sd.caseIDString, " &
"cr.casestatus, cr.datetimereported, cr.ExpectedDateFinish, cr.Update_DateTime, ap.Photo, ap.Description, ap.PhotoID " &
"FROM g3_SpecificCaseDetails sd " &
"LEFT JOIN g3_CaseRecords cr ON sd.caseID = cr.caseid " &
"LEFT JOIN g3_AdditionalPhotos ap ON sd.caseID = ap.CaseID " &
"WHERE sd.caseIDString LIKE @search OR sd.casename LIKE @search"

        viewer = New ImageViewer

        Try
            Using conn As New SqlConnection(connectionString), cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@search", "%" & searchQuery & "%")
                caseShow.AdditionalPhotos_FlowLayoutPanel.Controls.Clear()

                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If Not reader.HasRows Then Exit Sub

                    caseShow.ItemDescription_DataGridView.Rows.Clear()
                    caseShow.CasePeople_DataGridView1.Rows.Clear()



                    While reader.Read()
                        Dim caseID As Integer = CInt(reader("caseid"))
                        caseShow.HiddenCaseID.Text = caseID
                        caseShow.LoadedCaseID = caseID.ToString()
                        viewer.caseID = caseID.ToString()
                        caseShow.CaseType_TxtBox.Text = reader("casetype").ToString()
                        caseShow.CaseStatus_TxtBox.Text = reader("casestatus").ToString()
                        caseShow.DateAndTimeReported_TxtBox.Text = reader("datetimereported").ToString()
                        caseShow.CaseIDString_TextBox.Text = reader("caseIDString").ToString()
                        caseShow.ExpectedResolveDare_TextBox.Text = reader("ExpectedDateFinish").ToString()
                        caseIDString = reader("caseIDString").ToString()
                        caseShow.oldSpecificCaseDetails = reader("specificdetails")
                        caseShow.oldStatus = reader("casestatus")
                        caseShow.lastUpdatedOn = reader("Update_DateTime").ToString()
                        If reader("casetype") = "Theft" Or reader("casetype") = "Missing Person" Then
                            caseShow.Text = $"| Case Name: {reader("casename")} | {reader("casetype")} |"
                        End If

                        GetReportedBy(caseShow, caseIDString)
                        GetProcedures(caseShow.Procedure_ListView, caseIDString)

                        caseDetails = reader("specificdetails").ToString()
                        Dim specificDetails As String() = caseDetails.Split("|"c)

                        Select Case reader("casetype").ToString()
                            Case "Theft"
                                LoadTheftCase(caseShow, specificDetails, reader("casename").ToString())
                                specificDetails(3) = specificDetails(3).Replace(", ", "^")
                                caseShow.TabControl1.SelectedIndex = 1

                            Case "Missing Person"
                                LoadMissingPersonCase(caseShow, specificDetails, reader("caseimage"), reader("casename").ToString())
                                specificDetails(4) = specificDetails(4).Replace(", ", "^")
                                caseShow.TabControl1.SelectedIndex = 0

                            Case "Others (Please Specify)"
                                LoadOtherCase(caseShow, specificDetails, reader("caseimage"), reader("casename").ToString())
                                If caseShow.CaseType_TxtBox.Text = "Others (Please Specify)" Then
                                    caseShow.SpecificCaseType_ComboBox.Text = specificDetails(0)
                                    caseShow.TabControl1.SelectedIndex = 2
                                End If
                                specificDetails(2) = specificDetails(2).Replace(", ", "^")
                        End Select

                        ' Combine back the array into a string
                        caseDetails = String.Join("|", specificDetails)

                        If Not IsDBNull(reader("Photo")) Then
                            AddPhotoToPanel(caseShow, reader)
                        End If
                    End While
                End Using
            End Using

            ' Load officers if a case ID was found
            If caseShow.HiddenCaseID.Text IsNot Nothing AndAlso IsNumeric(caseShow.HiddenCaseID.Text) Then
                Dim query2 As String = "
            SELECT ocs.officerid, ed.EmployeeName, ed.Position
            FROM g3_OfficerCaseAssignments ocs
            INNER JOIN g4_EmployeeDetails ed ON ocs.officerid = ed.EmployeeID
            WHERE ocs.caseid = @caseid"

                Using conn As New SqlConnection(connectionString)
                    Using cmd As New SqlCommand(query2, conn)
                        cmd.Parameters.AddWithValue("@caseid", CInt(caseShow.HiddenCaseID.Text))
                        caseShow.OldOfficersList = New List(Of String)()
                        conn.Open()
                        Using reader As SqlDataReader = cmd.ExecuteReader()
                            While reader.Read()
                                If Not reader.IsDBNull(0) Then
                                    caseShow.OldOfficersList.Add(reader("officerid")) ' 0 = first column = officerid
                                End If
                            End While
                        End Using
                    End Using
                End Using

                Using conn As New SqlConnection(connectionString)
                    conn.Open()
                    Using cmd As New SqlCommand(query2, conn)
                        cmd.Parameters.AddWithValue("@caseid", Convert.ToInt32(caseShow.HiddenCaseID.Text))

                        Dim adapter As New SqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        table.Reset()
                        adapter.Fill(table)

                        ' Disable auto column generation
                        caseShow.OfficersSent_DataGridView.AutoGenerateColumns = False

                        ' Set DataSource
                        caseShow.OfficersSent_DataGridView.DataSource = table

                        ' Clear and define columns
                        With caseShow.OfficersSent_DataGridView.Columns
                            .Clear()
                            .Add(New DataGridViewTextBoxColumn() With {
                            .Name = "IDColumn",
                            .HeaderText = "Officer ID",
                            .DataPropertyName = "officerid"
                        })
                            .Add(New DataGridViewTextBoxColumn() With {
                            .Name = "NameColumn",
                            .HeaderText = "Officer Name",
                            .DataPropertyName = "EmployeeName"
                        })
                            .Add(New DataGridViewTextBoxColumn() With {
                            .Name = "PositionColumn",
                            .HeaderText = "Position",
                            .DataPropertyName = "Position"
                        })
                        End With
                    End Using
                End Using
            End If

        Catch ex As Exception
            MessageBox.Show($"An error occurred while loading the case data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub GetProcedures(ProcedureListView As ListView, CaseIDString As String)
        Dim query As String = "
    SELECT Procedures, Remarks, DateAndTime, CaseIDString 
    FROM g3_AdditionalProcedures
    WHERE CaseIDString = @CaseIDString"

        Try
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    cmd.Parameters.AddWithValue("@CaseIDString", CaseIDString)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        ' Clear previous items
                        ProcedureListView.Items.Clear()

                        ' Add columns if not already added
                        If ProcedureListView.Columns.Count = 0 Then
                            ProcedureListView.Columns.Add("Procedure", 180, HorizontalAlignment.Left)
                            ProcedureListView.Columns.Add("Remark", 220, HorizontalAlignment.Left)
                            ProcedureListView.Columns.Add("Date And Time", 180, HorizontalAlignment.Left)
                            ProcedureListView.Columns.Add("Case ID", 180, HorizontalAlignment.Left)
                        End If

                        ' Add data to the ListView
                        While reader.Read()
                            Dim item As New ListViewItem(reader("Procedures").ToString())
                            item.SubItems.Add(reader("Remarks").ToString())
                            item.SubItems.Add(Convert.ToDateTime(reader("DateAndTime")).ToString("g"))
                            item.SubItems.Add(reader("CaseIDString").ToString())
                            ProcedureListView.Items.Add(item)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving the procedures: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub GetReportedBy(caseShow As CaseRecordShowForm, caseIDString As String)
        Dim query As String = "
    SELECT c.CallerNumber, c.CallerEmail, CallerFirstName, CallerLastName, bc.ZoneName
    FROM g3_BrgyCallLogs bc
    INNER JOIN g3_Callers c ON bc.CallerID = c.CallerID
    WHERE bc.caseIDString = @CaseIDString"

        Try
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    cmd.Parameters.AddWithValue("@CaseIDString", caseIDString)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            caseShow.FullName_TxtBox.Text = reader("CallerFirstName").ToString() & " " & reader("CallerLastName").ToString()
                            caseShow.Email_textbox.Text = reader("CallerEmail").ToString()
                            caseShow.PhoneNum_TxtBox.Text = reader("CallerNumber").ToString()
                            caseShow.ZoneName_TxtBox.Text = reader("ZoneName").ToString()
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving the caller info: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub LoadTheftCase(caseShow As CaseRecordShowForm, details As String(), caseName As String)
        caseShow.StolenItems_GroupBox.Visible = True
        caseShow.MissingPerson_GroupBox.Visible = False

        caseShow.SuspectDesc_TxtBox.Text = details(0)
        caseShow.PropertyDamage_TextBox.Text = details(1)
        caseShow.StolenItemsCaseName_Label.Text = caseName
        caseShow.TheftLocation_TxtBox.Text = details(3).Replace("^", ", ")
        caseShow.AdditionalInfo_TxtBox.Text = details(4)

        AddItemsToGrid(caseShow.ItemDescription_DataGridView, details(2))
        AddPeopleToGrid(caseShow.CasePeople_DataGridView1, details(5))
    End Sub

    Private Sub LoadMissingPersonCase(caseShow As CaseRecordShowForm, details As String(), caseImageObj As Object, caseName As String)
        caseShow.StolenItems_GroupBox.Visible = False
        caseShow.MissingPerson_GroupBox.Visible = True

        caseShow.MissingPersonCaseName_Label.Text = caseName
        caseShow.MissingPersonName_TxtBox.Text = details(0).Replace("^", " ")
        caseShow.BrthDay_DateTimePicker.Value = DateTime.Parse(details(1))
        ' Calculate the person's age based on the birthdate
        Dim dateString As String = details(1)
        Dim parsedDate As DateTime

        If DateTime.TryParseExact(dateString, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, parsedDate) Then
            caseShow.BrthDay_DateTimePicker.Value = parsedDate
        Else
            MessageBox.Show("Invalid date: " & dateString)
        End If
        Dim age As Integer = DateTime.Now.Year - parsedDate.Year
        ' Adjust the age if the person hasn't had their birthday yet this year
        If DateTime.Now.DayOfYear < parsedDate.DayOfYear Then
            age -= 1
        End If
        ' Set the calculated age to the MissingPersonAge_TxtBox
        caseShow.MissingPersonAge_TxtBox.Text = age.ToString()
        caseShow.MissingPersonHeight_TxtBox.Text = details(2)
        caseShow.MissingPersonPhysicalDesc_TxtBox.Text = details(3)
        caseShow.MissingPersonNo_TxtBox.Text = details(4)
        caseShow.MissingPersonEmail_TxtBox.Text = details(5)
        caseShow.MissingPersonLastSeenLocation_TxtBox.Text = details(6).Replace("^", ", ")
        caseShow.AdditionalInfo_TxtBox.Text = details(7)

        If Not IsDBNull(caseImageObj) Then
            Dim imageBytes As Byte() = DirectCast(caseImageObj, Byte())
            Using ms As New MemoryStream(imageBytes)
                caseShow.MissingPerson_PicBox.Image = Image.FromStream(ms)
            End Using
        End If
        AddPeopleToGrid(caseShow.CasePeople_DataGridView1, details(8))
    End Sub

    Private Sub LoadOtherCase(caseShow As CaseRecordShowForm, details As String(), caseImageObj As Object, casename As String)
        caseShow.StolenItems_GroupBox.Visible = False
        caseShow.MissingPerson_GroupBox.Visible = False
        caseShow.GroupBox2.Visible = True

        caseShow.SpecificCaseType_ComboBox.Text = details(0)
        caseShow.WhatHappened_TextBox.Text = details(1)
        caseShow.GeneralCasesLocation_TextBox.Text = details(2).Replace("^", ", ")
        caseShow.AdditionalInfo_TxtBox.Text = details(3)
        caseShow.GeneralCaseName_Label.Text = casename

        If Not IsDBNull(caseImageObj) Then
            Dim imageBytes As Byte() = DirectCast(caseImageObj, Byte())
            Using ms As New MemoryStream(imageBytes)
                caseShow.GeneralCases_PicBox.Image = Image.FromStream(ms)
            End Using
        End If

        AddPeopleToGrid(caseShow.CasePeople_DataGridView1, details(4))
    End Sub

    Private Sub AddItemsToGrid(grid As DataGridView, raw As String)
        Dim parts = raw.Split("^"c, StringSplitOptions.RemoveEmptyEntries)
        ' Clear existing rows if needed
        grid.Rows.Clear()
        With grid.Columns
            .Clear() ' Clear existing columns
            ' Add Name Column
            .Add("StolenItemName", "Item Name")

            .Add("ItemDesc", "Item Description")

            .Add("Price", "Item Price (P)")
        End With
        For i As Integer = 0 To parts.Length - 1 Step 3
            If i + 2 < parts.Length Then
                grid.Rows.Add(parts(i).Trim(), parts(i + 1).Trim(), parts(i + 2).Trim)
            End If
        Next
    End Sub

    Private Sub AddPeopleToGrid(grid As DataGridView, raw As String)
        ' Split and filter empty entries correctly
        Dim people = raw.Split("^"c, StringSplitOptions.RemoveEmptyEntries)

        ' Clear existing rows if needed
        grid.Rows.Clear()

        ' Ensure correct stepping through the array
        For i As Integer = 0 To people.Length - 1 Step 3
            If i + 2 < people.Length Then
                grid.Rows.Add(people(i).Trim(), people(i + 1).Trim(), people(i + 2).Trim())
            End If
        Next
    End Sub

    Private Sub AddPhotoToPanel(caseShow As CaseRecordShowForm, reader As SqlDataReader)
        Dim bytes As Byte() = DirectCast(reader("Photo"), Byte())
        If bytes.Length = 0 Then Exit Sub

        Dim img As Image
        Using ms As New MemoryStream(bytes)
            img = Image.FromStream(ms)
        End Using

        Dim picBox As New PictureBox With {
        .Width = 149,
        .Height = 121,
        .SizeMode = PictureBoxSizeMode.StretchImage,
        .Image = img,
        .Tag = New Tuple(Of Image, String, Integer)(img, reader("Description").ToString(), CInt(reader("PhotoID")))
    }

        AddHandler picBox.Click, AddressOf caseShow.AdditionalPhoto_Click
        Dim tooltip As New ToolTip()
        tooltip.SetToolTip(picBox, reader("Description").ToString())
        caseShow.AdditionalPhotos_FlowLayoutPanel.Controls.Add(picBox)

    End Sub


    Private Sub initiateTables(caseShow As CaseRecordShowForm)

        ' Define columns for the DataGridView
        With caseShow.CasePeople_DataGridView1.Columns
            .Add("NameColumn", "Person Name")
            .Add("PhoneColumn", "Phone Number")
            .Add("TypeColumn", "Person Type")
        End With

        If caseShow.CaseType_TxtBox.Text = "Theft" Then
            With caseShow.ItemDescription_DataGridView.Columns
                .Clear()
                .Add("StolenItemName", "Item Name")

                .Add("ItemDesc", "Item Description")

                .Add("Price", "Item Price (P)")
            End With

        End If
    End Sub

    Private Sub CaseRecordTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InsertTable()
    End Sub
End Class