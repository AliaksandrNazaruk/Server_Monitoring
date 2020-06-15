Public Class SensorControlPanelType1
    Private index As Integer = 0
    Public Sub New(input As Sensor)
        If input.Status = "" Then
            Exit Sub
        End If
        If input.index = "" Then
            Exit Sub
        End If
        InitializeComponent()
        ' Добавить код инициализации после вызова InitializeComponent().
        GroupBox.Text = input.Description
        Dim maxScaleValue As Integer = 12
        Scale1.setScaleValue(maxScaleValue, input.UnitName)
        Dim value As Integer = Convert.ToInt16(input.Value) / (maxScaleValue * 10 / 100)
        Scale1.SetCursor(value)
        Dim minCritTrech As Integer = Convert.ToInt16(input.MinTreshold) / (maxScaleValue * 10 / 100)
        Dim minWarnTrech As Integer = Convert.ToInt16(input.MinWarnTreshold) / (maxScaleValue * 10 / 100)
        Dim MaxWarntTrech As Integer = Convert.ToInt16(input.MaxWarnTreshold) / (maxScaleValue * 10 / 100)
        Dim MaxCritTrech As Integer = Convert.ToInt16(input.MaxTreshold) / (maxScaleValue * 10 / 100)
        Scale1.setAlarm1(minCritTrech)
        Scale1.setWarn1(minWarnTrech)
        Scale1.setNormal(MaxWarntTrech)
        Scale1.setWarn2(MaxCritTrech)
        index = Convert.ToInt16(input.index)
        AddToMonitoring.Checked = User.LoginnedProfile.Data.MB.SensorListForMB.ipSensorList(index)
    End Sub
    Private Sub AddToMonitor_CheckedChanged(sender As Object, e As EventArgs) Handles AddToMonitoring.CheckedChanged
        If AddToMonitoring.Checked Then
            User.LoginnedProfile.Data.MB.SensorListForMB.ipSensorList(index) = True
        Else
            User.LoginnedProfile.Data.MB.SensorListForMB.ipSensorList(index) = False
        End If
    End Sub


End Class
