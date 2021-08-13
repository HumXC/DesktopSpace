Imports System.Drawing.FontFamily
Public Class SelectFont
    Private Text_Size As Integer = 9
    Public My_Font As String

    Private Sub Set_Font_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each FontFamily In Families

            ListBox1.Items.Add(FontFamily.Name)

        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.MouseDown
        Set_Lab()

    End Sub
    Public Sub Set_Lab()

        Label1.Font = New Font(CStr(ListBox1.SelectedItem), Text_Size, System.Drawing.FontStyle.Bold)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then
            Me.Text_Size = TextBox1.Text
            Set_Lab()
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Me.LostFocus
        Main.Titel_Font = CStr(ListBox1.SelectedItem)
        Main.Titel_Size = Me.Text_Size
        For i = 0 To Main.Box_Num - 1
            Main.Box(i).Titel.Titel_Set(Main.Box(i))
        Next
        Me.Close()
    End Sub


End Class