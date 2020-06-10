Public Class SensorsConfigPage
    Public resultLabel As Label = New Label
    Public SensorMap As SensorMap = New SensorMap
    Public BGWWork As Boolean = False
    '---------------------------------------------------------------------------------------------------------------
    'ВСПОМОГАТЕЛЬНЫЕ ФУНКЦИИ---------------------------------------------------------------------------------------
    Private Function testResult(input As String) As Boolean
        If input = "0" Then
            Return False
        End If
        If input = "" Then
            Return False
        End If
        If input Is Nothing Then
            Return False
        End If
        Return True
    End Function
    Private Sub grab(input As String)
        Select Case input
            Case "General"
                EnviromuxUserConnectionData1.IpAddpessBox1.InpIPTextBox1.Text = User.LoginnedProfile.Data.MB.IP.Arg1
                EnviromuxUserConnectionData1.IpAddpessBox1.InpIPTextBox2.Text = User.LoginnedProfile.Data.MB.IP.Arg2
                EnviromuxUserConnectionData1.IpAddpessBox1.InpIPTextBox3.Text = User.LoginnedProfile.Data.MB.IP.Arg3
                EnviromuxUserConnectionData1.IpAddpessBox1.InpIPTextBox4.Text = User.LoginnedProfile.Data.MB.IP.Arg4
                EnviromuxUserConnectionData1.CommunityBox.Text = User.LoginnedProfile.Data.MB.Login
                EnviromuxUserConnectionData1.Remember.Checked = User.LoginnedProfile.Data.MB.RememberCheckBOx
                EnviromuxUserConnectionData1.PortBox.Text = User.LoginnedProfile.Data.MB.port

            Case "Summary"
                'SUMMARY------------------------------------------------------
                SensorInformation1.ModelBase.Text = MonitoringBase.dataFile.DeviceInformation.DeviceModel
                SensorInformation1.SerialNumber.Text = MonitoringBase.dataFile.DeviceInformation.SerialNumber
                SensorInformation1.Manufacture.Text = MonitoringBase.dataFile.DeviceInformation.Manufacture
                SensorInformation1.HardwareRev.Text = MonitoringBase.dataFile.DeviceInformation.HardwareRev
                SensorInformation1.Branch.Text = MonitoringBase.dataFile.DeviceInformation.Branch
                SensorInformation1.myLocation.Text = MonitoringBase.dataFile.DeviceInformation.Location
                SensorInformation1.myName.Text = MonitoringBase.dataFile.DeviceInformation.Name
                SensorInformation1.Rack.Text = MonitoringBase.dataFile.DeviceInformation.Rack
                SensorInformation1.ContactPerson.Text = MonitoringBase.dataFile.DeviceInformation.Contact
                SensorInformation1.Phone.Text = MonitoringBase.dataFile.DeviceInformation.Phone
            Case "Network"
                'NETWORK-------------------------------------------------------
                '--IP4 Setting-------------------------------------------------
                If MonitoringBase.dataFile.NetConfiguration.IP4Mode = "0" Then
                    SensorNetConfig1.IP4Mode.SelectedIndex = 0
                End If
                If MonitoringBase.dataFile.NetConfiguration.IP4Mode = "1" Then
                    SensorNetConfig1.IP4Mode.SelectedIndex = 1
                End If
                SensorNetConfig1.IP4Addr.Text = MonitoringBase.dataFile.NetConfiguration.IP4Addr
                SensorNetConfig1.IP4Mask.Text = MonitoringBase.dataFile.NetConfiguration.IP4Mask
                SensorNetConfig1.IP4GateWay.Text = MonitoringBase.dataFile.NetConfiguration.IP4GateWay
                SensorNetConfig1.AlternativeDNS.Text = MonitoringBase.dataFile.NetConfiguration.AltDNS
                SensorNetConfig1.DNSTimeOut.Text = MonitoringBase.dataFile.NetConfiguration.DNSTimeOut
                '--IP6 Setting-------------------------------------------------
                If MonitoringBase.dataFile.NetConfiguration.IPv6Mode = "0" Then
                    SensorNetConfig1.IPv6Mode.SelectedIndex = 0
                End If
                If MonitoringBase.dataFile.NetConfiguration.IPv6Mode = "1" Then
                    SensorNetConfig1.IPv6Mode.SelectedIndex = 1
                End If
                If MonitoringBase.dataFile.NetConfiguration.IPv6Mode = "2" Then
                    SensorNetConfig1.IPv6Mode.SelectedIndex = 2
                End If
                If MonitoringBase.dataFile.NetConfiguration.IPv6Mode = "3" Then
                    SensorNetConfig1.IPv6Mode.SelectedIndex = 3
                End If
                SensorNetConfig1.IPv6Addr.Text = MonitoringBase.dataFile.NetConfiguration.IPv6Addr
                SensorNetConfig1.IPv6GateWay.Text = MonitoringBase.dataFile.NetConfiguration.IPv6GateWay
                If MonitoringBase.dataFile.NetConfiguration.Enable6To4Tunnel = "0" Then
                    SensorNetConfig1.Enable6To4Tunnel.SelectedIndex = 0
                End If
                If MonitoringBase.dataFile.NetConfiguration.Enable6To4Tunnel = "1" Then
                    SensorNetConfig1.Enable6To4Tunnel.SelectedIndex = 1
                End If
                SensorNetConfig1.LocallPAddr.Text = MonitoringBase.dataFile.NetConfiguration.LocalIPAddr
                '--VLAN Setting----------------------------------------------
                SensorNetConfig1.Vlan.Text = MonitoringBase.dataFile.NetConfiguration.Vlan
                If MonitoringBase.dataFile.NetConfiguration.VlanEnabled = "0" Then
                    SensorNetConfig1.VlanEnabled.SelectedIndex = 0
                End If
                If MonitoringBase.dataFile.NetConfiguration.VlanEnabled = "1" Then
                    SensorNetConfig1.VlanEnabled.SelectedIndex = 1
                End If
        End Select

    End Sub

    '---------------------------------------------------------------------------------------------------------------
    'ОСНОВНЫЕ ФУНКЦИИ-----------------------------------------------------------------------------------------------
    Public Sub DataRefresh()
        If MonitoringBase.online Then
            Logo.ImageLocation = "http://" + User.LoginnedProfile.Data.MB.IP.FullString + "/images/logo.gif"
            grab("Summary")
            grab("Network")
        End If
        grab("General")
    End Sub
    Public Sub ClearFunc()
        SensorMap = New SensorMap
        'My.Forms.Workspace.MonitoringPage.CalculateTable()
        SensorInformation1.ModelBase.Text = ""
        SensorInformation1.Branch.Text = ""
        SensorInformation1.myLocation.Text = ""
        SensorInformation1.myName.Text = ""
        SensorInformation1.Rack.Text = ""
        SensorInformation1.ContactPerson.Text = ""
        SensorInformation1.Phone.Text = ""
        SensorInformation1.HardwareRev.Text = ""
        SensorInformation1.Manufacture.Text = ""
        SensorInformation1.SerialNumber.Text = ""
        SensorNetConfig1.AlternativeDNS.Text = ""
        SensorNetConfig1.DNSTimeOut.Text = ""
        SensorNetConfig1.Enable6To4Tunnel.Text = ""
        SensorNetConfig1.IP4Addr.Text = ""
        SensorNetConfig1.IP4GateWay.Text = ""
        SensorNetConfig1.IP4Mask.Text = ""
        SensorNetConfig1.IP4Mode.Text = ""
        SensorNetConfig1.IPv6Mode.Text = ""
        SensorNetConfig1.IPv6Addr.Text = ""
        SensorNetConfig1.IPv6GateWay.Text = ""
        SensorNetConfig1.LocallPAddr.Text = ""
        SensorNetConfig1.Vlan.Text = ""
        SensorNetConfig1.VlanEnabled.Text = ""
        '---------------------------------
    End Sub

    Private Function DeleteFunc() As Boolean

        Return False
    End Function
    Private Sub SaveFunc()
        If Module2.MonitoringBase.online Then

        End If
    End Sub

    Public Sub FullClear()
        Module2.MonitoringBase.clear()
        ClearPage()
        'Удаление данных об усройсве из файла пользователя
        User.LoginnedProfile.Data.MB.clear()
        'Очистка переменных интерфейса 
        'SensorTypeTableActivated = False
        'FullDataPDUfilled = False
    End Sub
    Private Sub ClearPage()
        'очистка "PDU connection settings"
        EnviromuxUserConnectionData1.clear()

        'очистка "General settings"
        SensorInformation1.clear()
        EnviromuxUserConnectionData1.clear()
        SensorNetConfig1.clear()
    End Sub
    Private Sub ClearMonitoring()
        Module2.MonitoringBase.monitoringMode(False)
    End Sub
    '---------------------------------------------------------------------------------------------------------------
    'СОБЫТИЯ--------------------------------------------------------------------------------------------------------
    Private Sub SensorsConfigPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'сheckSensors()
        resultLabel.Text = "Done!"
    End Sub

    Public Sub SensorButtonsRefresh()
        If Module2.MonitoringBase.dataFile.SensorData.ScanSensor("IntSensor", "Online") IsNot Nothing Then
            InternalButton.Enabled = True
        End If
        If Module2.MonitoringBase.dataFile.SensorData.ScanSensor("Aux2Sensor", "Online") IsNot Nothing Then
            Aux2Button.Enabled = True
        End If
        If Module2.MonitoringBase.dataFile.SensorData.ScanSensor("AuxSensor", "Online") IsNot Nothing Then
            AuxButton.Enabled = True
        End If
        If Module2.MonitoringBase.dataFile.SensorData.ScanSensor("DigInput", "Online") IsNot Nothing Then
            DigitalInputButton.Enabled = True
        End If
        If Module2.MonitoringBase.dataFile.SensorData.ScanSensor("ExtSensor", "Online") IsNot Nothing Then
            ExternalSensorButton.Enabled = True
        End If
        If Module2.MonitoringBase.dataFile.SensorData.ScanSensor("MsgRegisters", "Online") IsNot Nothing Then
            MsgRegistersButton.Enabled = True
        End If
        If Module2.MonitoringBase.dataFile.SensorData.ScanSensor("OutRelay", "Online") IsNot Nothing Then
            OutRelaysButton.Enabled = True
        End If
        If Module2.MonitoringBase.dataFile.SensorData.ScanSensor("PwrSupply", "Online") IsNot Nothing Then
            PWRSupplyButton.Enabled = True
        End If
        If Module2.MonitoringBase.dataFile.SensorData.ScanSensor("RemoteInputs", "Online") IsNot Nothing Then
            RemoteInputButton.Enabled = True
        End If
        If Module2.MonitoringBase.dataFile.SensorData.ScanSensor("RemoteRelay", "Online") IsNot Nothing Then
            RemoteRelayButton.Enabled = True
        End If
        If Module2.MonitoringBase.dataFile.SensorData.ScanSensor("TacSensor", "Online") IsNot Nothing Then
            TacSensorButton.Enabled = True
        End If

        If Module2.MonitoringBase.dataFile.SensorData.ScanSensor("IPSensor", "Online") IsNot Nothing Then
            IPSensorsButton.Enabled = True
        End If
        If Module2.MonitoringBase.dataFile.SensorData.ScanSensor("IPDevice", "Online") IsNot Nothing Then
            IPDevicesButton.Enabled = True
        End If
        If Module2.MonitoringBase.dataFile.SensorData.ScanSensor("SmokeDetector", "Online") IsNot Nothing Then
            SmokeDetectorButton.Enabled = True
        End If
    End Sub
    Public Sub VisibleInterface(mode As Boolean)
        If mode Then
            If Module2.MonitoringBase.Online Then
                SensorNetConfig1.Enabled = True
                EnviromuxUserConnectionData1.Delete.Enabled = True
                SensorInformation1.Enabled = True
                SensorButtonsRefresh()
            End If
        Else
            SensorNetConfig1.Enabled = False
            SensorInformation1.Enabled = True
            EnviromuxUserConnectionData1.Delete.Enabled = True
        End If
    End Sub
    Public Sub UnvisibleInterface()
        SensorNetConfig1 = New SensorNetConfig
        SensorInformation1 = New SensorInformation
        EnviromuxUserConnectionData1 = New EnviromuxUserConnectionData
    End Sub

    '---------------------------------------------------------------------------------------------------------------
    'СОБЫТИЯ ЭЛЕМЕНТОВ ИНТЕРФЕЙСА-----------------------------------------------------------------------------------
    Private Sub DigitalInputButton_Click(sender As Object, e As EventArgs) Handles DigitalInputButton.Click
        Sensors_Form.start("DigitalIn")
    End Sub

    Private Sub TacSensorButton_Click(sender As Object, e As EventArgs) Handles TacSensorButton.Click
        Sensors_Form.start("TacSensor")
    End Sub

    Private Sub Aux2Button_Click(sender As Object, e As EventArgs) Handles Aux2Button.Click
        Sensors_Form.start("Aux2Sensor")
    End Sub

    Private Sub AuxButton_Click(sender As Object, e As EventArgs) Handles AuxButton.Click
        Sensors_Form.start("AuxSensors")
    End Sub

    Private Sub ExternalSensorButton_Click(sender As Object, e As EventArgs) Handles ExternalSensorButton.Click
        Sensors_Form.start("ExtSensors")
    End Sub
    Private Sub MsgRegistersButton_Click(sender As Object, e As EventArgs) Handles MsgRegistersButton.Click
        Sensors_Form.start("MsgRegisters")
    End Sub

    Private Sub PWRSupplyButton_Click(sender As Object, e As EventArgs) Handles PWRSupplyButton.Click
        Sensors_Form.start("PWRSupply")
    End Sub

    Private Sub RemoteInputButton_Click(sender As Object, e As EventArgs) Handles RemoteInputButton.Click
        Sensors_Form.start("RemoteInput")
    End Sub

    Private Sub RemoteOutputButton_Click(sender As Object, e As EventArgs) Handles RemoteRelayButton.Click
        Sensors_Form.start("RemoteRelay")
    End Sub

    Private Sub SmokeDetectorButton_Click(sender As Object, e As EventArgs) Handles SmokeDetectorButton.Click
        Sensors_Form.start("SmokeDetector")
    End Sub

    Private Sub InternalButton_Click(sender As Object, e As EventArgs) Handles InternalButton.Click
        Sensors_Form.start("IntSensor")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles IPDevicesButton.Click
        Sensors_Form.start("IPDevices")
    End Sub

    Private Sub OutRelaysButton_Click(sender As Object, e As EventArgs) Handles OutRelaysButton.Click
        Sensors_Form.start("OutRelays")
    End Sub

    Private Sub IPSensorsButton_Click(sender As Object, e As EventArgs) Handles IPSensorsButton.Click
        Sensors_Form.start("IPSensors")
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        User.LoginnedProfile.Save()
    End Sub



    Private Sub SensorConfigPage_VisebleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            DataRefresh()
        End If
    End Sub
End Class


