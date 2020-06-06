<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MonitoringPage
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BlockPDUAxPDUB = New System.Windows.Forms.PictureBox()
        Me.BlockPDUBxMB = New System.Windows.Forms.PictureBox()
        Me.MBTable = New WindowsApp3.TableForMB()
        Me.TableForPDUA = New WindowsApp3.TableForPDU()
        Me.TableForPDUB = New WindowsApp3.TableForPDU()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.BlockPDUAxPDUB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlockPDUBxMB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.CausesValidation = False
        Me.FlowLayoutPanel1.Controls.Add(Me.TableForPDUA)
        Me.FlowLayoutPanel1.Controls.Add(Me.BlockPDUAxPDUB)
        Me.FlowLayoutPanel1.Controls.Add(Me.TableForPDUB)
        Me.FlowLayoutPanel1.Controls.Add(Me.BlockPDUBxMB)
        Me.FlowLayoutPanel1.Controls.Add(Me.MBTable)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(14, 9)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(922, 849)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'BlockPDUAxPDUB
        '
        Me.BlockPDUAxPDUB.Location = New System.Drawing.Point(3, 262)
        Me.BlockPDUAxPDUB.Name = "BlockPDUAxPDUB"
        Me.BlockPDUAxPDUB.Size = New System.Drawing.Size(914, 23)
        Me.BlockPDUAxPDUB.TabIndex = 6
        Me.BlockPDUAxPDUB.TabStop = False
        Me.BlockPDUAxPDUB.Visible = False
        '
        'BlockPDUBxMB
        '
        Me.BlockPDUBxMB.Location = New System.Drawing.Point(3, 550)
        Me.BlockPDUBxMB.Name = "BlockPDUBxMB"
        Me.BlockPDUBxMB.Size = New System.Drawing.Size(916, 26)
        Me.BlockPDUBxMB.TabIndex = 9
        Me.BlockPDUBxMB.TabStop = False
        Me.BlockPDUBxMB.Visible = False
        '
        'MBTable
        '
        Me.MBTable.AutoSize = True
        Me.MBTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MBTable.Location = New System.Drawing.Point(3, 582)
        Me.MBTable.Name = "MBTable"
        Me.MBTable.Size = New System.Drawing.Size(914, 52)
        Me.MBTable.TabIndex = 10
        Me.MBTable.Visible = False
        '
        'TableForPDUA
        '
        Me.TableForPDUA.AutoSize = True
        Me.TableForPDUA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableForPDUA.Location = New System.Drawing.Point(0, 0)
        Me.TableForPDUA.Margin = New System.Windows.Forms.Padding(0)
        Me.TableForPDUA.Name = "TableForPDUA"
        Me.TableForPDUA.Size = New System.Drawing.Size(911, 259)
        Me.TableForPDUA.TabIndex = 11
        '
        'TableForPDUB
        '
        Me.TableForPDUB.AutoSize = True
        Me.TableForPDUB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableForPDUB.Location = New System.Drawing.Point(0, 288)
        Me.TableForPDUB.Margin = New System.Windows.Forms.Padding(0)
        Me.TableForPDUB.Name = "TableForPDUB"
        Me.TableForPDUB.Size = New System.Drawing.Size(911, 259)
        Me.TableForPDUB.TabIndex = 12
        '
        'MonitoringPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.MaximumSize = New System.Drawing.Size(950, 861)
        Me.MinimumSize = New System.Drawing.Size(950, 861)
        Me.Name = "MonitoringPage"
        Me.Size = New System.Drawing.Size(950, 861)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.BlockPDUAxPDUB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlockPDUBxMB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BlockPDUBxMB As PictureBox
    Friend WithEvents BlockPDUAxPDUB As PictureBox
    Friend WithEvents MBTable As TableForMB
    Friend WithEvents TableForPDUA As TableForPDU
    Friend WithEvents TableForPDUB As TableForPDU
End Class
