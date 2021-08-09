Public Class Box
    Inherits System.Windows.Forms.PictureBox
    '创建4个元素
    'Icon：图标
    'Titel：标题文字
    'Line：标题文字下方的线
    Public Line = New Box_Line
    Public Titel = New Box_Titel

    Public Sub New()
        '设置可透明
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.Red
        Size = New Size(500, 500)



    End Sub

    Public Sub Load_Box()

        '设置父子关系（影响显示）
        Line.Parent = Me
        Titel.Parent = Me

        '将控件添加到主窗体（Main）
        'Main.Controls.Add(Titel)
        Main.Controls.Add(Line)


        '初始化所有元素
        Line.Line_Load(Me)
        Titel.Titel_Load(Me)
    End Sub





    Private Sub Box_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove


        Main.Testp.BackColor = Color.Red
        BackColor = Color.Transparent
    End Sub
End Class
