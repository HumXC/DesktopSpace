Imports System.IO
Public Class Save_Theme

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

        Directory.CreateDirectory(Application.StartupPath & "\Theme\" & ThemeName)
        For i = 0 To Main.Box_Num - 1
            Main.Box(i).Icon.Image.Dispose()
            Dim s = Application.StartupPath & "\Theme\" & ThemeName & "\icon" & i
            File.Copy(Application.StartupPath & "\temp\icon" & i, s, True)
        Next
        Main.BackgroundImage.Dispose()
        Dim Rgb_Value() As String = Main.M_Color.Split(",")
        If Rgb_Value.Length < 3 Or Rgb_Value.Length > 3 Then

            File.Copy(Application.StartupPath & "\temp\Background", Application.StartupPath & "\Theme\" & ThemeName & "\Background", True)
            'Application.StartupPath & "\Theme\" & ThemeName & "\Background"

            'System.IO.IOException:“文件“D:\Desktop-Space\Code\Debug\Theme\Default\Background”正由另一进程使用，因此该进程无法访问该文件。”


            M_Color = "Background"
        Else
            M_Color = Main.M_Color
        End If
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


        Using Writer As New StreamWriter(Application.StartupPath & "\Theme\" & ThemeName & "\" & ThemeName)
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

            For i = 0 To Main.Box_Num - 1
                Writer.WriteLine(Main.Box(i).Titel_Text)
                Writer.WriteLine(Main.Box(i).Box_Index)
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

        Main.MdiParent = ThemeEditor
        Main.Show()

    End Sub
End Class
