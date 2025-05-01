<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ApprovedMENU
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
        DataGridView1 = New DataGridView()
        Label6 = New Label()
        Label14 = New Label()
        email = New TextBox()
        Label10 = New Label()
        nameInfo = New TextBox()
        Label9 = New Label()
        con = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        eventName = New TextBox()
        attend = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        lname = New TextBox()
        Button2 = New Button()
        endsche = New TextBox()
        startsche = New TextBox()
        datesche = New TextBox()
        type = New TextBox()
        venue = New TextBox()
        Button1 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(911, 467)
        DataGridView1.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(56, 482)
        Label6.Name = "Label6"
        Label6.Size = New Size(139, 17)
        Label6.TabIndex = 121
        Label6.Text = "----------INFO----------"
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
        Label14.TabIndex = 120
        Label14.Text = "EMAIL"
        ' 
        ' email
        ' 
        email.Location = New Point(12, 679)
        email.Name = "email"
        email.ReadOnly = True
        email.Size = New Size(239, 27)
        email.TabIndex = 119
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Arial", 9F, FontStyle.Bold)
        Label10.ForeColor = SystemColors.ActiveCaptionText
        Label10.Location = New Point(12, 506)
        Label10.Name = "Label10"
        Label10.Size = New Size(51, 18)
        Label10.TabIndex = 118
        Label10.Text = "NAME"
        ' 
        ' nameInfo
        ' 
        nameInfo.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        nameInfo.Location = New Point(12, 527)
        nameInfo.Name = "nameInfo"
        nameInfo.ReadOnly = True
        nameInfo.Size = New Size(239, 25)
        nameInfo.TabIndex = 117
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Arial", 9F, FontStyle.Bold)
        Label9.ForeColor = SystemColors.ActiveCaptionText
        Label9.Location = New Point(12, 607)
        Label9.Name = "Label9"
        Label9.Size = New Size(112, 18)
        Label9.TabIndex = 116
        Label9.Text = "CONTACT NO."
        ' 
        ' con
        ' 
        con.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        con.Location = New Point(12, 628)
        con.Name = "con"
        con.ReadOnly = True
        con.Size = New Size(239, 25)
        con.TabIndex = 115
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
        Label8.TabIndex = 114
        Label8.Text = "VENUE" & vbCrLf
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.Location = New Point(298, 482)
        Label7.Name = "Label7"
        Label7.Size = New Size(150, 17)
        Label7.TabIndex = 112
        Label7.Text = "----------VENUE----------"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        Label11.ForeColor = SystemColors.ActiveCaptionText
        Label11.Location = New Point(257, 506)
        Label11.Name = "Label11"
        Label11.Size = New Size(112, 17)
        Label11.TabIndex = 111
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
        Label12.TabIndex = 110
        Label12.Text = "TYPE OF EVENT"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        Label13.ForeColor = SystemColors.ActiveCaptionText
        Label13.Location = New Point(257, 557)
        Label13.Name = "Label13"
        Label13.Size = New Size(128, 17)
        Label13.TabIndex = 109
        Label13.Text = "NO. OF ATTENDEES" & vbCrLf
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(502, 506)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 17)
        Label5.TabIndex = 108
        Label5.Text = "DATE"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(502, 608)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 17)
        Label3.TabIndex = 107
        Label3.Text = "END"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(502, 557)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 17)
        Label4.TabIndex = 106
        Label4.Text = "START"
        ' 
        ' eventName
        ' 
        eventName.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        eventName.Location = New Point(257, 527)
        eventName.Name = "eventName"
        eventName.ReadOnly = True
        eventName.Size = New Size(239, 25)
        eventName.TabIndex = 103
        ' 
        ' attend
        ' 
        attend.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        attend.Location = New Point(257, 578)
        attend.Name = "attend"
        attend.ReadOnly = True
        attend.Size = New Size(239, 25)
        attend.TabIndex = 101
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(534, 482)
        Label1.Name = "Label1"
        Label1.Size = New Size(173, 17)
        Label1.TabIndex = 100
        Label1.Text = "----------SCHEDULE----------"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 9F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(12, 557)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 18)
        Label2.TabIndex = 125
        Label2.Text = "LAST NAME"
        ' 
        ' lname
        ' 
        lname.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        lname.Location = New Point(12, 578)
        lname.Name = "lname"
        lname.ReadOnly = True
        lname.Size = New Size(239, 25)
        lname.TabIndex = 124
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Green
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(767, 624)
        Button2.Name = "Button2"
        Button2.Size = New Size(143, 63)
        Button2.TabIndex = 127
        Button2.Text = "COMPLETE"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' endsche
        ' 
        endsche.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        endsche.Location = New Point(502, 628)
        endsche.Name = "endsche"
        endsche.ReadOnly = True
        endsche.Size = New Size(239, 25)
        endsche.TabIndex = 130
        ' 
        ' startsche
        ' 
        startsche.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        startsche.Location = New Point(502, 577)
        startsche.Name = "startsche"
        startsche.ReadOnly = True
        startsche.Size = New Size(239, 25)
        startsche.TabIndex = 129
        ' 
        ' datesche
        ' 
        datesche.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        datesche.Location = New Point(502, 527)
        datesche.Name = "datesche"
        datesche.ReadOnly = True
        datesche.Size = New Size(239, 25)
        datesche.TabIndex = 128
        ' 
        ' type
        ' 
        type.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        type.Location = New Point(257, 630)
        type.Name = "type"
        type.ReadOnly = True
        type.Size = New Size(239, 25)
        type.TabIndex = 132
        ' 
        ' venue
        ' 
        venue.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        venue.Location = New Point(257, 681)
        venue.Name = "venue"
        venue.ReadOnly = True
        venue.Size = New Size(239, 25)
        venue.TabIndex = 131
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Green
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(767, 555)
        Button1.Name = "Button1"
        Button1.Size = New Size(143, 63)
        Button1.TabIndex = 133
        Button1.Text = "REFRESH TABLE"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ApprovedMENU
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(71), CByte(184), CByte(129))
        BackgroundImage = My.Resources.Resources._1_bg
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(935, 718)
        Controls.Add(Button1)
        Controls.Add(type)
        Controls.Add(venue)
        Controls.Add(endsche)
        Controls.Add(startsche)
        Controls.Add(datesche)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Controls.Add(lname)
        Controls.Add(Label6)
        Controls.Add(Label14)
        Controls.Add(email)
        Controls.Add(Label10)
        Controls.Add(nameInfo)
        Controls.Add(Label9)
        Controls.Add(con)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label11)
        Controls.Add(Label12)
        Controls.Add(Label13)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(eventName)
        Controls.Add(attend)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ApprovedMENU"
        Text = "ApprovedMENU"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents nameInfo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents con As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents eventName As TextBox
    Friend WithEvents attend As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lname As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents endsche As TextBox
    Friend WithEvents startsche As TextBox
    Friend WithEvents datesche As TextBox
    Friend WithEvents type As TextBox
    Friend WithEvents venue As TextBox
    Friend WithEvents Button1 As Button
End Class
