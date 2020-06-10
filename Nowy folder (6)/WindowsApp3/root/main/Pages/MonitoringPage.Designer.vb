<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonitoringPage
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableForPDUA = New WindowsApp3.TableForPDU_New_()
        Me.TableForPDUB = New WindowsApp3.TableForPDU_New_()
        Me.TableForMB = New WindowsApp3.TableForPDU_New_()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Controls.Add(Me.TableForPDUA)
        Me.FlowLayoutPanel1.Controls.Add(Me.TableForPDUB)
        Me.FlowLayoutPanel1.Controls.Add(Me.TableForMB)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(15, 14)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(921, 652)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'TableForPDUA
        '
        Me.TableForPDUA.AutoSize = True
        Me.TableForPDUA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableForPDUA.Location = New System.Drawing.Point(3, 3)
        Me.TableForPDUA.Margin = New System.Windows.Forms.Padding(3, 3, 3, 30)
        Me.TableForPDUA.MaximumSize = New System.Drawing.Size(912, 0)
        Me.TableForPDUA.MinimumSize = New System.Drawing.Size(912, 80)
        Me.TableForPDUA.Name = "TableForPDUA"
        Me.TableForPDUA.Size = New System.Drawing.Size(912, 80)
        Me.TableForPDUA.TabIndex = 0
        Me.TableForPDUA.Visible = False
        '
        'TableForPDUB
        '
        Me.TableForPDUB.AutoSize = True
        Me.TableForPDUB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableForPDUB.Location = New System.Drawing.Point(3, 116)
        Me.TableForPDUB.Margin = New System.Windows.Forms.Padding(3, 3, 3, 30)
        Me.TableForPDUB.MaximumSize = New System.Drawing.Size(912, 0)
        Me.TableForPDUB.MinimumSize = New System.Drawing.Size(912, 80)
        Me.TableForPDUB.Name = "TableForPDUB"
        Me.TableForPDUB.Size = New System.Drawing.Size(912, 80)
        Me.TableForPDUB.TabIndex = 1
        Me.TableForPDUB.Visible = False
        '
        'TableForMB
        '
        Me.TableForMB.AutoSize = True
        Me.TableForMB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableForMB.Location = New System.Drawing.Point(3, 229)
        Me.TableForMB.Margin = New System.Windows.Forms.Padding(3, 3, 3, 30)
        Me.TableForMB.MaximumSize = New System.Drawing.Size(912, 0)
        Me.TableForMB.MinimumSize = New System.Drawing.Size(912, 80)
        Me.TableForMB.Name = "TableForMB"
        Me.TableForMB.Size = New System.Drawing.Size(912, 80)
        Me.TableForMB.TabIndex = 2
        Me.TableForMB.Visible = False
        '
        'MonitoringPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "MonitoringPage"
        Me.Size = New System.Drawing.Size(950, 681)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents TableForPDUA As TableForPDU_New_
    Friend WithEvents TableForPDUB As TableForPDU_New_
    Friend WithEvents TableForMB As TableForPDU_New_
End Class
