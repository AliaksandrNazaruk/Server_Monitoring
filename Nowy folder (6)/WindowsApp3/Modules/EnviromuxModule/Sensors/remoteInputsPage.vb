Public Class remoteInputsPage
    Public Function Start() As Boolean
        Dim count As Integer = Module2.MonitoringBase.dataFile.SensorData.remoteInputsList.Count
        If count <= 0 Then
            Return False
        End If
        For i As Integer = 0 To count - 1
            FlowLayoutPanel1.Controls.Add(New RemoteInputPanel(Module2.MonitoringBase.dataFile.SensorData.remoteInputsList(i)))
        Next
        If FlowLayoutPanel1.Controls.Count = 0 Then
            Return False
        End If
        Return True
    End Function

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class
