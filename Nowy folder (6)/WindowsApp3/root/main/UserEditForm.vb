Public Class UserEditForm

    Private newUser As UserProfile = New UserProfile(False, False, "", "")

    Private Sub AddNewUserButton_Click(sender As Object, e As EventArgs) Handles AddNewUserButton.Click

        If AddNewUser() Then
            My.Forms.Workspace.UserConfig1.FillDataGrid()
            MsgBox("User added")
        Else
            MsgBox("A user with the same name already exists. Try changing the name")
        End If
    End Sub
    Private Function AddNewUser() As Boolean
        newUser.AdminMode = AddNewUserPanel1.adminChecker.Checked
        newUser.OperatorMode = AddNewUserPanel1.OperatorChecker.Checked
        newUser.Title = AddNewUserPanel1.TittleInput.Text
        newUser.SMSNumber = AddNewUserPanel1.PhoneInput.Text
        newUser.Password = AddNewUserPanel1.PassInput.Text
        newUser.Login = AddNewUserPanel1.LoginInput.Text
        newUser.Email = AddNewUserPanel1.EmailInput.Text
        newUser.Departament = AddNewUserPanel1.DepInput.Text
        newUser.Password = AddNewUserPanel1.ConfPassInput.Text
        newUser.Company = AddNewUserPanel1.CompanyInput.Text
        newUser.Location = AddNewUserPanel1.LocationInput.Text
        If User.GetUser(newUser.Login) Is Nothing Then
            newUser.SaveProfileToFile()
            Workspace.Log1.SendMessagesFunction(New Message("Message", "", TempProfile.Login + " added a new user (" + newUser.Login + ") to the system"))
            Return True
        End If
        Return False
    End Function
    Public Function checkSyntax(Input As String) As Boolean
        Dim CorrectSymbols(86) As String
        Dim AsciiNum As Integer = 0
        For i As Integer = 0 To 86
            If AsciiNum < 32 Then
                AsciiNum = 32
            End If
            If AsciiNum = 91 Then
                AsciiNum = 96
            End If
            If AsciiNum = 123 Then
                Exit For
            End If
            Dim NewChar As Char = Chr(AsciiNum)
            CorrectSymbols(i) = NewChar
            AsciiNum = AsciiNum + 1
        Next
        For i As Integer = 0 To Input.Length - 1
            For j As Integer = 0 To 86
                If CorrectSymbols(j) Is Nothing Then
                    Return False
                End If
                If Input(i) = CorrectSymbols(j) Then
                    Exit For
                End If
            Next
        Next
        Return True
    End Function
    Private Sub UserEditForms_close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Me.Dispose()
    End Sub
End Class