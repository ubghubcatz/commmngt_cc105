Imports System.Data.Common
Imports Microsoft.Data.SqlClient

Public Class CallDetails

    Private connectionString As String = "Server=commngtcc105.mssql.somee.com;Database=commngtcc105;
                                     User Id=ublipa_SQLLogin_1;Password=nktg6ikffl;TrustServerCertificate=True;"

    Private Sub CallDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure the row height adjusts to fit wrapped text

        ' Table styling
        With CallNotes_Table
            .ReadOnly = True
            .EnableHeadersVisualStyles = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ' Fill available space
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells  ' Auto adjust row height
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True  ' Enable text wrapping
        End With

        ' Hide CallID and NoteID columns
        If CallNotes_Table.Columns.Contains("CallID") Then
            CallNotes_Table.Columns("CallID").Visible = False
        End If
        If CallNotes_Table.Columns.Contains("NoteID") Then
            CallNotes_Table.Columns("NoteID").Visible = False
        End If

        ' Header styling
        With CallNotes_Table.ColumnHeadersDefaultCellStyle
            .BackColor = Color.DarkGreen
            .ForeColor = Color.White
            .Font = New Font(CallNotes_Table.Font.FontFamily, CallNotes_Table.Font.Size, FontStyle.Bold)
            .Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        ' Cell styling (Semi-Bold, Centered)
        Dim semiBoldFont As New Font(CallNotes_Table.Font.FontFamily, CSng(CallNotes_Table.Font.Size - 1), FontStyle.Bold)
        For Each column As DataGridViewColumn In CallNotes_Table.Columns
            column.MinimumWidth = 100
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            column.DefaultCellStyle.Font = semiBoldFont  ' Apply semi-bold effect
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill  ' Ensure it fills the space
            column.FillWeight = 1  ' Give equal weight to each column
        Next
    End Sub


    Private Sub AddNotes_Btn_Click(sender As Object, e As EventArgs) Handles AddNotes_Btn.Click
        Dim addNoteForm As New AddNoteForm()
        ' Show the form after all data is loaded
        addNoteForm.TopLevel = False ' Set the form as non-top level
        addNoteForm.Location = New Point(0, 0) ' Position at the top-left corner
        Me.Controls.Add(addNoteForm) ' Add directly to the parent form
        addNoteForm.CallId_Label.Text = CallId_Label.Text.Trim()
        addNoteForm.BringToFront() ' Ensure it overlaps everything
        addNoteForm.Show() ' Show the form
    End Sub

End Class