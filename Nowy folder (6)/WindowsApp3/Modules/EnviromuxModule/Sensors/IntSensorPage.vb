Public Class intSensorPage
    Public Function Start() As Boolean
        Dim count As Integer = Module2.MonitoringBase.dataFile.SensorData.IntSensorList.Count
        If count <= 0 Then
            Return False
        End If
        For i As Integer = 0 To count - 1
            If Module2.MonitoringBase.dataFile.SensorData.IntSensorList(i).Status = "1" Then
                FlowLayoutPanel1.Controls.Add(New IntSensorControlPanel(Module2.MonitoringBase.dataFile.SensorData.IntSensorList(i)))
            End If
        Next
        If FlowLayoutPanel1.Controls.Count = 0 Then
            Return False
        End If
        Return True
    End Function
End Class