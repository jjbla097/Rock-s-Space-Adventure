Public Class Form4
    Dim hp As Integer = 5
    Dim life As Integer = 1
    Dim r As New Random
    Sub RandMove(p As PictureBox)
        Dim x As Integer
        Dim y As Integer
        y = r.Next(-6, 6)
        MoveTo(p, x, y)
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                MoveTo(PictureBox1, 0, -5)
            Case Keys.Down
                MoveTo(PictureBox1, 0, 5)
            Case Keys.Left
                MoveTo(PictureBox1, -5, 0)
            Case Keys.Right
                MoveTo(PictureBox1, 5, 0)
            Case Keys.Space And life = 1
                BULLET.Visible = True
                BULLET.Location = PictureBox1.Location
                MoveTo(BULLET, 100, 70)
                Timer2.Enabled = True
            Case Keys.R
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
                Me.Refresh()
        End Select
    End Sub
    Sub Follow(p As PictureBox)
        Static headstart As Integer
        Static c As New Collection
        c.Add(PictureBox1.Location)
        headstart = headstart + 1
        If headstart > 10 Then
            p.Location = c.Item(1)
            c.Remove(1)
        End If
    End Sub
    Public Sub Chase(p As PictureBox)
        Dim x, y As Integer
        If p.Location.X > PictureBox1.Location.X Then
            x = -4
        Else
            x = 4
        End If
        MoveTo(p, x, 0)
        If p.Location.Y < PictureBox1.Location.Y Then
            y = 4
        Else
            y = -4
        End If
        MoveTo(p, x, y)
    End Sub

    Function Collision(p As PictureBox, t As String, Optional ByRef other As Object = vbNull)
        Dim col As Boolean

        For Each c In Controls
            Dim obj As Control
            obj = c
            If obj.Visible AndAlso p.Bounds.IntersectsWith(obj.Bounds) And obj.Name.ToUpper.Contains(t.ToUpper) Then
                col = True
                other = obj
            End If
        Next
        Return col
    End Function
    'Return true or false if moving to the new location is clear of objects ending with t
    Function IsClear(p As PictureBox, distx As Integer, disty As Integer, t As String) As Boolean
        Dim b As Boolean

        p.Location += New Point(distx, disty)
        b = Not Collision(p, t)
        p.Location -= New Point(distx, disty)
        Return b
    End Function
    'Moves and object (won't move onto objects containing  "wall" and shows green if object ends with "win"
    Sub MoveTo(p As PictureBox, distx As Integer, disty As Integer)
        If IsClear(p, distx, disty, "WALL") Then
            p.Location += New Point(distx, disty)
        End If
        Dim other As Object = Nothing
        If p.Name = "PaperFIRE" And Collision(p, "PictureBox1", other) Then
            p.Location += New Point(distx, disty)
            Me.BackColor = Color.Red
            other.visible = False
            life = 0
            Timer3.Enabled = False
            Timer4.Enabled = False
            Dim f As New Form2
            f.ShowDialog()
            Me.Visible = True
            Return
        End If
        If p.Name = "bird1ENEMY" And Collision(p, "PictureBox1", other) Or
            p.Name = "bird2ENEMY" And Collision(p, "PictureBox1", other) Or
            p.Name = "bird3ENEMY" And Collision(p, "PictureBox1", other) Then
            p.Location += New Point(distx, disty)
            Me.BackColor = Color.Red
            other.visible = False
            life = 0
            Timer3.Enabled = False
            Timer4.Enabled = False
            Dim f As New Form2
            f.ShowDialog()
            Me.Visible = True
            Return
        End If
        If p.Name = "WALL" And Collision(p, "BULLET", other) Then
            other.Visible = False
            MoveTo(other, 10000, 10000)
        End If
        If p.Name = "BULLET" And Collision(p, "PaperFIRE", other) Then
            other.visible = False
            MoveTo(other, 10000, 10000)
            BULLET.Visible = False
            MoveTo(BULLET, 10000, 10000)
        End If
        If p.Name = "BULLET" And Collision(p, "bird1ENEMY", other) Or
                p.Name = "BULLET" And Collision(p, "bird2ENEMY", other) Or
                p.Name = "BULLET" And Collision(p, "bird3ENEMY", other) Then
            other.visible = False
            MoveTo(other, 10000, 10000)
            BULLET.Visible = False
            MoveTo(BULLET, 10000, 10000)
        End If
        If p.Name = "BULLET" And Collision(p, "CraneBOSS", other) Then
            BULLET.Visible = False
            MoveTo(BULLET, 10000, 10000)
            hp = hp - 1
            If hp = 0 Then
                Me.BackColor = Color.Green
                other.visible = False
                PaperFIRE.Visible = False
                MoveTo(PaperFIRE, 10000, 10000)
                Timer3.Enabled = False
                Timer4.Enabled = False
                Dim f As New Form6
                f.ShowDialog()
                Me.Visible = True
            End If
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        MoveTo(BULLET, 15, 0)
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        PaperFIRE.Visible = True
        PaperFIRE.Location = CraneBOSS.Location
        MoveTo(PaperFIRE, -60, 60)
        Timer4.Enabled = True
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        MoveTo(PaperFIRE, -10, 0)
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Chase(bird1ENEMY)
        Chase(bird2ENEMY)
        Chase(Bird3ENEMY)
        RandMove(bird1ENEMY)
        RandMove(bird2ENEMY)
        RandMove(Bird3ENEMY)
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        ScoreLabel.Text = hp
    End Sub
End Class