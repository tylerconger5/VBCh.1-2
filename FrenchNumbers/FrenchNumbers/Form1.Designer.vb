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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnone = New System.Windows.Forms.Button()
        Me.btntwo = New System.Windows.Forms.Button()
        Me.ntnthree = New System.Windows.Forms.Button()
        Me.btnfour = New System.Windows.Forms.Button()
        Me.btnfive = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(184, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Do you know the French words for the numbers " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 through 5? " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click the buttons b" & _
    "elow to see them."
        '
        'btnone
        '
        Me.btnone.Location = New System.Drawing.Point(21, 115)
        Me.btnone.Name = "btnone"
        Me.btnone.Size = New System.Drawing.Size(75, 23)
        Me.btnone.TabIndex = 1
        Me.btnone.Text = "1"
        Me.btnone.UseVisualStyleBackColor = True
        '
        'btntwo
        '
        Me.btntwo.Location = New System.Drawing.Point(140, 115)
        Me.btntwo.Name = "btntwo"
        Me.btntwo.Size = New System.Drawing.Size(75, 23)
        Me.btntwo.TabIndex = 2
        Me.btntwo.Text = "2"
        Me.btntwo.UseVisualStyleBackColor = True
        '
        'ntnthree
        '
        Me.ntnthree.Location = New System.Drawing.Point(256, 115)
        Me.ntnthree.Name = "ntnthree"
        Me.ntnthree.Size = New System.Drawing.Size(75, 23)
        Me.ntnthree.TabIndex = 3
        Me.ntnthree.Text = "3"
        Me.ntnthree.UseVisualStyleBackColor = True
        '
        'btnfour
        '
        Me.btnfour.Location = New System.Drawing.Point(357, 115)
        Me.btnfour.Name = "btnfour"
        Me.btnfour.Size = New System.Drawing.Size(75, 23)
        Me.btnfour.TabIndex = 4
        Me.btnfour.Text = "4"
        Me.btnfour.UseVisualStyleBackColor = True
        '
        'btnfive
        '
        Me.btnfive.Location = New System.Drawing.Point(452, 115)
        Me.btnfive.Name = "btnfive"
        Me.btnfive.Size = New System.Drawing.Size(75, 23)
        Me.btnfive.TabIndex = 5
        Me.btnfive.Text = "5"
        Me.btnfive.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(256, 185)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnfive)
        Me.Controls.Add(Me.btnfour)
        Me.Controls.Add(Me.ntnthree)
        Me.Controls.Add(Me.btntwo)
        Me.Controls.Add(Me.btnone)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnone As System.Windows.Forms.Button
    Friend WithEvents btntwo As System.Windows.Forms.Button
    Friend WithEvents ntnthree As System.Windows.Forms.Button
    Friend WithEvents btnfour As System.Windows.Forms.Button
    Friend WithEvents btnfive As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
