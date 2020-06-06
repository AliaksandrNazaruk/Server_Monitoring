Public Class ipSensor

    Private Sub IpSensor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim buf As String = Me.Name
        buf = buf.Replace("IpSensor", "")
        GroupBox1.Text = "IP Sensor #" + buf
    End Sub

    Private Sub Description_TextChanged(sender As Object, e As EventArgs) Handles Description.TextChanged

    End Sub
End Class
