Public Class Box
    Inherits System.Windows.Forms.PictureBox
    Public B_Name As String
    Public Text_Color As String
    Public Line_Color As String
    Public Icon_Path As String
    Public Icon_Location As String
    Public Icon_Size As String

    Public WithEvents Titel As New Titel
    Public WithEvents Line As New Line
    Public WithEvents Icon As New Icon

    Public Sub New()
        '设置可透明
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.Red

        Dim Size_Value() As String = Main.Box_Size.Split(",")
        Size = New Size(Size_Value(0), Size_Value(1))

    End Sub

    Public Sub Box_Load(B_Name As String, Text_Color As String, Line_Color As String, Icon_Path As String, Icon_Location As String, Icon_Size As String)
        Me.B_Name = B_Name
        Me.Text_Color = Text_Color
        Me.Line_Color = Line_Color
        Me.Icon_Path = Icon_Path
        Me.Icon_Location = Icon_Location
        Me.Icon_Size = Icon_Size
        '将自己加载进主窗体
        Main.Controls.Add(Me)
        Location = New Point(Main.M_Padding, 100)
        '初始化Titel、Line
        Titel.Titel_Load(Me)
        Line.Line_Load(Me)
        Icon.Icon_Load(Me)

    End Sub




    '鼠标悬停
    Private Sub Box_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, Icon.MouseMove, Titel.MouseMove

        Me.Line.BackColor = Color.Blue
        'BackColor = Color.Transparent
    End Sub


    Private Sub Box_MouseLeeve(sender As Object, e As EventArgs) Handles Me.MouseLeave, Icon.MouseLeave, Titel.MouseLeave

        Me.Line.BackColor = Color.Red
        'BackColor = Color.Transparent
    End Sub

End Class
