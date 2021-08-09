Public Class Box_Line
    Inherits System.Windows.Forms.PictureBox
    Public Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.FromArgb(0, 255, 0)

    End Sub

    Public Sub Line_Load(Box As Object)

        Size = New Size(Box.Size.Width, 50)
        Location = New Point(Box.Location.X, Box.Location.Y + Box.Size.Height - Me.Height)


    End Sub


    Private Sub Box_Line_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Main.Testp.BackColor = Color.Blue
    End Sub
End Class
