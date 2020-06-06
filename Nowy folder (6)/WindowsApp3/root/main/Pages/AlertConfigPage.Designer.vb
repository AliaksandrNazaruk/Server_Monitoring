<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AlertConfigPage
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AllertMessageSwitch = New MetroFramework.Controls.MetroToggle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SendMessageToEmailSwitch = New MetroFramework.Controls.MetroToggle()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AnimatedAlertSwitch = New MetroFramework.Controls.MetroToggle()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SoundAlertSwitch = New MetroFramework.Controls.MetroToggle()
        Me.TestModeSwitch = New MetroFramework.Controls.MetroToggle()
        Me.TestMode = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.PDUATabPage = New System.Windows.Forms.TabPage()
        Me.PDUAAlertTable = New WindowsApp3.AlertTable()
        Me.PDUBTabPage = New System.Windows.Forms.TabPage()
        Me.PDUBAlertTable = New WindowsApp3.AlertTable()
        Me.SensorsTabPage = New System.Windows.Forms.TabPage()
        Me.SaveButton = New MetroFramework.Controls.MetroButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ResendTime = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.PDUATabPage.SuspendLayout()
        Me.PDUBTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(247, 25)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "ALERT CONFIGURATION"
        '
        'AllertMessageSwitch
        '
        Me.AllertMessageSwitch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AllertMessageSwitch.AutoSize = True
        Me.AllertMessageSwitch.Location = New System.Drawing.Point(150, 96)
        Me.AllertMessageSwitch.Name = "AllertMessageSwitch"
        Me.AllertMessageSwitch.Size = New System.Drawing.Size(80, 17)
        Me.AllertMessageSwitch.Style = MetroFramework.MetroColorStyle.Red
        Me.AllertMessageSwitch.TabIndex = 65
        Me.AllertMessageSwitch.Text = "Off"
        Me.AllertMessageSwitch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Show alert message window"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Send alert message"
        '
        'SendMessageToEmailSwitch
        '
        Me.SendMessageToEmailSwitch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SendMessageToEmailSwitch.AutoSize = True
        Me.SendMessageToEmailSwitch.Location = New System.Drawing.Point(150, 211)
        Me.SendMessageToEmailSwitch.Name = "SendMessageToEmailSwitch"
        Me.SendMessageToEmailSwitch.Size = New System.Drawing.Size(80, 17)
        Me.SendMessageToEmailSwitch.Style = MetroFramework.MetroColorStyle.Red
        Me.SendMessageToEmailSwitch.TabIndex = 67
        Me.SendMessageToEmailSwitch.Text = "Off"
        Me.SendMessageToEmailSwitch.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Animated status display"
        '
        'AnimatedAlertSwitch
        '
        Me.AnimatedAlertSwitch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AnimatedAlertSwitch.AutoSize = True
        Me.AnimatedAlertSwitch.Location = New System.Drawing.Point(150, 135)
        Me.AnimatedAlertSwitch.Name = "AnimatedAlertSwitch"
        Me.AnimatedAlertSwitch.Size = New System.Drawing.Size(80, 17)
        Me.AnimatedAlertSwitch.Style = MetroFramework.MetroColorStyle.Red
        Me.AnimatedAlertSwitch.TabIndex = 69
        Me.AnimatedAlertSwitch.Text = "Off"
        Me.AnimatedAlertSwitch.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Location = New System.Drawing.Point(86, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Sound alert"
        '
        'SoundAlertSwitch
        '
        Me.SoundAlertSwitch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SoundAlertSwitch.AutoSize = True
        Me.SoundAlertSwitch.Enabled = False
        Me.SoundAlertSwitch.Location = New System.Drawing.Point(150, 173)
        Me.SoundAlertSwitch.Name = "SoundAlertSwitch"
        Me.SoundAlertSwitch.Size = New System.Drawing.Size(80, 17)
        Me.SoundAlertSwitch.Style = MetroFramework.MetroColorStyle.Red
        Me.SoundAlertSwitch.TabIndex = 73
        Me.SoundAlertSwitch.Text = "Off"
        Me.SoundAlertSwitch.UseVisualStyleBackColor = True
        '
        'TestModeSwitch
        '
        Me.TestModeSwitch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TestModeSwitch.AutoSize = True
        Me.TestModeSwitch.Enabled = False
        Me.TestModeSwitch.Location = New System.Drawing.Point(150, 598)
        Me.TestModeSwitch.Name = "TestModeSwitch"
        Me.TestModeSwitch.Size = New System.Drawing.Size(80, 17)
        Me.TestModeSwitch.Style = MetroFramework.MetroColorStyle.Red
        Me.TestModeSwitch.TabIndex = 85
        Me.TestModeSwitch.Text = "Off"
        Me.TestModeSwitch.UseVisualStyleBackColor = True
        '
        'TestMode
        '
        Me.TestMode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TestMode.AutoSize = True
        Me.TestMode.Enabled = False
        Me.TestMode.Location = New System.Drawing.Point(90, 600)
        Me.TestMode.Name = "TestMode"
        Me.TestMode.Size = New System.Drawing.Size(57, 13)
        Me.TestMode.TabIndex = 86
        Me.TestMode.Text = "Test mode"
        '
        'Timer1
        '
        Me.Timer1.Interval = 600000
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TabControl1.Controls.Add(Me.PDUATabPage)
        Me.TabControl1.Controls.Add(Me.PDUBTabPage)
        Me.TabControl1.Controls.Add(Me.SensorsTabPage)
        Me.TabControl1.Location = New System.Drawing.Point(246, 68)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(686, 551)
        Me.TabControl1.TabIndex = 126
        '
        'PDUATabPage
        '
        Me.PDUATabPage.Controls.Add(Me.PDUAAlertTable)
        Me.PDUATabPage.Location = New System.Drawing.Point(4, 22)
        Me.PDUATabPage.Name = "PDUATabPage"
        Me.PDUATabPage.Size = New System.Drawing.Size(678, 525)
        Me.PDUATabPage.TabIndex = 0
        Me.PDUATabPage.Text = "PDUA"
        Me.PDUATabPage.UseVisualStyleBackColor = True
        '
        'PDUAAlertTable
        '
        Me.PDUAAlertTable.Enabled = False
        Me.PDUAAlertTable.Location = New System.Drawing.Point(7, 15)
        Me.PDUAAlertTable.Name = "PDUAAlertTable"
        Me.PDUAAlertTable.Size = New System.Drawing.Size(657, 439)
        Me.PDUAAlertTable.TabIndex = 0
        '
        'PDUBTabPage
        '
        Me.PDUBTabPage.Controls.Add(Me.PDUBAlertTable)
        Me.PDUBTabPage.Location = New System.Drawing.Point(4, 22)
        Me.PDUBTabPage.Name = "PDUBTabPage"
        Me.PDUBTabPage.Size = New System.Drawing.Size(678, 525)
        Me.PDUBTabPage.TabIndex = 1
        Me.PDUBTabPage.Text = "PDUB"
        Me.PDUBTabPage.UseVisualStyleBackColor = True
        '
        'PDUBAlertTable
        '
        Me.PDUBAlertTable.Enabled = False
        Me.PDUBAlertTable.Location = New System.Drawing.Point(7, 15)
        Me.PDUBAlertTable.Name = "PDUBAlertTable"
        Me.PDUBAlertTable.Size = New System.Drawing.Size(657, 432)
        Me.PDUBAlertTable.TabIndex = 1
        '
        'SensorsTabPage
        '
        Me.SensorsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.SensorsTabPage.Name = "SensorsTabPage"
        Me.SensorsTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.SensorsTabPage.Size = New System.Drawing.Size(678, 525)
        Me.SensorsTabPage.TabIndex = 2
        Me.SensorsTabPage.Text = "Sensors"
        Me.SensorsTabPage.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SaveButton.Location = New System.Drawing.Point(818, 630)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(114, 32)
        Me.SaveButton.TabIndex = 128
        Me.SaveButton.Text = "Save"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(104, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "to email"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(9, 254)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox1.Size = New System.Drawing.Size(115, 17)
        Me.CheckBox1.TabIndex = 130
        Me.CheckBox1.Text = "Resend alerts after"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ResendTime
        '
        Me.ResendTime.Enabled = False
        Me.ResendTime.FormattingEnabled = True
        Me.ResendTime.Items.AddRange(New Object() {"20 seconds", "1 minutes", "5 minutes", "20 minutes", "60 minutes"})
        Me.ResendTime.Location = New System.Drawing.Point(133, 250)
        Me.ResendTime.Name = "ResendTime"
        Me.ResendTime.Size = New System.Drawing.Size(97, 21)
        Me.ResendTime.TabIndex = 131
        '
        'AlertConfigPage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.ResendTime)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TestMode)
        Me.Controls.Add(Me.TestModeSwitch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SoundAlertSwitch)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AnimatedAlertSwitch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SendMessageToEmailSwitch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AllertMessageSwitch)
        Me.Controls.Add(Me.Label3)
        Me.Name = "AlertConfigPage"
        Me.Size = New System.Drawing.Size(950, 681)
        Me.TabControl1.ResumeLayout(False)
        Me.PDUATabPage.ResumeLayout(False)
        Me.PDUBTabPage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents AllertMessageSwitch As MetroFramework.Controls.MetroToggle
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SendMessageToEmailSwitch As MetroFramework.Controls.MetroToggle
    Friend WithEvents Label4 As Label
    Friend WithEvents AnimatedAlertSwitch As MetroFramework.Controls.MetroToggle
    Friend WithEvents Label6 As Label
    Friend WithEvents SoundAlertSwitch As MetroFramework.Controls.MetroToggle
    Friend WithEvents TestModeSwitch As MetroFramework.Controls.MetroToggle
    Friend WithEvents TestMode As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents PDUATabPage As TabPage
    Friend WithEvents PDUBTabPage As TabPage
    Friend WithEvents SensorsTabPage As TabPage
    Friend WithEvents PDUAAlertTable As AlertTable
    Friend WithEvents Label5 As Label
    Friend WithEvents PDUBAlertTable As AlertTable
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ResendTime As ComboBox
    Private WithEvents SaveButton As MetroFramework.Controls.MetroButton
End Class
