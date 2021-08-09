Public Class Main
    Public bb = New Box
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load

        Controls.Add(bb)
        bb.Load_Box()
        'Controls.Add(bb.line)
    End Sub

    Private Sub Main_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Testp.BackColor = Color.Green
    End Sub
End Class