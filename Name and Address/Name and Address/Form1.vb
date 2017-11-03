Public Class Form

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblCityStateZip.Click

    End Sub

    Private Sub btnshowinfo_Click(sender As Object, e As EventArgs) Handles btnshowinfo.Click
        lblName.Text = "William Wolfe"
        lbladdress.Text = "888 South Main Street"
        lblCityStateZip.Text = "Waynesville, NC 28786"


    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbladdress.Click

    End Sub
End Class
