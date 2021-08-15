Public Class Icon
    Inherits System.Windows.Forms.PictureBox

    Public Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.Transparent
        SizeMode = PictureBoxSizeMode.Zoom
        Cursor = Cursors.Hand

    End Sub
    Public Sub Icon_Load(Box As Object)
        Main.Controls.Add(Me)
        Parent = Box
        Dim Size_Value() As String = Box.Icon_Size.Split(",")
        Me.Size = New Size(Size_Value(0), Size_Value(1))

        Dim Location_Value() As String = Box.Icon_Location.Split(",")
        Me.Location = New Point(Location_Value(0), Location_Value(1))

        Try
            Image = Image.FromFile(Application.StartupPath & "/Theme/" & Main.Theme_Name & "/icon" & Box.Icon_Name)
        Catch ex As System.ArgumentException
            ImageLocation = Box.Icon_Icon_Name
        Catch ex As System.NotSupportedException
            ImageLocation = Box.Icon_Icon_Name
        Catch ex As System.IO.FileNotFoundException

            Size = New Size(100, 100)
            Image = My.Resources.Resources._Default
            BackColor = Color.Transparent
            Location = New Point(0, 5) 'New Point((Parent.Size.Width - Me.Size.Width) \ 2, Parent.Size.Height - Me.Size.Height - 20)
            Box.Icon_Size = "100,100"
            Box.Icon_Location = "0,5"
            Box.Icon_Name = "UnknowPath"

        End Try
    End Sub



End Class
