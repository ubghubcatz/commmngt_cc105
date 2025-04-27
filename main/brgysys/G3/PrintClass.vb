Imports System.Drawing.Printing
Imports System.Globalization

Public Class PrintClass

    Public Shared Property caseID As String

    Private Shared additionalInfo As String
    Private Shared additionalPhotos As List(Of Tuple(Of Image, String))
    Private Shared additionalProcedures As List(Of Tuple(Of String, String, String))
    Private Shared caseStatus As String
    Private Shared caseType As String
    Private Shared caseName As String
    Private Shared dateTimeReported As String
    Private Shared expectedDeadline As String
    Private Shared mainCaseImage As List(Of Image)
    Private Shared officers As List(Of Tuple(Of String, String, String))
    Private Shared peopleInvolved As List(Of Tuple(Of String, String, String))
    Private Shared printCaseId As String
    Private Shared reportOrigins As String
    Private Shared reporterEmail As String
    Private Shared reporterName As String
    Private Shared reporterNum As String
    Private Shared caseLocation As String
    Private Shared MissingPersonName As String
    Private Shared missingPersonAge As String
    Private Shared missingPersonBday As String
    Private Shared missingPersonPhysicalDesc As String
    Private Shared missingPersonLastSeenLoc As String
    Private Shared missingPersonHeight As String
    Private Shared missingPersonEmail As String
    Private Shared missingPersonNum As String
    Private Shared labels As List(Of String)
    Private Shared values As List(Of String)
    Private Shared stolenItems As List(Of Tuple(Of String, String, String))
    Private Shared propertyDamage As String
    Private Shared suspectDesc As String
    Private Shared theftLocation As String
    Private Shared whatHappened As String
    Private Shared eventLoc As String





    Public Shared Sub FindMatchingCase(caseID As String)
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


    Public Shared Sub GetSpecificCaseDetails(caseShow As CaseRecordShowForm)
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


    Private Shared Sub GetCaseData(caseShow As CaseRecordShowForm)
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




    Public Shared Sub RenderCasePage(
    e As Printing.PrintPageEventArgs,
    ByRef intStart As Integer,
    ByRef currentSection As Integer,
    ByRef intPhotoIndex As Integer,
    ByRef caseImageIndex As Integer,
    ByRef intValIndex As Integer,
    ByRef procedureCount As Integer,
    ByRef peopleCount As Integer,
    ByRef officerCount As Integer,
    numbers() As Integer
)
        Dim titleFont As New Font("Arial", 20, FontStyle.Bold)
        Dim labelFont As New Font("Arial", 12, FontStyle.Bold)
        Dim dataFont As New Font("Arial", 12, FontStyle.Regular)
        Dim leftMargin As Integer = e.MarginBounds.Left
        Dim topMargin As Integer = e.MarginBounds.Top
        Dim txtHeight As Integer = e.MarginBounds.Height
        Dim lineHeight As Single = dataFont.GetHeight(e.Graphics)
        Dim linesPerPage As Integer = CInt(txtHeight / lineHeight)
        Dim thickPen As New Pen(Color.Black, 3)
        Dim intLineNumber As Integer = 0

        Do While True
            Select Case currentSection
                Case 0
                    ' Title and general info
                    e.Graphics.DrawString("Case Report", titleFont, Brushes.Black, leftMargin, topMargin + (intLineNumber * lineHeight))
                    intLineNumber += 3

                    Dim lineY As Single = topMargin + (intLineNumber * lineHeight) - (lineHeight / 2)
                    e.Graphics.DrawLine(thickPen, leftMargin, lineY, e.MarginBounds.Right, lineY)
                    intLineNumber += 1

                    e.Graphics.DrawString("General Case Info:", labelFont, Brushes.Black, leftMargin, topMargin + (intLineNumber * lineHeight))
                    intLineNumber += 3

                    ' Case info fields...
                    e.Graphics.DrawString("Case ID:", labelFont, Brushes.Black, leftMargin, topMargin + (intLineNumber * lineHeight))
                    e.Graphics.DrawString(caseID, dataFont, Brushes.Black, leftMargin + 180, topMargin + (intLineNumber * lineHeight))
                    intLineNumber += 2

                    e.Graphics.DrawString("Case Name:", labelFont, Brushes.Black, leftMargin, topMargin + (intLineNumber * lineHeight))
                    e.Graphics.DrawString(caseName, dataFont, Brushes.Black, leftMargin + 180, topMargin + (intLineNumber * lineHeight))
                    intLineNumber += 2

                    e.Graphics.DrawString("Case Type:", labelFont, Brushes.Black, leftMargin, topMargin + (intLineNumber * lineHeight))
                    e.Graphics.DrawString(caseType, dataFont, Brushes.Black, leftMargin + 180, topMargin + (intLineNumber * lineHeight))
                    intLineNumber += 2

                    e.Graphics.DrawString("Case Status:", labelFont, Brushes.Black, leftMargin, topMargin + (intLineNumber * lineHeight))
                    e.Graphics.DrawString(caseStatus, dataFont, Brushes.Black, leftMargin + 180, topMargin + (intLineNumber * lineHeight))
                    intLineNumber += 2

                    e.Graphics.DrawString("Reported On:", labelFont, Brushes.Black, leftMargin, topMargin + (intLineNumber * lineHeight))
                    e.Graphics.DrawString(dateTimeReported, dataFont, Brushes.Black, leftMargin + 180, topMargin + (intLineNumber * lineHeight))
                    intLineNumber += 2

                    e.Graphics.DrawString("Case Deadline:", labelFont, Brushes.Black, leftMargin, topMargin + (intLineNumber * lineHeight))
                    e.Graphics.DrawString(expectedDeadline, dataFont, Brushes.Black, leftMargin + 180, topMargin + (intLineNumber * lineHeight))
                    intLineNumber += 2

                    e.Graphics.DrawString("Reported By:", labelFont, Brushes.Black, leftMargin, topMargin + (intLineNumber * lineHeight))
                    e.Graphics.DrawString(reporterName, dataFont, Brushes.Black, leftMargin + 180, topMargin + (intLineNumber * lineHeight))
                    intLineNumber += 2

                    e.Graphics.DrawString("Reported Contacts:", labelFont, Brushes.Black, leftMargin, topMargin + (intLineNumber * lineHeight))
                    e.Graphics.DrawString(reporterEmail + " | " + reporterNum, dataFont, Brushes.Black, leftMargin + 180, topMargin + (intLineNumber * lineHeight))
                    intLineNumber += 2

                    e.Graphics.DrawString("Origins:", labelFont, Brushes.Black, leftMargin, topMargin + (intLineNumber * lineHeight))
                    e.Graphics.DrawString(reportOrigins, dataFont, Brushes.Black, leftMargin + 180, topMargin + (intLineNumber * lineHeight))
                    intLineNumber += 2

                    lineY = topMargin + (intLineNumber * lineHeight) - (lineHeight / 2)
                    e.Graphics.DrawLine(thickPen, leftMargin, lineY, e.MarginBounds.Right, lineY)
                    intLineNumber += 1

                    currentSection = 1

                Case 1

                    If numbers(1) = 0 Then
                        e.Graphics.DrawString("Specific Case Info:", labelFont, Brushes.Black, leftMargin, topMargin + (intLineNumber * lineHeight))
                        intLineNumber += 2
                    End If

                    If caseType = "Theft" Then
                        Dim intStartStolenItems As Integer = 0
                        If Not PrintTable(e, "Stolen Items:", stolenItems, labelFont, dataFont, intLineNumber, intStartStolenItems, linesPerPage, leftMargin, topMargin,
                        "Item Name", "Item Description", "Item Value") Then
                            currentSection = 1
                            numbers(1) = 1
                            Exit Sub
                        End If
                        intLineNumber += 2

                        If Not PrintWrappedText(e, "Property Damage:", propertyDamage, labelFont, dataFont, intLineNumber, intStart, leftMargin, topMargin) Then
                            currentSection = 1
                            numbers(1) = 1
                            Exit Sub
                        End If
                        intLineNumber += 2

                        If Not PrintWrappedText(e, "Suspect Description:", suspectDesc, labelFont, dataFont, intLineNumber, intStart, leftMargin, topMargin) Then
                            currentSection = 1
                            numbers(1) = 1
                            Exit Sub
                        End If
                        intLineNumber += 2

                        If Not PrintWrappedText(e, "Theft Location:", caseLocation, labelFont, dataFont, intLineNumber, intStart, leftMargin, topMargin) Then
                            currentSection = 1
                            numbers(1) = 1
                            Exit Sub
                        End If
                        intLineNumber += 2

                        ' Logic for printing a case (within the PrintPage event)
                    ElseIf caseType = "Missing Person" Then
                        If Not caseImage(e, mainCaseImage, leftMargin, topMargin, intLineNumber, lineHeight, caseImageIndex) Then
                            currentSection = 1
                            numbers(1) = 1
                            Exit Sub
                        End If

                        intLineNumber += 2  ' Add space after the image

                        ' Now print the columns of data
                        If Not columnFix(e,
                         leftMargin,
                         topMargin,
                         intLineNumber, lineHeight, labelFont, dataFont,
                         labels, values, intValIndex) Then
                            currentSection = 1
                            numbers(1) = 1
                            Exit Sub
                        End If

                        If Not PrintWrappedText(e, "Victim Description:", missingPersonPhysicalDesc, labelFont, dataFont, intLineNumber, intStart, leftMargin, topMargin) Then
                            currentSection = 1
                            numbers(1) = 1
                            Exit Sub
                        End If
                    Else
                        If Not caseImage(e, mainCaseImage, leftMargin, topMargin, intLineNumber, lineHeight, caseImageIndex) Then
                            currentSection = 1
                            numbers(1) = 1
                            Exit Sub
                        End If

                        If Not PrintWrappedText(e, "Location:", caseLocation, labelFont, dataFont, intLineNumber, intStart, leftMargin, topMargin) Then
                            currentSection = 1
                            numbers(1) = 1
                            Exit Sub
                        End If
                        intLineNumber += 1

                        If Not PrintWrappedText(e, "Events Unfolded:", whatHappened, labelFont, dataFont, intLineNumber, intStart, leftMargin, topMargin) Then
                            currentSection = 1
                            numbers(1) = 1
                            Exit Sub
                        End If
                    End If
                    intLineNumber += 1
                    Dim lineY As Single = topMargin + (intLineNumber * lineHeight) - (lineHeight / 2)
                    e.Graphics.DrawLine(thickPen, leftMargin, lineY, e.MarginBounds.Right, lineY)
                    currentSection = 2

                Case 2
                    If Not PrintWrappedText(e, "Additional Info:", additionalInfo, labelFont, dataFont, intLineNumber, intStart, leftMargin, topMargin) Then
                        currentSection = 2
                        Exit Sub
                    End If
                    intLineNumber += 1
                    currentSection = 3

                Case 3
                    intLineNumber += 3
                    Dim lineY As Single = topMargin + (intLineNumber * lineHeight) - (lineHeight / 2)
                    e.Graphics.DrawLine(thickPen, leftMargin, lineY, e.MarginBounds.Right, lineY)

                    If Not PrintTable(e, "Procedures Taken:", additionalProcedures, labelFont, dataFont, intLineNumber, procedureCount, linesPerPage, leftMargin, topMargin,
                 "Procedures", "Remarks", "Date And Time") Then
                        currentSection = 3
                        Exit Sub
                    End If

                    currentSection = 4
                Case 4
                    intLineNumber += 2
                    Dim lineY As Single = topMargin + (intLineNumber * lineHeight) - (lineHeight / 2)
                    e.Graphics.DrawLine(thickPen, leftMargin, lineY, e.MarginBounds.Right, lineY)

                    If Not PrintTable(e, "People Involved in the Case:", peopleInvolved, labelFont, dataFont, intLineNumber, peopleCount, linesPerPage, leftMargin, topMargin,
            "Names", "Number", "Roles") Then
                        currentSection = 4
                        Exit Sub
                    End If

                    If Not PrintTable(e, "Officers Involved:", officers, labelFont, dataFont, intLineNumber, officerCount, linesPerPage, leftMargin, topMargin,
                "Officers", "ID", "Position") Then
                        currentSection = 4
                        Exit Sub
                    End If

                    intLineNumber += 2
                    lineY = topMargin + (intLineNumber * lineHeight) - (lineHeight / 2)
                    e.Graphics.DrawLine(thickPen, leftMargin, lineY, e.MarginBounds.Right, lineY)

                    currentSection = 5

                Case 5
                    e.Graphics.DrawString("Additional Photos:", labelFont, Brushes.Black, leftMargin, topMargin + (intLineNumber * lineHeight))
                    intLineNumber += 2
                    If Not PrintPhotos(e, additionalPhotos, labelFont, intPhotoIndex, leftMargin, topMargin, intLineNumber, lineHeight) Then
                        currentSection = 5
                        Exit Sub
                    End If
                    intLineNumber += 2

                    Dim lineY As Single = topMargin + (intLineNumber * lineHeight) - (lineHeight / 2)
                    e.Graphics.DrawLine(thickPen, leftMargin, lineY, e.MarginBounds.Right, lineY)
                    currentSection = 6

                Case 6
                    e.HasMorePages = False
                    Exit Sub
            End Select
        Loop
    End Sub

    Private Shared Function PrintWrappedText(e As PrintPageEventArgs, textTitle As String, text As String, titleFont As Font, font As Font,
                                  ByRef intLineNumber As Integer, ByRef intStart As Integer,
                                  leftMargin As Integer, topMargin As Integer) As Boolean

        Dim layoutWidth As Single = e.MarginBounds.Width
        Dim wrappedLines As New List(Of String)()
        Dim yPos As Single = topMargin + (font.GetHeight(e.Graphics) * intLineNumber)
        ' Split and wrap text
        Dim words() As String = text.Split(" "c)
        Dim currentLine As String = ""

        ' Wrap the text into lines
        For Each word In words
            Dim testLine As String = If(currentLine = "", word, currentLine & " " & word)
            Dim size As SizeF = e.Graphics.MeasureString(testLine, font)

            If size.Width > layoutWidth Then
                wrappedLines.Add(currentLine)
                currentLine = word
            Else
                currentLine = testLine
            End If
        Next
        If currentLine <> "" Then wrappedLines.Add(currentLine)

        ' Print the title only once for the section
        If intStart = 0 And yPos + (font.GetHeight(e.Graphics)) < e.MarginBounds.Bottom Then
            e.Graphics.DrawString(textTitle, New Font(font.FontFamily, font.Size, FontStyle.Bold), Brushes.Black,
                              leftMargin, topMargin + (font.GetHeight(e.Graphics) * intLineNumber))
            intLineNumber += 1
        End If

        ' Print wrapped lines starting from intStart
        For i As Integer = intStart To wrappedLines.Count - 1
            yPos = topMargin + (font.GetHeight(e.Graphics) * intLineNumber)

            ' Check if the line exceeds the page's margin, and if so, start a new page
            If yPos + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom Then
                intStart = i ' Continue from the current line
                e.HasMorePages = True
                Return False ' Not done yet
            End If

            e.Graphics.DrawString(wrappedLines(i), font, Brushes.Black, leftMargin, yPos)
            intLineNumber += 1
        Next

        ' Only reset intStart to 0 after all lines are printed
        Return True ' All lines printed
    End Function


    Private Shared Function PrintTable(e As PrintPageEventArgs, textTitle As String, tableData As List(Of Tuple(Of String, String, String)),
                        titleFont As Font, cellFont As Font, ByRef intLineNumber As Integer, ByRef intStartRow As Integer,
                        linesPerPage As Integer, leftMargin As Integer, topMargin As Integer, column1 As String, column2 As String, column3 As String) As Boolean

        Dim layoutWidth As Single = e.MarginBounds.Width
        Dim colWidths() As Single = {layoutWidth / 3, layoutWidth / 3, layoutWidth / 3}
        Dim lineHeight As Single = cellFont.GetHeight(e.Graphics)
        Dim maxVal As Integer
        Dim headerLinesNeeded As Integer = 3 ' 

        ' Check if enough space for title and headers
        If intStartRow = 0 Then
            If intLineNumber + headerLinesNeeded > linesPerPage Then
                e.HasMorePages = True
                Return False
            End If

            ' Title
            e.Graphics.DrawString(textTitle, titleFont, Brushes.Black, leftMargin, topMargin + (lineHeight * intLineNumber))
            intLineNumber += 2

            ' Column headers
            e.Graphics.DrawString(column1, titleFont, Brushes.Black, leftMargin, topMargin + (lineHeight * intLineNumber))
            e.Graphics.DrawString(column2, titleFont, Brushes.Black, leftMargin + colWidths(0), topMargin + (lineHeight * intLineNumber))
            e.Graphics.DrawString(column3, titleFont, Brushes.Black, leftMargin + colWidths(0) + colWidths(1), topMargin + (lineHeight * intLineNumber))
            intLineNumber += 1
            ' Draw separator line **AFTER** drawing text but BEFORE incrementing line
            Dim lineY As Single = topMargin + ((intLineNumber + 1) * lineHeight) - (lineHeight / 2)
            e.Graphics.DrawLine(Pens.Black, leftMargin, lineY, e.MarginBounds.Right, lineY)
            intLineNumber += 1

        End If

        ' Print each row
        For i As Integer = intStartRow To tableData.Count - 1
            Dim row = tableData(i)
            Dim col1 = row.Item1
            Dim col2 = row.Item2
            Dim col3 = row.Item3

            ' Measure and wrap text for each cell
            Dim wrappedCol1 = WrapText(col1, cellFont, colWidths(0), e.Graphics)
            Dim wrappedCol2 = WrapText(col2, cellFont, colWidths(1), e.Graphics)
            Dim wrappedCol3 = WrapText(col3, cellFont, colWidths(2), e.Graphics)

            ' Get max lines for the row
            Dim maxLines = Math.Max(wrappedCol1.Count, Math.Max(wrappedCol2.Count, wrappedCol3.Count))

            ' Check if page limit is reached (before drawing the row)
            If intLineNumber + maxLines > linesPerPage Then
                intStartRow = i
                e.HasMorePages = True
                Return False
            End If

            For j = 0 To maxLines - 1
                Dim yPos = topMargin + (lineHeight * intLineNumber)

                If j < wrappedCol1.Count Then
                    e.Graphics.DrawString(wrappedCol1(j), cellFont, Brushes.Black, leftMargin, yPos)
                End If
                If j < wrappedCol2.Count Then
                    e.Graphics.DrawString(wrappedCol2(j), cellFont, Brushes.Black, leftMargin + colWidths(0), yPos)
                End If
                If j < wrappedCol3.Count Then
                    e.Graphics.DrawString(wrappedCol3(j), cellFont, Brushes.Black, leftMargin + colWidths(0) + colWidths(1), yPos)
                End If

                maxVal = wrappedCol1.Count

                ' Now increment
                intLineNumber += 1
            Next
            ' Draw separator line **AFTER** drawing text but BEFORE incrementing line
            Dim lineY As Single = topMargin + ((intLineNumber + 1) * lineHeight) - (lineHeight / 2)
            e.Graphics.DrawLine(Pens.Black, leftMargin, lineY, e.MarginBounds.Right, lineY)
            intLineNumber += 1
        Next

        ' After table is done, draw final bottom line
        intLineNumber += 1
        intStartRow = maxVal
        Return True
    End Function



    Private Shared Function WrapText(text As String, font As Font, maxWidth As Single, g As Graphics) As List(Of String)
        Dim lines As New List(Of String)
        Dim words() As String = text.Split(" "c)
        Dim currentLine As String = ""

        For Each word In words
            Dim testLine As String = If(currentLine = "", word, currentLine & " " & word)
            Dim size As SizeF = g.MeasureString(testLine, font)
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

    Private Shared Function PrintPhotos(e As PrintPageEventArgs, photos As List(Of Tuple(Of Image, String)),
                             font As Font, ByRef intPhotoIndex As Integer,
                             leftMargin As Integer, topMargin As Integer, ByRef intLineNumber As Integer,
                             lineHeight As Integer) As Boolean

        Dim availableWidth As Integer = e.MarginBounds.Width
        Dim maxImageHeight As Integer = 160 ' Max display height
        Dim spacing As Integer = 10

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
            Dim captionHeight As Integer = CInt(e.Graphics.MeasureString(caption, font, availableWidth).Height)
            Dim totalHeight As Integer = scaledHeight + spacing + captionHeight

            ' Check if there's space on the page
            If yPos + totalHeight > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                intPhotoIndex = i
                Return False
            End If

            ' Center image horizontally if narrower than availableWidth
            Dim xPos As Integer = leftMargin

            ' Draw the image
            e.Graphics.DrawImage(photo, xPos, yPos, scaledWidth, scaledHeight)

            ' Draw the caption below the image
            yPos += scaledHeight + spacing
            e.Graphics.DrawString(caption, font, Brushes.Black, leftMargin, yPos)

            ' Advance the line number by estimated space used
            intLineNumber += (totalHeight \ lineHeight) + 1
        Next

        intPhotoIndex = photos.Count
        Return True
    End Function

    Private Shared Function columnFix(e As PrintPageEventArgs,
                                  leftMargin As Integer,
                                  topMargin As Integer,
                                  ByRef intLineNumber As Integer, ByRef lineHeight As Integer, labelFont As Font, valueFont As Font,
                                  labels As List(Of String), values As List(Of String), ByRef intValIndex As Integer) As Boolean

        Dim layoutWidth As Single = e.MarginBounds.Width
        Dim labelX As Single = leftMargin
        Dim valueX As Single = leftMargin + 190 ' adjust spacing between label and value
        Dim currentY As Single = topMargin + (lineHeight * intLineNumber)

        For i As Integer = intValIndex To labels.Count - 1
            ' Check if it fits on the page
            If currentY + lineHeight > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                intValIndex = i ' Store where we left off
                Return False
            End If

            ' Draw label and value
            e.Graphics.DrawString(labels(i), labelFont, Brushes.Black, labelX, currentY)
            e.Graphics.DrawString(values(i), valueFont, Brushes.Black, valueX, currentY)

            currentY += lineHeight
            intLineNumber += 1

        Next

        intValIndex = labels.Count ' Mark as finished
        Return True
    End Function


    Private Shared Function caseImage(e As PrintPageEventArgs, photo As List(Of Image),
                                   leftMargin As Integer, topMargin As Integer, ByRef intLineNumber As Integer,
                                   lineHeight As Integer, ByRef intPhotoIndex As Integer) As Boolean

        Dim availableWidth As Integer = e.MarginBounds.Width
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
            If yPos + scaledHeight > e.MarginBounds.Bottom Then
                e.HasMorePages = True  ' Set flag for more pages
                intPhotoIndex = i  ' Save the current photo index to continue on the next page
                Return False
            End If

            ' Center the image horizontally within the margin bounds
            Dim xPos As Integer = e.MarginBounds.Left + (availableWidth - scaledWidth) \ 2
            e.Graphics.DrawImage(casePhoto, xPos, yPos, scaledWidth, scaledHeight)

            intLineNumber += (scaledHeight \ lineHeight) + 1
        Next

        intPhotoIndex = photo.Count ' Mark as finished
        Return True
    End Function
End Class
