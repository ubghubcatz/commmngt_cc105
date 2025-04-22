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

        ' Tabbed pane 
        form.TabControl1.Height = form.Panel1.Height * 0.85
        form.TabControl1.Width = form.Panel1.Width
        form.TabControl1.Top = form.Panel1.Height * 0.15

        form.TabControl1.Left = (form.Panel1.Left - form.FlowLayoutPanel1.Width) * 0.05

        ' Side bar
        form.CaseRecords_Btn.Width = form.FlowLayoutPanel1.Width * 0.95
        form.CallLogging_Btn.Width = form.FlowLayoutPanel1.Width * 0.95
        form.OfficersAvailability_Btn.Width = form.FlowLayoutPanel1.Width * 0.95
        form.CaseRecords_Btn.Height = form.FlowLayoutPanel1.Width * 0.6
        form.CallLogging_Btn.Height = form.FlowLayoutPanel1.Width * 0.6
        form.ActiveCases_Btn.Height = form.CallLogging_Btn.Height
        form.ActiveCases_Btn.Width = form.CallLogging_Btn.Width
        form.OfficersAvailability_Btn.Height = form.FlowLayoutPanel1.Width * 0.6


    End Sub

    ' Resize the CaseRecordTable form
    Public Shared Sub ResizeCaseForm(form As g3CommandCenter_Form, cases As CaseRecordTable)
        form.MainPanel.Height = form.Panel1.Height * 0.85
        form.MainPanel.Width = form.Panel1.Width
        cases.Height = form.MainPanel.Height
        cases.Width = form.MainPanel.Width
        cases.AddCaseRecord_Btn.Left = cases.Width * 0.7
        cases.Panel1.Width = cases.Width

        Dim panelScreenLocation As Point = form.TabPage1.PointToScreen(Point.Empty)
        cases.Location = panelScreenLocation
    End Sub

    ' Resize the CallLog_Tables form
    Public Shared Sub ResizeCallForm(form As g3CommandCenter_Form, calls As CallLog_Tables)
        form.MainPanel.Height = form.Panel1.Height * 0.85
        form.MainPanel.Width = form.Panel1.Width
        calls.Height = form.MainPanel.Height
        calls.Width = form.MainPanel.Width
        calls.CallLog_Table.Height = form.MainPanel.Height * 0.7
        calls.CallLog_Table.Width = form.MainPanel.Width * 0.88
        calls.Panel1.Width = form.MainPanel.Width
        calls.AddCallLog_Btn.Left = form.MainPanel.Width * 0.7
        ' Reset the position of the Call Log form (top-left of Panel1)
        Dim panelScreenLocation As Point = form.TabPage1.PointToScreen(Point.Empty)
        calls.Location = panelScreenLocation
    End Sub

    ' Resize the OfficersAvailabiltyForm
    Public Shared Sub ResizeOfficersAvailabilityForm(form As g3CommandCenter_Form, officersAvailability As OfficersAvailabiltyForm)
        form.MainPanel.Height = form.Panel1.Height * 0.85
        form.MainPanel.Width = form.Panel1.Width
        officersAvailability.Height = form.MainPanel.Height
        officersAvailability.Width = form.MainPanel.Width
        officersAvailability.Panel1.Width = form.MainPanel.Width
        officersAvailability.OfficersCases_DataGridView.Height = form.MainPanel.Height * 0.55
        officersAvailability.OfficersCases_DataGridView.Width = form.MainPanel.Width * 0.88
        Dim panelScreenLocation As Point = form.TabPage1.PointToScreen(Point.Empty)
        officersAvailability.Location = panelScreenLocation
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
