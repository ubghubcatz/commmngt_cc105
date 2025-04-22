<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageViewer
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
        FullImage_PictureBox = New PictureBox()
        desc_Label = New Label()
        Image_Panel = New Panel()
        Panel1 = New Panel()
        Fromwhere_Label = New Label()
        Label1 = New Label()
        CType(FullImage_PictureBox, ComponentModel.ISupportInitialize).BeginInit()
        Image_Panel.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' FullImage_PictureBox
        ' 
        FullImage_PictureBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FullImage_PictureBox.BackColor = Color.Black
        FullImage_PictureBox.BackgroundImageLayout = ImageLayout.Zoom
        FullImage_PictureBox.Location = New Point(12, 32)
        FullImage_PictureBox.Name = "FullImage_PictureBox"
        FullImage_PictureBox.Size = New Size(1474, 608)
        FullImage_PictureBox.SizeMode = PictureBoxSizeMode.CenterImage
        FullImage_PictureBox.TabIndex = 0
        FullImage_PictureBox.TabStop = False
        ' 
        ' desc_Label
        ' 
        desc_Label.AutoSize = True
        desc_Label.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Italic)
        desc_Label.ForeColor = Color.Green
        desc_Label.Location = New Point(3, 662)
        desc_Label.Name = "desc_Label"
        desc_Label.Size = New Size(79, 31)
        desc_Label.TabIndex = 1
        desc_Label.Text = "Label1"
        ' 
        ' Image_Panel
        ' 
        Image_Panel.AutoScroll = True
        Image_Panel.Controls.Add(FullImage_PictureBox)
        Image_Panel.Location = New Point(0, 0)
        Image_Panel.Name = "Image_Panel"
        Image_Panel.Size = New Size(1514, 659)
        Image_Panel.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Fromwhere_Label)
        Panel1.Controls.Add(desc_Label)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1514, 914)
        Panel1.TabIndex = 4
        ' 
        ' Fromwhere_Label
        ' 
        Fromwhere_Label.AutoSize = True
        Fromwhere_Label.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Fromwhere_Label.ForeColor = Color.Green
        Fromwhere_Label.Location = New Point(3, 716)
        Fromwhere_Label.Name = "Fromwhere_Label"
        Fromwhere_Label.Size = New Size(124, 46)
        Fromwhere_Label.TabIndex = 3
        Fromwhere_Label.Text = "Label2"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Green
        Label1.Location = New Point(718, 442)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 31)
        Label1.TabIndex = 2
        Label1.Text = "Label1"
        ' 
        ' ImageViewer
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        ClientSize = New Size(1513, 912)
        Controls.Add(Image_Panel)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "ImageViewer"
        Text = "ImageViewer"
        CType(FullImage_PictureBox, ComponentModel.ISupportInitialize).EndInit()
        Image_Panel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents FullImage_PictureBox As PictureBox
    Friend WithEvents desc_Label As Label
    Friend WithEvents Image_Panel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Fromwhere_Label As Label
    Friend WithEvents Label1 As Label
End Class
