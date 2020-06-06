Imports System.Net.Mail
Public Class AlertConfigPage
    Private Sub AlertConfigPage_Load(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True Then
            RefreshData()
        End If

    End Sub
    Private Function StringToBool(input As String) As Boolean
        If input Is Nothing Then
            Return False
        End If
        If input = "" Or input = "0" Then
            Return False
        End If
        If input = "True" Or input = "true" Or input = "1" Then
            Return True
        End If
        Return False
    End Function
    Public Sub RefreshData()
        If Module1.PDUA.Online Then
            PDUAAlertTable.AlertUserControlPanel1.MinTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter1.Min
            PDUAAlertTable.AlertUserControlPanel1.WarnTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter1.warn
            PDUAAlertTable.AlertUserControlPanel1.MaxTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter1.Max
            PDUAAlertTable.AlertUserControlPanel1.EmailCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter1.Email)
            PDUAAlertTable.AlertUserControlPanel1.SyslogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter1.Syslog)
            PDUAAlertTable.AlertUserControlPanel1.LogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter1.Log)
            PDUAAlertTable.AlertUserControlPanel1.TrapCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter1.Trap)
            PDUAAlertTable.AlertUserControlPanel1.AlarmCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter1.Alarm0A)

            PDUAAlertTable.AlertUserControlPanel2.MinTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter2.Min
            PDUAAlertTable.AlertUserControlPanel2.WarnTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter2.warn
            PDUAAlertTable.AlertUserControlPanel2.MaxTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter2.Max
            PDUAAlertTable.AlertUserControlPanel2.EmailCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter2.Email)
            PDUAAlertTable.AlertUserControlPanel2.SyslogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter2.Syslog)
            PDUAAlertTable.AlertUserControlPanel2.LogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter2.Log)
            PDUAAlertTable.AlertUserControlPanel2.TrapCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter2.Trap)
            PDUAAlertTable.AlertUserControlPanel2.AlarmCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter2.Alarm0A)

            PDUAAlertTable.AlertUserControlPanel3.MinTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter1.Min
            PDUAAlertTable.AlertUserControlPanel3.WarnTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter1.warn
            PDUAAlertTable.AlertUserControlPanel3.MaxTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter1.Max
            PDUAAlertTable.AlertUserControlPanel3.EmailCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter1.Email)
            PDUAAlertTable.AlertUserControlPanel3.SyslogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter1.Syslog)
            PDUAAlertTable.AlertUserControlPanel3.LogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter1.Log)
            PDUAAlertTable.AlertUserControlPanel3.TrapCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter1.Trap)
            PDUAAlertTable.AlertUserControlPanel3.AlarmCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter1.Alarm0A)

            PDUAAlertTable.AlertUserControlPanel4.MinTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter2.Min
            PDUAAlertTable.AlertUserControlPanel4.WarnTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter2.warn
            PDUAAlertTable.AlertUserControlPanel4.MaxTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter2.Max
            PDUAAlertTable.AlertUserControlPanel4.EmailCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter2.Email)
            PDUAAlertTable.AlertUserControlPanel4.SyslogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter2.Syslog)
            PDUAAlertTable.AlertUserControlPanel4.LogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter2.Log)
            PDUAAlertTable.AlertUserControlPanel4.TrapCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter2.Trap)
            PDUAAlertTable.AlertUserControlPanel4.AlarmCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter2.Alarm0A)

            PDUAAlertTable.AlertUserControlPanel5.MinTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter1.Min
            PDUAAlertTable.AlertUserControlPanel5.WarnTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter1.warn
            PDUAAlertTable.AlertUserControlPanel5.MaxTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter1.Max
            PDUAAlertTable.AlertUserControlPanel5.EmailCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter1.Email)
            PDUAAlertTable.AlertUserControlPanel5.SyslogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter1.Syslog)
            PDUAAlertTable.AlertUserControlPanel5.LogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter1.Log)
            PDUAAlertTable.AlertUserControlPanel5.TrapCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter1.Trap)
            PDUAAlertTable.AlertUserControlPanel5.AlarmCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter1.Alarm0A)

            PDUAAlertTable.AlertUserControlPanel6.MinTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter2.Min
            PDUAAlertTable.AlertUserControlPanel6.WarnTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter2.warn
            PDUAAlertTable.AlertUserControlPanel6.MaxTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter2.Max
            PDUAAlertTable.AlertUserControlPanel6.EmailCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter2.Email)
            PDUAAlertTable.AlertUserControlPanel6.SyslogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter2.Syslog)
            PDUAAlertTable.AlertUserControlPanel6.LogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter2.Log)
            PDUAAlertTable.AlertUserControlPanel6.TrapCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter2.Trap)
            PDUAAlertTable.AlertUserControlPanel6.AlarmCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter2.Alarm0A)

            PDUAAlertTable.AlertUserControlPanel7.EmailCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Email)
            PDUAAlertTable.AlertUserControlPanel7.SyslogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Syslog)
            PDUAAlertTable.AlertUserControlPanel7.LogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Log)
            PDUAAlertTable.AlertUserControlPanel7.TrapCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Trap)

            PDUAAlertTable.AlertUserControlPanel8.EmailCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Email)
            PDUAAlertTable.AlertUserControlPanel8.SyslogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Syslog)
            PDUAAlertTable.AlertUserControlPanel8.LogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Log)
            PDUAAlertTable.AlertUserControlPanel8.TrapCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Trap)

            PDUAAlertTable.AlertUserControlPanel9.EmailCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Email)
            PDUAAlertTable.AlertUserControlPanel9.SyslogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Syslog)
            PDUAAlertTable.AlertUserControlPanel9.LogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Log)
            PDUAAlertTable.AlertUserControlPanel9.TrapCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Trap)

            PDUAAlertTable.AlertUserControlPanel10.MinTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Temp.Trigger
            PDUAAlertTable.AlertUserControlPanel10.EmailCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Temp.Email)
            PDUAAlertTable.AlertUserControlPanel10.SyslogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Temp.Syslog)
            PDUAAlertTable.AlertUserControlPanel10.LogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Temp.Log)
            PDUAAlertTable.AlertUserControlPanel10.TrapCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Temp.Trap)
        End If
        If Module1.PDUB.Online Then
            PDUBAlertTable.AlertUserControlPanel1.MinTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter1.Min
            PDUBAlertTable.AlertUserControlPanel1.WarnTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter1.warn
            PDUBAlertTable.AlertUserControlPanel1.MaxTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter1.Max
            PDUBAlertTable.AlertUserControlPanel1.EmailCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter1.Email)
            PDUBAlertTable.AlertUserControlPanel1.SyslogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter1.Syslog)
            PDUBAlertTable.AlertUserControlPanel1.LogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter1.Log)
            PDUBAlertTable.AlertUserControlPanel1.TrapCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter1.Trap)
            PDUBAlertTable.AlertUserControlPanel1.AlarmCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter1.Alarm0A)

            PDUBAlertTable.AlertUserControlPanel2.MinTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter2.Min
            PDUBAlertTable.AlertUserControlPanel2.WarnTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter2.warn
            PDUBAlertTable.AlertUserControlPanel2.MaxTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter2.Max
            PDUBAlertTable.AlertUserControlPanel2.EmailCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter2.Email)
            PDUBAlertTable.AlertUserControlPanel2.SyslogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter2.Syslog)
            PDUBAlertTable.AlertUserControlPanel2.LogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter2.Log)
            PDUBAlertTable.AlertUserControlPanel2.TrapCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter2.Trap)
            PDUBAlertTable.AlertUserControlPanel2.AlarmCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter2.Alarm0A)

            PDUBAlertTable.AlertUserControlPanel3.MinTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter1.Min
            PDUBAlertTable.AlertUserControlPanel3.WarnTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter1.warn
            PDUBAlertTable.AlertUserControlPanel3.MaxTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter1.Max
            PDUBAlertTable.AlertUserControlPanel3.EmailCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter1.Email)
            PDUBAlertTable.AlertUserControlPanel3.SyslogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter1.Syslog)
            PDUBAlertTable.AlertUserControlPanel3.LogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter1.Log)
            PDUBAlertTable.AlertUserControlPanel3.TrapCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter1.Trap)
            PDUBAlertTable.AlertUserControlPanel3.AlarmCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter1.Alarm0A)

            PDUBAlertTable.AlertUserControlPanel4.MinTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter2.Min
            PDUBAlertTable.AlertUserControlPanel4.WarnTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter2.warn
            PDUBAlertTable.AlertUserControlPanel4.MaxTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter2.Max
            PDUBAlertTable.AlertUserControlPanel4.EmailCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter2.Email)
            PDUBAlertTable.AlertUserControlPanel4.SyslogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter2.Syslog)
            PDUBAlertTable.AlertUserControlPanel4.LogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter2.Log)
            PDUBAlertTable.AlertUserControlPanel4.TrapCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter2.Trap)
            PDUBAlertTable.AlertUserControlPanel4.AlarmCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter2.Alarm0A)

            PDUBAlertTable.AlertUserControlPanel5.MinTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter1.Min
            PDUBAlertTable.AlertUserControlPanel5.WarnTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter1.warn
            PDUBAlertTable.AlertUserControlPanel5.MaxTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter1.Max
            PDUBAlertTable.AlertUserControlPanel5.EmailCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter1.Email)
            PDUBAlertTable.AlertUserControlPanel5.SyslogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter1.Syslog)
            PDUBAlertTable.AlertUserControlPanel5.LogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter1.Log)
            PDUBAlertTable.AlertUserControlPanel5.TrapCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter1.Trap)
            PDUBAlertTable.AlertUserControlPanel5.AlarmCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter1.Alarm0A)

            PDUBAlertTable.AlertUserControlPanel6.MinTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter2.Min
            PDUBAlertTable.AlertUserControlPanel6.WarnTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter2.warn
            PDUBAlertTable.AlertUserControlPanel6.MaxTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter2.Max
            PDUBAlertTable.AlertUserControlPanel6.EmailCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter2.Email)
            PDUBAlertTable.AlertUserControlPanel6.SyslogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter2.Syslog)
            PDUBAlertTable.AlertUserControlPanel6.LogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter2.Log)
            PDUBAlertTable.AlertUserControlPanel6.TrapCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter2.Trap)
            PDUBAlertTable.AlertUserControlPanel6.AlarmCheckBox.Checked = Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter2.Alarm0A


            PDUBAlertTable.AlertUserControlPanel7.EmailCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Email)
            PDUBAlertTable.AlertUserControlPanel7.SyslogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Syslog)
            PDUBAlertTable.AlertUserControlPanel7.LogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Log)
            PDUBAlertTable.AlertUserControlPanel7.TrapCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Trap)

            PDUBAlertTable.AlertUserControlPanel8.EmailCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Email)
            PDUBAlertTable.AlertUserControlPanel8.SyslogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Syslog)
            PDUBAlertTable.AlertUserControlPanel8.LogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Log)
            PDUBAlertTable.AlertUserControlPanel8.TrapCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Trap)

            PDUBAlertTable.AlertUserControlPanel9.EmailCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Email)
            PDUBAlertTable.AlertUserControlPanel9.SyslogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Syslog)
            PDUBAlertTable.AlertUserControlPanel9.LogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Log)
            PDUBAlertTable.AlertUserControlPanel9.TrapCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Trap)

            PDUBAlertTable.AlertUserControlPanel10.MinTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Temp.Trigger
            PDUBAlertTable.AlertUserControlPanel10.EmailCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Temp.Email)
            PDUBAlertTable.AlertUserControlPanel10.SyslogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Temp.Syslog)
            PDUBAlertTable.AlertUserControlPanel10.LogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Temp.Log)
            PDUBAlertTable.AlertUserControlPanel10.TrapCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Temp.Trap)
        End If
    End Sub
    Public Sub InvertSynchronisation()
        Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter1.Min = PDUAAlertTable.AlertUserControlPanel1.MinTextBox.Text
        Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter1.warn = PDUAAlertTable.AlertUserControlPanel1.WarnTextBox.Text
        Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter1.Max = PDUAAlertTable.AlertUserControlPanel1.MaxTextBox.Text
        Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter1.Email = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel1.EmailCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter1.Syslog = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel1.SyslogCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter1.Log = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel1.LogCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter1.Trap = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel1.TrapCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter1.Alarm0A = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel1.AlarmCheckBox.Checked)

        Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter2.Min = PDUAAlertTable.AlertUserControlPanel2.MinTextBox.Text
        Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter2.warn = PDUAAlertTable.AlertUserControlPanel2.WarnTextBox.Text
        Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter2.Max = PDUAAlertTable.AlertUserControlPanel2.MaxTextBox.Text
        Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter2.Email = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel2.EmailCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter2.Syslog = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel2.SyslogCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter2.Log = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel2.LogCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter2.Trap = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel2.TrapCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter2.Alarm0A = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel2.AlarmCheckBox.Checked)

        Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter1.Min = PDUAAlertTable.AlertUserControlPanel3.MinTextBox.Text
        Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter1.warn = PDUAAlertTable.AlertUserControlPanel3.WarnTextBox.Text
        Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter1.Max = PDUAAlertTable.AlertUserControlPanel3.MaxTextBox.Text
        Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter1.Email = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel3.EmailCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter1.Syslog = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel3.SyslogCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter1.Log = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel3.LogCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter1.Trap = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel3.TrapCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter1.Alarm0A = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel3.AlarmCheckBox.Checked)

        Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter2.Min = PDUAAlertTable.AlertUserControlPanel4.MinTextBox.Text
        Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter2.warn = PDUAAlertTable.AlertUserControlPanel4.WarnTextBox.Text
        Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter2.Max = PDUAAlertTable.AlertUserControlPanel4.MaxTextBox.Text
        Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter2.Email = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel4.EmailCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter2.Syslog = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel4.SyslogCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter2.Log = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel4.LogCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter2.Trap = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel4.TrapCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter2.Alarm0A = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel4.AlarmCheckBox.Checked)

        Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter1.Min = PDUAAlertTable.AlertUserControlPanel5.MinTextBox.Text
        Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter1.warn = PDUAAlertTable.AlertUserControlPanel5.WarnTextBox.Text
        Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter1.Max = PDUAAlertTable.AlertUserControlPanel5.MaxTextBox.Text
        Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter1.Email = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel5.EmailCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter1.Syslog = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel5.SyslogCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter1.Log = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel5.LogCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter1.Trap = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel5.TrapCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter1.Alarm0A = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel5.AlarmCheckBox.Checked)

        Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter2.Min = PDUAAlertTable.AlertUserControlPanel6.MinTextBox.Text
        Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter2.warn = PDUAAlertTable.AlertUserControlPanel6.WarnTextBox.Text
        Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter2.Max = PDUAAlertTable.AlertUserControlPanel6.MaxTextBox.Text
        Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter2.Email = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel6.EmailCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter2.Syslog = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel6.SyslogCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter2.Log = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel6.LogCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter2.Trap = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel6.TrapCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter2.Alarm0A = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel6.AlarmCheckBox.Checked)

        Module1.PDUA.dataFile.MonitoringCofig.Phase1.Email = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel7.EmailCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase1.Syslog = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel7.SyslogCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase1.Log = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel7.LogCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase1.Trap = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel7.TrapCheckBox.Checked)

        Module1.PDUA.dataFile.MonitoringCofig.Phase2.Email = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel8.EmailCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase2.Syslog = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel8.SyslogCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase2.Log = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel8.LogCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase2.Trap = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel8.TrapCheckBox.Checked)

        Module1.PDUA.dataFile.MonitoringCofig.Phase3.Email = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel9.EmailCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase3.Syslog = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel9.SyslogCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase3.Log = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel9.LogCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Phase3.Trap = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel9.TrapCheckBox.Checked)

        Module1.PDUA.dataFile.MonitoringCofig.Temp.Trigger = PDUAAlertTable.AlertUserControlPanel10.MinTextBox.Text
        Module1.PDUA.dataFile.MonitoringCofig.Temp.Email = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel10.EmailCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Temp.Syslog = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel10.SyslogCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Temp.Log = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel10.LogCheckBox.Checked)
        Module1.PDUA.dataFile.MonitoringCofig.Temp.Trap = Convert.ToInt16(PDUAAlertTable.AlertUserControlPanel10.TrapCheckBox.Checked)


        '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\


        Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter1.Min = PDUBAlertTable.AlertUserControlPanel1.MinTextBox.Text
        Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter1.warn = PDUBAlertTable.AlertUserControlPanel1.WarnTextBox.Text
        Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter1.Max = PDUBAlertTable.AlertUserControlPanel1.MaxTextBox.Text
        Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter1.Email = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel1.EmailCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter1.Syslog = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel1.SyslogCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter1.Log = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel1.LogCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter1.Trap = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel1.TrapCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter1.Alarm0A = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel1.AlarmCheckBox.Checked)

        Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter2.Min = PDUBAlertTable.AlertUserControlPanel2.MinTextBox.Text
        Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter2.warn = PDUBAlertTable.AlertUserControlPanel2.WarnTextBox.Text
        Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter2.Max = PDUBAlertTable.AlertUserControlPanel2.MaxTextBox.Text
        Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter2.Email = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel2.EmailCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter2.Syslog = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel2.SyslogCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter2.Log = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel2.LogCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter2.Trap = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel2.TrapCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter2.Alarm0A = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel2.AlarmCheckBox.Checked)

        Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter1.Min = PDUBAlertTable.AlertUserControlPanel3.MinTextBox.Text
        Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter1.warn = PDUBAlertTable.AlertUserControlPanel3.WarnTextBox.Text
        Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter1.Max = PDUBAlertTable.AlertUserControlPanel3.MaxTextBox.Text
        Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter1.Email = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel3.EmailCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter1.Syslog = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel3.SyslogCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter1.Log = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel3.LogCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter1.Trap = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel3.TrapCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter1.Alarm0A = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel3.AlarmCheckBox.Checked)

        Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter2.Min = PDUBAlertTable.AlertUserControlPanel4.MinTextBox.Text
        Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter2.warn = PDUBAlertTable.AlertUserControlPanel4.WarnTextBox.Text
        Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter2.Max = PDUBAlertTable.AlertUserControlPanel4.MaxTextBox.Text
        Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter2.Email = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel4.EmailCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter2.Syslog = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel4.SyslogCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter2.Log = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel4.LogCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter2.Trap = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel4.TrapCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter2.Alarm0A = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel4.AlarmCheckBox.Checked)

        Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter1.Min = PDUBAlertTable.AlertUserControlPanel5.MinTextBox.Text
        Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter1.warn = PDUBAlertTable.AlertUserControlPanel5.WarnTextBox.Text
        Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter1.Max = PDUBAlertTable.AlertUserControlPanel5.MaxTextBox.Text
        Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter1.Email = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel5.EmailCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter1.Syslog = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel5.SyslogCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter1.Log = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel5.LogCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter1.Trap = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel5.TrapCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter1.Alarm0A = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel5.AlarmCheckBox.Checked)

        Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter2.Min = PDUBAlertTable.AlertUserControlPanel6.MinTextBox.Text
        Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter2.warn = PDUBAlertTable.AlertUserControlPanel6.WarnTextBox.Text
        Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter2.Max = PDUBAlertTable.AlertUserControlPanel6.MaxTextBox.Text
        Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter2.Email = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel6.EmailCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter2.Syslog = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel6.SyslogCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter2.Log = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel6.LogCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter2.Trap = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel6.TrapCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter2.Alarm0A = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel6.AlarmCheckBox.Checked)

        Module1.PDUB.dataFile.MonitoringCofig.Phase1.Email = PDUBAlertTable.AlertUserControlPanel7.EmailCheckBox.Checked
        Module1.PDUB.dataFile.MonitoringCofig.Phase1.Syslog = PDUBAlertTable.AlertUserControlPanel7.SyslogCheckBox.Checked
        Module1.PDUB.dataFile.MonitoringCofig.Phase1.Log = PDUBAlertTable.AlertUserControlPanel7.LogCheckBox.Checked
        Module1.PDUB.dataFile.MonitoringCofig.Phase1.Trap = PDUBAlertTable.AlertUserControlPanel7.TrapCheckBox.Checked
        Module1.PDUB.dataFile.MonitoringCofig.Phase2.Email = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel8.EmailCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase2.Syslog = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel8.SyslogCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase2.Log = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel8.LogCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase2.Trap = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel8.TrapCheckBox.Checked)

        Module1.PDUB.dataFile.MonitoringCofig.Phase3.Email = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel9.EmailCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase3.Syslog = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel9.SyslogCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase3.Log = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel9.LogCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Phase3.Trap = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel9.TrapCheckBox.Checked)

        Module1.PDUB.dataFile.MonitoringCofig.Temp.Trigger = PDUBAlertTable.AlertUserControlPanel10.MinTextBox.Text
        Module1.PDUB.dataFile.MonitoringCofig.Temp.Email = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel10.EmailCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Temp.Syslog = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel10.SyslogCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Temp.Log = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel10.LogCheckBox.Checked)
        Module1.PDUB.dataFile.MonitoringCofig.Temp.Trap = Convert.ToInt16(PDUBAlertTable.AlertUserControlPanel10.TrapCheckBox.Checked)

    End Sub
    Private Sub AlertConfigPage_Load_1(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            Refresh()
        End If
    End Sub
    Private Sub AnimatedAlertSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles AnimatedAlertSwitch.CheckedChanged
        If Workspace.AllertConfig1.AnimatedAlertSwitch.Checked = False Then
            Workspace.MonitoringPage.TableForPDUA.AnimationTimer.Stop()
            Workspace.MonitoringPage.TableForPDUB.AnimationTimer.Stop()
            Workspace.MonitoringPage.MBTable.AnimationTimer.Stop()
        End If
        If Workspace.AllertConfig1.AnimatedAlertSwitch.Checked Then
            Workspace.MonitoringPage.TableForPDUA.AnimationTimer.Start()
            Workspace.MonitoringPage.TableForPDUB.AnimationTimer.Start()
            Workspace.MonitoringPage.MBTable.AnimationTimer.Start()
        End If
    End Sub
    Private Sub SendMessageToEmailSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles SendMessageToEmailSwitch.CheckedChanged
        If SendMessageToEmailSwitch.Checked Then
            If User.TempProfile.Email Is Nothing Then
                SendMessageToEmailSwitch.Checked = False
                MsgBox("To activate the function of sending messages by email, you need to specify the user email in the ""User Configuration""")
                User.TempProfile.Save()
            ElseIf User.TempProfile.Email = "" Then
                SendMessageToEmailSwitch.Checked = False
                MsgBox("To activate the function of sending messages by email, you need to specify the user email in the ""User Configuration""")
                User.TempProfile.Save()
            End If
        End If

    End Sub
    Public Sub PDUBSave()
        Dim saveFunc1 As Boolean = False
        Dim saveFunc2 As Boolean = False
        Dim saveFunc3 As Boolean = False
        Dim saveFunc4 As Boolean = False
        Dim saveFunc5 As Boolean = False
        Dim saveFunc6 As Boolean = False
        Dim saveFunc7 As Boolean = False
        Dim saveFunc8 As Boolean = False
        Dim saveFunc9 As Boolean = False
        Dim saveFunc10 As Boolean = False

        If PDUBAlertTable.AlertUserControlPanel1.MinTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter1.Min And
            PDUBAlertTable.AlertUserControlPanel1.WarnTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter1.warn And
            PDUBAlertTable.AlertUserControlPanel1.MaxTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter1.Max And
            PDUBAlertTable.AlertUserControlPanel1.EmailCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter1.Email) And
            PDUBAlertTable.AlertUserControlPanel1.SyslogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter1.Syslog) And
            PDUBAlertTable.AlertUserControlPanel1.LogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter1.Log) And
            PDUBAlertTable.AlertUserControlPanel1.TrapCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter1.Trap) And
            PDUBAlertTable.AlertUserControlPanel1.AlarmCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter1.Alarm0A) Then
            saveFunc1 = False
        Else
            saveFunc1 = True
        End If
        If PDUBAlertTable.AlertUserControlPanel2.MinTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter2.Min And
            PDUBAlertTable.AlertUserControlPanel2.WarnTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter2.warn And
            PDUBAlertTable.AlertUserControlPanel2.MaxTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter2.Max And
            PDUBAlertTable.AlertUserControlPanel2.EmailCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter2.Email) And
            PDUBAlertTable.AlertUserControlPanel2.SyslogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter2.Syslog) And
            PDUBAlertTable.AlertUserControlPanel2.LogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter2.Log) And
            PDUBAlertTable.AlertUserControlPanel2.TrapCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter2.Trap) And
            PDUBAlertTable.AlertUserControlPanel2.AlarmCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Ampermeter2.Alarm0A) Then
            saveFunc2 = False
        Else
            saveFunc2 = True
        End If
        If PDUBAlertTable.AlertUserControlPanel3.MinTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter1.Min And
            PDUBAlertTable.AlertUserControlPanel3.WarnTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter1.warn And
            PDUBAlertTable.AlertUserControlPanel3.MaxTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter1.Max And
            PDUBAlertTable.AlertUserControlPanel3.EmailCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter1.Email) And
            PDUBAlertTable.AlertUserControlPanel3.SyslogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter1.Syslog) And
            PDUBAlertTable.AlertUserControlPanel3.LogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter1.Log) And
            PDUBAlertTable.AlertUserControlPanel3.TrapCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter1.Trap) And
            PDUBAlertTable.AlertUserControlPanel3.AlarmCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter1.Alarm0A) Then
            saveFunc3 = False
        Else
            saveFunc3 = True
        End If
        If PDUBAlertTable.AlertUserControlPanel4.MinTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter2.Min And
            PDUBAlertTable.AlertUserControlPanel4.WarnTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter2.warn And
            PDUBAlertTable.AlertUserControlPanel4.MaxTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter2.Max And
            PDUBAlertTable.AlertUserControlPanel4.EmailCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter2.Email) And
            PDUBAlertTable.AlertUserControlPanel4.SyslogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter2.Syslog) And
            PDUBAlertTable.AlertUserControlPanel4.LogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter2.Log) And
            PDUBAlertTable.AlertUserControlPanel4.TrapCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter2.Trap) And
            PDUBAlertTable.AlertUserControlPanel4.AlarmCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Ampermeter2.Alarm0A) Then
            saveFunc4 = False
        Else
            saveFunc4 = True
        End If
        If PDUBAlertTable.AlertUserControlPanel5.MinTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter1.Min And
            PDUBAlertTable.AlertUserControlPanel5.WarnTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter1.warn And
            PDUBAlertTable.AlertUserControlPanel5.MaxTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter1.Max And
            PDUBAlertTable.AlertUserControlPanel5.EmailCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter1.Email) And
            PDUBAlertTable.AlertUserControlPanel5.SyslogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter1.Syslog) And
            PDUBAlertTable.AlertUserControlPanel5.LogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter1.Log) And
            PDUBAlertTable.AlertUserControlPanel5.TrapCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter1.Trap) And
            PDUBAlertTable.AlertUserControlPanel5.AlarmCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter1.Alarm0A) Then
            saveFunc5 = False
        Else
            saveFunc5 = True
        End If
        If PDUBAlertTable.AlertUserControlPanel6.MinTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter2.Min And
            PDUBAlertTable.AlertUserControlPanel6.WarnTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter2.warn And
            PDUBAlertTable.AlertUserControlPanel6.MaxTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter2.Max And
            PDUBAlertTable.AlertUserControlPanel6.EmailCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter2.Email) And
            PDUBAlertTable.AlertUserControlPanel6.SyslogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter2.Syslog) And
            PDUBAlertTable.AlertUserControlPanel6.LogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter2.Log) And
            PDUBAlertTable.AlertUserControlPanel6.TrapCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter2.Trap) And
            PDUBAlertTable.AlertUserControlPanel6.AlarmCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Ampermeter2.Alarm0A) Then
            saveFunc6 = False
        Else
            saveFunc6 = True
        End If
        If PDUBAlertTable.AlertUserControlPanel7.EmailCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Email) And
            PDUBAlertTable.AlertUserControlPanel7.SyslogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Syslog) And
            PDUBAlertTable.AlertUserControlPanel7.LogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Log) And
            PDUBAlertTable.AlertUserControlPanel7.TrapCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase1.Trap) Then
            saveFunc7 = False
        Else
            saveFunc7 = True
        End If
        If PDUBAlertTable.AlertUserControlPanel8.EmailCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Email) And
            PDUBAlertTable.AlertUserControlPanel8.SyslogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Syslog) And
            PDUBAlertTable.AlertUserControlPanel8.LogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Log) And
            PDUBAlertTable.AlertUserControlPanel8.TrapCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase2.Trap) Then
            saveFunc8 = False
        Else
            saveFunc8 = True
        End If
        If PDUBAlertTable.AlertUserControlPanel9.EmailCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Email) And
             PDUBAlertTable.AlertUserControlPanel9.SyslogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Syslog) And
             PDUBAlertTable.AlertUserControlPanel9.LogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Log) And
             PDUBAlertTable.AlertUserControlPanel9.TrapCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Phase3.Trap) Then
            saveFunc9 = False
        Else
            saveFunc9 = True
        End If
        If PDUBAlertTable.AlertUserControlPanel10.MinTextBox.Text = Module1.PDUB.dataFile.MonitoringCofig.Temp.Trigger And
            PDUBAlertTable.AlertUserControlPanel10.EmailCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Temp.Email) And
            PDUBAlertTable.AlertUserControlPanel10.SyslogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Temp.Syslog) And
            PDUBAlertTable.AlertUserControlPanel10.LogCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Temp.Log) And
            PDUBAlertTable.AlertUserControlPanel10.TrapCheckBox.Checked = StringToBool(Module1.PDUB.dataFile.MonitoringCofig.Temp.Trap) Then
            saveFunc10 = False
        Else
            saveFunc10 = True
        End If
        InvertSynchronisation()
        If saveFunc1 Then
            Module1.PDUB.connectToDevice.WebConnection.gotoWebPage(Module1.PDUB.connectToDevice.WebConnection.getHost("SaveMonitoringConfigPhase1A1"))
        End If
        If saveFunc2 Then
            Module1.PDUB.connectToDevice.WebConnection.gotoWebPage(Module1.PDUB.connectToDevice.WebConnection.getHost("SaveMonitoringConfigPhase1A2"))
        End If
        If saveFunc3 Then
            Module1.PDUB.connectToDevice.WebConnection.gotoWebPage(Module1.PDUB.connectToDevice.WebConnection.getHost("SaveMonitoringConfigPhase1A1"))
        End If
        If saveFunc4 Then
            Module1.PDUB.connectToDevice.WebConnection.gotoWebPage(Module1.PDUB.connectToDevice.WebConnection.getHost("SaveMonitoringConfigPhase2A1"))
        End If
        If saveFunc5 Then
            Module1.PDUB.connectToDevice.WebConnection.gotoWebPage(Module1.PDUB.connectToDevice.WebConnection.getHost("SaveMonitoringConfigPhase1A2"))
        End If
        If saveFunc6 Then
            Module1.PDUB.connectToDevice.WebConnection.gotoWebPage(Module1.PDUB.connectToDevice.WebConnection.getHost("SaveMonitoringConfigPhase3A1"))
        End If
        If saveFunc7 Then
            Module1.PDUB.connectToDevice.WebConnection.gotoWebPage(Module1.PDUB.connectToDevice.WebConnection.getHost("SaveMonitoringConfigPhase1"))
        End If
        If saveFunc8 Then
            Module1.PDUB.connectToDevice.WebConnection.gotoWebPage(Module1.PDUB.connectToDevice.WebConnection.getHost("SaveMonitoringConfigPhase2"))
        End If
        If saveFunc9 Then
            Module1.PDUB.connectToDevice.WebConnection.gotoWebPage(Module1.PDUB.connectToDevice.WebConnection.getHost("SaveMonitoringConfigPhase3"))
        End If
        If saveFunc10 Then
            Module1.PDUB.connectToDevice.WebConnection.gotoWebPage(Module1.PDUB.connectToDevice.WebConnection.getHost("SaveMonitoringConfigTemperature"))
        End If
        Module1.PDUA.monitoringMode(True)
    End Sub
    Public Sub PDUASave()
        Workspace.LoadingPage1.Visible = True
        Workspace.LoadingPage1.TextMessage.Text = "Synchronization of parameters with the PDU A device"
        Dim saveFunc1 As Boolean = False
        Dim saveFunc2 As Boolean = False
        Dim saveFunc3 As Boolean = False
        Dim saveFunc4 As Boolean = False
        Dim saveFunc5 As Boolean = False
        Dim saveFunc6 As Boolean = False
        Dim saveFunc7 As Boolean = False
        Dim saveFunc8 As Boolean = False
        Dim saveFunc9 As Boolean = False
        Dim saveFunc10 As Boolean = False
        Workspace.LoadingPage1.ProgressBar1.Value = 0
        If PDUAAlertTable.AlertUserControlPanel1.MinTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter1.Min And
            PDUAAlertTable.AlertUserControlPanel1.WarnTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter1.warn And
            PDUAAlertTable.AlertUserControlPanel1.MaxTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter1.Max And
            PDUAAlertTable.AlertUserControlPanel1.EmailCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter1.Email) And
            PDUAAlertTable.AlertUserControlPanel1.SyslogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter1.Syslog) And
            PDUAAlertTable.AlertUserControlPanel1.LogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter1.Log) And
            PDUAAlertTable.AlertUserControlPanel1.TrapCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter1.Trap) And
            PDUAAlertTable.AlertUserControlPanel1.AlarmCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter1.Alarm0A) Then
            saveFunc1 = False
        Else
            saveFunc1 = True
        End If
        Workspace.LoadingPage1.ProgressBar1.Value = 10
        If PDUAAlertTable.AlertUserControlPanel2.MinTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter2.Min And
            PDUAAlertTable.AlertUserControlPanel2.WarnTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter2.warn And
            PDUAAlertTable.AlertUserControlPanel2.MaxTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter2.Max And
            PDUAAlertTable.AlertUserControlPanel2.EmailCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter2.Email) And
            PDUAAlertTable.AlertUserControlPanel2.SyslogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter2.Syslog) And
            PDUAAlertTable.AlertUserControlPanel2.LogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter2.Log) And
            PDUAAlertTable.AlertUserControlPanel2.TrapCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter2.Trap) And
            PDUAAlertTable.AlertUserControlPanel2.AlarmCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Ampermeter2.Alarm0A) Then
            saveFunc2 = False
        Else
            saveFunc2 = True
        End If
        Workspace.LoadingPage1.ProgressBar1.Value = 15
        If PDUAAlertTable.AlertUserControlPanel3.MinTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter1.Min And
            PDUAAlertTable.AlertUserControlPanel3.WarnTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter1.warn And
            PDUAAlertTable.AlertUserControlPanel3.MaxTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter1.Max And
            PDUAAlertTable.AlertUserControlPanel3.EmailCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter1.Email) And
            PDUAAlertTable.AlertUserControlPanel3.SyslogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter1.Syslog) And
            PDUAAlertTable.AlertUserControlPanel3.LogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter1.Log) And
            PDUAAlertTable.AlertUserControlPanel3.TrapCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter1.Trap) And
            PDUAAlertTable.AlertUserControlPanel3.AlarmCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter1.Alarm0A) Then
            saveFunc3 = False
        Else
            saveFunc3 = True
        End If
        Workspace.LoadingPage1.ProgressBar1.Value = 20
        If PDUAAlertTable.AlertUserControlPanel4.MinTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter2.Min And
            PDUAAlertTable.AlertUserControlPanel4.WarnTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter2.warn And
            PDUAAlertTable.AlertUserControlPanel4.MaxTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter2.Max And
            PDUAAlertTable.AlertUserControlPanel4.EmailCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter2.Email) And
            PDUAAlertTable.AlertUserControlPanel4.SyslogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter2.Syslog) And
            PDUAAlertTable.AlertUserControlPanel4.LogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter2.Log) And
            PDUAAlertTable.AlertUserControlPanel4.TrapCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter2.Trap) And
            PDUAAlertTable.AlertUserControlPanel4.AlarmCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Ampermeter2.Alarm0A) Then
            saveFunc4 = False
        Else
            saveFunc4 = True
        End If
        Workspace.LoadingPage1.ProgressBar1.Value = 25
        If PDUAAlertTable.AlertUserControlPanel5.MinTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter1.Min And
            PDUAAlertTable.AlertUserControlPanel5.WarnTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter1.warn And
            PDUAAlertTable.AlertUserControlPanel5.MaxTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter1.Max And
            PDUAAlertTable.AlertUserControlPanel5.EmailCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter1.Email) And
            PDUAAlertTable.AlertUserControlPanel5.SyslogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter1.Syslog) And
            PDUAAlertTable.AlertUserControlPanel5.LogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter1.Log) And
            PDUAAlertTable.AlertUserControlPanel5.TrapCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter1.Trap) And
            PDUAAlertTable.AlertUserControlPanel5.AlarmCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter1.Alarm0A) Then
            saveFunc5 = False
        Else
            saveFunc5 = True
        End If
        Workspace.LoadingPage1.ProgressBar1.Value = 30
        If PDUAAlertTable.AlertUserControlPanel6.MinTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter2.Min And
            PDUAAlertTable.AlertUserControlPanel6.WarnTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter2.warn And
            PDUAAlertTable.AlertUserControlPanel6.MaxTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter2.Max And
            PDUAAlertTable.AlertUserControlPanel6.EmailCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter2.Email) And
            PDUAAlertTable.AlertUserControlPanel6.SyslogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter2.Syslog) And
            PDUAAlertTable.AlertUserControlPanel6.LogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter2.Log) And
            PDUAAlertTable.AlertUserControlPanel6.TrapCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter2.Trap) And
            PDUAAlertTable.AlertUserControlPanel6.AlarmCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Ampermeter2.Alarm0A) Then
            saveFunc6 = False
        Else
            saveFunc6 = True
        End If
        Workspace.LoadingPage1.ProgressBar1.Value = 35
        If PDUAAlertTable.AlertUserControlPanel7.EmailCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Email) And
            PDUAAlertTable.AlertUserControlPanel7.SyslogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Syslog) And
            PDUAAlertTable.AlertUserControlPanel7.LogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Log) And
            PDUAAlertTable.AlertUserControlPanel7.TrapCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase1.Trap) Then
            saveFunc7 = False
        Else
            saveFunc7 = True
        End If
        Workspace.LoadingPage1.ProgressBar1.Value = 40
        If PDUAAlertTable.AlertUserControlPanel8.EmailCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Email) And
            PDUAAlertTable.AlertUserControlPanel8.SyslogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Syslog) And
            PDUAAlertTable.AlertUserControlPanel8.LogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Log) And
            PDUAAlertTable.AlertUserControlPanel8.TrapCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase2.Trap) Then
            saveFunc8 = False
        Else
            saveFunc8 = True
        End If
        Workspace.LoadingPage1.ProgressBar1.Value = 45
        If PDUAAlertTable.AlertUserControlPanel9.EmailCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Email) And
             PDUAAlertTable.AlertUserControlPanel9.SyslogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Syslog) And
             PDUAAlertTable.AlertUserControlPanel9.LogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Log) And
             PDUAAlertTable.AlertUserControlPanel9.TrapCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Phase3.Trap) Then
            saveFunc9 = False
        Else
            saveFunc9 = True
        End If
        Workspace.LoadingPage1.ProgressBar1.Value = 47
        If PDUAAlertTable.AlertUserControlPanel10.MinTextBox.Text = Module1.PDUA.dataFile.MonitoringCofig.Temp.Trigger And
            PDUAAlertTable.AlertUserControlPanel10.EmailCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Temp.Email) And
            PDUAAlertTable.AlertUserControlPanel10.SyslogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Temp.Syslog) And
            PDUAAlertTable.AlertUserControlPanel10.LogCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Temp.Log) And
            PDUAAlertTable.AlertUserControlPanel10.TrapCheckBox.Checked = StringToBool(Module1.PDUA.dataFile.MonitoringCofig.Temp.Trap) Then
            saveFunc10 = False
        Else
            saveFunc10 = True
        End If
        InvertSynchronisation()
        Workspace.LoadingPage1.ProgressBar1.Value = 50
        If saveFunc1 Then
            Module1.PDUA.connectToDevice.WebConnection.gotoWebPage(Module1.PDUA.connectToDevice.WebConnection.getHost("SaveMonitoringConfigPhase1A1"))

        End If
        Workspace.LoadingPage1.ProgressBar1.Value = 55
        If saveFunc2 Then
            Module1.PDUA.connectToDevice.WebConnection.gotoWebPage(Module1.PDUA.connectToDevice.WebConnection.getHost("SaveMonitoringConfigPhase1A2"))

        End If
        Workspace.LoadingPage1.ProgressBar1.Value = 60
        If saveFunc3 Then
            Module1.PDUA.connectToDevice.WebConnection.gotoWebPage(Module1.PDUA.connectToDevice.WebConnection.getHost("SaveMonitoringConfigPhase2A1"))

        End If
        Workspace.LoadingPage1.ProgressBar1.Value = 65
        If saveFunc4 Then
            Module1.PDUA.connectToDevice.WebConnection.gotoWebPage(Module1.PDUA.connectToDevice.WebConnection.getHost("SaveMonitoringConfigPhase2A2"))

        End If
        Workspace.LoadingPage1.ProgressBar1.Value = 70
        If saveFunc5 Then
            Module1.PDUA.connectToDevice.WebConnection.gotoWebPage(Module1.PDUA.connectToDevice.WebConnection.getHost("SaveMonitoringConfigPhase3A1"))

        End If
        Workspace.LoadingPage1.ProgressBar1.Value = 75
        If saveFunc6 Then
            Module1.PDUA.connectToDevice.WebConnection.gotoWebPage(Module1.PDUA.connectToDevice.WebConnection.getHost("SaveMonitoringConfigPhase3A2"))

        End If
        Workspace.LoadingPage1.ProgressBar1.Value = 80
        If saveFunc7 Then
            Module1.PDUA.connectToDevice.WebConnection.gotoWebPage(Module1.PDUA.connectToDevice.WebConnection.getHost("SaveMonitoringConfigPhase1"))

        End If
        Workspace.LoadingPage1.ProgressBar1.Value = 85
        If saveFunc8 Then
            Module1.PDUA.connectToDevice.WebConnection.gotoWebPage(Module1.PDUA.connectToDevice.WebConnection.getHost("SaveMonitoringConfigPhase2"))

        End If
        Workspace.LoadingPage1.ProgressBar1.Value = 90
        If saveFunc9 Then
            Module1.PDUA.connectToDevice.WebConnection.gotoWebPage(Module1.PDUA.connectToDevice.WebConnection.getHost("SaveMonitoringConfigPhase3"))

        End If
        Workspace.LoadingPage1.ProgressBar1.Value = 95
        If saveFunc10 Then
            Module1.PDUA.connectToDevice.WebConnection.gotoWebPage(Module1.PDUA.connectToDevice.WebConnection.getHost("SaveMonitoringConfigTemperature"))

        End If
        Module1.PDUA.monitoringMode(True)

        Workspace.LoadingPage1.ProgressBar1.Value = 100
    End Sub
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        PDUASave()
        PDUBSave()
        'MBSAVE()
        TempProfile.Save()
        Workspace.LoadingPage1.Visible = False
        Workspace.LoadingPage1.ProgressBar1.Value = 0
    End Sub
    Private WithEvents ResendTimer As Timer = New Timer
    Public Sub resendTimer_Start()
        ResendTimer.Stop()
        If ResendTime.Enabled Then
            If ResendTime.SelectedItem = "20 seconds" Then
                ResendTimer.Interval = 20000
                ResendTimer.Start()
                Exit Sub
            End If
            If ResendTime.SelectedItem = "1 minutes" Then
                ResendTimer.Interval = 60000
                ResendTimer.Start()
                Exit Sub
            End If
            If ResendTime.SelectedItem = "5 minutes" Then
                ResendTimer.Interval = 300000
                ResendTimer.Start()
                Exit Sub
            End If
            If ResendTime.SelectedItem = "20 minutes" Then
                ResendTimer.Interval = 1200000
                ResendTimer.Start()
                Exit Sub
            End If
            If ResendTime.SelectedItem = "60 minutes" Then
                ResendTimer.Interval = 3600000
                ResendTimer.Start()
                Exit Sub
            End If
        End If
        ResendTimer.Stop()
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ResendTime.Enabled = True

        Else
            ResendTime.Enabled = False

        End If
    End Sub
    Public ResendValue As Integer = 0
    Private Sub ResendTimer_Tick() Handles ResendTimer.Tick
        ResendValue = ResendValue + 1
        If ResendValue > 1000 Then
            ResendValue = 1
        End If
    End Sub
    Private Sub ResendTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ResendTime.SelectedIndexChanged
        If ResendTime.SelectedIndex >= 0 Then
            If ResendTime.Enabled Then
                resendTimer_Start()
            Else
                ResendTimer.Stop()
            End If
        End If
    End Sub

    Private Sub AlertConfigPage_Load_2(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
