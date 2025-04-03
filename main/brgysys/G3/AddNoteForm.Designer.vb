<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNoteForm
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
        ConfirmNotes_Btn = New Button()
        AddedByTxtBox = New TextBox()
        Note_TextBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        HandlerResultsListBox = New ListBox()
        CallId_Label = New Label()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Green
        Panel1.Location = New Point(511, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(54, 326)
        Panel1.TabIndex = 0
        ' 
        ' ConfirmNotes_Btn
        ' 
        ConfirmNotes_Btn.BackColor = Color.Green
        ConfirmNotes_Btn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ConfirmNotes_Btn.ForeColor = Color.White
        ConfirmNotes_Btn.Location = New Point(343, 263)
        ConfirmNotes_Btn.Name = "ConfirmNotes_Btn"
        ConfirmNotes_Btn.Size = New Size(151, 54)
        ConfirmNotes_Btn.TabIndex = 0
        ConfirmNotes_Btn.Text = "Add Note"
        ConfirmNotes_Btn.UseVisualStyleBackColor = False
        ' 
        ' AddedByTxtBox
        ' 
        AddedByTxtBox.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddedByTxtBox.Location = New Point(140, 30)
        AddedByTxtBox.Name = "AddedByTxtBox"
        AddedByTxtBox.Size = New Size(354, 30)
        AddedByTxtBox.TabIndex = 1
        ' 
        ' Note_TextBox
        ' 
        Note_TextBox.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Note_TextBox.Location = New Point(140, 102)
        Note_TextBox.Multiline = True
        Note_TextBox.Name = "Note_TextBox"
        Note_TextBox.Size = New Size(354, 155)
        Note_TextBox.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Green
        Label1.Location = New Point(11, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 31)
        Label1.TabIndex = 3
        Label1.Text = "Added By:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Green
        Label2.Location = New Point(61, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 31)
        Label2.TabIndex = 4
        Label2.Text = "Note:"
        ' 
        ' HandlerResultsListBox
        ' 
        HandlerResultsListBox.FormattingEnabled = True
        HandlerResultsListBox.Location = New Point(140, 55)
        HandlerResultsListBox.Name = "HandlerResultsListBox"
        HandlerResultsListBox.Size = New Size(354, 124)
        HandlerResultsListBox.TabIndex = 5
        ' 
        ' CallId_Label
        ' 
        CallId_Label.AutoSize = True
        CallId_Label.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CallId_Label.ForeColor = Color.DarkOliveGreen
        CallId_Label.Location = New Point(530, 9)
        CallId_Label.Name = "CallId_Label"
        CallId_Label.Size = New Size(0, 31)
        CallId_Label.TabIndex = 20
        ' 
        ' AddNoteForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        ClientSize = New Size(561, 325)
        Controls.Add(CallId_Label)
        Controls.Add(HandlerResultsListBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Note_TextBox)
        Controls.Add(AddedByTxtBox)
        Controls.Add(ConfirmNotes_Btn)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "AddNoteForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ConfirmNotes_Btn As Button
    Friend WithEvents AddedByTxtBox As TextBox
    Friend WithEvents Note_TextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents HandlerResultsListBox As ListBox
    Friend WithEvents CallId_Label As Label
End Class
