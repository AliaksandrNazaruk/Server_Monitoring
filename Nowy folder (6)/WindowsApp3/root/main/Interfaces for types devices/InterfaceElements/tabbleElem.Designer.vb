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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ElementText = New System.Windows.Forms.Label()
        Me.NameText = New System.Windows.Forms.Label()
        Me.CurrentText = New System.Windows.Forms.Label()
        Me.StatusText = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp3.My.Resources.Resources.EN_2D_TableElem_
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(911, 32)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ElementText
        '
        Me.ElementText.BackColor = System.Drawing.Color.White
        Me.ElementText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ElementText.Location = New System.Drawing.Point(5, 2)
        Me.ElementText.Name = "ElementText"
        Me.ElementText.Size = New System.Drawing.Size(199, 25)
        Me.ElementText.TabIndex = 1
        Me.ElementText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NameText
        '
        Me.NameText.BackColor = System.Drawing.Color.White
        Me.NameText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NameText.Location = New System.Drawing.Point(210, 2)
        Me.NameText.Name = "NameText"
        Me.NameText.Size = New System.Drawing.Size(393, 25)
        Me.NameText.TabIndex = 2
        Me.NameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CurrentText
        '
        Me.CurrentText.BackColor = System.Drawing.Color.White
        Me.CurrentText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CurrentText.Location = New System.Drawing.Point(608, 2)
        Me.CurrentText.Name = "CurrentText"
        Me.CurrentText.Size = New System.Drawing.Size(145, 25)
        Me.CurrentText.TabIndex = 3
        Me.CurrentText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusText
        '
        Me.StatusText.BackColor = System.Drawing.Color.White
        Me.StatusText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.StatusText.Location = New System.Drawing.Point(759, 2)
        Me.StatusText.Name = "StatusText"
        Me.StatusText.Size = New System.Drawing.Size(148, 25)
        Me.StatusText.TabIndex = 4
        Me.StatusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabbleElem
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.StatusText)
        Me.Controls.Add(Me.CurrentText)
        Me.Controls.Add(Me.NameText)
        Me.Controls.Add(Me.ElementText)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "tabbleElem"
        Me.Size = New System.Drawing.Size(911, 29)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ElementText As Label
    Friend WithEvents NameText As Label
    Friend WithEvents CurrentText As Label
    Friend WithEvents StatusText As Label
End Class
