<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class penaVENUE
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
        Label14 = New Label()
        Label13 = New Label()
        Label11 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label1 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(511, 52)
        Label14.Name = "Label14"
        Label14.Size = New Size(183, 46)
        Label14.TabIndex = 33
        Label14.Text = "Purok 1, Brgy. Talisay, " & vbCrLf & "Lipa City, Batangas"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(511, 27)
        Label13.Name = "Label13"
        Label13.Size = New Size(87, 28)
        Label13.TabIndex = 32
        Label13.Text = "Address"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Label11.Location = New Point(511, 219)
        Label11.Name = "Label11"
        Label11.Size = New Size(285, 92)
        Label11.TabIndex = 30
        Label11.Text = "Email: " & vbCrLf & "penafranciaeventsplace@gmail.com" & vbCrLf & "Website: " & vbCrLf & "Peñafrancia Events Place"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(511, 191)
        Label6.Name = "Label6"
        Label6.RightToLeft = RightToLeft.Yes
        Label6.Size = New Size(210, 28)
        Label6.TabIndex = 25
        Label6.Text = " Contact Information"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(511, 108)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 28)
        Label5.TabIndex = 24
        Label5.Text = "Facilities"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Label1.Location = New Point(511, 133)
        Label1.Name = "Label1"
        Label1.Size = New Size(306, 46)
        Label1.TabIndex = 20
        Label1.Text = "Suitable for various events; " & vbCrLf & "capacity details available upon inquiry." & vbCrLf
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = My.Resources.Resources.pena3
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(8, 352)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(497, 163)
        PictureBox3.TabIndex = 36
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.pena2
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(8, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(497, 163)
        PictureBox2.TabIndex = 35
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.pena1
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(8, 181)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(497, 165)
        PictureBox1.TabIndex = 34
        PictureBox1.TabStop = False
        ' 
        ' penaVENUE
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(212), CByte(238), CByte(226))
        ClientSize = New Size(911, 527)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label11)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "penaVENUE"
        Text = "penaVENUE"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
