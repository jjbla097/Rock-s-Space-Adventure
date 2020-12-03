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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.Timer8 = New System.Windows.Forms.Timer(Me.components)
        Me.bird2ENEMY = New System.Windows.Forms.PictureBox()
        Me.bird1ENEMY = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6WALL = New System.Windows.Forms.PictureBox()
        Me.PictureBox5WALL = New System.Windows.Forms.PictureBox()
        Me.WALL = New System.Windows.Forms.PictureBox()
        Me.PictureBox3WALL = New System.Windows.Forms.PictureBox()
        Me.asteroid1WALL = New System.Windows.Forms.PictureBox()
        Me.asteroidWALL = New System.Windows.Forms.PictureBox()
        Me.asteroid3WALL = New System.Windows.Forms.PictureBox()
        Me.PaperFIRE = New System.Windows.Forms.PictureBox()
        Me.BULLET = New System.Windows.Forms.PictureBox()
        Me.CraneBOSS = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.bird2ENEMY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bird1ENEMY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6WALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5WALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3WALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.asteroid1WALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.asteroidWALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.asteroid3WALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaperFIRE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BULLET, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CraneBOSS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.Location = New System.Drawing.Point(729, 29)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(39, 13)
        Me.ScoreLabel.TabIndex = 28
        Me.ScoreLabel.Text = "Label1"
        '
        'Timer8
        '
        Me.Timer8.Enabled = True
        '
        'bird2ENEMY
        '
        Me.bird2ENEMY.Image = Global.GameV1.My.Resources.Resources.origamibird
        Me.bird2ENEMY.Location = New System.Drawing.Point(709, 329)
        Me.bird2ENEMY.Name = "bird2ENEMY"
        Me.bird2ENEMY.Size = New System.Drawing.Size(71, 65)
        Me.bird2ENEMY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bird2ENEMY.TabIndex = 27
        Me.bird2ENEMY.TabStop = False
        '
        'bird1ENEMY
        '
        Me.bird1ENEMY.Image = Global.GameV1.My.Resources.Resources.origamibird
        Me.bird1ENEMY.Location = New System.Drawing.Point(658, 106)
        Me.bird1ENEMY.Name = "bird1ENEMY"
        Me.bird1ENEMY.Size = New System.Drawing.Size(71, 65)
        Me.bird1ENEMY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bird1ENEMY.TabIndex = 26
        Me.bird1ENEMY.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox13.Image = Global.GameV1.My.Resources.Resources.asteroid2WALL
        Me.PictureBox13.Location = New System.Drawing.Point(-91, 652)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(290, 30)
        Me.PictureBox13.TabIndex = 25
        Me.PictureBox13.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox12.Image = Global.GameV1.My.Resources.Resources.asteroid2WALL
        Me.PictureBox12.Location = New System.Drawing.Point(-51, 624)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(290, 30)
        Me.PictureBox12.TabIndex = 24
        Me.PictureBox12.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox11.Image = Global.GameV1.My.Resources.Resources.asteroid2WALL
        Me.PictureBox11.Location = New System.Drawing.Point(-51, 599)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(290, 30)
        Me.PictureBox11.TabIndex = 23
        Me.PictureBox11.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.Image = Global.GameV1.My.Resources.Resources.asteroid2WALL
        Me.PictureBox10.Location = New System.Drawing.Point(-91, 575)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(290, 30)
        Me.PictureBox10.TabIndex = 22
        Me.PictureBox10.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.Image = Global.GameV1.My.Resources.Resources.asteroid2WALL
        Me.PictureBox9.Location = New System.Drawing.Point(-104, 553)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(999, 30)
        Me.PictureBox9.TabIndex = 21
        Me.PictureBox9.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = Global.GameV1.My.Resources.Resources.asteroid2WALL
        Me.PictureBox7.Location = New System.Drawing.Point(-114, 529)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(999, 30)
        Me.PictureBox7.TabIndex = 20
        Me.PictureBox7.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.GameV1.My.Resources.Resources.asteroid2WALL
        Me.PictureBox3.Location = New System.Drawing.Point(-162, 505)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(999, 30)
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'PictureBox6WALL
        '
        Me.PictureBox6WALL.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6WALL.Image = Global.GameV1.My.Resources.Resources.asteroid2WALL
        Me.PictureBox6WALL.Location = New System.Drawing.Point(-12, -17)
        Me.PictureBox6WALL.Name = "PictureBox6WALL"
        Me.PictureBox6WALL.Size = New System.Drawing.Size(818, 22)
        Me.PictureBox6WALL.TabIndex = 18
        Me.PictureBox6WALL.TabStop = False
        '
        'PictureBox5WALL
        '
        Me.PictureBox5WALL.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5WALL.Image = Global.GameV1.My.Resources.Resources.asteroid2WALL
        Me.PictureBox5WALL.Location = New System.Drawing.Point(-138, 477)
        Me.PictureBox5WALL.Name = "PictureBox5WALL"
        Me.PictureBox5WALL.Size = New System.Drawing.Size(999, 30)
        Me.PictureBox5WALL.TabIndex = 17
        Me.PictureBox5WALL.TabStop = False
        '
        'WALL
        '
        Me.WALL.BackColor = System.Drawing.Color.Transparent
        Me.WALL.Image = Global.GameV1.My.Resources.Resources.asteroid2WALL
        Me.WALL.Location = New System.Drawing.Point(786, -10)
        Me.WALL.Name = "WALL"
        Me.WALL.Size = New System.Drawing.Size(10, 517)
        Me.WALL.TabIndex = 16
        Me.WALL.TabStop = False
        '
        'PictureBox3WALL
        '
        Me.PictureBox3WALL.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3WALL.Image = Global.GameV1.My.Resources.Resources.asteroid2WALL
        Me.PictureBox3WALL.Location = New System.Drawing.Point(-3, -10)
        Me.PictureBox3WALL.Name = "PictureBox3WALL"
        Me.PictureBox3WALL.Size = New System.Drawing.Size(10, 517)
        Me.PictureBox3WALL.TabIndex = 15
        Me.PictureBox3WALL.TabStop = False
        '
        'asteroid1WALL
        '
        Me.asteroid1WALL.BackColor = System.Drawing.Color.Transparent
        Me.asteroid1WALL.Image = Global.GameV1.My.Resources.Resources.asterpod3WALL
        Me.asteroid1WALL.Location = New System.Drawing.Point(-114, 389)
        Me.asteroid1WALL.Name = "asteroid1WALL"
        Me.asteroid1WALL.Size = New System.Drawing.Size(301, 293)
        Me.asteroid1WALL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.asteroid1WALL.TabIndex = 14
        Me.asteroid1WALL.TabStop = False
        '
        'asteroidWALL
        '
        Me.asteroidWALL.BackColor = System.Drawing.Color.Transparent
        Me.asteroidWALL.Image = Global.GameV1.My.Resources.Resources.asteroid2WALL
        Me.asteroidWALL.Location = New System.Drawing.Point(377, 353)
        Me.asteroidWALL.Name = "asteroidWALL"
        Me.asteroidWALL.Size = New System.Drawing.Size(136, 121)
        Me.asteroidWALL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.asteroidWALL.TabIndex = 13
        Me.asteroidWALL.TabStop = False
        '
        'asteroid3WALL
        '
        Me.asteroid3WALL.BackColor = System.Drawing.Color.Transparent
        Me.asteroid3WALL.Image = Global.GameV1.My.Resources.Resources.asteroidWALL
        Me.asteroid3WALL.Location = New System.Drawing.Point(240, -28)
        Me.asteroid3WALL.Name = "asteroid3WALL"
        Me.asteroid3WALL.Size = New System.Drawing.Size(146, 200)
        Me.asteroid3WALL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.asteroid3WALL.TabIndex = 12
        Me.asteroid3WALL.TabStop = False
        '
        'PaperFIRE
        '
        Me.PaperFIRE.BackColor = System.Drawing.Color.Transparent
        Me.PaperFIRE.Image = Global.GameV1.My.Resources.Resources.paper
        Me.PaperFIRE.Location = New System.Drawing.Point(13, 12)
        Me.PaperFIRE.Name = "PaperFIRE"
        Me.PaperFIRE.Size = New System.Drawing.Size(34, 37)
        Me.PaperFIRE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PaperFIRE.TabIndex = 11
        Me.PaperFIRE.TabStop = False
        Me.PaperFIRE.Visible = False
        '
        'BULLET
        '
        Me.BULLET.BackColor = System.Drawing.Color.Transparent
        Me.BULLET.Image = Global.GameV1.My.Resources.Resources._1200px_Small_pair_of_blue_scissors
        Me.BULLET.Location = New System.Drawing.Point(84, 416)
        Me.BULLET.Name = "BULLET"
        Me.BULLET.Size = New System.Drawing.Size(48, 30)
        Me.BULLET.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BULLET.TabIndex = 2
        Me.BULLET.TabStop = False
        '
        'CraneBOSS
        '
        Me.CraneBOSS.BackColor = System.Drawing.Color.Transparent
        Me.CraneBOSS.Image = Global.GameV1.My.Resources.Resources._96d59de576536789086c1e0b82fc91a7_origami_paper_crane_by_vexels
        Me.CraneBOSS.Location = New System.Drawing.Point(610, 177)
        Me.CraneBOSS.Name = "CraneBOSS"
        Me.CraneBOSS.Size = New System.Drawing.Size(170, 146)
        Me.CraneBOSS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CraneBOSS.TabIndex = 1
        Me.CraneBOSS.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.GameV1.My.Resources.Resources.PNGPIX_COM_The_Rock_PNG_Transparent_Image_500x463__2_
        Me.PictureBox1.Location = New System.Drawing.Point(81, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(791, 483)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.bird2ENEMY)
        Me.Controls.Add(Me.bird1ENEMY)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox6WALL)
        Me.Controls.Add(Me.PictureBox5WALL)
        Me.Controls.Add(Me.WALL)
        Me.Controls.Add(Me.PictureBox3WALL)
        Me.Controls.Add(Me.asteroid1WALL)
        Me.Controls.Add(Me.asteroidWALL)
        Me.Controls.Add(Me.asteroid3WALL)
        Me.Controls.Add(Me.PaperFIRE)
        Me.Controls.Add(Me.BULLET)
        Me.Controls.Add(Me.CraneBOSS)
        Me.Controls.Add(Me.PictureBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.Name = "Form1"
        Me.Text = "The Rock's Space Adventure"
        CType(Me.bird2ENEMY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bird1ENEMY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6WALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5WALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3WALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.asteroid1WALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.asteroidWALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.asteroid3WALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaperFIRE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BULLET, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CraneBOSS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CraneBOSS As PictureBox
    Friend WithEvents BULLET As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PaperFIRE As PictureBox
    Friend WithEvents asteroid3WALL As PictureBox
    Friend WithEvents asteroidWALL As PictureBox
    Friend WithEvents asteroid1WALL As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox3WALL As PictureBox
    Friend WithEvents WALL As PictureBox
    Friend WithEvents PictureBox5WALL As PictureBox
    Friend WithEvents PictureBox6WALL As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents bird1ENEMY As PictureBox
    Friend WithEvents bird2ENEMY As PictureBox
    Friend WithEvents Timer6 As Timer
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents Timer8 As Timer
End Class
