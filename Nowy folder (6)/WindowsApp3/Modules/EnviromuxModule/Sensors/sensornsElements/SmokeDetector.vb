﻿
Public Class SmokeDetector
    Private index As Integer = 0
    Sub New(input As Sensor)
        If input.Status = "" Then
            Exit Sub
        End If
        InitializeComponent()
        ' Добавить код инициализации после вызова InitializeComponent().
        Description.Text = input.Description
        Status.SelectedIndex = Convert.ToInt16(input.Status)
        value.Text = input.Value
        index = Convert.ToInt16(input.index)
        AddToMonitoring.Checked = User.LoginnedProfile.Data.MB.SensorListForMB.smokeDetectorsList(index)
        If input.Status = "0" Then
            GroupBox1.Enabled = False
        Else
            GroupBox1.Enabled = True
        End If
    End Sub
    Private Sub AddToMonitor_CheckedChanged(sender As Object, e As EventArgs) Handles AddToMonitoring.CheckedChanged
        If AddToMonitoring.Checked Then
            User.LoginnedProfile.Data.MB.SensorListForMB.smokeDetectorsList(index) = True
        Else
            User.LoginnedProfile.Data.MB.SensorListForMB.smokeDetectorsList(index) = False
        End If
    End Sub
End Class
