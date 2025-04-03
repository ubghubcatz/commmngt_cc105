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
        Panel1 = New Panel()
        CallTime_TxtBox = New TextBox()
        Label5 = New Label()
        Status_TxtBox = New TextBox()
        Label6 = New Label()
        CallType_TxtBox = New TextBox()
        Handler_TxtBox = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Panel2 = New Panel()
        Label9 = New Label()
        CallId_Label = New Label()
        CallZone_TxtBox = New TextBox()
        Label10 = New Label()
        CType(CallNotes_Table, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Green
        Label1.Location = New Point(57, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 28)
        Label1.TabIndex = 0
        Label1.Text = "Number: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Green
        Label2.Location = New Point(55, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 28)
        Label2.TabIndex = 1
        Label2.Text = "Call Date:"
        ' 
        ' Number_TxtBox
        ' 
        Number_TxtBox.BackColor = Color.Honeydew
        Number_TxtBox.Enabled = False
        Number_TxtBox.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Number_TxtBox.ForeColor = Color.Green
        Number_TxtBox.Location = New Point(164, 5)
        Number_TxtBox.Name = "Number_TxtBox"
        Number_TxtBox.Size = New Size(271, 34)
        Number_TxtBox.TabIndex = 2
        ' 
        ' CallDate_TxtBox
        ' 
        CallDate_TxtBox.BackColor = Color.Honeydew
        CallDate_TxtBox.Enabled = False
        CallDate_TxtBox.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        CallDate_TxtBox.ForeColor = Color.Green
        CallDate_TxtBox.Location = New Point(164, 73)
        CallDate_TxtBox.Multiline = True
        CallDate_TxtBox.Name = "CallDate_TxtBox"
        CallDate_TxtBox.Size = New Size(271, 34)
        CallDate_TxtBox.TabIndex = 3
        ' 
        ' Purpose_Txbox
        ' 
        Purpose_Txbox.BackColor = Color.Honeydew
        Purpose_Txbox.Enabled = False
        Purpose_Txbox.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Purpose_Txbox.Location = New Point(164, 203)
        Purpose_Txbox.Multiline = True
        Purpose_Txbox.Name = "Purpose_Txbox"
        Purpose_Txbox.Size = New Size(357, 82)
        Purpose_Txbox.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Green
        Label3.Location = New Point(24, 199)
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
        Label4.Location = New Point(38, 309)
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
        CallNotes_Table.Location = New Point(38, 340)
        CallNotes_Table.Name = "CallNotes_Table"
        CallNotes_Table.RowHeadersWidth = 51
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        CallNotes_Table.RowsDefaultCellStyle = DataGridViewCellStyle1
        CallNotes_Table.Size = New Size(922, 187)
        CallNotes_Table.TabIndex = 7
        ' 
        ' AddNotes_Btn
        ' 
        AddNotes_Btn.BackColor = Color.Green
        AddNotes_Btn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddNotes_Btn.ForeColor = Color.White
        AddNotes_Btn.Location = New Point(866, 305)
        AddNotes_Btn.Name = "AddNotes_Btn"
        AddNotes_Btn.Size = New Size(94, 30)
        AddNotes_Btn.TabIndex = 8
        AddNotes_Btn.Text = "Add Note"
        AddNotes_Btn.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Green
        Panel1.Location = New Point(1088, -6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(89, 593)
        Panel1.TabIndex = 9
        ' 
        ' CallTime_TxtBox
        ' 
        CallTime_TxtBox.BackColor = Color.Honeydew
        CallTime_TxtBox.Enabled = False
        CallTime_TxtBox.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        CallTime_TxtBox.ForeColor = Color.Green
        CallTime_TxtBox.Location = New Point(164, 137)
        CallTime_TxtBox.Multiline = True
        CallTime_TxtBox.Name = "CallTime_TxtBox"
        CallTime_TxtBox.Size = New Size(271, 39)
        CallTime_TxtBox.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Green
        Label5.Location = New Point(53, 137)
        Label5.Name = "Label5"
        Label5.Size = New Size(105, 28)
        Label5.TabIndex = 10
        Label5.Text = "Call Time:"
        ' 
        ' Status_TxtBox
        ' 
        Status_TxtBox.BackColor = Color.Honeydew
        Status_TxtBox.Enabled = False
        Status_TxtBox.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Status_TxtBox.ForeColor = Color.Green
        Status_TxtBox.Location = New Point(770, 229)
        Status_TxtBox.Multiline = True
        Status_TxtBox.Name = "Status_TxtBox"
        Status_TxtBox.Size = New Size(190, 42)
        Status_TxtBox.TabIndex = 17
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Green
        Label6.Location = New Point(647, 229)
        Label6.Name = "Label6"
        Label6.Size = New Size(117, 28)
        Label6.TabIndex = 16
        Label6.Text = "Call Status:"
        ' 
        ' CallType_TxtBox
        ' 
        CallType_TxtBox.BackColor = Color.Honeydew
        CallType_TxtBox.Enabled = False
        CallType_TxtBox.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        CallType_TxtBox.ForeColor = Color.Green
        CallType_TxtBox.Location = New Point(770, 164)
        CallType_TxtBox.Multiline = True
        CallType_TxtBox.Name = "CallType_TxtBox"
        CallType_TxtBox.Size = New Size(190, 42)
        CallType_TxtBox.TabIndex = 15
        ' 
        ' Handler_TxtBox
        ' 
        Handler_TxtBox.BackColor = Color.Honeydew
        Handler_TxtBox.Enabled = False
        Handler_TxtBox.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Handler_TxtBox.ForeColor = Color.Green
        Handler_TxtBox.Location = New Point(770, 103)
        Handler_TxtBox.Name = "Handler_TxtBox"
        Handler_TxtBox.Size = New Size(244, 34)
        Handler_TxtBox.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Green
        Label7.Location = New Point(661, 171)
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
        Label8.Location = New Point(610, 101)
        Label8.Name = "Label8"
        Label8.Size = New Size(154, 28)
        Label8.TabIndex = 12
        Label8.Text = "Handler Name:"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Green
        Panel2.Controls.Add(Label9)
        Panel2.Location = New Point(878, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(299, 76)
        Panel2.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Green
        Label9.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(17, 14)
        Label9.Name = "Label9"
        Label9.Size = New Size(233, 54)
        Label9.TabIndex = 19
        Label9.Text = "Call Details"
        ' 
        ' CallId_Label
        ' 
        CallId_Label.AutoSize = True
        CallId_Label.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CallId_Label.ForeColor = Color.Honeydew
        CallId_Label.Location = New Point(811, -3)
        CallId_Label.Name = "CallId_Label"
        CallId_Label.Size = New Size(0, 31)
        CallId_Label.TabIndex = 19
        ' 
        ' CallZone_TxtBox
        ' 
        CallZone_TxtBox.BackColor = Color.Honeydew
        CallZone_TxtBox.Enabled = False
        CallZone_TxtBox.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        CallZone_TxtBox.ForeColor = Color.Green
        CallZone_TxtBox.Location = New Point(661, 10)
        CallZone_TxtBox.Multiline = True
        CallZone_TxtBox.Name = "CallZone_TxtBox"
        CallZone_TxtBox.Size = New Size(185, 42)
        CallZone_TxtBox.TabIndex = 21
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Green
        Label10.Location = New Point(538, 10)
        Label10.Name = "Label10"
        Label10.Size = New Size(105, 28)
        Label10.TabIndex = 20
        Label10.Text = "Call Zone:"
        ' 
        ' CallDetails
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        ClientSize = New Size(1155, 553)
        Controls.Add(CallZone_TxtBox)
        Controls.Add(Label10)
        Controls.Add(CallId_Label)
        Controls.Add(Panel2)
        Controls.Add(Status_TxtBox)
        Controls.Add(Label6)
        Controls.Add(CallType_TxtBox)
        Controls.Add(Handler_TxtBox)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(CallTime_TxtBox)
        Controls.Add(Label5)
        Controls.Add(Panel1)
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
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CallTime_TxtBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Status_TxtBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CallType_TxtBox As TextBox
    Friend WithEvents Handler_TxtBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents CallId_Label As Label
    Friend WithEvents CallZone_TxtBox As TextBox
    Friend WithEvents Label10 As Label
End Class
