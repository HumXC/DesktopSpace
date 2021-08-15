<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Guider
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Guider))
        Me.Lab1 = New System.Windows.Forms.Label()
        Me.Lab2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PathBox = New System.Windows.Forms.TextBox()
        Me.changePath = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Lab1
        '
        Me.Lab1.AutoSize = True
        Me.Lab1.Font = New System.Drawing.Font("宋体", 26.0!)
        Me.Lab1.Location = New System.Drawing.Point(12, 21)
        Me.Lab1.Name = "Lab1"
        Me.Lab1.Size = New System.Drawing.Size(196, 44)
        Me.Lab1.TabIndex = 0
        Me.Lab1.Text = "设置向导"
        '
        'Lab2
        '
        Me.Lab2.AutoSize = True
        Me.Lab2.Font = New System.Drawing.Font("宋体", 20.0!)
        Me.Lab2.Location = New System.Drawing.Point(14, 92)
        Me.Lab2.Name = "Lab2"
        Me.Lab2.Size = New System.Drawing.Size(525, 34)
        Me.Lab2.TabIndex = 1
        Me.Lab2.Text = "让我来帮助你进行一些简单的设置"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(741, 396)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 63)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "下一步"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Button2.Location = New System.Drawing.Point(607, 396)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 63)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "上一步"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(824, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(45, 40)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "0"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PathBox
        '
        Me.PathBox.Font = New System.Drawing.Font("宋体", 16.0!)
        Me.PathBox.Location = New System.Drawing.Point(12, 352)
        Me.PathBox.Name = "PathBox"
        Me.PathBox.Size = New System.Drawing.Size(856, 38)
        Me.PathBox.TabIndex = 5
        Me.PathBox.Visible = False
        '
        'changePath
        '
        Me.changePath.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.changePath.Location = New System.Drawing.Point(12, 396)
        Me.changePath.Name = "changePath"
        Me.changePath.Size = New System.Drawing.Size(128, 63)
        Me.changePath.TabIndex = 6
        Me.changePath.Text = "选择路径"
        Me.changePath.UseVisualStyleBackColor = True
        Me.changePath.Visible = False
        '
        'Timer1
        '
        '
        'Guider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 471)
        Me.Controls.Add(Me.changePath)
        Me.Controls.Add(Me.PathBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Lab2)
        Me.Controls.Add(Me.Lab1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(899, 518)
        Me.MinimumSize = New System.Drawing.Size(899, 518)
        Me.Name = "Guider"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "设置向导"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lab1 As Label
    Friend WithEvents Lab2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PathBox As TextBox
    Friend WithEvents changePath As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Timer1 As Timer
End Class
