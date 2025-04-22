<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class g3CommandCenter_Form
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
        components = New ComponentModel.Container()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        OfficersAvailability_Btn = New Button()
        CaseRecords_Btn = New Button()
        CallLogging_Btn = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        MainPanel = New Panel()
        Label2 = New Label()
        ActiveCases_DataGridView = New DataGridView()
        Timer1 = New Timer(components)
        MenuStrip1 = New MenuStrip()
        FlowLayoutPanel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        MainPanel.SuspendLayout()
        CType(ActiveCases_DataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.SeaGreen
        FlowLayoutPanel1.Controls.Add(TableLayoutPanel1)
        FlowLayoutPanel1.Location = New Point(1, 1)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(224, 749)
        FlowLayoutPanel1.TabIndex = 9
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.SeaGreen
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 0)
        TableLayoutPanel1.Controls.Add(OfficersAvailability_Btn, 0, 3)
        TableLayoutPanel1.Controls.Add(CaseRecords_Btn, 0, 1)
        TableLayoutPanel1.Controls.Add(CallLogging_Btn, 0, 2)
        TableLayoutPanel1.Location = New Point(3, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 29.62963F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 23.45679F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 23.45679F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 23.45679F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(221, 746)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.23256F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 49.76744F))
        TableLayoutPanel2.Controls.Add(PictureBox2, 1, 0)
        TableLayoutPanel2.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel2.Location = New Point(3, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(215, 134)
        TableLayoutPanel2.TabIndex = 5
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources._482404742_1844290563062342_2384674934892593673_n
        PictureBox2.Location = New Point(111, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(101, 127)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._482585122_1176975447200876_593564339372044358_n
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(102, 127)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' OfficersAvailability_Btn
        ' 
        OfficersAvailability_Btn.BackColor = Color.SeaGreen
        OfficersAvailability_Btn.BackgroundImage = My.Resources.Resources.Officers__1_
        OfficersAvailability_Btn.BackgroundImageLayout = ImageLayout.Zoom
        OfficersAvailability_Btn.FlatStyle = FlatStyle.Flat
        OfficersAvailability_Btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        OfficersAvailability_Btn.ForeColor = Color.White
        OfficersAvailability_Btn.Location = New Point(3, 558)
        OfficersAvailability_Btn.Name = "OfficersAvailability_Btn"
        OfficersAvailability_Btn.Size = New Size(212, 117)
        OfficersAvailability_Btn.TabIndex = 3
        OfficersAvailability_Btn.Text = "Officers"
        OfficersAvailability_Btn.TextAlign = ContentAlignment.BottomCenter
        OfficersAvailability_Btn.UseVisualStyleBackColor = False
        ' 
        ' CaseRecords_Btn
        ' 
        CaseRecords_Btn.BackColor = Color.SeaGreen
        CaseRecords_Btn.BackgroundImage = My.Resources.Resources.CaseRecord_Close
        CaseRecords_Btn.BackgroundImageLayout = ImageLayout.Zoom
        CaseRecords_Btn.FlatStyle = FlatStyle.Flat
        CaseRecords_Btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        CaseRecords_Btn.ForeColor = Color.White
        CaseRecords_Btn.ImageAlign = ContentAlignment.BottomCenter
        CaseRecords_Btn.Location = New Point(3, 218)
        CaseRecords_Btn.Name = "CaseRecords_Btn"
        CaseRecords_Btn.Size = New Size(215, 110)
        CaseRecords_Btn.TabIndex = 1
        CaseRecords_Btn.Text = "Case Record"
        CaseRecords_Btn.TextAlign = ContentAlignment.BottomCenter
        CaseRecords_Btn.UseVisualStyleBackColor = False
        ' 
        ' CallLogging_Btn
        ' 
        CallLogging_Btn.BackColor = Color.SeaGreen
        CallLogging_Btn.BackgroundImage = My.Resources.Resources.CallLogs_Open__1_
        CallLogging_Btn.BackgroundImageLayout = ImageLayout.Zoom
        CallLogging_Btn.FlatStyle = FlatStyle.Flat
        CallLogging_Btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CallLogging_Btn.ForeColor = Color.White
        CallLogging_Btn.Location = New Point(3, 388)
        CallLogging_Btn.Name = "CallLogging_Btn"
        CallLogging_Btn.Size = New Size(212, 114)
        CallLogging_Btn.TabIndex = 2
        CallLogging_Btn.Text = "Call Logs"
        CallLogging_Btn.TextAlign = ContentAlignment.BottomCenter
        CallLogging_Btn.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SeaGreen
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TabControl1)
        Panel1.Location = New Point(225, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1436, 749)
        Panel1.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(89, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(722, 60)
        Label1.TabIndex = 4
        Label1.Text = "Brgy. Inosloban Command Center"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Location = New Point(0, 57)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1436, 692)
        TabControl1.TabIndex = 4
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Honeydew
        TabPage1.Controls.Add(MainPanel)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1428, 659)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        ' 
        ' MainPanel
        ' 
        MainPanel.AutoScroll = True
        MainPanel.Controls.Add(Label2)
        MainPanel.Controls.Add(ActiveCases_DataGridView)
        MainPanel.Location = New Point(0, 0)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(1425, 659)
        MainPanel.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.SeaGreen
        Label2.Location = New Point(1170, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(236, 50)
        Label2.TabIndex = 14
        Label2.Text = "Active Cases"
        ' 
        ' ActiveCases_DataGridView
        ' 
        ActiveCases_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ActiveCases_DataGridView.Location = New Point(3, 78)
        ActiveCases_DataGridView.Name = "ActiveCases_DataGridView"
        ActiveCases_DataGridView.RowHeadersWidth = 51
        ActiveCases_DataGridView.Size = New Size(1400, 575)
        ActiveCases_DataGridView.TabIndex = 13
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1663, 24)
        MenuStrip1.TabIndex = 11
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' g3CommandCenter_Form
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        ClientSize = New Size(1663, 749)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MinimumSize = New Size(1681, 796)
        Name = "g3CommandCenter_Form"
        FlowLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        MainPanel.ResumeLayout(False)
        MainPanel.PerformLayout()
        CType(ActiveCases_DataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents CaseRecords_Btn As Button
    Friend WithEvents CallLogging_Btn As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Timer1 As Timer
    Friend WithEvents OfficersAvailability_Btn As Button
    Friend WithEvents ActiveCases_DataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents MainPanel As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend Protected WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox

End Class
