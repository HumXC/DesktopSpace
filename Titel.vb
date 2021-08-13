Public Class Titel
    Inherits System.Windows.Forms.Label
    Public Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        TextAlign = ContentAlignment.MiddleCenter
        BackColor = Color.Transparent
        AutoSize = True
        Cursor = Cursors.Hand

    End Sub

    Public Sub Titel_Load(Box As Object)

        Main.Controls.Add(Me)
        Text = Box.Titel_Text
        Font = New Font(" & Main.Titel_Font & ", Main.Titel_Size, System.Drawing.FontStyle.Bold)
        Location = New Point(Box.Location.X + (Box.Size.Width - Me.Size.Width) / 2, Box.Location.Y + Box.Size.Height)
        ForeColor = Main.Titel_Color


    End Sub

    Public Sub Titel_Set(Box As Object)

        Text = Box.Titel_Text
        Font = New Font(Main.Titel_Font, Main.Titel_Size, System.Drawing.FontStyle.Bold)
        Location = New Point(Box.Location.X + (Box.Size.Width - Me.Size.Width) / 2, Box.Location.Y + Box.Size.Height)
        ForeColor = Main.Titel_Color

    End Sub






End Class
