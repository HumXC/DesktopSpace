Imports System.IO
Public Class Box
    Inherits System.Windows.Forms.PictureBox
    '标记自己是第几个窗口
    Public Box_Index As Integer

    Public Titel_Text As String = "桌面" & Main.Box_Index + 1

    Public Icon_Path As String = "UnknowPath"
    Public Icon_Size As String
    Public Icon_Location As String


    Public WithEvents Titel As New Titel
    Public WithEvents Line As New Line
    Public WithEvents Icon As New Icon
    '用户看不见的单选按钮，用于键盘控制
    Public WithEvents Ctrl As New RadioButton

    Public Sub New()
        '设置可透明
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.Transparent
        Cursor = Cursors.Hand


    End Sub

    Public Sub Box_Set(Titel_Text As String, Icon_Path As String, Icon_Location As String, Icon_Size As String)
        Me.Box_Index = Main.Box_Index
        Me.Titel_Text = Titel_Text

        Me.Icon_Path = Icon_Path
        Me.Icon_Location = Icon_Location
        Me.Icon_Size = Icon_Size

        '将各元素加载进主窗体
        Main.Controls.Add(Me)
        '加载控制按钮进主窗体
        Main.Controls.Add(Ctrl)



    End Sub

    Public Sub Box_Load()

        Dim Size_Value() As String = Main.Box_Size.Split(",")
        Size = New Size(Size_Value(0), Size_Value(1))

        Location = New Point(Main.L_Padding + Box_Index * (Main.B_Spacing + Me.Size.Width), Main.U_Padding)

        '初始化Ctrl,Titel、Line
        Ctrl.Location = New Point(Me.Location.X, Me.Location.Y + Me.Size.Height - 1000)
        Titel.Titel_Load(Me)
        Icon.Icon_Load(Me)
        Line.Line_Load(Me)
    End Sub



    '鼠标悬停
    Private Sub Box_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, Icon.MouseMove, Titel.MouseMove
        If Me.Ctrl.Checked = False Then
            Me.Line.BackColor = Main.Line_Select_Color
        End If

        'BackColor = Color.Transparent
    End Sub

    '鼠标移开
    Private Sub Box_MouseLeeve(sender As Object, e As EventArgs) Handles Me.MouseLeave, Icon.MouseLeave, Titel.MouseLeave
        If Me.Ctrl.Checked = False Then
            Me.Line.BackColor = Color.Transparent
        End If

        'BackColor = Color.Transparent
    End Sub

    '按键控制
    Private Sub Box_KeyChange(sender As Object, e As EventArgs) Handles Ctrl.CheckedChanged
        If Ctrl.Checked = False Then
            Me.Line.BackColor = Color.Transparent
        ElseIf Ctrl.Checked = True Then
            Me.Line.BackColor = Main.Line_Color
        End If
    End Sub

    '按下键盘
    Private Sub Box_KeyDown(sender As Object, e As KeyEventArgs) Handles Ctrl.KeyDown
        If e.KeyCode = Keys.Enter Then
            Set_Desktop()
        ElseIf e.KeyCode = Keys.Escape Then
            End
        End If
    End Sub

    '按下鼠标
    Private Sub Box_MouseClick(sender As Object, e As MouseEventArgs) Handles Icon.MouseClick, Titel.MouseClick, Me.MouseClick
        Set_Desktop()
    End Sub

    '通过修改注册表更换桌面
    Private Sub Set_Desktop()
        '如果正在使用主题编辑器，则不做如任何操作
        If Main.Theme_Editing = False Then
            '如果选中的桌面已经是当前桌面，则不做任何处理，退出
            If String.Compare(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop), Main.change_Desktop_Path & Me.Titel_Text) = 0 Then
                End
            ElseIf Directory.Exists(Main.change_Desktop_Path & Titel_Text) <> True Then
                Directory.CreateDirectory(Main.change_Desktop_Path & Titel_Text & "/这里是" & Titel_Text & "桌面")
            End If

            Shell("cmd.exe /c reg export HKEY_CURRENT_USER\Software\Microsoft\Windows\Shell\Bags\1\Desktop " & Main.change_Desktop_Path & Main.Now_Path & ".reg /y & reg import " & Main.change_Desktop_Path & Titel_Text & ".reg")

            Shell("cmd.exe /c reg add ""HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders"" /v ""Desktop"" /d " & Main.change_Desktop_Path & Titel_Text & " /t REG_EXPAND_SZ /f")
            Shell("cmd.exe /c taskkill /im explorer.exe & taskkill /f /im explorer.exe & start explorer.exe")
            End
        End If
    End Sub


End Class
