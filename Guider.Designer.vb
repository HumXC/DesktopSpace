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
        Me.Set_Img = New System.Windows.Forms.Button()
        Me.BoxGroup = New System.Windows.Forms.GroupBox()
        Me.BoxInfo = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CreateBox = New System.Windows.Forms.Button()
        Me.AllBoxValue = New System.Windows.Forms.GroupBox()
        Me.L_Spacing_TextBox = New System.Windows.Forms.TextBox()
        Me.B_Spacing_TextBox = New System.Windows.Forms.TextBox()
        Me.Top_Spacing_TextBox = New System.Windows.Forms.TextBox()
        Me.Select_Font = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Inde_BoxValue = New System.Windows.Forms.GroupBox()
        Me.SelectColor = New System.Windows.Forms.Button()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BoxInfo.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AllBoxValue.SuspendLayout()
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
        Me.Lab2.Size = New System.Drawing.Size(525, 102)
        Me.Lab2.TabIndex = 1
        Me.Lab2.Text = "让我来帮助你进行一些简单的设置" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "第二行" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "第三行" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.changePath.Location = New System.Drawing.Point(13, 396)
        Me.changePath.Name = "changePath"
        Me.changePath.Size = New System.Drawing.Size(128, 63)
        Me.changePath.TabIndex = 6
        Me.changePath.Text = "选择路径"
        Me.changePath.UseVisualStyleBackColor = True
        Me.changePath.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Set_Img
        '
        Me.Set_Img.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Set_Img.Location = New System.Drawing.Point(147, 396)
        Me.Set_Img.Name = "Set_Img"
        Me.Set_Img.Size = New System.Drawing.Size(128, 63)
        Me.Set_Img.TabIndex = 13
        Me.Set_Img.Text = "选择图片"
        Me.Set_Img.UseVisualStyleBackColor = True
        Me.Set_Img.Visible = False
        '
        'BoxGroup
        '
        Me.BoxGroup.Location = New System.Drawing.Point(224, 66)
        Me.BoxGroup.Name = "BoxGroup"
        Me.BoxGroup.Size = New System.Drawing.Size(458, 137)
        Me.BoxGroup.TabIndex = 17
        Me.BoxGroup.TabStop = False
        Me.BoxGroup.Text = "桌面一览"
        Me.BoxGroup.Visible = False
        '
        'BoxInfo
        '
        Me.BoxInfo.Controls.Add(Me.Label4)
        Me.BoxInfo.Controls.Add(Me.Label3)
        Me.BoxInfo.Controls.Add(Me.Label2)
        Me.BoxInfo.Controls.Add(Me.Label1)
        Me.BoxInfo.Controls.Add(Me.PictureBox4)
        Me.BoxInfo.Controls.Add(Me.PictureBox3)
        Me.BoxInfo.Controls.Add(Me.PictureBox2)
        Me.BoxInfo.Controls.Add(Me.PictureBox1)
        Me.BoxInfo.Location = New System.Drawing.Point(688, 66)
        Me.BoxInfo.Name = "BoxInfo"
        Me.BoxInfo.Size = New System.Drawing.Size(181, 306)
        Me.BoxInfo.TabIndex = 18
        Me.BoxInfo.TabStop = False
        Me.BoxInfo.Text = "Box元素说明"
        Me.BoxInfo.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "底部标识线"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "标题"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "图标"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "鼠标可以交互的范围"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PictureBox4.Location = New System.Drawing.Point(14, 264)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(154, 11)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.YellowGreen
        Me.PictureBox3.Location = New System.Drawing.Point(14, 222)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(154, 36)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Gold
        Me.PictureBox2.Location = New System.Drawing.Point(38, 86)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(109, 110)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkSalmon
        Me.PictureBox1.Location = New System.Drawing.Point(14, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 193)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'CreateBox
        '
        Me.CreateBox.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.CreateBox.Location = New System.Drawing.Point(13, 396)
        Me.CreateBox.Name = "CreateBox"
        Me.CreateBox.Size = New System.Drawing.Size(128, 63)
        Me.CreateBox.TabIndex = 19
        Me.CreateBox.Text = "添加桌面"
        Me.CreateBox.UseVisualStyleBackColor = True
        Me.CreateBox.Visible = False
        '
        'AllBoxValue
        '
        Me.AllBoxValue.Controls.Add(Me.Button4)
        Me.AllBoxValue.Controls.Add(Me.L_Spacing_TextBox)
        Me.AllBoxValue.Controls.Add(Me.B_Spacing_TextBox)
        Me.AllBoxValue.Controls.Add(Me.Top_Spacing_TextBox)
        Me.AllBoxValue.Controls.Add(Me.Select_Font)
        Me.AllBoxValue.Controls.Add(Me.Label9)
        Me.AllBoxValue.Controls.Add(Me.Label8)
        Me.AllBoxValue.Controls.Add(Me.Label7)
        Me.AllBoxValue.Controls.Add(Me.Label6)
        Me.AllBoxValue.Controls.Add(Me.Label5)
        Me.AllBoxValue.Location = New System.Drawing.Point(13, 66)
        Me.AllBoxValue.Name = "AllBoxValue"
        Me.AllBoxValue.Size = New System.Drawing.Size(205, 316)
        Me.AllBoxValue.TabIndex = 20
        Me.AllBoxValue.TabStop = False
        Me.AllBoxValue.Text = "共同参数"
        Me.AllBoxValue.Visible = False
        '
        'L_Spacing_TextBox
        '
        Me.L_Spacing_TextBox.Location = New System.Drawing.Point(95, 86)
        Me.L_Spacing_TextBox.Name = "L_Spacing_TextBox"
        Me.L_Spacing_TextBox.Size = New System.Drawing.Size(100, 25)
        Me.L_Spacing_TextBox.TabIndex = 26
        '
        'B_Spacing_TextBox
        '
        Me.B_Spacing_TextBox.Location = New System.Drawing.Point(95, 22)
        Me.B_Spacing_TextBox.Name = "B_Spacing_TextBox"
        Me.B_Spacing_TextBox.Size = New System.Drawing.Size(100, 25)
        Me.B_Spacing_TextBox.TabIndex = 25
        '
        'Top_Spacing_TextBox
        '
        Me.Top_Spacing_TextBox.Location = New System.Drawing.Point(95, 54)
        Me.Top_Spacing_TextBox.Name = "Top_Spacing_TextBox"
        Me.Top_Spacing_TextBox.Size = New System.Drawing.Size(100, 25)
        Me.Top_Spacing_TextBox.TabIndex = 24
        '
        'Select_Font
        '
        Me.Select_Font.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Select_Font.Location = New System.Drawing.Point(95, 149)
        Me.Select_Font.Name = "Select_Font"
        Me.Select_Font.Size = New System.Drawing.Size(98, 25)
        Me.Select_Font.TabIndex = 23
        Me.Select_Font.Text = "选择字体"
        Me.Select_Font.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(6, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 20)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "标题颜色"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(6, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 20)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "标题字体"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(6, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "左右空间"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(6, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "顶部空间"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(46, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "间距"
        '
        'Inde_BoxValue
        '
        Me.Inde_BoxValue.Location = New System.Drawing.Point(224, 210)
        Me.Inde_BoxValue.Name = "Inde_BoxValue"
        Me.Inde_BoxValue.Size = New System.Drawing.Size(458, 172)
        Me.Inde_BoxValue.TabIndex = 21
        Me.Inde_BoxValue.TabStop = False
        Me.Inde_BoxValue.Text = "独立参数"
        Me.Inde_BoxValue.Visible = False
        '
        'SelectColor
        '
        Me.SelectColor.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.SelectColor.Location = New System.Drawing.Point(13, 396)
        Me.SelectColor.Name = "SelectColor"
        Me.SelectColor.Size = New System.Drawing.Size(128, 63)
        Me.SelectColor.TabIndex = 22
        Me.SelectColor.Text = "选择颜色"
        Me.SelectColor.UseVisualStyleBackColor = True
        Me.SelectColor.Visible = False
        '
        'FontDialog1
        '
        Me.FontDialog1.ShowEffects = False
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Button4.Location = New System.Drawing.Point(95, 115)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 25)
        Me.Button4.TabIndex = 27
        Me.Button4.Text = "选择颜色"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Guider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 471)
        Me.Controls.Add(Me.AllBoxValue)
        Me.Controls.Add(Me.Inde_BoxValue)
        Me.Controls.Add(Me.CreateBox)
        Me.Controls.Add(Me.BoxGroup)
        Me.Controls.Add(Me.Set_Img)
        Me.Controls.Add(Me.changePath)
        Me.Controls.Add(Me.PathBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Lab2)
        Me.Controls.Add(Me.Lab1)
        Me.Controls.Add(Me.BoxInfo)
        Me.Controls.Add(Me.SelectColor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(899, 518)
        Me.MinimumSize = New System.Drawing.Size(899, 518)
        Me.Name = "Guider"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "设置向导"
        Me.BoxInfo.ResumeLayout(False)
        Me.BoxInfo.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AllBoxValue.ResumeLayout(False)
        Me.AllBoxValue.PerformLayout()
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
    Friend WithEvents Set_Img As Button
    Friend WithEvents BoxGroup As GroupBox
    Friend WithEvents BoxInfo As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CreateBox As Button
    Friend WithEvents AllBoxValue As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Inde_BoxValue As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents SelectColor As Button
    Friend WithEvents L_Spacing_TextBox As TextBox
    Friend WithEvents B_Spacing_TextBox As TextBox
    Friend WithEvents Top_Spacing_TextBox As TextBox
    Friend WithEvents Select_Font As Button
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents Button4 As Button
End Class
