
Partial Class Directions
    Inherits System.Web.UI.Page

    Protected Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        Response.Redirect("~\Instructions_BuildNewHome.aspx")
    End Sub
End Class
