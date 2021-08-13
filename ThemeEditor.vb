Public Class ThemeEditor
    '当前编辑的Box序号
    Public Box_Index As Integer = 200
    Private Sub ThemeEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.MdiParent = Me
        Main.Show()
        Dim Size_Value() As String = Main.Box_Size.Split(",")
        Icon_X.Width = Size_Value(0) + 34
        Icon_X.Maximum = Size_Value(0)
        Icon_X.Value = Size_Value(0) / 2

        Icon_Y.Height = Size_Value(1) + 34
        Icon_Y.Maximum = Size_Value(1)
        Icon_Y.Value = Size_Value(1) / 2
        '     Icon_E.Size = New Size(Size_Value(0), Size_Value(1))

        Icon_LX.Width = Size_Value(0) + 34
        Icon_LX.Maximum = Size_Value(0)

        Icon_LY.Height = Size_Value(1) + 34
        Icon_LY.Maximum = Size_Value(1)
        Icon_LY.Value = Icon_LY.Maximum

        Box_E.Size = New Size(Size_Value(0), Size_Value(1))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Delete_aBox.Click
        Main.Delect_Box()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Add_aBox.Click
        Main.Add_Box()
    End Sub

    '设置图片框控件为合适的图片大小
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Icon_E.Click

        '       Dim Size_Value() As String = Main.Box_Size.Split(",")
        Dim Img = Image.FromFile("D:/test.gif")
        '       If Img.Width > Size_Value(0) Or Img.Height > Size_Value(1) Then
        '           If Img.Width > Img.Height Then
        '               PictureBox1.Size = New Size(Size_Value(0), Img.Size.Height / (Img.Width / Size_Value(0)))
        '           Else
        '               PictureBox1.Size = New Size(Img.Size.Width / (Img.Height / Size_Value(1)), Size_Value(1))
        '           End If
        '       End If
        Icon_E.Image = Img
    End Sub


    Private Sub ThemeEditor_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_E.Click
        Label1.Text = Icon_E.Image.Size.Width
        Label2.Text = Icon_E.Image.Size.Height
        Label3.Text = Icon_E.Size.Width
        Label4.Text = Icon_E.Size.Height
    End Sub

    Private Sub Icon_X_ValueChanged(sender As Object, e As EventArgs) Handles Icon_X.ValueChanged
        Icon_E.Size = New Size(Icon_X.Value, Icon_E.Height)

    End Sub

    Private Sub Icon_Y_ValueChanged(sender As Object, e As EventArgs) Handles Icon_Y.ValueChanged
        Icon_E.Size = New Size(Icon_E.Width, Icon_Y.Maximum - Icon_Y.Value)
    End Sub

    Private Sub Icon_X_Scroll(sender As Object, e As EventArgs) Handles Icon_X.Scroll
        Try
            Main.Box(Box_Index).Icon_Size = Icon_X.Value & "," & Main.Box(Box_Index).Icon.Size.Height
            Main.Box(Box_Index).Icon.Icon_Set(Main.Box(Box_Index))
        Catch ex As System.IndexOutOfRangeException
            '什么也不做
        End Try
    End Sub

    Private Sub Icon_Y_Scroll(sender As Object, e As EventArgs) Handles Icon_Y.Scroll
        Try
            Main.Box(Box_Index).Icon_Size = Main.Box(Box_Index).Icon.Size.Width & "," & Icon_Y.Maximum - Icon_Y.Value
            Main.Box(Box_Index).Icon.Icon_Set(Main.Box(Box_Index))
        Catch ex As System.IndexOutOfRangeException
            '什么也不做
        End Try
    End Sub

    Private Sub Icon_LX_ValueChanged(sender As Object, e As EventArgs) Handles Icon_LX.ValueChanged
        Icon_X.Location = New Point(Box_E.Location.X - 17 + Icon_LX.Value, Icon_X.Location.Y)
        Icon_E.Location = New Point(Box_E.Location.X + Icon_LX.Value, Icon_E.Location.Y)
    End Sub

    Private Sub Icon_LY_ValueChanged(sender As Object, e As EventArgs) Handles Icon_LY.ValueChanged
        Icon_Y.Location = New Point(Icon_Y.Location.X, Box_E.Location.Y - 51 - Icon_LY.Value + Icon_Y.Size.Height)
        Icon_E.Location = New Point(Icon_E.Location.X, Box_E.Location.Y + Icon_LY.Maximum - Icon_LY.Value)
    End Sub


    Private Sub Icon_LX_Scroll(sender As Object, e As EventArgs) Handles Icon_LX.Scroll
        Try
            Main.Box(Box_Index).Icon_Location = Icon_LX.Value & "," & Main.Box(Box_Index).Icon.Location.Y
            Main.Box(Box_Index).Icon.Icon_Set(Main.Box(Box_Index))
        Catch ex As System.IndexOutOfRangeException
            '什么也不做
        End Try
    End Sub
    Private Sub Icon_LY_Scroll(sender As Object, e As EventArgs) Handles Icon_LY.Scroll
        Try
            Main.Box(Box_Index).Icon_Location = Main.Box(Box_Index).Icon.Location.X & "," & Icon_LY.Maximum - Icon_LY.Value
            Main.Box(Box_Index).Icon.Icon_Set(Main.Box(Box_Index))
        Catch ex As System.IndexOutOfRangeException
            '什么也不做
        End Try
    End Sub

    '居中按钮
    Private Sub Set_Center_Click(sender As Object, e As EventArgs) Handles Set_Center.Click
        Try
            Icon_LX.Value = (Box_E.Size.Width - Icon_E.Size.Width) / 2
            Icon_LY.Value = Icon_LY.Maximum - (Box_E.Size.Height - Icon_E.Size.Height) / 2
            Main.Box(Box_Index).Icon_Location = Icon_LX.Value & "," & Icon_LY.Maximum - Icon_LY.Value
            Main.Box(Box_Index).Icon.Icon_Set(Main.Box(Box_Index))
        Catch ex As System.IndexOutOfRangeException
            '什么也不做
        End Try

    End Sub
End Class