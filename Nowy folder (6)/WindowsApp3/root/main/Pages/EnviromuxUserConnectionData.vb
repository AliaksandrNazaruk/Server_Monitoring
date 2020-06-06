Public Class EnviromuxUserConnectionData
    Public ThisDevice As String
    Private Function ThisDeviceModule() As Module1.VirtualDevice
        If ThisDevice = "_Listwa1" Then
            Return Module1.PDUA
        End If
        If ThisDevice = "_Listwa2" Then
            Return Module1.PDUB
        End If
        Return Nothing
    End Function
    Private Function thisDeviceProfileData() As UserProfile.DevicesDataFile.DeviceData
        If ThisDevice = "_Listwa1" Then
            Return User.TempProfile.Data.PDUA
        ElseIf ThisDevice = "_Listwa2" Then
            Return User.TempProfile.Data.PDUB
        End If
        Return Nothing
    End Function
    Private Function ThisDeviceConfigPage() As WindowsApp3.PDUConfigPage
        If ThisDevice = "_Listwa1" Then
            Return My.Forms.Workspace._Listwa1
        ElseIf ThisDevice = "_Listwa2" Then
            Return My.Forms.Workspace._Listwa2
        End If
        Return Nothing
    End Function
    Private Function checkOperator(input As String, checkTypeCharter As String, mode As String) As Boolean
        If mode = "ALL" Then
            If checkTypeCharter = "NUMERIC" Then
                For i As Integer = 0 To input.Length - 1
                    If input(i) <> "0" And
                       input(i) <> "1" And
                       input(i) <> "2" And
                       input(i) <> "3" And
                       input(i) <> "4" And
                       input(i) <> "5" And
                       input(i) <> "6" And
                       input(i) <> "7" And
                       input(i) <> "8" And
                       input(i) <> "9" Then
                        Return False
                    End If
                Next
                Return True
            End If
            If checkTypeCharter = "LETTER" Then
                For i As Integer = 0 To input.Length - 1
                    If input(i) <> "q" And
                       input(i) <> "w" And
                       input(i) <> "e" And
                       input(i) <> "r" And
                       input(i) <> "t" And
                       input(i) <> "y" And
                       input(i) <> "u" And
                       input(i) <> "o" And
                       input(i) <> "p" And
                       input(i) <> "a" And
                       input(i) <> "s" And
                       input(i) <> "d" And
                       input(i) <> "f" And
                       input(i) <> "g" And
                       input(i) <> "h" And
                       input(i) <> "j" And
                       input(i) <> "k" And
                       input(i) <> "l" And
                       input(i) <> "z" And
                       input(i) <> "x" And
                       input(i) <> "c" And
                       input(i) <> "v" And
                       input(i) <> "b" And
                       input(i) <> "n" And
                       input(i) <> "m" And
                       input(i) <> "Q" And
                       input(i) <> "W" And
                       input(i) <> "Y" And
                       input(i) <> "U" And
                       input(i) <> "P" And
                       input(i) <> "A" And
                       input(i) <> "S" And
                       input(i) <> "D" And
                       input(i) <> "G" And
                       input(i) <> "H" And
                       input(i) <> "J" And
                       input(i) <> "K" And
                       input(i) <> "L" And
                       input(i) <> "Z" And
                       input(i) <> "X" And
                       input(i) <> "C" And
                       input(i) <> "V" And
                       input(i) <> "B" And
                       input(i) <> "N" And
                       input(i) <> "M" Then
                        Return False
                    End If
                Next
                Return True
            End If
        End If
        Return False
    End Function
    Private Function CheckAuthData() As Boolean
        Dim ret As Boolean = False
        If IpAddpessBox1.IPaddr.installed() Then
        Else
            MsgBox("The IP address does not match the format   ( ***.***.***.*** )" & vbNewLine & "" & vbNewLine & "       * - numeric ")
            Return False
        End If
        If checkOperator(IpAddpessBox1.InpIPTextBox1.Text + IpAddpessBox1.InpIPTextBox2.Text + IpAddpessBox1.InpIPTextBox3.Text + IpAddpessBox1.InpIPTextBox4.Text, "NUMERIC", "ALL") Then
            ret = True
        Else
            MsgBox("The IP address does not match the format   ( ***.***.***.*** )" & vbNewLine & "" & vbNewLine & "       * - numeric ")
            Return False
        End If
        Return ret
    End Function
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        'Принимаем IP из интерфейса и передаем на виртуальное устройство.
        If CheckAuthData() Then

        Else
            Exit Sub
        End If

        MonitoringBase.connectToDevice.SNMPConnection.IP = IpAddpessBox1.IPaddr

        'Тест IP аддресса виртуального устройством
        If MonitoringBase.connectToDevice.testConnection() <> True Then
            MsgBox("IP field cannot be empty")
            MonitoringBase.connectToDevice.SNMPConnection.IP = New IPaddress(0, 0, 0, 0)
            Exit Sub
        End If

        'Если тест пройден успешно
        'Сохраняем данные в профайл пользователя
        TempProfile.Data.MB.IP = MonitoringBase.connectToDevice.SNMPConnection.IP
        TempProfile.Data.MB.Login = CommunityBox.Text
        TempProfile.Data.MB.Password = ""

        'Активация прогрессбара
        Workspace.LoadingPage1.ProgressBar1.Value = 0
        Workspace.LoadingPage1.Visible = True
        Workspace.LoadingPage1.TextMessage.Text = "search for a device under the address: " + MonitoringBase.connectToDevice.SNMPConnection.IP.FullString()

        'Подключение к устройству
        If MonitoringBase.startDevice(TempProfile.Data.MB) Then
            Workspace.LoadingPage1.TextMessage.Text = "Start of the monitoring system..."
            Workspace.LoadingPage1.ProgressBar1.Value = 90
            Workspace.Log1.LOGbox.Items.Add(TimeOfDay + ", " + DateString + "    " + TempProfile.Login + " added device " + MonitoringBase.infoFile.DeviceModel + "(" + MonitoringBase.connectToDevice.SNMPConnection.IP.FullString() + ")" + "" + "")
        Else
            'Если не удалось подключиться к реальному устройству очищаем
            '- Данные пользователя
            '- Данные виртуального устройства
            '- Очищаем страницу
            TempProfile.Data.MB = New UserProfile.DevicesDataFile.DeviceData
            MonitoringBase.connectToDevice.SNMPConnection.IP = New IPaddress(0, 0, 0, 0)
            My.Forms.Workspace.SensorsConfig1.ClearFunc()
            MsgBox("Error connecting to device")
        End If

        'Деактивация прогрессбара
        Workspace.LoadingPage1.Visible = False
        Workspace.LoadingPage1.ProgressBar1.Value = 0
        Workspace.LoadingPage1.TextMessage.Text = ""
    End Sub
    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If Module2.MonitoringBase.DevInterface._unlock Then
            Dim a As Integer
            a = MsgBox("Are you sure you want to delete the connection to device " + Module2.MonitoringBase.connectToDevice.SNMPConnection.IP.FullString() + "?", 323, "")
            If a = 6 Then
                Workspace.LoadingPage1.Visible = True
                Workspace.LoadingPage1.ProgressBar1.Value = 0
                Workspace.LoadingPage1.TextMessage.Text = "Disabling the monitoring system"
                Workspace.Log1.SendMessagesFunction(New Message("Message", "", User.TempProfile.Login + " Deleted a device with an IP address " + User.TempProfile.Data.MB.IP.FullString() + "(Name:" + Module2.MonitoringBase.infoFile.Name + ")"))
                My.Forms.Workspace.SensorsConfig1.FullClear()
                TempProfile.Save()
                Workspace.LoadingPage1.Visible = False
                Workspace.LoadingPage1.ProgressBar1.Value = 0
            ElseIf a = 7 Then
                Exit Sub
            Else
                Exit Sub
            End If
        End If










        Module2.MonitoringBase = New Module2.virtualDevice("MonitoringBase1")
        'очищаем
        '- Данные пользователя
        '- Данные виртуального устройства
        '- Очищаем страницу
        'ground LoginForm.UserSession.MonitoringBase1.ip = ""
        TempProfile.Data.MB = New UserProfile.DevicesDataFile.DeviceData
        MonitoringBase.connectToDevice.SNMPConnection.IP = New IPaddress(0, 0, 0, 0)
        Delete.Enabled = False
        My.Forms.Workspace.SensorsConfig1.ClearFunc()
    End Sub
    Public Sub clear()
        IpAddpessBox1.clear()
        PortBox.Clear()
        CommunityBox.Clear()
        Remember.Checked = False
    End Sub

End Class
