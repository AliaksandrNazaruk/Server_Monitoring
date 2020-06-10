Public Class PDUWebConnection
    Public IP As IPaddress = New IPaddress(0, 0, 0, 0)
    Public PORT As String = ""
    Public STATUS As String = ""
    Public LOGIN As String = ""
    Public PASS As String = ""
    Public Session As SessionClass = New SessionClass
    Public FILE As ExportDataFileForPDU = New ExportDataFileForPDU
    Public Function LoginFunc() As Boolean
        Session = New SessionClass
        WebBrowser1 = New WebBrowser
        If gotoWebPage(getHost("Index")) Then
            wait(5000)
            For Each h As HtmlElement In WebBrowser1.Document.Body.GetElementsByTagName("input")

                If h.Name Is Nothing Then
                    Return False
                End If
                If h.GetAttribute("name").Equals("pw") Then
                    WebBrowser1.Document.GetElementById("pw").SetAttribute("value", PASS)
                    For Each s As HtmlElement In WebBrowser1.Document.Body.GetElementsByTagName("input")
                        If s.GetAttribute("type").Equals("submit") Then
                            s.InvokeMember("click")
                            wait(1000)
                            TimeOuttimer.Start()
                            While Session.Number Is Nothing And timeOut < timerValue
                                Application.DoEvents()
                                If Session.Number Is Nothing Then
                                    If WebBrowser1.Url.ToString() = getHost("Home") And WebBrowser1.ReadyState = WebBrowserReadyState.Complete Then
                                        Session.Number = grabSessionNumber()
                                    End If
                                End If
                            End While
                            TimeOuttimer.Stop()
                            If Session.Number IsNot Nothing Then
                                Return True
                            Else
                                Return False
                            End If
                        End If
                    Next
                End If
            Next
        End If
        Return False
    End Function
    Public Function Logining() As Boolean
        STATUS = "CHECKING_LOGIN"
        If WebBrowser1.Url Is Nothing Then
            STATUS = "LOGIN_FALSE"
            Return False
        End If
        If WebBrowser1.Url.ToString = getHost("Monitoring") Or
             WebBrowser1.Url.ToString = getHost("PDUCOnfig") Or
              WebBrowser1.Url.ToString = getHost("Alert") Or
               WebBrowser1.Url.ToString = getHost("Date") Or
                WebBrowser1.Url.ToString = getHost("LOG") Then
            If WebBrowser1.Document.Url.AbsolutePath.IndexOf("dnserror") >= 0 Then
            Else
                STATUS = "LOGIN_TRUE"
                Return True
            End If
        End If
        STATUS = "LOGIN_FALSE"
        Return False
    End Function
    Public Function ResetFunction() As Boolean
        If Logining() <> True Then
            startWebBrowserConfig()
            Return False
        End If
        gotoWebPage(getHost("Reboot"))
        resetLock = True
        WaitTimer.Start()
        While WebBrowser1.Url.ToString <> getHost("Index") AndAlso WaitTimerCalcVal < 60000
            wait(5000)
            If WebBrowser1.Url.ToString = getHost("Index") Then
                If WebBrowser1.ReadyState = WebBrowserReadyState.Complete Then
                    Session = New SessionClass
                    resetLock = False
                    WaitTimer.Stop()
                    WaitTimerCalcVal = 0
                    Return True
                End If
            ElseIf WebBrowser1.Url.ToString = getHost("Monitoring") Then
                resetLock = False
                WaitTimer.Stop()
                WaitTimerCalcVal = 0
                Return True
            End If
        End While
        Session = New SessionClass
        resetLock = False
        WaitTimer.Stop()
        WaitTimerCalcVal = 0
        Return False
    End Function


    Private Function SessionWebLogin() As Boolean
        STATUS = "LOGS_IN"
        gotoWebPage(getHost("Login"))
        If WebBrowser1.Url.ToString = getHost("Index") Then
            STATUS = "LOGGET_IN"
            Return True
        End If
        STATUS = "LOGS_FAILED"
        Return False
    End Function
    Private goToLock As Boolean = False
    Public Function ValidationСheck(input As String) As Boolean
        If My.Computer.Network.IsAvailable <> True Then
            STATUS = "TRANSITION_TO_WEBSITE_FAILED"
            Return False
        End If
        If input Is Nothing Then
            STATUS = "TRANSITION_TO_WEBSITE_FAILED"
            Return False
        End If
        If input <> getHost("Monitoring") Then
            STATUS = "MONITORING_TIMER_STOPPED"
            MonitoringTimer.Stop()
        End If
        Return True
    End Function
    Public Function gotoWebPage(addr As String) As Boolean
        STATUS = "PREPARING_FOR_THE_TRANSITION_TO_WEBSITE"
        If ValidationСheck(addr) <> True Then
            Return False
        End If

        Dim num1 As Integer = 10000
        Dim num2 As Integer = 0

        If addr.IndexOf("adminwait") >= 0 Then
            addr = getHost("PDUCOnfig")
            num1 = 20000
        ElseIf addr.IndexOf("admin2wait") >= 0 Then
            addr = getHost("Alert")
            num1 = 20000
        End If

        If addr = getHost("MonitoringConfig") Then
            WebBrowser1.Navigate(addr)
            STATUS = "TRANSITION_TO_MONITORING_CONFIGURATION"
        ElseIf addr.IndexOf("monitoringwait.html") > 0 Then
            WebBrowser1.Navigate(addr)
            addr = getHost("MonitoringConfig")
        ElseIf addr = getHost("Reboot") Then
            WebBrowser1.Navigate(addr)
            addr = getHost("Reboot")
        Else
            WebBrowser1.Navigate(addr)
        End If
        wait(2000)
        If (WebBrowser1.Url IsNot Nothing) Then
            While ((WebBrowser1.Url.ToString() <> addr OrElse WebBrowser1.ReadyState <> WebBrowserReadyState.Complete) AndAlso num2 < num1)
                wait(500)
                num2 = num2 + 500
            End While
            If num2 >= num1 Then
                STATUS = "TRANSITION_TO_WEBSITE_FAILED"
                Return False
            End If
            If WebBrowser1.Document.Url.AbsolutePath.IndexOf("dnserror") >= 0 Then
                STATUS = "TRANSITION_TO_WEBSITE_FAILED"
                Return False
            End If
            If WebBrowser1.Url.ToString() = addr Then
                STATUS = "TRANSITION_TO_WEBSITE_TRUE"
                Return True
            End If
        End If
        STATUS = "TRANSITION_TO_WEBSITE_FAILED"
        Return False
    End Function

    Public WithEvents WaitTimer As Timer = New Timer
    Public WaitTimerCalcVal As Integer = 0
    Public WaitTimerEnable As Boolean = False
    Public Function wait(input As Integer)
        If WaitTimerEnable <> True Then
            WaitTimer.Interval = 10
            WaitTimerCalcVal = 0
            WaitTimerCalcVal = WaitTimerCalcVal + WaitTimer.Interval
            WaitTimer.Start()
            While WaitTimerCalcVal < input
                WaitTimerEnable = True
                Application.DoEvents()
            End While
            WaitTimerEnable = False
            WaitTimer.Stop()
            WaitTimerCalcVal = 0
        End If
    End Function
    Public Sub WaitTimer_Tick() Handles WaitTimer.Tick
        WaitTimerCalcVal = WaitTimerCalcVal + WaitTimer.Interval
    End Sub

    Public Function getPDUConfigTable() As WebPDUConfigurationCard
        If Session.Number Is Nothing Then
            Return Nothing
        End If
        Dim buf = Walk("PDUCOnfig")
        If buf Is Nothing Then
            Return Nothing
        End If
        Dim newCard As WebPDUConfigurationCard = New WebPDUConfigurationCard
        If buf Is Nothing Then
            Return Nothing
        End If
        If buf(1, 1) IsNot Nothing Then
            newCard.Location = buf(1, 1)
        Else
            Return Nothing
        End If
        If buf(2, 1) IsNot Nothing Then
            newCard.Name = buf(2, 1)
        Else
            Return Nothing
        End If
        If buf(3, 1) IsNot Nothing Then
            newCard.DHCPClient = buf(3, 1)
        Else
            Return Nothing
        End If
        If buf(4, 1) IsNot Nothing Then
            newCard.IPAddress = buf(4, 1)
        Else
            Return Nothing
        End If
        If buf(5, 1) IsNot Nothing Then
            newCard.SubnetMask = buf(5, 1)
        Else
            Return Nothing
        End If
        If buf(6, 1) IsNot Nothing Then
            newCard.Gateway = buf(6, 1)
        Else
            Return Nothing
        End If
        If buf(7, 1) IsNot Nothing Then
            newCard.UserPassword = buf(7, 1)
        Else
            Return Nothing
        End If
        If buf(8, 1) IsNot Nothing Then
            newCard.AdminPassword = buf(8, 1)
        Else
            Return Nothing
        End If
        If buf(9, 1) IsNot Nothing Then
            newCard.LoginTimeOut = buf(9, 1)
        Else
            Return Nothing
        End If
        If buf(10, 1) IsNot Nothing Then
            newCard.AutoRefreshWebsite = buf(10, 1)
        Else
            Return Nothing
        End If
        If buf(11, 1) = "1" Then
            newCard.Temperature = True
        End If
        If buf(11, 1) = "0" Then
            newCard.Temperature = False
        End If
        Return newCard
    End Function

    Public Function getMonitoringConfigTable() As WebMonitoringConfigurationCard

        If Session.Number Is Nothing Then
            Return Nothing
        End If
        Dim buf = Walk("MonitoringConfig")
        If buf Is Nothing Then
            Return Nothing
        End If
        Dim configurationCard As WebMonitoringConfigurationCard = New WebMonitoringConfigurationCard

        configurationCard.Phase1.Ampermeter1.Min = buf(1, 1)
        configurationCard.Phase1.Ampermeter1.warn = buf(2, 1)
        configurationCard.Phase1.Ampermeter1.Max = buf(3, 1)
        configurationCard.Phase1.Ampermeter1.Email = buf(4, 1)
        configurationCard.Phase1.Ampermeter1.Syslog = buf(5, 1)
        configurationCard.Phase1.Ampermeter1.Log = buf(6, 1)
        configurationCard.Phase1.Ampermeter1.Trap = buf(7, 1)
        configurationCard.Phase1.Ampermeter1.Alarm0A = buf(8, 1)

        configurationCard.Phase1.Ampermeter2.Min = buf(9, 1)
        configurationCard.Phase1.Ampermeter2.warn = buf(10, 1)
        configurationCard.Phase1.Ampermeter2.Max = buf(11, 1)
        configurationCard.Phase1.Ampermeter2.Email = buf(12, 1)
        configurationCard.Phase1.Ampermeter2.Syslog = buf(13, 1)
        configurationCard.Phase1.Ampermeter2.Log = buf(14, 1)
        configurationCard.Phase1.Ampermeter2.Trap = buf(15, 1)
        configurationCard.Phase1.Ampermeter2.Alarm0A = buf(16, 1)



        configurationCard.Phase2.Ampermeter1.Min = buf(17, 1)
        configurationCard.Phase2.Ampermeter1.warn = buf(18, 1)
        configurationCard.Phase2.Ampermeter1.Max = buf(19, 1)
        configurationCard.Phase2.Ampermeter1.Email = buf(20, 1)
        configurationCard.Phase2.Ampermeter1.Syslog = buf(21, 1)
        configurationCard.Phase2.Ampermeter1.Log = buf(22, 1)
        configurationCard.Phase2.Ampermeter1.Trap = buf(23, 1)
        configurationCard.Phase2.Ampermeter1.Alarm0A = buf(24, 1)

        configurationCard.Phase2.Ampermeter2.Min = buf(25, 1)
        configurationCard.Phase2.Ampermeter2.warn = buf(26, 1)
        configurationCard.Phase2.Ampermeter2.Max = buf(27, 1)
        configurationCard.Phase2.Ampermeter2.Email = buf(28, 1)
        configurationCard.Phase2.Ampermeter2.Syslog = buf(29, 1)
        configurationCard.Phase2.Ampermeter2.Log = buf(30, 1)
        configurationCard.Phase2.Ampermeter2.Trap = buf(31, 1)
        configurationCard.Phase2.Ampermeter2.Alarm0A = buf(32, 1)


        configurationCard.Phase3.Ampermeter1.Min = buf(33, 1)
        configurationCard.Phase3.Ampermeter1.warn = buf(34, 1)
        configurationCard.Phase3.Ampermeter1.Max = buf(35, 1)
        configurationCard.Phase3.Ampermeter1.Email = buf(36, 1)
        configurationCard.Phase3.Ampermeter1.Syslog = buf(37, 1)
        configurationCard.Phase3.Ampermeter1.Log = buf(38, 1)
        configurationCard.Phase3.Ampermeter1.Trap = buf(39, 1)
        configurationCard.Phase3.Ampermeter1.Alarm0A = buf(40, 1)


        configurationCard.Phase3.Ampermeter2.Min = buf(41, 1)
        configurationCard.Phase3.Ampermeter2.warn = buf(42, 1)
        configurationCard.Phase3.Ampermeter2.Max = buf(43, 1)
        configurationCard.Phase3.Ampermeter2.Email = buf(44, 1)
        configurationCard.Phase3.Ampermeter2.Syslog = buf(45, 1)
        configurationCard.Phase3.Ampermeter2.Log = buf(46, 1)
        configurationCard.Phase3.Ampermeter2.Trap = buf(47, 1)
        configurationCard.Phase3.Ampermeter2.Alarm0A = buf(48, 1)



        configurationCard.Phase1.Email = buf(49, 1)
        configurationCard.Phase1.Syslog = buf(50, 1)
        configurationCard.Phase1.Log = buf(51, 1)
        configurationCard.Phase1.Trap = buf(52, 1)
        configurationCard.Phase2.Email = buf(53, 1)
        configurationCard.Phase2.Syslog = buf(54, 1)
        configurationCard.Phase2.Log = buf(55, 1)
        configurationCard.Phase2.Trap = buf(56, 1)
        configurationCard.Phase3.Email = buf(57, 1)
        configurationCard.Phase3.Syslog = buf(58, 1)
        configurationCard.Phase3.Log = buf(59, 1)
        configurationCard.Phase3.Trap = buf(60, 1)
        configurationCard.Temp.Trigger = buf(61, 1)
        configurationCard.Temp.Email = buf(62, 1)
        configurationCard.Temp.Syslog = buf(63, 1)
        configurationCard.Temp.Log = buf(64, 1)
        configurationCard.Temp.Trap = buf(65, 1)
        Return configurationCard
    End Function

    Public Function getAlertConfigTable() As WebAlertConfigurationCard
        If Session.Number Is Nothing Then
            Return Nothing
        End If
        Dim buf = Walk("Alert")
        If buf Is Nothing Then
            Return Nothing
        End If
        Dim newCard As WebAlertConfigurationCard = New WebAlertConfigurationCard
        newCard.SMTPUsername = buf(1, 1)
        newCard.SMPTPassword = buf(2, 1)
        newCard.SMTPSender = buf(3, 1)
        newCard.SMTPReciepient = buf(4, 1)
        newCard.SMTPIPAddressForServer = buf(5, 1)
        newCard.SMTPPortNumber = buf(6, 1)
        newCard.SyslogIPAddress = buf(7, 1)
        newCard.SyslogPortNumber = buf(8, 1)
        newCard.SNMPPrivateCommunity = buf(9, 1)
        newCard.SNMPPublicCommunity = buf(10, 1)
        newCard.SNMPIPAddressForTrap = buf(11, 1)
        newCard.SNTPIPAddresForServer = buf(12, 1)
        Return newCard
    End Function
    Public Function getTable() As WebMonitoringCard
        If Session Is Nothing Then
            Return Nothing
        End If
        Return FILE.Table
    End Function
    Private resetLock As Boolean = False

    Public Sub startWebBrowserConfig()
        Me.InitializeComponent()
        IP = New IPaddress(0, 0, 0, 0)
        LOGIN = ""
        PASS = ""
        Session = New SessionClass
        FILE = New ExportDataFileForPDU
        goToLock = False
        WaitTimer = New Timer
        WaitTimerCalcVal = 0
        WaitTimerEnable = False
        resetLock = False
        pagereadyWeb1 = False
        timer24 = New Timer
        calcValue = 0
        timeOut = 0
        timerValue = 15000
        TimeOuttimer = New Timer
        MonitoringTimerCalc = 0
        MonitoringStatusTimer = New Timer
        MonitoringStatus = False
        MonitoringLock = False
        lock = False
    End Sub
    '============================================================================================================
    Public Function getLog() As WebLogCard
        If Session.Number Is Nothing Then
            Return Nothing
        End If
        Dim buf = Walk("LOG")
        If buf Is Nothing Then
            Return Nothing
        End If
        Dim newCard As WebLogCard = New WebLogCard
        If buf Is Nothing Then
            Return Nothing
        End If
        newCard.Page1.String1 = buf(1, 1)
        newCard.Page2.String1 = buf(2, 1)
        newCard.Page3.String1 = buf(3, 1)
        newCard.Page4.String1 = buf(4, 1)
        newCard.Page5.String1 = buf(5, 1)
        newCard.Page6.String1 = buf(6, 1)
        newCard.Page7.String1 = buf(7, 1)
        newCard.Page8.String1 = buf(8, 1)
        newCard.Page9.String1 = buf(9, 1)
        newCard.Page10.String1 = buf(10, 1)
        newCard.Page11.String1 = buf(11, 1)
        newCard.Page12.String1 = buf(12, 1)
        Return newCard
    End Function
    Public Function getLogo() As PictureBox
        If Session.Number Is Nothing Then
            Return Nothing
        End If
        Dim buf = Walk("Logo")
        If buf Is Nothing Then
            Return Nothing
        End If
        Dim newCard As PictureBox = New PictureBox
        newCard.ImageLocation = buf(0, 0)
        Return newCard
    End Function
    Public Function getInformationCard() As WebInformationCard
        If Session.Number Is Nothing Then
            Return Nothing
        End If
        Dim buf = Walk("Leftpane")
        If buf Is Nothing Then
            Return Nothing
        End If
        Dim newCard As WebInformationCard = New WebInformationCard
        newCard.MACAdress = buf(3, 1)
        newCard.PartNumber = buf(4, 1)
        newCard.pduLocation = buf(0, 1)
        newCard.pduName = buf(1, 1)
        newCard.SoftwareVersion = buf(2, 1)
        Return newCard
    End Function
    Public Function getHost(input As String) As String
        Dim _port As String = ""
        If IP.installed() Then
            If PORT <> "" Then
                _port = ":" + PORT
            End If
            If input = "Home" Then
                Return "http://" + IP.FullString + _port + "/home.html"
            End If
            If input = "Leftpane" Then
                Return "http://" + IP.FullString + _port + "/leftpane.html"
            End If
            If input = "Logo" Then
                Return "http://" + IP.FullString + _port + "/leftpane.html"
            End If
            If input = "Login" Or input = "Index" Then
                Return "http://" + IP.FullString + _port + "/index.html"
            End If
            If Session.Number IsNot Nothing Then
                If input = "SaveMonitoringConfigPhase1A1" Then
                    Dim EmailCheckBox As String = "&YEE0X=0"
                    Dim SyslogCheckBox As String = "&YSE0X=0"
                    Dim LogCheckBox As String = "&YLE0X=0"
                    Dim TrapCheckBox As String = "&YTE0X=0"
                    Dim AlarmCheckBox As String = "&YWE0X=0"
                    If FILE.MonitoringConfiguration.Phase1.Ampermeter1.Email = "1" Then
                        EmailCheckBox = "&YEE0X=0" + "&YEE0X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase1.Ampermeter1.Syslog = "1" Then
                        SyslogCheckBox = "&YSE0X=0" + "&YSE0X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase1.Ampermeter1.Log = "1" Then
                        LogCheckBox = "&YLE0X=0" + "&YLE0X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase1.Ampermeter1.Trap = "1" Then
                        TrapCheckBox = "&YTE0X=0" + "&YTE0X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase1.Ampermeter1.Alarm0A = "1" Then
                        AlarmCheckBox = "&YWE0X=0" + "&YWE0X=1"
                    End If
                    Dim ret As String = "http://" + IP.FullString + _port + "/monitoringwait.html?session=" + Session.Number +
                    "&AME0X=" + FILE.MonitoringConfiguration.Phase1.Ampermeter1.Min +
                    "&AOE0X=" + FILE.MonitoringConfiguration.Phase1.Ampermeter1.warn +
                    "&APE0X=" + FILE.MonitoringConfiguration.Phase1.Ampermeter1.Max +
                    EmailCheckBox + SyslogCheckBox + LogCheckBox + TrapCheckBox + AlarmCheckBox
                    Return ret
                End If
                If input = "SaveMonitoringConfigPhase1A2" Then
                    Dim EmailCheckBox As String = "&YEE1X=0"
                    Dim SyslogCheckBox As String = "&YSE1X=0"
                    Dim LogCheckBox As String = "&YLE1X=0"
                    Dim TrapCheckBox As String = "&YTE1X=0"
                    Dim AlarmCheckBox As String = "&YWE1X=0"
                    If FILE.MonitoringConfiguration.Phase1.Ampermeter2.Email = "1" Then
                        EmailCheckBox = "&YEE1X=0" + "&YEE1X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase1.Ampermeter2.Syslog = "1" Then
                        SyslogCheckBox = "&YSE1X=0" + "&YSE1X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase1.Ampermeter2.Log = "1" Then
                        LogCheckBox = "&YLE1X=0" + "&YLE1X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase1.Ampermeter2.Trap = "1" Then
                        TrapCheckBox = "&YTE1X=0" + "&YTE1X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase1.Ampermeter2.Alarm0A = "1" Then
                        AlarmCheckBox = "&YWE1X=0" + "&YWE1X=1"
                    End If
                    Dim ret As String = "http://" + IP.FullString + _port + "/monitoringwait.html?session=" + Session.Number +
                    "&AME1X=" + FILE.MonitoringConfiguration.Phase1.Ampermeter2.Min +
                    "&AOE1X=" + FILE.MonitoringConfiguration.Phase1.Ampermeter2.warn +
                    "&APE1X=" + FILE.MonitoringConfiguration.Phase1.Ampermeter2.Max +
                    EmailCheckBox + SyslogCheckBox + LogCheckBox + TrapCheckBox + AlarmCheckBox
                    Return ret
                End If
                If input = "SaveMonitoringConfigPhase2A1" Then
                    Dim EmailCheckBox As String = "&YEE2X=0"
                    Dim SyslogCheckBox As String = "&YSE2X=0"
                    Dim LogCheckBox As String = "&YLE2X=0"
                    Dim TrapCheckBox As String = "&YTE2X=0"
                    Dim AlarmCheckBox As String = "&YWE2X=0"
                    If FILE.MonitoringConfiguration.Phase2.Ampermeter1.Email = "1" Then
                        EmailCheckBox = "&YEE2X=0" + "&YEE2X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase2.Ampermeter1.Syslog = "1" Then
                        SyslogCheckBox = "&YSE2X=0" + "&YSE2X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase2.Ampermeter1.Log = "1" Then
                        LogCheckBox = "&YLE2X=0" + "&YLE2X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase2.Ampermeter1.Trap = "1" Then
                        TrapCheckBox = "&YTE2X=0" + "&YTE2X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase2.Ampermeter1.Alarm0A = "1" Then
                        AlarmCheckBox = "&YWE2X=0" + "&YWE2X=1"
                    End If
                    Dim ret As String = "http://" + IP.FullString + _port + "/monitoringwait.html?session=" + Session.Number +
                    "&AME2X=" + FILE.MonitoringConfiguration.Phase2.Ampermeter1.Min +
                    "&AOE2X=" + FILE.MonitoringConfiguration.Phase2.Ampermeter1.warn +
                    "&APE2X=" + FILE.MonitoringConfiguration.Phase2.Ampermeter1.Max +
                    EmailCheckBox + SyslogCheckBox + LogCheckBox + TrapCheckBox + AlarmCheckBox
                    Return ret
                End If
                If input = "SaveMonitoringConfigPhase2A2" Then
                    Dim EmailCheckBox As String = "&YEE3X=0"
                    Dim SyslogCheckBox As String = "&YSE3X=0"
                    Dim LogCheckBox As String = "&YLE3X=0"
                    Dim TrapCheckBox As String = "&YTE3X=0"
                    Dim AlarmCheckBox As String = "&YWE3X=0"
                    If FILE.MonitoringConfiguration.Phase2.Ampermeter2.Email = "1" Then
                        EmailCheckBox = "&YEE3X=0" + "&YEE3X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase2.Ampermeter2.Syslog = "1" Then
                        SyslogCheckBox = "&YSE3X=0" + "&YSE3X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase2.Ampermeter2.Log = "1" Then
                        LogCheckBox = "&YLE3X=0" + "&YLE3X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase2.Ampermeter2.Trap = "1" Then
                        TrapCheckBox = "&YTE3X=0" + "&YTE3X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase2.Ampermeter2.Alarm0A = "1" Then
                        AlarmCheckBox = "&YWE3X=0" + "&YWE3X=1"
                    End If
                    Dim ret As String = "http://" + IP.FullString + _port + "/monitoringwait.html?session=" + Session.Number +
                    "&AME3X=" + FILE.MonitoringConfiguration.Phase2.Ampermeter2.Min +
                    "&AOE3X=" + FILE.MonitoringConfiguration.Phase2.Ampermeter2.warn +
                    "&APE3X=" + FILE.MonitoringConfiguration.Phase2.Ampermeter2.Max +
                    EmailCheckBox + SyslogCheckBox + LogCheckBox + TrapCheckBox + AlarmCheckBox
                    Return ret
                End If
                If input = "SaveMonitoringConfigPhase3A1" Then
                    Dim EmailCheckBox As String = "&YEE4X=0"
                    Dim SyslogCheckBox As String = "&YSE4X=0"
                    Dim LogCheckBox As String = "&YLE4X=0"
                    Dim TrapCheckBox As String = "&YTE4X=0"
                    Dim AlarmCheckBox As String = "&YWE4X=0"
                    If FILE.MonitoringConfiguration.Phase3.Ampermeter1.Email = "1" Then
                        EmailCheckBox = "&YEE4X=0" + "&YEE4X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase3.Ampermeter1.Syslog = "1" Then
                        SyslogCheckBox = "&YSE4X=0" + "&YSE4X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase3.Ampermeter1.Log = "1" Then
                        LogCheckBox = "&YLE4X=0" + "&YLE4X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase3.Ampermeter1.Trap = "1" Then
                        TrapCheckBox = "&YTE4X=0" + "&YTE4X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase3.Ampermeter1.Alarm0A = "1" Then
                        AlarmCheckBox = "&YWE4X=0" + "&YWE4X=1"
                    End If
                    Dim ret As String = "http://" + IP.FullString + _port + "/monitoringwait.html?session=" + Session.Number +
                    "&AME4X=" + FILE.MonitoringConfiguration.Phase3.Ampermeter1.Min +
                    "&AOE4X=" + FILE.MonitoringConfiguration.Phase3.Ampermeter1.warn +
                    "&APE4X=" + FILE.MonitoringConfiguration.Phase3.Ampermeter1.Max +
                    EmailCheckBox + SyslogCheckBox + LogCheckBox + TrapCheckBox + AlarmCheckBox
                    Return ret
                End If
                If input = "SaveMonitoringConfigPhase3A2" Then
                    Dim EmailCheckBox As String = "&YEE5X=0"
                    Dim SyslogCheckBox As String = "&YSE5X=0"
                    Dim LogCheckBox As String = "&YLE5X=0"
                    Dim TrapCheckBox As String = "&YTE5X=0"
                    Dim AlarmCheckBox As String = "&YWE5X=0"
                    If FILE.MonitoringConfiguration.Phase3.Ampermeter2.Email = "1" Then
                        EmailCheckBox = "&YEE5X=0" + "&YEE5X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase3.Ampermeter2.Syslog = "1" Then
                        SyslogCheckBox = "&YSE5X=0" + "&YSE5X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase3.Ampermeter2.Log = "1" Then
                        LogCheckBox = "&YLE5X=0" + "&YLE5X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase3.Ampermeter2.Trap = "1" Then
                        TrapCheckBox = "&YTE5X=0" + "&YTE5X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase3.Ampermeter2.Alarm0A = "1" Then
                        AlarmCheckBox = "&YWE5X=0" + "&YWE5X=1"
                    End If
                    Dim ret As String = "http://" + IP.FullString + _port + "/monitoringwait.html?session=" + Session.Number +
                    "&AME5X=" + FILE.MonitoringConfiguration.Phase3.Ampermeter2.Min +
                    "&AOE5X=" + FILE.MonitoringConfiguration.Phase3.Ampermeter2.warn +
                    "&APE5X=" + FILE.MonitoringConfiguration.Phase3.Ampermeter2.Max +
                    EmailCheckBox + SyslogCheckBox + LogCheckBox + TrapCheckBox + AlarmCheckBox
                    Return ret
                End If

                If input = "SaveMonitoringConfigPhase1" Then
                    Dim EmailCheckBox As String = "&YEE6X=0"
                    Dim SyslogCheckBox As String = "&YSE6X=0"
                    Dim LogCheckBox As String = "&YLE6X=0"
                    Dim TrapCheckBox As String = "&YTE6X=0"
                    Dim AlarmCheckBox As String = "&YWE6X=0"
                    If FILE.MonitoringConfiguration.Phase1.Email = "1" Then
                        EmailCheckBox = "&YEE6X=0" + "&YEE6X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase1.Syslog = "1" Then
                        SyslogCheckBox = "&YSE6X=0" + "&YSE6X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase1.Log = "1" Then
                        LogCheckBox = "&YLE6X=0" + "&YLE6X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase1.Trap = "1" Then
                        TrapCheckBox = "&YTE6X=0" + "&YTE6X=1"
                    End If
                    Dim ret As String = "http://" + IP.FullString + _port + "/monitoringwait.html?session=" + Session.Number +
                    EmailCheckBox + SyslogCheckBox + LogCheckBox + TrapCheckBox
                    Return ret
                End If
                If input = "SaveMonitoringConfigPhase2" Then
                    Dim EmailCheckBox As String = "&YEE7X=0"
                    Dim SyslogCheckBox As String = "&YSE7X=0"
                    Dim LogCheckBox As String = "&YLE7X=0"
                    Dim TrapCheckBox As String = "&YTE7X=0"
                    Dim AlarmCheckBox As String = "&YWE7X=0"
                    If FILE.MonitoringConfiguration.Phase2.Email = "1" Then
                        EmailCheckBox = "&YEE7X=0" + "&YEE7X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase2.Syslog = "1" Then
                        SyslogCheckBox = "&YSE7X=0" + "&YSE7X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase2.Log = "1" Then
                        LogCheckBox = "&YLE7X=0" + "&YLE7X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase2.Trap = "1" Then
                        TrapCheckBox = "&YTE7X=0" + "&YTE7X=1"
                    End If
                    Dim ret As String = "http://" + IP.FullString + _port + "/monitoringwait.html?session=" + Session.Number +
                    EmailCheckBox + SyslogCheckBox + LogCheckBox + TrapCheckBox
                    Return ret
                End If
                If input = "SaveMonitoringConfigPhase3" Then
                    Dim EmailCheckBox As String = "&YEE8X=0"
                    Dim SyslogCheckBox As String = "&YSE8X=0"
                    Dim LogCheckBox As String = "&YLE8X=0"
                    Dim TrapCheckBox As String = "&YTE8X=0"
                    Dim AlarmCheckBox As String = "&YWE8X=0"
                    If FILE.MonitoringConfiguration.Phase3.Email = "1" Then
                        EmailCheckBox = "&YEE8X=0" + "&YEE8X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase3.Syslog = "1" Then
                        SyslogCheckBox = "&YSE8X=0" + "&YSE8X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase3.Log = "1" Then
                        LogCheckBox = "&YLE8X=0" + "&YLE8X=1"
                    End If
                    If FILE.MonitoringConfiguration.Phase3.Trap = "1" Then
                        TrapCheckBox = "&YTE8X=0" + "&YTE8X=1"
                    End If
                    Dim ret As String = "http://" + IP.FullString + _port + "/monitoringwait.html?session=" + Session.Number +
                    EmailCheckBox + SyslogCheckBox + LogCheckBox + TrapCheckBox
                    Return ret
                End If

                If input = "SaveMonitoringConfigTemperature" Then
                    Dim value As String = "&PTE0X=" + FILE.MonitoringConfiguration.Temp.Trigger
                    Dim EmailCheckBox As String = "&XEE6X=0"
                    Dim SyslogCheckBox As String = "&XSE6X=0"
                    Dim LogCheckBox As String = "&XLE6X=0"
                    Dim TrapCheckBox As String = "&XTE6X=0"
                    If FILE.MonitoringConfiguration.Temp.Email = "1" Then
                        EmailCheckBox = "&XEE6X=0" + "&XEE6X=1"
                    End If
                    If FILE.MonitoringConfiguration.Temp.Syslog = "1" Then
                        SyslogCheckBox = "&XSE6X=0" + "&XSE6X=1"
                    End If
                    If FILE.MonitoringConfiguration.Temp.Log = "1" Then
                        LogCheckBox = "&XLE6X=0" + "&XLE6X=1"
                    End If
                    If FILE.MonitoringConfiguration.Temp.Trap = "1" Then
                        TrapCheckBox = "&XTE6X=0" + "&XTE6X=1"
                    End If
                    Dim ret As String = "http://" + IP.FullString + _port + "/monitoringwait.html?session=" + Session.Number +
                    value + EmailCheckBox + SyslogCheckBox + LogCheckBox + TrapCheckBox
                    Return ret
                End If

                If input = "SavePDUConfig" Then
                    Return "http://" + IP.FullString + _port + "/adminwait.html?session=" + Session.Number +
                    "&ONE=" + FILE.PDUConfiguration.Location +
                    "&DNE=" + FILE.PDUConfiguration.Name +
                    "&DHE=" + FILE.PDUConfiguration.DHCPClient +
                    "&IPE=" + FILE.PDUConfiguration.IPAddress +
                    "&NME=" + FILE.PDUConfiguration.SubnetMask +
                    "&GIE=" + FILE.PDUConfiguration.Gateway +
                    "&PWE=" + FILE.PDUConfiguration.UserPassword +
                    "&P2E=" + FILE.PDUConfiguration.AdminPassword +
                    "&ATE=" + FILE.PDUConfiguration.LoginTimeOut.Replace(" minutes", "") +
                    "&ARE=" + FILE.PDUConfiguration.AutoRefreshWebsite.Replace(" seconds", "")
                End If
                If input = "SeveTempMonitor" Then
                    If FILE.PDUConfiguration.Temperature Then
                        Return "http://" + IP.FullString + _port + "/servicereboot.html?session=" + Session.Number + "&PXE6X=0"
                    Else
                        Return "http://" + IP.FullString + _port + "/servicereboot.html?session=" + Session.Number + "&PXE6X=0&PXE6X=1"
                    End If
                End If
                If input = "AlertPDUConfig" Then
                    FILE.AlertConfiguration.SMTPUsername = FILE.AlertConfiguration.SMTPUsername.Replace("@", "%40")
                    FILE.AlertConfiguration.SMTPSender = FILE.AlertConfiguration.SMTPUsername.Replace("@", "%40")
                    FILE.AlertConfiguration.SMTPReciepient = FILE.AlertConfiguration.SMTPUsername.Replace("@", "%40")
                    Return "http://" + IP.FullString + _port + "/admin2wait.html?session=" + Session.Number +
                    "&MUE=" + FILE.AlertConfiguration.SMTPUsername +
                    "&MPE=" + FILE.AlertConfiguration.SMPTPassword +
                    "&MSE=" + FILE.AlertConfiguration.SMTPSender +
                    "&MRE=" + FILE.AlertConfiguration.SMTPReciepient +
                    "&MIE=" + FILE.AlertConfiguration.SMTPIPAddressForServer +
                    "&MTE=" + FILE.AlertConfiguration.SMTPPortNumber +
                    "&NIE=" + FILE.AlertConfiguration.SyslogIPAddress +
                    "&NPE=" + FILE.AlertConfiguration.SyslogPortNumber +
                    "&SRE=" + FILE.AlertConfiguration.SNMPPrivateCommunity +
                    "&SPE=" + FILE.AlertConfiguration.SNMPPublicCommunity +
                    "&SAE=" + FILE.AlertConfiguration.SNMPIPAddressForTrap +
                    "&NTE=" + FILE.AlertConfiguration.SNTPIPAddresForServer
                End If
                If input = "Monitoring" Then

                    Return "http://" + IP.FullString + _port + "/monitoring.html" + "?session=" + Session.Number
                End If
                If input = "MonitoringConfig" Then
                    Return "http://" + IP.FullString + _port + "/monitoring_admin.html?session=" + Session.Number
                End If
                If input = "PDUCOnfig" Then
                    Return "http://" + IP.FullString + _port + "/admin.html" + "?session=" + Session.Number
                End If
                If input = "Alert" Then
                    Return "http://" + IP.FullString + _port + "/admin2.html" + "?session=" + Session.Number
                End If
                If input = "Date" Then
                    Return "http://" + IP.FullString + _port + "/rtc.html" + "?session=" + Session.Number
                End If
                If input = "LOG" Then
                    Return "http://" + IP.FullString + _port + "/log.html" + "?session=" + Session.Number
                End If
                If input = "Reboot" Then
                    Return "http://" + IP.FullString + _port + "/reboot.html"
                End If
            End If
        End If
        Return Nothing
    End Function
    Public Function getStartMonitoring() As Boolean
        If Session Is Nothing Then
            Return False
        End If
        MonitoringStatus = False
        MonitoringStatusTimer.Interval = 100
        MonitoringTimerCalc = 0
        MonitoringStatusTimer.Start()
        Dim buf = Walk("Monitoring")
        If buf(0, 0) Is Nothing Then
            MonitoringStatus = False
            MonitoringTimerCalc = 0
            MonitoringStatusTimer.Interval = 100
            MonitoringStatusTimer.Stop()
            Return False
        End If
        Return True
    End Function
    Private Function grabSessionNumber() As String
        Dim ret As String = ""
        If gotoWebPage(getHost("Leftpane")) Then
            For Each s1 As HtmlElement In WebBrowser1.Document.GetElementsByTagName("A")

                Dim _port As String = ""
                If PORT <> "" Then
                    _port = ":" + PORT
                End If

                If s1.GetAttribute("href").IndexOf("http://" + IP.FullString() + _port + "/monitoring.html?session=") >= 0 Then
                    ret = s1.GetAttribute("href").Replace("http://" + IP.FullString() + _port + "/monitoring.html?session=", "")
                    If ret.Length = 5 Then
                        Return ret
                    End If
                End If
            Next

            For Each s1 As HtmlElement In WebBrowser1.Document.Body.GetElementsByTagName("frame")
                If s1.GetAttribute("name").Equals("showframe") Then
                    Dim Str As String = "monitoring.html?session="
                    Dim buf As String = s1.Document.ActiveElement.OuterHtml.ToString
                    ret = (buf.Remove(0, buf.IndexOf(Str) + Str.Count)).Remove(5, (buf.Remove(0, buf.IndexOf(Str) + Str.Count)).Count - 5)
                    If ret.Length = 5 Then
                        Return ret
                    End If
                End If
            Next
        End If

        If WebBrowser1.Document.ActiveElement.InnerHtml.ToString.IndexOf("src='monitoring.html?session=") >= 0 Then
            Dim buf As String = WebBrowser1.Document.ActiveElement.InnerHtml.ToString()
            Dim index As Integer = WebBrowser1.Document.ActiveElement.InnerHtml.ToString.IndexOf("src='monitoring.html?session=") + "src='monitoring.html?session=".Length
            For i As Integer = index To index + 4
                ret = ret + buf(i)
            Next
            Return ret
        End If
        Return Nothing
    End Function
    Private Function getElement(text As String, word As String) As String
        Dim result As String = ""
        If text.IndexOf(word) >= 0 Then
            Dim index = text.IndexOf(word) + word.Length
            Dim buf As String = text.Remove(0, index)
            If word = "part number:" Then
                While buf(0) = vbCrLf Or buf(0) = vbCr Or buf(0) = vbLf
                    buf = buf.Remove(0, 1)
                End While
                Dim endIndex = buf.IndexOf(vbCrLf)
                If endIndex = -1 Then
                    endIndex = buf.Length
                End If
                For i As Integer = 0 To endIndex - 1
                    result = result + buf(i)
                Next
            Else
                Dim endIndex = buf.IndexOf(vbCrLf)
                If endIndex = -1 Then
                    endIndex = buf.Length
                End If
                For i As Integer = 0 To endIndex - 1
                    result = result + buf(i)
                Next
            End If
        End If
        Return result
    End Function
    Private Function getHTML(host As String) As HtmlDocument
        Dim buf
        If host IsNot Nothing Then
            If host <> "" Or
            host.Length > 10 Then
                If NewWebOperator(host) Then
                    buf = WebBrowser1.Document
                    If WebBrowser1.Document.ActiveElement.OuterText Is Nothing Then
                        wait(1000)
                    End If
                    If host = getHost("MonitoringConfig") Then
                        wait(5000)
                    End If
                    If WebBrowser1.Document.ActiveElement.OuterText Is Nothing Then
                        Return Nothing
                    Else
                        Return WebBrowser1.Document
                    End If
                Else
                    If host.IndexOf("monitoring") Then
                        LoginFunc()
                        If NewWebOperator(host) Then
                            buf = WebBrowser1.Document
                            Return buf
                        End If
                    End If
                End If
            End If
        End If

        Return Nothing
    End Function
    Private Function getArray(input As HtmlDocument) As String(,)
        If input IsNot Nothing Then
            Dim ret(66, 1) As String
            If input.Url.ToString.IndexOf("/leftpane") >= 0 Then
                ret(0, 0) = "Location"
                ret(0, 1) = input.[All].Item(20).OuterText
                ret(1, 0) = "Name"
                ret(1, 1) = input.[All].Item(24).OuterText
                ret(2, 0) = "SoftwareVersion"
                ret(2, 1) = getElement(input.[All].Item(13).OuterText, "ver. ")
                ret(3, 0) = "MacAddress"
                ret(3, 1) = getElement(input.[All].Item(13).OuterText, "mac:")
                ret(4, 0) = "PDUName"
                ret(4, 1) = getElement(input.[All].Item(13).OuterText, "part number:")
                Return ret
            End If

            If input.Url.ToString.IndexOf("/monitoring_admin.") >= 0 Then
                ret(1, 0) = "Phase1A1Min"
                ret(1, 1) = IDNothingCheck("AME0X", input)
                ret(2, 0) = "Phase1A1Warn"
                ret(2, 1) = IDNothingCheck("AOE0X", input)
                ret(3, 0) = "Phase1A1Max"
                ret(3, 1) = IDNothingCheck("APE0X", input)
                ret(4, 0) = "Phase1A1Email"
                ret(4, 1) = IDNothingCheck("YEE0X", input)
                ret(5, 0) = "Phase1A1Syslog"
                ret(5, 1) = IDNothingCheck("YSE0X", input)
                ret(6, 0) = "Phase1A1Log"
                ret(6, 1) = IDNothingCheck("YLE0X", input)
                ret(7, 0) = "Phase1A1Trap"
                ret(7, 1) = IDNothingCheck("YTE0X", input)
                ret(8, 0) = "Phase1A1Alarm0A"
                ret(8, 1) = IDNothingCheck("YWE0X", input)
                ret(9, 0) = "Phase1A2Min"
                ret(9, 1) = IDNothingCheck("AME1X", input)
                ret(10, 0) = "Phase1A2Warn"
                ret(10, 1) = IDNothingCheck("AOE1X", input)
                ret(11, 0) = "Phase1A2Max"
                ret(11, 1) = IDNothingCheck("APE1X", input)
                ret(12, 0) = "Phase1A2Email"
                ret(12, 1) = IDNothingCheck("YEE1X", input)
                ret(13, 0) = "Phase1A2Syslog"
                ret(13, 1) = IDNothingCheck("YSE1X", input)
                ret(14, 0) = "Phase1A2Log"
                ret(14, 1) = IDNothingCheck("YLE1X", input)
                ret(15, 0) = "Phase1A2Trap"
                ret(15, 1) = IDNothingCheck("YTE1X", input)
                ret(16, 0) = "Phase1A2Alarm0A"
                ret(16, 1) = IDNothingCheck("YWE1X", input)
                ret(17, 0) = "Phase2A1Min"
                ret(17, 1) = IDNothingCheck("AME2X", input)
                ret(18, 0) = "Phase2A1Warn"
                ret(18, 1) = IDNothingCheck("AOE2X", input)
                ret(19, 0) = "Phase2A1Max"
                ret(19, 1) = IDNothingCheck("APE2X", input)
                ret(20, 0) = "Phase2A1Email"
                ret(20, 1) = IDNothingCheck("YEE2X", input)
                ret(21, 0) = "Phase2A1Syslog"
                ret(21, 1) = IDNothingCheck("YSE2X", input)
                ret(22, 0) = "Phase2A1Log"
                ret(22, 1) = IDNothingCheck("YLE2X", input)
                ret(23, 0) = "Phase2A1Trap"
                ret(23, 1) = IDNothingCheck("YTE2X", input)
                ret(24, 0) = "Phase2A1Alarm0A"
                ret(24, 1) = IDNothingCheck("YWE2X", input)
                ret(25, 0) = "Phase2A2Min"
                ret(25, 1) = IDNothingCheck("AME3X", input)
                ret(26, 0) = "Phase2A2Warn"
                ret(26, 1) = IDNothingCheck("AOE3X", input)
                ret(27, 0) = "Phase2A2Max"
                ret(27, 1) = IDNothingCheck("APE3X", input)
                ret(28, 0) = "Phase2A2Email"
                ret(28, 1) = IDNothingCheck("YEE3X", input)
                ret(29, 0) = "Phase2A2Syslog"
                ret(29, 1) = IDNothingCheck("YSE3X", input)
                ret(30, 0) = "Phase2A2Log"
                ret(30, 1) = IDNothingCheck("YLE3X", input)
                ret(31, 0) = "Phase2A2Trap"
                ret(31, 1) = IDNothingCheck("YTE3X", input)
                ret(32, 0) = "Phase2A2Alarm0A"
                ret(32, 1) = IDNothingCheck("YWE3X", input)
                ret(33, 0) = "Phase3A1Min"
                ret(33, 1) = IDNothingCheck("AME4X", input)
                ret(34, 0) = "Phase3A1Warn"
                ret(34, 1) = IDNothingCheck("AOE4X", input)
                ret(35, 0) = "Phase3A1Max"
                ret(35, 1) = IDNothingCheck("APE4X", input)
                ret(36, 0) = "Phase3A1Email"
                ret(36, 1) = IDNothingCheck("YEE4X", input)
                ret(37, 0) = "Phase3A1Syslog"
                ret(37, 1) = IDNothingCheck("YSE4X", input)
                ret(38, 0) = "Phase3A1Log"
                ret(38, 1) = IDNothingCheck("YLE4X", input)
                ret(39, 0) = "Phase3A1Trap"
                ret(39, 1) = IDNothingCheck("YTE4X", input)
                ret(40, 0) = "Phase3A1Alarm0A"
                ret(40, 1) = IDNothingCheck("YWE4X", input)
                ret(41, 0) = "Phase3A2Min"
                ret(41, 1) = IDNothingCheck("AME5X", input)
                ret(42, 0) = "Phase3A2Warn"
                ret(42, 1) = IDNothingCheck("AOE5X", input)
                ret(43, 0) = "Phase3A2Max"
                ret(43, 1) = IDNothingCheck("APE5X", input)
                ret(44, 0) = "Phase3A2Email"
                ret(44, 1) = IDNothingCheck("YEE5X", input)
                ret(45, 0) = "Phase3A2Syslog"
                ret(45, 1) = IDNothingCheck("YSE5X", input)
                ret(46, 0) = "Phase3A2Log"
                ret(46, 1) = IDNothingCheck("YLE5X", input)
                ret(47, 0) = "Phase3A2Trap"
                ret(47, 1) = IDNothingCheck("YTE5X", input)
                ret(48, 0) = "Phase3A2Alarm0A"
                ret(48, 1) = IDNothingCheck("YWE5X", input)
                ret(49, 0) = "Phase1Email"
                ret(49, 1) = IDNothingCheck("YEE6X", input)
                ret(50, 0) = "Phase1Syslog"
                ret(50, 1) = IDNothingCheck("YSE6X", input)
                ret(51, 0) = "Phase1Log"
                ret(51, 1) = IDNothingCheck("YLE6X", input)
                ret(52, 0) = "Phase1Trap"
                ret(52, 1) = IDNothingCheck("YTE6X", input)
                ret(53, 0) = "Phase2Email"
                ret(53, 1) = IDNothingCheck("YEE7X", input)
                ret(54, 0) = "Phase2Syslog"
                ret(54, 1) = IDNothingCheck("YSE7X", input)
                ret(55, 0) = "Phase2Log"
                ret(55, 1) = IDNothingCheck("YLE7X", input)
                ret(56, 0) = "Phase2Trap"
                ret(56, 1) = IDNothingCheck("YTE7X", input)
                ret(57, 0) = "Phase3Email"
                ret(57, 1) = IDNothingCheck("YEE8X", input)
                ret(58, 0) = "Phase3Syslog"
                ret(58, 1) = IDNothingCheck("YSE8X", input)
                ret(59, 0) = "Phase3Log"
                ret(59, 1) = IDNothingCheck("YLE8X", input)
                ret(60, 0) = "Phase3Trap"
                ret(60, 1) = IDNothingCheck("YTE8X", input)
                ret(61, 0) = "TemperatureTrigger"
                ret(61, 1) = IDNothingCheck("PTE0X", input)
                ret(62, 0) = "TemperatureEmail"
                ret(62, 1) = IDNothingCheck("XEE6X", input)
                ret(63, 0) = "TemperatureSyslog"
                ret(63, 1) = IDNothingCheck("XSE6X", input)
                ret(64, 0) = "TemperatureLog"
                ret(64, 1) = IDNothingCheck("XLE6X", input)
                ret(65, 0) = "TemperatureTrap"
                ret(65, 1) = IDNothingCheck("XTE6X", input)
                Return ret
            End If
            If input.Url.ToString.IndexOf("/admin.") >= 0 Then
                ret(1, 0) = "Location"
                ret(1, 1) = input.GetElementById("ONE").GetAttribute("value")
                ret(2, 0) = "Name"
                ret(2, 1) = input.GetElementById("DNE").GetAttribute("value")
                ret(3, 0) = "DHCP Client"
                ret(3, 1) = input.GetElementById("DHE").GetAttribute("value")
                ret(4, 0) = "IP Address"
                ret(4, 1) = input.GetElementById("IPE").GetAttribute("value")
                ret(5, 0) = "Subnet mask"
                ret(5, 1) = input.GetElementById("NME").GetAttribute("value")
                ret(6, 0) = "Gateway"
                ret(6, 1) = input.GetElementById("GIE").GetAttribute("value")
                ret(7, 0) = "User password"
                ret(7, 1) = input.GetElementById("PWE").GetAttribute("value")
                ret(8, 0) = "Administration password"
                ret(8, 1) = input.GetElementById("P2E").GetAttribute("value")
                ret(9, 0) = "Login timeout on website"
                ret(9, 1) = input.GetElementById("ATE").GetAttribute("value")
                ret(10, 0) = "Auto-refresh website"
                ret(10, 1) = input.GetElementById("ARE").GetAttribute("value")
                ret(11, 0) = "Temperature monitored"
                ret(11, 1) = input.GetElementById("PXE6X").GetAttribute("value")
                ret(0, 0) = "Filled"
                Return ret
            End If


            If input.Url.ToString.IndexOf("/admin2") >= 0 Then
                    ret(1, 0) = "SMTP - username"
                    ret(1, 1) = input.GetElementById("MUE").GetAttribute("value")
                    ret(2, 0) = "SMTP - password"
                    ret(2, 1) = input.GetElementById("MPE").GetAttribute("value")
                    ret(3, 0) = "SMTP - sender"
                    ret(3, 1) = input.GetElementById("MSE").GetAttribute("value")
                    ret(4, 0) = "SMTP - recipient"
                    ret(4, 1) = input.GetElementById("MRE").GetAttribute("value")
                    ret(5, 0) = "SMTP - IP address for Server"
                    ret(5, 1) = input.GetElementById("MIE").GetAttribute("value")
                    ret(6, 0) = "SMTP - port number"
                    ret(6, 1) = input.GetElementById("MTE").GetAttribute("value")
                    ret(7, 0) = "Syslog - IP address"
                    ret(7, 1) = input.GetElementById("NIE").GetAttribute("value")
                    ret(8, 0) = "Syslog - port number"
                    ret(8, 1) = input.GetElementById("NPE").GetAttribute("value")
                    ret(9, 0) = "SNMP - private community"
                    ret(9, 1) = input.GetElementById("SRE").GetAttribute("value")
                    ret(10, 0) = "SNMP - public community"
                    ret(10, 1) = input.GetElementById("SPE").GetAttribute("value")
                    ret(11, 0) = "SNMP - IP address for Trap"
                    ret(11, 1) = input.GetElementById("SAE").GetAttribute("value")
                    ret(12, 0) = "SNTP - IP address for Server"
                    ret(12, 1) = input.GetElementById("NTE").GetAttribute("value")
                    ret(0, 0) = "Filled"
                    Return ret
                End If
                If input.Url.ToString.IndexOf("/log.") >= 0 Then
                    ret(1, 0) = input.ToString()
                    Return ret
                End If
                If input.Url.ToString.IndexOf("/monitoring") >= 0 Then
                    ret(1, 0) = "AME0X"
                    ret(2, 0) = "AME1X"
                    ret(3, 0) = "AME2X"
                    ret(4, 0) = "AME3X"
                    ret(5, 0) = "AME4X"
                    ret(6, 0) = "AME5X"
                    ret(7, 0) = "AOE0X"
                    ret(8, 0) = "AOE1X"
                    ret(9, 0) = "AOE2X"
                    ret(10, 0) = "AOE3X"
                    ret(11, 0) = "AOE4X"
                    ret(12, 0) = "AOE5X"
                    ret(13, 0) = "APE0X"
                    ret(14, 0) = "APE1X"
                    ret(15, 0) = "APE2X"
                    ret(16, 0) = "APE3X"
                    ret(17, 0) = "APE4X"
                    ret(18, 0) = "APE5X"
                    ret(19, 0) = "AVE0X"
                    ret(20, 0) = "AVE1X"
                    ret(21, 0) = "AVE2X"
                    ret(22, 0) = "AVE3X"
                    ret(23, 0) = "AVE4X"
                    ret(24, 0) = "AVE5X"
                    ret(25, 0) = "AVE6X"
                    ret(26, 0) = "AVE7X"
                    ret(27, 0) = "AVE8X"
                    ret(28, 0) = "AXE0X"
                    ret(29, 0) = "AXE1X"
                    ret(30, 0) = "AXE2X"
                    ret(31, 0) = "AXE3X"
                    ret(32, 0) = "AXE4X"
                    ret(33, 0) = "AXE5X"
                    ret(34, 0) = "PTE0X"
                    ret(35, 0) = "TVE0X"
                    '-------------------------------------------------------------------------------------------------------------------------------
                    ret(1, 1) = input.GetElementById("AME0X").GetAttribute("value")
                    ret(2, 1) = input.GetElementById("AME1X").GetAttribute("value")
                    ret(3, 1) = input.GetElementById("AME2X").GetAttribute("value")
                    ret(4, 1) = input.GetElementById("AME3X").GetAttribute("value")
                    ret(5, 1) = input.GetElementById("AME4X").GetAttribute("value")
                    ret(6, 1) = input.GetElementById("AME5X").GetAttribute("value")
                    ret(7, 1) = input.GetElementById("AOE0X").GetAttribute("value")
                    ret(8, 1) = input.GetElementById("AOE1X").GetAttribute("value")
                    ret(9, 1) = input.GetElementById("AOE2X").GetAttribute("value")
                    ret(10, 1) = input.GetElementById("AOE3X").GetAttribute("value")
                    ret(11, 1) = input.GetElementById("AOE4X").GetAttribute("value")
                    ret(12, 1) = input.GetElementById("AOE5X").GetAttribute("value")
                    ret(13, 1) = input.GetElementById("APE0X").GetAttribute("value")
                    ret(14, 1) = input.GetElementById("APE1X").GetAttribute("value")
                    ret(15, 1) = input.GetElementById("APE2X").GetAttribute("value")
                    ret(16, 1) = input.GetElementById("APE3X").GetAttribute("value")
                    ret(17, 1) = input.GetElementById("APE4X").GetAttribute("value")
                    ret(18, 1) = input.GetElementById("APE5X").GetAttribute("value")
                    ret(19, 1) = input.GetElementById("AVE0X").OuterText
                    ret(20, 1) = input.GetElementById("AVE1X").OuterText
                    ret(21, 1) = input.GetElementById("AVE2X").OuterText
                    ret(22, 1) = input.GetElementById("AVE3X").OuterText
                    ret(23, 1) = input.GetElementById("AVE4X").OuterText
                    ret(24, 1) = input.GetElementById("AVE5X").OuterText
                    ret(25, 1) = input.GetElementById("AVE6X").OuterText
                    ret(26, 1) = input.GetElementById("AVE7X").OuterText
                    ret(27, 1) = input.GetElementById("AVE8X").OuterText
                    ret(28, 1) = input.GetElementById("AXE0X").OuterText
                    ret(29, 1) = input.GetElementById("AXE1X").OuterText
                    ret(30, 1) = input.GetElementById("AXE2X").OuterText
                    ret(31, 1) = input.GetElementById("AXE3X").OuterText
                    ret(32, 1) = input.GetElementById("AXE4X").OuterText
                    ret(33, 1) = input.GetElementById("AXE5X").OuterText
                    ret(34, 1) = input.GetElementById("PTE0X").GetAttribute("value")
                    ret(35, 1) = input.GetElementById("TVE0X").OuterText
                    ret(0, 0) = "Filled"
                    ret(0, 1) = calculateTableType(ret)
                    Return ret
                End If
                If input.Url.ToString.IndexOf("Index") >= 0 Then
                    ret(0, 0) = "OK"
                    Return ret
                End If
            End If
            Return Nothing
    End Function
    Private Function getLogoSRC(host As String) As String
        Dim buf
        If NewWebOperator(host) Then
            buf = WebBrowser1.Document
        Else
            Return Nothing
        End If
        Dim ret As String = ""
        If buf Is Nothing Then
            Return Nothing
        Else
            If buf.Url.AbsoluteUri = host Then
                ret = buf.All.Item(12).GetAttribute("src")
            End If
        End If
        Return ret
    End Function
    '============================================================================================================
    Private Function testNavigation() As Boolean
        If IP.installed() Then
            gotoWebPage(getHost("Home"))
            If WebBrowser1.Url.ToString = getHost("Home") Then
                Return True
            End If
        End If
        Return False
    End Function
    Private Function Walk(command As String) As String(,)
        Dim ret(66, 1) As String
        If command = "Logo" Then
            ret(0, 0) = getLogoSRC(getHost("Logo"))
        ElseIf command = "Monitoring" Then
            ret(0, 0) = Nothing
            gotoWebPage(getHost(command))
            If WebBrowser1.Url Is Nothing Then
                gotoWebPage(getHost(command))
                If WebBrowser1.Url Is Nothing Then
                    If WebBrowser1.Url.ToString = getHost("Monitoring") Then
                        ret(0, 0) = "Started"
                    End If
                End If
            Else
                If WebBrowser1.Url.ToString = getHost("Monitoring") Then
                    ret(0, 0) = "Started"
                End If
            End If

            Return ret
        Else
            ret = getArray(getHTML(getHost(command)))
        End If
        Return ret
    End Function
    Private Function IDNothingCheck(Input As String, inputHTML As HtmlDocument) As String
        If inputHTML.GetElementById(Input) Is Nothing Then
            Return Nothing
        End If
        If inputHTML.GetElementById(Input).GetAttribute("value") Is Nothing Then
            Return Nothing
        End If
        If inputHTML.GetElementById(Input).GetAttribute("value") = "" Then
            Return Nothing
        End If
        If inputHTML.GetElementById(Input).GetAttribute("value") = "..." Then
            Return Nothing
        End If
        Return inputHTML.GetElementById(Input).GetAttribute("value").ToString
    End Function
    '============================================================================================================
    Private Property pagereadyWeb1 As Boolean
#Region "Page Loading Functions"
    Public Function WaitForPageLoad() As Boolean
        Dim result As Boolean
        AddHandler WebBrowser1.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PageWaiter)
        calcValue = 0
        timer24.Start()
        pagereadyWeb1 = False
        While Not pagereadyWeb1 And calcValue < 15000
            Application.DoEvents()
        End While
        calcValue = 0
        timer24.Stop()
        result = pagereadyWeb1
        pagereadyWeb1 = False
        Return result
    End Function

    Private Sub PageWaiter(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)

        If WebBrowser1.ReadyState = WebBrowserReadyState.Complete Then
            pagereadyWeb1 = True
            RemoveHandler WebBrowser1.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PageWaiter)
        End If

    End Sub
#End Region

    '-----------------------------------------------------------------------------------------------------------------------------------
    'События----------------------------------------------------------------------------------------------------------------------------
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If WaitTimerCalcVal > 0 OrElse WebBrowser1.ReadyState <> WebBrowserReadyState.Complete Then
            Exit Sub
        End If
        pagereadyWeb1 = True
        If WebBrowser1.Url.ToString.IndexOf("monitoring") < 0 OrElse
            WebBrowser1.Url.ToString <> getHost("Monitoring") OrElse
            WebBrowser1.Document.GetElementById("AVE0X") Is Nothing Then
            Exit Sub
        End If

        MonitoringStatus = True
        MonitoringTimerCalc = 0
        If WebBrowser1.Document.GetElementById("AME0X") IsNot Nothing Then
            FILE.Table.Phase1.Ampermeter1.Min = WebBrowser1.Document.GetElementById("AME0X").GetAttribute("value")
        End If

        If WebBrowser1.Document.GetElementById("AME1X") IsNot Nothing Then
            FILE.Table.Phase1.Ampermeter2.Min = WebBrowser1.Document.GetElementById("AME1X").GetAttribute("value")
        End If
        If WebBrowser1.Document.GetElementById("AME2X") IsNot Nothing Then
            FILE.Table.Phase2.Ampermeter1.Min = WebBrowser1.Document.GetElementById("AME2X").GetAttribute("value")
        End If
        If WebBrowser1.Document.GetElementById("AME3X") IsNot Nothing Then
            FILE.Table.Phase2.Ampermeter2.Min = WebBrowser1.Document.GetElementById("AME3X").GetAttribute("value")
        End If
        If WebBrowser1.Document.GetElementById("AME4X") IsNot Nothing Then
            FILE.Table.Phase3.Ampermeter1.Min = WebBrowser1.Document.GetElementById("AME4X").GetAttribute("value")
        End If
        If WebBrowser1.Document.GetElementById("AME5X") IsNot Nothing Then
            FILE.Table.Phase3.Ampermeter2.Min = WebBrowser1.Document.GetElementById("AME5X").GetAttribute("value")
        End If
        If WebBrowser1.Document.GetElementById("AOE0X") IsNot Nothing Then
            FILE.Table.Phase1.Ampermeter1.Warn = WebBrowser1.Document.GetElementById("AOE0X").GetAttribute("value")
        End If
        If WebBrowser1.Document.GetElementById("AOE1X") IsNot Nothing Then
            FILE.Table.Phase1.Ampermeter2.Warn = WebBrowser1.Document.GetElementById("AOE1X").GetAttribute("value")
        End If
        If WebBrowser1.Document.GetElementById("AOE2X") IsNot Nothing Then
            FILE.Table.Phase2.Ampermeter1.Warn = WebBrowser1.Document.GetElementById("AOE2X").GetAttribute("value")
        End If
        If WebBrowser1.Document.GetElementById("AOE3X") IsNot Nothing Then
            FILE.Table.Phase2.Ampermeter2.Warn = WebBrowser1.Document.GetElementById("AOE3X").GetAttribute("value")
        End If
        If WebBrowser1.Document.GetElementById("AOE4X") IsNot Nothing Then
            FILE.Table.Phase3.Ampermeter1.Warn = WebBrowser1.Document.GetElementById("AOE4X").GetAttribute("value")
        End If
        If WebBrowser1.Document.GetElementById("AOE5X") IsNot Nothing Then
            FILE.Table.Phase3.Ampermeter2.Warn = WebBrowser1.Document.GetElementById("AOE5X").GetAttribute("value")
        End If
        If WebBrowser1.Document.GetElementById("APE0X") IsNot Nothing Then
            FILE.Table.Phase1.Ampermeter1.Max = WebBrowser1.Document.GetElementById("APE0X").GetAttribute("value")
        End If
        If WebBrowser1.Document.GetElementById("APE1X") IsNot Nothing Then
            FILE.Table.Phase1.Ampermeter2.Max = WebBrowser1.Document.GetElementById("APE1X").GetAttribute("value")
        End If
        If WebBrowser1.Document.GetElementById("APE2X") IsNot Nothing Then
            FILE.Table.Phase2.Ampermeter1.Max = WebBrowser1.Document.GetElementById("APE2X").GetAttribute("value")
        End If
        If WebBrowser1.Document.GetElementById("APE3X") IsNot Nothing Then
            FILE.Table.Phase2.Ampermeter2.Max = WebBrowser1.Document.GetElementById("APE3X").GetAttribute("value")
        End If
        If WebBrowser1.Document.GetElementById("APE4X") IsNot Nothing Then
            FILE.Table.Phase3.Ampermeter1.Max = WebBrowser1.Document.GetElementById("APE4X").GetAttribute("value")
        End If
        If WebBrowser1.Document.GetElementById("APE5X") IsNot Nothing Then
            FILE.Table.Phase3.Ampermeter2.Max = WebBrowser1.Document.GetElementById("APE5X").GetAttribute("value")
        End If
        If WebBrowser1.Document.GetElementById("AVE0X") IsNot Nothing Then
            FILE.Table.Phase1.Ampermeter1.Current = WebBrowser1.Document.GetElementById("AVE0X").OuterText
        End If
        If WebBrowser1.Document.GetElementById("AVE1X") IsNot Nothing Then
            FILE.Table.Phase1.Ampermeter2.Current = WebBrowser1.Document.GetElementById("AVE1X").OuterText
        End If
        If WebBrowser1.Document.GetElementById("AVE2X") IsNot Nothing Then
            FILE.Table.Phase2.Ampermeter1.Current = WebBrowser1.Document.GetElementById("AVE2X").OuterText
        End If
        If WebBrowser1.Document.GetElementById("AVE3X") IsNot Nothing Then
            FILE.Table.Phase2.Ampermeter2.Current = WebBrowser1.Document.GetElementById("AVE3X").OuterText
        End If
        If WebBrowser1.Document.GetElementById("AVE4X") IsNot Nothing Then
            FILE.Table.Phase3.Ampermeter1.Current = WebBrowser1.Document.GetElementById("AVE4X").OuterText
        End If
        If WebBrowser1.Document.GetElementById("AVE5X") IsNot Nothing Then
            FILE.Table.Phase3.Ampermeter2.Current = WebBrowser1.Document.GetElementById("AVE5X").OuterText
        End If
        If WebBrowser1.Document.GetElementById("AVE6X") IsNot Nothing Then
            FILE.Table.Phase1.Section1.Status = WebBrowser1.Document.GetElementById("AVE6X").OuterText
        End If
        If WebBrowser1.Document.GetElementById("AVE6X") IsNot Nothing Then
            FILE.Table.Phase1.Section2.Status = WebBrowser1.Document.GetElementById("AVE6X").OuterText
        End If
        If WebBrowser1.Document.GetElementById("AVE7X") IsNot Nothing Then
            FILE.Table.Phase2.Section1.Status = WebBrowser1.Document.GetElementById("AVE7X").OuterText
        End If
        If WebBrowser1.Document.GetElementById("AVE7X") IsNot Nothing Then
            FILE.Table.Phase2.Section2.Status = WebBrowser1.Document.GetElementById("AVE7X").OuterText
        End If
        If WebBrowser1.Document.GetElementById("AVE8X") IsNot Nothing Then
            FILE.Table.Phase3.Section1.Status = WebBrowser1.Document.GetElementById("AVE8X").OuterText
        End If
        If WebBrowser1.Document.GetElementById("AVE8X") IsNot Nothing Then
            FILE.Table.Phase3.Section2.Status = WebBrowser1.Document.GetElementById("AVE8X").OuterText
        End If
        If WebBrowser1.Document.GetElementById("AXE0X") IsNot Nothing Then
            FILE.Table.Phase1.Section1.message = WebBrowser1.Document.GetElementById("AXE0X").OuterText
        End If
        If WebBrowser1.Document.GetElementById("AXE1X") IsNot Nothing Then
            FILE.Table.Phase1.Section2.message = WebBrowser1.Document.GetElementById("AXE1X").OuterText
        End If
        If WebBrowser1.Document.GetElementById("AXE2X") IsNot Nothing Then
            FILE.Table.Phase2.Section1.message = WebBrowser1.Document.GetElementById("AXE2X").OuterText
        End If
        If WebBrowser1.Document.GetElementById("AXE3X") IsNot Nothing Then
            FILE.Table.Phase2.Section2.message = WebBrowser1.Document.GetElementById("AXE3X").OuterText
        End If
        If WebBrowser1.Document.GetElementById("AXE4X") IsNot Nothing Then
            FILE.Table.Phase3.Section1.message = WebBrowser1.Document.GetElementById("AXE4X").OuterText
        End If
        If WebBrowser1.Document.GetElementById("AXE5X") IsNot Nothing Then
            FILE.Table.Phase3.Section2.message = WebBrowser1.Document.GetElementById("AXE5X").OuterText
        End If
        If WebBrowser1.Document.GetElementById("PTE0X") IsNot Nothing Then
            FILE.Table.Temp.Trigger = WebBrowser1.Document.GetElementById("PTE0X").GetAttribute("value")
        End If
        If WebBrowser1.Document.GetElementById("TVE0X") IsNot Nothing Then
            FILE.Table.Temp.Value = WebBrowser1.Document.GetElementById("TVE0X").OuterText
        End If
        Dim ret(66, 1) As String
        ret(1, 1) = FILE.Table.Phase1.Ampermeter1.Min
        ret(2, 1) = FILE.Table.Phase1.Ampermeter2.Min
        ret(3, 1) = FILE.Table.Phase2.Ampermeter1.Min
        ret(4, 1) = FILE.Table.Phase2.Ampermeter2.Min
        ret(5, 1) = FILE.Table.Phase3.Ampermeter1.Min
        ret(6, 1) = FILE.Table.Phase3.Ampermeter2.Min
        ret(7, 1) = FILE.Table.Phase1.Ampermeter1.Warn
        ret(8, 1) = FILE.Table.Phase1.Ampermeter2.Warn
        ret(9, 1) = FILE.Table.Phase2.Ampermeter1.Warn
        ret(10, 1) = FILE.Table.Phase2.Ampermeter2.Warn
        ret(11, 1) = FILE.Table.Phase3.Ampermeter1.Warn
        ret(12, 1) = FILE.Table.Phase3.Ampermeter2.Warn
        ret(13, 1) = FILE.Table.Phase1.Ampermeter1.Max
        ret(14, 1) = FILE.Table.Phase1.Ampermeter2.Max
        ret(15, 1) = FILE.Table.Phase2.Ampermeter1.Max
        ret(16, 1) = FILE.Table.Phase2.Ampermeter2.Max
        ret(17, 1) = FILE.Table.Phase3.Ampermeter1.Max
        ret(18, 1) = FILE.Table.Phase3.Ampermeter2.Max
        ret(19, 1) = FILE.Table.Phase1.Ampermeter1.Current
        ret(20, 1) = FILE.Table.Phase1.Ampermeter2.Current
        ret(21, 1) = FILE.Table.Phase2.Ampermeter1.Current
        ret(22, 1) = FILE.Table.Phase2.Ampermeter2.Current
        ret(23, 1) = FILE.Table.Phase3.Ampermeter1.Current
        ret(24, 1) = FILE.Table.Phase3.Ampermeter2.Current
        ret(25, 1) = FILE.Table.Phase1.Section2.Status

        ret(26, 1) = FILE.Table.Phase2.Section1.Status
        ret(27, 1) = FILE.Table.Phase3.Section1.Status
        ret(28, 1) = FILE.Table.Phase1.Section1.message
        ret(29, 1) = FILE.Table.Phase1.Section2.message
        ret(30, 1) = FILE.Table.Phase2.Section1.message
        ret(31, 1) = FILE.Table.Phase2.Section2.message
        ret(32, 1) = FILE.Table.Phase3.Section1.message
        ret(33, 1) = FILE.Table.Phase3.Section2.message
        ret(34, 1) = FILE.Table.Temp.Trigger
        ret(35, 1) = FILE.Table.Temp.Value
        FILE.Table.TableType = calculateTableType(ret)

    End Sub

    '------------------------------------------------------------------------------------------------------------------------------------
    'Таймеры-----------------------------------------------------------------------------------------------------------------------------
    Private WithEvents timer24 As Timer = New Timer
    Private calcValue = 0
    Private Sub timer24_tick() Handles timer24.Tick
        calcValue = calcValue + timer24.Interval
    End Sub

    Private timeOut As Integer = 0
    Private timerValue As Integer = 15000
    Private WithEvents TimeOuttimer As Timer = New Timer
    Private Sub TimeOutTimer_Tick() Handles TimeOuttimer.Tick
        timeOut = timeOut + 100
        If timeOut > timerValue Then
            TimeOuttimer.Stop()
        End If
    End Sub

    Private MonitoringTimerCalc As Integer = 0
    Private WithEvents MonitoringStatusTimer As Timer = New Timer
    Public MonitoringStatus As Boolean
    Private MonitoringLock As Boolean
    Private Sub MonitoringStatusTimer_tick() Handles MonitoringStatusTimer.Tick
        If IP.FullString() <> LoginnedProfile.Data.PDUA.IP.FullString() And IP.FullString() <> LoginnedProfile.Data.PDUB.IP.FullString() Then
            MonitoringStatusTimer.Stop()
            Exit Sub
        End If
        Dim times As Integer = 20000
        MonitoringTimerCalc = MonitoringTimerCalc + MonitoringStatusTimer.Interval
        If MonitoringTimerCalc >= times Then
            MonitoringTimerCalc = times
            MonitoringStatus = False
        End If
        If MonitoringStatus = False And MonitoringTimerCalc >= times Then
            MonitoringLock = True
            MonitoringTimerCalc = 0
            If gotoWebPage(getHost("Monitoring")) Then
                WebBrowser1.Refresh()
                MonitoringLock = False
            ElseIf MyProject.Computer.Network.IsAvailable Then
                If My.Computer.Network.Ping(IP.FullString()) Then
                    If Logining() Then
                        If gotoWebPage(getHost("Monitoring")) Then
                            STATUS = "DEVICE_FOUND_ON_NETWORK"
                            WebBrowser1.Refresh()
                            MonitoringLock = False
                        Else
                            'не удается обнаружить листву в сети
                            STATUS = "DEVICE_NOT_FOUND_ON_NETWORK"
                        End If
                    Else
                        If LoginFunc() Then
                            STATUS = "DEVICE_FOUND_ON_NETWORK"
                        Else
                            STATUS = "DEVICE_NOT_FOUND_ON_NETWORK"
                        End If
                    End If
                End If
            Else
                MonitoringLock = False
            End If
        End If

    End Sub
    '------------------------------------------------------------------------------------------------------------------------------
    'Вспомогательные функции ------------------------------------------------------------------------------------------------------
    Private Function NewWebOperator(input As String) As Boolean
        gotoWebPage(input)
        If WebBrowser1.Url.ToString = input Then
            Return True
        End If
        Return False
    End Function
    Private Function calculateTableType(input As String(,)) As String
        Dim ampermeters As Integer = 0
        Dim phases As Integer = 0
        If input(19, 1) IsNot Nothing Then
            ampermeters = ampermeters + 1
        End If
        If input(20, 1) IsNot Nothing Then
            ampermeters = ampermeters + 1
        End If
        If input(21, 1) IsNot Nothing Then
            ampermeters = ampermeters + 1
        End If
        If input(22, 1) IsNot Nothing Then
            ampermeters = ampermeters + 1
        End If
        If input(23, 1) IsNot Nothing Then
            ampermeters = ampermeters + 1
        End If
        If input(24, 1) IsNot Nothing Then
            ampermeters = ampermeters + 1
        End If
        If input(25, 1) IsNot Nothing Then
            phases = phases + 1
        End If
        If input(26, 1) IsNot Nothing Then
            phases = phases + 1
        End If
        If input(27, 1) IsNot Nothing Then
            phases = phases + 1
        End If
        Dim ret As String = "PDUType" + "P" + phases.ToString + "A" + ampermeters.ToString
        If input(35, 1) = "no sensor" Or input(32, 1) = "" Or input(32, 1) Is Nothing Then
            ret = ret + "T0"
        Else
            ret = ret + "T1"
        End If
        Return ret
    End Function


    '------------------------------------------------------------------------------------------------------------------------------
    'Классы------------------------------------------------------------------------------------------------------------------------
    Public Class SessionClass
        Public Number As String = Nothing
        Public Function Actual() As Boolean
            If PDUA.connectToDevice.WebConnection.Session.Number IsNot Nothing Then
                If PDUA.connectToDevice.WebConnection.Session.Number = Number Then
                    If PDUA.connectToDevice.WebConnection.MonitoringStatus = True Then
                        Return True
                    End If
                    If PDUA.connectToDevice.WebConnection.testNavigation() Then
                        Return True
                    End If
                End If
            End If

            If PDUB.connectToDevice.WebConnection.Session.Number IsNot Nothing Then
                If PDUB.connectToDevice.WebConnection.Session.Number = Number Then
                    If PDUB.connectToDevice.WebConnection.MonitoringStatus = True Then
                        Return True
                    End If
                    If PDUB.connectToDevice.WebConnection.testNavigation() Then
                        Return True
                    End If
                End If
            End If
            Return False
        End Function
    End Class
    Private lock As Boolean
End Class