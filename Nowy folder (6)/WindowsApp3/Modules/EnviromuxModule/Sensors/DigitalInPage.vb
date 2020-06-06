Public Class DigitalInPage
    Public Function Start() As Boolean
        Dim count As Integer = Module2.MonitoringBase.dataFile.SensorData.DigInputList.Count
        If count <= 0 Then
            Return False
        End If
        For i As Integer = 0 To count - 1
            FlowLayoutPanel1.Controls.Add(New DigitalSensor(Module2.MonitoringBase.dataFile.SensorData.DigInputList(i)))
        Next
        Return True
    End Function

End Class
