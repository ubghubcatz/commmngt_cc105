Imports System.Windows.Forms

Public Class PrintOptions

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim dataFont As New Font("Arial", 13, FontStyle.Regular)
        Dim dataTitleFont As New Font("Arial", 18, FontStyle.Bold)
        e.Graphics.DrawString("Lol", dataTitleFont, Brushes.Black, 200, 200)
    End Sub

    Private Sub Print_Button_Click(sender As Object, e As EventArgs) Handles Print_Button.Click
        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub
    Private Sub PrintPreview_Button_Click(sender As Object, e As EventArgs) Handles PrintPreview_Button.Click
        If PrintDocument1.DefaultPageSettings Is Nothing Then
            PrintDocument1.DefaultPageSettings = New Printing.PageSettings()
        End If
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.TopMost = True
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub PageSetup_Button_Click(sender As Object, e As EventArgs) Handles PageSetup_Button.Click
        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.Document.DefaultPageSettings.Color = False
        PageSetupDialog1.ShowDialog()
    End Sub
End Class