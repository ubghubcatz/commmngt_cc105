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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Schedule))
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
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(257, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(298, 35)
        Label1.TabIndex = 1
        Label1.Text = "Shift Scheduling System"
        ' 
        ' DataGridViewShifts
        ' 
        DataGridViewShifts.BackgroundColor = Color.White
        DataGridViewShifts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewShifts.Location = New Point(51, 121)
        DataGridViewShifts.Name = "DataGridViewShifts"
        DataGridViewShifts.RowHeadersWidth = 51
        DataGridViewShifts.Size = New Size(728, 315)
        DataGridViewShifts.TabIndex = 2
        ' 
        ' cboFilter
        ' 
        cboFilter.FormattingEnabled = True
        cboFilter.Location = New Point(534, 85)
        cboFilter.Name = "cboFilter"
        cboFilter.Size = New Size(162, 28)
        cboFilter.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Variable Display Semib", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(387, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 25)
        Label2.TabIndex = 4
        Label2.Text = "Filter by Position:"
        ' 
        ' btnGenerateShifts
        ' 
        btnGenerateShifts.BackColor = Color.FromArgb(CByte(52), CByte(205), CByte(28))
        btnGenerateShifts.FlatAppearance.BorderSize = 0
        btnGenerateShifts.FlatStyle = FlatStyle.Popup
        btnGenerateShifts.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnGenerateShifts.ForeColor = Color.White
        btnGenerateShifts.Location = New Point(51, 442)
        btnGenerateShifts.Name = "btnGenerateShifts"
        btnGenerateShifts.Size = New Size(136, 43)
        btnGenerateShifts.TabIndex = 6
        btnGenerateShifts.Text = "Generate Shift"
        btnGenerateShifts.UseVisualStyleBackColor = False
        ' 
        ' btnResetShifts
        ' 
        btnResetShifts.BackColor = Color.FromArgb(CByte(52), CByte(205), CByte(28))
        btnResetShifts.FlatAppearance.BorderSize = 0
        btnResetShifts.FlatStyle = FlatStyle.Popup
        btnResetShifts.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnResetShifts.ForeColor = Color.White
        btnResetShifts.Location = New Point(193, 442)
        btnResetShifts.Name = "btnResetShifts"
        btnResetShifts.Size = New Size(136, 43)
        btnResetShifts.TabIndex = 7
        btnResetShifts.Text = "Reset"
        btnResetShifts.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(52), CByte(205), CByte(28))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(702, 84)
        Button1.Name = "Button1"
        Button1.Size = New Size(77, 31)
        Button1.TabIndex = 8
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Schedule
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(24), CByte(106), CByte(59))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(829, 523)
        Controls.Add(Button1)
        Controls.Add(btnResetShifts)
        Controls.Add(btnGenerateShifts)
        Controls.Add(Label2)
        Controls.Add(cboFilter)
        Controls.Add(DataGridViewShifts)
        Controls.Add(Label1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Schedule"
        StartPosition = FormStartPosition.CenterScreen
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
