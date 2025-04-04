<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaseRecordForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        CaseFormTabs = New TabControl()
        MissingPersonFormTab = New TabPage()
        ProcedureTaken_Label = New Label()
        Original_CaseStatusLabel = New Label()
        GroupBox1 = New GroupBox()
        Remarks_TextBox = New TextBox()
        Label17 = New Label()
        Label27 = New Label()
        Procedure_ComboBox = New ComboBox()
        caseID_Label = New Label()
        Label16 = New Label()
        OfficersSent_DataGridView = New DataGridView()
        Button1 = New Button()
        Label21 = New Label()
        StolenItems_GroupBox = New GroupBox()
        GroupBox2 = New GroupBox()
        SpecificCaseType_ComboBox = New ComboBox()
        generalCases_PicBox = New PictureBox()
        Label28 = New Label()
        WhatHappened_TextBox = New TextBox()
        Label29 = New Label()
        Label30 = New Label()
        Label31 = New Label()
        GeneralCasesBrgy_TextBox = New TextBox()
        GeneralCasesStreet_TextBox = New TextBox()
        GeneralCasesCity_TextBox = New TextBox()
        Label33 = New Label()
        Label34 = New Label()
        Label35 = New Label()
        Label36 = New Label()
        AddStolenItem_Btn = New Button()
        Suspect_Physical_Desc = New Label()
        SuspectDesc_TxtBox = New TextBox()
        Label20 = New Label()
        ItemDescription_DataGridView = New DataGridView()
        TheftMethod_ComboBox = New ComboBox()
        Label19 = New Label()
        Label15 = New Label()
        Label22 = New Label()
        PropertyDamage_TextBox = New TextBox()
        BrgyTheftLocation_TxtBox = New TextBox()
        StreetTheftLocation_TxtBox = New TextBox()
        CityTheftLocation_TxtBox = New TextBox()
        Label23 = New Label()
        Label24 = New Label()
        Label25 = New Label()
        Label26 = New Label()
        CaseType_ComboBox = New ComboBox()
        Label11 = New Label()
        MissingPerson_GroupBox = New GroupBox()
        Label12 = New Label()
        MissingPerson_PicBox = New PictureBox()
        MissingPersonName_TxtBox = New TextBox()
        Label1 = New Label()
        MissingPersonAge_TxtBox = New TextBox()
        MissingPersonHeight_TxtBox = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label9 = New Label()
        MissingPersonPhysicalDesc_TxtBox = New TextBox()
        MissingPersonLastSeenBrgy_TxtBox = New TextBox()
        MissingPersonLastSeenStreet_TxtBox = New TextBox()
        MissingPersonLastSeenCity_TxtBox = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CasePeople_DataGridView1 = New DataGridView()
        AddPerson_Btn = New Button()
        Label8 = New Label()
        CaseName_Txt = New TextBox()
        DateAndimeReported_DateTimePicker = New DateTimePicker()
        Label18 = New Label()
        SaveMissingPerson_Btn = New Button()
        AddAdditionalPhoto_Btn = New Button()
        Label14 = New Label()
        AdditionalPhotos_FlowLayoutPanel = New FlowLayoutPanel()
        CaseStatus_ComboBox = New ComboBox()
        Label13 = New Label()
        Label10 = New Label()
        AdditionalInfo_TxtBox = New TextBox()
        CaseFormTabs.SuspendLayout()
        MissingPersonFormTab.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(OfficersSent_DataGridView, ComponentModel.ISupportInitialize).BeginInit()
        StolenItems_GroupBox.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(generalCases_PicBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(ItemDescription_DataGridView, ComponentModel.ISupportInitialize).BeginInit()
        MissingPerson_GroupBox.SuspendLayout()
        CType(MissingPerson_PicBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(CasePeople_DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CaseFormTabs
        ' 
        CaseFormTabs.Appearance = TabAppearance.FlatButtons
        CaseFormTabs.Controls.Add(MissingPersonFormTab)
        CaseFormTabs.ItemSize = New Size(0, 1)
        CaseFormTabs.Location = New Point(-1, -13)
        CaseFormTabs.Multiline = True
        CaseFormTabs.Name = "CaseFormTabs"
        CaseFormTabs.SelectedIndex = 0
        CaseFormTabs.Size = New Size(1712, 782)
        CaseFormTabs.TabIndex = 0
        ' 
        ' MissingPersonFormTab
        ' 
        MissingPersonFormTab.BackColor = Color.Honeydew
        MissingPersonFormTab.Controls.Add(ProcedureTaken_Label)
        MissingPersonFormTab.Controls.Add(Original_CaseStatusLabel)
        MissingPersonFormTab.Controls.Add(GroupBox1)
        MissingPersonFormTab.Controls.Add(caseID_Label)
        MissingPersonFormTab.Controls.Add(Label16)
        MissingPersonFormTab.Controls.Add(OfficersSent_DataGridView)
        MissingPersonFormTab.Controls.Add(Button1)
        MissingPersonFormTab.Controls.Add(Label21)
        MissingPersonFormTab.Controls.Add(StolenItems_GroupBox)
        MissingPersonFormTab.Controls.Add(CaseType_ComboBox)
        MissingPersonFormTab.Controls.Add(Label11)
        MissingPersonFormTab.Controls.Add(MissingPerson_GroupBox)
        MissingPersonFormTab.Controls.Add(CasePeople_DataGridView1)
        MissingPersonFormTab.Controls.Add(AddPerson_Btn)
        MissingPersonFormTab.Controls.Add(Label8)
        MissingPersonFormTab.Controls.Add(CaseName_Txt)
        MissingPersonFormTab.Controls.Add(DateAndimeReported_DateTimePicker)
        MissingPersonFormTab.Controls.Add(Label18)
        MissingPersonFormTab.Controls.Add(SaveMissingPerson_Btn)
        MissingPersonFormTab.Controls.Add(AddAdditionalPhoto_Btn)
        MissingPersonFormTab.Controls.Add(Label14)
        MissingPersonFormTab.Controls.Add(AdditionalPhotos_FlowLayoutPanel)
        MissingPersonFormTab.Controls.Add(CaseStatus_ComboBox)
        MissingPersonFormTab.Controls.Add(Label13)
        MissingPersonFormTab.Controls.Add(Label10)
        MissingPersonFormTab.Controls.Add(AdditionalInfo_TxtBox)
        MissingPersonFormTab.Location = New Point(4, 5)
        MissingPersonFormTab.Name = "MissingPersonFormTab"
        MissingPersonFormTab.Padding = New Padding(3)
        MissingPersonFormTab.Size = New Size(1704, 773)
        MissingPersonFormTab.TabIndex = 0
        MissingPersonFormTab.Text = "TabPage1"
        ' 
        ' ProcedureTaken_Label
        ' 
        ProcedureTaken_Label.AutoSize = True
        ProcedureTaken_Label.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ProcedureTaken_Label.ForeColor = Color.Honeydew
        ProcedureTaken_Label.Location = New Point(312, 678)
        ProcedureTaken_Label.Name = "ProcedureTaken_Label"
        ProcedureTaken_Label.Size = New Size(0, 38)
        ProcedureTaken_Label.TabIndex = 52
        ' 
        ' Original_CaseStatusLabel
        ' 
        Original_CaseStatusLabel.AutoSize = True
        Original_CaseStatusLabel.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Original_CaseStatusLabel.ForeColor = Color.Honeydew
        Original_CaseStatusLabel.Location = New Point(19, 678)
        Original_CaseStatusLabel.Name = "Original_CaseStatusLabel"
        Original_CaseStatusLabel.Size = New Size(0, 38)
        Original_CaseStatusLabel.TabIndex = 51
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Remarks_TextBox)
        GroupBox1.Controls.Add(Label17)
        GroupBox1.Controls.Add(Label27)
        GroupBox1.Controls.Add(Procedure_ComboBox)
        GroupBox1.Location = New Point(818, 310)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(343, 186)
        GroupBox1.TabIndex = 50
        GroupBox1.TabStop = False
        ' 
        ' Remarks_TextBox
        ' 
        Remarks_TextBox.BorderStyle = BorderStyle.FixedSingle
        Remarks_TextBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Remarks_TextBox.Location = New Point(4, 113)
        Remarks_TextBox.Multiline = True
        Remarks_TextBox.Name = "Remarks_TextBox"
        Remarks_TextBox.ScrollBars = ScrollBars.Vertical
        Remarks_TextBox.Size = New Size(310, 63)
        Remarks_TextBox.TabIndex = 46
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = Color.Green
        Label17.Location = New Point(6, 82)
        Label17.Name = "Label17"
        Label17.Size = New Size(93, 28)
        Label17.TabIndex = 47
        Label17.Text = "Remarks"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label27.ForeColor = Color.Green
        Label27.Location = New Point(6, 22)
        Label27.Name = "Label27"
        Label27.Size = New Size(213, 28)
        Label27.TabIndex = 48
        Label27.Text = "Additional Procedure"
        ' 
        ' Procedure_ComboBox
        ' 
        Procedure_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        Procedure_ComboBox.FormattingEnabled = True
        Procedure_ComboBox.Items.AddRange(New Object() {"None", "Conducted Interview", "Collected Evidence", "Took Statement from Witness", "Filed Incident Report", "Contacted Involved Parties", "Visited Scene", "Assisted Victim", "Issued Warning", "Made Arrest", "Escalated to Senior Officer", "Requested Backup", "Filed Charges", "Conducted Surveillance", "Mediated Conflict", "Transported Individual", "Issued Citation", "Completed Documentation", "Submitted Report to Supervisor", "Provided Legal Information", "Other (details in Remarks)"})
        Procedure_ComboBox.Location = New Point(6, 53)
        Procedure_ComboBox.Name = "Procedure_ComboBox"
        Procedure_ComboBox.Size = New Size(312, 28)
        Procedure_ComboBox.TabIndex = 49
        ' 
        ' caseID_Label
        ' 
        caseID_Label.AutoSize = True
        caseID_Label.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        caseID_Label.ForeColor = Color.Honeydew
        caseID_Label.Location = New Point(1044, 12)
        caseID_Label.Name = "caseID_Label"
        caseID_Label.Size = New Size(0, 28)
        caseID_Label.TabIndex = 45
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.Green
        Label16.Location = New Point(1210, 198)
        Label16.Name = "Label16"
        Label16.Size = New Size(152, 31)
        Label16.TabIndex = 44
        Label16.Text = "Officers Sent"
        ' 
        ' OfficersSent_DataGridView
        ' 
        OfficersSent_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        OfficersSent_DataGridView.Location = New Point(1210, 232)
        OfficersSent_DataGridView.Name = "OfficersSent_DataGridView"
        OfficersSent_DataGridView.RowHeadersWidth = 51
        OfficersSent_DataGridView.Size = New Size(459, 135)
        OfficersSent_DataGridView.TabIndex = 43
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Green
        Button1.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(1567, 196)
        Button1.Name = "Button1"
        Button1.Size = New Size(102, 30)
        Button1.TabIndex = 42
        Button1.Text = "Add Officer"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.Green
        Label21.Location = New Point(1210, 10)
        Label21.Name = "Label21"
        Label21.Size = New Size(184, 31)
        Label21.TabIndex = 41
        Label21.Text = "People Involved"
        ' 
        ' StolenItems_GroupBox
        ' 
        StolenItems_GroupBox.Controls.Add(GroupBox2)
        StolenItems_GroupBox.Controls.Add(AddStolenItem_Btn)
        StolenItems_GroupBox.Controls.Add(Suspect_Physical_Desc)
        StolenItems_GroupBox.Controls.Add(SuspectDesc_TxtBox)
        StolenItems_GroupBox.Controls.Add(Label20)
        StolenItems_GroupBox.Controls.Add(ItemDescription_DataGridView)
        StolenItems_GroupBox.Controls.Add(TheftMethod_ComboBox)
        StolenItems_GroupBox.Controls.Add(Label19)
        StolenItems_GroupBox.Controls.Add(Label15)
        StolenItems_GroupBox.Controls.Add(Label22)
        StolenItems_GroupBox.Controls.Add(PropertyDamage_TextBox)
        StolenItems_GroupBox.Controls.Add(BrgyTheftLocation_TxtBox)
        StolenItems_GroupBox.Controls.Add(StreetTheftLocation_TxtBox)
        StolenItems_GroupBox.Controls.Add(CityTheftLocation_TxtBox)
        StolenItems_GroupBox.Controls.Add(Label23)
        StolenItems_GroupBox.Controls.Add(Label24)
        StolenItems_GroupBox.Controls.Add(Label25)
        StolenItems_GroupBox.Controls.Add(Label26)
        StolenItems_GroupBox.Location = New Point(0, 6)
        StolenItems_GroupBox.Name = "StolenItems_GroupBox"
        StolenItems_GroupBox.Size = New Size(748, 658)
        StolenItems_GroupBox.TabIndex = 39
        StolenItems_GroupBox.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(SpecificCaseType_ComboBox)
        GroupBox2.Controls.Add(generalCases_PicBox)
        GroupBox2.Controls.Add(Label28)
        GroupBox2.Controls.Add(WhatHappened_TextBox)
        GroupBox2.Controls.Add(Label29)
        GroupBox2.Controls.Add(Label30)
        GroupBox2.Controls.Add(Label31)
        GroupBox2.Controls.Add(GeneralCasesBrgy_TextBox)
        GroupBox2.Controls.Add(GeneralCasesStreet_TextBox)
        GroupBox2.Controls.Add(GeneralCasesCity_TextBox)
        GroupBox2.Controls.Add(Label33)
        GroupBox2.Controls.Add(Label34)
        GroupBox2.Controls.Add(Label35)
        GroupBox2.Controls.Add(Label36)
        GroupBox2.Location = New Point(0, 6)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(748, 652)
        GroupBox2.TabIndex = 40
        GroupBox2.TabStop = False
        ' 
        ' SpecificCaseType_ComboBox
        ' 
        SpecificCaseType_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        SpecificCaseType_ComboBox.FormattingEnabled = True
        SpecificCaseType_ComboBox.Items.AddRange(New Object() {"Environmental and Sanitation Issues", "Public Order Violations", "Neighborhood and Community Conflicts", "Business and Financial Disputes", "", "Physical Injuries and Assault", "Property and Boundary Disputes", "Family and Domestic Disputes"})
        SpecificCaseType_ComboBox.Location = New Point(12, 424)
        SpecificCaseType_ComboBox.Name = "SpecificCaseType_ComboBox"
        SpecificCaseType_ComboBox.Size = New Size(300, 28)
        SpecificCaseType_ComboBox.TabIndex = 39
        ' 
        ' generalCases_PicBox
        ' 
        generalCases_PicBox.Location = New Point(12, 124)
        generalCases_PicBox.Name = "generalCases_PicBox"
        generalCases_PicBox.Size = New Size(338, 252)
        generalCases_PicBox.TabIndex = 38
        generalCases_PicBox.TabStop = False
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label28.ForeColor = Color.Green
        Label28.Location = New Point(387, 326)
        Label28.Name = "Label28"
        Label28.Size = New Size(167, 28)
        Label28.TabIndex = 30
        Label28.Text = "Events Unfolded"
        ' 
        ' WhatHappened_TextBox
        ' 
        WhatHappened_TextBox.BorderStyle = BorderStyle.FixedSingle
        WhatHappened_TextBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        WhatHappened_TextBox.Location = New Point(386, 368)
        WhatHappened_TextBox.Multiline = True
        WhatHappened_TextBox.Name = "WhatHappened_TextBox"
        WhatHappened_TextBox.ScrollBars = ScrollBars.Vertical
        WhatHappened_TextBox.Size = New Size(315, 200)
        WhatHappened_TextBox.TabIndex = 29
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label29.ForeColor = Color.Green
        Label29.Location = New Point(9, 87)
        Label29.Name = "Label29"
        Label29.Size = New Size(164, 28)
        Label29.TabIndex = 28
        Label29.Text = "Picture of Event"
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label30.ForeColor = Color.Green
        Label30.Location = New Point(9, 386)
        Label30.Name = "Label30"
        Label30.Size = New Size(186, 28)
        Label30.TabIndex = 20
        Label30.Text = "Specific Case Type"
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label31.ForeColor = Color.Green
        Label31.Location = New Point(16, 18)
        Label31.Name = "Label31"
        Label31.Size = New Size(211, 41)
        Label31.TabIndex = 19
        Label31.Text = "General Cases"
        ' 
        ' GeneralCasesBrgy_TextBox
        ' 
        GeneralCasesBrgy_TextBox.BorderStyle = BorderStyle.FixedSingle
        GeneralCasesBrgy_TextBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GeneralCasesBrgy_TextBox.Location = New Point(392, 112)
        GeneralCasesBrgy_TextBox.Name = "GeneralCasesBrgy_TextBox"
        GeneralCasesBrgy_TextBox.Size = New Size(211, 34)
        GeneralCasesBrgy_TextBox.TabIndex = 4
        ' 
        ' GeneralCasesStreet_TextBox
        ' 
        GeneralCasesStreet_TextBox.BorderStyle = BorderStyle.FixedSingle
        GeneralCasesStreet_TextBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GeneralCasesStreet_TextBox.Location = New Point(392, 192)
        GeneralCasesStreet_TextBox.Name = "GeneralCasesStreet_TextBox"
        GeneralCasesStreet_TextBox.Size = New Size(211, 34)
        GeneralCasesStreet_TextBox.TabIndex = 5
        ' 
        ' GeneralCasesCity_TextBox
        ' 
        GeneralCasesCity_TextBox.BorderStyle = BorderStyle.FixedSingle
        GeneralCasesCity_TextBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GeneralCasesCity_TextBox.Location = New Point(392, 282)
        GeneralCasesCity_TextBox.Name = "GeneralCasesCity_TextBox"
        GeneralCasesCity_TextBox.Size = New Size(211, 34)
        GeneralCasesCity_TextBox.TabIndex = 6
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label33.ForeColor = Color.Green
        Label33.Location = New Point(392, 34)
        Label33.Name = "Label33"
        Label33.Size = New Size(129, 38)
        Label33.TabIndex = 7
        Label33.Text = "Location"
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label34.ForeColor = Color.Green
        Label34.Location = New Point(389, 82)
        Label34.Name = "Label34"
        Label34.Size = New Size(101, 28)
        Label34.TabIndex = 8
        Label34.Text = "Barangay"
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label35.ForeColor = Color.Green
        Label35.Location = New Point(389, 161)
        Label35.Name = "Label35"
        Label35.Size = New Size(69, 28)
        Label35.TabIndex = 9
        Label35.Text = "Street"
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label36.ForeColor = Color.Green
        Label36.Location = New Point(392, 251)
        Label36.Name = "Label36"
        Label36.Size = New Size(49, 28)
        Label36.TabIndex = 10
        Label36.Text = "City"
        ' 
        ' AddStolenItem_Btn
        ' 
        AddStolenItem_Btn.BackColor = Color.Green
        AddStolenItem_Btn.FlatStyle = FlatStyle.Flat
        AddStolenItem_Btn.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddStolenItem_Btn.ForeColor = Color.White
        AddStolenItem_Btn.Location = New Point(271, 82)
        AddStolenItem_Btn.Name = "AddStolenItem_Btn"
        AddStolenItem_Btn.Size = New Size(102, 30)
        AddStolenItem_Btn.TabIndex = 37
        AddStolenItem_Btn.Text = "Add Item"
        AddStolenItem_Btn.UseVisualStyleBackColor = False
        ' 
        ' Suspect_Physical_Desc
        ' 
        Suspect_Physical_Desc.AutoSize = True
        Suspect_Physical_Desc.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Suspect_Physical_Desc.ForeColor = Color.Green
        Suspect_Physical_Desc.Location = New Point(375, 386)
        Suspect_Physical_Desc.Name = "Suspect_Physical_Desc"
        Suspect_Physical_Desc.Size = New Size(200, 28)
        Suspect_Physical_Desc.TabIndex = 30
        Suspect_Physical_Desc.Text = "Suspect Description"
        ' 
        ' SuspectDesc_TxtBox
        ' 
        SuspectDesc_TxtBox.BorderStyle = BorderStyle.FixedSingle
        SuspectDesc_TxtBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SuspectDesc_TxtBox.Location = New Point(374, 417)
        SuspectDesc_TxtBox.Multiline = True
        SuspectDesc_TxtBox.Name = "SuspectDesc_TxtBox"
        SuspectDesc_TxtBox.Size = New Size(315, 124)
        SuspectDesc_TxtBox.TabIndex = 29
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = Color.Green
        Label20.Location = New Point(9, 87)
        Label20.Name = "Label20"
        Label20.Size = New Size(170, 28)
        Label20.TabIndex = 28
        Label20.Text = "Item Description"
        ' 
        ' ItemDescription_DataGridView
        ' 
        ItemDescription_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ItemDescription_DataGridView.Location = New Point(9, 118)
        ItemDescription_DataGridView.Name = "ItemDescription_DataGridView"
        ItemDescription_DataGridView.RowHeadersWidth = 51
        ItemDescription_DataGridView.Size = New Size(364, 252)
        ItemDescription_DataGridView.TabIndex = 27
        ' 
        ' TheftMethod_ComboBox
        ' 
        TheftMethod_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        TheftMethod_ComboBox.FormattingEnabled = True
        TheftMethod_ComboBox.Items.AddRange(New Object() {"Open", "In Progress", "Pending", "Resolved"})
        TheftMethod_ComboBox.Location = New Point(9, 417)
        TheftMethod_ComboBox.Name = "TheftMethod_ComboBox"
        TheftMethod_ComboBox.Size = New Size(253, 28)
        TheftMethod_ComboBox.TabIndex = 26
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = Color.Green
        Label19.Location = New Point(9, 386)
        Label19.Name = "Label19"
        Label19.Size = New Size(172, 28)
        Label19.TabIndex = 20
        Label19.Text = "Method Of Theft"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.Green
        Label15.Location = New Point(16, 18)
        Label15.Name = "Label15"
        Label15.Size = New Size(261, 41)
        Label15.TabIndex = 19
        Label15.Text = "Stolen Item Form"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = Color.Green
        Label22.Location = New Point(7, 470)
        Label22.Name = "Label22"
        Label22.Size = New Size(256, 28)
        Label22.TabIndex = 18
        Label22.Text = "Property Damage (If Any)"
        ' 
        ' PropertyDamage_TextBox
        ' 
        PropertyDamage_TextBox.BorderStyle = BorderStyle.FixedSingle
        PropertyDamage_TextBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PropertyDamage_TextBox.Location = New Point(11, 501)
        PropertyDamage_TextBox.Multiline = True
        PropertyDamage_TextBox.Name = "PropertyDamage_TextBox"
        PropertyDamage_TextBox.Size = New Size(315, 84)
        PropertyDamage_TextBox.TabIndex = 16
        ' 
        ' BrgyTheftLocation_TxtBox
        ' 
        BrgyTheftLocation_TxtBox.BorderStyle = BorderStyle.FixedSingle
        BrgyTheftLocation_TxtBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BrgyTheftLocation_TxtBox.Location = New Point(392, 112)
        BrgyTheftLocation_TxtBox.Name = "BrgyTheftLocation_TxtBox"
        BrgyTheftLocation_TxtBox.Size = New Size(211, 34)
        BrgyTheftLocation_TxtBox.TabIndex = 4
        ' 
        ' StreetTheftLocation_TxtBox
        ' 
        StreetTheftLocation_TxtBox.BorderStyle = BorderStyle.FixedSingle
        StreetTheftLocation_TxtBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StreetTheftLocation_TxtBox.Location = New Point(392, 192)
        StreetTheftLocation_TxtBox.Name = "StreetTheftLocation_TxtBox"
        StreetTheftLocation_TxtBox.Size = New Size(211, 34)
        StreetTheftLocation_TxtBox.TabIndex = 5
        ' 
        ' CityTheftLocation_TxtBox
        ' 
        CityTheftLocation_TxtBox.BorderStyle = BorderStyle.FixedSingle
        CityTheftLocation_TxtBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CityTheftLocation_TxtBox.Location = New Point(392, 282)
        CityTheftLocation_TxtBox.Name = "CityTheftLocation_TxtBox"
        CityTheftLocation_TxtBox.Size = New Size(211, 34)
        CityTheftLocation_TxtBox.TabIndex = 6
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label23.ForeColor = Color.Green
        Label23.Location = New Point(392, 34)
        Label23.Name = "Label23"
        Label23.Size = New Size(248, 38)
        Label23.TabIndex = 7
        Label23.Text = "Location Of Theft"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label24.ForeColor = Color.Green
        Label24.Location = New Point(389, 82)
        Label24.Name = "Label24"
        Label24.Size = New Size(101, 28)
        Label24.TabIndex = 8
        Label24.Text = "Barangay"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label25.ForeColor = Color.Green
        Label25.Location = New Point(389, 161)
        Label25.Name = "Label25"
        Label25.Size = New Size(69, 28)
        Label25.TabIndex = 9
        Label25.Text = "Street"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label26.ForeColor = Color.Green
        Label26.Location = New Point(392, 251)
        Label26.Name = "Label26"
        Label26.Size = New Size(49, 28)
        Label26.TabIndex = 10
        Label26.Text = "City"
        ' 
        ' CaseType_ComboBox
        ' 
        CaseType_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        CaseType_ComboBox.FormattingEnabled = True
        CaseType_ComboBox.Items.AddRange(New Object() {"Theft", "Missing Person", "Others (Please Specify)"})
        CaseType_ComboBox.Location = New Point(822, 137)
        CaseType_ComboBox.Name = "CaseType_ComboBox"
        CaseType_ComboBox.Size = New Size(253, 28)
        CaseType_ComboBox.TabIndex = 40
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Green
        Label11.Location = New Point(822, 106)
        Label11.Name = "Label11"
        Label11.Size = New Size(106, 28)
        Label11.TabIndex = 39
        Label11.Text = "Case Type"
        ' 
        ' MissingPerson_GroupBox
        ' 
        MissingPerson_GroupBox.Controls.Add(Label12)
        MissingPerson_GroupBox.Controls.Add(MissingPerson_PicBox)
        MissingPerson_GroupBox.Controls.Add(MissingPersonName_TxtBox)
        MissingPerson_GroupBox.Controls.Add(Label1)
        MissingPerson_GroupBox.Controls.Add(MissingPersonAge_TxtBox)
        MissingPerson_GroupBox.Controls.Add(MissingPersonHeight_TxtBox)
        MissingPerson_GroupBox.Controls.Add(Label6)
        MissingPerson_GroupBox.Controls.Add(Label7)
        MissingPerson_GroupBox.Controls.Add(Label9)
        MissingPerson_GroupBox.Controls.Add(MissingPersonPhysicalDesc_TxtBox)
        MissingPerson_GroupBox.Controls.Add(MissingPersonLastSeenBrgy_TxtBox)
        MissingPerson_GroupBox.Controls.Add(MissingPersonLastSeenStreet_TxtBox)
        MissingPerson_GroupBox.Controls.Add(MissingPersonLastSeenCity_TxtBox)
        MissingPerson_GroupBox.Controls.Add(Label2)
        MissingPerson_GroupBox.Controls.Add(Label3)
        MissingPerson_GroupBox.Controls.Add(Label4)
        MissingPerson_GroupBox.Controls.Add(Label5)
        MissingPerson_GroupBox.Location = New Point(9, 3)
        MissingPerson_GroupBox.Name = "MissingPerson_GroupBox"
        MissingPerson_GroupBox.Size = New Size(739, 661)
        MissingPerson_GroupBox.TabIndex = 38
        MissingPerson_GroupBox.TabStop = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Green
        Label12.Location = New Point(15, 17)
        Label12.Name = "Label12"
        Label12.Size = New Size(311, 41)
        Label12.TabIndex = 19
        Label12.Text = "Missing Person Form"
        ' 
        ' MissingPerson_PicBox
        ' 
        MissingPerson_PicBox.BackgroundImageLayout = ImageLayout.Stretch
        MissingPerson_PicBox.ImageLocation = ""
        MissingPerson_PicBox.Location = New Point(15, 97)
        MissingPerson_PicBox.Name = "MissingPerson_PicBox"
        MissingPerson_PicBox.Size = New Size(302, 258)
        MissingPerson_PicBox.TabIndex = 0
        MissingPerson_PicBox.TabStop = False
        ' 
        ' MissingPersonName_TxtBox
        ' 
        MissingPersonName_TxtBox.BorderStyle = BorderStyle.FixedSingle
        MissingPersonName_TxtBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MissingPersonName_TxtBox.Location = New Point(19, 410)
        MissingPersonName_TxtBox.Name = "MissingPersonName_TxtBox"
        MissingPersonName_TxtBox.Size = New Size(211, 34)
        MissingPersonName_TxtBox.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Green
        Label1.Location = New Point(19, 379)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 28)
        Label1.TabIndex = 2
        Label1.Text = "Given Name"
        ' 
        ' MissingPersonAge_TxtBox
        ' 
        MissingPersonAge_TxtBox.BorderStyle = BorderStyle.FixedSingle
        MissingPersonAge_TxtBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MissingPersonAge_TxtBox.Location = New Point(19, 501)
        MissingPersonAge_TxtBox.Name = "MissingPersonAge_TxtBox"
        MissingPersonAge_TxtBox.Size = New Size(102, 34)
        MissingPersonAge_TxtBox.TabIndex = 3
        ' 
        ' MissingPersonHeight_TxtBox
        ' 
        MissingPersonHeight_TxtBox.BorderStyle = BorderStyle.FixedSingle
        MissingPersonHeight_TxtBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MissingPersonHeight_TxtBox.Location = New Point(19, 583)
        MissingPersonHeight_TxtBox.Name = "MissingPersonHeight_TxtBox"
        MissingPersonHeight_TxtBox.Size = New Size(102, 34)
        MissingPersonHeight_TxtBox.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Green
        Label6.Location = New Point(19, 470)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 28)
        Label6.TabIndex = 13
        Label6.Text = "Age"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Green
        Label7.Location = New Point(19, 556)
        Label7.Name = "Label7"
        Label7.Size = New Size(124, 28)
        Label7.TabIndex = 14
        Label7.Text = "Height (cm)"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Green
        Label9.Location = New Point(347, 439)
        Label9.Name = "Label9"
        Label9.Size = New Size(204, 28)
        Label9.TabIndex = 18
        Label9.Text = "Physical Description"
        ' 
        ' MissingPersonPhysicalDesc_TxtBox
        ' 
        MissingPersonPhysicalDesc_TxtBox.BorderStyle = BorderStyle.FixedSingle
        MissingPersonPhysicalDesc_TxtBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MissingPersonPhysicalDesc_TxtBox.Location = New Point(351, 470)
        MissingPersonPhysicalDesc_TxtBox.Multiline = True
        MissingPersonPhysicalDesc_TxtBox.Name = "MissingPersonPhysicalDesc_TxtBox"
        MissingPersonPhysicalDesc_TxtBox.Size = New Size(341, 84)
        MissingPersonPhysicalDesc_TxtBox.TabIndex = 16
        ' 
        ' MissingPersonLastSeenBrgy_TxtBox
        ' 
        MissingPersonLastSeenBrgy_TxtBox.BorderStyle = BorderStyle.FixedSingle
        MissingPersonLastSeenBrgy_TxtBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MissingPersonLastSeenBrgy_TxtBox.Location = New Point(383, 149)
        MissingPersonLastSeenBrgy_TxtBox.Name = "MissingPersonLastSeenBrgy_TxtBox"
        MissingPersonLastSeenBrgy_TxtBox.Size = New Size(211, 34)
        MissingPersonLastSeenBrgy_TxtBox.TabIndex = 4
        ' 
        ' MissingPersonLastSeenStreet_TxtBox
        ' 
        MissingPersonLastSeenStreet_TxtBox.BorderStyle = BorderStyle.FixedSingle
        MissingPersonLastSeenStreet_TxtBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MissingPersonLastSeenStreet_TxtBox.Location = New Point(383, 239)
        MissingPersonLastSeenStreet_TxtBox.Multiline = True
        MissingPersonLastSeenStreet_TxtBox.Name = "MissingPersonLastSeenStreet_TxtBox"
        MissingPersonLastSeenStreet_TxtBox.Size = New Size(211, 37)
        MissingPersonLastSeenStreet_TxtBox.TabIndex = 5
        ' 
        ' MissingPersonLastSeenCity_TxtBox
        ' 
        MissingPersonLastSeenCity_TxtBox.BorderStyle = BorderStyle.FixedSingle
        MissingPersonLastSeenCity_TxtBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MissingPersonLastSeenCity_TxtBox.Location = New Point(383, 330)
        MissingPersonLastSeenCity_TxtBox.Name = "MissingPersonLastSeenCity_TxtBox"
        MissingPersonLastSeenCity_TxtBox.Size = New Size(211, 34)
        MissingPersonLastSeenCity_TxtBox.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Green
        Label2.Location = New Point(383, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(260, 38)
        Label2.TabIndex = 7
        Label2.Text = "Location Last Seen"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Green
        Label3.Location = New Point(383, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 28)
        Label3.TabIndex = 8
        Label3.Text = "Barangay"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Green
        Label4.Location = New Point(383, 209)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 28)
        Label4.TabIndex = 9
        Label4.Text = "Street"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Green
        Label5.Location = New Point(383, 299)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 28)
        Label5.TabIndex = 10
        Label5.Text = "City"
        ' 
        ' CasePeople_DataGridView1
        ' 
        CasePeople_DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        CasePeople_DataGridView1.Location = New Point(1210, 46)
        CasePeople_DataGridView1.Name = "CasePeople_DataGridView1"
        CasePeople_DataGridView1.RowHeadersWidth = 51
        CasePeople_DataGridView1.Size = New Size(459, 149)
        CasePeople_DataGridView1.TabIndex = 37
        ' 
        ' AddPerson_Btn
        ' 
        AddPerson_Btn.BackColor = Color.Green
        AddPerson_Btn.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddPerson_Btn.ForeColor = Color.White
        AddPerson_Btn.Location = New Point(1567, 10)
        AddPerson_Btn.Name = "AddPerson_Btn"
        AddPerson_Btn.Size = New Size(102, 30)
        AddPerson_Btn.TabIndex = 36
        AddPerson_Btn.Text = "Add Person"
        AddPerson_Btn.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Green
        Label8.Location = New Point(822, 30)
        Label8.Name = "Label8"
        Label8.Size = New Size(117, 28)
        Label8.TabIndex = 34
        Label8.Text = "Case Name"
        ' 
        ' CaseName_Txt
        ' 
        CaseName_Txt.BorderStyle = BorderStyle.FixedSingle
        CaseName_Txt.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CaseName_Txt.Location = New Point(822, 65)
        CaseName_Txt.Name = "CaseName_Txt"
        CaseName_Txt.Size = New Size(250, 34)
        CaseName_Txt.TabIndex = 33
        ' 
        ' DateAndimeReported_DateTimePicker
        ' 
        DateAndimeReported_DateTimePicker.CustomFormat = "MM-dd-yyyy HH:mm"
        DateAndimeReported_DateTimePicker.Format = DateTimePickerFormat.Custom
        DateAndimeReported_DateTimePicker.Location = New Point(822, 206)
        DateAndimeReported_DateTimePicker.Name = "DateAndimeReported_DateTimePicker"
        DateAndimeReported_DateTimePicker.ShowUpDown = True
        DateAndimeReported_DateTimePicker.Size = New Size(250, 27)
        DateAndimeReported_DateTimePicker.TabIndex = 32
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = Color.Green
        Label18.Location = New Point(818, 175)
        Label18.Name = "Label18"
        Label18.Size = New Size(339, 28)
        Label18.TabIndex = 31
        Label18.Text = "Date and Time Reported (24 hour)"
        ' 
        ' SaveMissingPerson_Btn
        ' 
        SaveMissingPerson_Btn.BackColor = Color.Green
        SaveMissingPerson_Btn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SaveMissingPerson_Btn.ForeColor = Color.White
        SaveMissingPerson_Btn.Location = New Point(1544, 663)
        SaveMissingPerson_Btn.Name = "SaveMissingPerson_Btn"
        SaveMissingPerson_Btn.Size = New Size(128, 52)
        SaveMissingPerson_Btn.TabIndex = 1
        SaveMissingPerson_Btn.Text = "SAVE"
        SaveMissingPerson_Btn.UseVisualStyleBackColor = False
        ' 
        ' AddAdditionalPhoto_Btn
        ' 
        AddAdditionalPhoto_Btn.BackColor = Color.Green
        AddAdditionalPhoto_Btn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddAdditionalPhoto_Btn.ForeColor = Color.White
        AddAdditionalPhoto_Btn.Location = New Point(1555, 370)
        AddAdditionalPhoto_Btn.Name = "AddAdditionalPhoto_Btn"
        AddAdditionalPhoto_Btn.Size = New Size(120, 29)
        AddAdditionalPhoto_Btn.TabIndex = 28
        AddAdditionalPhoto_Btn.Text = "Add Photo"
        AddAdditionalPhoto_Btn.UseVisualStyleBackColor = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.Green
        Label14.Location = New Point(1210, 370)
        Label14.Name = "Label14"
        Label14.Size = New Size(209, 31)
        Label14.TabIndex = 27
        Label14.Text = "Additional Photos"
        ' 
        ' AdditionalPhotos_FlowLayoutPanel
        ' 
        AdditionalPhotos_FlowLayoutPanel.BackColor = Color.Green
        AdditionalPhotos_FlowLayoutPanel.Location = New Point(1210, 401)
        AdditionalPhotos_FlowLayoutPanel.Name = "AdditionalPhotos_FlowLayoutPanel"
        AdditionalPhotos_FlowLayoutPanel.Size = New Size(465, 261)
        AdditionalPhotos_FlowLayoutPanel.TabIndex = 26
        ' 
        ' CaseStatus_ComboBox
        ' 
        CaseStatus_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        CaseStatus_ComboBox.FormattingEnabled = True
        CaseStatus_ComboBox.Items.AddRange(New Object() {"Open", "In Progress", "Pending", "Resolved"})
        CaseStatus_ComboBox.Location = New Point(818, 267)
        CaseStatus_ComboBox.Name = "CaseStatus_ComboBox"
        CaseStatus_ComboBox.Size = New Size(257, 28)
        CaseStatus_ComboBox.TabIndex = 25
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.Green
        Label13.Location = New Point(818, 236)
        Label13.Name = "Label13"
        Label13.Size = New Size(120, 28)
        Label13.TabIndex = 24
        Label13.Text = "Case Status"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Green
        Label10.Location = New Point(818, 498)
        Label10.Name = "Label10"
        Label10.Size = New Size(155, 28)
        Label10.TabIndex = 19
        Label10.Text = "Additional Info"
        ' 
        ' AdditionalInfo_TxtBox
        ' 
        AdditionalInfo_TxtBox.BorderStyle = BorderStyle.FixedSingle
        AdditionalInfo_TxtBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AdditionalInfo_TxtBox.Location = New Point(822, 529)
        AdditionalInfo_TxtBox.Multiline = True
        AdditionalInfo_TxtBox.Name = "AdditionalInfo_TxtBox"
        AdditionalInfo_TxtBox.ScrollBars = ScrollBars.Vertical
        AdditionalInfo_TxtBox.Size = New Size(310, 144)
        AdditionalInfo_TxtBox.TabIndex = 17
        ' 
        ' CaseRecordForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.Honeydew
        ClientSize = New Size(1723, 725)
        Controls.Add(CaseFormTabs)
        MaximizeBox = False
        MaximumSize = New Size(1741, 812)
        MinimumSize = New Size(1305, 609)
        Name = "CaseRecordForm"
        Text = "New Cases Form"
        CaseFormTabs.ResumeLayout(False)
        MissingPersonFormTab.ResumeLayout(False)
        MissingPersonFormTab.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(OfficersSent_DataGridView, ComponentModel.ISupportInitialize).EndInit()
        StolenItems_GroupBox.ResumeLayout(False)
        StolenItems_GroupBox.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(generalCases_PicBox, ComponentModel.ISupportInitialize).EndInit()
        CType(ItemDescription_DataGridView, ComponentModel.ISupportInitialize).EndInit()
        MissingPerson_GroupBox.ResumeLayout(False)
        MissingPerson_GroupBox.PerformLayout()
        CType(MissingPerson_PicBox, ComponentModel.ISupportInitialize).EndInit()
        CType(CasePeople_DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents CaseFormTabs As TabControl
    Friend WithEvents MissingPersonFormTab As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents MissingPersonHeight_TxtBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MissingPersonLastSeenCity_TxtBox As TextBox
    Friend WithEvents MissingPersonLastSeenStreet_TxtBox As TextBox
    Friend WithEvents MissingPersonLastSeenBrgy_TxtBox As TextBox
    Friend WithEvents MissingPersonAge_TxtBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MissingPerson_PicBox As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents AdditionalInfo_TxtBox As TextBox
    Friend WithEvents MissingPersonPhysicalDesc_TxtBox As TextBox
    Friend WithEvents AdditionalPhotos_FlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents CaseType_ComboBox As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents AddAdditionalPhoto_Btn As Button
    Friend WithEvents CaseStatus_ComboBox As ComboBox
    Friend WithEvents SaveMissingPerson_Btn As Button
    Friend WithEvents DateAndimeReported_DateTimePicker As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CaseName_Txt As TextBox
    Friend WithEvents AddPerson_Btn As Button
    Friend WithEvents CasePeople_DataGridView1 As DataGridView
    Friend WithEvents MissingPerson_GroupBox As GroupBox
    Friend WithEvents StolenItems_GroupBox As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents PropertyDamage_TextBox As TextBox
    Friend WithEvents BrgyTheftLocation_TxtBox As TextBox
    Friend WithEvents StreetTheftLocation_TxtBox As TextBox
    Friend WithEvents CityTheftLocation_TxtBox As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents ItemDescription_DataGridView As DataGridView
    Friend WithEvents TheftMethod_ComboBox As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents AddStolenItem_Btn As Button
    Friend WithEvents Suspect_Physical_Desc As Label
    Friend WithEvents SuspectDesc_TxtBox As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents OfficersSent_DataGridView As DataGridView
    Friend WithEvents Button1 As Button
    Public WithEvents MissingPersonName_TxtBox As TextBox
    Friend WithEvents caseID_Label As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Remarks_TextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Procedure_ComboBox As ComboBox
    Friend WithEvents Original_CaseStatusLabel As Label
    Friend WithEvents ProcedureTaken_Label As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label28 As Label
    Friend WithEvents WhatHappened_TextBox As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents GeneralCasesBrgy_TextBox As TextBox
    Friend WithEvents GeneralCasesStreet_TextBox As TextBox
    Friend WithEvents GeneralCasesCity_TextBox As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents generalCases_PicBox As PictureBox
    Friend WithEvents SpecificCaseType_ComboBox As ComboBox
End Class
