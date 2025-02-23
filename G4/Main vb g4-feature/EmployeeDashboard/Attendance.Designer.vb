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
        txtEmployeeID = New TextBox()
        Label7 = New Label()
        btnTimeInOut = New Button()
        CType(pbEmployeePhoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label1.Location = New Point(39, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(272, 35)
        Label1.TabIndex = 1
        Label1.Text = "Employee Attendance"
        ' 
        ' lblName
        ' 
        lblName.BackColor = Color.FromArgb(CByte(234), CByte(250), CByte(241))
        lblName.BorderStyle = BorderStyle.FixedSingle
        lblName.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblName.Location = New Point(42, 174)
        lblName.Name = "lblName"
        lblName.Padding = New Padding(5)
        lblName.Size = New Size(298, 35)
        lblName.TabIndex = 2
        ' 
        ' lblID
        ' 
        lblID.BackColor = Color.FromArgb(CByte(234), CByte(250), CByte(241))
        lblID.BorderStyle = BorderStyle.FixedSingle
        lblID.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblID.Location = New Point(42, 334)
        lblID.Name = "lblID"
        lblID.Padding = New Padding(5)
        lblID.Size = New Size(131, 35)
        lblID.TabIndex = 4
        ' 
        ' lblPosition
        ' 
        lblPosition.BackColor = Color.FromArgb(CByte(234), CByte(250), CByte(241))
        lblPosition.BorderStyle = BorderStyle.FixedSingle
        lblPosition.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblPosition.Location = New Point(42, 254)
        lblPosition.Name = "lblPosition"
        lblPosition.Padding = New Padding(5)
        lblPosition.Size = New Size(298, 35)
        lblPosition.TabIndex = 6
        ' 
        ' pbEmployeePhoto
        ' 
        pbEmployeePhoto.BackColor = SystemColors.Control
        pbEmployeePhoto.Location = New Point(360, 145)
        pbEmployeePhoto.Name = "pbEmployeePhoto"
        pbEmployeePhoto.Size = New Size(162, 162)
        pbEmployeePhoto.TabIndex = 11
        pbEmployeePhoto.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(24), CByte(106), CByte(59))
        Label2.Location = New Point(39, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 20)
        Label2.TabIndex = 12
        Label2.Text = "FULL NAME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(24), CByte(106), CByte(59))
        Label3.Location = New Point(39, 228)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 20)
        Label3.TabIndex = 13
        Label3.Text = "POSITION"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(24), CByte(106), CByte(59))
        Label4.Location = New Point(39, 309)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 20)
        Label4.TabIndex = 14
        Label4.Text = "ID NUMBER"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.FromArgb(CByte(24), CByte(106), CByte(59))
        Label5.Location = New Point(559, 145)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 20)
        Label5.TabIndex = 15
        Label5.Text = "TIME IN"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.FromArgb(CByte(24), CByte(106), CByte(59))
        Label6.Location = New Point(559, 215)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 20)
        Label6.TabIndex = 16
        Label6.Text = "TIME OUT"
        ' 
        ' lblTimeIn
        ' 
        lblTimeIn.BackColor = Color.FromArgb(CByte(234), CByte(250), CByte(241))
        lblTimeIn.BorderStyle = BorderStyle.FixedSingle
        lblTimeIn.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblTimeIn.Location = New Point(559, 165)
        lblTimeIn.Name = "lblTimeIn"
        lblTimeIn.Padding = New Padding(5)
        lblTimeIn.Size = New Size(90, 35)
        lblTimeIn.TabIndex = 17
        ' 
        ' lblTimeOut
        ' 
        lblTimeOut.BackColor = Color.FromArgb(CByte(234), CByte(250), CByte(241))
        lblTimeOut.BorderStyle = BorderStyle.FixedSingle
        lblTimeOut.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblTimeOut.Location = New Point(559, 235)
        lblTimeOut.Name = "lblTimeOut"
        lblTimeOut.Padding = New Padding(5)
        lblTimeOut.Size = New Size(88, 35)
        lblTimeOut.TabIndex = 18
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.BorderStyle = BorderStyle.None
        txtEmployeeID.Location = New Point(506, 352)
        txtEmployeeID.MinimumSize = New Size(0, 35)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(222, 35)
        txtEmployeeID.TabIndex = 19
        txtEmployeeID.WordWrap = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        Label7.Location = New Point(511, 319)
        Label7.Name = "Label7"
        Label7.Size = New Size(210, 30)
        Label7.TabIndex = 20
        Label7.Text = "ENTER ID NUMBER"
        ' 
        ' btnTimeInOut
        ' 
        btnTimeInOut.BackColor = Color.Blue
        btnTimeInOut.FlatAppearance.BorderSize = 0
        btnTimeInOut.FlatStyle = FlatStyle.Flat
        btnTimeInOut.Font = New Font("Segoe UI", 11F)
        btnTimeInOut.ForeColor = Color.White
        btnTimeInOut.Location = New Point(604, 393)
        btnTimeInOut.Name = "btnTimeInOut"
        btnTimeInOut.Size = New Size(124, 56)
        btnTimeInOut.TabIndex = 21
        btnTimeInOut.Text = "Enter"
        btnTimeInOut.UseVisualStyleBackColor = False
        ' 
        ' Attendance
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(212), CByte(238), CByte(226))
        ClientSize = New Size(795, 486)
        Controls.Add(btnTimeInOut)
        Controls.Add(Label7)
        Controls.Add(txtEmployeeID)
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
        Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        FormBorderStyle = FormBorderStyle.None
        Name = "Attendance"
        Text = "Attendance"
        CType(pbEmployeePhoto, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnTimeInOut As Button
End Class
