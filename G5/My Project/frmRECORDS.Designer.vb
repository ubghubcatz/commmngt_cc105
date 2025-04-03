<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRECORDS
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
        Panel1 = New Panel()
        btnCLOSE = New Button()
        Label1 = New Label()
        txtRecords = New TextBox()
        dgvRecords = New DataGridView()
        Panel1.SuspendLayout()
        CType(dgvRecords, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(60))
        Panel1.Controls.Add(btnCLOSE)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(700, 49)
        Panel1.TabIndex = 2
        ' 
        ' btnCLOSE
        ' 
        btnCLOSE.BackColor = Color.Gray
        btnCLOSE.FlatStyle = FlatStyle.Flat
        btnCLOSE.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCLOSE.Location = New Point(600, 4)
        btnCLOSE.Margin = New Padding(3, 2, 3, 2)
        btnCLOSE.Name = "btnCLOSE"
        btnCLOSE.Size = New Size(97, 40)
        btnCLOSE.TabIndex = 3
        btnCLOSE.Text = "CLOSE"
        btnCLOSE.TextImageRelation = TextImageRelation.ImageAboveText
        btnCLOSE.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(10, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(197, 19)
        Label1.TabIndex = 0
        Label1.Text = "BRGY. INOSLUBAN LIPA CITY"
        ' 
        ' txtRecords
        ' 
        txtRecords.Dock = DockStyle.Fill
        txtRecords.Location = New Point(0, 49)
        txtRecords.Margin = New Padding(3, 2, 3, 2)
        txtRecords.Multiline = True
        txtRecords.Name = "txtRecords"
        txtRecords.ReadOnly = True
        txtRecords.ScrollBars = ScrollBars.Vertical
        txtRecords.Size = New Size(700, 289)
        txtRecords.TabIndex = 3
        ' 
        ' dgvRecords
        ' 
        dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecords.Location = New Point(28, 68)
        dgvRecords.Name = "dgvRecords"
        dgvRecords.Size = New Size(624, 235)
        dgvRecords.TabIndex = 4
        ' 
        ' frmRECORDS
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 338)
        ControlBox = False
        Controls.Add(dgvRecords)
        Controls.Add(txtRecords)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmRECORDS"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvRecords, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCLOSE As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRecords As TextBox
    Friend WithEvents dgvRecords As DataGridView
End Class
