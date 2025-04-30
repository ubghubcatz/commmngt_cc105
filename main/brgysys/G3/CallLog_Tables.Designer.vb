<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CallLog_Tables
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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        CallLog_Table = New DataGridView()
        AddCallLog_Btn = New Button()
        SearchCallLog_TxtField = New TextBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label1 = New Label()
        Timer1 = New Timer(components)
        CType(CallLog_Table, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' CallLog_Table
        ' 
        CallLog_Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        CallLog_Table.Location = New Point(42, 160)
        CallLog_Table.Name = "CallLog_Table"
        CallLog_Table.ReadOnly = True
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Honeydew
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        CallLog_Table.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        CallLog_Table.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        CallLog_Table.Size = New Size(1359, 481)
        CallLog_Table.TabIndex = 1
        ' 
        ' AddCallLog_Btn
        ' 
        AddCallLog_Btn.BackColor = Color.SeaGreen
        AddCallLog_Btn.FlatStyle = FlatStyle.Flat
        AddCallLog_Btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddCallLog_Btn.ForeColor = Color.White
        AddCallLog_Btn.Location = New Point(1167, 112)
        AddCallLog_Btn.Name = "AddCallLog_Btn"
        AddCallLog_Btn.Size = New Size(234, 38)
        AddCallLog_Btn.TabIndex = 3
        AddCallLog_Btn.Text = "ADD CALL LOG"
        AddCallLog_Btn.UseVisualStyleBackColor = False
        ' 
        ' SearchCallLog_TxtField
        ' 
        SearchCallLog_TxtField.BorderStyle = BorderStyle.FixedSingle
        SearchCallLog_TxtField.Font = New Font("Segoe UI", 12F)
        SearchCallLog_TxtField.Location = New Point(42, 116)
        SearchCallLog_TxtField.Name = "SearchCallLog_TxtField"
        SearchCallLog_TxtField.PlaceholderText = "Search by phone number, call date, zone name, or handler."
        SearchCallLog_TxtField.Size = New Size(572, 34)
        SearchCallLog_TxtField.TabIndex = 4
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SeaGreen
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-2, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1429, 96)
        Panel1.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = My.Resources.Resources.CallLogs_Open__1_
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Location = New Point(3, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(104, 93)
        Panel2.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(110, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(210, 60)
        Label1.TabIndex = 9
        Label1.Text = "Call Logs"
        ' 
        ' CallLog_Tables
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        ClientSize = New Size(1428, 653)
        Controls.Add(Panel1)
        Controls.Add(SearchCallLog_TxtField)
        Controls.Add(AddCallLog_Btn)
        Controls.Add(CallLog_Table)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "CallLog_Tables"
        StartPosition = FormStartPosition.Manual
        Text = "CallLog_Tables"
        CType(CallLog_Table, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CallLog_Table As DataGridView
    Friend WithEvents AddCallLog_Btn As Button
    Friend WithEvents SearchCallLog_TxtField As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Timer1 As Timer
End Class
