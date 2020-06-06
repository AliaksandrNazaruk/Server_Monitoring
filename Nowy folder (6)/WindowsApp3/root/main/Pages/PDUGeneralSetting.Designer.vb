<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PDUGeneralSetting
    Inherits System.Windows.Forms.UserControl

    'Пользовательский элемент управления (UserControl) переопределяет метод Dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AlertConfGroupBox = New System.Windows.Forms.GroupBox()
        Me.SNTPIPaddrServer = New System.Windows.Forms.TextBox()
        Me.SNMPIPaddrfTrap = New System.Windows.Forms.TextBox()
        Me.SNMPPublicComBox = New System.Windows.Forms.TextBox()
        Me.SNMPPrivateCommBox = New System.Windows.Forms.TextBox()
        Me.SyslogPortNumBox = New System.Windows.Forms.TextBox()
        Me.SyslogIPaddrBox = New System.Windows.Forms.TextBox()
        Me.SMTPPortNumBox = New System.Windows.Forms.TextBox()
        Me.SMTPIPaddrServerBox = New System.Windows.Forms.TextBox()
        Me.SMTPPecientBox = New System.Windows.Forms.TextBox()
        Me.SMTPSenderBox = New System.Windows.Forms.TextBox()
        Me.SMTPPassBox = New System.Windows.Forms.TextBox()
        Me.SMTPNameBox = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GenSetGroupBox = New System.Windows.Forms.GroupBox()
        Me.TemperatureMonitor = New MetroFramework.Controls.MetroCheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LogTimeOutComboBox = New System.Windows.Forms.ComboBox()
        Me.AutoRefreshWebsiteComboBox = New System.Windows.Forms.ComboBox()
        Me.dhcpcheck = New MetroFramework.Controls.MetroCheckBox()
        Me.AdminPassBox = New System.Windows.Forms.TextBox()
        Me.UserpasBox = New System.Windows.Forms.TextBox()
        Me.GatewayBox = New System.Windows.Forms.TextBox()
        Me.SubnetBox = New System.Windows.Forms.TextBox()
        Me.Ipaddrbox = New System.Windows.Forms.TextBox()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.LocationBox = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.AlertConfGroupBox.SuspendLayout()
        Me.GenSetGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'AlertConfGroupBox
        '
        Me.AlertConfGroupBox.Controls.Add(Me.SNTPIPaddrServer)
        Me.AlertConfGroupBox.Controls.Add(Me.SNMPIPaddrfTrap)
        Me.AlertConfGroupBox.Controls.Add(Me.SNMPPublicComBox)
        Me.AlertConfGroupBox.Controls.Add(Me.SNMPPrivateCommBox)
        Me.AlertConfGroupBox.Controls.Add(Me.SyslogPortNumBox)
        Me.AlertConfGroupBox.Controls.Add(Me.SyslogIPaddrBox)
        Me.AlertConfGroupBox.Controls.Add(Me.SMTPPortNumBox)
        Me.AlertConfGroupBox.Controls.Add(Me.SMTPIPaddrServerBox)
        Me.AlertConfGroupBox.Controls.Add(Me.SMTPPecientBox)
        Me.AlertConfGroupBox.Controls.Add(Me.SMTPSenderBox)
        Me.AlertConfGroupBox.Controls.Add(Me.SMTPPassBox)
        Me.AlertConfGroupBox.Controls.Add(Me.SMTPNameBox)
        Me.AlertConfGroupBox.Controls.Add(Me.Label17)
        Me.AlertConfGroupBox.Controls.Add(Me.Label18)
        Me.AlertConfGroupBox.Controls.Add(Me.Label19)
        Me.AlertConfGroupBox.Controls.Add(Me.Label20)
        Me.AlertConfGroupBox.Controls.Add(Me.Label21)
        Me.AlertConfGroupBox.Controls.Add(Me.Label16)
        Me.AlertConfGroupBox.Controls.Add(Me.Label15)
        Me.AlertConfGroupBox.Controls.Add(Me.Label14)
        Me.AlertConfGroupBox.Controls.Add(Me.Label13)
        Me.AlertConfGroupBox.Controls.Add(Me.Label12)
        Me.AlertConfGroupBox.Controls.Add(Me.Label11)
        Me.AlertConfGroupBox.Controls.Add(Me.Label10)
        Me.AlertConfGroupBox.Location = New System.Drawing.Point(396, 1)
        Me.AlertConfGroupBox.Name = "AlertConfGroupBox"
        Me.AlertConfGroupBox.Size = New System.Drawing.Size(382, 510)
        Me.AlertConfGroupBox.TabIndex = 183
        Me.AlertConfGroupBox.TabStop = False
        Me.AlertConfGroupBox.Text = "Alert configuration"
        '
        'SNTPIPaddrServer
        '
        Me.SNTPIPaddrServer.Location = New System.Drawing.Point(174, 358)
        Me.SNTPIPaddrServer.Name = "SNTPIPaddrServer"
        Me.SNTPIPaddrServer.Size = New System.Drawing.Size(163, 20)
        Me.SNTPIPaddrServer.TabIndex = 24
        '
        'SNMPIPaddrfTrap
        '
        Me.SNMPIPaddrfTrap.Location = New System.Drawing.Point(174, 329)
        Me.SNMPIPaddrfTrap.Name = "SNMPIPaddrfTrap"
        Me.SNMPIPaddrfTrap.Size = New System.Drawing.Size(163, 20)
        Me.SNMPIPaddrfTrap.TabIndex = 23
        '
        'SNMPPublicComBox
        '
        Me.SNMPPublicComBox.Location = New System.Drawing.Point(174, 300)
        Me.SNMPPublicComBox.Name = "SNMPPublicComBox"
        Me.SNMPPublicComBox.Size = New System.Drawing.Size(163, 20)
        Me.SNMPPublicComBox.TabIndex = 22
        '
        'SNMPPrivateCommBox
        '
        Me.SNMPPrivateCommBox.Location = New System.Drawing.Point(174, 271)
        Me.SNMPPrivateCommBox.Name = "SNMPPrivateCommBox"
        Me.SNMPPrivateCommBox.Size = New System.Drawing.Size(163, 20)
        Me.SNMPPrivateCommBox.TabIndex = 21
        '
        'SyslogPortNumBox
        '
        Me.SyslogPortNumBox.Location = New System.Drawing.Point(174, 242)
        Me.SyslogPortNumBox.Name = "SyslogPortNumBox"
        Me.SyslogPortNumBox.Size = New System.Drawing.Size(163, 20)
        Me.SyslogPortNumBox.TabIndex = 19
        '
        'SyslogIPaddrBox
        '
        Me.SyslogIPaddrBox.Location = New System.Drawing.Point(174, 213)
        Me.SyslogIPaddrBox.Name = "SyslogIPaddrBox"
        Me.SyslogIPaddrBox.Size = New System.Drawing.Size(163, 20)
        Me.SyslogIPaddrBox.TabIndex = 18
        '
        'SMTPPortNumBox
        '
        Me.SMTPPortNumBox.Location = New System.Drawing.Point(174, 184)
        Me.SMTPPortNumBox.Name = "SMTPPortNumBox"
        Me.SMTPPortNumBox.Size = New System.Drawing.Size(163, 20)
        Me.SMTPPortNumBox.TabIndex = 17
        '
        'SMTPIPaddrServerBox
        '
        Me.SMTPIPaddrServerBox.Location = New System.Drawing.Point(174, 155)
        Me.SMTPIPaddrServerBox.Name = "SMTPIPaddrServerBox"
        Me.SMTPIPaddrServerBox.Size = New System.Drawing.Size(163, 20)
        Me.SMTPIPaddrServerBox.TabIndex = 16
        '
        'SMTPPecientBox
        '
        Me.SMTPPecientBox.Location = New System.Drawing.Point(173, 126)
        Me.SMTPPecientBox.Name = "SMTPPecientBox"
        Me.SMTPPecientBox.Size = New System.Drawing.Size(163, 20)
        Me.SMTPPecientBox.TabIndex = 15
        '
        'SMTPSenderBox
        '
        Me.SMTPSenderBox.Location = New System.Drawing.Point(174, 97)
        Me.SMTPSenderBox.Name = "SMTPSenderBox"
        Me.SMTPSenderBox.Size = New System.Drawing.Size(163, 20)
        Me.SMTPSenderBox.TabIndex = 14
        '
        'SMTPPassBox
        '
        Me.SMTPPassBox.Location = New System.Drawing.Point(174, 68)
        Me.SMTPPassBox.Name = "SMTPPassBox"
        Me.SMTPPassBox.Size = New System.Drawing.Size(163, 20)
        Me.SMTPPassBox.TabIndex = 13
        '
        'SMTPNameBox
        '
        Me.SMTPNameBox.Location = New System.Drawing.Point(173, 39)
        Me.SMTPNameBox.Name = "SMTPNameBox"
        Me.SMTPNameBox.Size = New System.Drawing.Size(163, 20)
        Me.SMTPNameBox.TabIndex = 12
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(35, 333)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(137, 13)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "SNMP - IP address for Trap"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(70, 188)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(102, 13)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "SMTP - port number"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(40, 275)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(132, 13)
        Me.Label19.TabIndex = 9
        Me.Label19.Text = "SNMP - private community"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(27, 159)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(145, 13)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "SMTP - IP address for Server"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(28, 362)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(144, 13)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "SNTP - IP address for Server"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(85, 130)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "SMTP - recipient"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(69, 246)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Syslog - port number"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(94, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "SMTP - sender"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(44, 304)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "SNMP - public community"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(81, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "SMTP - password"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(75, 217)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Syslog - IP address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(79, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "SMTP - username"
        '
        'GenSetGroupBox
        '
        Me.GenSetGroupBox.Controls.Add(Me.TemperatureMonitor)
        Me.GenSetGroupBox.Controls.Add(Me.Label5)
        Me.GenSetGroupBox.Controls.Add(Me.LogTimeOutComboBox)
        Me.GenSetGroupBox.Controls.Add(Me.AutoRefreshWebsiteComboBox)
        Me.GenSetGroupBox.Controls.Add(Me.dhcpcheck)
        Me.GenSetGroupBox.Controls.Add(Me.AdminPassBox)
        Me.GenSetGroupBox.Controls.Add(Me.UserpasBox)
        Me.GenSetGroupBox.Controls.Add(Me.GatewayBox)
        Me.GenSetGroupBox.Controls.Add(Me.SubnetBox)
        Me.GenSetGroupBox.Controls.Add(Me.Ipaddrbox)
        Me.GenSetGroupBox.Controls.Add(Me.NameBox)
        Me.GenSetGroupBox.Controls.Add(Me.LocationBox)
        Me.GenSetGroupBox.Controls.Add(Me.Label23)
        Me.GenSetGroupBox.Controls.Add(Me.Label24)
        Me.GenSetGroupBox.Controls.Add(Me.Label25)
        Me.GenSetGroupBox.Controls.Add(Me.Label27)
        Me.GenSetGroupBox.Controls.Add(Me.Label28)
        Me.GenSetGroupBox.Controls.Add(Me.Label29)
        Me.GenSetGroupBox.Controls.Add(Me.Label30)
        Me.GenSetGroupBox.Controls.Add(Me.Label31)
        Me.GenSetGroupBox.Controls.Add(Me.Label32)
        Me.GenSetGroupBox.Controls.Add(Me.Label33)
        Me.GenSetGroupBox.Location = New System.Drawing.Point(6, 1)
        Me.GenSetGroupBox.Name = "GenSetGroupBox"
        Me.GenSetGroupBox.Size = New System.Drawing.Size(361, 510)
        Me.GenSetGroupBox.TabIndex = 182
        Me.GenSetGroupBox.TabStop = False
        Me.GenSetGroupBox.Text = "General setting"
        '
        'TemperatureMonitor
        '
        Me.TemperatureMonitor.AutoSize = True
        Me.TemperatureMonitor.Location = New System.Drawing.Point(153, 332)
        Me.TemperatureMonitor.Name = "TemperatureMonitor"
        Me.TemperatureMonitor.Size = New System.Drawing.Size(26, 15)
        Me.TemperatureMonitor.Style = MetroFramework.MetroColorStyle.Red
        Me.TemperatureMonitor.TabIndex = 105
        Me.TemperatureMonitor.Text = " "
        Me.TemperatureMonitor.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "Temperature monitored"
        '
        'LogTimeOutComboBox
        '
        Me.LogTimeOutComboBox.FormattingEnabled = True
        Me.LogTimeOutComboBox.Items.AddRange(New Object() {"1 minute", "5 minutes", "20 minutes", "60 minutes"})
        Me.LogTimeOutComboBox.Location = New System.Drawing.Point(153, 272)
        Me.LogTimeOutComboBox.Name = "LogTimeOutComboBox"
        Me.LogTimeOutComboBox.Size = New System.Drawing.Size(163, 21)
        Me.LogTimeOutComboBox.TabIndex = 108
        '
        'AutoRefreshWebsiteComboBox
        '
        Me.AutoRefreshWebsiteComboBox.FormattingEnabled = True
        Me.AutoRefreshWebsiteComboBox.Items.AddRange(New Object() {"3 seconds", "10 seconds", "60 seconds"})
        Me.AutoRefreshWebsiteComboBox.Location = New System.Drawing.Point(153, 301)
        Me.AutoRefreshWebsiteComboBox.Name = "AutoRefreshWebsiteComboBox"
        Me.AutoRefreshWebsiteComboBox.Size = New System.Drawing.Size(163, 21)
        Me.AutoRefreshWebsiteComboBox.TabIndex = 107
        '
        'dhcpcheck
        '
        Me.dhcpcheck.Location = New System.Drawing.Point(153, 100)
        Me.dhcpcheck.Name = "dhcpcheck"
        Me.dhcpcheck.Size = New System.Drawing.Size(26, 15)
        Me.dhcpcheck.Style = MetroFramework.MetroColorStyle.Red
        Me.dhcpcheck.TabIndex = 106
        Me.dhcpcheck.UseVisualStyleBackColor = True
        '
        'AdminPassBox
        '
        Me.AdminPassBox.Location = New System.Drawing.Point(153, 243)
        Me.AdminPassBox.Name = "AdminPassBox"
        Me.AdminPassBox.Size = New System.Drawing.Size(163, 20)
        Me.AdminPassBox.TabIndex = 75
        '
        'UserpasBox
        '
        Me.UserpasBox.Location = New System.Drawing.Point(153, 214)
        Me.UserpasBox.Name = "UserpasBox"
        Me.UserpasBox.Size = New System.Drawing.Size(163, 20)
        Me.UserpasBox.TabIndex = 74
        '
        'GatewayBox
        '
        Me.GatewayBox.Location = New System.Drawing.Point(153, 185)
        Me.GatewayBox.Name = "GatewayBox"
        Me.GatewayBox.Size = New System.Drawing.Size(163, 20)
        Me.GatewayBox.TabIndex = 73
        '
        'SubnetBox
        '
        Me.SubnetBox.Location = New System.Drawing.Point(153, 156)
        Me.SubnetBox.Name = "SubnetBox"
        Me.SubnetBox.Size = New System.Drawing.Size(163, 20)
        Me.SubnetBox.TabIndex = 72
        '
        'Ipaddrbox
        '
        Me.Ipaddrbox.Location = New System.Drawing.Point(153, 127)
        Me.Ipaddrbox.Name = "Ipaddrbox"
        Me.Ipaddrbox.Size = New System.Drawing.Size(163, 20)
        Me.Ipaddrbox.TabIndex = 71
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(153, 68)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(163, 20)
        Me.NameBox.TabIndex = 69
        '
        'LocationBox
        '
        Me.LocationBox.Location = New System.Drawing.Point(153, 39)
        Me.LocationBox.Name = "LocationBox"
        Me.LocationBox.Size = New System.Drawing.Size(163, 20)
        Me.LocationBox.TabIndex = 68
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(102, 189)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(49, 13)
        Me.Label23.TabIndex = 66
        Me.Label23.Text = "Gateway"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(27, 277)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(124, 13)
        Me.Label24.TabIndex = 65
        Me.Label24.Text = "Login timeout on website"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(82, 160)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(69, 13)
        Me.Label25.TabIndex = 64
        Me.Label25.Text = "Subnet mask"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(93, 131)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(58, 13)
        Me.Label27.TabIndex = 62
        Me.Label27.Text = "IP Address"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(36, 247)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(115, 13)
        Me.Label28.TabIndex = 61
        Me.Label28.Text = "Administrator password"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(84, 101)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(66, 13)
        Me.Label29.TabIndex = 60
        Me.Label29.Text = "DHCP Client"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(48, 306)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(103, 13)
        Me.Label30.TabIndex = 59
        Me.Label30.Text = "Auto-refresh website"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(116, 72)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(35, 13)
        Me.Label31.TabIndex = 58
        Me.Label31.Text = "Name"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(74, 218)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(77, 13)
        Me.Label32.TabIndex = 57
        Me.Label32.Text = "User password"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(103, 43)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(48, 13)
        Me.Label33.TabIndex = 56
        Me.Label33.Text = "Location"
        '
        'PDUGeneralSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AlertConfGroupBox)
        Me.Controls.Add(Me.GenSetGroupBox)
        Me.Name = "PDUGeneralSetting"
        Me.Size = New System.Drawing.Size(786, 519)
        Me.AlertConfGroupBox.ResumeLayout(False)
        Me.AlertConfGroupBox.PerformLayout()
        Me.GenSetGroupBox.ResumeLayout(False)
        Me.GenSetGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AlertConfGroupBox As GroupBox
    Friend WithEvents SNTPIPaddrServer As TextBox
    Friend WithEvents SNMPIPaddrfTrap As TextBox
    Friend WithEvents SNMPPublicComBox As TextBox
    Friend WithEvents SNMPPrivateCommBox As TextBox
    Friend WithEvents SyslogPortNumBox As TextBox
    Friend WithEvents SyslogIPaddrBox As TextBox
    Friend WithEvents SMTPPortNumBox As TextBox
    Friend WithEvents SMTPIPaddrServerBox As TextBox
    Friend WithEvents SMTPPecientBox As TextBox
    Friend WithEvents SMTPSenderBox As TextBox
    Friend WithEvents SMTPPassBox As TextBox
    Friend WithEvents SMTPNameBox As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GenSetGroupBox As GroupBox
    Friend WithEvents TemperatureMonitor As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LogTimeOutComboBox As ComboBox
    Friend WithEvents AutoRefreshWebsiteComboBox As ComboBox
    Friend WithEvents dhcpcheck As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents AdminPassBox As TextBox
    Friend WithEvents UserpasBox As TextBox
    Friend WithEvents GatewayBox As TextBox
    Friend WithEvents SubnetBox As TextBox
    Friend WithEvents Ipaddrbox As TextBox
    Friend WithEvents NameBox As TextBox
    Friend WithEvents LocationBox As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
End Class
