Imports System.IO
Imports System.Text.RegularExpressions
Public Class Main
    '主窗体颜色
    Public M_Color As String = "96,96,96"
    'Box和主窗体左右边界的距离
    Public L_Padding As Integer = 50
    'Box和主窗体上边界的距离
    Public U_Padding As Integer = 40
    'Box之间的距离
    Public B_Spacing As Integer = 20
    'Box的大小
    Public Box_Size As String = "130,150"

    'Titel的字体颜色
    Public Titel_Color As Color = Color.White
    Public Titel_Color_S As String = "255,255,255"
    'Titel的字体名称 
    Public Titel_Font As String = "幼圆"
    'Titel的字体大小
    Public Titel_Size As Integer = "15"


    'Line的高度
    Public Line_Height As Integer = 9
    'Line默认的颜色
    Public Line_Color As Color = Color.Lime
    Public Line_Color_S As String = "0,255,0"
    '鼠标悬停在Line上的颜色
    Public Line_Select_Color As Color = Color.Orange
    Public Line_Select_Color_S As String = "255,165,0"

    '记录有多少个Box
    Public ReadOnly Box(10) As Object
    Public Box_Num As Integer = 0

    '记录主题信息
    Public Theme_Info As String = ""
    'Box：可以交互的范围
    'Icon：图标
    'Titel：标题文字
    'Line：标题文字下方的线

    '更改桌面目录的父目录
    Public change_Desktop_Path As String = "D:\DesktopSpace\"

    '运行时桌面路径
    Public Now_Path As String = "UnknowPath"

    '主题文件路径
    Public Theme_Name As String = "Default"

    '初始桌面位置
    Public Default_Path As String

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load

        Box_Num = 0
        '打开配置文件
        Try
            Using Reader As New StreamReader("DesktopSpace.conf")
                change_Desktop_Path = Reader.ReadLine
                ThemeEditor.桌面空间所在路径.Text = change_Desktop_Path
                Theme_Name = Reader.ReadLine
                If Theme_Name = "" Then
                    Theme_Name = "Default"
                End If
                Default_Path = Reader.ReadLine
                ThemeEditor.初始桌面路径.Text = Default_Path
                ThemeEditor.当前加载主题.Text = Theme_Name
            End Using

            '如果没有找到配置文件则打开配置向导
        Catch ex As System.IO.FileNotFoundException
            Dim DefaultTheme = New FirstRun
            Guider.Show()
        End Try
        ReadTheme()
        '窗口的初始位置
        Me.Location = New Point((Screen.PrimaryScreen.Bounds.Width - Me.Size.Width) \ 2, 10)

        '正则表达式读取并检查桌面路径
        '        Dim mc As MatchCollection = Regex.Matches(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "[a-zA-Z]+$")
        '        Dim m As Match
        '        For Each m In mc
        '            Me.Now_Path = m.ToString
        '        Next m
        '
        '        For i = 0 To Box_Num - 1
        '            If Box(i).Titel.Text = Me.Now_Path Then
        '                Box(i).Ctrl.Checked = True
        '                Exit For
        '            End If
        '        Next
        '
        '导出桌面图标信息
        'Shell("cmd.exe \c reg export HKEY_CURRENT_USER\Software\Microsoft\Windows\Shell\Bags\1\Desktop " & Me.change_Desktop_Path & Me.Now_Path & ".reg \y ")

    End Sub

    Public Sub ReadTheme()

        '配置文件存在则读取主题文件并生成Box
        Try
            Using Reader As New StreamReader("Theme\" & Theme_Name & "\" & Theme_Name)
                Dim Key_Code As String
                Dim cycle_Num As Integer
                Do
                    cycle_Num += 1
                    Key_Code = Reader.ReadLine
                    Theme_Info += Key_Code & vbCr
                    If cycle_Num > 3000 Then
                        MsgBox("循环超过3000次，主题文件似乎损坏！请删除Theme文件夹下的" & Theme_Name & "文件夹")
                        Me.Close()
                    End If
                Loop Until Key_Code = "Theme_Start"

                '开始读取配置文件的共同参数
                M_Color = Reader.ReadLine
                Box_Size = Reader.ReadLine
                L_Padding = Reader.ReadLine
                U_Padding = Reader.ReadLine
                B_Spacing = Reader.ReadLine
                Titel_Font = Reader.ReadLine
                Titel_Size = Reader.ReadLine
                Titel_Color_S = Reader.ReadLine
                Line_Height = Reader.ReadLine
                Line_Color_S = Reader.ReadLine
                Line_Select_Color_S = Reader.ReadLine
                Color_S_To_Color()
                Set_Main_Color()

                '读取每个box的不同参数
                For i = 0 To 9

                    '检测是否读取到结束关键词
                    Dim First_Code = Reader.ReadLine
                    If First_Code = "Theme_End" Then
                        Exit For
                    End If
                    Box(i) = New Box
                    Box(i).Box_Load(First_Code, Reader.ReadLine, Reader.ReadLine, Reader.ReadLine, i)
                    'Titel_Name, Text_Color, Icon_Path, Icon_Location, Icon_Size
                    Box_Num += 1

                Next

                Set_Main()


            End Using
        Catch ex As System.IO.FileNotFoundException
            Dim DefaultTheme = New FirstRun
            ReadTheme()
            '  Catch ex As System.IO.DirectoryNotFoundException
            '  Dim DefaultTheme = New FirstRun
            '   ReadTheme()
        End Try
    End Sub



    Public Sub Set_Main_Color()
        Me.BackgroundImage = My.Resources.透明
        If M_Color = "Background" Then
            Me.BackgroundImage = Image.FromFile("Theme\" & Theme_Name & "\Background")
        Else
            Try
                Dim Rgb_Value() As String = M_Color.Split(",")
                Me.BackColor = Color.FromArgb(Rgb_Value(0), Rgb_Value(1), Rgb_Value(2))

            Catch ex As System.InvalidCastException
                Try
                    BackgroundImage = Image.FromFile(M_Color)

                Catch ax As System.NotSupportedException
                    MsgBox("不支持的路径格式", 0)

                Catch ax As System.ArgumentException
                    MsgBox("路径中具有非法字符", 0)

                Catch ax As System.IO.FileNotFoundException
                    MsgBox("路径中具有非法字符", 0)
                End Try


            End Try

        End If

    End Sub

    '将颜色的字符串格式转为color格式
    Public Sub Color_S_To_Color()
        Dim Rgb_Value() As String = Titel_Color_S.Split(",")
        Titel_Color = Color.FromArgb(Rgb_Value(0), Rgb_Value(1), Rgb_Value(2))

        Dim Rgb_Value2() As String = Line_Color_S.Split(",")
        Line_Color = Color.FromArgb(Rgb_Value2(0), Rgb_Value2(1), Rgb_Value2(2))

        Dim Rgb_Value3() As String = Line_Select_Color_S.Split(",")
        Line_Select_Color = Color.FromArgb(Rgb_Value3(0), Rgb_Value3(1), Rgb_Value3(2))
    End Sub

    '删除一个Box
    Public Sub Delect_Box()


        For i = 0 To Box_Num - 1
            If Box(i).Ctrl.Checked = True Then
                For j = i To Box_Num - 2

                    Box(j).Box_Set(Box(j + 1).Titel_Text, Box(j + 1).Icon_Name, Box(j + 1).Icon_Location, Box(j + 1).Icon_Size)
                Next
                Box(Box_Num - 1).Unload_Box()
                Box_Num -= 1
                Set_Main()
                ThemeEditor.Add_aBox.Enabled = True
            End If
        Next

        Uncheck_Ctrl()
    End Sub

    '添加一个Box
    Public Sub Add_Box()
        If Box_Num < 10 Then
            Box(Box_Num) = New Box
            Box(Box_Num).Box_Load("桌面" & Box_Num + 1, "NuknowName", "15,10", "100,100", Box_Num)
            Box_Num += 1
            Set_Main()
        Else
            ThemeEditor.Add_aBox.Enabled = False
        End If

    End Sub

    Public Sub Tr_All_Line()
        For i = 0 To Box_Num - 1
            Box(i).Line.BackColor = Color.Transparent
        Next

    End Sub

    Public Sub Set_Main()
        '绘制主窗体右边界、下边界
        '    获取box宽度
        Dim Size_Value() As String = Box_Size.Split(",")
        Me.Size = New Size(Box_Num * Size_Value(0) + (Box_Num - 1) * B_Spacing + 2 * L_Padding, Box(0).Line.Location.Y + 30)

    End Sub

    Public Sub Uncheck_Ctrl()
        For i = 0 To Box_Num - 1
            Box(i).Ctrl.Checked = False

        Next
    End Sub

End Class