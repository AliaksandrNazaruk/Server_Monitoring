Public Class DigitalSensor
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

    End Sub

    Private Sub AddToMonitor_CheckedChanged(sender As Object, e As EventArgs) Handles AddToMonitor.CheckedChanged
        If AddToMonitor.Checked Then

        End If
    End Sub
End Class
