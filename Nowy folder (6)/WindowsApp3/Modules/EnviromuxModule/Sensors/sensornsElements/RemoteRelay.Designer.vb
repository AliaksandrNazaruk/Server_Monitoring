<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoteRelay
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
        Me.AddToMonitoring = New System.Windows.Forms.CheckBox()
        Me.Description = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AddToMonitoring)
        Me.GroupBox1.Controls.Add(Me.Description)
        Me.GroupBox1.Controls.Add(Me.Status)
        Me.GroupBox1.Location = New System.Drawing.Point(5, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 40)
        Me.GroupBox1.TabIndex = 96
        Me.GroupBox1.TabStop = False
        '
        'AddToMonitoring
        '
        Me.AddToMonitoring.AutoSize = True
        Me.AddToMonitoring.Location = New System.Drawing.Point(362, 16)
        Me.AddToMonitoring.Name = "AddToMonitoring"
        Me.AddToMonitoring.Size = New System.Drawing.Size(15, 14)
        Me.AddToMonitoring.TabIndex = 94
        Me.AddToMonitoring.UseVisualStyleBackColor = True
        '
        'Description
        '
        Me.Description.AutoSize = True
        Me.Description.Location = New System.Drawing.Point(3, 16)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(35, 13)
        Me.Description.TabIndex = 89
        Me.Description.Text = "Name"
        '
        'Status
        '
        Me.Status.FormattingEnabled = True
        Me.Status.Items.AddRange(New Object() {"active", "inactive"})
        Me.Status.Location = New System.Drawing.Point(140, 12)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(164, 21)
        Me.Status.TabIndex = 90
        '
        'RemoteRelay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "RemoteRelay"
        Me.Size = New System.Drawing.Size(440, 40)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AddToMonitoring As CheckBox
    Friend WithEvents Description As Label
    Friend WithEvents Status As ComboBox
End Class
