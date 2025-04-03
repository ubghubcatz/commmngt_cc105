Imports System.IO
Imports Microsoft.Data.SqlClient
Imports System.Drawing.Imaging

Public Class CaseRecordForm
    ' Connection string for the database
    Private connectionString As String = "Server=commngtcc105.mssql.somee.com;Database=commngtcc105;
                                   User Id=ublipa_SQLLogin_1;Password=nktg6ikffl;TrustServerCertificate=True;"

    ' Variables for image handling
    Dim mainCaseImagePath As String
    Dim imageBytes As Byte() = Nothing
    Dim hiddenLabel As New Label

    ' Boolean variable to track validation status
    Dim isValid As Boolean = True

    ' Case record related objects
    Dim caseRecordTable As CaseRecordTable = Nothing
    Dim caseShow As CaseRecordShowForm = Nothing

    ' Property to store the loaded case ID
    Public Property LoadedCaseID As String

    ' Event handler for form load
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

        ' Hide specific group boxes initially
        MissingPerson_GroupBox.Visible = False
        StolenItems_GroupBox.Visible = False
        GroupBox2.Visible = False

        ' Trigger case type related UI adjustments
        caseType_Trigger()
    End Sub

    ' Function to apply consistent styling to a DataGridView
    ' This method ensures that all DataGridViews have a uniform appearance and behavior
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

    Private Sub SaveMissingPerson_Btn_Click(sender As Object, e As EventArgs) Handles SaveMissingPerson_Btn.Click
        UpdateLabels()
        Dim isValidSpecificDetails As Boolean = VerifySpecificDetails()
        ConditionalChecker()
        caseRecordTable = New CaseRecordTable()
        If isValidSpecificDetails Then

            If isValid Then
                SaveToCaseRecords()
                caseRecordTable.loadCaseData(CaseName_Txt.Text)
                Me.Close()
            End If

        Else
            MessageBox.Show("Inavalid Inputs : (|, ^)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub UpdateLabels()
        If ProcedureTaken_Label.Text = "" AndAlso Procedure_ComboBox.SelectedItem IsNot Nothing Then
            ProcedureTaken_Label.Text = Procedure_ComboBox.SelectedItem.ToString()
        End If
    End Sub

    Private Sub SaveToCaseRecords()
        Dim caseId As Integer = -1 ' Initialize case ID to -1, which indicates a new case

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
                INSERT INTO g3_CaseRecords (casename, casestatus, datetimereported)
                OUTPUT INSERTED.caseid
                VALUES (@casename, @casestatus, @datetimereported)", con)

                    cmdAdd.Parameters.AddWithValue("@casename", CaseName_Txt.Text.Trim())
                    cmdAdd.Parameters.AddWithValue("@casestatus", CaseStatus_ComboBox.SelectedItem.ToString())
                    cmdAdd.Parameters.AddWithValue("@datetimereported", DateAndimeReported_DateTimePicker.Value)

                    caseId = Convert.ToInt32(cmdAdd.ExecuteScalar()) ' Retrieve the inserted case ID  
                End Using
            Else
                Using cmdUpdate As New SqlCommand("
                UPDATE g3_CaseRecords
                SET casestatus = @casestatus,
                    datetimereported = @datetimereported
                WHERE caseid = @caseid", con)

                    cmdUpdate.Parameters.AddWithValue("@casestatus", CaseStatus_ComboBox.SelectedItem.ToString())
                    cmdUpdate.Parameters.AddWithValue("@datetimereported", DateAndimeReported_DateTimePicker.Value)
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
    End Sub

    Private Sub SaveSpecificCaseDetails(caseId As Integer)
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
                         specificdetails = @specificdetails, 
                         Remarks = @Remarks, 
                         ActionTaken = @ActionTaken
                     WHERE caseid = @caseid"
            Else
                query = "INSERT INTO g3_SpecificCaseDetails (caseid, casename, casetype, specificdetails, caseimage, Remarks, ActionTaken) 
                     VALUES (@caseid, @casename, @casetype, @specificdetails, @caseimage, @Remarks, @ActionTaken)"
            End If

            ' Execute the INSERT or UPDATE query  
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@caseid", caseId)
                cmd.Parameters.AddWithValue("@casename", CaseName_Txt.Text.Trim())
                cmd.Parameters.AddWithValue("@specificdetails", specificCaseDetails)
                cmd.Parameters.AddWithValue("@Remarks", Remarks_TextBox.Text.Trim())
                cmd.Parameters.AddWithValue("@ActionTaken", Procedure_ComboBox.SelectedItem.ToString())

                ' Add case type and image only if inserting a new record  
                If Not isExisting Then
                    cmd.Parameters.AddWithValue("@casetype", CaseType_ComboBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@caseimage", If(imageBytes IsNot Nothing, imageBytes, DBNull.Value))
                End If

                cmd.ExecuteNonQuery() ' Execute query  
            End Using

            ' Update the case image if a record already exists and a new image is provided  
            If isExisting AndAlso imageBytes IsNot Nothing Then
                Using cmdImg As New SqlCommand("
                UPDATE g3_SpecificCaseDetails 
                SET caseimage = @caseimage 
                WHERE caseid = @caseid", con)

                    cmdImg.Parameters.AddWithValue("@caseid", caseId)
                    cmdImg.Parameters.AddWithValue("@caseimage", imageBytes)
                    cmdImg.ExecuteNonQuery()
                End Using
            End If
        End Using
    End Sub


    ' This function builds and returns a formatted string containing specific case details.
    ' It gathers information from various UI elements based on the selected case type.
    ' Function to check if a string contains ^ or |
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
                Return String.Join("|", {
                MissingPersonName_TxtBox.Text.Trim(),
                MissingPersonAge_TxtBox.Text.Trim(),
                MissingPersonHeight_TxtBox.Text.Trim(),
                MissingPersonPhysicalDesc_TxtBox.Text.Trim(),
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
                TheftMethod_ComboBox.Text.Trim(),
                SuspectDesc_TxtBox.Text.Trim(),
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
                MissingPersonName_TxtBox.Text.Trim(),
                MissingPersonAge_TxtBox.Text.Trim(),
                MissingPersonHeight_TxtBox.Text.Trim(),
                MissingPersonPhysicalDesc_TxtBox.Text.Trim(),
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
                TheftMethod_ComboBox.Text.Trim(),
                SuspectDesc_TxtBox.Text.Trim(),
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

    ''' <summary>
    ''' Retrieves people-related details from the DataGridView.
    ''' </summary>
    ''' <returns>Formatted string of people details</returns>
    Private Function GetPeopleDetails() As String
        Return String.Join("", CasePeople_DataGridView1.Rows.
        Cast(Of DataGridViewRow)().
        Where(Function(r) Not r.IsNewRow).
        Select(Function(r) $"{r.Cells("NameColumn").Value}^{r.Cells("PhoneColumn").Value}^{r.Cells("TypeColumn").Value}^"))
    End Function

    ''' <summary>
    ''' Retrieves item details for a theft case.
    ''' </summary>
    ''' <returns>Formatted string of item details</returns>
    Private Function GetItemDetails() As String
        Return String.Join("", ItemDescription_DataGridView.Rows.
        Cast(Of DataGridViewRow)().
        Where(Function(r) Not r.IsNewRow).
        Select(Function(r) $"{r.Cells("StolenItemName").Value}^{r.Cells("ItemDesc").Value}^{r.Cells("Price").Value}^"))
    End Function

    ''' <summary>
    ''' Formats an address string with separators.
    ''' </summary>
    ''' <param name="street">Street name</param>
    ''' <param name="brgy">Barangay name</param>
    ''' <param name="city">City name</param>
    ''' <returns>Formatted address string</returns>
    Private Function FormatAddress(street As String, brgy As String, city As String) As String
        Return $"{street.Trim()}^{brgy.Trim()}^{city.Trim()}"
    End Function

    ''' <summary>
    ''' Formats case details, replacing empty values with a space.
    ''' </summary>
    ''' <param name="details">Array of details to format</param>
    ''' <returns>Formatted case details string</returns>
    Private Function FormatCaseDetails(details As String()) As String
        Return String.Join("|", details.Select(Function(d) If(String.IsNullOrEmpty(d), " ", d.Trim())))
    End Function


    ' === Method to Assign an Officer to a Case ===
    ' This method inserts an officer assignment into the database if the officer is not already assigned.
    ' It also checks the status of the case and sets the IsActive flag accordingly.
    '
    ' Parameters:
    '   officerId (String) - The ID of the officer to be assigned.
    '   caseId (Integer) - The ID of the case to which the officer is assigned.
    Private Sub InsertOfficerAssignment(officerId As String, caseId As Integer)
        ' Check if the officer is already assigned to this case
        If OfficerAlreadyAssigned(officerId, caseId) Then Exit Sub

        Dim isActive As Boolean = False ' Default to inactive

        Using con As New SqlConnection(connectionString)
            con.Open()

            ' === Retrieve Case Status ===
            ' Determines if the case is currently "In Progress" to set IsActive flag.
            Dim queryStatus As String = "SELECT casestatus FROM g3_CaseRecords WHERE caseid = @caseid"
            Using statusCmd As New SqlCommand(queryStatus, con)
                statusCmd.Parameters.AddWithValue("@caseid", caseId)
                Dim statusObj As Object = statusCmd.ExecuteScalar()

                ' Check if status is "In Progress"
                isActive = (statusObj IsNot Nothing AndAlso statusObj.ToString().Trim().ToLower() = "in progress")
            End Using

            ' === Insert Officer Assignment into Database ===
            Dim queryInsert As String = "INSERT INTO g3_OfficerCaseAssignments (officerid, caseid, IsActive, assigneddatetime)
                                     VALUES (@officerid, @caseid, @IsActive, @assigneddatetime)"
            Using insertCmd As New SqlCommand(queryInsert, con)
                ' Add parameters to prevent SQL injection
                insertCmd.Parameters.AddWithValue("@officerid", officerId)
                insertCmd.Parameters.AddWithValue("@caseid", caseId)
                insertCmd.Parameters.AddWithValue("@IsActive", isActive)
                insertCmd.Parameters.AddWithValue("@assigneddatetime", DateTime.Now)

                insertCmd.ExecuteNonQuery()
                MessageBox.Show("Officer successfully assigned.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        End Using
    End Sub

    ' === Helper Function to Execute Scalar Queries ===
    ' Executes a SQL scalar query with parameters and returns a single value.
    '
    ' Parameters:
    '   query (String) - The SQL query string to execute.
    '   parameters (Dictionary(Of String, Object)) - A dictionary of SQL parameters and their values.
    '
    ' Returns:
    '   Object - The result of the scalar query.
    Private Function ExecuteScalarQuery(query As String, parameters As Dictionary(Of String, Object)) As Object
        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                ' Dynamically add parameters to prevent SQL injection
                For Each param In parameters
                    cmd.Parameters.AddWithValue(param.Key, param.Value)
                Next

                Try
                    con.Open()
                    Return cmd.ExecuteScalar()
                Catch ex As Exception
                    MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return Nothing
                End Try
            End Using
        End Using
    End Function

    ' === Check if an Officer is Already Assigned to a Case ===
    ' Queries the database to check if a given officer is already assigned to a specific case.
    '
    ' Parameters:
    '   officerId (String) - The ID of the officer.
    '   caseId (Integer) - The ID of the case.
    '
    ' Returns:
    '   Boolean - True if the officer is already assigned, otherwise False.
    Private Function OfficerAlreadyAssigned(officerId As String, caseId As Integer) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM g3_OfficerCaseAssignments WHERE officerid = @officerid AND caseid = @caseid"
        Dim count As Integer = Convert.ToInt32(ExecuteScalarQuery(query, New Dictionary(Of String, Object) From {
        {"@officerid", officerId},
        {"@caseid", caseId}
    }))
        Return count > 0
    End Function

    ' === Delete an Officer's Assignment from a Case ===
    ' Removes an officer from an assigned case in the database.
    '
    ' Parameters:
    '   officerId (String) - The ID of the officer to be removed.
    '   caseId (Integer) - The ID of the case from which the officer will be unassigned.
    Private Sub DeleteOfficerAssignment(officerId As String, caseId As Integer)
        Dim query As String = "DELETE FROM g3_OfficerCaseAssignments WHERE officerid = @officerid AND caseid = @caseid"

        Using con As New SqlConnection(connectionString),
          cmd As New SqlCommand(query, con)

            ' Add parameters to avoid SQL injection
            cmd.Parameters.AddWithValue("@officerid", officerId)
            cmd.Parameters.AddWithValue("@caseid", caseId)

            con.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' === Save Additional Photos to Database ===
    ''' <summary>
    ''' Saves the additional photos from the PictureBoxes in the flow layout panel to the database.
    ''' It checks if the photo already exists for the given case ID and inserts it if not.
    ''' </summary>
    ''' <param name="caseId"The ID of the case to which the photos belong.</param>
' === Save Additional Photos to Database ===
    Private Sub SaveAdditionalPhotos(caseId As Integer)
        Using con As New SqlConnection(connectionString)
            con.Open()

            For Each pb As PictureBox In AdditionalPhotos_FlowLayoutPanel.Controls.OfType(Of PictureBox)()
                If pb.Image IsNot Nothing Then
                    Try
                        Dim photoBytes As Byte() = ImageToByteArray(pb.Image)
                        Dim description As String = If(pb.Tag IsNot Nothing AndAlso TypeOf pb.Tag Is Tuple(Of Image, String, Integer),
                                                   CType(pb.Tag, Tuple(Of Image, String, Integer)).Item2, "")

                        ' Check if photo exists in DB
                        If ExecuteScalarQuery("SELECT 1 FROM g3_AdditionalPhotos WHERE CaseID = @caseid AND Photo = @photo",
                                          New Dictionary(Of String, Object) From {{"@caseid", caseId}, {"@photo", photoBytes}}) Is Nothing Then
                            ' Insert new photo
                            Using cmd As New SqlCommand("INSERT INTO g3_AdditionalPhotos (CaseID, Photo, Description) VALUES (@caseid, @photo, @description)", con)
                                cmd.Parameters.AddWithValue("@caseid", caseId)
                                cmd.Parameters.AddWithValue("@photo", photoBytes)
                                cmd.Parameters.AddWithValue("@description", description)
                                cmd.ExecuteNonQuery()
                            End Using
                        End If
                    Catch ex As Exception
                        Console.WriteLine("Error saving photo: " & ex.Message)
                    End Try
                End If
            Next
        End Using
    End Sub



    ' === Officer Removal from DataGridView ===
    ''' <summary>
    ''' Handles the double-click event on the OfficersSent DataGridView.
    ''' Prompts the user to confirm removal of an officer and deletes the officer from both the grid and the database if necessary.
    ''' </summary>
    ''' <param name="sender">The object that triggered the event (the DataGridView).</param>
    ''' <param name="e">Event data containing information about the double-clicked cell.</param>
    Private Sub OfficersSent_DataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles OfficersSent_DataGridView.CellDoubleClick
        ' Ensure a valid row is double-clicked
        If e.RowIndex >= 0 Then
            ' Get the selected row and officer information
            Dim selectedRow As DataGridViewRow = OfficersSent_DataGridView.Rows(e.RowIndex)
            Dim officerId As String = selectedRow.Cells(0).Value.ToString()
            Dim officerName As String = selectedRow.Cells(1).Value.ToString()

            ' Prompt the user to confirm the removal of the officer
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove " & officerName & "?", "Confirm Deletion",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' If caseID_Label is empty, just remove the officer from the grid
                If String.IsNullOrEmpty(caseID_Label.Text) Then
                    OfficersSent_DataGridView.Rows.RemoveAt(e.RowIndex)
                Else
                    ' If case ID exists, check if the officer is assigned to the case and delete from the database
                    If OfficerAlreadyAssigned(officerId, caseID_Label.Text) Then
                        DeleteOfficerAssignment(officerId, caseID_Label.Text)
                    End If
                    ' Remove from grid either way
                    OfficersSent_DataGridView.Rows.RemoveAt(e.RowIndex)
                End If
            End If
        End If
    End Sub

    ' === Item Description Removal from DataGridView ===
    ''' <summary>
    ''' Handles the double-click event on the ItemDescription DataGridView.
    ''' Prompts the user to confirm removal of an item and removes it from the grid if confirmed.
    ''' </summary>
    ''' <param name="sender">The object that triggered the event (the DataGridView).</param>
    ''' <param name="e">Event data containing information about the double-clicked cell.</param>
    Private Sub ItemDescription_DataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemDescription_DataGridView.CellDoubleClick
        ' Ensure a valid row is double-clicked
        If e.RowIndex >= 0 Then
            ' Get the selected row and item information
            Dim selectedRow As DataGridViewRow = ItemDescription_DataGridView.Rows(e.RowIndex)
            Dim itemName As String = selectedRow.Cells(0).Value.ToString()

            ' Prompt the user to confirm the removal of the item
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove " & itemName & "?", "Confirm Deletion",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Remove the item from the grid
                ItemDescription_DataGridView.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    ' === Case People Removal from DataGridView ===
    ''' <summary>
    ''' Handles the double-click event on the CasePeople DataGridView.
    ''' Prompts the user to confirm removal of a person and removes them from the grid if confirmed.
    ''' </summary>
    ''' <param name="sender">The object that triggered the event (the DataGridView).</param>
    ''' <param name="e">Event data containing information about the double-clicked cell.</param>
    Private Sub CasePeople_DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles CasePeople_DataGridView1.CellDoubleClick
        ' Ensure a valid row is double-clicked
        If e.RowIndex >= 0 Then
            ' Get the selected row and person information
            Dim selectedRow As DataGridViewRow = CasePeople_DataGridView1.Rows(e.RowIndex)
            Dim personName As String = selectedRow.Cells(0).Value.ToString()

            ' Prompt the user to confirm the removal of the person
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove " & personName & "?", "Confirm Deletion",
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
        If img Is Nothing Then
            Throw New ArgumentNullException("img", "The image cannot be null.")
        End If

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

    ' Event handler for when the MissingPerson_PicBox is clicked.
    ' It allows the user to select an image, compress it, and display it in the PictureBox.
    Private Sub MissingPerson_PicBox_Click(sender As Object, e As EventArgs) Handles MissingPerson_PicBox.Click
        ' Call the method to allow the user to select and process the image for the MissingPerson_PicBox.
        SelectAndProcessImage(MissingPerson_PicBox, imageBytes, mainCaseImagePath)
    End Sub

    ' Event handler for when the generalCases_PicBox is clicked.
    ' It allows the user to select an image, compress it, and display it in the PictureBox.
    Private Sub generalCases_PicBox_Click(sender As Object, e As EventArgs) Handles generalCases_PicBox.Click
        ' Call the method to allow the user to select and process the image for the generalCases_PicBox.
        SelectAndProcessImage(generalCases_PicBox, imageBytes, mainCaseImagePath)
    End Sub

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

    ' Function to compress an image to a specified quality level and return it as a byte array.
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

    Private Sub CaseType_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CaseType_ComboBox.SelectedIndexChanged
        caseType_Trigger()
    End Sub

    Private Sub caseType_Trigger()

        If CaseType_ComboBox.SelectedIndex = -1 Then
            MissingPerson_GroupBox.Visible = False
            StolenItems_GroupBox.Visible = False

        ElseIf CaseType_ComboBox.SelectedIndex = 0 Then
            MissingPerson_GroupBox.Visible = False
            StolenItems_GroupBox.Visible = True
            GroupBox2.Visible = False
            StyleDataGridView(ItemDescription_DataGridView)
            With ItemDescription_DataGridView.Columns
                .Clear() ' Clear existing columns
                ' Add Name Column
                .Add("StolenItemName", "Item Name")

                .Add("ItemDesc", "Item Description")

                .Add("Price", "Item Price (P)")
            End With

        ElseIf CaseType_ComboBox.SelectedIndex = 1 Then
            MissingPerson_GroupBox.Visible = True
            StolenItems_GroupBox.Visible = False
            GroupBox2.Visible = False
        ElseIf CaseType_ComboBox.SelectedIndex = 2 Then
            MissingPerson_GroupBox.Visible = False
            StolenItems_GroupBox.Visible = False
            GroupBox2.Visible = True
        End If
    End Sub

    ' This method shows a single instance of a form of type T. 
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

    ' Event handler for the AddAdditionalPhoto_Btn button click.
    ' It shows the AdditionalPhotoForm if it's not already open.
    Private Sub AddAdditionalPhoto_Btn_Click(sender As Object, e As EventArgs) Handles AddAdditionalPhoto_Btn.Click
        ShowSingleInstance(Of AdditionalPhotoForm)()
    End Sub

    ' Event handler for the AddPerson_Btn button click.
    ' It shows the AddPersonInvolvedFormvb if it's not already open.
    Private Sub AddPerson_Btn_Click(sender As Object, e As EventArgs) Handles AddPerson_Btn.Click
        ShowSingleInstance(Of AddPersonInvolvedFormvb)()
    End Sub

    ' Event handler for the Button1 click.
    ' It shows the AddOfficersForm if it's not already open.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowSingleInstance(Of AddOfficersForm)()
    End Sub

    ' Event handler for the AddStolenItem_Btn button click.
    ' It shows the AddStolenItemsForm if it's not already open.
    Private Sub AddStolenItem_Btn_Click(sender As Object, e As EventArgs) Handles AddStolenItem_Btn.Click
        ShowSingleInstance(Of AddStolenItemsForm)()
    End Sub

    ' Public method that adds a PictureBox control with an image and description to the AdditionalPhotos FlowLayoutPanel.
    ' This method is used to display additional photos in the main form.
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

    Private Sub CaseRecordForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Dim existingForm = Application.OpenForms.OfType(Of AdditionalPhotoForm)().FirstOrDefault()
        If existingForm IsNot Nothing AndAlso Not existingForm.IsDisposed Then
            existingForm.Close()
            existingForm = Nothing
        End If
    End Sub

    ' === Helper function for displaying error messages ===
    Private Sub ShowError(msg As String)
        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        isValid = False
    End Sub

    Private Sub ConditionalChecker()
        isValid = True ' Assume valid unless proven otherwise

        ' === Basic Validations ===
        If String.IsNullOrWhiteSpace(CaseName_Txt.Text) Then ShowError("Case name is required.")
        If CaseType_ComboBox.SelectedIndex = -1 Then ShowError("Please select a case type.")
        If CaseStatus_ComboBox.SelectedIndex = -1 Then ShowError("Please select a case status.")
        If DateAndimeReported_DateTimePicker.Value > DateTime.Now Then ShowError("Reported date cannot be in the future.")
        If Procedure_ComboBox.SelectedIndex < 0 Then ShowError("Invalid Procedure!")
        If CasePeople_DataGridView1.Rows.Count <= 0 Then ShowError("Please add people to the case.")
        If CaseStatus_ComboBox.SelectedIndex <> 2 AndAlso OfficersSent_DataGridView.Rows.Count <= 0 Then
            ShowError("Please ensure officers are assigned or update the case status.")
        End If

        ' Stop validation if any error was encountered
        If Not isValid Then Exit Sub

        ' === Status & Procedure Change Validations ===
        If CaseStatus_ComboBox.SelectedItem IsNot Nothing AndAlso
       Original_CaseStatusLabel.Text IsNot Nothing AndAlso
       ProcedureTaken_Label.Text IsNot Nothing AndAlso
       Procedure_ComboBox.SelectedItem IsNot Nothing Then

            Dim caseChanged As Boolean = (CaseStatus_ComboBox.SelectedItem.ToString() <> Original_CaseStatusLabel.Text)
            Dim procedureInvalid As Boolean = (Procedure_ComboBox.SelectedIndex < 0 OrElse
                                           Procedure_ComboBox.SelectedItem.ToString() = ProcedureTaken_Label.Text)
            Dim isOtherSelected As Boolean = (Procedure_ComboBox.SelectedItem.ToString() = "Other (details in Remarks)")
            Dim otherWithoutRemarks As Boolean = (isOtherSelected AndAlso String.IsNullOrWhiteSpace(Remarks_TextBox.Text))

            If (caseChanged AndAlso procedureInvalid) OrElse otherWithoutRemarks Then ShowError("Invalid Action Taken")
        End If

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
                If TheftMethod_ComboBox.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(SuspectDesc_TxtBox.Text) Then
                    ShowError("Please select a theft method and provide a suspect description.")
                End If

            Case 1 ' Missing Person
                If Not (IsNumeric(MissingPersonHeight_TxtBox.Text) AndAlso IsNumeric(MissingPersonAge_TxtBox.Text)) OrElse
               String.IsNullOrWhiteSpace(MissingPersonName_TxtBox.Text) OrElse
               String.IsNullOrWhiteSpace(MissingPersonPhysicalDesc_TxtBox.Text) Then
                    ShowError("Please ensure all required fields for Missing Person are filled correctly.")
                End If

                If String.IsNullOrWhiteSpace(MissingPersonLastSeenBrgy_TxtBox.Text) OrElse
               String.IsNullOrWhiteSpace(MissingPersonLastSeenStreet_TxtBox.Text) OrElse
               String.IsNullOrWhiteSpace(MissingPersonLastSeenCity_TxtBox.Text) Then
                    ShowError("Please provide the last seen location.")
                End If

            Case 2 ' General Case
                If SpecificCaseType_ComboBox.SelectedIndex = -1 Then ShowError("Please select a specific case type.")
                If String.IsNullOrWhiteSpace(GeneralCasesBrgy_TextBox.Text) OrElse
               String.IsNullOrWhiteSpace(GeneralCasesStreet_TextBox.Text) OrElse
               String.IsNullOrWhiteSpace(GeneralCasesCity_TextBox.Text) Then
                    ShowError("Please provide complete case location.")
                End If

                If String.IsNullOrWhiteSpace(WhatHappened_TextBox.Text) Then ShowError("Please provide info on the case.")
        End Select
    End Sub

End Class