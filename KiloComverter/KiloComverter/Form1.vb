Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnfeet.Click
        lblMessage.Text = "1 Kilo = 3,281 feet"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnyards.Click
        lblMessage.Text = "1 Kilo =1,093.6 yards"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnmiles.Click
        lblMessage.Text = "1 Kilo =0.6214 miles"
    End Sub

    Private Sub btninches_Click(sender As Object, e As EventArgs) Handles btninches.Click
        lblMessage.Text = "1 Kilo = 39,370"

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class
