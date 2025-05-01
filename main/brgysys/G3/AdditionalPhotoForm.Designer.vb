<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdditionalPhotoForm
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        PhotoDescription_TxtBox = New TextBox()
        Panel1 = New Panel()
        AddPic_Btn = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Honeydew
        PictureBox1.Location = New Point(16, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(669, 341)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Green
        Label1.Location = New Point(4, 393)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 28)
        Label1.TabIndex = 1
        Label1.Text = "Description:"
        ' 
        ' PhotoDescription_TxtBox
        ' 
        PhotoDescription_TxtBox.BorderStyle = BorderStyle.FixedSingle
        PhotoDescription_TxtBox.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PhotoDescription_TxtBox.Location = New Point(136, 393)
        PhotoDescription_TxtBox.Multiline = True
        PhotoDescription_TxtBox.Name = "PhotoDescription_TxtBox"
        PhotoDescription_TxtBox.Size = New Size(463, 70)
        PhotoDescription_TxtBox.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Green
        Panel1.Controls.Add(PictureBox1)
        Panel1.ForeColor = SystemColors.ControlLightLight
        Panel1.Location = New Point(9, 9)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(702, 378)
        Panel1.TabIndex = 3
        ' 
        ' AddPic_Btn
        ' 
        AddPic_Btn.BackColor = Color.Green
        AddPic_Btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddPic_Btn.ForeColor = Color.White
        AddPic_Btn.Location = New Point(605, 416)
        AddPic_Btn.Name = "AddPic_Btn"
        AddPic_Btn.Size = New Size(106, 47)
        AddPic_Btn.TabIndex = 4
        AddPic_Btn.Text = "Add"
        AddPic_Btn.UseVisualStyleBackColor = False
        ' 
        ' AdditionalPhotoForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        ClientSize = New Size(721, 475)
        Controls.Add(AddPic_Btn)
        Controls.Add(PhotoDescription_TxtBox)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        MaximizeBox = False
        Name = "AdditionalPhotoForm"
        Text = "Add Photo"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PhotoDescription_TxtBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AddPic_Btn As Button
End Class
