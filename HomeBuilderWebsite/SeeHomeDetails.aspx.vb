
Partial Class SeeHomeDetails
    Inherits System.Web.UI.Page

    Private mydataloader As New DataLoader

    Private Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim homeid As Integer = Session("homeid")

        dvwHomeDetails.DataSource = mydataloader.GetHomePicture(homeid)
        dvwHomeDetails.DataBind()

    End Sub



    Protected Sub btnbacktochoosehome_Click(sender As Object, e As EventArgs) Handles btnbacktochoosehome.Click
        Session("numberofloads") = 2
        Response.Redirect("ChooseHomeLayout.aspx")
    End Sub

    Private Sub btnFeatureEvaluation_Click(sender As Object, e As EventArgs) Handles btnFeatureEvaluation.Click
        Response.Redirect("~\ChooseFeature.aspx")
    End Sub
End Class
