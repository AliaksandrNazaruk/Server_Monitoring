Imports System.ComponentModel
Module Module2
    Public Class virtualDevice
        Public name As String = ""
        Public dataFile As DataFile
        Public infoFile As DeviceInformation = New DeviceInformation
        Public WithEvents DevInterface As DeviceInterface = New DeviceInterface(False)
        Public Sub DevInterface_changed(e As Boolean) Handles DevInterface.UnlockChanged
            If DevInterface._unlock Then
                My.Forms.Workspace.SensorsConfig1.VisibleInterface(LoginnedProfile.AdminMode)
            Else
                My.Forms.Workspace.SensorsConfig1.UnvisibleInterface()
            End If
        End Sub
        Public Function Online() As Boolean
            If connectToDevice Is Nothing Then
                Return False
            End If
            If connectToDevice.testConnection() Then
                If Module2.MonitoringBase.dataFile IsNot Nothing Then
                    Return True
                End If
            End If
            Return False
        End Function
        Public WithEvents CheckCycle As Timer = New Timer
        Public connectToDevice As ConnectClassForMb = New ConnectClassForMb
        Private TempUserProfile As UserProfile.DevicesDataFile.DeviceData = New UserProfile.DevicesDataFile.DeviceData
        Sub New(name As String)
            Me.name = name
        End Sub
        '--------------------------------------------------------
        Public Function startDevice() As Boolean
            connectToDevice.SNMPConnection.ResetFunction()
            'dataFile = New SensorsDataFile
            'infoFile = New MBinfoFile
            If User.LoginnedProfile.Data.MB.IP.installed = False Then
                If connectToDevice.testConnection() Then
                    If connectToDevice.SNMPConnection.Logining() Then
                        Return True
                    Else
                        If postLoginFunction() Then
                            Return True
                        End If
                    End If
                Else
                    MsgBox("IP field cannot be empty")
                End If
            Else
                If connectToDevice.testConnection() Then
                    If connectToDevice.Login() Then
                        If postLoginFunction() Then
                            Return True
                        End If
                    Else
                        'MsgBox("IP field cannot be empty")
                    End If

                End If
                'MsgBox("Error connecting (device not responding)")
                Workspace.LoadingPage1.TextMessage.Text = "Error connecting (device not responding)"
            End If
            Return False
        End Function
        Private Function postLoginFunction() As Boolean
            Dim tempInfo As SnmpInfoCard = connectToDevice.SNMPConnection.getSnmpInfoCard()
            If tempInfo IsNot Nothing Then
                If tempInfo.deviceModel = "ENVIROMUX-2DB" Then
                    Dim newConfigFile As dataFileConstructor = New dataFileConstructor
                    newConfigFile.aux2SensorCount = 12
                    newConfigFile.auxSensorCount = 4
                    newConfigFile.DIgitalSensorCount = 5
                    newConfigFile.IntSensorCount = 1
                    newConfigFile.ipSensorCount = 36
                    newConfigFile.remoteInputCount = 32
                    newConfigFile.remoteRelayCount = 32
                    newConfigFile.smokeDetectorCount = 8
                    newConfigFile.tacSensorCount = 1
                    newConfigFile.extSensorCount = 8
                    newConfigFile.IPDeviceCount = 10
                    newConfigFile.outRelayCount = 10
                    newConfigFile.pwrSupplyCount = 10
                    dataFile = New DataFile(newConfigFile)
                    If User.LoginnedProfile.Data.MB.SensorListForMB Is Nothing Then
                        User.LoginnedProfile.Data.MB.SensorListForMB = New SensorMapMonitoringSystem(newConfigFile)
                    End If
                End If
                If grabFullData() Then
                    monitoringMode(True)
                    CheckCycle.Interval = 2000
                    CheckCycle.Start()
                    DevInterface.DevIntUnlock(True)
                    Return True
                End If
            End If
            Return False
        End Function
        Private Function logindev() As Boolean
            If connectToDevice.Login() Then
                Return True
            Else
                Return False
            End If
        End Function
        Private Function SaveFunc()

            Return False
        End Function
        Public Function grabFullData() As Boolean
            If MonitoringBase.connectToDevice.testConnection() Then
                Return FullGrab()
            End If
            Return False
        End Function
        Public Function monitoringMode(input As Boolean) As Boolean
            If Online() Then
                If input = True Then
                    Me.myBackgroundWorker = New System.Windows.Forms.Timer(New System.ComponentModel.Container())
                    backgroundWorker1.WorkerReportsProgress = True
                    backgroundWorker1.WorkerSupportsCancellation = True
                    myBackgroundWorker.Interval = 5000
                    myBackgroundWorker.Start()
                    Return True
                Else
                    myBackgroundWorker.Stop()
                    Return True
                End If
            End If
            myBackgroundWorker.Stop()
            Return False
        End Function
        '-----------------------------------------------------------
        Private Sub CheckCycle_tick() Handles CheckCycle.Tick
            If connectToDevice.SNMPConnection.IP.installed() Then
                If Online() Then
                    'FullGrab()
                    'thisDevicePage.DataRefresh()
                End If
            End If
        End Sub
        Public Function thisDevicePage() As SensorsConfigPage
            If Me.name = "MB" Then
                Return My.Forms.Workspace.SensorsConfig1
            End If
        End Function
        Public Function FullGrab() As Boolean
            If connectToDevice.fullgrab("SNMP") Then
                dataFile.SensorData.FullRefresh(connectToDevice.SNMPConnection.FILE)
                dataFile.DeviceInformation.Grab(connectToDevice.SNMPConnection.FILE)
                dataFile.NetConfiguration.Grab(connectToDevice.SNMPConnection.FILE)
                Return True
            End If
            Return False
        End Function
        Public Class ConnectClassForMb
            Implements IDisposable
            Public SNMPConnection As snmpBrowser = New snmpBrowser
            Public Sub Dispose() Implements IDisposable.Dispose
                'DirectCast(SNMPConnection, IDisposable).Dispose()
            End Sub
            '---------------------------------------------------------------------------------------------------------------
            'ОСНОВНЫЕ ФУНКЦИИ-----------------------------------------------------------------------------------------------
            Public Function testConnection() As Boolean
                If SNMPConnection.STATUS = "DEVICE_NOT_FOUND_ON_NETWORK" Then
                    Return False
                End If
                If User.LoginnedProfile.Data.MB.IP.installed() Then
                    If My.Computer.Network.Ping(User.LoginnedProfile.Data.MB.IP.FullString()) Then
                        Return True
                    End If
                    End If
                Return False
            End Function
            Public Function PingTest(input As String) As Boolean
                If My.Computer.Network.IsAvailable Then
                    Return My.Computer.Network.Ping(input)
                End If
                Return False
            End Function
            Public Function Login() As Boolean
                If testConnection() Then
                    If SNMPConnection.Logining Then
                        Return True
                    End If
                    If SNMPConnection.PASS IsNot Nothing Then
                        If SNMPConnection.LoginFunc Then
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


            Public Function fullgrab(input As String) As Boolean
                If MonitoringBase.connectToDevice.testConnection() Then
                    If User.LoginnedProfile.Data.MB.IP.installed() Then
                        If input = "SNMP" Then
                            SNMPConnection.FILE.Information = SNMPConnection.getSnmpInfoCard()
                            If SNMPConnection.FILE.Information Is Nothing Then
                                Return False
                            End If
                            SNMPConnection.FILE.NetConfig = SNMPConnection.getSnmpNetConfCard()
                            If SNMPConnection.FILE.NetConfig Is Nothing Then
                                Return False
                            End If
                            SNMPConnection.FILE.IntSensor = SNMPConnection.getSnmpIntSensorCard()
                            If SNMPConnection.FILE.IntSensor Is Nothing Then
                                Return False
                            End If
                            SNMPConnection.FILE.AuxSensor = SNMPConnection.getSnmpAuxSensorCard()
                            If SNMPConnection.FILE.AuxSensor Is Nothing Then
                                Return False
                            End If
                            SNMPConnection.FILE.ExtSensor = SNMPConnection.getSnmpExtSensorCard()
                            If SNMPConnection.FILE.ExtSensor Is Nothing Then
                                Return False
                            End If
                            SNMPConnection.FILE.DigInput = SNMPConnection.getSnmpDigInputCard()
                            If SNMPConnection.FILE.DigInput Is Nothing Then
                                Return False
                            End If
                            SNMPConnection.FILE.OutRelay = SNMPConnection.getSnmpOutRelayCard()
                            If SNMPConnection.FILE.OutRelay Is Nothing Then
                                Return False
                            End If
                            SNMPConnection.FILE.PwrSupply = SNMPConnection.getSnmpPwrSupplyCard()
                            If SNMPConnection.FILE.PwrSupply Is Nothing Then
                                Return False
                            End If
                            SNMPConnection.FILE.RemoteInputs = SNMPConnection.getSnmpRemoteInputCard()
                            If SNMPConnection.FILE.RemoteInputs Is Nothing Then
                                Return False
                            End If
                            SNMPConnection.FILE.RemoteRelay = SNMPConnection.getSnmpRemoteRelayCard()
                            If SNMPConnection.FILE.RemoteRelay Is Nothing Then
                                Return False
                            End If
                            SNMPConnection.FILE.SmokeDetector = SNMPConnection.getSnmpSmokeDetectorCard()
                            If SNMPConnection.FILE.SmokeDetector Is Nothing Then
                                Return False
                            End If
                            SNMPConnection.FILE.TacSensor = SNMPConnection.getSnmpTackSensorCard()
                            If SNMPConnection.FILE.TacSensor Is Nothing Then
                                Return False
                            End If
                            SNMPConnection.FILE.Aux2Sensor = SNMPConnection.getSnmpAux2SensorCard()
                            If SNMPConnection.FILE.Aux2Sensor Is Nothing Then
                                Return False
                            End If
                            SNMPConnection.FILE.MsgRegisters = SNMPConnection.getSnmpMsgRegistersCard()
                            If SNMPConnection.FILE.MsgRegisters Is Nothing Then
                                Return False
                            End If
                            Return True
                        End If
                        If input = "HTTP" Then
                            SNMPConnection.FILE.Information = SNMPConnection.getSnmpInfoCard()
                            SNMPConnection.FILE.NetConfig = SNMPConnection.getSnmpNetConfCard()
                            SNMPConnection.FILE.IntSensor = SNMPConnection.getSnmpIntSensorCard()
                            SNMPConnection.FILE.AuxSensor = SNMPConnection.getSnmpAuxSensorCard()
                            SNMPConnection.FILE.ExtSensor = SNMPConnection.getSnmpExtSensorCard()
                            SNMPConnection.FILE.DigInput = SNMPConnection.getSnmpDigInputCard()
                            SNMPConnection.FILE.OutRelay = SNMPConnection.getSnmpOutRelayCard()
                            SNMPConnection.FILE.PwrSupply = SNMPConnection.getSnmpPwrSupplyCard()
                            SNMPConnection.FILE.RemoteInputs = SNMPConnection.getSnmpRemoteInputCard()
                            SNMPConnection.FILE.RemoteRelay = SNMPConnection.getSnmpRemoteRelayCard()
                            SNMPConnection.FILE.SmokeDetector = SNMPConnection.getSnmpSmokeDetectorCard()
                            SNMPConnection.FILE.TacSensor = SNMPConnection.getSnmpTackSensorCard()
                            SNMPConnection.FILE.Aux2Sensor = SNMPConnection.getSnmpAux2SensorCard()
                            SNMPConnection.FILE.MsgRegisters = SNMPConnection.getSnmpMsgRegistersCard()

                            Return True
                        End If
                    End If
                End If
                Return False
            End Function

        End Class
        '-------------------------------------------------------------
        Friend WithEvents myBackgroundWorker As Timer = New Timer
        Private WithEvents backgroundWorker1 As BackgroundWorker = New BackgroundWorker
        Private resultLabel As String = ""
        Private Sub BackgroundWorker_Tick(sender As Object, e As EventArgs) Handles myBackgroundWorker.Tick
            If MonitoringBase.Online Then
                If MonitoringBase.DevInterface._unlock Then
                    If backgroundWorker1.IsBusy Then
                        Exit Sub
                    Else
                        backgroundWorker1.RunWorkerAsync()
                        Exit Sub
                    End If
                End If
            End If
            myBackgroundWorker.Stop()
            backgroundWorker1 = New BackgroundWorker
        End Sub
        Public Function clear() As Boolean
            Module2.MonitoringBase.CheckCycle.Stop()
            monitoringMode(False)
            DevInterface.DevIntUnlock(False)
            dataFile = New DataFile(New dataFileConstructor)
            infoFile = New DeviceInformation
            If connectToDevice IsNot Nothing Then
                connectToDevice.Dispose()
                connectToDevice = New ConnectClassForMb
            End If
            Return True
        End Function
        Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles backgroundWorker1.DoWork
            resultLabel = "startBackgroundWorker"
            Using worker As BackgroundWorker = New BackgroundWorker
                For i As Integer = 1 To 10
                    If worker.CancellationPending = True Then
                        e.Cancel = True
                        Exit For
                    Else
                        If MonitoringBase.Online <> True Then
                            Exit Sub
                        End If
                        connectToDevice.fullgrab("SNMP")
                        grabFullData()
                    End If
                Next
            End Using
        End Sub
        Private Sub backgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles backgroundWorker1.ProgressChanged
            resultLabel = e.ProgressPercentage.ToString() + "%"
        End Sub
        Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles backgroundWorker1.RunWorkerCompleted
            If e.Error IsNot Nothing Then
                resultLabel = "Error: " + e.Error.Message
            Else
                resultLabel = "Done!"
            End If
        End Sub
    End Class
    Public MonitoringBase As virtualDevice = New virtualDevice("MonitoringBase1")
End Module



