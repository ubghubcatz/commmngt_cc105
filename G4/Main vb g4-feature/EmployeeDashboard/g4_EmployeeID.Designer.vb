<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class g4_EmployeeID
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
        idPic = New PictureBox()
        lblFullName = New Label()
        lblPosition = New Label()
        IDNumberlbl = New Label()
        backPanel = New Panel()
        QRpbox = New PictureBox()
        lblFullAddress = New Label()
        lblContactNo = New Label()
        frontPanel = New Panel()
        lblIDnumber = New Label()
        idNumber = New TextBox()
        btnloadDetails = New Button()
        btnSaveQR = New Button()
        btnPrint = New Button()
        CType(idPic, ComponentModel.ISupportInitialize).BeginInit()
        backPanel.SuspendLayout()
        CType(QRpbox, ComponentModel.ISupportInitialize).BeginInit()
        frontPanel.SuspendLayout()
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
        ' lblPosition
        ' 
        lblPosition.Anchor = AnchorStyles.Top
        lblPosition.BackColor = Color.Transparent
        lblPosition.Font = New Font("Segoe UI", 9F)
        lblPosition.ForeColor = Color.White
        lblPosition.Location = New Point(15, 279)
        lblPosition.MaximumSize = New Size(250, 0)
        lblPosition.Name = "lblPosition"
        lblPosition.Size = New Size(245, 35)
        lblPosition.TabIndex = 4
        lblPosition.Text = "Position"
        lblPosition.TextAlign = ContentAlignment.MiddleCenter
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
        ' backPanel
        ' 
        backPanel.BackgroundImage = My.Resources.Resources.ID_F
        backPanel.BackgroundImageLayout = ImageLayout.Zoom
        backPanel.Controls.Add(QRpbox)
        backPanel.Controls.Add(lblFullAddress)
        backPanel.Controls.Add(lblContactNo)
        backPanel.Location = New Point(344, 45)
        backPanel.Name = "backPanel"
        backPanel.Size = New Size(277, 394)
        backPanel.TabIndex = 14
        ' 
        ' QRpbox
        ' 
        QRpbox.BackColor = Color.Transparent
        QRpbox.BackgroundImageLayout = ImageLayout.Center
        QRpbox.Location = New Point(38, 57)
        QRpbox.Name = "QRpbox"
        QRpbox.Size = New Size(200, 200)
        QRpbox.SizeMode = PictureBoxSizeMode.Zoom
        QRpbox.TabIndex = 5
        QRpbox.TabStop = False
        ' 
        ' lblFullAddress
        ' 
        lblFullAddress.AllowDrop = True
        lblFullAddress.BackColor = Color.Transparent
        lblFullAddress.Font = New Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFullAddress.ForeColor = Color.Black
        lblFullAddress.Location = New Point(17, 304)
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
        lblContactNo.Location = New Point(17, 279)
        lblContactNo.Name = "lblContactNo"
        lblContactNo.Size = New Size(239, 25)
        lblContactNo.TabIndex = 0
        lblContactNo.Text = "Contact Number"
        lblContactNo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' frontPanel
        ' 
        frontPanel.BackgroundImage = My.Resources.Resources.ID_F__1_
        frontPanel.BackgroundImageLayout = ImageLayout.Zoom
        frontPanel.Controls.Add(idPic)
        frontPanel.Controls.Add(lblFullName)
        frontPanel.Controls.Add(lblPosition)
        frontPanel.Controls.Add(IDNumberlbl)
        frontPanel.Location = New Point(56, 45)
        frontPanel.Name = "frontPanel"
        frontPanel.Size = New Size(277, 394)
        frontPanel.TabIndex = 13
        ' 
        ' lblIDnumber
        ' 
        lblIDnumber.AutoSize = True
        lblIDnumber.BackColor = Color.Transparent
        lblIDnumber.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblIDnumber.Location = New Point(630, 340)
        lblIDnumber.Name = "lblIDnumber"
        lblIDnumber.Size = New Size(145, 20)
        lblIDnumber.TabIndex = 12
        lblIDnumber.Text = "ENTER ID NUMBER"
        ' 
        ' idNumber
        ' 
        idNumber.Location = New Point(635, 363)
        idNumber.Name = "idNumber"
        idNumber.Size = New Size(136, 27)
        idNumber.TabIndex = 11
        idNumber.WordWrap = False
        ' 
        ' btnloadDetails
        ' 
        btnloadDetails.BackColor = Color.Blue
        btnloadDetails.FlatAppearance.BorderSize = 0
        btnloadDetails.FlatStyle = FlatStyle.Flat
        btnloadDetails.ForeColor = Color.White
        btnloadDetails.Location = New Point(635, 396)
        btnloadDetails.Name = "btnloadDetails"
        btnloadDetails.Size = New Size(136, 43)
        btnloadDetails.TabIndex = 10
        btnloadDetails.Text = "Load Details"
        btnloadDetails.UseVisualStyleBackColor = False
        ' 
        ' btnSaveQR
        ' 
        btnSaveQR.BackColor = Color.Blue
        btnSaveQR.FlatAppearance.BorderSize = 0
        btnSaveQR.FlatStyle = FlatStyle.Flat
        btnSaveQR.ForeColor = Color.White
        btnSaveQR.Location = New Point(635, 94)
        btnSaveQR.Name = "btnSaveQR"
        btnSaveQR.Size = New Size(136, 43)
        btnSaveQR.TabIndex = 15
        btnSaveQR.Text = "Save QR"
        btnSaveQR.UseVisualStyleBackColor = False
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.Blue
        btnPrint.FlatAppearance.BorderSize = 0
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.ForeColor = Color.White
        btnPrint.Location = New Point(635, 45)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(136, 43)
        btnPrint.TabIndex = 16
        btnPrint.Text = "Print ID"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' g4_EmployeeID
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(212), CByte(238), CByte(226))
        ClientSize = New Size(829, 522)
        Controls.Add(btnPrint)
        Controls.Add(btnSaveQR)
        Controls.Add(backPanel)
        Controls.Add(frontPanel)
        Controls.Add(lblIDnumber)
        Controls.Add(idNumber)
        Controls.Add(btnloadDetails)
        FormBorderStyle = FormBorderStyle.None
        Name = "g4_EmployeeID"
        Text = "g4_EmployeeID"
        CType(idPic, ComponentModel.ISupportInitialize).EndInit()
        backPanel.ResumeLayout(False)
        CType(QRpbox, ComponentModel.ISupportInitialize).EndInit()
        frontPanel.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents idPic As PictureBox
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents IDNumberlbl As Label
    Friend WithEvents backPanel As Panel
    Friend WithEvents lblFullAddress As Label
    Friend WithEvents lblContactNo As Label
    Friend WithEvents frontPanel As Panel
    Friend WithEvents lblIDnumber As Label
    Friend WithEvents idNumber As TextBox
    Friend WithEvents btnloadDetails As Button
    Friend WithEvents QRpbox As PictureBox
    Friend WithEvents btnSaveQR As Button
    Friend WithEvents btnPrint As Button
End Class
