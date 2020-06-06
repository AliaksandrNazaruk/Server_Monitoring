Public Class Sensors_Form
    Inherits Form
    Private Sub Sensor_forms_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        fullResset()
    End Sub
    Private Sub fullResset()
        DigitalInPage1.Visible = False
        TacSensorPage1.Visible = False
        Aux2SensorPage1.Visible = False
        AuxSensorsPage1.Visible = False
        ExtSensorsPage1.Visible = False
        IpDeviceListPage1.Visible = False
        IpSensorsListPage1.Visible = False
        RemoteInputsPage1.Visible = False
        RemoteRelayPage1.Visible = False
        SmokeDetectorsPage1.Visible = False
        IntSensorPage1.Visible = False
        OutRelayPage1.Visible = False
    End Sub

    Public Sub start(input As String)
        Me.HorizontalScroll.Enabled = False
        fullResset()
        Select Case input
            Case "DigitalIn"
                If DigitalInPage1.Start() Then
                    DigitalInPage1.Visible = True
                    Me.Visible = True
                    Exit Sub
                Else
                    DigitalInPage1.Visible = False
                    Me.Visible = False
                    MyBase.Close()

                End If
            Case "TacSensor"
                If TacSensorPage1.Start() Then
                    TacSensorPage1.Visible = True
                    Me.Visible = True
                    Exit Sub
                Else
                    TacSensorPage1.Visible = False
                    Me.Visible = False
                    MyBase.Close()
                End If
            Case "IPSensors"
                If IpSensorsListPage1.Start() Then
                    IpSensorsListPage1.Visible = True
                    Me.Visible = True
                    Exit Sub
                Else
                    IpSensorsListPage1.Visible = False
                    Me.Visible = False
                    MyBase.Close()
                End If
            Case "Aux2Sensor"
                If Aux2SensorPage1.Start() Then
                    Aux2SensorPage1.Visible = True
                    Me.Visible = True
                    Exit Sub
                Else
                    Aux2SensorPage1.Visible = False
                    Me.Visible = False
                    MyBase.Close()
                End If
            Case "AuxSensors"
                If AuxSensorsPage1.Start() Then
                    AuxSensorsPage1.Visible = True
                    Me.Visible = True
                    Exit Sub
                Else
                    AuxSensorsPage1.Visible = False
                    Me.Visible = False
                    MyBase.Close()
                End If
            Case "ExtSensors"
                If ExtSensorsPage1.Start() Then
                    ExtSensorsPage1.Visible = True
                    Me.Visible = True
                    Exit Sub
                Else
                    ExtSensorsPage1.Visible = False
                    Me.Visible = False
                    MyBase.Close()
                End If
            Case "IPDevices"
                If IpDeviceListPage1.Start() Then
                    IpDeviceListPage1.Visible = True
                    Me.Visible = True
                    Exit Sub
                Else
                    IpDeviceListPage1.Visible = False
                    Me.Visible = False
                    MyBase.Close()
                End If
            Case "IpSensors"
                If IpSensorsListPage1.Start() Then
                    IpSensorsListPage1.Visible = True
                    Me.Visible = True
                    Exit Sub
                Else
                    AuxSensorsPage1.Visible = False
                    Me.Visible = False
                    MyBase.Close()
                End If
            Case "RemoteInput"
                If RemoteInputsPage1.Start() Then
                    RemoteInputsPage1.Visible = True
                    Me.Visible = True
                    Exit Sub
                Else
                    RemoteInputsPage1.Visible = False
                    Me.Visible = False
                    MyBase.Close()
                End If
            Case "RemoteRelay"
                If RemoteRelayPage1.Start() Then
                    RemoteRelayPage1.Visible = True
                    Me.Visible = True
                    Exit Sub
                Else
                    RemoteRelayPage1.Visible = False
                    Me.Visible = False
                    MyBase.Close()
                End If
            Case "IntSensor"
                If IntSensorPage1.Start() Then
                    IntSensorPage1.Visible = True
                    Me.Visible = True
                    Exit Sub
                Else
                    IntSensorPage1.Visible = False
                    Me.Visible = False
                    MyBase.Close()
                End If
            Case "OutRelays"
                If OutRelayPage1.Start() Then
                    OutRelayPage1.Visible = True
                    Me.Visible = True
                    Exit Sub
                Else
                    OutRelayPage1.Visible = False
                    Me.Visible = False
                    MyBase.Close()
                End If
            Case "SmokeDetector"
                If SmokeDetectorsPage1.Start() Then
                    SmokeDetectorsPage1.Visible = True
                    Me.Visible = True
                    Exit Sub
                Else
                    SmokeDetectorsPage1.Visible = False
                    Me.Visible = False
                    MyBase.Close()
                End If
        End Select
        MsgBox("Sensors not detected")
    End Sub
End Class