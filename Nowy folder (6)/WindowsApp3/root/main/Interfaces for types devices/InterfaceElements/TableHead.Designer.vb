<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableHead
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
        Me.PictureTable = New System.Windows.Forms.PictureBox()
        Me.Text1 = New System.Windows.Forms.Label()
        Me.Text2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.PictureTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureTable
        '
        Me.PictureTable.Image = Global.WindowsApp3.My.Resources.Resources.P3A6
        Me.PictureTable.Location = New System.Drawing.Point(0, 18)
        Me.PictureTable.Name = "PictureTable"
        Me.PictureTable.Size = New System.Drawing.Size(911, 31)
        Me.PictureTable.TabIndex = 38
        Me.PictureTable.TabStop = False
        '
        'Text1
        '
        Me.Text1.AutoSize = True
        Me.Text1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Text1.Location = New System.Drawing.Point(3, 0)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(57, 18)
        Me.Text1.TabIndex = 39
        Me.Text1.Text = "Label1"
        '
        'Text2
        '
        Me.Text2.AutoSize = True
        Me.Text2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Text2.ForeColor = System.Drawing.Color.Red
        Me.Text2.Location = New System.Drawing.Point(66, 0)
        Me.Text2.Name = "Text2"
        Me.Text2.Size = New System.Drawing.Size(0, 18)
        Me.Text2.TabIndex = 40
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Text1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Text2)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(407, 18)
        Me.FlowLayoutPanel1.TabIndex = 41
        '
        'TableHead
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.PictureTable)
        Me.MaximumSize = New System.Drawing.Size(911, 49)
        Me.MinimumSize = New System.Drawing.Size(911, 49)
        Me.Name = "TableHead"
        Me.Size = New System.Drawing.Size(911, 49)
        CType(Me.PictureTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureTable As PictureBox
    Friend WithEvents Text1 As Label
    Friend WithEvents Text2 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
