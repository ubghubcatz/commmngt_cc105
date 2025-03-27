<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Schedule
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
        DataGridViewShifts = New DataGridView()
        cboFilter = New ComboBox()
        Label2 = New Label()
        btnGenerateShifts = New Button()
        btnResetShifts = New Button()
        Button1 = New Button()
        CType(DataGridViewShifts, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label1.Location = New Point(204, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(241, 28)
        Label1.TabIndex = 1
        Label1.Text = "Shift Scheduling System"
        ' 
        ' DataGridViewShifts
        ' 
        DataGridViewShifts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewShifts.Location = New Point(32, 96)
        DataGridViewShifts.Margin = New Padding(3, 2, 3, 2)
        DataGridViewShifts.Name = "DataGridViewShifts"
        DataGridViewShifts.RowHeadersWidth = 51
        DataGridViewShifts.Size = New Size(637, 236)
        DataGridViewShifts.TabIndex = 2
        ' 
        ' cboFilter
        ' 
        cboFilter.FormattingEnabled = True
        cboFilter.Location = New Point(455, 69)
        cboFilter.Margin = New Padding(3, 2, 3, 2)
        cboFilter.Name = "cboFilter"
        cboFilter.Size = New Size(133, 23)
        cboFilter.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(326, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 19)
        Label2.TabIndex = 4
        Label2.Text = "Filter by Position:"
        ' 
        ' btnGenerateShifts
        ' 
        btnGenerateShifts.BackColor = Color.Blue
        btnGenerateShifts.FlatAppearance.BorderSize = 0
        btnGenerateShifts.FlatStyle = FlatStyle.Flat
        btnGenerateShifts.ForeColor = Color.White
        btnGenerateShifts.Location = New Point(32, 336)
        btnGenerateShifts.Margin = New Padding(3, 2, 3, 2)
        btnGenerateShifts.Name = "btnGenerateShifts"
        btnGenerateShifts.Size = New Size(119, 32)
        btnGenerateShifts.TabIndex = 6
        btnGenerateShifts.Text = "Generate Shift"
        btnGenerateShifts.UseVisualStyleBackColor = False
        ' 
        ' btnResetShifts
        ' 
        btnResetShifts.BackColor = Color.Blue
        btnResetShifts.FlatAppearance.BorderSize = 0
        btnResetShifts.FlatStyle = FlatStyle.Flat
        btnResetShifts.ForeColor = Color.White
        btnResetShifts.Location = New Point(157, 336)
        btnResetShifts.Margin = New Padding(3, 2, 3, 2)
        btnResetShifts.Name = "btnResetShifts"
        btnResetShifts.Size = New Size(119, 32)
        btnResetShifts.TabIndex = 7
        btnResetShifts.Text = "Reset"
        btnResetShifts.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Blue
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Location = New Point(602, 68)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(67, 23)
        Button1.TabIndex = 8
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Schedule
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(212), CByte(238), CByte(226))
        ClientSize = New Size(725, 392)
        Controls.Add(Button1)
        Controls.Add(btnResetShifts)
        Controls.Add(btnGenerateShifts)
        Controls.Add(Label2)
        Controls.Add(cboFilter)
        Controls.Add(DataGridViewShifts)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 2, 3, 2)
        Name = "Schedule"
        Text = "Schedule"
        CType(DataGridViewShifts, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewShifts As DataGridView
    Friend WithEvents cboFilter As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGenerateShifts As Button
    Friend WithEvents btnResetShifts As Button
    Friend WithEvents Button1 As Button
End Class
