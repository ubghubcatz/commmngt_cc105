<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attendance
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
        Label1 = New Label()
        lblName = New Label()
        lblID = New Label()
        lblPosition = New Label()
        pbEmployeePhoto = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        lblTimeIn = New Label()
        lblTimeOut = New Label()
        pbCamera = New PictureBox()
        CType(pbEmployeePhoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbCamera, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(82, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(272, 35)
        Label1.TabIndex = 1
        Label1.Text = "Employee Attendance"
        ' 
        ' lblName
        ' 
        lblName.BackColor = Color.White
        lblName.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblName.Location = New Point(61, 364)
        lblName.Name = "lblName"
        lblName.Padding = New Padding(5)
        lblName.Size = New Size(313, 35)
        lblName.TabIndex = 2
        ' 
        ' lblID
        ' 
        lblID.BackColor = Color.White
        lblID.FlatStyle = FlatStyle.Flat
        lblID.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblID.Location = New Point(417, 104)
        lblID.Name = "lblID"
        lblID.Padding = New Padding(5)
        lblID.Size = New Size(199, 35)
        lblID.TabIndex = 4
        ' 
        ' lblPosition
        ' 
        lblPosition.BackColor = Color.White
        lblPosition.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblPosition.Location = New Point(61, 433)
        lblPosition.Name = "lblPosition"
        lblPosition.Padding = New Padding(5)
        lblPosition.Size = New Size(313, 35)
        lblPosition.TabIndex = 6
        ' 
        ' pbEmployeePhoto
        ' 
        pbEmployeePhoto.BackColor = SystemColors.Control
        pbEmployeePhoto.Location = New Point(112, 102)
        pbEmployeePhoto.Name = "pbEmployeePhoto"
        pbEmployeePhoto.Size = New Size(215, 215)
        pbEmployeePhoto.TabIndex = 11
        pbEmployeePhoto.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(56, 341)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 20)
        Label2.TabIndex = 12
        Label2.Text = "FULL NAME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(57, 411)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 20)
        Label3.TabIndex = 13
        Label3.Text = "POSITION"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(24), CByte(106), CByte(59))
        Label4.Location = New Point(415, 74)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 20)
        Label4.TabIndex = 14
        Label4.Text = "ID NUMBER"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.FromArgb(CByte(24), CByte(106), CByte(59))
        Label5.Location = New Point(416, 166)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 20)
        Label5.TabIndex = 15
        Label5.Text = "TIME IN"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.FromArgb(CByte(24), CByte(106), CByte(59))
        Label6.Location = New Point(416, 254)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 20)
        Label6.TabIndex = 16
        Label6.Text = "TIME OUT"
        ' 
        ' lblTimeIn
        ' 
        lblTimeIn.BackColor = Color.White
        lblTimeIn.FlatStyle = FlatStyle.Flat
        lblTimeIn.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblTimeIn.Location = New Point(418, 195)
        lblTimeIn.Name = "lblTimeIn"
        lblTimeIn.Padding = New Padding(5)
        lblTimeIn.Size = New Size(198, 35)
        lblTimeIn.TabIndex = 17
        ' 
        ' lblTimeOut
        ' 
        lblTimeOut.BackColor = Color.White
        lblTimeOut.FlatStyle = FlatStyle.Flat
        lblTimeOut.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblTimeOut.Location = New Point(418, 282)
        lblTimeOut.Name = "lblTimeOut"
        lblTimeOut.Padding = New Padding(5)
        lblTimeOut.Size = New Size(196, 35)
        lblTimeOut.TabIndex = 18
        ' 
        ' pbCamera
        ' 
        pbCamera.BackColor = SystemColors.Control
        pbCamera.BackgroundImageLayout = ImageLayout.Center
        pbCamera.Location = New Point(595, 296)
        pbCamera.Name = "pbCamera"
        pbCamera.Size = New Size(222, 222)
        pbCamera.TabIndex = 19
        pbCamera.TabStop = False
        ' 
        ' Attendance
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.newbackattendance
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(829, 522)
        Controls.Add(pbCamera)
        Controls.Add(lblTimeOut)
        Controls.Add(lblTimeIn)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(pbEmployeePhoto)
        Controls.Add(lblPosition)
        Controls.Add(lblID)
        Controls.Add(lblName)
        Controls.Add(Label1)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        FormBorderStyle = FormBorderStyle.None
        Name = "Attendance"
        Text = "Attendance"
        CType(pbEmployeePhoto, ComponentModel.ISupportInitialize).EndInit()
        CType(pbCamera, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents pbEmployeePhoto As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTimeIn As Label
    Friend WithEvents lblTimeOut As Label
    Friend WithEvents pbCamera As PictureBox
End Class
