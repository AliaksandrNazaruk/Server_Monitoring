Imports System.ComponentModel
Module Module1
    Public Class VirtualDevice
        Public Name As String = ""
        Public dataFile As ListwaDataFile = New ListwaDataFile
        Public infoFile As DeviceInformation = New DeviceInformation
        Public WithEvents DevInterface As DeviceInterface = New DeviceInterface(False)
        Public Sub DevInterface_changed(e As Boolean) Handles DevInterface.UnlockChanged
            If DevInterface._unlock Then
                ThisDevicePage.VisibleInterface(LoginnedProfile.AdminMode)
            Else
                ThisDevicePage.UnvisibleInterface()
            End If
        End Sub
        Public Function Online() As Boolean
            If connectToDevice Is Nothing Then
                Return False
            End If
            Return connectToDevice.testConnection()

        End Function
        Public WithEvents CheckCycle As Timer = New Timer
        Public connectToDevice As ConnectClassForPDU = New ConnectClassForPDU
        Private TempUserProfile As UserProfile.DevicesDataFile.DeviceData = New UserProfile.DevicesDataFile.DeviceData

        Sub New(name As String)
            Me.Name = name
        End Sub
        '----------------------------------------------------------------------------------------------------------------------
        'ОСНОВНЫЕ ФУНКЦИИ------------------------------------------------------------------------------------------------------
        Public Function startDevice(dev As UserProfile.DevicesDataFile.DeviceData) As Boolean
            connectToDevice.WebConnection.ResetFunction()
            dataFile = New ListwaDataFile
            infoFile = New DeviceInformation
            If connectToDevice.WebConnection.IP.installed = False Then
                connectToDevice.WebConnection.IP = dev.IP
                connectToDevice.WebConnection.PORT = dev.port
                If connectToDevice.testConnection() Then
                    If connectToDevice.WebConnection.Logining() Then
                        Return True
                    Else
                        If postLoginFunction(dev) Then
                            Return True
                        End If
                    End If
                Else
                    MsgBox("IP field cannot be empty")
                End If
            Else
                If connectToDevice.testConnection() Then
                    If connectToDevice.WebConnection.Logining() Then
                        Return True
                    Else
                        If postLoginFunction(dev) Then
                            Return True
                        End If
                    End If
                Else
                    MsgBox("IP field cannot be empty")
                End If

                MsgBox("Error connecting (device not responding)")
                Workspace.LoadingPage1.TextMessage.Text = "Error connecting (device not responding)"
            End If
            CheckCycle.Stop()
            Return False
        End Function
        Private Function postLoginFunction(dev As UserProfile.DevicesDataFile.DeviceData) As Boolean
            If dev.IP.installed() Then
                If logindev(dev) Then
                    If connectToDevice.grabDataFromDevice("fullData") Then
                        grabFullDataFromDeviceToModule()
                        monitoringMode(True)
                        DevInterface.DevIntUnlock(True)
                        Return True
                    End If
                End If
            End If
            Return False
        End Function

        Public Function ResetPDU() As Boolean
            If connectToDevice.WebConnection.ResetFunction() Then
                If startDevice(TempUserProfile) Then
                    Return True
                End If
            End If
            Return False
        End Function
        Public Function clear() As Boolean
            DevInterface.DevIntUnlock(False)
            monitoringMode(False)
            dataFile = New ListwaDataFile
            infoFile = New DeviceInformation
            If connectToDevice IsNot Nothing Then
                connectToDevice.Dispose()
                connectToDevice = New ConnectClassForPDU
            End If
        End Function

        Private Function logindev(dev As UserProfile.DevicesDataFile.DeviceData) As Boolean
            connectToDevice.WebConnection.IP = dev.IP
            connectToDevice.WebConnection.PASS = dev.Password
            connectToDevice.WebConnection.LOGIN = dev.Login
            connectToDevice.WebConnection.PORT = dev.port
            If connectToDevice.StartSession() Then
                Return True
            Else
                Return False
            End If
        End Function
        Public Function SaveFunc(input As String) As Boolean
            If ThisDevicePage() Is Nothing Then
                Return False
            End If
            If input = "GeneralSetting" Then
                connectToDevice.WebConnection.FILE.PDUConfiguration.Location = ThisDevicePage().PduGeneralSetting1.LocationBox.Text
                connectToDevice.WebConnection.FILE.PDUConfiguration.Name = ThisDevicePage().PduGeneralSetting1.NameBox.Text
                connectToDevice.WebConnection.FILE.PDUConfiguration.DHCPClient = Convert.ToInt32(ThisDevicePage().PduGeneralSetting1.dhcpcheck.Checked).ToString
                connectToDevice.WebConnection.FILE.PDUConfiguration.IPAddress = ThisDevicePage().PduGeneralSetting1.Ipaddrbox.Text
                connectToDevice.WebConnection.FILE.PDUConfiguration.SubnetMask = ThisDevicePage().PduGeneralSetting1.SubnetBox.Text
                connectToDevice.WebConnection.FILE.PDUConfiguration.Gateway = ThisDevicePage().PduGeneralSetting1.GatewayBox.Text
                connectToDevice.WebConnection.FILE.PDUConfiguration.UserPassword = ThisDevicePage().PduGeneralSetting1.UserpasBox.Text
                connectToDevice.WebConnection.FILE.PDUConfiguration.AdminPassword = ThisDevicePage().PduGeneralSetting1.AdminPassBox.Text
                connectToDevice.WebConnection.FILE.PDUConfiguration.LoginTimeOut = ThisDevicePage().PduGeneralSetting1.LogTimeOutComboBox.Text
                connectToDevice.WebConnection.FILE.PDUConfiguration.AutoRefreshWebsite = ThisDevicePage().PduGeneralSetting1.AutoRefreshWebsiteComboBox.Text
                Workspace.LoadingPage1.ProgressBar1.Value = 10
                connectToDevice.WebConnection.gotoWebPage(connectToDevice.WebConnection.getHost("SavePDUConfig"))
                Workspace.LoadingPage1.ProgressBar1.Value = 80
                monitoringMode(True)
                Workspace.LoadingPage1.ProgressBar1.Value = 100
                Return True
            End If
            If input = "TemperatureMonitored" Then
                connectToDevice.WebConnection.FILE.PDUConfiguration.Temperature = ThisDevicePage().PduGeneralSetting1.TemperatureMonitor.Checked.ToString
                Return True
            End If
            If input = "AllertConfiguration" Then
                connectToDevice.WebConnection.FILE.AlertConfiguration.SMTPUsername = ThisDevicePage().PduGeneralSetting1.SMTPNameBox.Text
                connectToDevice.WebConnection.FILE.AlertConfiguration.SMPTPassword = ThisDevicePage().PduGeneralSetting1.SMTPPassBox.Text
                connectToDevice.WebConnection.FILE.AlertConfiguration.SMTPSender = ThisDevicePage().PduGeneralSetting1.SMTPSenderBox.Text
                connectToDevice.WebConnection.FILE.AlertConfiguration.SMTPReciepient = ThisDevicePage().PduGeneralSetting1.SMTPPecientBox.Text
                connectToDevice.WebConnection.FILE.AlertConfiguration.SMTPIPAddressForServer = ThisDevicePage().PduGeneralSetting1.SMTPIPaddrServerBox.Text
                connectToDevice.WebConnection.FILE.AlertConfiguration.SMTPPortNumber = ThisDevicePage().PduGeneralSetting1.SMTPPortNumBox.Text
                connectToDevice.WebConnection.FILE.AlertConfiguration.SyslogIPAddress = ThisDevicePage().PduGeneralSetting1.SyslogIPaddrBox.Text
                connectToDevice.WebConnection.FILE.AlertConfiguration.SyslogPortNumber = ThisDevicePage().PduGeneralSetting1.SyslogPortNumBox.Text
                connectToDevice.WebConnection.FILE.AlertConfiguration.SNMPPrivateCommunity = ThisDevicePage().PduGeneralSetting1.SNMPPrivateCommBox.Text
                connectToDevice.WebConnection.FILE.AlertConfiguration.SNMPPublicCommunity = ThisDevicePage().PduGeneralSetting1.SNMPPublicComBox.Text
                connectToDevice.WebConnection.FILE.AlertConfiguration.SNMPIPAddressForTrap = ThisDevicePage().PduGeneralSetting1.SNMPIPaddrfTrap.Text
                connectToDevice.WebConnection.FILE.AlertConfiguration.SNTPIPAddresForServer = ThisDevicePage().PduGeneralSetting1.SNTPIPaddrServer.Text
                Workspace.LoadingPage1.ProgressBar1.Value = 10
                connectToDevice.WebConnection.gotoWebPage(connectToDevice.WebConnection.getHost("AlertPDUConfig"))
                Workspace.LoadingPage1.ProgressBar1.Value = 80
                monitoringMode(True)
                Workspace.LoadingPage1.ProgressBar1.Value = 100
                Return True
            End If
            Return False
        End Function
        Public Function grabFullDataFromDeviceToModule() As Boolean
            dataFile.FullGrab(connectToDevice.WebConnection.FILE)
            Return True
        End Function
        Public Function ThisDevicePage() As PDUConfigPage
            If My.Forms.Workspace._Listwa1.PartNumberBox.Text = connectToDevice.WebConnection.FILE.Information.PartNumber Then
                Return My.Forms.Workspace._Listwa1
            End If
            If My.Forms.Workspace._Listwa2.PartNumberBox.Text = connectToDevice.WebConnection.FILE.Information.PartNumber Then
                Return My.Forms.Workspace._Listwa2
            End If
            If Me.Name = "PDUA" Then
                Return My.Forms.Workspace._Listwa1
            End If
            If Me.Name = "PDUB" Then
                Return My.Forms.Workspace._Listwa2
            End If
            Return Nothing
        End Function
        Public Function monitoringMode(input As Boolean) As Boolean
            If connectToDevice IsNot Nothing Then
                If input = False Then
                    connectToDevice.WebConnection.startWebBrowserConfig()
                    Return True
                End If
                If connectToDevice.testConnection() Then
                    If input = True Then
                        If connectToDevice.WebConnection.MonitoringStatus Then
                            CheckCycle.Interval = 2000
                            CheckCycle.Start()
                            connectToDevice.WebConnection.MonitoringTimer.Start()
                            Return True
                        Else
                            If connectToDevice.WebConnection.getStartMonitoring() Then
                                CheckCycle.Interval = 2000
                                CheckCycle.Start()
                                Return True
                            End If
                        End If

                    End If
                End If

            End If
            Return False
        End Function
        Public Sub ClearPDUConnection()
            If connectToDevice IsNot Nothing Then
                Me.connectToDevice.WebConnection.ResetFunction()
            End If
        End Sub

        '-----------------------------------------------------------------------------------------------------------------------
        'СОБЫТИЯ----------------------------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------------------------------
        'ТАЙМЕРЫ----------------------------------------------------------------------------------------------------------------
        Private Sub CheckCycle_tick() Handles CheckCycle.Tick
            If connectToDevice.WebConnection.IP.installed() Then
                If Online() Then
                    If connectToDevice.WebConnection.Logining() Then
                        If connectToDevice.WebConnection.MonitoringStatus Then
                            dataFile.table = connectToDevice.WebConnection.FILE.Table
                            Exit Sub
                        Else

                        End If
                    End If
                End If
            End If
        End Sub
        Public Class ConnectClassForPDU
            Implements IDisposable
            Public WebConnection As PDUWebConnection = New PDUWebConnection
            Public Sub Dispose() Implements IDisposable.Dispose
                DirectCast(WebConnection, IDisposable).Dispose()
            End Sub
            '---------------------------------------------------------------------------------------------------------------
            'ОСНОВНЫЕ ФУНКЦИИ-----------------------------------------------------------------------------------------------
            Public Function testConnection() As Boolean
                If WebConnection.STATUS = "DEVICE_NOT_FOUND_ON_NETWORK" Then
                    Return False
                End If
                If WebConnection.IP.installed() Then
                    Return PingTest(WebConnection.IP.FullString())
                End If
                Return False
            End Function
            Public Function PingTest(input As String) As Boolean
                If My.Computer.Network.IsAvailable Then
                    Return My.Computer.Network.Ping(input)
                End If
                Return False
            End Function
            Public Function PingTest(IP As String, Port As String) As Boolean
                If My.Computer.Network.IsAvailable Then
                    Return True
                End If
                Return False
            End Function
            Public Function Login() As Boolean
                If testConnection() Then
                    If WebConnection.Logining Then
                        Return True
                    End If
                    If WebConnection.PASS IsNot Nothing Then
                        If WebConnection.LoginFunc() Then
                            Return True
                        End If
                    End If
                End If
                Return False
            End Function
            Public Function StartSession() As Boolean
                If Login() Then
                    Return True
                End If
                Return False
            End Function
            Public Function grabDataFromDevice(input As String) As Boolean
                If WebConnection.IP.installed() Then
                    If testConnection() Then
                        If WebConnection.Session.Number IsNot Nothing Then
                            If input = "fullData" Then
                                WebConnection.FILE.Information = WebConnection.getInformationCard()
                                If WebConnection.FILE.Information Is Nothing Then
                                    Return False
                                End If
                                WebConnection.FILE.logo = WebConnection.getLogo()
                                If WebConnection.FILE.logo Is Nothing Then
                                    Return False
                                End If
                                WebConnection.FILE.PDUConfiguration = WebConnection.getPDUConfigTable()
                                If WebConnection.FILE.PDUConfiguration Is Nothing Then
                                    Return False
                                End If
                                WebConnection.FILE.MonitoringConfiguration = WebConnection.getMonitoringConfigTable()
                                If WebConnection.FILE.MonitoringConfiguration Is Nothing Then
                                    Return False
                                End If
                                WebConnection.FILE.AlertConfiguration = WebConnection.getAlertConfigTable()
                                If WebConnection.FILE.AlertConfiguration Is Nothing Then
                                    Return False
                                End If
                                'WebConnection.FILE.Log = WebConnection.getLog()
                                'If WebConnection.FILE.Log Is Nothing Then
                                '    Return False
                                'End If
                                Return True
                            End If
                            If input = "table" Then
                                WebConnection.FILE.Table = WebConnection.getTable()
                                Return True
                            End If
                        End If
                    End If
                End If
                Return False
            End Function
        End Class
    End Class
    Public PDUA As VirtualDevice = New VirtualDevice("PDUA")
    Public PDUB As VirtualDevice = New VirtualDevice("PDUB")
End Module
