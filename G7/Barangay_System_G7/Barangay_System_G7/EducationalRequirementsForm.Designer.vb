<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EducationalRequirementsForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbYearLevel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSchoolName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtStudentMiddleInitial = New System.Windows.Forms.TextBox()
        Me.txtStudentFirstName = New System.Windows.Forms.TextBox()
        Me.txtStudentLastName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.progressBarUpload = New System.Windows.Forms.ProgressBar()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.txtResidencyCertPath = New System.Windows.Forms.TextBox()
        Me.btnUploadResidencyCert = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtEnrollmentPath = New System.Windows.Forms.TextBox()
        Me.btnUploadEnrollment = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtIndigencyCertPath = New System.Windows.Forms.TextBox()
        Me.btnUploadIndigencyCert = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSchoolIDPath = New System.Windows.Forms.TextBox()
        Me.btnUploadSchoolID = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtReportCardPath = New System.Windows.Forms.TextBox()
        Me.btnUploadReportCard = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbYearLevel)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSchoolName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtStudentMiddleInitial)
        Me.GroupBox1.Controls.Add(Me.txtStudentFirstName)
        Me.GroupBox1.Controls.Add(Me.txtStudentLastName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 152)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter name of Student"
        '
        'cmbYearLevel
        '
        Me.cmbYearLevel.FormattingEnabled = True
        Me.cmbYearLevel.Items.AddRange(New Object() {"Elementary", "High School", "College"})
        Me.cmbYearLevel.Location = New System.Drawing.Point(168, 117)
        Me.cmbYearLevel.Name = "cmbYearLevel"
        Me.cmbYearLevel.Size = New System.Drawing.Size(153, 23)
        Me.cmbYearLevel.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 15)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Enter Year Level:"
        '
        'txtSchoolName
        '
        Me.txtSchoolName.Location = New System.Drawing.Point(168, 79)
        Me.txtSchoolName.Name = "txtSchoolName"
        Me.txtSchoolName.Size = New System.Drawing.Size(312, 21)
        Me.txtSchoolName.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 15)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Enter name of School:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(324, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 15)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Midde Initial:"
        '
        'txtStudentMiddleInitial
        '
        Me.txtStudentMiddleInitial.Location = New System.Drawing.Point(327, 44)
        Me.txtStudentMiddleInitial.Name = "txtStudentMiddleInitial"
        Me.txtStudentMiddleInitial.Size = New System.Drawing.Size(153, 21)
        Me.txtStudentMiddleInitial.TabIndex = 23
        '
        'txtStudentFirstName
        '
        Me.txtStudentFirstName.Location = New System.Drawing.Point(168, 44)
        Me.txtStudentFirstName.Name = "txtStudentFirstName"
        Me.txtStudentFirstName.Size = New System.Drawing.Size(153, 21)
        Me.txtStudentFirstName.TabIndex = 22
        '
        'txtStudentLastName
        '
        Me.txtStudentLastName.Location = New System.Drawing.Point(9, 44)
        Me.txtStudentLastName.Name = "txtStudentLastName"
        Me.txtStudentLastName.Size = New System.Drawing.Size(153, 21)
        Me.txtStudentLastName.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(165, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 15)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "First Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 15)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Last Name:"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSubmit.Location = New System.Drawing.Point(322, 168)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(181, 45)
        Me.btnSubmit.TabIndex = 33
        Me.btnSubmit.Text = "Submit Documents"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'progressBarUpload
        '
        Me.progressBarUpload.Location = New System.Drawing.Point(6, 20)
        Me.progressBarUpload.Name = "progressBarUpload"
        Me.progressBarUpload.Size = New System.Drawing.Size(192, 15)
        Me.progressBarUpload.TabIndex = 30
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Location = New System.Drawing.Point(204, 20)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(92, 15)
        Me.lblProgress.TabIndex = 31
        Me.lblProgress.Text = "0% Complete"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.lblProgress)
        Me.GroupBox8.Controls.Add(Me.progressBarUpload)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox8.Location = New System.Drawing.Point(11, 168)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(305, 45)
        Me.GroupBox8.TabIndex = 35
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Progress:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.GroupBox9)
        Me.GroupBox7.Controls.Add(Me.GroupBox2)
        Me.GroupBox7.Controls.Add(Me.GroupBox6)
        Me.GroupBox7.Controls.Add(Me.GroupBox3)
        Me.GroupBox7.Controls.Add(Me.GroupBox4)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox7.Location = New System.Drawing.Point(509, 12)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(333, 387)
        Me.GroupBox7.TabIndex = 36
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Upload the following documents:"
        '
        'GroupBox9
        '
        Me.GroupBox9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox9.Controls.Add(Me.txtResidencyCertPath)
        Me.GroupBox9.Controls.Add(Me.btnUploadResidencyCert)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox9.Location = New System.Drawing.Point(6, 236)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(317, 66)
        Me.GroupBox9.TabIndex = 34
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Barangay Certificate of Residency:"
        '
        'txtResidencyCertPath
        '
        Me.txtResidencyCertPath.Location = New System.Drawing.Point(143, 29)
        Me.txtResidencyCertPath.Name = "txtResidencyCertPath"
        Me.txtResidencyCertPath.ReadOnly = True
        Me.txtResidencyCertPath.Size = New System.Drawing.Size(164, 21)
        Me.txtResidencyCertPath.TabIndex = 1
        '
        'btnUploadResidencyCert
        '
        Me.btnUploadResidencyCert.Location = New System.Drawing.Point(11, 20)
        Me.btnUploadResidencyCert.Name = "btnUploadResidencyCert"
        Me.btnUploadResidencyCert.Size = New System.Drawing.Size(126, 38)
        Me.btnUploadResidencyCert.TabIndex = 0
        Me.btnUploadResidencyCert.Text = "Upload"
        Me.btnUploadResidencyCert.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtEnrollmentPath)
        Me.GroupBox2.Controls.Add(Me.btnUploadEnrollment)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(317, 66)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Certificate of Enrollment:"
        '
        'txtEnrollmentPath
        '
        Me.txtEnrollmentPath.Location = New System.Drawing.Point(143, 29)
        Me.txtEnrollmentPath.Name = "txtEnrollmentPath"
        Me.txtEnrollmentPath.ReadOnly = True
        Me.txtEnrollmentPath.Size = New System.Drawing.Size(164, 21)
        Me.txtEnrollmentPath.TabIndex = 1
        '
        'btnUploadEnrollment
        '
        Me.btnUploadEnrollment.Location = New System.Drawing.Point(11, 20)
        Me.btnUploadEnrollment.Name = "btnUploadEnrollment"
        Me.btnUploadEnrollment.Size = New System.Drawing.Size(126, 38)
        Me.btnUploadEnrollment.TabIndex = 0
        Me.btnUploadEnrollment.Text = "Upload"
        Me.btnUploadEnrollment.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.txtIndigencyCertPath)
        Me.GroupBox6.Controls.Add(Me.btnUploadIndigencyCert)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 308)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(317, 66)
        Me.GroupBox6.TabIndex = 33
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Certificate of Indigency:"
        '
        'txtIndigencyCertPath
        '
        Me.txtIndigencyCertPath.Location = New System.Drawing.Point(143, 29)
        Me.txtIndigencyCertPath.Name = "txtIndigencyCertPath"
        Me.txtIndigencyCertPath.ReadOnly = True
        Me.txtIndigencyCertPath.Size = New System.Drawing.Size(164, 21)
        Me.txtIndigencyCertPath.TabIndex = 1
        '
        'btnUploadIndigencyCert
        '
        Me.btnUploadIndigencyCert.Location = New System.Drawing.Point(11, 20)
        Me.btnUploadIndigencyCert.Name = "btnUploadIndigencyCert"
        Me.btnUploadIndigencyCert.Size = New System.Drawing.Size(126, 38)
        Me.btnUploadIndigencyCert.TabIndex = 0
        Me.btnUploadIndigencyCert.Text = "Upload"
        Me.btnUploadIndigencyCert.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txtSchoolIDPath)
        Me.GroupBox3.Controls.Add(Me.btnUploadSchoolID)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 92)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(317, 66)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Latest School ID:"
        '
        'txtSchoolIDPath
        '
        Me.txtSchoolIDPath.Location = New System.Drawing.Point(143, 29)
        Me.txtSchoolIDPath.Name = "txtSchoolIDPath"
        Me.txtSchoolIDPath.ReadOnly = True
        Me.txtSchoolIDPath.Size = New System.Drawing.Size(164, 21)
        Me.txtSchoolIDPath.TabIndex = 1
        '
        'btnUploadSchoolID
        '
        Me.btnUploadSchoolID.Location = New System.Drawing.Point(11, 20)
        Me.btnUploadSchoolID.Name = "btnUploadSchoolID"
        Me.btnUploadSchoolID.Size = New System.Drawing.Size(126, 38)
        Me.btnUploadSchoolID.TabIndex = 0
        Me.btnUploadSchoolID.Text = "Upload"
        Me.btnUploadSchoolID.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.txtReportCardPath)
        Me.GroupBox4.Controls.Add(Me.btnUploadReportCard)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 164)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(317, 66)
        Me.GroupBox4.TabIndex = 31
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Report Card:"
        '
        'txtReportCardPath
        '
        Me.txtReportCardPath.Location = New System.Drawing.Point(143, 29)
        Me.txtReportCardPath.Name = "txtReportCardPath"
        Me.txtReportCardPath.ReadOnly = True
        Me.txtReportCardPath.Size = New System.Drawing.Size(164, 21)
        Me.txtReportCardPath.TabIndex = 1
        '
        'btnUploadReportCard
        '
        Me.btnUploadReportCard.Location = New System.Drawing.Point(11, 20)
        Me.btnUploadReportCard.Name = "btnUploadReportCard"
        Me.btnUploadReportCard.Size = New System.Drawing.Size(126, 38)
        Me.btnUploadReportCard.TabIndex = 0
        Me.btnUploadReportCard.Text = "Upload"
        Me.btnUploadReportCard.UseVisualStyleBackColor = True
        '
        'EducationalRequirementsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(851, 406)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "EducationalRequirementsForm"
        Me.ShowIcon = False
        Me.Text = "EDUCATIONAL ASSISTANCE REQUIREMENTS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtStudentMiddleInitial As TextBox
    Friend WithEvents txtStudentFirstName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents progressBarUpload As ProgressBar
    Friend WithEvents lblProgress As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtEnrollmentPath As TextBox
    Friend WithEvents btnUploadEnrollment As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtSchoolIDPath As TextBox
    Friend WithEvents btnUploadSchoolID As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtReportCardPath As TextBox
    Friend WithEvents btnUploadReportCard As Button
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents txtResidencyCertPath As TextBox
    Friend WithEvents btnUploadResidencyCert As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtIndigencyCertPath As TextBox
    Friend WithEvents btnUploadIndigencyCert As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSchoolName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStudentLastName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbYearLevel As ComboBox
End Class
