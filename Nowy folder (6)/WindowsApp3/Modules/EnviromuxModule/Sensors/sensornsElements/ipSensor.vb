Public Class ipSensor
    Private index As Integer = 0
    Private Sub IpSensor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim buf As String = Me.Name
        buf = buf.Replace("IpSensor", "")
        GroupBox1.Text = "IP Sensor #" + buf
        'Index = Convert.ToInt16(Input.index)
        'AddToMonitoring.Checked = Module2.MonitoringBase.SensorMap.DigInputList(Index)
    End Sub
    Sub New(input As Sensor)
        If input.Status = "" Then
            Exit Sub
        End If
        InitializeComponent()
        ' Добавить код инициализации после вызова InitializeComponent().

        If input.Status = "0" Then
            GroupBox1.Enabled = False
        Else
            GroupBox1.Enabled = True
        End If
        Description.Text = input.Description
        Connector.Text = input.Connector
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
