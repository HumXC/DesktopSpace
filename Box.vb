Public Class Box
    Inherits System.Windows.Forms.PictureBox
    Public Titel_Name As String
    Public Text_Color As String
    Public Icon_Path As String
    Public Icon_Location As String
    Public Icon_Size As String

    Public WithEvents Titel As New Titel
    Public WithEvents Line As New Line
    Public WithEvents Icon As New Icon
    '用户看不见的单选按钮，用于键盘控制
    Public WithEvents Ctrl As New RadioButton

    Public Sub New()
        '设置可透明
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.Red

        Dim Size_Value() As String = Main.Box_Size.Split(",")
        Size = New Size(Size_Value(0), Size_Value(1))

    End Sub

    Public Sub Box_Load(Titel_Name As String, Icon_Path As String, Icon_Location As String, Icon_Size As String)
        Me.Titel_Name = Titel_Name
        Me.Icon_Path = Icon_Path
        Me.Icon_Location = Icon_Location
        Me.Icon_Size = Icon_Size
        '将自己加载进主窗体
        Main.Controls.Add(Me)
        Location = New Point(Main.M_Padding, 50)
        '初始化Ctrl,Titel、Line
        Main.Controls.Add(Ctrl)
        Ctrl.Location = New Point(Me.Location.X, Me.Location.Y + Me.Size.Height + 200)

        Titel.Titel_Load(Me)
        Line.Line_Load(Me)
        Icon.Icon_Load(Me)

    End Sub




    '鼠标悬停
    Private Sub Box_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, Icon.MouseMove, Titel.MouseMove
        If Me.Ctrl.Checked = False Then
            Me.Line.BackColor = Main.Line_Select_Color
        End If

        'BackColor = Color.Transparent
    End Sub

    '鼠标移开
    Private Sub Box_MouseLeeve(sender As Object, e As EventArgs) Handles Me.MouseLeave, Icon.MouseLeave, Titel.MouseLeave
        If Me.Ctrl.Checked = False Then
            Me.Line.BackColor = Color.Transparent
        End If

        'BackColor = Color.Transparent
    End Sub

    '按键控制
    Private Sub Box_KeyChange(sender As Object, e As EventArgs) Handles Ctrl.CheckedChanged
        If Ctrl.Checked = False Then
            Me.Line.BackColor = Color.Transparent
        ElseIf Ctrl.Checked = True Then
            Me.Line.BackColor = Main.Line_Color
        End If
    End Sub




End Class
