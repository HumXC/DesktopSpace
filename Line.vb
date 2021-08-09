Public Class Line
    Inherits System.Windows.Forms.PictureBox
    Public Titel = New Titel

    Public Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
    End Sub

    Public Sub Line_Load(Box As Object)
        Main.Controls.Add(Me)
        Size = New Size(Box.Titel.Size.Width + 16, 9)
        Location = New Point(Box.Location.X + (Box.Size.Width - Me.Size.Width) / 2, Box.Titel.Location.Y + Box.Titel.Size.Height)
        Dim Rgb_Value() As String = Box.Line_Color.Split(",")
        BackColor = Color.FromArgb(Rgb_Value(0), Rgb_Value(1), Rgb_Value(2))


    End Sub


    Private Sub Box_Line_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Main.Testp.BackColor = Color.Blue
    End Sub
End Class
