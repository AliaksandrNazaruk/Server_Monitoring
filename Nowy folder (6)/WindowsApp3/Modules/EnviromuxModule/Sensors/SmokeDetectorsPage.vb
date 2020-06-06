Public Class SmokeDetectorsPage
    Public Function Start() As Boolean
        Dim count As Integer = Module2.MonitoringBase.dataFile.SensorData.smokeDetectorsList.Count
        If count <= 0 Then
            Return False
        End If
        For i As Integer = 0 To count - 1
            FlowLayoutPanel1.Controls.Add(New SmokeDetector(Module2.MonitoringBase.dataFile.SensorData.smokeDetectorsList(i)))
        Next
        If FlowLayoutPanel1.Controls.Count = 0 Then
            Return False
        End If
        Return True
    End Function
End Class
