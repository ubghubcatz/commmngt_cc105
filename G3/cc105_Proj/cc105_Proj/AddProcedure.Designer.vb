<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProcedure
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
        AddProcedure_Btn = New Button()
        Remarks_TxtBox = New TextBox()
        Label12 = New Label()
        Label1 = New Label()
        Procedures_ComboBox = New ComboBox()
        SuspendLayout()
        ' 
        ' AddProcedure_Btn
        ' 
        AddProcedure_Btn.BackColor = Color.DarkGreen
        AddProcedure_Btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        AddProcedure_Btn.ForeColor = Color.White
        AddProcedure_Btn.Location = New Point(230, 254)
        AddProcedure_Btn.Name = "AddProcedure_Btn"
        AddProcedure_Btn.Size = New Size(110, 43)
        AddProcedure_Btn.TabIndex = 11
        AddProcedure_Btn.Text = "ADD"
        AddProcedure_Btn.UseVisualStyleBackColor = False
        ' 
        ' Remarks_TxtBox
        ' 
        Remarks_TxtBox.BorderStyle = BorderStyle.FixedSingle
        Remarks_TxtBox.Location = New Point(12, 112)
        Remarks_TxtBox.Multiline = True
        Remarks_TxtBox.Name = "Remarks_TxtBox"
        Remarks_TxtBox.Size = New Size(328, 136)
        Remarks_TxtBox.TabIndex = 34
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Green
        Label12.Location = New Point(12, 84)
        Label12.Name = "Label12"
        Label12.Size = New Size(85, 25)
        Label12.TabIndex = 33
        Label12.Text = "Remarks"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Green
        Label1.Location = New Point(12, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(154, 25)
        Label1.TabIndex = 35
        Label1.Text = "Procedure Taken"
        ' 
        ' Procedures_ComboBox
        ' 
        Procedures_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        Procedures_ComboBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Procedures_ComboBox.FormattingEnabled = True
        Procedures_ComboBox.Items.AddRange(New Object() {"Talked to witnesses", "Took victim’s statement", "", "", "Took suspect’s statement", "", "", "Secured the area", "", "", "Collected evidence", "", "", "Took photos", "", "", "Wrote a report", "", "", "Made an arrest", "", "", "Gave a warning", "", "", "Gave a ticket", "", "", "Called for backup", "", "", "Brought person to station", "", "", "Helped with medical needs", "", "", "Searched area", "", "", "Notified investigators", "Others (Please Specify)"})
        Procedures_ComboBox.Location = New Point(12, 47)
        Procedures_ComboBox.Name = "Procedures_ComboBox"
        Procedures_ComboBox.Size = New Size(332, 31)
        Procedures_ComboBox.TabIndex = 42
        ' 
        ' AddProcedure
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        ClientSize = New Size(364, 303)
        Controls.Add(Procedures_ComboBox)
        Controls.Add(Label1)
        Controls.Add(Remarks_TxtBox)
        Controls.Add(Label12)
        Controls.Add(AddProcedure_Btn)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "AddProcedure"
        Text = "AddProcedure"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AddProcedure_Btn As Button
    Friend WithEvents Remarks_TxtBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Procedures_ComboBox As ComboBox
End Class
