<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IPAddpessBox
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
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.InpIPTextBox3 = New System.Windows.Forms.TextBox()
        Me.InpIPTextBox4 = New System.Windows.Forms.TextBox()
        Me.InpIPTextBox2 = New System.Windows.Forms.TextBox()
        Me.InpIPTextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(1, 1)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(130, 20)
        Me.TextBox2.TabIndex = 187
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(94, 4)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(10, 13)
        Me.Label26.TabIndex = 194
        Me.Label26.Text = "."
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(62, 4)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(10, 13)
        Me.Label22.TabIndex = 193
        Me.Label22.Text = "."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(29, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 188
        Me.Label5.Text = "."
        '
        'InpIPTextBox3
        '
        Me.InpIPTextBox3.BackColor = System.Drawing.Color.White
        Me.InpIPTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InpIPTextBox3.Location = New System.Drawing.Point(73, 5)
        Me.InpIPTextBox3.MaxLength = 3
        Me.InpIPTextBox3.Name = "InpIPTextBox3"
        Me.InpIPTextBox3.Size = New System.Drawing.Size(20, 13)
        Me.InpIPTextBox3.TabIndex = 191
        Me.InpIPTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'InpIPTextBox4
        '
        Me.InpIPTextBox4.BackColor = System.Drawing.Color.White
        Me.InpIPTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InpIPTextBox4.Location = New System.Drawing.Point(106, 5)
        Me.InpIPTextBox4.MaxLength = 3
        Me.InpIPTextBox4.Name = "InpIPTextBox4"
        Me.InpIPTextBox4.Size = New System.Drawing.Size(20, 13)
        Me.InpIPTextBox4.TabIndex = 192
        '
        'InpIPTextBox2
        '
        Me.InpIPTextBox2.BackColor = System.Drawing.Color.White
        Me.InpIPTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InpIPTextBox2.Location = New System.Drawing.Point(40, 5)
        Me.InpIPTextBox2.MaxLength = 3
        Me.InpIPTextBox2.Name = "InpIPTextBox2"
        Me.InpIPTextBox2.Size = New System.Drawing.Size(20, 13)
        Me.InpIPTextBox2.TabIndex = 190
        Me.InpIPTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'InpIPTextBox1
        '
        Me.InpIPTextBox1.BackColor = System.Drawing.Color.White
        Me.InpIPTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InpIPTextBox1.Location = New System.Drawing.Point(6, 5)
        Me.InpIPTextBox1.MaxLength = 3
        Me.InpIPTextBox1.Name = "InpIPTextBox1"
        Me.InpIPTextBox1.Size = New System.Drawing.Size(20, 13)
        Me.InpIPTextBox1.TabIndex = 189
        Me.InpIPTextBox1.Text = " "
        Me.InpIPTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'IPAddpessBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.InpIPTextBox3)
        Me.Controls.Add(Me.InpIPTextBox4)
        Me.Controls.Add(Me.InpIPTextBox2)
        Me.Controls.Add(Me.InpIPTextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Name = "IPAddpessBox"
        Me.Size = New System.Drawing.Size(134, 24)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents InpIPTextBox3 As TextBox
    Friend WithEvents InpIPTextBox4 As TextBox
    Friend WithEvents InpIPTextBox2 As TextBox
    Friend WithEvents InpIPTextBox1 As TextBox
End Class
