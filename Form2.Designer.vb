<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblHelpMenu = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHelpMenu
        '
        Me.lblHelpMenu.Location = New System.Drawing.Point(12, 9)
        Me.lblHelpMenu.Name = "lblHelpMenu"
        Me.lblHelpMenu.Size = New System.Drawing.Size(209, 225)
        Me.lblHelpMenu.TabIndex = 0
        Me.lblHelpMenu.Text = "Welcome to ""The BoolaidMan"", this is a classic platormer game "
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(233, 243)
        Me.Controls.Add(Me.lblHelpMenu)
        Me.Name = "Form2"
        Me.Text = "Help Menu "
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHelpMenu As System.Windows.Forms.Label
End Class
