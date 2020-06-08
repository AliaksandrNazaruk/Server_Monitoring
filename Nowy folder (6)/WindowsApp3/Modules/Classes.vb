Public Class DeviceInterface
    Public _unlock As Boolean
    Public Event UnlockChanged(e As Boolean)

    Public Sub New(Unlock As Boolean)
        _unlock = Unlock
    End Sub
    Public Sub DevIntUnlock(input As Boolean)
        _unlock = input
        RaiseEvent UnlockChanged(_unlock)
    End Sub
End Class


Public Class UserProfile
    Sub New(adm As Boolean, opr As Boolean, NameUser As String, PasswordUser As String)
        AdminMode = adm '
        OperatorMode = opr '
        Login = NameUser '
        Password = PasswordUser '
    End Sub

    '//General Data
    Public AdminMode As Boolean
    Public OperatorMode As Boolean
    Public Login As String
    Public Password As String
    Public Data As DevicesDataFile = New DevicesDataFile

    '//Allert Configuration Settings
    Public AlertMessageSwitch As Boolean
    Public AnimatedAlertSwitch As Boolean
    Public SoundAlertSwitch As Boolean
    Public SendMessageToEmailSwitch As Boolean
    Public TestModeSwitch As Boolean

    '//User Configuration Settings
    Public Title As String '
    Public Departament As String '
    Public Company As String '
    Public Email As String '
    Public SMSNumber As String '
    Public Location As String '

    '//Log Configuration Setting
    Public Log As LogBank = New LogBank
    Public Sub clear()
        AdminMode = False
        OperatorMode = False
        Login = ""
        Password = ""
        Data = New DevicesDataFile
        AlertMessageSwitch = False
        AnimatedAlertSwitch = False
        SoundAlertSwitch = False
        SendMessageToEmailSwitch = False
        TestModeSwitch = False
        Title = ""
        Departament = ""
        Company = ""
        Email = ""
        SMSNumber = ""
        Location = ""
    End Sub
    Public Function Save() As Boolean

        If Login IsNot Nothing Then
            If Password IsNot Nothing Then
                '//General and Admin Settings
                If My.Forms.UserEditForm.Visible Then
                    AdminMode = My.Forms.UserEditForm.AddNewUserPanel1.adminChecker.Checked
                    OperatorMode = My.Forms.UserEditForm.AddNewUserPanel1.OperatorChecker.Checked
                    Title = My.Forms.UserEditForm.AddNewUserPanel1.TittleInput.Text
                    Departament = My.Forms.UserEditForm.AddNewUserPanel1.DepInput.Text
                    Company = My.Forms.UserEditForm.AddNewUserPanel1.CompanyInput.Text
                    Email = My.Forms.UserEditForm.AddNewUserPanel1.EmailInput.Text
                    SMSNumber = My.Forms.UserEditForm.AddNewUserPanel1.PhoneInput.Text
                Else
                End If
                '//Allert Configuration Settings
                AlertMessageSwitch = My.Forms.Workspace.AllertConfig1.AllertMessageSwitch.Checked
                AnimatedAlertSwitch = My.Forms.Workspace.AllertConfig1.AnimatedAlertSwitch.Checked
                SoundAlertSwitch = My.Forms.Workspace.AllertConfig1.SoundAlertSwitch.Checked
                SendMessageToEmailSwitch = My.Forms.Workspace.AllertConfig1.SendMessageToEmailSwitch.Checked
                TestModeSwitch = My.Forms.Workspace.AllertConfig1.TestModeSwitch.Checked

                If MonitoringBase.connectToDevice IsNot Nothing Then
                    If MonitoringBase.connectToDevice.SNMPConnection IsNot Nothing Then
                        If MonitoringBase.connectToDevice.SNMPConnection.IP IsNot Nothing Then
                            Data.MB.IP = MonitoringBase.connectToDevice.SNMPConnection.IP
                            Data.MB.Login = MonitoringBase.connectToDevice.SNMPConnection.LOGIN
                            Data.MB.RememberCheckBOx = My.Forms.Workspace.SensorsConfig1.EnviromuxUserConnectionData1.Remember.Checked
                            'Data.MB.SensorList = My.Forms.Workspace._Listwa1.SensorMap
                        End If
                    End If
                End If

                If PDUA.connectToDevice IsNot Nothing Then
                    If PDUA.connectToDevice.WebConnection IsNot Nothing Then
                        If PDUA.connectToDevice.WebConnection.IP IsNot Nothing Then
                            Data.PDUA.IP = PDUA.connectToDevice.WebConnection.IP
                            Data.PDUA.Password = PDUA.connectToDevice.WebConnection.PASS
                            Data.PDUA.RememberCheckBOx = My.Forms.Workspace._Listwa1.PduUserConnectionData1.Remember.Checked
                            Data.PDUA.port = PDUA.connectToDevice.WebConnection.PORT
                            Data.PDUA.LocAddrCheckBox = My.Forms.Workspace._Listwa1.PduUserConnectionData1.LocAddrCheckBox.Checked
                            Data.PDUA.SensorList.MonitoringCard.Ampermeter1M = My.Forms.Workspace._Listwa1.PduSensorsSetting1.Ampermeter1Monitoring.Checked
                            Data.PDUA.SensorList.MonitoringCard.Ampermeter2M = My.Forms.Workspace._Listwa1.PduSensorsSetting1.Ampermeter2Monitoring.Checked
                            Data.PDUA.SensorList.MonitoringCard.Ampermeter3M = My.Forms.Workspace._Listwa1.PduSensorsSetting1.Ampermeter3Monitoring.Checked
                            Data.PDUA.SensorList.MonitoringCard.Ampermeter4M = My.Forms.Workspace._Listwa1.PduSensorsSetting1.Ampermeter4Monitoring.Checked
                            Data.PDUA.SensorList.MonitoringCard.Ampermeter5M = My.Forms.Workspace._Listwa1.PduSensorsSetting1.Ampermeter5Monitoring.Checked
                            Data.PDUA.SensorList.MonitoringCard.Ampermeter6M = My.Forms.Workspace._Listwa1.PduSensorsSetting1.Ampermeter6Monitoring.Checked
                            Data.PDUA.SensorList.MonitoringCard.TermometerM = My.Forms.Workspace._Listwa1.PduSensorsSetting1.TemperatureMonitor.Checked
                            Data.PDUA.SensorList.LogCard.Ampermeter1L = My.Forms.Workspace._Listwa1.PduSensorsSetting1.Ampermeter1Log.Checked
                            Data.PDUA.SensorList.LogCard.Ampermeter2L = My.Forms.Workspace._Listwa1.PduSensorsSetting1.Ampermeter2Log.Checked
                            Data.PDUA.SensorList.LogCard.Ampermeter3L = My.Forms.Workspace._Listwa1.PduSensorsSetting1.Ampermeter3Log.Checked
                            Data.PDUA.SensorList.LogCard.Ampermeter4L = My.Forms.Workspace._Listwa1.PduSensorsSetting1.Ampermeter4Log.Checked
                            Data.PDUA.SensorList.LogCard.Ampermeter5L = My.Forms.Workspace._Listwa1.PduSensorsSetting1.Ampermeter5Log.Checked
                            Data.PDUA.SensorList.LogCard.Ampermeter6L = My.Forms.Workspace._Listwa1.PduSensorsSetting1.Ampermeter6Log.Checked
                            Data.PDUA.SensorList.LogCard.TermometerL = My.Forms.Workspace._Listwa1.PduSensorsSetting1.TemperatureLog.Checked
                        End If
                    End If
                End If

                If PDUB.connectToDevice IsNot Nothing Then
                    If PDUA.connectToDevice.WebConnection IsNot Nothing Then
                        If PDUA.connectToDevice.WebConnection.IP IsNot Nothing Then
                            Data.PDUB.IP = PDUB.connectToDevice.WebConnection.IP
                            Data.PDUB.Password = PDUB.connectToDevice.WebConnection.PASS
                            Data.PDUB.RememberCheckBOx = My.Forms.Workspace._Listwa2.PduUserConnectionData1.Remember.Checked
                            Data.PDUB.port = PDUB.connectToDevice.WebConnection.PORT
                            Data.PDUB.LocAddrCheckBox = My.Forms.Workspace._Listwa1.PduUserConnectionData1.LocAddrCheckBox.Checked
                            Data.PDUB.SensorList.MonitoringCard.Ampermeter1M = My.Forms.Workspace._Listwa2.PduSensorsSetting1.Ampermeter1Monitoring.Checked
                            Data.PDUB.SensorList.MonitoringCard.Ampermeter2M = My.Forms.Workspace._Listwa2.PduSensorsSetting1.Ampermeter2Monitoring.Checked
                            Data.PDUB.SensorList.MonitoringCard.Ampermeter3M = My.Forms.Workspace._Listwa2.PduSensorsSetting1.Ampermeter3Monitoring.Checked
                            Data.PDUB.SensorList.MonitoringCard.Ampermeter4M = My.Forms.Workspace._Listwa2.PduSensorsSetting1.Ampermeter4Monitoring.Checked
                            Data.PDUB.SensorList.MonitoringCard.Ampermeter5M = My.Forms.Workspace._Listwa2.PduSensorsSetting1.Ampermeter5Monitoring.Checked
                            Data.PDUB.SensorList.MonitoringCard.Ampermeter6M = My.Forms.Workspace._Listwa2.PduSensorsSetting1.Ampermeter6Monitoring.Checked
                            Data.PDUB.SensorList.MonitoringCard.TermometerM = My.Forms.Workspace._Listwa2.PduSensorsSetting1.TemperatureMonitor.Checked
                            Data.PDUB.SensorList.LogCard.Ampermeter1L = My.Forms.Workspace._Listwa2.PduSensorsSetting1.Ampermeter1Log.Checked
                            Data.PDUB.SensorList.LogCard.Ampermeter2L = My.Forms.Workspace._Listwa2.PduSensorsSetting1.Ampermeter2Log.Checked
                            Data.PDUB.SensorList.LogCard.Ampermeter3L = My.Forms.Workspace._Listwa2.PduSensorsSetting1.Ampermeter3Log.Checked
                            Data.PDUB.SensorList.LogCard.Ampermeter4L = My.Forms.Workspace._Listwa2.PduSensorsSetting1.Ampermeter4Log.Checked
                            Data.PDUB.SensorList.LogCard.Ampermeter5L = My.Forms.Workspace._Listwa2.PduSensorsSetting1.Ampermeter5Log.Checked
                            Data.PDUB.SensorList.LogCard.Ampermeter6L = My.Forms.Workspace._Listwa2.PduSensorsSetting1.Ampermeter6Log.Checked
                            Data.PDUB.SensorList.LogCard.TermometerL = My.Forms.Workspace._Listwa2.PduSensorsSetting1.TemperatureLog.Checked
                        End If
                    End If
                End If


                'LOG!!!!!!!!!!!!!!!!!!!
                '!!!!!!!!!!!!!!!!!!!!!!
                '!!!!!!!!!!!!!!!!!!!!!!

                SaveProfileToFile()
                TempProfile.Synchronization()
                Return True
            End If
        End If
        Return False


    End Function

    Public Function Load() As Boolean
        If System.IO.File.Exists(My.Application.Info.DirectoryPath + "\" + User.TempProfile.Login + "ProfileFile.txt") Then
            'Загружаем данные из файла во временную память настроек пользователя программы
            Dim Buf = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath + "\" + User.TempProfile.Login + "ProfileFile.txt")
            AdminMode = GetDataBool(Buf, "AdminMode")
            OperatorMode = GetDataBool(Buf, "OperatorMode")
            Login = GetDataStr(Buf, "Login")
            Password = GetDataStr(Buf, "Password")
            Location = GetDataStr(Buf, "Location")
            Title = GetDataStr(Buf, "Title")
            Departament = GetDataStr(Buf, "Departament")
            Company = GetDataStr(Buf, "Company")
            Email = GetDataStr(Buf, "Email")
            SMSNumber = GetDataStr(Buf, "SMSNumber")
            AlertMessageSwitch = GetDataBool(Buf, "AlertMessageSwitch")
            AnimatedAlertSwitch = GetDataBool(Buf, "AnimatedAlertSwitch")
            SoundAlertSwitch = GetDataBool(Buf, "SoundAlertSwitch")
            SendMessageToEmailSwitch = GetDataBool(Buf, "SendMessageToEmailSwitch")
            TestModeSwitch = GetDataBool(Buf, "TestModeSwitch")

            Data.MB.IP = GetDataIP(Buf, "MonitoringBaseIP")
            Data.MB.Login = GetDataStr(Buf, "MonitoringBaseLogin")
            Data.MB.Password = GetDataStr(Buf, "MonitoringBasePassword")
            Data.MB.RememberCheckBOx = GetDataBool(Buf, "MonitoringBaseRememberCheckBOx")
            Data.MB.SensorList = GetDataSensorMap(Buf, "MonitoringBaseSensorMap", "MB")

            Data.PDUA.IP = GetDataIP(Buf, "PDUAIP")
            Data.PDUA.Login = GetDataStr(Buf, "PDUALogin")
            Data.PDUA.Password = GetDataStr(Buf, "PDUAPassword")
            Data.PDUA.port = GetDataStr(Buf, "PDUAPort")
            Data.PDUA.LocAddrCheckBox = GetDataBool(Buf, "PDUALocAddrCheckBox")
            Data.PDUA.RememberCheckBOx = GetDataBool(Buf, "PDUARememberCheckBOx")
            Data.PDUA.SensorList = GetDataSensorMap(Buf, "PDUASensorMap", "PDU")

            Data.PDUB.IP = GetDataIP(Buf, "PDUBIP")
            Data.PDUB.Login = GetDataStr(Buf, "PDUBLogin")
            Data.PDUB.Password = GetDataStr(Buf, "PDUBPassword")
            Data.PDUB.port = GetDataStr(Buf, "PDUBPort")
            Data.PDUB.LocAddrCheckBox = GetDataBool(Buf, "PDUBLocAddrCheckBox")
            Data.PDUB.RememberCheckBOx = GetDataBool(Buf, "PDUBRememberCheckBOx")
            Data.PDUB.SensorList = GetDataSensorMap(Buf, "PDUBSensorMap", "PDU")
            Return True
        Else

        End If
        Return False
    End Function
    Public Function Load(adr As String) As Boolean
        If System.IO.File.Exists(adr) Then
            'Загружаем данные из файла во временную память настроек пользователя программы
            Dim Buf = System.IO.File.ReadAllText(adr)
            AdminMode = GetDataBool(Buf, "AdminMode")
            OperatorMode = GetDataBool(Buf, "OperatorMode")
            Login = GetDataStr(Buf, "Login")
            Password = GetDataStr(Buf, "Password")
            Title = GetDataStr(Buf, "Title")
            Departament = GetDataStr(Buf, "Departament")
            Company = GetDataStr(Buf, "Company")
            Email = GetDataStr(Buf, "Email")
            SMSNumber = GetDataStr(Buf, "SMSNumber")
            AlertMessageSwitch = GetDataBool(Buf, "AlertMessageSwitch")
            AnimatedAlertSwitch = GetDataBool(Buf, "AnimatedAlertSwitch")
            SoundAlertSwitch = GetDataBool(Buf, "SoundAlertSwitch")
            SendMessageToEmailSwitch = GetDataBool(Buf, "SendMessageToEmailSwitch")
            TestModeSwitch = GetDataBool(Buf, "TestModeSwitch")

            Data.MB.IP = GetDataIP(Buf, "MonitoringBaseIP")
            Data.MB.Login = GetDataStr(Buf, "MonitoringBaseLogin")
            Data.MB.Password = GetDataStr(Buf, "MonitoringBasePassword")
            Data.MB.RememberCheckBOx = GetDataBool(Buf, "MonitoringBaseRememberCheckBOx")
            Data.MB.SensorList = GetDataSensorMap(Buf, "MonitoringBaseSensorMap", "MB")

            Data.PDUA.IP = GetDataIP(Buf, "PDUAIP")
            Data.PDUA.Login = GetDataStr(Buf, "PDUALogin")
            Data.PDUA.Password = GetDataStr(Buf, "PDUAPassword")
            Data.PDUA.port = GetDataStr(Buf, "PDUAPort")
            Data.PDUA.LocAddrCheckBox = GetDataBool(Buf, "PDUALocAddrCheckBox")
            Data.PDUA.RememberCheckBOx = GetDataBool(Buf, "PDUARememberCheckBOx")
            Data.PDUA.SensorList = GetDataSensorMap(Buf, "PDUASensorMap", "PDU")

            Data.PDUB.IP = GetDataIP(Buf, "PDUBIP")
            Data.PDUB.Login = GetDataStr(Buf, "PDUBLogin")
            Data.PDUB.Password = GetDataStr(Buf, "PDUBPassword")
            Data.PDUB.port = GetDataStr(Buf, "PDUBPort")
            Data.PDUB.LocAddrCheckBox = GetDataBool(Buf, "PDUBLocAddrCheckBox")
            Data.PDUB.RememberCheckBOx = GetDataBool(Buf, "PDUBRememberCheckBOx")
            Data.PDUB.SensorList = GetDataSensorMap(Buf, "PDUBSensorMap", "PDU")
            Return True
        Else

        End If
        Return False
    End Function
    Private Function GetDataBool(inpDataFile As String, NameParameter As String) As Boolean
        Dim indexValParam As Integer = inpDataFile.IndexOf(NameParameter) + NameParameter.Length + 1
        Dim ret As String = ""
        For i As Integer = indexValParam To inpDataFile.Length
            If inpDataFile(i) = "]" Or inpDataFile(i) = "}" Then
                Exit For
            End If
            ret = ret + inpDataFile(i)
        Next
        If ret = "True" Then
            Return True
        End If
        Return False
    End Function
    Private Function GetDataIP(inpDataFile As String, NameParameter As String) As IPaddress
        Dim indexValParam As Integer = inpDataFile.IndexOf(NameParameter) + NameParameter.Length + 1
        Dim buf As String = ""
        Dim arg1 As String = ""
        Dim arg2 As String = ""
        Dim arg3 As String = ""
        Dim arg4 As String = ""
        For i As Integer = indexValParam To inpDataFile.Length - 1
            If inpDataFile(i) = "}" Or inpDataFile(i) = "]" Then
                Exit For
            End If
            If inpDataFile(i) = "[" Then
                Continue For
            End If
            arg1 = arg1 + inpDataFile(i)
        Next
        For i As Integer = indexValParam + arg1.Length + 2 To inpDataFile.Length - 1
            If inpDataFile(i) = "}" Or inpDataFile(i) = "]" Then
                Exit For
            End If
            If inpDataFile(i) = "[" Then
                Continue For
            End If
            arg2 = arg2 + inpDataFile(i)
        Next
        For i As Integer = indexValParam + arg1.Length + arg2.Length + 4 To inpDataFile.Length - 1
            If inpDataFile(i) = "}" Or inpDataFile(i) = "]" Then
                Exit For
            End If
            If inpDataFile(i) = "[" Then
                Continue For
            End If
            arg3 = arg3 + inpDataFile(i)
        Next
        For i As Integer = indexValParam + arg1.Length + arg2.Length + arg3.Length + 6 To inpDataFile.Length - 1
            If inpDataFile(i) = "}" Or inpDataFile(i) = "]" Then
                Exit For
            End If
            If inpDataFile(i) = "[" Then
                Continue For
            End If
            arg4 = arg4 + inpDataFile(i)
        Next
        If arg1 = "" And arg2 = "" And arg3 = "" And arg4 = "" Then
            Return New IPaddress(0, 0, 0, 0)
        End If
        Return New IPaddress(Convert.ToInt16(arg1), Convert.ToInt16(arg2), Convert.ToInt16(arg3), Convert.ToInt16(arg4))
    End Function
    Private Function GetDataStr(inpDataFile As String, NameParameter As String) As String
        Dim indexValParam As Integer = inpDataFile.IndexOf(NameParameter) + NameParameter.Length + 1
        Dim ret As String = ""
        If indexValParam = NameParameter.Length Then
            Return ""
        End If
        For i As Integer = indexValParam To inpDataFile.Length

            If inpDataFile(i) = "]" Or inpDataFile(i) = "}" Then
                Exit For
            End If
            ret = ret + inpDataFile(i)
        Next
        If ret.Length >= 1 Then
            Return ret
        End If
        Return ""
    End Function
    Private Function GetDataSensorMap(inpDataFile As String, NameParameter As String, typeDevice As String) As SensorMap
        Dim ret As SensorMap = New SensorMap
        Dim indexValParam As Double = inpDataFile.IndexOf(NameParameter) + NameParameter.Length + 1
        Dim buf As String = ""
        For i As Integer = indexValParam To inpDataFile.Length - 1
            If inpDataFile(i) = "}" Then
                Exit For
            End If
            buf = buf + inpDataFile(i)
        Next
        If buf = "" Then
            Return ret
        End If
        If typeDevice = "MB" Then

        End If
        If typeDevice = "PDU" Then
            ret.MonitoringCard.Ampermeter1M = getValueDataStr(buf, "Ampermeter1")
            ret.MonitoringCard.Ampermeter2M = getValueDataStr(buf, "Ampermeter2")
            ret.MonitoringCard.Ampermeter3M = getValueDataStr(buf, "Ampermeter3")
            ret.MonitoringCard.Ampermeter4M = getValueDataStr(buf, "Ampermeter4")
            ret.MonitoringCard.Ampermeter5M = getValueDataStr(buf, "Ampermeter5")
            ret.MonitoringCard.Ampermeter6M = getValueDataStr(buf, "Ampermeter6")
            ret.MonitoringCard.TermometerM = getValueDataStr(buf, "TemperatureMonitor")
            ret.LogCard.Ampermeter1L = getValueDataStr(buf, "Log1")
            ret.LogCard.Ampermeter2L = getValueDataStr(buf, "Log2")
            ret.LogCard.Ampermeter3L = getValueDataStr(buf, "Log3")
            ret.LogCard.Ampermeter4L = getValueDataStr(buf, "Log4")
            ret.LogCard.Ampermeter5L = getValueDataStr(buf, "Log5")
            ret.LogCard.Ampermeter6L = getValueDataStr(buf, "Log6")
            ret.LogCard.TermometerL = getValueDataStr(buf, "TemperatureLog")
        End If
        Return ret
    End Function
    Private Function getValueDataStr(buf As String, param As String) As String
        Dim ret As String = ""
        Dim IndexParamVal As Integer = buf.IndexOf(param) + param.Length + 1
        For i As Integer = IndexParamVal To buf.Length - 1
            If buf(i) = "]" Then
                Exit For
            ElseIf buf(i) = "[" Then
                Continue For
            ElseIf buf(i) = vbCr Then
                Continue For
            ElseIf buf(i) = vbLf Then
                Continue For
            Else
                ret = ret + buf(i)
            End If
        Next
        Return ret
    End Function
    Public Sub SaveProfileToFile()
        If System.IO.File.Exists(My.Application.Info.DirectoryPath + "\" + Login + "ProfileFile.txt") Then
        Else
            Dim fs As System.IO.FileStream = System.IO.File.Create(My.Application.Info.DirectoryPath + "\" + Login + "ProfileFile.txt")
            fs.Close()
        End If
        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath + "\" + Login + "ProfileFile.txt", GenerateDataFile())
    End Sub
    Private Function GenerateDataFile() As String
        Dim MBFile As String = ""
        Dim PDUAFile As String = ""
        Dim PDUBFile As String = ""
        Dim file As String = "AdminMode" + "{" + AdminMode.ToString + "}" & vbCrLf +
                             "OperatorMode" + "{" + OperatorMode.ToString + "}" & vbCrLf +
                             "Login" + "{" + Login.ToString + "}" & vbCrLf +
                             "Password" + "{" + Password.ToString + "}" & vbCrLf +
                             "Location" + "{" + Location.ToString + "}" & vbCrLf +
                             "Title" + "{" + Title.ToString + "}" & vbCrLf +
                             "Departament" + "{" + Departament.ToString + "}" & vbCrLf +
                             "Company" + "{" + Company.ToString + "}" & vbCrLf +
                             "Email" + "{" + Email.ToString + "}" & vbCrLf +
                             "SMSNumber" + "{" + SMSNumber.ToString + "}" & vbCrLf +
                             "AlertMessageSwitch" + "{" + AlertMessageSwitch.ToString + "}" & vbCrLf +
                             "AnimatedAlertSwitch" + "{" + AnimatedAlertSwitch.ToString + "}" & vbCrLf +
                             "SoundAlertSwitch" + "{" + SoundAlertSwitch.ToString + "}" & vbCrLf +
                             "SendMessageToEmailSwitch" + "{" + SendMessageToEmailSwitch.ToString + "}" & vbCrLf +
                             "TestModeSwitch" + "{" + TestModeSwitch.ToString + "}" & vbCrLf
        If Data.MB.RememberCheckBOx Then
            MBFile =
            "MonitoringBaseIP" + "{" + "[" + Data.MB.IP.Arg1.ToString + "]" + "[" + Data.MB.IP.Arg2.ToString + "]" + "[" + Data.MB.IP.Arg3.ToString + "]" + "[" + Data.MB.IP.Arg4.ToString + "]" + "}" & vbCrLf +
            "MonitoringBaseLogin" + "{" + Data.MB.Login.ToString + "}" & vbCrLf +
            "MonitoringBasePassword" + "{" + Data.MB.Password.ToString + "}" & vbCrLf +
            "MonitoringBaseRememberCheckBOx" + "{" + Data.MB.RememberCheckBOx.ToString + "}" & vbCrLf +
            "MonitoringBaseSensorMap" + "{" + SensorMapTostring(Data.MB.SensorList, "MB") + "}" & vbCrLf
        Else
            MBFile =
            "MonitoringBaseIP" + "{" + "[0]" + "[0]" + "[0]" + "[0]" + "}" & vbCrLf +
            "MonitoringBaseLogin" + "{}" & vbCrLf +
            "MonitoringBasePassword" + "{}" & vbCrLf +
            "MonitoringBaseRememberCheckBOx" + "{}" & vbCrLf +
            "MonitoringBaseSensorMap" + "{" + SensorMapTostring(Data.MB.SensorList, "MB") + "}" & vbCrLf
        End If
        If Data.PDUA.RememberCheckBOx Then
            PDUAFile =
            "PDUAIP" + "{" + "[" + Data.PDUA.IP.Arg1.ToString + "]" + "[" + Data.PDUA.IP.Arg2.ToString + "]" + "[" + Data.PDUA.IP.Arg3.ToString + "]" + "[" + Data.PDUA.IP.Arg4.ToString + "]" + "}" & vbCrLf +
            "PDUALogin" + "{" + Data.PDUA.Login.ToString + "}" & vbCrLf +
            "PDUAPassword" + "{" + Data.PDUA.Password.ToString + "}" & vbCrLf +
            "PDUAPort" + "{" + Data.PDUA.port.ToString + "}" & vbCrLf +
            "PDUARememberCheckBOx" + "{" + Data.PDUA.RememberCheckBOx.ToString + "}" & vbCrLf +
            "PDUALocAddrCheckBox" + "{" + Data.PDUA.LocAddrCheckBox.ToString + "}" & vbCrLf +
            "PDUASensorMap" + "{" + SensorMapTostring(Data.PDUA.SensorList, "PDU") + "}" & vbCrLf
        Else
            PDUAFile =
            "PDUAIP" + "{" + "[0]" + "[0]" + "[0]" + "[0]" + "}" & vbCrLf +
            "PDUALogin" + "{}" & vbCrLf +
            "PDUAPassword" + "{}" & vbCrLf +
            "PDUAPort" + "{}" & vbCrLf +
            "PDUARememberCheckBOx" + "{}" & vbCrLf +
            "PDUALocAddrCheckBox" + "{}" & vbCrLf +
            "PDUASensorMap" + "{" + SensorMapTostring(Data.PDUA.SensorList, "PDU") + "}" & vbCrLf
        End If
        If Data.PDUB.RememberCheckBOx Then
            PDUBFile =
            "PDUBIP" + "{" + "[" + Data.PDUB.IP.Arg1.ToString + "]" + "[" + Data.PDUB.IP.Arg2.ToString + "]" + "[" + Data.PDUB.IP.Arg3.ToString + "]" + "[" + Data.PDUB.IP.Arg4.ToString + "]" + "}" & vbCrLf +
            "PDUBLogin" + "{" + Data.PDUB.Login.ToString + "}" & vbCrLf +
            "PDUBPassword" + "{" + Data.PDUB.Password.ToString + "}" & vbCrLf +
            "PDUBPort" + "{" + Data.PDUA.port.ToString + "}" & vbCrLf +
            "PDUBLocAddrCheckBox" + "{" + Data.PDUA.LocAddrCheckBox.ToString + "}" & vbCrLf +
            "PDUBRememberCheckBOx" + "{" + Data.PDUB.RememberCheckBOx.ToString + "}" & vbCrLf +
            "PDUBSensorMap" + "{" + SensorMapTostring(Data.PDUB.SensorList, "PDU") + "}" & vbCrLf
        Else
            PDUBFile =
            "PDUBIP" + "{" + "[0]" + "[0]" + "[0]" + "[0]" + "}" & vbCrLf +
            "PDUBLogin" + "{}" & vbCrLf +
            "PDUBPassword" + "{}" & vbCrLf +
            "PDUBPort" + "{}" & vbCrLf +
            "PDUBRememberCheckBOx" + "{}" & vbCrLf +
            "PDUBLocAddrCheckBox" + "{}" & vbCrLf +
            "PDUBSensorMap" + "{" + SensorMapTostring(Data.PDUB.SensorList, "PDU") + "}" & vbCrLf
        End If
        Return file + MBFile + PDUAFile + PDUBFile
    End Function
    Private Function SensorMapTostring(inputMap As SensorMap, typeDevice As String) As String
        Dim Map As String = ""
        If typeDevice = "MB" Then

        End If
        If typeDevice = "PDU" Then
            Map = "Ampermeter1" + "[" + inputMap.MonitoringCard.Ampermeter1M.ToString + "]" + "Ampermeter2" + "[" + inputMap.MonitoringCard.Ampermeter2M.ToString + "]" + "Ampermeter3" + "[" + inputMap.MonitoringCard.Ampermeter3M.ToString + "]" + "Ampermeter4" + "[" + inputMap.MonitoringCard.Ampermeter4M.ToString + "]" + "Ampermeter5" + "[" + inputMap.MonitoringCard.Ampermeter5M.ToString + "]" + "Ampermeter6" + "[" + inputMap.MonitoringCard.Ampermeter6M.ToString + "]" + "TemperatureMonitor" + "[" + inputMap.MonitoringCard.TermometerM.ToString + "]" +
                   "Log1" + "[" + inputMap.LogCard.Ampermeter1L.ToString + "]" + "Log2" + "[" + inputMap.LogCard.Ampermeter2L.ToString + "]" + "Log3" + "[" + inputMap.LogCard.Ampermeter3L.ToString + "]" + "Log4" + "[" + inputMap.LogCard.Ampermeter4L.ToString + "]" + "Log5" + "[" + inputMap.LogCard.Ampermeter5L.ToString + "]" + "Log6" + "[" + inputMap.LogCard.Ampermeter6L.ToString + "]" + "TemperatureLog" + "[" + inputMap.LogCard.TermometerL.ToString + "]"
        End If
        Return Map
    End Function
    Public Class DevicesDataFile
        Public PDUA As DeviceData = New DeviceData
        Public PDUB As DeviceData = New DeviceData
        Public MB As DeviceData = New DeviceData

        Public Class DeviceData
            Public port As String = ""
            Public Type As String = ""
            Public IP As IPaddress = New IPaddress(0, 0, 0, 0)
            Public Login As String = ""
            Public Password As String = ""
            Public RememberCheckBOx As Boolean = False
            Public LocAddrCheckBox As Boolean = False
            Public SensorList As SensorMap = New SensorMap
            Public Sub clear()
                Type = ""
                port = ""
                IP = New IPaddress(0, 0, 0, 0)
                Login = ""
                Password = ""
                RememberCheckBOx = False
                SensorList = New SensorMap
            End Sub
        End Class
    End Class
    Public Sub Synchronization()

        'Синхронизируем загруженные данные с графическим интерфейсом программы

        My.Forms.Workspace.AllertConfig1.AllertMessageSwitch.Checked = AlertMessageSwitch
        My.Forms.Workspace.AllertConfig1.AnimatedAlertSwitch.Checked = AnimatedAlertSwitch
        My.Forms.Workspace.AllertConfig1.SoundAlertSwitch.Checked = SoundAlertSwitch
        My.Forms.Workspace.AllertConfig1.SendMessageToEmailSwitch.Checked = SendMessageToEmailSwitch
        My.Forms.Workspace.AllertConfig1.TestModeSwitch.Checked = TestModeSwitch
        My.Forms.Workspace.InfoPanel1.labLocation.Text = Location

        My.Forms.Workspace._Listwa1.PduUserConnectionData1.Remember.Checked = Data.PDUA.RememberCheckBOx
        My.Forms.Workspace._Listwa1.PduUserConnectionData1.IpAddpessBox1.InpIPTextBox1.Text = Data.PDUA.IP.Arg1.ToString
        My.Forms.Workspace._Listwa1.PduUserConnectionData1.IpAddpessBox1.InpIPTextBox2.Text = Data.PDUA.IP.Arg2.ToString
        My.Forms.Workspace._Listwa1.PduUserConnectionData1.IpAddpessBox1.InpIPTextBox3.Text = Data.PDUA.IP.Arg3.ToString
        My.Forms.Workspace._Listwa1.PduUserConnectionData1.IpAddpessBox1.InpIPTextBox4.Text = Data.PDUA.IP.Arg4.ToString
        My.Forms.Workspace._Listwa1.PduUserConnectionData1.PortBox.Text = Data.PDUA.port
        My.Forms.Workspace._Listwa1.PduUserConnectionData1.PasswordBox.Text = Data.PDUA.Password
        My.Forms.Workspace._Listwa1.PduSensorsSetting1.Ampermeter1Monitoring.Checked = Data.PDUA.SensorList.MonitoringCard.Ampermeter1M
        My.Forms.Workspace._Listwa1.PduSensorsSetting1.Ampermeter2Monitoring.Checked = Data.PDUA.SensorList.MonitoringCard.Ampermeter2M
        My.Forms.Workspace._Listwa1.PduSensorsSetting1.Ampermeter3Monitoring.Checked = Data.PDUA.SensorList.MonitoringCard.Ampermeter3M
        My.Forms.Workspace._Listwa1.PduSensorsSetting1.Ampermeter4Monitoring.Checked = Data.PDUA.SensorList.MonitoringCard.Ampermeter4M
        My.Forms.Workspace._Listwa1.PduSensorsSetting1.Ampermeter5Monitoring.Checked = Data.PDUA.SensorList.MonitoringCard.Ampermeter5M
        My.Forms.Workspace._Listwa1.PduSensorsSetting1.Ampermeter6Monitoring.Checked = Data.PDUA.SensorList.MonitoringCard.Ampermeter6M
        My.Forms.Workspace._Listwa1.PduSensorsSetting1.TemperatureMonitor.Checked = Data.PDUA.SensorList.MonitoringCard.TermometerM
        My.Forms.Workspace._Listwa1.PduSensorsSetting1.Ampermeter1Log.Checked = Data.PDUA.SensorList.LogCard.Ampermeter1L
        My.Forms.Workspace._Listwa1.PduSensorsSetting1.Ampermeter2Log.Checked = Data.PDUA.SensorList.LogCard.Ampermeter2L
        My.Forms.Workspace._Listwa1.PduSensorsSetting1.Ampermeter3Log.Checked = Data.PDUA.SensorList.LogCard.Ampermeter3L
        My.Forms.Workspace._Listwa1.PduSensorsSetting1.Ampermeter4Log.Checked = Data.PDUA.SensorList.LogCard.Ampermeter4L
        My.Forms.Workspace._Listwa1.PduSensorsSetting1.Ampermeter5Log.Checked = Data.PDUA.SensorList.LogCard.Ampermeter5L
        My.Forms.Workspace._Listwa1.PduSensorsSetting1.Ampermeter6Log.Checked = Data.PDUA.SensorList.LogCard.Ampermeter6L
        My.Forms.Workspace._Listwa1.PduSensorsSetting1.TemperatureLog.Checked = Data.PDUA.SensorList.LogCard.TermometerL
        My.Forms.Workspace._Listwa2.PduUserConnectionData1.Remember.Checked = Data.PDUB.RememberCheckBOx
        My.Forms.Workspace._Listwa2.PduUserConnectionData1.IpAddpessBox1.InpIPTextBox1.Text = Data.PDUB.IP.Arg1.ToString
        My.Forms.Workspace._Listwa2.PduUserConnectionData1.IpAddpessBox1.InpIPTextBox2.Text = Data.PDUB.IP.Arg2.ToString
        My.Forms.Workspace._Listwa2.PduUserConnectionData1.IpAddpessBox1.InpIPTextBox3.Text = Data.PDUB.IP.Arg3.ToString
        My.Forms.Workspace._Listwa2.PduUserConnectionData1.IpAddpessBox1.InpIPTextBox4.Text = Data.PDUB.IP.Arg4.ToString
        My.Forms.Workspace._Listwa2.PduUserConnectionData1.PortBox.Text = Data.PDUB.port
        My.Forms.Workspace._Listwa2.PduUserConnectionData1.PasswordBox.Text = Data.PDUB.Password
        My.Forms.Workspace._Listwa2.PduSensorsSetting1.Ampermeter1Monitoring.Checked = Data.PDUB.SensorList.MonitoringCard.Ampermeter1M
        My.Forms.Workspace._Listwa2.PduSensorsSetting1.Ampermeter2Monitoring.Checked = Data.PDUB.SensorList.MonitoringCard.Ampermeter2M
        My.Forms.Workspace._Listwa2.PduSensorsSetting1.Ampermeter3Monitoring.Checked = Data.PDUB.SensorList.MonitoringCard.Ampermeter3M
        My.Forms.Workspace._Listwa2.PduSensorsSetting1.Ampermeter4Monitoring.Checked = Data.PDUB.SensorList.MonitoringCard.Ampermeter4M
        My.Forms.Workspace._Listwa2.PduSensorsSetting1.Ampermeter5Monitoring.Checked = Data.PDUB.SensorList.MonitoringCard.Ampermeter5M
        My.Forms.Workspace._Listwa2.PduSensorsSetting1.Ampermeter6Monitoring.Checked = Data.PDUB.SensorList.MonitoringCard.Ampermeter6M
        My.Forms.Workspace._Listwa2.PduSensorsSetting1.TemperatureMonitor.Checked = Data.PDUB.SensorList.MonitoringCard.TermometerM
        My.Forms.Workspace._Listwa2.PduSensorsSetting1.Ampermeter1Log.Checked = Data.PDUB.SensorList.LogCard.Ampermeter1L
        My.Forms.Workspace._Listwa2.PduSensorsSetting1.Ampermeter2Log.Checked = Data.PDUB.SensorList.LogCard.Ampermeter2L
        My.Forms.Workspace._Listwa2.PduSensorsSetting1.Ampermeter3Log.Checked = Data.PDUB.SensorList.LogCard.Ampermeter3L
        My.Forms.Workspace._Listwa2.PduSensorsSetting1.Ampermeter4Log.Checked = Data.PDUB.SensorList.LogCard.Ampermeter4L
        My.Forms.Workspace._Listwa2.PduSensorsSetting1.Ampermeter5Log.Checked = Data.PDUB.SensorList.LogCard.Ampermeter5L
        My.Forms.Workspace._Listwa2.PduSensorsSetting1.Ampermeter6Log.Checked = Data.PDUB.SensorList.LogCard.Ampermeter6L
        My.Forms.Workspace._Listwa2.PduSensorsSetting1.TemperatureLog.Checked = Data.PDUB.SensorList.LogCard.TermometerL
        ProgramMode(AdminMode)
    End Sub
    Public Sub ProgramMode(input As Boolean)
        If input Then
            My.Forms.Workspace._Listwa1.PduGeneralSetting1.GenSetGroupBox.Enabled = True
            My.Forms.Workspace._Listwa1.PduGeneralSetting1.AlertConfGroupBox.Enabled = True
            My.Forms.Workspace._Listwa1.GenSetTabPage.Enabled = True
            My.Forms.Workspace._Listwa2.PduGeneralSetting1.GenSetGroupBox.Enabled = True
            My.Forms.Workspace._Listwa2.PduGeneralSetting1.AlertConfGroupBox.Enabled = True
            My.Forms.Workspace._Listwa2.GenSetTabPage.Enabled = True
        Else
            My.Forms.Workspace._Listwa1.PduGeneralSetting1.GenSetGroupBox.Enabled = False
            My.Forms.Workspace._Listwa1.PduGeneralSetting1.AlertConfGroupBox.Enabled = False
            My.Forms.Workspace._Listwa1.GenSetTabPage.Enabled = False
            My.Forms.Workspace._Listwa2.PduGeneralSetting1.GenSetGroupBox.Enabled = False
            My.Forms.Workspace._Listwa2.PduGeneralSetting1.AlertConfGroupBox.Enabled = False
            My.Forms.Workspace._Listwa2.GenSetTabPage.Enabled = False
        End If
    End Sub
End Class
Public Class LogBank
    Public Pages As List(Of String) = New List(Of String)
End Class


Public Class Message
    Sub New(TypeMessage As String, inpHead As String, inpBODY As String)
        Type = TypeMessage
        HeadMessage = inpHead
        BodyMessage = inpBODY
        _Date = DateTime.Now
        ID = DateTime.Now.DayOfYear.ToString + DateTime.Now.Hour.ToString + DateTime.Now.Second.ToString + DateTime.Now.Minute.ToString + DateTime.Now.Millisecond.ToString
    End Sub
    Public HeadMessage As String = ""
    Public BodyMessage As String = ""
    Public Type As String = ""
    Public ID As String = ""
    Public _Date As DateTime = New DateTime
End Class

Public Class IPaddress
    Sub New(inp1 As Integer, inp2 As Integer, inp3 As Integer, inp4 As Integer)
        Arg1 = inp1.ToString
        Arg2 = inp2.ToString
        Arg3 = inp3.ToString
        Arg4 = inp4.ToString
    End Sub

    Public Arg1 As String
    Public Arg2 As String
    Public Arg3 As String
    Public Arg4 As String
    Public Function FullString() As String
        Return Arg1 + "." + Arg2 + "." + Arg3 + "." + Arg4
    End Function

    Public Function installed() As Boolean
        If Arg1 Is Nothing Then
            Return False
        End If
        If Arg2 Is Nothing Then
            Return False
        End If
        If Arg3 Is Nothing Then
            Return False
        End If
        If Arg4 Is Nothing Then
            Return False
        End If
        If Arg1 = "0" And Arg2 = "0" And Arg3 = "0" And Arg4 = "0" Then
            Return False
        End If
        If Arg1 = "" Or Arg2 = "" Or Arg3 = "" Or Arg4 = "" Then
            Return False
        End If
        Return True
    End Function

    Public Function StringToIP(input As String) As String
        Dim prearg1 As String
        Dim prearg2 As String
        Dim prearg3 As String
        Dim prearg4 As String
        Dim calc As Integer = 0
        Dim cursor As Integer = 0

        While (calc < 3)
            While (calc < 2)
                While (calc < 1)
                    For i As Integer = cursor To cursor + 3
                        If input(i) = "." Then
                            calc += 1
                            cursor += 1
                            Exit For
                        End If
                        prearg1 += input(i)
                        cursor += 1
                    Next
                End While
                For i As Integer = cursor To cursor + 3

                    If input(i) = "." Then
                        calc += 1
                        cursor += 1
                        Exit For
                    End If
                    prearg2 += input(i)
                    cursor += 1
                Next
            End While
            For i As Integer = cursor To cursor + 3
                If input(i) = "." Then
                    calc += 1
                    cursor += 1
                    Exit For
                End If
                prearg3 += input(i)
                cursor += 1
            Next
        End While
        For i As Integer = cursor To input.Length - 1
            prearg4 += input(i)
            cursor += 1
        Next

        Arg1 = prearg1
        Arg2 = prearg2
        Arg3 = prearg3
        Arg4 = prearg4

        Return FullString()
    End Function
End Class
'PDU CLASSES--------------------------------------------------------
'-------------------------------------------------------------------
Public Class WebInformationCard
    Public pduLocation As String = ""
    Public pduName As String = ""
    Public PartNumber As String = ""
    Public MACAdress As String = ""
    Public SoftwareVersion As String = ""
End Class
Public Class WebMonitoringCard
    Public TableType As String = ""
    Public Temp As Temperature = New Temperature
    Public Phase1 As Phase = New Phase
    Public Phase2 As Phase = New Phase
    Public Phase3 As Phase = New Phase
    Public Class Phase
        Public Ampermeter1 As Ampermeter = New Ampermeter
        Public Ampermeter2 As Ampermeter = New Ampermeter
        Public Section1 As Section = New Section
        Public Section2 As Section = New Section
        Public Class Ampermeter
            Public Range As String = ""
            Public Min As String = ""
            Public Warn As String = ""
            Public Max As String = ""
            Public Current As String = ""
        End Class
        Public Class Section
            Public Status As String = ""
            Public message As String = ""
        End Class
    End Class

    Public Class Temperature
        Public Range As String = ""
        Public Trigger As String = ""
        Public Value As String = ""
    End Class


    Public Function StatusCard() As String
        If TableType = "PDUTypeP3A6T0" Or TableType = "PDUTypeP3A6T1" Then
            If Phase1.Equals(New Phase) Then
                Return "Phase1 Not Filled"
            End If
            If Phase2.Equals(New Phase) Then
                Return "Phase2 Not Filled"
            End If
            If Phase3.Equals(New Phase) Then
                Return "Phase3 Not Filled"
            End If
            If Phase1.Ampermeter1.Current = " " Or Phase1.Ampermeter1.Current = "..." Then
                Return "Phase1.Ampermeter1 Not Filled"
            End If
            If Phase1.Ampermeter2.Current = " " Or Phase1.Ampermeter2.Current = "..." Then
                Return "Phase1.Ampermeter2 Not Filled"
            End If
            If Phase2.Ampermeter1.Current = " " Or Phase2.Ampermeter1.Current = "..." Then
                Return "Phase2.Ampermeter1 Not Filled"
            End If
            If Phase2.Ampermeter2.Current = " " Or Phase2.Ampermeter2.Current = "..." Then
                Return "Phase2.Ampermeter2 Not Filled"
            End If
            If Phase3.Ampermeter1.Current = " " Or Phase3.Ampermeter1.Current = "..." Then
                Return "Phase3.Ampermeter1 Not Filled"
            End If
            If Phase3.Ampermeter2.Current = " " Or Phase3.Ampermeter2.Current = "..." Then
                Return "Phase3.Ampermeter2 Not Filled"
            End If
            Return "Filled"
        End If
        If TableType = "PDUTypeP3A3T0" Or TableType = "PDUTypeP3A3T1" Then
            If Phase1.Equals(New Phase) Then
                Return "Phase1 Not Filled"
            End If
            If Phase2.Equals(New Phase) Then
                Return "Phase2 Not Filled"
            End If
            If Phase3.Equals(New Phase) Then
                Return "Phase3 Not Filled"
            End If
            If Phase1.Ampermeter1.Current = " " Or Phase1.Ampermeter1.Current = "..." Then
                Return "Phase1.Ampermeter1 Not Filled"
            End If
            If Phase2.Ampermeter1.Current = " " Or Phase2.Ampermeter1.Current = "..." Then
                Return "Phase2.Ampermeter1 Not Filled"
            End If
            If Phase3.Ampermeter1.Current = " " Or Phase3.Ampermeter1.Current = "..." Then
                Return "Phase3.Ampermeter1 Not Filled"
            End If
            Return "Filled"
        End If
        If TableType = "PDUTypeP1A2T0" Or TableType = "PDUTypeP1A2T1" Then
            If Phase1.Equals(New Phase) Then
                Return "Phase1 Not Filled"
            End If
            If Phase1.Ampermeter1.Current = " " Or Phase1.Ampermeter1.Current = "..." Then
                Return "Phase1.Ampermeter1 Not Filled"
            End If
            If Phase1.Ampermeter2.Current = " " Or Phase1.Ampermeter2.Current = "..." Then
                Return "Phase1.Ampermeter2 Not Filled"
            End If
            Return "Filled"
        End If
        If TableType = "PDUTypeP1A1T0" Or TableType = "PDUTypeP1A1T1" Then
            If Phase1.Equals(New Phase) Then
                Return "Phase1 Not Filled"
            End If
            If Phase1.Ampermeter1.Current = " " Or Phase1.Ampermeter1.Current = "..." Then
                Return "Phase1.Ampermeter1 Not Filled"
            End If
            Return "Filled"
        End If
        Return "Not filled"
    End Function
End Class
Public Class WebMonitoringConfigurationCard
    Public Temp As Temperature = New Temperature
    Public Phase1 As Phase = New Phase
    Public Phase2 As Phase = New Phase
    Public Phase3 As Phase = New Phase

    Public Class Phase
        Public Ampermeter1 As Ampermeter = New Ampermeter
        Public Ampermeter2 As Ampermeter = New Ampermeter
        Public Class Ampermeter
            Public Range As String = ""
            Public Min As String = ""
            Public warn As String = ""
            Public Max As String = ""
            Public Email As String = ""
            Public Syslog As String = ""
            Public Log As String = ""
            Public Trap As String = ""
            Public Alarm0A As String = ""

        End Class
        Public Email As String = ""
        Public Syslog As String = ""
        Public Log As String = ""
        Public Trap As String = ""
        Public Alarm0A As String = ""
    End Class
    Public Class Temperature
        Public Range As String = ""
        Public Trigger As String = ""
        Public Email As String = ""
        Public Syslog As String = ""
        Public Log As String = ""
        Public Trap As String = ""
    End Class
End Class
Public Class WebPDUConfigurationCard
    Public Location As String = ""
    Public Name As String = ""
    Public DHCPClient As String = ""
    Public IPAddress As String = ""
    Public SubnetMask As String = ""
    Public Gateway As String = ""
    Public UserPassword As String = ""
    Public AdminPassword As String = ""
    Public LoginTimeOut As String = ""
    Public AutoRefreshWebsite As String = ""
    Public Temperature As Boolean = False
End Class
Public Class WebAlertConfigurationCard
    Public SMTPUsername As String = ""
    Public SMPTPassword As String = ""
    Public SMTPSender As String = ""
    Public SMTPReciepient As String = ""
    Public SMTPIPAddressForServer As String = ""
    Public SMTPPortNumber As String = ""
    Public SyslogIPAddress As String = ""
    Public SyslogPortNumber As String = ""
    Public SNMPPrivateCommunity As String = ""
    Public SNMPPublicCommunity As String = ""
    Public SNMPIPAddressForTrap As String = ""
    Public SNTPIPAddresForServer As String = ""
End Class
Public Class WebDataAndYimeCard
    Public Year As String
    Public Month As String
    Public Day As String
    Public Hour As String
    Public Minute As String
End Class
Public Class WebLogCard
    Public Page1 As Page = New Page
    Public Page2 As Page = New Page
    Public Page3 As Page = New Page
    Public Page4 As Page = New Page
    Public Page5 As Page = New Page
    Public Page6 As Page = New Page
    Public Page7 As Page = New Page
    Public Page8 As Page = New Page
    Public Page9 As Page = New Page
    Public Page10 As Page = New Page
    Public Page11 As Page = New Page
    Public Page12 As Page = New Page
    Public Page13 As Page = New Page
    Public Page14 As Page = New Page
    Public Page15 As Page = New Page
    Public Page16 As Page = New Page
    Public Page17 As Page = New Page
    Public Page18 As Page = New Page
    Public Page19 As Page = New Page
    Public Page20 As Page = New Page
    Public Page21 As Page = New Page
    Public Page22 As Page = New Page
    Public Page23 As Page = New Page
    Public Page24 As Page = New Page
    Public Page25 As Page = New Page
    Public Page26 As Page = New Page
    Public Page27 As Page = New Page
    Public Page28 As Page = New Page
    Public Page29 As Page = New Page
    Public Page30 As Page = New Page
    Public Page31 As Page = New Page
    Public Page32 As Page = New Page
    Public Page33 As Page = New Page
    Public Page34 As Page = New Page
    Public Page35 As Page = New Page
    Public Page36 As Page = New Page
    Public Page37 As Page = New Page
    Public Page38 As Page = New Page
    Public Page39 As Page = New Page
    Public Page40 As Page = New Page
    Public Page41 As Page = New Page
    Public Page42 As Page = New Page
    Public Page43 As Page = New Page
    Public Page44 As Page = New Page
    Public Page45 As Page = New Page
    Public Page46 As Page = New Page
    Public Page47 As Page = New Page
    Public Page48 As Page = New Page
    Public Page49 As Page = New Page
    Public Page50 As Page = New Page
    Public Class Page
        Public String1 As String = ""
        Public String2 As String = ""
        Public String3 As String = ""
        Public String4 As String = ""
        Public String5 As String = ""
        Public String6 As String = ""
        Public String7 As String = ""
        Public String8 As String = ""
        Public String9 As String = ""
        Public String10 As String = ""
        Public String11 As String = ""
        Public String12 As String = ""
    End Class
End Class
Public Class ListwaDataFile
    Private newFile As ExportDataFileForPDU = New ExportDataFileForPDU
    Public Function FullGrab(input As ExportDataFileForPDU)
        newFile = input
        GrabInformation(newFile)
        GrabLogo(newFile)
        GrabTable(newFile)
        GrabPDUConfig(newFile)
        GrabAlertCOnfig(newFile)
        GrabMonitoringConfig(newFile)
    End Function
    Private Sub GrabMonitoringConfig(Input As ExportDataFileForPDU)
        MonitoringCofig = Input.MonitoringConfiguration
    End Sub
    Private Sub GrabAlertCOnfig(input As ExportDataFileForPDU)
        Alert = input.AlertConfiguration
    End Sub
    Private Sub GrabPDUConfig(input As ExportDataFileForPDU)
        PDUConfig = input.PDUConfiguration
    End Sub
    Private Sub GrabTable(input As ExportDataFileForPDU)
        table = input.Table
    End Sub
    Private Sub GrabInformation(input As ExportDataFileForPDU)
        information = input.Information
    End Sub
    Private Sub GrabLogo(input As ExportDataFileForPDU)
        Logo = input.logo
    End Sub
    Public information As WebInformationCard = New WebInformationCard
    Public Logo As PictureBox = New PictureBox
    Public table As WebMonitoringCard = New WebMonitoringCard
    Public PDUConfig As WebPDUConfigurationCard = New WebPDUConfigurationCard
    Public Alert As WebAlertConfigurationCard = New WebAlertConfigurationCard
    Public MonitoringCofig As WebMonitoringConfigurationCard = New WebMonitoringConfigurationCard
End Class
'----------------------------------------
Public Class SensorMapMonitoringSystem
    Sub New(constructor As dataFileConstructor)
        For i As Integer = 0 To constructor.IntSensorCount
            IntSensorList.Add(New Boolean)
        Next
        For i As Integer = 0 To constructor.DIgitalSensorCount
            DigInputList.Add(New Boolean)
        Next
        For i As Integer = 0 To constructor.ipSensorCount
            ipSensorList.Add(New Boolean)
        Next
        For i As Integer = 0 To constructor.remoteInputCount
            remoteInputsList.Add(New Boolean)
        Next
        For i As Integer = 0 To constructor.remoteRelayCount
            RemoteRelayList.Add(New Boolean)
        Next
        For i As Integer = 0 To constructor.smokeDetectorCount
            smokeDetectorsList.Add(New Boolean)
        Next
        For i As Integer = 0 To constructor.tacSensorCount
            TacSensorList.Add(New Boolean)
        Next
        For i As Integer = 0 To constructor.aux2SensorCount
            Aux2SensorList.Add(New Boolean)
        Next
        For i As Integer = 0 To constructor.auxSensorCount
            AuxSensorList.Add(New Boolean)
        Next
        For i As Integer = 0 To constructor.extSensorCount
            ExtSensorList.Add(New Boolean)
        Next
        For i As Integer = 0 To constructor.IPDeviceCount
            IPDevicesList.Add(New Boolean)
        Next
        For i As Integer = 0 To constructor.outRelayCount
            OutRelayList.Add(New Boolean)
        Next
        For i As Integer = 0 To constructor.pwrSupplyCount
            PwrSupplyList.Add(New Boolean)
        Next
    End Sub
    Public IntSensorList As List(Of Boolean) = New List(Of Boolean)
    Public SensorsList As List(Of Boolean) = New List(Of Boolean)
    Public DigInputList As List(Of Boolean) = New List(Of Boolean)
    Public ipSensorList As List(Of Boolean) = New List(Of Boolean)
    Public remoteInputsList As List(Of Boolean) = New List(Of Boolean)
    Public RemoteRelayList As List(Of Boolean) = New List(Of Boolean)
    Public smokeDetectorsList As List(Of Boolean) = New List(Of Boolean)
    Public TacSensorList As List(Of Boolean) = New List(Of Boolean)
    Public Aux2SensorList As List(Of Boolean) = New List(Of Boolean)
    Public AuxSensorList As List(Of Boolean) = New List(Of Boolean)
    Public ExtSensorList As List(Of Boolean) = New List(Of Boolean)
    Public IPDevicesList As List(Of Boolean) = New List(Of Boolean)
    Public OutRelayList As List(Of Boolean) = New List(Of Boolean)
    Public PwrSupplyList As List(Of Boolean) = New List(Of Boolean)
    Public MsgRegistersList As List(Of Boolean) = New List(Of Boolean)
End Class
Public Class SnmpInfoCard
    Public sysTime As String = ""
    Public sysName As String = ""
    Public sysLocation As String = ""
    Public sysBranch As String = ""
    Public sysRack As String = ""
    Public sysContact As String = ""
    Public sysPhone As String = ""
    Public firmwareVersion As String = ""
    Public deviceModel As String = ""
    Public sysReset As String = ""
    Public devSerialNum As String = ""
    Public devHardwareRev As String = ""
    Public devManufactureR As String = ""
End Class
Public Class SnmpIntSensorCard
    Public IndexList As List(Of String) = New List(Of String)
    Public TypeList As List(Of String) = New List(Of String)
    Public DescriptionList As List(Of String) = New List(Of String)
    Public ConnectorList As List(Of String) = New List(Of String)
    Public GroupList As List(Of String) = New List(Of String)
    Public GroupNbList As List(Of String) = New List(Of String)
    Public ValueList As List(Of String) = New List(Of String)
    Public UnitList As List(Of String) = New List(Of String)
    Public UnitNameList As List(Of String) = New List(Of String)
    Public StatusList As List(Of String) = New List(Of String)
    Public MinTresholdList As List(Of String) = New List(Of String)
    Public MaxTresholdList As List(Of String) = New List(Of String)
    Public MinWarnTresholdList As List(Of String) = New List(Of String)
    Public MaxWarnTresholdList As List(Of String) = New List(Of String)
End Class
Public Class SnmpAuxSensorCard
    Public IndexList As List(Of String) = New List(Of String)
    Public TypeList As List(Of String) = New List(Of String)
    Public DescriptionList As List(Of String) = New List(Of String)
    Public ConnectorList As List(Of String) = New List(Of String)
    Public GroupList As List(Of String) = New List(Of String)
    Public GroupNbList As List(Of String) = New List(Of String)
    Public ValueList As List(Of String) = New List(Of String)
    Public UnitList As List(Of String) = New List(Of String)
    Public UnitNameList As List(Of String) = New List(Of String)
    Public StatusList As List(Of String) = New List(Of String)
    Public MinTresholdList As List(Of String) = New List(Of String)
    Public MaxTresholdList As List(Of String) = New List(Of String)
    Public MinWarnTresholdList As List(Of String) = New List(Of String)
    Public MaxWarnTresholdList As List(Of String) = New List(Of String)
End Class
Public Class SnmpExtSensorCard
    Public IndexList As List(Of String) = New List(Of String)
    Public TypeList As List(Of String) = New List(Of String)
    Public DescriptionList As List(Of String) = New List(Of String)
    Public ConnectorList As List(Of String) = New List(Of String)
    Public GroupList As List(Of String) = New List(Of String)
    Public GroupNbList As List(Of String) = New List(Of String)
    Public ValueList As List(Of String) = New List(Of String)
    Public UnitList As List(Of String) = New List(Of String)
    Public UnitNameList As List(Of String) = New List(Of String)
    Public StatusList As List(Of String) = New List(Of String)
    Public NormalValueList As List(Of String) = New List(Of String)
    Public MinTresholdList As List(Of String) = New List(Of String)
    Public MaxTresholdList As List(Of String) = New List(Of String)
    Public MinWarnTresholdList As List(Of String) = New List(Of String)
    Public MaxWarnTresholdList As List(Of String) = New List(Of String)

    Public PeakValueList As List(Of String) = New List(Of String)
    Public FrequencyList As List(Of String) = New List(Of String)
    Public CurrentList As List(Of String) = New List(Of String)
    Public SpikesList As List(Of String) = New List(Of String)
    Public SwellsList As List(Of String) = New List(Of String)
    Public SagsList As List(Of String) = New List(Of String)
    Public RelayList As List(Of String) = New List(Of String)
    Public AclmIndexList As List(Of String) = New List(Of String)
End Class
Public Class SnmpDigInputCard
    Public IndexList As List(Of String) = New List(Of String)
    Public TypeList As List(Of String) = New List(Of String)
    Public DescriptionList As List(Of String) = New List(Of String)
    Public ConnectorList As List(Of String) = New List(Of String)
    Public GroupList As List(Of String) = New List(Of String)
    Public GroupNbList As List(Of String) = New List(Of String)
    Public ValueList As List(Of String) = New List(Of String)
    Public StatusList As List(Of String) = New List(Of String)
    Public NormalValueList As List(Of String) = New List(Of String)
End Class
Public Class SnmpIPDevicesCard
    Public IndexList As List(Of String) = New List(Of String)
    Public AddressList As List(Of String) = New List(Of String)
    Public DescriptionList As List(Of String) = New List(Of String)
    Public GroupNbList As List(Of String) = New List(Of String)
    Public GroupList As List(Of String) = New List(Of String)
    Public TimeoutList As List(Of String) = New List(Of String)
    Public ValueList As List(Of String) = New List(Of String)
    Public StatusList As List(Of String) = New List(Of String)
    Public RetriesList As List(Of String) = New List(Of String)
End Class
Public Class SnmpOutRelayCard
    Public IndexList As List(Of String) = New List(Of String)
    Public DescriptionList As List(Of String) = New List(Of String)
    Public StatusList As List(Of String) = New List(Of String)
End Class
Public Class SnmpPwrSupplyCard
    Public IndexList As List(Of String) = New List(Of String)
    Public StatusList As List(Of String) = New List(Of String)
End Class
Public Class SnmpRemoteInputCard
    Public IndexList As List(Of String) = New List(Of String)
    Public TypeList As List(Of String) = New List(Of String)
    Public DescriptionList As List(Of String) = New List(Of String)
    Public ConnectorList As List(Of String) = New List(Of String)
    Public GroupList As List(Of String) = New List(Of String)
    Public GroupNbList As List(Of String) = New List(Of String)
    Public ValueList As List(Of String) = New List(Of String)
    Public StatusList As List(Of String) = New List(Of String)
    Public NormalValueList As List(Of String) = New List(Of String)

End Class
Public Class SnmpRemoteRelayCard
    Public IndexList As List(Of String) = New List(Of String)
    Public DescriptionList As List(Of String) = New List(Of String)
    Public StatusList As List(Of String) = New List(Of String)
End Class
Public Class SnmpSmokeDetectorCard
    Public IndexList As List(Of String) = New List(Of String)
    Public DescriptionList As List(Of String) = New List(Of String)
    Public List As List(Of String) = New List(Of String)
    Public GroupNbList As List(Of String) = New List(Of String)
    Public ValueList As List(Of String) = New List(Of String)
    Public StatusList As List(Of String) = New List(Of String)
End Class
Public Class SnmpTackSensorCard
    Public IndexList As List(Of String) = New List(Of String)
    Public TypeList As List(Of String) = New List(Of String)
    Public DescriptionList As List(Of String) = New List(Of String)
    Public ConnectorList As List(Of String) = New List(Of String)
    Public GroupList As List(Of String) = New List(Of String)
    Public GroupNbList As List(Of String) = New List(Of String)
    Public ValueList As List(Of String) = New List(Of String)
    Public UnitNameList As List(Of String) = New List(Of String)
    Public UnitList As List(Of String) = New List(Of String)
    Public StatusList As List(Of String) = New List(Of String)
    Public MinTresholdList As List(Of String) = New List(Of String)
    Public MaxTresholdList As List(Of String) = New List(Of String)
    Public MinWarnTresholdList As List(Of String) = New List(Of String)
    Public MaxWarnTresholdList As List(Of String) = New List(Of String)
End Class
Public Class SnmpIPSensorsCard
    Public IndexList As List(Of String) = New List(Of String)
    Public MicroUnitList As List(Of String) = New List(Of String)
    Public TypeList As List(Of String) = New List(Of String)
    Public DescriptionList As List(Of String) = New List(Of String)
    Public ConnectorList As List(Of String) = New List(Of String)
    Public GroupNbList As List(Of String) = New List(Of String)
    Public GroupList As List(Of String) = New List(Of String)
    Public ValueList As List(Of String) = New List(Of String)
    Public UnitList As List(Of String) = New List(Of String)
    Public UnitNameList As List(Of String) = New List(Of String)
    Public StatusList As List(Of String) = New List(Of String)
    Public MinTresholdList As List(Of String) = New List(Of String)
    Public MaxTresholdList As List(Of String) = New List(Of String)
    Public MinWarnTresholdList As List(Of String) = New List(Of String)
    Public MaxWarnTresholdList As List(Of String) = New List(Of String)
End Class
Public Class SnmpAux2SensorCard
    Public IndexList As List(Of String) = New List(Of String)
    Public TypeList As List(Of String) = New List(Of String)
    Public DescriptionList As List(Of String) = New List(Of String)
    Public ConnectorList As List(Of String) = New List(Of String)
    Public List As List(Of String) = New List(Of String)
    Public GroupList As List(Of String) = New List(Of String)
    Public GroupNbList As List(Of String) = New List(Of String)
    Public ValueList As List(Of String) = New List(Of String)
    Public UnitList As List(Of String) = New List(Of String)
    Public UnitNameList As List(Of String) = New List(Of String)
    Public StatusList As List(Of String) = New List(Of String)
    Public MinTresholdList As List(Of String) = New List(Of String)
    Public MaxTresholdList As List(Of String) = New List(Of String)
    Public MinWarnTresholdList As List(Of String) = New List(Of String)
    Public MaxWarnTresholdList As List(Of String) = New List(Of String)
End Class
Public Class SnmpMsgRegistersCard
    Public IndexList As List(Of String) = New List(Of String)
End Class
Public Class SnmpNetConfCard
    Public IP4Mode As String = ""
    Public IP4Addr As String = ""
    Public IP4Mask As String = ""
    Public IP4GateWay As String = ""
    Public PreDNS As String = ""
    Public AltDNS As String = ""
    Public DNSTimeOut As String = ""
    Public IPv6Mode As String = ""
    Public IPv6Addr As String = ""
    Public IPv6GateWay As String = ""
    Public Enable6To4Tunnel As String = ""
    Public LocalIPAddr As String = ""
    Public RemoteIPv4Addr As String = ""
    Public VlanEnabled As String = ""
    Public Vlan As String = ""
    Public Save As String = ""
    Public EnableSecurity As String = ""
End Class
'-------------------------------------------
Public Class DeviceInformation
    'Monitoring Base Information-----
    Public Time As String = ""
    Public Name As String = ""
    Public Location As String = ""
    Public Branch As String = ""
    Public Rack As String = ""
    Public Contact As String = ""
    Public Phone As String = ""
    Public FirmwareVersion As String = ""
    Public DeviceModel As String = ""
    Public Reset As String = ""
    Public SerialNumber As String = ""
    Public HardwareRev As String = ""
    Public Manufacture As String = ""
    Public Sub Grab(Input As ExportDataFileforMB)
        'Monitoring Base Information-----
        HardwareRev = Input.Information.devHardwareRev
        Manufacture = Input.Information.devManufactureR
        SerialNumber = Input.Information.devSerialNum
        DeviceModel = Input.Information.deviceModel
        FirmwareVersion = Input.Information.firmwareVersion
        Branch = Input.Information.sysBranch
        Contact = Input.Information.sysContact
        Location = Input.Information.sysLocation
        Name = Input.Information.sysName
        Phone = Input.Information.sysPhone
        Rack = Input.Information.sysRack
        Reset = Input.Information.sysReset
        Time = Input.Information.sysTime
    End Sub
End Class
Public Class SensorsData
    Public testSensor As Sensor = New Sensor
    Public IntSensorList As List(Of Sensor) = New List(Of Sensor)
    Public SensorsList As List(Of Sensor) = New List(Of Sensor)
    Public DigInputList As List(Of Sensor) = New List(Of Sensor)
    Public ipSensorList As List(Of Sensor) = New List(Of Sensor)
    Public remoteInputsList As List(Of Sensor) = New List(Of Sensor)
    Public RemoteRelayList As List(Of Sensor) = New List(Of Sensor)
    Public smokeDetectorsList As List(Of Sensor) = New List(Of Sensor)
    Public TacSensorList As List(Of Sensor) = New List(Of Sensor)
    Public Aux2SensorList As List(Of Sensor) = New List(Of Sensor)
    Public AuxSensorList As List(Of Sensor) = New List(Of Sensor)
    Public ExtSensorList As List(Of Sensor) = New List(Of Sensor)
    Public IPDevicesList As List(Of Sensor) = New List(Of Sensor)
    Public OutRelayList As List(Of Sensor) = New List(Of Sensor)
    Public PwrSupplyList As List(Of Sensor) = New List(Of Sensor)
    Public MsgRegistersList As List(Of Sensor) = New List(Of Sensor)
    Public Function ScanSensor(sensorCategory As String, command As String) As List(Of Sensor)
        Dim returnSensorList As List(Of Sensor) = New List(Of Sensor)
        If command = "Online" Then
            If sensorCategory = "IntSensor" Then
                If IntSensorList.Count <= 0 Then
                    Return Nothing
                End If
                For i As Integer = 0 To IntSensorList.Count - 1
                    If IntSensorList(i).Status = "1" Then
                        returnSensorList.Add(IntSensorList(i))
                    End If
                Next
            End If
            If sensorCategory = "Aux2Sensor" Then
                If Aux2SensorList.Count <= 0 Then
                    Return Nothing
                End If
                For i As Integer = 0 To Aux2SensorList.Count - 1
                    If Aux2SensorList(i).Status = "1" Then
                        returnSensorList.Add(Aux2SensorList(i))
                    End If
                Next
            End If
            If sensorCategory = "AuxSensor" Then
                If AuxSensorList.Count <= 0 Then
                    Return Nothing
                End If
                For i As Integer = 0 To AuxSensorList.Count - 1
                    If AuxSensorList(i).Status = "1" Then
                        returnSensorList.Add(AuxSensorList(i))
                    End If
                Next
            End If
            If sensorCategory = "DigInput" Then
                If DigInputList.Count <= 0 Then
                    Return Nothing
                End If
                For i As Integer = 0 To DigInputList.Count - 1
                    If DigInputList(i).Status = "1" Then
                        returnSensorList.Add(DigInputList(i))
                    End If
                Next
            End If
            If sensorCategory = "ExtSensor" Then
                If ExtSensorList.Count <= 0 Then
                    Return Nothing
                End If
                For i As Integer = 0 To ExtSensorList.Count - 1
                    If ExtSensorList(i).Status = "1" Then
                        returnSensorList.Add(ExtSensorList(i))
                    End If
                Next
            End If
            If sensorCategory = "MsgRegisters" Then
                If MsgRegistersList.Count <= 0 Then
                    Return Nothing
                End If
                For i As Integer = 0 To MsgRegistersList.Count - 1
                    If MsgRegistersList(i).Status = "1" Then
                        returnSensorList.Add(MsgRegistersList(i))
                    End If
                Next
            End If
            If sensorCategory = "OutRelay" Then
                If OutRelayList.Count <= 0 Then
                    Return Nothing
                End If
                For i As Integer = 0 To OutRelayList.Count - 1
                    If OutRelayList(i).Status = "1" Then
                        returnSensorList.Add(OutRelayList(i))
                    End If
                Next
            End If
            If sensorCategory = "PwrSupply" Then
                If PwrSupplyList.Count <= 0 Then
                    Return Nothing
                End If
                For i As Integer = 0 To PwrSupplyList.Count - 1
                    If PwrSupplyList(i).Status = "1" Then
                        returnSensorList.Add(PwrSupplyList(i))
                    End If
                Next
            End If
            If sensorCategory = "RemoteInputs" Then
                If remoteInputsList.Count <= 0 Then
                    Return Nothing
                End If
                For i As Integer = 0 To remoteInputsList.Count - 1
                    If remoteInputsList(i).Status = "1" Then
                        returnSensorList.Add(remoteInputsList(i))
                    End If
                Next
            End If
            If sensorCategory = "RemoteRelay" Then
                If RemoteRelayList.Count <= 0 Then
                    Return Nothing
                End If
                For i As Integer = 0 To RemoteRelayList.Count - 1
                    If RemoteRelayList(i).Status = "1" Then
                        returnSensorList.Add(RemoteRelayList(i))
                    End If
                Next
            End If
            If sensorCategory = "TacSensor" Then
                If TacSensorList.Count <= 0 Then
                    Return Nothing
                End If
                For i As Integer = 0 To TacSensorList.Count - 1
                    If TacSensorList(i).Status = "1" Then
                        returnSensorList.Add(TacSensorList(i))
                    End If
                Next
            End If
            If sensorCategory = "IPSensor" Then
                If ipSensorList.Count <= 0 Then
                    Return Nothing
                End If
                For i As Integer = 0 To ipSensorList.Count - 1
                    If ipSensorList(i).Status = "1" Then
                        returnSensorList.Add(ipSensorList(i))
                    End If
                Next
            End If
            If sensorCategory = "IPDevice" Then
                If IPDevicesList.Count <= 0 Then
                    Return Nothing
                End If
                For i As Integer = 0 To IPDevicesList.Count - 1
                    If IPDevicesList(i).Status = "1" Then
                        returnSensorList.Add(IPDevicesList(i))
                    End If
                Next
            End If
            If sensorCategory = "SmokeDetector" Then
                If smokeDetectorsList.Count <= 0 Then
                    Return Nothing
                End If
                For i As Integer = 0 To smokeDetectorsList.Count - 1
                    If smokeDetectorsList(i).Status = "1" Then
                        returnSensorList.Add(smokeDetectorsList(i))
                    End If
                Next
            End If
        End If
        Return returnSensorList
    End Function
    Public Function returnSensor(input As ExportDataFileforMB, sensorCategory As String, index As Integer) As Sensor
        Dim _returnSensor As Sensor = New Sensor
        If sensorCategory = "IntSensor" Then
            If input.IntSensor.IndexList.Count < index Then
                Return Nothing
            End If
            _returnSensor.index = input.IntSensor.IndexList(index)
            _returnSensor.Type = input.IntSensor.TypeList(index)
            _returnSensor.Description = input.IntSensor.DescriptionList(index)
            _returnSensor.GroupNb = input.IntSensor.GroupNbList(index)
            _returnSensor.Group = input.IntSensor.GroupList(index)
            _returnSensor.Value = input.IntSensor.ValueList(index)
            _returnSensor.Unit = input.IntSensor.UnitList(index)
            _returnSensor.UnitName = input.IntSensor.UnitNameList(index)
            _returnSensor.Status = input.IntSensor.StatusList(index)
            _returnSensor.MinTreshold = input.IntSensor.MinTresholdList(index)
            _returnSensor.MaxTreshold = input.IntSensor.MaxTresholdList(index)
            _returnSensor.MinWarnTreshold = input.IntSensor.MinWarnTresholdList(index)
            _returnSensor.MaxWarnTreshold = input.IntSensor.MaxWarnTresholdList(index)
        End If
        If sensorCategory = "Aux2Sensor" Then
            If input.Aux2Sensor.IndexList.Count < index Then
                Return Nothing
            End If
            _returnSensor.index = input.Aux2Sensor.IndexList(index)
            _returnSensor.Type = input.Aux2Sensor.TypeList(index)
            _returnSensor.Description = input.Aux2Sensor.DescriptionList(index)
            _returnSensor.Connector = input.Aux2Sensor.ConnectorList(index)
            _returnSensor.GroupNb = input.Aux2Sensor.GroupNbList(index)
            _returnSensor.Group = input.Aux2Sensor.GroupList(index)
            _returnSensor.Value = input.Aux2Sensor.ValueList(index)
            _returnSensor.Unit = input.Aux2Sensor.UnitList(index)
            _returnSensor.UnitName = input.Aux2Sensor.UnitNameList(index)
            _returnSensor.Status = input.Aux2Sensor.StatusList(index)
            _returnSensor.MinTreshold = input.Aux2Sensor.MinTresholdList(index)
            _returnSensor.MaxTreshold = input.Aux2Sensor.MaxTresholdList(index)
            _returnSensor.MinWarnTreshold = input.Aux2Sensor.MinWarnTresholdList(index)
            _returnSensor.MaxWarnTreshold = input.Aux2Sensor.MaxWarnTresholdList(index)
        End If
        If sensorCategory = "AuxSensor" Then
            If input.AuxSensor.IndexList.Count < index Then
                Return Nothing
            End If
            _returnSensor.index = input.AuxSensor.IndexList(index)
            _returnSensor.Type = input.AuxSensor.TypeList(index)
            _returnSensor.Description = input.AuxSensor.DescriptionList(index)
            _returnSensor.Connector = input.AuxSensor.ConnectorList(index)
            _returnSensor.GroupNb = input.AuxSensor.GroupNbList(index)
            _returnSensor.Group = input.AuxSensor.GroupList(index)
            _returnSensor.Value = input.AuxSensor.ValueList(index)
            _returnSensor.Unit = input.AuxSensor.UnitList(index)
            _returnSensor.UnitName = input.AuxSensor.UnitNameList(index)
            _returnSensor.Status = input.AuxSensor.StatusList(index)
            _returnSensor.MinTreshold = input.AuxSensor.MinTresholdList(index)
            _returnSensor.MaxTreshold = input.AuxSensor.MaxTresholdList(index)
            _returnSensor.MinWarnTreshold = input.AuxSensor.MinWarnTresholdList(index)
            _returnSensor.MaxWarnTreshold = input.AuxSensor.MaxWarnTresholdList(index)
        End If
        If sensorCategory = "DigInput" Then
            If input.DigInput.IndexList.Count < index Then
                Return Nothing
            End If
            _returnSensor.index = input.DigInput.IndexList(index)
            _returnSensor.Type = input.DigInput.TypeList(index)
            _returnSensor.Description = input.DigInput.DescriptionList(index)
            _returnSensor.Connector = input.DigInput.ConnectorList(index)
            _returnSensor.GroupNb = input.DigInput.GroupNbList(index)
            _returnSensor.Group = input.DigInput.GroupList(index)
            _returnSensor.Value = input.DigInput.ValueList(index)
            _returnSensor.Status = input.DigInput.StatusList(index)
            _returnSensor.NormalValue = input.DigInput.NormalValueList(index)
        End If
        If sensorCategory = "ExtSensor" Then
            If input.ExtSensor.IndexList.Count < index Then
                Return Nothing
            End If
            _returnSensor.index = input.ExtSensor.IndexList(index)
            _returnSensor.Type = input.ExtSensor.TypeList(index)
            _returnSensor.Description = input.ExtSensor.DescriptionList(index)
            _returnSensor.Connector = input.ExtSensor.ConnectorList(index)
            _returnSensor.GroupNb = input.ExtSensor.GroupNbList(index)
            _returnSensor.Group = input.ExtSensor.GroupList(index)
            _returnSensor.Value = input.ExtSensor.ValueList(index)
            _returnSensor.Unit = input.ExtSensor.UnitList(index)
            _returnSensor.UnitName = input.ExtSensor.UnitNameList(index)
            _returnSensor.Status = input.ExtSensor.StatusList(index)
            _returnSensor.MinTreshold = input.ExtSensor.MinTresholdList(index)
            _returnSensor.MaxTreshold = input.ExtSensor.MaxTresholdList(index)
            _returnSensor.MinWarnTreshold = input.ExtSensor.MinWarnTresholdList(index)
            _returnSensor.MaxWarnTreshold = input.ExtSensor.MaxWarnTresholdList(index)
            '_returnSensor.AlcmIndex = input.ExtSensor.AclmIndexList((index / 2) + (index Mod 2))
            '_returnSensor.PeakValue = input.ExtSensor.PeakValueList((index / 2) + (index Mod 2))
            '_returnSensor.Frequency = input.ExtSensor.FrequencyList((index / 2) + (index Mod 2))
            '_returnSensor.Current = input.ExtSensor.CurrentList((index / 2) + (index Mod 2))
            '_returnSensor.Spikes = input.ExtSensor.SpikesList((index / 2) + (index Mod 2))
            '_returnSensor.Swells = input.ExtSensor.SwellsList((index / 2) + (index Mod 2))
            '_returnSensor.Sags = input.ExtSensor.SagsList((index / 2) + (index Mod 2))
            '_returnSensor.Relay = input.ExtSensor.RelayList((index / 2) + (index Mod 2))
        End If
        If sensorCategory = "MsgRegisters" Then
            If input.MsgRegisters.IndexList.Count < index Then
                Return Nothing
            End If
            _returnSensor.index = input.MsgRegisters.IndexList(index)
        End If
        If sensorCategory = "OutRelay" Then
            If input.OutRelay.IndexList.Count < index Then
                Return Nothing
            End If
            _returnSensor.index = input.OutRelay.IndexList(index)
            _returnSensor.Description = input.OutRelay.DescriptionList(index)
            _returnSensor.Status = input.OutRelay.StatusList(index)
        End If
        If sensorCategory = "PwrSupply" Then
            If input.PwrSupply.IndexList.Count < index Then
                Return Nothing
            End If
            _returnSensor.index = input.PwrSupply.IndexList(index)
            _returnSensor.Status = input.PwrSupply.StatusList(index)
        End If
        If sensorCategory = "RemoteInputs" Then
            If input.RemoteInputs.IndexList.Count < index Then
                Return Nothing
            End If
            _returnSensor.index = input.RemoteInputs.IndexList(index)
            _returnSensor.Type = input.RemoteInputs.TypeList(index)
            _returnSensor.Description = input.RemoteInputs.DescriptionList(index)
            _returnSensor.Connector = input.RemoteInputs.ConnectorList(index)
            _returnSensor.GroupNb = input.RemoteInputs.GroupNbList(index)
            _returnSensor.Group = input.RemoteInputs.GroupList(index)
            _returnSensor.Value = input.RemoteInputs.ValueList(index)
            _returnSensor.Status = input.RemoteInputs.StatusList(index)
            _returnSensor.NormalValue = input.RemoteInputs.NormalValueList(index)
        End If
        If sensorCategory = "RemoteRelay" Then
            If input.RemoteRelay.IndexList.Count < index Then
                Return Nothing
            End If
            _returnSensor.index = input.RemoteRelay.IndexList(index)
            _returnSensor.Description = input.RemoteRelay.DescriptionList(index)
            _returnSensor.Status = input.RemoteRelay.StatusList(index)
        End If
        If sensorCategory = "TacSensor" Then
            If input.TacSensor.IndexList.Count < index Then
                Return Nothing
            End If
            _returnSensor.index = input.TacSensor.IndexList(index)
            _returnSensor.Type = input.TacSensor.TypeList(index)
            _returnSensor.Description = input.TacSensor.DescriptionList(index)
            _returnSensor.Connector = input.TacSensor.ConnectorList(index)
            _returnSensor.GroupNb = input.TacSensor.GroupNbList(index)
            _returnSensor.Group = input.TacSensor.GroupList(index)
            _returnSensor.Value = input.TacSensor.ValueList(index)
            _returnSensor.Unit = input.TacSensor.UnitList(index)
            _returnSensor.UnitName = input.TacSensor.UnitNameList(index)
            _returnSensor.Status = input.TacSensor.StatusList(index)
            _returnSensor.MinTreshold = input.TacSensor.MinTresholdList(index)
            _returnSensor.MaxTreshold = input.TacSensor.MaxTresholdList(index)
            _returnSensor.MinWarnTreshold = input.TacSensor.MinWarnTresholdList(index)
            _returnSensor.MaxWarnTreshold = input.TacSensor.MaxWarnTresholdList(index)
        End If
        If sensorCategory = "SmokeDetector" Then
            If input.SmokeDetector.IndexList.Count < index Then
                Return Nothing
            End If
            _returnSensor.index = input.SmokeDetector.IndexList(index)
            _returnSensor.Description = input.SmokeDetector.DescriptionList(index)
            _returnSensor.GroupNb = input.SmokeDetector.GroupNbList(index)
            _returnSensor.Value = input.SmokeDetector.ValueList(index)
            _returnSensor.Status = input.SmokeDetector.StatusList(index)
        End If
        If sensorCategory = "IPSensor" Then
            If input.SmokeDetector.IndexList.Count < index Then
                Return Nothing
            End If
            _returnSensor.index = input.IPSensors.IndexList(index)
            _returnSensor.microUnit = input.IPSensors.MicroUnitList(index)
            _returnSensor.Type = input.IPSensors.TypeList(index)
            _returnSensor.Description = input.IPSensors.DescriptionList(index)
            _returnSensor.Connector = input.IPSensors.ConnectorList(index)
            _returnSensor.GroupNb = input.IPSensors.GroupNbList(index)
            _returnSensor.Group = input.IPSensors.GroupList(index)
            _returnSensor.Value = input.IPSensors.ValueList(index)
            _returnSensor.Unit = input.IPSensors.UnitList(index)
            _returnSensor.UnitName = input.IPSensors.UnitNameList(index)
            _returnSensor.Status = input.IPSensors.StatusList(index)
            _returnSensor.MinTreshold = input.IPSensors.MinTresholdList(index)
            _returnSensor.MaxTreshold = input.IPSensors.MaxTresholdList(index)

        End If
        If sensorCategory = "IPDevice" Then
            If input.IPdevice.IndexList.Count < index Then
                Return Nothing
            End If
            _returnSensor.index = input.IPdevice.IndexList(index)
            _returnSensor.Address = input.IPdevice.AddressList(index)
            _returnSensor.Description = input.IPdevice.DescriptionList(index)
            _returnSensor.GroupNb = input.IPdevice.GroupNbList(index)
            _returnSensor.Group = input.IPdevice.GroupList(index)
            _returnSensor.Timeout = input.IPdevice.TimeoutList(index)
            _returnSensor.Retries = input.IPdevice.RetriesList(index)
            _returnSensor.Value = input.IPdevice.ValueList(index)
            _returnSensor.Status = input.IPdevice.StatusList(index)
        End If


        Return _returnSensor
    End Function
    Public Function returnSensorGroup(input As ExportDataFileforMB, sensorCategory As String) As List(Of Sensor)
        Dim _returnSensorGroup As List(Of Sensor) = New List(Of Sensor)
        Dim count As Integer = 0
        If sensorCategory = "IntSensors" Then
            If input.IntSensor.IndexList.Count <= 0 Then
            Else
                For i As Integer = 0 To input.IntSensor.IndexList.Count - 1
                    _returnSensorGroup.Add(returnSensor(input, "IntSensor", i))
                Next
            End If
        End If
        If sensorCategory = "Aux2Sensors" Then
            If input.Aux2Sensor.IndexList.Count <= 0 Then
            Else
                For i As Integer = 0 To input.Aux2Sensor.IndexList.Count - 1
                    _returnSensorGroup.Add(returnSensor(input, "Aux2Sensor", i))
                Next
            End If
        End If
        If sensorCategory = "AuxSensors" Then
            If input.AuxSensor.IndexList.Count <= 0 Then
            Else
                For i As Integer = 0 To input.AuxSensor.IndexList.Count - 1
                    _returnSensorGroup.Add(returnSensor(input, "AuxSensor", i))
                Next
            End If
        End If
        If sensorCategory = "DigInputs" Then
            If input.DigInput.IndexList.Count <= 0 Then
            Else
                For i As Integer = 0 To input.DigInput.IndexList.Count - 1
                    _returnSensorGroup.Add(returnSensor(input, "DigInput", i))
                Next
            End If
        End If
        If sensorCategory = "ExtSensors" Then
            If input.ExtSensor.IndexList.Count <= 0 Then
            Else
                For i As Integer = 0 To input.ExtSensor.IndexList.Count - 1
                    _returnSensorGroup.Add(returnSensor(input, "ExtSensor", i))
                Next
            End If
        End If
        If sensorCategory = "MsgRegisters" Then
            If input.MsgRegisters.IndexList.Count <= 0 Then
            Else
                For i As Integer = 0 To input.MsgRegisters.IndexList.Count - 1
                    _returnSensorGroup.Add(returnSensor(input, "MsgRegisters", i))
                Next
            End If
        End If
        If sensorCategory = "OutRelays" Then
            If input.OutRelay.IndexList.Count <= 0 Then
            Else
                For i As Integer = 0 To input.OutRelay.IndexList.Count - 1
                    _returnSensorGroup.Add(returnSensor(input, "OutRelay", i))
                Next
            End If
        End If
        If sensorCategory = "PwrSupplys" Then
            If input.PwrSupply.IndexList.Count <= 0 Then
            Else
                For i As Integer = 0 To input.PwrSupply.IndexList.Count - 1
                    _returnSensorGroup.Add(returnSensor(input, "PwrSupply", i))
                Next
            End If
        End If
        If sensorCategory = "RemoteInputs" Then
            If input.RemoteInputs.IndexList.Count <= 0 Then
            Else
                For i As Integer = 0 To input.RemoteInputs.IndexList.Count - 1
                    _returnSensorGroup.Add(returnSensor(input, "RemoteInputs", i))
                Next
            End If
        End If
        If sensorCategory = "RemoteRelays" Then
            If input.RemoteRelay.IndexList.Count <= 0 Then
            Else
                For i As Integer = 0 To input.RemoteRelay.IndexList.Count - 1
                    _returnSensorGroup.Add(returnSensor(input, "RemoteRelay", i))
                Next
            End If
        End If
        If sensorCategory = "TacSensors" Then
            If input.TacSensor.IndexList.Count <= 0 Then
            Else
                For i As Integer = 0 To input.TacSensor.IndexList.Count - 1
                    _returnSensorGroup.Add(returnSensor(input, "TacSensor", i))
                Next
            End If
        End If
        If sensorCategory = "SmokeDetectors" Then
            If input.SmokeDetector.IndexList.Count <= 0 Then
            Else
                For i As Integer = 0 To input.SmokeDetector.IndexList.Count - 1
                    _returnSensorGroup.Add(returnSensor(input, "SmokeDetector", i))
                Next
            End If
        End If
        If sensorCategory = "IPSensors" Then
            If input.IPSensors.IndexList.Count <= 0 Then
            Else
                For i As Integer = 0 To input.IPSensors.IndexList.Count - 1
                    _returnSensorGroup.Add(returnSensor(input, "IPSensor", i))
                Next
            End If
        End If
        If sensorCategory = "IPDevices" Then
            If input.IPdevice.IndexList.Count <= 0 Then
            Else
                For i As Integer = 0 To input.IPdevice.IndexList.Count - 1
                    _returnSensorGroup.Add(returnSensor(input, "IPDevice", i))
                Next
            End If
        End If
        Return _returnSensorGroup
    End Function
    Private Sub TestSensorConfig()
        testSensor.Description = "VirtualSensor"
        testSensor.Status = "1"
        testSensor.active = "1"
        testSensor.Connector = "99"
        testSensor.Current = "20"
        testSensor.Frequency = "9600"
        testSensor.Group = "1"
        testSensor.GroupNb = "1"
        testSensor.index = 20
        testSensor.MaxCriticalThreshold = "9999"
        testSensor.MaxWarnTreshold = "7777"
        testSensor.MinCriticalThreshold = "3333"
        testSensor.MinWarnTreshold = "1111"
        testSensor.MaxTreshold = "12000"
        testSensor.MinTreshold = "0"
        testSensor.NormalValue = "1"
        testSensor.UnitName = "GHz"
        testSensor.Value = "5555"
    End Sub
    Public Function Grab(input As ExportDataFileforMB)
        IntSensorList = returnSensorGroup(input, "IntSensors")
        Aux2SensorList = returnSensorGroup(input, "Aux2Sensors")
        AuxSensorList = returnSensorGroup(input, "AuxSensors")
        DigInputList = returnSensorGroup(input, "DigInputs")
        ExtSensorList = returnSensorGroup(input, "ExtSensors")
        MsgRegistersList = returnSensorGroup(input, "MsgRegisters")
        OutRelayList = returnSensorGroup(input, "OutRelays")
        PwrSupplyList = returnSensorGroup(input, "PwrSupplys")
        remoteInputsList = returnSensorGroup(input, "RemoteInputs")
        RemoteRelayList = returnSensorGroup(input, "RemoteRelays")
        TacSensorList = returnSensorGroup(input, "TacSensors")
        smokeDetectorsList = returnSensorGroup(input, "SmokeDetectors")
        ipSensorList = returnSensorGroup(input, "IPSensors")
        IPDevicesList = returnSensorGroup(input, "IPDevices")
    End Function
    Sub New(input As dataFileConstructor)
        For i As Integer = 0 To input.IntSensorCount
            IntSensorList.Add(New Sensor)
        Next
        For i As Integer = 0 To input.DIgitalSensorCount
            DigInputList.Add(New Sensor)
        Next
        For i As Integer = 0 To input.ipSensorCount
            ipSensorList.Add(New Sensor)
        Next
        For i As Integer = 0 To input.remoteInputCount
            remoteInputsList.Add(New Sensor)
        Next
        For i As Integer = 0 To input.remoteRelayCount
            RemoteRelayList.Add(New Sensor)
        Next
        For i As Integer = 0 To input.smokeDetectorCount
            smokeDetectorsList.Add(New Sensor)
        Next
        For i As Integer = 0 To input.tacSensorCount
            TacSensorList.Add(New Sensor)
        Next
        For i As Integer = 0 To input.aux2SensorCount
            Aux2SensorList.Add(New Sensor)
        Next
        For i As Integer = 0 To input.auxSensorCount
            AuxSensorList.Add(New Sensor)
        Next
        For i As Integer = 0 To input.extSensorCount
            ExtSensorList.Add(New Sensor)
        Next
        For i As Integer = 0 To input.IPDeviceCount
            IPDevicesList.Add(New Sensor)
        Next
        For i As Integer = 0 To input.outRelayCount
            OutRelayList.Add(New Sensor)
        Next
        For i As Integer = 0 To input.pwrSupplyCount
            PwrSupplyList.Add(New Sensor)
        Next
        TestSensorConfig()
    End Sub
End Class
Public Class NetConfiguration
    Public IP4Mode As String = ""
    Public IP4Addr As String = ""
    Public IP4Mask As String = ""
    Public IP4GateWay As String = ""
    Public PreDNS As String = ""
    Public AltDNS As String = ""
    Public DNSTimeOut As String = ""
    Public IPv6Mode As String = ""
    Public IPv6Addr As String = ""
    Public IPv6GateWay As String = ""
    Public Enable6To4Tunnel As String = ""
    Public LocalIPAddr As String = ""
    Public RemoteIPv4Addr As String = ""
    Public VlanEnabled As String = ""
    Public Vlan As String = ""
    Public Save As String = ""
    Public EnableSecurity As String = ""
    Public Sub Grab(Input As ExportDataFileforMB)
        IP4Mode = Input.NetConfig.IP4Mode
        IP4Addr = Input.NetConfig.IPv6Addr
        IP4Mask = Input.NetConfig.IP4Mask
        IP4GateWay = Input.NetConfig.IP4GateWay
        PreDNS = Input.NetConfig.PreDNS
        AltDNS = Input.NetConfig.AltDNS
        DNSTimeOut = Input.NetConfig.DNSTimeOut
        IPv6Mode = Input.NetConfig.IPv6Mode
        IPv6Addr = Input.NetConfig.IPv6Addr
        IPv6GateWay = Input.NetConfig.IPv6GateWay
        Enable6To4Tunnel = Input.NetConfig.Enable6To4Tunnel
        LocalIPAddr = Input.NetConfig.LocalIPAddr
        RemoteIPv4Addr = Input.NetConfig.RemoteIPv4Addr
        VlanEnabled = Input.NetConfig.VlanEnabled
        Vlan = Input.NetConfig.Vlan
        Save = Input.NetConfig.Save
        EnableSecurity = Input.NetConfig.EnableSecurity
    End Sub
End Class
'-------------------------------------------
Public Class DataFile
    Public DeviceInformation As DeviceInformation
    Public SensorData As SensorsData
    Public NetConfiguration As NetConfiguration
    Sub New(input As dataFileConstructor)
        DeviceInformation = New DeviceInformation
        SensorData = New SensorsData(input)
        NetConfiguration = New NetConfiguration
    End Sub
End Class

Public Class dataFileConstructor
    Public IntSensorCount As Integer = 0
    Public SensorCount As Integer = 0
    Public DIgitalSensorCount As Integer = 0
    Public ipSensorCount As Integer = 0
    Public remoteInputCount As Integer = 0
    Public remoteRelayCount As Integer = 0
    Public smokeDetectorCount As Integer = 0
    Public tacSensorCount As Integer = 0
    Public aux2SensorCount As Integer = 0
    Public auxSensorCount As Integer = 0
    Public extSensorCount As Integer = 0
    Public IPDeviceCount As Integer = 0
    Public outRelayCount As Integer = 0
    Public pwrSupplyCount As Integer = 0
End Class
Public Class Sensor
    '-------------------------------------------
    Public AlcmIndex As String = ""
    Public PeakValue As String = ""
    Public Frequency As String = ""
    Public Current As String = ""
    Public Spikes As String = ""
    Public Swells As String = ""
    Public Sags As String = ""
    Public Relay As String = ""
    '-------------------------------------------
    Public index As String = ""
    Public Unit As String = ""
    Public UnitName As String = ""
    '-------------------------------------------
    Public active As String = ""
    Public Value As String = ""
    Public NormalValue As String = ""
    Public Type As String = ""
    Public Name As String = ""
    Public Connector As String = ""
    Public Status As String = ""
    Public SimulateAllert As String
    '-------------------------------------------

    Public microUnit As String = ""

    'Sensor settings----------------------------
    Public Description As String = ""
    Public MinTreshold As String = ""
    Public MaxTreshold As String = ""
    Public MinWarnTreshold As String = ""
    Public MaxWarnTreshold As String = ""
    Public MinCriticalThreshold As String = ""
    Public MaxCriticalThreshold As String = ""
    Public RefreshRate As String = ""
    '--------------------------------------------

    'Schedule  Settings------------------------------
    Public ScheduleType As String = ""
    Public StartDay As String = ""
    Public EndDay As String = ""
    Public StartHour As String = ""

    '--------------------------------------------
    'Group Settings------------------------------
    Public Group As String = ""

    Public GroupNb As String = ""
    '--------------------------------------------

    'Non-Critical Alert Settings-----------------
    Public nDisableAlerts As String = ""
    Public nAlertDelay As String = ""
    Public nNotifyAgainTimeToNormal As String = ""
    Public nEnableSyslogAlerts As String = ""
    Public nEnableSNMPTraps As String = ""
    Public nEnableEmailAlerts As String = ""
    Public nEmailSubject As String = ""
    Public nEnableSMSAlerts As String = ""
    Public nSendcustomSMS As String = ""
    Public nCustomizedSMS As String = ""
    Public nAssociatedOutputRelay As String = ""
    Public nOutputRelayStatusOnAlert As String = ""
    Public nOutputRelayStatusOnReturnFromAlert As String = ""
    '---------------------------------------------

    'CriticalAlertSettings------------------------
    Public cDisableAlerts As String = ""
    Public cAlertDelay As String = ""
    Public cNotifyAgainTime As String = ""
    Public cNotifyOnReturnToNormal As String = ""
    Public cAutoAcknowledge As String = ""
    Public cEnableSyslogAlerts As String = ""
    Public cEnableSNMPTraps As String = ""
    Public cEnableEmailAlerts As String = ""
    Public cEmailSubject As String = ""
    Public cSelectIPCamera As String = ""
    Public cAttachIPCameraCaptureToEmail As String = ""
    Public cSaveImageToUSB As String = ""
    Public cEnableSMSAlerts As String = ""
    Public cSendCustomSMS As String = ""
    Public cCustomizedSMS As String = ""
    Public cAssociatedOutputRelay As String = ""
    Public cOutputRelayStatusOnAlert As String = ""
    Public cOutputRelayStatusOnReturnFromAlert As String = ""
    '---------------------------------------------
    Public Address As String = ""
    Public Timeout As String = ""
    Public Retries As String = ""

    'Data Loggining-------------------------------
    Public AddToDataLog As String = ""
    Public LoggingPeriod As String = ""
    '---------------------------------------------
End Class
Public Class SensorMap
    Public MonitoringCard As Monitoring = New Monitoring
    Public LogCard As Log = New Log
    Public Class Monitoring
        Public Ampermeter1M As Boolean = False
        Public Ampermeter2M As Boolean = False
        Public Ampermeter3M As Boolean = False
        Public Ampermeter4M As Boolean = False
        Public Ampermeter5M As Boolean = False
        Public Ampermeter6M As Boolean = False
        Public TermometerM As Boolean = False
    End Class
    Public Class Log
        Public Ampermeter1L As Boolean = False
        Public Ampermeter2L As Boolean = False
        Public Ampermeter3L As Boolean = False
        Public Ampermeter4L As Boolean = False
        Public Ampermeter5L As Boolean = False
        Public Ampermeter6L As Boolean = False
        Public TermometerL As Boolean = False
    End Class
End Class
