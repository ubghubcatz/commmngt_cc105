<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        btnOK = New Button()
        TextBox1 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(53, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' btnOK
        ' 
        btnOK.Location = New Point(81, 128)
        btnOK.Name = "btnOK"
        btnOK.Size = New Size(75, 23)
        btnOK.TabIndex = 1
        btnOK.Text = "&Ok"
        btnOK.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(137, 48)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.ControlDark
        Label2.Location = New Point(72, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 15)
        Label2.TabIndex = 3
        Label2.Text = "Enter username and password"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(137, 77)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(56, 85)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 4
        Label3.Text = "Password"
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(162, 128)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 6
        btnCancel.Text = "&Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(284, 193)
        Controls.Add(btnCancel)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(btnOK)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCancel As Button

End Class
