<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.btnPunchLine = New System.Windows.Forms.Button()
        Me.lbljoke = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(38, 154)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(75, 23)
        Me.btnSetup.TabIndex = 1
        Me.btnSetup.Text = "Setup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'btnPunchLine
        '
        Me.btnPunchLine.Location = New System.Drawing.Point(184, 154)
        Me.btnPunchLine.Name = "btnPunchLine"
        Me.btnPunchLine.Size = New System.Drawing.Size(75, 23)
        Me.btnPunchLine.TabIndex = 2
        Me.btnPunchLine.Text = "Punch Line "
        Me.btnPunchLine.UseVisualStyleBackColor = True
        '
        'lbljoke
        '
        Me.lbljoke.AutoSize = True
        Me.lbljoke.Location = New System.Drawing.Point(60, 73)
        Me.lbljoke.Name = "lbljoke"
        Me.lbljoke.Size = New System.Drawing.Size(106, 13)
        Me.lbljoke.TabIndex = 3
        Me.lbljoke.Text = "Setup and Punchline"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lbljoke)
        Me.Controls.Add(Me.btnPunchLine)
        Me.Controls.Add(Me.btnSetup)
        Me.Name = "Form1"
        Me.Text = "Punchline"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSetup As System.Windows.Forms.Button
    Friend WithEvents btnPunchLine As System.Windows.Forms.Button
    Friend WithEvents lbljoke As System.Windows.Forms.Label

End Class
