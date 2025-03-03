Public Class Form2
    ' Shared list to store recorded incident reports
    Public Shared RecordsList As New List(Of String)()

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display stored records in the same format as Form3
        Dim yOffset As Integer = 20 ' Start position for labels
        Me.Controls.Clear() ' Remove old controls to refresh each time

        If RecordsList.Count > 0 Then
            Dim count As Integer = 1 ' Start numbering from 01

            For Each record As String In RecordsList
                ' Format incident report numbering
                Dim formattedRecord As String = count.ToString("00") & " Incident Report: " & record

                ' Create a new label for each record
                Dim lblRecord As New Label()
                lblRecord.Text = formattedRecord
                lblRecord.AutoSize = True
                lblRecord.Location = New Point(20, yOffset)
                Me.Controls.Add(lblRecord)

                yOffset += 30 ' Move next label down
                count += 1 ' Increment for the next report
            Next
        Else
            ' Show "No records found" if empty
            Dim lblNoRecords As New Label()
            lblNoRecords.Text = "No records found."
            lblNoRecords.AutoSize = True
            lblNoRecords.Location = New Point(20, yOffset)
            Me.Controls.Add(lblNoRecords)
        End If
    End Sub
End Class



