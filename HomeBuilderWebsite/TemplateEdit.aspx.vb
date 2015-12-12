

Imports System.Data

Partial Class TemplateEdit
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



        rdb1.Visible = False
        rdb2.Visible = False
        rdb3.Visible = False
        rdb4.Visible = False
        rdb5.Visible = False
        Panel1.Visible = False
        Dim myOptionList As List(Of Options) = Session("OptionSet")
        'Dim myChosenOptions As List(Of Integer) = Session("chosenTemplateFeatures")
        Dim myTable As DataTable = Session("myTemplate")

        'Session("chosenTemplateFeatures") = myChosenOptions
        Dim index As Integer = Session("tempid") - 1
        Dim homeid As Integer = myTable.Rows(index).Item(1)
        Dim homelist As List(Of HomeLayouts) = Session("HomeSet")
        Dim myhome As New HomeLayouts

        For Each home In homelist
            If home.gethomeID = homeid Then
                myhome = home
            End If
        Next

        Dim displayList As New DataTable
        displayList.Columns.Add("Feature")
        displayList.Columns.Add("Name")
        displayList.Columns.Add("Description")
        displayList.Columns.Add("Price")

        Dim myChosenOptions As New List(Of Integer)
        If Session("chosenTemplateFeatures") Is Nothing Then

            For i = 4 To 13

                myChosenOptions.Add(myTable.Rows(index).Item(i))

            Next
            Session("chosenTemplateFeatures") = myChosenOptions

        Else
            myChosenOptions = Session("chosenTemplateFeatures")
        End If


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
                End If
            Next

        Next
        lblCost.Text = "Total Cost: $" & (sum + myHome.Price)
        gvwEditTemplate.DataSource = displayList
        gvwEditTemplate.DataBind()
        Dim C As New TempPieChart(chtPie)
        C.Draw()
    End Sub
    Protected Sub gvwEditTemplate_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gvwEditTemplate.RowCommand
        Panel1.Visible = True
        Dim rowIndex As Integer = e.CommandArgument
        Dim myOptionList As List(Of Options) = Session("OptionSet")
        Dim myFeatureList As List(Of Feature) = Session("FeatureSet")
        Dim optCount As Integer = 0
        Dim myChosenOptions As List(Of Integer) = Session("chosenTemplateFeatures")

        lblFeatureName.Visible = True
        lblFeatureName.Text = myFeatureList.Item(rowIndex).Name

        For i = 0 To myOptionList.Count - 1
            If myOptionList.Item(i).getFeatureID = rowIndex + 1 Then
                optCount += 1

                If optCount = 1 Then
                    rdb1.Text = myOptionList.Item(i).getoptionname
                    rdb1.Visible = True
                    If myOptionList.Item(i).getoptionID = myChosenOptions.Item(rowIndex) Then
                        rdb1.Checked = True
                    End If

                ElseIf optCount = 2 Then
                    rdb2.Text = myOptionList.Item(i).getoptionname
                    rdb2.Visible = True
                    If myOptionList.Item(i).getoptionID = myChosenOptions.Item(rowIndex) Then
                        rdb2.Checked = True
                    End If

                ElseIf optCount = 3 Then
                    rdb3.Text = myOptionList.Item(i).getoptionname
                    rdb3.Visible = True
                    If myOptionList.Item(i).getoptionID = myChosenOptions.Item(rowIndex) Then
                        rdb3.Checked = True
                    End If

                ElseIf optCount = 4 Then
                    rdb4.Text = myOptionList.Item(i).getoptionname
                    rdb4.Visible = True
                    If myOptionList.Item(i).getoptionID = myChosenOptions.Item(rowIndex) Then
                        rdb4.Checked = True
                    End If

                ElseIf optCount = 5 Then
                    rdb5.Text = myOptionList.Item(i).getoptionname
                    rdb5.Visible = True
                    If myOptionList.Item(i).getoptionID = myChosenOptions.Item(rowIndex) Then
                        rdb5.Checked = True
                    End If
                End If





            End If
        Next




    End Sub

    Protected Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim myOptionList As List(Of Options) = Session("OptionSet")
        Dim myFeatureList As List(Of Feature) = Session("FeatureSet")
        Dim myChosenOptions As List(Of Integer) = Session("chosenTemplateFeatures")

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

        Session("chosenTemplateFeatures") = myChosenOptions
        Response.Redirect("TemplateEdit.aspx")
    End Sub

    Protected Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim myTable As DataTable = Session("myTemplate")
        Dim index As Integer = Session("tempid") - 1
        Dim homeName As Integer = myTable.Rows(index).Item(1)
        Dim myHomeList As List(Of HomeLayouts) = Session("HomeSet")
        Dim myHome As New HomeLayouts

        For Each aHome In myHomeList
            If aHome.gethomeID = homeName Then
                myHome = aHome
            End If
        Next

        Dim myChosenOptions As List(Of Integer) = Session("chosenTemplateFeatures")
        Dim myOptionsList As List(Of Options) = Session("OptionSet")
        Dim upgradeCost As Double = 0
        Dim Utility As Integer = 93



        For Each aOption In myOptionsList
            For i = 0 To myChosenOptions.Count - 1
                If aOption.getoptionID = myChosenOptions.Item(i) Then
                    upgradeCost += aOption.getoptionprice

                End If
            Next
        Next



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


    Protected Sub btnback_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Response.Redirect("ScenarioGridview.aspx")
    End Sub
End Class

