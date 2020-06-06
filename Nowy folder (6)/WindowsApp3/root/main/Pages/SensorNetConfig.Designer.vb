<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SensorNetConfig
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
        Me.MBVlan = New System.Windows.Forms.GroupBox()
        Me.VlanEnabled = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Vlan = New System.Windows.Forms.TextBox()
        Me.MBIP6Setting = New System.Windows.Forms.GroupBox()
        Me.IPv6Mode = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IPv6Addr = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.IPv6GateWay = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Enable6To4Tunnel = New System.Windows.Forms.ComboBox()
        Me.LocallPAddr = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.MBIP4Setting = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.DNSTimeOut = New System.Windows.Forms.TextBox()
        Me.AlternativeDNS = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.IP4Mode = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IP4Addr = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.IP4Mask = New System.Windows.Forms.TextBox()
        Me.IP4GateWay = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MBVlan.SuspendLayout()
        Me.MBIP6Setting.SuspendLayout()
        Me.MBIP4Setting.SuspendLayout()
        Me.SuspendLayout()
        '
        'MBVlan
        '
        Me.MBVlan.Controls.Add(Me.VlanEnabled)
        Me.MBVlan.Controls.Add(Me.Label36)
        Me.MBVlan.Controls.Add(Me.Label15)
        Me.MBVlan.Controls.Add(Me.Label14)
        Me.MBVlan.Controls.Add(Me.Label35)
        Me.MBVlan.Controls.Add(Me.Vlan)
        Me.MBVlan.Location = New System.Drawing.Point(3, 300)
        Me.MBVlan.Name = "MBVlan"
        Me.MBVlan.Size = New System.Drawing.Size(513, 163)
        Me.MBVlan.TabIndex = 180
        Me.MBVlan.TabStop = False
        Me.MBVlan.Text = "VLAN Settings"
        '
        'VlanEnabled
        '
        Me.VlanEnabled.FormattingEnabled = True
        Me.VlanEnabled.Items.AddRange(New Object() {"Disabled", "Enabled"})
        Me.VlanEnabled.Location = New System.Drawing.Point(125, 71)
        Me.VlanEnabled.Name = "VlanEnabled"
        Me.VlanEnabled.Size = New System.Drawing.Size(164, 21)
        Me.VlanEnabled.TabIndex = 173
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label36.Location = New System.Drawing.Point(125, 92)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(354, 39)
        Me.Label36.TabIndex = 175
        Me.Label36.Text = "NOTE: This will cause device to drop out of regular LAN." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "In case device is inacc" &
    "essible, You can disable VLAN from Serial Console" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or do system reset"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(76, 35)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 141
        Me.Label15.Text = "VLAN ID"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 76)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 13)
        Me.Label14.TabIndex = 140
        Me.Label14.Text = "Enable 802.1Q VLAN"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label35.Location = New System.Drawing.Point(125, 51)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(165, 13)
        Me.Label35.TabIndex = 174
        Me.Label35.Text = "Set VLAN ID for Tagged Packets"
        '
        'Vlan
        '
        Me.Vlan.Location = New System.Drawing.Point(127, 31)
        Me.Vlan.Name = "Vlan"
        Me.Vlan.Size = New System.Drawing.Size(164, 20)
        Me.Vlan.TabIndex = 149
        '
        'MBIP6Setting
        '
        Me.MBIP6Setting.Controls.Add(Me.IPv6Mode)
        Me.MBIP6Setting.Controls.Add(Me.Label5)
        Me.MBIP6Setting.Controls.Add(Me.IPv6Addr)
        Me.MBIP6Setting.Controls.Add(Me.Label13)
        Me.MBIP6Setting.Controls.Add(Me.IPv6GateWay)
        Me.MBIP6Setting.Controls.Add(Me.Label33)
        Me.MBIP6Setting.Controls.Add(Me.Label12)
        Me.MBIP6Setting.Controls.Add(Me.Label25)
        Me.MBIP6Setting.Controls.Add(Me.Label32)
        Me.MBIP6Setting.Controls.Add(Me.Label30)
        Me.MBIP6Setting.Controls.Add(Me.Enable6To4Tunnel)
        Me.MBIP6Setting.Controls.Add(Me.LocallPAddr)
        Me.MBIP6Setting.Controls.Add(Me.Label31)
        Me.MBIP6Setting.Controls.Add(Me.Label18)
        Me.MBIP6Setting.Controls.Add(Me.Label17)
        Me.MBIP6Setting.Location = New System.Drawing.Point(394, 3)
        Me.MBIP6Setting.Name = "MBIP6Setting"
        Me.MBIP6Setting.Size = New System.Drawing.Size(406, 288)
        Me.MBIP6Setting.TabIndex = 179
        Me.MBIP6Setting.TabStop = False
        Me.MBIP6Setting.Text = "IPv6 Settings"
        '
        'IPv6Mode
        '
        Me.IPv6Mode.FormattingEnabled = True
        Me.IPv6Mode.Items.AddRange(New Object() {"Automatic Config", "DHCPv6", "Static", "Disabled"})
        Me.IPv6Mode.Location = New System.Drawing.Point(142, 19)
        Me.IPv6Mode.Name = "IPv6Mode"
        Me.IPv6Mode.Size = New System.Drawing.Size(164, 21)
        Me.IPv6Mode.TabIndex = 153
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(81, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "IPv6 Mode"
        '
        'IPv6Addr
        '
        Me.IPv6Addr.Location = New System.Drawing.Point(142, 61)
        Me.IPv6Addr.Name = "IPv6Addr"
        Me.IPv6Addr.Size = New System.Drawing.Size(164, 20)
        Me.IPv6Addr.TabIndex = 145
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(29, 105)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 13)
        Me.Label13.TabIndex = 139
        Me.Label13.Text = "IPv6 Default Gateway"
        '
        'IPv6GateWay
        '
        Me.IPv6GateWay.Location = New System.Drawing.Point(142, 101)
        Me.IPv6GateWay.Name = "IPv6GateWay"
        Me.IPv6GateWay.Size = New System.Drawing.Size(164, 20)
        Me.IPv6GateWay.TabIndex = 146
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label33.Location = New System.Drawing.Point(137, 204)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(222, 13)
        Me.Label33.TabIndex = 172
        Me.Label33.Text = "IPv4 Address of local interface for 6to4 tunnel"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(70, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 138
        Me.Label12.Text = "IPv6 Address"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label25.Location = New System.Drawing.Point(138, 163)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(114, 13)
        Me.Label25.TabIndex = 164
        Me.Label25.Text = "Enable 6to4 Tunneling"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label32.Location = New System.Drawing.Point(140, 122)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(197, 13)
        Me.Label32.TabIndex = 171
        Me.Label32.Text = "Statically assigned IPv6 default gateway"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label30.Location = New System.Drawing.Point(140, 41)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(165, 13)
        Me.Label30.TabIndex = 169
        Me.Label30.Text = "Method of acquiring IPv6 settings"
        '
        'Enable6To4Tunnel
        '
        Me.Enable6To4Tunnel.FormattingEnabled = True
        Me.Enable6To4Tunnel.Items.AddRange(New Object() {"Disabled", "Enabled"})
        Me.Enable6To4Tunnel.Location = New System.Drawing.Point(140, 141)
        Me.Enable6To4Tunnel.Name = "Enable6To4Tunnel"
        Me.Enable6To4Tunnel.Size = New System.Drawing.Size(164, 21)
        Me.Enable6To4Tunnel.TabIndex = 154
        '
        'LocallPAddr
        '
        Me.LocallPAddr.Location = New System.Drawing.Point(140, 183)
        Me.LocallPAddr.Name = "LocallPAddr"
        Me.LocallPAddr.Size = New System.Drawing.Size(164, 20)
        Me.LocallPAddr.TabIndex = 147
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label31.Location = New System.Drawing.Point(139, 82)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(159, 13)
        Me.Label31.TabIndex = 170
        Me.Label31.Text = "Statically assigned IPv6 address"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(42, 145)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 13)
        Me.Label18.TabIndex = 150
        Me.Label18.Text = "Enable 6to4 tunnel"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(39, 186)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(99, 13)
        Me.Label17.TabIndex = 143
        Me.Label17.Text = "Local IPv4 Address"
        '
        'MBIP4Setting
        '
        Me.MBIP4Setting.Controls.Add(Me.Label24)
        Me.MBIP4Setting.Controls.Add(Me.Label23)
        Me.MBIP4Setting.Controls.Add(Me.DNSTimeOut)
        Me.MBIP4Setting.Controls.Add(Me.AlternativeDNS)
        Me.MBIP4Setting.Controls.Add(Me.Label8)
        Me.MBIP4Setting.Controls.Add(Me.Label11)
        Me.MBIP4Setting.Controls.Add(Me.IP4Mode)
        Me.MBIP4Setting.Controls.Add(Me.Label6)
        Me.MBIP4Setting.Controls.Add(Me.Label26)
        Me.MBIP4Setting.Controls.Add(Me.Label28)
        Me.MBIP4Setting.Controls.Add(Me.Label29)
        Me.MBIP4Setting.Controls.Add(Me.Label27)
        Me.MBIP4Setting.Controls.Add(Me.Label4)
        Me.MBIP4Setting.Controls.Add(Me.IP4Addr)
        Me.MBIP4Setting.Controls.Add(Me.Label7)
        Me.MBIP4Setting.Controls.Add(Me.IP4Mask)
        Me.MBIP4Setting.Controls.Add(Me.IP4GateWay)
        Me.MBIP4Setting.Controls.Add(Me.Label10)
        Me.MBIP4Setting.Location = New System.Drawing.Point(3, 3)
        Me.MBIP4Setting.Name = "MBIP4Setting"
        Me.MBIP4Setting.Size = New System.Drawing.Size(374, 288)
        Me.MBIP4Setting.TabIndex = 178
        Me.MBIP4Setting.TabStop = False
        Me.MBIP4Setting.Text = "IPv4 Settings"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label24.Location = New System.Drawing.Point(135, 247)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(150, 13)
        Me.Label24.TabIndex = 169
        Me.Label24.Text = "Timeout for DNS request (sec)"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label23.Location = New System.Drawing.Point(136, 208)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(199, 13)
        Me.Label23.TabIndex = 168
        Me.Label23.Text = "Statically assigned alternate name server"
        '
        'DNSTimeOut
        '
        Me.DNSTimeOut.Location = New System.Drawing.Point(139, 226)
        Me.DNSTimeOut.Name = "DNSTimeOut"
        Me.DNSTimeOut.Size = New System.Drawing.Size(164, 20)
        Me.DNSTimeOut.TabIndex = 167
        '
        'AlternativeDNS
        '
        Me.AlternativeDNS.Location = New System.Drawing.Point(139, 185)
        Me.AlternativeDNS.Name = "AlternativeDNS"
        Me.AlternativeDNS.Size = New System.Drawing.Size(164, 20)
        Me.AlternativeDNS.TabIndex = 166
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(66, 229)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 164
        Me.Label8.Text = "DNS Timeout"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(62, 188)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 13)
        Me.Label11.TabIndex = 165
        Me.Label11.Text = "Alternate DNS"
        '
        'IP4Mode
        '
        Me.IP4Mode.FormattingEnabled = True
        Me.IP4Mode.Items.AddRange(New Object() {"DHCT with Failover", "Static"})
        Me.IP4Mode.Location = New System.Drawing.Point(137, 19)
        Me.IP4Mode.Name = "IP4Mode"
        Me.IP4Mode.Size = New System.Drawing.Size(164, 21)
        Me.IP4Mode.TabIndex = 152
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(76, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 125
        Me.Label6.Text = "IPv4 Mode"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label26.Location = New System.Drawing.Point(134, 165)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(197, 13)
        Me.Label26.TabIndex = 165
        Me.Label26.Text = "Statically assigned IPv4 default gateway"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label28.Location = New System.Drawing.Point(136, 124)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(159, 13)
        Me.Label28.TabIndex = 167
        Me.Label28.Text = "Statically assigned IPv4 address"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label29.Location = New System.Drawing.Point(136, 41)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(153, 13)
        Me.Label29.TabIndex = 168
        Me.Label29.Text = "Method of acquiring IP settings"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label27.Location = New System.Drawing.Point(136, 82)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(159, 13)
        Me.Label27.TabIndex = 166
        Me.Label27.Text = "Statically assigned IPv6 address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "IPv4 Address"
        '
        'IP4Addr
        '
        Me.IP4Addr.Location = New System.Drawing.Point(137, 61)
        Me.IP4Addr.Name = "IP4Addr"
        Me.IP4Addr.Size = New System.Drawing.Size(164, 20)
        Me.IP4Addr.TabIndex = 134
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 126
        Me.Label7.Text = "IPv4 Subnet Mask"
        '
        'IP4Mask
        '
        Me.IP4Mask.Location = New System.Drawing.Point(138, 103)
        Me.IP4Mask.Name = "IP4Mask"
        Me.IP4Mask.Size = New System.Drawing.Size(164, 20)
        Me.IP4Mask.TabIndex = 136
        '
        'IP4GateWay
        '
        Me.IP4GateWay.Location = New System.Drawing.Point(139, 144)
        Me.IP4GateWay.Name = "IP4GateWay"
        Me.IP4GateWay.Size = New System.Drawing.Size(164, 20)
        Me.IP4GateWay.TabIndex = 135
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 13)
        Me.Label10.TabIndex = 128
        Me.Label10.Text = "IPv4 Default Gateway" & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'SensorNetConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MBVlan)
        Me.Controls.Add(Me.MBIP6Setting)
        Me.Controls.Add(Me.MBIP4Setting)
        Me.MaximumSize = New System.Drawing.Size(808, 467)
        Me.MinimumSize = New System.Drawing.Size(808, 467)
        Me.Name = "SensorNetConfig"
        Me.Size = New System.Drawing.Size(808, 467)
        Me.MBVlan.ResumeLayout(False)
        Me.MBVlan.PerformLayout()
        Me.MBIP6Setting.ResumeLayout(False)
        Me.MBIP6Setting.PerformLayout()
        Me.MBIP4Setting.ResumeLayout(False)
        Me.MBIP4Setting.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MBVlan As GroupBox
    Friend WithEvents VlanEnabled As ComboBox
    Friend WithEvents Label36 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Vlan As TextBox
    Friend WithEvents MBIP6Setting As GroupBox
    Friend WithEvents IPv6Mode As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents IPv6Addr As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents IPv6GateWay As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Enable6To4Tunnel As ComboBox
    Friend WithEvents LocallPAddr As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents MBIP4Setting As GroupBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents DNSTimeOut As TextBox
    Friend WithEvents AlternativeDNS As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents IP4Mode As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents IP4Addr As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents IP4Mask As TextBox
    Friend WithEvents IP4GateWay As TextBox
    Friend WithEvents Label10 As Label
End Class
