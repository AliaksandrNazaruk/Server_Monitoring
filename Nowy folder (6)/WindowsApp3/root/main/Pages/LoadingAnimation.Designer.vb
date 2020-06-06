<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingAnimation
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
        Me.MetroProgressSpinner1 = New MetroFramework.Controls.MetroProgressSpinner()
        Me.Status = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MetroProgressSpinner1
        '
        Me.MetroProgressSpinner1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroProgressSpinner1.CausesValidation = False
        Me.MetroProgressSpinner1.CustomBackground = True
        Me.MetroProgressSpinner1.Location = New System.Drawing.Point(221, 88)
        Me.MetroProgressSpinner1.Maximum = 100
        Me.MetroProgressSpinner1.Name = "MetroProgressSpinner1"
        Me.MetroProgressSpinner1.Size = New System.Drawing.Size(70, 70)
        Me.MetroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroProgressSpinner1.TabIndex = 0
        Me.MetroProgressSpinner1.Value = 25
        '
        'Status
        '
        Me.Status.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Status.AutoSize = True
        Me.Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Status.Location = New System.Drawing.Point(227, 172)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(58, 18)
        Me.Status.TabIndex = 1
        Me.Status.Text = "Starting"
        '
        'LoadingAnimation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.MetroProgressSpinner1)
        Me.Name = "LoadingAnimation"
        Me.Size = New System.Drawing.Size(513, 248)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroProgressSpinner1 As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents Status As Label
End Class
