<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CallDetails
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        Label2 = New Label()
        Number_TxtBox = New TextBox()
        CallDate_TxtBox = New TextBox()
        Purpose_Txbox = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        CallNotes_Table = New DataGridView()
        AddNotes_Btn = New Button()
        Status_TxtBox = New TextBox()
        Label6 = New Label()
        CallType_TxtBox = New TextBox()
        Handler_TxtBox = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        CallId_Label = New Label()
        CallZone_TxtBox = New TextBox()
        Label10 = New Label()
        Email_TextBox = New TextBox()
        Label9 = New Label()
        Name_Text = New TextBox()
        Label11 = New Label()
        Report_Origins_Text = New TextBox()
        Report_Origins = New Label()
        label90 = New Label()
        ConnectedCase_Label = New Label()
        CType(CallNotes_Table, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Green
        Label1.Location = New Point(66, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 28)
        Label1.TabIndex = 0
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Green
        Label2.Location = New Point(38, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 28)
        Label2.TabIndex = 1
        Label2.Text = "Call Date:"
        ' 
        ' Number_TxtBox
        ' 
        Number_TxtBox.BackColor = Color.White
        Number_TxtBox.BorderStyle = BorderStyle.FixedSingle
        Number_TxtBox.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Number_TxtBox.ForeColor = Color.Black
        Number_TxtBox.Location = New Point(145, 94)
        Number_TxtBox.Name = "Number_TxtBox"
        Number_TxtBox.ReadOnly = True
        Number_TxtBox.Size = New Size(271, 34)
        Number_TxtBox.TabIndex = 2
        ' 
        ' CallDate_TxtBox
        ' 
        CallDate_TxtBox.BackColor = Color.White
        CallDate_TxtBox.BorderStyle = BorderStyle.FixedSingle
        CallDate_TxtBox.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        CallDate_TxtBox.ForeColor = Color.Black
        CallDate_TxtBox.Location = New Point(145, 134)
        CallDate_TxtBox.Multiline = True
        CallDate_TxtBox.Name = "CallDate_TxtBox"
        CallDate_TxtBox.ReadOnly = True
        CallDate_TxtBox.Size = New Size(271, 34)
        CallDate_TxtBox.TabIndex = 3
        ' 
        ' Purpose_Txbox
        ' 
        Purpose_Txbox.BackColor = Color.White
        Purpose_Txbox.BorderStyle = BorderStyle.FixedSingle
        Purpose_Txbox.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Purpose_Txbox.ForeColor = Color.Black
        Purpose_Txbox.Location = New Point(145, 174)
        Purpose_Txbox.Multiline = True
        Purpose_Txbox.Name = "Purpose_Txbox"
        Purpose_Txbox.ReadOnly = True
        Purpose_Txbox.Size = New Size(271, 82)
        Purpose_Txbox.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Green
        Label3.Location = New Point(5, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 28)
        Label3.TabIndex = 4
        Label3.Text = "Call Purpose:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Green
        Label4.Location = New Point(22, 269)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 28)
        Label4.TabIndex = 6
        Label4.Text = "Call Notes:"
        ' 
        ' CallNotes_Table
        ' 
        CallNotes_Table.AllowUserToAddRows = False
        CallNotes_Table.AllowUserToDeleteRows = False
        CallNotes_Table.AllowUserToResizeColumns = False
        CallNotes_Table.AllowUserToResizeRows = False
        CallNotes_Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        CallNotes_Table.Location = New Point(22, 300)
        CallNotes_Table.Name = "CallNotes_Table"
        CallNotes_Table.RowHeadersWidth = 51
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        CallNotes_Table.RowsDefaultCellStyle = DataGridViewCellStyle1
        CallNotes_Table.Size = New Size(822, 241)
        CallNotes_Table.TabIndex = 7
        ' 
        ' AddNotes_Btn
        ' 
        AddNotes_Btn.BackColor = Color.Green
        AddNotes_Btn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddNotes_Btn.ForeColor = Color.White
        AddNotes_Btn.Location = New Point(750, 264)
        AddNotes_Btn.Name = "AddNotes_Btn"
        AddNotes_Btn.Size = New Size(94, 30)
        AddNotes_Btn.TabIndex = 8
        AddNotes_Btn.Text = "Add Note"
        AddNotes_Btn.UseVisualStyleBackColor = False
        ' 
        ' Status_TxtBox
        ' 
        Status_TxtBox.BackColor = Color.White
        Status_TxtBox.BorderStyle = BorderStyle.FixedSingle
        Status_TxtBox.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Status_TxtBox.ForeColor = Color.Black
        Status_TxtBox.Location = New Point(592, 139)
        Status_TxtBox.Name = "Status_TxtBox"
        Status_TxtBox.ReadOnly = True
        Status_TxtBox.Size = New Size(190, 34)
        Status_TxtBox.TabIndex = 17
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Green
        Label6.Location = New Point(469, 139)
        Label6.Name = "Label6"
        Label6.Size = New Size(117, 28)
        Label6.TabIndex = 16
        Label6.Text = "Call Status:"
        ' 
        ' CallType_TxtBox
        ' 
        CallType_TxtBox.BackColor = Color.White
        CallType_TxtBox.BorderStyle = BorderStyle.FixedSingle
        CallType_TxtBox.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        CallType_TxtBox.ForeColor = Color.Black
        CallType_TxtBox.Location = New Point(592, 99)
        CallType_TxtBox.Name = "CallType_TxtBox"
        CallType_TxtBox.ReadOnly = True
        CallType_TxtBox.Size = New Size(190, 34)
        CallType_TxtBox.TabIndex = 15
        ' 
        ' Handler_TxtBox
        ' 
        Handler_TxtBox.BackColor = Color.White
        Handler_TxtBox.BorderStyle = BorderStyle.FixedSingle
        Handler_TxtBox.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Handler_TxtBox.ForeColor = Color.Black
        Handler_TxtBox.Location = New Point(592, 59)
        Handler_TxtBox.Name = "Handler_TxtBox"
        Handler_TxtBox.ReadOnly = True
        Handler_TxtBox.Size = New Size(190, 34)
        Handler_TxtBox.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Green
        Label7.Location = New Point(483, 99)
        Label7.Name = "Label7"
        Label7.Size = New Size(103, 28)
        Label7.TabIndex = 13
        Label7.Text = "Call Type:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Green
        Label8.Location = New Point(432, 59)
        Label8.Name = "Label8"
        Label8.Size = New Size(154, 28)
        Label8.TabIndex = 12
        Label8.Text = "Handler Name:"
        ' 
        ' CallId_Label
        ' 
        CallId_Label.AutoSize = True
        CallId_Label.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CallId_Label.ForeColor = Color.Honeydew
        CallId_Label.Location = New Point(794, -7)
        CallId_Label.Name = "CallId_Label"
        CallId_Label.Size = New Size(0, 31)
        CallId_Label.TabIndex = 19
        ' 
        ' CallZone_TxtBox
        ' 
        CallZone_TxtBox.BackColor = Color.White
        CallZone_TxtBox.BorderStyle = BorderStyle.FixedSingle
        CallZone_TxtBox.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        CallZone_TxtBox.ForeColor = Color.Black
        CallZone_TxtBox.Location = New Point(592, 19)
        CallZone_TxtBox.Name = "CallZone_TxtBox"
        CallZone_TxtBox.ReadOnly = True
        CallZone_TxtBox.Size = New Size(190, 34)
        CallZone_TxtBox.TabIndex = 21
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Green
        Label10.Location = New Point(481, 19)
        Label10.Name = "Label10"
        Label10.Size = New Size(105, 28)
        Label10.TabIndex = 20
        Label10.Text = "Call Zone:"
        ' 
        ' Email_TextBox
        ' 
        Email_TextBox.BackColor = Color.White
        Email_TextBox.BorderStyle = BorderStyle.FixedSingle
        Email_TextBox.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Email_TextBox.ForeColor = Color.Black
        Email_TextBox.Location = New Point(145, 54)
        Email_TextBox.Name = "Email_TextBox"
        Email_TextBox.ReadOnly = True
        Email_TextBox.Size = New Size(271, 34)
        Email_TextBox.TabIndex = 23
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Green
        Label9.Location = New Point(70, 56)
        Label9.Name = "Label9"
        Label9.Size = New Size(69, 28)
        Label9.TabIndex = 22
        Label9.Text = "Email:"
        ' 
        ' Name_Text
        ' 
        Name_Text.BackColor = Color.White
        Name_Text.BorderStyle = BorderStyle.FixedSingle
        Name_Text.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name_Text.ForeColor = Color.Black
        Name_Text.Location = New Point(145, 12)
        Name_Text.Name = "Name_Text"
        Name_Text.ReadOnly = True
        Name_Text.Size = New Size(271, 34)
        Name_Text.TabIndex = 25
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Green
        Label11.Location = New Point(38, 94)
        Label11.Name = "Label11"
        Label11.Size = New Size(101, 28)
        Label11.TabIndex = 24
        Label11.Text = "Number: "
        ' 
        ' Report_Origins_Text
        ' 
        Report_Origins_Text.BackColor = Color.White
        Report_Origins_Text.BorderStyle = BorderStyle.FixedSingle
        Report_Origins_Text.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Report_Origins_Text.ForeColor = Color.Black
        Report_Origins_Text.Location = New Point(592, 179)
        Report_Origins_Text.Name = "Report_Origins_Text"
        Report_Origins_Text.ReadOnly = True
        Report_Origins_Text.Size = New Size(190, 34)
        Report_Origins_Text.TabIndex = 27
        ' 
        ' Report_Origins
        ' 
        Report_Origins.AutoSize = True
        Report_Origins.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Report_Origins.ForeColor = Color.Green
        Report_Origins.Location = New Point(486, 179)
        Report_Origins.Name = "Report_Origins"
        Report_Origins.Size = New Size(100, 28)
        Report_Origins.TabIndex = 26
        Report_Origins.Text = "Platform:"
        ' 
        ' label90
        ' 
        label90.AutoSize = True
        label90.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label90.ForeColor = Color.Green
        label90.Location = New Point(422, 228)
        label90.Name = "label90"
        label90.Size = New Size(166, 28)
        label90.TabIndex = 28
        label90.Text = "Connected Case:"
        ' 
        ' ConnectedCase_Label
        ' 
        ConnectedCase_Label.AutoSize = True
        ConnectedCase_Label.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ConnectedCase_Label.ForeColor = Color.Green
        ConnectedCase_Label.Location = New Point(592, 228)
        ConnectedCase_Label.Name = "ConnectedCase_Label"
        ConnectedCase_Label.Size = New Size(50, 28)
        ConnectedCase_Label.TabIndex = 29
        ConnectedCase_Label.Text = "Test"
        ' 
        ' CallDetails
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        ClientSize = New Size(865, 553)
        Controls.Add(ConnectedCase_Label)
        Controls.Add(label90)
        Controls.Add(Report_Origins_Text)
        Controls.Add(Report_Origins)
        Controls.Add(Name_Text)
        Controls.Add(Label11)
        Controls.Add(Email_TextBox)
        Controls.Add(Label9)
        Controls.Add(CallZone_TxtBox)
        Controls.Add(Label10)
        Controls.Add(CallId_Label)
        Controls.Add(Status_TxtBox)
        Controls.Add(Label6)
        Controls.Add(CallType_TxtBox)
        Controls.Add(Handler_TxtBox)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(AddNotes_Btn)
        Controls.Add(CallNotes_Table)
        Controls.Add(Label4)
        Controls.Add(Purpose_Txbox)
        Controls.Add(Label3)
        Controls.Add(CallDate_TxtBox)
        Controls.Add(Number_TxtBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        MaximumSize = New Size(1259, 672)
        MinimumSize = New Size(600, 600)
        Name = "CallDetails"
        Text = "CallDetails"
        CType(CallNotes_Table, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Number_TxtBox As TextBox
    Friend WithEvents CallDate_TxtBox As TextBox
    Friend WithEvents Purpose_Txbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CallNotes_Table As DataGridView
    Friend WithEvents AddNotes_Btn As Button
    Friend WithEvents Status_TxtBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CallType_TxtBox As TextBox
    Friend WithEvents Handler_TxtBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CallId_Label As Label
    Friend WithEvents CallZone_TxtBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Email_TextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Name_Text As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Report_Origins_Text As TextBox
    Friend WithEvents Report_Origins As Label
    Friend WithEvents label90 As Label
    Friend WithEvents ConnectedCase_Label As Label
End Class
