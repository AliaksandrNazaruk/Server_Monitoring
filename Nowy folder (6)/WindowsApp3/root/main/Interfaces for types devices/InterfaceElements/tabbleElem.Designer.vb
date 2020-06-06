<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tabbleElem
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
        Me.Status = New MetroFramework.Controls.MetroLabel()
        Me.Value = New MetroFramework.Controls.MetroLabel()
        Me.SensorType = New MetroFramework.Controls.MetroLabel()
        Me.Name1 = New MetroFramework.Controls.MetroTextBox()
        Me.EnterName1 = New MetroFramework.Controls.MetroLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AnimationAlert = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Base = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Status
        '
        Me.Status.BackColor = System.Drawing.Color.White
        Me.Status.CustomBackground = True
        Me.Status.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Status.Location = New System.Drawing.Point(761, 6)
        Me.Status.MaximumSize = New System.Drawing.Size(144, 21)
        Me.Status.MinimumSize = New System.Drawing.Size(144, 21)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(144, 21)
        Me.Status.TabIndex = 14
        Me.Status.Text = "None"
        Me.Status.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Value
        '
        Me.Value.BackColor = System.Drawing.Color.White
        Me.Value.CustomBackground = True
        Me.Value.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Value.Location = New System.Drawing.Point(610, 6)
        Me.Value.MaximumSize = New System.Drawing.Size(143, 21)
        Me.Value.MinimumSize = New System.Drawing.Size(143, 21)
        Me.Value.Name = "Value"
        Me.Value.Size = New System.Drawing.Size(143, 21)
        Me.Value.TabIndex = 15
        Me.Value.Text = "None"
        Me.Value.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SensorType
        '
        Me.SensorType.BackColor = System.Drawing.SystemColors.Control
        Me.SensorType.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.SensorType.Location = New System.Drawing.Point(8, 6)
        Me.SensorType.Name = "SensorType"
        Me.SensorType.Size = New System.Drawing.Size(195, 20)
        Me.SensorType.TabIndex = 16
        Me.SensorType.Text = "None"
        '
        'Name1
        '
        Me.Name1.CausesValidation = False
        Me.Name1.CustomBackground = True
        Me.Name1.CustomForeColor = True
        Me.Name1.Location = New System.Drawing.Point(209, 4)
        Me.Name1.Name = "Name1"
        Me.Name1.Size = New System.Drawing.Size(395, 25)
        Me.Name1.TabIndex = 71
        Me.Name1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Name1.Visible = False
        '
        'EnterName1
        '
        Me.EnterName1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.EnterName1.Location = New System.Drawing.Point(213, 6)
        Me.EnterName1.Name = "EnterName1"
        Me.EnterName1.Size = New System.Drawing.Size(390, 20)
        Me.EnterName1.TabIndex = 70
        Me.EnterName1.Text = "Enter Consumer Name"
        Me.EnterName1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'AnimationAlert
        '
        Me.AnimationAlert.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp3.My.Resources.Resources.EN_2D_TableElem_
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(911, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Base
        '
        Me.Base.Location = New System.Drawing.Point(4, 36)
        Me.Base.Name = "Base"
        Me.Base.Size = New System.Drawing.Size(33, 20)
        Me.Base.TabIndex = 72
        '
        'tabbleElem
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.Controls.Add(Me.Base)
        Me.Controls.Add(Me.Name1)
        Me.Controls.Add(Me.EnterName1)
        Me.Controls.Add(Me.SensorType)
        Me.Controls.Add(Me.Value)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(911, 30)
        Me.MinimumSize = New System.Drawing.Size(911, 30)
        Me.Name = "tabbleElem"
        Me.Size = New System.Drawing.Size(911, 30)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents AnimationAlert As Timer
    Friend WithEvents Base As TextBox
    Public WithEvents Status As MetroFramework.Controls.MetroLabel
    Public WithEvents Value As MetroFramework.Controls.MetroLabel
    Public WithEvents SensorType As MetroFramework.Controls.MetroLabel
    Public WithEvents Name1 As MetroFramework.Controls.MetroTextBox
    Public WithEvents EnterName1 As MetroFramework.Controls.MetroLabel
End Class
