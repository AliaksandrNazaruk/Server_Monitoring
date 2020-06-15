Public Class outRelay
    Private index As Integer = 0
    Public Sub New(input As Sensor)
        If input.Status = "" Then
            Exit Sub
        End If
        InitializeComponent()
        ' Добавить код инициализации после вызова InitializeComponent().

        Description.Text = input.Description
        If input.Status = "1" Then
            Status.Text = "Inactive"
        Else
            Status.Text = "Active"
        End If
        index = Convert.ToInt16(input.index)
        AddToMonitoring.Checked = User.LoginnedProfile.Data.MB.SensorListForMB.OutRelayList(index)
    End Sub
    Private Sub AddToMonitor_CheckedChanged(sender As Object, e As EventArgs) Handles AddToMonitoring.CheckedChanged
        If AddToMonitoring.Checked Then
            User.LoginnedProfile.Data.MB.SensorListForMB.OutRelayList(index) = True
        Else
            User.LoginnedProfile.Data.MB.SensorListForMB.OutRelayList(index) = False
        End If
    End Sub
End Class
