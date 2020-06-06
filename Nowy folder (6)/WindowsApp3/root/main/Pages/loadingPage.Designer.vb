<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loadingPage
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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TextMessage = New System.Windows.Forms.Label()
        Me.MetroProgressSpinner1 = New MetroFramework.Controls.MetroProgressSpinner()
        Me.SpinerLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(281, 325)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(388, 24)
        Me.ProgressBar1.TabIndex = 0
        '
        'TextMessage
        '
        Me.TextMessage.AutoSize = True
        Me.TextMessage.Location = New System.Drawing.Point(279, 309)
        Me.TextMessage.Name = "TextMessage"
        Me.TextMessage.Size = New System.Drawing.Size(76, 13)
        Me.TextMessage.TabIndex = 2
        Me.TextMessage.Text = "Save changes"
        '
        'MetroProgressSpinner1
        '
        Me.MetroProgressSpinner1.CustomBackground = True
        Me.MetroProgressSpinner1.Location = New System.Drawing.Point(425, 290)
        Me.MetroProgressSpinner1.Maximum = 100
        Me.MetroProgressSpinner1.Name = "MetroProgressSpinner1"
        Me.MetroProgressSpinner1.Size = New System.Drawing.Size(100, 100)
        Me.MetroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroProgressSpinner1.TabIndex = 3
        Me.MetroProgressSpinner1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroProgressSpinner1.Value = 15
        Me.MetroProgressSpinner1.Visible = False
        '
        'SpinerLabel
        '
        Me.SpinerLabel.AutoSize = True
        Me.SpinerLabel.Location = New System.Drawing.Point(438, 393)
        Me.SpinerLabel.Name = "SpinerLabel"
        Me.SpinerLabel.Size = New System.Drawing.Size(82, 13)
        Me.SpinerLabel.TabIndex = 4
        Me.SpinerLabel.Text = "wait for restart..."
        Me.SpinerLabel.Visible = False
        '
        'loadingPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SpinerLabel)
        Me.Controls.Add(Me.MetroProgressSpinner1)
        Me.Controls.Add(Me.TextMessage)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "loadingPage"
        Me.Size = New System.Drawing.Size(950, 681)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TextMessage As Label
    Friend WithEvents MetroProgressSpinner1 As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents SpinerLabel As Label
End Class
