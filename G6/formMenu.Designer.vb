<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMenu
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
        submit = New Button()
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        dtpDate = New DateTimePicker()
        attendeeCo = New TextBox()
        cmbType = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        eventName = New TextBox()
        DateTimePicker2 = New DateTimePicker()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label1 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        cmbvenue = New ComboBox()
        Label9 = New Label()
        conInfo = New TextBox()
        Label10 = New Label()
        nameInfo = New TextBox()
        Label14 = New Label()
        emailInfo = New TextBox()
        Label15 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Label16 = New Label()
        LastName = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' submit
        ' 
        submit.BackColor = Color.Green
        submit.FlatStyle = FlatStyle.Flat
        submit.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        submit.ForeColor = SystemColors.ControlLightLight
        submit.Location = New Point(772, 569)
        submit.Name = "submit"
        submit.Size = New Size(151, 52)
        submit.TabIndex = 48
        submit.Text = "Submit"
        submit.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 36)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(911, 442)
        DataGridView1.TabIndex = 39
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 20)
        Label2.TabIndex = 35
        ' 
        ' dtpDate
        ' 
        dtpDate.CustomFormat = "dd/MM/yyyy "
        dtpDate.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        dtpDate.Location = New Point(502, 526)
        dtpDate.MinDate = New Date(2025, 3, 2, 0, 0, 0, 0)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(244, 25)
        dtpDate.TabIndex = 30
        ' 
        ' attendeeCo
        ' 
        attendeeCo.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        attendeeCo.Location = New Point(257, 577)
        attendeeCo.Name = "attendeeCo"
        attendeeCo.Size = New Size(239, 25)
        attendeeCo.TabIndex = 41
        ' 
        ' cmbType
        ' 
        cmbType.FlatStyle = FlatStyle.Popup
        cmbType.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        cmbType.FormattingEnabled = True
        cmbType.Items.AddRange(New Object() {"Business", "Social", "Personal", "Meeting", "Seminar", "Other (consult with barangay)"})
        cmbType.Location = New Point(257, 628)
        cmbType.Name = "cmbType"
        cmbType.Size = New Size(239, 25)
        cmbType.TabIndex = 44
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "hh:mm tt"
        DateTimePicker1.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        DateTimePicker1.Format = DateTimePickerFormat.Time
        DateTimePicker1.Location = New Point(502, 580)
        DateTimePicker1.MinDate = New Date(2025, 3, 2, 0, 0, 0, 0)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.ShowUpDown = True
        DateTimePicker1.Size = New Size(244, 25)
        DateTimePicker1.TabIndex = 53
        ' 
        ' eventName
        ' 
        eventName.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        eventName.Location = New Point(257, 526)
        eventName.Name = "eventName"
        eventName.Size = New Size(239, 25)
        eventName.TabIndex = 51
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.CustomFormat = "hh:mm tt"
        DateTimePicker2.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        DateTimePicker2.Format = DateTimePickerFormat.Time
        DateTimePicker2.Location = New Point(502, 631)
        DateTimePicker2.MinDate = New Date(2025, 3, 2, 0, 0, 0, 0)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.ShowUpDown = True
        DateTimePicker2.Size = New Size(244, 25)
        DateTimePicker2.TabIndex = 54
        DateTimePicker2.Value = New Date(2025, 3, 16, 22, 32, 0, 0)
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(505, 607)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 17)
        Label3.TabIndex = 56
        Label3.Text = "END"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(502, 559)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 17)
        Label4.TabIndex = 55
        Label4.Text = "START"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(505, 505)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 17)
        Label5.TabIndex = 57
        Label5.Text = "DATE"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        Label11.ForeColor = SystemColors.ActiveCaptionText
        Label11.Location = New Point(257, 505)
        Label11.Name = "Label11"
        Label11.Size = New Size(112, 17)
        Label11.TabIndex = 60
        Label11.Text = "NAME OF EVENT"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        Label12.ForeColor = SystemColors.ActiveCaptionText
        Label12.Location = New Point(257, 607)
        Label12.Name = "Label12"
        Label12.Size = New Size(105, 17)
        Label12.TabIndex = 59
        Label12.Text = "TYPE OF EVENT"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        Label13.ForeColor = SystemColors.ActiveCaptionText
        Label13.Location = New Point(257, 556)
        Label13.Name = "Label13"
        Label13.Size = New Size(128, 17)
        Label13.TabIndex = 58
        Label13.Text = "NO. OF ATTENDEES" & vbCrLf
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(541, 481)
        Label1.Name = "Label1"
        Label1.Size = New Size(173, 17)
        Label1.TabIndex = 34
        Label1.Text = "----------SCHEDULE----------"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.Location = New Point(306, 481)
        Label7.Name = "Label7"
        Label7.Size = New Size(150, 17)
        Label7.TabIndex = 61
        Label7.Text = "----------VENUE----------"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        Label8.ForeColor = SystemColors.ActiveCaptionText
        Label8.Location = New Point(257, 658)
        Label8.Name = "Label8"
        Label8.Size = New Size(50, 17)
        Label8.TabIndex = 63
        Label8.Text = "VENUE" & vbCrLf
        ' 
        ' cmbvenue
        ' 
        cmbvenue.DropDownStyle = ComboBoxStyle.DropDownList
        cmbvenue.FlatStyle = FlatStyle.Popup
        cmbvenue.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        cmbvenue.FormattingEnabled = True
        cmbvenue.Items.AddRange(New Object() {"School", "Barangay Hall", "Inosluban Covered Court", "Other (consult with barangay)"})
        cmbvenue.Location = New Point(257, 679)
        cmbvenue.Name = "cmbvenue"
        cmbvenue.Size = New Size(239, 25)
        cmbvenue.TabIndex = 62
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        Label9.ForeColor = SystemColors.ActiveCaptionText
        Label9.Location = New Point(12, 607)
        Label9.Name = "Label9"
        Label9.Size = New Size(95, 17)
        Label9.TabIndex = 65
        Label9.Text = "CONTACT NO."
        ' 
        ' conInfo
        ' 
        conInfo.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        conInfo.Location = New Point(12, 628)
        conInfo.Name = "conInfo"
        conInfo.Size = New Size(239, 25)
        conInfo.TabIndex = 64
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Arial", 9F, FontStyle.Bold)
        Label10.ForeColor = SystemColors.ActiveCaptionText
        Label10.Location = New Point(12, 505)
        Label10.Name = "Label10"
        Label10.Size = New Size(51, 18)
        Label10.TabIndex = 67
        Label10.Text = "NAME"
        ' 
        ' nameInfo
        ' 
        nameInfo.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        nameInfo.Location = New Point(12, 526)
        nameInfo.Name = "nameInfo"
        nameInfo.Size = New Size(239, 25)
        nameInfo.TabIndex = 66
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Arial", 9F, FontStyle.Bold)
        Label14.ForeColor = SystemColors.ActiveCaptionText
        Label14.Location = New Point(12, 658)
        Label14.Name = "Label14"
        Label14.Size = New Size(53, 18)
        Label14.TabIndex = 71
        Label14.Text = "EMAIL"
        ' 
        ' emailInfo
        ' 
        emailInfo.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        emailInfo.Location = New Point(12, 679)
        emailInfo.Name = "emailInfo"
        emailInfo.Size = New Size(239, 25)
        emailInfo.TabIndex = 70
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.Black
        Label15.Location = New Point(266, 9)
        Label15.Name = "Label15"
        Label15.Size = New Size(433, 23)
        Label15.TabIndex = 72
        Label15.Text = "----------BOOKED SCHEDULES AND VENUES----------" & vbCrLf
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(69, 481)
        Label6.Name = "Label6"
        Label6.Size = New Size(139, 17)
        Label6.TabIndex = 73
        Label6.Text = "----------INFO----------"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Green
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(772, 511)
        Button1.Name = "Button1"
        Button1.Size = New Size(151, 52)
        Button1.TabIndex = 80
        Button1.Text = "Refresh Table"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Green
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(772, 630)
        Button2.Name = "Button2"
        Button2.Size = New Size(151, 52)
        Button2.TabIndex = 81
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.Font = New Font("Arial", 9F, FontStyle.Bold)
        Label16.ForeColor = SystemColors.ActiveCaptionText
        Label16.Location = New Point(12, 556)
        Label16.Name = "Label16"
        Label16.Size = New Size(93, 18)
        Label16.TabIndex = 83
        Label16.Text = "LAST NAME"
        ' 
        ' LastName
        ' 
        LastName.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        LastName.Location = New Point(12, 577)
        LastName.Name = "LastName"
        LastName.Size = New Size(239, 25)
        LastName.TabIndex = 82
        ' 
        ' formMenu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.FromArgb(CByte(71), CByte(184), CByte(129))
        BackgroundImage = My.Resources.Resources._1_bg
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(935, 718)
        Controls.Add(Label16)
        Controls.Add(LastName)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(emailInfo)
        Controls.Add(Label10)
        Controls.Add(nameInfo)
        Controls.Add(Label9)
        Controls.Add(conInfo)
        Controls.Add(Label8)
        Controls.Add(cmbvenue)
        Controls.Add(Label7)
        Controls.Add(Label11)
        Controls.Add(Label12)
        Controls.Add(Label13)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(eventName)
        Controls.Add(submit)
        Controls.Add(cmbType)
        Controls.Add(attendeeCo)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dtpDate)
        FormBorderStyle = FormBorderStyle.None
        Name = "formMenu"
        Text = "formMenu"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents submit As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents attendeeCo As TextBox
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents eventName As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbvenue As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents conInfo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents nameInfo As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents emailInfo As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents LastName As TextBox
End Class
