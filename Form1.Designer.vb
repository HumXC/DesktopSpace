<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Title = New System.Windows.Forms.Label()
        Me.Default_line = New System.Windows.Forms.Label()
        Me.Game_line = New System.Windows.Forms.Label()
        Me.Code_line = New System.Windows.Forms.Label()
        Me.Code_text = New System.Windows.Forms.Label()
        Me.Music_text = New System.Windows.Forms.Label()
        Me.Music_line = New System.Windows.Forms.Label()
        Me.Game_text = New System.Windows.Forms.Label()
        Me.Defau_text = New System.Windows.Forms.Label()
        Me.Defau_Button = New System.Windows.Forms.RadioButton()
        Me.Game_Button = New System.Windows.Forms.RadioButton()
        Me.Music_Button = New System.Windows.Forms.RadioButton()
        Me.Default_ico = New System.Windows.Forms.PictureBox()
        Me.Game_ico = New System.Windows.Forms.PictureBox()
        Me.Music_ioc = New System.Windows.Forms.PictureBox()
        Me.Code_ico = New System.Windows.Forms.PictureBox()
        Me.Code_Button = New System.Windows.Forms.RadioButton()
        CType(Me.Default_ico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Game_ico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Music_ioc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Code_ico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Title.Cursor = System.Windows.Forms.Cursors.No
        Me.Title.Font = New System.Drawing.Font("幼圆", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Title.Location = New System.Drawing.Point(11, 7)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(668, 63)
        Me.Title.TabIndex = 4
        Me.Title.Text = "桌面空间"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Default_line
        '
        Me.Default_line.AutoSize = True
        Me.Default_line.BackColor = System.Drawing.Color.Transparent
        Me.Default_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Default_line.Font = New System.Drawing.Font("Segoe UI Historic", 48.0!, System.Drawing.FontStyle.Bold)
        Me.Default_line.ForeColor = System.Drawing.Color.Lime
        Me.Default_line.Location = New System.Drawing.Point(45, 200)
        Me.Default_line.Name = "Default_line"
        Me.Default_line.Size = New System.Drawing.Size(181, 106)
        Me.Default_line.TabIndex = 5
        Me.Default_line.Text = "____"
        Me.Default_line.Visible = False
        '
        'Game_line
        '
        Me.Game_line.AutoSize = True
        Me.Game_line.BackColor = System.Drawing.Color.Transparent
        Me.Game_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Game_line.Font = New System.Drawing.Font("Segoe UI Historic", 48.0!, System.Drawing.FontStyle.Bold)
        Me.Game_line.ForeColor = System.Drawing.Color.Lime
        Me.Game_line.Location = New System.Drawing.Point(207, 210)
        Me.Game_line.Name = "Game_line"
        Me.Game_line.Size = New System.Drawing.Size(147, 106)
        Me.Game_line.TabIndex = 6
        Me.Game_line.Text = "___"
        Me.Game_line.Visible = False
        '
        'Code_line
        '
        Me.Code_line.AutoSize = True
        Me.Code_line.BackColor = System.Drawing.Color.Transparent
        Me.Code_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Code_line.Font = New System.Drawing.Font("Segoe UI Historic", 48.0!, System.Drawing.FontStyle.Bold)
        Me.Code_line.ForeColor = System.Drawing.Color.Lime
        Me.Code_line.Location = New System.Drawing.Point(479, 223)
        Me.Code_line.Name = "Code_line"
        Me.Code_line.Size = New System.Drawing.Size(147, 106)
        Me.Code_line.TabIndex = 8
        Me.Code_line.Text = "___"
        Me.Code_line.Visible = False
        '
        'Code_text
        '
        Me.Code_text.AutoSize = True
        Me.Code_text.BackColor = System.Drawing.Color.Transparent
        Me.Code_text.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Code_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Code_text.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Code_text.Location = New System.Drawing.Point(500, 126)
        Me.Code_text.Name = "Code_text"
        Me.Code_text.Size = New System.Drawing.Size(119, 160)
        Me.Code_text.TabIndex = 9
        Me.Code_text.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Code  "
        '
        'Music_text
        '
        Me.Music_text.AutoSize = True
        Me.Music_text.BackColor = System.Drawing.Color.Transparent
        Me.Music_text.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Music_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Music_text.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Music_text.Location = New System.Drawing.Point(356, 126)
        Me.Music_text.Name = "Music_text"
        Me.Music_text.Size = New System.Drawing.Size(118, 160)
        Me.Music_text.TabIndex = 11
        Me.Music_text.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Music "
        '
        'Music_line
        '
        Me.Music_line.AutoSize = True
        Me.Music_line.BackColor = System.Drawing.Color.Transparent
        Me.Music_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Music_line.Font = New System.Drawing.Font("Segoe UI Historic", 48.0!, System.Drawing.FontStyle.Bold)
        Me.Music_line.ForeColor = System.Drawing.Color.Lime
        Me.Music_line.Location = New System.Drawing.Point(344, 210)
        Me.Music_line.Name = "Music_line"
        Me.Music_line.Size = New System.Drawing.Size(147, 106)
        Me.Music_line.TabIndex = 7
        Me.Music_line.Text = "___"
        Me.Music_line.Visible = False
        '
        'Game_text
        '
        Me.Game_text.AutoSize = True
        Me.Game_text.BackColor = System.Drawing.Color.Transparent
        Me.Game_text.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Game_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Game_text.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Game_text.Location = New System.Drawing.Point(213, 93)
        Me.Game_text.Name = "Game_text"
        Me.Game_text.Size = New System.Drawing.Size(128, 160)
        Me.Game_text.TabIndex = 12
        Me.Game_text.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Game  "
        '
        'Defau_text
        '
        Me.Defau_text.AutoSize = True
        Me.Defau_text.BackColor = System.Drawing.Color.Transparent
        Me.Defau_text.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Defau_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Defau_text.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Defau_text.Location = New System.Drawing.Point(47, 70)
        Me.Defau_text.Name = "Defau_text"
        Me.Defau_text.Size = New System.Drawing.Size(116, 174)
        Me.Defau_text.TabIndex = 13
        Me.Defau_text.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Default "
        '
        'Defau_Button
        '
        Me.Defau_Button.AutoSize = True
        Me.Defau_Button.Location = New System.Drawing.Point(63, 342)
        Me.Defau_Button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Defau_Button.Name = "Defau_Button"
        Me.Defau_Button.Size = New System.Drawing.Size(124, 19)
        Me.Defau_Button.TabIndex = 14
        Me.Defau_Button.TabStop = True
        Me.Defau_Button.Text = "RadioButton1"
        Me.Defau_Button.UseVisualStyleBackColor = True
        '
        'Game_Button
        '
        Me.Game_Button.AutoSize = True
        Me.Game_Button.Location = New System.Drawing.Point(225, 342)
        Me.Game_Button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Game_Button.Name = "Game_Button"
        Me.Game_Button.Size = New System.Drawing.Size(124, 19)
        Me.Game_Button.TabIndex = 15
        Me.Game_Button.TabStop = True
        Me.Game_Button.Text = "RadioButton2"
        Me.Game_Button.UseVisualStyleBackColor = True
        '
        'Music_Button
        '
        Me.Music_Button.AutoSize = True
        Me.Music_Button.Location = New System.Drawing.Point(356, 342)
        Me.Music_Button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Music_Button.Name = "Music_Button"
        Me.Music_Button.Size = New System.Drawing.Size(124, 19)
        Me.Music_Button.TabIndex = 16
        Me.Music_Button.TabStop = True
        Me.Music_Button.Text = "RadioButton1"
        Me.Music_Button.UseVisualStyleBackColor = True
        '
        'Default_ico
        '
        Me.Default_ico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Default_ico.Location = New System.Drawing.Point(70, 101)
        Me.Default_ico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Default_ico.Name = "Default_ico"
        Me.Default_ico.Size = New System.Drawing.Size(117, 67)
        Me.Default_ico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Default_ico.TabIndex = 18
        Me.Default_ico.TabStop = False
        '
        'Game_ico
        '
        Me.Game_ico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Game_ico.Location = New System.Drawing.Point(210, 93)
        Me.Game_ico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Game_ico.Name = "Game_ico"
        Me.Game_ico.Size = New System.Drawing.Size(128, 82)
        Me.Game_ico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Game_ico.TabIndex = 19
        Me.Game_ico.TabStop = False
        '
        'Music_ioc
        '
        Me.Music_ioc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Music_ioc.Location = New System.Drawing.Point(362, 99)
        Me.Music_ioc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Music_ioc.Name = "Music_ioc"
        Me.Music_ioc.Size = New System.Drawing.Size(106, 76)
        Me.Music_ioc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Music_ioc.TabIndex = 20
        Me.Music_ioc.TabStop = False
        '
        'Code_ico
        '
        Me.Code_ico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Code_ico.Location = New System.Drawing.Point(485, 103)
        Me.Code_ico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Code_ico.Name = "Code_ico"
        Me.Code_ico.Size = New System.Drawing.Size(110, 67)
        Me.Code_ico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Code_ico.TabIndex = 21
        Me.Code_ico.TabStop = False
        '
        'Code_Button
        '
        Me.Code_Button.AutoSize = True
        Me.Code_Button.Location = New System.Drawing.Point(497, 342)
        Me.Code_Button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Code_Button.Name = "Code_Button"
        Me.Code_Button.Size = New System.Drawing.Size(124, 19)
        Me.Code_Button.TabIndex = 17
        Me.Code_Button.TabStop = True
        Me.Code_Button.Text = "RadioButton3"
        Me.Code_Button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(665, 434)
        Me.ControlBox = False
        Me.Controls.Add(Me.Code_ico)
        Me.Controls.Add(Me.Music_ioc)
        Me.Controls.Add(Me.Game_ico)
        Me.Controls.Add(Me.Default_ico)
        Me.Controls.Add(Me.Code_Button)
        Me.Controls.Add(Me.Music_Button)
        Me.Controls.Add(Me.Game_Button)
        Me.Controls.Add(Me.Defau_Button)
        Me.Controls.Add(Me.Defau_text)
        Me.Controls.Add(Me.Game_text)
        Me.Controls.Add(Me.Music_text)
        Me.Controls.Add(Me.Code_text)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Default_line)
        Me.Controls.Add(Me.Game_line)
        Me.Controls.Add(Me.Music_line)
        Me.Controls.Add(Me.Code_line)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "桌面空间"
        CType(Me.Default_ico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Game_ico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Music_ioc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Code_ico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Title As Label
    Friend WithEvents Default_line As Label
    Friend WithEvents Game_line As Label
    Friend WithEvents Code_line As Label
    Friend WithEvents Code_text As Label
    Friend WithEvents Music_text As Label
    Friend WithEvents Music_line As Label
    Friend WithEvents Game_text As Label
    Friend WithEvents Defau_text As Label
    Friend WithEvents Defau_Button As RadioButton
    Friend WithEvents Game_Button As RadioButton
    Friend WithEvents Music_Button As RadioButton
    Friend WithEvents Default_ico As PictureBox
    Friend WithEvents Game_ico As PictureBox
    Friend WithEvents Music_ioc As PictureBox
    Friend WithEvents Code_ico As PictureBox
    Friend WithEvents Code_Button As RadioButton
End Class
