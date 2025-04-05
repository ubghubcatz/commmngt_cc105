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
        IDNumberlbl = New Label()
        backPanel = New Panel()
        QRpbox = New PictureBox()
        lblFullAddress = New Label()
        lblContactNo = New Label()
        frontPanel = New Panel()
        lblPosition = New Label()
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
        idPic.Anchor = AnchorStyles.None
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
        lblFullName.Anchor = AnchorStyles.None
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
        IDNumberlbl.Anchor = AnchorStyles.None
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
        backPanel.Anchor = AnchorStyles.None
        backPanel.BackColor = Color.Transparent
        backPanel.BackgroundImage = My.Resources.Resources.ID_F1
        backPanel.BackgroundImageLayout = ImageLayout.Zoom
        backPanel.Controls.Add(QRpbox)
        backPanel.Controls.Add(lblFullAddress)
        backPanel.Controls.Add(lblContactNo)
        backPanel.Location = New Point(346, 62)
        backPanel.Name = "backPanel"
        backPanel.Size = New Size(277, 394)
        backPanel.TabIndex = 14
        ' 
        ' QRpbox
        ' 
        QRpbox.Anchor = AnchorStyles.None
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
        lblFullAddress.Anchor = AnchorStyles.None
        lblFullAddress.BackColor = Color.Transparent
        lblFullAddress.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        lblContactNo.Anchor = AnchorStyles.None
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
        frontPanel.Anchor = AnchorStyles.None
        frontPanel.BackColor = Color.Transparent
        frontPanel.BackgroundImage = My.Resources.Resources.ID_F__1_
        frontPanel.BackgroundImageLayout = ImageLayout.Zoom
        frontPanel.Controls.Add(lblPosition)
        frontPanel.Controls.Add(idPic)
        frontPanel.Controls.Add(lblFullName)
        frontPanel.Controls.Add(IDNumberlbl)
        frontPanel.Location = New Point(58, 62)
        frontPanel.Name = "frontPanel"
        frontPanel.Size = New Size(277, 394)
        frontPanel.TabIndex = 13
        ' 
        ' lblPosition
        ' 
        lblPosition.AllowDrop = True
        lblPosition.Anchor = AnchorStyles.None
        lblPosition.BackColor = Color.Transparent
        lblPosition.Font = New Font("Segoe UI", 9F)
        lblPosition.ForeColor = Color.White
        lblPosition.Location = New Point(15, 280)
        lblPosition.MaximumSize = New Size(250, 0)
        lblPosition.Name = "lblPosition"
        lblPosition.Size = New Size(245, 35)
        lblPosition.TabIndex = 5
        lblPosition.Text = "Position"
        lblPosition.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblIDnumber
        ' 
        lblIDnumber.Anchor = AnchorStyles.None
        lblIDnumber.AutoSize = True
        lblIDnumber.BackColor = Color.Transparent
        lblIDnumber.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblIDnumber.Location = New Point(632, 357)
        lblIDnumber.Name = "lblIDnumber"
        lblIDnumber.Size = New Size(145, 20)
        lblIDnumber.TabIndex = 12
        lblIDnumber.Text = "ENTER ID NUMBER"
        ' 
        ' idNumber
        ' 
        idNumber.Anchor = AnchorStyles.None
        idNumber.Location = New Point(637, 380)
        idNumber.Name = "idNumber"
        idNumber.Size = New Size(136, 27)
        idNumber.TabIndex = 11
        idNumber.WordWrap = False
        ' 
        ' btnloadDetails
        ' 
        btnloadDetails.Anchor = AnchorStyles.None
        btnloadDetails.BackColor = Color.White
        btnloadDetails.FlatAppearance.BorderColor = Color.Green
        btnloadDetails.FlatAppearance.BorderSize = 3
        btnloadDetails.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnloadDetails.ForeColor = Color.Green
        btnloadDetails.Location = New Point(637, 413)
        btnloadDetails.Name = "btnloadDetails"
        btnloadDetails.Size = New Size(136, 43)
        btnloadDetails.TabIndex = 10
        btnloadDetails.Text = "Load Details"
        btnloadDetails.UseVisualStyleBackColor = False
        ' 
        ' btnSaveQR
        ' 
        btnSaveQR.Anchor = AnchorStyles.None
        btnSaveQR.BackColor = Color.White
        btnSaveQR.FlatAppearance.BorderColor = Color.Green
        btnSaveQR.FlatAppearance.BorderSize = 3
        btnSaveQR.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSaveQR.ForeColor = Color.Green
        btnSaveQR.Location = New Point(637, 111)
        btnSaveQR.Name = "btnSaveQR"
        btnSaveQR.Size = New Size(136, 43)
        btnSaveQR.TabIndex = 15
        btnSaveQR.Text = "Save QR"
        btnSaveQR.UseVisualStyleBackColor = False
        ' 
        ' btnPrint
        ' 
        btnPrint.Anchor = AnchorStyles.None
        btnPrint.BackColor = Color.White
        btnPrint.FlatAppearance.BorderColor = Color.Green
        btnPrint.FlatAppearance.BorderSize = 3
        btnPrint.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnPrint.ForeColor = Color.Green
        btnPrint.Location = New Point(637, 62)
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
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.IDBG
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(829, 522)
        Controls.Add(btnPrint)
        Controls.Add(btnSaveQR)
        Controls.Add(frontPanel)
        Controls.Add(backPanel)
        Controls.Add(lblIDnumber)
        Controls.Add(idNumber)
        Controls.Add(btnloadDetails)
        Name = "g4_EmployeeID"
        StartPosition = FormStartPosition.CenterScreen
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
    Friend WithEvents lblPosition As Label
End Class
