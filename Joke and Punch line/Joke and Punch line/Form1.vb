Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        lbljoke.Text = "Why did the turkey refuse desert?"

    End Sub

    Private Sub btnPunchLine_Click(sender As Object, e As EventArgs) Handles btnPunchLine.Click
        lbljoke.Text = "Because he was stuffed :)"
    End Sub
End Class
