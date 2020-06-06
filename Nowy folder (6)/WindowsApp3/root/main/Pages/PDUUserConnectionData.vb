Public Class PDUUserConnectionData
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
        If IpAddpessBox1.IPaddr.installed Then
            Return True
        End If
        Return False

    End Function
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim port As String = ""
        If CheckAuthData() Then
            If LocAddrCheckBox.Checked Then
                If ThisDeviceModule.connectToDevice.PingTest(IpAddpessBox1.IPaddr.FullString) <> True Then
                    MsgBox("The device you searched for was not found on the network")
                    Exit Sub
                End If
            Else
                port = PortBox.Text
                If ThisDeviceModule.connectToDevice.PingTest(IpAddpessBox1.IPaddr.FullString, port) <> True Then
                    MsgBox("The device you searched for was not found on the network")
                    Exit Sub
                End If
            End If
        Else
            Exit Sub
        End If
        Workspace.LoadingPage1.Visible = True
        Workspace.LoadingPage1.TextMessage.Text = "Connecting to the device(" + ThisDeviceModule.Name + ": " + IpAddpessBox1.IPaddr.FullString() + ")"
        Workspace.LoadingPage1.ProgressBar1.Value = 10
        Dim BufIP As IPaddress = New IPaddress(IpAddpessBox1.IPaddr.Arg1, IpAddpessBox1.IPaddr.Arg2, IpAddpessBox1.IPaddr.Arg3, IpAddpessBox1.IPaddr.Arg4)
        Dim BufPassword = PasswordBox.Text


        Dim connect As Boolean = False
        thisDeviceProfileData.IP = BufIP
        thisDeviceProfileData.Password = BufPassword
        thisDeviceProfileData.port = port
        Workspace.LoadingPage1.ProgressBar1.Value = 40

        If ThisDeviceModule.Online() Then
            Dim a As Integer
            a = MsgBox("Do you want to replace the connected device?", 323, "")
            If a = 6 Then
                connect = ThisDeviceConfigPage.ConnectFunction()
            End If
        Else
            connect = ThisDeviceConfigPage.ConnectFunction()
        End If

        If connect Then
            Workspace.LoadingPage1.ProgressBar1.Value = 85
            Workspace.Log1.SendMessagesFunction(New Message("Message", "", User.TempProfile.Login + " Added a device with an IP address " + thisDeviceProfileData.IP.FullString + "(Name:" + ThisDeviceModule.dataFile.information.pduName + ")"))
            ThisDeviceConfigPage.Cycle.Start()
        Else
            MsgBox("Connection error! Invalid address or invalid credentials")
        End If
        Workspace.LoadingPage1.Visible = False
    End Sub
    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If ThisDeviceModule.connectToDevice.WebConnection.IP.installed() Then
            Dim a As Integer
            a = MsgBox("Are you sure you want to delete the connection to device " + ThisDeviceModule.connectToDevice.WebConnection.IP.FullString() + "?", 323, "")
            If a = 6 Then

                Workspace.LoadingPage1.Visible = True
                Workspace.LoadingPage1.ProgressBar1.Value = 0
                Workspace.LoadingPage1.TextMessage.Text = "Disabling the monitoring system"
                Workspace.Log1.SendMessagesFunction(New Message("Message", "", User.TempProfile.Login + " Deleted a device with an IP address " + thisDeviceProfileData.IP.FullString + "(Name:" + ThisDeviceModule.dataFile.information.pduName + ")"))
                ThisDeviceConfigPage.FullClear()
                TempProfile.Save()
                Workspace.LoadingPage1.Visible = False
                Workspace.LoadingPage1.ProgressBar1.Value = 0
            ElseIf a = 7 Then
                Exit Sub
            Else
                Exit Sub
            End If
        End If
    End Sub
    Public Sub clear()
        IpAddpessBox1.clear()
        PortBox.Clear()
        PortBox.Enabled = False
        PasswordBox.Clear()
        Remember.Checked = False
        LocAddrCheckBox.Checked = True

        Delete.Enabled = False
    End Sub

    Private Sub LocAddrCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles LocAddrCheckBox.CheckedChanged
        If LocAddrCheckBox.Checked Then
            PortBox.Enabled = False
        Else
            PortBox.Enabled = True
        End If
    End Sub

    Private Sub PortBox_TextChanged(sender As Object, e As EventArgs) Handles PortBox.TextChanged
        If PortBox.Text = "" Then
            Exit Sub
        End If
        For j As Integer = 0 To PortBox.Text.Length - 1
            Dim correct As Boolean = False
            For i As Integer = 0 To 9
                If PortBox.Text(j) = i.ToString Then
                    correct = True
                End If
            Next
            If correct = False Then
                MsgBox("Invalid port number! Please input another one(1-65535)")
                PortBox.Text = ""
                Exit Sub
            End If
        Next
        If Convert.ToDouble(PortBox.Text) = 0 Then
            MsgBox("Invalid port number! Please input another one(1-65535)")
            PortBox.Text = ""
            Exit Sub
        End If
        If Convert.ToDouble(PortBox.Text) > 65535 Then
            MsgBox("Invalid port number! Please input another one(1-65535)")
            PortBox.Text = ""
            Exit Sub
        End If

    End Sub
End Class
