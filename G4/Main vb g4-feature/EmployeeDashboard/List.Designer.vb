<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class List
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
        btnviewID = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnviewID
        ' 
        btnviewID.BackColor = Color.Blue
        btnviewID.FlatAppearance.BorderSize = 0
        btnviewID.FlatStyle = FlatStyle.Flat
        btnviewID.Font = New Font("Segoe UI", 11F)
        btnviewID.ForeColor = Color.White
        btnviewID.Location = New Point(614, 362)
        btnviewID.Name = "btnviewID"
        btnviewID.Size = New Size(124, 56)
        btnviewID.TabIndex = 9
        btnviewID.Text = "View ID"
        btnviewID.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(60, 57)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(678, 274)
        DataGridView1.TabIndex = 10
        ' 
        ' List
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(212), CByte(238), CByte(226))
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(btnviewID)
        FormBorderStyle = FormBorderStyle.None
        Name = "List"
        Text = "List"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnviewID As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
