<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PDUUserConnectionData
    Inherits System.Windows.Forms.UserControl

    'Пользовательский элемент управления (UserControl) переопределяет метод Dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.groupBox = New System.Windows.Forms.GroupBox()
        Me.LocAddrCheckBox = New System.Windows.Forms.CheckBox()
        Me.PasswordBox = New System.Windows.Forms.TextBox()
        Me.PortBox = New System.Windows.Forms.TextBox()
        Me.IpAddpessBox1 = New WindowsApp3.IPAddpessBox()
        Me.Remember = New System.Windows.Forms.CheckBox()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.groupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox
        '
        Me.groupBox.Controls.Add(Me.LocAddrCheckBox)
        Me.groupBox.Controls.Add(Me.PasswordBox)
        Me.groupBox.Controls.Add(Me.PortBox)
        Me.groupBox.Controls.Add(Me.IpAddpessBox1)
        Me.groupBox.Controls.Add(Me.Remember)
        Me.groupBox.Controls.Add(Me.Delete)
        Me.groupBox.Controls.Add(Me.Submit)
        Me.groupBox.Controls.Add(Me.Label3)
        Me.groupBox.Controls.Add(Me.Label2)
        Me.groupBox.Controls.Add(Me.Label1)
        Me.groupBox.Location = New System.Drawing.Point(4, -1)
        Me.groupBox.MaximumSize = New System.Drawing.Size(332, 161)
        Me.groupBox.MinimumSize = New System.Drawing.Size(332, 161)
        Me.groupBox.Name = "groupBox"
        Me.groupBox.Size = New System.Drawing.Size(332, 161)
        Me.groupBox.TabIndex = 0
        Me.groupBox.TabStop = False
        Me.groupBox.Text = "Connection settings"
        '
        'LocAddrCheckBox
        '
        Me.LocAddrCheckBox.AutoSize = True
        Me.LocAddrCheckBox.Checked = True
        Me.LocAddrCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LocAddrCheckBox.Location = New System.Drawing.Point(222, 52)
        Me.LocAddrCheckBox.Name = "LocAddrCheckBox"
        Me.LocAddrCheckBox.Size = New System.Drawing.Size(92, 17)
        Me.LocAddrCheckBox.TabIndex = 12
        Me.LocAddrCheckBox.Text = "Local address"
        Me.LocAddrCheckBox.UseVisualStyleBackColor = True
        '
        'PasswordBox
        '
        Me.PasswordBox.Location = New System.Drawing.Point(113, 78)
        Me.PasswordBox.MaxLength = 8
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordBox.Size = New System.Drawing.Size(133, 20)
        Me.PasswordBox.TabIndex = 7
        '
        'PortBox
        '
        Me.PortBox.Enabled = False
        Me.PortBox.Location = New System.Drawing.Point(113, 50)
        Me.PortBox.MaxLength = 5
        Me.PortBox.Name = "PortBox"
        Me.PortBox.Size = New System.Drawing.Size(93, 20)
        Me.PortBox.TabIndex = 6
        '
        'IpAddpessBox1
        '
        Me.IpAddpessBox1.Location = New System.Drawing.Point(112, 21)
        Me.IpAddpessBox1.Name = "IpAddpessBox1"
        Me.IpAddpessBox1.Size = New System.Drawing.Size(134, 23)
        Me.IpAddpessBox1.TabIndex = 8
        '
        'Remember
        '
        Me.Remember.AutoSize = True
        Me.Remember.Location = New System.Drawing.Point(13, 128)
        Me.Remember.Name = "Remember"
        Me.Remember.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Remember.Size = New System.Drawing.Size(131, 17)
        Me.Remember.TabIndex = 11
        Me.Remember.Text = "Remember this device"
        Me.Remember.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Enabled = False
        Me.Delete.Location = New System.Drawing.Point(165, 124)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(75, 23)
        Me.Delete.TabIndex = 10
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(247, 124)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(75, 23)
        Me.Submit.TabIndex = 9
        Me.Submit.Text = "Connect"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Port:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IP Address:"
        '
        'PDUUserConnectionData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.groupBox)
        Me.MaximumSize = New System.Drawing.Size(340, 165)
        Me.MinimumSize = New System.Drawing.Size(340, 165)
        Me.Name = "PDUUserConnectionData"
        Me.Size = New System.Drawing.Size(340, 165)
        Me.groupBox.ResumeLayout(False)
        Me.groupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents groupBox As GroupBox
    Friend WithEvents PasswordBox As TextBox
    Friend WithEvents PortBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents IpAddpessBox1 As IPAddpessBox
    Friend WithEvents Delete As Button
    Friend WithEvents Submit As Button
    Friend WithEvents Remember As CheckBox
    Friend WithEvents LocAddrCheckBox As CheckBox
End Class
