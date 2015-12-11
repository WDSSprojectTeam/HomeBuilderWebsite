Imports System.Web.UI.DataVisualization.Charting
Imports System.data

Partial Class OptimizationResultsPage
    Inherits System.Web.UI.Page
    Private check2 As Boolean = False

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DrawCharts()

        If (IsPostBack And lblFeatureName.visible = True) Then
            updateFeatures()
        End If

        check2 = False

    End Sub

    Private Sub updateFeatures()
        Dim myFeature As Integer = Session("whichFeature")
        Dim myOption As Options = Session("whichOption")
        Dim myFeatureSet As List(Of Feature) = Session("FeatureSet")
        Dim myOptionList As List(Of Options) = Session("OptionSet")
        Dim myChosenOptions As List(Of Integer) = Session("chosenOptions")
        Dim index As Integer
        For i = 0 To myOptionList.Count - 1
            If myOption.getoptionID = myOptionList.Item(i).getoptionID Then
                index = i
            End If
        Next


        Dim check As String

        If rdb1.Checked = True And rdb1.Text IsNot myOptionList.Item(index).getoptionname Then
            check = rdb1.Text

        ElseIf rdb2.Checked = True And rdb2.Text IsNot myOptionList.Item(index).getoptionname
            check = rdb2.Text


        ElseIf rdb3.Checked = True And rdb3.Text IsNot myOptionList.Item(index).getoptionname
            check = rdb3.Text

        ElseIf rdb4.Checked = True And rdb4.Text IsNot myOptionList.Item(index).getoptionname
            check = rdb4.Text

        ElseIf rdb5.Checked = True And rdb5.Text IsNot myOptionList.Item(index).getoptionname
            check = rdb5.Text

        Else
            check = myOptionList.Item(index).getoptionname
        End If

        ChangeChoice(check)
        Dim displayList As New datatable
        displayList.Columns.Add("Feature")
        displayList.Columns.Add("Name")
        displayList.Columns.Add("Description")
        displayList.Columns.Add("Price")

        myChosenOptions = Session("chosenOptions")

        For i = 0 To myOptionList.Count - 1
            For j = 0 To myChosenOptions.Count - 1
                If myOptionList.Item(i).getoptionID = myChosenOptions.Item(j) Then
                    Dim list As New ArrayList
                    displayList.Rows.Add()
                    displayList.Rows(displayList.Rows.Count - 1)("Feature") = myOptionList.Item(i).getFeatureName
                    displayList.Rows(displayList.Rows.Count - 1)("Name") = myOptionList.Item(i).getoptionname
                    displayList.Rows(displayList.Rows.Count - 1)("Description") = myOptionList.Item(i).getoptiondescription
                    displayList.Rows(displayList.Rows.Count - 1)("Price") = myOptionList.Item(i).getoptionprice

                End If
            Next

        Next
        gvwDetails.DataSource = displayList
        gvwDetails.DataBind()


    End Sub


    Private Sub DrawCharts()
        Dim myResults As New List(Of OptimizationResults)
        myResults = Session("Results")
        Dim C As New ResultChart(chtCompareBudgets)
        C.LoadData(myResults)
        C.DrawOptResults()
    End Sub

    Protected Sub chtCompareBudgets_Click(sender As Object, e As ImageMapEventArgs) Handles chtCompareBudgets.Click
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
        gvwDetails.visible = True
        Dim myResults As List(Of OptimizationResults) = Session("Results")
        Dim displayList As New DataTable
        'gvwDetails.DataSource = myResults.Item(check).getSelectedOptions
        'gvwDetails.DataBind()

        Dim myOptionsList As List(Of Options) = Session("OptionSet")
        Dim myChosenOptions As New List(Of Integer)
        For Each aChoice In myResults.Item(check).getSelectedOptions()
            myChosenOptions.Add(aChoice.getoptionID)
        Next

        'For i = 0 To myOptionsList.Count - 1
        '    If myResults.Item(check).getChoices.Item(i) = 1 Then
        '        myChosenOptions.Add(i)
        '    End If
        'Next
        Session("chosenOptions") = myChosenOptions

        Dim myOptionList As List(Of Options) = Session("optionSet")

        displayList.Columns.Add("Feature")
        displayList.Columns.Add("Name")
        displayList.Columns.Add("Description")
        displayList.Columns.Add("Price")


        For i = 0 To myOptionList.Count - 1
            For j = 0 To myChosenOptions.Count - 1
                If myOptionList.Item(i).getoptionID = myChosenOptions.Item(j) Then
                    Dim list As New ArrayList
                    displayList.Rows.Add()
                    displayList.Rows(displayList.Rows.Count - 1)("Feature") = myOptionList.Item(i).getFeatureName
                    displayList.Rows(displayList.Rows.Count - 1)("Name") = myOptionList.Item(i).getoptionname
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
    'Protected Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
    '    Response.Redirect("EditOptResults.aspx")
    'End Sub

    Protected Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim myHome As homeLayouts = Session("selectedHome")
        Dim HouseName As String = myHome.name
        Dim Budget As Integer = Session("Budget")
        Dim ScenarioName As String = "whaaaa"
        Dim TotalCost As Double = 1
        Dim FloorCost As Double = 1
        Dim RoofCost As Double = 1
        Dim Floors As Integer = 1
        Dim Roof_Type As Integer = 1
        Dim Appliances As Integer = 1
        Dim Garage As Integer = 1
        Dim Countertops As Integer = 1
        Dim Bath As Integer = 1
        Dim Closets As Integer = 1
        Dim Fireplace As Integer = 1
        Dim Utility As Integer = 1

        Dim DAL As New DataLoader
        DAL.InsertSavedScenario(HouseName, Budget, ScenarioName, TotalCost, FloorCost, RoofCost, Floors, Roof_Type, Appliances, Garage, Countertops, Bath, Closets, Fireplace, Utility)
    End Sub

    Protected Sub gvwDetails_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gvwDetails.RowCommand
        lblFeatureName.visible = False
        rdb1.visible = False
        rdb2.visible = False
        rdb3.visible = False
        rdb4.visible = False
        rdb5.visible = False

        Dim rowIndex As Integer = e.CommandArgument    ' which row
        Session("whichFeature") = rowIndex + 1
        Dim myResults As List(Of OptimizationResults) = Session("Results")
        Dim myChosenOptions As List(Of Integer) = Session("chosenOptions")
        Dim optID As Integer = myChosenOptions.Item(rowIndex)
        Dim myOptionSet As List(Of Options) = Session("OptionSet")

        For Each aOption In myOptionSet
            If aOption.getoptionID = optID Then
                Session("whichOption") = aOption
            End If
        Next

        Dim myFeature As Integer = Session("whichFeature")
        Dim myOption As Options = Session("whichOption")
        Dim myFeatureSet As List(Of Feature) = Session("FeatureSet")
        Dim myOptionList As List(Of Options) = Session("OptionSet")
        Dim panelCount As Integer = 0
        For Each aFeature In myFeatureSet
            If aFeature.getID = myFeature Then
                lblFeatureName.visible = True
                lblFeatureName.Text = aFeature.Name
            End If
        Next


        For i = 0 To myOptionList.Count - 1
            If myOptionList.Item(i).getFeatureID = myFeature Then
                panelCount = panelCount + 1

                If panelCount = 1 Then
                    rdb1.Visible = True
                    rdb1.Text = myOptionList.Item(i).getoptionname
                    If myOptionList.Item(i).getoptionname = myOption.getoptionname Then
                        rdb1.Checked = True
                    End If

                ElseIf panelCount = 2 Then
                    rdb2.Visible = True
                    rdb2.Text = myOptionList.Item(i).getoptionname
                    If myOptionList.Item(i).getoptionname = myOption.getoptionname Then
                        rdb2.Checked = True
                    End If

                ElseIf panelCount = 3 Then
                    rdb3.Visible = True
                    rdb3.Text = myOptionList.Item(i).getoptionname
                    If myOptionList.Item(i).getoptionname = myOption.getoptionname Then
                        rdb3.Checked = True
                    End If

                ElseIf panelCount = 4 Then
                    rdb4.Visible = True
                    rdb4.Text = myOptionList.Item(i).getoptionname
                    If myOptionList.Item(i).getoptionname = myOption.getoptionname Then
                        rdb4.Checked = True
                    End If

                ElseIf panelCount = 5 Then
                    rdb5.Visible = True
                    rdb5.Text = myOptionList.Item(i).getoptionname
                    If myOptionList.Item(i).getoptionname = myOption.getoptionname Then
                        rdb5.Checked = True
                    End If
                End If
            End If
        Next





    End Sub

    Private Sub ChangeChoice(ByVal checkText As String)
        Dim myOptionList As List(Of Options) = Session("OptionSet")
        Dim myChosenOptions As List(Of Integer) = Session("chosenOptions")
        Dim myFeature As Integer = Session("whichFeature")
        Dim myOption As Options

        For i = 0 To myOptionList.Count - 1
            If myOptionList.Item(i).getoptionname = checkText Then
                myChosenOptions.Item(myFeature - 1) = myOptionList.Item(i).getoptionID
                myOption = myOptionList.Item(i)
            End If
        Next
        Session("whichOption") = myOption

        check2 = True

    End Sub

End Class
