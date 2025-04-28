<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ApprovedSeminarsForm
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
        Me.lvApprovedSeminars = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'lvApprovedSeminars
        '
        Me.lvApprovedSeminars.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvApprovedSeminars.HideSelection = False
        Me.lvApprovedSeminars.Location = New System.Drawing.Point(12, 12)
        Me.lvApprovedSeminars.Name = "lvApprovedSeminars"
        Me.lvApprovedSeminars.Size = New System.Drawing.Size(576, 329)
        Me.lvApprovedSeminars.TabIndex = 0
        Me.lvApprovedSeminars.UseCompatibleStateImageBehavior = False
        '
        'ApprovedSeminarsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(600, 355)
        Me.Controls.Add(Me.lvApprovedSeminars)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ApprovedSeminarsForm"
        Me.Text = "APPROVED SEMINARS"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvApprovedSeminars As ListView
End Class
