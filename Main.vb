Imports System.IO
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
    'Line的高度
    Public Line_Height As Integer



    Public Box(10) As Object
    'Box：可以交互的范围
    'Icon：图标
    'Titel：标题文字
    'Line：标题文字下方的线

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load


        '打开配置文件
        Using Reader As New StreamReader("D:/test.txt")
            Dim Key_Code As String


            Do
                Key_Code = Reader.ReadLine
            Loop Until Key_Code = "Config_Start"

            Box_Size = Reader.ReadLine

            M_Padding = Reader.ReadLine

            Spacing = Reader.ReadLine

            Titel_Font_Name = Reader.ReadLine
            Titel_Font_Size = Reader.ReadLine

            Line_Height = Reader.ReadLine





            Set_Main_Color(Reader.ReadLine)


            For i = 0 To 9
                Dim First_Code = Reader.ReadLine
                If First_Code = "Config_End" Then
                    Exit For
                End If

                Box(i) = New Box

                Box(i).Box_Load(First_Code, Reader.ReadLine, Reader.ReadLine, Reader.ReadLine, Reader.ReadLine, Reader.ReadLine)


                M_Padding += Box(i).Size.Width + Spacing
            Next
        End Using

        '绘制主窗体右边界
        Me.Size = New Size(M_Padding + 8, Me.Size.Height)


        '   Dim M_Color = "64,64,64"
        '   Dim B_Name = "Default"
        '   Dim Text_Color = "0,255,0"
        '   Dim Line_Color = "0,255,255"
        '   Dim Icon_Path = "D:/test.jpg"
        '   Dim Icon_Location = "12,20"
        '   Dim Icon_Size = "100,100"
        '   Box(0) = New Box
        ' Box(0).Box_Load(B_Name, Text_Color, Line_Color, Icon_Path, Icon_Location, Icon_Size)


    End Sub

    Public Sub Set_Main_Color(M_Color As String)
        Dim Rgb_Value() As String = M_Color.Split(",")
        BackColor = Color.FromArgb(Rgb_Value(0), Rgb_Value(1), Rgb_Value(2))

    End Sub

    Private Sub Main_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        ' Testp.BackColor = Color.Red
        Button1.Text = e.X
    End Sub
End Class