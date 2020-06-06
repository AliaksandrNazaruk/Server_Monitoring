'Imports MetroFramework.Components
'Imports MetroFramework.Forms
'Imports System.Windows.Forms

Public Class LoginForm
    Inherits MetroFramework.Forms.MetroForm
    '■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
    '■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
    Public UserPassword As String
    Public Userlogin As String
    Public workspaceClosed As Boolean = False
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        User.TempProfile.Login = LoginBox.Text
        User.TempProfile.Password = PassBox.Text
        Status.Visible = True
        LoginButton.Enabled = False
        If UserVerification(User.TempProfile.Login, User.TempProfile.Password) Then
            TempProfile = User.GetUser(User.TempProfile.Login)
            Workspace.Show()
            Workspace.Visible = False
            Workspace.Log1.SendMessagesFunction(New Message("Message", "", User.TempProfile.Login + " is logged in monitoring system"))
            Workspace.startingForms()
            Status.Visible = False
            LoginButton.Enabled = True
            Workspace.Visible = True
            Me.Visible = False
            Exit Sub
        End If
        MsgBox("Please check that the entered login is correct")
        LoginButton.Enabled = True
        Status.Visible = False
    End Sub

    Public Function UserVerification(Login As String, Password As String) As Boolean
        If User.GetUser(Login) IsNot Nothing Then
            If User.GetUser(Login).Password = Password Then
                Return True
            End If
        End If
        Return False
    End Function
    Private Sub ExitButtonUnMove__Click(sender As Object, e As EventArgs) Handles ExitButton.MouseLeave
        ExitButton.Image = EXIT1
    End Sub
    Private Sub ExitButtonMove__Click(sender As Object, e As EventArgs) Handles ExitButton.MouseEnter
        ExitButton.Image = ExitButtonMove1
    End Sub
    Private Sub ExitButtonInactive__Click(sender As Object, e As EventArgs) Handles Me.Deactivate
        ExitButton.Image = ExitButtonInActive
    End Sub
    Private Sub ExitButtonActive__Click(sender As Object, e As EventArgs) Handles Me.Activated
        ExitButton.Image = EXIT1
    End Sub
    Private Sub ExitButtonDown__Click(sender As Object, e As EventArgs) Handles ExitButton.MouseDown
        ExitButton.Image = ExitButtonClick
    End Sub
    Private Sub ExitButton__Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private mouseOffset As Point
    Private isMouseDown As Boolean = False
    '■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■remove window functions■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
    Private Sub PictureBox3__MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseDown
        Dim xOffset As Integer
        Dim yOffset As Integer
        If e.Button = MouseButtons.Left Then
            xOffset = -e.X - SystemInformation.FrameBorderSize.Width
            yOffset = -e.Y - SystemInformation.CaptionHeight -
           SystemInformation.FrameBorderSize.Height
            mouseOffset = New Point(xOffset, yOffset)
            isMouseDown = True
        End If
    End Sub
    Private Sub PictureBox3_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub
    Private Sub PictureBox3_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseUp
        If e.Button = MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If User.GetUser("Admin") Is Nothing Then
            CreateNewAdminUserProfile()
        End If
    End Sub

    Private Sub CreateNewAdminUserProfile()
        Dim NewAdminDataFile As String = EmailRes.NewAdmin
        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath + "\" + "Admin" + "ProfileFile.txt", NewAdminDataFile)
    End Sub
End Class