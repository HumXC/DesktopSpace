Public Class CreateColor
    Private Sub CreateColor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'RGB颜色滑块
    Private Sub ColorBar_Scroll(sender As Object, e As EventArgs) Handles RedBar.ValueChanged, GreenBar.ValueChanged, BlueBar.ValueChanged
        RedValue.Text = RedBar.Value
        GreenValue.Text = GreenBar.Value
        BlueValue.Text = BlueBar.Value
        '改变确定按钮颜色
        If Guider.page = 2 Then
            ColorEnter.BackColor = Color.FromArgb(RedBar.Value, GreenBar.Value, BlueBar.Value)
        Else
            ColorEnter.ForeColor = Color.FromArgb(RedBar.Value, GreenBar.Value, BlueBar.Value)
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
    Private Sub ColorEnter_Click(sender As Object, e As EventArgs) Handles ColorEnter.Click, RedBar.LostFocus
        If Guider.page = 2 Then
            Main.BackColor = ColorEnter.BackColor
        Else

        End If

        Me.Close()
    End Sub

End Class