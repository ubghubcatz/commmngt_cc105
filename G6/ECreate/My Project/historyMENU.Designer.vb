<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class historyMENU
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
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(911, 655)
        DataGridView1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Green
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(418, 673)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 43)
        Button1.TabIndex = 81
        Button1.Text = "Refresh"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' historyMENU
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(71), CByte(184), CByte(129))
        ClientSize = New Size(935, 718)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Name = "historyMENU"
        Text = "historyMENU"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
End Class
