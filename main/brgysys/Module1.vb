Module Module1
    Public gs_User As String
    Public Function App_Path() As String
        App_Path = New System.IO.FileInfo(Application.ExecutablePath).DirectoryName
    End Function

End Module
