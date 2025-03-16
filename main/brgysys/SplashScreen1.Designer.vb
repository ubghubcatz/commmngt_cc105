<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen1
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
    Friend WithEvents ApplicationTitle As System.Windows.Forms.Label
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents Copyright As System.Windows.Forms.Label
    Friend WithEvents MainLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DetailsLayoutPanel As System.Windows.Forms.TableLayoutPanel

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen1))
        MainLayoutPanel = New TableLayoutPanel()
        ApplicationTitle = New Label()
        DetailsLayoutPanel = New TableLayoutPanel()
        Version = New Label()
        Copyright = New Label()
        ProgressBar1 = New ProgressBar()
        Timer1 = New Timer(components)
        MainLayoutPanel.SuspendLayout()
        DetailsLayoutPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' MainLayoutPanel
        ' 
        MainLayoutPanel.BackgroundImage = CType(resources.GetObject("MainLayoutPanel.BackgroundImage"), Image)
        MainLayoutPanel.BackgroundImageLayout = ImageLayout.Stretch
        MainLayoutPanel.ColumnCount = 2
        MainLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 243F))
        MainLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 100F))
        MainLayoutPanel.Controls.Add(ApplicationTitle, 1, 0)
        MainLayoutPanel.Controls.Add(DetailsLayoutPanel, 0, 1)
        MainLayoutPanel.Controls.Add(ProgressBar1, 1, 1)
        MainLayoutPanel.Dock = DockStyle.Fill
        MainLayoutPanel.Location = New Point(0, 0)
        MainLayoutPanel.Name = "MainLayoutPanel"
        MainLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 218F))
        MainLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 38F))
        MainLayoutPanel.Size = New Size(496, 303)
        MainLayoutPanel.TabIndex = 0
        ' 
        ' ApplicationTitle
        ' 
        ApplicationTitle.Anchor = AnchorStyles.None
        ApplicationTitle.BackColor = Color.Transparent
        ApplicationTitle.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ApplicationTitle.Location = New Point(246, 24)
        ApplicationTitle.Name = "ApplicationTitle"
        ApplicationTitle.Size = New Size(247, 169)
        ApplicationTitle.TabIndex = 0
        ApplicationTitle.Text = "Barangay System"
        ApplicationTitle.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' DetailsLayoutPanel
        ' 
        DetailsLayoutPanel.Anchor = AnchorStyles.None
        DetailsLayoutPanel.BackColor = Color.Transparent
        DetailsLayoutPanel.ColumnCount = 1
        DetailsLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 142F))
        DetailsLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 142F))
        DetailsLayoutPanel.Controls.Add(Version, 0, 0)
        DetailsLayoutPanel.Controls.Add(Copyright, 0, 1)
        DetailsLayoutPanel.Location = New Point(3, 221)
        DetailsLayoutPanel.Name = "DetailsLayoutPanel"
        DetailsLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33F))
        DetailsLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33F))
        DetailsLayoutPanel.Size = New Size(237, 79)
        DetailsLayoutPanel.TabIndex = 1
        ' 
        ' Version
        ' 
        Version.Anchor = AnchorStyles.None
        Version.BackColor = Color.Transparent
        Version.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Version.Location = New Point(3, 9)
        Version.Name = "Version"
        Version.Size = New Size(231, 20)
        Version.TabIndex = 1
        Version.Text = "Version {0}.{1:00}"
        ' 
        ' Copyright
        ' 
        Copyright.Anchor = AnchorStyles.None
        Copyright.BackColor = Color.Transparent
        Copyright.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Copyright.Location = New Point(3, 39)
        Copyright.Name = "Copyright"
        Copyright.Size = New Size(231, 40)
        Copyright.TabIndex = 2
        Copyright.Text = "Copyright"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(246, 221)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(247, 23)
        ProgressBar1.TabIndex = 2
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 3
        ' 
        ' SplashScreen1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(496, 303)
        ControlBox = False
        Controls.Add(MainLayoutPanel)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "SplashScreen1"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        MainLayoutPanel.ResumeLayout(False)
        DetailsLayoutPanel.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer

End Class
