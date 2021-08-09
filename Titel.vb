Public Class Titel
    Inherits System.Windows.Forms.Label
    Public Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Font = New Font(Main.Titel_Font_Name, Main.Titel_Font_Size, System.Drawing.FontStyle.Bold)
        TextAlign = ContentAlignment.MiddleCenter
        BackColor = Color.Transparent
        AutoSize = True

    End Sub

    Public Sub Titel_Load(Box As Object)
        Main.Controls.Add(Me)
        Text = Box.B_Name
        '将3位字符串数字分割成3位RGB值
        Dim Rgb_Value() As String = Box.Text_Color.Split(",")
        ForeColor = Color.FromArgb(Rgb_Value(0), Rgb_Value(1), Rgb_Value(2))

        Location = New Point(Box.Location.x + (Box.Size.Width - Me.Size.Width) / 2, Box.Location.Y + Box.Size.Height)

    End Sub



End Class
