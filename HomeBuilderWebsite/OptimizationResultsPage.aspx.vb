Imports System.Web.UI.DataVisualization.Charting
Imports System.data

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

        ElseIf wc = "90% of Budget"
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
        Dim displayList As New DataTable
        'gvwDetails.DataSource = myResults.Item(check).getSelectedOptions
        'gvwDetails.DataBind()

        Dim myOptionsList As List(Of Options) = Session("OptionSet")
        Dim myChosenOptions As New List(Of Integer)
        For Each aChoice In myResults.Item(check).getSelectedOptions()
            myChosenOptions.add(aChoice.getoptionID)
        Next

        'For i = 0 To myOptionsList.Count - 1
        '    If myResults.Item(check).getChoices.Item(i) = 1 Then
        '        myChosenOptions.Add(i)
        '    End If
        'Next
        Session("chosenOptions") = myChosenOptions

        Dim myOptionList As List(Of Options) = Session("optionSet")

        displayList.columns.add("Feature")
        displayList.Columns.Add("Name")
        displayList.Columns.Add("Description")
        displayList.Columns.Add("Price")


        For i = 0 To myOptionList.Count - 1
            For j = 0 To myChosenOptions.Count - 1
                If myOptionList.Item(i).getoptionID = myChosenOptions.Item(j) Then
                    Dim list As New ArrayList
                    displayList.Rows.Add()
                    displayList.Rows(displayList.Rows.Count - 1)("Feature") = myOptionList.item(i).getFeatureName
                    displayList.Rows(displayList.Rows.Count - 1)("Name") = myOptionList.item(i).getoptionname
                    displayList.Rows(displayList.Rows.Count - 1)("Description") = myOptionList.Item(i).getoptiondescription
                    displayList.Rows(displayList.Rows.Count - 1)("Price") = myOptionList.Item(i).getoptionprice
                    'list.Add(myOptionList.Item(i).getoptionname)
                    'list.Add(myOptionList.Item(i).getoptiondescription)
                    'list.Add(myOptionList.Item(i).getoptionprice)
                    'displayList.Add(list)
                End If
            Next

        Next
        gvwDetails.DataSource = displayList
        gvwDetails.DataBind()

    End Sub
    Protected Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Response.Redirect("EditOptResults.aspx")
    End Sub

End Class
