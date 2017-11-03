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
        Me.btnsinister = New System.Windows.Forms.Button()
        Me.btndexter = New System.Windows.Forms.Button()
        Me.btnmedium = New System.Windows.Forms.Button()
        Me.lblleft = New System.Windows.Forms.Label()
        Me.lblright = New System.Windows.Forms.Label()
        Me.lblcenter = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnsinister
        '
        Me.btnsinister.Location = New System.Drawing.Point(20, 158)
        Me.btnsinister.Name = "btnsinister"
        Me.btnsinister.Size = New System.Drawing.Size(75, 23)
        Me.btnsinister.TabIndex = 0
        Me.btnsinister.Text = "Sinister "
        Me.btnsinister.UseVisualStyleBackColor = True
        '
        'btndexter
        '
        Me.btndexter.Location = New System.Drawing.Point(110, 158)
        Me.btndexter.Name = "btndexter"
        Me.btndexter.Size = New System.Drawing.Size(75, 23)
        Me.btndexter.TabIndex = 1
        Me.btndexter.Text = "Dexter "
        Me.btndexter.UseVisualStyleBackColor = True
        '
        'btnmedium
        '
        Me.btnmedium.Location = New System.Drawing.Point(197, 158)
        Me.btnmedium.Name = "btnmedium"
        Me.btnmedium.Size = New System.Drawing.Size(75, 23)
        Me.btnmedium.TabIndex = 2
        Me.btnmedium.Text = "Medium "
        Me.btnmedium.UseVisualStyleBackColor = True
        '
        'lblleft
        '
        Me.lblleft.AutoSize = True
        Me.lblleft.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblleft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblleft.Location = New System.Drawing.Point(38, 102)
        Me.lblleft.Name = "lblleft"
        Me.lblleft.Size = New System.Drawing.Size(0, 18)
        Me.lblleft.TabIndex = 3
        '
        'lblright
        '
        Me.lblright.AutoSize = True
        Me.lblright.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblright.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblright.Location = New System.Drawing.Point(107, 102)
        Me.lblright.Name = "lblright"
        Me.lblright.Size = New System.Drawing.Size(0, 18)
        Me.lblright.TabIndex = 4
        '
        'lblcenter
        '
        Me.lblcenter.AutoSize = True
        Me.lblcenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcenter.Location = New System.Drawing.Point(177, 102)
        Me.lblcenter.Name = "lblcenter"
        Me.lblcenter.Size = New System.Drawing.Size(0, 18)
        Me.lblcenter.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblcenter)
        Me.Controls.Add(Me.lblright)
        Me.Controls.Add(Me.lblleft)
        Me.Controls.Add(Me.btnmedium)
        Me.Controls.Add(Me.btndexter)
        Me.Controls.Add(Me.btnsinister)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsinister As System.Windows.Forms.Button
    Friend WithEvents btndexter As System.Windows.Forms.Button
    Friend WithEvents btnmedium As System.Windows.Forms.Button
    Friend WithEvents lblleft As System.Windows.Forms.Label
    Friend WithEvents lblright As System.Windows.Forms.Label
    Friend WithEvents lblcenter As System.Windows.Forms.Label

End Class
