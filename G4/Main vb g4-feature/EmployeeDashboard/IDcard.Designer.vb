<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IDcard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IDcard))
        idCardbase = New PictureBox()
        idPic = New PictureBox()
        lblFullName = New Label()
        IDNumberlbl = New Label()
        lblPosition = New Label()
        btnloadDetails = New Button()
        idNumber = New TextBox()
        lblIDnumber = New Label()
        CType(idCardbase, ComponentModel.ISupportInitialize).BeginInit()
        CType(idPic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' idCardbase
        ' 
        idCardbase.BackColor = Color.White
        idCardbase.BackgroundImage = CType(resources.GetObject("idCardbase.BackgroundImage"), Image)
        idCardbase.BackgroundImageLayout = ImageLayout.Zoom
        idCardbase.Location = New Point(280, 27)
        idCardbase.Name = "idCardbase"
        idCardbase.Size = New Size(280, 397)
        idCardbase.TabIndex = 0
        idCardbase.TabStop = False
        ' 
        ' idPic
        ' 
        idPic.BackgroundImageLayout = ImageLayout.Center
        idPic.Location = New Point(351, 127)
        idPic.Name = "idPic"
        idPic.Size = New Size(140, 135)
        idPic.TabIndex = 1
        idPic.TabStop = False
        ' 
        ' lblFullName
        ' 
        lblFullName.BackColor = Color.White
        lblFullName.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblFullName.Location = New Point(291, 275)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(256, 25)
        lblFullName.TabIndex = 2
        lblFullName.Text = "Ricardo Diego Sun Aquino"
        lblFullName.TextAlign = ContentAlignment.TopCenter
        ' 
        ' IDNumberlbl
        ' 
        IDNumberlbl.BackColor = Color.Green
        IDNumberlbl.Font = New Font("Calibri", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IDNumberlbl.ForeColor = Color.White
        IDNumberlbl.Location = New Point(319, 349)
        IDNumberlbl.Name = "IDNumberlbl"
        IDNumberlbl.Size = New Size(203, 28)
        IDNumberlbl.TabIndex = 3
        IDNumberlbl.Text = "ID Number"
        IDNumberlbl.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblPosition
        ' 
        lblPosition.BackColor = Color.White
        lblPosition.Font = New Font("Segoe UI", 8F)
        lblPosition.Location = New Point(296, 302)
        lblPosition.MaximumSize = New Size(250, 0)
        lblPosition.Name = "lblPosition"
        lblPosition.Size = New Size(249, 36)
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
        btnloadDetails.Location = New Point(612, 415)
        btnloadDetails.Name = "btnloadDetails"
        btnloadDetails.Size = New Size(125, 43)
        btnloadDetails.TabIndex = 5
        btnloadDetails.Text = "Load Details"
        btnloadDetails.UseVisualStyleBackColor = False
        ' 
        ' idNumber
        ' 
        idNumber.Location = New Point(612, 364)
        idNumber.Name = "idNumber"
        idNumber.Size = New Size(125, 27)
        idNumber.TabIndex = 6
        ' 
        ' lblIDnumber
        ' 
        lblIDnumber.AutoSize = True
        lblIDnumber.Location = New Point(612, 333)
        lblIDnumber.Name = "lblIDnumber"
        lblIDnumber.Size = New Size(123, 20)
        lblIDnumber.TabIndex = 7
        lblIDnumber.Text = "Enter ID Number:"
        ' 
        ' IDcard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(212), CByte(238), CByte(226))
        ClientSize = New Size(795, 486)
        Controls.Add(lblIDnumber)
        Controls.Add(idNumber)
        Controls.Add(btnloadDetails)
        Controls.Add(lblPosition)
        Controls.Add(IDNumberlbl)
        Controls.Add(lblFullName)
        Controls.Add(idPic)
        Controls.Add(idCardbase)
        FormBorderStyle = FormBorderStyle.None
        Name = "IDcard"
        Text = "IDcard"
        CType(idCardbase, ComponentModel.ISupportInitialize).EndInit()
        CType(idPic, ComponentModel.ISupportInitialize).EndInit()
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
End Class
