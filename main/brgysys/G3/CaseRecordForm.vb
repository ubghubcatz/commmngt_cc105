Imports System.IO
Imports Microsoft.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.ComponentModel
Imports System.DirectoryServices
Imports System.Diagnostics.Eventing.Reader

Public Class CaseRecordForm
    ' Connection string for the database
    Private connectionString As String = "Server=commngtcc105.mssql.somee.com;Database=commngtcc105;
                                   User Id=ublipa_SQLLogin_1;Password=nktg6ikffl;TrustServerCertificate=True;"

    ' Variables for image handling
    Dim mainCaseImagePath As String

    Dim imageBytes As Byte() = Nothing

    Dim hiddenLabel As New Label

    Dim mainForm As g3CommandCenter_Form = Nothing
    Public Property newOfficersList As List(Of String)
    Public Property newSpecificCaseDetails As String
    Public Property procedureCount As Integer
    Public Property newStatus As String

    Public Property OldOfficersList As List(Of String)

    Public Property oldSpecificCaseDetails As String

    Public Property oldProcedures As Integer

    Public Property oldStatus As String

    ' Boolean variable to track validation status
    Dim isValid As Boolean = True
    Dim handlerID As String
    Dim splitString As String()
    ' Case record related objects
    Dim caseRecordTable As CaseRecordTable = Nothing
    Dim caseShow As CaseRecordShowForm = Nothing
    Private employeeNames As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase) ' Prevents duplicates automatically
    Private callers As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
    Private callerDetails As New Dictionary(Of String, (Email As String, Number As String))(StringComparer.OrdinalIgnoreCase)
    Public Property originalCaseStatus
    ' Property to store the loaded case ID
    Public Property LoadedCaseID As String

    Dim caseId As Integer = -1 ' Initialize case ID to -1, which indicates a new case


    ' This method applies styles to DataGridViews, defines columns, and initializes UI elements
    Private Sub CaseRecordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Apply styling to both DataGridViews
        StyleDataGridView(CasePeople_DataGridView1)
        StyleDataGridView(OfficersSent_DataGridView)

        ' Define columns for CasePeople_DataGridView1
        With CasePeople_DataGridView1.Columns
            .Clear() ' Clear existing columns
            .Add("NameColumn", "Person Name")
            .Add("PhoneColumn", "Phone Number")
            .Add("TypeColumn", "Person Type")
        End With

        ' Define columns for OfficersSent_DataGridView
        With OfficersSent_DataGridView.Columns
            .Clear() ' Clear existing columns
            .Add("IDColumn", "Officer ID")
            .Add("NameColumn", "Officer Name")
            .Add("PositionColumn", "Position")
        End With
        ' Trigger case type related UI adjustments
        caseType_Trigger()
        HideTabSelector()
        HandlerResultsListBox.Visible = False
        ListBox1.Visible = False
        ListBox2.Visible = False

        ' Only add columns if none exist
        If Procedure_ListView.Columns.Count = 0 Then
            Procedure_ListView.Columns.Add("Procedure", 180, HorizontalAlignment.Left)
            Procedure_ListView.Columns.Add("Remark", 220, HorizontalAlignment.Left)
            Procedure_ListView.Columns.Add("Date And Time", 180, HorizontalAlignment.Left)
            Procedure_ListView.Columns.Add("Case ID", 180, HorizontalAlignment.Left)
        End If
        Procedure_ListView.Columns(2).Width = 0
        Procedure_ListView.Columns(3).Width = 0
        Procedure_ListView.OwnerDraw = True

    End Sub

    Private Sub Procedure_ListView_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles Procedure_ListView.ColumnWidthChanging
        ' Lock all columns to their current widths
        e.NewWidth = Procedure_ListView.Columns(e.ColumnIndex).Width
        e.Cancel = True
    End Sub

    Private Sub Procedures_ListView_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles Procedure_ListView.DrawColumnHeader
        Using headerFont As New Font("Segoe UI", 10, FontStyle.Bold)
            e.Graphics.FillRectangle(Brushes.DarkGreen, e.Bounds)

            Dim flags As TextFormatFlags = TextFormatFlags.Left Or TextFormatFlags.VerticalCenter Or TextFormatFlags.EndEllipsis

            TextRenderer.DrawText(e.Graphics, e.Header.Text, headerFont, e.Bounds, Color.White, flags)
        End Using
    End Sub


    Private Sub Procedures_ListView_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles Procedure_ListView.DrawItem
        e.DrawDefault = True
    End Sub

    Private Sub Procedures_ListView_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles Procedure_ListView.DrawSubItem
        e.DrawDefault = True
    End Sub

    Private Sub HideTabSelector()
        ' Hide the tab page selector
        SpecificCasesTab.Appearance = TabAppearance.FlatButtons
        SpecificCasesTab.ItemSize = New Size(0, 1) ' Sets the tab headers to zero height
        SpecificCasesTab.SizeMode = TabSizeMode.Fixed ' Ensure the tab size is fixed
        ' Hide the tab page selector
        ReportedBy_TabControl.Appearance = TabAppearance.FlatButtons
        ReportedBy_TabControl.ItemSize = New Size(0, 1) ' Sets the tab headers to zero height
        ReportedBy_TabControl.SizeMode = TabSizeMode.Fixed ' Ensure the tab size is fixed
    End Sub

    Private Sub StyleDataGridView(ByRef dgv As DataGridView)
        With dgv
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ' Fill empty space
            .ReadOnly = True
            .EnableHeadersVisualStyles = False
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Center text
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing ' Disable row header resizing
        End With

        ' Prevent users from adding rows manually
        dgv.AllowUserToAddRows = False

        ' Style column headers
        With dgv.ColumnHeadersDefaultCellStyle
            .BackColor = Color.DarkGreen
            .ForeColor = Color.White
            .Font = New Font(dgv.Font.FontFamily, dgv.Font.Size, FontStyle.Bold)
            .Alignment = DataGridViewContentAlignment.MiddleCenter ' Center headers
        End With

        ' Prevent column resizing
        For Each col As DataGridViewColumn In dgv.Columns
            col.Resizable = DataGridViewTriState.False
        Next
    End Sub


    Private Sub SaveMissingPerson_Btn_Click_1(sender As Object, e As EventArgs) Handles SaveMissingPerson_Btn.Click
        Dim isValidSpecificDetails = VerifySpecificDetails()
        ConditionalChecker()
        caseRecordTable = New CaseRecordTable
        If isValidSpecificDetails Then

            If isValid Then
                For Each f As Form In Application.OpenForms
                    If TypeOf f Is g3CommandCenter_Form Then
                        mainForm = CType(f, g3CommandCenter_Form) ' Assign the already open form to the mainForm variable
                        Exit For
                    End If
                Next
                PermanentlyDeleteMarkedAssignments()
                SaveToCaseRecords()
                updateDate(caseId)
                caseRecordTable.loadCaseData(CaseName_Txt.Text)
                For Each frm As Form In Application.OpenForms
                    If TypeOf frm Is CaseRecordTable Then
                        Dim openForm As CaseRecordTable = CType(frm, CaseRecordTable)
                        openForm.InsertTable()
                        Exit For ' Done! No need to keep looping
                    End If
                Next
                Me.Close()
            End If

        Else
            MessageBox.Show("Inavalid Inputs : (|, ^)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
    Private Sub SaveToCaseRecords()
        Try
            ' Open a connection to the database
            Using con As New SqlConnection(connectionString)
                con.Open()

                ' Check if the case already exists  
                Using cmdCheck As New SqlCommand("
            SELECT caseid FROM g3_CaseRecords 
            WHERE LOWER(LTRIM(RTRIM(casename))) = LOWER(@casename)", con)

                    cmdCheck.Parameters.AddWithValue("@casename", CaseName_Txt.Text.Trim())
                    Dim existingCaseId As Object = cmdCheck.ExecuteScalar()
                    If existingCaseId IsNot Nothing Then
                        caseId = Convert.ToInt32(existingCaseId) ' Store the existing case ID  
                    End If
                End Using

                ' Insert a new case if it doesn't exist, otherwise update the existing case  
                If caseId = -1 Then
                    Using cmdAdd As New SqlCommand("
                INSERT INTO g3_CaseRecords (casename, casestatus, datetimereported, ExpectedDateFinish)
                OUTPUT INSERTED.caseid
                VALUES (@casename, @casestatus, @datetimereported, @ExpectedDateFinish)", con)

                        cmdAdd.Parameters.AddWithValue("@casename", CaseName_Txt.Text.Trim())
                        cmdAdd.Parameters.AddWithValue("@casestatus", CaseStatus_ComboBox.SelectedItem.ToString())
                        cmdAdd.Parameters.AddWithValue("@datetimereported", DateAndimeReported_DateTimePicker.Value)
                        cmdAdd.Parameters.AddWithValue("@ExpectedDateFinish", ExpectedFinish_DateTimePicker.Value)
                        caseId = Convert.ToInt32(cmdAdd.ExecuteScalar()) ' Retrieve the inserted case ID  
                    End Using
                Else
                    Using cmdUpdate As New SqlCommand("
    UPDATE g3_CaseRecords
    SET 
        casestatus = @casestatus,
        datetimereported = @datetimereported,
        ExpectedDateFinish = @ExpectedDateFinish,
        ResolvedDate = CASE 
                          WHEN @casestatus = 'Resolved' THEN @ResolvedDate
                          ELSE ResolvedDate
                       END
    WHERE caseid = @caseid", con)


                        cmdUpdate.Parameters.AddWithValue("@casestatus", CaseStatus_ComboBox.SelectedItem.ToString())
                        cmdUpdate.Parameters.AddWithValue("@datetimereported", DateAndimeReported_DateTimePicker.Value)
                        cmdUpdate.Parameters.AddWithValue("@ExpectedDateFinish", ExpectedFinish_DateTimePicker.Value)
                        cmdUpdate.Parameters.AddWithValue("@ResolvedDate", DateTime.Now)
                        cmdUpdate.Parameters.AddWithValue("@caseid", caseId)

                        cmdUpdate.ExecuteNonQuery() ' Update the existing case record  
                    End Using
                End If

                ' Save additional details if a valid case ID was obtained  
                If caseId <> -1 Then
                    SaveSpecificCaseDetails(caseId) ' Save specific case details
                    SaveAdditionalPhotos(caseId) ' Save related case photos  

                    ' Assign officers to the case  
                    For Each row As DataGridViewRow In OfficersSent_DataGridView.Rows
                        If Not row.IsNewRow Then
                            Dim officerId As String = row.Cells("IDColumn").Value.ToString().Trim()

                            If Not OfficerAlreadyAssigned(officerId, caseId) Then
                                InsertOfficerAssignment(officerId, caseId) ' Assign officer if not already assigned  
                            End If
                        End If
                    Next
                Else
                    MessageBox.Show("Failed to retrieve or insert case. No actions were saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving the case: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub updateDate(caseId As Integer)
        ' Build the new officers list
        newOfficersList = New List(Of String)
        newOfficersList.Clear() ' Make sure the list is empty before filling it
        For Each row As DataGridViewRow In OfficersSent_DataGridView.Rows
            If Not row.IsNewRow Then
                Dim cellValue As String = row.Cells(0).Value?.ToString()
                newOfficersList.Add(cellValue)
            End If
        Next

        ' Other updates
        procedureCount = Procedure_ListView.Items.Count
        newSpecificCaseDetails = BuildSpecificCaseDetails()
        newStatus = CaseStatus_ComboBox.SelectedItem.ToString()

        ' Now update the Update_DateTime in database
        Dim query As String = "
    UPDATE g3_CaseRecords
    SET Update_DateTime = @date
    WHERE CaseID = @caseId"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                If Not newOfficersList.SequenceEqual(OldOfficersList) Or procedureCount <> oldProcedures Or newStatus <> oldStatus Or newSpecificCaseDetails <> oldSpecificCaseDetails Then
                    cmd.Parameters.AddWithValue("@caseId", caseId)
                    cmd.Parameters.AddWithValue("@date", DateTime.Now)
                Else
                    cmd.Parameters.AddWithValue("@caseId", caseId)
                    cmd.Parameters.AddWithValue("@date", DateAndimeReported_DateTimePicker.Value)
                End If
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub SaveToMainFormIfExists(caseRecordTable As CaseRecordTable)
        If caseRecordTable IsNot Nothing AndAlso Not mainForm.IsDisposed Then
            caseRecordTable.InsertTable()
        End If
    End Sub

    Private Sub SaveSpecificCaseDetails(caseId As Integer)
        Try
            Dim specificCaseDetails As String = BuildSpecificCaseDetails()
            If specificCaseDetails Is Nothing Then Exit Sub ' Exit if no details are provided  

            Using con As New SqlConnection(connectionString)
                con.Open()

                Dim query As String
                Dim isExisting As Boolean

                ' Check if specific case details already exist for the given caseId  
                Using cmdCheck As New SqlCommand("
                SELECT COUNT(*) FROM g3_SpecificCaseDetails WHERE caseid = @caseid", con)

                    cmdCheck.Parameters.AddWithValue("@caseid", caseId)
                    isExisting = Convert.ToInt32(cmdCheck.ExecuteScalar()) > 0 ' Record exists if count > 0  
                End Using

                ' Construct the appropriate query based on whether the record exists  
                If isExisting Then
                    query = "UPDATE g3_SpecificCaseDetails 
                         SET casename = @casename, 
                             specificdetails = @specificdetails
                         WHERE caseid = @caseid"
                Else
                    query = "INSERT INTO g3_SpecificCaseDetails (caseid, casename, casetype, specificdetails, caseimage, CaseIDString) 
                         VALUES (@caseid, @casename, @casetype, @specificdetails, @caseimage, @CaseIDString)"
                End If

                Dim dateReported As String = DateAndimeReported_DateTimePicker.Value.ToString("MM/dd/yyyy")
                Dim paddedCaseId As String = caseId.ToString("D4")
                Dim caseIdString As String = $"Case-{dateReported}-{paddedCaseId}"
                SaveProcedures(caseIdString)

                ' Execute the INSERT or UPDATE query  
                Using cmd As New SqlCommand(query, con)
                    ' Only add parameters needed for the current query
                    cmd.Parameters.AddWithValue("@caseid", caseId)
                    cmd.Parameters.AddWithValue("@casename", CaseName_Txt.Text.Trim())
                    cmd.Parameters.AddWithValue("@specificdetails", specificCaseDetails)

                    If Not isExisting Then
                        cmd.Parameters.AddWithValue("@casetype", CaseType_ComboBox.Text.Trim())
                        If imageBytes IsNot Nothing Then
                            cmd.Parameters.Add("@caseimage", SqlDbType.VarBinary).Value = imageBytes
                        Else
                            cmd.Parameters.Add("@caseimage", SqlDbType.VarBinary).Value = DBNull.Value
                        End If
                        cmd.Parameters.AddWithValue("@CaseIDString", caseIdString)
                    End If
                    Dim splitHandler As String() = Handled_TxtBox.Text.Trim().Split(" | ")
                    If ReportedBy_TabControl.SelectedIndex = 0 Then
                        Call_Log.SaveDataToCallersTables(PhoneNum_TxtBox.Text.Trim(), splitHandler(1), "Responded", "Incoming",
                                                 DateAndimeReported_DateTimePicker.Value, "Reported A Case", Purok_Picker.SelectedItem.ToString(), splitHandler(0),
                                                 CommType_ComboBox.SelectedItem.ToString(), FirstName_TxtBox.Text.Trim(), LastName_TxtBox.Text.Trim(),
                                                 Email_TextBox.Text.Trim(), caseIdString)
                    End If

                    cmd.ExecuteNonQuery()
                End Using

                ' Update the case image if a record already exists and a new image is provided  
                If isExisting AndAlso imageBytes IsNot Nothing Then
                    Using cmdImg As New SqlCommand("
                    UPDATE g3_SpecificCaseDetails 
                    SET caseimage = @caseimage 
                    WHERE caseid = @caseid", con)

                        cmdImg.Parameters.AddWithValue("@caseid", caseId)
                        If imageBytes IsNot Nothing Then
                            cmdImg.Parameters.Add("@caseimage", SqlDbType.VarBinary).Value = imageBytes
                        Else
                            cmdImg.Parameters.Add("@caseimage", SqlDbType.VarBinary).Value = DBNull.Value
                        End If
                        cmdImg.ExecuteNonQuery()
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving specific case details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SaveProcedures(caseIDString As String)
        Try
            Dim query As String = "INSERT INTO g3_AdditionalProcedures (caseIDString, Procedures, Remarks, DateAndTime) " &
                                "VALUES (@caseIDString, @Procedures, @Remarks, @DateAndTime)"

            Using con As New SqlConnection(connectionString)
                con.Open()
                Using cmd As New SqlCommand(query, con)

                    For Each item As ListViewItem In Procedure_ListView.Items
                        Dim procedure As String = item.SubItems(0).Text
                        Dim remark As String = item.SubItems(1).Text
                        Dim dateTimeValue As DateTime = DateTime.Now
                        Dim caseID As String = caseIDString

                        ' Insert if it doesn't exist
                        If item.SubItems(2).Text = "none" Then
                            Using cmdInsert As New SqlCommand(query, con)
                                cmdInsert.Parameters.AddWithValue("@caseIDString", caseID)
                                cmdInsert.Parameters.AddWithValue("@Procedures", procedure)
                                cmdInsert.Parameters.AddWithValue("@Remarks", remark)
                                cmdInsert.Parameters.AddWithValue("@DateAndTime", dateTimeValue)

                                cmdInsert.ExecuteNonQuery()
                            End Using
                        End If
                    Next
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving procedures: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function ContainsInvalidCharacters(ByVal input As String) As Boolean
        Return input.Any(Function(c) c = "^"c OrElse c = "|"c)
    End Function

    Private Function BuildSpecificCaseDetails() As String
        ' Gather people-related information from CasePeople_DataGridView
        Dim people As String = String.Join("", CasePeople_DataGridView1.Rows.
        Cast(Of DataGridViewRow)().
        Where(Function(r) Not r.IsNewRow).
        Select(Function(r) $"{r.Cells("NameColumn").Value}^{r.Cells("PhoneColumn").Value}^{r.Cells("TypeColumn").Value}^"))

        Select Case CaseType_ComboBox.SelectedIndex
            Case 1 ' Missing Person Case
                Dim fullNam As String = MissingPersonFirstName_TxtBox.Text.Trim() + "^" + MissingPersonLastName_TxtBox.Text.Trim()

                Return String.Join("|", {
                fullNam,
                BrthDay_DateTimePicker.Value.ToString("MM/dd/yyyy"),
                MissingPersonHeight_TxtBox.Text.Trim(),
                MissingPersonPhysicalDesc_TxtBox.Text.Trim(),
                MissingPersonNo_TxtBox.Text.Trim(),
                MissingPersonEmail_TxtBox.Text.Trim(),
                $"{MissingPersonLastSeenStreet_TxtBox.Text.Trim()}^{MissingPersonLastSeenBrgy_TxtBox.Text.Trim()}^{MissingPersonLastSeenCity_TxtBox.Text.Trim()}",
                If(String.IsNullOrEmpty(AdditionalInfo_TxtBox.Text.Trim()), " ", AdditionalInfo_TxtBox.Text.Trim()),
                people
            })

            Case 0 ' Theft Case
                Dim ItemDetails As String = String.Join("", ItemDescription_DataGridView.Rows.
                Cast(Of DataGridViewRow)().
            Where(Function(r) Not r.IsNewRow).
            Select(Function(r) $"{r.Cells("StolenItemName").Value}^{r.Cells("ItemDesc").Value}^{r.Cells("Price").Value}^"))

                Return String.Join("|", {
                SuspectDesc_TxtBox.Text.Trim(),
                PropertyDamage_TextBox.Text,
                ItemDetails,
                $"{StreetTheftLocation_TxtBox.Text.Trim()}^{BrgyTheftLocation_TxtBox.Text.Trim()}^{CityTheftLocation_TxtBox.Text.Trim()}",
                If(String.IsNullOrEmpty(AdditionalInfo_TxtBox.Text.Trim()), " ", AdditionalInfo_TxtBox.Text.Trim()),
                people
            })

            Case 2 ' General Case
                Return String.Join("|", {
                SpecificCaseType_ComboBox.SelectedItem?.ToString().Trim(),
                WhatHappened_TextBox.Text.Trim(),
                $"{GeneralCasesStreet_TextBox.Text.Trim()}^{GeneralCasesBrgy_TextBox.Text.Trim()}^{GeneralCasesCity_TextBox.Text.Trim()}",
                If(String.IsNullOrEmpty(AdditionalInfo_TxtBox.Text.Trim()), " ", AdditionalInfo_TxtBox.Text.Trim()),
                people
            })
        End Select

        Return ""
    End Function

    Private Function VerifySpecificDetails() As Boolean
        ' Gather people-related information
        Dim people As String = String.Join("", CasePeople_DataGridView1.Rows.
        Cast(Of DataGridViewRow)().
        Where(Function(r) Not r.IsNewRow).
        Select(Function(r) $"{r.Cells("NameColumn").Value}{r.Cells("PhoneColumn").Value}{r.Cells("TypeColumn").Value}"))

        Dim concatenatedString As String = ""

        Select Case CaseType_ComboBox.SelectedIndex
            Case 1 ' Missing Person Case
                concatenatedString = String.Join("", {
                MissingPersonFirstName_TxtBox.Text.Trim(),
               BrthDay_DateTimePicker.Value.ToString("MM/dd/yyyy"),
                MissingPersonHeight_TxtBox.Text.Trim(),
                MissingPersonPhysicalDesc_TxtBox.Text.Trim(),
                MissingPersonNo_TxtBox.Text.Trim(),
                MissingPersonEmail_TxtBox.Text.Trim(),
                MissingPersonLastSeenStreet_TxtBox.Text.Trim(),
                MissingPersonLastSeenBrgy_TxtBox.Text.Trim(),
                MissingPersonLastSeenCity_TxtBox.Text.Trim(),
                AdditionalInfo_TxtBox.Text.Trim(),
                people
            })

            Case 0 ' Theft Case
                Dim ItemDetails As String = String.Join("", ItemDescription_DataGridView.Rows.
        Cast(Of DataGridViewRow)().
        Where(Function(r) Not r.IsNewRow).
        Select(Function(r) $"{r.Cells("StolenItemName").Value}{r.Cells("ItemDesc").Value}{r.Cells("Price").Value}"))

                concatenatedString = String.Join("", {
                SuspectDesc_TxtBox.Text.Trim(),
                PropertyDamage_TextBox.Text,
                ItemDetails,
                StreetTheftLocation_TxtBox.Text.Trim(),
                BrgyTheftLocation_TxtBox.Text.Trim(),
                CityTheftLocation_TxtBox.Text.Trim(),
                AdditionalInfo_TxtBox.Text.Trim(),
                people
            })

            Case 2 ' General Case
                concatenatedString = String.Join("", {
                SpecificCaseType_ComboBox.SelectedItem?.ToString().Trim(),
                WhatHappened_TextBox.Text.Trim(),
                GeneralCasesStreet_TextBox.Text.Trim(),
                GeneralCasesBrgy_TextBox.Text.Trim(),
                GeneralCasesCity_TextBox.Text.Trim(),
                AdditionalInfo_TxtBox.Text.Trim(),
                people
            })
        End Select

        ' Check for invalid characters in concatenatedString
        Return Not ContainsInvalidCharacters(concatenatedString)
    End Function

    Private Sub InsertOfficerAssignment(officerId As String, caseId As Integer)
        Try
            ' Check if the officer is already assigned to this case
            If OfficerAlreadyAssigned(officerId, caseId) Then Exit Sub

            Using con As New SqlConnection(connectionString)
                con.Open()

                ' === Insert Officer Assignment into Database ===
                Dim queryInsert As String = "INSERT INTO g3_OfficerCaseAssignments (officerid, caseid, assigneddatetime)
                                         VALUES (@officerid, @caseid, @assigneddatetime)"
                Using insertCmd As New SqlCommand(queryInsert, con)
                    ' Add parameters to prevent SQL injection
                    insertCmd.Parameters.AddWithValue("@officerid", officerId)
                    insertCmd.Parameters.AddWithValue("@caseid", caseId)
                    insertCmd.Parameters.AddWithValue("@assigneddatetime", DateTime.Now)

                    insertCmd.ExecuteNonQuery()
                    MessageBox.Show("Officer successfully assigned.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while assigning the officer: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub DeleteOfficerAssignment(officerId As String, caseId As Integer)
        Try
            Dim query As String = "UPDATE g3_OfficerCaseAssignments SET IsDeleted = 1 WHERE officerid = @officerid AND caseid = @caseid"

            Using con As New SqlConnection(connectionString),
              cmd As New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@officerid", officerId)
                cmd.Parameters.AddWithValue("@caseid", caseId)

                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting the officer assignment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PermanentlyDeleteMarkedAssignments()
        Try
            Dim query As String = "DELETE FROM g3_OfficerCaseAssignments WHERE IsDeleted = 1"

            Using con As New SqlConnection(connectionString),
              cmd As New SqlCommand(query, con)

                con.Open()
                cmd.ExecuteNonQuery()
                ' Step 2: Remove rows from the DataGridView that are marked (e.g., light red background)
                For i As Integer = OfficersSent_DataGridView.Rows.Count - 1 To 0 Step -1
                    Dim row As DataGridViewRow = OfficersSent_DataGridView.Rows(i)
                    If row.DefaultCellStyle.BackColor = Color.LightCoral Then
                        OfficersSent_DataGridView.Rows.RemoveAt(i)
                    End If
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while permanently deleting officer assignments: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ExecuteScalarQuery(query As String, parameters As Dictionary(Of String, Object)) As Object
        Try
            Using con As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, con)
                    ' Dynamically add parameters to prevent SQL injection
                    For Each param In parameters
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next

                    con.Open()
                    Return cmd.ExecuteScalar()
                End Using
            End Using
        Catch ex As SqlException
            ' Handle database-specific errors
            MessageBox.Show("Database error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Catch ex As Exception
            ' Handle general errors
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Private Function OfficerAlreadyAssigned(officerId As String, caseId As Integer) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM g3_OfficerCaseAssignments WHERE officerid = @officerid AND caseid = @caseid"
            Dim count As Integer = Convert.ToInt32(ExecuteScalarQuery(query, New Dictionary(Of String, Object) From {
            {"@officerid", officerId},
            {"@caseid", caseId}
        }))
            Return count > 0
        Catch ex As Exception
            ' Handle errors if ExecuteScalarQuery fails
            MessageBox.Show("An error occurred while checking officer assignment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False ' Defaulting to False in case of error, as the officer assignment check cannot be performed
        End Try
    End Function


    Private Sub SaveAdditionalPhotos(caseId As Integer)
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()

                ' Loop through all PictureBox controls in the FlowLayoutPanel
                For Each pb As PictureBox In AdditionalPhotos_FlowLayoutPanel.Controls.OfType(Of PictureBox)()
                    If pb.Image IsNot Nothing Then
                        Try
                            ' Convert image to byte array
                            Dim photoBytes As Byte() = ImageToByteArray(pb.Image)

                            ' Extract description if available
                            Dim description As String = If(pb.Tag IsNot Nothing AndAlso TypeOf pb.Tag Is Tuple(Of Image, String, Integer),
                                                       CType(pb.Tag, Tuple(Of Image, String, Integer)).Item2, "")

                            ' Check if the photo already exists in the database
                            If ExecuteScalarQuery("SELECT 1 FROM g3_AdditionalPhotos WHERE CaseID = @caseid AND Photo = @photo",
                                              New Dictionary(Of String, Object) From {{"@caseid", caseId}, {"@photo", photoBytes}}) Is Nothing Then
                                ' Insert new photo into the database
                                Using cmd As New SqlCommand("INSERT INTO g3_AdditionalPhotos (CaseID, Photo, Description) VALUES (@caseid, @photo, @description)", con)
                                    cmd.Parameters.AddWithValue("@caseid", caseId)
                                    cmd.Parameters.AddWithValue("@photo", photoBytes)
                                    cmd.Parameters.AddWithValue("@description", description)
                                    cmd.ExecuteNonQuery()
                                End Using
                            End If
                        Catch ex As Exception
                            ' Log or show error for each individual photo
                            Console.WriteLine("Error saving photo: " & ex.Message)
                        End Try
                    End If
                Next
            End Using
        Catch ex As SqlException
            ' Handle SQL-related exceptions (database errors)
            MessageBox.Show("Database error while saving photos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            ' Handle any other general exceptions
            MessageBox.Show("An error occurred while saving photos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub OfficersSent_DataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles OfficersSent_DataGridView.CellDoubleClick
        ' Ensure a valid row is double-clicked
        If e.RowIndex >= 0 Then
            ' Get the selected row and officer information
            Dim selectedRow = OfficersSent_DataGridView.Rows(e.RowIndex)
            Dim officerId = selectedRow.Cells(0).Value.ToString
            Dim officerName = selectedRow.Cells(1).Value.ToString

            ' Prompt the user to confirm the removal of the officer
            Dim result = MessageBox.Show("Are you sure you want to remove " & officerName & "?", "Confirm Deletion",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' If caseID_Label is empty, just remove the officer from the grid
                If String.IsNullOrEmpty(caseID_Label.Text) Then
                    ' Find the index of the officer to remove
                    OfficersSent_DataGridView.Rows.RemoveAt(e.RowIndex)

                Else
                    ' If case ID exists, check if the officer is assigned to the case and delete from the database
                    If OfficerAlreadyAssigned(officerId, caseID_Label.Text) Then
                        ' Mark the row with a light red background instead of removing it
                        selectedRow.DefaultCellStyle.BackColor = Color.LightCoral
                        DeleteOfficerAssignment(officerId, caseID_Label.Text)
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub ItemDescription_DataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemDescription_DataGridView.CellDoubleClick
        ' Ensure a valid row is double-clicked
        If e.RowIndex >= 0 Then
            ' Get the selected row and item information
            Dim selectedRow = ItemDescription_DataGridView.Rows(e.RowIndex)
            Dim itemName = selectedRow.Cells(0).Value.ToString

            ' Prompt the user to confirm the removal of the item
            Dim result = MessageBox.Show("Are you sure you want to remove " & itemName & "?", "Confirm Deletion",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Remove the item from the grid
                ItemDescription_DataGridView.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub CasePeople_DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles CasePeople_DataGridView1.CellDoubleClick
        ' Ensure a valid row is double-clicked
        If e.RowIndex >= 0 Then
            ' Get the selected row and person information
            Dim selectedRow = CasePeople_DataGridView1.Rows(e.RowIndex)
            Dim personName = selectedRow.Cells(0).Value.ToString

            ' Prompt the user to confirm the removal of the person
            Dim result = MessageBox.Show("Are you sure you want to remove " & personName & "?", "Confirm Deletion",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' If caseID_Label is empty, just remove the person from the grid
                If String.IsNullOrEmpty(caseID_Label.Text) Then
                    CasePeople_DataGridView1.Rows.RemoveAt(e.RowIndex)
                End If
            End If
        End If
    End Sub


    ' Function to convert an image to a byte array.
    ' This function saves the image in its original format (JPEG, PNG, GIF, BMP, TIFF) and returns its byte array representation.
    Private Function ImageToByteArray(img As Image) As Byte()
        ' Check if the image is null. If it is, throw an exception.

        Using ms As New MemoryStream()
            ' Determine the image format and save the image in the correct format to the MemoryStream.
            ' This supports JPEG, PNG, GIF, BMP, TIFF formats.
            If img.RawFormat.Equals(Imaging.ImageFormat.Jpeg) Then
                img.Save(ms, Imaging.ImageFormat.Jpeg)
            ElseIf img.RawFormat.Equals(Imaging.ImageFormat.Png) Then
                img.Save(ms, Imaging.ImageFormat.Png)
            ElseIf img.RawFormat.Equals(Imaging.ImageFormat.Gif) Then
                img.Save(ms, Imaging.ImageFormat.Gif)
            ElseIf img.RawFormat.Equals(Imaging.ImageFormat.Bmp) Then
                img.Save(ms, Imaging.ImageFormat.Bmp)
            ElseIf img.RawFormat.Equals(Imaging.ImageFormat.Tiff) Then
                img.Save(ms, Imaging.ImageFormat.Tiff)
            Else
                ' If the image format is unknown, save it as a JPEG by default.
                img.Save(ms, Imaging.ImageFormat.Jpeg)
            End If

            ' Reset the position of the MemoryStream so it can be read from the beginning.
            ms.Position = 0

            ' Return the image as a byte array.
            Return ms.ToArray()
        End Using
    End Function



    ' Method to select an image file and process it for the specified PictureBox.
    ' This method allows the user to select an image, compress it, and display it in the provided PictureBox.
    Private Sub SelectAndProcessImage(ByVal pictureBox As PictureBox, ByRef imageBytes As Byte(), ByRef imagePath As String)
        Using ofd As New OpenFileDialog
            ' Filter to only allow image file selection (JPG, JPEG, PNG, BMP).
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

            ' Show the open file dialog to select an image.
            If ofd.ShowDialog() = DialogResult.OK Then
                ' Store the selected file's path.
                imagePath = ofd.FileName

                ' Compress the image and convert it to a byte array.
                imageBytes = CompressImage(imagePath, 50L) ' Compress image to 50% quality.

                ' Load and display the selected image in the specified PictureBox.
                pictureBox.Image = Image.FromFile(imagePath)
            Else
                ' If the user cancels the selection, display a message box.
                MessageBox.Show("No image selected.")
            End If
        End Using
    End Sub

    ' This function reduces the image quality to the specified level and converts it to a byte array.
    Private Function CompressImage(imagePath As String, quality As Long) As Byte()
        ' Initialize an empty byte array to store the compressed image data.
        Dim imageBytes As Byte() = Nothing

        Using img As Image = Image.FromFile(imagePath)
            ' Get the JPEG encoder (used for compressing the image).
            Dim jpgEncoder As ImageCodecInfo = ImageCodecInfo.GetImageEncoders().FirstOrDefault(Function(codec) codec.FormatID = ImageFormat.Jpeg.Guid)

            ' If a JPEG encoder is found, use it to compress the image.
            If jpgEncoder IsNot Nothing Then
                ' Set up the encoder parameters to specify the quality of the image.
                Dim encoderParams As New EncoderParameters(1)
                encoderParams.Param(0) = New EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality)

                ' Compress the image and save it to a MemoryStream.
                Using ms As New MemoryStream()
                    img.Save(ms, jpgEncoder, encoderParams)

                    ' Convert the compressed image to a byte array.
                    imageBytes = ms.ToArray()
                End Using
            End If
        End Using

        ' Return the byte array of the compressed image.
        Return imageBytes
    End Function

    ' It allows the user to select an image, compress it, and display it in the PictureBox.
    Private Sub MissingPerson_PicBox_Click(sender As Object, e As EventArgs) Handles MissingPerson_PicBox.Click
        ' Call the method to allow the user to select and process the image for the MissingPerson_PicBox.
        imageBytes = ImageToByteArray(MissingPerson_PicBox.Image)
        SelectAndProcessImage(MissingPerson_PicBox, imageBytes, mainCaseImagePath)
    End Sub

    ' It allows the user to select an image, compress it, and display it in the PictureBox.
    Private Sub generalCases_PicBox_Click(sender As Object, e As EventArgs) Handles generalCases_PicBox.Click
        ' Call the method to allow the user to select and process the image for the generalCases_PicBox.
        imageBytes = ImageToByteArray(generalCases_PicBox.Image)
        SelectAndProcessImage(generalCases_PicBox, imageBytes, mainCaseImagePath)
    End Sub

    Private Sub CaseType_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CaseType_ComboBox.SelectedIndexChanged
        caseType_Trigger()
    End Sub


    Private Sub LoadEmployeeNamesByPrefix(employeePrefix As String)
        Try
            Using con As New SqlConnection(connectionString),
              cmd As New SqlCommand("SELECT FirstName, LastName, EmployeeID FROM g4_EmployeesInfo WHERE EmployeeID LIKE @Prefix + '%'", con)
                cmd.Parameters.AddWithValue("@Prefix", employeePrefix)

                con.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    ' Clear the list before adding new names
                    employeeNames.Clear()

                    While reader.Read()
                        employeeNames.Add($"{reader("EmployeeID")} | {reader("FirstName")} {reader("LastName")}")
                    End While
                End Using
            End Using
        Catch ex As SqlException
            ' Handle SQL-related errors
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            ' Handle general errors
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub FirstName_TxtBox_TextChanged(sender As Object, e As EventArgs) Handles FirstName_TxtBox.TextChanged
        Call_Log.FilterCallersByName(FirstName_TxtBox, ListBox1, closeFirstName)
    End Sub

    Private Sub LastName_TxtBox_TextChanged(sender As Object, e As EventArgs) Handles LastName_TxtBox.TextChanged
        Call_Log.FilterCallersByName(LastName_TxtBox, ListBox2, closeLastName)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Call_Log.PopulateCallerDetailsFromListBox(ListBox1.SelectedItem, Email_TextBox, PhoneNum_TxtBox, FirstName_TxtBox, LastName_TxtBox)
        ListBox2.Visible = False
        ListBox1.Visible = False
        closeLastName.Visible = False
        closeFirstName.Visible = False
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        Call_Log.PopulateCallerDetailsFromListBox(ListBox2.SelectedItem, Email_TextBox, PhoneNum_TxtBox, FirstName_TxtBox, LastName_TxtBox)
        ListBox2.Visible = False
        ListBox1.Visible = False
        closeLastName.Visible = False
        closeFirstName.Visible = False
    End Sub

    Private Sub HandlerResultsListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles HandlerResultsListBox.SelectedIndexChanged
        If HandlerResultsListBox.SelectedItem IsNot Nothing Then
            Handled_TxtBox.Text = HandlerResultsListBox.SelectedItem.ToString
            splitString = Handled_TxtBox.Text.Split(" | ")
            handlerID = splitString(0)
            HandlerResultsListBox.Visible = False
        End If
    End Sub

    Private Sub Handled_TxtBox_TextChanged(sender As Object, e As EventArgs) Handles Handled_TxtBox.TextChanged
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

    ' If the form of type T is already open, it brings it to the front; otherwise, it creates a new instance.
    Private Sub ShowSingleInstance(Of T As {Form, New})()
        ' Loop through the controls on the current form and check if any is of type T
        For Each ctrl As Control In Controls
            If TypeOf ctrl Is T Then
                ' If the form is already open, bring it to the front and exit
                ctrl.BringToFront()
                Return ' No need to add the form again if it is already open
            End If
        Next

        ' If no instance of the form is found, create a new one
        Dim formInstance As New T With {
        .TopLevel = False,  ' The form will not be a top-level window (i.e., it will be embedded in the parent form)
        .Location = New Point(0, 0) ' Set the location of the form within the parent form
    }

        ' Add the form as a control to the parent form
        Controls.Add(formInstance)
        formInstance.BringToFront() ' Bring the new form to the front
        formInstance.Show() ' Show the form
    End Sub

    ' It shows the AdditionalPhotoForm if it's not already open.
    Private Sub AddAdditionalPhoto_Btn_Click(sender As Object, e As EventArgs) Handles AddAdditionalPhoto_Btn.Click
        ShowSingleInstance(Of AdditionalPhotoForm)()
    End Sub

    ' It shows the AddPersonInvolvedFormvb if it's not already open.
    Private Sub AddPerson_Btn_Click(sender As Object, e As EventArgs) Handles AddPerson_Btn.Click
        ShowSingleInstance(Of AddPersonInvolvedFormvb)()
    End Sub

    ' It shows the AddOfficersForm if it's not already open.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowSingleInstance(Of AddOfficersForm)()
    End Sub

    ' It shows the AddStolenItemsForm if it's not already open.
    Private Sub AddStolenItem_Btn_Click(sender As Object, e As EventArgs) Handles AddStolenItem_Btn.Click
        ShowSingleInstance(Of AddStolenItemsForm)()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ShowSingleInstance(Of AddProcedure)()
    End Sub
    ' Public method that adds a PictureBox control with an image and description to the AdditionalPhotos FlowLayoutPanel.
    Public Sub AddAditionalPicture(image As Image, desc As String)
        ' Create a new instance of CaseRecordShowForm (or reuse an existing one)
        caseShow = New CaseRecordShowForm()

        ' Create a new PictureBox to display the image
        Dim additionalPhoto As New PictureBox
        additionalPhoto.SizeMode = PictureBoxSizeMode.StretchImage ' Set the image size mode to zoom
        additionalPhoto.Width = 149 ' Set the width of the PictureBox
        additionalPhoto.Height = 121 ' Set the height of the PictureBox
        additionalPhoto.Image = image ' Set the image in the PictureBox
        additionalPhoto.Tag = New Tuple(Of Image, String, Integer)(image, desc, -1) ' Store the image and description in the Tag property

        ' Add an event handler for double-clicking the PictureBox
        AddHandler additionalPhoto.DoubleClick, AddressOf caseShow.AdditionalPhoto_DoubleClick

        ' Add the PictureBox to the AdditionalPhotos FlowLayoutPanel on the form
        AdditionalPhotos_FlowLayoutPanel.Controls.Add(additionalPhoto)
    End Sub


    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If CaseStatus_ComboBox.SelectedIndex = 1 Then
            If OfficersSent_DataGridView.Rows.Count <= 0 Then
                MessageBox.Show("Please ensure officers are assigned or update the case status.")
                e.Cancel = True ' This stops the form from closing
                Return
            End If
        End If
    End Sub

    ' === Helper function for displaying error messages ===
    Private Sub ShowError(msg As String)
        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        isValid = False
    End Sub
    Private Sub caseType_Trigger()

        If CaseType_ComboBox.SelectedIndex = -1 Then
            SpecificCasesTab.Visible = False
        ElseIf CaseType_ComboBox.SelectedIndex = 0 Then
            StyleDataGridView(ItemDescription_DataGridView)
            With ItemDescription_DataGridView.Columns
                .Clear() ' Clear existing columns
                ' Add Name Column
                .Add("StolenItemName", "Item Name")

                .Add("ItemDesc", "Item Description")

                .Add("Price", "Item Price (P)")
            End With
            SpecificCasesTab.Visible = True
            SpecificCasesTab.SelectedIndex = 0
        ElseIf CaseType_ComboBox.SelectedIndex = 1 Then
            SpecificCasesTab.Visible = True
            SpecificCasesTab.SelectedIndex = 2
        ElseIf CaseType_ComboBox.SelectedIndex = 2 Then
            SpecificCasesTab.Visible = True
            SpecificCasesTab.SelectedIndex = 1
        End If
    End Sub
    Private Sub ConditionalChecker()
        isValid = True ' Assume valid unless proven otherwise

        ' === Basic Validations ===
        If String.IsNullOrWhiteSpace(CaseName_Txt.Text) Then ShowError("Case name is required.")
        If CaseType_ComboBox.SelectedIndex = -1 Then ShowError("Please select a case type.")
        If CaseStatus_ComboBox.SelectedIndex = -1 Then ShowError("Please select a case status.")
        If DateAndimeReported_DateTimePicker.Value > DateTime.Now Then ShowError("Reported date cannot be in the future.")
        If CasePeople_DataGridView1.Rows.Count <= 0 Then ShowError("Please add people to the case.")
        If CaseStatus_ComboBox.SelectedIndex = 1 AndAlso OfficersSent_DataGridView.Rows.Count <= 0 Then
            ShowError("Please ensure officers are assigned or update the case status.")
        End If

        ' Stop validation if any error was encountered
        If Not isValid Then Exit Sub


        ' Stop validation if any error was encountered
        If Not isValid Then Exit Sub

        ' === Case-Specific Validations ===
        Select Case CaseType_ComboBox.SelectedIndex
            Case 0 ' Theft
                If String.IsNullOrWhiteSpace(BrgyTheftLocation_TxtBox.Text) OrElse
               String.IsNullOrWhiteSpace(StreetTheftLocation_TxtBox.Text) OrElse
               String.IsNullOrWhiteSpace(CityTheftLocation_TxtBox.Text) Then
                    ShowError("Please provide the complete theft location details.")
                End If

                If ItemDescription_DataGridView.Rows.Count <= 0 Then ShowError("Please add items involved in the theft.")
                If String.IsNullOrWhiteSpace(SuspectDesc_TxtBox.Text) Then
                    ShowError("Please provide a suspect description.")
                End If

            Case 1 ' Missing Person

                If String.IsNullOrWhiteSpace(MissingPersonLastSeenBrgy_TxtBox.Text) OrElse
               String.IsNullOrWhiteSpace(MissingPersonLastSeenStreet_TxtBox.Text) OrElse
               String.IsNullOrWhiteSpace(MissingPersonLastSeenCity_TxtBox.Text) Then
                    ShowError("Please provide the last seen location.")
                End If

                If String.IsNullOrWhiteSpace(MissingPersonLastName_TxtBox.Text) OrElse
               String.IsNullOrWhiteSpace(MissingPersonFirstName_TxtBox.Text) Then
                    ShowError("Please provide the complete name.")
                End If

                If String.IsNullOrWhiteSpace(MissingPersonPhysicalDesc_TxtBox.Text) Then
                    ShowError("Please provide a physical description.")
                End If

                If String.IsNullOrWhiteSpace(MissingPersonHeight_TxtBox.Text) OrElse Not IsNumeric(MissingPersonHeight_TxtBox.Text.Trim()) Then
                    ShowError("Please provide a valid height.")
                End If
            Case 2 ' General Case
                If SpecificCaseType_ComboBox.SelectedIndex = -1 Then ShowError("Please select a specific case type.")
                If String.IsNullOrWhiteSpace(GeneralCasesBrgy_TextBox.Text) OrElse
               String.IsNullOrWhiteSpace(GeneralCasesStreet_TextBox.Text) OrElse
               String.IsNullOrWhiteSpace(GeneralCasesCity_TextBox.Text) Then
                    ShowError("Please provide complete case location.")
                End If

                If String.IsNullOrWhiteSpace(WhatHappened_TextBox.Text) Then ShowError("Please provide info on the case.")
                If HandlerResultsListBox.Items.Count = 0 Or HandlerResultsListBox.Items.Count > 1 Then
                    MsgBox("Invalid handler!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
                End If
        End Select
    End Sub

End Class