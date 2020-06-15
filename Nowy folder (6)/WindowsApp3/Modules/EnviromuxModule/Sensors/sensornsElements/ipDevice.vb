Public Class ipDevice
    Private index As Integer = 0
    Public Sub New(input As Sensor)
        If input.Status = "" Then
            Exit Sub
        End If
        InitializeComponent()
        ' Добавить код инициализации после вызова InitializeComponent().

        Description.Text = input.Description
        IPaddress.Text = input.Address
        Status.Text = input.Status
        Value.Text = input.Value
        TimeOut.Text = input.Timeout
        Retries.Text = input.Retries
        index = Convert.ToInt16(input.index)
        AddToMonitoring.Checked = User.LoginnedProfile.Data.MB.SensorListForMB.IPDevicesList(index)
    End Sub
    Private Sub AddToMonitor_CheckedChanged(sender As Object, e As EventArgs) Handles AddToMonitoring.CheckedChanged
        If AddToMonitoring.Checked Then
            User.LoginnedProfile.Data.MB.SensorListForMB.IPDevicesList(index) = True
        Else
            User.LoginnedProfile.Data.MB.SensorListForMB.IPDevicesList(index) = False
        End If
    End Sub
End Class
