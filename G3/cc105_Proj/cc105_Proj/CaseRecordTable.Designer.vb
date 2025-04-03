<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaseRecordTable
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
        AddCaseRecord_Btn = New Button()
        Search_Field = New TextBox()
        Search_Btn = New Button()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' AddCaseRecord_Btn
        ' 
        AddCaseRecord_Btn.BackColor = Color.DarkSeaGreen
        AddCaseRecord_Btn.FlatStyle = FlatStyle.Flat
        AddCaseRecord_Btn.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddCaseRecord_Btn.ForeColor = Color.White
        AddCaseRecord_Btn.Location = New Point(1168, 130)
        AddCaseRecord_Btn.Name = "AddCaseRecord_Btn"
        AddCaseRecord_Btn.Size = New Size(182, 56)
        AddCaseRecord_Btn.TabIndex = 6
        AddCaseRecord_Btn.Text = "ADD CASE"
        AddCaseRecord_Btn.UseVisualStyleBackColor = False
        ' 
        ' Search_Field
        ' 
        Search_Field.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        Search_Field.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Search_Field.Location = New Point(103, 130)
        Search_Field.Multiline = True
        Search_Field.Name = "Search_Field"
        Search_Field.Size = New Size(706, 56)
        Search_Field.TabIndex = 7
        ' 
        ' Search_Btn
        ' 
        Search_Btn.BackColor = Color.SeaGreen
        Search_Btn.FlatStyle = FlatStyle.Flat
        Search_Btn.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Search_Btn.ForeColor = Color.White
        Search_Btn.Location = New Point(815, 130)
        Search_Btn.Name = "Search_Btn"
        Search_Btn.RightToLeft = RightToLeft.No
        Search_Btn.Size = New Size(176, 56)
        Search_Btn.TabIndex = 5
        Search_Btn.Text = "SEARCH"
        Search_Btn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(110, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(276, 60)
        Label1.TabIndex = 8
        Label1.Text = "Case Record"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SeaGreen
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1617, 93)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = My.Resources.Resources.CaseRecord_Close
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(104, 93)
        Panel2.TabIndex = 11
        ' 
        ' CaseRecordTable
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        ClientSize = New Size(1394, 681)
        Controls.Add(AddCaseRecord_Btn)
        Controls.Add(Search_Field)
        Controls.Add(Search_Btn)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "CaseRecordTable"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents AddCaseRecord_Btn As Button
    Friend WithEvents Search_Field As TextBox
    Friend WithEvents Search_Btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
