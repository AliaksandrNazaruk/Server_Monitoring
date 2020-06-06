<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddNewUserPanel
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OperatorChecker = New MetroFramework.Controls.MetroCheckBox()
        Me.adminChecker = New MetroFramework.Controls.MetroCheckBox()
        Me.PhoneInput = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmailInput = New MetroFramework.Controls.MetroTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CompanyInput = New MetroFramework.Controls.MetroTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DepInput = New MetroFramework.Controls.MetroTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TittleInput = New MetroFramework.Controls.MetroTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ConfPassInput = New MetroFramework.Controls.MetroTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PassInput = New MetroFramework.Controls.MetroTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LoginInput = New MetroFramework.Controls.MetroTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.MessageTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LocationInput = New MetroFramework.Controls.MetroTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LocationInput)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.OperatorChecker)
        Me.GroupBox1.Controls.Add(Me.adminChecker)
        Me.GroupBox1.Controls.Add(Me.PhoneInput)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.EmailInput)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CompanyInput)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DepInput)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TittleInput)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ConfPassInput)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.PassInput)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.LoginInput)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(467, 417)
        Me.GroupBox1.TabIndex = 98
        Me.GroupBox1.TabStop = False
        '
        'OperatorChecker
        '
        Me.OperatorChecker.Location = New System.Drawing.Point(127, 82)
        Me.OperatorChecker.Name = "OperatorChecker"
        Me.OperatorChecker.Size = New System.Drawing.Size(83, 15)
        Me.OperatorChecker.Style = MetroFramework.MetroColorStyle.Red
        Me.OperatorChecker.TabIndex = 96
        Me.OperatorChecker.UseVisualStyleBackColor = True
        '
        'adminChecker
        '
        Me.adminChecker.Location = New System.Drawing.Point(127, 54)
        Me.adminChecker.Name = "adminChecker"
        Me.adminChecker.Size = New System.Drawing.Size(61, 15)
        Me.adminChecker.Style = MetroFramework.MetroColorStyle.Red
        Me.adminChecker.TabIndex = 99
        Me.adminChecker.UseVisualStyleBackColor = True
        '
        'PhoneInput
        '
        Me.PhoneInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PhoneInput.Location = New System.Drawing.Point(127, 289)
        Me.PhoneInput.Name = "PhoneInput"
        Me.PhoneInput.Size = New System.Drawing.Size(301, 23)
        Me.PhoneInput.TabIndex = 92
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Password*"
        '
        'EmailInput
        '
        Me.EmailInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmailInput.Location = New System.Drawing.Point(127, 259)
        Me.EmailInput.Name = "EmailInput"
        Me.EmailInput.Size = New System.Drawing.Size(301, 23)
        Me.EmailInput.TabIndex = 91
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Confirm*"
        '
        'CompanyInput
        '
        Me.CompanyInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CompanyInput.Location = New System.Drawing.Point(127, 229)
        Me.CompanyInput.Name = "CompanyInput"
        Me.CompanyInput.Size = New System.Drawing.Size(301, 23)
        Me.CompanyInput.TabIndex = 90
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Operator"
        '
        'DepInput
        '
        Me.DepInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DepInput.Location = New System.Drawing.Point(127, 199)
        Me.DepInput.Name = "DepInput"
        Me.DepInput.Size = New System.Drawing.Size(301, 23)
        Me.DepInput.TabIndex = 89
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Admin"
        '
        'TittleInput
        '
        Me.TittleInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TittleInput.Location = New System.Drawing.Point(127, 169)
        Me.TittleInput.Name = "TittleInput"
        Me.TittleInput.Size = New System.Drawing.Size(301, 23)
        Me.TittleInput.TabIndex = 88
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Username(Login)*"
        '
        'ConfPassInput
        '
        Me.ConfPassInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConfPassInput.Location = New System.Drawing.Point(127, 139)
        Me.ConfPassInput.Name = "ConfPassInput"
        Me.ConfPassInput.Size = New System.Drawing.Size(301, 23)
        Me.ConfPassInput.TabIndex = 87
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(48, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Department"
        '
        'PassInput
        '
        Me.PassInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PassInput.Location = New System.Drawing.Point(127, 109)
        Me.PassInput.Name = "PassInput"
        Me.PassInput.Size = New System.Drawing.Size(301, 23)
        Me.PassInput.TabIndex = 86
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(61, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Company"
        '
        'LoginInput
        '
        Me.LoginInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoginInput.Location = New System.Drawing.Point(127, 19)
        Me.LoginInput.Name = "LoginInput"
        Me.LoginInput.Size = New System.Drawing.Size(301, 23)
        Me.LoginInput.TabIndex = 84
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Title"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(40, 299)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "SMS Number"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(34, 269)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 13)
        Me.Label13.TabIndex = 79
        Me.Label13.Text = "E-mail Address"
        '
        'MessageTimer
        '
        Me.MessageTimer.Interval = 6000
        '
        'LocationInput
        '
        Me.LocationInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LocationInput.Location = New System.Drawing.Point(127, 320)
        Me.LocationInput.Name = "LocationInput"
        Me.LocationInput.Size = New System.Drawing.Size(301, 23)
        Me.LocationInput.TabIndex = 101
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(60, 329)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "Location"
        '
        'AddNewUserPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AddNewUserPanel"
        Me.Size = New System.Drawing.Size(480, 443)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents adminChecker As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents OperatorChecker As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TittleInput As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ConfPassInput As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PassInput As MetroFramework.Controls.MetroTextBox
    Friend WithEvents EmailInput As MetroFramework.Controls.MetroTextBox
    Friend WithEvents LoginInput As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PhoneInput As MetroFramework.Controls.MetroTextBox
    Friend WithEvents DepInput As MetroFramework.Controls.MetroTextBox
    Friend WithEvents CompanyInput As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MessageTimer As Timer
    Friend WithEvents LocationInput As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label9 As Label
End Class
