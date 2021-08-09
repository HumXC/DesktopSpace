Public Class Icon
    Inherits System.Windows.Forms.PictureBox

    Public Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.Blue
        SizeMode = PictureBoxSizeMode.Zoom

    End Sub
    Public Sub Icon_Load(Box As Object)
        Main.Controls.Add(Me)
        Parent = Box
        Image = Image.FromFile(Box.Icon_Path)
        Dim Size_Value() As String = Box.Icon_Size.Split(",")
        Me.Size = New Size(Size_Value(0), Size_Value(1))
        Dim Location_Value() As String = Box.Icon_Location.Split(",")
        Me.Location = New Point(Location_Value(0), Location_Value(1))
    End Sub


End Class
