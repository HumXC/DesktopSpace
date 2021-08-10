Imports System.IO
Imports System.Text.RegularExpressions
Public Class Main
    'Box的大小
    Public Box_Size As String
    'Box和主窗体边界的距离
    Public M_Padding As Integer
    'Box之间的距离
    Public Spacing As Integer
    'Titel的字体设置
    Public Titel_Font_Name As String
    Public Titel_Font_Size As Integer
    'Titel的字体颜色
    Public Titel_Color_S As String
    Public Titel_Color As Color
    'Line的高度
    Public Line_Height As Integer
    'Line默认的颜色
    Public Line_Color_S As String
    Public Line_Color As Color
    'Line被选中时的颜色
    Public Line_Select_Color_S As String
    Public Line_Select_Color As Color

    Public Box(10) As Object
    'Box：可以交互的范围
    'Icon：图标
    'Titel：标题文字
    'Line：标题文字下方的线

    '更改桌面目录的父目录
    Public ReadOnly change_Desktop_Path As String = "D:/DesktopSpace/"


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        '记录有多少个Box
        Dim Box_Index As Integer = 0

        '打开配置文件
        Using Reader As New StreamReader("D:/test.txt")
            Dim Key_Code As String


            Do
                Key_Code = Reader.ReadLine
            Loop Until Key_Code = "Config_Start"

            Set_Main_Color(Reader.ReadLine)
            Box_Size = Reader.ReadLine
            M_Padding = Reader.ReadLine
            Dim M_Padding_Old = M_Padding
            Spacing = Reader.ReadLine
            Titel_Font_Name = Reader.ReadLine
            Titel_Font_Size = Reader.ReadLine
            Titel_Color_S = Reader.ReadLine
            Line_Height = Reader.ReadLine
            Line_Color_S = Reader.ReadLine
            Line_Select_Color_S = Reader.ReadLine
            Dim Rgb_Value() As String = Line_Color_S.Split(",")
            Line_Color = Color.FromArgb(Rgb_Value(0), Rgb_Value(1), Rgb_Value(2))
            Dim Rgb_Value2() As String = Line_Select_Color_S.Split(",")
            Line_Select_Color = Color.FromArgb(Rgb_Value2(0), Rgb_Value2(1), Rgb_Value2(2))
            Dim Rgb_Value3() As String = Titel_Color_S.Split(",")
            Titel_Color = Color.FromArgb(Rgb_Value3(0), Rgb_Value3(1), Rgb_Value3(2))


            For i = 0 To 9
                Dim First_Code = Reader.ReadLine
                If First_Code = "Config_End" Then
                    Exit For
                End If

                Box(i) = New Box

                Box(i).Box_Load(First_Code, Reader.ReadLine, Reader.ReadLine, Reader.ReadLine)
                'Titel_Name, Text_Color, Icon_Path, Icon_Location, Icon_Size
                Box_Index = i
                M_Padding += Box(i).Size.Width + Spacing
            Next


            '绘制主窗体右边界、下边界
            ' Me.Size = New Size(M_Padding + M_Padding_Old, Box(0).Location.Y + Box(0).Size.Height + 110)
        End Using

        Me.Location = New Point((Screen.PrimaryScreen.Bounds.Width - Me.Size.Width) / 2, Screen.PrimaryScreen.Bounds.Height / 2 - Me.Size.Height + 10)

        '正则表达式检查桌面路径
        Dim mc As MatchCollection = Regex.Matches(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "[a-zA-Z]+$")
        Dim m As Match
        Dim path_Name As String = "UnknowPath"
        For Each m In mc
            path_Name = m.ToString
        Next m

        For i = 0 To Box_Index
            If Box(i).Titel.Text = path_Name Then
                Box(i).Ctrl.Checked = True
                Exit For
            End If
        Next


    End Sub

    Public Sub Set_Main_Color(M_Color As String)
        Dim Rgb_Value() As String = M_Color.Split(",")
        BackColor = Color.FromArgb(Rgb_Value(0), Rgb_Value(1), Rgb_Value(2))

    End Sub

    Private Sub Main_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        ' Testp.BackColor = Color.Red
        'Button1.Text = e.X
    End Sub
End Class