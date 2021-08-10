<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Theme_Edit
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Main_Color = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 514)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "主窗口颜色:"
        '
        'Main_Color
        '
        Me.Main_Color.Font = New System.Drawing.Font("宋体", 13.0!)
        Me.Main_Color.Location = New System.Drawing.Point(168, 507)
        Me.Main_Color.Name = "Main_Color"
        Me.Main_Color.Size = New System.Drawing.Size(113, 32)
        Me.Main_Color.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(287, 507)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "提交"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Theme_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1345, 783)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Main_Color)
        Me.Controls.Add(Me.Label1)
        Me.IsMdiContainer = True
        Me.Name = "Theme_Edit"
        Me.Text = "Theme_Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Main_Color As TextBox
    Friend WithEvents Button1 As Button
End Class
