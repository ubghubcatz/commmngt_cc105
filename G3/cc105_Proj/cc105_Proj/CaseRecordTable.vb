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
                Form2.WindowState = FormWindowState.Normal
                Form2.BringToFront()
                Form2.Activate()
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

                            If Not crsf.Visible Then crsf.Show()
                            crsf.WindowState = FormWindowState.Normal
                            crsf.BringToFront()
                        crsf.Activate()
                    End If


                    Return ' Exit the subroutine as the case is already open and handled
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
        ' Define the SQL query to get the CaseID from the g3_SpecificCaseDetails table based on the case name
        Dim query As String = "SELECT TOP 1 CaseID FROM g3_SpecificCaseDetails WHERE casename = @casename"

        ' Establish a connection to the database using the connection string
        Using conn As New SqlConnection(connectionString)
            ' Create a new SqlCommand object with the query and the connection
            Using cmd As New SqlCommand(query, conn)
                ' Add the parameter @casename to the command to prevent SQL injection
                cmd.Parameters.AddWithValue("@casename", caseName)

                Try
                    ' Open the connection to the database
                    conn.Open()

                    ' Execute the query and retrieve the result as a single value (CaseID)
                    Dim result = cmd.ExecuteScalar()

                    ' Check if a result was returned
                    If result IsNot Nothing Then
                        ' If a CaseID was found, return it as a string
                        Return result.ToString()
                    Else
                        ' If no CaseID was found, return an empty string
                        Return ""
                    End If
                Catch ex As Exception
                    ' In case of an error (e.g., connection issue), log or show the error message
                    MessageBox.Show("Error: " & ex.Message)
                    Return ""
                End Try
            End Using
        End Using
    End Function

    ' This function reloads case data into the form based on a search query.
    Private Sub ReloadCaseDataIntoForm(caseShow As CaseRecordShowForm, searchQuery As String)
        Dim query As String =
        "SELECT sd.specificdetails, sd.caseimage, sd.casetype, sd.CaseID, sd.casename, sd.Remarks, sd.ActionTaken, " &
        "cr.casestatus, cr.datetimereported, ap.Photo, ap.Description, ap.PhotoID " &
        "FROM g3_SpecificCaseDetails sd " &
        "JOIN g3_CaseRecords cr ON sd.caseID = cr.caseid " &
        "LEFT JOIN g3_AdditionalPhotos ap ON sd.caseID = ap.CaseID " &
        "WHERE sd.casename = @casename"

        viewer = New ImageViewer
        Using conn As New SqlConnection(connectionString), cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@casename", searchQuery)
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
                    caseShow.Procedure_TextBox.Text = reader("ActionTaken").ToString()
                    caseShow.Remarks_TextBox.Text = reader("Remarks").ToString()
                    If reader("casetype") = "Theft" Or reader("casetype") = "Missing Person" Then
                        caseShow.Text = $"| Case Name: {reader("casename")} | {reader("casetype")} |"
                    End If
                    Dim specificDetails As String() = reader("specificdetails").ToString().Split("|"c)
                    Select Case reader("casetype").ToString()
                        Case "Theft" : LoadTheftCase(caseShow, specificDetails, reader("casename").ToString())
                        Case "Missing Person" : LoadMissingPersonCase(caseShow, specificDetails, reader("caseimage"))
                        Case "Others (Please Specify)"
                            LoadOtherCase(caseShow, specificDetails, reader("caseimage"))
                            If caseShow.CaseType_TxtBox.Text = "Others (Please Specify)" Then
                                caseShow.SpecificCaseType_ComboBox.Text = specificDetails(0)
                                caseShow.CaseType_TxtBox.Text = specificDetails(0)
                            End If
                    End Select


                    If Not IsDBNull(reader("Photo")) Then
                        AddPhotoToPanel(caseShow, reader)
                    End If
                End While
            End Using
        End Using

        If caseShow.HiddenCaseID.Text IsNot Nothing AndAlso IsNumeric(caseShow.HiddenCaseID.Text) Then
            Dim query2 As String = "
        SELECT ocs.officerid, ed.EmployeeName, ed.Position
        FROM g3_OfficerCaseAssignments ocs
        INNER JOIN g4_EmployeeDetails ed ON ocs.officerid = ed.EmployeeID
        WHERE ocs.caseid = @caseid"

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

                    ' Set DataSource for officers grid
                    caseShow.OfficersSent_DataGridView.DataSource = table

                    ' Clear and define columns for officers grid
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
    End Sub

    Private Sub LoadTheftCase(caseShow As CaseRecordShowForm, details As String(), caseName As String)
        caseShow.StolenItems_GroupBox.Visible = True
        caseShow.MissingPerson_GroupBox.Visible = False

        caseShow.TheftMethod_TxtBox.Text = details(0)
        caseShow.SuspectDesc_TxtBox.Text = details(1)
        caseShow.Label15.Text = caseName
        caseShow.TheftLocation_TxtBox.Text = details(3).Replace("^", ", ")
        caseShow.AdditionalInfo_TxtBox.Text = details(4)

        AddItemsToGrid(caseShow.ItemDescription_DataGridView, details(2))
        AddPeopleToGrid(caseShow.CasePeople_DataGridView1, details(5))
    End Sub

    Private Sub LoadMissingPersonCase(caseShow As CaseRecordShowForm, details As String(), caseImageObj As Object)
        caseShow.StolenItems_GroupBox.Visible = False
        caseShow.MissingPerson_GroupBox.Visible = True

        caseShow.Label12.Text = details(0)
        caseShow.MissingPersonName_TxtBox.Text = details(0)
        caseShow.MissingPersonAge_TxtBox.Text = details(1)
        caseShow.MissingPersonHeight_TxtBox.Text = details(2)
        caseShow.MissingPersonPhysicalDesc_TxtBox.Text = details(3)
        caseShow.MissingPersonLastSeenLocation_TxtBox.Text = details(4).Replace("^", ", ")
        caseShow.AdditionalInfo_TxtBox.Text = details(5)

        If Not IsDBNull(caseImageObj) Then
            Dim imageBytes As Byte() = DirectCast(caseImageObj, Byte())
            Using ms As New MemoryStream(imageBytes)
                caseShow.MissingPerson_PicBox.Image = Image.FromStream(ms)
            End Using
        End If
        AddPeopleToGrid(caseShow.CasePeople_DataGridView1, details(6))
    End Sub

    Private Sub LoadOtherCase(caseShow As CaseRecordShowForm, details As String(), caseImageObj As Object)
        caseShow.StolenItems_GroupBox.Visible = False
        caseShow.MissingPerson_GroupBox.Visible = False
        caseShow.GroupBox2.Visible = True

        caseShow.SpecificCaseType_ComboBox.Text = details(0)
        caseShow.WhatHappened_TextBox.Text = details(1)
        caseShow.GeneralCasesLocation_TextBox.Text = details(2).Replace("^", ", ")
        caseShow.AdditionalInfo_TxtBox.Text = details(3)

        If Not IsDBNull(caseImageObj) Then
            Dim imageBytes As Byte() = DirectCast(caseImageObj, Byte())
            Using ms As New MemoryStream(imageBytes)
                caseShow.GeneralCases_PicBox.Image = Image.FromStream(ms)
            End Using
        End If

        AddPeopleToGrid(caseShow.CasePeople_DataGridView1, details(4))
    End Sub

    Private Sub AddItemsToGrid(grid As DataGridView, raw As String)
        Dim parts = raw.Split("^"c)
        For i As Integer = 0 To parts.Length - 1 Step 3
            If i + 2 < parts.Length Then
                grid.Rows.Add(parts(i), parts(i + 1), parts(i + 2))
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
End Class