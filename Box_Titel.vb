Public Class Box_Titel
    Inherits System.Windows.Forms.Label
    Public Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Font = New Font("幼圆", 36.0!, System.Drawing.FontStyle.Bold)
        TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Public Sub Titel_Load(Box As Object)
        BackColor = Color.Transparent
        Text = "Text"
        Size = New Size(Parent.Size.Width, 60)
        Location = New Point(Box.Location.X, Box.Location.Y + Box.Size.Height - Me.Size.Height - Box.Line.Size.Height / 2)
    End Sub

End Class
