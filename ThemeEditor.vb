Public Class ThemeEditor
    Private Sub ThemeEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.MdiParent = Me
        Main.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.Delect_Box()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Main.Add_Box()
    End Sub
End Class