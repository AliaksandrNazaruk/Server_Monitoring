<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SensorInformation
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
        Me.HardwareRev = New System.Windows.Forms.TextBox()
        Me.Branch1 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.SerialNumber = New System.Windows.Forms.TextBox()
        Me.Manufacture = New System.Windows.Forms.TextBox()
        Me.myLocation1 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.myName1 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PhoneNo1 = New System.Windows.Forms.Label()
        Me.Contact1 = New System.Windows.Forms.Label()
        Me.Rack1 = New System.Windows.Forms.Label()
        Me.myName = New System.Windows.Forms.TextBox()
        Me.ModelBase1 = New System.Windows.Forms.Label()
        Me.ModelBase = New System.Windows.Forms.TextBox()
        Me.Branch = New System.Windows.Forms.TextBox()
        Me.Phone = New System.Windows.Forms.TextBox()
        Me.myLocation = New System.Windows.Forms.TextBox()
        Me.Rack = New System.Windows.Forms.TextBox()
        Me.ContactPerson = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'HardwareRev
        '
        Me.HardwareRev.Location = New System.Drawing.Point(105, 101)
        Me.HardwareRev.Name = "HardwareRev"
        Me.HardwareRev.ReadOnly = True
        Me.HardwareRev.Size = New System.Drawing.Size(209, 20)
        Me.HardwareRev.TabIndex = 145
        '
        'Branch1
        '
        Me.Branch1.AutoSize = True
        Me.Branch1.Location = New System.Drawing.Point(59, 136)
        Me.Branch1.Name = "Branch1"
        Me.Branch1.Size = New System.Drawing.Size(44, 13)
        Me.Branch1.TabIndex = 132
        Me.Branch1.Text = "Branch:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(27, 41)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(74, 13)
        Me.Label19.TabIndex = 142
        Me.Label19.Text = "Serial number:"
        '
        'SerialNumber
        '
        Me.SerialNumber.Location = New System.Drawing.Point(105, 38)
        Me.SerialNumber.Name = "SerialNumber"
        Me.SerialNumber.ReadOnly = True
        Me.SerialNumber.Size = New System.Drawing.Size(209, 20)
        Me.SerialNumber.TabIndex = 147
        '
        'Manufacture
        '
        Me.Manufacture.Location = New System.Drawing.Point(106, 69)
        Me.Manufacture.Name = "Manufacture"
        Me.Manufacture.ReadOnly = True
        Me.Manufacture.Size = New System.Drawing.Size(208, 20)
        Me.Manufacture.TabIndex = 146
        '
        'myLocation1
        '
        Me.myLocation1.AutoSize = True
        Me.myLocation1.Location = New System.Drawing.Point(52, 167)
        Me.myLocation1.Name = "myLocation1"
        Me.myLocation1.Size = New System.Drawing.Size(51, 13)
        Me.myLocation1.TabIndex = 128
        Me.myLocation1.Text = "Location:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(3, 104)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(100, 13)
        Me.Label21.TabIndex = 144
        Me.Label21.Text = "Hardware Revision:"
        '
        'myName1
        '
        Me.myName1.AutoSize = True
        Me.myName1.Location = New System.Drawing.Point(65, 198)
        Me.myName1.Name = "myName1"
        Me.myName1.Size = New System.Drawing.Size(38, 13)
        Me.myName1.TabIndex = 129
        Me.myName1.Text = "Name:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(34, 72)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 13)
        Me.Label20.TabIndex = 143
        Me.Label20.Text = "Manufacture:"
        '
        'PhoneNo1
        '
        Me.PhoneNo1.AutoSize = True
        Me.PhoneNo1.Location = New System.Drawing.Point(62, 291)
        Me.PhoneNo1.Name = "PhoneNo1"
        Me.PhoneNo1.Size = New System.Drawing.Size(41, 13)
        Me.PhoneNo1.TabIndex = 130
        Me.PhoneNo1.Text = "Phone:"
        '
        'Contact1
        '
        Me.Contact1.AutoSize = True
        Me.Contact1.Location = New System.Drawing.Point(20, 260)
        Me.Contact1.Name = "Contact1"
        Me.Contact1.Size = New System.Drawing.Size(83, 13)
        Me.Contact1.TabIndex = 131
        Me.Contact1.Text = "Contact Person:"
        '
        'Rack1
        '
        Me.Rack1.AutoSize = True
        Me.Rack1.Location = New System.Drawing.Point(67, 229)
        Me.Rack1.Name = "Rack1"
        Me.Rack1.Size = New System.Drawing.Size(36, 13)
        Me.Rack1.TabIndex = 133
        Me.Rack1.Text = "Rack:"
        '
        'myName
        '
        Me.myName.Location = New System.Drawing.Point(105, 194)
        Me.myName.Name = "myName"
        Me.myName.ReadOnly = True
        Me.myName.Size = New System.Drawing.Size(209, 20)
        Me.myName.TabIndex = 138
        '
        'ModelBase1
        '
        Me.ModelBase1.AutoSize = True
        Me.ModelBase1.Location = New System.Drawing.Point(64, 11)
        Me.ModelBase1.Name = "ModelBase1"
        Me.ModelBase1.Size = New System.Drawing.Size(39, 13)
        Me.ModelBase1.TabIndex = 134
        Me.ModelBase1.Text = "Model:"
        '
        'ModelBase
        '
        Me.ModelBase.Location = New System.Drawing.Point(105, 7)
        Me.ModelBase.Name = "ModelBase"
        Me.ModelBase.ReadOnly = True
        Me.ModelBase.Size = New System.Drawing.Size(209, 20)
        Me.ModelBase.TabIndex = 135
        '
        'Branch
        '
        Me.Branch.Location = New System.Drawing.Point(105, 132)
        Me.Branch.Name = "Branch"
        Me.Branch.ReadOnly = True
        Me.Branch.Size = New System.Drawing.Size(209, 20)
        Me.Branch.TabIndex = 136
        '
        'Phone
        '
        Me.Phone.Location = New System.Drawing.Point(105, 287)
        Me.Phone.Name = "Phone"
        Me.Phone.ReadOnly = True
        Me.Phone.Size = New System.Drawing.Size(209, 20)
        Me.Phone.TabIndex = 141
        '
        'myLocation
        '
        Me.myLocation.Location = New System.Drawing.Point(105, 163)
        Me.myLocation.Name = "myLocation"
        Me.myLocation.ReadOnly = True
        Me.myLocation.Size = New System.Drawing.Size(209, 20)
        Me.myLocation.TabIndex = 137
        '
        'Rack
        '
        Me.Rack.Location = New System.Drawing.Point(105, 225)
        Me.Rack.Name = "Rack"
        Me.Rack.ReadOnly = True
        Me.Rack.Size = New System.Drawing.Size(209, 20)
        Me.Rack.TabIndex = 139
        '
        'ContactPerson
        '
        Me.ContactPerson.Location = New System.Drawing.Point(105, 256)
        Me.ContactPerson.Name = "ContactPerson"
        Me.ContactPerson.ReadOnly = True
        Me.ContactPerson.Size = New System.Drawing.Size(209, 20)
        Me.ContactPerson.TabIndex = 140
        '
        'SensorInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.HardwareRev)
        Me.Controls.Add(Me.Branch1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.SerialNumber)
        Me.Controls.Add(Me.Manufacture)
        Me.Controls.Add(Me.myLocation1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.myName1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.PhoneNo1)
        Me.Controls.Add(Me.Contact1)
        Me.Controls.Add(Me.Rack1)
        Me.Controls.Add(Me.myName)
        Me.Controls.Add(Me.ModelBase1)
        Me.Controls.Add(Me.ModelBase)
        Me.Controls.Add(Me.Branch)
        Me.Controls.Add(Me.Phone)
        Me.Controls.Add(Me.myLocation)
        Me.Controls.Add(Me.Rack)
        Me.Controls.Add(Me.ContactPerson)
        Me.MaximumSize = New System.Drawing.Size(319, 316)
        Me.MinimumSize = New System.Drawing.Size(319, 316)
        Me.Name = "SensorInformation"
        Me.Size = New System.Drawing.Size(319, 316)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HardwareRev As TextBox
    Friend WithEvents Branch1 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents SerialNumber As TextBox
    Friend WithEvents Manufacture As TextBox
    Friend WithEvents myLocation1 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents myName1 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents PhoneNo1 As Label
    Friend WithEvents Contact1 As Label
    Friend WithEvents Rack1 As Label
    Friend WithEvents myName As TextBox
    Friend WithEvents ModelBase1 As Label
    Friend WithEvents ModelBase As TextBox
    Friend WithEvents Branch As TextBox
    Friend WithEvents Phone As TextBox
    Friend WithEvents myLocation As TextBox
    Friend WithEvents Rack As TextBox
    Friend WithEvents ContactPerson As TextBox
End Class
