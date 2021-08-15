Imports System.IO
Public Class FirstRun
    Public Sub New()
        Using Writer As New StreamWriter("DesktopSpace.conf")

        End Using
        Dim l1 As String
        Dim l2 As String
        Dim l3 As String
        Using reader As New StreamReader("DesktopSpace.conf")
            l1 = reader.ReadLine
            l2 = reader.ReadLine
            l3 = reader.ReadLine
        End Using

        Using Writer As New StreamWriter("DesktopSpace.conf")
            Writer.WriteLine(l1)
            Writer.WriteLine("Default")
            Writer.WriteLine(l3)
        End Using
        Directory.CreateDirectory("Theme\Default")


        Using writer As New StreamWriter("Theme\Default\Default")

            writer.WriteLine("这是DesktopSpace的默认主题")
            writer.WriteLine("主题内容从""Theme_Start""开始,由""Theme_End""结束。从""Theme_Start""开始,前9行为")
            writer.WriteLine("主窗口颜色或者主窗口图片")
            writer.WriteLine("Box的大小:两个数字表示，中间由逗号隔开。有多少个桌面就会生成多少个Box,但不会超过10个。")
            writer.WriteLine("Box和主窗体左边界的距离：用一个数字表示")
            writer.WriteLine("Box和主窗体上边界的距离：用一个数字表示")
            writer.WriteLine("Box之间的距离：用一个数字表示")
            writer.WriteLine("标题的字体名称：输入一个字体名称，例如""微软雅黑""，无需带引号。")
            writer.WriteLine("标题的字体字号：一个数字，可以是小数")
            writer.WriteLine("标题文字颜色：3位整数表示RGB颜色，用逗号隔开，例如""255，255，255""。")
            writer.WriteLine("文字底部标识线的高度：一个数字表示")
            writer.WriteLine("文字底部标识线被选中的颜色：3位整数表示")
            writer.WriteLine("文字底部标识线鼠标经过时的颜色：3位整数表示。从这一行开始，便是对单个Box的设置。")
            writer.WriteLine("标题名称：任意可以被用来创建文件夹的字符。")
            writer.WriteLine("图标路径：图片的完整路径")
            writer.WriteLine("图标位置：图标在Box上的偏移量")
            writer.WriteLine("图标大小：图标显示的大小。4行为一组，可以继续往下设置第二个Box（桌面）。")
            writer.WriteLine("标题名称2")
            writer.WriteLine("图标路径2")
            writer.WriteLine("图标位置2")
            writer.WriteLine("图标大小2")
            writer.WriteLine("标题名称3")
            writer.WriteLine("图标路径3")
            writer.WriteLine("图标位置3")
            writer.WriteLine("图标大小3")
            writer.WriteLine("下面开始是可以被程序识别的内容")
            writer.WriteLine("Theme_Start")
            writer.WriteLine("96,96,96")
            writer.WriteLine("100,100")
            writer.WriteLine("40")
            writer.WriteLine("30")
            writer.WriteLine("20")
            writer.WriteLine("幼圆")
            writer.WriteLine("16.2")
            writer.WriteLine("255,255,255")
            writer.WriteLine("9")
            writer.WriteLine("0,255,0")
            writer.WriteLine("255,215,0")
            writer.WriteLine("Default")
            writer.WriteLine("UnknowPath")
            writer.WriteLine("0,0")
            writer.WriteLine("100,200")
            writer.WriteLine("Game")
            writer.WriteLine("UnknowPath")
            writer.WriteLine("0,0")
            writer.WriteLine("100,200")
            writer.WriteLine("Music")
            writer.WriteLine("UnknowPath")
            writer.WriteLine("0,0")
            writer.WriteLine("90,100")
            writer.WriteLine("Code")
            writer.WriteLine("UnknowPath")
            writer.WriteLine("0,0")
            writer.WriteLine("100,200")
            writer.WriteLine("Theme_End")
        End Using


    End Sub
End Class
