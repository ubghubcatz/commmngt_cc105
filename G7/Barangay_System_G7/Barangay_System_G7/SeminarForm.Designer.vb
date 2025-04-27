<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SeminarForm
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
        Me.lvSeminars = New System.Windows.Forms.ListView()
        Me.btnDeleteSeminar = New System.Windows.Forms.Button()
        Me.btnApproveSeminar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAddSeminar = New System.Windows.Forms.Button()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.grpSeminarDetails = New System.Windows.Forms.GroupBox()
        Me.lstSpeakers = New System.Windows.Forms.ListBox()
        Me.btnAddSpeaker = New System.Windows.Forms.Button()
        Me.txtSeminarTitle = New System.Windows.Forms.TextBox()
        Me.dtpSeminarDate = New System.Windows.Forms.DateTimePicker()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAddSpeaker = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpRegisteredSeminar = New System.Windows.Forms.GroupBox()
        Me.grpSemianrCoord = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCoordinatorMiddleInitial = New System.Windows.Forms.TextBox()
        Me.txtCoordinatorFirstName = New System.Windows.Forms.TextBox()
        Me.txtCoordinatorLastName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.grpSeminarDetails.SuspendLayout()
        Me.grpRegisteredSeminar.SuspendLayout()
        Me.grpSemianrCoord.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvSeminars
        '
        Me.lvSeminars.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvSeminars.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvSeminars.FullRowSelect = True
        Me.lvSeminars.GridLines = True
        Me.lvSeminars.HideSelection = False
        Me.lvSeminars.Location = New System.Drawing.Point(7, 20)
        Me.lvSeminars.MultiSelect = False
        Me.lvSeminars.Name = "lvSeminars"
        Me.lvSeminars.Size = New System.Drawing.Size(510, 272)
        Me.lvSeminars.TabIndex = 19
        Me.lvSeminars.UseCompatibleStateImageBehavior = False
        Me.lvSeminars.View = System.Windows.Forms.View.Details
        '
        'btnDeleteSeminar
        '
        Me.btnDeleteSeminar.BackColor = System.Drawing.Color.Red
        Me.btnDeleteSeminar.Location = New System.Drawing.Point(259, 304)
        Me.btnDeleteSeminar.Name = "btnDeleteSeminar"
        Me.btnDeleteSeminar.Size = New System.Drawing.Size(256, 42)
        Me.btnDeleteSeminar.TabIndex = 17
        Me.btnDeleteSeminar.Text = "DELETE SEMINAR"
        Me.btnDeleteSeminar.UseVisualStyleBackColor = False
        '
        'btnApproveSeminar
        '
        Me.btnApproveSeminar.BackColor = System.Drawing.Color.LimeGreen
        Me.btnApproveSeminar.Location = New System.Drawing.Point(7, 304)
        Me.btnApproveSeminar.Name = "btnApproveSeminar"
        Me.btnApproveSeminar.Size = New System.Drawing.Size(246, 42)
        Me.btnApproveSeminar.TabIndex = 16
        Me.btnApproveSeminar.Text = "APPROVE SEMINAR"
        Me.btnApproveSeminar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAddSeminar)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 298)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(551, 161)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Seminar Details"
        '
        'btnAddSeminar
        '
        Me.btnAddSeminar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAddSeminar.Location = New System.Drawing.Point(388, 21)
        Me.btnAddSeminar.Name = "btnAddSeminar"
        Me.btnAddSeminar.Size = New System.Drawing.Size(155, 134)
        Me.btnAddSeminar.TabIndex = 20
        Me.btnAddSeminar.Text = "ADD SEMINAR"
        Me.btnAddSeminar.UseVisualStyleBackColor = False
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.Location = New System.Drawing.Point(7, 21)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(375, 134)
        Me.txtDescription.TabIndex = 15
        '
        'grpSeminarDetails
        '
        Me.grpSeminarDetails.Controls.Add(Me.lstSpeakers)
        Me.grpSeminarDetails.Controls.Add(Me.btnAddSpeaker)
        Me.grpSeminarDetails.Controls.Add(Me.txtSeminarTitle)
        Me.grpSeminarDetails.Controls.Add(Me.dtpSeminarDate)
        Me.grpSeminarDetails.Controls.Add(Me.txtLocation)
        Me.grpSeminarDetails.Controls.Add(Me.Label5)
        Me.grpSeminarDetails.Controls.Add(Me.Label4)
        Me.grpSeminarDetails.Controls.Add(Me.Label2)
        Me.grpSeminarDetails.Controls.Add(Me.txtAddSpeaker)
        Me.grpSeminarDetails.Controls.Add(Me.Label3)
        Me.grpSeminarDetails.Location = New System.Drawing.Point(10, 127)
        Me.grpSeminarDetails.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpSeminarDetails.Name = "grpSeminarDetails"
        Me.grpSeminarDetails.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpSeminarDetails.Size = New System.Drawing.Size(551, 338)
        Me.grpSeminarDetails.TabIndex = 20
        Me.grpSeminarDetails.TabStop = False
        Me.grpSeminarDetails.Text = "Create New Seminar"
        '
        'lstSpeakers
        '
        Me.lstSpeakers.FormattingEnabled = True
        Me.lstSpeakers.ItemHeight = 15
        Me.lstSpeakers.Location = New System.Drawing.Point(234, 76)
        Me.lstSpeakers.Name = "lstSpeakers"
        Me.lstSpeakers.Size = New System.Drawing.Size(309, 79)
        Me.lstSpeakers.TabIndex = 23
        '
        'btnAddSpeaker
        '
        Me.btnAddSpeaker.Location = New System.Drawing.Point(437, 39)
        Me.btnAddSpeaker.Name = "btnAddSpeaker"
        Me.btnAddSpeaker.Size = New System.Drawing.Size(107, 28)
        Me.btnAddSpeaker.TabIndex = 22
        Me.btnAddSpeaker.Text = "Add Speaker"
        Me.btnAddSpeaker.UseVisualStyleBackColor = True
        '
        'txtSeminarTitle
        '
        Me.txtSeminarTitle.Location = New System.Drawing.Point(11, 43)
        Me.txtSeminarTitle.Name = "txtSeminarTitle"
        Me.txtSeminarTitle.Size = New System.Drawing.Size(195, 21)
        Me.txtSeminarTitle.TabIndex = 4
        '
        'dtpSeminarDate
        '
        Me.dtpSeminarDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSeminarDate.Location = New System.Drawing.Point(11, 133)
        Me.dtpSeminarDate.Name = "dtpSeminarDate"
        Me.dtpSeminarDate.Size = New System.Drawing.Size(195, 21)
        Me.dtpSeminarDate.TabIndex = 9
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(11, 88)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(195, 21)
        Me.txtLocation.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(231, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 18)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Speaker:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Location:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Title of Seminar:"
        '
        'txtAddSpeaker
        '
        Me.txtAddSpeaker.Location = New System.Drawing.Point(234, 43)
        Me.txtAddSpeaker.Name = "txtAddSpeaker"
        Me.txtAddSpeaker.Size = New System.Drawing.Size(190, 21)
        Me.txtAddSpeaker.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Date of Seminar:"
        '
        'grpRegisteredSeminar
        '
        Me.grpRegisteredSeminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpRegisteredSeminar.Controls.Add(Me.lvSeminars)
        Me.grpRegisteredSeminar.Controls.Add(Me.btnDeleteSeminar)
        Me.grpRegisteredSeminar.Controls.Add(Me.btnApproveSeminar)
        Me.grpRegisteredSeminar.Location = New System.Drawing.Point(568, 13)
        Me.grpRegisteredSeminar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpRegisteredSeminar.Name = "grpRegisteredSeminar"
        Me.grpRegisteredSeminar.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpRegisteredSeminar.Size = New System.Drawing.Size(524, 363)
        Me.grpRegisteredSeminar.TabIndex = 22
        Me.grpRegisteredSeminar.TabStop = False
        Me.grpRegisteredSeminar.Text = "Registered Seminars:"
        '
        'grpSemianrCoord
        '
        Me.grpSemianrCoord.Controls.Add(Me.Label8)
        Me.grpSemianrCoord.Controls.Add(Me.txtCoordinatorMiddleInitial)
        Me.grpSemianrCoord.Controls.Add(Me.txtCoordinatorFirstName)
        Me.grpSemianrCoord.Controls.Add(Me.txtCoordinatorLastName)
        Me.grpSemianrCoord.Controls.Add(Me.Label7)
        Me.grpSemianrCoord.Controls.Add(Me.Label6)
        Me.grpSemianrCoord.Controls.Add(Me.Label1)
        Me.grpSemianrCoord.Location = New System.Drawing.Point(10, 13)
        Me.grpSemianrCoord.Name = "grpSemianrCoord"
        Me.grpSemianrCoord.Size = New System.Drawing.Size(551, 108)
        Me.grpSemianrCoord.TabIndex = 23
        Me.grpSemianrCoord.TabStop = False
        Me.grpSemianrCoord.Text = "Seminar Coordinator"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(374, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 15)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Midde Initial:"
        '
        'txtCoordinatorMiddleInitial
        '
        Me.txtCoordinatorMiddleInitial.Location = New System.Drawing.Point(377, 73)
        Me.txtCoordinatorMiddleInitial.Name = "txtCoordinatorMiddleInitial"
        Me.txtCoordinatorMiddleInitial.Size = New System.Drawing.Size(153, 21)
        Me.txtCoordinatorMiddleInitial.TabIndex = 5
        '
        'txtCoordinatorFirstName
        '
        Me.txtCoordinatorFirstName.Location = New System.Drawing.Point(194, 73)
        Me.txtCoordinatorFirstName.Name = "txtCoordinatorFirstName"
        Me.txtCoordinatorFirstName.Size = New System.Drawing.Size(153, 21)
        Me.txtCoordinatorFirstName.TabIndex = 4
        '
        'txtCoordinatorLastName
        '
        Me.txtCoordinatorLastName.Location = New System.Drawing.Point(11, 73)
        Me.txtCoordinatorLastName.Name = "txtCoordinatorLastName"
        Me.txtCoordinatorLastName.Size = New System.Drawing.Size(153, 21)
        Me.txtCoordinatorLastName.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(191, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "First Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Full Name:"
        '
        'SeminarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1094, 473)
        Me.Controls.Add(Me.grpSemianrCoord)
        Me.Controls.Add(Me.grpRegisteredSeminar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpSeminarDetails)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "SeminarForm"
        Me.ShowIcon = False
        Me.Text = "SEMINAR CREATOR"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpSeminarDetails.ResumeLayout(False)
        Me.grpSeminarDetails.PerformLayout()
        Me.grpRegisteredSeminar.ResumeLayout(False)
        Me.grpSemianrCoord.ResumeLayout(False)
        Me.grpSemianrCoord.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvSeminars As ListView
    Friend WithEvents btnDeleteSeminar As Button
    Friend WithEvents btnApproveSeminar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents grpSeminarDetails As GroupBox
    Friend WithEvents txtSeminarTitle As TextBox
    Friend WithEvents dtpSeminarDate As DateTimePicker
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAddSpeaker As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents grpRegisteredSeminar As GroupBox
    Friend WithEvents grpSemianrCoord As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCoordinatorMiddleInitial As TextBox
    Friend WithEvents txtCoordinatorFirstName As TextBox
    Friend WithEvents txtCoordinatorLastName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAddSpeaker As Button
    Friend WithEvents lstSpeakers As ListBox
    Friend WithEvents btnAddSeminar As Button
End Class
