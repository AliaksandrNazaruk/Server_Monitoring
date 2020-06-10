Public Class tabbleElem
    Private Valuelink As Object
    Sub New(input As Sensor)
        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()
        ' Добавить код инициализации после вызова InitializeComponent().
        Valuelink = "/" + "MB/" + input.Type + "/"

        NameText.Text = input.Description
        CurrentText.Text = input.Value
        StatusText.Text = input.Status
        Dim Valuelink1 As New Customer("")

    End Sub
    Sub New(PDU As String, input As String)
        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()
        ' Добавить код инициализации после вызова InitializeComponent().
        ElementText.Text = input
        Valuelink = "/" + PDU + "/" + input + "/"

    End Sub
    Sub New(PDU As String, Type As String, dev As String)
        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()
        ' Добавить код инициализации после вызова InitializeComponent().
        Valuelink = "/"
        If PDU = "PDUA" Then
            Valuelink = Valuelink + "PDUA/"
            If Type = "Phase1" Then
                Valuelink = Valuelink + "Phase1/"
                If dev = "Ampermeter1" Then
                    NameText.Text = "Ampermeter 1"
                    Valuelink = Valuelink + "Ampermeter1/"
                    CurrentText.Text = Module1.PDUA.dataFile.table.Phase1.Ampermeter1.Current
                    StatusText.Text = Module1.PDUA.dataFile.table.Phase1.Section1.message
                End If
                If dev = "Ampermeter2" Then
                    Valuelink = Valuelink + "Ampermeter2/"
                    NameText.Text = "Ampermeter 2"
                    CurrentText.Text = Module1.PDUA.dataFile.table.Phase1.Ampermeter2.Current
                    StatusText.Text = Module1.PDUA.dataFile.table.Phase1.Section2.message
                End If
            End If
            If Type = "Phase2" Then
                Valuelink = Valuelink + "Phase2/"
                If dev = "Ampermeter1" Then
                    Valuelink = Valuelink + "Ampermeter1/"
                    NameText.Text = "Ampermeter 1"
                    CurrentText.Text = Module1.PDUA.dataFile.table.Phase2.Ampermeter1.Current
                    StatusText.Text = Module1.PDUA.dataFile.table.Phase2.Section1.message
                End If
                If dev = "Ampermeter2" Then
                    Valuelink = Valuelink + "Ampermeter2/"
                    NameText.Text = "Ampermeter 2"
                    CurrentText.Text = Module1.PDUA.dataFile.table.Phase2.Ampermeter2.Current
                    StatusText.Text = Module1.PDUA.dataFile.table.Phase2.Section2.message
                End If
            End If
            If Type = "Phase3" Then
                Valuelink = Valuelink + "Phase3/"
                If dev = "Ampermeter1" Then
                    Valuelink = Valuelink + "Ampermeter1/"
                    NameText.Text = "Ampermeter 1"
                    CurrentText.Text = Module1.PDUA.dataFile.table.Phase3.Ampermeter1.Current
                    StatusText.Text = Module1.PDUA.dataFile.table.Phase3.Section1.message
                End If
                If dev = "Ampermeter2" Then
                    Valuelink = Valuelink + "Ampermeter2/"
                    NameText.Text = "Ampermeter 2"
                    CurrentText.Text = Module1.PDUA.dataFile.table.Phase3.Ampermeter2.Current
                    StatusText.Text = Module1.PDUA.dataFile.table.Phase3.Section2.message
                End If
            End If
            If Type = "Termometer" Then
                Valuelink = Valuelink + "Temperature/"
                If dev = "Termometer1" Then
                    Valuelink = Valuelink + "Termometer1/"
                    NameText.Text = "Temperature"
                    If Module1.PDUA.dataFile.table.Temp.Value.Length > 5 Then
                        CurrentText.Text = "."
                        StatusText.Text = Module1.PDUA.dataFile.table.Temp.Value
                    Else
                        CurrentText.Text = Module1.PDUA.dataFile.table.Temp.Value
                        StatusText.Text = ""
                    End If

                End If
            End If
        End If
        If PDU = "PDUB" Then
            If Type = "Phase1" Then
                If dev = "Ampermeter1" Then
                    Valuelink = Valuelink + "Ampermeter1/"
                    NameText.Text = "Ampermeter 1"
                    CurrentText.Text = Module1.PDUB.dataFile.table.Phase1.Ampermeter1.Current
                    StatusText.Text = Module1.PDUB.dataFile.table.Phase1.Section1.message
                End If
                If dev = "Ampermeter2" Then
                    Valuelink = Valuelink + "Ampermeter2/"
                    NameText.Text = "Ampermeter 2"
                    CurrentText.Text = Module1.PDUB.dataFile.table.Phase1.Ampermeter2.Current
                    StatusText.Text = Module1.PDUB.dataFile.table.Phase1.Section2.message
                End If
            End If
            If Type = "Phase2" Then
                If dev = "Ampermeter1" Then
                    Valuelink = Valuelink + "Ampermeter1/"
                    NameText.Text = "Ampermeter 1"
                    CurrentText.Text = Module1.PDUB.dataFile.table.Phase2.Ampermeter1.Current
                    StatusText.Text = Module1.PDUB.dataFile.table.Phase2.Section1.message
                End If
                If dev = "Ampermeter2" Then
                    Valuelink = Valuelink + "Ampermeter2/"
                    NameText.Text = "Ampermeter 2"
                    CurrentText.Text = Module1.PDUB.dataFile.table.Phase2.Ampermeter2.Current
                    StatusText.Text = Module1.PDUB.dataFile.table.Phase2.Section2.message
                End If
            End If
            If Type = "Phase3" Then
                If dev = "Ampermeter1" Then
                    Valuelink = Valuelink + "Ampermeter1/"
                    NameText.Text = "Ampermeter 1"
                    CurrentText.Text = Module1.PDUB.dataFile.table.Phase3.Ampermeter1.Current
                    StatusText.Text = Module1.PDUB.dataFile.table.Phase3.Section1.message
                End If
                If dev = "Ampermeter2" Then
                    Valuelink = Valuelink + "Ampermeter2/"
                    NameText.Text = "Ampermeter 2"
                    CurrentText.Text = Module1.PDUB.dataFile.table.Phase3.Ampermeter2.Current
                    StatusText.Text = Module1.PDUB.dataFile.table.Phase3.Section2.message
                End If
            End If
            If Type = "Termometer" Then
                Valuelink = Valuelink + "Temperature/"
                If dev = "Termometer1" Then
                    Valuelink = Valuelink + "Termometer1/"
                    NameText.Text = "Temperature"
                    CurrentText.Text = Module1.PDUB.dataFile.table.Temp.Value
                    StatusText.Text = Module1.PDUB.dataFile.table.Temp.Trigger
                End If
            End If
        End If
    End Sub
    Private WithEvents timer As Timer = New Timer
    Private Sub TimerTick() Handles timer.Tick
        If Valuelink <> "" Then
            If Valuelink.IndexOf("PDUA") >= 0 Then
                If Valuelink.IndexOf("Phase1") >= 0 Then
                    If Valuelink = "/PDUA/Phase1/" Then
                        StatusText.Text = Module1.PDUA.dataFile.table.Phase1.Section1.Status
                    End If
                    If Valuelink.IndexOf("Ampermeter1") >= 0 Then
                        CurrentText.Text = Module1.PDUA.dataFile.table.Phase1.Ampermeter1.Current
                        StatusText.Text = Module1.PDUA.dataFile.table.Phase1.Section1.message
                    End If
                    If Valuelink.IndexOf("Ampermeter2") >= 0 Then
                        CurrentText.Text = Module1.PDUA.dataFile.table.Phase1.Ampermeter2.Current
                        StatusText.Text = Module1.PDUA.dataFile.table.Phase1.Section2.message
                    End If
                End If
                If Valuelink.IndexOf("Phase2") >= 0 Then
                    If Valuelink = "/PDUA/Phase2/" Then
                        StatusText.Text = Module1.PDUA.dataFile.table.Phase2.Section1.Status
                    End If
                    If Valuelink.IndexOf("Ampermeter1") >= 0 Then
                        CurrentText.Text = Module1.PDUA.dataFile.table.Phase2.Ampermeter1.Current
                        StatusText.Text = Module1.PDUA.dataFile.table.Phase2.Section1.message
                    End If
                    If Valuelink.IndexOf("Ampermeter2") >= 0 Then
                        CurrentText.Text = Module1.PDUA.dataFile.table.Phase2.Ampermeter2.Current
                        StatusText.Text = Module1.PDUA.dataFile.table.Phase2.Section2.message
                    End If
                End If
                If Valuelink.IndexOf("Phase3") >= 0 Then
                    If Valuelink = "/PDUA/Phase3/" Then
                        StatusText.Text = Module1.PDUA.dataFile.table.Phase3.Section1.Status
                    End If
                    If Valuelink.IndexOf("Ampermeter1") >= 0 Then
                        CurrentText.Text = Module1.PDUA.dataFile.table.Phase3.Ampermeter1.Current
                        StatusText.Text = Module1.PDUA.dataFile.table.Phase3.Section1.message
                    End If
                    If Valuelink.IndexOf("Ampermeter2") >= 0 Then
                        CurrentText.Text = Module1.PDUA.dataFile.table.Phase3.Ampermeter2.Current
                        StatusText.Text = Module1.PDUA.dataFile.table.Phase3.Section2.message
                    End If
                End If
            End If
            If Valuelink.IndexOf("PDUB") >= 0 Then
                If Valuelink.IndexOf("Phase1") >= 0 Then
                    If Valuelink.IndexOf("Ampermeter1") >= 0 Then

                    End If
                    If Valuelink.IndexOf("Ampermeter2") >= 0 Then

                    End If
                End If
                If Valuelink.IndexOf("Phase2") >= 0 Then
                    If Valuelink.IndexOf("Ampermeter1") >= 0 Then

                    End If
                    If Valuelink.IndexOf("Ampermeter2") >= 0 Then

                    End If
                End If
                If Valuelink.IndexOf("Phase3") >= 0 Then
                    If Valuelink.IndexOf("Ampermeter1") >= 0 Then

                    End If
                    If Valuelink.IndexOf("Ampermeter2") >= 0 Then

                    End If
                End If
            End If
        End If

        If My.Forms.Workspace.MonitoringPage.Visible = False Then
            timer.Stop()
        End If
        If Me.Visible = False Then
            timer.Stop()
        End If
    End Sub
    Private Sub Visible_Changed() Handles MyBase.VisibleChanged
        If Me.Visible Then
            timer.Interval = 2000
            timer.Start()
        Else
            timer.Stop()
        End If
    End Sub
End Class
