Public Class pwrSupply
    Private index As Integer = 0
    Public Sub New(input As Sensor)
        If input.Status = "" Then
            Exit Sub
        End If
        InitializeComponent()
        ' Добавить код инициализации после вызова InitializeComponent().

        index = Convert.ToInt16(input.index)
        'AddToMonitoring.Checked = Module2.MonitoringBase.SensorMap.OutRelayList(index)
    End Sub
    'Private Sub AddToMonitor_CheckedChanged(sender As Object, e As EventArgs) Handles AddToMonitoring.CheckedChanged
    'If AddToMonitoring.Checked Then
    'Module2.MonitoringBase.SensorMap.OutRelayList(index) = True
    'Else
    'Module2.MonitoringBase.SensorMap.OutRelayList(index) = False
    'End If
    'End Sub
End Class
