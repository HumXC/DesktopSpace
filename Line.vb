Public Class Line
    Inherits System.Windows.Forms.PictureBox
    Public Titel = New Titel

    Public Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
    End Sub

    Public Sub Line_Load(Box As Object)
        Main.Controls.Add(Me)
        Size = New Size(Box.Titel.Size.Width + 16, 9)
        Location = New Point(Box.Location.X + (Box.Size.Width - Me.Size.Width) / 2, Box.Titel.Location.Y + Box.Titel.Size.Height + 5)
        BackColor = Color.Transparent


    End Sub

End Class
