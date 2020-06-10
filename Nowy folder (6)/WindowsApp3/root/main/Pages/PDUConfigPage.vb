
Public Class PDUConfigPage
    Public WithEvents Cycle As Timer = New Timer
    '---------------------------------------------------------------------------------------------------------------
    'ТАЙМЕРЫ--------------------------------------------------------------------------------------------------------
    Private checkSensorsCalc As Integer = 0
    Public SensorTypeTableActivated As Boolean = False
    Private FullDataPDUfilled As Boolean = False
    Private genSetTableGenSetBackup As String = ""
    Private genSetTableTempMonBackup As String = ""
    Private genSetTableAlertConfBackup As String = ""
    Private Sub Cycle_start() Handles Cycle.Tick
        If ThisDeviceModule.Online Then
            If SensorTypeTableActivated = False And ThisDeviceModule.connectToDevice.WebConnection.FILE.Table.TableType <> "" Then
                SensorTypeTableActivated = PduSensorsSetting1.TableEnable(ThisDeviceModule.dataFile.table.TableType)
                If SensorTypeTableActivated Then
                    If ThisDeviceModule.Name = "PDUA" Then
                        My.Forms.Workspace.AllertConfig1.PDUAAlertTable.ActivateTable(ThisDeviceModule.dataFile.table.TableType)
                        My.Forms.Workspace.AllertConfig1.PDUAAlertTable.Visible = True
                    ElseIf ThisDeviceModule.Name = "PDUB" Then
                        My.Forms.Workspace.AllertConfig1.PDUBAlertTable.ActivateTable(ThisDeviceModule.dataFile.table.TableType)
                        My.Forms.Workspace.AllertConfig1.PDUBAlertTable.Visible = True
                    Else
                    End If
                End If
            End If

            ConStatus.Text = "Connected"
            ConStatus.ForeColor = Color.Green
            'Workspace.Log1.SendMessagesFunction("Message", "Connection to PDU " + ThisDeviceModule.connectToDevice.WebConnection.IP.FullString + " restored")
            If checkSensorsCalc >= 4 Then
                Datarefresh()
                checkSensorsCalc = 0
            Else
                checkSensorsCalc = checkSensorsCalc + 1
            End If
        Else
            checkSensorsCalc = 0
            ConStatus.Text = "Not connection"
            ConStatus.ForeColor = Color.Red
            'Workspace.Log1.SendMessagesFunction("Message", "Connection lost with PDU " + " " + ThisDeviceModule.connectToDevice.WebConnection.IP.FullString)
        End If
    End Sub
    Private Sub Cycle_Stop()
        checkSensorsCalc = 0
        SensorTypeTableActivated = False
        ConStatus.Text = "Not connection"
        ConStatus.ForeColor = Color.Red
        Cycle.Stop()
    End Sub
    '---------------------------------------------------------------------------------------------------------------
    'ВСПОМОГАТЕЛЬНЫЕ ФУНКЦИИ---------------------------------------------------------------------------------------
    Private Function thisDeviceProfileData() As UserProfile.DevicesDataFile.DeviceData
        If Me.Name = "_Listwa1" Then
            Return User.LoginnedProfile.Data.PDUA
        ElseIf Me.Name = "_Listwa2" Then
            Return User.LoginnedProfile.Data.PDUB
        End If
        Return Nothing
    End Function
    Private Function ThisDeviceModule() As Module1.VirtualDevice
        If Me.Name = "_Listwa1" Then
            Return Module1.PDUA
        End If
        If Me.Name = "_Listwa2" Then
            Return Module1.PDUB
        End If
        Return Nothing
    End Function
    Private Function ThisDevicePage() As WindowsApp3.PDUConfigPage
        If Me.Name = "_Listwa1" Then
            Return My.Forms.Workspace._Listwa1
        End If
        If Me.Name = "_Listwa2" Then
            Return My.Forms.Workspace._Listwa2
        End If
        Return Nothing
    End Function
    Private Sub IPconverterToInputBox(input As String)
        Dim index1 As Integer = 0
        Dim arg1 As String = ""
        Dim arg2 As String = ""
        Dim arg3 As String = ""
        Dim arg4 As String = ""

        For i As Integer = index1 To input.Length - 1
            index1 = index1 + 1
            If input(i) = "." Then
                Exit For
            Else
                arg1 = arg1 + input(i)
            End If
        Next
        For i As Integer = index1 To input.Length - 1
            index1 = index1 + 1
            If input(i) = "." Then
                Exit For
            Else
                arg2 = arg2 + input(i)
            End If
        Next
        For i As Integer = index1 To input.Length - 1
            index1 = index1 + 1
            If input(i) = "." Then
                Exit For
            Else
                arg3 = arg3 + input(i)
            End If
        Next
        For i As Integer = index1 To input.Length - 1
            index1 = index1 + 1
            If input(i) = "." Then
                Exit For
            Else
                arg4 = arg4 + input(i)
            End If
        Next
        PduUserConnectionData1.IpAddpessBox1.InpIPTextBox1.Text = arg1
        PduUserConnectionData1.IpAddpessBox1.InpIPTextBox2.Text = arg2
        PduUserConnectionData1.IpAddpessBox1.InpIPTextBox3.Text = arg3
        PduUserConnectionData1.IpAddpessBox1.InpIPTextBox4.Text = arg4
    End Sub
    Private Sub ClearMonitoring()
        ThisDeviceModule().monitoringMode(False)
    End Sub
    Private Sub ClearPage()
        'очистка "PDU connection settings"
        ThisDevicePage.PduUserConnectionData1.clear()

        'очистка "Information"
        ThisDevicePage.PartNumberBox.Text = ""
        ThisDevicePage.MacAddrBox.Text = ""
        ThisDevicePage.SoftVersionBox.Text = ""

        'очистка AlertPage
        My.Forms.Workspace.AllertConfig1.PDUAAlertTable.Visible = False
        My.Forms.Workspace.AllertConfig1.PDUAAlertTable.ActivateTable("")
        My.Forms.Workspace.AllertConfig1.PDUBAlertTable.Visible = False
        My.Forms.Workspace.AllertConfig1.PDUBAlertTable.ActivateTable("")

        'очистка "General settings"
        ThisDevicePage.PduGeneralSetting1.LocationBox.Text = ""
        ThisDevicePage.PduGeneralSetting1.NameBox.Text = ""
        ThisDevicePage.PduGeneralSetting1.dhcpcheck.Checked = False
        ThisDevicePage.PduGeneralSetting1.Ipaddrbox.Text = ""
        ThisDevicePage.PduGeneralSetting1.SubnetBox.Text = ""
        ThisDevicePage.PduGeneralSetting1.GatewayBox.Text = ""
        ThisDevicePage.PduGeneralSetting1.UserpasBox.Text = ""
        ThisDevicePage.PduGeneralSetting1.AdminPassBox.Text = ""
        ThisDevicePage.PduGeneralSetting1.LogTimeOutComboBox.SelectedIndex = 0
        ThisDevicePage.PduGeneralSetting1.AutoRefreshWebsiteComboBox.SelectedIndex = 0
        ThisDevicePage.PduGeneralSetting1.TemperatureMonitor.Checked = False

        ThisDevicePage.PduGeneralSetting1.SMTPNameBox.Text = ""
        ThisDevicePage.PduGeneralSetting1.SMTPPassBox.Text = ""
        ThisDevicePage.PduGeneralSetting1.SMTPSenderBox.Text = ""
        ThisDevicePage.PduGeneralSetting1.SMTPPecientBox.Text = ""
        ThisDevicePage.PduGeneralSetting1.SMTPIPaddrServerBox.Text = ""
        ThisDevicePage.PduGeneralSetting1.SMTPPortNumBox.Text = ""
        ThisDevicePage.PduGeneralSetting1.SyslogIPaddrBox.Text = ""
        ThisDevicePage.PduGeneralSetting1.SyslogPortNumBox.Text = ""
        ThisDevicePage.PduGeneralSetting1.SNMPPrivateCommBox.Text = ""
        ThisDevicePage.PduGeneralSetting1.SNMPPublicComBox.Text = ""
        ThisDevicePage.PduGeneralSetting1.SNMPIPaddrfTrap.Text = ""
        ThisDevicePage.PduGeneralSetting1.SNTPIPaddrServer.Text = ""

        ThisDevicePage.PduSensorsSetting1.Clear()
    End Sub
    '---------------------------------------------------------------------------------------------------------------
    'ОСНОВНЫЕ ФУНКЦИИ-----------------------------------------------------------------------------------------------
    Public Function ConnectFunction() As Boolean
        If ThisDeviceModule.startDevice(thisDeviceProfileData) Then
            Cycle.Start()
            Return True
        End If
        Return False
    End Function
    Public Sub FullClear()
        'stop таймеры 
        Cycle_Stop()
        ThisDeviceModule.clear()
        If ThisDeviceModule.connectToDevice IsNot Nothing Then
            If ThisDeviceModule.connectToDevice.WebConnection IsNot Nothing Then
                If ThisDeviceModule.connectToDevice.WebConnection.MonitoringTimer IsNot Nothing Then
                    ThisDeviceModule.connectToDevice.WebConnection.MonitoringTimer.Stop()
                End If
            End If
        End If
        ThisDeviceModule.CheckCycle.Stop()
        ClearMonitoring()
        ClearPage()
        'Удаление данных об усройсве из файла пользователя
        thisDeviceProfileData.clear()
        'Очистка переменных интерфейса 
        SensorTypeTableActivated = False
        FullDataPDUfilled = False
    End Sub
    Private Function Datarefresh() As Boolean
        If FullDataPDUfilled Then
            Return True
        Else
            Logo.ImageLocation = ThisDeviceModule.dataFile.Logo.ImageLocation
            FillPage("PDUConSetting")
            If FillPage("info") Then
                If FillPage("PDUConigData") Then
                    If FillPage("AlertConfigData") Then
                        FullDataPDUfilled = True
                        Return True
                    End If
                End If
            End If
        End If
        Return False
    End Function
    Private Function FillPage(input As String) As Boolean
        If input = "PDUConSetting" Then
            IPconverterToInputBox(thisDeviceProfileData.IP.FullString)
            PduUserConnectionData1.PasswordBox.Text = thisDeviceProfileData.Password
        End If
        If input = "info" Then
            PartNumberBox.Text = ThisDeviceModule.dataFile.information.PartNumber
            MacAddrBox.Text = ThisDeviceModule.dataFile.information.MACAdress
            SoftVersionBox.Text = ThisDeviceModule.dataFile.information.SoftwareVersion
            Return True
        End If
        If input = "PDUConigData" Then
            PduGeneralSetting1.LocationBox.Text = ThisDeviceModule.dataFile.PDUConfig.Location
            PduGeneralSetting1.NameBox.Text = ThisDeviceModule.dataFile.PDUConfig.Name
            If ThisDeviceModule.dataFile.PDUConfig.DHCPClient = "0" Then
                PduGeneralSetting1.dhcpcheck.Checked = False
            Else
                PduGeneralSetting1.dhcpcheck.Checked = True
            End If
            PduGeneralSetting1.Ipaddrbox.Text = ThisDeviceModule.dataFile.PDUConfig.IPAddress
            PduGeneralSetting1.SubnetBox.Text = ThisDeviceModule.dataFile.PDUConfig.SubnetMask
            PduGeneralSetting1.GatewayBox.Text = ThisDeviceModule.dataFile.PDUConfig.Gateway
            PduGeneralSetting1.UserpasBox.Text = ThisDeviceModule.dataFile.PDUConfig.UserPassword
            PduGeneralSetting1.AdminPassBox.Text = ThisDeviceModule.dataFile.PDUConfig.AdminPassword
            If ThisDeviceModule.dataFile.PDUConfig.LoginTimeOut = "1" Then
                PduGeneralSetting1.LogTimeOutComboBox.SelectedIndex = 0
            End If
            If ThisDeviceModule.dataFile.PDUConfig.LoginTimeOut = "5" Then
                PduGeneralSetting1.LogTimeOutComboBox.SelectedIndex = 1
            End If
            If ThisDeviceModule.dataFile.PDUConfig.LoginTimeOut = "20" Then
                PduGeneralSetting1.LogTimeOutComboBox.SelectedIndex = 2
            End If
            If ThisDeviceModule.dataFile.PDUConfig.LoginTimeOut = "60" Then
                PduGeneralSetting1.LogTimeOutComboBox.SelectedIndex = 3
            End If
            If ThisDeviceModule.dataFile.PDUConfig.AutoRefreshWebsite = "3" Then
                PduGeneralSetting1.AutoRefreshWebsiteComboBox.SelectedIndex = 0
            End If
            If ThisDeviceModule.dataFile.PDUConfig.AutoRefreshWebsite = "10" Then
                PduGeneralSetting1.AutoRefreshWebsiteComboBox.SelectedIndex = 1
            End If
            If ThisDeviceModule.dataFile.PDUConfig.AutoRefreshWebsite = "60" Then
                PduGeneralSetting1.AutoRefreshWebsiteComboBox.SelectedIndex = 2
            End If
            PduGeneralSetting1.TemperatureMonitor.Checked = ThisDeviceModule.dataFile.PDUConfig.Temperature
            Return True
        End If
        If input = "AlertConfigData" Then
            PduGeneralSetting1.SMTPNameBox.Text = ThisDeviceModule.dataFile.Alert.SMTPUsername
            PduGeneralSetting1.SMTPPassBox.Text = ThisDeviceModule.dataFile.Alert.SMPTPassword
            PduGeneralSetting1.SMTPSenderBox.Text = ThisDeviceModule.dataFile.Alert.SMTPSender
            PduGeneralSetting1.SMTPPecientBox.Text = ThisDeviceModule.dataFile.Alert.SMTPReciepient
            PduGeneralSetting1.SMTPIPaddrServerBox.Text = ThisDeviceModule.dataFile.Alert.SMTPIPAddressForServer
            PduGeneralSetting1.SMTPPortNumBox.Text = ThisDeviceModule.dataFile.Alert.SMTPPortNumber
            PduGeneralSetting1.SyslogIPaddrBox.Text = ThisDeviceModule.dataFile.Alert.SyslogIPAddress
            PduGeneralSetting1.SyslogPortNumBox.Text = ThisDeviceModule.dataFile.Alert.SyslogPortNumber
            PduGeneralSetting1.SNMPPrivateCommBox.Text = ThisDeviceModule.dataFile.Alert.SNMPPrivateCommunity
            PduGeneralSetting1.SNMPPublicComBox.Text = ThisDeviceModule.dataFile.Alert.SNMPPublicCommunity
            PduGeneralSetting1.SNMPIPaddrfTrap.Text = ThisDeviceModule.dataFile.Alert.SNMPIPAddressForTrap
            PduGeneralSetting1.SNTPIPaddrServer.Text = ThisDeviceModule.dataFile.Alert.SNTPIPAddresForServer
            Return True
        End If
        Return False
    End Function
    '---------------------------------------------------------------------------------------------------------------
    'КНОПКИ---------------------------------------------------------------------------------------------------------
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        'Сохранить вкладку General setting в PDU
        Workspace.LoadingPage1.Visible = True
        Workspace.LoadingPage1.ProgressBar1.Value = 0
        Workspace.LoadingPage1.TextMessage.Text = "Saving data on the device " + ThisDeviceModule.connectToDevice.WebConnection.IP.FullString()

        If PDUTab.SelectedTab.TabIndex = 1 Then
        ElseIf PDUTab.SelectedTab.TabIndex = 2 Then

            Dim Tab1 As String = PduGeneralSetting1.LocationBox.Text + PduGeneralSetting1.NameBox.Text + PduGeneralSetting1.dhcpcheck.Checked.ToString + PduGeneralSetting1.Ipaddrbox.Text + PduGeneralSetting1.SubnetBox.Text + PduGeneralSetting1.GatewayBox.Text + PduGeneralSetting1.UserpasBox.Text + PduGeneralSetting1.AdminPassBox.Text + PduGeneralSetting1.LogTimeOutComboBox.Text + PduGeneralSetting1.AutoRefreshWebsiteComboBox.Text
            Dim tab2 As String = PduGeneralSetting1.TemperatureMonitor.Checked.ToString
            Dim tab3 As String = PduGeneralSetting1.SMTPNameBox.Text + PduGeneralSetting1.SMTPPassBox.Text + PduGeneralSetting1.SMTPSenderBox.Text + PduGeneralSetting1.SMTPPecientBox.Text + PduGeneralSetting1.SMTPIPaddrServerBox.Text + PduGeneralSetting1.SMTPPortNumBox.Text + PduGeneralSetting1.SyslogIPaddrBox.Text + PduGeneralSetting1.SyslogPortNumBox.Text + PduGeneralSetting1.SNMPPrivateCommBox.Text + PduGeneralSetting1.SNMPPublicComBox.Text + PduGeneralSetting1.SNMPIPaddrfTrap.Text + PduGeneralSetting1.SNTPIPaddrServer.Text
            If Tab1 = genSetTableGenSetBackup Then
                ThisDeviceModule.SaveFunc("GeneralSetting")
            End If
            If tab2 <> genSetTableTempMonBackup Then
                ThisDeviceModule.SaveFunc("TemperatureMonitored")
            End If
            If tab3 <> genSetTableAlertConfBackup Then
                ThisDeviceModule.SaveFunc("AllertConfiguration")
                genSetTableGenSetBackup = tab3
            End If
        ElseIf PDUTab.SelectedTab.TabIndex = 3 Then
        End If
        Workspace.LoadingPage1.Visible = False
        Workspace.LoadingPage1.ProgressBar1.Value = 0
        Workspace.LoadingPage1.TextMessage.Text = ""
    End Sub
    Private Sub SoftReset_Click(sender As Object, e As EventArgs) Handles SoftReset.Click
        Dim a As Integer
        a = MsgBox("Due to a restart, the device " + ThisDeviceModule.connectToDevice.WebConnection.IP.FullString() + " will be unavailable for 1-3 minute, do you want to continue?", 323, "")
        If a = 6 Then
            My.Forms.Workspace.LoadingPage1.LoadingMode(1)
            Workspace.LoadingPage1.Visible = True
            If ThisDeviceModule.ResetPDU() Then
                Workspace.Log1.SendMessagesFunction(New Message("Message", "", LoginnedProfile.Login + " (" + thisDeviceProfileData.IP.FullString + ")" + " Successfully rebooted"))
            Else
                Workspace.Log1.SendMessagesFunction(New Message("Message", "", "An error occurred while rebooting the device " + ThisDeviceModule.Name + "(" + ThisDeviceModule.connectToDevice.WebConnection.IP.FullString + ")"))
            End If
            Workspace.LoadingPage1.Visible = False
            My.Forms.Workspace.LoadingPage1.LoadingMode(2)
        End If
    End Sub
    '---------------------------------------------------------------------------------------------------------------
    'СОБЫТИЯ-------------------------------------------------------------------------------------------------------
    Private Sub PDUConfigPage_viseble(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        PduUserConnectionData1.ThisDevice = Me.Name
        If Me.Visible Then
            If Me.Name.ToString = "_Listwa1" Then
                Label3.Text = "PDU A CONFIGURATION"
            ElseIf Me.Name.ToString = "_Listwa2" Then
                Label3.Text = "PDU B CONFIGURATION"
            End If
        End If
    End Sub
    Private Sub GenSetTabPage_Click(sender As Object, e As EventArgs) Handles GenSetTabPage.VisibleChanged
        If GenSetTabPage.Visible = True Then
            genSetTableGenSetBackup = PduGeneralSetting1.LocationBox.Text + PduGeneralSetting1.NameBox.Text + PduGeneralSetting1.dhcpcheck.Checked.ToString + PduGeneralSetting1.Ipaddrbox.Text + PduGeneralSetting1.SubnetBox.Text + PduGeneralSetting1.GatewayBox.Text + PduGeneralSetting1.UserpasBox.Text + PduGeneralSetting1.AdminPassBox.Text + PduGeneralSetting1.LogTimeOutComboBox.Text + PduGeneralSetting1.AutoRefreshWebsiteComboBox.Text
            genSetTableTempMonBackup = PduGeneralSetting1.TemperatureMonitor.Checked.ToString
            genSetTableAlertConfBackup = PduGeneralSetting1.SMTPNameBox.Text + PduGeneralSetting1.SMTPPassBox.Text + PduGeneralSetting1.SMTPSenderBox.Text + PduGeneralSetting1.SMTPPecientBox.Text + PduGeneralSetting1.SMTPIPaddrServerBox.Text + PduGeneralSetting1.SMTPPortNumBox.Text + PduGeneralSetting1.SyslogIPaddrBox.Text + PduGeneralSetting1.SyslogPortNumBox.Text + PduGeneralSetting1.SNMPPrivateCommBox.Text + PduGeneralSetting1.SNMPPublicComBox.Text + PduGeneralSetting1.SNMPIPaddrfTrap.Text + PduGeneralSetting1.SNTPIPaddrServer.Text
        End If
    End Sub
    Public Sub VisibleInterface(mode As Boolean)
        If mode Then
            If ThisDeviceModule.Online Then
                PduSensorsSetting1.Enabled = True
                thisDeviceAlertPage.Enabled = True
                Label6.Enabled = True
                Label7.Enabled = True
                Label8.Enabled = True
                PartNumberBox.Enabled = False
                MacAddrBox.Enabled = False
                SoftVersionBox.Enabled = False
                PduUserConnectionData1.Delete.Enabled = True
                PDUTab.TabPages.Item(1).Enabled = True
                PDUTab.TabPages.Item(2).Enabled = False
                PduGeneralSetting1.Enabled = True
                SoftReset.Enabled = True
            End If
        Else
            If ThisDeviceModule.Online Then
                thisDeviceAlertPage.Enabled = False
                PduGeneralSetting1.Enabled = False
                PduSensorsSetting1.Enabled = True
                PduUserConnectionData1.Delete.Enabled = True
                PDUTab.TabPages.Item(1).Enabled = False
                PDUTab.TabPages.Item(2).Enabled = False
                SoftReset.Enabled = True
                SoftReset.Enabled = False
            End If
        End If
    End Sub
    Public Sub UnvisibleInterface()
        If ThisDeviceModule.Online <> True Then
            thisDeviceAlertPage.Enabled = False
            PduGeneralSetting1.Enabled = False
            PduSensorsSetting1.Enabled = False
            PduUserConnectionData1.Delete.Enabled = False
            PduUserConnectionData1.clear()
            PDUTab.TabPages.Item(1).Enabled = False
            PDUTab.TabPages.Item(2).Enabled = False
            SoftReset.Enabled = False
            SoftReset.Enabled = False
        End If
    End Sub
    Public Function thisDeviceAlertPage() As WindowsApp3.AlertTable
        If Me.Name = "_Listwa1" Then
            Return My.Forms.Workspace.AllertConfig1.PDUAAlertTable
        End If
        If Me.Name = "_Listwa2" Then
            Return My.Forms.Workspace.AllertConfig1.PDUBAlertTable
        End If
        Return Nothing
    End Function
End Class
