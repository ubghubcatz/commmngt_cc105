<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OfficersAvailabiltyForm
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
        Label1 = New Label()
        OfficersCases_DataGridView = New DataGridView()
        SearchOfficers_TextBox = New TextBox()
        Refresh_Btn = New Button()
        Panel1.SuspendLayout()
        CType(OfficersCases_DataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SeaGreen
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-2, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1561, 93)
        Panel1.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(94, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(420, 60)
        Label1.TabIndex = 9
        Label1.Text = "Officers Availabilty"
        ' 
        ' OfficersCases_DataGridView
        ' 
        OfficersCases_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        OfficersCases_DataGridView.Location = New Point(92, 204)
        OfficersCases_DataGridView.Name = "OfficersCases_DataGridView"
        OfficersCases_DataGridView.RowHeadersWidth = 51
        OfficersCases_DataGridView.Size = New Size(1409, 469)
        OfficersCases_DataGridView.TabIndex = 8
        ' 
        ' SearchOfficers_TextBox
        ' 
        SearchOfficers_TextBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SearchOfficers_TextBox.Location = New Point(107, 145)
        SearchOfficers_TextBox.Name = "SearchOfficers_TextBox"
        SearchOfficers_TextBox.PlaceholderText = "Search by officer name, position, or officer id"
        SearchOfficers_TextBox.Size = New Size(604, 34)
        SearchOfficers_TextBox.TabIndex = 9
        ' 
        ' Refresh_Btn
        ' 
        Refresh_Btn.BackColor = Color.SeaGreen
        Refresh_Btn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Refresh_Btn.ForeColor = Color.White
        Refresh_Btn.Location = New Point(1364, 139)
        Refresh_Btn.Name = "Refresh_Btn"
        Refresh_Btn.Size = New Size(137, 45)
        Refresh_Btn.TabIndex = 11
        Refresh_Btn.Text = "Refresh"
        Refresh_Btn.UseVisualStyleBackColor = False
        ' 
        ' OfficersAvailabiltyForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        ClientSize = New Size(1554, 685)
        Controls.Add(Refresh_Btn)
        Controls.Add(SearchOfficers_TextBox)
        Controls.Add(OfficersCases_DataGridView)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "OfficersAvailabiltyForm"
        TopMost = True
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(OfficersCases_DataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents OfficersCases_DataGridView As DataGridView
    Friend WithEvents SearchOfficers_TextBox As TextBox
    Friend WithEvents Refresh_Btn As Button
End Class
