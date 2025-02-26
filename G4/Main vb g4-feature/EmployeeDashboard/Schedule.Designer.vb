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
        CType(DataGridViewShifts, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label1.Location = New Point(233, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(298, 35)
        Label1.TabIndex = 1
        Label1.Text = "Shift Scheduling System"
        ' 
        ' DataGridViewShifts
        ' 
        DataGridViewShifts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewShifts.Location = New Point(37, 128)
        DataGridViewShifts.Name = "DataGridViewShifts"
        DataGridViewShifts.RowHeadersWidth = 51
        DataGridViewShifts.Size = New Size(728, 314)
        DataGridViewShifts.TabIndex = 2
        ' 
        ' cboFilter
        ' 
        cboFilter.FormattingEnabled = True
        cboFilter.Location = New Point(614, 94)
        cboFilter.Name = "cboFilter"
        cboFilter.Size = New Size(151, 28)
        cboFilter.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(466, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 25)
        Label2.TabIndex = 4
        Label2.Text = "Filter by Position:"
        ' 
        ' btnGenerateShifts
        ' 
        btnGenerateShifts.BackColor = Color.Blue
        btnGenerateShifts.FlatAppearance.BorderSize = 0
        btnGenerateShifts.FlatStyle = FlatStyle.Flat
        btnGenerateShifts.ForeColor = Color.White
        btnGenerateShifts.Location = New Point(37, 448)
        btnGenerateShifts.Name = "btnGenerateShifts"
        btnGenerateShifts.Size = New Size(136, 43)
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
        btnResetShifts.Location = New Point(179, 448)
        btnResetShifts.Name = "btnResetShifts"
        btnResetShifts.Size = New Size(136, 43)
        btnResetShifts.TabIndex = 7
        btnResetShifts.Text = "Reset"
        btnResetShifts.UseVisualStyleBackColor = False
        ' 
        ' Schedule
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(212), CByte(238), CByte(226))
        ClientSize = New Size(829, 522)
        Controls.Add(btnResetShifts)
        Controls.Add(btnGenerateShifts)
        Controls.Add(Label2)
        Controls.Add(cboFilter)
        Controls.Add(DataGridViewShifts)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
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
End Class
