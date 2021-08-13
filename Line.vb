Public Class Line
    Inherits System.Windows.Forms.PictureBox

    Public Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
    End Sub

    Public Sub Line_Load(Box As Object)

        Main.Controls.Add(Me)
        Size = New Size(Box.Titel.Size.Width + 16, Main.Line_Height)
        Location = New Point(Box.Location.X + (Box.Size.Width - Me.Size.Width) / 2, Box.Titel.Location.Y + Box.Titel.Size.Height + 5)
        BackColor = Color.Transparent
        Size = New Size(Me.Size.Width, Main.Line_Height)
    End Sub


    Public Sub Line_Set(Box As Object)

        Size = New Size(Box.Titel.Size.Width + 16, Main.Line_Height)
        Location = New Point(Box.Location.X + (Box.Size.Width - Me.Size.Width) / 2, Box.Titel.Location.Y + Box.Titel.Size.Height + 5)
        BackColor = Color.Transparent
        Size = New Size(Me.Size.Width, Main.Line_Height)
    End Sub


End Class
