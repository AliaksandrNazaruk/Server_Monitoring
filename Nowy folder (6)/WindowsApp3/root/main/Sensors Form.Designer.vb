<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sensors_Form
    'Форма переопределяет dispose для очистки списка компонентов.
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
    '<System.Diagnostics.DebuggerStepThrough()>

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sensors_Form))
        Me.LoadingPage1 = New WindowsApp3.loadingPage()
        Me.IntSensorPage1 = New WindowsApp3.intSensorPage()
        Me.TacSensorPage1 = New WindowsApp3.tacSensorPage()
        Me.Aux2SensorPage1 = New WindowsApp3.aux2SensorPage()
        Me.AuxSensorsPage1 = New WindowsApp3.auxSensorsPage()
        Me.DigitalInPage1 = New WindowsApp3.DigitalInPage()
        Me.ExtSensorsPage1 = New WindowsApp3.extSensorsPage()
        Me.IpDeviceListPage1 = New WindowsApp3.IPDeviceListPage()
        Me.IpSensorsListPage1 = New WindowsApp3.IPSensorsListPage()
        Me.RemoteInputsPage1 = New WindowsApp3.remoteInputsPage()
        Me.RemoteRelayPage1 = New WindowsApp3.RemoteRelaysPage()
        Me.SmokeDetectorsPage1 = New WindowsApp3.SmokeDetectorsPage()
        Me.OutRelayPage1 = New WindowsApp3.OutRelayPage()
        Me.SuspendLayout()
        '
        'LoadingPage1
        '
        Me.LoadingPage1.Location = New System.Drawing.Point(0, 0)
        Me.LoadingPage1.Name = "LoadingPage1"
        Me.LoadingPage1.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.LoadingPage1.Size = New System.Drawing.Size(957, 844)
        Me.LoadingPage1.TabIndex = 11
        Me.LoadingPage1.Visible = False
        '
        'IntSensorPage1
        '
        Me.IntSensorPage1.AutoSize = True
        Me.IntSensorPage1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.IntSensorPage1.BackColor = System.Drawing.Color.White
        Me.IntSensorPage1.Location = New System.Drawing.Point(0, 0)
        Me.IntSensorPage1.Name = "IntSensorPage1"
        Me.IntSensorPage1.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.IntSensorPage1.Size = New System.Drawing.Size(539, 84)
        Me.IntSensorPage1.TabIndex = 10
        '
        'TacSensorPage1
        '
        Me.TacSensorPage1.AutoSize = True
        Me.TacSensorPage1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TacSensorPage1.BackColor = System.Drawing.Color.White
        Me.TacSensorPage1.Location = New System.Drawing.Point(0, 0)
        Me.TacSensorPage1.Name = "TacSensorPage1"
        Me.TacSensorPage1.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.TacSensorPage1.Size = New System.Drawing.Size(539, 84)
        Me.TacSensorPage1.TabIndex = 9
        '
        'Aux2SensorPage1
        '
        Me.Aux2SensorPage1.AutoSize = True
        Me.Aux2SensorPage1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Aux2SensorPage1.BackColor = System.Drawing.Color.White
        Me.Aux2SensorPage1.Location = New System.Drawing.Point(0, 0)
        Me.Aux2SensorPage1.Name = "Aux2SensorPage1"
        Me.Aux2SensorPage1.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.Aux2SensorPage1.Size = New System.Drawing.Size(539, 84)
        Me.Aux2SensorPage1.TabIndex = 8
        '
        'AuxSensorsPage1
        '
        Me.AuxSensorsPage1.AutoSize = True
        Me.AuxSensorsPage1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AuxSensorsPage1.BackColor = System.Drawing.Color.White
        Me.AuxSensorsPage1.Location = New System.Drawing.Point(0, 0)
        Me.AuxSensorsPage1.Name = "AuxSensorsPage1"
        Me.AuxSensorsPage1.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.AuxSensorsPage1.Size = New System.Drawing.Size(539, 84)
        Me.AuxSensorsPage1.TabIndex = 7
        '
        'DigitalInPage1
        '
        Me.DigitalInPage1.AutoSize = True
        Me.DigitalInPage1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.DigitalInPage1.BackColor = System.Drawing.Color.White
        Me.DigitalInPage1.Location = New System.Drawing.Point(0, 0)
        Me.DigitalInPage1.MaximumSize = New System.Drawing.Size(1000, 0)
        Me.DigitalInPage1.Name = "DigitalInPage1"
        Me.DigitalInPage1.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.DigitalInPage1.Size = New System.Drawing.Size(876, 112)
        Me.DigitalInPage1.TabIndex = 6
        '
        'ExtSensorsPage1
        '
        Me.ExtSensorsPage1.AutoSize = True
        Me.ExtSensorsPage1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ExtSensorsPage1.BackColor = System.Drawing.Color.White
        Me.ExtSensorsPage1.Location = New System.Drawing.Point(0, 0)
        Me.ExtSensorsPage1.Name = "ExtSensorsPage1"
        Me.ExtSensorsPage1.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.ExtSensorsPage1.Size = New System.Drawing.Size(539, 84)
        Me.ExtSensorsPage1.TabIndex = 5
        '
        'IpDeviceListPage1
        '
        Me.IpDeviceListPage1.AutoSize = True
        Me.IpDeviceListPage1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.IpDeviceListPage1.BackColor = System.Drawing.Color.White
        Me.IpDeviceListPage1.Location = New System.Drawing.Point(0, 0)
        Me.IpDeviceListPage1.Name = "IpDeviceListPage1"
        Me.IpDeviceListPage1.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.IpDeviceListPage1.Size = New System.Drawing.Size(539, 84)
        Me.IpDeviceListPage1.TabIndex = 4
        '
        'IpSensorsListPage1
        '
        Me.IpSensorsListPage1.AutoSize = True
        Me.IpSensorsListPage1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.IpSensorsListPage1.BackColor = System.Drawing.Color.White
        Me.IpSensorsListPage1.Location = New System.Drawing.Point(0, 0)
        Me.IpSensorsListPage1.Name = "IpSensorsListPage1"
        Me.IpSensorsListPage1.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.IpSensorsListPage1.Size = New System.Drawing.Size(539, 84)
        Me.IpSensorsListPage1.TabIndex = 3
        '
        'RemoteInputsPage1
        '
        Me.RemoteInputsPage1.AutoSize = True
        Me.RemoteInputsPage1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RemoteInputsPage1.BackColor = System.Drawing.Color.White
        Me.RemoteInputsPage1.Location = New System.Drawing.Point(0, 0)
        Me.RemoteInputsPage1.Name = "RemoteInputsPage1"
        Me.RemoteInputsPage1.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.RemoteInputsPage1.Size = New System.Drawing.Size(868, 110)
        Me.RemoteInputsPage1.TabIndex = 2
        '
        'RemoteRelayPage1
        '
        Me.RemoteRelayPage1.AutoSize = True
        Me.RemoteRelayPage1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RemoteRelayPage1.BackColor = System.Drawing.Color.White
        Me.RemoteRelayPage1.Location = New System.Drawing.Point(0, 0)
        Me.RemoteRelayPage1.Name = "RemoteRelayPage1"
        Me.RemoteRelayPage1.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.RemoteRelayPage1.Size = New System.Drawing.Size(539, 110)
        Me.RemoteRelayPage1.TabIndex = 1
        Me.RemoteRelayPage1.Visible = False
        '
        'SmokeDetectorsPage1
        '
        Me.SmokeDetectorsPage1.AutoSize = True
        Me.SmokeDetectorsPage1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SmokeDetectorsPage1.BackColor = System.Drawing.Color.White
        Me.SmokeDetectorsPage1.Location = New System.Drawing.Point(0, 0)
        Me.SmokeDetectorsPage1.Name = "SmokeDetectorsPage1"
        Me.SmokeDetectorsPage1.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.SmokeDetectorsPage1.Size = New System.Drawing.Size(539, 84)
        Me.SmokeDetectorsPage1.TabIndex = 0
        Me.SmokeDetectorsPage1.Visible = False
        '
        'OutRelayPage1
        '
        Me.OutRelayPage1.AutoSize = True
        Me.OutRelayPage1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.OutRelayPage1.Location = New System.Drawing.Point(0, 0)
        Me.OutRelayPage1.Name = "OutRelayPage1"
        Me.OutRelayPage1.Size = New System.Drawing.Size(519, 84)
        Me.OutRelayPage1.TabIndex = 12
        '
        'Sensors_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1007, 535)
        Me.Controls.Add(Me.OutRelayPage1)
        Me.Controls.Add(Me.LoadingPage1)
        Me.Controls.Add(Me.IntSensorPage1)
        Me.Controls.Add(Me.TacSensorPage1)
        Me.Controls.Add(Me.Aux2SensorPage1)
        Me.Controls.Add(Me.AuxSensorsPage1)
        Me.Controls.Add(Me.DigitalInPage1)
        Me.Controls.Add(Me.ExtSensorsPage1)
        Me.Controls.Add(Me.IpDeviceListPage1)
        Me.Controls.Add(Me.IpSensorsListPage1)
        Me.Controls.Add(Me.RemoteInputsPage1)
        Me.Controls.Add(Me.RemoteRelayPage1)
        Me.Controls.Add(Me.SmokeDetectorsPage1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1100, 900)
        Me.Name = "Sensors_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sensor_forms"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SmokeDetectorsPage1 As SmokeDetectorsPage
    Friend WithEvents RemoteRelayPage1 As RemoteRelaysPage
    Friend WithEvents RemoteInputsPage1 As remoteInputsPage
    Friend WithEvents IpSensorsListPage1 As IPSensorsListPage
    Friend WithEvents IpDeviceListPage1 As IPDeviceListPage
    Friend WithEvents ExtSensorsPage1 As extSensorsPage
    Friend WithEvents DigitalInPage1 As DigitalInPage
    Friend WithEvents AuxSensorsPage1 As auxSensorsPage
    Friend WithEvents Aux2SensorPage1 As aux2SensorPage
    Friend WithEvents TacSensorPage1 As tacSensorPage
    Friend WithEvents IntSensorPage1 As intSensorPage
    Friend WithEvents LoadingPage1 As loadingPage
    Friend WithEvents OutRelayPage1 As OutRelayPage
End Class
