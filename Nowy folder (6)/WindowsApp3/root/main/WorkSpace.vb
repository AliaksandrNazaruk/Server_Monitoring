Imports MetroFramework.Components
'Imports MetroFramework.Forms
Imports System.Windows.Forms
Imports System.Threading
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Public Class Workspace
    Inherits Form

    '■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■resize window Functions■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■ 
    Public Sub startingForms()
        Module1.PDUA = New Module1.VirtualDevice("PDUA")
        Module1.PDUB = New Module1.VirtualDevice("PDUB")
        Module2.MonitoringBase = New Module2.virtualDevice("MB")
        LoadConfiguration()
        startDevices()
        'MonitoringPage.TableFinder.Interval = 2000
        'MonitoringPage.TableFinder.Start()
        My.Forms.Workspace.MonitoringPage.Visible = True
    End Sub
    Private Function LoadConfiguration()
        My.Forms.Workspace._Listwa1.FullClear()
        My.Forms.Workspace._Listwa2.FullClear()

        InfoPanel1.labLanguage.Text = "English"
        InfoPanel1.labName.Text = User.LoginnedProfile.Login
        InfoPanel1.labVersion.Text = "1.0v."
        InfoPanel1.labLocation.Text = User.LoginnedProfile.Location
    End Function
    Private Function startDevices()
        If User.LoginnedProfile.Data.PDUA.IP.installed Then
            If _Listwa1.ConnectFunction() Then

            End If
        End If
        If User.LoginnedProfile.Data.PDUB.IP.installed Then
            If _Listwa2.ConnectFunction() Then

            End If
        End If
        If User.LoginnedProfile.Data.MB.IP.installed Then
            SensorsConfig1.DataRefresh()
            If MonitoringBase.startDevice() Then

            End If
        End If

    End Function

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MonitoringPage.Size = New Size(950, 681)
    End Sub
    Private Sub workSpace_formClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo, "")
            Case MsgBoxResult.Yes
                e.Cancel = False
                GC.Collect(2)
                My.Forms.LoginForm.Visible = True
            Case MsgBoxResult.No
                e.Cancel = True
        End Select
    End Sub
    '■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■exit butto■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
    Private mouseOffset As Point
    Private isMouseDown As Boolean = False
    Private Sub ExitButton__Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        My.Application.SaveMySettingsOnExit = True
        Me.Close()
    End Sub
    '■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■resize window Functions■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
    Public ypos As Integer
    Private Sub PictureBox11_Click(sender As Object, e As MouseEventArgs) Handles PictureBox11.MouseDown, PictureBox11.Click
        If e.Button = MouseButtons.Left Then
            isMouseDown = True
            ypos = Control.MousePosition.Y
        End If
    End Sub
    Public SizeWhitePanel As New Size()
    Private Sub PictureBox11_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox11.MouseMove
        If isMouseDown Then
            Dim maxWindow As Integer = Screen.PrimaryScreen.WorkingArea.Height
            Dim resultY As Integer = MousePosition.Y - Location.Y
            If resultY < 500 Then
                resultY = 500
            End If
            If resultY > maxWindow Then
                resultY = maxWindow
            End If
            PictureBox11.Location = New Point(0, (resultY))
            Me.Size = New Size(Size.Width, (resultY + 5))

            SizeWhitePanel = New Size(SensorsConfig1.Size.Width, resultY - MonitoringPage.Location.Y)
            MonitoringPage.Size = SizeWhitePanel
            _Listwa1.Size = SizeWhitePanel
            _Listwa2.Size = SizeWhitePanel
            SensorsConfig1.Size = SizeWhitePanel
            UserConfig1.Size = SizeWhitePanel
            AllertConfig1.Size = SizeWhitePanel
            Log1.Size = SizeWhitePanel
            PictureBox4.Size = New Size(PictureBox4.Size.Width, resultY)
            PictureBox7.Size = New Size(PictureBox7.Size.Width, resultY)
        End If
    End Sub
    Private Sub PictureBox11_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox11.MouseUp
        If e.Button = MouseButtons.Left Then
            isMouseDown = False

        End If
    End Sub
    '■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■remove window functions■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
    Private Sub PictureBox3__MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseDown

        Dim xOffset As Integer
        Dim yOffset As Integer

        If e.Button = MouseButtons.Left Then

            xOffset = -e.X - SystemInformation.FrameBorderSize.Width
            yOffset = -e.Y - SystemInformation.CaptionHeight -
           SystemInformation.FrameBorderSize.Height
            mouseOffset = New Point(xOffset, yOffset)
            isMouseDown = True

        End If
    End Sub
    Private Sub PictureBox3_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseMove

        If isMouseDown Then

            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub
    Private Sub PictureBox3_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseUp
        If e.Button = MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    '■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■MENU BUTTONS■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
    Private Sub MonitoringOverview_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        unvisibleWindows()
        MonitoringPage.Visible = True
    End Sub
    Private Sub PDUAConfig_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        unvisibleWindows()
        _Listwa1.Visible = True

    End Sub
    Private Sub PDUBConfig_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        unvisibleWindows()
        _Listwa2.Visible = True
    End Sub
    Private Sub SensorConfig_Click(sender As Object, e As EventArgs) Handles SensorConfig.Click
        unvisibleWindows()
        SensorsConfig1.Visible = True

    End Sub
    Private Sub AllertConfig_Click(sender As Object, e As EventArgs) Handles AllertConfig.Click
        unvisibleWindows()
        AllertConfig1.Visible = True
    End Sub
    Private Sub NetworkConfig_Click(sender As Object, e As EventArgs) Handles NetworkConfig.Click
        unvisibleWindows()
        UserConfig1.Visible = True
    End Sub
    Private Sub log_Click(sender As Object, e As EventArgs) Handles Log.Click
        unvisibleWindows()
        Log1.Visible = True
    End Sub
    Private Sub unvisibleWindows()
        Log1.Visible = False
        UserConfig1.Visible = False
        AllertConfig1.Visible = False
        MonitoringPage.Visible = False
        _Listwa1.Visible = False
        _Listwa2.Visible = False
        SensorsConfig1.Visible = False
    End Sub
    '■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■Buttons animation■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
    Private Sub ExitButtonUnMove__Click(sender As Object, e As EventArgs) Handles ExitButton.MouseLeave
        ExitButton.Image = WindowsApp3.My.Resources.Resources.EXIT1
    End Sub
    Private Sub ExitButtonMove__Click(sender As Object, e As EventArgs) Handles ExitButton.MouseEnter
        ExitButton.Image = WindowsApp3.My.Resources.Resources.ExitButtonMove1
    End Sub
    Private Sub ExitButtonInactive__Click(sender As Object, e As EventArgs) Handles Me.Deactivate
        ExitButton.Image = WindowsApp3.My.Resources.Resources.ExitButtonInActive
    End Sub
    Private Sub ExitButtonActive__Click(sender As Object, e As EventArgs) Handles Me.Activated
        ExitButton.Image = WindowsApp3.My.Resources.Resources.EXIT1
    End Sub
    Private Sub ExitButtonDown__Click(sender As Object, e As EventArgs) Handles ExitButton.MouseDown
        ExitButton.Image = WindowsApp3.My.Resources.Resources.ExitButtonClick
    End Sub
    Private Sub PictureBox2me_Click(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter, PictureBox2.MouseUp
        PictureBox2.Image = WindowsApp3.My.Resources.Resources.MO_Gray_
    End Sub
    Private Sub PictureBox5me_Click(sender As Object, e As EventArgs) Handles PictureBox5.MouseEnter, PictureBox5.MouseUp
        PictureBox5.Image = WindowsApp3.My.Resources.Resources.PDUAC_gray_
    End Sub
    Private Sub PictureBox6me_Click(sender As Object, e As EventArgs) Handles PictureBox6.MouseEnter, PictureBox6.MouseUp
        PictureBox6.Image = WindowsApp3.My.Resources.Resources.PDUBC_gray_
    End Sub
    Private Sub PictureBox7me_Click(sender As Object, e As EventArgs) Handles SensorConfig.MouseEnter, SensorConfig.MouseUp
        SensorConfig.Image = WindowsApp3.My.Resources.Resources.SC_gray_
    End Sub
    Private Sub PictureBox8me_Click(sender As Object, e As EventArgs) Handles AllertConfig.MouseEnter, AllertConfig.MouseUp
        AllertConfig.Image = WindowsApp3.My.Resources.Resources.AC_gray_
    End Sub
    Private Sub PictureBox9me_Click(sender As Object, e As EventArgs) Handles NetworkConfig.MouseEnter, NetworkConfig.MouseUp
        NetworkConfig.Image = WindowsApp3.My.Resources.Resources.NC_gray_
    End Sub
    Private Sub PictureBox10me_Click(sender As Object, e As EventArgs) Handles Log.MouseEnter, Log.MouseUp
        Log.Image = WindowsApp3.My.Resources.Resources.LOG_gray_
    End Sub
    Private Sub PictureBox2ml_Click(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = WindowsApp3.My.Resources.Resources.MO_black_
    End Sub
    Private Sub PictureBox5ml_Click(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.Image = WindowsApp3.My.Resources.Resources.PDUAC_black_
    End Sub
    Private Sub PictureBox6ml_Click(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave
        PictureBox6.Image = WindowsApp3.My.Resources.Resources.PDUBC_black_
    End Sub
    Private Sub PictureBox7ml_Click(sender As Object, e As EventArgs) Handles SensorConfig.MouseLeave
        SensorConfig.Image = WindowsApp3.My.Resources.Resources.SC_black_
    End Sub
    Private Sub PictureBox8ml_Click(sender As Object, e As EventArgs) Handles AllertConfig.MouseLeave
        AllertConfig.Image = WindowsApp3.My.Resources.Resources.AC_black_
    End Sub
    Private Sub PictureBox9ml_Click(sender As Object, e As EventArgs) Handles NetworkConfig.MouseLeave
        NetworkConfig.Image = WindowsApp3.My.Resources.Resources.NC_black_
    End Sub
    Private Sub PictureBox10ml_Click(sender As Object, e As EventArgs) Handles Log.MouseLeave
        Log.Image = WindowsApp3.My.Resources.Resources.LOG_black_
    End Sub
    Private Sub PictureBox2md_Click(sender As Object, e As EventArgs) Handles PictureBox2.MouseDown
        PictureBox2.Image = WindowsApp3.My.Resources.Resources.MO_light_gray_
    End Sub
    Private Sub PictureBox5md_Click(sender As Object, e As EventArgs) Handles PictureBox5.MouseDown
        PictureBox5.Image = WindowsApp3.My.Resources.Resources.PDUAC_light_gray_
    End Sub
    Private Sub PictureBox6md_Click(sender As Object, e As EventArgs) Handles PictureBox6.MouseDown
        PictureBox6.Image = WindowsApp3.My.Resources.Resources.PDUBC_light_gray_
    End Sub
    Private Sub PictureBox7md_Click(sender As Object, e As EventArgs) Handles SensorConfig.MouseDown
        SensorConfig.Image = WindowsApp3.My.Resources.Resources.SC_light_gray_
    End Sub
    Private Sub PictureBox8md_Click(sender As Object, e As EventArgs) Handles AllertConfig.MouseDown
        AllertConfig.Image = WindowsApp3.My.Resources.Resources.AC_light_gray_
    End Sub
    Private Sub PictureBox9md_Click(sender As Object, e As EventArgs) Handles NetworkConfig.MouseDown
        NetworkConfig.Image = WindowsApp3.My.Resources.Resources.NC_light_gray_
    End Sub
    Private Sub PictureBox10md_Click(sender As Object, e As EventArgs) Handles Log.MouseDown
        Log.Image = WindowsApp3.My.Resources.Resources.LOG_light_gray_
    End Sub
    '■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■resizex window Functions■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
    Public xpos As Integer
    Private Sub PictureBox7_Click1(sender As Object, e As MouseEventArgs) Handles PictureBox7.MouseDown, PictureBox7.Click
        If e.Button = MouseButtons.Left Then
            'isMouseDown = True
            xpos = Control.MousePosition.X
        End If
    End Sub
    Private Sub PictureBox7_Click2(sender As Object, e As MouseEventArgs) Handles PictureBox7.MouseMove
        If isMouseDown Then
            Dim maxWindow As Integer = Screen.PrimaryScreen.WorkingArea.Width
            Dim resultx As Integer = MousePosition.X - Location.X
            If resultx < 1230 Then
                resultx = 1230
            End If
            If resultx > maxWindow Then
                resultx = maxWindow
            End If
            PictureBox7.Location = New Point((resultx), 0)
            Me.Size = New Size((resultx + 5), Size.Height)

            SizeWhitePanel = New Size(resultx - MonitoringPage.Location.X, SensorsConfig1.Size.Height)
            MonitoringPage.Size = SizeWhitePanel
            _Listwa1.Size = SizeWhitePanel
            _Listwa2.Size = SizeWhitePanel
            SensorsConfig1.Size = SizeWhitePanel
            UserConfig1.Size = SizeWhitePanel
            AllertConfig1.Size = SizeWhitePanel
            Log1.Size = SizeWhitePanel
            PictureBox3.Size = New Size(resultx, PictureBox3.Size.Height)
            PictureBox11.Size = New Size(resultx, PictureBox11.Size.Height)
            PictureBox4.Size = New Size(resultx, PictureBox4.Size.Height)

        End If
    End Sub
    Private Sub PictureBox7_Click(sender As Object, e As MouseEventArgs) Handles PictureBox7.MouseUp
        If e.Button = MouseButtons.Left Then
            isMouseDown = False

        End If
    End Sub


End Class