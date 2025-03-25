Public Class Form3
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSUBMIT.Click
        ' Capture user input from text fields
        Dim inputData As String = "Name: " & TextBox1.Text &
                                  " | Date: " & DateTimePicker1.Value.ToString("MM/dd/yyyy") &
                                  " | Location: " & TextBox2.Text &
                                  " | Incident: " & TextBox3.Text &
                                  " | Description: " & TextBox4.Text

        ' Save to Form2's shared list
        Form2.RecordsList.Add(inputData)

        ' Clear text fields for new input
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        DateTimePicker1.Value = DateTime.Now

        ' Notify user that data was saved
        MessageBox.Show("Incident report submitted successfully! Click 'RECORDS' to view.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
