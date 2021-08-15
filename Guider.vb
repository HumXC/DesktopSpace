Imports System.ComponentModel
Imports System.IO
Public Class Guider
    '页面序号
    Public page As Integer = 0



    '按下“下一步”
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.Visible = True
        page += 1
        Button3.Text = page

        Pageto()


    End Sub

    '按下“上一步”
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If page = 1 Then
            Button2.Visible = False
        End If
        page -= 1
        Button3.Text = page

        Pageto()

    End Sub

    Private Sub Pageto()
        '根据page的数字来显示页面内容
        Select Case page
            Case 0
                TurnOff()
                Lab1.Text = "设置向导"
                Lab2.Text = "让我来帮助你进行一些简单的设置"


            Case 1
                TurnOff()
                Lab1.Text = "桌面路径"
                Lab2.Text = "选择一个空文件夹用于存放所有的桌面" & vbCr & "你原本的桌面文件不会被删除" & vbCr & "新桌面将会是空的，你需要自己转移原有的文件" & vbCr & "如果你没有设置，则会使用默认配置"
                changePath.Visible = True
                PathBox.Visible = True

            Case 2
                TurnOff()
                Lab1.Text = "完成"
                Button1.Text = "完成"
                Lab2.Text = "你已经完成了设置，这些设置可以在后续更改" & vbCr & "即将进入主题编辑器" & vbCr & "你可以在主题编辑器里自定义程序的外观" & vbCr & "当然，你也可以在这里找到现成的主题直接使用"
            Case 3
                Main.change_Desktop_Path = PathBox.Text
                ThemeEditor.桌面空间所在路径.Text = PathBox.Text
                If ThemeEditor.桌面空间所在路径.Text = "" Then
                    Main.change_Desktop_Path = "D:\DesktopSpace\"
                End If
                ThemeEditor.桌面空间所在路径.Text = Main.change_Desktop_Path

                ThemeEditor.Visible = True
                Main.Default_Path = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                Using writer As New StreamWriter("DesktopSpace.conf")
                    writer.WriteLine(Main.change_Desktop_Path)
                    writer.WriteLine("Default")
                    writer.WriteLine(Main.Default_Path)

                End Using
                ThemeEditor.初始桌面路径.Text = Main.Default_Path

                Me.Close()

        End Select
    End Sub

    '关闭所有控件
    Private Sub TurnOff()
        changePath.Visible = False
        PathBox.Visible = False
        SelectColor.Visible = False

    End Sub


    '读取选择的桌面目录
    Private Sub ChangePath_Click(sender As Object, e As EventArgs) Handles changePath.Click
        FolderBrowserDialog1.ShowDialog()
        PathBox.Text = FolderBrowserDialog1.SelectedPath & "DesktopSpace"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ThemeEditor.Visible = False
    End Sub

    Private Sub Guider_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Guider_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Timer1.Enabled = False
        ThemeEditor.Visible = True
    End Sub
End Class