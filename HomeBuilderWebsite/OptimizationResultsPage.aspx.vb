Imports System.Web.UI.DataVisualization.Charting

Partial Class OptimizationResultsPage
    Inherits Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DrawCharts()
    End Sub

    Private Sub DrawCharts()
        Dim myResults As New List(Of OptimizationResults)
        myResults = Session("Results")
        Dim C As New ResultChart(chtCompareBudgets)
        C.LoadData(myResults)
        C.DrawOptResults()
    End Sub

    Protected Sub chtMaxUtility_Click(sender As Object, e As ImageMapEventArgs) Handles chtCompareBudgets.Click

        Dim wc = e.PostBackValue.Remove(0, 8)
        Session("Chart") = 1
        Response.Redirect("OptResultsPage2.aspx")

    End Sub
End Class
