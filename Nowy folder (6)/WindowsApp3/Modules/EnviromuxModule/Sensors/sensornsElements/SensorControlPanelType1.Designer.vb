<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SensorControlPanelType1
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
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.AddToMonitoring = New System.Windows.Forms.CheckBox()
        Me.Scale1 = New WindowsApp3.Scale()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.AddToMonitoring)
        Me.GroupBox.Controls.Add(Me.Scale1)
        Me.GroupBox.Location = New System.Drawing.Point(5, 0)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(842, 123)
        Me.GroupBox.TabIndex = 160
        Me.GroupBox.TabStop = False
        '
        'AddToMonitoring
        '
        Me.AddToMonitoring.AutoSize = True
        Me.AddToMonitoring.Location = New System.Drawing.Point(723, 94)
        Me.AddToMonitoring.Name = "AddToMonitoring"
        Me.AddToMonitoring.Size = New System.Drawing.Size(108, 17)
        Me.AddToMonitoring.TabIndex = 1
        Me.AddToMonitoring.Text = "Add to monitoring"
        Me.AddToMonitoring.UseVisualStyleBackColor = True
        '
        'Scale1
        '
        Me.Scale1.Location = New System.Drawing.Point(6, 18)
        Me.Scale1.Name = "Scale1"
        Me.Scale1.Size = New System.Drawing.Size(830, 104)
        Me.Scale1.TabIndex = 2
        '
        'SensorControlPanelType1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox)
        Me.Name = "SensorControlPanelType1"
        Me.Size = New System.Drawing.Size(850, 127)
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents AddToMonitoring As CheckBox
    Friend WithEvents Scale1 As Scale
End Class
