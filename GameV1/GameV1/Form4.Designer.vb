<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer8 = New System.Windows.Forms.Timer(Me.components)
        Me.BULLET = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PaperFIRE = New System.Windows.Forms.PictureBox()
        Me.bird2ENEMY = New System.Windows.Forms.PictureBox()
        Me.bird1ENEMY = New System.Windows.Forms.PictureBox()
        Me.PictureBox6WALL = New System.Windows.Forms.PictureBox()
        Me.PictureBox5WALL = New System.Windows.Forms.PictureBox()
        Me.WALL = New System.Windows.Forms.PictureBox()
        Me.PictureBox3WALL = New System.Windows.Forms.PictureBox()
        Me.asteroid1WALL = New System.Windows.Forms.PictureBox()
        Me.asteroidWALL = New System.Windows.Forms.PictureBox()
        Me.asteroid3WALL = New System.Windows.Forms.PictureBox()
        Me.CraneBOSS = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Bird3ENEMY = New System.Windows.Forms.PictureBox()
        CType(Me.BULLET, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaperFIRE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bird2ENEMY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bird1ENEMY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6WALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5WALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3WALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.asteroid1WALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.asteroidWALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.asteroid3WALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CraneBOSS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bird3ENEMY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.Location = New System.Drawing.Point(734, 21)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(39, 13)
        Me.ScoreLabel.TabIndex = 40
        Me.ScoreLabel.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 3000
        '
        'Timer4
        '
        Me.Timer4.Interval = 25
        '
        'Timer5
        '
        Me.Timer5.Enabled = True
        Me.Timer5.Interval = 100000
        '
        'Timer6
        '
        Me.Timer6.Enabled = True
        '
        'Timer8
        '
        Me.Timer8.Enabled = True
        '
        'BULLET
        '
        Me.BULLET.Image = Global.GameV1.My.Resources.Resources._1200px_Small_pair_of_blue_scissors
        Me.BULLET.Location = New System.Drawing.Point(561, -65)
        Me.BULLET.Name = "BULLET"
        Me.BULLET.Size = New System.Drawing.Size(48, 30)
        Me.BULLET.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BULLET.TabIndex = 43
        Me.BULLET.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.GameV1.My.Resources.Resources.asteroid2WALL
        Me.PictureBox2.Location = New System.Drawing.Point(2, -18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(818, 22)
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'PaperFIRE
        '
        Me.PaperFIRE.BackColor = System.Drawing.Color.Transparent
        Me.PaperFIRE.Image = Global.GameV1.My.Resources.Resources.paper
        Me.PaperFIRE.Location = New System.Drawing.Point(694, 12)
        Me.PaperFIRE.Name = "PaperFIRE"
        Me.PaperFIRE.Size = New System.Drawing.Size(34, 37)
        Me.PaperFIRE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PaperFIRE.TabIndex = 41
        Me.PaperFIRE.TabStop = False
        Me.PaperFIRE.Visible = False
        '
        'bird2ENEMY
        '
        Me.bird2ENEMY.Image = Global.GameV1.My.Resources.Resources.origamibird
        Me.bird2ENEMY.Location = New System.Drawing.Point(714, 321)
        Me.bird2ENEMY.Name = "bird2ENEMY"
        Me.bird2ENEMY.Size = New System.Drawing.Size(71, 65)
        Me.bird2ENEMY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bird2ENEMY.TabIndex = 39
        Me.bird2ENEMY.TabStop = False
        '
        'bird1ENEMY
        '
        Me.bird1ENEMY.Image = Global.GameV1.My.Resources.Resources.origamibird
        Me.bird1ENEMY.Location = New System.Drawing.Point(714, 98)
        Me.bird1ENEMY.Name = "bird1ENEMY"
        Me.bird1ENEMY.Size = New System.Drawing.Size(71, 65)
        Me.bird1ENEMY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bird1ENEMY.TabIndex = 38
        Me.bird1ENEMY.TabStop = False
        '
        'PictureBox6WALL
        '
        Me.PictureBox6WALL.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6WALL.Image = Global.GameV1.My.Resources.Resources.asteroid2WALL
        Me.PictureBox6WALL.Location = New System.Drawing.Point(-7, -25)
        Me.PictureBox6WALL.Name = "PictureBox6WALL"
        Me.PictureBox6WALL.Size = New System.Drawing.Size(818, 22)
        Me.PictureBox6WALL.TabIndex = 37
        Me.PictureBox6WALL.TabStop = False
        '
        'PictureBox5WALL
        '
        Me.PictureBox5WALL.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5WALL.Image = Global.GameV1.My.Resources.Resources.asteroid2WALL
        Me.PictureBox5WALL.Location = New System.Drawing.Point(-133, 469)
        Me.PictureBox5WALL.Name = "PictureBox5WALL"
        Me.PictureBox5WALL.Size = New System.Drawing.Size(999, 30)
        Me.PictureBox5WALL.TabIndex = 36
        Me.PictureBox5WALL.TabStop = False
        '
        'WALL
        '
        Me.WALL.BackColor = System.Drawing.Color.Transparent
        Me.WALL.Image = Global.GameV1.My.Resources.Resources.asteroid2WALL
        Me.WALL.Location = New System.Drawing.Point(791, -18)
        Me.WALL.Name = "WALL"
        Me.WALL.Size = New System.Drawing.Size(10, 517)
        Me.WALL.TabIndex = 35
        Me.WALL.TabStop = False
        '
        'PictureBox3WALL
        '
        Me.PictureBox3WALL.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3WALL.Image = Global.GameV1.My.Resources.Resources.asteroid2WALL
        Me.PictureBox3WALL.Location = New System.Drawing.Point(2, -18)
        Me.PictureBox3WALL.Name = "PictureBox3WALL"
        Me.PictureBox3WALL.Size = New System.Drawing.Size(10, 517)
        Me.PictureBox3WALL.TabIndex = 34
        Me.PictureBox3WALL.TabStop = False
        '
        'asteroid1WALL
        '
        Me.asteroid1WALL.BackColor = System.Drawing.Color.Transparent
        Me.asteroid1WALL.Image = Global.GameV1.My.Resources.Resources.asterpod3WALL
        Me.asteroid1WALL.Location = New System.Drawing.Point(206, -189)
        Me.asteroid1WALL.Name = "asteroid1WALL"
        Me.asteroid1WALL.Size = New System.Drawing.Size(224, 335)
        Me.asteroid1WALL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.asteroid1WALL.TabIndex = 33
        Me.asteroid1WALL.TabStop = False
        '
        'asteroidWALL
        '
        Me.asteroidWALL.BackColor = System.Drawing.Color.Transparent
        Me.asteroidWALL.Image = Global.GameV1.My.Resources.Resources.asteroid2WALL
        Me.asteroidWALL.Location = New System.Drawing.Point(-27, 159)
        Me.asteroidWALL.Name = "asteroidWALL"
        Me.asteroidWALL.Size = New System.Drawing.Size(98, 187)
        Me.asteroidWALL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.asteroidWALL.TabIndex = 32
        Me.asteroidWALL.TabStop = False
        '
        'asteroid3WALL
        '
        Me.asteroid3WALL.BackColor = System.Drawing.Color.Transparent
        Me.asteroid3WALL.Image = Global.GameV1.My.Resources.Resources.asteroidWALL
        Me.asteroid3WALL.Location = New System.Drawing.Point(230, 333)
        Me.asteroid3WALL.Name = "asteroid3WALL"
        Me.asteroid3WALL.Size = New System.Drawing.Size(317, 166)
        Me.asteroid3WALL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.asteroid3WALL.TabIndex = 31
        Me.asteroid3WALL.TabStop = False
        '
        'CraneBOSS
        '
        Me.CraneBOSS.BackColor = System.Drawing.Color.Transparent
        Me.CraneBOSS.Image = Global.GameV1.My.Resources.Resources._96d59de576536789086c1e0b82fc91a7_origami_paper_crane_by_vexels
        Me.CraneBOSS.Location = New System.Drawing.Point(615, 169)
        Me.CraneBOSS.Name = "CraneBOSS"
        Me.CraneBOSS.Size = New System.Drawing.Size(170, 146)
        Me.CraneBOSS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CraneBOSS.TabIndex = 30
        Me.CraneBOSS.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.GameV1.My.Resources.Resources.PNGPIX_COM_The_Rock_PNG_Transparent_Image_500x463__2_
        Me.PictureBox1.Location = New System.Drawing.Point(86, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'Bird3ENEMY
        '
        Me.Bird3ENEMY.Image = Global.GameV1.My.Resources.Resources.origamibird
        Me.Bird3ENEMY.Location = New System.Drawing.Point(637, 98)
        Me.Bird3ENEMY.Name = "Bird3ENEMY"
        Me.Bird3ENEMY.Size = New System.Drawing.Size(71, 65)
        Me.Bird3ENEMY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bird3ENEMY.TabIndex = 44
        Me.Bird3ENEMY.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(798, 478)
        Me.Controls.Add(Me.Bird3ENEMY)
        Me.Controls.Add(Me.BULLET)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PaperFIRE)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.bird2ENEMY)
        Me.Controls.Add(Me.bird1ENEMY)
        Me.Controls.Add(Me.PictureBox6WALL)
        Me.Controls.Add(Me.PictureBox5WALL)
        Me.Controls.Add(Me.WALL)
        Me.Controls.Add(Me.PictureBox3WALL)
        Me.Controls.Add(Me.asteroid1WALL)
        Me.Controls.Add(Me.asteroidWALL)
        Me.Controls.Add(Me.asteroid3WALL)
        Me.Controls.Add(Me.CraneBOSS)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form4"
        Me.Text = "The Rock's Space Adventure"
        CType(Me.BULLET, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaperFIRE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bird2ENEMY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bird1ENEMY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6WALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5WALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3WALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.asteroid1WALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.asteroidWALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.asteroid3WALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CraneBOSS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bird3ENEMY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ScoreLabel As Label
    Friend WithEvents bird2ENEMY As PictureBox
    Friend WithEvents bird1ENEMY As PictureBox
    Friend WithEvents PictureBox6WALL As PictureBox
    Friend WithEvents PictureBox5WALL As PictureBox
    Friend WithEvents WALL As PictureBox
    Friend WithEvents PictureBox3WALL As PictureBox
    Friend WithEvents asteroid1WALL As PictureBox
    Friend WithEvents asteroidWALL As PictureBox
    Friend WithEvents asteroid3WALL As PictureBox
    Friend WithEvents CraneBOSS As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PaperFIRE As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Timer6 As Timer
    Friend WithEvents Timer8 As Timer
    Friend WithEvents BULLET As PictureBox
    Friend WithEvents Bird3ENEMY As PictureBox
End Class
