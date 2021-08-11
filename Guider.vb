Imports System.ComponentModel
Imports System.IO
Public Class Guider
    Private page As Integer = 0
    Private Sub Guider_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Button2.Visible = False
        '创建主题文件夹，创建配置文件，写入原始桌面路径
        Directory.CreateDirectory(Application.StartupPath & "/Theme/")
        Using Writer As New StreamWriter(Application.StartupPath & "/DesktopSpace.conf")
            Writer.WriteLine(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
        End Using

    End Sub

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
                Lab1.Text = "设置主界面"
                Lab2.Text = "主界面是为你提供操作的主要界面" & vbCr & "她现在在你左边" & vbCr & "把她设置成你喜欢的样子"
                RedBar.Visible = True
                RedValue.Visible = True
                GreenBar.Visible = True
                GreenValue.Visible = True
                BlueBar.Visible = True
                BlueValue.Visible = True

        End Select
    End Sub

    '关闭所有控件
    Private Sub TurnOff()
        changePath.Visible = False
        PathBox.Visible = False
        RedBar.Visible = False
        RedValue.Visible = False
        GreenBar.Visible = False
        GreenValue.Visible = False
        BlueBar.Visible = False
        BlueValue.Visible = False

    End Sub


    Private Sub Guider_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        '方便测试，删除配置文件
        File.Delete(Application.StartupPath & "/DesktopSpace.conf")
        End
    End Sub

    Private Sub ChangePath_Click(sender As Object, e As EventArgs) Handles changePath.Click
        FolderBrowserDialog1.ShowDialog()
        PathBox.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Main.Location = New Point(Me.Location.X - Main.Size.Width - 20, Me.Location.Y + (Me.Size.Height - Main.Size.Height) / 2)
    End Sub

    Private Sub ColorBar_Scroll(sender As Object, e As EventArgs) Handles RedBar.Scroll, GreenBar.Scroll, BlueBar.Scroll
        RedValue.Text = RedBar.Value
        GreenValue.Text = GreenBar.Value
        BlueValue.Text = BlueBar.Value
        Main.BackColor = Color.FromArgb(RedBar.Value, GreenBar.Value, BlueBar.Value)
    End Sub
End Class