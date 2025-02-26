<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IDcard
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
        idPic = New PictureBox()
        lblFullName = New Label()
        IDNumberlbl = New Label()
        lblPosition = New Label()
        btnloadDetails = New Button()
        idNumber = New TextBox()
        lblIDnumber = New Label()
        idPicPanel = New Panel()
        idBackPanel = New Panel()
        lblFullAddress = New Label()
        lblContactNo = New Label()
        CType(idPic, ComponentModel.ISupportInitialize).BeginInit()
        idPicPanel.SuspendLayout()
        idBackPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' idPic
        ' 
        idPic.BackColor = Color.Transparent
        idPic.BackgroundImageLayout = ImageLayout.Center
        idPic.Location = New Point(64, 61)
        idPic.Name = "idPic"
        idPic.Size = New Size(152, 152)
        idPic.TabIndex = 1
        idPic.TabStop = False
        ' 
        ' lblFullName
        ' 
        lblFullName.BackColor = Color.Transparent
        lblFullName.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblFullName.ForeColor = Color.FromArgb(CByte(0), CByte(120), CByte(62))
        lblFullName.Location = New Point(15, 254)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(245, 25)
        lblFullName.TabIndex = 2
        lblFullName.Text = "Employee Full Name"
        lblFullName.TextAlign = ContentAlignment.TopCenter
        ' 
        ' IDNumberlbl
        ' 
        IDNumberlbl.BackColor = Color.Transparent
        IDNumberlbl.Font = New Font("Calibri", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IDNumberlbl.ForeColor = Color.White
        IDNumberlbl.Location = New Point(38, 324)
        IDNumberlbl.Name = "IDNumberlbl"
        IDNumberlbl.Size = New Size(203, 28)
        IDNumberlbl.TabIndex = 3
        IDNumberlbl.Text = "ID Number"
        IDNumberlbl.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblPosition
        ' 
        lblPosition.Anchor = AnchorStyles.Top
        lblPosition.BackColor = Color.Transparent
        lblPosition.Font = New Font("Segoe UI", 9F)
        lblPosition.ForeColor = Color.White
        lblPosition.Location = New Point(15, 277)
        lblPosition.MaximumSize = New Size(250, 0)
        lblPosition.Name = "lblPosition"
        lblPosition.Size = New Size(245, 35)
        lblPosition.TabIndex = 4
        lblPosition.Text = "Position"
        lblPosition.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnloadDetails
        ' 
        btnloadDetails.BackColor = Color.Blue
        btnloadDetails.FlatAppearance.BorderSize = 0
        btnloadDetails.FlatStyle = FlatStyle.Flat
        btnloadDetails.ForeColor = Color.White
        btnloadDetails.Location = New Point(655, 438)
        btnloadDetails.Name = "btnloadDetails"
        btnloadDetails.Size = New Size(136, 43)
        btnloadDetails.TabIndex = 5
        btnloadDetails.Text = "Load Details"
        btnloadDetails.UseVisualStyleBackColor = False
        ' 
        ' idNumber
        ' 
        idNumber.Location = New Point(655, 405)
        idNumber.Name = "idNumber"
        idNumber.Size = New Size(136, 27)
        idNumber.TabIndex = 6
        idNumber.WordWrap = False
        ' 
        ' lblIDnumber
        ' 
        lblIDnumber.AutoSize = True
        lblIDnumber.BackColor = Color.Transparent
        lblIDnumber.Location = New Point(655, 382)
        lblIDnumber.Name = "lblIDnumber"
        lblIDnumber.Size = New Size(136, 20)
        lblIDnumber.TabIndex = 7
        lblIDnumber.Text = "ENTER ID NUMBER"
        ' 
        ' idPicPanel
        ' 
        idPicPanel.BackgroundImage = My.Resources.Resources.ID_F__1_
        idPicPanel.BackgroundImageLayout = ImageLayout.Zoom
        idPicPanel.Controls.Add(idPic)
        idPicPanel.Controls.Add(lblFullName)
        idPicPanel.Controls.Add(lblPosition)
        idPicPanel.Controls.Add(IDNumberlbl)
        idPicPanel.Location = New Point(65, 38)
        idPicPanel.Name = "idPicPanel"
        idPicPanel.Size = New Size(277, 394)
        idPicPanel.TabIndex = 8
        ' 
        ' idBackPanel
        ' 
        idBackPanel.BackgroundImage = My.Resources.Resources.ID_F
        idBackPanel.BackgroundImageLayout = ImageLayout.Zoom
        idBackPanel.Controls.Add(lblFullAddress)
        idBackPanel.Controls.Add(lblContactNo)
        idBackPanel.Location = New Point(353, 38)
        idBackPanel.Name = "idBackPanel"
        idBackPanel.Size = New Size(277, 394)
        idBackPanel.TabIndex = 9
        ' 
        ' lblFullAddress
        ' 
        lblFullAddress.AllowDrop = True
        lblFullAddress.BackColor = Color.Transparent
        lblFullAddress.Font = New Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFullAddress.ForeColor = Color.Black
        lblFullAddress.Location = New Point(20, 113)
        lblFullAddress.Name = "lblFullAddress"
        lblFullAddress.Size = New Size(239, 46)
        lblFullAddress.TabIndex = 1
        lblFullAddress.Text = "Complete Address"
        lblFullAddress.TextAlign = ContentAlignment.MiddleCenter
        lblFullAddress.UseCompatibleTextRendering = True
        ' 
        ' lblContactNo
        ' 
        lblContactNo.BackColor = Color.Transparent
        lblContactNo.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblContactNo.ForeColor = Color.Black
        lblContactNo.Location = New Point(20, 88)
        lblContactNo.Name = "lblContactNo"
        lblContactNo.Size = New Size(239, 25)
        lblContactNo.TabIndex = 0
        lblContactNo.Text = "Contact Number"
        lblContactNo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' IDcard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(212), CByte(238), CByte(226))
        ClientSize = New Size(829, 522)
        Controls.Add(idBackPanel)
        Controls.Add(idPicPanel)
        Controls.Add(lblIDnumber)
        Controls.Add(idNumber)
        Controls.Add(btnloadDetails)
        FormBorderStyle = FormBorderStyle.None
        Name = "IDcard"
        Text = "IDcard"
        CType(idPic, ComponentModel.ISupportInitialize).EndInit()
        idPicPanel.ResumeLayout(False)
        idBackPanel.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents idCardbase As PictureBox
    Friend WithEvents idPic As PictureBox
    Friend WithEvents lblFullName As Label
    Friend WithEvents IDNumberlbl As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents btnloadDetails As Button
    Friend WithEvents idNumber As TextBox
    Friend WithEvents lblIDnumber As Label
    Friend WithEvents idPicPanel As Panel
    Friend WithEvents idBackPanel As Panel
    Friend WithEvents lblFullAddress As Label
    Friend WithEvents lblContactNo As Label
End Class
