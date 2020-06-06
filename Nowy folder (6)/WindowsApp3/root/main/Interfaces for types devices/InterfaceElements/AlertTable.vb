Public Class AlertTable
    Private Function thisPDUPage() As PDUConfigPage
        If Me.Name = "PDUAAlertTAble" Then
            Return My.Forms.Workspace._Listwa1
        End If
        If Me.Name = "PDUBAlertTable" Then
            Return My.Forms.Workspace._Listwa2
        End If
        Return Nothing
    End Function
    Private Function thisPDUModule() As Module1.VirtualDevice
        If Me.Name = "PDUAAlertTAble" Then
            Return Module1.PDUA
        End If
        If Me.Name = "PDUBAlertTable" Then
            Return Module1.PDUB
        End If
        Return Nothing
    End Function
    Public Sub ActivateTable(ListwaType As String)
        Clear()
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label9.Visible = True
        Select Case ListwaType

            Case "PDUTypeP3A6T1"
                AlertUserControlPanel1.Visible = True
                AlertUserControlPanel1.PhaseNum.Text = "1"
                AlertUserControlPanel1.AmpNum.Text = "-  A1"
                AlertUserControlPanel2.Visible = True
                AlertUserControlPanel2.PhaseNum.Text = "1"
                AlertUserControlPanel2.AmpNum.Text = "-  A2"
                AlertUserControlPanel3.Visible = True
                AlertUserControlPanel3.PhaseNum.Text = "2"
                AlertUserControlPanel3.AmpNum.Text = "-  A1"
                AlertUserControlPanel4.Visible = True
                AlertUserControlPanel4.PhaseNum.Text = "2"
                AlertUserControlPanel4.AmpNum.Text = "-  A3"
                AlertUserControlPanel5.Visible = True
                AlertUserControlPanel5.PhaseNum.Text = "3"
                AlertUserControlPanel5.AmpNum.Text = "-  A1"
                AlertUserControlPanel6.Visible = True
                AlertUserControlPanel6.PhaseNum.Text = "3"
                AlertUserControlPanel6.AmpNum.Text = "-  A2"
                AlertUserControlPanel7.Visible = True
                AlertUserControlPanel7.AlarmCheckBox.Visible = False
                AlertUserControlPanel7.PhaseNum.Text = "1"
                AlertUserControlPanel7.AmpNum.Text = ""
                AlertUserControlPanel8.Visible = True
                AlertUserControlPanel8.AlarmCheckBox.Visible = False
                AlertUserControlPanel8.PhaseNum.Text = "1"
                AlertUserControlPanel8.AmpNum.Text = ""
                AlertUserControlPanel9.Visible = True
                AlertUserControlPanel9.AlarmCheckBox.Visible = False
                AlertUserControlPanel9.PhaseNum.Text = "1"
                AlertUserControlPanel9.AmpNum.Text = ""
                AlertUserControlPanel10.Visible = True
                AlertUserControlPanel10.AlarmCheckBox.Visible = False
                AlertUserControlPanel10.WarnTextBox.Visible = False
                AlertUserControlPanel10.MaxTextBox.Visible = False
                AlertUserControlPanel10.PhaseName.Text = "Temperature"
                AlertUserControlPanel10.PhaseNum.Text = ""
                AlertUserControlPanel10.AmpNum.Text = ""
            Case "PDUTypeP3A6T0"
                AlertUserControlPanel1.Visible = True
                AlertUserControlPanel1.PhaseNum.Text = "1"
                AlertUserControlPanel1.AmpNum.Text = "-  A1"
                AlertUserControlPanel2.Visible = True
                AlertUserControlPanel2.PhaseNum.Text = "1"
                AlertUserControlPanel2.AmpNum.Text = "-  A2"
                AlertUserControlPanel3.Visible = True
                AlertUserControlPanel3.PhaseNum.Text = "2"
                AlertUserControlPanel3.AmpNum.Text = "-  A1"
                AlertUserControlPanel4.Visible = True
                AlertUserControlPanel4.PhaseNum.Text = "2"
                AlertUserControlPanel4.AmpNum.Text = "-  A3"
                AlertUserControlPanel5.Visible = True
                AlertUserControlPanel5.PhaseNum.Text = "3"
                AlertUserControlPanel5.AmpNum.Text = "-  A1"
                AlertUserControlPanel6.Visible = True
                AlertUserControlPanel6.PhaseNum.Text = "3"
                AlertUserControlPanel6.AmpNum.Text = "-  A2"
                AlertUserControlPanel7.Visible = True
                AlertUserControlPanel7.AlarmCheckBox.Visible = False
                AlertUserControlPanel7.PhaseNum.Text = "1"
                AlertUserControlPanel7.AmpNum.Text = ""
                AlertUserControlPanel8.Visible = True
                AlertUserControlPanel8.AlarmCheckBox.Visible = False
                AlertUserControlPanel8.PhaseNum.Text = "1"
                AlertUserControlPanel8.AmpNum.Text = ""
                AlertUserControlPanel9.Visible = True
                AlertUserControlPanel9.AlarmCheckBox.Visible = False
                AlertUserControlPanel9.PhaseNum.Text = "1"
                AlertUserControlPanel9.AmpNum.Text = ""

            Case "PDUTypeP3A3T1"
                AlertUserControlPanel1.Visible = True
                AlertUserControlPanel1.PhaseNum.Text = "1"
                AlertUserControlPanel1.AmpNum.Text = "-  A1"
                AlertUserControlPanel3.Visible = True
                AlertUserControlPanel3.PhaseNum.Text = "2"
                AlertUserControlPanel3.AmpNum.Text = "-  A1"
                AlertUserControlPanel5.Visible = True
                AlertUserControlPanel5.PhaseNum.Text = "3"
                AlertUserControlPanel5.AmpNum.Text = "-  A1"
                AlertUserControlPanel7.Visible = True
                AlertUserControlPanel7.AlarmCheckBox.Visible = False
                AlertUserControlPanel7.PhaseNum.Text = "1"
                AlertUserControlPanel7.AmpNum.Text = ""
                AlertUserControlPanel8.Visible = True
                AlertUserControlPanel8.AlarmCheckBox.Visible = False
                AlertUserControlPanel8.PhaseNum.Text = "1"
                AlertUserControlPanel8.AmpNum.Text = ""
                AlertUserControlPanel9.Visible = True
                AlertUserControlPanel9.AlarmCheckBox.Visible = False
                AlertUserControlPanel9.PhaseNum.Text = "1"
                AlertUserControlPanel9.AmpNum.Text = ""
                AlertUserControlPanel10.Visible = True
                AlertUserControlPanel10.AlarmCheckBox.Visible = False
                AlertUserControlPanel10.WarnTextBox.Visible = False
                AlertUserControlPanel10.MaxTextBox.Visible = False
                AlertUserControlPanel10.PhaseName.Text = "Temperature"
                AlertUserControlPanel10.PhaseNum.Text = ""
                AlertUserControlPanel10.AmpNum.Text = ""

            Case "PDUTypeP3A3T0"
                AlertUserControlPanel1.Visible = True
                AlertUserControlPanel1.PhaseNum.Text = "1"
                AlertUserControlPanel1.AmpNum.Text = "-  A1"
                AlertUserControlPanel3.Visible = True
                AlertUserControlPanel3.PhaseNum.Text = "2"
                AlertUserControlPanel3.AmpNum.Text = "-  A1"
                AlertUserControlPanel5.Visible = True
                AlertUserControlPanel5.PhaseNum.Text = "3"
                AlertUserControlPanel5.AmpNum.Text = "-  A1"
                AlertUserControlPanel7.Visible = True
                AlertUserControlPanel7.AlarmCheckBox.Visible = False
                AlertUserControlPanel7.PhaseNum.Text = "1"
                AlertUserControlPanel7.AmpNum.Text = ""
                AlertUserControlPanel8.Visible = True
                AlertUserControlPanel8.AlarmCheckBox.Visible = False
                AlertUserControlPanel8.PhaseNum.Text = "1"
                AlertUserControlPanel8.AmpNum.Text = ""
                AlertUserControlPanel9.Visible = True
                AlertUserControlPanel9.AlarmCheckBox.Visible = False
                AlertUserControlPanel9.PhaseNum.Text = "1"
                AlertUserControlPanel9.AmpNum.Text = ""
            Case "PDUTypeP1A2T1"
                AlertUserControlPanel1.Visible = True
                AlertUserControlPanel1.PhaseNum.Text = "1"
                AlertUserControlPanel1.AmpNum.Text = "-  A1"
                AlertUserControlPanel2.Visible = True
                AlertUserControlPanel2.PhaseNum.Text = "2"
                AlertUserControlPanel2.AmpNum.Text = "-  A1"

                AlertUserControlPanel7.Visible = True
                AlertUserControlPanel7.AlarmCheckBox.Visible = False
                AlertUserControlPanel7.PhaseNum.Text = "1"
                AlertUserControlPanel7.AmpNum.Text = ""

                AlertUserControlPanel10.Visible = True
                AlertUserControlPanel10.AlarmCheckBox.Visible = False
                AlertUserControlPanel10.WarnTextBox.Visible = False
                AlertUserControlPanel10.MaxTextBox.Visible = False
                AlertUserControlPanel10.PhaseName.Text = "Temperature"
                AlertUserControlPanel10.PhaseNum.Text = ""
                AlertUserControlPanel10.AmpNum.Text = ""
            Case "PDUTypeP1A2T0"
                AlertUserControlPanel1.Visible = True
                AlertUserControlPanel1.PhaseNum.Text = "1"
                AlertUserControlPanel1.AmpNum.Text = "-  A1"
                AlertUserControlPanel2.Visible = True
                AlertUserControlPanel2.PhaseNum.Text = "2"
                AlertUserControlPanel2.AmpNum.Text = "-  A1"

                AlertUserControlPanel7.Visible = True
                AlertUserControlPanel7.AlarmCheckBox.Visible = False
                AlertUserControlPanel7.PhaseNum.Text = "1"
                AlertUserControlPanel7.AmpNum.Text = ""


            Case "PDUTypeP1A1T1"
                AlertUserControlPanel1.Visible = True
                AlertUserControlPanel1.PhaseNum.Text = "1"
                AlertUserControlPanel1.AmpNum.Text = "-  A1"

                AlertUserControlPanel7.Visible = True
                AlertUserControlPanel7.AlarmCheckBox.Visible = False
                AlertUserControlPanel7.PhaseNum.Text = "1"
                AlertUserControlPanel7.AmpNum.Text = ""

                AlertUserControlPanel10.Visible = True
                AlertUserControlPanel10.AlarmCheckBox.Visible = False
                AlertUserControlPanel10.WarnTextBox.Visible = False
                AlertUserControlPanel10.MaxTextBox.Visible = False
                AlertUserControlPanel10.PhaseName.Text = "Temperature"
                AlertUserControlPanel10.PhaseNum.Text = ""
                AlertUserControlPanel10.AmpNum.Text = ""

            Case "PDUTypeP1A1T0"
                AlertUserControlPanel1.Visible = True
                AlertUserControlPanel1.PhaseNum.Text = "1"
                AlertUserControlPanel1.AmpNum.Text = "-  A1"

                AlertUserControlPanel7.Visible = True
                AlertUserControlPanel7.AlarmCheckBox.Visible = False
                AlertUserControlPanel7.PhaseNum.Text = "1"
                AlertUserControlPanel7.AmpNum.Text = ""
            Case Else
                Clear()
        End Select
    End Sub
    Private Sub Clear()
        AlertUserControlPanel1.Visible = False
        AlertUserControlPanel2.Visible = False
        AlertUserControlPanel3.Visible = False
        AlertUserControlPanel4.Visible = False
        AlertUserControlPanel5.Visible = False
        AlertUserControlPanel6.Visible = False
        AlertUserControlPanel7.Visible = False
        AlertUserControlPanel8.Visible = False
        AlertUserControlPanel9.Visible = False
        AlertUserControlPanel10.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
    End Sub

    Private Sub AlertUserControlPanel1_Load(sender As Object, e As EventArgs) Handles AlertUserControlPanel1.Load
        Clear()
    End Sub

    Private Sub AlertTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
