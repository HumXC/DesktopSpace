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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Title = New System.Windows.Forms.Label()
        Me.Code_text = New System.Windows.Forms.Label()
        Me.Music_text = New System.Windows.Forms.Label()
        Me.Game_text = New System.Windows.Forms.Label()
        Me.Defau_text = New System.Windows.Forms.Label()
        Me.Defau_Button = New System.Windows.Forms.RadioButton()
        Me.Game_Button = New System.Windows.Forms.RadioButton()
        Me.Music_Button = New System.Windows.Forms.RadioButton()
        Me.Code_Button = New System.Windows.Forms.RadioButton()
        Me.Animation_up = New System.Windows.Forms.Timer(Me.components)
        Me.Animation_down = New System.Windows.Forms.Timer(Me.components)
        Me.Info_B = New System.Windows.Forms.PictureBox()
        Me.Code_line = New System.Windows.Forms.PictureBox()
        Me.Music_line = New System.Windows.Forms.PictureBox()
        Me.Game_line = New System.Windows.Forms.PictureBox()
        Me.Default_line = New System.Windows.Forms.PictureBox()
        Me.Code_ico = New System.Windows.Forms.PictureBox()
        Me.Music_ico = New System.Windows.Forms.PictureBox()
        Me.Game_ico = New System.Windows.Forms.PictureBox()
        Me.Default_ico = New System.Windows.Forms.PictureBox()
        Me.Code_line_back = New System.Windows.Forms.PictureBox()
        Me.Music_line_back = New System.Windows.Forms.PictureBox()
        Me.Game_line_back = New System.Windows.Forms.PictureBox()
        Me.Default_line_back = New System.Windows.Forms.PictureBox()
        CType(Me.Info_B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Code_line, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Music_line, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Game_line, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Default_line, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Code_ico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Music_ico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Game_ico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Default_ico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Code_line_back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Music_line_back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Game_line_back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Default_line_back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Title.Cursor = System.Windows.Forms.Cursors.No
        Me.Title.Font = New System.Drawing.Font("幼圆", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Title.Location = New System.Drawing.Point(-1, 478)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(668, 63)
        Me.Title.TabIndex = 4
        Me.Title.Text = "桌面空间"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Code_text
        '
        Me.Code_text.AutoSize = True
        Me.Code_text.BackColor = System.Drawing.Color.Transparent
        Me.Code_text.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Code_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Code_text.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Code_text.Location = New System.Drawing.Point(506, 30)
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
        Me.Music_text.Location = New System.Drawing.Point(359, 30)
        Me.Music_text.Name = "Music_text"
        Me.Music_text.Size = New System.Drawing.Size(118, 160)
        Me.Music_text.TabIndex = 11
        Me.Music_text.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Music "
        '
        'Game_text
        '
        Me.Game_text.AutoSize = True
        Me.Game_text.BackColor = System.Drawing.Color.Transparent
        Me.Game_text.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Game_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Game_text.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Game_text.Location = New System.Drawing.Point(214, 30)
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
        Me.Defau_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Defau_text.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Defau_text.Location = New System.Drawing.Point(62, 30)
        Me.Defau_text.Name = "Defau_text"
        Me.Defau_text.Size = New System.Drawing.Size(129, 160)
        Me.Defau_text.TabIndex = 13
        Me.Defau_text.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Default "
        '
        'Defau_Button
        '
        Me.Defau_Button.AutoSize = True
        Me.Defau_Button.Location = New System.Drawing.Point(63, 383)
        Me.Defau_Button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Defau_Button.Name = "Defau_Button"
        Me.Defau_Button.Size = New System.Drawing.Size(84, 19)
        Me.Defau_Button.TabIndex = 14
        Me.Defau_Button.TabStop = True
        Me.Defau_Button.Text = "Default"
        Me.Defau_Button.UseVisualStyleBackColor = True
        '
        'Game_Button
        '
        Me.Game_Button.AutoSize = True
        Me.Game_Button.Location = New System.Drawing.Point(225, 383)
        Me.Game_Button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Game_Button.Name = "Game_Button"
        Me.Game_Button.Size = New System.Drawing.Size(60, 19)
        Me.Game_Button.TabIndex = 15
        Me.Game_Button.TabStop = True
        Me.Game_Button.Text = "Game"
        Me.Game_Button.UseVisualStyleBackColor = True
        '
        'Music_Button
        '
        Me.Music_Button.AutoSize = True
        Me.Music_Button.Location = New System.Drawing.Point(362, 383)
        Me.Music_Button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Music_Button.Name = "Music_Button"
        Me.Music_Button.Size = New System.Drawing.Size(68, 19)
        Me.Music_Button.TabIndex = 16
        Me.Music_Button.TabStop = True
        Me.Music_Button.Text = "Music"
        Me.Music_Button.UseVisualStyleBackColor = True
        '
        'Code_Button
        '
        Me.Code_Button.AutoSize = True
        Me.Code_Button.Location = New System.Drawing.Point(506, 383)
        Me.Code_Button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Code_Button.Name = "Code_Button"
        Me.Code_Button.Size = New System.Drawing.Size(60, 19)
        Me.Code_Button.TabIndex = 17
        Me.Code_Button.TabStop = True
        Me.Code_Button.Text = "Code"
        Me.Code_Button.UseVisualStyleBackColor = True
        '
        'Animation_up
        '
        Me.Animation_up.Interval = 10
        '
        'Animation_down
        '
        Me.Animation_down.Interval = 10
        '
        'Info_B
        '
        Me.Info_B.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Info_B.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Info_B.Location = New System.Drawing.Point(655, 0)
        Me.Info_B.Name = "Info_B"
        Me.Info_B.Size = New System.Drawing.Size(42, 42)
        Me.Info_B.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Info_B.TabIndex = 32
        Me.Info_B.TabStop = False
        '
        'Code_line
        '
        Me.Code_line.BackColor = System.Drawing.Color.Lime
        Me.Code_line.Location = New System.Drawing.Point(511, 196)
        Me.Code_line.Name = "Code_line"
        Me.Code_line.Size = New System.Drawing.Size(104, 9)
        Me.Code_line.TabIndex = 27
        Me.Code_line.TabStop = False
        '
        'Music_line
        '
        Me.Music_line.BackColor = System.Drawing.Color.Lime
        Me.Music_line.Location = New System.Drawing.Point(369, 196)
        Me.Music_line.Name = "Music_line"
        Me.Music_line.Size = New System.Drawing.Size(104, 9)
        Me.Music_line.TabIndex = 26
        Me.Music_line.TabStop = False
        '
        'Game_line
        '
        Me.Game_line.BackColor = System.Drawing.Color.Lime
        Me.Game_line.Location = New System.Drawing.Point(225, 196)
        Me.Game_line.Name = "Game_line"
        Me.Game_line.Size = New System.Drawing.Size(104, 9)
        Me.Game_line.TabIndex = 25
        Me.Game_line.TabStop = False
        '
        'Default_line
        '
        Me.Default_line.BackColor = System.Drawing.Color.Lime
        Me.Default_line.Location = New System.Drawing.Point(55, 196)
        Me.Default_line.Name = "Default_line"
        Me.Default_line.Size = New System.Drawing.Size(138, 9)
        Me.Default_line.TabIndex = 24
        Me.Default_line.TabStop = False
        '
        'Code_ico
        '
        Me.Code_ico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Code_ico.Location = New System.Drawing.Point(503, 40)
        Me.Code_ico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Code_ico.Name = "Code_ico"
        Me.Code_ico.Size = New System.Drawing.Size(124, 115)
        Me.Code_ico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Code_ico.TabIndex = 21
        Me.Code_ico.TabStop = False
        Me.Code_ico.Tag = "Code"
        '
        'Music_ico
        '
        Me.Music_ico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Music_ico.Location = New System.Drawing.Point(363, 54)
        Me.Music_ico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Music_ico.Name = "Music_ico"
        Me.Music_ico.Size = New System.Drawing.Size(112, 93)
        Me.Music_ico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Music_ico.TabIndex = 20
        Me.Music_ico.TabStop = False
        Me.Music_ico.Tag = "Music"
        '
        'Game_ico
        '
        Me.Game_ico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Game_ico.Location = New System.Drawing.Point(218, 54)
        Me.Game_ico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Game_ico.Name = "Game_ico"
        Me.Game_ico.Size = New System.Drawing.Size(118, 93)
        Me.Game_ico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Game_ico.TabIndex = 19
        Me.Game_ico.TabStop = False
        Me.Game_ico.Tag = "Game"
        '
        'Default_ico
        '
        Me.Default_ico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Default_ico.Location = New System.Drawing.Point(55, 46)
        Me.Default_ico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Default_ico.Name = "Default_ico"
        Me.Default_ico.Size = New System.Drawing.Size(138, 117)
        Me.Default_ico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Default_ico.TabIndex = 18
        Me.Default_ico.TabStop = False
        Me.Default_ico.Tag = "Default"
        '
        'Code_line_back
        '
        Me.Code_line_back.BackColor = System.Drawing.Color.Gold
        Me.Code_line_back.Location = New System.Drawing.Point(511, 224)
        Me.Code_line_back.Name = "Code_line_back"
        Me.Code_line_back.Size = New System.Drawing.Size(104, 9)
        Me.Code_line_back.TabIndex = 31
        Me.Code_line_back.TabStop = False
        Me.Code_line_back.Visible = False
        '
        'Music_line_back
        '
        Me.Music_line_back.BackColor = System.Drawing.Color.Gold
        Me.Music_line_back.Location = New System.Drawing.Point(369, 224)
        Me.Music_line_back.Name = "Music_line_back"
        Me.Music_line_back.Size = New System.Drawing.Size(104, 9)
        Me.Music_line_back.TabIndex = 30
        Me.Music_line_back.TabStop = False
        Me.Music_line_back.Visible = False
        '
        'Game_line_back
        '
        Me.Game_line_back.BackColor = System.Drawing.Color.Gold
        Me.Game_line_back.Location = New System.Drawing.Point(225, 224)
        Me.Game_line_back.Name = "Game_line_back"
        Me.Game_line_back.Size = New System.Drawing.Size(104, 9)
        Me.Game_line_back.TabIndex = 29
        Me.Game_line_back.TabStop = False
        Me.Game_line_back.Visible = False
        '
        'Default_line_back
        '
        Me.Default_line_back.BackColor = System.Drawing.Color.Gold
        Me.Default_line_back.Location = New System.Drawing.Point(55, 224)
        Me.Default_line_back.Name = "Default_line_back"
        Me.Default_line_back.Size = New System.Drawing.Size(138, 9)
        Me.Default_line_back.TabIndex = 28
        Me.Default_line_back.TabStop = False
        Me.Default_line_back.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(698, 237)
        Me.ControlBox = False
        Me.Controls.Add(Me.Info_B)
        Me.Controls.Add(Me.Code_line)
        Me.Controls.Add(Me.Music_line)
        Me.Controls.Add(Me.Game_line)
        Me.Controls.Add(Me.Default_line)
        Me.Controls.Add(Me.Code_ico)
        Me.Controls.Add(Me.Music_ico)
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
        Me.Controls.Add(Me.Code_line_back)
        Me.Controls.Add(Me.Music_line_back)
        Me.Controls.Add(Me.Game_line_back)
        Me.Controls.Add(Me.Default_line_back)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "桌面空间"
        CType(Me.Info_B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Code_line, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Music_line, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Game_line, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Default_line, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Code_ico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Music_ico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Game_ico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Default_ico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Code_line_back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Music_line_back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Game_line_back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Default_line_back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Title As Label
    Friend WithEvents Code_text As Label
    Friend WithEvents Music_text As Label
    Friend WithEvents Game_text As Label
    Friend WithEvents Defau_text As Label
    Friend WithEvents Defau_Button As RadioButton
    Friend WithEvents Game_Button As RadioButton
    Friend WithEvents Music_Button As RadioButton
    Friend WithEvents Default_ico As PictureBox
    Friend WithEvents Game_ico As PictureBox
    Friend WithEvents Music_ico As PictureBox
    Friend WithEvents Code_ico As PictureBox
    Friend WithEvents Code_Button As RadioButton
    Friend WithEvents Default_line As PictureBox
    Friend WithEvents Game_line As PictureBox
    Friend WithEvents Music_line As PictureBox
    Friend WithEvents Code_line As PictureBox
    Friend WithEvents Animation_up As Timer
    Friend WithEvents Animation_down As Timer
    Friend WithEvents Code_line_back As PictureBox
    Friend WithEvents Music_line_back As PictureBox
    Friend WithEvents Game_line_back As PictureBox
    Friend WithEvents Default_line_back As PictureBox
    Friend WithEvents Info_B As PictureBox
End Class
