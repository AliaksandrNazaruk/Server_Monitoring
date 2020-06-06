<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SmokeDetector
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AddToMonitor = New System.Windows.Forms.CheckBox()
        Me.Description = New System.Windows.Forms.Label()
        Me.value = New System.Windows.Forms.TextBox()
        Me.Status = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AddToMonitor)
        Me.GroupBox1.Controls.Add(Me.Description)
        Me.GroupBox1.Controls.Add(Me.value)
        Me.GroupBox1.Controls.Add(Me.Status)
        Me.GroupBox1.Location = New System.Drawing.Point(5, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(557, 40)
        Me.GroupBox1.TabIndex = 96
        Me.GroupBox1.TabStop = False
        '
        'AddToMonitor
        '
        Me.AddToMonitor.AutoSize = True
        Me.AddToMonitor.Location = New System.Drawing.Point(479, 16)
        Me.AddToMonitor.Name = "AddToMonitor"
        Me.AddToMonitor.Size = New System.Drawing.Size(15, 14)
        Me.AddToMonitor.TabIndex = 94
        Me.AddToMonitor.UseVisualStyleBackColor = True
        '
        'Description
        '
        Me.Description.AutoSize = True
        Me.Description.Location = New System.Drawing.Point(7, 16)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(35, 13)
        Me.Description.TabIndex = 89
        Me.Description.Text = "Name"
        '
        'value
        '
        Me.value.Location = New System.Drawing.Point(147, 13)
        Me.value.Name = "value"
        Me.value.ReadOnly = True
        Me.value.Size = New System.Drawing.Size(126, 20)
        Me.value.TabIndex = 92
        '
        'Status
        '
        Me.Status.FormattingEnabled = True
        Me.Status.Items.AddRange(New Object() {"notconnected", "normal", "prealert", "alert", "acknowledged", "dismissed", "disconnected", "reversed"})
        Me.Status.Location = New System.Drawing.Point(284, 13)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(131, 21)
        Me.Status.TabIndex = 90
        '
        'SmokeDetector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SmokeDetector"
        Me.Size = New System.Drawing.Size(568, 40)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AddToMonitor As CheckBox
    Friend WithEvents Description As Label
    Friend WithEvents value As TextBox
    Friend WithEvents Status As ComboBox
End Class
