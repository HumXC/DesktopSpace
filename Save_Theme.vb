Imports System.IO
Public Class Save_Theme
    Private Box_Index As Integer = Main.Box_Num - 1
    Public Sub New(ThemeName As String)
        Dim M_Color As String
        Dim Box_Size As String
        Dim L_Padding As String
        Dim U_Padding As String
        Dim B_Spacing As String
        Dim Titel_Font As String
        Dim Titel_Size As String
        Dim Titel_Color As String
        Dim Line_Height As String
        Dim Line_Color As String
        Dim Line_Select_Color As String
        '生成预览截图
        '    Try
        '        Directory.Delete("temp",true)
        '    Catch ex As System.IO.DirectoryNotFoundException
        '        'System.IO.DirectoryNotFoundException:“未能找到路径“D:\Desktop-Space\Code\Debug\temp”的一部分。”
        '    End Try


        Dim Img = New Bitmap(Main.Width, Main.Height) '创建一个图像文件
        Dim Gra As Graphics = Graphics.FromImage(Img) '用上面的图像文件创建一个画板
        Gra.CopyFromScreen(Main.Location.X, Main.Location.Y, 0, 0, Img.Size)  '把要保存的文件画到画板上，再保存
        Directory.CreateDirectory("Theme\" & ThemeName)
        Directory.CreateDirectory("temp")
        Img.Save("temp\" & ThemeName & ".png")






        File.Copy("temp\" & ThemeName & ".png", "Theme\" & ThemeName & "\" & ThemeName & ".png", True)



            '保存图标
            For i = 0 To Box_Index
            Dim s = "Theme\" & ThemeName & "\icon" & i
            Main.Box(i).Icon.Image.Save("temp\icon" & i)
            Main.Box(i).Icon.Image.Dispose()
            Main.Box(i).Icon.Dispose()
            Main.Box(i).Dispose()
            File.Copy("temp\icon" & i, "Theme\" & ThemeName & "\icon" & i, True)
        Next
        Dim Rgb_Value() As String = Main.M_Color.Split(",")
        If Rgb_Value.Length < 3 Or Rgb_Value.Length > 3 Then
            Main.BackgroundImage.Save("temp\Background")
            Main.BackgroundImage.Dispose()
            File.Copy("temp\Background", "Theme\" & ThemeName & "\Background", True)
            M_Color = "Background"
        Else
            M_Color = Main.M_Color
        End If
        Directory.Delete("temp", True)
        Box_Size = Main.Box_Size
        L_Padding = Main.L_Padding
        U_Padding = Main.U_Padding
        B_Spacing = Main.B_Spacing
        Titel_Font = Main.Titel_Font
        Titel_Size = Main.Titel_Size
        Titel_Color = Main.Titel_Color_S
        Line_Height = Main.Line_Height
        Line_Color = Main.Line_Color_S
        Line_Select_Color = Main.Line_Select_Color_S


        Using Writer As New StreamWriter("Theme\" & ThemeName & "\" & ThemeName)
            Writer.WriteLine("Theme_Start")
            Writer.WriteLine(M_Color)
            Writer.WriteLine(Box_Size)
            Writer.WriteLine(L_Padding)
            Writer.WriteLine(U_Padding)
            Writer.WriteLine(B_Spacing)
            Writer.WriteLine(Titel_Font)
            Writer.WriteLine(Titel_Size)
            Writer.WriteLine(Titel_Color)
            Writer.WriteLine(Line_Height)
            Writer.WriteLine(Line_Color)
            Writer.WriteLine(Line_Select_Color)

            For i = 0 To Box_Index
                Writer.WriteLine(Main.Box(i).Titel_Text)
                If Main.Box(i).Icon_Name <> "UnknowPath" Then

                    Writer.WriteLine(Main.Box(i).Box_Index)
                Else
                    Writer.WriteLine("UnknowPath")
                End If

                Writer.WriteLine(Main.Box(i).Icon_Location)
                Writer.WriteLine(Main.Box(i).Icon_Size)
                '
                '   Try
                '                  Main.Box(i).Icon.Image.Save(s)
                '              Catch ex As System.Runtime.InteropServices.ExternalException ':“GDI+ 中发生一般性错误。”
                '                  Dim P As Image = Main.Box(i).Icon.Image
                '
                '                  Dim Img = New Bitmap(P.Width, P.Height) '创建一个图像文件
                '                  Dim Gra As Graphics = Graphics.FromImage(Img) '用上面的图像文件创建一个画板
                '                  Gra.DrawImage(P, 0, 0)  '把要保存的文件画到画板上，再保存
                '                  Gra.Save()
                '                  Img.Save(s)
                '                  'System.Runtime.InteropServices.ExternalException:“GDI+ 中发生一般性错误。”

                '             End Try



            Next
            Writer.WriteLine("Theme_End")

        End Using
        Main.Dispose()
        Main.Show()
    End Sub
End Class
