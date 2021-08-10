Imports System.IO
Imports System.Text.RegularExpressions
Public Class Theme_Edit
    'Box的大小
    Public Box_Size As String
    'Box和主窗体左边界的距离
    Public L_Padding As Integer
    'Box和主窗体上边界的距离
    Public U_Padding As Integer
    'Box之间的距离
    Public Spacing As Integer
    'Titel的字体设置
    Public Titel_Font_Name As String
    Public Titel_Font_Size As Integer
    'Titel的字体颜色
    Public Titel_Color_S As String
    Public Titel_Color As Color
    'Line的高度
    Public Line_Height As Integer
    'Line默认的颜色
    Public Line_Color_S As String
    Public Line_Color As Color
    'Line被选中时的颜色
    Public Line_Select_Color_S As String
    Public Line_Select_Color As Color

    Public Box(10) As Object

    Dim Main_editt As New Main_Edit

    Private Sub Theme_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Main_editt.MdiParent = Me
        Main_editt.Show()
        Dim Editt As New Main_Edit
        Editt.MdiParent = Me
        Editt.Show()
        Editt.Dock = DockStyle.Bottom
    End Sub

    Private Sub Theme_Edit_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Main.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Rgb_Value3() As String = Main_Color.Text.Split(",")
        Main_editt.BackColor = Color.FromArgb(Rgb_Value3(0), Rgb_Value3(1), Rgb_Value3(2))

    End Sub
End Class