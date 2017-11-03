Public Class Form1

    Private Sub lblleft_Click(sender As Object, e As EventArgs) Handles lblleft.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblcenter_Click(sender As Object, e As EventArgs) Handles lblcenter.Click

    End Sub

    Private Sub btnsinister_Click(sender As Object, e As EventArgs) Handles btnsinister.Click
        lblleft.Text = "left"

    End Sub

    Private Sub btndexter_Click(sender As Object, e As EventArgs) Handles btndexter.Click
        lblright.Text = "right"
    End Sub

    Private Sub btnmedium_Click(sender As Object, e As EventArgs) Handles btnmedium.Click
        lblcenter.Text = "center"
    End Sub
End Class
