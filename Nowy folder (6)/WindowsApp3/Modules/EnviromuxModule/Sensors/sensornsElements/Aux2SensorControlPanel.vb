Public Class Aux2SensorControlPanel
    Private index As Integer = 0
    Public Sub New(input As Sensor)
        InitializeComponent()
        ' Добавить код инициализации после вызова InitializeComponent().

        SensorName.Text = input.Description
        Dim maxScaleValue As Integer = 100
        Scale1.setScaleValue(maxScaleValue, input.UnitName)
        Dim value As Double = Convert.ToInt16(input.Value) / (maxScaleValue / 100)
        Scale1.SetCursor(value)
        Dim minCritTrech As Integer = Convert.ToInt16(input.MinTreshold) / (maxScaleValue / 100)
        Dim minWarnTrech As Integer = Convert.ToInt16(input.MinWarnTreshold) / (maxScaleValue / 100)
        Dim MaxWarntTrech As Integer = Convert.ToInt16(input.MaxWarnTreshold) / (maxScaleValue / 100)
        Dim MaxCritTrech As Integer = Convert.ToInt16(input.MaxTreshold) / (maxScaleValue / 100)
        Scale1.setAlarm1(minCritTrech)
        Scale1.setWarn1(minWarnTrech)
        Scale1.setNormal(MaxWarntTrech)
        Scale1.setWarn2(MaxCritTrech)
        Status.SelectedIndex = input.Status
        Connector.Text = input.Connector
        If input.Type = "3" Then
            Type.Text = "Voltage"
        End If
        If input.Type = "0" Then
            Type.Text = "Not Configured"
            Scale1.setMode("Read")
        End If
        index = Convert.ToInt16(input.index)
        AddToMonitoring.Checked = User.LoginnedProfile.Data.MB.SensorListForMB.Aux2SensorList(index)
        If input.Status = "0" Then
            SensorName.Enabled = False
        Else
            SensorName.Enabled = True
        End If
    End Sub
    Private Sub AddToMonitoring_CheckedChanged(sender As Object, e As EventArgs) Handles AddToMonitoring.CheckedChanged
        If AddToMonitoring.Checked Then
            User.LoginnedProfile.Data.MB.SensorListForMB.Aux2SensorList(index) = True
        Else
            User.LoginnedProfile.Data.MB.SensorListForMB.Aux2SensorList(index) = False
        End If
    End Sub
End Class
