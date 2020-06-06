<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserEditForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserEditForm))
        Me.SaveChanges = New MetroFramework.Controls.MetroButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Messages = New System.Windows.Forms.Label()
        Me.MessageTimer = New System.Windows.Forms.Timer(Me.components)
        Me.AddNewUserPanel1 = New WindowsApp3.AddNewUserPanel()
        Me.AddNewUserButton = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'SaveChanges
        '
        Me.SaveChanges.Location = New System.Drawing.Point(302, 412)
        Me.SaveChanges.Name = "SaveChanges"
        Me.SaveChanges.Size = New System.Drawing.Size(94, 36)
        Me.SaveChanges.TabIndex = 1
        Me.SaveChanges.Text = "Save changes"
        '
        'Messages
        '
        Me.Messages.AutoSize = True
        Me.Messages.ForeColor = System.Drawing.Color.Red
        Me.Messages.Location = New System.Drawing.Point(166, 336)
        Me.Messages.Name = "Messages"
        Me.Messages.Size = New System.Drawing.Size(0, 13)
        Me.Messages.TabIndex = 2
        Me.Messages.Visible = False
        '
        'MessageTimer
        '
        Me.MessageTimer.Interval = 6000
        '
        'AddNewUserPanel1
        '
        Me.AddNewUserPanel1.BackColor = System.Drawing.Color.White
        Me.AddNewUserPanel1.Location = New System.Drawing.Point(-3, -12)
        Me.AddNewUserPanel1.Name = "AddNewUserPanel1"
        Me.AddNewUserPanel1.Size = New System.Drawing.Size(538, 501)
        Me.AddNewUserPanel1.TabIndex = 0
        '
        'AddNewUserButton
        '
        Me.AddNewUserButton.Location = New System.Drawing.Point(406, 412)
        Me.AddNewUserButton.Name = "AddNewUserButton"
        Me.AddNewUserButton.Size = New System.Drawing.Size(94, 36)
        Me.AddNewUserButton.TabIndex = 3
        Me.AddNewUserButton.Text = "Add new user"
        '
        'UserEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(518, 464)
        Me.Controls.Add(Me.AddNewUserButton)
        Me.Controls.Add(Me.SaveChanges)
        Me.Controls.Add(Me.Messages)
        Me.Controls.Add(Me.AddNewUserPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(534, 503)
        Me.MinimumSize = New System.Drawing.Size(534, 503)
        Me.Name = "UserEditForm"
        Me.Text = "UserEditForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddNewUserPanel1 As AddNewUserPanel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Messages As Label
    Friend WithEvents MessageTimer As Timer
    Private WithEvents SaveChanges As MetroFramework.Controls.MetroButton
    Private WithEvents AddNewUserButton As MetroFramework.Controls.MetroButton
End Class
