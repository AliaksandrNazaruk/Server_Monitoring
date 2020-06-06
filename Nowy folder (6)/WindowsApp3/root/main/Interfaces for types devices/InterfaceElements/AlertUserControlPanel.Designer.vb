<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlertUserControlPanel
    Inherits System.Windows.Forms.UserControl
    Sub New(input As Integer)

        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()

        ' Добавить код инициализации после вызова InitializeComponent().
        If input <> 4 Then
            Me.PhaseNum.Text = input.ToString
            Me.AmpNum.Text = ""
            Me.MinTextBox.Visible = False
            Me.WarnTextBox.Visible = False
            Me.MaxTextBox.Visible = False
            AlarmCheckBox.Visible = False
        Else
            Me.PhaseName.Text = "Temperature"
            Me.PhaseNum.Text = ""
            Me.AmpNum.Text = ""
            Me.WarnTextBox.Visible = False
            Me.MaxTextBox.Visible = False
            AlarmCheckBox.Visible = False
        End If

    End Sub

    Sub New(PhaseNum As String, AmpNum As String)
        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()

        ' Добавить код инициализации после вызова InitializeComponent().
        Me.PhaseNum.Text = PhaseNum
        Me.AmpNum.Text = " - " + AmpNum
    End Sub

    Sub New()

        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()

        ' Добавить код инициализации после вызова InitializeComponent().

    End Sub

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
        Me.MaxTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.WarnTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.MinTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.PhaseName = New System.Windows.Forms.Label()
        Me.EmailCheckBox = New System.Windows.Forms.CheckBox()
        Me.SyslogCheckBox = New System.Windows.Forms.CheckBox()
        Me.TrapCheckBox = New System.Windows.Forms.CheckBox()
        Me.LogCheckBox = New System.Windows.Forms.CheckBox()
        Me.AlarmCheckBox = New System.Windows.Forms.CheckBox()
        Me.PhaseNum = New System.Windows.Forms.Label()
        Me.AmpNum = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MaxTextBox
        '
        Me.MaxTextBox.Location = New System.Drawing.Point(285, 6)
        Me.MaxTextBox.Name = "MaxTextBox"
        Me.MaxTextBox.Size = New System.Drawing.Size(70, 22)
        Me.MaxTextBox.TabIndex = 2
        Me.MaxTextBox.Text = "0.1"
        '
        'WarnTextBox
        '
        Me.WarnTextBox.Location = New System.Drawing.Point(185, 6)
        Me.WarnTextBox.Name = "WarnTextBox"
        Me.WarnTextBox.Size = New System.Drawing.Size(70, 22)
        Me.WarnTextBox.TabIndex = 3
        Me.WarnTextBox.Text = "0.1"
        '
        'MinTextBox
        '
        Me.MinTextBox.Location = New System.Drawing.Point(85, 6)
        Me.MinTextBox.Name = "MinTextBox"
        Me.MinTextBox.Size = New System.Drawing.Size(70, 22)
        Me.MinTextBox.TabIndex = 4
        Me.MinTextBox.Text = "0.1"
        '
        'PhaseName
        '
        Me.PhaseName.AutoSize = True
        Me.PhaseName.Location = New System.Drawing.Point(-2, 11)
        Me.PhaseName.Name = "PhaseName"
        Me.PhaseName.Size = New System.Drawing.Size(37, 13)
        Me.PhaseName.TabIndex = 5
        Me.PhaseName.Text = "Phase"
        '
        'EmailCheckBox
        '
        Me.EmailCheckBox.AutoSize = True
        Me.EmailCheckBox.Location = New System.Drawing.Point(391, 10)
        Me.EmailCheckBox.Name = "EmailCheckBox"
        Me.EmailCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.EmailCheckBox.TabIndex = 6
        Me.EmailCheckBox.UseVisualStyleBackColor = True
        '
        'SyslogCheckBox
        '
        Me.SyslogCheckBox.AutoSize = True
        Me.SyslogCheckBox.Location = New System.Drawing.Point(446, 10)
        Me.SyslogCheckBox.Name = "SyslogCheckBox"
        Me.SyslogCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.SyslogCheckBox.TabIndex = 7
        Me.SyslogCheckBox.UseVisualStyleBackColor = True
        '
        'TrapCheckBox
        '
        Me.TrapCheckBox.AutoSize = True
        Me.TrapCheckBox.Location = New System.Drawing.Point(556, 11)
        Me.TrapCheckBox.Name = "TrapCheckBox"
        Me.TrapCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.TrapCheckBox.TabIndex = 9
        Me.TrapCheckBox.UseVisualStyleBackColor = True
        '
        'LogCheckBox
        '
        Me.LogCheckBox.AutoSize = True
        Me.LogCheckBox.Location = New System.Drawing.Point(501, 11)
        Me.LogCheckBox.Name = "LogCheckBox"
        Me.LogCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.LogCheckBox.TabIndex = 8
        Me.LogCheckBox.UseVisualStyleBackColor = True
        '
        'AlarmCheckBox
        '
        Me.AlarmCheckBox.AutoSize = True
        Me.AlarmCheckBox.Location = New System.Drawing.Point(611, 11)
        Me.AlarmCheckBox.Name = "AlarmCheckBox"
        Me.AlarmCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.AlarmCheckBox.TabIndex = 10
        Me.AlarmCheckBox.UseVisualStyleBackColor = True
        '
        'PhaseNum
        '
        Me.PhaseNum.AutoSize = True
        Me.PhaseNum.Location = New System.Drawing.Point(33, 11)
        Me.PhaseNum.Name = "PhaseNum"
        Me.PhaseNum.Size = New System.Drawing.Size(13, 13)
        Me.PhaseNum.TabIndex = 11
        Me.PhaseNum.Text = "0"
        '
        'AmpNum
        '
        Me.AmpNum.AutoSize = True
        Me.AmpNum.Location = New System.Drawing.Point(44, 11)
        Me.AmpNum.Name = "AmpNum"
        Me.AmpNum.Size = New System.Drawing.Size(29, 13)
        Me.AmpNum.TabIndex = 13
        Me.AmpNum.Text = "-  A0"
        '
        'AlertUserControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AmpNum)
        Me.Controls.Add(Me.PhaseNum)
        Me.Controls.Add(Me.AlarmCheckBox)
        Me.Controls.Add(Me.TrapCheckBox)
        Me.Controls.Add(Me.LogCheckBox)
        Me.Controls.Add(Me.SyslogCheckBox)
        Me.Controls.Add(Me.EmailCheckBox)
        Me.Controls.Add(Me.PhaseName)
        Me.Controls.Add(Me.MinTextBox)
        Me.Controls.Add(Me.WarnTextBox)
        Me.Controls.Add(Me.MaxTextBox)
        Me.Name = "AlertUserControlPanel"
        Me.Size = New System.Drawing.Size(627, 35)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaxTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents WarnTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MinTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PhaseName As Label
    Friend WithEvents EmailCheckBox As CheckBox
    Friend WithEvents SyslogCheckBox As CheckBox
    Friend WithEvents TrapCheckBox As CheckBox
    Friend WithEvents LogCheckBox As CheckBox
    Friend WithEvents AlarmCheckBox As CheckBox
    Friend WithEvents PhaseNum As Label
    Friend WithEvents AmpNum As Label
End Class
