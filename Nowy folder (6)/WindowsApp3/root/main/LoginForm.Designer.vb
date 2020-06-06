<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    'Форма переопределяет dispose для очистки списка компонентов.
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
    '<System.Diagnostics.DebuggerStepThrough()>

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.LoginBox = New MetroFramework.Controls.MetroTextBox()
        Me.PassBox = New MetroFramework.Controls.MetroTextBox()
        Me.Autentification = New MetroFramework.Controls.MetroLink()
        Me.LoginButton = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Status = New WindowsApp3.LoadingAnimation()
        CType(Me.ExitButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginBox
        '
        Me.LoginBox.Location = New System.Drawing.Point(222, 126)
        Me.LoginBox.Name = "LoginBox"
        Me.LoginBox.Size = New System.Drawing.Size(167, 23)
        Me.LoginBox.TabIndex = 0
        '
        'PassBox
        '
        Me.PassBox.Location = New System.Drawing.Point(222, 160)
        Me.PassBox.Name = "PassBox"
        Me.PassBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.PassBox.Size = New System.Drawing.Size(167, 23)
        Me.PassBox.TabIndex = 1
        Me.PassBox.UseSystemPasswordChar = True
        '
        'Autentification
        '
        Me.Autentification.Dock = System.Windows.Forms.DockStyle.Top
        Me.Autentification.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.Autentification.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.Autentification.Location = New System.Drawing.Point(20, 60)
        Me.Autentification.Name = "Autentification"
        Me.Autentification.Size = New System.Drawing.Size(571, 52)
        Me.Autentification.TabIndex = 2
        Me.Autentification.Text = "Autentification"
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(246, 201)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(119, 39)
        Me.LoginButton.TabIndex = 3
        Me.LoginButton.Text = "Login"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(169, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Login:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password:"
        '
        'ExitButton
        '
        Me.ExitButton.Image = Global.WindowsApp3.My.Resources.Resources.EXIT1
        Me.ExitButton.Location = New System.Drawing.Point(558, 1)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(45, 19)
        Me.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ExitButton.TabIndex = 20
        Me.ExitButton.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApp3.My.Resources.Resources.Background1
        Me.PictureBox3.Location = New System.Drawing.Point(-5, -2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(749, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'Status
        '
        Me.Status.BackColor = System.Drawing.Color.White
        Me.Status.Location = New System.Drawing.Point(101, 63)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(396, 216)
        Me.Status.TabIndex = 72
        Me.Status.Visible = False
        '
        'LoginForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(611, 322)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.LoginBox)
        Me.Controls.Add(Me.Autentification)
        Me.Controls.Add(Me.PassBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(611, 322)
        Me.MinimumSize = New System.Drawing.Size(611, 322)
        Me.Name = "LoginForm"
        Me.Style = MetroFramework.MetroColorStyle.Red
        CType(Me.ExitButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PassBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Autentification As MetroFramework.Controls.MetroLink
    Friend WithEvents LoginButton As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ExitButton As PictureBox
    Friend WithEvents Status As LoadingAnimation
End Class
