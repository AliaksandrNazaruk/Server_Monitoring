Public Class PDUSensorsSetting
    Public Function TableEnable(TableType As String) As Boolean
        Clear()
        If TableType = "PDUTypeP3A6T1" Then
            Phase1Box.Enabled = True
            Phase2Box.Enabled = True
            Phase3Box.Enabled = True
            OtherSensorsBox.Enabled = True

            Ampermeter1Monitoring.Enabled = True
            Ampermeter2Monitoring.Enabled = True
            Ampermeter3Monitoring.Enabled = True
            Ampermeter4Monitoring.Enabled = True
            Ampermeter5Monitoring.Enabled = True
            Ampermeter6Monitoring.Enabled = True
            TemperatureMonitor.Enabled = True

            Ampermeter1Log.Enabled = True
            Ampermeter2Log.Enabled = True
            Ampermeter3Log.Enabled = True
            Ampermeter4Log.Enabled = True
            Ampermeter5Log.Enabled = True
            Ampermeter6Log.Enabled = True
            TemperatureLog.Enabled = True

            amp1.Enabled = True
            amp2.Enabled = True
            amp3.Enabled = True
            amp4.Enabled = True
            amp5.Enabled = True
            amp6.Enabled = True
            Temperature.Enabled = True
            Return True
        End If
        If TableType = "PDUTypeP3A6T0" Then
            Phase1Box.Enabled = True
            Phase2Box.Enabled = True
            Phase3Box.Enabled = True

            Ampermeter1Monitoring.Enabled = True
            Ampermeter2Monitoring.Enabled = True
            Ampermeter3Monitoring.Enabled = True
            Ampermeter4Monitoring.Enabled = True
            Ampermeter5Monitoring.Enabled = True
            Ampermeter6Monitoring.Enabled = True

            Ampermeter1Log.Enabled = True
            Ampermeter2Log.Enabled = True
            Ampermeter3Log.Enabled = True
            Ampermeter4Log.Enabled = True
            Ampermeter5Log.Enabled = True
            Ampermeter6Log.Enabled = True

            amp1.Enabled = True
            amp2.Enabled = True
            amp3.Enabled = True
            amp4.Enabled = True
            amp5.Enabled = True
            amp6.Enabled = True

            Return True
        End If
        If TableType = "PDUTypeP3A3T1" Then
            Phase1Box.Enabled = True
            Phase2Box.Enabled = True
            Phase3Box.Enabled = True
            OtherSensorsBox.Enabled = True

            Ampermeter1Monitoring.Enabled = True
            Ampermeter3Monitoring.Enabled = True
            Ampermeter5Monitoring.Enabled = True
            TemperatureMonitor.Enabled = True

            Ampermeter1Log.Enabled = True
            Ampermeter3Log.Enabled = True
            Ampermeter5Log.Enabled = True
            TemperatureLog.Enabled = True
            amp1.Enabled = True
            amp3.Enabled = True
            amp5.Enabled = True
            Temperature.Enabled = True
            Return True
        End If
        If TableType = "PDUTypeP3A3T0" Then
            Phase1Box.Enabled = True
            Phase2Box.Enabled = True
            Phase3Box.Enabled = True

            Ampermeter1Monitoring.Enabled = True
            Ampermeter3Monitoring.Enabled = True
            Ampermeter5Monitoring.Enabled = True

            Ampermeter1Log.Enabled = True
            Ampermeter3Log.Enabled = True
            Ampermeter5Log.Enabled = True
            amp1.Enabled = True
            amp3.Enabled = True
            amp5.Enabled = True
            Return True
        End If
        If TableType = "PDUTypeP1A2T1" Then
            Phase1Box.Enabled = True
            OtherSensorsBox.Enabled = True

            Ampermeter1Monitoring.Enabled = True
            Ampermeter2Monitoring.Enabled = True
            TemperatureMonitor.Enabled = True

            Ampermeter1Log.Enabled = True
            Ampermeter2Log.Enabled = True
            TemperatureLog.Enabled = True
            amp1.Enabled = True
            amp2.Enabled = True
            Temperature.Enabled = True
            Return True
        End If
        If TableType = "PDUTypeP1A2T0" Then
            Phase1Box.Enabled = True

            Ampermeter1Monitoring.Enabled = True
            Ampermeter2Monitoring.Enabled = True

            Ampermeter1Log.Enabled = True
            Ampermeter2Log.Enabled = True
            amp1.Enabled = True
            amp2.Enabled = True
            Return True
        End If
        If TableType = "PDUTypeP1A1T1" Then
            Phase1Box.Enabled = True
            OtherSensorsBox.Enabled = True

            Ampermeter1Monitoring.Enabled = True
            TemperatureMonitor.Enabled = True

            Ampermeter1Log.Enabled = True
            TemperatureLog.Enabled = True
            amp1.Enabled = True
            Temperature.Enabled = True
            Return True
        End If
        If TableType = "PDUTypeP1A1T0" Then
            Phase1Box.Enabled = True

            Ampermeter1Monitoring.Enabled = True

            Ampermeter1Log.Enabled = True
            amp1.Enabled = True
            Return True
        End If
        Return False
    End Function
    Public Sub Clear()
        amp1.Enabled = False
        amp2.Enabled = False
        amp3.Enabled = False
        amp4.Enabled = False
        amp5.Enabled = False
        amp6.Enabled = False
        Temperature.Enabled = False

        Phase1Box.Enabled = False
        Phase2Box.Enabled = False
        Phase3Box.Enabled = False
        OtherSensorsBox.Enabled = False

        Ampermeter1Monitoring.Enabled = False
        Ampermeter2Monitoring.Enabled = False
        Ampermeter3Monitoring.Enabled = False
        Ampermeter4Monitoring.Enabled = False
        Ampermeter5Monitoring.Enabled = False
        Ampermeter6Monitoring.Enabled = False
        TemperatureMonitor.Enabled = False

        Ampermeter1Log.Enabled = False
        Ampermeter2Log.Enabled = False
        Ampermeter3Log.Enabled = False
        Ampermeter4Log.Enabled = False
        Ampermeter5Log.Enabled = False
        Ampermeter6Log.Enabled = False
        TemperatureLog.Enabled = False

        OtherSensorsBox.Enabled = False

        Ampermeter1Monitoring.Checked = False
        Ampermeter2Monitoring.Checked = False
        Ampermeter3Monitoring.Checked = False
        Ampermeter4Monitoring.Checked = False
        Ampermeter5Monitoring.Checked = False
        Ampermeter6Monitoring.Checked = False
        TemperatureMonitor.Checked = False
        Ampermeter1Log.Checked = False
        Ampermeter2Log.Checked = False
        Ampermeter3Log.Checked = False
        Ampermeter4Log.Checked = False
        Ampermeter5Log.Checked = False
        Ampermeter6Log.Checked = False
        TemperatureLog.Checked = False
    End Sub
End Class
