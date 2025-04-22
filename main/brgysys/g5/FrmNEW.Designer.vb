<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNEW
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        btnCLOSE = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        DisasterName = New TextBox()
        txtLocation = New TextBox()
        ResidentPhoneNumber = New TextBox()
        Incident = New TextBox()
        Description = New TextBox()
        DisasterDate = New DateTimePicker()
        btnSave = New Button()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(60))
        Panel1.Controls.Add(btnCLOSE)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 65)
        Panel1.TabIndex = 1
        ' 
        ' btnCLOSE
        ' 
        btnCLOSE.BackColor = Color.Gray
        btnCLOSE.FlatStyle = FlatStyle.Flat
        btnCLOSE.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCLOSE.Location = New Point(686, 5)
        btnCLOSE.Name = "btnCLOSE"
        btnCLOSE.Size = New Size(111, 53)
        btnCLOSE.TabIndex = 3
        btnCLOSE.Text = "CLOSE"
        btnCLOSE.TextImageRelation = TextImageRelation.ImageAboveText
        btnCLOSE.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(11, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(242, 24)
        Label1.TabIndex = 0
        Label1.Text = "BRGY. INOSLUBAN LIPA CITY"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(43, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 2
        Label2.Text = "NAME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(43, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 20)
        Label3.TabIndex = 3
        Label3.Text = "DATE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(43, 161)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 20)
        Label4.TabIndex = 4
        Label4.Text = "LOCATION"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(34, 231)
        Label5.Name = "Label5"
        Label5.Size = New Size(147, 20)
        Label5.TabIndex = 5
        Label5.Text = "CONTACT NUMBER"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(89, 13)
        Label6.Name = "Label6"
        Label6.Size = New Size(107, 20)
        Label6.TabIndex = 6
        Label6.Text = "TYPE OF ITEM"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(101, 93)
        Label7.Name = "Label7"
        Label7.Size = New Size(106, 20)
        Label7.TabIndex = 7
        Label7.Text = "DESCRIPTION"
        ' 
        ' DisasterName
        ' 
        DisasterName.Location = New Point(112, 26)
        DisasterName.Name = "DisasterName"
        DisasterName.Size = New Size(207, 27)
        DisasterName.TabIndex = 8
        ' 
        ' txtLocation
        ' 
        txtLocation.Location = New Point(127, 161)
        txtLocation.Name = "txtLocation"
        txtLocation.Size = New Size(207, 27)
        txtLocation.TabIndex = 10
        ' 
        ' ResidentPhoneNumber
        ' 
        ResidentPhoneNumber.Location = New Point(187, 228)
        ResidentPhoneNumber.Name = "ResidentPhoneNumber"
        ResidentPhoneNumber.Size = New Size(207, 27)
        ResidentPhoneNumber.TabIndex = 11
        ' 
        ' Incident
        ' 
        Incident.Location = New Point(40, 48)
        Incident.Name = "Incident"
        Incident.Size = New Size(207, 27)
        Incident.TabIndex = 12
        ' 
        ' Description
        ' 
        Description.Location = New Point(40, 135)
        Description.Multiline = True
        Description.Name = "Description"
        Description.Size = New Size(207, 120)
        Description.TabIndex = 13
        ' 
        ' DisasterDate
        ' 
        DisasterDate.Location = New Point(112, 88)
        DisasterDate.Name = "DisasterDate"
        DisasterDate.Size = New Size(250, 27)
        DisasterDate.TabIndex = 14
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(373, 391)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 15
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.DarkSeaGreen
        GroupBox1.Controls.Add(Description)
        GroupBox1.Controls.Add(Incident)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Location = New Point(482, 108)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(291, 272)
        GroupBox1.TabIndex = 16
        GroupBox1.TabStop = False
        GroupBox1.Text = "DETAILS"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.DarkSeaGreen
        GroupBox2.Controls.Add(DisasterDate)
        GroupBox2.Controls.Add(ResidentPhoneNumber)
        GroupBox2.Controls.Add(txtLocation)
        GroupBox2.Controls.Add(DisasterName)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Location = New Point(35, 108)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(418, 266)
        GroupBox2.TabIndex = 17
        GroupBox2.TabStop = False
        GroupBox2.Text = "INFORMATION"
        ' 
        ' FrmNEW
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 451)
        ControlBox = False
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(btnSave)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "FrmNEW"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCLOSE As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DisasterName As TextBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents ResidentPhoneNumber As TextBox
    Friend WithEvents Incident As TextBox
    Friend WithEvents Description As TextBox
    Friend WithEvents DisasterDate As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
