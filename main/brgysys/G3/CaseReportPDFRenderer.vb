Imports System.Drawing.Printing
Imports System.Reflection.Metadata
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf
Imports Windows.Win32.System

Module CaseReportPDFRenderer
    Public Property caseID As String

    Private additionalInfo As String
    Private additionalPhotos As List(Of Tuple(Of Image, String))
    Private additionalProcedures As List(Of Tuple(Of String, String, String))
    Private caseStatus As String
    Private caseType As String
    Private caseName As String
    Private dateTimeReported As String
    Private expectedDeadline As String
    Private mainCaseImage As List(Of Image)
    Private officers As List(Of Tuple(Of String, String, String))
    Private peopleInvolved As List(Of Tuple(Of String, String, String))
    Private printCaseId As String
    Private reportOrigins As String
    Private reporterEmail As String
    Private reporterName As String
    Private reporterNum As String
    Private caseLocation As String
    Private MissingPersonName As String
    Private missingPersonAge As String
    Private missingPersonBday As String
    Private missingPersonPhysicalDesc As String
    Private missingPersonLastSeenLoc As String
    Private missingPersonHeight As String
    Private missingPersonEmail As String
    Private missingPersonNum As String
    Private labels As List(Of String)
    Private values As List(Of String)
    Private stolenItems As List(Of Tuple(Of String, String, String))
    Private propertyDamage As String
    Private suspectDesc As String
    Private theftLocation As String
    Private whatHappened As String
    Private eventLoc As String

    Public Sub FindMatchingCase(caseID As String)
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


    Public Sub GetSpecificCaseDetails(caseShow As CaseRecordShowForm)
        mainCaseImage = New List(Of Image)()
        Select Case caseShow.CaseType_TxtBox.Text
            Case "Theft"
                propertyDamage = caseShow.PropertyDamage_TextBox.Text
                suspectDesc = caseShow.SuspectDesc_TxtBox.Text
                caseLocation = caseShow.TheftLocation_TxtBox.Text

                stolenItems = New List(Of Tuple(Of String, String, String))
                For Each row As DataGridViewRow In caseShow.ItemDescription_DataGridView.Rows
                    If Not row.IsNewRow Then
                        Dim itemName As String = row.Cells(0).Value?.ToString()
                        Dim Desc As String = row.Cells(1).Value?.ToString()
                        Dim price As String = row.Cells(2).Value?.ToString()
                        stolenItems.Add(Tuple.Create(itemName, Desc, price))
                    End If
                Next
                caseName = caseShow.StolenItemsCaseName_Label.Text

            Case "Missing Person"

                MissingPersonName = caseShow.MissingPersonName_TxtBox.Text
                missingPersonAge = caseShow.MissingPersonAge_TxtBox.Text
                missingPersonBday = caseShow.BrthDay_DateTimePicker.Text
                caseLocation = caseShow.MissingPersonLastSeenLocation_TxtBox.Text
                missingPersonHeight = caseShow.MissingPersonHeight_TxtBox.Text
                missingPersonEmail = caseShow.MissingPersonEmail_TxtBox.Text
                missingPersonNum = caseShow.MissingPersonNo_TxtBox.Text

                missingPersonPhysicalDesc = caseShow.MissingPersonPhysicalDesc_TxtBox.Text

                mainCaseImage.Add(caseShow.MissingPerson_PicBox.Image)

                caseName = caseShow.MissingPersonCaseName_Label.Text
                labels = New List(Of String)()
                labels.AddRange(New List(Of String) From {
    "Name:",
    "Age:",
    "Birthday:",
    "Last Seen Location:",
    "Height:",
    "Email:",
    "Phone Number:"
})

                values = New List(Of String)()

                values.AddRange(New List(Of String) From {
                    MissingPersonName,
                    missingPersonAge,
                    missingPersonBday,
                    caseLocation,
                    missingPersonHeight,
                    missingPersonEmail,
                    missingPersonNum
                })
            Case Else
                whatHappened = caseShow.WhatHappened_TextBox.Text
                caseLocation = caseShow.GeneralCasesLocation_TextBox.Text
                mainCaseImage.Add(caseShow.GeneralCases_PicBox.Image)
                caseName = caseShow.GeneralCaseName_Label.Text
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

        additionalProcedures = New List(Of Tuple(Of String, String, String))
        For Each item As ListViewItem In caseShow.Procedure_ListView.Items
            Dim procedures As String = item.SubItems(0).Text ' main text
            Dim remarks As String = item.SubItems(1).Text ' first subitem
            Dim dateAdded As String = item.SubItems(2).Text ' first subitem
            additionalProcedures.Add(Tuple.Create(procedures, remarks, dateAdded))
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


    Private Sub DrawHorizontalLine2(ByRef e As XGraphics, pages As PdfPage, leftMargin As Double, rightMargin As Double, topMargin As Double, intLineNumber As Integer, lineHeight As Double)
        Dim lineY As Double = topMargin + (intLineNumber * lineHeight) - (lineHeight / 2)
        Dim startPoint As New XPoint(leftMargin, lineY)
        Dim endPoint As New XPoint(pages.Width.Point - rightMargin, lineY)
        e.DrawLine(XPens.Black, startPoint, endPoint)
    End Sub

    Private Sub DrawHorizontalLine(ByRef e As XGraphics, pages As PdfPage, leftMargin As Double, rightMargin As Double, topMargin As Double, intLineNumber As Integer, lineHeight As Double)
        Dim lineY As Double = topMargin + (intLineNumber * lineHeight) - (lineHeight / 2)
        Dim startPoint As New XPoint(leftMargin, lineY)
        Dim endPoint As New XPoint(pages.Width.Point - rightMargin, lineY)

        ' Create a thicker pen
        Dim thickPen As New XPen(XColors.Black, 3) ' 2 is the thickness (you can change it)
        e.DrawLine(thickPen, startPoint, endPoint)
    End Sub


    Public Sub RenderCasePage_PDF(
       e As XGraphics,
       pages As PdfPage,
       ByRef intStart As Integer,
       ByRef currentSection As Integer,
       ByRef intPhotoIndex As Integer,
       ByRef caseImageIndex As Integer,
       ByRef intValIndex As Integer,
       ByRef procedureCount As Integer,
       ByRef peopleCount As Integer,
       ByRef officerCount As Integer,
       numbers() As Integer,
       document As PdfDocument)
        Dim wrappedLines As List(Of String) = Nothing


        ' Get the page's height
        Dim pageHeight As Double = pages.Height.Point
        Dim titleFont As New XFont("Arial", 20, XFontStyleEx.Bold)
        Dim labelFont As New XFont("Arial", 12, XFontStyleEx.Bold)
        Dim dataFont As New XFont("Arial", 12, XFontStyleEx.Regular)
        Dim thickPen As New XPen(XColors.Black, 3)
        Dim leftMargin As Double = 50
        Dim rightMargin As Double = 50
        Dim topMargin As Double = 50
        Dim bottomMargin As Double = 50
        Dim lineHeight As Double = dataFont.GetHeight()
        ' Calculate the total available height for content (without margins)
        Dim txtHeight As Double = pageHeight - topMargin - bottomMargin
        Dim linesPerPage As Integer = CInt(Math.Floor(txtHeight / lineHeight))
        Dim intLineNumber As Integer = 0

        Do While True
            Select Case currentSection
                Case 0
                    ' Title and general info
                    e.DrawString("Case Report", titleFont, XBrushes.Black, leftMargin, topMargin + (intLineNumber * lineHeight))
                    intLineNumber += 1
                    DrawHorizontalLine(e, pages, leftMargin, rightMargin, topMargin, intLineNumber, lineHeight)
                    intLineNumber += 1

                    e.DrawString("General Case Info:", labelFont, XBrushes.Black, leftMargin, topMargin + (intLineNumber * lineHeight))
                    intLineNumber += 1


                    e.DrawString("Case ID:", labelFont, XBrushes.Black, leftMargin, topMargin + (intLineNumber * lineHeight))
                    e.DrawString(caseID, dataFont, XBrushes.Black, leftMargin + 180, topMargin + (intLineNumber * lineHeight))
                    intLineNumber += 2

                    e.DrawString("Case Name:", labelFont, XBrushes.Black, leftMargin, topMargin + (intLineNumber * lineHeight))
                    e.DrawString(caseName, dataFont, XBrushes.Black, leftMargin + 180, topMargin + (intLineNumber * lineHeight))
                    intLineNumber += 2

                    e.DrawString("Case Type:", labelFont, XBrushes.Black, leftMargin, topMargin + (intLineNumber * lineHeight))
                    e.DrawString(caseType, dataFont, XBrushes.Black, leftMargin + 180, topMargin + (intLineNumber * lineHeight))
                    intLineNumber += 2

                    e.DrawString("Case Status:", labelFont, XBrushes.Black, leftMargin, topMargin + (intLineNumber * lineHeight))
                    e.DrawString(caseStatus, dataFont, XBrushes.Black, leftMargin + 180, topMargin + (intLineNumber * lineHeight))
                    intLineNumber += 2

                    e.DrawString("Reported On:", labelFont, XBrushes.Black, leftMargin, topMargin + (intLineNumber * lineHeight))
                    e.DrawString(dateTimeReported, dataFont, XBrushes.Black, leftMargin + 180, topMargin + (intLineNumber * lineHeight))
                    intLineNumber += 2

                    e.DrawString("Case Deadline:", labelFont, XBrushes.Black, leftMargin, topMargin + (intLineNumber * lineHeight))
                    e.DrawString(expectedDeadline, dataFont, XBrushes.Black, leftMargin + 180, topMargin + (intLineNumber * lineHeight))
                    intLineNumber += 2

                    e.DrawString("Reported By:", labelFont, XBrushes.Black, leftMargin, topMargin + (intLineNumber * lineHeight))
                    e.DrawString(reporterName, dataFont, XBrushes.Black, leftMargin + 180, topMargin + (intLineNumber * lineHeight))
                    intLineNumber += 2

                    e.DrawString("Reported Contacts:", labelFont, XBrushes.Black, leftMargin, topMargin + (intLineNumber * lineHeight))
                    e.DrawString(reporterEmail + " | " + reporterNum, dataFont, XBrushes.Black, leftMargin + 180, topMargin + (intLineNumber * lineHeight))
                    intLineNumber += 2

                    e.DrawString("Origins:", labelFont, XBrushes.Black, leftMargin, topMargin + (intLineNumber * lineHeight))
                    e.DrawString(reportOrigins, dataFont, XBrushes.Black, leftMargin + 180, topMargin + (intLineNumber * lineHeight))
                    intLineNumber += 2

                    DrawHorizontalLine(e, pages, leftMargin, rightMargin, topMargin, intLineNumber, lineHeight)
                    intLineNumber += 1

                    currentSection = 1

                Case 1
                    intLineNumber += 1

                    If numbers(1) = 0 Then
                        e.DrawString("Specific Case Info:", labelFont, XBrushes.Black, leftMargin, topMargin + (intLineNumber * lineHeight))
                        intLineNumber += 2
                    End If

                    If caseType = "Theft" Then

                        Dim intStartStolenItems As Integer = 0
                        If Not PrintTable(e, "Stolen Items:", stolenItems, labelFont, dataFont, intLineNumber, intStartStolenItems, leftMargin, topMargin,
                        "Item Name", "Item Description", "Item Value", rightMargin, bottomMargin, lineHeight,
                                       document, pages) Then
                            currentSection = 1
                            numbers(1) = 1
                            Return
                        End If
                        intLineNumber += 1

                        If Not PrintWrappedText(e, "Property Damage:", propertyDamage, labelFont, dataFont, intLineNumber, intStart, leftMargin, topMargin, pages,
                                                  bottomMargin, rightMargin, lineHeight, document, wrappedLines) Then
                            currentSection = 1
                            numbers(1) = 1
                            Exit Sub
                        End If
                        intLineNumber += 2

                        If Not PrintWrappedText(e, "Suspect Description:", suspectDesc, labelFont, dataFont, intLineNumber, intStart, leftMargin, topMargin, pages,
                                                  bottomMargin, rightMargin, lineHeight, document, wrappedLines) Then
                            currentSection = 1
                            numbers(1) = 1
                            Exit Sub
                        End If
                        intLineNumber += 2


                        If Not PrintWrappedText(e, "Theft Location:", caseLocation, labelFont, dataFont, intLineNumber, intStart, leftMargin, topMargin, pages,
                                                  bottomMargin, rightMargin, lineHeight, document, wrappedLines) Then
                            currentSection = 1
                            numbers(1) = 1
                            Exit Sub
                        End If
                        intLineNumber += 2

                        ' Logic for printing a case (within the PrintPage event)
                    ElseIf caseType = "Missing Person" Then
                        If Not caseImage(e, mainCaseImage, leftMargin, topMargin, intLineNumber, lineHeight, caseImageIndex, pages,
                        bottomMargin, rightMargin, document) Then
                            currentSection = 1
                            numbers(1) = 1
                            Exit Sub
                        End If

                        intLineNumber += 2

                        If Not columnFix(e,
                        leftMargin, topMargin, intLineNumber, lineHeight, labelFont, dataFont, labels, values, intValIndex, pages,
                               bottomMargin, rightMargin, document) Then
                                currentSection = 1
                                numbers(1) = 1
                                Exit Sub
                            End If

                        intLineNumber += 2
                        If Not PrintWrappedText(e, "Victim Description:", missingPersonPhysicalDesc, labelFont, dataFont, intLineNumber, intStart,
                                                leftMargin, topMargin, pages,
                                                  bottomMargin, rightMargin, lineHeight, document, wrappedLines) Then
                                currentSection = 1
                                numbers(1) = 1
                                Exit Sub
                            End If
                        Else
                            If Not caseImage(e, mainCaseImage, leftMargin, topMargin, intLineNumber, lineHeight, caseImageIndex, pages,
                               bottomMargin, rightMargin, document) Then
                            currentSection = 1
                            numbers(1) = 1
                            Exit Sub
                        End If

                        If Not PrintWrappedText(e, "Location:", caseLocation, labelFont, dataFont, intLineNumber, intStart, leftMargin, topMargin, pages,
                                                  bottomMargin, rightMargin, lineHeight, document, wrappedLines) Then
                                currentSection = 1
                                numbers(1) = 1
                                Exit Sub
                            End If
                            intLineNumber += 1

                            If Not PrintWrappedText(e, "Events Unfolded:", whatHappened, labelFont, dataFont, intLineNumber, intStart, leftMargin, topMargin, pages,
                                                  bottomMargin, rightMargin, lineHeight, document, wrappedLines) Then
                                currentSection = 1
                                numbers(1) = 1
                                Exit Sub
                            End If
                        End If
                    intLineNumber += 1
                    DrawHorizontalLine(e, pages, leftMargin, rightMargin, topMargin, intLineNumber, lineHeight)

                    intLineNumber += 2
                    currentSection = 2

                Case 2

                    If Not PrintWrappedText(e, "Additional Info:", additionalInfo, labelFont, dataFont, intLineNumber, intStart, leftMargin, topMargin, pages,
                                                 bottomMargin, rightMargin, lineHeight, document, wrappedLines) Then
                        currentSection = 2
                        Exit Sub
                    End If
                    intLineNumber += 1
                    DrawHorizontalLine(e, pages, leftMargin, rightMargin, topMargin, intLineNumber, lineHeight)
                    currentSection = 3

                Case 3

                    intLineNumber += 3
                    If Not PrintTable(e, "Procedures Taken:", additionalProcedures, labelFont, dataFont, intLineNumber, procedureCount, leftMargin, topMargin,
                 "Procedures", "Remarks", "Date And Time", rightMargin, bottomMargin, lineHeight,
                                       document, pages) Then
                        currentSection = 3
                        Return
                    End If

                    currentSection = 4
                Case 4
                    DrawHorizontalLine(e, pages, leftMargin, rightMargin, topMargin, intLineNumber, lineHeight)
                    intLineNumber += 1

                    If Not PrintTable(e, "People Involved in the Case:", peopleInvolved, labelFont, dataFont, intLineNumber, peopleCount, leftMargin, topMargin,
            "Names", "Number", "Roles", rightMargin, bottomMargin, lineHeight,
                                       document, pages) Then
                        currentSection = 4
                        Return
                    End If


                    If Not PrintTable(e, "Officers Involved:", officers, labelFont, dataFont, intLineNumber, officerCount, leftMargin, topMargin,
                "Officers", "ID", "Position", rightMargin, bottomMargin, lineHeight,
                                       document, pages) Then
                        currentSection = 4
                        Return
                    End If


                    DrawHorizontalLine(e, pages, leftMargin, rightMargin, topMargin, intLineNumber, lineHeight)
                    intLineNumber += 2

                    currentSection = 5

                Case 5
                    e.DrawString("Additional Photos:", labelFont, XBrushes.Black, leftMargin, topMargin + (intLineNumber * lineHeight))
                    intLineNumber += 2
                    If Not PrintPhotos(e, additionalPhotos, labelFont, intPhotoIndex, leftMargin, topMargin, intLineNumber, lineHeight,
                    pages, bottomMargin, document) Then
                        currentSection = 5
                        Exit Sub
                    End If
                    intLineNumber += 2
                    DrawHorizontalLine(e, pages, leftMargin, rightMargin, topMargin, intLineNumber, lineHeight)
                    currentSection = 6

                Case 6
                    Exit Sub
            End Select
        Loop
    End Sub

    Private Function PrintWrappedText(ByRef e As XGraphics, textTitle As String, text As String, titleFont As XFont, font As XFont,
                                  ByRef intLineNumber As Integer, ByRef intStart As Integer,
                                  leftMargin As Double, topMargin As Double, pages As PdfPage, bottomMargin As Double,
                                  rightMargin As Double, lineHeight As Double, document As PdfDocument,
                                  ByRef wrappedLines As List(Of String)) As Boolean

        Dim layoutWidth As Single = pages.Width.Point - (leftMargin + rightMargin)

        Dim yPos As Single = topMargin + (lineHeight * intLineNumber)
        ' Only wrap text once (when wrappedLines is empty)
        If wrappedLines Is Nothing OrElse wrappedLines.Count = 0 Then
            wrappedLines = New List(Of String)()
            Dim words() As String = text.Split(" "c)
            Dim currentLine As String = ""

            For Each word In words
                Dim testLine As String = If(currentLine = "", word, currentLine & " " & word)
                Dim size As XSize = e.MeasureString(testLine, font)

                If size.Width > layoutWidth Then
                    wrappedLines.Add(currentLine)
                    currentLine = word
                Else
                    currentLine = testLine
                End If
            Next
            If currentLine <> "" Then wrappedLines.Add(currentLine)
        End If
        If yPos + lineHeight > (pages.Height.Point - bottomMargin) Then
            ' Add new page
            pages = document.AddPage()
            e = XGraphics.FromPdfPage(pages)
            intLineNumber = 0
            yPos = topMargin
        End If

        ' Print the title only once for the section
        If intStart = 0 And yPos + lineHeight < (pages.Height.Point - bottomMargin) Then
            e.DrawString(textTitle, titleFont, XBrushes.Black, leftMargin, topMargin + (lineHeight * intLineNumber))
            intLineNumber += 1
        End If

        ' Print wrapped lines starting from intStart
        For i As Integer = intStart To wrappedLines.Count - 1
            yPos = topMargin + (lineHeight * intLineNumber)

            If yPos + lineHeight > (pages.Height.Point - bottomMargin) Then
                ' Add new page
                pages = document.AddPage()
                e = XGraphics.FromPdfPage(pages)
                intLineNumber = 0
                yPos = topMargin
            End If

            e.DrawString(wrappedLines(i), font, XBrushes.Black, leftMargin, yPos)
            intLineNumber += 1
        Next

        intStart = 0 ' Reset start
        wrappedLines = Nothing
        Return True ' All lines printed
    End Function

    Private Function PrintTable(ByRef e As XGraphics, textTitle As String, tableData As List(Of Tuple(Of String, String, String)),
                      titleFont As XFont, cellFont As XFont, ByRef intLineNumber As Integer, ByRef intStartRow As Integer,
                                leftMargin As Double, topMargin As Double, column1 As String, column2 As String, column3 As String,
                                     rightMargin As Double, bottomMargin As Double, lineHeight As Double,
                                     document As PdfDocument, pages As PdfPage) As Boolean

        Dim layoutWidth As Single = pages.Width.Point - (leftMargin + rightMargin)
        Dim colWidths() As Single = {layoutWidth / 3, layoutWidth / 3, layoutWidth / 3}
        Dim maxVal As Integer
        Dim yPos As Single = topMargin + (lineHeight * intLineNumber)
        ' Print the first table
        If intStartRow = 0 Then
            ' Check if we need a new page for the first table
            If yPos + (3 * lineHeight) > pages.Height.Point - bottomMargin Then
                pages = document.AddPage()
                e = XGraphics.FromPdfPage(pages) ' Create a new graphics object for the new page
                intLineNumber = 0 ' Reset line number for the new page
            End If

            ' Title
            e.DrawString(textTitle, titleFont, XBrushes.Black, leftMargin, yPos)
            intLineNumber += 2
            yPos = topMargin + (lineHeight * intLineNumber)
            ' Column headers
            e.DrawString(column1, titleFont, XBrushes.Black, leftMargin, yPos)
            e.DrawString(column2, titleFont, XBrushes.Black, leftMargin + colWidths(0), yPos)
            e.DrawString(column3, titleFont, XBrushes.Black, leftMargin + colWidths(0) + colWidths(1), yPos)
            intLineNumber += 1
            DrawHorizontalLine2(e, pages, leftMargin, rightMargin, topMargin, intLineNumber, lineHeight)

            intLineNumber += 1
            yPos = topMargin + (lineHeight * intLineNumber)
        End If

        ' Print the rows of the first table
        For i As Integer = intStartRow To tableData.Count - 1
            Dim row = tableData(i)
            Dim col1 = row.Item1
            Dim col2 = row.Item2
            Dim col3 = row.Item3

            ' Measure and wrap text for each cell
            Dim wrappedCol1 = WrapText(col1, cellFont, colWidths(0), e)
            Dim wrappedCol2 = WrapText(col2, cellFont, colWidths(1), e)
            Dim wrappedCol3 = WrapText(col3, cellFont, colWidths(2), e)

            ' Get max lines for the row
            Dim maxLines = Math.Max(wrappedCol1.Count, Math.Max(wrappedCol2.Count, wrappedCol3.Count))

            ' Check if page limit is reached (before drawing the row)
            If yPos + (maxLines * lineHeight) > pages.Height.Point - bottomMargin Then
                pages = document.AddPage()
                e = XGraphics.FromPdfPage(pages) ' Create a new graphics object for the new page
                intLineNumber = 0 ' Reset line number for the new page
            End If

            ' Draw the row
            For j = 0 To maxLines - 1
                yPos = topMargin + (lineHeight * intLineNumber)

                If j < wrappedCol1.Count Then
                    e.DrawString(wrappedCol1(j), cellFont, XBrushes.Black, leftMargin, yPos)
                End If
                If j < wrappedCol2.Count Then
                    e.DrawString(wrappedCol2(j), cellFont, XBrushes.Black, leftMargin + colWidths(0), yPos)
                End If
                If j < wrappedCol3.Count Then
                    e.DrawString(wrappedCol3(j), cellFont, XBrushes.Black, leftMargin + colWidths(0) + colWidths(1), yPos)
                End If

                maxVal = wrappedCol1.Count
                intLineNumber += 1
            Next

            ' Draw separator line after the row
            DrawHorizontalLine2(e, pages, leftMargin, rightMargin, topMargin, intLineNumber, lineHeight)
            intLineNumber += 1
        Next
        intLineNumber += 2


        ' After table is done, return success
        intStartRow = maxVal
        Return True
    End Function


    Private Function WrapText(text As String, font As XFont, maxWidth As Single, gfx As XGraphics) As List(Of String)
        Dim lines As New List(Of String)
        Dim words() As String = text.Split(" "c)
        Dim currentLine As String = ""

        For Each word In words
            Dim testLine As String = If(currentLine = "", word, currentLine & " " & word)
            Dim size As XSize = gfx.MeasureString(testLine, font) ' Use XGraphics here
            If size.Width > maxWidth Then
                lines.Add(currentLine)
                currentLine = word
            Else
                currentLine = testLine
            End If
        Next

        If currentLine <> "" Then lines.Add(currentLine)
        Return lines
    End Function

    Private Function PrintPhotos(ByRef e As XGraphics, photos As List(Of Tuple(Of Image, String)),
                           font As XFont, ByRef intPhotoIndex As Integer,
                           leftMargin As Double, topMargin As Double, ByRef intLineNumber As Integer,
                           lineHeight As Double, page As PdfPage, bottomMargin As Double, Document As PdfDocument) As Boolean

        Dim availableWidth As Double = page.Height.Point - (topMargin + bottomMargin)
        Dim maxImageHeight As Double = 160 ' Max display height
        Dim spacing As Double = 10

        For i As Integer = intPhotoIndex To photos.Count - 1
            Dim photo = photos(i).Item1
            Dim caption = photos(i).Item2

            Dim originalWidth = photo.Width
            Dim originalHeight = photo.Height

            ' Scale image to fit width, maintaining aspect ratio
            Dim scaleFactor As Single = Math.Min(availableWidth / originalWidth, maxImageHeight / originalHeight)
            Dim scaledWidth As Integer = CInt(originalWidth * scaleFactor)
            Dim scaledHeight As Integer = CInt(originalHeight * scaleFactor)

            Dim yPos As Integer = topMargin + intLineNumber * lineHeight
            Dim captionHeight As Integer = CInt(e.MeasureString(caption, font).Height)
            Dim totalHeight As Integer = scaledHeight + spacing + captionHeight

            ' Check if there's space on the page
            If yPos + totalHeight > page.Height.Point - (bottomMargin) Then
                intPhotoIndex = i
                page = Document.AddPage()
                e = XGraphics.FromPdfPage(page)
                intLineNumber = 0 ' reset line number for new page
            End If

            ' Center image horizontally if narrower than availableWidth
            Dim xPos As Integer = leftMargin

            Dim ms As New System.IO.MemoryStream()
            Using clonedPhoto As New Bitmap(photo)
                clonedPhoto.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
            End Using
            ms.Position = 0 ' Reset memory stream position
            Dim xImage As XImage = XImage.FromStream(ms)

            e.DrawImage(xImage, xPos, yPos, scaledWidth, scaledHeight)


            ' Draw the caption below the image
            yPos += scaledHeight + spacing
            e.DrawString(caption, font, XBrushes.Black, leftMargin, yPos)

            ' Advance the line number by estimated space used
            intLineNumber += (totalHeight \ lineHeight) + 1
        Next

        intPhotoIndex = photos.Count
        Return True
    End Function

    Private Function columnFix(ByRef e As XGraphics,
                                  ByRef leftMargin As Double,
                                  topMargin As Double,
                                  ByRef intLineNumber As Integer, ByRef lineHeight As Integer, labelFont As XFont, valueFont As XFont,
                                  labels As List(Of String), values As List(Of String), ByRef intValIndex As Integer, page As PdfPage,
                               bottomMargin As Double, rightMargin As Double, Document As PdfDocument) As Boolean

        Dim layoutWidth As Single = page.Width.Point - (leftMargin + rightMargin)
        Dim colWidths() As Single = {layoutWidth / 2, layoutWidth / 2}
        Dim labelX As Single = leftMargin
        Dim valueX As Single = leftMargin + 190
        Dim currentY As Single = topMargin + (lineHeight * intLineNumber)

        For f As Integer = intValIndex To labels.Count - 1
            Dim wrappedCol1 = WrapText(labels(f), labelFont, colWidths(0), e)
            Dim wrappedCol2 = WrapText(values(f), valueFont, colWidths(1), e)

            Dim maxLines = Math.Max(wrappedCol1.Count, wrappedCol2.Count)

            For j As Integer = intValIndex To maxLines - 1
                ' Check if it fits on the page
                currentY = topMargin + (lineHeight * intLineNumber)

                If currentY + lineHeight * maxLines + lineHeight > page.Height.Point - bottomMargin Then
                    intValIndex = j
                    page = Document.AddPage()
                    e = XGraphics.FromPdfPage(page)
                    intLineNumber = 0
                End If

                If j < wrappedCol1.Count Then
                    e.DrawString(wrappedCol1(j), labelFont, XBrushes.Black, leftMargin, currentY)
                End If
                If j < wrappedCol2.Count Then
                    e.DrawString(wrappedCol2(j), valueFont, XBrushes.Black, leftMargin + colWidths(0), currentY)
                End If

                currentY += lineHeight
                intLineNumber += 1

            Next

        Next

        intValIndex = labels.Count ' Mark as finished
        Return True
    End Function


    Private Function caseImage(ByRef e As XGraphics, photo As List(Of Image),
                                   leftMargin As Double, topMargin As Double, ByRef intLineNumber As Integer,
                                   lineHeight As Double, ByRef intPhotoIndex As Integer, page As PdfPage,
                               bottomMargin As Double, rightMargin As Double, Document As PdfDocument) As Boolean

        Dim availableWidth As Single = page.Width.Point - (leftMargin + rightMargin)
        Dim maxImageHeight As Integer = 180
        Dim spacing As Integer = 10

        ' Loop through the photos to print them
        For i As Integer = intPhotoIndex To photo.Count - 1
            Dim casePhoto = photo(i)

            Dim originalWidth = casePhoto.Width
            Dim originalHeight = casePhoto.Height

            ' Scale image to fit width, maintaining aspect ratio
            Dim scaleFactor As Single = Math.Min(availableWidth / originalWidth, maxImageHeight / originalHeight)
            Dim scaledWidth As Integer = CInt(originalWidth * scaleFactor)
            Dim scaledHeight As Integer = CInt(originalHeight * scaleFactor)

            Dim yPos As Integer = topMargin + intLineNumber * lineHeight

            ' Check if the image fits on the current page
            If yPos + scaledHeight > page.Height.Point - bottomMargin Then
                intPhotoIndex = i
                page = Document.AddPage()
                e = XGraphics.FromPdfPage(page)
                intLineNumber = 0 ' reset line  for new page
            End If

            ' Center the image horizontally within the margin bounds
            Dim xPos As Integer = leftMargin + (availableWidth - scaledWidth) \ 2

            Dim ms As New System.IO.MemoryStream()
            Using clonedPhoto As New Bitmap(casePhoto)
                clonedPhoto.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
            End Using
            ms.Position = 0 ' Reset memory stream position
            Dim xImage As XImage = XImage.FromStream(ms)
            e.DrawImage(xImage, xPos, yPos, scaledWidth, scaledHeight)

            intLineNumber += (scaledHeight \ lineHeight) + 1
        Next

        intPhotoIndex = photo.Count
        Return True
    End Function

End Module
