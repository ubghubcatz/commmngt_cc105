<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddOfficersForm
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
        OfficialsResultsListBox = New ListBox()
        Label1 = New Label()
        Officer_TextBox = New TextBox()
        ConfirmOfficer_Btn = New Button()
        Panel1 = New Panel()
        officerId_Label = New Label()
        SuspendLayout()
        ' 
        ' OfficialsResultsListBox
        ' 
        OfficialsResultsListBox.FormattingEnabled = True
        OfficialsResultsListBox.Location = New Point(101, 70)
        OfficialsResultsListBox.Name = "OfficialsResultsListBox"
        OfficialsResultsListBox.Size = New Size(354, 104)
        OfficialsResultsListBox.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Green
        Label1.Location = New Point(7, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 31)
        Label1.TabIndex = 10
        Label1.Text = "Officer"
        ' 
        ' Officer_TextBox
        ' 
        Officer_TextBox.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Officer_TextBox.Location = New Point(101, 40)
        Officer_TextBox.Name = "Officer_TextBox"
        Officer_TextBox.Size = New Size(354, 30)
        Officer_TextBox.TabIndex = 8
        ' 
        ' ConfirmOfficer_Btn
        ' 
        ConfirmOfficer_Btn.BackColor = Color.Green
        ConfirmOfficer_Btn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ConfirmOfficer_Btn.ForeColor = Color.White
        ConfirmOfficer_Btn.Location = New Point(304, 180)
        ConfirmOfficer_Btn.Name = "ConfirmOfficer_Btn"
        ConfirmOfficer_Btn.Size = New Size(151, 54)
        ConfirmOfficer_Btn.TabIndex = 6
        ConfirmOfficer_Btn.Text = "Add Officer"
        ConfirmOfficer_Btn.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Green
        Panel1.Location = New Point(461, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(79, 298)
        Panel1.TabIndex = 7
        ' 
        ' officerId_Label
        ' 
        officerId_Label.AutoSize = True
        officerId_Label.ForeColor = Color.Honeydew
        officerId_Label.Location = New Point(12, 179)
        officerId_Label.Name = "officerId_Label"
        officerId_Label.Size = New Size(0, 20)
        officerId_Label.TabIndex = 13
        ' 
        ' AddOfficersForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        ClientSize = New Size(539, 249)
        Controls.Add(officerId_Label)
        Controls.Add(OfficialsResultsListBox)
        Controls.Add(Label1)
        Controls.Add(Officer_TextBox)
        Controls.Add(ConfirmOfficer_Btn)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "AddOfficersForm"
        Text = "Add Officer"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents OfficialsResultsListBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Officer_TextBox As TextBox
    Friend WithEvents ConfirmOfficer_Btn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents officerId_Label As Label
End Class
