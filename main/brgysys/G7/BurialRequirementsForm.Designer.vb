<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BurialRequirementsForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpDateOfDeath = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDeceasedMiddleName = New System.Windows.Forms.TextBox()
        Me.txtDeceasedFirstName = New System.Windows.Forms.TextBox()
        Me.txtDeceasedLastName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDeathCertPath = New System.Windows.Forms.TextBox()
        Me.btnUploadDeathCert = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtBarangayCertPath = New System.Windows.Forms.TextBox()
        Me.btnUploadBarangayCert = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtValidIDPath = New System.Windows.Forms.TextBox()
        Me.btnUploadValidID = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtFuneralContractPath = New System.Windows.Forms.TextBox()
        Me.btnUploadFuneralContract = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtIndigencyCertPath = New System.Windows.Forms.TextBox()
        Me.btnUploadIndigencyCert = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.progressBarUpload = New System.Windows.Forms.ProgressBar()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRelationToDeceased = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRelationToDeceased)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpDateOfDeath)
        Me.GroupBox1.Controls.Add(Me.dtpDateOfBirth)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtDeceasedMiddleName)
        Me.GroupBox1.Controls.Add(Me.txtDeceasedFirstName)
        Me.GroupBox1.Controls.Add(Me.txtDeceasedLastName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 158)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter name of the Deceased:"
        '
        'dtpDateOfDeath
        '
        Me.dtpDateOfDeath.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateOfDeath.Location = New System.Drawing.Point(342, 80)
        Me.dtpDateOfDeath.Name = "dtpDateOfDeath"
        Me.dtpDateOfDeath.Size = New System.Drawing.Size(112, 21)
        Me.dtpDateOfDeath.TabIndex = 28
        '
        'dtpDateOfBirth
        '
        Me.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateOfBirth.Location = New System.Drawing.Point(103, 80)
        Me.dtpDateOfBirth.Name = "dtpDateOfBirth"
        Me.dtpDateOfBirth.Size = New System.Drawing.Size(112, 21)
        Me.dtpDateOfBirth.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(237, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 15)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Date of Death:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Date of Birth:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(324, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 15)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Midde Name:"
        '
        'txtDeceasedMiddleName
        '
        Me.txtDeceasedMiddleName.Location = New System.Drawing.Point(327, 44)
        Me.txtDeceasedMiddleName.Name = "txtDeceasedMiddleName"
        Me.txtDeceasedMiddleName.Size = New System.Drawing.Size(153, 21)
        Me.txtDeceasedMiddleName.TabIndex = 23
        '
        'txtDeceasedFirstName
        '
        Me.txtDeceasedFirstName.Location = New System.Drawing.Point(168, 44)
        Me.txtDeceasedFirstName.Name = "txtDeceasedFirstName"
        Me.txtDeceasedFirstName.Size = New System.Drawing.Size(153, 21)
        Me.txtDeceasedFirstName.TabIndex = 22
        '
        'txtDeceasedLastName
        '
        Me.txtDeceasedLastName.Location = New System.Drawing.Point(9, 44)
        Me.txtDeceasedLastName.Name = "txtDeceasedLastName"
        Me.txtDeceasedLastName.Size = New System.Drawing.Size(153, 21)
        Me.txtDeceasedLastName.TabIndex = 21
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
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtDeathCertPath)
        Me.GroupBox2.Controls.Add(Me.btnUploadDeathCert)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(317, 66)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Death Certificate:"
        '
        'txtDeathCertPath
        '
        Me.txtDeathCertPath.Location = New System.Drawing.Point(143, 29)
        Me.txtDeathCertPath.Name = "txtDeathCertPath"
        Me.txtDeathCertPath.ReadOnly = True
        Me.txtDeathCertPath.Size = New System.Drawing.Size(164, 21)
        Me.txtDeathCertPath.TabIndex = 1
        '
        'btnUploadDeathCert
        '
        Me.btnUploadDeathCert.Location = New System.Drawing.Point(11, 20)
        Me.btnUploadDeathCert.Name = "btnUploadDeathCert"
        Me.btnUploadDeathCert.Size = New System.Drawing.Size(126, 38)
        Me.btnUploadDeathCert.TabIndex = 0
        Me.btnUploadDeathCert.Text = "Upload"
        Me.btnUploadDeathCert.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txtBarangayCertPath)
        Me.GroupBox3.Controls.Add(Me.btnUploadBarangayCert)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 92)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(317, 66)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Barangay Certificate of Residency:"
        '
        'txtBarangayCertPath
        '
        Me.txtBarangayCertPath.Location = New System.Drawing.Point(143, 29)
        Me.txtBarangayCertPath.Name = "txtBarangayCertPath"
        Me.txtBarangayCertPath.ReadOnly = True
        Me.txtBarangayCertPath.Size = New System.Drawing.Size(164, 21)
        Me.txtBarangayCertPath.TabIndex = 1
        '
        'btnUploadBarangayCert
        '
        Me.btnUploadBarangayCert.Location = New System.Drawing.Point(11, 20)
        Me.btnUploadBarangayCert.Name = "btnUploadBarangayCert"
        Me.btnUploadBarangayCert.Size = New System.Drawing.Size(126, 38)
        Me.btnUploadBarangayCert.TabIndex = 0
        Me.btnUploadBarangayCert.Text = "Upload"
        Me.btnUploadBarangayCert.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.txtValidIDPath)
        Me.GroupBox4.Controls.Add(Me.btnUploadValidID)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 164)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(317, 66)
        Me.GroupBox4.TabIndex = 31
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Valid ID of Claimant:"
        '
        'txtValidIDPath
        '
        Me.txtValidIDPath.Location = New System.Drawing.Point(143, 29)
        Me.txtValidIDPath.Name = "txtValidIDPath"
        Me.txtValidIDPath.ReadOnly = True
        Me.txtValidIDPath.Size = New System.Drawing.Size(164, 21)
        Me.txtValidIDPath.TabIndex = 1
        '
        'btnUploadValidID
        '
        Me.btnUploadValidID.Location = New System.Drawing.Point(11, 20)
        Me.btnUploadValidID.Name = "btnUploadValidID"
        Me.btnUploadValidID.Size = New System.Drawing.Size(126, 38)
        Me.btnUploadValidID.TabIndex = 0
        Me.btnUploadValidID.Text = "Upload"
        Me.btnUploadValidID.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.txtFuneralContractPath)
        Me.GroupBox5.Controls.Add(Me.btnUploadFuneralContract)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 308)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(317, 66)
        Me.GroupBox5.TabIndex = 32
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Funeral Contract:"
        '
        'txtFuneralContractPath
        '
        Me.txtFuneralContractPath.Location = New System.Drawing.Point(143, 29)
        Me.txtFuneralContractPath.Name = "txtFuneralContractPath"
        Me.txtFuneralContractPath.ReadOnly = True
        Me.txtFuneralContractPath.Size = New System.Drawing.Size(164, 21)
        Me.txtFuneralContractPath.TabIndex = 1
        '
        'btnUploadFuneralContract
        '
        Me.btnUploadFuneralContract.Location = New System.Drawing.Point(11, 20)
        Me.btnUploadFuneralContract.Name = "btnUploadFuneralContract"
        Me.btnUploadFuneralContract.Size = New System.Drawing.Size(126, 38)
        Me.btnUploadFuneralContract.TabIndex = 0
        Me.btnUploadFuneralContract.Text = "Upload"
        Me.btnUploadFuneralContract.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.txtIndigencyCertPath)
        Me.GroupBox6.Controls.Add(Me.btnUploadIndigencyCert)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox6.Location = New System.Drawing.Point(9, 236)
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
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.GroupBox2)
        Me.GroupBox7.Controls.Add(Me.GroupBox6)
        Me.GroupBox7.Controls.Add(Me.GroupBox3)
        Me.GroupBox7.Controls.Add(Me.GroupBox5)
        Me.GroupBox7.Controls.Add(Me.GroupBox4)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox7.Location = New System.Drawing.Point(510, 12)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(345, 387)
        Me.GroupBox7.TabIndex = 29
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Upload the following documents:"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSubmit.Location = New System.Drawing.Point(323, 187)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(181, 39)
        Me.btnSubmit.TabIndex = 2
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
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.lblProgress)
        Me.GroupBox8.Controls.Add(Me.progressBarUpload)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox8.Location = New System.Drawing.Point(15, 179)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(302, 45)
        Me.GroupBox8.TabIndex = 31
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Progress:"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 15)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Relationship with the deceased:"
        '
        'txtRelationToDeceased
        '
        Me.txtRelationToDeceased.Location = New System.Drawing.Point(224, 118)
        Me.txtRelationToDeceased.Name = "txtRelationToDeceased"
        Me.txtRelationToDeceased.Size = New System.Drawing.Size(193, 21)
        Me.txtRelationToDeceased.TabIndex = 30
        '
        'BurialRequirementsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(865, 407)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "BurialRequirementsForm"
        Me.ShowIcon = False
        Me.Text = "BURIAL ASSISTANCE REQUIREMENTS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDeceasedMiddleName As TextBox
    Friend WithEvents txtDeceasedFirstName As TextBox
    Friend WithEvents txtDeceasedLastName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDateOfDeath As DateTimePicker
    Friend WithEvents dtpDateOfBirth As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnUploadDeathCert As Button
    Friend WithEvents txtDeathCertPath As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtBarangayCertPath As TextBox
    Friend WithEvents btnUploadBarangayCert As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtValidIDPath As TextBox
    Friend WithEvents btnUploadValidID As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtFuneralContractPath As TextBox
    Friend WithEvents btnUploadFuneralContract As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtIndigencyCertPath As TextBox
    Friend WithEvents btnUploadIndigencyCert As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents progressBarUpload As ProgressBar
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents lblProgress As Label
    Friend WithEvents txtRelationToDeceased As TextBox
    Friend WithEvents Label2 As Label
End Class
