Public Class MonitoringPage
    Public WithEvents TableFinder As Timer = New Timer
    Private Sub TableFinder_Tick() Handles TableFinder.Tick
        If MonitoringBase.DevInterface._unlock Then
            MBTable.Visible = True
        Else
            MBTable.Visible = False
        End If
        If PDUA.DevInterface._unlock Then
            TableForPDUA.Visible = True
        Else
            TableForPDUA.Visible = False
        End If
        If PDUB.DevInterface._unlock Then
            TableForPDUB.Visible = True
        Else
            TableForPDUB.Visible = False
        End If
        'Отступы между таблицами
        If TableForPDUA.Visible And TableForPDUB.Visible Then
            BlockPDUAxPDUB.Visible = True
        Else
            BlockPDUAxPDUB.Visible = False
        End If
        If TableForPDUA.Visible And MBTable.Visible Then
            BlockPDUBxMB.Visible = True
        ElseIf TableForPDUB.Visible And MBTable.Visible Then
            BlockPDUBxMB.Visible = True
        Else
            BlockPDUBxMB.Visible = False
        End If
    End Sub
    Public Sub MonitoringPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MBTable.Visible = False
        BlockPDUAxPDUB.Visible = False
        BlockPDUBxMB.Visible = False
        TableForPDUA.TableHead1.Text1.Text = "PDU A"
        TableForPDUB.TableHead1.Text1.Text = "PDU B"
    End Sub
    Public Sub Moe_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then

        End If
    End Sub
End Class
