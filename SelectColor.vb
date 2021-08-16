Public Class SelectColor
    Private My_Color As String
    Private Key_Code As Integer
    Public Sub Set_Key_Code(Key_Code As Integer)
        Me.Key_Code = Key_Code
    End Sub
    '设置初始值
    Public Sub F_Color(Rgb1 As String, RGB2 As String, RGB3 As String)
        RedValue.Text = Rgb1
        GreenValue.Text = RGB2
        BlueValue.Text = RGB3
    End Sub
    'RGB颜色滑块
    Private Sub ColorBar_Scroll(sender As Object, e As EventArgs) Handles RedBar.ValueChanged, GreenBar.ValueChanged, BlueBar.ValueChanged
        RedValue.Text = RedBar.Value
        GreenValue.Text = GreenBar.Value
        BlueValue.Text = BlueBar.Value
        '改变确定按钮颜色

        If Key_Code = 2 Then
            ColorEnter.ForeColor = Color.FromArgb(RedBar.Value, GreenBar.Value, BlueBar.Value)
        Else
            ColorEnter.BackColor = Color.FromArgb(RedBar.Value, GreenBar.Value, BlueBar.Value)

        End If





    End Sub
    'RGB颜色输入框
    Private Sub ColorValue_TextChanged(sender As Object, e As EventArgs) Handles RedValue.TextChanged, GreenValue.TextChanged, BlueValue.TextChanged
        Try
            RedBar.Value = RedValue.Text
            GreenBar.Value = GreenValue.Text
            BlueBar.Value = BlueValue.Text
            '加载时便会运行这个方法，会报错，所以加上捕获
        Catch ex As InvalidCastException
            RedBar.Value = 0
            GreenBar.Value = 0
            BlueBar.Value = 0
        End Try
    End Sub

    '将color的值传出去
    Private Sub ColorEnter_Click(sender As Object, e As EventArgs) Handles ColorEnter.Click, Me.LostFocus

        My_Color = RedBar.Value & "," & GreenBar.Value & "," & BlueBar.Value
        Set_Color()
        Me.Close()

    End Sub

    Public Sub Set_Color()
        Select Case Key_Code
            '主界面颜色
            Case 1
                Main.M_Color = My_Color
                Main.Set_Main_Color()
                '标题颜色
            Case 2
                Main.Titel_Color_S = My_Color
                Main.Color_S_To_Color()

                For i = 0 To Main.Box_Num - 1
                    Main.Box(i).Titel.Titel_Set(Main.Box(i))
                Next
            Case 3
                '线的颜色
                Main.Line_Color_S = My_Color
                Main.Color_S_To_Color()

            Case 4
                '线被选中的颜色
                Main.Line_Select_Color_S = My_Color
                Main.Color_S_To_Color()

        End Select

    End Sub
End Class