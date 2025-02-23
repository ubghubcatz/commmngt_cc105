<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        pnlSideBar = New Panel()
        SchedBtn = New Button()
        AttendanceBtn = New Button()
        ListBtn = New Button()
        pnlLogo = New Panel()
        Panel1 = New Panel()
        pnlMain = New Panel()
        Label1 = New Label()
        pnlSideBar.SuspendLayout()
        pnlMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSideBar
        ' 
        pnlSideBar.BackColor = Color.FromArgb(CByte(71), CByte(184), CByte(129))
        pnlSideBar.Controls.Add(SchedBtn)
        pnlSideBar.Controls.Add(AttendanceBtn)
        pnlSideBar.Controls.Add(ListBtn)
        pnlSideBar.Controls.Add(pnlLogo)
        pnlSideBar.Dock = DockStyle.Left
        pnlSideBar.Location = New Point(0, 0)
        pnlSideBar.Name = "pnlSideBar"
        pnlSideBar.Size = New Size(250, 591)
        pnlSideBar.TabIndex = 0
        ' 
        ' SchedBtn
        ' 
        SchedBtn.BackColor = SystemColors.ControlLightLight
        SchedBtn.FlatAppearance.BorderSize = 0
        SchedBtn.FlatStyle = FlatStyle.Flat
        SchedBtn.Location = New Point(5, 274)
        SchedBtn.Name = "SchedBtn"
        SchedBtn.Size = New Size(240, 60)
        SchedBtn.TabIndex = 3
        SchedBtn.Text = "Shift Schedule"
        SchedBtn.UseVisualStyleBackColor = False
        ' 
        ' AttendanceBtn
        ' 
        AttendanceBtn.BackColor = SystemColors.ControlLightLight
        AttendanceBtn.FlatAppearance.BorderSize = 0
        AttendanceBtn.FlatStyle = FlatStyle.Flat
        AttendanceBtn.Location = New Point(5, 208)
        AttendanceBtn.Name = "AttendanceBtn"
        AttendanceBtn.Size = New Size(240, 60)
        AttendanceBtn.TabIndex = 2
        AttendanceBtn.Text = "Employee Attendance"
        AttendanceBtn.UseVisualStyleBackColor = False
        ' 
        ' ListBtn
        ' 
        ListBtn.BackColor = SystemColors.ControlLightLight
        ListBtn.FlatAppearance.BorderSize = 0
        ListBtn.FlatStyle = FlatStyle.Flat
        ListBtn.Location = New Point(5, 142)
        ListBtn.Name = "ListBtn"
        ListBtn.Size = New Size(240, 60)
        ListBtn.TabIndex = 1
        ListBtn.Text = "Employee List"
        ListBtn.UseVisualStyleBackColor = False
        ' 
        ' pnlLogo
        ' 
        pnlLogo.BackColor = Color.FromArgb(CByte(234), CByte(250), CByte(241))
        pnlLogo.BackgroundImage = My.Resources.Resources.Beysik__removebg_preview
        pnlLogo.BackgroundImageLayout = ImageLayout.Zoom
        pnlLogo.Dock = DockStyle.Top
        pnlLogo.Location = New Point(0, 0)
        pnlLogo.Name = "pnlLogo"
        pnlLogo.Size = New Size(250, 137)
        pnlLogo.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(62))
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(250, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(829, 69)
        Panel1.TabIndex = 1
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.FromArgb(CByte(212), CByte(238), CByte(226))
        pnlMain.Controls.Add(Label1)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(250, 69)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(829, 522)
        pnlMain.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(24), CByte(106), CByte(59))
        Label1.Location = New Point(209, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(384, 28)
        Label1.TabIndex = 0
        Label1.Text = "Scheduler / Employee Task Assignment"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1079, 591)
        Controls.Add(pnlMain)
        Controls.Add(Panel1)
        Controls.Add(pnlSideBar)
        Name = "Form1"
        Text = "Form1"
        pnlSideBar.ResumeLayout(False)
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSideBar As Panel
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents ListBtn As Button
    Friend WithEvents SchedBtn As Button
    Friend WithEvents AttendanceBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents Label1 As Label

End Class
