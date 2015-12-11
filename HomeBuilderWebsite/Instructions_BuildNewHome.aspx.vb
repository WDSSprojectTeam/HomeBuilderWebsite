
Partial Class Instructions_BuildNewHome
    Inherits System.Web.UI.Page

    Private Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If (Not IsPostBack) Then
            lblbudgetvalidation.visible = False
        End If


    End Sub


    Protected Sub btnBegin_Click(sender As Object, e As EventArgs) Handles btnBegin.Click


        Dim homestyle As String
            homestyle = rdbhomestyle.SelectedValue
            Session("homestyleselected") = homestyle

        Session("Budget") = tbxBudget.Text

        If Session("Budget") Is Nothing Then
            Session("Budget") = 0
            lblbudgetvalidation.visible = True
        Else
            Response.Redirect("~\ChooseHomeLayout.aspx")

        End If



    End Sub


End Class
