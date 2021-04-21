<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Floor1
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
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.picBoolaidMan = New System.Windows.Forms.PictureBox()
        Me.picAir = New System.Windows.Forms.PictureBox()
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrStartGame = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.picWall1 = New System.Windows.Forms.PictureBox()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.picWall3 = New System.Windows.Forms.PictureBox()
        Me.picWall2 = New System.Windows.Forms.PictureBox()
        Me.tmrDown = New System.Windows.Forms.Timer(Me.components)
        Me.tmrShot = New System.Windows.Forms.Timer(Me.components)
        Me.picShot1 = New System.Windows.Forms.PictureBox()
        Me.tmrMovement = New System.Windows.Forms.Timer(Me.components)
        Me.picShot2 = New System.Windows.Forms.PictureBox()
        Me.picShot3 = New System.Windows.Forms.PictureBox()
        Me.picShot4 = New System.Windows.Forms.PictureBox()
        Me.picShot5 = New System.Windows.Forms.PictureBox()
        CType(Me.picBoolaidMan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWall1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWall3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShot3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShot4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShot5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrRight
        '
        Me.tmrRight.Interval = 1
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 1
        '
        'picBoolaidMan
        '
        Me.picBoolaidMan.BackColor = System.Drawing.Color.Transparent
        Me.picBoolaidMan.Image = Global.Final_Project___Computer_Science_10___Hiren_Patel.My.Resources.Resources.Koolaid_man_21
        Me.picBoolaidMan.Location = New System.Drawing.Point(12, 356)
        Me.picBoolaidMan.Name = "picBoolaidMan"
        Me.picBoolaidMan.Size = New System.Drawing.Size(92, 88)
        Me.picBoolaidMan.TabIndex = 3
        Me.picBoolaidMan.TabStop = False
        Me.picBoolaidMan.Tag = ""
        '
        'picAir
        '
        Me.picAir.BackColor = System.Drawing.Color.Transparent
        Me.picAir.Location = New System.Drawing.Point(-15, -207)
        Me.picAir.Name = "picAir"
        Me.picAir.Size = New System.Drawing.Size(890, 592)
        Me.picAir.TabIndex = 2
        Me.picAir.TabStop = False
        Me.picAir.Visible = False
        '
        'picGround
        '
        Me.picGround.BackColor = System.Drawing.Color.Transparent
        Me.picGround.Location = New System.Drawing.Point(-61, 455)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(1542, 46)
        Me.picGround.TabIndex = 0
        Me.picGround.TabStop = False
        Me.picGround.Tag = "bound"
        Me.picGround.Visible = False
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 1
        '
        'tmrStartGame
        '
        Me.tmrStartGame.Interval = 1
        '
        'tmrGravity
        '
        Me.tmrGravity.Interval = 1
        '
        'picWall1
        '
        Me.picWall1.BackColor = System.Drawing.Color.Transparent
        Me.picWall1.Image = Global.Final_Project___Computer_Science_10___Hiren_Patel.My.Resources.Resources.grasstop2
        Me.picWall1.Location = New System.Drawing.Point(200, 377)
        Me.picWall1.Name = "picWall1"
        Me.picWall1.Size = New System.Drawing.Size(110, 21)
        Me.picWall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWall1.TabIndex = 4
        Me.picWall1.TabStop = False
        Me.picWall1.Tag = "bound"
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(572, 19)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(140, 27)
        Me.lblScore.TabIndex = 5
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picWall3
        '
        Me.picWall3.BackColor = System.Drawing.Color.Transparent
        Me.picWall3.Image = Global.Final_Project___Computer_Science_10___Hiren_Patel.My.Resources.Resources.grasstop2
        Me.picWall3.Location = New System.Drawing.Point(637, 312)
        Me.picWall3.Name = "picWall3"
        Me.picWall3.Size = New System.Drawing.Size(110, 21)
        Me.picWall3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWall3.TabIndex = 6
        Me.picWall3.TabStop = False
        Me.picWall3.Tag = "bound"
        '
        'picWall2
        '
        Me.picWall2.BackColor = System.Drawing.Color.Transparent
        Me.picWall2.Image = Global.Final_Project___Computer_Science_10___Hiren_Patel.My.Resources.Resources.grasstop2
        Me.picWall2.Location = New System.Drawing.Point(376, 356)
        Me.picWall2.Name = "picWall2"
        Me.picWall2.Size = New System.Drawing.Size(230, 21)
        Me.picWall2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWall2.TabIndex = 7
        Me.picWall2.TabStop = False
        Me.picWall2.Tag = "bound"
        '
        'tmrDown
        '
        Me.tmrDown.Interval = 500
        '
        'tmrShot
        '
        '
        'picShot1
        '
        Me.picShot1.BackColor = System.Drawing.Color.Maroon
        Me.picShot1.Location = New System.Drawing.Point(110, 401)
        Me.picShot1.Name = "picShot1"
        Me.picShot1.Size = New System.Drawing.Size(18, 10)
        Me.picShot1.TabIndex = 8
        Me.picShot1.TabStop = False
        Me.picShot1.Tag = "Shot"
        Me.picShot1.Visible = False
        '
        'tmrMovement
        '
        '
        'picShot2
        '
        Me.picShot2.BackColor = System.Drawing.Color.Maroon
        Me.picShot2.Location = New System.Drawing.Point(134, 401)
        Me.picShot2.Name = "picShot2"
        Me.picShot2.Size = New System.Drawing.Size(18, 10)
        Me.picShot2.TabIndex = 9
        Me.picShot2.TabStop = False
        Me.picShot2.Tag = "Shot"
        Me.picShot2.Visible = False
        '
        'picShot3
        '
        Me.picShot3.BackColor = System.Drawing.Color.Maroon
        Me.picShot3.Location = New System.Drawing.Point(158, 401)
        Me.picShot3.Name = "picShot3"
        Me.picShot3.Size = New System.Drawing.Size(18, 10)
        Me.picShot3.TabIndex = 10
        Me.picShot3.TabStop = False
        Me.picShot3.Tag = "Shot"
        Me.picShot3.Visible = False
        '
        'picShot4
        '
        Me.picShot4.BackColor = System.Drawing.Color.Maroon
        Me.picShot4.Location = New System.Drawing.Point(182, 401)
        Me.picShot4.Name = "picShot4"
        Me.picShot4.Size = New System.Drawing.Size(18, 10)
        Me.picShot4.TabIndex = 11
        Me.picShot4.TabStop = False
        Me.picShot4.Tag = "Shot"
        Me.picShot4.Visible = False
        '
        'picShot5
        '
        Me.picShot5.BackColor = System.Drawing.Color.Maroon
        Me.picShot5.Location = New System.Drawing.Point(206, 401)
        Me.picShot5.Name = "picShot5"
        Me.picShot5.Size = New System.Drawing.Size(18, 10)
        Me.picShot5.TabIndex = 12
        Me.picShot5.TabStop = False
        Me.picShot5.Tag = "Shot"
        Me.picShot5.Visible = False
        '
        'Floor1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Final_Project___Computer_Science_10___Hiren_Patel.My.Resources.Resources.background0
        Me.ClientSize = New System.Drawing.Size(862, 477)
        Me.Controls.Add(Me.picShot5)
        Me.Controls.Add(Me.picShot4)
        Me.Controls.Add(Me.picShot3)
        Me.Controls.Add(Me.picShot2)
        Me.Controls.Add(Me.picShot1)
        Me.Controls.Add(Me.picWall2)
        Me.Controls.Add(Me.picWall3)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.picWall1)
        Me.Controls.Add(Me.picBoolaidMan)
        Me.Controls.Add(Me.picAir)
        Me.Controls.Add(Me.picGround)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "Floor1"
        Me.Text = "The Boolaid Man"
        CType(Me.picBoolaidMan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWall1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWall3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShot3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShot4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShot5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picGround As System.Windows.Forms.PictureBox
    Friend WithEvents picAir As System.Windows.Forms.PictureBox
    Friend WithEvents tmrRight As System.Windows.Forms.Timer
    Friend WithEvents tmrUp As System.Windows.Forms.Timer
    Friend WithEvents picBoolaidMan As System.Windows.Forms.PictureBox
    Friend WithEvents tmrLeft As System.Windows.Forms.Timer
    Friend WithEvents tmrStartGame As System.Windows.Forms.Timer
    Friend WithEvents tmrGravity As System.Windows.Forms.Timer
    Friend WithEvents picWall1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents picWall3 As System.Windows.Forms.PictureBox
    Friend WithEvents picWall2 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrDown As System.Windows.Forms.Timer
    Friend WithEvents tmrShot As System.Windows.Forms.Timer
    Friend WithEvents picShot1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrMovement As System.Windows.Forms.Timer
    Friend WithEvents picShot2 As System.Windows.Forms.PictureBox
    Friend WithEvents picShot3 As System.Windows.Forms.PictureBox
    Friend WithEvents picShot4 As System.Windows.Forms.PictureBox
    Friend WithEvents picShot5 As System.Windows.Forms.PictureBox

End Class
