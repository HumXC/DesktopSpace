<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guider
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.RedBar = New System.Windows.Forms.TrackBar()
        Me.GreenBar = New System.Windows.Forms.TrackBar()
        Me.BlueBar = New System.Windows.Forms.TrackBar()
        Me.Set_Img = New System.Windows.Forms.Button()
        Me.RedValue = New System.Windows.Forms.TextBox()
        Me.GreenValue = New System.Windows.Forms.TextBox()
        Me.BlueValue = New System.Windows.Forms.TextBox()
        CType(Me.RedBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GreenBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlueBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lab1
        '
        Me.Lab1.AutoSize = True
        Me.Lab1.Font = New System.Drawing.Font("宋体", 26.0!)
        Me.Lab1.Location = New System.Drawing.Point(12, 9)
        Me.Lab1.Name = "Lab1"
        Me.Lab1.Size = New System.Drawing.Size(196, 44)
        Me.Lab1.TabIndex = 0
        Me.Lab1.Text = "设置向导"
        '
        'Lab2
        '
        Me.Lab2.AutoSize = True
        Me.Lab2.Font = New System.Drawing.Font("宋体", 20.0!)
        Me.Lab2.Location = New System.Drawing.Point(20, 73)
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
        Me.PathBox.Location = New System.Drawing.Point(13, 344)
        Me.PathBox.Name = "PathBox"
        Me.PathBox.Size = New System.Drawing.Size(856, 38)
        Me.PathBox.TabIndex = 5
        Me.PathBox.Visible = False
        '
        'changePath
        '
        Me.changePath.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.changePath.Location = New System.Drawing.Point(13, 296)
        Me.changePath.Name = "changePath"
        Me.changePath.Size = New System.Drawing.Size(135, 42)
        Me.changePath.TabIndex = 6
        Me.changePath.Text = "选择路径"
        Me.changePath.UseVisualStyleBackColor = True
        Me.changePath.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'RedBar
        '
        Me.RedBar.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.RedBar.LargeChange = 1
        Me.RedBar.Location = New System.Drawing.Point(26, 210)
        Me.RedBar.Maximum = 255
        Me.RedBar.Name = "RedBar"
        Me.RedBar.Size = New System.Drawing.Size(783, 56)
        Me.RedBar.TabIndex = 7
        Me.RedBar.Visible = False
        '
        'GreenBar
        '
        Me.GreenBar.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.GreenBar.LargeChange = 1
        Me.GreenBar.Location = New System.Drawing.Point(27, 272)
        Me.GreenBar.Maximum = 255
        Me.GreenBar.Name = "GreenBar"
        Me.GreenBar.Size = New System.Drawing.Size(783, 56)
        Me.GreenBar.TabIndex = 9
        Me.GreenBar.Visible = False
        '
        'BlueBar
        '
        Me.BlueBar.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.BlueBar.LargeChange = 1
        Me.BlueBar.Location = New System.Drawing.Point(26, 334)
        Me.BlueBar.Maximum = 255
        Me.BlueBar.Name = "BlueBar"
        Me.BlueBar.Size = New System.Drawing.Size(783, 56)
        Me.BlueBar.TabIndex = 10
        Me.BlueBar.Visible = False
        '
        'Set_Img
        '
        Me.Set_Img.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Set_Img.Location = New System.Drawing.Point(12, 396)
        Me.Set_Img.Name = "Set_Img"
        Me.Set_Img.Size = New System.Drawing.Size(128, 63)
        Me.Set_Img.TabIndex = 13
        Me.Set_Img.Text = "选择图片"
        Me.Set_Img.UseVisualStyleBackColor = True
        '
        'RedValue
        '
        Me.RedValue.Font = New System.Drawing.Font("宋体", 15.0!)
        Me.RedValue.Location = New System.Drawing.Point(811, 210)
        Me.RedValue.Name = "RedValue"
        Me.RedValue.Size = New System.Drawing.Size(58, 36)
        Me.RedValue.TabIndex = 14
        Me.RedValue.Visible = False
        '
        'GreenValue
        '
        Me.GreenValue.Font = New System.Drawing.Font("宋体", 15.0!)
        Me.GreenValue.Location = New System.Drawing.Point(811, 272)
        Me.GreenValue.Name = "GreenValue"
        Me.GreenValue.Size = New System.Drawing.Size(58, 36)
        Me.GreenValue.TabIndex = 15
        Me.GreenValue.Visible = False
        '
        'BlueValue
        '
        Me.BlueValue.Font = New System.Drawing.Font("宋体", 15.0!)
        Me.BlueValue.Location = New System.Drawing.Point(811, 334)
        Me.BlueValue.Name = "BlueValue"
        Me.BlueValue.Size = New System.Drawing.Size(58, 36)
        Me.BlueValue.TabIndex = 16
        Me.BlueValue.Visible = False
        '
        'Guider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 471)
        Me.Controls.Add(Me.BlueValue)
        Me.Controls.Add(Me.GreenValue)
        Me.Controls.Add(Me.RedValue)
        Me.Controls.Add(Me.Set_Img)
        Me.Controls.Add(Me.BlueBar)
        Me.Controls.Add(Me.GreenBar)
        Me.Controls.Add(Me.RedBar)
        Me.Controls.Add(Me.changePath)
        Me.Controls.Add(Me.PathBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Lab2)
        Me.Controls.Add(Me.Lab1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(899, 518)
        Me.MinimumSize = New System.Drawing.Size(899, 518)
        Me.Name = "Guider"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "设置向导"
        CType(Me.RedBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GreenBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlueBar, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RedBar As TrackBar
    Friend WithEvents GreenBar As TrackBar
    Friend WithEvents BlueBar As TrackBar
    Friend WithEvents Set_Img As Button
    Friend WithEvents RedValue As TextBox
    Friend WithEvents GreenValue As TextBox
    Friend WithEvents BlueValue As TextBox
End Class
