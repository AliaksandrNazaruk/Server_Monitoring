Public Class IntSensorControlPanel
    Public Sub New(input As Sensor)
        InitializeComponent()
        ' Добавить код инициализации после вызова InitializeComponent().
        SensorName.Text = input.Description
        Dim maxScaleValue As Integer = 12
        Scale1.setScaleValue(maxScaleValue, input.UnitName)
        Dim value As Double = Convert.ToInt16(input.Value) / (maxScaleValue * 10 / 100)
        Scale1.SetCursor(value)
        Dim minCritTrech As Integer = Convert.ToInt16(input.MinTreshold) / (maxScaleValue * 10 / 100)
        Dim minWarnTrech As Integer = Convert.ToInt16(input.MinWarnTreshold) / (maxScaleValue * 10 / 100)
        Dim MaxWarntTrech As Integer = Convert.ToInt16(input.MaxWarnTreshold) / (maxScaleValue * 10 / 100)
        Dim MaxCritTrech As Integer = Convert.ToInt16(input.MaxTreshold) / (maxScaleValue * 10 / 100)
        Scale1.setAlarm1(minCritTrech)
        Scale1.setWarn1(minWarnTrech)
        Scale1.setNormal(MaxWarntTrech)
        Scale1.setWarn2(MaxCritTrech)
        Status.SelectedIndex = input.Status
        If input.Type = "3" Then
            Type.Text = "Voltage"
        End If
        If input.Type = "0" Then
            Type.Text = "Not Configured"
        End If
    End Sub

    Private Sub Scale1_Load(sender As Object, e As EventArgs) Handles Scale1.Load
    End Sub


End Class
