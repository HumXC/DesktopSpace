Imports System.IO

Public Class Form1

    '这行不知道什么哪里复制的，也不知道是拿来干什么的，好像是拿来刷新？不过程序里没有用上
    'Private Declare Auto Function SendMessage Lib "user32" Alias "SendMessageW" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As String) As Integer

    Dim Now_Desktop_Path As String
    Dim Space_Name As String

    ReadOnly change_Desktop_Path = "D:\Desktop-Space\"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Now_Desktop_Path = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        Try
            Space_Name = My.Computer.FileSystem.ReadAllText(Now_Desktop_Path & "\Space_Name.txt") '读取名称文件，识别当前桌面
        Catch ex As System.IO.FileNotFoundException
            '什么都不会发生
        End Try



        '控制底下的绿线
        If Space_Name = "Default" Then
            Default_line.Visible = True
            Defau_Button.Checked = True
        End If
        If Space_Name = "Game" Then
            Game_line.Visible = True
            Game_Button.Checked = True
        End If
        If Space_Name = "Music" Then
            Music_line.Visible = True
            Music_Button.Checked = True
        End If
        If Space_Name = "Code" Then
            Code_line.Visible = True
            Code_Button.Checked = True
        End If
    End Sub


    '这4个按钮在窗体下面，把窗口拉长才能看到，可以用键盘控制
    Private Sub Defau_Button_CheckedChanged(sender As Object, e As EventArgs) Handles Defau_Button.CheckedChanged
        Default_line.Visible = True
        Game_line.Visible = False
        Music_line.Visible = False
        Code_line.Visible = False
    End Sub

    Private Sub Game_Button_CheckedChanged(sender As Object, e As EventArgs) Handles Game_Button.CheckedChanged
        Default_line.Visible = False
        Game_line.Visible = True
        Music_line.Visible = False
        Code_line.Visible = False
    End Sub

    Private Sub Music_Button_CheckedChanged(sender As Object, e As EventArgs) Handles Music_Button.CheckedChanged
        Default_line.Visible = False
        Game_line.Visible = False
        Music_line.Visible = True
        Code_line.Visible = False
    End Sub

    Private Sub Code_Button_CheckedChanged(sender As Object, e As EventArgs) Handles Code_Button.CheckedChanged
        Default_line.Visible = False
        Game_line.Visible = False
        Music_line.Visible = False
        Code_line.Visible = True
    End Sub

    Private Sub Defau_Button_KeyDown(sender As Object, e As KeyEventArgs) Handles Defau_Button.KeyDown
        If e.KeyCode = Keys.Space Then Set_Desktop(change_Desktop_Path & "Default")
    End Sub

    Private Sub Game_Button_KeyDown(sender As Object, e As KeyEventArgs) Handles Game_Button.KeyDown
        If e.KeyCode = Keys.Space Then Set_Desktop(change_Desktop_Path & "Game")
    End Sub

    Private Sub Music_Button_KeyDown(sender As Object, e As KeyEventArgs) Handles Music_Button.KeyDown
        If e.KeyCode = Keys.Space Then Set_Desktop(change_Desktop_Path & "Music")
    End Sub

    Private Sub Code_Button_KeyDown(sender As Object, e As KeyEventArgs) Handles Code_Button.KeyDown
        If e.KeyCode = Keys.Space Then Set_Desktop(change_Desktop_Path & "Code")
    End Sub

    Private Sub SetDesktop_Defaulet(sender As Object, e As EventArgs) Handles Default_ico.Click
        'Default文件夹设置为桌面
        Set_Desktop(change_Desktop_Path & "Default")
        'SendMessage(HWND_BROADCAST, WM_SETTINGCHANGE, NULL, NULL)
    End Sub

    Private Sub SetDesktop_Game(sender As Object, e As EventArgs) Handles Game_ico.Click
        'Game文件夹设置为桌面
        Set_Desktop(change_Desktop_Path & "Game")
    End Sub

    Private Sub SetDesktop_Music(sender As Object, e As EventArgs) Handles Music_ioc.Click， Music_text.Click
        'Music文件夹设置为桌面
        Set_Desktop(change_Desktop_Path & "Music")
    End Sub

    Private Sub SetDesktop_Code(sender As Object, e As EventArgs) Handles Code_ico.Click, Code_text.Click
        'Code文件夹设置为桌面
        Set_Desktop(change_Desktop_Path & "Code")
    End Sub

    Private Sub Title_Click(sender As Object, e As EventArgs) Handles Title.Click
        End
    End Sub

    Private Sub Set_Desktop(desktopPath As String)
        If String.Compare(Me.Now_Desktop_Path, desktopPath) = 0 Then
            End
        End If
        Shell("cmd.exe /c reg add ""HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders"" /v ""Desktop"" /d " & desktopPath & " /t REG_EXPAND_SZ /f")
        Shell("cmd.exe /c taskkill /f /im explorer.exe & start explorer.exe")
        End
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Esc.Text = Me.Now_Desktop_Path
    End Sub

    Private Sub Esc_Click(sender As Object, e As EventArgs) Handles Esc.Click
        End
    End Sub

    Private Sub Enter_Click(sender As Object, e As EventArgs) Handles Enter.Click
        If Defau_Button.Checked = True Then
            Set_Desktop(change_Desktop_Path & "Default")
        End If

        If Game_Button.Checked = True Then
            Set_Desktop(change_Desktop_Path & "Game")
        End If

        If Music_Button.Checked = True Then
            Set_Desktop(change_Desktop_Path & "Music")
        End If

        If Code_Button.Checked = True Then
            Set_Desktop(change_Desktop_Path & "Code")
        End If
    End Sub


End Class