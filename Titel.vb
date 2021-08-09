Public Class Titel
    Inherits System.Windows.Forms.Label
    Public Sub New()
        ' SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Font = New Font(" & Main.Titel_Font_Name & ", Main.Titel_Font_Size, System.Drawing.FontStyle.Bold)
        TextAlign = ContentAlignment.MiddleCenter
        ' BackColor = Color.Transparent
        AutoSize = True

    End Sub

    Public Sub Titel_Load(Box As Object)
        Main.Controls.Add(Me)
        Text = Box.Titel_Name
        ForeColor = Main.Titel_Color
        Location = New Point(Box.Location.x + (Box.Size.Width - Me.Size.Width) / 2, Box.Location.Y + Box.Size.Height + 5)

    End Sub



End Class
