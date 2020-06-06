<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scale
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
        Me.value1 = New System.Windows.Forms.Label()
        Me.value3 = New System.Windows.Forms.Label()
        Me.value4 = New System.Windows.Forms.Label()
        Me.value2 = New System.Windows.Forms.Label()
        Me.value5 = New System.Windows.Forms.Label()
        Me.NormalButton = New System.Windows.Forms.PictureBox()
        Me.MinLine = New System.Windows.Forms.PictureBox()
        Me.AlarmButton1 = New System.Windows.Forms.PictureBox()
        Me.WarnButton1 = New System.Windows.Forms.PictureBox()
        Me.AlarmIndicator1 = New System.Windows.Forms.PictureBox()
        Me.WarnIndicaror1 = New System.Windows.Forms.PictureBox()
        Me.MaxLine = New System.Windows.Forms.PictureBox()
        Me.WarnButton2 = New System.Windows.Forms.PictureBox()
        Me.linear = New System.Windows.Forms.PictureBox()
        Me.cursor1 = New System.Windows.Forms.PictureBox()
        Me.NormalIndicator = New System.Windows.Forms.PictureBox()
        Me.WarnIndicator2 = New System.Windows.Forms.PictureBox()
        Me.alarm1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.cursor2 = New System.Windows.Forms.PictureBox()
        Me.maxcrittresh = New System.Windows.Forms.TextBox()
        Me.mincrittresh = New System.Windows.Forms.TextBox()
        Me.maxnoncrittresh = New System.Windows.Forms.TextBox()
        Me.minnoncrittresh = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.NormalButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlarmButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarnButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlarmIndicator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarnIndicaror1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaxLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarnButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.linear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cursor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NormalIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarnIndicator2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alarm1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cursor2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'value1
        '
        Me.value1.AutoSize = True
        Me.value1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.value1.Location = New System.Drawing.Point(340, 45)
        Me.value1.Name = "value1"
        Me.value1.Size = New System.Drawing.Size(27, 16)
        Me.value1.TabIndex = 70
        Me.value1.Text = "0 V"
        '
        'value3
        '
        Me.value3.AutoSize = True
        Me.value3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.value3.Location = New System.Drawing.Point(566, 45)
        Me.value3.Name = "value3"
        Me.value3.Size = New System.Drawing.Size(23, 13)
        Me.value3.TabIndex = 84
        Me.value3.Text = "6 V"
        Me.value3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'value4
        '
        Me.value4.AutoSize = True
        Me.value4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.value4.Location = New System.Drawing.Point(677, 45)
        Me.value4.Name = "value4"
        Me.value4.Size = New System.Drawing.Size(23, 13)
        Me.value4.TabIndex = 85
        Me.value4.Text = "9 V"
        Me.value4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'value2
        '
        Me.value2.AutoSize = True
        Me.value2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.value2.Location = New System.Drawing.Point(455, 44)
        Me.value2.Name = "value2"
        Me.value2.Size = New System.Drawing.Size(23, 13)
        Me.value2.TabIndex = 83
        Me.value2.Text = "3 V"
        '
        'value5
        '
        Me.value5.AutoSize = True
        Me.value5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.value5.Location = New System.Drawing.Point(772, 45)
        Me.value5.Name = "value5"
        Me.value5.Size = New System.Drawing.Size(34, 16)
        Me.value5.TabIndex = 71
        Me.value5.Text = "12 V"
        Me.value5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'NormalButton
        '
        Me.NormalButton.Image = Global.WindowsApp3.My.Resources.Resources.Background1
        Me.NormalButton.Location = New System.Drawing.Point(664, 14)
        Me.NormalButton.Name = "NormalButton"
        Me.NormalButton.Size = New System.Drawing.Size(5, 20)
        Me.NormalButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NormalButton.TabIndex = 87
        Me.NormalButton.TabStop = False
        '
        'MinLine
        '
        Me.MinLine.Image = Global.WindowsApp3.My.Resources.Resources.Background1
        Me.MinLine.Location = New System.Drawing.Point(351, 14)
        Me.MinLine.Name = "MinLine"
        Me.MinLine.Size = New System.Drawing.Size(2, 28)
        Me.MinLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MinLine.TabIndex = 73
        Me.MinLine.TabStop = False
        '
        'AlarmButton1
        '
        Me.AlarmButton1.Image = Global.WindowsApp3.My.Resources.Resources.Background1
        Me.AlarmButton1.Location = New System.Drawing.Point(418, 14)
        Me.AlarmButton1.Name = "AlarmButton1"
        Me.AlarmButton1.Size = New System.Drawing.Size(5, 20)
        Me.AlarmButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AlarmButton1.TabIndex = 69
        Me.AlarmButton1.TabStop = False
        '
        'WarnButton1
        '
        Me.WarnButton1.Image = Global.WindowsApp3.My.Resources.Resources.Background1
        Me.WarnButton1.Location = New System.Drawing.Point(478, 14)
        Me.WarnButton1.Name = "WarnButton1"
        Me.WarnButton1.Size = New System.Drawing.Size(5, 20)
        Me.WarnButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WarnButton1.TabIndex = 68
        Me.WarnButton1.TabStop = False
        '
        'AlarmIndicator1
        '
        Me.AlarmIndicator1.Image = Global.WindowsApp3.My.Resources.Resources.Alarm2
        Me.AlarmIndicator1.Location = New System.Drawing.Point(353, 14)
        Me.AlarmIndicator1.Name = "AlarmIndicator1"
        Me.AlarmIndicator1.Size = New System.Drawing.Size(70, 20)
        Me.AlarmIndicator1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AlarmIndicator1.TabIndex = 67
        Me.AlarmIndicator1.TabStop = False
        '
        'WarnIndicaror1
        '
        Me.WarnIndicaror1.Image = Global.WindowsApp3.My.Resources.Resources.Warn2
        Me.WarnIndicaror1.Location = New System.Drawing.Point(353, 14)
        Me.WarnIndicaror1.Name = "WarnIndicaror1"
        Me.WarnIndicaror1.Size = New System.Drawing.Size(130, 20)
        Me.WarnIndicaror1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WarnIndicaror1.TabIndex = 65
        Me.WarnIndicaror1.TabStop = False
        '
        'MaxLine
        '
        Me.MaxLine.Image = Global.WindowsApp3.My.Resources.Resources.Background1
        Me.MaxLine.Location = New System.Drawing.Point(794, 14)
        Me.MaxLine.Name = "MaxLine"
        Me.MaxLine.Size = New System.Drawing.Size(2, 28)
        Me.MaxLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MaxLine.TabIndex = 77
        Me.MaxLine.TabStop = False
        '
        'WarnButton2
        '
        Me.WarnButton2.Image = Global.WindowsApp3.My.Resources.Resources.Background1
        Me.WarnButton2.Location = New System.Drawing.Point(731, 14)
        Me.WarnButton2.Name = "WarnButton2"
        Me.WarnButton2.Size = New System.Drawing.Size(5, 20)
        Me.WarnButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WarnButton2.TabIndex = 82
        Me.WarnButton2.TabStop = False
        '
        'linear
        '
        Me.linear.Image = Global.WindowsApp3.My.Resources.Resources.UPFOORM
        Me.linear.Location = New System.Drawing.Point(351, 34)
        Me.linear.Name = "linear"
        Me.linear.Size = New System.Drawing.Size(445, 3)
        Me.linear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.linear.TabIndex = 79
        Me.linear.TabStop = False
        '
        'cursor1
        '
        Me.cursor1.BackColor = System.Drawing.Color.White
        Me.cursor1.Image = Global.WindowsApp3.My.Resources.Resources.cursor31
        Me.cursor1.Location = New System.Drawing.Point(347, 36)
        Me.cursor1.Name = "cursor1"
        Me.cursor1.Size = New System.Drawing.Size(10, 8)
        Me.cursor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cursor1.TabIndex = 75
        Me.cursor1.TabStop = False
        '
        'NormalIndicator
        '
        Me.NormalIndicator.Image = Global.WindowsApp3.My.Resources.Resources.Normal2
        Me.NormalIndicator.Location = New System.Drawing.Point(353, 14)
        Me.NormalIndicator.Name = "NormalIndicator"
        Me.NormalIndicator.Size = New System.Drawing.Size(316, 20)
        Me.NormalIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NormalIndicator.TabIndex = 86
        Me.NormalIndicator.TabStop = False
        '
        'WarnIndicator2
        '
        Me.WarnIndicator2.Image = Global.WindowsApp3.My.Resources.Resources.Warn2
        Me.WarnIndicator2.Location = New System.Drawing.Point(351, 14)
        Me.WarnIndicator2.Name = "WarnIndicator2"
        Me.WarnIndicator2.Size = New System.Drawing.Size(385, 20)
        Me.WarnIndicator2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WarnIndicator2.TabIndex = 78
        Me.WarnIndicator2.TabStop = False
        '
        'alarm1
        '
        Me.alarm1.Image = Global.WindowsApp3.My.Resources.Resources.Alarm2
        Me.alarm1.Location = New System.Drawing.Point(351, 14)
        Me.alarm1.Name = "alarm1"
        Me.alarm1.Size = New System.Drawing.Size(445, 20)
        Me.alarm1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alarm1.TabIndex = 66
        Me.alarm1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApp3.My.Resources.Resources.Background1
        Me.PictureBox3.Location = New System.Drawing.Point(687, 14)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(2, 28)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 81
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApp3.My.Resources.Resources.Background1
        Me.PictureBox2.Location = New System.Drawing.Point(463, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(2, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 80
        Me.PictureBox2.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.WindowsApp3.My.Resources.Resources.Background1
        Me.PictureBox8.Location = New System.Drawing.Point(576, 14)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(2, 28)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 72
        Me.PictureBox8.TabStop = False
        '
        'cursor2
        '
        Me.cursor2.BackColor = System.Drawing.Color.White
        Me.cursor2.Image = Global.WindowsApp3.My.Resources.Resources.cursor3_2
        Me.cursor2.Location = New System.Drawing.Point(347, 7)
        Me.cursor2.Name = "cursor2"
        Me.cursor2.Size = New System.Drawing.Size(10, 8)
        Me.cursor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cursor2.TabIndex = 76
        Me.cursor2.TabStop = False
        '
        'maxcrittresh
        '
        Me.maxcrittresh.Location = New System.Drawing.Point(137, 77)
        Me.maxcrittresh.Name = "maxcrittresh"
        Me.maxcrittresh.Size = New System.Drawing.Size(183, 20)
        Me.maxcrittresh.TabIndex = 99
        '
        'mincrittresh
        '
        Me.mincrittresh.Location = New System.Drawing.Point(137, 53)
        Me.mincrittresh.Name = "mincrittresh"
        Me.mincrittresh.Size = New System.Drawing.Size(183, 20)
        Me.mincrittresh.TabIndex = 98
        '
        'maxnoncrittresh
        '
        Me.maxnoncrittresh.Location = New System.Drawing.Point(137, 29)
        Me.maxnoncrittresh.Name = "maxnoncrittresh"
        Me.maxnoncrittresh.Size = New System.Drawing.Size(183, 20)
        Me.maxnoncrittresh.TabIndex = 97
        '
        'minnoncrittresh
        '
        Me.minnoncrittresh.Location = New System.Drawing.Point(137, 5)
        Me.minnoncrittresh.Name = "minnoncrittresh"
        Me.minnoncrittresh.Size = New System.Drawing.Size(183, 20)
        Me.minnoncrittresh.TabIndex = 96
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(28, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 20)
        Me.Label14.TabIndex = 93
        Me.Label14.Text = "Min. Critical Treshold"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(25, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 20)
        Me.Label13.TabIndex = 92
        Me.Label13.Text = "Max. Critical Treshold"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(2, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 20)
        Me.Label12.TabIndex = 91
        Me.Label12.Text = "Max. Non-Critical Treshold"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(5, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 20)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "Min. Non-Critical Treshold"
        '
        'Scale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.maxcrittresh)
        Me.Controls.Add(Me.mincrittresh)
        Me.Controls.Add(Me.maxnoncrittresh)
        Me.Controls.Add(Me.minnoncrittresh)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.NormalButton)
        Me.Controls.Add(Me.MinLine)
        Me.Controls.Add(Me.AlarmButton1)
        Me.Controls.Add(Me.WarnButton1)
        Me.Controls.Add(Me.AlarmIndicator1)
        Me.Controls.Add(Me.WarnIndicaror1)
        Me.Controls.Add(Me.MaxLine)
        Me.Controls.Add(Me.WarnButton2)
        Me.Controls.Add(Me.linear)
        Me.Controls.Add(Me.cursor1)
        Me.Controls.Add(Me.NormalIndicator)
        Me.Controls.Add(Me.WarnIndicator2)
        Me.Controls.Add(Me.value1)
        Me.Controls.Add(Me.value3)
        Me.Controls.Add(Me.value4)
        Me.Controls.Add(Me.value2)
        Me.Controls.Add(Me.alarm1)
        Me.Controls.Add(Me.value5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.cursor2)
        Me.Name = "Scale"
        Me.Size = New System.Drawing.Size(804, 102)
        CType(Me.NormalButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlarmButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarnButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlarmIndicator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarnIndicaror1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaxLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarnButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.linear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cursor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NormalIndicator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarnIndicator2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alarm1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cursor2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NormalButton As PictureBox
    Friend WithEvents MinLine As PictureBox
    Friend WithEvents AlarmButton1 As PictureBox
    Friend WithEvents WarnButton1 As PictureBox
    Friend WithEvents AlarmIndicator1 As PictureBox
    Friend WithEvents WarnIndicaror1 As PictureBox
    Friend WithEvents MaxLine As PictureBox
    Friend WithEvents WarnButton2 As PictureBox
    Friend WithEvents linear As PictureBox
    Friend WithEvents cursor1 As PictureBox
    Friend WithEvents NormalIndicator As PictureBox
    Friend WithEvents WarnIndicator2 As PictureBox
    Friend WithEvents value1 As Label
    Friend WithEvents value3 As Label
    Friend WithEvents value4 As Label
    Friend WithEvents value2 As Label
    Friend WithEvents alarm1 As PictureBox
    Friend WithEvents value5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents cursor2 As PictureBox
    Friend WithEvents maxcrittresh As TextBox
    Friend WithEvents mincrittresh As TextBox
    Friend WithEvents maxnoncrittresh As TextBox
    Friend WithEvents minnoncrittresh As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
End Class
