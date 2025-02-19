<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class List
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        btnviewID = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(284, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(221, 35)
        Label1.TabIndex = 0
        Label1.Text = "List of Employees"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(93, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 23)
        Label2.TabIndex = 1
        Label2.Text = "Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(93, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(152, 23)
        Label3.TabIndex = 2
        Label3.Text = "1. RAUL J. VARGAS"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(316, 108)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 23)
        Label4.TabIndex = 3
        Label4.Text = "Position:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(93, 190)
        Label5.Name = "Label5"
        Label5.Size = New Size(177, 23)
        Label5.TabIndex = 4
        Label5.Text = "2. JUAN D. MARTINEZ"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(93, 220)
        Label7.Name = "Label7"
        Label7.Size = New Size(141, 23)
        Label7.TabIndex = 5
        Label7.Text = "3. ANA I. TORRES"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F)
        Label6.ForeColor = Color.Cyan
        Label6.Location = New Point(316, 160)
        Label6.Name = "Label6"
        Label6.Size = New Size(200, 23)
        Label6.TabIndex = 6
        Label6.Text = "YOUTH REPRESENTATIVE"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10F)
        Label8.ForeColor = Color.Cyan
        Label8.Location = New Point(316, 190)
        Label8.Name = "Label8"
        Label8.Size = New Size(96, 23)
        Label8.TabIndex = 7
        Label8.Text = "SECRETARY"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10F)
        Label9.ForeColor = Color.Cyan
        Label9.Location = New Point(316, 220)
        Label9.Name = "Label9"
        Label9.Size = New Size(225, 23)
        Label9.TabIndex = 8
        Label9.Text = "WOMEN'S REPRESENTATIVE"
        ' 
        ' btnviewID
        ' 
        btnviewID.BackColor = Color.Blue
        btnviewID.FlatAppearance.BorderSize = 0
        btnviewID.FlatStyle = FlatStyle.Flat
        btnviewID.Font = New Font("Segoe UI", 11F)
        btnviewID.ForeColor = Color.White
        btnviewID.Location = New Point(614, 362)
        btnviewID.Name = "btnviewID"
        btnviewID.Size = New Size(124, 56)
        btnviewID.TabIndex = 9
        btnviewID.Text = "View ID"
        btnviewID.UseVisualStyleBackColor = False
        ' 
        ' List
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(14), CByte(21), CByte(58))
        ClientSize = New Size(800, 450)
        Controls.Add(btnviewID)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "List"
        Text = "List"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnviewID As Button
End Class
