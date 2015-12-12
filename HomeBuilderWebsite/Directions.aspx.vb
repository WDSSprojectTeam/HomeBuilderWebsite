
Partial Class Directions
    Inherits System.Web.UI.Page

    Protected Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        Response.Redirect("~\Instructions_BuildNewHome.aspx")
    End Sub

    Protected Sub btnBack_Click(sender As Object, e As System.EventArgs) Handles btnBack.Click
        Response.Redirect("Home.aspx")
    End Sub
End Class
