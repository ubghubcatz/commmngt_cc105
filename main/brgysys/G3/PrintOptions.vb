Imports System.Windows.Forms

Public Class PrintOptions

    Public Property caseID As String

    Private additionalInfo As String '
    Private additionalPhotos As List(Of Tuple(Of Image, String)) '
    Private additionalProcedures As List(Of Tuple(Of String, String)) '
    Private caseStatus As String '
    Private caseType As String '
    Private caseName As String
    Private dateTimeReported As String '
    Private expectedDeadline As String '
    Private mainCaseImage As Image
    Private officers As List(Of Tuple(Of String, String, String)) '
    Private peopleInvolved As List(Of Tuple(Of String, String, String)) '
    Private printCaseId As String '
    Private reportOrigins As String '
    Private reporterEmail As String '
    Private reporterName As String '
    Private reporterNum As String '

    Private MissingPersonName As String
    Private missingPersonAge As String
    Private missingPersonBday As String
    Private missingPersonPhysicalDesc As String
    Private missingPersonLastSeenLoc As String
    Private missingPersonHeight As String
    Private missingPersonEmail As String
    Private missingPersonNum As String

    Private stolenItems As List(Of Tuple(Of String, String, String))
    Private propertyDamage As String
    Private suspectDesc As String
    Private theftLocation As String

    Private whatHappened As String
    Private eventLoc As String

    Private Sub PrintOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FindMatchingCase()
    End Sub

    Private Sub FindMatchingCase()
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is CaseRecordShowForm Then
                Dim caseShow As CaseRecordShowForm = CType(frm, CaseRecordShowForm)
                If caseID = caseShow.CaseIDString_TextBox.Text Then
                    GetCaseData(caseShow)
                    Exit For
                End If
            End If
        Next
    End Sub

    Private Sub GetSpecificCaseDetails(caseShow As CaseRecordShowForm)
        Select Case caseShow.CaseType_TxtBox.Text
            Case "Theft"
                propertyDamage = caseShow.PropertyDamage_TextBox.Text
                suspectDesc = caseShow.SuspectDesc_TxtBox.Text
                theftLocation = caseShow.TheftLocation_TxtBox.Text

                stolenItems = New List(Of Tuple(Of String, String, String))
                For Each row As DataGridViewRow In caseShow.ItemDescription_DataGridView.Rows
                    If Not row.IsNewRow Then
                        Dim itemName As String = row.Cells(0).Value?.ToString()
                        Dim Desc As String = row.Cells(1).Value?.ToString()
                        Dim price As String = row.Cells(2).Value?.ToString()
                        stolenItems.Add(Tuple.Create(itemName, Desc, price))
                    End If
                Next

            Case "Missing Person"
                MissingPersonName = caseShow.MissingPersonName_TxtBox.Text
                missingPersonAge = caseShow.MissingPersonAge_TxtBox.Text
                missingPersonBday = caseShow.BrthDay_DateTimePicker.Text
                missingPersonPhysicalDesc = caseShow.MissingPersonPhysicalDesc_TxtBox.Text
                missingPersonLastSeenLoc = caseShow.MissingPersonLastSeenLocation_TxtBox.Text
                missingPersonHeight = caseShow.MissingPersonHeight_TxtBox.Text
                missingPersonEmail = caseShow.MissingPersonEmail_TxtBox.Text
                missingPersonNum = caseShow.MissingPersonNo_TxtBox.Text
                mainCaseImage = caseShow.MissingPerson_PicBox.Image

            Case Else
                whatHappened = caseShow.WhatHappened_TextBox.Text
                eventLoc = caseShow.GeneralCasesLocation_TextBox.Text
                mainCaseImage = caseShow.GeneralCases_PicBox.Image
        End Select
    End Sub

    Private Sub GetCaseData(caseShow As CaseRecordShowForm)
        printCaseId = caseShow.CaseIDString_TextBox.Text
        dateTimeReported = caseShow.DateAndTimeReported_TxtBox.Text
        caseStatus = caseShow.CaseStatus_TxtBox.Text
        caseType = caseShow.CaseType_TxtBox.Text
        If caseType.Contains("Others") Then
            caseType = caseShow.SpecificCaseType_ComboBox.Text
        End If
        expectedDeadline = caseShow.ExpectedResolveDare_TextBox.Text
        additionalInfo = caseShow.AdditionalInfo_TxtBox.Text

        reportOrigins = caseShow.ZoneName_TxtBox.Text
        reporterName = caseShow.FullName_TxtBox.Text
        reporterEmail = caseShow.Email_textbox.Text
        reporterNum = caseShow.PhoneNum_TxtBox.Text

        peopleInvolved = New List(Of Tuple(Of String, String, String))
        For Each row As DataGridViewRow In caseShow.CasePeople_DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim name As String = row.Cells(0).Value?.ToString()
                Dim number As String = row.Cells(1).Value?.ToString()
                Dim role As String = row.Cells(2).Value?.ToString()
                peopleInvolved.Add(Tuple.Create(name, number, role))
            End If
        Next

        officers = New List(Of Tuple(Of String, String, String))
        For Each row As DataGridViewRow In caseShow.OfficersSent_DataGridView.Rows
            If Not row.IsNewRow Then
                Dim officerId As String = row.Cells(0).Value?.ToString()
                Dim name As String = row.Cells(1).Value?.ToString()
                Dim position As String = row.Cells(2).Value?.ToString()
                officers.Add(Tuple.Create(name, officerId, position))
            End If
        Next

        additionalProcedures = New List(Of Tuple(Of String, String))
        For Each item As ListViewItem In caseShow.Procedure_ListView.Items
            Dim procedures As String = item.SubItems(0).Text ' main text
            Dim remarks As String = item.SubItems(1).Text ' first subitem
            additionalProcedures.Add(Tuple.Create(procedures, remarks))
        Next

        additionalPhotos = New List(Of Tuple(Of Image, String))
        For Each ctrl As Control In caseShow.AdditionalPhotos_FlowLayoutPanel.Controls
            If TypeOf ctrl Is PictureBox Then
                Dim picBox As PictureBox = DirectCast(ctrl, PictureBox)
                Dim tagTuple = TryCast(picBox.Tag, Tuple(Of Image, String, Integer))

                If tagTuple IsNot Nothing Then
                    Dim img As Image = tagTuple.Item1
                    Dim desc As String = tagTuple.Item2
                    additionalPhotos.Add(Tuple.Create(img, desc))
                End If
            End If
        Next
        GetSpecificCaseDetails(caseShow)
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim titleFont As New Font("Arial", 18, FontStyle.Bold)
        Dim labelFont As New Font("Arial", 12, FontStyle.Bold)
        Dim dataFont As New Font("Arial", 12, FontStyle.Regular)

        ' Variable to track if a page break has occurred
        Dim pageBreakOccurred As Boolean = False
        Dim yPos As Integer = 80
        Dim leftMargin As Integer = 70
        Dim lineSpacing As Integer = 30

        ' Title
        e.Graphics.DrawString("Case Report", titleFont, Brushes.Black, leftMargin, yPos)
        yPos += 40

        ' === Draw Case Info Box ===
        Dim boxPadding As Integer = 10
        Dim boxLeft As Integer = leftMargin - boxPadding
        Dim boxTop As Integer = yPos
        Dim boxWidth As Integer = 720

        ' Measure Additional Info text height
        Dim additionalInfoSize As SizeF = e.Graphics.MeasureString(additionalInfo, dataFont, boxWidth - 40)
        Dim additionalInfoHeight As Integer = CInt(Math.Ceiling(additionalInfoSize.Height))
        Dim textAreaWidth As Integer = boxWidth - (2 * boxPadding) - 10

        Dim contentHeight As Integer = 6 * lineSpacing + additionalInfoHeight + (2 * lineSpacing)
        Dim boxHeight As Integer = contentHeight + (boxPadding * 2)
        ' Check if the box will overflow the page
        If boxTop + boxHeight > e.MarginBounds.Bottom Then
            ' If the page break hasn't occurred yet, trigger a page break
            If Not pageBreakOccurred Then
                e.HasMorePages = True
                pageBreakOccurred = True ' Mark that the page break has occurred
                yPos = e.MarginBounds.Top ' Reset to the top of the new page
                pageBreakOccurred = False ' Mark that the page break has occurred
                Return ' Exit to continue on the new page
            End If
        End If
        ' Draw the rectangle (box)
        e.Graphics.DrawRectangle(Pens.Black, boxLeft, boxTop, boxWidth, boxHeight)

        ' Move yPos into the box
        yPos += boxPadding

        ' Inside the box (Case Information)
        Dim textLeft As Integer = boxLeft + boxPadding

        e.Graphics.DrawString("Case ID: ", labelFont, Brushes.Black, textLeft, yPos)
        e.Graphics.DrawString(printCaseId, dataFont, Brushes.Black, textLeft + 120, yPos)
        yPos += lineSpacing

        e.Graphics.DrawString("Reported On: ", labelFont, Brushes.Black, textLeft, yPos)
        e.Graphics.DrawString(dateTimeReported, dataFont, Brushes.Black, textLeft + 120, yPos)
        yPos += lineSpacing

        e.Graphics.DrawString("Status: ", labelFont, Brushes.Black, textLeft, yPos)
        e.Graphics.DrawString(caseStatus, dataFont, Brushes.Black, textLeft + 120, yPos)
        yPos += lineSpacing

        e.Graphics.DrawString("Case Type: ", labelFont, Brushes.Black, textLeft, yPos)
        e.Graphics.DrawString(caseType, dataFont, Brushes.Black, textLeft + 120, yPos)
        yPos += lineSpacing

        e.Graphics.DrawString("Expected Deadline: ", labelFont, Brushes.Black, textLeft, yPos)
        e.Graphics.DrawString(expectedDeadline, dataFont, Brushes.Black, textLeft + 160, yPos)
        yPos += lineSpacing

        e.Graphics.DrawString("Reporter: ", labelFont, Brushes.Black, textLeft, yPos)
        e.Graphics.DrawString($"{reporterName} ({reporterEmail}, {reporterNum})", dataFont, Brushes.Black, textLeft + 100, yPos)
        yPos += lineSpacing

        e.Graphics.DrawString("Zone: ", labelFont, Brushes.Black, textLeft, yPos)
        e.Graphics.DrawString(reportOrigins, dataFont, Brushes.Black, textLeft + 100, yPos)
        yPos += lineSpacing + 10

        ' Additional Info
        e.Graphics.DrawString("Additional Info: ", labelFont, Brushes.Black, textLeft, yPos)
        yPos += lineSpacing
        e.Graphics.DrawString(additionalInfo, dataFont, Brushes.Black, New RectangleF(textLeft, yPos, textAreaWidth, additionalInfoHeight))

        yPos += 100

        ' Add final spacing after the box
        yPos = boxTop + boxHeight + 30


        ' Theft-Specific Info
        If caseType = "Theft" Then

            If caseType = "Theft" Then
                e.Graphics.DrawString("=== Theft Case Details ===", titleFont, Brushes.Black, leftMargin, yPos)
                yPos += 40
            End If
            ' Measure Additional Info text height
            Dim suspectInfoSize As SizeF = e.Graphics.MeasureString(suspectDesc, dataFont, boxWidth - 40)
            Dim suspectInfoHeight As Integer = CInt(Math.Ceiling(suspectInfoSize.Height))
            Dim propertyDamageInfoSize As SizeF = e.Graphics.MeasureString(propertyDamage, dataFont, boxWidth - 40)
            Dim propertyDamageInfoHeight As Integer = CInt(Math.Ceiling(propertyDamageInfoSize.Height))
            Dim boxPadding2 As Integer = 10
            Dim boxLeft2 As Integer = leftMargin - boxPadding
            Dim boxTop2 As Integer = yPos
            Dim boxWidth2 As Integer = 720
            Dim contentHeight2 As Integer = 6 * lineSpacing + propertyDamageInfoHeight + suspectInfoHeight + (2 * lineSpacing) ' Estimate total content height
            Dim boxHeight2 As Integer = contentHeight + (boxPadding * 2)


            ' Draw the rectangle (box)
            e.Graphics.DrawRectangle(Pens.Black, boxLeft2, boxTop2, boxWidth2, boxHeight2)

            ' Move yPos into the box
            yPos += boxPadding2

            ' Inside the box
            Dim textLeft2 As Integer = boxLeft2 + boxPadding2

            e.Graphics.DrawString("Theft Location: ", labelFont, Brushes.Black, leftMargin, yPos)
            e.Graphics.DrawString(theftLocation, dataFont, Brushes.Black, leftMargin + 160, yPos)
            yPos += lineSpacing

            e.Graphics.DrawString("Suspect Description: ", labelFont, Brushes.Black, leftMargin, yPos)
            yPos += lineSpacing
            e.Graphics.DrawString(suspectDesc, dataFont, Brushes.Black, New RectangleF(textLeft, yPos, textAreaWidth, suspectInfoHeight))
            yPos += 30

            e.Graphics.DrawString("Property Damage: ", labelFont, Brushes.Black, leftMargin, yPos)
            yPos += lineSpacing
            e.Graphics.DrawString(propertyDamage, dataFont, Brushes.Black, New RectangleF(textLeft, yPos, textAreaWidth, propertyDamageInfoHeight))
            yPos += lineSpacing + 10

            ' Table Header
            e.Graphics.DrawString("Stolen Items:", labelFont, Brushes.Black, leftMargin, yPos)
            yPos += lineSpacing

            Dim col1Width As Integer = 180
            Dim col2Width As Integer = 280
            Dim col3Width As Integer = 220

            e.Graphics.DrawString("Item Name", labelFont, Brushes.Black, leftMargin, yPos)
            e.Graphics.DrawString("Description", labelFont, Brushes.Black, leftMargin + col1Width, yPos)
            e.Graphics.DrawString("Value", labelFont, Brushes.Black, leftMargin + col1Width + col2Width, yPos)

            yPos += lineSpacing
            e.Graphics.DrawLine(Pens.Black, leftMargin, yPos - 5, leftMargin + col1Width + col2Width + col3Width, yPos - 5)

            For Each item In stolenItems
                e.Graphics.DrawRectangle(Pens.Gray, leftMargin, yPos, col1Width, lineSpacing)
                e.Graphics.DrawRectangle(Pens.Gray, leftMargin + col1Width, yPos, col2Width, lineSpacing)
                e.Graphics.DrawRectangle(Pens.Gray, leftMargin + col1Width + col2Width, yPos, col3Width, lineSpacing)

                e.Graphics.DrawString(item.Item1, dataFont, Brushes.Black, leftMargin + 5, yPos)
                e.Graphics.DrawString(item.Item2, dataFont, Brushes.Black, leftMargin + col1Width + 5, yPos)
                e.Graphics.DrawString(item.Item3, dataFont, Brushes.Black, leftMargin + col1Width + col2Width + 5, yPos)

                yPos += lineSpacing
            Next

            ' Add final spacing after the box
            yPos = boxTop2 + boxHeight2 + 10

        End If



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