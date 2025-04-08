Public Class LayoutManager
    Public Shared Sub ResizeFormLayout(form As g3CommandCenter_Form)

        ' Ensure FlowLayoutPanel1 remains full width
        form.FlowLayoutPanel1.Width = form.ClientSize.Width * 0.15
        form.FlowLayoutPanel1.Height = form.ClientSize.Height

        ' Adjust Panel1 to match form size
        form.Panel1.Width = form.ClientSize.Width - form.FlowLayoutPanel1.Width
        form.Panel1.Height = form.ClientSize.Height
        form.Panel1.Left = form.FlowLayoutPanel1.Width
        form.ActiveCases_DataGridView.Width = form.Panel1.Width * 0.95
        form.ActiveCases_DataGridView.Height = form.Panel1.Height * 0.7
        form.MainPanel.Height = form.Panel1.Height * 0.85
        form.MainPanel.Width = form.Panel1.Width
        ' Adjust all other elements when fullscreen
        form.TableLayoutPanel1.Width = form.FlowLayoutPanel1.Width
        form.TableLayoutPanel1.Height = form.FlowLayoutPanel1.Height
        form.TableLayoutPanel2.Width = form.TableLayoutPanel1.Width
        form.TableLayoutPanel2.Height = form.TableLayoutPanel1.Width * 1.3
        form.PictureBox1.Width = form.TableLayoutPanel2.Width * 0.5
        form.PictureBox1.Height = form.TableLayoutPanel2.Width * 0.5
        form.PictureBox2.Width = form.TableLayoutPanel2.Width * 0.5
        form.PictureBox2.Height = form.TableLayoutPanel2.Width * 0.5
        ' Tabbed pane 
        form.TabControl1.Height = form.Panel1.Height * 0.85
        form.TabControl1.Width = form.Panel1.Width
        form.TabControl1.Top = form.Panel1.Height * 0.15
        form.Label2.Left = form.TabControl1.Width * 0.75
        form.TabControl1.Left = (form.Panel1.Left - form.FlowLayoutPanel1.Width) * 0.05
        form.Label1.Top = form.Panel1.Height * 0.04

        AdjustFontSize(form.Label1)

        ' Side bar
        form.CaseRecords_Btn.Width = form.FlowLayoutPanel1.Width * 0.95
        form.CallLogging_Btn.Width = form.FlowLayoutPanel1.Width * 0.95
        form.OfficersAvailability_Btn.Width = form.FlowLayoutPanel1.Width * 0.95
        form.CaseRecords_Btn.Height = form.FlowLayoutPanel1.Width * 0.6
        form.CallLogging_Btn.Height = form.FlowLayoutPanel1.Width * 0.6
        form.OfficersAvailability_Btn.Height = form.FlowLayoutPanel1.Width * 0.6
    End Sub


    Private Shared Sub AdjustFontSize(ByVal label As Label)
        Dim g As Graphics = label.CreateGraphics()
        Dim fontSize As Single = 12 ' Default starting size
        Dim maxWidth As Integer = label.Width
        Dim maxHeight As Integer = label.Height

        Do
            Dim testFont As New Font(label.Font.FontFamily, fontSize, label.Font.Style)
            Dim size As SizeF = g.MeasureString(label.Text, testFont)

            If size.Width > maxWidth OrElse size.Height > maxHeight Then
                Exit Do
            End If

            fontSize += 4
        Loop

        label.Font = New Font(label.Font.FontFamily, fontSize - 1, label.Font.Style)
        g.Dispose()
    End Sub
    Public Shared Sub ResizeImageViewerForm(viewer As ImageViewer)
        viewer.Image_Panel.Left = viewer.Width * 0.13
        viewer.Image_Panel.Top = viewer.Height * 0.07
        viewer.desc_Label.Top = (viewer.Image_Panel.Top + viewer.Image_Panel.Height)
        viewer.Fromwhere_Label.Top = viewer.Height * 0.02
        viewer.Fromwhere_Label.Left = viewer.Image_Panel.Left
        viewer.desc_Label.Left = viewer.Fromwhere_Label.Left
    End Sub
End Class
