Option Explicit On
Imports System.Data
Imports System.Data.OleDb
Imports ADODB

Imports System.IO
Imports System.Configuration
Public Class Form1


    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click


        Dim da As New System.Data.OleDb.OleDbDataAdapter
        Dim ds As New DataSet
        Dim li_DBUser As String
        Dim li_DBPass As String
        Dim rs As ADODB.Recordset
        Dim gs_Conn As String
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
            .Open("select * from users where UserID='" & txtUser.Text & "' and Password2='" & txtPassword.Text & "'", gs_Conn)
            '.Close()
        End With

        rs.ActiveConnection = Nothing



        If rs.EOF Then

            '        If rs.EOF Then



            MsgBox("No existing user or Incorrect password")
            'txtUser.Text = ""
            'txtPassword.Text = ""
            'li_ctr = li_ctr + 1

            'If li_ctr = 3 Then
            '    MsgBox("You reached 3 attempts")
            '    End
            'End If
        Else
            da.Fill(ds, rs, "Users")
            li_DBUser = ds.Tables("Users").Rows(0).Item(0)
            li_DBPass = ds.Tables("Users").Rows(0).Item(2)
            'gs_User = li_DBUser
            'gs_UserFN = ds.Tables("Users").Rows(0).Item(2)
            If UCase(txtUser.Text) = UCase(li_DBUser) Or UCase(txtPassword.Text) = UCase(li_DBPass) Then
                'MsgBox("Success")
                'li_ctr = 0

                'MDIParent1.Show()

                '
                SplashScreen1.Show()
                Me.Visible = False
            Else
                'txtUser.Text = ""
                txtPassword.Text = ""
                'li_ctr = li_ctr + 1
            End If

        End If


        Try
            'Do something.
            'Return 0
        Catch
            'Return Nothing
        End Try
        'MDIBrgySys.Show()

    End Sub

End Class
