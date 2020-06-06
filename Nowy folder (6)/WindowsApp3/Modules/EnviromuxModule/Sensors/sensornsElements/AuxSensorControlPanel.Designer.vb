<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuxSensorControlPanel
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.ComboBox()
        Me.Type = New System.Windows.Forms.TextBox()
        Me.AddToMonitoring = New System.Windows.Forms.CheckBox()
        Me.SensorName = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Connector = New System.Windows.Forms.TextBox()
        Me.Scale1 = New WindowsApp3.Scale()
        Me.SensorName.SuspendLayout()
        Me.SuspendLayout()
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
        'AddToMonitoring
        '
        Me.AddToMonitoring.AutoSize = True
        Me.AddToMonitoring.Location = New System.Drawing.Point(699, 159)
        Me.AddToMonitoring.Name = "AddToMonitoring"
        Me.AddToMonitoring.Size = New System.Drawing.Size(108, 17)
        Me.AddToMonitoring.TabIndex = 1
        Me.AddToMonitoring.Text = "Add to monitoring"
        Me.AddToMonitoring.UseVisualStyleBackColor = True
        '
        'SensorName
        '
        Me.SensorName.AutoSize = True
        Me.SensorName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SensorName.Controls.Add(Me.Label3)
        Me.SensorName.Controls.Add(Me.Connector)
        Me.SensorName.Controls.Add(Me.Label2)
        Me.SensorName.Controls.Add(Me.Label1)
        Me.SensorName.Controls.Add(Me.Status)
        Me.SensorName.Controls.Add(Me.Type)
        Me.SensorName.Controls.Add(Me.AddToMonitoring)
        Me.SensorName.Controls.Add(Me.Scale1)
        Me.SensorName.Location = New System.Drawing.Point(3, 3)
        Me.SensorName.Name = "SensorName"
        Me.SensorName.Size = New System.Drawing.Size(821, 205)
        Me.SensorName.TabIndex = 162
        Me.SensorName.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 166
        Me.Label3.Text = "Connector"
        '
        'Connector
        '
        Me.Connector.Location = New System.Drawing.Point(143, 63)
        Me.Connector.Name = "Connector"
        Me.Connector.Size = New System.Drawing.Size(182, 20)
        Me.Connector.TabIndex = 165
        '
        'Scale1
        '
        Me.Scale1.Location = New System.Drawing.Point(5, 82)
        Me.Scale1.Name = "Scale1"
        Me.Scale1.Size = New System.Drawing.Size(810, 104)
        Me.Scale1.TabIndex = 2
        '
        'AuxSensorControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SensorName)
        Me.MaximumSize = New System.Drawing.Size(827, 211)
        Me.MinimumSize = New System.Drawing.Size(827, 211)
        Me.Name = "AuxSensorControlPanel"
        Me.Size = New System.Drawing.Size(827, 211)
        Me.SensorName.ResumeLayout(False)
        Me.SensorName.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Status As ComboBox
    Friend WithEvents Type As TextBox
    Friend WithEvents AddToMonitoring As CheckBox
    Friend WithEvents Scale1 As Scale
    Friend WithEvents SensorName As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Connector As TextBox
End Class
