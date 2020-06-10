<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IntSensorControlPanel
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
        Me.AddToMonitoring = New System.Windows.Forms.CheckBox()
        Me.Scale1 = New WindowsApp3.Scale()
        Me.SensorName = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.ComboBox()
        Me.Type = New System.Windows.Forms.TextBox()
        Me.SensorName.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddToMonitoring
        '
        Me.AddToMonitoring.AutoSize = True
        Me.AddToMonitoring.Location = New System.Drawing.Point(723, 131)
        Me.AddToMonitoring.Name = "AddToMonitoring"
        Me.AddToMonitoring.Size = New System.Drawing.Size(108, 17)
        Me.AddToMonitoring.TabIndex = 1
        Me.AddToMonitoring.Text = "Add to monitoring"
        Me.AddToMonitoring.UseVisualStyleBackColor = True
        '
        'Scale1
        '
        Me.Scale1.Location = New System.Drawing.Point(6, 58)
        Me.Scale1.Name = "Scale1"
        Me.Scale1.Size = New System.Drawing.Size(830, 104)
        Me.Scale1.TabIndex = 2
        '
        'SensorName
        '
        Me.SensorName.Controls.Add(Me.Label2)
        Me.SensorName.Controls.Add(Me.Label1)
        Me.SensorName.Controls.Add(Me.Status)
        Me.SensorName.Controls.Add(Me.Type)
        Me.SensorName.Controls.Add(Me.AddToMonitoring)
        Me.SensorName.Controls.Add(Me.Scale1)
        Me.SensorName.Location = New System.Drawing.Point(3, 3)
        Me.SensorName.Name = "SensorName"
        Me.SensorName.Size = New System.Drawing.Size(842, 166)
        Me.SensorName.TabIndex = 161
        Me.SensorName.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 163
        Me.Label1.Text = "Type:"
        '
        'Status
        '
        Me.Status.FormattingEnabled = True
        Me.Status.Items.AddRange(New Object() {"notconnected", "normal", "prealert", "alert", "acknowledged", "dismissed", "disconnected", "reversed"})
        Me.Status.Location = New System.Drawing.Point(143, 14)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(182, 21)
        Me.Status.TabIndex = 162
        '
        'Type
        '
        Me.Type.Location = New System.Drawing.Point(143, 39)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(182, 20)
        Me.Type.TabIndex = 3
        '
        'IntSensorControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SensorName)
        Me.MaximumSize = New System.Drawing.Size(850, 0)
        Me.Name = "IntSensorControlPanel"
        Me.Size = New System.Drawing.Size(848, 173)
        Me.SensorName.ResumeLayout(False)
        Me.SensorName.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddToMonitoring As CheckBox
    Friend WithEvents Scale1 As Scale
    Friend WithEvents SensorName As GroupBox
    Friend WithEvents Type As TextBox
    Friend WithEvents Status As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
