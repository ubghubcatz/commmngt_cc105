<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintOptions))
        PrintPreview_Button = New Button()
        PageSetup_Button = New Button()
        Print_Button = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDialog1 = New PrintDialog()
        PageSetupDialog1 = New PageSetupDialog()
        SuspendLayout()
        ' 
        ' PrintPreview_Button
        ' 
        PrintPreview_Button.BackColor = Color.Green
        PrintPreview_Button.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PrintPreview_Button.ForeColor = Color.White
        PrintPreview_Button.Location = New Point(12, 27)
        PrintPreview_Button.Name = "PrintPreview_Button"
        PrintPreview_Button.Size = New Size(127, 60)
        PrintPreview_Button.TabIndex = 7
        PrintPreview_Button.Text = "Print Preview"
        PrintPreview_Button.UseVisualStyleBackColor = False
        ' 
        ' PageSetup_Button
        ' 
        PageSetup_Button.BackColor = Color.Green
        PageSetup_Button.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PageSetup_Button.ForeColor = Color.White
        PageSetup_Button.Location = New Point(145, 27)
        PageSetup_Button.Name = "PageSetup_Button"
        PageSetup_Button.Size = New Size(127, 60)
        PageSetup_Button.TabIndex = 8
        PageSetup_Button.Text = "Page Setup"
        PageSetup_Button.UseVisualStyleBackColor = False
        ' 
        ' Print_Button
        ' 
        Print_Button.BackColor = Color.Green
        Print_Button.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Print_Button.ForeColor = Color.White
        Print_Button.Location = New Point(278, 27)
        Print_Button.Name = "Print_Button"
        Print_Button.Size = New Size(127, 60)
        Print_Button.TabIndex = 9
        Print_Button.Text = "Print"
        Print_Button.UseVisualStyleBackColor = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' PrintOptions
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        ClientSize = New Size(423, 100)
        Controls.Add(Print_Button)
        Controls.Add(PageSetup_Button)
        Controls.Add(PrintPreview_Button)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "PrintOptions"
        ResumeLayout(False)
    End Sub

    Friend WithEvents PrintPreview_Button As Button
    Friend WithEvents PageSetup_Button As Button
    Friend WithEvents Print_Button As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
End Class
