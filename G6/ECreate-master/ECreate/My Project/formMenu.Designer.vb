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
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' submit
        ' 
        submit.BackColor = Color.Green
        submit.FlatStyle = FlatStyle.Flat
        submit.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        submit.ForeColor = SystemColors.ControlLightLight
        submit.Location = New Point(132, 620)
        submit.Name = "submit"
        submit.Size = New Size(94, 43)
        submit.TabIndex = 48
        submit.Text = "Submit"
        submit.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(462, 28)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(461, 635)
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
        dtpDate.Location = New Point(180, 482)
        dtpDate.MinDate = New Date(2025, 3, 2, 0, 0, 0, 0)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(244, 27)
        dtpDate.TabIndex = 30
        ' 
        ' attendeeCo
        ' 
        attendeeCo.Location = New Point(185, 332)
        attendeeCo.Name = "attendeeCo"
        attendeeCo.Size = New Size(239, 27)
        attendeeCo.TabIndex = 41
        ' 
        ' cmbType
        ' 
        cmbType.FlatStyle = FlatStyle.Popup
        cmbType.FormattingEnabled = True
        cmbType.Items.AddRange(New Object() {"Business", "Social", "Personal"})
        cmbType.Location = New Point(185, 365)
        cmbType.Name = "cmbType"
        cmbType.Size = New Size(239, 28)
        cmbType.TabIndex = 44
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "hh:mm tt"
        DateTimePicker1.Format = DateTimePickerFormat.Time
        DateTimePicker1.Location = New Point(180, 515)
        DateTimePicker1.MinDate = New Date(2025, 3, 2, 0, 0, 0, 0)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.ShowUpDown = True
        DateTimePicker1.Size = New Size(244, 27)
        DateTimePicker1.TabIndex = 53
        ' 
        ' eventName
        ' 
        eventName.Location = New Point(185, 300)
        eventName.Name = "eventName"
        eventName.Size = New Size(239, 27)
        eventName.TabIndex = 51
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.CustomFormat = "hh:mm tt"
        DateTimePicker2.Format = DateTimePickerFormat.Time
        DateTimePicker2.Location = New Point(180, 549)
        DateTimePicker2.MinDate = New Date(2025, 3, 2, 0, 0, 0, 0)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.ShowUpDown = True
        DateTimePicker2.Size = New Size(244, 27)
        DateTimePicker2.TabIndex = 54
        DateTimePicker2.Value = New Date(2025, 3, 16, 22, 32, 0, 0)
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 9F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(132, 556)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 18)
        Label3.TabIndex = 56
        Label3.Text = "END"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 9F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(115, 522)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 18)
        Label4.TabIndex = 55
        Label4.Text = "START"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 9F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(125, 489)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 18)
        Label5.TabIndex = 57
        Label5.Text = "DATE"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial", 9F, FontStyle.Bold)
        Label11.ForeColor = SystemColors.ControlLightLight
        Label11.Location = New Point(49, 305)
        Label11.Name = "Label11"
        Label11.Size = New Size(130, 18)
        Label11.TabIndex = 60
        Label11.Text = "NAME OF EVENT"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial", 9F, FontStyle.Bold)
        Label12.ForeColor = SystemColors.ControlLightLight
        Label12.Location = New Point(52, 370)
        Label12.Name = "Label12"
        Label12.Size = New Size(127, 18)
        Label12.TabIndex = 59
        Label12.Text = "TYPE OF EVENT"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Arial", 9F, FontStyle.Bold)
        Label13.ForeColor = SystemColors.ControlLightLight
        Label13.Location = New Point(26, 337)
        Label13.Name = "Label13"
        Label13.Size = New Size(153, 18)
        Label13.TabIndex = 58
        Label13.Text = "NO. OF ATTENDEES" & vbCrLf
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Text", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(115, 444)
        Label1.Name = "Label1"
        Label1.Size = New Size(223, 24)
        Label1.TabIndex = 34
        Label1.Text = "----------SCHEDULE----------"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Sitka Text", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(132, 252)
        Label7.Name = "Label7"
        Label7.Size = New Size(190, 24)
        Label7.TabIndex = 61
        Label7.Text = "----------VENUE----------"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 9F, FontStyle.Bold)
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(118, 404)
        Label8.Name = "Label8"
        Label8.Size = New Size(59, 18)
        Label8.TabIndex = 63
        Label8.Text = "VENUE" & vbCrLf
        ' 
        ' cmbvenue
        ' 
        cmbvenue.DropDownStyle = ComboBoxStyle.DropDownList
        cmbvenue.FlatStyle = FlatStyle.Popup
        cmbvenue.FormattingEnabled = True
        cmbvenue.Items.AddRange(New Object() {"Divine Grace Leisure Park", "De Novo", "Inosluban Covered Court", "Aquamarine Recreational Center (outside Inosluban)", "Peñafrancia (outside Inosluban)", "Blue Sapphire Hotel (outside Inosluban)", "Private Resort and Event (outside Inosluban)", "Pacita's Garden and Catering (outside Inosluban)"})
        cmbvenue.Location = New Point(185, 399)
        cmbvenue.Name = "cmbvenue"
        cmbvenue.Size = New Size(239, 28)
        cmbvenue.TabIndex = 62
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 9F, FontStyle.Bold)
        Label9.ForeColor = SystemColors.ControlLightLight
        Label9.Location = New Point(67, 176)
        Label9.Name = "Label9"
        Label9.Size = New Size(112, 18)
        Label9.TabIndex = 65
        Label9.Text = "CONTACT NO."
        ' 
        ' conInfo
        ' 
        conInfo.Location = New Point(185, 171)
        conInfo.Name = "conInfo"
        conInfo.Size = New Size(239, 27)
        conInfo.TabIndex = 64
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 9F, FontStyle.Bold)
        Label10.ForeColor = SystemColors.ControlLightLight
        Label10.Location = New Point(126, 143)
        Label10.Name = "Label10"
        Label10.Size = New Size(51, 18)
        Label10.TabIndex = 67
        Label10.Text = "NAME"
        ' 
        ' nameInfo
        ' 
        nameInfo.Location = New Point(185, 138)
        nameInfo.Name = "nameInfo"
        nameInfo.Size = New Size(239, 27)
        nameInfo.TabIndex = 66
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Arial", 9F, FontStyle.Bold)
        Label14.ForeColor = SystemColors.ControlLightLight
        Label14.Location = New Point(126, 211)
        Label14.Name = "Label14"
        Label14.Size = New Size(53, 18)
        Label14.TabIndex = 71
        Label14.Text = "EMAIL"
        ' 
        ' emailInfo
        ' 
        emailInfo.Location = New Point(185, 206)
        emailInfo.Name = "emailInfo"
        emailInfo.Size = New Size(239, 27)
        emailInfo.TabIndex = 70
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Sitka Text", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.Black
        Label15.Location = New Point(482, 1)
        Label15.Name = "Label15"
        Label15.Size = New Size(426, 24)
        Label15.TabIndex = 72
        Label15.Text = "----------BOOKED SCHEDULES AND VENUES----------" & vbCrLf
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Sitka Text", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(140, 101)
        Label6.Name = "Label6"
        Label6.Size = New Size(172, 24)
        Label6.TabIndex = 73
        Label6.Text = "----------INFO----------"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.bottomLeft
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(3, 581)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 125)
        PictureBox1.TabIndex = 76
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.bottomRight
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(331, 581)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(125, 125)
        PictureBox2.TabIndex = 77
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImage = My.Resources.Resources.topLeft
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(3, 8)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(125, 129)
        PictureBox3.TabIndex = 78
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.BackgroundImage = My.Resources.Resources.topRight
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(331, 8)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(125, 125)
        PictureBox4.TabIndex = 79
        PictureBox4.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Green
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(644, 669)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 43)
        Button1.TabIndex = 80
        Button1.Text = "Refresh"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Green
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(234, 620)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 43)
        Button2.TabIndex = 81
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' formMenu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(71), CByte(184), CByte(129))
        ClientSize = New Size(935, 718)
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
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        FormBorderStyle = FormBorderStyle.None
        Name = "formMenu"
        Text = "formMenu"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
