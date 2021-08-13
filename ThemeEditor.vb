Public Class ThemeEditor
    '当前编辑的Box序号
    Public Box_Index As Integer = 200
    Private Sub ThemeEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        U_Padding.Text = Main.U_Padding
        L_Padding.Text = Main.L_Padding
        B_Spacing.Text = Main.B_Spacing
        当前主界面大小.Text = Main.Size.ToString
        桌面空间所在路径.Text = Main.change_Desktop_Path
        Main.MdiParent = Me
        Main.Show()
        Dim Size_Value() As String = Main.Box_Size.Split(",")
        Icon_X.Width = Size_Value(0) + 34
        Icon_X.Maximum = Size_Value(0)
        Icon_X.Value = Size_Value(0) / 2

        Icon_Y.Height = Size_Value(1) + 34
        Icon_Y.Maximum = Size_Value(1)
        Icon_Y.Value = Size_Value(1) / 2
        Icon_E.Size = New Size(Size_Value(0), Size_Value(1))

        Icon_LX.Width = Size_Value(0) + 34
        Icon_LX.Maximum = Size_Value(0)

        Icon_LY.Height = Size_Value(1) + 34
        Icon_LY.Maximum = Size_Value(1)
        Icon_LY.Value = Icon_LY.Maximum

        Box_E.Size = New Size(Size_Value(0), Size_Value(1))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Delete_aBox.Click
        Main.Delect_Box()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Add_aBox.Click
        Main.Add_Box()
    End Sub

    '设置图片框控件为合适的图片大小
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Icon_E.Click

        '       Dim Size_Value() As String = Main.Box_Size.Split(",")
        Dim Img = Image.FromFile("D:/test.gif")
        '       If Img.Width > Size_Value(0) Or Img.Height > Size_Value(1) Then
        '           If Img.Width > Img.Height Then
        '               PictureBox1.Size = New Size(Size_Value(0), Img.Size.Height / (Img.Width / Size_Value(0)))
        '           Else
        '               PictureBox1.Size = New Size(Img.Size.Width / (Img.Height / Size_Value(1)), Size_Value(1))
        '           End If
        '       End If
        Icon_E.Image = Img
    End Sub


    Private Sub Icon_X_ValueChanged(sender As Object, e As EventArgs) Handles Icon_X.ValueChanged
        Icon_E.Size = New Size(Icon_X.Value, Icon_E.Height)

    End Sub

    Private Sub Icon_Y_ValueChanged(sender As Object, e As EventArgs) Handles Icon_Y.ValueChanged
        Icon_E.Size = New Size(Icon_E.Width, Icon_Y.Maximum - Icon_Y.Value)
    End Sub

    Private Sub Icon_X_Scroll(sender As Object, e As EventArgs) Handles Icon_X.Scroll
        Try
            Main.Box(Box_Index).Icon_Size = Icon_X.Value & "," & Main.Box(Box_Index).Icon.Size.Height
            Main.Box(Box_Index).Icon.Icon_Set(Main.Box(Box_Index))
        Catch ex As System.IndexOutOfRangeException
            '什么也不做
        End Try
    End Sub

    Private Sub Icon_Y_Scroll(sender As Object, e As EventArgs) Handles Icon_Y.Scroll
        Try
            Main.Box(Box_Index).Icon_Size = Main.Box(Box_Index).Icon.Size.Width & "," & Icon_Y.Maximum - Icon_Y.Value
            Main.Box(Box_Index).Icon.Icon_Set(Main.Box(Box_Index))
        Catch ex As System.IndexOutOfRangeException
            '什么也不做
        End Try
    End Sub

    Private Sub Icon_LX_ValueChanged(sender As Object, e As EventArgs) Handles Icon_LX.ValueChanged
        Icon_X.Location = New Point(Box_E.Location.X - 17 + Icon_LX.Value, Icon_X.Location.Y)
        Icon_E.Location = New Point(Box_E.Location.X + Icon_LX.Value, Icon_E.Location.Y)
    End Sub

    Private Sub Icon_LY_ValueChanged(sender As Object, e As EventArgs) Handles Icon_LY.ValueChanged
        Icon_Y.Location = New Point(Icon_Y.Location.X, Box_E.Location.Y - 51 - Icon_LY.Value + Icon_Y.Size.Height)
        Icon_E.Location = New Point(Icon_E.Location.X, Box_E.Location.Y + Icon_LY.Maximum - Icon_LY.Value)
    End Sub


    Private Sub Icon_LX_Scroll(sender As Object, e As EventArgs) Handles Icon_LX.Scroll
        Try
            Main.Box(Box_Index).Icon_Location = Icon_LX.Value & "," & Main.Box(Box_Index).Icon.Location.Y
            Main.Box(Box_Index).Icon.Icon_Set(Main.Box(Box_Index))
        Catch ex As System.IndexOutOfRangeException
            '什么也不做
        End Try
    End Sub
    Private Sub Icon_LY_Scroll(sender As Object, e As EventArgs) Handles Icon_LY.Scroll
        Try
            Main.Box(Box_Index).Icon_Location = Main.Box(Box_Index).Icon.Location.X & "," & Icon_LY.Maximum - Icon_LY.Value
            Main.Box(Box_Index).Icon.Icon_Set(Main.Box(Box_Index))
        Catch ex As System.IndexOutOfRangeException
            '什么也不做
        End Try
    End Sub

    '居中按钮
    Private Sub Set_Center_Click(sender As Object, e As EventArgs) Handles Set_Center.Click
        Try
            Icon_LX.Value = (Box_E.Size.Width - Icon_E.Size.Width) / 2
            Icon_LY.Value = Icon_LY.Maximum - (Box_E.Size.Height - Icon_E.Size.Height) / 2
            Main.Box(Box_Index).Icon_Location = Icon_LX.Value & "," & Icon_LY.Maximum - Icon_LY.Value
            Main.Box(Box_Index).Icon.Icon_Set(Main.Box(Box_Index))
        Catch ex As System.IndexOutOfRangeException
            '什么也不做
        End Try

    End Sub

    Private Sub Open_img_Click(sender As Object, e As EventArgs) Handles Open_img.Click
        OpenFileDialog1.ShowDialog()
        Img_Path.Text = OpenFileDialog1.FileName

    End Sub

    Private Sub Apply_Img_Click(sender As Object, e As EventArgs) Handles Apply_Img.Click
        Try
            Main.Box(Box_Index).Set_Icon_Img(Img_Path.Text)
        Catch ex As System.IndexOutOfRangeException
            '什么也不做
        End Try

    End Sub

    Private Sub BackColor_Off_Click(sender As Object, e As EventArgs) Handles BackColor_Off.Click
        For i = 0 To Main.Box_Num - 1
            Main.Box(i).Icon.BackColor = Color.Transparent
            Main.Box(i).BackColor = Color.Transparent
        Next
    End Sub

    Private Sub BackColor_On_Click(sender As Object, e As EventArgs) Handles BackColor_On.Click
        For i = 0 To Main.Box_Num - 1
            Main.Box(i).Icon.BackColor = Color.FromArgb(195, 0, 255)
            Main.Box(i).BackColor = Color.FromArgb(255, 165, 0)
        Next
    End Sub

    Private Sub Change_Titel_Text_Click(sender As Object, e As EventArgs) Handles Change_Titel_Text.Click
        Try
            If Titel_Text.Text <> "" Then
                Main.Box(Box_Index).Titel_Text = Titel_Text.Text
                Main.Box(Box_Index).Titel.Titel_Set(Main.Box(Box_Index))
            End If
        Catch ex As System.IndexOutOfRangeException
            '什么也不做
        End Try
    End Sub

    Private Sub Change_Main_Color_Click(sender As Object, e As EventArgs) Handles Change_Main_Color.Click
        SelectColor.Show()
        SelectColor.Set_Key_Code(1)
    End Sub

    Private Sub Change_Titel_Color_Click(sender As Object, e As EventArgs) Handles Change_Titel_Color.Click
        SelectColor.Show()
        SelectColor.Set_Key_Code(2)
    End Sub

    Private Sub Change_Line_Color_Click(sender As Object, e As EventArgs) Handles Change_Line_Color.Click
        SelectColor.Show()
        SelectColor.Set_Key_Code(3)
    End Sub

    Private Sub Change_Line_2Color_Click(sender As Object, e As EventArgs) Handles Change_Line_2Color.Click
        SelectColor.Show()
        SelectColor.Set_Key_Code(4)
    End Sub

    Private Sub Change_Titel_Font_Click(sender As Object, e As EventArgs) Handles Change_Titel_Font.Click
        SelectFont.Show()
    End Sub


    Private Sub Apply_UPL_Click(sender As Object, e As EventArgs) Handles Apply_UPL.Click
        当前主界面大小.Text = Main.Size.ToString


        Try
            Main.U_Padding = U_Padding.Text
        Catch ex As System.InvalidCastException
            '什么也不做
        End Try

        Try
            Main.L_Padding = L_Padding.Text
        Catch ex As System.InvalidCastException
            '什么也不做
        End Try

        Try
            Main.B_Spacing = B_Spacing.Text
        Catch ex As System.InvalidCastException
            '什么也不做
        End Try

        For i = 0 To Main.Box_Num - 1
            Main.Box(i).Set2()
        Next

        Main.Set_Main()


    End Sub

    Private Sub 向右移动_Click(sender As Object, e As EventArgs) Handles 向右移动.Click
        Main.Location = New Point(Main.Location.X + 80, Main.Location.Y)
    End Sub

    Private Sub 向左移动_Click(sender As Object, e As EventArgs) Handles 向左移动.Click
        Main.Location = New Point(Main.Location.X - 80, Main.Location.Y)
    End Sub

    Private Sub 更换主界面背景颜色_Click(sender As Object, e As EventArgs) Handles 更换主界面背景颜色.Click
        OpenFileDialog1.ShowDialog()
        主界面背景路径.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub 应用主界面图片_Click(sender As Object, e As EventArgs) Handles 应用主界面图片.Click
        Main.M_Color = 主界面背景路径.Text
        Main.Set_Main_Color()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Shell("cmd.exe /c explorer.exe " & 初始桌面路径.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Shell("cmd.exe /c explorer.exe " & 桌面空间所在路径.Text)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("无法读取配置文件，请先运行目录下的DesktopSetting.exe", 4) = 6 Then


            Shell("cmd.exe /c reg add ""HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders"" /v ""Desktop"" /d " & 初始桌面路径.Text & " /t REG_EXPAND_SZ /f ")

        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        FolderBrowserDialog1.ShowDialog()
        Main.change_Desktop_Path = FolderBrowserDialog1.SelectedPath & "/DesktopSpace"
        桌面空间所在路径.Text = Main.change_Desktop_Path
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Apply2_Click(sender As Object, e As EventArgs) Handles Apply2.Click
        Main.Box_Size = 可交互范围X.Text & "," & 可交互范围Y.Text
        For i = 0 To Main.Box_Num - 1
            Main.Box(i).Set_Box_Size()
        Next
        Main.Set_Main()

    End Sub
End Class