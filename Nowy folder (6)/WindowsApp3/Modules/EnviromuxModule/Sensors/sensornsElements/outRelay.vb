Public Class outRelay
    Public Sub New(input As Sensor)
        InitializeComponent()
        ' Добавить код инициализации после вызова InitializeComponent().

        Description.Text = input.Description
        If input.Status = "1" Then
            Status.Text = "Inactive"
        Else
            Status.Text = "Active"
        End If
    End Sub

    Private Sub Status_TextChanged(sender As Object, e As EventArgs) Handles Status.TextChanged

    End Sub
End Class
