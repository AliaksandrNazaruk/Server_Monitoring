Public Class ipDevice
    Public Sub New(input As Sensor)
        InitializeComponent()
        ' Добавить код инициализации после вызова InitializeComponent().

        Description.Text = input.Description
        IPaddress.Text = input.Address
        Status.Text = input.Status
        Value.Text = input.Value
        TimeOut.Text = input.Timeout
        Retries.Text = input.Retries
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub
End Class
