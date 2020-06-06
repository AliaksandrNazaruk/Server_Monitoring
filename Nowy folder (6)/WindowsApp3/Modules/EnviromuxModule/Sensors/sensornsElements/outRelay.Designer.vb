<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class outRelay
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SetOutput = New System.Windows.Forms.ComboBox()
        Me.Status = New System.Windows.Forms.TextBox()
        Me.AddToMonitorint1 = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Description = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(478, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 31)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Apply Changes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SetOutput
        '
        Me.SetOutput.FormattingEnabled = True
        Me.SetOutput.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.SetOutput.Location = New System.Drawing.Point(349, 12)
        Me.SetOutput.Name = "SetOutput"
        Me.SetOutput.Size = New System.Drawing.Size(121, 21)
        Me.SetOutput.TabIndex = 7
        '
        'Status
        '
        Me.Status.Location = New System.Drawing.Point(206, 12)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(134, 20)
        Me.Status.TabIndex = 9
        '
        'AddToMonitorint1
        '
        Me.AddToMonitorint1.AutoSize = True
        Me.AddToMonitorint1.Location = New System.Drawing.Point(129, 38)
        Me.AddToMonitorint1.Name = "AddToMonitorint1"
        Me.AddToMonitorint1.Size = New System.Drawing.Size(15, 14)
        Me.AddToMonitorint1.TabIndex = 138
        Me.AddToMonitorint1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 13)
        Me.Label11.TabIndex = 137
        Me.Label11.Text = "Add to monitoring page"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AddToMonitorint1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Description)
        Me.GroupBox1.Controls.Add(Me.SetOutput)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Status)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(579, 59)
        Me.GroupBox1.TabIndex = 139
        Me.GroupBox1.TabStop = False
        '
        'Description
        '
        Me.Description.Location = New System.Drawing.Point(11, 12)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(186, 20)
        Me.Description.TabIndex = 8
        '
        'outRelay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "outRelay"
        Me.Size = New System.Drawing.Size(588, 64)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents SetOutput As ComboBox
    Friend WithEvents Status As TextBox
    Friend WithEvents AddToMonitorint1 As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Description As TextBox
End Class
