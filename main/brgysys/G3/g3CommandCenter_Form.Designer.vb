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
        Label6 = New Label()
        EndDate_DateTimePicker = New DateTimePicker()
        StartDate_DateTimePicker = New DateTimePicker()
        AverageCompletion_Label = New Label()
        CasesResolved_Label = New Label()
        CasesReported_Label = New Label()
        Label8 = New Label()
        lab = New Label()
        IPCasesCount_Panel = New Panel()
        InProgressCasesCount_Label = New Label()
        Label5 = New Label()
        OpenCasesCount_Panel = New Panel()
        OpenCasesCount_Label = New Label()
        Label4 = New Label()
        PendingCasesCount_Panel = New Panel()
        PendingCasesCount_Label = New Label()
        Label3 = New Label()
        ResolvedCasesCount_Panel = New Panel()
        ResolvedCasesCount_Label = New Label()
        Label2 = New Label()
        Timer1 = New Timer(components)
        MenuStrip1 = New MenuStrip()
        SqlCommand1 = New Microsoft.Data.SqlClient.SqlCommand()
        FlowLayoutPanel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        MainPanel.SuspendLayout()
        IPCasesCount_Panel.SuspendLayout()
        OpenCasesCount_Panel.SuspendLayout()
        PendingCasesCount_Panel.SuspendLayout()
        ResolvedCasesCount_Panel.SuspendLayout()
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
        CaseRecords_Btn.Text = "Case Records"
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
        MainPanel.Controls.Add(Label6)
        MainPanel.Controls.Add(EndDate_DateTimePicker)
        MainPanel.Controls.Add(StartDate_DateTimePicker)
        MainPanel.Controls.Add(AverageCompletion_Label)
        MainPanel.Controls.Add(CasesResolved_Label)
        MainPanel.Controls.Add(CasesReported_Label)
        MainPanel.Controls.Add(Label8)
        MainPanel.Controls.Add(lab)
        MainPanel.Controls.Add(IPCasesCount_Panel)
        MainPanel.Controls.Add(OpenCasesCount_Panel)
        MainPanel.Controls.Add(PendingCasesCount_Panel)
        MainPanel.Controls.Add(ResolvedCasesCount_Panel)
        MainPanel.Location = New Point(0, 0)
        MainPanel.MaximumSize = New Size(1425, 659)
        MainPanel.MinimumSize = New Size(1425, 659)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(1425, 659)
        MainPanel.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Green
        Label6.Location = New Point(647, 228)
        Label6.Name = "Label6"
        Label6.Size = New Size(145, 31)
        Label6.TabIndex = 15
        Label6.Text = "Ending Date"
        ' 
        ' EndDate_DateTimePicker
        ' 
        EndDate_DateTimePicker.CustomFormat = "MM-dd-yyyy"
        EndDate_DateTimePicker.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        EndDate_DateTimePicker.Format = DateTimePickerFormat.Custom
        EndDate_DateTimePicker.Location = New Point(647, 262)
        EndDate_DateTimePicker.Name = "EndDate_DateTimePicker"
        EndDate_DateTimePicker.ShowUpDown = True
        EndDate_DateTimePicker.Size = New Size(223, 34)
        EndDate_DateTimePicker.TabIndex = 14
        ' 
        ' StartDate_DateTimePicker
        ' 
        StartDate_DateTimePicker.CustomFormat = "MM-dd-yyyy"
        StartDate_DateTimePicker.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StartDate_DateTimePicker.Format = DateTimePickerFormat.Custom
        StartDate_DateTimePicker.Location = New Point(341, 262)
        StartDate_DateTimePicker.Name = "StartDate_DateTimePicker"
        StartDate_DateTimePicker.ShowUpDown = True
        StartDate_DateTimePicker.Size = New Size(222, 34)
        StartDate_DateTimePicker.TabIndex = 13
        ' 
        ' AverageCompletion_Label
        ' 
        AverageCompletion_Label.AutoSize = True
        AverageCompletion_Label.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold)
        AverageCompletion_Label.ForeColor = Color.Green
        AverageCompletion_Label.Location = New Point(221, 546)
        AverageCompletion_Label.Name = "AverageCompletion_Label"
        AverageCompletion_Label.Size = New Size(222, 46)
        AverageCompletion_Label.TabIndex = 12
        AverageCompletion_Label.Text = "Cases Count:"
        ' 
        ' CasesResolved_Label
        ' 
        CasesResolved_Label.AutoSize = True
        CasesResolved_Label.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold)
        CasesResolved_Label.ForeColor = Color.Green
        CasesResolved_Label.Location = New Point(221, 442)
        CasesResolved_Label.Name = "CasesResolved_Label"
        CasesResolved_Label.Size = New Size(222, 46)
        CasesResolved_Label.TabIndex = 11
        CasesResolved_Label.Text = "Cases Count:"
        ' 
        ' CasesReported_Label
        ' 
        CasesReported_Label.AutoSize = True
        CasesReported_Label.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold)
        CasesReported_Label.ForeColor = Color.Green
        CasesReported_Label.Location = New Point(221, 341)
        CasesReported_Label.Name = "CasesReported_Label"
        CasesReported_Label.Size = New Size(222, 46)
        CasesReported_Label.TabIndex = 10
        CasesReported_Label.Text = "Cases Count:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Green
        Label8.Location = New Point(221, 12)
        Label8.Name = "Label8"
        Label8.Size = New Size(300, 38)
        Label8.TabIndex = 9
        Label8.Text = "All Time Cases Count:"
        ' 
        ' lab
        ' 
        lab.AutoSize = True
        lab.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lab.ForeColor = Color.Green
        lab.Location = New Point(341, 228)
        lab.Name = "lab"
        lab.Size = New Size(157, 31)
        lab.TabIndex = 5
        lab.Text = "Starting Date"
        ' 
        ' IPCasesCount_Panel
        ' 
        IPCasesCount_Panel.BackColor = Color.SandyBrown
        IPCasesCount_Panel.Controls.Add(InProgressCasesCount_Label)
        IPCasesCount_Panel.Controls.Add(Label5)
        IPCasesCount_Panel.Location = New Point(934, 66)
        IPCasesCount_Panel.Name = "IPCasesCount_Panel"
        IPCasesCount_Panel.Size = New Size(181, 101)
        IPCasesCount_Panel.TabIndex = 3
        ' 
        ' InProgressCasesCount_Label
        ' 
        InProgressCasesCount_Label.AutoSize = True
        InProgressCasesCount_Label.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        InProgressCasesCount_Label.ForeColor = Color.White
        InProgressCasesCount_Label.Location = New Point(3, 62)
        InProgressCasesCount_Label.Name = "InProgressCasesCount_Label"
        InProgressCasesCount_Label.Size = New Size(27, 31)
        InProgressCasesCount_Label.TabIndex = 8
        InProgressCasesCount_Label.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(45, 15)
        Label5.Name = "Label5"
        Label5.Size = New Size(133, 31)
        Label5.TabIndex = 7
        Label5.Text = "In Progress"
        ' 
        ' OpenCasesCount_Panel
        ' 
        OpenCasesCount_Panel.BackColor = Color.Tomato
        OpenCasesCount_Panel.Controls.Add(OpenCasesCount_Label)
        OpenCasesCount_Panel.Controls.Add(Label4)
        OpenCasesCount_Panel.Location = New Point(692, 66)
        OpenCasesCount_Panel.Name = "OpenCasesCount_Panel"
        OpenCasesCount_Panel.Size = New Size(181, 101)
        OpenCasesCount_Panel.TabIndex = 3
        ' 
        ' OpenCasesCount_Label
        ' 
        OpenCasesCount_Label.AutoSize = True
        OpenCasesCount_Label.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        OpenCasesCount_Label.ForeColor = Color.White
        OpenCasesCount_Label.Location = New Point(3, 62)
        OpenCasesCount_Label.Name = "OpenCasesCount_Label"
        OpenCasesCount_Label.Size = New Size(27, 31)
        OpenCasesCount_Label.TabIndex = 7
        OpenCasesCount_Label.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(43, 15)
        Label4.Name = "Label4"
        Label4.Size = New Size(135, 31)
        Label4.TabIndex = 6
        Label4.Text = "Open Cases"
        ' 
        ' PendingCasesCount_Panel
        ' 
        PendingCasesCount_Panel.BackColor = Color.DarkKhaki
        PendingCasesCount_Panel.Controls.Add(PendingCasesCount_Label)
        PendingCasesCount_Panel.Controls.Add(Label3)
        PendingCasesCount_Panel.Location = New Point(452, 66)
        PendingCasesCount_Panel.Name = "PendingCasesCount_Panel"
        PendingCasesCount_Panel.Size = New Size(181, 101)
        PendingCasesCount_Panel.TabIndex = 3
        ' 
        ' PendingCasesCount_Label
        ' 
        PendingCasesCount_Label.AutoSize = True
        PendingCasesCount_Label.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PendingCasesCount_Label.ForeColor = Color.White
        PendingCasesCount_Label.Location = New Point(3, 62)
        PendingCasesCount_Label.Name = "PendingCasesCount_Label"
        PendingCasesCount_Label.Size = New Size(27, 31)
        PendingCasesCount_Label.TabIndex = 6
        PendingCasesCount_Label.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(12, 15)
        Label3.Name = "Label3"
        Label3.Size = New Size(166, 31)
        Label3.TabIndex = 5
        Label3.Text = "Pending Cases"
        ' 
        ' ResolvedCasesCount_Panel
        ' 
        ResolvedCasesCount_Panel.BackColor = Color.Green
        ResolvedCasesCount_Panel.Controls.Add(ResolvedCasesCount_Label)
        ResolvedCasesCount_Panel.Controls.Add(Label2)
        ResolvedCasesCount_Panel.Location = New Point(221, 66)
        ResolvedCasesCount_Panel.Name = "ResolvedCasesCount_Panel"
        ResolvedCasesCount_Panel.Size = New Size(181, 101)
        ResolvedCasesCount_Panel.TabIndex = 2
        ' 
        ' ResolvedCasesCount_Label
        ' 
        ResolvedCasesCount_Label.AutoSize = True
        ResolvedCasesCount_Label.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ResolvedCasesCount_Label.ForeColor = Color.White
        ResolvedCasesCount_Label.Location = New Point(3, 58)
        ResolvedCasesCount_Label.Name = "ResolvedCasesCount_Label"
        ResolvedCasesCount_Label.Size = New Size(27, 31)
        ResolvedCasesCount_Label.TabIndex = 4
        ResolvedCasesCount_Label.Text = "0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(5, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(173, 31)
        Label2.TabIndex = 4
        Label2.Text = "Resolved Cases"
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
        ' SqlCommand1
        ' 
        SqlCommand1.CommandTimeout = 30
        SqlCommand1.EnableOptimizedParameterBinding = False
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
        IPCasesCount_Panel.ResumeLayout(False)
        IPCasesCount_Panel.PerformLayout()
        OpenCasesCount_Panel.ResumeLayout(False)
        OpenCasesCount_Panel.PerformLayout()
        PendingCasesCount_Panel.ResumeLayout(False)
        PendingCasesCount_Panel.PerformLayout()
        ResolvedCasesCount_Panel.ResumeLayout(False)
        ResolvedCasesCount_Panel.PerformLayout()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents MainPanel As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IPCasesCount_Panel As Panel
    Friend WithEvents OpenCasesCount_Panel As Panel
    Friend WithEvents PendingCasesCount_Panel As Panel
    Friend WithEvents ResolvedCasesCount_Panel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents InProgressCasesCount_Label As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents OpenCasesCount_Label As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PendingCasesCount_Label As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ResolvedCasesCount_Label As Label
    Friend WithEvents SqlCommand1 As Microsoft.Data.SqlClient.SqlCommand
    Friend WithEvents lab As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents EndDate_DateTimePicker As DateTimePicker
    Friend WithEvents StartDate_DateTimePicker As DateTimePicker
    Friend WithEvents AverageCompletion_Label As Label
    Friend WithEvents CasesResolved_Label As Label
    Friend WithEvents CasesReported_Label As Label
    Friend WithEvents Label6 As Label

End Class
