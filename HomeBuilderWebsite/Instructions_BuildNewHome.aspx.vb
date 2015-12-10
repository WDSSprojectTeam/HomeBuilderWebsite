
Partial Class Instructions_BuildNewHome
    Inherits System.Web.UI.Page

    Protected Sub btnBegin_Click(sender As Object, e As EventArgs) Handles btnBegin.Click

        Session("Budget") = tbxBudget.Text
        Response.Redirect("~\ChooseHomeLayout.aspx")

        Dim homestyle As String
        homestyle = rdbhomestyle.SelectedValue
        Session("homestyleselected") = homestyle

    End Sub


End Class
