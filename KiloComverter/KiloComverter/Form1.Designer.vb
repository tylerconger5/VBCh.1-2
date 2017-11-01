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
        Me.btninches = New System.Windows.Forms.Button()
        Me.btnfeet = New System.Windows.Forms.Button()
        Me.btnyards = New System.Windows.Forms.Button()
        Me.btnmiles = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btninches
        '
        Me.btninches.Location = New System.Drawing.Point(27, 89)
        Me.btninches.Name = "btninches"
        Me.btninches.Size = New System.Drawing.Size(75, 23)
        Me.btninches.TabIndex = 0
        Me.btninches.Text = "Inches"
        Me.btninches.UseVisualStyleBackColor = True
        '
        'btnfeet
        '
        Me.btnfeet.Location = New System.Drawing.Point(138, 89)
        Me.btnfeet.Name = "btnfeet"
        Me.btnfeet.Size = New System.Drawing.Size(75, 23)
        Me.btnfeet.TabIndex = 1
        Me.btnfeet.Text = "Feet"
        Me.btnfeet.UseVisualStyleBackColor = True
        '
        'btnyards
        '
        Me.btnyards.Location = New System.Drawing.Point(261, 89)
        Me.btnyards.Name = "btnyards"
        Me.btnyards.Size = New System.Drawing.Size(75, 23)
        Me.btnyards.TabIndex = 2
        Me.btnyards.Text = "Yards"
        Me.btnyards.UseVisualStyleBackColor = True
        '
        'btnmiles
        '
        Me.btnmiles.Location = New System.Drawing.Point(391, 89)
        Me.btnmiles.Name = "btnmiles"
        Me.btnmiles.Size = New System.Drawing.Size(75, 23)
        Me.btnmiles.TabIndex = 3
        Me.btnmiles.Text = "Miles "
        Me.btnmiles.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(210, 151)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 4
        Me.btnexit.Text = "Exit "
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(170, 22)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(144, 24)
        Me.lblMessage.TabIndex = 5
        Me.lblMessage.Text = "1 Kilometer =?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 200)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnmiles)
        Me.Controls.Add(Me.btnyards)
        Me.Controls.Add(Me.btnfeet)
        Me.Controls.Add(Me.btninches)
        Me.Name = "Form1"
        Me.Text = "Kilometer Converter "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btninches As System.Windows.Forms.Button
    Friend WithEvents btnfeet As System.Windows.Forms.Button
    Friend WithEvents btnyards As System.Windows.Forms.Button
    Friend WithEvents btnmiles As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label

End Class
