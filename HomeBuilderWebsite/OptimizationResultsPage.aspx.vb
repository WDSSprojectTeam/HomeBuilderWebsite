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
        Dim check As Integer
        Dim wc = e.PostBackValue.Remove(0, 8)
        If wc = "80% of Budget" Then
            check = 0

        ElseIf wc = "85% of Budget"
            check = 1

        ElseIf wc = "90% of Budactuallget"
            check = 2

        ElseIf wc = "95% of Budget"
            check = 3

        ElseIf wc = "100% of Budget"
            check = 4

        ElseIf wc = "106% of Budget"
            check = 5

        ElseIf wc = "110% of Budget"
            check = 6

        ElseIf wc = "115% of Budget"
            check = 7

        ElseIf wc = "120% of Budget"
            check = 8
        End If
        Session("Chart") = check
        pnlGVW.Visible = True
        Dim myResults As List(Of OptimizationResults) = Session("Results")
        gvwDetails.DataSource = myResults.Item(check).getSelectedOptions
        gvwDetails.DataBind()

    End Sub
End Class
