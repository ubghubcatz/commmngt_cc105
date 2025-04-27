<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AssistanceForm
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
        Me.cmbAssistanceType = New System.Windows.Forms.ComboBox()
        Me.btnRegisterAssistance = New System.Windows.Forms.Button()
        Me.btnRemoveAssistance = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnApproveAssistance = New System.Windows.Forms.Button()
        Me.lvAssistanceRequests = New System.Windows.Forms.ListView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtResidentMiddleInitial = New System.Windows.Forms.TextBox()
        Me.txtResidentFirstName = New System.Windows.Forms.TextBox()
        Me.txtResidentLastName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnViewRequirements = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbAssistanceType
        '
        Me.cmbAssistanceType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmbAssistanceType.FormattingEnabled = True
        Me.cmbAssistanceType.Items.AddRange(New Object() {"Burial Assistance", "Educational Assistance", "Medical Assistance", "Livelihood Assistance", "Calamity Assistance", "TUPAD Assistance"})
        Me.cmbAssistanceType.Location = New System.Drawing.Point(6, 23)
        Me.cmbAssistanceType.Name = "cmbAssistanceType"
        Me.cmbAssistanceType.Size = New System.Drawing.Size(198, 23)
        Me.cmbAssistanceType.TabIndex = 0
        '
        'btnRegisterAssistance
        '
        Me.btnRegisterAssistance.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRegisterAssistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegisterAssistance.Location = New System.Drawing.Point(357, 15)
        Me.btnRegisterAssistance.Name = "btnRegisterAssistance"
        Me.btnRegisterAssistance.Size = New System.Drawing.Size(144, 43)
        Me.btnRegisterAssistance.TabIndex = 8
        Me.btnRegisterAssistance.Text = "Register Assistance"
        Me.btnRegisterAssistance.UseVisualStyleBackColor = False
        '
        'btnRemoveAssistance
        '
        Me.btnRemoveAssistance.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveAssistance.BackColor = System.Drawing.Color.Red
        Me.btnRemoveAssistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRemoveAssistance.Location = New System.Drawing.Point(237, 233)
        Me.btnRemoveAssistance.Name = "btnRemoveAssistance"
        Me.btnRemoveAssistance.Size = New System.Drawing.Size(224, 43)
        Me.btnRemoveAssistance.TabIndex = 10
        Me.btnRemoveAssistance.Text = "Remove Request"
        Me.btnRemoveAssistance.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnApproveAssistance)
        Me.GroupBox1.Controls.Add(Me.lvAssistanceRequests)
        Me.GroupBox1.Controls.Add(Me.btnRemoveAssistance)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(518, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(467, 282)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registered Assistance Requests:"
        '
        'btnApproveAssistance
        '
        Me.btnApproveAssistance.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApproveAssistance.BackColor = System.Drawing.Color.LimeGreen
        Me.btnApproveAssistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnApproveAssistance.Location = New System.Drawing.Point(7, 233)
        Me.btnApproveAssistance.Name = "btnApproveAssistance"
        Me.btnApproveAssistance.Size = New System.Drawing.Size(224, 43)
        Me.btnApproveAssistance.TabIndex = 15
        Me.btnApproveAssistance.Text = "Approve Request"
        Me.btnApproveAssistance.UseVisualStyleBackColor = False
        '
        'lvAssistanceRequests
        '
        Me.lvAssistanceRequests.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvAssistanceRequests.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lvAssistanceRequests.HideSelection = False
        Me.lvAssistanceRequests.Location = New System.Drawing.Point(6, 20)
        Me.lvAssistanceRequests.Name = "lvAssistanceRequests"
        Me.lvAssistanceRequests.Size = New System.Drawing.Size(457, 207)
        Me.lvAssistanceRequests.TabIndex = 2
        Me.lvAssistanceRequests.UseCompatibleStateImageBehavior = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtResidentMiddleInitial)
        Me.GroupBox2.Controls.Add(Me.txtResidentFirstName)
        Me.GroupBox2.Controls.Add(Me.txtResidentLastName)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(507, 105)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resident Information:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(328, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 15)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Midde Initial:"
        '
        'txtResidentMiddleInitial
        '
        Me.txtResidentMiddleInitial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtResidentMiddleInitial.Location = New System.Drawing.Point(331, 72)
        Me.txtResidentMiddleInitial.Name = "txtResidentMiddleInitial"
        Me.txtResidentMiddleInitial.Size = New System.Drawing.Size(153, 21)
        Me.txtResidentMiddleInitial.TabIndex = 16
        '
        'txtResidentFirstName
        '
        Me.txtResidentFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtResidentFirstName.Location = New System.Drawing.Point(172, 72)
        Me.txtResidentFirstName.Name = "txtResidentFirstName"
        Me.txtResidentFirstName.Size = New System.Drawing.Size(153, 21)
        Me.txtResidentFirstName.TabIndex = 15
        '
        'txtResidentLastName
        '
        Me.txtResidentLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtResidentLastName.Location = New System.Drawing.Point(13, 72)
        Me.txtResidentLastName.Name = "txtResidentLastName"
        Me.txtResidentLastName.Size = New System.Drawing.Size(153, 21)
        Me.txtResidentLastName.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(169, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "First Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(10, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Last Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(10, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Enter Full Name:"
        '
        'btnViewRequirements
        '
        Me.btnViewRequirements.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnViewRequirements.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewRequirements.Location = New System.Drawing.Point(210, 15)
        Me.btnViewRequirements.Name = "btnViewRequirements"
        Me.btnViewRequirements.Size = New System.Drawing.Size(141, 43)
        Me.btnViewRequirements.TabIndex = 14
        Me.btnViewRequirements.Text = "View Requirements"
        Me.btnViewRequirements.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbAssistanceType)
        Me.GroupBox3.Controls.Add(Me.btnViewRequirements)
        Me.GroupBox3.Controls.Add(Me.btnRegisterAssistance)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(2, 114)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(507, 64)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Choose Assistance Type:"
        '
        'AssistanceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(992, 382)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "AssistanceForm"
        Me.ShowIcon = False
        Me.Text = "ASSISTANCE REGISTRATION"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbAssistanceType As ComboBox
    Friend WithEvents btnRegisterAssistance As Button
    Friend WithEvents btnRemoveAssistance As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lvAssistanceRequests As ListView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtResidentMiddleInitial As TextBox
    Friend WithEvents txtResidentFirstName As TextBox
    Friend WithEvents txtResidentLastName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnViewRequirements As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnApproveAssistance As Button
End Class
