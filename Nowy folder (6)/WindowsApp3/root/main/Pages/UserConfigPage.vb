Public Class UserConfigPage
    Private Sub UserConfig_Load(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If MyBase.Visible Then
            FillPage()
        End If

    End Sub
    Public Sub FillPage()
        LoginInput1.Text = TempProfile.Login
        TittleInput1.Text = TempProfile.Title
        DepInput1.Text = TempProfile.Departament
        CompanyInput1.Text = TempProfile.Company
        EmailInput.Text = TempProfile.Email
        'PhoneInput.Text = TempProfile.SMSNumber
        LocationBox.Text = TempProfile.Location
        FillDataGrid()
    End Sub
    Private Sub SaveButton_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub FillDataGrid()
        UsersControl1.DataGridView1.Rows.Clear()
        Dim newUserList As List(Of UserProfile) = New List(Of UserProfile)
        newUserList = User.Search()
        For i As Integer = 0 To newUserList.Count - 1

            UsersControl1.DataGridView1.Rows.Add(newUserList.Item(i).Login, newUserList.Item(i).Password, newUserList.Item(i).AdminMode, newUserList.Item(i).OperatorMode)
        Next
    End Sub

    Private Sub AddNewUserLink_Click(sender As Object, e As EventArgs) Handles AddNewUserLink.Click
        unvisibleFunc()
    End Sub

    Private Sub UsersControl_Click(sender As Object, e As EventArgs) Handles UsersControl.Click
        unvisibleFunc()
        UsersControl1.Visible = True
    End Sub
    Function unvisibleFunc()
        AddNewUserLink.Visible = False
        UsersControl.Visible = False
        UsersControl1.Visible = False
    End Function
    Public Function visibleLinks()
        unvisibleFunc()
        AddNewUserLink.Visible = True
        UsersControl.Visible = True
    End Function

    Private Sub LoginInput_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub SaveButton_Click_1(sender As Object, e As EventArgs) Handles SaveButton.Click
        TempProfile.Email = EmailInput.Text
        TempProfile.Location = LocationBox.Text
        TempProfile.Save()

    End Sub
End Class
