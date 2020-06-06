Public Class aux2SensorPage
    Public Function Start() As Boolean
        Dim count As Integer = Module2.MonitoringBase.dataFile.SensorData.Aux2SensorList.Count
        If count <= 0 Then
            Return False
        End If
        For i As Integer = 0 To count - 1
            FlowLayoutPanel1.Controls.Add(New AuxSensorControlPanel(Module2.MonitoringBase.dataFile.SensorData.Aux2SensorList(i)))
        Next
        If FlowLayoutPanel1.Controls.Count = 0 Then
            Return False
        End If
        Return True
    End Function
End Class
