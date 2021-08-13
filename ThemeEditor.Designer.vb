<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThemeEditor
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
        Me.Delete_aBox = New System.Windows.Forms.Button()
        Me.Add_aBox = New System.Windows.Forms.Button()
        Me.Icon_E = New System.Windows.Forms.PictureBox()
        Me.Icon_X = New System.Windows.Forms.TrackBar()
        Me.Icon_Y = New System.Windows.Forms.TrackBar()
        Me.Icon_LY = New System.Windows.Forms.TrackBar()
        Me.Icon_LX = New System.Windows.Forms.TrackBar()
        Me.Box_E = New System.Windows.Forms.PictureBox()
        Me.Set_Center = New System.Windows.Forms.Button()
        Me.Open_img = New System.Windows.Forms.Button()
        Me.Img_Path = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BackColor_Off = New System.Windows.Forms.Button()
        Me.BackColor_On = New System.Windows.Forms.Button()
        Me.Apply_Img = New System.Windows.Forms.Button()
        Me.Titel_Text = New System.Windows.Forms.TextBox()
        Me.Change_Titel_Text = New System.Windows.Forms.Button()
        Me.Change_Main_Color = New System.Windows.Forms.Button()
        Me.Change_Titel_Color = New System.Windows.Forms.Button()
        Me.Change_Line_Color = New System.Windows.Forms.Button()
        Me.Change_Line_2Color = New System.Windows.Forms.Button()
        Me.Change_Titel_Font = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.U_Padding = New System.Windows.Forms.TextBox()
        Me.L_Padding = New System.Windows.Forms.TextBox()
        Me.B_Spacing = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Apply_UPL = New System.Windows.Forms.Button()
        Me.图标编辑 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBoxY = New System.Windows.Forms.GroupBox()
        Me.主界面背景路径 = New System.Windows.Forms.TextBox()
        Me.应用主界面图片 = New System.Windows.Forms.Button()
        Me.更换主界面背景颜色 = New System.Windows.Forms.Button()
        Me.向右移动 = New System.Windows.Forms.Button()
        Me.向左移动 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.当前主界面大小 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.初始桌面路径 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.桌面空间所在路径 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BoxInfo = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.可交互范围X = New System.Windows.Forms.TextBox()
        Me.可交互范围Y = New System.Windows.Forms.TextBox()
        Me.Apply2 = New System.Windows.Forms.Button()
        CType(Me.Icon_E, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_X, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_Y, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_LY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_LX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Box_E, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.图标编辑.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBoxY.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.BoxInfo.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Delete_aBox
        '
        Me.Delete_aBox.Location = New System.Drawing.Point(12, 306)
        Me.Delete_aBox.Name = "Delete_aBox"
        Me.Delete_aBox.Size = New System.Drawing.Size(104, 68)
        Me.Delete_aBox.TabIndex = 1
        Me.Delete_aBox.Text = "删除桌面"
        Me.Delete_aBox.UseVisualStyleBackColor = True
        '
        'Add_aBox
        '
        Me.Add_aBox.Location = New System.Drawing.Point(134, 306)
        Me.Add_aBox.Name = "Add_aBox"
        Me.Add_aBox.Size = New System.Drawing.Size(104, 68)
        Me.Add_aBox.TabIndex = 2
        Me.Add_aBox.Text = "添加桌面"
        Me.Add_aBox.UseVisualStyleBackColor = True
        '
        'Icon_E
        '
        Me.Icon_E.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Icon_E.Location = New System.Drawing.Point(221, 243)
        Me.Icon_E.Name = "Icon_E"
        Me.Icon_E.Size = New System.Drawing.Size(66, 62)
        Me.Icon_E.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Icon_E.TabIndex = 3
        Me.Icon_E.TabStop = False
        '
        'Icon_X
        '
        Me.Icon_X.Location = New System.Drawing.Point(163, 156)
        Me.Icon_X.Name = "Icon_X"
        Me.Icon_X.RightToLeftLayout = True
        Me.Icon_X.Size = New System.Drawing.Size(214, 56)
        Me.Icon_X.TabIndex = 11
        '
        'Icon_Y
        '
        Me.Icon_Y.Location = New System.Drawing.Point(123, 195)
        Me.Icon_Y.Name = "Icon_Y"
        Me.Icon_Y.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.Icon_Y.Size = New System.Drawing.Size(56, 202)
        Me.Icon_Y.TabIndex = 12
        '
        'Icon_LY
        '
        Me.Icon_LY.Location = New System.Drawing.Point(67, 195)
        Me.Icon_LY.Name = "Icon_LY"
        Me.Icon_LY.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.Icon_LY.Size = New System.Drawing.Size(56, 202)
        Me.Icon_LY.TabIndex = 16
        '
        'Icon_LX
        '
        Me.Icon_LX.BackColor = System.Drawing.SystemColors.Control
        Me.Icon_LX.Location = New System.Drawing.Point(163, 100)
        Me.Icon_LX.Name = "Icon_LX"
        Me.Icon_LX.RightToLeftLayout = True
        Me.Icon_LX.Size = New System.Drawing.Size(214, 56)
        Me.Icon_LX.TabIndex = 17
        '
        'Box_E
        '
        Me.Box_E.BackColor = System.Drawing.Color.Orange
        Me.Box_E.Location = New System.Drawing.Point(180, 212)
        Me.Box_E.Name = "Box_E"
        Me.Box_E.Size = New System.Drawing.Size(198, 186)
        Me.Box_E.TabIndex = 18
        Me.Box_E.TabStop = False
        '
        'Set_Center
        '
        Me.Set_Center.Location = New System.Drawing.Point(67, 100)
        Me.Set_Center.Name = "Set_Center"
        Me.Set_Center.Size = New System.Drawing.Size(81, 79)
        Me.Set_Center.TabIndex = 20
        Me.Set_Center.Text = "居中"
        Me.Set_Center.UseVisualStyleBackColor = True
        '
        'Open_img
        '
        Me.Open_img.Location = New System.Drawing.Point(28, 24)
        Me.Open_img.Name = "Open_img"
        Me.Open_img.Size = New System.Drawing.Size(80, 64)
        Me.Open_img.TabIndex = 21
        Me.Open_img.Text = "选择图片"
        Me.Open_img.UseVisualStyleBackColor = True
        '
        'Img_Path
        '
        Me.Img_Path.Location = New System.Drawing.Point(114, 53)
        Me.Img_Path.Name = "Img_Path"
        Me.Img_Path.Size = New System.Drawing.Size(298, 25)
        Me.Img_Path.TabIndex = 22
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BackColor_Off
        '
        Me.BackColor_Off.Location = New System.Drawing.Point(265, 306)
        Me.BackColor_Off.Name = "BackColor_Off"
        Me.BackColor_Off.Size = New System.Drawing.Size(81, 68)
        Me.BackColor_Off.TabIndex = 23
        Me.BackColor_Off.Text = "关闭背景"
        Me.BackColor_Off.UseVisualStyleBackColor = True
        '
        'BackColor_On
        '
        Me.BackColor_On.Location = New System.Drawing.Point(352, 306)
        Me.BackColor_On.Name = "BackColor_On"
        Me.BackColor_On.Size = New System.Drawing.Size(81, 68)
        Me.BackColor_On.TabIndex = 24
        Me.BackColor_On.Text = "开启背景"
        Me.BackColor_On.UseVisualStyleBackColor = True
        '
        'Apply_Img
        '
        Me.Apply_Img.Location = New System.Drawing.Point(419, 53)
        Me.Apply_Img.Name = "Apply_Img"
        Me.Apply_Img.Size = New System.Drawing.Size(75, 23)
        Me.Apply_Img.TabIndex = 25
        Me.Apply_Img.Text = "应用图片"
        Me.Apply_Img.UseVisualStyleBackColor = True
        '
        'Titel_Text
        '
        Me.Titel_Text.Location = New System.Drawing.Point(30, 165)
        Me.Titel_Text.Name = "Titel_Text"
        Me.Titel_Text.Size = New System.Drawing.Size(171, 25)
        Me.Titel_Text.TabIndex = 26
        '
        'Change_Titel_Text
        '
        Me.Change_Titel_Text.Location = New System.Drawing.Point(142, 95)
        Me.Change_Titel_Text.Name = "Change_Titel_Text"
        Me.Change_Titel_Text.Size = New System.Drawing.Size(80, 64)
        Me.Change_Titel_Text.TabIndex = 27
        Me.Change_Titel_Text.Text = "更改标题"
        Me.Change_Titel_Text.UseVisualStyleBackColor = True
        '
        'Change_Main_Color
        '
        Me.Change_Main_Color.Location = New System.Drawing.Point(16, 24)
        Me.Change_Main_Color.Name = "Change_Main_Color"
        Me.Change_Main_Color.Size = New System.Drawing.Size(106, 64)
        Me.Change_Main_Color.TabIndex = 28
        Me.Change_Main_Color.Text = "更换背景颜色"
        Me.Change_Main_Color.UseVisualStyleBackColor = True
        '
        'Change_Titel_Color
        '
        Me.Change_Titel_Color.Location = New System.Drawing.Point(30, 95)
        Me.Change_Titel_Color.Name = "Change_Titel_Color"
        Me.Change_Titel_Color.Size = New System.Drawing.Size(106, 64)
        Me.Change_Titel_Color.TabIndex = 30
        Me.Change_Titel_Color.Text = "更换标题颜色"
        Me.Change_Titel_Color.UseVisualStyleBackColor = True
        '
        'Change_Line_Color
        '
        Me.Change_Line_Color.Location = New System.Drawing.Point(98, 180)
        Me.Change_Line_Color.Name = "Change_Line_Color"
        Me.Change_Line_Color.Size = New System.Drawing.Size(106, 64)
        Me.Change_Line_Color.TabIndex = 32
        Me.Change_Line_Color.Text = "更换标线颜色"
        Me.Change_Line_Color.UseVisualStyleBackColor = True
        '
        'Change_Line_2Color
        '
        Me.Change_Line_2Color.Location = New System.Drawing.Point(98, 250)
        Me.Change_Line_2Color.Name = "Change_Line_2Color"
        Me.Change_Line_2Color.Size = New System.Drawing.Size(106, 64)
        Me.Change_Line_2Color.TabIndex = 33
        Me.Change_Line_2Color.Text = "更换鼠标悬停时标线颜色"
        Me.Change_Line_2Color.UseVisualStyleBackColor = True
        '
        'Change_Titel_Font
        '
        Me.Change_Titel_Font.Location = New System.Drawing.Point(222, 165)
        Me.Change_Titel_Font.Name = "Change_Titel_Font"
        Me.Change_Titel_Font.Size = New System.Drawing.Size(80, 64)
        Me.Change_Titel_Font.TabIndex = 35
        Me.Change_Titel_Font.Text = "更改标题字体"
        Me.Change_Titel_Font.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(119, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 27)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "顶部间距"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 16.0!)
        Me.Label2.Location = New System.Drawing.Point(119, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 27)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "左右间距"
        '
        'U_Padding
        '
        Me.U_Padding.Location = New System.Drawing.Point(245, 63)
        Me.U_Padding.Name = "U_Padding"
        Me.U_Padding.Size = New System.Drawing.Size(106, 25)
        Me.U_Padding.TabIndex = 38
        '
        'L_Padding
        '
        Me.L_Padding.Location = New System.Drawing.Point(245, 111)
        Me.L_Padding.Name = "L_Padding"
        Me.L_Padding.Size = New System.Drawing.Size(106, 25)
        Me.L_Padding.TabIndex = 39
        '
        'B_Spacing
        '
        Me.B_Spacing.Location = New System.Drawing.Point(245, 148)
        Me.B_Spacing.Name = "B_Spacing"
        Me.B_Spacing.Size = New System.Drawing.Size(106, 25)
        Me.B_Spacing.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 16.0!)
        Me.Label3.Location = New System.Drawing.Point(155, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 27)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "间隔"
        '
        'Apply_UPL
        '
        Me.Apply_UPL.Location = New System.Drawing.Point(374, 61)
        Me.Apply_UPL.Name = "Apply_UPL"
        Me.Apply_UPL.Size = New System.Drawing.Size(80, 189)
        Me.Apply_UPL.TabIndex = 42
        Me.Apply_UPL.Text = "应用"
        Me.Apply_UPL.UseVisualStyleBackColor = True
        '
        '图标编辑
        '
        Me.图标编辑.Controls.Add(Me.Apply2)
        Me.图标编辑.Controls.Add(Me.可交互范围Y)
        Me.图标编辑.Controls.Add(Me.Icon_X)
        Me.图标编辑.Controls.Add(Me.Label11)
        Me.图标编辑.Controls.Add(Me.可交互范围X)
        Me.图标编辑.Controls.Add(Me.Icon_E)
        Me.图标编辑.Controls.Add(Me.Icon_Y)
        Me.图标编辑.Controls.Add(Me.Icon_LY)
        Me.图标编辑.Controls.Add(Me.Icon_LX)
        Me.图标编辑.Controls.Add(Me.Set_Center)
        Me.图标编辑.Controls.Add(Me.Img_Path)
        Me.图标编辑.Controls.Add(Me.Apply_Img)
        Me.图标编辑.Controls.Add(Me.Open_img)
        Me.图标编辑.Controls.Add(Me.Box_E)
        Me.图标编辑.Location = New System.Drawing.Point(359, 410)
        Me.图标编辑.Name = "图标编辑"
        Me.图标编辑.Size = New System.Drawing.Size(495, 508)
        Me.图标编辑.TabIndex = 43
        Me.图标编辑.TabStop = False
        Me.图标编辑.Text = "图标样式"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Change_Line_2Color)
        Me.GroupBox1.Controls.Add(Me.Change_Line_Color)
        Me.GroupBox1.Location = New System.Drawing.Point(875, 421)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 352)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "标识线样式"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Titel_Text)
        Me.GroupBox2.Controls.Add(Me.Change_Titel_Color)
        Me.GroupBox2.Controls.Add(Me.Change_Titel_Text)
        Me.GroupBox2.Controls.Add(Me.Change_Titel_Font)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 421)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(327, 280)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "标题样式"
        '
        'GroupBoxY
        '
        Me.GroupBoxY.Controls.Add(Me.BoxInfo)
        Me.GroupBoxY.Controls.Add(Me.当前主界面大小)
        Me.GroupBoxY.Controls.Add(Me.Label4)
        Me.GroupBoxY.Controls.Add(Me.主界面背景路径)
        Me.GroupBoxY.Controls.Add(Me.应用主界面图片)
        Me.GroupBoxY.Controls.Add(Me.Change_Main_Color)
        Me.GroupBoxY.Controls.Add(Me.更换主界面背景颜色)
        Me.GroupBoxY.Controls.Add(Me.Label1)
        Me.GroupBoxY.Controls.Add(Me.Label2)
        Me.GroupBoxY.Controls.Add(Me.U_Padding)
        Me.GroupBoxY.Controls.Add(Me.Apply_UPL)
        Me.GroupBoxY.Controls.Add(Me.L_Padding)
        Me.GroupBoxY.Controls.Add(Me.B_Spacing)
        Me.GroupBoxY.Controls.Add(Me.Label3)
        Me.GroupBoxY.Location = New System.Drawing.Point(1143, 398)
        Me.GroupBoxY.Name = "GroupBoxY"
        Me.GroupBoxY.Size = New System.Drawing.Size(530, 387)
        Me.GroupBoxY.TabIndex = 46
        Me.GroupBoxY.TabStop = False
        Me.GroupBoxY.Text = "主界面样式"
        '
        '主界面背景路径
        '
        Me.主界面背景路径.Location = New System.Drawing.Point(74, 323)
        Me.主界面背景路径.Name = "主界面背景路径"
        Me.主界面背景路径.Size = New System.Drawing.Size(298, 25)
        Me.主界面背景路径.TabIndex = 27
        '
        '应用主界面图片
        '
        Me.应用主界面图片.Location = New System.Drawing.Point(379, 323)
        Me.应用主界面图片.Name = "应用主界面图片"
        Me.应用主界面图片.Size = New System.Drawing.Size(75, 23)
        Me.应用主界面图片.TabIndex = 28
        Me.应用主界面图片.Text = "应用图片"
        Me.应用主界面图片.UseVisualStyleBackColor = True
        '
        '更换主界面背景颜色
        '
        Me.更换主界面背景颜色.Location = New System.Drawing.Point(-12, 294)
        Me.更换主界面背景颜色.Name = "更换主界面背景颜色"
        Me.更换主界面背景颜色.Size = New System.Drawing.Size(80, 64)
        Me.更换主界面背景颜色.TabIndex = 26
        Me.更换主界面背景颜色.Text = "选择图片"
        Me.更换主界面背景颜色.UseVisualStyleBackColor = True
        '
        '向右移动
        '
        Me.向右移动.Location = New System.Drawing.Point(12, 277)
        Me.向右移动.Name = "向右移动"
        Me.向右移动.Size = New System.Drawing.Size(75, 23)
        Me.向右移动.TabIndex = 48
        Me.向右移动.Text = "向右移动"
        Me.向右移动.UseVisualStyleBackColor = True
        '
        '向左移动
        '
        Me.向左移动.Location = New System.Drawing.Point(1598, 306)
        Me.向左移动.Name = "向左移动"
        Me.向左移动.Size = New System.Drawing.Size(75, 23)
        Me.向左移动.TabIndex = 49
        Me.向左移动.Text = "向左移动"
        Me.向左移动.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(183, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 15)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "当前主界面大小"
        '
        '当前主界面大小
        '
        Me.当前主界面大小.Location = New System.Drawing.Point(301, 20)
        Me.当前主界面大小.Name = "当前主界面大小"
        Me.当前主界面大小.Size = New System.Drawing.Size(192, 25)
        Me.当前主界面大小.TabIndex = 44
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.桌面空间所在路径)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.初始桌面路径)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 707)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(330, 219)
        Me.GroupBox4.TabIndex = 51
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "程序设置"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "初始桌面路径"
        '
        '初始桌面路径
        '
        Me.初始桌面路径.Location = New System.Drawing.Point(118, 18)
        Me.初始桌面路径.Name = "初始桌面路径"
        Me.初始桌面路径.Size = New System.Drawing.Size(171, 25)
        Me.初始桌面路径.TabIndex = 36
        Me.初始桌面路径.Text = "无法获取"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 15)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "桌面空间所在路径"
        '
        '桌面空间所在路径
        '
        Me.桌面空间所在路径.Location = New System.Drawing.Point(138, 71)
        Me.桌面空间所在路径.Name = "桌面空间所在路径"
        Me.桌面空间所在路径.Size = New System.Drawing.Size(120, 25)
        Me.桌面空间所在路径.TabIndex = 38
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(218, 127)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 64)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "更改桌面空间路径"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(26, 127)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 64)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "恢复到初始桌面路径"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(264, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 41)
        Me.Button3.TabIndex = 40
        Me.Button3.Text = "打开"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(263, 61)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(60, 41)
        Me.Button4.TabIndex = 41
        Me.Button4.Text = "打开"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button5)
        Me.GroupBox5.Location = New System.Drawing.Point(1184, 791)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(335, 158)
        Me.GroupBox5.TabIndex = 52
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "主题选项"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(240, 111)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(89, 41)
        Me.Button5.TabIndex = 42
        Me.Button5.Text = "保存主题"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'BoxInfo
        '
        Me.BoxInfo.Controls.Add(Me.Label7)
        Me.BoxInfo.Controls.Add(Me.Label8)
        Me.BoxInfo.Controls.Add(Me.Label9)
        Me.BoxInfo.Controls.Add(Me.Label10)
        Me.BoxInfo.Controls.Add(Me.PictureBox4)
        Me.BoxInfo.Controls.Add(Me.PictureBox3)
        Me.BoxInfo.Controls.Add(Me.PictureBox2)
        Me.BoxInfo.Controls.Add(Me.PictureBox1)
        Me.BoxInfo.Location = New System.Drawing.Point(397, 370)
        Me.BoxInfo.Name = "BoxInfo"
        Me.BoxInfo.Size = New System.Drawing.Size(181, 306)
        Me.BoxInfo.TabIndex = 53
        Me.BoxInfo.TabStop = False
        Me.BoxInfo.Text = "桌面元素说明"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(53, 281)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "底部标识线"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(72, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 15)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "标题"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(72, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 15)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "图标"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 15)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "鼠标可以交互的范围"
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("宋体", 16.0!)
        Me.Label11.Location = New System.Drawing.Point(23, 445)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(201, 27)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "可交互区域大小"
        '
        '可交互范围X
        '
        Me.可交互范围X.Location = New System.Drawing.Point(232, 426)
        Me.可交互范围X.Name = "可交互范围X"
        Me.可交互范围X.Size = New System.Drawing.Size(106, 25)
        Me.可交互范围X.TabIndex = 46
        '
        '可交互范围Y
        '
        Me.可交互范围Y.Location = New System.Drawing.Point(232, 465)
        Me.可交互范围Y.Name = "可交互范围Y"
        Me.可交互范围Y.Size = New System.Drawing.Size(106, 25)
        Me.可交互范围Y.TabIndex = 47
        '
        'Apply2
        '
        Me.Apply2.Location = New System.Drawing.Point(370, 424)
        Me.Apply2.Name = "Apply2"
        Me.Apply2.Size = New System.Drawing.Size(80, 76)
        Me.Apply2.TabIndex = 45
        Me.Apply2.Text = "应用"
        Me.Apply2.UseVisualStyleBackColor = True
        '
        'ThemeEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1682, 1014)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.向左移动)
        Me.Controls.Add(Me.向右移动)
        Me.Controls.Add(Me.GroupBoxY)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.图标编辑)
        Me.Controls.Add(Me.BackColor_On)
        Me.Controls.Add(Me.BackColor_Off)
        Me.Controls.Add(Me.Add_aBox)
        Me.Controls.Add(Me.Delete_aBox)
        Me.IsMdiContainer = True
        Me.Name = "ThemeEditor"
        Me.Text = "Form1"
        CType(Me.Icon_E, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_X, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_Y, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_LY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_LX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Box_E, System.ComponentModel.ISupportInitialize).EndInit()
        Me.图标编辑.ResumeLayout(False)
        Me.图标编辑.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBoxY.ResumeLayout(False)
        Me.GroupBoxY.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.BoxInfo.ResumeLayout(False)
        Me.BoxInfo.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Delete_aBox As Button
    Friend WithEvents Add_aBox As Button
    Friend WithEvents Icon_E As PictureBox
    Friend WithEvents Icon_X As TrackBar
    Friend WithEvents Icon_Y As TrackBar
    Friend WithEvents Icon_LY As TrackBar
    Friend WithEvents Icon_LX As TrackBar
    Friend WithEvents Box_E As PictureBox
    Friend WithEvents Set_Center As Button
    Friend WithEvents Open_img As Button
    Friend WithEvents Img_Path As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BackColor_Off As Button
    Friend WithEvents BackColor_On As Button
    Friend WithEvents Apply_Img As Button
    Friend WithEvents Titel_Text As TextBox
    Friend WithEvents Change_Titel_Text As Button
    Friend WithEvents Change_Main_Color As Button
    Friend WithEvents Change_Titel_Color As Button
    Friend WithEvents Change_Line_Color As Button
    Friend WithEvents Change_Line_2Color As Button
    Friend WithEvents Change_Titel_Font As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents U_Padding As TextBox
    Friend WithEvents L_Padding As TextBox
    Friend WithEvents B_Spacing As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Apply_UPL As Button
    Friend WithEvents 图标编辑 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBoxY As GroupBox
    Friend WithEvents 主界面背景路径 As TextBox
    Friend WithEvents 应用主界面图片 As Button
    Friend WithEvents 更换主界面背景颜色 As Button
    Friend WithEvents 向右移动 As Button
    Friend WithEvents 向左移动 As Button
    Friend WithEvents 当前主界面大小 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents 桌面空间所在路径 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents 初始桌面路径 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents BoxInfo As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents 可交互范围Y As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents 可交互范围X As TextBox
    Friend WithEvents Apply2 As Button
End Class
