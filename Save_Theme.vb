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

        Dim Rgb_Value() As String = Main.M_Color.Split(",")
        If Rgb_Value.Length < 3 Or Rgb_Value.Length > 3 Then
            Main.BackgroundImage.Save(Application.StartupPath & "\Theme\" & ThemeName & "\Background")
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
                Dim s = Application.StartupPath & "\Theme\" & ThemeName & "\icon" & i
                Try
                    Main.Box(i).Icon.Image.Save(s)
                Catch ex As System.Runtime.InteropServices.ExternalException ':“GDI+ 中发生一般性错误。”

                    Bitmap B = New Bitmap(Main.Box(i).Icon.Image.Width, Main.Box(i).Icon.Image.Height) '新建一个理想大小的图像文件
                    Graphics g = Graphics.FromImage(B) '实例一个画板的对象, 就用上面的图像的画板
                    g.DrawImage(pictureBox_Sreen.Image, 0, 0) '把目标图像画在这个图像文件的画板上

                    B.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);//通过这个图像来保存

                End Try

                Writer.WriteLine(Main.Box(i).Box_Index)
                Writer.WriteLine(Main.Box(i).Icon_Location)
                Writer.WriteLine(Main.Box(i).Icon_Size)

            Next
            Writer.WriteLine("Theme_End")

        End Using
        MsgBox("主题""" & ThemeName & """保存成功", 0)

    End Sub
End Class
