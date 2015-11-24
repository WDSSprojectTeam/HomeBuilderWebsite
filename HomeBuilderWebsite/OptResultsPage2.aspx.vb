
Partial Class OptResultsPage2
    Inherits Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim chek As Integer = Session("Chart")
        Dim results As List(Of OptimizationResults) = Session("Results")
        If chek = 1 Then
            gvwDetails.DataSource = results.Item(0).getSelectedOptions
            gvwDetails.DataBind()
        End If

    End Sub

    Protected Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Response.Redirect("Home.aspx")
    End Sub


End Class
