Public Class RemoteInputPanel
    Private index As Integer = 0
    Sub New(input As Sensor)
        InitializeComponent()
        ' Добавить код инициализации после вызова InitializeComponent().

        If input.Status = "0" Then
            GroupBox1.Enabled = False
        Else
            GroupBox1.Enabled = True
        End If
        Description.Text = input.Description
        Connector.Text = input.Connector
        Status.SelectedIndex = Convert.ToInt16(input.Status)

        NormValue.SelectedIndex = Convert.ToInt16(input.NormalValue)
        If input.Value = "1" Then
            value.Text = "Open"
        Else
            value.Text = "Closed"
        End If
        index = Convert.ToInt16(input.index)
        AddToMonitoring.Checked = User.LoginnedProfile.Data.MB.SensorListForMB.remoteInputsList(index)
    End Sub

    Private Sub AddToMonitor_CheckedChanged(sender As Object, e As EventArgs) Handles AddToMonitoring.CheckedChanged
        If AddToMonitoring.Checked Then
            User.LoginnedProfile.Data.MB.SensorListForMB.remoteInputsList(index) = True
        Else
            User.LoginnedProfile.Data.MB.SensorListForMB.remoteInputsList(index) = False
        End If
    End Sub
End Class
