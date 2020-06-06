<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SensorsConfigPage
    Inherits System.Windows.Forms.UserControl

    'Пользовательский элемент управления (UserControl) переопределяет метод Dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ConStatus = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Tab1 = New System.Windows.Forms.TabPage()
        Me.EnviromuxUserConnectionData1 = New WindowsApp3.EnviromuxUserConnectionData()
        Me.InformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.SensorInformation1 = New WindowsApp3.SensorInformation()
        Me.SensorsGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.SortZone = New System.Windows.Forms.FlowLayoutPanel()
        Me.DigitalInputButton = New System.Windows.Forms.Button()
        Me.TacSensorButton = New System.Windows.Forms.Button()
        Me.Aux2Button = New System.Windows.Forms.Button()
        Me.AuxButton = New System.Windows.Forms.Button()
        Me.ExternalSensorButton = New System.Windows.Forms.Button()
        Me.MsgRegistersButton = New System.Windows.Forms.Button()
        Me.PWRSupplyButton = New System.Windows.Forms.Button()
        Me.RemoteInputButton = New System.Windows.Forms.Button()
        Me.RemoteRelayButton = New System.Windows.Forms.Button()
        Me.SmokeDetectorButton = New System.Windows.Forms.Button()
        Me.InternalButton = New System.Windows.Forms.Button()
        Me.IPDevicesButton = New System.Windows.Forms.Button()
        Me.OutRelaysButton = New System.Windows.Forms.Button()
        Me.IPSensorsButton = New System.Windows.Forms.Button()
        Me.Tab2 = New System.Windows.Forms.TabPage()
        Me.SensorNetConfig1 = New WindowsApp3.SensorNetConfig()
        Me.Tab3 = New System.Windows.Forms.TabPage()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.MetroTextBox2 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Tab1.SuspendLayout()
        Me.InformationGroupBox.SuspendLayout()
        Me.SensorsGroupBox.SuspendLayout()
        Me.SortZone.SuspendLayout()
        Me.Tab2.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConStatus
        '
        Me.ConStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ConStatus.AutoSize = True
        Me.ConStatus.ForeColor = System.Drawing.Color.Red
        Me.ConStatus.Location = New System.Drawing.Point(122, 639)
        Me.ConStatus.Name = "ConStatus"
        Me.ConStatus.Size = New System.Drawing.Size(81, 13)
        Me.ConStatus.TabIndex = 65
        Me.ConStatus.Text = "Not Connection"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 639)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Connection status:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(281, 25)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "SENSORS CONFIGURATION"
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.Tab1)
        Me.TabControl1.Controls.Add(Me.Tab2)
        Me.TabControl1.Controls.Add(Me.Tab3)
        Me.TabControl1.Location = New System.Drawing.Point(18, 71)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(914, 546)
        Me.TabControl1.TabIndex = 126
        '
        'Tab1
        '
        Me.Tab1.AutoScroll = True
        Me.Tab1.Controls.Add(Me.EnviromuxUserConnectionData1)
        Me.Tab1.Controls.Add(Me.InformationGroupBox)
        Me.Tab1.Controls.Add(Me.SensorsGroupBox)
        Me.Tab1.Location = New System.Drawing.Point(4, 22)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab1.Size = New System.Drawing.Size(906, 520)
        Me.Tab1.TabIndex = 1
        Me.Tab1.Text = "Summary"
        Me.Tab1.UseVisualStyleBackColor = True
        '
        'EnviromuxUserConnectionData1
        '
        Me.EnviromuxUserConnectionData1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EnviromuxUserConnectionData1.Location = New System.Drawing.Point(14, 6)
        Me.EnviromuxUserConnectionData1.MaximumSize = New System.Drawing.Size(340, 165)
        Me.EnviromuxUserConnectionData1.MinimumSize = New System.Drawing.Size(340, 165)
        Me.EnviromuxUserConnectionData1.Name = "EnviromuxUserConnectionData1"
        Me.EnviromuxUserConnectionData1.Size = New System.Drawing.Size(340, 165)
        Me.EnviromuxUserConnectionData1.TabIndex = 175
        '
        'InformationGroupBox
        '
        Me.InformationGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.InformationGroupBox.Controls.Add(Me.SensorInformation1)
        Me.InformationGroupBox.Location = New System.Drawing.Point(18, 171)
        Me.InformationGroupBox.Name = "InformationGroupBox"
        Me.InformationGroupBox.Size = New System.Drawing.Size(331, 343)
        Me.InformationGroupBox.TabIndex = 167
        Me.InformationGroupBox.TabStop = False
        Me.InformationGroupBox.Text = "Information"
        '
        'SensorInformation1
        '
        Me.SensorInformation1.Location = New System.Drawing.Point(6, 19)
        Me.SensorInformation1.MaximumSize = New System.Drawing.Size(319, 316)
        Me.SensorInformation1.MinimumSize = New System.Drawing.Size(319, 316)
        Me.SensorInformation1.Name = "SensorInformation1"
        Me.SensorInformation1.Size = New System.Drawing.Size(319, 316)
        Me.SensorInformation1.TabIndex = 175
        '
        'SensorsGroupBox
        '
        Me.SensorsGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SensorsGroupBox.Controls.Add(Me.Label39)
        Me.SensorsGroupBox.Controls.Add(Me.SortZone)
        Me.SensorsGroupBox.Location = New System.Drawing.Point(364, 4)
        Me.SensorsGroupBox.Name = "SensorsGroupBox"
        Me.SensorsGroupBox.Size = New System.Drawing.Size(525, 510)
        Me.SensorsGroupBox.TabIndex = 166
        Me.SensorsGroupBox.TabStop = False
        Me.SensorsGroupBox.Text = "Sensors"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label39.Location = New System.Drawing.Point(89, 43)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(0, 13)
        Me.Label39.TabIndex = 173
        '
        'SortZone
        '
        Me.SortZone.Controls.Add(Me.DigitalInputButton)
        Me.SortZone.Controls.Add(Me.TacSensorButton)
        Me.SortZone.Controls.Add(Me.Aux2Button)
        Me.SortZone.Controls.Add(Me.AuxButton)
        Me.SortZone.Controls.Add(Me.ExternalSensorButton)
        Me.SortZone.Controls.Add(Me.MsgRegistersButton)
        Me.SortZone.Controls.Add(Me.PWRSupplyButton)
        Me.SortZone.Controls.Add(Me.RemoteInputButton)
        Me.SortZone.Controls.Add(Me.RemoteRelayButton)
        Me.SortZone.Controls.Add(Me.SmokeDetectorButton)
        Me.SortZone.Controls.Add(Me.InternalButton)
        Me.SortZone.Controls.Add(Me.IPDevicesButton)
        Me.SortZone.Controls.Add(Me.OutRelaysButton)
        Me.SortZone.Controls.Add(Me.IPSensorsButton)
        Me.SortZone.Location = New System.Drawing.Point(7, 19)
        Me.SortZone.Margin = New System.Windows.Forms.Padding(0)
        Me.SortZone.Name = "SortZone"
        Me.SortZone.Size = New System.Drawing.Size(512, 475)
        Me.SortZone.TabIndex = 159
        '
        'DigitalInputButton
        '
        Me.DigitalInputButton.Enabled = False
        Me.DigitalInputButton.Location = New System.Drawing.Point(3, 3)
        Me.DigitalInputButton.Name = "DigitalInputButton"
        Me.DigitalInputButton.Size = New System.Drawing.Size(79, 53)
        Me.DigitalInputButton.TabIndex = 11
        Me.DigitalInputButton.Text = "Digital inputs"
        Me.DigitalInputButton.UseVisualStyleBackColor = True
        '
        'TacSensorButton
        '
        Me.TacSensorButton.Enabled = False
        Me.TacSensorButton.Location = New System.Drawing.Point(88, 3)
        Me.TacSensorButton.Name = "TacSensorButton"
        Me.TacSensorButton.Size = New System.Drawing.Size(79, 53)
        Me.TacSensorButton.TabIndex = 12
        Me.TacSensorButton.Text = "Tac sensors"
        Me.TacSensorButton.UseVisualStyleBackColor = True
        '
        'Aux2Button
        '
        Me.Aux2Button.Enabled = False
        Me.Aux2Button.Location = New System.Drawing.Point(173, 3)
        Me.Aux2Button.Name = "Aux2Button"
        Me.Aux2Button.Size = New System.Drawing.Size(79, 53)
        Me.Aux2Button.TabIndex = 13
        Me.Aux2Button.Text = "Aux2"
        Me.Aux2Button.UseVisualStyleBackColor = True
        '
        'AuxButton
        '
        Me.AuxButton.Enabled = False
        Me.AuxButton.Location = New System.Drawing.Point(258, 3)
        Me.AuxButton.Name = "AuxButton"
        Me.AuxButton.Size = New System.Drawing.Size(79, 53)
        Me.AuxButton.TabIndex = 14
        Me.AuxButton.Text = "Aux"
        Me.AuxButton.UseVisualStyleBackColor = True
        '
        'ExternalSensorButton
        '
        Me.ExternalSensorButton.Enabled = False
        Me.ExternalSensorButton.Location = New System.Drawing.Point(343, 3)
        Me.ExternalSensorButton.Name = "ExternalSensorButton"
        Me.ExternalSensorButton.Size = New System.Drawing.Size(79, 53)
        Me.ExternalSensorButton.TabIndex = 15
        Me.ExternalSensorButton.Text = "External sensors"
        Me.ExternalSensorButton.UseVisualStyleBackColor = True
        '
        'MsgRegistersButton
        '
        Me.MsgRegistersButton.Enabled = False
        Me.MsgRegistersButton.Location = New System.Drawing.Point(428, 3)
        Me.MsgRegistersButton.Name = "MsgRegistersButton"
        Me.MsgRegistersButton.Size = New System.Drawing.Size(79, 53)
        Me.MsgRegistersButton.TabIndex = 16
        Me.MsgRegistersButton.Text = "Msg Registers"
        Me.MsgRegistersButton.UseVisualStyleBackColor = True
        '
        'PWRSupplyButton
        '
        Me.PWRSupplyButton.Enabled = False
        Me.PWRSupplyButton.Location = New System.Drawing.Point(3, 62)
        Me.PWRSupplyButton.Name = "PWRSupplyButton"
        Me.PWRSupplyButton.Size = New System.Drawing.Size(79, 53)
        Me.PWRSupplyButton.TabIndex = 17
        Me.PWRSupplyButton.Text = "Pwr Supply"
        Me.PWRSupplyButton.UseVisualStyleBackColor = True
        '
        'RemoteInputButton
        '
        Me.RemoteInputButton.Enabled = False
        Me.RemoteInputButton.Location = New System.Drawing.Point(88, 62)
        Me.RemoteInputButton.Name = "RemoteInputButton"
        Me.RemoteInputButton.Size = New System.Drawing.Size(79, 53)
        Me.RemoteInputButton.TabIndex = 18
        Me.RemoteInputButton.Text = "Remote inputs"
        Me.RemoteInputButton.UseVisualStyleBackColor = True
        '
        'RemoteRelayButton
        '
        Me.RemoteRelayButton.Enabled = False
        Me.RemoteRelayButton.Location = New System.Drawing.Point(173, 62)
        Me.RemoteRelayButton.Name = "RemoteRelayButton"
        Me.RemoteRelayButton.Size = New System.Drawing.Size(79, 53)
        Me.RemoteRelayButton.TabIndex = 19
        Me.RemoteRelayButton.Text = "Remote Relays"
        Me.RemoteRelayButton.UseVisualStyleBackColor = True
        '
        'SmokeDetectorButton
        '
        Me.SmokeDetectorButton.Enabled = False
        Me.SmokeDetectorButton.Location = New System.Drawing.Point(258, 62)
        Me.SmokeDetectorButton.Name = "SmokeDetectorButton"
        Me.SmokeDetectorButton.Size = New System.Drawing.Size(79, 53)
        Me.SmokeDetectorButton.TabIndex = 20
        Me.SmokeDetectorButton.Text = "Smoke Detectors"
        Me.SmokeDetectorButton.UseVisualStyleBackColor = True
        '
        'InternalButton
        '
        Me.InternalButton.Enabled = False
        Me.InternalButton.Location = New System.Drawing.Point(343, 62)
        Me.InternalButton.Name = "InternalButton"
        Me.InternalButton.Size = New System.Drawing.Size(79, 53)
        Me.InternalButton.TabIndex = 21
        Me.InternalButton.Text = "Internal Sensors"
        Me.InternalButton.UseVisualStyleBackColor = True
        '
        'IPDevicesButton
        '
        Me.IPDevicesButton.Enabled = False
        Me.IPDevicesButton.Location = New System.Drawing.Point(428, 62)
        Me.IPDevicesButton.Name = "IPDevicesButton"
        Me.IPDevicesButton.Size = New System.Drawing.Size(79, 53)
        Me.IPDevicesButton.TabIndex = 22
        Me.IPDevicesButton.Text = "IP Devices"
        Me.IPDevicesButton.UseVisualStyleBackColor = True
        '
        'OutRelaysButton
        '
        Me.OutRelaysButton.Enabled = False
        Me.OutRelaysButton.Location = New System.Drawing.Point(3, 121)
        Me.OutRelaysButton.Name = "OutRelaysButton"
        Me.OutRelaysButton.Size = New System.Drawing.Size(79, 53)
        Me.OutRelaysButton.TabIndex = 23
        Me.OutRelaysButton.Text = "Out Relay"
        Me.OutRelaysButton.UseVisualStyleBackColor = True
        '
        'IPSensorsButton
        '
        Me.IPSensorsButton.Enabled = False
        Me.IPSensorsButton.Location = New System.Drawing.Point(88, 121)
        Me.IPSensorsButton.Name = "IPSensorsButton"
        Me.IPSensorsButton.Size = New System.Drawing.Size(79, 53)
        Me.IPSensorsButton.TabIndex = 24
        Me.IPSensorsButton.Text = "IP Sensors"
        Me.IPSensorsButton.UseVisualStyleBackColor = True
        '
        'Tab2
        '
        Me.Tab2.AutoScroll = True
        Me.Tab2.Controls.Add(Me.SensorNetConfig1)
        Me.Tab2.Location = New System.Drawing.Point(4, 22)
        Me.Tab2.Name = "Tab2"
        Me.Tab2.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab2.Size = New System.Drawing.Size(906, 520)
        Me.Tab2.TabIndex = 2
        Me.Tab2.Text = "Net Configuration"
        Me.Tab2.UseVisualStyleBackColor = True
        '
        'SensorNetConfig1
        '
        Me.SensorNetConfig1.Enabled = False
        Me.SensorNetConfig1.Location = New System.Drawing.Point(6, 6)
        Me.SensorNetConfig1.MaximumSize = New System.Drawing.Size(808, 467)
        Me.SensorNetConfig1.MinimumSize = New System.Drawing.Size(808, 467)
        Me.SensorNetConfig1.Name = "SensorNetConfig1"
        Me.SensorNetConfig1.Size = New System.Drawing.Size(808, 467)
        Me.SensorNetConfig1.TabIndex = 178
        '
        'Tab3
        '
        Me.Tab3.AutoScroll = True
        Me.Tab3.Location = New System.Drawing.Point(4, 22)
        Me.Tab3.Name = "Tab3"
        Me.Tab3.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab3.Size = New System.Drawing.Size(906, 520)
        Me.Tab3.TabIndex = 3
        Me.Tab3.Text = "System Configuration"
        Me.Tab3.UseVisualStyleBackColor = True
        '
        'Logo
        '
        Me.Logo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Logo.Location = New System.Drawing.Point(697, 6)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(228, 81)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Logo.TabIndex = 162
        Me.Logo.TabStop = False
        '
        'MetroTextBox2
        '
        Me.MetroTextBox2.Owner = Nothing
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.Location = New System.Drawing.Point(842, 637)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(86, 24)
        Me.SaveButton.TabIndex = 163
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'SensorsConfigPage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ConStatus)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.MinimumSize = New System.Drawing.Size(950, 681)
        Me.Name = "SensorsConfigPage"
        Me.Size = New System.Drawing.Size(950, 681)
        Me.TabControl1.ResumeLayout(False)
        Me.Tab1.ResumeLayout(False)
        Me.InformationGroupBox.ResumeLayout(False)
        Me.SensorsGroupBox.ResumeLayout(False)
        Me.SensorsGroupBox.PerformLayout()
        Me.SortZone.ResumeLayout(False)
        Me.Tab2.ResumeLayout(False)
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConStatus As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Tab1 As TabPage
    Friend WithEvents Tab2 As TabPage
    Friend WithEvents Tab3 As TabPage
    Friend WithEvents SortZone As FlowLayoutPanel
    Friend WithEvents InputIP As MetroFramework.Controls.MetroTextBox
    Friend WithEvents backDot As MetroFramework.Controls.MetroTextBox
    Friend WithEvents InformationGroupBox As GroupBox
    Friend WithEvents SensorsGroupBox As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label39 As Label
    Friend WithEvents Logo As PictureBox
    Private WithEvents MetroTextBox2 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents EnviromuxUserConnectionData1 As EnviromuxUserConnectionData
    Friend WithEvents SensorNetConfig1 As SensorNetConfig
    Friend WithEvents SensorInformation1 As SensorInformation
    Friend WithEvents SaveButton As Button
    Friend WithEvents DigitalInputButton As Button
    Friend WithEvents TacSensorButton As Button
    Friend WithEvents Aux2Button As Button
    Friend WithEvents AuxButton As Button
    Friend WithEvents ExternalSensorButton As Button
    Friend WithEvents MsgRegistersButton As Button
    Friend WithEvents PWRSupplyButton As Button
    Friend WithEvents RemoteInputButton As Button
    Friend WithEvents RemoteRelayButton As Button
    Friend WithEvents SmokeDetectorButton As Button
    Friend WithEvents InternalButton As Button
    Friend WithEvents IPDevicesButton As Button
    Friend WithEvents OutRelaysButton As Button
    Friend WithEvents IPSensorsButton As Button
End Class
