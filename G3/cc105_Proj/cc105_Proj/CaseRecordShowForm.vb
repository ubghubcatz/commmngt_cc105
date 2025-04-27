Imports System.Drawing.Printing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Data.SqlClient

Public Class CaseRecordShowForm

    Dim caseUpdateData As CaseRecordForm = Nothing

    Private connectionString As String = "Server=commngtcc105.mssql.somee.com;Database=commngtcc105;
                                     User Id=ublipa_SQLLogin_1;Password=nktg6ikffl;TrustServerCertificate=True;"


    Dim viewer As ImageViewer = Nothing
    Dim mainFormRef As g3CommandCenter_Form = TryCast(Application.OpenForms("g3CommandCenter_Form"), g3CommandCenter_Form)

    Public Property LoadedCaseID As String
    Private Sub CaseRecordShowForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initiateTables()
        HideTabSelector()
        Procedure_ListView.OwnerDraw = True
        Procedure_ListView.Columns(2).Width = 0
        Procedure_ListView.Columns(3).Width = 0

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
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.ItemSize = New Size(0, 1) ' Sets the tab headers to zero height
        TabControl1.SizeMode = TabSizeMode.Fixed ' Ensure the tab size is fixed
    End Sub

    Private Sub initiateTables()

        StyleDataGridView(CasePeople_DataGridView1)
        StyleDataGridView(OfficersSent_DataGridView)

        If CaseType_TxtBox.Text = "Theft" Then
            StyleDataGridView(ItemDescription_DataGridView)

        End If


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

    ' Handles click on "Update Case Data" button
    Private Sub UpdateCaseData_Btn_Click(sender As Object, e As EventArgs) Handles UpdateCaseData_Btn.Click
        ' Check if the form for this case ID is already open
        If BringExistingCaseFormToFront(HiddenCaseID.Text) Then Return

        ' Create and display a new form for editing case data
        Dim caseUpdateData As New CaseRecordForm

        caseUpdateData.WindowState = FormWindowState.Normal
        caseUpdateData.BringToFront
        caseUpdateData.Activate
        caseUpdateData.TopMost = True
        caseUpdateData.caseID_Label.Text = HiddenCaseID.Text
        caseUpdateData.Show
        ' Extract case ID and retrieve location details
        Dim caseID As Integer
        Integer.TryParse(HiddenCaseID.Text, caseID)
        Dim details = ReturnLocation(caseID).Split("|"c)

        ' Copy shared data grid views
        InitiateCommonDataGridView(caseUpdateData)

        ' Fill in general fields like time, status, and additional info
        PopulateCommonFields(caseUpdateData)

        ' Fill in fields specific to the case type
        PopulateByCaseType(caseUpdateData, details)

        ' Transfer additional images
        TransferAdditionalPhotos(caseUpdateData)
        SetEnabled(caseUpdateData)

        ' Set loaded case ID on the form
        caseUpdateData.LoadedCaseID = LoadedCaseID
        Panel3.Visible = True
    End Sub

    ' Checks if the CaseRecordForm for the same case ID is already open and brings it to front
    Private Function BringExistingCaseFormToFront(caseID As String) As Boolean
        For Each openForm As Form In Application.OpenForms
            If TypeOf openForm Is CaseRecordForm Then
                Dim crsf As CaseRecordForm = DirectCast(openForm, CaseRecordForm)
                If crsf.LoadedCaseID = caseID Then
                    ' Re-add if it's minimized and hidden
                    If crsf.WindowState = FormWindowState.Minimized OrElse Not crsf.Visible Then

                        If Not crsf.Visible Then crsf.Show()
                        crsf.WindowState = FormWindowState.Normal
                        crsf.BringToFront()
                        crsf.Activate()
                    End If
                    Return True
                End If
            End If
        Next
        Return False
    End Function

    ' Copies shared DataGridView content from main form to the target form
    Private Sub InitiateCommonDataGridView(targetForm As CaseRecordForm)
        ' Copy CasePeople columns and rows
        If targetForm.CasePeople_DataGridView1.Columns.Count = 0 Then
            For Each col As DataGridViewColumn In CasePeople_DataGridView1.Columns
                targetForm.CasePeople_DataGridView1.Columns.Add(DirectCast(col.Clone(), DataGridViewColumn))
            Next
        End If
        For Each row As DataGridViewRow In CasePeople_DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim index = targetForm.CasePeople_DataGridView1.Rows.Add()
                For i = 0 To row.Cells.Count - 1
                    targetForm.CasePeople_DataGridView1.Rows(index).Cells(i).Value = row.Cells(i).Value
                Next
            End If
        Next

        ' Copy OfficersSent columns and rows
        If targetForm.OfficersSent_DataGridView.Columns.Count = 0 Then
            For Each col As DataGridViewColumn In OfficersSent_DataGridView.Columns
                targetForm.OfficersSent_DataGridView.Columns.Add(DirectCast(col.Clone(), DataGridViewColumn))
            Next
        End If

        For Each row As DataGridViewRow In OfficersSent_DataGridView.Rows
            If Not row.IsNewRow Then
                Dim index = targetForm.OfficersSent_DataGridView.Rows.Add()

                ' Copy cell values
                For i = 0 To row.Cells.Count - 1
                    targetForm.OfficersSent_DataGridView.Rows(index).Cells(i).Value = row.Cells(i).Value
                Next

                ' Get officerID from the first column and check if soft deleted
                Dim officerID As String = row.Cells(0).Value.ToString()
                CheckIfSoftDeleted(officerID, targetForm)
            End If
        Next
    End Sub

    Private Sub CheckIfSoftDeleted(officerID As String, targetForm As CaseRecordForm)
        Dim query As String = "SELECT 1 FROM g3_OfficerCaseAssignments WHERE officerID = @officerid AND IsDeleted = 1;"

        Try
            Using conn As New SqlConnection(connectionString), cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@officerid", officerID)

                conn.Open() ' Open the connection inside Try to catch connection issues
                Dim result = cmd.ExecuteScalar()

                ' Check if the officer has soft-deleted assignments
                If result IsNot Nothing Then
                    ' Officer has soft-deleted assignments, now find and highlight rows in DataGridView
                    For Each row As DataGridViewRow In targetForm.OfficersSent_DataGridView.Rows
                        If Not row.IsNewRow AndAlso row.Cells(0).Value.ToString() = officerID Then
                            row.DefaultCellStyle.BackColor = Color.LightCoral ' Highlight row with a light coral color
                        End If
                    Next
                End If
            End Using
        Catch ex As SqlException
            ' Handle SQL-specific exceptions (e.g., query issues)
            MessageBox.Show("Database error: " & ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As InvalidOperationException
            ' Handle connection-related issues
            MessageBox.Show("Connection error: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            ' Catch any other exceptions
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Populates general case info into the new form
    Private Sub PopulateCommonFields(targetForm As CaseRecordForm)
        targetForm.DateAndimeReported_DateTimePicker.Value = Convert.ToDateTime(DateAndTimeReported_TxtBox.Text)
        targetForm.AdditionalInfo_TxtBox.Text = AdditionalInfo_TxtBox.Text
        targetForm.Text = Me.Text + " - Update |"
        targetForm.ReportedBy_TabControl.SelectedIndex = 1
        targetForm.FullName_TxtBox.Text = FullName_TxtBox.Text
        targetForm.CaseIDString_TextBox.Text = CaseIDString_TextBox.Text
        targetForm.PhoneNumReadnly_TxtBox.Text = PhoneNum_TxtBox.Text
        targetForm.EmailReadnly_TxtBox.Text = Email_textbox.Text
        targetForm.ZoneName_TxtBox.Text = ZoneName_TxtBox.Text
        targetForm.ExpectedFinish_DateTimePicker.Value = Convert.ToDateTime(ExpectedResolveDare_TextBox.Text)
        CaseRecordTable.GetProcedures(targetForm.Procedure_ListView, CaseIDString_TextBox.Text)
        ' Set case status in dropdown 
        Dim index = targetForm.CaseStatus_ComboBox.FindStringExact(CaseStatus_TxtBox.Text)
        If index >= 0 Then targetForm.CaseStatus_ComboBox.SelectedIndex = index

        targetForm.originalCaseStatus = CaseStatus_TxtBox.Text
    End Sub

    ' Populates fields that depend on the case type
    Private Sub PopulateByCaseType(targetForm As CaseRecordForm, details() As String)
        Select Case CaseType_TxtBox.Text
            Case "Theft"
                targetForm.CaseType_ComboBox.SelectedIndex = 0

                ' Copy ItemDescription grid if needed
                If targetForm.ItemDescription_DataGridView.Columns.Count = 0 Then
                    For Each col As DataGridViewColumn In ItemDescription_DataGridView.Columns
                        targetForm.ItemDescription_DataGridView.Columns.Add(DirectCast(col.Clone(), DataGridViewColumn))
                    Next
                End If
                For Each row As DataGridViewRow In ItemDescription_DataGridView.Rows
                    If Not row.IsNewRow Then
                        Dim index = targetForm.ItemDescription_DataGridView.Rows.Add()
                        For i = 0 To row.Cells.Count - 1
                            targetForm.ItemDescription_DataGridView.Rows(index).Cells(i).Value = row.Cells(i).Value
                        Next
                    End If
                Next
                targetForm.CaseName_Txt.Text = StolenItemsCaseName_Label.Text
                targetForm.SuspectDesc_TxtBox.Text = SuspectDesc_TxtBox.Text
                targetForm.PropertyDamage_TextBox.Text = PropertyDamage_TextBox.Text
                Dim theftLoc As String() = details(3).Split("^"c)
                targetForm.BrgyTheftLocation_TxtBox.Text = theftLoc(1)
                targetForm.CityTheftLocation_TxtBox.Text = theftLoc(2)
                targetForm.StreetTheftLocation_TxtBox.Text = theftLoc(0)

            Case "Missing Person"
                targetForm.CaseType_ComboBox.SelectedIndex = 1
                targetForm.CaseName_Txt.Text = MissingPersonCaseName_Label.Text
                Dim nameParts As String() = details(0).Split("^")
                targetForm.MissingPersonFirstName_TxtBox.Text = nameParts(0)
                targetForm.MissingPersonLastName_TxtBox.Text = nameParts(1)
                targetForm.MissingPersonNo_TxtBox.Text = MissingPersonNo_TxtBox.Text
                targetForm.MissingPersonEmail_TxtBox.Text = MissingPersonEmail_TxtBox.Text
                targetForm.MissingPersonHeight_TxtBox.Text = MissingPersonHeight_TxtBox.Text
                targetForm.MissingPersonPhysicalDesc_TxtBox.Text = MissingPersonPhysicalDesc_TxtBox.Text

                ' Split location into components
                Dim loc() As String = details(6).Split("^"c)
                targetForm.MissingPersonLastSeenStreet_TxtBox.Text = loc(0)
                targetForm.MissingPersonLastSeenBrgy_TxtBox.Text = loc(1)
                targetForm.MissingPersonLastSeenCity_TxtBox.Text = loc(2)



                ' Transfer image if present
                If MissingPerson_PicBox.Image IsNot Nothing Then
                    targetForm.MissingPerson_PicBox.Image = CType(MissingPerson_PicBox.Image.Clone(), Image)
                End If

            Case Else
                targetForm.CaseType_ComboBox.SelectedIndex = 2

                Dim index = targetForm.SpecificCaseType_ComboBox.FindStringExact(SpecificCaseType_ComboBox.Text)
                If index >= 0 Then targetForm.SpecificCaseType_ComboBox.SelectedIndex = index

                ' Split location into components
                Dim loc() As String = details(2).Split("^"c)
                targetForm.GeneralCasesStreet_TextBox.Text = loc(0)
                targetForm.GeneralCasesBrgy_TextBox.Text = loc(1)
                targetForm.GeneralCasesCity_TextBox.Text = loc(2)
                targetForm.CaseName_Txt.Text = GeneralCaseName_Label.Text

                ' Transfer image if present
                If GeneralCases_PicBox.Image IsNot Nothing Then
                    targetForm.generalCases_PicBox.Image = CType(GeneralCases_PicBox.Image.Clone(), Image)
                End If

                targetForm.WhatHappened_TextBox.Text = WhatHappened_TextBox.Text
        End Select
    End Sub

    ' Transfers all additional photos from the flow panel to the new form
    Private Sub TransferAdditionalPhotos(targetForm As CaseRecordForm)
        For Each ctrl As Control In AdditionalPhotos_FlowLayoutPanel.Controls
            If TypeOf ctrl Is PictureBox Then
                Dim pb As PictureBox = DirectCast(ctrl, PictureBox)
                If TypeOf pb.Tag Is Tuple(Of Image, String, Integer) Then
                    ' Retrieve image and metadata from the Tag
                    Dim tag = DirectCast(pb.Tag, Tuple(Of Image, String, Integer))
                    LoadPhoto(tag.Item1, tag.Item2, tag.Item3, targetForm)
                End If
            End If
        Next
    End Sub

    ' Method to load photos onto the next form's FlowLayoutPanel (without description)
    Private Sub LoadPhoto(photo As Image, desc As String, photoID As Integer, caseUpdateData As CaseRecordForm)
        ' Ensure that the FlowLayoutPanel on the next form is properly initialized
        If caseUpdateData.AdditionalPhotos_FlowLayoutPanel Is Nothing Then
            MessageBox.Show("The FlowLayoutPanel on the next form is not initialized.")
            Return
        End If

        ' Create a new PictureBox for the next form and set its properties
        Dim picBox As New PictureBox With {
        .Image = photo,  ' Set image directly
        .SizeMode = PictureBoxSizeMode.StretchImage,  ' Adjust the size mode as necessary
        .Size = New Size(149, 129)  ' Set an appropriate size for the next form
}
        picBox.Tag = New Tuple(Of Image, String, Integer)(photo, desc, photoID)
        ' Add the picture box to the next form's FlowLayoutPanel
        AddHandler picBox.DoubleClick, AddressOf AdditionalPhoto_DoubleClick
        caseUpdateData.AdditionalPhotos_FlowLayoutPanel.Controls.Add(picBox)
    End Sub

    Private Sub SetEnabled(targetForm As CaseRecordForm)
        targetForm.CaseType_ComboBox.Enabled = False
        targetForm.DateAndimeReported_DateTimePicker.Enabled = False
        targetForm.CaseName_Txt.Enabled = False
        targetForm.SpecificCaseType_ComboBox.Enabled = False
        targetForm.BrthDay_DateTimePicker.Value = BrthDay_DateTimePicker.Value
        targetForm.MissingPersonFirstName_TxtBox.ReadOnly = True
        targetForm.BrthDay_DateTimePicker.Enabled = False
        targetForm.MissingPersonHeight_TxtBox.ReadOnly = True
        targetForm.SpecificCaseType_ComboBox.Enabled = False
    End Sub

    Public Sub AdditionalPhoto_DoubleClick(sender As Object, e As EventArgs)
        Dim picBox As PictureBox = TryCast(sender, PictureBox)
        If picBox IsNot Nothing AndAlso picBox.Tag IsNot Nothing Then
            ' Retrieve the stored data from Tag
            Dim photoData = TryCast(picBox.Tag, Tuple(Of Image, String, Integer))
            If photoData IsNot Nothing Then
                Dim desc As String = photoData.Item2
                Dim photoID As Integer = photoData.Item3

                ' Ask user if they want to delete
                Dim result = MessageBox.Show($"Double-clicked PhotoID: {photoID}" & vbCrLf & $"Description: {desc}" &
                                         vbCrLf & vbCrLf & "Do you want to delete this photo?",
                                         "Photo Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    If picBox IsNot Nothing AndAlso photoID < 0 Then
                        picBox.Dispose() ' Completely removes the PictureBox and frees its resources
                    ElseIf picBox IsNot Nothing AndAlso photoID >= 0 Then
                        DeleteAdditionalPhotoFromDB(photoID)
                        picBox.Dispose()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub DeleteAdditionalPhotoFromDB(photoID As Integer)
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()

                ' SQL query to delete the photo based on its PhotoID
                Dim query As String = "DELETE FROM g3_AdditionalPhotos WHERE PhotoID = @PhotoID"

                ' Prepare the SQL command to execute the delete query
                Using deleteCommand As New SqlCommand(query, con)
                    deleteCommand.Parameters.AddWithValue("@PhotoID", photoID)

                    ' Execute the delete operation
                    deleteCommand.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As SqlException
            ' Handle SQL-related exceptions (e.g., issues with the database connection or query)
            MessageBox.Show("Database error while deleting the photo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            ' Handle any general exceptions
            MessageBox.Show("An error occurred while deleting the photo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub AdditionalPhoto_Click(sender As Object, e As EventArgs)
        Dim picBox As PictureBox = CType(sender, PictureBox)
        If picBox.Tag IsNot Nothing Then
            Dim data = CType(picBox.Tag, Tuple(Of Image, String, Integer))
            Dim img As Image = data.Item1
            Dim desc As String = data.Item2
            Dim photoID As Integer = data.Item3

            ' Show ImageViewer form
            Dim viewer As New ImageViewer()
            viewer.Fromwhere_Label.Text = "Source : " + Me.Text
            viewer.LoadImageAndDescription(img, desc)
            viewer.TopMost = True
            LayoutManager.ResizeImageViewerForm(viewer)
            viewer.ShowDialog()
        End If
    End Sub
    Private Function ReturnLocation(caseid As Integer) As String
        Dim locations As String = ""

        Dim query As String = "SELECT sd.specificdetails " &
                          "FROM g3_SpecificCaseDetails sd " &
                          "JOIN g3_CaseRecords cr ON sd.CaseID = cr.CaseID " &
                          "WHERE sd.CaseID = @caseid"

        Try
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@caseid", caseid)

                    conn.Open() ' Open connection inside Try block to catch connection errors

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            ' Ensure data is not DBNull before converting it
                            If Not IsDBNull(reader("specificdetails")) Then
                                locations = reader("specificdetails").ToString()
                            End If
                        End While
                    End Using
                End Using
            End Using
        Catch ex As SqlException
            ' Handle SQL-specific exceptions
            MessageBox.Show("Database error: " & ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As InvalidOperationException
            ' Handle connection issues or other operation-related issues
            MessageBox.Show("Connection error: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            ' Catch all other exceptions
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return locations
    End Function

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Static intStart As Integer = 0
        Static currentSection As Integer = 0
        Static intPhotoIndex As Integer = 0
        Static caseImageIndex As Integer = 0
        Static intValIndex As Integer = 0
        Static procedureCount As Integer = 0
        Static peopleCount As Integer = 0
        Static officersCount As Integer = 0
        Static numbers As Integer() = {0, 0, 0}

        PrintClass.caseID = CaseIDString_TextBox.Text
        PrintClass.FindMatchingCase(CaseIDString_TextBox.Text)

        PrintClass.RenderCasePage(e, intStart, currentSection, intPhotoIndex, caseImageIndex, intValIndex, procedureCount, peopleCount, officersCount, numbers)
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        ' Link the document to PageSetupDialog and PrintDialog
        PageSetupDialog1.Document = PrintDocument1
        PrintDialog1.Document = PrintDocument1

        ' Show Page Setup dialog first
        If PageSetupDialog1.ShowDialog() = DialogResult.OK Then
            Dim pageSetup As New PageSettings
            With pageSetup
                .Margins.Left = 50
                .Margins.Right = 50
                .Margins.Top = 50
                .Margins.Bottom = 50
                .Landscape = False
            End With
            PrintDocument1.DefaultPageSettings = pageSetup

            ' Show print preview
            If PrintDocument1.DefaultPageSettings Is Nothing Then
                PrintDocument1.DefaultPageSettings = New Printing.PageSettings()
            End If
            PrintDocument1.PrintController = New StandardPrintController()
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.TopMost = True
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        ' If PrintDocument1.DefaultPageSettings Is Nothing Then
        'PrintDocument1.DefaultPageSettings = New Printing.PageSettings()
        'End If
        PrintDocument1.PrintController = New StandardPrintController()
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.TopMost = True
        PrintPreviewDialog1.ShowDialog()
    End Sub



    Private Sub PageSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageSetupToolStripMenuItem.Click
        ' Attach the PrintDocument to the dialog
        PageSetupDialog1.Document = PrintDocument1

        ' Show the dialog and wait for confirmation
        If PageSetupDialog1.ShowDialog() = DialogResult.OK Then
            ' Apply the selected page settings from the dialog
            PrintDocument1.DefaultPageSettings = PageSetupDialog1.PageSettings

            ' Optionally override some values (like margins or orientation)
            With PrintDocument1.DefaultPageSettings
                .Margins = New Margins(50, 50, 50, 50)
                .Landscape = False
                .Color = False
            End With
        End If
    End Sub
End Class