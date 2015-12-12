
Partial Class Instructions_BuildNewHome
    Inherits System.Web.UI.Page

    Private Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If (Not IsPostBack) Then
            lblbudgetvalidation.Visible = False
        End If


    End Sub


    Protected Sub btnBegin_Click(sender As Object, e As EventArgs) Handles btnBegin.Click

        If tbxBudget.Text = "" Then

            lblbudgetvalidation.Visible = True
        Else

            Dim homestyle As String
            homestyle = rdbhomestyle.SelectedValue
            Session("homestyleselected") = homestyle

            Session("Budget") = tbxBudget.Text

            Response.Redirect("~\ChooseHomeLayout.aspx")

        End If



    End Sub


    Protected Sub btnBack_Click(sender As Object, e As System.EventArgs) Handles btnBack.Click
        Response.Redirect("Directions.aspx")
    End Sub
End Class
