<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaseRecordShowForm
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
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        CaseID_Label = New Label()
        HiddenCaseID = New Label()
        TabControl2 = New TabControl()
        TabPage4 = New TabPage()
        Panel3 = New Panel()
        ExpectedResolveDare_TextBox = New TextBox()
        Label3 = New Label()
        Button1 = New Button()
        OfficersSent_DataGridView = New DataGridView()
        Label11 = New Label()
        Label16 = New Label()
        Label21 = New Label()
        Label10 = New Label()
        CasePeople_DataGridView1 = New DataGridView()
        UpdateCaseData_Btn = New Button()
        CaseType_TxtBox = New TextBox()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        MissingPerson_GroupBox = New GroupBox()
        Label45 = New Label()
        BrthDay_DateTimePicker = New DateTimePicker()
        Label44 = New Label()
        Label4 = New Label()
        MissingPersonNo_TxtBox = New TextBox()
        MissingPersonEmail_TxtBox = New TextBox()
        MissingPersonCaseName_Label = New Label()
        MissingPerson_PicBox = New PictureBox()
        MissingPersonName_TxtBox = New TextBox()
        Label1 = New Label()
        MissingPersonAge_TxtBox = New TextBox()
        MissingPersonHeight_TxtBox = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label9 = New Label()
        MissingPersonPhysicalDesc_TxtBox = New TextBox()
        MissingPersonLastSeenLocation_TxtBox = New TextBox()
        Label2 = New Label()
        TabPage2 = New TabPage()
        StolenItems_GroupBox = New GroupBox()
        Suspect_Physical_Desc = New Label()
        SuspectDesc_TxtBox = New TextBox()
        Label20 = New Label()
        ItemDescription_DataGridView = New DataGridView()
        StolenItemsCaseName_Label = New Label()
        Label22 = New Label()
        PropertyDamage_TextBox = New TextBox()
        TheftLocation_TxtBox = New TextBox()
        Label23 = New Label()
        TabPage3 = New TabPage()
        GroupBox2 = New GroupBox()
        GeneralCases_PicBox = New PictureBox()
        Label28 = New Label()
        WhatHappened_TextBox = New TextBox()
        Label30 = New Label()
        GeneralCaseName_Label = New Label()
        SpecificCaseType_ComboBox = New TextBox()
        GeneralCasesLocation_TextBox = New TextBox()
        Label33 = New Label()
        Label14 = New Label()
        GroupBox1 = New GroupBox()
        Procedure_ListView = New ListView()
        Label27 = New Label()
        AdditionalPhotos_FlowLayoutPanel = New FlowLayoutPanel()
        CaseStatus_TxtBox = New TextBox()
        Label13 = New Label()
        DateAndTimeReported_TxtBox = New TextBox()
        Label18 = New Label()
        AdditionalInfo_TxtBox = New TextBox()
        GroupBox3 = New GroupBox()
        ZoneName_TxtBox = New TextBox()
        FullName_TxtBox = New TextBox()
        Label39 = New Label()
        Label38 = New Label()
        PhoneNum_TxtBox = New TextBox()
        Label37 = New Label()
        Email_textbox = New TextBox()
        Label5 = New Label()
        CaseIDString_TextBox = New TextBox()
        Label8 = New Label()
        Panel1 = New Panel()
        TabControl2.SuspendLayout()
        TabPage4.SuspendLayout()
        Panel3.SuspendLayout()
        CType(OfficersSent_DataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(CasePeople_DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        MissingPerson_GroupBox.SuspendLayout()
        CType(MissingPerson_PicBox, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        StolenItems_GroupBox.SuspendLayout()
        CType(ItemDescription_DataGridView, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(GeneralCases_PicBox, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' CaseID_Label
        ' 
        CaseID_Label.AutoSize = True
        CaseID_Label.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CaseID_Label.ForeColor = Color.Green
        CaseID_Label.Location = New Point(19, 634)
        CaseID_Label.Name = "CaseID_Label"
        CaseID_Label.Size = New Size(0, 38)
        CaseID_Label.TabIndex = 66
        ' 
        ' HiddenCaseID
        ' 
        HiddenCaseID.AutoSize = True
        HiddenCaseID.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HiddenCaseID.ForeColor = Color.Honeydew
        HiddenCaseID.Location = New Point(1055, 37)
        HiddenCaseID.Name = "HiddenCaseID"
        HiddenCaseID.Size = New Size(0, 38)
        HiddenCaseID.TabIndex = 78
        ' 
        ' TabControl2
        ' 
        TabControl2.Controls.Add(TabPage4)
        TabControl2.Location = New Point(3, 1)
        TabControl2.Name = "TabControl2"
        TabControl2.SelectedIndex = 0
        TabControl2.Size = New Size(1618, 700)
        TabControl2.TabIndex = 113
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(Panel3)
        TabPage4.Location = New Point(4, 29)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(1610, 667)
        TabPage4.TabIndex = 0
        TabPage4.Text = "TabPage4"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Honeydew
        Panel3.Controls.Add(ExpectedResolveDare_TextBox)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(OfficersSent_DataGridView)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(Label16)
        Panel3.Controls.Add(Label21)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(CasePeople_DataGridView1)
        Panel3.Controls.Add(UpdateCaseData_Btn)
        Panel3.Controls.Add(CaseType_TxtBox)
        Panel3.Controls.Add(TabControl1)
        Panel3.Controls.Add(Label14)
        Panel3.Controls.Add(GroupBox1)
        Panel3.Controls.Add(AdditionalPhotos_FlowLayoutPanel)
        Panel3.Controls.Add(CaseStatus_TxtBox)
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(DateAndTimeReported_TxtBox)
        Panel3.Controls.Add(Label18)
        Panel3.Controls.Add(AdditionalInfo_TxtBox)
        Panel3.Controls.Add(GroupBox3)
        Panel3.Controls.Add(CaseIDString_TextBox)
        Panel3.Controls.Add(Label8)
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1622, 700)
        Panel3.TabIndex = 2
        ' 
        ' ExpectedResolveDare_TextBox
        ' 
        ExpectedResolveDare_TextBox.BorderStyle = BorderStyle.FixedSingle
        ExpectedResolveDare_TextBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExpectedResolveDare_TextBox.Location = New Point(945, 172)
        ExpectedResolveDare_TextBox.Name = "ExpectedResolveDare_TextBox"
        ExpectedResolveDare_TextBox.ReadOnly = True
        ExpectedResolveDare_TextBox.Size = New Size(191, 34)
        ExpectedResolveDare_TextBox.TabIndex = 117
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Green
        Label3.Location = New Point(945, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(167, 20)
        Label3.TabIndex = 116
        Label3.Text = "Expected Resolve Date"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1507, 10)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 114
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' OfficersSent_DataGridView
        ' 
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = SystemColors.Control
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle7.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        OfficersSent_DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        OfficersSent_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = SystemColors.Window
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle8.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False
        OfficersSent_DataGridView.DefaultCellStyle = DataGridViewCellStyle8
        OfficersSent_DataGridView.Location = New Point(1148, 222)
        OfficersSent_DataGridView.Name = "OfficersSent_DataGridView"
        OfficersSent_DataGridView.RowHeadersWidth = 51
        OfficersSent_DataGridView.Size = New Size(459, 141)
        OfficersSent_DataGridView.TabIndex = 115
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Green
        Label11.Location = New Point(766, 3)
        Label11.Name = "Label11"
        Label11.Size = New Size(106, 28)
        Label11.TabIndex = 75
        Label11.Text = "Case Type"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.Green
        Label16.Location = New Point(1142, 189)
        Label16.Name = "Label16"
        Label16.Size = New Size(152, 31)
        Label16.TabIndex = 73
        Label16.Text = "Officers Sent"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.Green
        Label21.Location = New Point(1142, 10)
        Label21.Name = "Label21"
        Label21.Size = New Size(184, 31)
        Label21.TabIndex = 71
        Label21.Text = "People Involved"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Green
        Label10.Location = New Point(766, 463)
        Label10.Name = "Label10"
        Label10.Size = New Size(155, 28)
        Label10.TabIndex = 74
        Label10.Text = "Additional Info"
        ' 
        ' CasePeople_DataGridView1
        ' 
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = SystemColors.Control
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle9.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.True
        CasePeople_DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        CasePeople_DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = SystemColors.Window
        DataGridViewCellStyle10.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle10.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = DataGridViewTriState.False
        CasePeople_DataGridView1.DefaultCellStyle = DataGridViewCellStyle10
        CasePeople_DataGridView1.Location = New Point(1142, 46)
        CasePeople_DataGridView1.Name = "CasePeople_DataGridView1"
        CasePeople_DataGridView1.RowHeadersWidth = 51
        CasePeople_DataGridView1.Size = New Size(459, 137)
        CasePeople_DataGridView1.TabIndex = 70
        ' 
        ' UpdateCaseData_Btn
        ' 
        UpdateCaseData_Btn.BackColor = Color.Green
        UpdateCaseData_Btn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UpdateCaseData_Btn.ForeColor = Color.White
        UpdateCaseData_Btn.Location = New Point(526, 606)
        UpdateCaseData_Btn.Name = "UpdateCaseData_Btn"
        UpdateCaseData_Btn.Size = New Size(128, 52)
        UpdateCaseData_Btn.TabIndex = 114
        UpdateCaseData_Btn.Text = "UPDATE"
        UpdateCaseData_Btn.UseVisualStyleBackColor = False
        ' 
        ' CaseType_TxtBox
        ' 
        CaseType_TxtBox.BorderStyle = BorderStyle.FixedSingle
        CaseType_TxtBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CaseType_TxtBox.Location = New Point(766, 31)
        CaseType_TxtBox.Name = "CaseType_TxtBox"
        CaseType_TxtBox.ReadOnly = True
        CaseType_TxtBox.Size = New Size(173, 34)
        CaseType_TxtBox.TabIndex = 76
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.ItemSize = New Size(75, 26)
        TabControl1.Location = New Point(6, 10)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(747, 475)
        TabControl1.TabIndex = 113
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Honeydew
        TabPage1.Controls.Add(MissingPerson_GroupBox)
        TabPage1.Location = New Point(4, 30)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(739, 441)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        ' 
        ' MissingPerson_GroupBox
        ' 
        MissingPerson_GroupBox.Controls.Add(Label45)
        MissingPerson_GroupBox.Controls.Add(BrthDay_DateTimePicker)
        MissingPerson_GroupBox.Controls.Add(Label44)
        MissingPerson_GroupBox.Controls.Add(Label4)
        MissingPerson_GroupBox.Controls.Add(MissingPersonNo_TxtBox)
        MissingPerson_GroupBox.Controls.Add(MissingPersonEmail_TxtBox)
        MissingPerson_GroupBox.Controls.Add(MissingPersonCaseName_Label)
        MissingPerson_GroupBox.Controls.Add(MissingPerson_PicBox)
        MissingPerson_GroupBox.Controls.Add(MissingPersonName_TxtBox)
        MissingPerson_GroupBox.Controls.Add(Label1)
        MissingPerson_GroupBox.Controls.Add(MissingPersonAge_TxtBox)
        MissingPerson_GroupBox.Controls.Add(MissingPersonHeight_TxtBox)
        MissingPerson_GroupBox.Controls.Add(Label6)
        MissingPerson_GroupBox.Controls.Add(Label7)
        MissingPerson_GroupBox.Controls.Add(Label9)
        MissingPerson_GroupBox.Controls.Add(MissingPersonPhysicalDesc_TxtBox)
        MissingPerson_GroupBox.Controls.Add(MissingPersonLastSeenLocation_TxtBox)
        MissingPerson_GroupBox.Controls.Add(Label2)
        MissingPerson_GroupBox.Location = New Point(3, 3)
        MissingPerson_GroupBox.Name = "MissingPerson_GroupBox"
        MissingPerson_GroupBox.Size = New Size(739, 438)
        MissingPerson_GroupBox.TabIndex = 39
        MissingPerson_GroupBox.TabStop = False
        ' 
        ' Label45
        ' 
        Label45.AutoSize = True
        Label45.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label45.ForeColor = Color.Green
        Label45.Location = New Point(464, 296)
        Label45.Name = "Label45"
        Label45.Size = New Size(110, 28)
        Label45.TabIndex = 117
        Label45.Text = "Phone No."
        ' 
        ' BrthDay_DateTimePicker
        ' 
        BrthDay_DateTimePicker.CustomFormat = "MM-dd-yyyy"
        BrthDay_DateTimePicker.Enabled = False
        BrthDay_DateTimePicker.Format = DateTimePickerFormat.Custom
        BrthDay_DateTimePicker.Location = New Point(144, 395)
        BrthDay_DateTimePicker.Name = "BrthDay_DateTimePicker"
        BrthDay_DateTimePicker.ShowUpDown = True
        BrthDay_DateTimePicker.Size = New Size(142, 27)
        BrthDay_DateTimePicker.TabIndex = 77
        ' 
        ' Label44
        ' 
        Label44.AutoSize = True
        Label44.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label44.ForeColor = Color.Green
        Label44.Location = New Point(244, 296)
        Label44.Name = "Label44"
        Label44.Size = New Size(64, 28)
        Label44.TabIndex = 116
        Label44.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Green
        Label4.Location = New Point(144, 364)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 28)
        Label4.TabIndex = 21
        Label4.Text = "Birthday"
        ' 
        ' MissingPersonNo_TxtBox
        ' 
        MissingPersonNo_TxtBox.BorderStyle = BorderStyle.FixedSingle
        MissingPersonNo_TxtBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MissingPersonNo_TxtBox.Location = New Point(464, 327)
        MissingPersonNo_TxtBox.Name = "MissingPersonNo_TxtBox"
        MissingPersonNo_TxtBox.ReadOnly = True
        MissingPersonNo_TxtBox.Size = New Size(203, 34)
        MissingPersonNo_TxtBox.TabIndex = 115
        ' 
        ' MissingPersonEmail_TxtBox
        ' 
        MissingPersonEmail_TxtBox.BorderStyle = BorderStyle.FixedSingle
        MissingPersonEmail_TxtBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MissingPersonEmail_TxtBox.Location = New Point(244, 327)
        MissingPersonEmail_TxtBox.Name = "MissingPersonEmail_TxtBox"
        MissingPersonEmail_TxtBox.ReadOnly = True
        MissingPersonEmail_TxtBox.Size = New Size(203, 34)
        MissingPersonEmail_TxtBox.TabIndex = 114
        ' 
        ' MissingPersonCaseName_Label
        ' 
        MissingPersonCaseName_Label.AutoSize = True
        MissingPersonCaseName_Label.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MissingPersonCaseName_Label.ForeColor = Color.Green
        MissingPersonCaseName_Label.Location = New Point(15, 17)
        MissingPersonCaseName_Label.Name = "MissingPersonCaseName_Label"
        MissingPersonCaseName_Label.Size = New Size(311, 41)
        MissingPersonCaseName_Label.TabIndex = 19
        MissingPersonCaseName_Label.Text = "Missing Person Form"
        ' 
        ' MissingPerson_PicBox
        ' 
        MissingPerson_PicBox.BackgroundImageLayout = ImageLayout.None
        MissingPerson_PicBox.ImageLocation = ""
        MissingPerson_PicBox.Location = New Point(15, 70)
        MissingPerson_PicBox.Name = "MissingPerson_PicBox"
        MissingPerson_PicBox.Size = New Size(295, 213)
        MissingPerson_PicBox.SizeMode = PictureBoxSizeMode.StretchImage
        MissingPerson_PicBox.TabIndex = 0
        MissingPerson_PicBox.TabStop = False
        ' 
        ' MissingPersonName_TxtBox
        ' 
        MissingPersonName_TxtBox.BorderStyle = BorderStyle.FixedSingle
        MissingPersonName_TxtBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MissingPersonName_TxtBox.Location = New Point(22, 327)
        MissingPersonName_TxtBox.Name = "MissingPersonName_TxtBox"
        MissingPersonName_TxtBox.ReadOnly = True
        MissingPersonName_TxtBox.Size = New Size(211, 34)
        MissingPersonName_TxtBox.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Green
        Label1.Location = New Point(22, 296)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 28)
        Label1.TabIndex = 2
        Label1.Text = "Given Name"
        ' 
        ' MissingPersonAge_TxtBox
        ' 
        MissingPersonAge_TxtBox.BorderStyle = BorderStyle.FixedSingle
        MissingPersonAge_TxtBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MissingPersonAge_TxtBox.Location = New Point(22, 395)
        MissingPersonAge_TxtBox.Name = "MissingPersonAge_TxtBox"
        MissingPersonAge_TxtBox.ReadOnly = True
        MissingPersonAge_TxtBox.Size = New Size(102, 34)
        MissingPersonAge_TxtBox.TabIndex = 3
        ' 
        ' MissingPersonHeight_TxtBox
        ' 
        MissingPersonHeight_TxtBox.BorderStyle = BorderStyle.FixedSingle
        MissingPersonHeight_TxtBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MissingPersonHeight_TxtBox.Location = New Point(304, 395)
        MissingPersonHeight_TxtBox.Name = "MissingPersonHeight_TxtBox"
        MissingPersonHeight_TxtBox.ReadOnly = True
        MissingPersonHeight_TxtBox.Size = New Size(102, 34)
        MissingPersonHeight_TxtBox.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Green
        Label6.Location = New Point(22, 364)
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
        Label7.Location = New Point(304, 361)
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
        Label9.Location = New Point(358, 123)
        Label9.Name = "Label9"
        Label9.Size = New Size(204, 28)
        Label9.TabIndex = 18
        Label9.Text = "Physical Description"
        ' 
        ' MissingPersonPhysicalDesc_TxtBox
        ' 
        MissingPersonPhysicalDesc_TxtBox.BorderStyle = BorderStyle.FixedSingle
        MissingPersonPhysicalDesc_TxtBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MissingPersonPhysicalDesc_TxtBox.Location = New Point(358, 154)
        MissingPersonPhysicalDesc_TxtBox.Multiline = True
        MissingPersonPhysicalDesc_TxtBox.Name = "MissingPersonPhysicalDesc_TxtBox"
        MissingPersonPhysicalDesc_TxtBox.ReadOnly = True
        MissingPersonPhysicalDesc_TxtBox.ScrollBars = ScrollBars.Vertical
        MissingPersonPhysicalDesc_TxtBox.Size = New Size(341, 129)
        MissingPersonPhysicalDesc_TxtBox.TabIndex = 16
        ' 
        ' MissingPersonLastSeenLocation_TxtBox
        ' 
        MissingPersonLastSeenLocation_TxtBox.BorderStyle = BorderStyle.FixedSingle
        MissingPersonLastSeenLocation_TxtBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MissingPersonLastSeenLocation_TxtBox.Location = New Point(358, 75)
        MissingPersonLastSeenLocation_TxtBox.Name = "MissingPersonLastSeenLocation_TxtBox"
        MissingPersonLastSeenLocation_TxtBox.ReadOnly = True
        MissingPersonLastSeenLocation_TxtBox.ScrollBars = ScrollBars.Vertical
        MissingPersonLastSeenLocation_TxtBox.Size = New Size(260, 34)
        MissingPersonLastSeenLocation_TxtBox.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Green
        Label2.Location = New Point(358, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(260, 38)
        Label2.TabIndex = 7
        Label2.Text = "Location Last Seen"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.Honeydew
        TabPage2.Controls.Add(StolenItems_GroupBox)
        TabPage2.Location = New Point(4, 30)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(739, 441)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        ' 
        ' StolenItems_GroupBox
        ' 
        StolenItems_GroupBox.Controls.Add(Suspect_Physical_Desc)
        StolenItems_GroupBox.Controls.Add(SuspectDesc_TxtBox)
        StolenItems_GroupBox.Controls.Add(Label20)
        StolenItems_GroupBox.Controls.Add(ItemDescription_DataGridView)
        StolenItems_GroupBox.Controls.Add(StolenItemsCaseName_Label)
        StolenItems_GroupBox.Controls.Add(Label22)
        StolenItems_GroupBox.Controls.Add(PropertyDamage_TextBox)
        StolenItems_GroupBox.Controls.Add(TheftLocation_TxtBox)
        StolenItems_GroupBox.Controls.Add(Label23)
        StolenItems_GroupBox.Location = New Point(6, 1)
        StolenItems_GroupBox.Name = "StolenItems_GroupBox"
        StolenItems_GroupBox.Size = New Size(733, 437)
        StolenItems_GroupBox.TabIndex = 40
        StolenItems_GroupBox.TabStop = False
        ' 
        ' Suspect_Physical_Desc
        ' 
        Suspect_Physical_Desc.AutoSize = True
        Suspect_Physical_Desc.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Suspect_Physical_Desc.ForeColor = Color.Green
        Suspect_Physical_Desc.Location = New Point(400, 105)
        Suspect_Physical_Desc.Name = "Suspect_Physical_Desc"
        Suspect_Physical_Desc.Size = New Size(200, 28)
        Suspect_Physical_Desc.TabIndex = 30
        Suspect_Physical_Desc.Text = "Suspect Description"
        ' 
        ' SuspectDesc_TxtBox
        ' 
        SuspectDesc_TxtBox.BorderStyle = BorderStyle.FixedSingle
        SuspectDesc_TxtBox.Enabled = False
        SuspectDesc_TxtBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SuspectDesc_TxtBox.Location = New Point(399, 136)
        SuspectDesc_TxtBox.Multiline = True
        SuspectDesc_TxtBox.Name = "SuspectDesc_TxtBox"
        SuspectDesc_TxtBox.ReadOnly = True
        SuspectDesc_TxtBox.ScrollBars = ScrollBars.Vertical
        SuspectDesc_TxtBox.Size = New Size(315, 124)
        SuspectDesc_TxtBox.TabIndex = 29
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = Color.Green
        Label20.Location = New Point(14, 60)
        Label20.Name = "Label20"
        Label20.Size = New Size(170, 28)
        Label20.TabIndex = 28
        Label20.Text = "Item Description"
        ' 
        ' ItemDescription_DataGridView
        ' 
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = SystemColors.Control
        DataGridViewCellStyle11.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle11.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True
        ItemDescription_DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        ItemDescription_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = SystemColors.Window
        DataGridViewCellStyle12.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle12.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = DataGridViewTriState.False
        ItemDescription_DataGridView.DefaultCellStyle = DataGridViewCellStyle12
        ItemDescription_DataGridView.Location = New Point(14, 91)
        ItemDescription_DataGridView.Name = "ItemDescription_DataGridView"
        ItemDescription_DataGridView.RowHeadersWidth = 51
        ItemDescription_DataGridView.Size = New Size(364, 199)
        ItemDescription_DataGridView.TabIndex = 27
        ' 
        ' StolenItemsCaseName_Label
        ' 
        StolenItemsCaseName_Label.AutoSize = True
        StolenItemsCaseName_Label.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StolenItemsCaseName_Label.ForeColor = Color.Green
        StolenItemsCaseName_Label.Location = New Point(18, 11)
        StolenItemsCaseName_Label.Name = "StolenItemsCaseName_Label"
        StolenItemsCaseName_Label.Size = New Size(261, 41)
        StolenItemsCaseName_Label.TabIndex = 19
        StolenItemsCaseName_Label.Text = "Stolen Item Form"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = Color.Green
        Label22.Location = New Point(392, 261)
        Label22.Name = "Label22"
        Label22.Size = New Size(256, 28)
        Label22.TabIndex = 18
        Label22.Text = "Property Damage (If Any)"
        ' 
        ' PropertyDamage_TextBox
        ' 
        PropertyDamage_TextBox.BorderStyle = BorderStyle.FixedSingle
        PropertyDamage_TextBox.Enabled = False
        PropertyDamage_TextBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PropertyDamage_TextBox.Location = New Point(396, 292)
        PropertyDamage_TextBox.Multiline = True
        PropertyDamage_TextBox.Name = "PropertyDamage_TextBox"
        PropertyDamage_TextBox.ReadOnly = True
        PropertyDamage_TextBox.ScrollBars = ScrollBars.Vertical
        PropertyDamage_TextBox.Size = New Size(315, 116)
        PropertyDamage_TextBox.TabIndex = 16
        ' 
        ' TheftLocation_TxtBox
        ' 
        TheftLocation_TxtBox.BorderStyle = BorderStyle.FixedSingle
        TheftLocation_TxtBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TheftLocation_TxtBox.Location = New Point(399, 66)
        TheftLocation_TxtBox.Name = "TheftLocation_TxtBox"
        TheftLocation_TxtBox.ReadOnly = True
        TheftLocation_TxtBox.ScrollBars = ScrollBars.Vertical
        TheftLocation_TxtBox.Size = New Size(306, 34)
        TheftLocation_TxtBox.TabIndex = 4
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label23.ForeColor = Color.Green
        Label23.Location = New Point(396, 19)
        Label23.Name = "Label23"
        Label23.Size = New Size(248, 38)
        Label23.TabIndex = 7
        Label23.Text = "Location Of Theft"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.Honeydew
        TabPage3.Controls.Add(GroupBox2)
        TabPage3.Location = New Point(4, 30)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(739, 441)
        TabPage3.TabIndex = 2
        TabPage3.Text = "TabPage3"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(GeneralCases_PicBox)
        GroupBox2.Controls.Add(Label28)
        GroupBox2.Controls.Add(WhatHappened_TextBox)
        GroupBox2.Controls.Add(Label30)
        GroupBox2.Controls.Add(GeneralCaseName_Label)
        GroupBox2.Controls.Add(SpecificCaseType_ComboBox)
        GroupBox2.Controls.Add(GeneralCasesLocation_TextBox)
        GroupBox2.Controls.Add(Label33)
        GroupBox2.Location = New Point(6, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(739, 435)
        GroupBox2.TabIndex = 41
        GroupBox2.TabStop = False
        ' 
        ' GeneralCases_PicBox
        ' 
        GeneralCases_PicBox.Location = New Point(12, 82)
        GeneralCases_PicBox.Name = "GeneralCases_PicBox"
        GeneralCases_PicBox.Size = New Size(338, 252)
        GeneralCases_PicBox.TabIndex = 38
        GeneralCases_PicBox.TabStop = False
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label28.ForeColor = Color.Green
        Label28.Location = New Point(367, 123)
        Label28.Name = "Label28"
        Label28.Size = New Size(167, 28)
        Label28.TabIndex = 30
        Label28.Text = "Events Unfolded"
        ' 
        ' WhatHappened_TextBox
        ' 
        WhatHappened_TextBox.BorderStyle = BorderStyle.FixedSingle
        WhatHappened_TextBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        WhatHappened_TextBox.Location = New Point(366, 154)
        WhatHappened_TextBox.Multiline = True
        WhatHappened_TextBox.Name = "WhatHappened_TextBox"
        WhatHappened_TextBox.ReadOnly = True
        WhatHappened_TextBox.ScrollBars = ScrollBars.Vertical
        WhatHappened_TextBox.Size = New Size(315, 180)
        WhatHappened_TextBox.TabIndex = 29
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label30.ForeColor = Color.Green
        Label30.Location = New Point(9, 351)
        Label30.Name = "Label30"
        Label30.Size = New Size(186, 28)
        Label30.TabIndex = 20
        Label30.Text = "Specific Case Type"
        ' 
        ' GeneralCaseName_Label
        ' 
        GeneralCaseName_Label.AutoSize = True
        GeneralCaseName_Label.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GeneralCaseName_Label.ForeColor = Color.Green
        GeneralCaseName_Label.Location = New Point(14, 34)
        GeneralCaseName_Label.Name = "GeneralCaseName_Label"
        GeneralCaseName_Label.Size = New Size(211, 41)
        GeneralCaseName_Label.TabIndex = 19
        GeneralCaseName_Label.Text = "General Cases"
        ' 
        ' SpecificCaseType_ComboBox
        ' 
        SpecificCaseType_ComboBox.BorderStyle = BorderStyle.FixedSingle
        SpecificCaseType_ComboBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SpecificCaseType_ComboBox.Location = New Point(14, 382)
        SpecificCaseType_ComboBox.Name = "SpecificCaseType_ComboBox"
        SpecificCaseType_ComboBox.ReadOnly = True
        SpecificCaseType_ComboBox.Size = New Size(336, 34)
        SpecificCaseType_ComboBox.TabIndex = 16
        ' 
        ' GeneralCasesLocation_TextBox
        ' 
        GeneralCasesLocation_TextBox.BorderStyle = BorderStyle.FixedSingle
        GeneralCasesLocation_TextBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GeneralCasesLocation_TextBox.Location = New Point(366, 82)
        GeneralCasesLocation_TextBox.Name = "GeneralCasesLocation_TextBox"
        GeneralCasesLocation_TextBox.ReadOnly = True
        GeneralCasesLocation_TextBox.Size = New Size(297, 34)
        GeneralCasesLocation_TextBox.TabIndex = 4
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label33.ForeColor = Color.Green
        Label33.Location = New Point(363, 34)
        Label33.Name = "Label33"
        Label33.Size = New Size(129, 38)
        Label33.TabIndex = 7
        Label33.Text = "Location"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.Green
        Label14.Location = New Point(1145, 366)
        Label14.Name = "Label14"
        Label14.Size = New Size(209, 31)
        Label14.TabIndex = 69
        Label14.Text = "Additional Photos"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Procedure_ListView)
        GroupBox1.Controls.Add(Label27)
        GroupBox1.Location = New Point(766, 223)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(372, 236)
        GroupBox1.TabIndex = 63
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Procedure_ListView
        ' 
        Procedure_ListView.FullRowSelect = True
        Procedure_ListView.HeaderStyle = ColumnHeaderStyle.Nonclickable
        Procedure_ListView.Location = New Point(0, 51)
        Procedure_ListView.Name = "Procedure_ListView"
        Procedure_ListView.Size = New Size(372, 179)
        Procedure_ListView.TabIndex = 50
        Procedure_ListView.UseCompatibleStateImageBehavior = False
        Procedure_ListView.View = View.Details
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label27.ForeColor = Color.Green
        Label27.Location = New Point(6, 20)
        Label27.Name = "Label27"
        Label27.Size = New Size(213, 28)
        Label27.TabIndex = 48
        Label27.Text = "Additional Procedure"
        ' 
        ' AdditionalPhotos_FlowLayoutPanel
        ' 
        AdditionalPhotos_FlowLayoutPanel.BackColor = Color.Green
        AdditionalPhotos_FlowLayoutPanel.Location = New Point(1145, 400)
        AdditionalPhotos_FlowLayoutPanel.Name = "AdditionalPhotos_FlowLayoutPanel"
        AdditionalPhotos_FlowLayoutPanel.Size = New Size(465, 261)
        AdditionalPhotos_FlowLayoutPanel.TabIndex = 68
        ' 
        ' CaseStatus_TxtBox
        ' 
        CaseStatus_TxtBox.BorderStyle = BorderStyle.FixedSingle
        CaseStatus_TxtBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CaseStatus_TxtBox.Location = New Point(766, 172)
        CaseStatus_TxtBox.Name = "CaseStatus_TxtBox"
        CaseStatus_TxtBox.ReadOnly = True
        CaseStatus_TxtBox.Size = New Size(173, 34)
        CaseStatus_TxtBox.TabIndex = 60
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.Green
        Label13.Location = New Point(766, 141)
        Label13.Name = "Label13"
        Label13.Size = New Size(120, 28)
        Label13.TabIndex = 53
        Label13.Text = "Case Status"
        ' 
        ' DateAndTimeReported_TxtBox
        ' 
        DateAndTimeReported_TxtBox.BorderStyle = BorderStyle.FixedSingle
        DateAndTimeReported_TxtBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateAndTimeReported_TxtBox.Location = New Point(766, 105)
        DateAndTimeReported_TxtBox.Name = "DateAndTimeReported_TxtBox"
        DateAndTimeReported_TxtBox.ReadOnly = True
        DateAndTimeReported_TxtBox.Size = New Size(253, 34)
        DateAndTimeReported_TxtBox.TabIndex = 59
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = Color.Green
        Label18.Location = New Point(766, 74)
        Label18.Name = "Label18"
        Label18.Size = New Size(245, 28)
        Label18.TabIndex = 55
        Label18.Text = "Date and Time Reported"
        ' 
        ' AdditionalInfo_TxtBox
        ' 
        AdditionalInfo_TxtBox.BorderStyle = BorderStyle.FixedSingle
        AdditionalInfo_TxtBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AdditionalInfo_TxtBox.Location = New Point(766, 500)
        AdditionalInfo_TxtBox.Multiline = True
        AdditionalInfo_TxtBox.Name = "AdditionalInfo_TxtBox"
        AdditionalInfo_TxtBox.ReadOnly = True
        AdditionalInfo_TxtBox.ScrollBars = ScrollBars.Vertical
        AdditionalInfo_TxtBox.Size = New Size(314, 139)
        AdditionalInfo_TxtBox.TabIndex = 51
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(ZoneName_TxtBox)
        GroupBox3.Controls.Add(FullName_TxtBox)
        GroupBox3.Controls.Add(Label39)
        GroupBox3.Controls.Add(Label38)
        GroupBox3.Controls.Add(PhoneNum_TxtBox)
        GroupBox3.Controls.Add(Label37)
        GroupBox3.Controls.Add(Email_textbox)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.FlatStyle = FlatStyle.Flat
        GroupBox3.Location = New Point(21, 500)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(490, 154)
        GroupBox3.TabIndex = 110
        GroupBox3.TabStop = False
        ' 
        ' ZoneName_TxtBox
        ' 
        ZoneName_TxtBox.BorderStyle = BorderStyle.FixedSingle
        ZoneName_TxtBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        ZoneName_TxtBox.Location = New Point(276, 52)
        ZoneName_TxtBox.Name = "ZoneName_TxtBox"
        ZoneName_TxtBox.ReadOnly = True
        ZoneName_TxtBox.Size = New Size(187, 30)
        ZoneName_TxtBox.TabIndex = 106
        ' 
        ' FullName_TxtBox
        ' 
        FullName_TxtBox.BorderStyle = BorderStyle.FixedSingle
        FullName_TxtBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        FullName_TxtBox.Location = New Point(276, 18)
        FullName_TxtBox.Name = "FullName_TxtBox"
        FullName_TxtBox.ReadOnly = True
        FullName_TxtBox.Size = New Size(187, 30)
        FullName_TxtBox.TabIndex = 98
        ' 
        ' Label39
        ' 
        Label39.AutoSize = True
        Label39.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label39.ForeColor = Color.Green
        Label39.Location = New Point(141, 52)
        Label39.Name = "Label39"
        Label39.Size = New Size(134, 23)
        Label39.TabIndex = 103
        Label39.Text = "Origins Of Case"
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label38.ForeColor = Color.Green
        Label38.Location = New Point(4, 87)
        Label38.Name = "Label38"
        Label38.Size = New Size(269, 25)
        Label38.TabIndex = 93
        Label38.Text = "Phone Number (09xxxxxxxxx)"
        ' 
        ' PhoneNum_TxtBox
        ' 
        PhoneNum_TxtBox.BorderStyle = BorderStyle.FixedSingle
        PhoneNum_TxtBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        PhoneNum_TxtBox.Location = New Point(276, 85)
        PhoneNum_TxtBox.Name = "PhoneNum_TxtBox"
        PhoneNum_TxtBox.ReadOnly = True
        PhoneNum_TxtBox.Size = New Size(187, 30)
        PhoneNum_TxtBox.TabIndex = 94
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label37.ForeColor = Color.Green
        Label37.Location = New Point(212, 122)
        Label37.Name = "Label37"
        Label37.Size = New Size(58, 25)
        Label37.TabIndex = 95
        Label37.Text = "Email"
        ' 
        ' Email_textbox
        ' 
        Email_textbox.BorderStyle = BorderStyle.FixedSingle
        Email_textbox.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Email_textbox.Location = New Point(276, 120)
        Email_textbox.Name = "Email_textbox"
        Email_textbox.ReadOnly = True
        Email_textbox.Size = New Size(187, 30)
        Email_textbox.TabIndex = 96
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Green
        Label5.Location = New Point(109, 18)
        Label5.Name = "Label5"
        Label5.Size = New Size(166, 25)
        Label5.TabIndex = 97
        Label5.Text = "Name of Reporter"
        ' 
        ' CaseIDString_TextBox
        ' 
        CaseIDString_TextBox.BorderStyle = BorderStyle.FixedSingle
        CaseIDString_TextBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CaseIDString_TextBox.Location = New Point(526, 541)
        CaseIDString_TextBox.Name = "CaseIDString_TextBox"
        CaseIDString_TextBox.ReadOnly = True
        CaseIDString_TextBox.Size = New Size(186, 34)
        CaseIDString_TextBox.TabIndex = 112
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Green
        Label8.Location = New Point(526, 510)
        Label8.Name = "Label8"
        Label8.Size = New Size(82, 28)
        Label8.TabIndex = 111
        Label8.Text = "Case ID"
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(3, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1621, 700)
        Panel1.TabIndex = 79
        Panel1.Visible = False
        ' 
        ' CaseRecordShowForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.Honeydew
        ClientSize = New Size(1626, 703)
        Controls.Add(TabControl2)
        Controls.Add(HiddenCaseID)
        Controls.Add(Panel1)
        Controls.Add(CaseID_Label)
        MaximizeBox = False
        MaximumSize = New Size(1718, 750)
        MinimumSize = New Size(859, 375)
        Name = "CaseRecordShowForm"
        ShowIcon = False
        Text = "CaseRecordShowForm"
        TabControl2.ResumeLayout(False)
        TabPage4.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(OfficersSent_DataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(CasePeople_DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        MissingPerson_GroupBox.ResumeLayout(False)
        MissingPerson_GroupBox.PerformLayout()
        CType(MissingPerson_PicBox, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        StolenItems_GroupBox.ResumeLayout(False)
        StolenItems_GroupBox.PerformLayout()
        CType(ItemDescription_DataGridView, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(GeneralCases_PicBox, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents CaseID_Label As Label
    Friend WithEvents HiddenCaseID As Label
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents OfficersSent_DataGridView As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CasePeople_DataGridView1 As DataGridView
    Friend WithEvents UpdateCaseData_Btn As Button
    Friend WithEvents CaseType_TxtBox As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents MissingPerson_GroupBox As GroupBox
    Friend WithEvents BrthDay_DateTimePicker As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents MissingPersonCaseName_Label As Label
    Friend WithEvents MissingPerson_PicBox As PictureBox
    Public WithEvents MissingPersonName_TxtBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MissingPersonAge_TxtBox As TextBox
    Friend WithEvents MissingPersonHeight_TxtBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents MissingPersonPhysicalDesc_TxtBox As TextBox
    Friend WithEvents MissingPersonLastSeenLocation_TxtBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents StolenItems_GroupBox As GroupBox
    Friend WithEvents Suspect_Physical_Desc As Label
    Friend WithEvents SuspectDesc_TxtBox As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents ItemDescription_DataGridView As DataGridView
    Friend WithEvents StolenItemsCaseName_Label As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents PropertyDamage_TextBox As TextBox
    Friend WithEvents TheftLocation_TxtBox As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GeneralCases_PicBox As PictureBox
    Friend WithEvents Label28 As Label
    Friend WithEvents WhatHappened_TextBox As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents GeneralCaseName_Label As Label
    Friend WithEvents SpecificCaseType_ComboBox As TextBox
    Friend WithEvents GeneralCasesLocation_TextBox As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label27 As Label
    Friend WithEvents AdditionalPhotos_FlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents CaseStatus_TxtBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents DateAndTimeReported_TxtBox As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents AdditionalInfo_TxtBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ZoneName_TxtBox As TextBox
    Friend WithEvents FullName_TxtBox As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents PhoneNum_TxtBox As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Email_textbox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CaseIDString_TextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label45 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents MissingPersonNo_TxtBox As TextBox
    Friend WithEvents MissingPersonEmail_TxtBox As TextBox
    Friend WithEvents Procedure_ListView As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents ExpectedResolveDare_TextBox As TextBox
    Friend WithEvents Label3 As Label
End Class
