<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DonationForm
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
        Me.rdoCashDropOff = New System.Windows.Forms.RadioButton()
        Me.rdoGCash = New System.Windows.Forms.RadioButton()
        Me.txtGCashNumber = New System.Windows.Forms.TextBox()
        Me.btnProcessDonation = New System.Windows.Forms.Button()
        Me.lvDonations = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRemoveDonation = New System.Windows.Forms.Button()
        Me.btnApproveDonation = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtResidentMiddleInitial = New System.Windows.Forms.TextBox()
        Me.txtResidentFirstName = New System.Windows.Forms.TextBox()
        Me.txtResidentLastName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cmbDonationType = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoCashDropOff
        '
        Me.rdoCashDropOff.AutoSize = True
        Me.rdoCashDropOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rdoCashDropOff.Location = New System.Drawing.Point(9, 20)
        Me.rdoCashDropOff.Name = "rdoCashDropOff"
        Me.rdoCashDropOff.Size = New System.Drawing.Size(223, 19)
        Me.rdoCashDropOff.TabIndex = 1
        Me.rdoCashDropOff.TabStop = True
        Me.rdoCashDropOff.Text = "Cash Drop-off at Barangay Hall"
        Me.rdoCashDropOff.UseVisualStyleBackColor = True
        '
        'rdoGCash
        '
        Me.rdoGCash.AutoSize = True
        Me.rdoGCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rdoGCash.Location = New System.Drawing.Point(9, 44)
        Me.rdoGCash.Name = "rdoGCash"
        Me.rdoGCash.Size = New System.Drawing.Size(124, 19)
        Me.rdoGCash.TabIndex = 2
        Me.rdoGCash.TabStop = True
        Me.rdoGCash.Text = "GCash Transfer"
        Me.rdoGCash.UseVisualStyleBackColor = True
        '
        'txtGCashNumber
        '
        Me.txtGCashNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtGCashNumber.Location = New System.Drawing.Point(139, 42)
        Me.txtGCashNumber.Name = "txtGCashNumber"
        Me.txtGCashNumber.Size = New System.Drawing.Size(171, 21)
        Me.txtGCashNumber.TabIndex = 3
        Me.txtGCashNumber.Text = "GCash No."
        '
        'btnProcessDonation
        '
        Me.btnProcessDonation.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnProcessDonation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnProcessDonation.Location = New System.Drawing.Point(273, 171)
        Me.btnProcessDonation.Name = "btnProcessDonation"
        Me.btnProcessDonation.Size = New System.Drawing.Size(256, 43)
        Me.btnProcessDonation.TabIndex = 9
        Me.btnProcessDonation.Text = "Process Donation"
        Me.btnProcessDonation.UseVisualStyleBackColor = False
        '
        'lvDonations
        '
        Me.lvDonations.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvDonations.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lvDonations.HideSelection = False
        Me.lvDonations.Location = New System.Drawing.Point(6, 16)
        Me.lvDonations.Name = "lvDonations"
        Me.lvDonations.Size = New System.Drawing.Size(435, 258)
        Me.lvDonations.TabIndex = 11
        Me.lvDonations.UseCompatibleStateImageBehavior = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRemoveDonation)
        Me.GroupBox1.Controls.Add(Me.lvDonations)
        Me.GroupBox1.Controls.Add(Me.btnApproveDonation)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(535, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 329)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pending Donation Requests:"
        '
        'btnRemoveDonation
        '
        Me.btnRemoveDonation.BackColor = System.Drawing.Color.Red
        Me.btnRemoveDonation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRemoveDonation.Location = New System.Drawing.Point(226, 280)
        Me.btnRemoveDonation.Name = "btnRemoveDonation"
        Me.btnRemoveDonation.Size = New System.Drawing.Size(215, 43)
        Me.btnRemoveDonation.TabIndex = 20
        Me.btnRemoveDonation.Text = "Remove Donation"
        Me.btnRemoveDonation.UseVisualStyleBackColor = False
        '
        'btnApproveDonation
        '
        Me.btnApproveDonation.BackColor = System.Drawing.Color.LimeGreen
        Me.btnApproveDonation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnApproveDonation.Location = New System.Drawing.Point(6, 280)
        Me.btnApproveDonation.Name = "btnApproveDonation"
        Me.btnApproveDonation.Size = New System.Drawing.Size(214, 43)
        Me.btnApproveDonation.TabIndex = 19
        Me.btnApproveDonation.Text = "Approve Donation"
        Me.btnApproveDonation.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtResidentMiddleInitial)
        Me.GroupBox2.Controls.Add(Me.txtResidentFirstName)
        Me.GroupBox2.Controls.Add(Me.txtResidentLastName)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(526, 76)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Enter Resident Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(327, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 15)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Midde Initial:"
        '
        'txtResidentMiddleInitial
        '
        Me.txtResidentMiddleInitial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtResidentMiddleInitial.Location = New System.Drawing.Point(330, 44)
        Me.txtResidentMiddleInitial.Name = "txtResidentMiddleInitial"
        Me.txtResidentMiddleInitial.Size = New System.Drawing.Size(88, 21)
        Me.txtResidentMiddleInitial.TabIndex = 16
        '
        'txtResidentFirstName
        '
        Me.txtResidentFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtResidentFirstName.Location = New System.Drawing.Point(171, 44)
        Me.txtResidentFirstName.Name = "txtResidentFirstName"
        Me.txtResidentFirstName.Size = New System.Drawing.Size(153, 21)
        Me.txtResidentFirstName.TabIndex = 15
        '
        'txtResidentLastName
        '
        Me.txtResidentLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtResidentLastName.Location = New System.Drawing.Point(12, 44)
        Me.txtResidentLastName.Name = "txtResidentLastName"
        Me.txtResidentLastName.Size = New System.Drawing.Size(153, 21)
        Me.txtResidentLastName.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(168, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "First Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(9, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Last Name:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtAmount)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.Location = New System.Drawing.Point(316, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(202, 50)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Amount to Donate:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "₱"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtAmount.Location = New System.Drawing.Point(33, 29)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(159, 21)
        Me.txtAmount.TabIndex = 18
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rdoCashDropOff)
        Me.GroupBox5.Controls.Add(Me.rdoGCash)
        Me.GroupBox5.Controls.Add(Me.txtGCashNumber)
        Me.GroupBox5.Controls.Add(Me.GroupBox4)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 84)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(526, 69)
        Me.GroupBox5.TabIndex = 18
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Payment Method for Donation:"
        '
        'cmbDonationType
        '
        Me.cmbDonationType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmbDonationType.FormattingEnabled = True
        Me.cmbDonationType.Items.AddRange(New Object() {"Financial Aid", "Medical Support Donation", "Educational Donation", "Disaster Relief Donation", "Community Project Support", "Feeding Program Donation"})
        Me.cmbDonationType.Location = New System.Drawing.Point(6, 23)
        Me.cmbDonationType.Name = "cmbDonationType"
        Me.cmbDonationType.Size = New System.Drawing.Size(252, 23)
        Me.cmbDonationType.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbDonationType)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 159)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(264, 64)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Choose Donation Type:"
        '
        'DonationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(985, 336)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnProcessDonation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DonationForm"
        Me.ShowIcon = False
        Me.Text = "DONATION FORM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rdoCashDropOff As RadioButton
    Friend WithEvents rdoGCash As RadioButton
    Friend WithEvents txtGCashNumber As TextBox
    Friend WithEvents btnProcessDonation As Button
    Friend WithEvents lvDonations As ListView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtResidentMiddleInitial As TextBox
    Friend WithEvents txtResidentFirstName As TextBox
    Friend WithEvents txtResidentLastName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnApproveDonation As Button
    Friend WithEvents cmbDonationType As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnRemoveDonation As Button
End Class
