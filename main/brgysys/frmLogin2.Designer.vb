<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin2
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
        btnCancel = New Button()
        txtPassword = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        txtUser = New TextBox()
        btnOK = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(186, 135)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 13
        btnCancel.Text = "&Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(161, 84)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(100, 23)
        txtPassword.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(80, 92)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 11
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.ControlDark
        Label2.Location = New Point(96, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 15)
        Label2.TabIndex = 10
        Label2.Text = "Enter username and password"
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(161, 55)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(100, 23)
        txtUser.TabIndex = 9
        ' 
        ' btnOK
        ' 
        btnOK.Location = New Point(105, 135)
        btnOK.Name = "btnOK"
        btnOK.Size = New Size(75, 23)
        btnOK.TabIndex = 8
        btnOK.Text = "&Ok"
        btnOK.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(77, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 7
        Label1.Text = "Username"
        ' 
        ' frmLogin2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(339, 184)
        Controls.Add(btnCancel)
        Controls.Add(txtPassword)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtUser)
        Controls.Add(btnOK)
        Controls.Add(Label1)
        Name = "frmLogin2"
        Text = "frmLogin2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents Label1 As Label
End Class
