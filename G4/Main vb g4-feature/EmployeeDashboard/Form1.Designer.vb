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
        schedBtn = New Button()
        attendanceBtn = New Button()
        ListBtn = New Button()
        pnlLogo = New Panel()
        Panel1 = New Panel()
        pnlMain = New Panel()
        pnlSideBar.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSideBar
        ' 
        pnlSideBar.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        pnlSideBar.Controls.Add(schedBtn)
        pnlSideBar.Controls.Add(attendanceBtn)
        pnlSideBar.Controls.Add(ListBtn)
        pnlSideBar.Controls.Add(pnlLogo)
        pnlSideBar.Dock = DockStyle.Left
        pnlSideBar.Location = New Point(0, 0)
        pnlSideBar.Name = "pnlSideBar"
        pnlSideBar.Size = New Size(250, 591)
        pnlSideBar.TabIndex = 0
        ' 
        ' schedBtn
        ' 
        schedBtn.BackColor = SystemColors.ControlLightLight
        schedBtn.FlatAppearance.BorderSize = 0
        schedBtn.FlatStyle = FlatStyle.Flat
        schedBtn.Location = New Point(5, 274)
        schedBtn.Name = "schedBtn"
        schedBtn.Size = New Size(240, 60)
        schedBtn.TabIndex = 3
        schedBtn.Text = "Shift Schedule"
        schedBtn.UseVisualStyleBackColor = False
        ' 
        ' attendanceBtn
        ' 
        attendanceBtn.BackColor = SystemColors.ControlLightLight
        attendanceBtn.FlatAppearance.BorderSize = 0
        attendanceBtn.FlatStyle = FlatStyle.Flat
        attendanceBtn.Location = New Point(5, 208)
        attendanceBtn.Name = "attendanceBtn"
        attendanceBtn.Size = New Size(240, 60)
        attendanceBtn.TabIndex = 2
        attendanceBtn.Text = "Employee Attendance"
        attendanceBtn.UseVisualStyleBackColor = False
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
        pnlLogo.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
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
        Panel1.BackColor = Color.FromArgb(CByte(88), CByte(27), CByte(152))
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(250, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(829, 69)
        Panel1.TabIndex = 1
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.FromArgb(CByte(186), CByte(83), CByte(222))
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(250, 69)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(829, 522)
        pnlMain.TabIndex = 2
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
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSideBar As Panel
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents ListBtn As Button
    Friend WithEvents schedBtn As Button
    Friend WithEvents attendanceBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlMain As Panel

End Class
