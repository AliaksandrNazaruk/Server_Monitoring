Module User
    Public TempProfile As UserProfile = New UserProfile(False, False, "TemporaryName", "TemporaryPassword")
    Public Function GetUser(Login As String) As UserProfile
        Dim UserList As List(Of UserProfile) = Search()
        For i As Integer = 0 To UserList.Count - 1
            If UserList.Item(i).Login = Login Then
                Return UserList.Item(i)
            End If
        Next
        Return Nothing
    End Function
    Public Function DeleteUserProfile(Login As String) As Boolean
        If GetUser(Login) IsNot Nothing Then
            System.IO.File.Delete(My.Application.Info.DirectoryPath + "\" + Login + "ProfileFile.txt")
            Return True
        Else
            Return True
        End If
        Return False
    End Function

    Public Function Search() As List(Of UserProfile)
        Dim fold As String = My.Application.Info.DirectoryPath
        Dim UserList As List(Of UserProfile) = New List(Of UserProfile)
        For i As Integer = 0 To System.IO.Directory.GetFiles(fold).Count - 1
            If System.IO.Directory.GetFiles(fold)(i).ToString.IndexOf("ProfileFile") >= 0 Then
                Dim RetUser As UserProfile = New UserProfile(False, False, "", "")
                RetUser.Load(System.IO.Directory.GetFiles(fold)(i).ToString)
                UserList.Add(RetUser)
            End If
        Next
        Return UserList
    End Function
End Module
