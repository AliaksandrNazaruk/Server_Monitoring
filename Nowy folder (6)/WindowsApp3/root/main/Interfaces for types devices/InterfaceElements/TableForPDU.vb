Public Class TableForPDU
    Private p1Grab As Boolean = False
    Private p2Grab As Boolean = False
    Public DeviceName As String = ""
    Private LostConnection As Boolean = False
    Private WithEvents timer1 As Timer = New Timer
    Public WithEvents AnimationTimer As Timer = New Timer
    Private Sub AnimationTimer_Tick() Handles AnimationTimer.Tick

        AnimationTimer.Interval = 1000
        Animation()
        If Module1.PDUA.Online <> True And Module1.PDUB.Online <> True And Module2.MonitoringBase.online <> True Then
            AnimationTimer.Stop()
        End If
        If Workspace.AllertConfig1.AnimatedAlertSwitch.Checked = False Then
            AnimationTimer.Stop()
        End If
    End Sub
    Private Sub timer1_tick() Handles timer1.Tick
        '//Выключение таймера при отсутствии соединения с устройством
        If CheckStatusDevice() <> True Then
            timer1.Stop()
        Else
            '//Алгоритм обновления данных в таблице
            DataRefresh()
        End If

    End Sub
    Private Sub DataRefresh()
        calcTIme = calcTIme + 1000
        If calcTIme > time Then
            calcTIme = time
        End If
        If p1Grab And p2Grab And calcTIme = time Then
            calcTIme = 0
            p1Grab = False
            p2Grab = False
        End If

        If thisDeviceModule.Online Then
            TableHead1.Text2.Text = ("")
            refreshFunc()
            If LostConnection Then
                My.Forms.Workspace.Log1.SendMessagesFunction(New Message("Message", "", "Connection to " + DeviceName + " restored"))
            End If
            LostConnection = False
        Else
            If LostConnection = False Then
                My.Forms.Workspace.Log1.SendMessagesFunction(New Message("Alert", "", "Lost connection to " + DeviceName))
            End If
            LostConnection = True
            TableHead1.Text2.Text = "(Not online)"
            If TableHead1.Text2.ForeColor = Color.Red Then
                TableHead1.Text2.ForeColor = Color.DarkRed
            Else
                TableHead1.Text2.ForeColor = Color.Red
            End If
        End If
    End Sub
    Private Function CheckStatusDevice() As Boolean
        If thisDeviceModule.connectToDevice Is Nothing Then
            Return False
        ElseIf thisDeviceModule.connectToDevice.WebConnection Is Nothing Then
            Return False
        ElseIf thisDeviceModule.connectToDevice.WebConnection.IP Is Nothing Then
            Return False
        ElseIf thisDeviceModule.connectToDevice.WebConnection.IP.installed() = False Then
            Return False
        ElseIf thisDeviceModule.connectToDevice.WebConnection.STATUS = "DEVICE_NOT_FOUND_ON_NETWORK" Then
            Return False
        End If
        Return True
    End Function
    Public Sub Animation()

        If Ampermeter1Table.Status.BackColor = Color.Red Then
            Ampermeter1Table.Status.BackColor = Color.DarkRed
        ElseIf Ampermeter1Table.Status.BackColor = Color.DarkRed Then
            Ampermeter1Table.Status.BackColor = Color.Red
        End If

        If Ampermeter2Table.Status.BackColor = Color.Red Then
            Ampermeter2Table.Status.BackColor = Color.DarkRed
        ElseIf Ampermeter2Table.Status.BackColor = Color.DarkRed Then
            Ampermeter2Table.Status.BackColor = Color.Red
        End If
        If Ampermeter3Table.Status.BackColor = Color.Red Then
            Ampermeter3Table.Status.BackColor = Color.DarkRed
        ElseIf Ampermeter3Table.Status.BackColor = Color.DarkRed Then
            Ampermeter3Table.Status.BackColor = Color.Red
        End If
        If Ampermeter4Table.Status.BackColor = Color.Red Then
            Ampermeter4Table.Status.BackColor = Color.DarkRed
        ElseIf Ampermeter4Table.Status.BackColor = Color.DarkRed Then
            Ampermeter4Table.Status.BackColor = Color.Red
        End If

        If Ampermeter5Table.Status.BackColor = Color.Red Then
            Ampermeter5Table.Status.BackColor = Color.DarkRed
        ElseIf Ampermeter5Table.Status.BackColor = Color.DarkRed Then
            Ampermeter5Table.Status.BackColor = Color.Red
        End If

        If Ampermeter6Table.Status.BackColor = Color.Red Then
            Ampermeter6Table.Status.BackColor = Color.DarkRed
        ElseIf Ampermeter6Table.Status.BackColor = Color.DarkRed Then
            Ampermeter6Table.Status.BackColor = Color.Red
        End If
        If Termometer1Table.Status.BackColor = Color.Red Then
            Termometer1Table.Status.BackColor = Color.DarkRed
        ElseIf Termometer1Table.Status.BackColor = Color.DarkRed Then
            Termometer1Table.Status.BackColor = Color.Red
        End If

        If Ampermeter1Table.Value.BackColor = Color.Red Then
            Ampermeter1Table.Value.BackColor = Color.DarkRed
        ElseIf Ampermeter1Table.Value.BackColor = Color.DarkRed Then
            Ampermeter1Table.Value.BackColor = Color.Red
        End If

        If Ampermeter2Table.Value.BackColor = Color.Red Then
            Ampermeter2Table.Value.BackColor = Color.DarkRed
        ElseIf Ampermeter2Table.Value.BackColor = Color.DarkRed Then
            Ampermeter2Table.Value.BackColor = Color.Red
        End If
        If Ampermeter3Table.Value.BackColor = Color.Red Then
            Ampermeter3Table.Value.BackColor = Color.DarkRed
        ElseIf Ampermeter3Table.Value.BackColor = Color.DarkRed Then
            Ampermeter3Table.Value.BackColor = Color.Red
        End If
        If Ampermeter4Table.Value.BackColor = Color.Red Then
            Ampermeter4Table.Value.BackColor = Color.DarkRed
        ElseIf Ampermeter4Table.Value.BackColor = Color.DarkRed Then
            Ampermeter4Table.Value.BackColor = Color.Red
        End If

        If Ampermeter5Table.Value.BackColor = Color.Red Then
            Ampermeter5Table.Value.BackColor = Color.DarkRed
        ElseIf Ampermeter5Table.Value.BackColor = Color.DarkRed Then
            Ampermeter5Table.Value.BackColor = Color.Red
        End If

        If Ampermeter6Table.Value.BackColor = Color.Red Then
            Ampermeter6Table.Value.BackColor = Color.DarkRed
        ElseIf Ampermeter6Table.Value.BackColor = Color.DarkRed Then
            Ampermeter6Table.Value.BackColor = Color.Red
        End If
        If Termometer1Table.Value.BackColor = Color.Red Then
            Termometer1Table.Value.BackColor = Color.DarkRed
        ElseIf Termometer1Table.Value.BackColor = Color.DarkRed Then
            Termometer1Table.Value.BackColor = Color.Red
        End If

    End Sub
    Private Sub TableHead1_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Me.Name = "TableForPDUB" Then
            DeviceName = "PDU B"
        ElseIf Me.Name = "TableForPDUA" Then
            DeviceName = "PDU A"
        Else
            DeviceName = "Unknown"
        End If
        timer1.Interval = 2000
        AnimationTimer.Interval = 1000
        Ampermeter1Table.SensorType.Text = "Ampermeter1(Phase1)"
        Ampermeter2Table.SensorType.Text = "Ampermeter2(Phase1)"
        Ampermeter3Table.SensorType.Text = "Ampermeter1(Phase2)"
        Ampermeter4Table.SensorType.Text = "Ampermeter2(Phase2)"
        Ampermeter5Table.SensorType.Text = "Ampermeter1(Phase3)"
        Ampermeter6Table.SensorType.Text = "Ampermeter2(Phase3)"
        Termometer1Table.SensorType.Text = "Termometer"
        Ampermeter1Table.Base.Text = DeviceName
        Ampermeter2Table.Base.Text = DeviceName
        Ampermeter3Table.Base.Text = DeviceName
        Ampermeter4Table.Base.Text = DeviceName
        Ampermeter5Table.Base.Text = DeviceName
        Ampermeter6Table.Base.Text = DeviceName
        Termometer1Table.Base.Text = DeviceName
    End Sub
    Public Sub RefreshAmp(input As WebMonitoringCard.Phase.Ampermeter, ByRef table As tabbleElem)
        table.Value.BackColor = Color.Yellow
        table.Value.Text = "--"
        If input.Current.IndexOf(" A") >= 0 Then
            table.Value.Text = input.Current
            Dim Current As Double = 0
            Dim Min As Double = 0
            Dim Warn As Double = 0
            Dim Max As Double = 0
            If input.Current <> "" And input.Current <> " " And input.Current <> "..." Then
                Current = Convert.ToDouble(input.Current.Replace(" A", "").Replace(".", ","))
            End If
            If input.Min <> "" And input.Min <> " " And input.Min <> "..." Then
                Min = Convert.ToDouble(input.Min.Replace(".", ","))
            End If
            If input.Warn <> "" And input.Warn <> " " And input.Warn <> "..." Then
                Warn = Convert.ToDouble(input.Warn.Replace(".", ","))
            End If
            If input.Max <> "" And input.Max <> " " And input.Max <> "..." Then
                Max = Convert.ToDouble(input.Max.Replace(".", ","))
            End If
            If Current <= Min Then
                table.Value.BackColor = Color.DodgerBlue
            End If
            If Current >= Min Then
                table.Value.BackColor = Color.LimeGreen
            End If
            If Current >= Warn Then
                table.Value.BackColor = Color.DarkOrange
            End If
            If Current >= Max Then
                table.Value.BackColor = Color.Red
                If thisDevice.IP.FullString = TempProfile.Data.PDUA.IP.FullString Then

                End If
            End If
        End If

    End Sub
    Dim calcTIme As Double = 0
    Dim time As Double = 0
    Public Function AlertFunc() As Boolean
        If My.Forms.Workspace.AllertConfig1.CheckBox1.Checked Then
            If time = calcTIme Then
                If p2Grab = False Then

                    If thisDevice.IP.FullString = TempProfile.Data.PDUA.IP.FullString Then
                        If TempProfile.Data.PDUA.SensorList.LogCard.Ampermeter1L Then
                            If Ampermeter1Table.Value.BackColor = Color.Red Then
                                My.Forms.Workspace.Log1.SendMessagesFunction(New Message("Alert", "in PDU " + TempProfile.Data.PDUA.IP.FullString + " Ampermeter1 (Phase 1) readings exceed the set limit", ""))

                            End If
                        End If
                        If TempProfile.Data.PDUA.SensorList.LogCard.Ampermeter2L Then
                            If Ampermeter2Table.Value.BackColor = Color.Red Then
                                My.Forms.Workspace.Log1.SendMessagesFunction(New Message("Alert", "in PDU " + TempProfile.Data.PDUA.IP.FullString + " Ampermeter2 (Phase 1) readings exceed the set limit", ""))
                            End If
                        End If
                        If TempProfile.Data.PDUA.SensorList.LogCard.Ampermeter3L Then
                            If Ampermeter3Table.Value.BackColor = Color.Red Then
                                My.Forms.Workspace.Log1.SendMessagesFunction(New Message("Alert", "in PDU " + TempProfile.Data.PDUA.IP.FullString + " Ampermeter1 (Phase 2) readings exceed the set limit", ""))
                            End If
                        End If
                        If TempProfile.Data.PDUA.SensorList.LogCard.Ampermeter4L Then
                            If Ampermeter4Table.Value.BackColor = Color.Red Then
                                My.Forms.Workspace.Log1.SendMessagesFunction(New Message("Alert", "in PDU " + TempProfile.Data.PDUA.IP.FullString + " Ampermeter2 (Phase 2) readings exceed the set limit", ""))
                            End If
                        End If
                        If TempProfile.Data.PDUA.SensorList.LogCard.Ampermeter5L Then
                            If Ampermeter5Table.Value.BackColor = Color.Red Then
                                My.Forms.Workspace.Log1.SendMessagesFunction(New Message("Alert", "in PDU " + TempProfile.Data.PDUA.IP.FullString + " Ampermeter1 (Phase 3) readings exceed the set limit", ""))
                            End If
                        End If
                        If TempProfile.Data.PDUA.SensorList.LogCard.Ampermeter6L Then
                            If Ampermeter6Table.Value.BackColor = Color.Red Then
                                My.Forms.Workspace.Log1.SendMessagesFunction(New Message("Alert", "in PDU " + TempProfile.Data.PDUA.IP.FullString + " Ampermeter2 (Phase 3) readings exceed the set limit", ""))
                            End If
                        End If
                    End If


                    If thisDevice.IP.FullString = TempProfile.Data.PDUB.IP.FullString Then
                        If TempProfile.Data.PDUB.SensorList.LogCard.Ampermeter1L Then
                            If Ampermeter1Table.Value.BackColor = Color.Red Then
                                My.Forms.Workspace.Log1.SendMessagesFunction(New Message("Alert", "in PDU " + TempProfile.Data.PDUB.IP.FullString + " Ampermeter1 (Phase 1) readings exceed the set limit", ""))
                            End If
                        End If
                        If TempProfile.Data.PDUB.SensorList.LogCard.Ampermeter2L Then
                            If Ampermeter2Table.Value.BackColor = Color.Red Then
                                My.Forms.Workspace.Log1.SendMessagesFunction(New Message("Alert", "in PDU " + TempProfile.Data.PDUB.IP.FullString + " Ampermeter2 (Phase 1) readings exceed the set limit", ""))
                            End If
                        End If
                        If TempProfile.Data.PDUB.SensorList.LogCard.Ampermeter3L Then
                            If Ampermeter3Table.Value.BackColor = Color.Red Then
                                My.Forms.Workspace.Log1.SendMessagesFunction(New Message("Alert", "in PDU " + TempProfile.Data.PDUB.IP.FullString + " Ampermeter1 (Phase 2) readings exceed the set limit", ""))
                            End If

                        End If
                        If TempProfile.Data.PDUB.SensorList.LogCard.Ampermeter4L Then
                            If Ampermeter4Table.Value.BackColor = Color.Red Then
                                My.Forms.Workspace.Log1.SendMessagesFunction(New Message("Alert", "in PDU " + TempProfile.Data.PDUB.IP.FullString + " Ampermeter2 (Phase 2) readings exceed the set limit", ""))
                            End If
                        End If
                        If TempProfile.Data.PDUB.SensorList.LogCard.Ampermeter5L Then
                            If Ampermeter5Table.Value.BackColor = Color.Red Then
                                My.Forms.Workspace.Log1.SendMessagesFunction(New Message("Alert", "in PDU " + TempProfile.Data.PDUB.IP.FullString + " Ampermeter1 (Phase 3) readings exceed the set limit", ""))
                            End If
                        End If
                        If TempProfile.Data.PDUB.SensorList.LogCard.Ampermeter6L Then
                            If Ampermeter6Table.Value.BackColor = Color.Red Then
                                My.Forms.Workspace.Log1.SendMessagesFunction(New Message("Alert", "in PDU " + TempProfile.Data.PDUB.IP.FullString + " Ampermeter2 (Phase 3) readings exceed the set limit", ""))
                            End If
                        End If
                    End If
                    p2Grab = True
                End If
            End If
        End If
    End Function
    Public Sub RefreshPhase(input As WebMonitoringCard.Phase.Section, ByRef table As tabbleElem)
        If input.message.Length >= 1 Then
            table.Status.Text = input.message
        End If
        If table.Status.Text = "OK" Then
            table.Status.BackColor = Color.LimeGreen
        ElseIf table.Status.Text = "no section" Then
            table.Status.BackColor = Color.Red
        ElseIf table.Status.Text = "no sensor" Then
            table.Status.Text = "no sensor"
            table.Status.BackColor = Color.Yellow
        ElseIf table.Status.Text = " " Then
            table.Status.BackColor = Color.White
        Else
            table.Status.BackColor = Color.White
        End If
    End Sub
    Private Sub refreshFunc()
        If thisDeviceModule.dataFile.table Is Nothing Then
            Exit Sub
        End If
        If thisDevice.SensorList.MonitoringCard.Ampermeter1M Then
            RefreshAmp(thisDeviceModule.dataFile.table.Phase1.Ampermeter1, Ampermeter1Table)
            RefreshPhase(thisDeviceModule.dataFile.table.Phase1.Section1, Ampermeter1Table)
        End If
        If thisDevice.SensorList.MonitoringCard.Ampermeter2M Then
            RefreshAmp(thisDeviceModule.dataFile.table.Phase1.Ampermeter2, Ampermeter2Table)
            RefreshPhase(thisDeviceModule.dataFile.table.Phase1.Section2, Ampermeter2Table)
        End If
        If thisDevice.SensorList.MonitoringCard.Ampermeter3M Then
            RefreshAmp(thisDeviceModule.dataFile.table.Phase2.Ampermeter1, Ampermeter3Table)
            RefreshPhase(thisDeviceModule.dataFile.table.Phase2.Section1, Ampermeter3Table)
        End If
        If thisDevice.SensorList.MonitoringCard.Ampermeter4M Then
            RefreshAmp(thisDeviceModule.dataFile.table.Phase2.Ampermeter2, Ampermeter4Table)
            RefreshPhase(thisDeviceModule.dataFile.table.Phase2.Section2, Ampermeter4Table)
        End If
        If thisDevice.SensorList.MonitoringCard.Ampermeter5M Then
            RefreshAmp(thisDeviceModule.dataFile.table.Phase3.Ampermeter1, Ampermeter5Table)
            RefreshPhase(thisDeviceModule.dataFile.table.Phase3.Section1, Ampermeter5Table)
        End If
        If thisDevice.SensorList.MonitoringCard.Ampermeter6M Then
            RefreshAmp(thisDeviceModule.dataFile.table.Phase3.Ampermeter2, Ampermeter6Table)
            RefreshPhase(thisDeviceModule.dataFile.table.Phase3.Section2, Ampermeter6Table)
        End If
        '-----------------------------------------------------------------------------------Индикация показаний амперметра для TERMOMETER 1
        If thisDevice.SensorList.MonitoringCard.TermometerM Then
            If thisDeviceModule.dataFile.table.Temp.Value.IndexOf(" °C") >= 0 Then
                Termometer1Table.Value.Text = thisDeviceModule.dataFile.table.Temp.Value
                Dim bufVAlue As String = thisDeviceModule.dataFile.table.Temp.Value
                Dim IntValue As Double = Convert.ToDouble(bufVAlue.Replace(" °C", "").Replace(".", ","))

                bufVAlue = thisDeviceModule.dataFile.MonitoringCofig.Temp.Trigger
                If bufVAlue <> "" And bufVAlue <> " " And bufVAlue <> "..." Then
                    Dim IntVAlue2 As Integer = Convert.ToDouble(bufVAlue.Replace(".", ","))
                    If IntValue <= IntVAlue2 Then
                        Termometer1Table.Status.Text = "OK"
                        Termometer1Table.Status.BackColor = Color.LimeGreen
                        Termometer1Table.Value.BackColor = Color.LimeGreen
                    ElseIf IntValue > IntVAlue2 Then
                        Termometer1Table.Status.Text = "Alert"
                        Termometer1Table.Status.BackColor = Color.Red
                        Termometer1Table.Value.BackColor = Color.Red
                    Else
                        Termometer1Table.Status.Text = ""
                        Termometer1Table.Status.BackColor = Color.White
                        Termometer1Table.Value.BackColor = Color.White
                    End If
                End If
            Else
                Termometer1Table.Value.BackColor = Color.Yellow
                Termometer1Table.Value.Text = "--"
                Termometer1Table.Status.BackColor = Color.Yellow
                Termometer1Table.Status.Text = "no sensor"

            End If
        End If

    End Sub
    Public Sub startTable(Input As SensorMap)
        unvisible()
        Ampermeter1Table.Visible = Input.MonitoringCard.Ampermeter1M
        Ampermeter2Table.Visible = Input.MonitoringCard.Ampermeter2M
        Ampermeter3Table.Visible = Input.MonitoringCard.Ampermeter3M
        Ampermeter4Table.Visible = Input.MonitoringCard.Ampermeter4M
        Ampermeter5Table.Visible = Input.MonitoringCard.Ampermeter5M
        Ampermeter6Table.Visible = Input.MonitoringCard.Ampermeter6M
        Termometer1Table.Visible = Input.MonitoringCard.TermometerM
    End Sub
    Private Sub unvisible()
        Ampermeter1Table.Visible = False
        Ampermeter2Table.Visible = False
        Ampermeter3Table.Visible = False
        Ampermeter4Table.Visible = False
        Ampermeter5Table.Visible = False
        Ampermeter6Table.Visible = False
        Termometer1Table.Visible = False
    End Sub
    Private Sub MyBase_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            TableHead1.Visible = True
            EndTable.Visible = True
            timer1.Start()
            startTable(thisDevice.SensorList)
        Else
            'unvisible()
            TableHead1.Visible = False
            EndTable.Visible = False
            timer1.Stop()
        End If
    End Sub
    Private Function thisDeviceModule() As Module1.VirtualDevice
        If Me.Name = "TableForPDUB" Then
            Return Module1.PDUB
        ElseIf Me.Name = "TableForPDUA" Then
            Return Module1.PDUA
        Else
            Return Nothing
        End If
    End Function
    Private Function thisDevice() As UserProfile.DevicesDataFile.DeviceData
        If Me.Name = "TableForPDUB" Then
            Return User.TempProfile.Data.PDUB
        ElseIf Me.Name = "TableForPDUA" Then
            Return User.TempProfile.Data.PDUA
        Else
            Return Nothing
        End If
    End Function
End Class
