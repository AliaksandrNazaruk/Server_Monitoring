<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsersControl
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NameUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Passwords = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Admin = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Enabled = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AddUsrButton = New MetroFramework.Controls.MetroButton()
        Me.DeleteButton = New MetroFramework.Controls.MetroButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameUser, Me.Passwords, Me.Admin, Me.Enabled})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(487, 179)
        Me.DataGridView1.TabIndex = 0
        '
        'NameUser
        '
        Me.NameUser.HeaderText = "Name User"
        Me.NameUser.Name = "NameUser"
        Me.NameUser.ReadOnly = True
        '
        'Passwords
        '
        Me.Passwords.HeaderText = "Passwords"
        Me.Passwords.Name = "Passwords"
        Me.Passwords.ReadOnly = True
        '
        'Admin
        '
        Me.Admin.HeaderText = "Admin"
        Me.Admin.Name = "Admin"
        Me.Admin.ReadOnly = True
        '
        'Enabled
        '
        Me.Enabled.HeaderText = "Enabled"
        Me.Enabled.Name = "Enabled"
        Me.Enabled.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.CausesValidation = False
        Me.GroupBox1.Controls.Add(Me.AddUsrButton)
        Me.GroupBox1.Controls.Add(Me.DeleteButton)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 245)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'AddUsrButton
        '
        Me.AddUsrButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddUsrButton.Location = New System.Drawing.Point(307, 203)
        Me.AddUsrButton.Name = "AddUsrButton"
        Me.AddUsrButton.Size = New System.Drawing.Size(94, 36)
        Me.AddUsrButton.TabIndex = 104
        Me.AddUsrButton.Text = "Add new user"
        '
        'DeleteButton
        '
        Me.DeleteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteButton.Enabled = False
        Me.DeleteButton.Location = New System.Drawing.Point(407, 203)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(94, 36)
        Me.DeleteButton.TabIndex = 102
        Me.DeleteButton.Text = "Delete"
        '
        'UsersControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UsersControl"
        Me.Size = New System.Drawing.Size(536, 263)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DeleteButton As MetroFramework.Controls.MetroButton
    Friend WithEvents NameUser As DataGridViewTextBoxColumn
    Friend WithEvents Passwords As DataGridViewTextBoxColumn
    Friend WithEvents Admin As DataGridViewCheckBoxColumn
    Friend WithEvents Enabled As DataGridViewCheckBoxColumn
    Friend WithEvents AddUsrButton As MetroFramework.Controls.MetroButton
End Class
