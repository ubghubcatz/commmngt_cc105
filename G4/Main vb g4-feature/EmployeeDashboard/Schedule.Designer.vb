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
        Shift = New TabControl()
        Weekly = New TabPage()
        WeeklyShift = New DataGridView()
        Monthly = New TabPage()
        MonthlyShift = New DataGridView()
        Shift.SuspendLayout()
        Weekly.SuspendLayout()
        CType(WeeklyShift, ComponentModel.ISupportInitialize).BeginInit()
        Monthly.SuspendLayout()
        CType(MonthlyShift, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label1.Location = New Point(304, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 35)
        Label1.TabIndex = 1
        Label1.Text = "Shift Schedule"
        ' 
        ' Shift
        ' 
        Shift.Controls.Add(Weekly)
        Shift.Controls.Add(Monthly)
        Shift.Location = New Point(62, 107)
        Shift.Name = "Shift"
        Shift.SelectedIndex = 0
        Shift.Size = New Size(663, 309)
        Shift.TabIndex = 2
        ' 
        ' Weekly
        ' 
        Weekly.BackColor = Color.Transparent
        Weekly.Controls.Add(WeeklyShift)
        Weekly.Location = New Point(4, 29)
        Weekly.Name = "Weekly"
        Weekly.Padding = New Padding(3)
        Weekly.Size = New Size(655, 276)
        Weekly.TabIndex = 0
        Weekly.Text = "Weekly"
        ' 
        ' WeeklyShift
        ' 
        WeeklyShift.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        WeeklyShift.Location = New Point(15, 22)
        WeeklyShift.Name = "WeeklyShift"
        WeeklyShift.RowHeadersWidth = 51
        WeeklyShift.Size = New Size(621, 236)
        WeeklyShift.TabIndex = 0
        ' 
        ' Monthly
        ' 
        Monthly.BackColor = Color.Transparent
        Monthly.Controls.Add(MonthlyShift)
        Monthly.Location = New Point(4, 29)
        Monthly.Name = "Monthly"
        Monthly.Padding = New Padding(3)
        Monthly.Size = New Size(655, 276)
        Monthly.TabIndex = 1
        Monthly.Text = "Monthly"
        ' 
        ' MonthlyShift
        ' 
        MonthlyShift.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        MonthlyShift.Location = New Point(17, 20)
        MonthlyShift.Name = "MonthlyShift"
        MonthlyShift.RowHeadersWidth = 51
        MonthlyShift.Size = New Size(621, 236)
        MonthlyShift.TabIndex = 1
        ' 
        ' Schedule
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(212), CByte(238), CByte(226))
        ClientSize = New Size(800, 450)
        Controls.Add(Shift)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Schedule"
        Text = "Schedule"
        Shift.ResumeLayout(False)
        Weekly.ResumeLayout(False)
        CType(WeeklyShift, ComponentModel.ISupportInitialize).EndInit()
        Monthly.ResumeLayout(False)
        CType(MonthlyShift, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Shift As TabControl
    Friend WithEvents Weekly As TabPage
    Friend WithEvents Monthly As TabPage
    Friend WithEvents WeeklyShift As DataGridView
    Friend WithEvents MonthlyShift As DataGridView
End Class
