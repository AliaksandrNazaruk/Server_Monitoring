Public Class IntSensorControlPanel
    Private index As Integer = 0
    Public Sub New(input As Sensor)
        If input.Status = "" Then
            Exit Sub
        End If
        InitializeComponent()
        If input.Status = "0" Then
            SensorName.Enabled = False
        Else
            SensorName.Enabled = True
        End If
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

        index = Convert.ToInt16(input.index)
        AddToMonitoring.Checked = User.LoginnedProfile.Data.MB.SensorListForMB.IntSensorList(index)
    End Sub
    Private Sub AddToMonitor_CheckedChanged(sender As Object, e As EventArgs) Handles AddToMonitoring.CheckedChanged
        If AddToMonitoring.Checked Then
            User.LoginnedProfile.Data.MB.SensorListForMB.IntSensorList(index) = True
        Else
            User.LoginnedProfile.Data.MB.SensorListForMB.IntSensorList(index) = False
        End If
    End Sub
End Class
