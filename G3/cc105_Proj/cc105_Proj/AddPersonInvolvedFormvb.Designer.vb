<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPersonInvolvedFormvb
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
        Name_TxtBox = New TextBox()
        num = New TextBox()
        Button1 = New Button()
        ComboBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Green
        Label1.Location = New Point(31, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 31)
        Label1.TabIndex = 0
        Label1.Text = "Person Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Green
        Label2.Location = New Point(9, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(183, 31)
        Label2.TabIndex = 1
        Label2.Text = "Phone Number:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Green
        Label3.Location = New Point(44, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 31)
        Label3.TabIndex = 2
        Label3.Text = "Person Type:"
        ' 
        ' Name_TxtBox
        ' 
        Name_TxtBox.BorderStyle = BorderStyle.FixedSingle
        Name_TxtBox.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Name_TxtBox.Location = New Point(198, 24)
        Name_TxtBox.Name = "Name_TxtBox"
        Name_TxtBox.Size = New Size(253, 38)
        Name_TxtBox.TabIndex = 3
        ' 
        ' num
        ' 
        num.BorderStyle = BorderStyle.FixedSingle
        num.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        num.Location = New Point(198, 68)
        num.Name = "num"
        num.Size = New Size(253, 38)
        num.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Green
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(348, 154)
        Button1.Name = "Button1"
        Button1.Size = New Size(102, 42)
        Button1.TabIndex = 6
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Main Suspect", "Potential Suspect", "Victim", "Witness", "Victim Relative"})
        ComboBox1.Location = New Point(198, 112)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(253, 36)
        ComboBox1.TabIndex = 7
        ' 
        ' AddPersonInvolvedFormvb
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        ClientSize = New Size(462, 205)
        Controls.Add(ComboBox1)
        Controls.Add(Button1)
        Controls.Add(num)
        Controls.Add(Name_TxtBox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "AddPersonInvolvedFormvb"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Name_TxtBox As TextBox
    Friend WithEvents num As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
