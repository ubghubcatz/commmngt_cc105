<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Panel1 = New Panel()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        TextBox4 = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        TextBox3 = New TextBox()
        Label6 = New Label()
        btnSUBMIT = New Button()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.YellowGreen
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 70)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(188, 21)
        Label1.TabIndex = 0
        Label1.Text = "INCIDENT REPORT FORM"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonFace
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(12, 76)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(354, 348)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = " INFORMATION"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 194)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 20)
        Label3.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(86, 137)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(249, 27)
        TextBox2.TabIndex = 6
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(86, 87)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(249, 27)
        DateTimePicker1.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(86, 45)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(249, 27)
        TextBox1.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 140)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 20)
        Label5.TabIndex = 5
        Label5.Text = "Location"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 94)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 20)
        Label4.TabIndex = 4
        Label4.Text = "Date "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 2
        Label2.Text = "Name"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ButtonFace
        GroupBox2.Controls.Add(TextBox4)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(TextBox3)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Location = New Point(401, 87)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(376, 337)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "INCIDENT DETAILS"
        ' 
        ' TextBox4
        ' 
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Location = New Point(133, 127)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(196, 142)
        TextBox4.TabIndex = 10
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(6, 129)
        Label8.Name = "Label8"
        Label8.Size = New Size(85, 20)
        Label8.TabIndex = 9
        Label8.Text = "Description"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 83)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 20)
        Label7.TabIndex = 8
        Label7.Text = "Severity Level"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(164, 41)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(196, 27)
        TextBox3.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(0, 41)
        Label6.Name = "Label6"
        Label6.Size = New Size(115, 20)
        Label6.TabIndex = 3
        Label6.Text = "Type of incident"
        ' 
        ' btnSUBMIT
        ' 
        btnSUBMIT.FlatStyle = FlatStyle.Flat
        btnSUBMIT.Font = New Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSUBMIT.Location = New Point(341, 430)
        btnSUBMIT.Name = "btnSUBMIT"
        btnSUBMIT.Size = New Size(94, 29)
        btnSUBMIT.TabIndex = 3
        btnSUBMIT.Text = "SUBMIT"
        btnSUBMIT.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 541)
        ControlBox = False
        Controls.Add(btnSUBMIT)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form3"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents btnSUBMIT As Button
End Class
