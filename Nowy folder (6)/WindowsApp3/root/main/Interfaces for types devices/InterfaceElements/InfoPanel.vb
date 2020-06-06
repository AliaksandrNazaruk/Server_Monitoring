Public Class InfoPanel
    Private Sub LabLogout_MouseEnter(sender As Object, e As EventArgs) Handles labLogout.MouseEnter
        labLogout.ForeColor = Color.Red
    End Sub

    Private Sub LabLogout_MouseLeave(sender As Object, e As EventArgs) Handles labLogout.MouseLeave
        labLogout.ForeColor = Color.White
    End Sub

    Private Sub LabLogout_Click(sender As Object, e As EventArgs) Handles labLogout.Click

        Workspace.Close()
    End Sub


End Class
