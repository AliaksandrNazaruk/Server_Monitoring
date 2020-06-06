<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PDUConfigPage
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ConStatus = New System.Windows.Forms.Label()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MonitoringConfigTab = New System.Windows.Forms.TabPage()
        Me.GenSetTabPage = New System.Windows.Forms.TabPage()
        Me.PDUConfigTab = New System.Windows.Forms.TabPage()
        Me.SensorsGroupBox = New System.Windows.Forms.GroupBox()
        Me.InfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.PartNumberBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SoftVersionBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MacAddrBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.partNum = New System.Windows.Forms.Label()
        Me.Mac = New System.Windows.Forms.Label()
        Me.SoftVer = New System.Windows.Forms.Label()
        Me.PDUTab = New System.Windows.Forms.TabControl()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.SoftReset = New System.Windows.Forms.Button()
        Me.PduUserConnectionData1 = New WindowsApp3.PDUUserConnectionData()
        Me.PduSensorsSetting1 = New WindowsApp3.PDUSensorsSetting()
        Me.PduGeneralSetting1 = New WindowsApp3.PDUGeneralSetting()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GenSetTabPage.SuspendLayout()
        Me.PDUConfigTab.SuspendLayout()
        Me.SensorsGroupBox.SuspendLayout()
        Me.InfoGroupBox.SuspendLayout()
        Me.PDUTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 642)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Connection status:"
        '
        'ConStatus
        '
        Me.ConStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ConStatus.AutoSize = True
        Me.ConStatus.ForeColor = System.Drawing.Color.Red
        Me.ConStatus.Location = New System.Drawing.Point(122, 642)
        Me.ConStatus.Name = "ConStatus"
        Me.ConStatus.Size = New System.Drawing.Size(80, 13)
        Me.ConStatus.TabIndex = 57
        Me.ConStatus.Text = "Not connection"
        '
        'Logo
        '
        Me.Logo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Logo.Location = New System.Drawing.Point(704, 3)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(228, 81)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo.TabIndex = 163
        Me.Logo.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 25)
        Me.Label3.TabIndex = 165
        Me.Label3.Text = "PDU"
        '
        'MonitoringConfigTab
        '
        Me.MonitoringConfigTab.Location = New System.Drawing.Point(4, 22)
        Me.MonitoringConfigTab.Name = "MonitoringConfigTab"
        Me.MonitoringConfigTab.Padding = New System.Windows.Forms.Padding(3)
        Me.MonitoringConfigTab.Size = New System.Drawing.Size(906, 525)
        Me.MonitoringConfigTab.TabIndex = 3
        Me.MonitoringConfigTab.Text = "Monitoring cofiguration"
        Me.MonitoringConfigTab.UseVisualStyleBackColor = True
        '
        'GenSetTabPage
        '
        Me.GenSetTabPage.Controls.Add(Me.PduGeneralSetting1)
        Me.GenSetTabPage.Location = New System.Drawing.Point(4, 22)
        Me.GenSetTabPage.Name = "GenSetTabPage"
        Me.GenSetTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.GenSetTabPage.Size = New System.Drawing.Size(906, 525)
        Me.GenSetTabPage.TabIndex = 2
        Me.GenSetTabPage.Text = "General settings"
        Me.GenSetTabPage.UseVisualStyleBackColor = True
        '
        'PDUConfigTab
        '
        Me.PDUConfigTab.AutoScroll = True
        Me.PDUConfigTab.Controls.Add(Me.PduUserConnectionData1)
        Me.PDUConfigTab.Controls.Add(Me.SensorsGroupBox)
        Me.PDUConfigTab.Controls.Add(Me.InfoGroupBox)
        Me.PDUConfigTab.Location = New System.Drawing.Point(4, 22)
        Me.PDUConfigTab.Name = "PDUConfigTab"
        Me.PDUConfigTab.Padding = New System.Windows.Forms.Padding(3)
        Me.PDUConfigTab.Size = New System.Drawing.Size(906, 525)
        Me.PDUConfigTab.TabIndex = 1
        Me.PDUConfigTab.Text = "PDU configuration"
        Me.PDUConfigTab.UseVisualStyleBackColor = True
        '
        'SensorsGroupBox
        '
        Me.SensorsGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SensorsGroupBox.Controls.Add(Me.PduSensorsSetting1)
        Me.SensorsGroupBox.Location = New System.Drawing.Point(364, 6)
        Me.SensorsGroupBox.Name = "SensorsGroupBox"
        Me.SensorsGroupBox.Size = New System.Drawing.Size(525, 510)
        Me.SensorsGroupBox.TabIndex = 180
        Me.SensorsGroupBox.TabStop = False
        Me.SensorsGroupBox.Text = "Sensors"
        '
        'InfoGroupBox
        '
        Me.InfoGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.InfoGroupBox.Controls.Add(Me.PartNumberBox)
        Me.InfoGroupBox.Controls.Add(Me.Label8)
        Me.InfoGroupBox.Controls.Add(Me.SoftVersionBox)
        Me.InfoGroupBox.Controls.Add(Me.Label7)
        Me.InfoGroupBox.Controls.Add(Me.MacAddrBox)
        Me.InfoGroupBox.Controls.Add(Me.Label6)
        Me.InfoGroupBox.Controls.Add(Me.partNum)
        Me.InfoGroupBox.Controls.Add(Me.Mac)
        Me.InfoGroupBox.Controls.Add(Me.SoftVer)
        Me.InfoGroupBox.Location = New System.Drawing.Point(17, 173)
        Me.InfoGroupBox.Name = "InfoGroupBox"
        Me.InfoGroupBox.Size = New System.Drawing.Size(331, 343)
        Me.InfoGroupBox.TabIndex = 179
        Me.InfoGroupBox.TabStop = False
        Me.InfoGroupBox.Text = "Information"
        '
        'PartNumberBox
        '
        Me.PartNumberBox.Enabled = False
        Me.PartNumberBox.Location = New System.Drawing.Point(105, 24)
        Me.PartNumberBox.Name = "PartNumberBox"
        Me.PartNumberBox.Size = New System.Drawing.Size(209, 20)
        Me.PartNumberBox.TabIndex = 172
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(70, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "MAC:"
        '
        'SoftVersionBox
        '
        Me.SoftVersionBox.Enabled = False
        Me.SoftVersionBox.Location = New System.Drawing.Point(106, 86)
        Me.SoftVersionBox.Name = "SoftVersionBox"
        Me.SoftVersionBox.Size = New System.Drawing.Size(209, 20)
        Me.SoftVersionBox.TabIndex = 174
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Software Version:"
        '
        'MacAddrBox
        '
        Me.MacAddrBox.Enabled = False
        Me.MacAddrBox.Location = New System.Drawing.Point(105, 55)
        Me.MacAddrBox.Name = "MacAddrBox"
        Me.MacAddrBox.Size = New System.Drawing.Size(209, 20)
        Me.MacAddrBox.TabIndex = 173
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "partNumber:"
        '
        'partNum
        '
        Me.partNum.AutoSize = True
        Me.partNum.Location = New System.Drawing.Point(108, 34)
        Me.partNum.Name = "partNum"
        Me.partNum.Size = New System.Drawing.Size(0, 13)
        Me.partNum.TabIndex = 53
        '
        'Mac
        '
        Me.Mac.AutoSize = True
        Me.Mac.Location = New System.Drawing.Point(108, 66)
        Me.Mac.Name = "Mac"
        Me.Mac.Size = New System.Drawing.Size(0, 13)
        Me.Mac.TabIndex = 54
        '
        'SoftVer
        '
        Me.SoftVer.AutoSize = True
        Me.SoftVer.Location = New System.Drawing.Point(108, 98)
        Me.SoftVer.Name = "SoftVer"
        Me.SoftVer.Size = New System.Drawing.Size(0, 13)
        Me.SoftVer.TabIndex = 55
        '
        'PDUTab
        '
        Me.PDUTab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PDUTab.Controls.Add(Me.PDUConfigTab)
        Me.PDUTab.Controls.Add(Me.GenSetTabPage)
        Me.PDUTab.Controls.Add(Me.MonitoringConfigTab)
        Me.PDUTab.Location = New System.Drawing.Point(18, 71)
        Me.PDUTab.Name = "PDUTab"
        Me.PDUTab.SelectedIndex = 0
        Me.PDUTab.Size = New System.Drawing.Size(914, 551)
        Me.PDUTab.TabIndex = 125
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.Location = New System.Drawing.Point(842, 642)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(86, 24)
        Me.SaveButton.TabIndex = 166
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'SoftReset
        '
        Me.SoftReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SoftReset.Enabled = False
        Me.SoftReset.Location = New System.Drawing.Point(398, 642)
        Me.SoftReset.Name = "SoftReset"
        Me.SoftReset.Size = New System.Drawing.Size(75, 23)
        Me.SoftReset.TabIndex = 167
        Me.SoftReset.Text = "Reset"
        Me.SoftReset.UseVisualStyleBackColor = True
        '
        'PduUserConnectionData1
        '
        Me.PduUserConnectionData1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PduUserConnectionData1.Location = New System.Drawing.Point(13, 10)
        Me.PduUserConnectionData1.MaximumSize = New System.Drawing.Size(340, 165)
        Me.PduUserConnectionData1.MinimumSize = New System.Drawing.Size(340, 165)
        Me.PduUserConnectionData1.Name = "PduUserConnectionData1"
        Me.PduUserConnectionData1.Size = New System.Drawing.Size(340, 165)
        Me.PduUserConnectionData1.TabIndex = 181
        '
        'PduSensorsSetting1
        '
        Me.PduSensorsSetting1.Enabled = False
        Me.PduSensorsSetting1.Location = New System.Drawing.Point(-4, 1)
        Me.PduSensorsSetting1.Name = "PduSensorsSetting1"
        Me.PduSensorsSetting1.Size = New System.Drawing.Size(531, 317)
        Me.PduSensorsSetting1.TabIndex = 0
        '
        'PduGeneralSetting1
        '
        Me.PduGeneralSetting1.Enabled = False
        Me.PduGeneralSetting1.Location = New System.Drawing.Point(5, 5)
        Me.PduGeneralSetting1.Name = "PduGeneralSetting1"
        Me.PduGeneralSetting1.Size = New System.Drawing.Size(786, 519)
        Me.PduGeneralSetting1.TabIndex = 110
        '
        'PDUConfigPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SoftReset)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.PDUTab)
        Me.Controls.Add(Me.ConStatus)
        Me.Controls.Add(Me.Label9)
        Me.MinimumSize = New System.Drawing.Size(950, 681)
        Me.Name = "PDUConfigPage"
        Me.Size = New System.Drawing.Size(950, 681)
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GenSetTabPage.ResumeLayout(False)
        Me.PDUConfigTab.ResumeLayout(False)
        Me.SensorsGroupBox.ResumeLayout(False)
        Me.InfoGroupBox.ResumeLayout(False)
        Me.InfoGroupBox.PerformLayout()
        Me.PDUTab.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As Label
    Friend WithEvents ConStatus As Label
    Friend WithEvents Logo As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MonitoringConfigTab As TabPage
    Friend WithEvents GenSetTabPage As TabPage
    Friend WithEvents PDUConfigTab As TabPage
    Friend WithEvents PDUTab As TabControl
    Friend WithEvents SensorsGroupBox As GroupBox
    Friend WithEvents PduSensorsSetting1 As PDUSensorsSetting
    Friend WithEvents InfoGroupBox As GroupBox
    Friend WithEvents PartNumberBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents SoftVersionBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents MacAddrBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents partNum As Label
    Friend WithEvents Mac As Label
    Friend WithEvents SoftVer As Label
    Public WithEvents PduUserConnectionData1 As PDUUserConnectionData
    Friend WithEvents SaveButton As Button
    Friend WithEvents SoftReset As Button
    Friend WithEvents PduGeneralSetting1 As PDUGeneralSetting
End Class
