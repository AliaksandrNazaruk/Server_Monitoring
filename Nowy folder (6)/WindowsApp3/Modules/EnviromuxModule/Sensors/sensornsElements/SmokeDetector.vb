Public Class SmokeDetector
    Sub New(input As Sensor)
        InitializeComponent()
        ' Добавить код инициализации после вызова InitializeComponent().
        Description.Text = input.Description
        Status.SelectedIndex = Convert.ToInt16(input.Status)
        value.Text = input.Value
    End Sub
End Class
