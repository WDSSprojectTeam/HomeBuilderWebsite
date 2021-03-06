﻿Imports System.Web.UI.DataVisualization.Charting
Imports System.Data

Partial Class OptimizationResultsPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (IsPostBack And Session("checkthings") = 1) Then
            btnSave.Visible = True
            chtFeatures.Visible = True
            Dim cht As New OptPieChart(chtFeatures)
            cht.Draw()
            Dim check As Integer = Session("Chart")
            DrawCharts(check)
        Else
            DrawCharts(10000)
        End If

    End Sub

    Private Sub DrawCharts(ByVal i As Integer)
        Dim myResults As New List(Of OptimizationResults)
        myResults = Session("Results")
        Dim C As New ResultChart(chtCompareBudgets, i)
        C.LoadData(myResults)
        C.DrawOptResults()
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
        Dim displayList As New DataTable
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

        chtFeatures.Visible = True
        Dim cht As New OptPieChart(chtFeatures)
        cht.Draw()

    End Sub


    'Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    Dim C As New OptPieChart(chtFeatures)
    '    DrawCharts(10000)
    '    btnSave.Visible = False
    '    Panel1.Visible = False
    '    If (IsPostBack) Then
    '        btnSave.Visible = True

    '    End If


    '    If (IsPostBack And Session("checkthings") = 1) Then
    '        btnSave.Visible = True
    '        updateFeatures()
    '        chtFeatures.Visible = True
    '        Dim cht As New OptPieChart(chtFeatures)
    '        cht.Draw()
    '    End If

    '    'rdb1.Visible = False
    '    'rdb2.Visible = False
    '    'rdb3.Visible = False
    '    'rdb4.Visible = False
    '    'rdb5.Visible = False
    '    'Panel1.Visible = False
    '    'Dim myOptionList As List(Of Options) = Session("OptionSet")
    '    ''Dim myChosenOptions As List(Of Integer) = Session("chosenTemplateFeatures")
    '    ''Dim myTable As DataTable = Session("myTemplate")
    '    ''Session("chosenTemplateFeatures") = myChosenOptions
    '    'Dim index As Integer = Session("whichTemplate")
    '    'Dim displayList As New DataTable
    '    'displayList.Columns.Add("Feature")
    '    'displayList.Columns.Add("Name")
    '    'displayList.Columns.Add("Description")
    '    'displayList.Columns.Add("Price")

    '    'Dim myChosenOptions As New List(Of Integer)
    '    'If Session("chosenTemplateFeatures") Is Nothing Then

    '    '    For i = 4 To 13

    '    '        myChosenOptions.Add(myTable.Rows(index).Item(i))

    '    '    Next
    '    '    Session("chosenTemplateFeatures") = myChosenOptions

    '    'Else
    '    '    myChosenOptions = Session("chosenTemplateFeatures")
    '    'End If




    '    'For i = 0 To myOptionList.Count - 1
    '    '    For j = 0 To myChosenOptions.Count - 1
    '    '        If myOptionList.Item(i).getoptionID = myChosenOptions.Item(j) Then
    '    '            Dim list As New ArrayList
    '    '            displayList.Rows.Add()
    '    '            displayList.Rows(displayList.Rows.Count - 1)("Feature") = myOptionList.Item(i).getFeatureName
    '    '            displayList.Rows(displayList.Rows.Count - 1)("Name") = myOptionList.Item(i).getoptionname
    '    '            displayList.Rows(displayList.Rows.Count - 1)("Description") = myOptionList.Item(i).getoptiondescription
    '    '            displayList.Rows(displayList.Rows.Count - 1)("Price") = myOptionList.Item(i).getoptionprice

    '    '        End If
    '    '    Next

    '    'Next
    '    'gvwEditTemplate.DataSource = displayList
    '    'gvwEditTemplate.DataBind()


    'End Sub



    ''Private Sub chtCompareBudgets_GetToolTipText(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs) Handles chtCompareBudgets.GetToolTipText
    ''    If e.HitTestResult.PointIndex >= 0 Then
    ''        If e.HitTestResult.ChartElementType = DataVisualization.Charting.ChartElementType.DataPoint Then
    ''            Dim Xvalue As Integer = e.X
    ''            Dim Yvalue As Integer = e.Y
    ''        End If
    ''    End If
    ''End Sub








    Protected Sub chtCompareBudgets_Click(sender As Object, e As ImageMapEventArgs) Handles chtCompareBudgets.Click
        btnSave.Visible = True
        Panel1.Visible = False
        lblFeatureEdit.Visible = False
        lblFeatureName.Visible = True
        rdb1.Visible = False
        rdb2.Visible = False
        rdb3.Visible = False
        rdb4.Visible = False
        rdb5.Visible = False
        Dim check As Integer
        Dim optBudgets As ArrayList = Session("OptBudgets")
        Dim wc = e.PostBackValue.Remove(0, 8)

        For i = 0 To 8
            If wc = optBudgets.Item(i).ToString Then
                check = i
            End If
        Next

        Session("Chart") = check
        DrawCharts(check)
        gvwDetails.Visible = True
        Dim myResults As List(Of OptimizationResults) = Session("Results")

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
        populateGridview()
    End Sub
    Private Sub populateGridview()
        Dim displayList As New DataTable
        Dim myHome As HomeLayouts = Session("selectedHome")


        Dim myChosenOptions As List(Of Integer) = Session("chosenOptions")
        Dim myOptionList As List(Of Options) = Session("optionSet")

        displayList.Columns.Add("Feature")
        displayList.Columns.Add("Name")
        displayList.Columns.Add("Description")
        displayList.Columns.Add("Price")
        Dim sum As Integer = 0

        For i = 0 To myOptionList.Count - 1
            For j = 0 To myChosenOptions.Count - 1
                If myOptionList.Item(i).getoptionID = myChosenOptions.Item(j) Then
                    Dim list As New ArrayList
                    displayList.Rows.Add()
                    displayList.Rows(displayList.Rows.Count - 1)("Feature") = myOptionList.Item(i).getFeatureName
                    displayList.Rows(displayList.Rows.Count - 1)("Name") = myOptionList.Item(i).getoptionname
                    displayList.Rows(displayList.Rows.Count - 1)("Description") = myOptionList.Item(i).getoptiondescription
                    displayList.Rows(displayList.Rows.Count - 1)("Price") = myOptionList.Item(i).getoptionprice
                    sum += myOptionList.Item(i).getoptionprice

                    'list.Add(myOptionList.Item(i).getoptionname)
                    'list.Add(myOptionList.Item(i).getoptiondescription)
                    'list.Add(myOptionList.Item(i).getoptionprice)
                    'displayList.Add(list)
                End If
            Next

        Next
        gvwDetails.DataSource = displayList
        gvwDetails.DataBind()
        lblCost.Text = "Total Cost: $" & (sum + myHome.Price)

        chtFeatures.Visible = True
        Dim cht As New OptPieChart(chtFeatures)
        cht.Draw()
    End Sub


    Protected Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim myOptionList As List(Of Options) = Session("OptionSet")
        Dim myFeatureList As List(Of Feature) = Session("FeatureSet")
        Dim myChosenOptions As List(Of Integer) = Session("chosenOptions")

        Dim whichRDB As RadioButton

        If rdb1.Checked = True Then
            whichRDB = rdb1

        ElseIf rdb2.Checked
            whichRDB = rdb2

        ElseIf rdb3.Checked
            whichRDB = rdb3

        ElseIf rdb4.Checked
            whichRDB = rdb4

        ElseIf rdb5.Checked
            whichRDB = rdb5

        Else
            whichRDB = rdb1
        End If


        For i = 0 To myOptionList.Count - 1
            If myOptionList.Item(i).getoptionname = whichRDB.Text Then
                For j = 0 To myFeatureList.Count - 1
                    If myFeatureList.Item(j).getID = myOptionList.Item(i).getFeatureID Then
                        myChosenOptions.Item(j) = myOptionList.Item(i).getoptionID
                    End If
                Next
            End If
        Next

        Session("chosenOptions") = myChosenOptions
        populateGridview()
    End Sub

    Protected Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim myHome As HomeLayouts = Session("selectedHome")
        Dim index As Integer = Session("Chart")
        Dim myResults As List(Of OptimizationResults) = Session("Results")
        Dim Result As OptimizationResults = myResults.Item(index)
        Dim myChosenOptions As List(Of Integer) = Session("chosenOptions")
        Dim myOptionsList As List(Of Options) = Session("OptionSet")
        Dim upgradeCost As Double = 0
        Dim Utility As Integer = 0



        For Each aOption In myOptionsList
            For Each chosenOption In myChosenOptions
                If aOption.getoptionID = chosenOption Then
                    upgradeCost += aOption.getoptionprice
                    Utility += aOption.Preference * aOption.getFeaturePreference
                End If
            Next
        Next

        Utility = Utility / Result.getMaxUtility * 100

        Dim HouseName As String = myHome.Name
        Dim Budget As Integer = Session("Budget")
        Dim ScenarioName As String = InputBox("What would you like to save this scenario as?", "Save Scenario", "")
        Dim TotalCost As Double = upgradeCost + myHome.Price

        Dim FloorCost As Double = 1
        Dim RoofCost As Double = 1

        For i = 0 To myOptionsList.Count - 1
            If myOptionsList.Item(i).getoptionID = myChosenOptions.Item(0) Then
                FloorCost = myOptionsList.Item(i).getoptionprice
            End If

            If myOptionsList.Item(i).getoptionID = myChosenOptions.Item(1) Then
                RoofCost = myOptionsList.Item(i).getoptionprice
            End If

        Next


        For Each aOption In myOptionsList
            If aOption.getoptionID = myChosenOptions.Item(0) Then
                FloorCost = aOption.getoptionprice
            End If

            If aOption.getoptionID = myChosenOptions.Item(1) Then
                RoofCost = aOption.getoptionprice
            End If
        Next

        Dim Floors As Integer = myChosenOptions.Item(0)
        Dim Roof_Type As Integer = myChosenOptions.Item(1)
        Dim Appliances As Integer = myChosenOptions.Item(2)
        Dim Garage As Integer = myChosenOptions.Item(3)
        Dim Countertops As Integer = myChosenOptions.Item(4)
        Dim Bath As Integer = myChosenOptions.Item(5)
        Dim Closets As Integer = myChosenOptions.Item(6)
        Dim Fireplace As Integer = myChosenOptions.Item(7)
        Dim Landscape As Integer = myChosenOptions.Item(8)
        Dim Cabinet As Integer = myChosenOptions.Item(9)


        Dim DAL As New DataLoader
        DAL.InsertSavedScenario(HouseName, Budget, ScenarioName, TotalCost, FloorCost, RoofCost, Floors, Roof_Type, Appliances, Garage, Countertops, Bath, Closets, Fireplace, Cabinet, Landscape, Utility)
    End Sub

    Protected Sub gvwDetails_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gvwDetails.RowCommand

        lblFeatureEdit.Visible = False
        Panel1.Visible = False
        lblFeatureName.Visible = False
        rdb1.Visible = False
        rdb2.Visible = False
        rdb3.Visible = False
        rdb4.Visible = False
        rdb5.Visible = False

        Dim rowIndex As Integer = e.CommandArgument    ' which row
        Session("whichFeature") = rowIndex + 1
        Dim myResults As List(Of OptimizationResults) = Session("Results")
        Dim myChosenOptions As List(Of Integer) = Session("chosenOptions")
        Dim optID As Integer = myChosenOptions.Item(rowIndex)
        Dim myOptionList As List(Of Options) = Session("OptionSet")

        For Each aOption In myOptionList
            If aOption.getoptionID = optID Then
                Session("whichOption") = aOption
            End If
        Next

        Dim myFeature As Integer = Session("whichFeature")
        Dim myOption As Options = Session("whichOption")
        Dim myFeatureSet As List(Of Feature) = Session("FeatureSet")

        Dim panelCount As Integer = 0
        For Each aFeature In myFeatureSet
            If aFeature.getID = myFeature Then
                lblFeatureEdit.Visible = True
                lblFeatureName.Visible = True
                Panel1.Visible = True
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

        If lblFeatureName.Visible = True Then
            Session("checkthings") = 1
        Else
            Session("checkthings") = 0
        End If

    End Sub

    Protected Sub btnBack_Click(sender As Object, e As System.EventArgs) Handles btnBack.Click
        Response.Redirect("FEBedroom.aspx")
    End Sub

    Protected Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Response.Redirect("Home.aspx")
    End Sub
End Class
