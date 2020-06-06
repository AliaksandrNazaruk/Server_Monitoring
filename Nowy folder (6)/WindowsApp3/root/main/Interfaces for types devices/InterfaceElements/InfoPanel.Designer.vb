<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoPanel
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.labLogout = New System.Windows.Forms.Label()
        Me.labVersion = New System.Windows.Forms.Label()
        Me.labStatus = New System.Windows.Forms.Label()
        Me.labLocation = New System.Windows.Forms.Label()
        Me.labName = New System.Windows.Forms.Label()
        Me.labLanguage = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(11, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Location:"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Snow
        Me.Label2.Location = New System.Drawing.Point(22, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Status:"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Snow
        Me.Label3.Location = New System.Drawing.Point(15, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Soft ver:"
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Snow
        Me.Label4.Location = New System.Drawing.Point(160, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Language:"
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Snow
        Me.Label5.Location = New System.Drawing.Point(186, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "User:"
        '
        'labLogout
        '
        Me.labLogout.ForeColor = System.Drawing.Color.Snow
        Me.labLogout.Location = New System.Drawing.Point(226, 58)
        Me.labLogout.Name = "labLogout"
        Me.labLogout.Size = New System.Drawing.Size(40, 13)
        Me.labLogout.TabIndex = 6
        Me.labLogout.Text = "Logout"
        '
        'labVersion
        '
        Me.labVersion.AutoSize = True
        Me.labVersion.ForeColor = System.Drawing.Color.Snow
        Me.labVersion.Location = New System.Drawing.Point(59, 58)
        Me.labVersion.Name = "labVersion"
        Me.labVersion.Size = New System.Drawing.Size(0, 13)
        Me.labVersion.TabIndex = 9
        '
        'labStatus
        '
        Me.labStatus.AutoSize = True
        Me.labStatus.ForeColor = System.Drawing.Color.Snow
        Me.labStatus.Location = New System.Drawing.Point(59, 34)
        Me.labStatus.Name = "labStatus"
        Me.labStatus.Size = New System.Drawing.Size(0, 13)
        Me.labStatus.TabIndex = 8
        '
        'labLocation
        '
        Me.labLocation.AutoSize = True
        Me.labLocation.ForeColor = System.Drawing.Color.Snow
        Me.labLocation.Location = New System.Drawing.Point(59, 10)
        Me.labLocation.Name = "labLocation"
        Me.labLocation.Size = New System.Drawing.Size(0, 13)
        Me.labLocation.TabIndex = 7
        '
        'labName
        '
        Me.labName.AutoSize = True
        Me.labName.ForeColor = System.Drawing.Color.Snow
        Me.labName.Location = New System.Drawing.Point(215, 34)
        Me.labName.Name = "labName"
        Me.labName.Size = New System.Drawing.Size(0, 13)
        Me.labName.TabIndex = 11
        '
        'labLanguage
        '
        Me.labLanguage.AutoSize = True
        Me.labLanguage.ForeColor = System.Drawing.Color.Snow
        Me.labLanguage.Location = New System.Drawing.Point(215, 10)
        Me.labLanguage.Name = "labLanguage"
        Me.labLanguage.Size = New System.Drawing.Size(0, 13)
        Me.labLanguage.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.WindowsApp3.My.Resources.Resources.MonitoringOverviewButton2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(290, 83)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(290, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(290, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'InfoPanel
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.labName)
        Me.Controls.Add(Me.labLanguage)
        Me.Controls.Add(Me.labVersion)
        Me.Controls.Add(Me.labStatus)
        Me.Controls.Add(Me.labLocation)
        Me.Controls.Add(Me.labLogout)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "InfoPanel"
        Me.Size = New System.Drawing.Size(290, 83)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents labLogout As Label
    Friend WithEvents labVersion As Label
    Friend WithEvents labStatus As Label
    Friend WithEvents labLocation As Label
    Friend WithEvents labName As Label
    Friend WithEvents labLanguage As Label
End Class
