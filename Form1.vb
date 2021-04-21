Public Class Floor1
    'Hiren Patel
    'Final Project 

    Dim intMoveSpeed As Integer = 8
    Dim blnJump As Boolean
    Dim blnMoveLeft As Boolean
    Dim blnMoveRight As Boolean
    Dim blnStandingStill As Boolean
    Dim JumpCount As Byte
    Dim picFloor(1) As PictureBox
    Dim picWall(1) As PictureBox
    Dim blnMoveUp As Boolean
    Dim blnBottom As Boolean
    Dim intCooldown As Integer
    Dim intGroundLayer As Integer
    Dim intShotSpeed As Integer
    Dim intVerticalVelocity As Integer = 0
    Dim intGravity As Integer = 2
    Dim Shots() As PictureBox = (picShot1, picShot2, picShot3, picShot4, picShot5) 


    
    'Dim blnBottom As Boolean
    'Dim intCooldown As Integer
    'Dim intGroundLayer As Integer
    'Dim intShotSpeed As Integer
    'Dim intEnemySpeed As Integer
    'Dim intNumOfEnemies As Integer = 10

    'Dim intRight(intNumOfEnemies) As Boolean
    'Dim Invaders(intNumOfEnemies) As PictureBox
    'Dim X As Integer            'RENAME______________________________




    'Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    '    Floor(1) = picFloor



    'End Sub



    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'Select Case e.KeyCode
        '    Case Keys.Right
        '        tmrRight.Start()
        '    Case Keys.Left
        '        tmrLeft.Start()
        '    Case Keys.Up
        '        'If blnJump = True Then
        '        '    tmrUp.Enabled = True
        '        '    'blnJump = False
        '        tmrUp.Start()
        '        'End If
        'End Select

       Dim Shots() As PictureBox = (picShot1, picShot2, picShot3, picShot4, picShot5) 

        Static intCount As Integer


        Select Case e.KeyCode
            Case Keys.Space
                intCount += 1
                tmrShot.Enabled = True

                If intCount = 5 Then
                    intCount = 0
                End If
        End Select

        If e.KeyValue = Keys.Right Then
            blnMoveRight = True
            blnMoveLeft = False
        End If

        If e.KeyValue = Keys.Left Then
            blnMoveRight = False
            blnMoveLeft = True
        End If










        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Start()
            Case Keys.Left
                tmrLeft.Start()
            Case Keys.Up
                blnJump = True
                tmrGravity.Enabled = True
                intVerticalVelocity = -5
                blnJump = False
            Case Keys.F2
                'Show help menu
        End Select

        If blnJump = False Then
            blnStandingStill = True
            'If blnStandingStill = True Then
            '    picBoolaidMan.Left = 0
            'End If
        End If
        If blnStandingStill Then
            If e.KeyCode = Keys.Up Then
                blnJump = True
                blnStandingStill = False
            End If
        End If

        If e.KeyCode = Keys.Left Then
            blnMoveLeft = True
        End If


        'If e.KeyCode = Keys.Right Then
        '    blnMoveRight = True
        'End If

        'If blnMoveRight = True Then
        '    picBoolaidMan.Left += intMoveSpeed
        'Else
        '    picBoolaidMan.Left += 0
        'End If
        'If picBoolaidMan.Right >= Me.ClientRectangle.Right Then
        '    blnMoveRight = False
        'Else
        '    blnMoveRight = True
        'End If

    End Sub


    Private Sub tmrRight_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrRight.Tick

        If blnMoveRight = True Then
            picBoolaidMan.Left += intMoveSpeed
        Else
            picBoolaidMan.Left += 0
        End If
        If picBoolaidMan.Right >= Me.ClientRectangle.Right Then
            blnMoveRight = False
        Else
            blnMoveRight = True
        End If

    End Sub
    'Private Sub tmrRight_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrRight.Tick

    '    If blnMoveRight = True Then
    '        picBoolaidMan.Left += intMoveSpeed
    '    Else
    '        picBoolaidMan.Left += 0
    '    End If
    '    If picBoolaidMan.Right >= Me.ClientRectangle.Right Then
    '        blnMoveRight = False
    '    Else
    '        blnMoveRight = True
    '    End If

    'End Sub

    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Stop()
            Case Keys.Left
                tmrLeft.Stop()
            Case Keys.Up
                tmrUp.Stop()
                blnJump = False
        End Select

        'If e.KeyCode = Keys.Up Then
        '    blnJump = False
        'End If

        'If e.KeyCode = Keys.Left Then
        '    blnMoveLeft = False
        'End If

        'If e.KeyCode = Keys.Right Then
        '    blnMoveRight = False
        'End If

        'Select Case e.KeyCode
        '    Case Keys.Right
        '        tmrRight.Stop()
        '    Case Keys.Left
        '        tmrLeft.Stop()
        '    Case Keys.Up
        '        tmrUp.Stop()
        '        blnJump = False
        'End Select
    End Sub

    '    Private Sub tmrLeft_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrLeft.Tick

    '        If blnMoveLeft = True Then
    '            picBoolaidMan.Left -= intMoveSpeed
    '        Else
    '            picBoolaidMan.Left -= 0
    '        End If
    '        If picBoolaidMan.Left <= Me.ClientRectangle.Left Then
    '            blnMoveLeft = False
    '        Else
    '            blnMoveLeft = True
    '        End If

    '    End Sub
    'End Class

    Private Sub tmrLeft_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrLeft.Tick

        If blnMoveLeft = True Then
            picBoolaidMan.Left -= intMoveSpeed
        Else
            picBoolaidMan.Left -= 0
        End If
        If picBoolaidMan.Left <= Me.ClientRectangle.Left Then
            blnMoveLeft = False
        Else
            blnMoveLeft = True
        End If

    End Sub

    'Private Sub tmrUp_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrUp.Tick

    '    tmrDown.Start()

    '    If intCooldown = 3 Then
    '        picBoolaidMan.Top += 40
    '    End If
    '    If blnMoveUp = True Then
    '        picBoolaidMan.Top -= intMoveSpeed
    '    Else
    '        picBoolaidMan.Top -= 0
    '    End If
    '    If picBoolaidMan.Top <= Me.ClientRectangle.Top Then
    '        blnMoveUp = False
    '    Else
    '        blnMoveUp = True
    '    End If
    'End Sub

    'Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    intGroundLayer = Me.Height + 32
    '    tmrStartGame.Start()
    'End Sub


    'Private Sub tmrStartGame_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrStartGame.Tick

    '    picBoolaidMan.Top += 3
    '    For X = 1 To 1
    '        If picBoolaidMan.Bounds.IntersectsWith(picWall(X).Bounds) And picWall(X).Visible = True Then
    '            blnStandingStill = True
    '            picBoolaidMan.Top -= 3

    '        End If

    '        If picBoolaidMan.Bounds.IntersectsWith(picWall(X).Bounds) And picWall(X).Visible = True Then
    '            blnStandingStill = True
    '            picBoolaidMan.Top -= 3
    '        End If

    '    Next X

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        intGroundLayer = Me.Height + 32
        tmrStartGame.Start()
    End Sub



    Private Sub tmrStartGame_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrStartGame.Tick
        If picBoolaidMan.Bounds.IntersectsWith(picAir.Bounds) Then
            If blnJump = False Then
                tmrGravity.Start()
            End If
        ElseIf picBoolaidMan.Bounds.IntersectsWith(picGround.Bounds) Then
            tmrGravity.Stop()
        End If

        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If picBoolaidMan.Bounds.IntersectsWith(b.Bounds) Then
                        tmrGravity.Stop()
                    End If
                End If
            End If
        Next

        'If picBoolaidMan.Bounds.IntersectsWith(picAir.Bounds) Then
        '    If blnJump = False Then
        '        tmrGravity.Start()
        '    End If
        'ElseIf picBoolaidMan.Bounds.IntersectsWith(picGround.Bounds) Then
        '    tmrGravity.Stop()
        'End If


        ' '' ''If picBoolaidMan.Location.Y <= intGroundLayer Then
        ' '' ''    tmrGravity.Stop()
        ' '' ''End If

        'For Each b As Control In Me.Controls
        '    If TypeOf b Is PictureBox Then
        '        If b.Tag = "bound" Then
        '            If picBoolaidMan.Bounds.IntersectsWith(b.Bounds) Then
        '                tmrGravity.Stop()
        '            End If
        '        End If
        '    End If
        'Next

        'use rnd fuction to spawn enemies and keep the three same platforms on the screen at all times, the charecter should be contained within a certain area until the next level.

    End Sub




    '    Private Sub tmrGravity_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrGravity.Tick
    '        picBoolaidMan.Top += 20

    '        If picBoolaidMan.Location.Y <= intGroundLayer Then
    '            tmrGravity.Stop()
    '        End If
    '    End Sub

    '    Private Sub tmrDown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDown.Tick
    '        picBoolaidMan.Top += 8
    '        If picBoolaidMan.Bounds.IntersectsWith(picGround.Bounds) Then
    '            tmrDown.Enabled = False
    '            blnJump = True
    '        End If
    '        'make it so that when the accumulator reaches 3 the charecter is forced down to directly below the charecter position in the air
    '        'NEWCODEHERE!
    '    End Sub

    '    Private Sub tmrShot_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrShot.Tick
    '        MoveEnemy()
    '        FireShot()


    '    End Sub


    Private Sub LoadSettings()
        intShotSpeed = 10

        picShot1.Visible = False

    End Sub


    Private Sub tmrMovement_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrMovement.Tick

        If blnJump = True Then
            picBoolaidMan.Top -= 6
            JumpCount += 1
            If JumpCount >= 20 Then
                JumpCount = 0
                blnJump = False
            End If
        End If

        If blnMoveLeft = True Then
            picBoolaidMan.Left -= 1

            If picBoolaidMan.Left <= 0 Then
                picBoolaidMan.Left = 0
            End If

            For x = 1 To 1
                If picBoolaidMan.Bounds.IntersectsWith(picWall(x).Bounds) Then
                    picBoolaidMan.Left += 1
                End If
            Next x
        End If

        If blnMoveRight = True Then
            picBoolaidMan.Left += 1

            If picBoolaidMan.Left >= 1149 Then
                picBoolaidMan.Left = 1149
            End If

            For x = 1 To 1
                If picBoolaidMan.Bounds.IntersectsWith(picWall(x).Bounds) Then
                    picBoolaidMan.Left -= 1
                End If

            Next x

        End If

    End Sub

    'Private Sub tmrGravity_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrGravity.Tick

    'If blnJump = True Then
    '    picBoolaidMan.Top += 20

    'Do Until blnJump = False
    '    If intVerticalVelocity <= 2 Then
    '        intVerticalVelocity = intVerticalVelocity - 2
    '        If intVerticalVelocity = 1 Then
    '            blnJump = False
    '        End If
    '    End If
    'Loop

    'If picBoolaidMan.Location.Y <= intGroundLayer Then
    '    tmrGravity.Stop()
    'End If

    'End If
    'End Sub

    Private Sub tmrDown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDown.Tick
        'picBoolaidMan.Top += 6
        'If picBoolaidMan.Bounds.IntersectsWith(picGround.Bounds) Then
        '    tmrDown.Enabled = False
        '    blnJump = True
        'End If
        'make it so that when the accumulator reaches 3 the charecter is forced down to directly below the charecter position in the air
        'NEWCODEHERE!
    End Sub

    Private Sub tmrShot_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrShot.Tick

            Dim Shots() As PictureBox = (picShot1, picShot2, picShot3, picShot4, picShot5) 

        For x = 0 To picShots.Length - 1
            picShots(x).Top -= 3

        Next x

    End Sub
End Class



''Add side and bottom collision detection
''https://www.youtube.com/watch?v=0mwL8bq3YnI
