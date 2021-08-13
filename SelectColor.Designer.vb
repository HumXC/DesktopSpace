<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectColor
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
        Me.ColorEnter = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BlueValue = New System.Windows.Forms.TextBox()
        Me.GreenValue = New System.Windows.Forms.TextBox()
        Me.RedValue = New System.Windows.Forms.TextBox()
        Me.BlueBar = New System.Windows.Forms.TrackBar()
        Me.GreenBar = New System.Windows.Forms.TrackBar()
        Me.RedBar = New System.Windows.Forms.TrackBar()
        CType(Me.BlueBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GreenBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RedBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColorEnter
        '
        Me.ColorEnter.Font = New System.Drawing.Font("宋体", 30.0!, System.Drawing.FontStyle.Bold)
        Me.ColorEnter.Location = New System.Drawing.Point(628, 25)
        Me.ColorEnter.Name = "ColorEnter"
        Me.ColorEnter.Size = New System.Drawing.Size(128, 160)
        Me.ColorEnter.TabIndex = 37
        Me.ColorEnter.Text = "确定"
        Me.ColorEnter.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("宋体", 18.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(35, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 30)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "蓝色"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("宋体", 18.0!)
        Me.Label2.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label2.Location = New System.Drawing.Point(35, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 30)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "绿色"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("宋体", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(35, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 30)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "红色"
        '
        'BlueValue
        '
        Me.BlueValue.Font = New System.Drawing.Font("宋体", 15.0!)
        Me.BlueValue.Location = New System.Drawing.Point(553, 149)
        Me.BlueValue.Name = "BlueValue"
        Me.BlueValue.Size = New System.Drawing.Size(45, 36)
        Me.BlueValue.TabIndex = 33
        Me.BlueValue.Text = "0"
        '
        'GreenValue
        '
        Me.GreenValue.Font = New System.Drawing.Font("宋体", 15.0!)
        Me.GreenValue.Location = New System.Drawing.Point(552, 87)
        Me.GreenValue.Name = "GreenValue"
        Me.GreenValue.Size = New System.Drawing.Size(45, 36)
        Me.GreenValue.TabIndex = 32
        Me.GreenValue.Text = "0"
        '
        'RedValue
        '
        Me.RedValue.Font = New System.Drawing.Font("宋体", 15.0!)
        Me.RedValue.Location = New System.Drawing.Point(553, 25)
        Me.RedValue.Name = "RedValue"
        Me.RedValue.Size = New System.Drawing.Size(45, 36)
        Me.RedValue.TabIndex = 31
        Me.RedValue.Text = "0"
        '
        'BlueBar
        '
        Me.BlueBar.Cursor = System.Windows.Forms.Cursors.Default
        Me.BlueBar.LargeChange = 1
        Me.BlueBar.Location = New System.Drawing.Point(106, 149)
        Me.BlueBar.Maximum = 255
        Me.BlueBar.Name = "BlueBar"
        Me.BlueBar.Size = New System.Drawing.Size(441, 56)
        Me.BlueBar.TabIndex = 30
        '
        'GreenBar
        '
        Me.GreenBar.Cursor = System.Windows.Forms.Cursors.Default
        Me.GreenBar.LargeChange = 1
        Me.GreenBar.Location = New System.Drawing.Point(106, 87)
        Me.GreenBar.Maximum = 255
        Me.GreenBar.Name = "GreenBar"
        Me.GreenBar.Size = New System.Drawing.Size(441, 56)
        Me.GreenBar.TabIndex = 29
        '
        'RedBar
        '
        Me.RedBar.Cursor = System.Windows.Forms.Cursors.Default
        Me.RedBar.LargeChange = 1
        Me.RedBar.Location = New System.Drawing.Point(106, 25)
        Me.RedBar.Maximum = 255
        Me.RedBar.Name = "RedBar"
        Me.RedBar.Size = New System.Drawing.Size(441, 56)
        Me.RedBar.TabIndex = 28
        '
        'SelectColor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 209)
        Me.Controls.Add(Me.ColorEnter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BlueValue)
        Me.Controls.Add(Me.GreenValue)
        Me.Controls.Add(Me.RedValue)
        Me.Controls.Add(Me.BlueBar)
        Me.Controls.Add(Me.GreenBar)
        Me.Controls.Add(Me.RedBar)
        Me.Name = "SelectColor"
        Me.Text = "CelecteColor"
        CType(Me.BlueBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GreenBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RedBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ColorEnter As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BlueValue As TextBox
    Friend WithEvents GreenValue As TextBox
    Friend WithEvents RedValue As TextBox
    Friend WithEvents BlueBar As TrackBar
    Friend WithEvents GreenBar As TrackBar
    Friend WithEvents RedBar As TrackBar
End Class
