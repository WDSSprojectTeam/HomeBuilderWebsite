
Partial Class ScenarioInfo
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

            Dim keyarea As String
            keyarea = rdbhomestyle.SelectedValue
            Session("keyareaselected") = keyarea

            Session("Budget") = tbxBudget.Text

            Response.Redirect("~\ScenarioGridview.aspx")

        End If
    End Sub
End Class
