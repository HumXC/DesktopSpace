Imports System.ComponentModel
Imports System.IO
Public Class Guider
    '页面序号
    Public page As Integer = 0



    Private Sub Guider_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.Theme_Editing = True
        Timer1.Enabled = True
        Button2.Visible = False
        Me.Location = New Point((Screen.PrimaryScreen.Bounds.Width - Me.Size.Width) / 2, Screen.PrimaryScreen.Bounds.Height / 2 - Me.Size.Height + 300)
        '创建主题文件夹，创建配置文件，写入原始桌面路径
        Directory.CreateDirectory(Application.StartupPath & "/Theme/")
        Using Writer As New StreamWriter(Application.StartupPath & "/DesktopSpace.conf")
            Writer.WriteLine(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
        End Using

    End Sub

    '按下“下一步”
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.Visible = True
        page += 1
        Button3.Text = page

        Pageto()

    End Sub

    '按下“上一步”
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If page = 1 Then
            Button2.Visible = False
        End If
        page -= 1
        Button3.Text = page

        Pageto()

    End Sub

    Private Sub Pageto()
        '根据page的数字来显示页面内容
        Select Case page
            Case 0
                TurnOff()
                Lab1.Text = "设置向导"
                Lab2.Text = "让我来帮助你进行一些简单的设置"

            Case 1
                TurnOff()
                Lab1.Text = "桌面路径"
                Lab2.Text = "选择一个空文件夹用于存放所有的桌面" & vbCr & "你原本的桌面文件不会被删除" & vbCr & "新桌面将会是空的，你需要自己转移原有的文件" & vbCr & "如果你没有设置，则会使用默认配置"
                changePath.Visible = True
                PathBox.Visible = True

            Case 2
                TurnOff()
                Lab1.Text = "设置主界面"
                Lab2.Text = "主界面是为你提供操作的主要界面" & vbCr & "现在她就在上边" & vbCr & "选择颜色或图片把她设置成你喜欢的样子"
                SelectColor.Visible = True
                Set_Img.Visible = True

            Case 3
                TurnOff()
                Lab1.Text = "创建桌面"
                Lab2.Text = "这是用于切换的桌面" & vbCr & "这会在第一步设置的""桌面路径""中创建子文件夹" & vbCr & "最多支持创建10个桌面"



            Case 4
                TurnOff()
                Lab1.Text = "创建桌面"
                Lab2.Text = ""
                BoxInfo.Visible = True
                AllBoxValue.Visible = True
                Inde_BoxValue.Visible = True
                CreateBox.Visible = True
                DelBox.Visible = True
        End Select
    End Sub

    '关闭所有控件
    Private Sub TurnOff()
        changePath.Visible = False
        PathBox.Visible = False
        SelectColor.Visible = False
        Set_Img.Visible = False

        AllBoxValue.Visible = False
        Inde_BoxValue.Visible = False
        BoxInfo.Visible = False

        CreateBox.Visible = False
        DelBox.Visible = False




    End Sub


    Private Sub Guider_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        '方便测试，删除配置文件
        File.Delete(Application.StartupPath & "/DesktopSpace.conf")
        End
    End Sub

    '读取选择的桌面目录
    Private Sub ChangePath_Click(sender As Object, e As EventArgs) Handles changePath.Click
        FolderBrowserDialog1.ShowDialog()
        PathBox.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    '使主窗体保持在设置向导上边
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Main.Location = New Point(Me.Location.X + （Me.Size.Width - Main.Size.Width） / 2, Me.Location.Y - Main.Size.Height - 20)
    End Sub

    '选择字体
    Private Sub Select_Font_Click(sender As Object, e As EventArgs) Handles Select_Font.Click
        Set_Font.Show()

    End Sub

    '主窗口颜色选择
    Private Sub SelectColor_Click(sender As Object, e As EventArgs) Handles SelectColor.Click
        CreateColor.Set_Key_Code(1)
        CreateColor.Show()
    End Sub

    '第四页的选择标题颜色按钮
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CreateColor.Set_Key_Code(2)
        CreateColor.Show()
    End Sub
    '线的颜色选择
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CreateColor.Set_Key_Code(3)
        CreateColor.Show()
    End Sub
    '线被选中时的颜色
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CreateColor.Set_Key_Code(4)
        CreateColor.Show()
    End Sub

    '重新设置Box参数的值
    Public Sub Ser_All_Box()
        For i = 0 To Main.Box_Index - 1
            If Main.Box_Index <> 0 Then
                Main.Box(i).Box_Load()
            End If
        Next
        If Main.Box_Index <> 0 Then
            Main.Size = New Size(Main.Box(Main.Box_Index - 1).Size.Width + Main.Box(Main.Box_Index - 1).Location.X + Main.L_Padding, Main.Box(0).Line.Location.Y + 40)
        End If
    End Sub
    Private Sub B_Spacing_TextBox_TextChanged(sender As Object, e As EventArgs) Handles B_Spacing_TextBox.TextChanged
        If B_Spacing_TextBox.Text <> "" Then
            Main.B_Spacing = B_Spacing_TextBox.Text
            Ser_All_Box()

        End If
    End Sub

    Private Sub U_Padding_TextBox_TextChanged(sender As Object, e As EventArgs) Handles U_Padding_TextBox.TextChanged
        If U_Padding_TextBox.Text <> "" Then
            Main.U_Padding = U_Padding_TextBox.Text
            Ser_All_Box()
        End If
    End Sub

    Private Sub L_Padding_TextBox_TextChanged(sender As Object, e As EventArgs) Handles L_Padding_TextBox.TextChanged
        If L_Padding_TextBox.Text <> "" Then
            Main.L_Padding = L_Padding_TextBox.Text
            Ser_All_Box()
        End If
    End Sub

    '添加桌面按钮
    Private Sub CreateBox_Click(sender As Object, e As EventArgs) Handles CreateBox.Click
        If Main.Box_Index <= 9 Then

            Main.Box(Main.Box_Index) = New Box
            Main.Box(Main.Box_Index).Box_Set("nihao", "D:/test.jpg", "2,2", "100,100")
            'Titel_Name, Text_Color, Icon_Path, Icon_Location, Icon_Size
            Main.Box(Main.Box_Index).Box_Load()
            Main.Box(Main.Box_Index).Ctrl.Checked = True
            Main.Set_Main_Size()
            Main.Box_Index += 1
        End If




    End Sub
    '删除桌面按钮
    Private Sub DelBox_Click(sender As Object, e As EventArgs) Handles DelBox.Click
        If Main.Box_Index > 0 Then
            Main.Box_Index -= 1
            Main.Controls.Remove(Main.Box(Main.Box_Index))
            Main.Controls.Remove(Main.Box(Main.Box_Index).Titel)
            Main.Controls.Remove(Main.Box(Main.Box_Index).Line)
            Main.Controls.Remove(Main.Box(Main.Box_Index).Ctrl)
            If Main.Box_Index <> 0 Then
                Main.Size = New Size(Main.Box(Main.Box_Index - 1).Size.Width + Main.Box(Main.Box_Index - 1).Location.X + Main.L_Padding, Main.Box(0).Line.Location.Y + 40)

            End If


        End If
    End Sub

End Class