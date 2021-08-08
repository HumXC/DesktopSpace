Public Class Form1

    '这行不知道什么哪里复制的，也不知道是拿来干什么的，好像是拿来刷新？不过程序里没有用上
    'Private Declare Auto Function SendMessage Lib "user32" Alias "SendMessageW" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As String) As Integer

    '当前桌面路径和当前桌面名称，组合成为完整的路径
    Dim Now_Desktop_Path As String
    Dim Space_Name As String
    '当前选中的桌面
    Dim Select_Desktop_Name As String

    ReadOnly change_Desktop_Path = "D:\Desktop-Space\"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Now_Desktop_Path = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        '这里要改成使用正则表达式，但是现在还不会
        Try
            Space_Name = My.Computer.FileSystem.ReadAllText(Now_Desktop_Path & "\Space_Name.txt") '读取名称文件，识别当前桌面
        Catch ex As System.IO.FileNotFoundException
            '什么都不会发生
        End Try

        '控制文字底下的绿线
        Select Case Space_Name
            Case "Default"
                Default_line.Visible = True
                Defau_Button.Checked = True
            Case "Game"
                Game_line.Visible = True
                Game_Button.Checked = True
            Case "Music"
                Music_line.Visible = True
                Music_Button.Checked = True
            Case "Code"
                Code_line.Visible = True
                Code_Button.Checked = True
        End Select

    End Sub


    '这4个按钮在窗体下面，把窗口拉长才能看到，可以用键盘控制
    Private Sub Defau_Button_CheckedChanged(sender As Object, e As EventArgs) Handles Defau_Button.CheckedChanged


        Default_line.Visible = True
        Game_line.Visible = False
        Music_line.Visible = False
        Code_line.Visible = False
        Select_Desktop_Name = "Default"
    End Sub

    Private Sub Game_Button_CheckedChanged(sender As Object, e As EventArgs) Handles Game_Button.CheckedChanged
        Default_line.Visible = False
        Game_line.Visible = True
        Music_line.Visible = False
        Code_line.Visible = False
        Select_Desktop_Name = "Game"
    End Sub

    Private Sub Music_Button_CheckedChanged(sender As Object, e As EventArgs) Handles Music_Button.CheckedChanged
        Default_line.Visible = False
        Game_line.Visible = False
        Music_line.Visible = True
        Code_line.Visible = False
        Select_Desktop_Name = "Music"
    End Sub

    Private Sub Code_Button_CheckedChanged(sender As Object, e As EventArgs) Handles Code_Button.CheckedChanged
        Default_line.Visible = False
        Game_line.Visible = False
        Music_line.Visible = False
        Code_line.Visible = True
        Select_Desktop_Name = "Code"
    End Sub

    '如果在选中的桌面上按下空格、Enter和Esc，做出相应的动作，设置桌面
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Defau_Button.KeyDown, Game_Button.KeyDown, Music_Button.KeyDown, Code_Button.KeyDown

        If e.KeyCode = Keys.Enter Then

            Set_Desktop(Select_Desktop_Name)

        ElseIf e.KeyCode = Keys.Escape Then
            End

        End If
    End Sub


    '鼠标点击交互
    '  Private Sub SetDesktop_Defaulet(sender As Object, e As EventArgs) Handles Default_ico.Click， Defau_text.Click
    '      'Default文件夹设置为桌面
    '      Set_Desktop(change_Desktop_Path & "Default")
    '  End Sub
    '
    '  Private Sub SetDesktop_Game(sender As Object, e As EventArgs) Handles Game_ico.Click, Game_text.Click
    '      'Game文件夹设置为桌面
    '      Set_Desktop(change_Desktop_Path & "Game")
    '  End Sub
    '
    '  Private Sub SetDesktop_Music(sender As Object, e As EventArgs) Handles Music_ioc.Click, Music_text.Click
    '      'Music文件夹设置为桌面
    '      Set_Desktop(change_Desktop_Path & "Music")
    '  End Sub
    '
    '  Private Sub SetDesktop_Code(sender As Object, e As EventArgs) Handles Code_ico.Click, Code_text.Click
    '      'Code文件夹设置为桌面
    '      Set_Desktop(change_Desktop_Path & "Code")
    '  End Sub

    Private Sub Title_Click(sender As Object, e As EventArgs) Handles Title.Click
        End
    End Sub

    Private Sub Set_Desktop(select_Desktop_Name As String)

        If String.Compare(Me.Now_Desktop_Path, change_Desktop_Path & select_Desktop_Name) = 0 Then
            End

        End If

        Shell("cmd.exe /c reg add ""HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders"" /v ""Desktop"" /d " & change_Desktop_Path & select_Desktop_Name & " /t REG_EXPAND_SZ /f")
        Shell("cmd.exe /c taskkill /f /im explorer.exe & start explorer.exe")
        End
    End Sub

    Private Sub Esc_Click(sender As Object, e As EventArgs) Handles Esc.Click
        End

    End Sub

End Class