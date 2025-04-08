Public Class MDIBrgySys

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Create a new instance of the child form.
        'Dim ChildForm As New System.Windows.Forms.Form
        '' Make it a child of this MDI form before showing it.
        'ChildForm.MdiParent = Me

        'm_ChildFormNumber += 1
        'ChildForm.Text = "Window " & m_ChildFormNumber

        'ChildForm.Show()
        '20250325
        'Attendance.MdiParent = Me
        'Attendance.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        'Dim OpenFileDialog As New OpenFileDialog
        'OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        'OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        'If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
        '    Dim FileName As String = OpenFileDialog.FileName
        '    ' TODO: Add code here to open the file.
        'End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub FileMenu_Click(sender As Object, e As EventArgs) Handles FileMenu.Click

    End Sub

    Private Sub MDIBrgySys_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Dim ChildForm As New System.Windows.Forms.Form
        '' Make it a child of this MDI form before showing it.
        'Attendance.MdiParent = Me

        ''m_ChildFormNumber += 1
        ''ChildForm.Text = "Window " & m_ChildFormNumber

        'Attendance.Show()
        ''For Each ChildForm As Form In Me.MdiChildren
        ''    Attendance.Show()
        ''    ' ChildForm.Close()
        ''Next

    End Sub

    Private Sub AttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendanceToolStripMenuItem.Click

        Dim da As New System.Data.OleDb.OleDbDataAdapter
        Dim ds As New DataSet
        'Dim li_DBUser As String
        'Dim li_DBPass As String
        Dim rs As ADODB.Recordset
        Dim gs_Conn As String
        Dim scr_desc As String
        Dim scr_ID As String = "EM0001"
        'rsData = New ADODB.Recordset

        'gs_Conn = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=ublipa_SQLLogin_1;Password=nktg6ikffl;Initial Catalog=commmngtcc105;Data Source=commngtcc105.mssql.somee.com;TrustServerCertificate=True" '"FILE NAME=" & App_Path() & "\RE.udl"
        'gs_Conn = "Provider=SQLOLEDB.1;workstation Id = commngtcc105.mssql.somee.com;packet size=4096;user id=ublipa_SQLLogin_1;pwd=nktg6ikffl;data source=commngtcc105.mssql.somee.com;persist security info=False;initial catalog=commngtcc105;TrustServerCertificate=True"
        'gs_Conn = "Provider = SQLOLEDB.1;Password=nktg6ikffl;Persist Security Info=True;User ID=ublipa_SQLLogin_1;Initial Catalog=commmngtcc105;Data Source=commngtcc105.mssql.somee.com"
        gs_Conn = "FILE NAME=" & App_Path() & "\RE.udl" '"Provider=SQLOLEDB.1;Password=nktg6ikffl;Persist Security Info=True;User ID=ublipa_SQLLogin_1;Initial Catalog=commngtcc105;Data Source=commngtcc105.mssql.somee.com"
        rs = New ADODB.Recordset
        With rs
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
            .CursorType = ADODB.CursorTypeEnum.adOpenStatic
            .LockType = ADODB.LockTypeEnum.adLockBatchOptimistic
            .Open("select userid,screenid,status,(select description from mn_screen x where x.screenID=a.screenID)scrdesc  from mn_AccessRight a where userid='" & gs_User & "' and screenid='" & scr_ID & "' and status='A'", gs_Conn)
            '.Close()
        End With

        rs.ActiveConnection = Nothing



        If rs.EOF Then





            MsgBox("No access right!")

        Else
            da.Fill(ds, rs, "mn_AccessRight")
            'li_DBUser = ds.Tables("Users").Rows(0).Item(0)
            scr_desc = ds.Tables("mn_AccessRight").Rows(0).Item(3)
            ''gs_User = li_DBUser
            ''gs_UserFN = ds.Tables("Users").Rows(0).Item(2)
            'If UCase(txtUser.Text) = UCase(li_DBUser) Or UCase(txtPassword.Text) = UCase(li_DBPass) Then
            'MsgBox("Success")
            'li_ctr = 0

            'MDIParent1.Show()

            '
            Attendance.Text = "[" + scr_ID + "]-" + scr_desc
            Attendance.Show()
            Me.Visible = False
            'Else
            '    'txtUser.Text = ""
            '    ' txtPassword.Text = ""
            '    'li_ctr = li_ctr + 1
            'End If

        End If


        Try
            'Do something.
            'Return 0
        Catch
            'Return Nothing
        End Try
        'MDIBrgySys.Show()


    End Sub

    Private Sub SchedulingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SchedulingToolStripMenuItem.Click

        Schedule.MdiParent = Me
        Schedule.Show()
    End Sub

    Private Sub CommandCenterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommandCenterToolStripMenuItem.Click
        g3CommandCenter_Form.Show()
    End Sub
End Class
