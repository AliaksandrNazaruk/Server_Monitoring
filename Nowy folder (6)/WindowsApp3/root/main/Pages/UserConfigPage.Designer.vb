<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserConfigPage
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EmailInput = New MetroFramework.Controls.MetroTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.usrList = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LocationBox = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CompanyInput1 = New System.Windows.Forms.Label()
        Me.DepInput1 = New System.Windows.Forms.Label()
        Me.TittleInput1 = New System.Windows.Forms.Label()
        Me.LoginInput1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SaveButton = New MetroFramework.Controls.MetroButton()
        Me.AddNewUserLink = New System.Windows.Forms.Label()
        Me.UsersControl = New System.Windows.Forms.Label()
        Me.UsersControl1 = New WindowsApp3.UsersControl()
        Me.usrList.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(237, 25)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "USER CONFIGURATION"
        '
        'EmailInput
        '
        Me.EmailInput.BackColor = System.Drawing.Color.White
        Me.EmailInput.Location = New System.Drawing.Point(121, 152)
        Me.EmailInput.Name = "EmailInput"
        Me.EmailInput.Size = New System.Drawing.Size(197, 23)
        Me.EmailInput.TabIndex = 114
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(30, 155)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 13)
        Me.Label13.TabIndex = 105
        Me.Label13.Text = "E-mail Address:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(81, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Title:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(57, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 103
        Me.Label9.Text = "Company:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(44, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "Department:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(53, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 101
        Me.Label11.Text = "Username:"
        '
        'usrList
        '
        Me.usrList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.usrList.Controls.Add(Me.TabPage1)
        Me.usrList.Controls.Add(Me.TabPage2)
        Me.usrList.Location = New System.Drawing.Point(14, 68)
        Me.usrList.Name = "usrList"
        Me.usrList.SelectedIndex = 0
        Me.usrList.Size = New System.Drawing.Size(914, 544)
        Me.usrList.TabIndex = 124
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LocationBox)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.CompanyInput1)
        Me.TabPage1.Controls.Add(Me.DepInput1)
        Me.TabPage1.Controls.Add(Me.TittleInput1)
        Me.TabPage1.Controls.Add(Me.LoginInput1)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.EmailInput)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(906, 525)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Administration"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LocationBox
        '
        Me.LocationBox.BackColor = System.Drawing.Color.White
        Me.LocationBox.Location = New System.Drawing.Point(121, 181)
        Me.LocationBox.Name = "LocationBox"
        Me.LocationBox.Size = New System.Drawing.Size(197, 23)
        Me.LocationBox.TabIndex = 122
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "Location:"
        '
        'CompanyInput1
        '
        Me.CompanyInput1.AutoSize = True
        Me.CompanyInput1.Location = New System.Drawing.Point(118, 128)
        Me.CompanyInput1.Name = "CompanyInput1"
        Me.CompanyInput1.Size = New System.Drawing.Size(10, 13)
        Me.CompanyInput1.TabIndex = 120
        Me.CompanyInput1.Text = "-"
        '
        'DepInput1
        '
        Me.DepInput1.AutoSize = True
        Me.DepInput1.Location = New System.Drawing.Point(118, 98)
        Me.DepInput1.Name = "DepInput1"
        Me.DepInput1.Size = New System.Drawing.Size(10, 13)
        Me.DepInput1.TabIndex = 119
        Me.DepInput1.Text = "-"
        '
        'TittleInput1
        '
        Me.TittleInput1.AutoSize = True
        Me.TittleInput1.Location = New System.Drawing.Point(118, 68)
        Me.TittleInput1.Name = "TittleInput1"
        Me.TittleInput1.Size = New System.Drawing.Size(10, 13)
        Me.TittleInput1.TabIndex = 118
        Me.TittleInput1.Text = "-"
        '
        'LoginInput1
        '
        Me.LoginInput1.AutoSize = True
        Me.LoginInput1.Location = New System.Drawing.Point(118, 38)
        Me.LoginInput1.Name = "LoginInput1"
        Me.LoginInput1.Size = New System.Drawing.Size(10, 13)
        Me.LoginInput1.TabIndex = 117
        Me.LoginInput1.Text = "-"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.UsersControl1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(906, 518)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "User list"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.Location = New System.Drawing.Point(818, 623)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(114, 32)
        Me.SaveButton.TabIndex = 125
        Me.SaveButton.Text = "Save"
        '
        'AddNewUserLink
        '
        Me.AddNewUserLink.AutoSize = True
        Me.AddNewUserLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.AddNewUserLink.ForeColor = System.Drawing.Color.Blue
        Me.AddNewUserLink.Location = New System.Drawing.Point(377, 102)
        Me.AddNewUserLink.Name = "AddNewUserLink"
        Me.AddNewUserLink.Size = New System.Drawing.Size(72, 13)
        Me.AddNewUserLink.TabIndex = 122
        Me.AddNewUserLink.Text = "Add new user"
        '
        'UsersControl
        '
        Me.UsersControl.AutoSize = True
        Me.UsersControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.UsersControl.ForeColor = System.Drawing.Color.Blue
        Me.UsersControl.Location = New System.Drawing.Point(377, 128)
        Me.UsersControl.Name = "UsersControl"
        Me.UsersControl.Size = New System.Drawing.Size(64, 13)
        Me.UsersControl.TabIndex = 123
        Me.UsersControl.Text = "User control"
        '
        'UsersControl1
        '
        Me.UsersControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UsersControl1.Location = New System.Drawing.Point(3, 3)
        Me.UsersControl1.Name = "UsersControl1"
        Me.UsersControl1.Size = New System.Drawing.Size(900, 512)
        Me.UsersControl1.TabIndex = 0
        '
        'UserConfigPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.usrList)
        Me.Controls.Add(Me.UsersControl)
        Me.Controls.Add(Me.AddNewUserLink)
        Me.Controls.Add(Me.Label3)
        Me.Name = "UserConfigPage"
        Me.Size = New System.Drawing.Size(950, 681)
        Me.usrList.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents EmailInput As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents usrList As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents UsersControl1 As UsersControl
    Friend WithEvents CompanyInput1 As Label
    Friend WithEvents DepInput1 As Label
    Friend WithEvents TittleInput1 As Label
    Friend WithEvents LoginInput1 As Label
    Friend WithEvents LocationBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SaveButton As MetroFramework.Controls.MetroButton
    Friend WithEvents AddNewUserLink As Label
    Friend WithEvents UsersControl As Label
End Class
