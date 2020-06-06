<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ipSensor
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
        Me.Description = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Type = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Connector = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MinTreshold = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MaxTreshold = New System.Windows.Forms.TextBox()
        Me.AddToMonitorint1 = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Description
        '
        Me.Description.Location = New System.Drawing.Point(86, 38)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(134, 20)
        Me.Description.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Type"
        '
        'Type
        '
        Me.Type.Location = New System.Drawing.Point(86, 64)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(134, 20)
        Me.Type.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Connector"
        '
        'Connector
        '
        Me.Connector.Location = New System.Drawing.Point(87, 91)
        Me.Connector.Name = "Connector"
        Me.Connector.Size = New System.Drawing.Size(133, 20)
        Me.Connector.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Status"
        '
        'Status
        '
        Me.Status.Location = New System.Drawing.Point(87, 117)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(133, 20)
        Me.Status.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Min. Treshold"
        '
        'MinTreshold
        '
        Me.MinTreshold.Location = New System.Drawing.Point(87, 143)
        Me.MinTreshold.Name = "MinTreshold"
        Me.MinTreshold.Size = New System.Drawing.Size(133, 20)
        Me.MinTreshold.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Max. Treshold"
        '
        'MaxTreshold
        '
        Me.MaxTreshold.Location = New System.Drawing.Point(87, 169)
        Me.MaxTreshold.Name = "MaxTreshold"
        Me.MaxTreshold.Size = New System.Drawing.Size(133, 20)
        Me.MaxTreshold.TabIndex = 10
        '
        'AddToMonitorint1
        '
        Me.AddToMonitorint1.AutoSize = True
        Me.AddToMonitorint1.Location = New System.Drawing.Point(258, 17)
        Me.AddToMonitorint1.Name = "AddToMonitorint1"
        Me.AddToMonitorint1.Size = New System.Drawing.Size(15, 14)
        Me.AddToMonitorint1.TabIndex = 136
        Me.AddToMonitorint1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(136, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 13)
        Me.Label11.TabIndex = 135
        Me.Label11.Text = "Add to monitoring page"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AddToMonitorint1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.MaxTreshold)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.MinTreshold)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Status)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Connector)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Type)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Description)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 205)
        Me.GroupBox1.TabIndex = 137
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "IP Sensor"
        '
        'ipSensor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ipSensor"
        Me.Size = New System.Drawing.Size(295, 215)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Description As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Type As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Connector As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Status As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents MinTreshold As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MaxTreshold As TextBox
    Friend WithEvents AddToMonitorint1 As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
