Imports System.IO
Imports System.Text.RegularExpressions

Public Class Form1

    '当前桌面路径和当前桌面名称，组合成为完整的路径
    Dim Now_Desktop_Path As String
    Dim Space_Name As String
    '当前选中的桌面
    Dim Select_Desktop As Object

    ReadOnly change_Desktop_Path = "D:\Desktop-Space\"

    '正则表达式匹配最后一个单词，用于检查当前路径
    Private Sub CheckName(path As String)
        Dim mc As MatchCollection = Regex.Matches(path, "[a-zA-Z]+$")
        Dim m As Match
        For Each m In mc
            Me.Space_Name = m.ToString
        Next m
    End Sub

    '当桌面文件夹不存在时创建文件夹
    Private Sub Create_Path()
        Directory.CreateDirectory(change_Desktop_Path & "Default/这里是Default桌面")
        Directory.CreateDirectory(change_Desktop_Path & "Game/这里是Game桌面")
        Directory.CreateDirectory(change_Desktop_Path & "Music/这里是Music桌面")
        Directory.CreateDirectory(change_Desktop_Path & "Code/这里是Code桌面")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '获取当前桌面路径
        Now_Desktop_Path = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        '检查路径
        CheckName(Now_Desktop_Path)


        '控制文字底下的绿线
        Select Case Space_Name
            Case "Default"
                Defau_Button.Checked = True

            Case "Game"
                Game_Button.Checked = True

            Case "Music"
                Music_Button.Checked = True

            Case "Code"
                Code_Button.Checked = True

                '如果没有匹配的文件夹，就主动创建
            Case Else
                Create_Path()

        End Select

        Default_line_back.Location = Default_line.Location
        Game_line_back.Location = Game_line.Location
        Music_line_back.Location = Music_line.Location
        Code_line_back.Location = Code_line.Location
    End Sub


    '这4个按钮在窗体下面，把窗口拉长才能看到，可以用键盘控制
    '4个单选按钮被选中时
    Private Sub Defau_Button_CheckedChanged(sender As Object, e As EventArgs) Handles Defau_Button.CheckedChanged


        Default_line.Visible = True
        Game_line.Visible = False
        Music_line.Visible = False
        Code_line.Visible = False
        Select_Desktop = Default_ico
        Animation_up.Enabled = True

    End Sub

    Private Sub Game_Button_CheckedChanged(sender As Object, e As EventArgs) Handles Game_Button.CheckedChanged
        Default_line.Visible = False
        Game_line.Visible = True
        Music_line.Visible = False
        Code_line.Visible = False
        Select_Desktop = Game_ico
        Animation_up.Enabled = True
    End Sub

    Private Sub Music_Button_CheckedChanged(sender As Object, e As EventArgs) Handles Music_Button.CheckedChanged
        Default_line.Visible = False
        Game_line.Visible = False
        Music_line.Visible = True
        Code_line.Visible = False
        Select_Desktop = Music_ico
        Animation_up.Enabled = True
    End Sub

    Private Sub Code_Button_CheckedChanged(sender As Object, e As EventArgs) Handles Code_Button.CheckedChanged
        Default_line.Visible = False
        Game_line.Visible = False
        Music_line.Visible = False
        Code_line.Visible = True
        Select_Desktop = Code_ico
        Animation_up.Enabled = True
    End Sub

    '如果在选中的桌面上按下Enter和Esc，做出相应的动作，设置桌面或者退出
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Defau_Button.KeyDown, Game_Button.KeyDown, Music_Button.KeyDown, Code_Button.KeyDown

        If e.KeyCode = Keys.Enter Then

            Set_Desktop(Select_Desktop)

        ElseIf e.KeyCode = Keys.Escape Then
            End

        End If
    End Sub

    '通过修改注册表修改桌面路径


    Private Sub Set_Desktop(select_Desktop As Object)
        '如果选中的桌面已经是当前桌面，则不做任何处理，退出
        If String.Compare(Me.Now_Desktop_Path, change_Desktop_Path & select_Desktop.Tag) = 0 Then
            End
        End If

        Shell("cmd.exe /c reg add ""HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders"" /v ""Desktop"" /d " & change_Desktop_Path & select_Desktop.Tag & " /t REG_EXPAND_SZ /f")
        Shell("cmd.exe /c taskkill /f /im explorer.exe & start explorer.exe")
        End

    End Sub

    '鼠标交互

    Private Sub TurnOff_AllBackLine() '关闭所有橘色的背景线
        Default_line_back.Visible = False
        Game_line_back.Visible = False
        Music_line_back.Visible = False
        Code_line_back.Visible = False
    End Sub

    '鼠标悬停
    Private Sub Default_MouseMove(sender As Object, e As MouseEventArgs) Handles Default_ico.MouseMove, Defau_text.MouseMove
        TurnOff_AllBackLine()
        Default_line_back.Visible = True
    End Sub

    Private Sub Game_MouseMove(sender As Object, e As MouseEventArgs) Handles Game_ico.MouseMove, Game_text.MouseMove
        TurnOff_AllBackLine()
        Game_line_back.Visible = True
    End Sub

    Private Sub Music_MouseMove(sender As Object, e As MouseEventArgs) Handles Music_ico.MouseMove, Music_text.MouseMove
        TurnOff_AllBackLine()
        Music_line_back.Visible = True
    End Sub

    Private Sub Code_MouseMove(sender As Object, e As MouseEventArgs) Handles Code_ico.MouseMove, Code_text.MouseMove
        TurnOff_AllBackLine()
        Code_line_back.Visible = True
    End Sub

    '提示信息按钮的显示
    Private Sub Info_MouseMove(sender As Object, e As MouseEventArgs) Handles Info_B.MouseMove
        Info_B.BackColor = Color.White
    End Sub


    '检测鼠标，如果鼠标移出图标范围，则关闭所有背景线(_line_back)
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, Default_line_back.MouseMove, Game_line_back.MouseMove, Music_line_back.MouseMove, Code_line_back.MouseMove
        TurnOff_AllBackLine()
        Info_B.BackColor = Me.BackColor '恢复提示按钮的颜色

    End Sub

    '鼠标按下

    Private Sub Default_MouseDown(sender As Object, e As MouseEventArgs) Handles Default_ico.MouseDown, Defau_text.MouseDown
        Defau_Button.Checked = True
    End Sub

    Private Sub Game_MouseDown(sender As Object, e As MouseEventArgs) Handles Game_ico.MouseDown, Game_text.MouseDown
        Game_Button.Checked = True
    End Sub

    Private Sub Music_MouseDown(sender As Object, e As MouseEventArgs) Handles Music_ico.MouseDown, Music_text.MouseDown
        Music_Button.Checked = True
    End Sub

    Private Sub Code_MouseDown(sender As Object, e As MouseEventArgs) Handles Code_ico.MouseDown, Code_text.MouseDown
        Code_Button.Checked = True
    End Sub

    Private Sub Info_MouseDown(sender As Object, e As MouseEventArgs) Handles Info_B.MouseDown
        Info.Show()

    End Sub

    '鼠标松开
    Private Sub Default_MouseUp(sender As Object, e As MouseEventArgs) Handles Default_ico.MouseUp, Defau_text.MouseUp
        Set_Desktop(Select_Desktop)
    End Sub

    Private Sub Game_MouseUp(sender As Object, e As MouseEventArgs) Handles Game_ico.MouseUp, Game_text.MouseUp
        Set_Desktop(Select_Desktop)
    End Sub

    Private Sub Music_MouseUp(sender As Object, e As MouseEventArgs) Handles Music_ico.MouseUp, Music_text.MouseUp
        Set_Desktop(Select_Desktop)
    End Sub

    Private Sub Code_MouseUp(sender As Object, e As MouseEventArgs) Handles Code_ico.MouseUp, Code_text.MouseUp
        Set_Desktop(Select_Desktop)
    End Sub

    Private Sub Info_B_Click(sender As Object, e As EventArgs) Handles Info_B.Click

    End Sub
End Class