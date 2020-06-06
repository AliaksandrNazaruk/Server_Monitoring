Public Class loadingPage
    Private Sub LoadingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Function LoadingMode(input As Integer) As Boolean
        Workspace.LoadingPage1.ProgressBar1.Value = 0
        If input = 1 Then
            ProgressBar1.Visible = False
            TextMessage.Visible = False
            MetroProgressSpinner1.Visible = True
            SpinerLabel.Visible = True
            Return True
        End If
        If input = 2 Then
            ProgressBar1.Visible = True
            TextMessage.Visible = True
            MetroProgressSpinner1.Visible = False
            SpinerLabel.Visible = False
            Return True
        End If
        Return False
    End Function
End Class
