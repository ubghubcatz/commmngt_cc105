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
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(60))
        Panel1.Controls.Add(btnCLOSE)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(700, 49)
        Panel1.TabIndex = 1
        ' 
        ' btnCLOSE
        ' 
        btnCLOSE.BackColor = Color.Gray
        btnCLOSE.FlatStyle = FlatStyle.Flat
        btnCLOSE.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCLOSE.Location = New Point(600, 4)
        btnCLOSE.Margin = New Padding(3, 2, 3, 2)
        btnCLOSE.Name = "btnCLOSE"
        btnCLOSE.Size = New Size(97, 40)
        btnCLOSE.TabIndex = 3
        btnCLOSE.Text = "CLOSE"
        btnCLOSE.TextImageRelation = TextImageRelation.ImageAboveText
        btnCLOSE.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(10, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(197, 19)
        Label1.TabIndex = 0
        Label1.Text = "BRGY. INOSLUBAN LIPA CITY"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(68, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 2
        Label2.Text = "NAME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(68, 146)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 3
        Label3.Text = "DATE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(68, 201)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 15)
        Label4.TabIndex = 4
        Label4.Text = "LOCATION"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(68, 254)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 15)
        Label5.TabIndex = 5
        Label5.Text = "CONTACT NUMBER"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(500, 91)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 15)
        Label6.TabIndex = 6
        Label6.Text = "TYPE OF ITEM"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(510, 151)
        Label7.Name = "Label7"
        Label7.Size = New Size(84, 15)
        Label7.TabIndex = 7
        Label7.Text = "DESCRIPTION"
        ' 
        ' DisasterName
        ' 
        DisasterName.Location = New Point(129, 91)
        DisasterName.Margin = New Padding(3, 2, 3, 2)
        DisasterName.Name = "DisasterName"
        DisasterName.Size = New Size(182, 23)
        DisasterName.TabIndex = 8
        ' 
        ' txtLocation
        ' 
        txtLocation.Location = New Point(142, 201)
        txtLocation.Margin = New Padding(3, 2, 3, 2)
        txtLocation.Name = "txtLocation"
        txtLocation.Size = New Size(182, 23)
        txtLocation.TabIndex = 10
        ' 
        ' ResidentPhoneNumber
        ' 
        ResidentPhoneNumber.Location = New Point(194, 251)
        ResidentPhoneNumber.Margin = New Padding(3, 2, 3, 2)
        ResidentPhoneNumber.Name = "ResidentPhoneNumber"
        ResidentPhoneNumber.Size = New Size(182, 23)
        ResidentPhoneNumber.TabIndex = 11
        ' 
        ' Incident
        ' 
        Incident.Location = New Point(457, 117)
        Incident.Margin = New Padding(3, 2, 3, 2)
        Incident.Name = "Incident"
        Incident.Size = New Size(182, 23)
        Incident.TabIndex = 12
        ' 
        ' Description
        ' 
        Description.Location = New Point(457, 182)
        Description.Margin = New Padding(3, 2, 3, 2)
        Description.Multiline = True
        Description.Name = "Description"
        Description.Size = New Size(182, 91)
        Description.TabIndex = 13
        ' 
        ' DisasterDate
        ' 
        DisasterDate.Location = New Point(129, 146)
        DisasterDate.Margin = New Padding(3, 2, 3, 2)
        DisasterDate.Name = "DisasterDate"
        DisasterDate.Size = New Size(219, 23)
        DisasterDate.TabIndex = 14
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(326, 293)
        btnSave.Margin = New Padding(3, 2, 3, 2)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(82, 22)
        btnSave.TabIndex = 15
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' FrmNEW
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 338)
        ControlBox = False
        Controls.Add(btnSave)
        Controls.Add(DisasterDate)
        Controls.Add(Description)
        Controls.Add(Incident)
        Controls.Add(ResidentPhoneNumber)
        Controls.Add(txtLocation)
        Controls.Add(DisasterName)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 2, 3, 2)
        Name = "FrmNEW"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
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
End Class
