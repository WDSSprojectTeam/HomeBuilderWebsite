
Imports System.Data

Partial Class Detialsoftemplate
    Inherits System.Web.UI.Page


    Private mydataloader As New DataLoader

    Private Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim homeid As Integer = Session("tempid")

        dvwHomeDetails.DataSource = mydataloader.GetTemplateDetails(homeid)
        dvwHomeDetails.DataBind()

    End Sub



    Protected Sub btnbacktochoosehome_Click(sender As Object, e As EventArgs) Handles btnbacktochoosehome.Click
        Response.Redirect("ScenarioGridview.aspx")
    End Sub

    Private Sub btnFeatureEvaluation_Click(sender As Object, e As EventArgs) Handles btnFeatureEvaluation.Click
        Response.Redirect("~\EditTemplateFeatures.aspx")
    End Sub

End Class
