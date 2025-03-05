<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Button1 = New Button()
        txtEng = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtSci = New TextBox()
        Label3 = New Label()
        txtMath = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(72, 118)
        Button1.Name = "Button1"
        Button1.Size = New Size(126, 23)
        Button1.TabIndex = 0
        Button1.Text = "Compute Average"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtEng
        ' 
        txtEng.Location = New Point(98, 21)
        txtEng.Name = "txtEng"
        txtEng.Size = New Size(100, 23)
        txtEng.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 2
        Label1.Text = "English"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 15)
        Label2.TabIndex = 4
        Label2.Text = "Science"
        ' 
        ' txtSci
        ' 
        txtSci.Location = New Point(98, 50)
        txtSci.Name = "txtSci"
        txtSci.Size = New Size(100, 23)
        txtSci.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 87)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 15)
        Label3.TabIndex = 6
        Label3.Text = "Math"
        ' 
        ' txtMath
        ' 
        txtMath.Location = New Point(98, 79)
        txtMath.Name = "txtMath"
        txtMath.Size = New Size(100, 23)
        txtMath.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(336, 274)
        Controls.Add(Label3)
        Controls.Add(txtMath)
        Controls.Add(Label2)
        Controls.Add(txtSci)
        Controls.Add(Label1)
        Controls.Add(txtEng)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "GRADE"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtEng As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSci As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMath As TextBox

End Class
