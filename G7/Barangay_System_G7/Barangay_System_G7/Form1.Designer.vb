<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSeminar = New System.Windows.Forms.Button()
        Me.btnAssistance = New System.Windows.Forms.Button()
        Me.btnPayout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSeminar
        '
        Me.btnSeminar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeminar.Location = New System.Drawing.Point(97, 105)
        Me.btnSeminar.Name = "btnSeminar"
        Me.btnSeminar.Size = New System.Drawing.Size(178, 57)
        Me.btnSeminar.TabIndex = 0
        Me.btnSeminar.Text = "CREATE SEMINAR"
        Me.btnSeminar.UseVisualStyleBackColor = True
        '
        'btnAssistance
        '
        Me.btnAssistance.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssistance.Location = New System.Drawing.Point(97, 184)
        Me.btnAssistance.Name = "btnAssistance"
        Me.btnAssistance.Size = New System.Drawing.Size(178, 57)
        Me.btnAssistance.TabIndex = 1
        Me.btnAssistance.Text = "ASSISTANCE"
        Me.btnAssistance.UseVisualStyleBackColor = True
        '
        'btnPayout
        '
        Me.btnPayout.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayout.Location = New System.Drawing.Point(97, 265)
        Me.btnPayout.Name = "btnPayout"
        Me.btnPayout.Size = New System.Drawing.Size(178, 57)
        Me.btnPayout.TabIndex = 2
        Me.btnPayout.Text = "PAYOUT"
        Me.btnPayout.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(379, 440)
        Me.Controls.Add(Me.btnPayout)
        Me.Controls.Add(Me.btnAssistance)
        Me.Controls.Add(Me.btnSeminar)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "BARANGAY SYSTEM (G7)"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSeminar As Button
    Friend WithEvents btnAssistance As Button
    Friend WithEvents btnPayout As Button
End Class
