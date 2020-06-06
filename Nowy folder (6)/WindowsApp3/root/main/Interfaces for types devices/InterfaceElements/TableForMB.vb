Public Class TableForMB
    Private WithEvents timer1 As Timer = New Timer
    Public WithEvents AnimationTimer As Timer = New Timer
    Private Sub timer1_tick() Handles timer1.Tick
        If MonitoringBase.online <> False Then
            TableHead1.Text2.Text = ("")
            refreshFunc()
        Else
            TableHead1.Text2.Text = "(Not online)"
            If TableHead1.Text2.ForeColor = Color.Red Then
                TableHead1.Text2.ForeColor = Color.DarkRed
            Else
                TableHead1.Text2.ForeColor = Color.Red
            End If
        End If
    End Sub
    Private Sub Table_Load(sender As Object, e As EventArgs) Handles Me.Load
        timer1.Interval = 2000

    End Sub
    Private Sub refreshFunc()

    End Sub
    Public Sub startTable(Input As SensorsConfigPage)
        unvisible()
    End Sub
    Private Sub unvisible()

    End Sub
    Private Sub viseble_changed() Handles Me.VisibleChanged
        If Me.Visible Then
            TableHead1.Visible = True
            EndTable.Visible = True
            timer1.Start()
            startTable(My.Forms.Workspace.SensorsConfig1)
        Else
            unvisible()
            TableHead1.Visible = False
            EndTable.Visible = False
            timer1.Stop()
        End If
    End Sub
End Class
