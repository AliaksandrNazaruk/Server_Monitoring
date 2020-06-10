<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Workspace
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Workspace))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Ids = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IPs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Logins = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDevice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Passwords = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Log = New System.Windows.Forms.PictureBox()
        Me.NetworkConfig = New System.Windows.Forms.PictureBox()
        Me.AllertConfig = New System.Windows.Forms.PictureBox()
        Me.SensorConfig = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ExitButton = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.LoadingPage1 = New WindowsApp3.loadingPage()
        Me.Log1 = New WindowsApp3.LOGPage()
        Me.AllertConfig1 = New WindowsApp3.AlertConfigPage()
        Me.UserConfig1 = New WindowsApp3.UserConfigPage()
        Me.InfoPanel1 = New WindowsApp3.InfoPanel()
        Me.SensorsConfig1 = New WindowsApp3.SensorsConfigPage()
        Me._Listwa1 = New WindowsApp3.PDUConfigPage()
        Me._Listwa2 = New WindowsApp3.PDUConfigPage()
        Me.MonitoringPage = New WindowsApp3.MonitoringPage()
        Me.LoadingAnimation1 = New WindowsApp3.LoadingAnimation()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Log, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NetworkConfig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllertConfig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SensorConfig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ids, Me.IPs, Me.Logins, Me.TypeDevice, Me.Passwords})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(1618, 156)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(562, 281)
        Me.DataGridView1.TabIndex = 13
        '
        'Ids
        '
        Me.Ids.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Ids.HeaderText = "Ids"
        Me.Ids.Name = "Ids"
        '
        'IPs
        '
        Me.IPs.HeaderText = "IPs"
        Me.IPs.Name = "IPs"
        '
        'Logins
        '
        Me.Logins.HeaderText = "Logins"
        Me.Logins.Name = "Logins"
        '
        'TypeDevice
        '
        Me.TypeDevice.HeaderText = "TypeDevice"
        Me.TypeDevice.Name = "TypeDevice"
        '
        'Passwords
        '
        Me.Passwords.HeaderText = "Passwords"
        Me.Passwords.Name = "Passwords"
        '
        'PictureBox11
        '
        Me.PictureBox11.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.PictureBox11.Location = New System.Drawing.Point(-9, 780)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(1537, 5)
        Me.PictureBox11.TabIndex = 29
        Me.PictureBox11.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.PictureBox7.Location = New System.Drawing.Point(1224, -1)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(10, 784)
        Me.PictureBox7.TabIndex = 38
        Me.PictureBox7.TabStop = False
        '
        'Log
        '
        Me.Log.Image = Global.WindowsApp3.My.Resources.Resources.LOG_black_
        Me.Log.Location = New System.Drawing.Point(4, 395)
        Me.Log.Name = "Log"
        Me.Log.Size = New System.Drawing.Size(264, 42)
        Me.Log.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Log.TabIndex = 27
        Me.Log.TabStop = False
        '
        'NetworkConfig
        '
        Me.NetworkConfig.Image = Global.WindowsApp3.My.Resources.Resources.NC_black_
        Me.NetworkConfig.Location = New System.Drawing.Point(4, 347)
        Me.NetworkConfig.Name = "NetworkConfig"
        Me.NetworkConfig.Size = New System.Drawing.Size(264, 42)
        Me.NetworkConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.NetworkConfig.TabIndex = 26
        Me.NetworkConfig.TabStop = False
        '
        'AllertConfig
        '
        Me.AllertConfig.Image = Global.WindowsApp3.My.Resources.Resources.AC_black_
        Me.AllertConfig.Location = New System.Drawing.Point(4, 299)
        Me.AllertConfig.Name = "AllertConfig"
        Me.AllertConfig.Size = New System.Drawing.Size(264, 42)
        Me.AllertConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.AllertConfig.TabIndex = 25
        Me.AllertConfig.TabStop = False
        '
        'SensorConfig
        '
        Me.SensorConfig.Image = Global.WindowsApp3.My.Resources.Resources.SC_black_
        Me.SensorConfig.Location = New System.Drawing.Point(4, 251)
        Me.SensorConfig.Name = "SensorConfig"
        Me.SensorConfig.Size = New System.Drawing.Size(264, 42)
        Me.SensorConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.SensorConfig.TabIndex = 24
        Me.SensorConfig.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.WindowsApp3.My.Resources.Resources.PDUBC_black_
        Me.PictureBox6.Location = New System.Drawing.Point(4, 203)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(264, 42)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox6.TabIndex = 23
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.WindowsApp3.My.Resources.Resources.PDUAC_black_
        Me.PictureBox5.Location = New System.Drawing.Point(4, 155)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(264, 42)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 22
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApp3.My.Resources.Resources.MO_black_
        Me.PictureBox2.Location = New System.Drawing.Point(4, 107)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(264, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp3.My.Resources.Resources.bitmapMaxbert2
        Me.PictureBox1.Location = New System.Drawing.Point(25, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(227, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.Image = Global.WindowsApp3.My.Resources.Resources.EXIT1
        Me.ExitButton.Location = New System.Drawing.Point(1177, 1)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(47, 22)
        Me.ExitButton.TabIndex = 16
        Me.ExitButton.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(4, 1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1220, 91)
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.PictureBox4.Location = New System.Drawing.Point(2, 98)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1232, 681)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 20
        Me.PictureBox4.TabStop = False
        '
        'LoadingPage1
        '
        Me.LoadingPage1.BackColor = System.Drawing.Color.White
        Me.LoadingPage1.Location = New System.Drawing.Point(274, 98)
        Me.LoadingPage1.Name = "LoadingPage1"
        Me.LoadingPage1.Size = New System.Drawing.Size(950, 684)
        Me.LoadingPage1.TabIndex = 42
        Me.LoadingPage1.Visible = False
        '
        'Log1
        '
        Me.Log1.BackColor = System.Drawing.Color.White
        Me.Log1.Location = New System.Drawing.Point(274, 98)
        Me.Log1.Name = "Log1"
        Me.Log1.Size = New System.Drawing.Size(950, 681)
        Me.Log1.TabIndex = 41
        '
        'AllertConfig1
        '
        Me.AllertConfig1.BackColor = System.Drawing.Color.White
        Me.AllertConfig1.Location = New System.Drawing.Point(274, 98)
        Me.AllertConfig1.Name = "AllertConfig1"
        Me.AllertConfig1.Size = New System.Drawing.Size(950, 681)
        Me.AllertConfig1.TabIndex = 40
        '
        'UserConfig1
        '
        Me.UserConfig1.BackColor = System.Drawing.Color.White
        Me.UserConfig1.Location = New System.Drawing.Point(274, 98)
        Me.UserConfig1.Name = "UserConfig1"
        Me.UserConfig1.Size = New System.Drawing.Size(950, 681)
        Me.UserConfig1.TabIndex = 39
        '
        'InfoPanel1
        '
        Me.InfoPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoPanel1.BackColor = System.Drawing.Color.Black
        Me.InfoPanel1.Location = New System.Drawing.Point(875, 8)
        Me.InfoPanel1.Name = "InfoPanel1"
        Me.InfoPanel1.Size = New System.Drawing.Size(290, 82)
        Me.InfoPanel1.TabIndex = 37
        '
        'SensorsConfig1
        '
        Me.SensorsConfig1.BackColor = System.Drawing.Color.White
        Me.SensorsConfig1.Location = New System.Drawing.Point(274, 98)
        Me.SensorsConfig1.MinimumSize = New System.Drawing.Size(950, 681)
        Me.SensorsConfig1.Name = "SensorsConfig1"
        Me.SensorsConfig1.Size = New System.Drawing.Size(950, 681)
        Me.SensorsConfig1.TabIndex = 36
        '
        '_Listwa1
        '
        Me._Listwa1.BackColor = System.Drawing.Color.White
        Me._Listwa1.Location = New System.Drawing.Point(274, 98)
        Me._Listwa1.MinimumSize = New System.Drawing.Size(950, 681)
        Me._Listwa1.Name = "_Listwa1"
        Me._Listwa1.Size = New System.Drawing.Size(950, 681)
        Me._Listwa1.TabIndex = 34
        '
        '_Listwa2
        '
        Me._Listwa2.BackColor = System.Drawing.Color.White
        Me._Listwa2.Location = New System.Drawing.Point(274, 98)
        Me._Listwa2.MinimumSize = New System.Drawing.Size(950, 681)
        Me._Listwa2.Name = "_Listwa2"
        Me._Listwa2.Size = New System.Drawing.Size(950, 681)
        Me._Listwa2.TabIndex = 35
        '
        'MonitoringPage
        '
        Me.MonitoringPage.AutoScroll = True
        Me.MonitoringPage.BackColor = System.Drawing.Color.White
        Me.MonitoringPage.Location = New System.Drawing.Point(274, 98)
        Me.MonitoringPage.MaximumSize = New System.Drawing.Size(950, 861)
        Me.MonitoringPage.MinimumSize = New System.Drawing.Size(950, 861)
        Me.MonitoringPage.Name = "MonitoringPage"
        Me.MonitoringPage.Size = New System.Drawing.Size(950, 861)
        Me.MonitoringPage.TabIndex = 28
        Me.MonitoringPage.Visible = False
        '
        'LoadingAnimation1
        '
        Me.LoadingAnimation1.BackColor = System.Drawing.Color.White
        Me.LoadingAnimation1.Location = New System.Drawing.Point(274, 99)
        Me.LoadingAnimation1.Name = "LoadingAnimation1"
        Me.LoadingAnimation1.Size = New System.Drawing.Size(950, 681)
        Me.LoadingAnimation1.TabIndex = 32
        '
        'Workspace
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1230, 785)
        Me.Controls.Add(Me.LoadingPage1)
        Me.Controls.Add(Me.Log1)
        Me.Controls.Add(Me.AllertConfig1)
        Me.Controls.Add(Me.UserConfig1)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.InfoPanel1)
        Me.Controls.Add(Me.SensorsConfig1)
        Me.Controls.Add(Me._Listwa1)
        Me.Controls.Add(Me._Listwa2)
        Me.Controls.Add(Me.MonitoringPage)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Log)
        Me.Controls.Add(Me.NetworkConfig)
        Me.Controls.Add(Me.AllertConfig)
        Me.Controls.Add(Me.SensorConfig)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.LoadingAnimation1)
        Me.Controls.Add(Me.PictureBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1230, 500)
        Me.Name = "Workspace"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 0, 0)
        Me.Text = "Monitoring"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Log, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NetworkConfig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllertConfig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SensorConfig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ExitButton As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents SensorConfig As PictureBox
    Friend WithEvents AllertConfig As PictureBox
    Friend WithEvents NetworkConfig As PictureBox
    Friend WithEvents Log As PictureBox
    Friend WithEvents MonitoringPage As MonitoringPage
    Friend WithEvents Ids As DataGridViewTextBoxColumn
    Friend WithEvents IPs As DataGridViewTextBoxColumn
    Friend WithEvents Logins As DataGridViewTextBoxColumn
    Friend WithEvents TypeDevice As DataGridViewTextBoxColumn
    Friend WithEvents Passwords As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents LoadingAnimation1 As LoadingAnimation
    Friend WithEvents _Listwa1 As PDUConfigPage
    Friend WithEvents _Listwa2 As PDUConfigPage
    Friend WithEvents SensorsConfig1 As SensorsConfigPage
    Friend WithEvents InfoPanel1 As InfoPanel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents UserConfig1 As UserConfigPage
    Friend WithEvents AllertConfig1 As AlertConfigPage
    Friend WithEvents Log1 As LOGPage
    Friend WithEvents LoadingPage1 As loadingPage
End Class
