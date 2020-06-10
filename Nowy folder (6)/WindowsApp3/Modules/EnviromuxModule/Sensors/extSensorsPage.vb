Public Class extSensorsPage
    Public Function Start() As Boolean
        Dim count As Integer = Module2.MonitoringBase.dataFile.SensorData.ExtSensorList.Count
        If count <= 0 Then
            Return False
        End If
        For i As Integer = 0 To count - 1
            FlowLayoutPanel1.Controls.Add(New ExtSensorPanel(Module2.MonitoringBase.dataFile.SensorData.ExtSensorList(i)))
        Next
        If FlowLayoutPanel1.Controls.Count = 0 Then
            Return False
        End If
        Return True
    End Function
End Class
