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
        idCardbase.BackgroundImageLayout = ImageLayout.Center
        idCardbase.Location = New Point(265, 28)
        idCardbase.Name = "idCardbase"
        idCardbase.Size = New Size(295, 396)
        idCardbase.TabIndex = 0
        idCardbase.TabStop = False
        ' 
        ' idPic
        ' 
        idPic.BackgroundImageLayout = ImageLayout.Center
        idPic.Location = New Point(328, 62)
        idPic.Name = "idPic"
        idPic.Size = New Size(168, 168)
        idPic.TabIndex = 1
        idPic.TabStop = False
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.BackColor = Color.White
        lblFullName.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblFullName.Location = New Point(294, 257)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(222, 23)
        lblFullName.TabIndex = 2
        lblFullName.Text = "Ricardo Diego Sun Aquino"
        ' 
        ' IDNumberlbl
        ' 
        IDNumberlbl.AutoSize = True
        IDNumberlbl.BackColor = Color.White
        IDNumberlbl.Font = New Font("Calibri", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IDNumberlbl.Location = New Point(294, 362)
        IDNumberlbl.Name = "IDNumberlbl"
        IDNumberlbl.Size = New Size(116, 28)
        IDNumberlbl.TabIndex = 3
        IDNumberlbl.Text = "ID Number"
        IDNumberlbl.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblPosition
        ' 
        lblPosition.AutoSize = True
        lblPosition.BackColor = Color.White
        lblPosition.Location = New Point(294, 280)
        lblPosition.Name = "lblPosition"
        lblPosition.Size = New Size(61, 20)
        lblPosition.TabIndex = 4
        lblPosition.Text = "Position"
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
