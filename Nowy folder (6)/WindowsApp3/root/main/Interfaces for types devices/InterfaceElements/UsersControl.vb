Public Class UsersControl
    Private Sub DataGrid_cellselect(sender As Object, e As EventArgs) Handles DataGridView1.CellClick

    End Sub
    Private Sub DataGrid_enter(sender As Object, e As EventArgs) Handles DataGridView1.RowEnter
        DeleteButton.Enabled = True
    End Sub

    Public Sub DataGridView1_CellContentClick(sender As Object, e As EventArgs) Handles DataGridView1.VisibleChanged, DataGridView1.CellContentClick

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Select Case MsgBox("Are you sure you want to delete the user?", MsgBoxStyle.YesNo, "")
            Case MsgBoxResult.Yes
                Dim UserName As String = DataGridView1.SelectedCells.Item(0).Value
                If UserName = TempProfile.Login Then
                    MsgBox("Unable to delete logged in user")
                    Exit Sub
                End If
                If DeleteUser(UserName) Then
                    My.Forms.Workspace.UserConfig1.FillDataGrid()
                End If
            Case MsgBoxResult.No
                Exit Sub
        End Select

    End Sub

    Private Function DeleteUser(Login As String)
        If DeleteUserProfile(Login) Then
            Workspace.Log1.SendMessagesFunction(New Message("Message", "", TempProfile.Login + " deleted user  (" + DataGridView1.SelectedCells.Item(0).Value + ") from the system"))
            DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows.Item(0).Index)
            Return True
        End If
        Return False
    End Function


    Private Sub UsersControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.RowHeadersVisible = False
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub AddUsrButton_Click(sender As Object, e As EventArgs) Handles AddUsrButton.Click
        My.Forms.UserEditForm.Dispose()
        UserEditForm.Visible = True
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
