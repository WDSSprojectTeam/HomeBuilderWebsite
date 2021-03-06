﻿Imports System.Web.UI.DataVisualization.Charting

Partial Class FEOutdoor
    Inherits System.Web.UI.Page

    Protected Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim myOptionList As New optionSet(Session("OptionSet"))

        'ROOF TYPE

            myOptionList.GetName("Asphalt Shingle").Preference = rltAsphaltShingle.SelectedValue
            myOptionList.GetName("Wood Shingle").Preference = rltWoodShingle.SelectedValue
            myOptionList.GetName("Metal Shingle").Preference = rltMetalShingle.SelectedValue
            myOptionList.GetName("Slate Shingle").Preference = rltSlateShingle.SelectedValue
            myOptionList.GetName("Tile Shingle").Preference = rltTileShingle.SelectedValue

        'GARAGE

        myOptionList.GetName("One Car").Preference = rltOneCar.SelectedValue
        myOptionList.GetName("Two Car").Preference = rltTwoCar.SelectedValue
        myOptionList.GetName("Three Car").Preference = rltThreeCar.SelectedValue

        'LANDSCAPING

            myOptionList.GetName("Basic Curb Appeal").Preference = rltCurb.SelectedValue
            myOptionList.GetName("Curb Appeal Plus").Preference = rltCurbPlus.SelectedValue
            myOptionList.GetName("Premium Landscaping").Preference = rltPremium.SelectedValue

        'ROOF
        Dim asphaltshinglePrice As Double = myOptionList.GetName("Asphalt Shingle").getoptionprice
        Dim woodshinglePrice As Double = myOptionList.GetName("Wood Shingle").getoptionprice
        Dim metalshinglePrice As Double = myOptionList.GetName("Metal Shingle").getoptionprice
        Dim slateshinglePrice As Double = myOptionList.GetName("Slate Shingle").getoptionprice
        Dim tileshinglePrice As Double = myOptionList.GetName("Tile Shingle").getoptionprice

        Dim asphaltshingleRating As Integer = myOptionList.GetName("Asphalt Shingle").Preference
        Dim woodshingleRating As Integer = myOptionList.GetName("Wood Shingle").Preference
        Dim metalshingleRating As Integer = myOptionList.GetName("Metal Shingle").Preference
        Dim slateshingleRating As Integer = myOptionList.GetName("Slate Shingle").Preference
        Dim tileshingleRating As Integer = myOptionList.GetName("Tile Shingle").Preference

        'GARAGE
        Dim onecarPrice As Double = myOptionList.GetName("One Car").getoptionprice
        Dim twocarPrice As Double = myOptionList.GetName("Two Car").getoptionprice
        Dim threecarPrice As Double = myOptionList.GetName("Three Car").getoptionprice

        Dim onecarRating As Integer = myOptionList.GetName("One Car").Preference
        Dim twocarRating As Integer = myOptionList.GetName("Two Car").Preference
        Dim threecarRating As Integer = myOptionList.GetName("Three Car").Preference

        'LANDSCAPING
        Dim curbPrice As Double = myOptionList.GetName("Basic Curb Appeal").getoptionprice
        Dim curbPlusPrice As Double = myOptionList.GetName("Curb Appeal Plus").getoptionprice
        Dim PremiumPrice As Double = myOptionList.GetName("Premium Landscaping").getoptionprice

        Dim curbRating As Integer = myOptionList.GetName("Basic Curb Appeal").Preference
        Dim curbPlusRating As Integer = myOptionList.GetName("Curb Appeal Plus").Preference
        Dim PremiumRating As Integer = myOptionList.GetName("Premium Landscaping").Preference

        Dim roofavg As Double = AvgPrice(asphaltshinglePrice, woodshinglePrice, metalshinglePrice, slateshinglePrice, tileshinglePrice, asphaltshingleRating, woodshingleRating, metalshingleRating, slateshingleRating, tileshingleRating)
        Dim garageavg As Double = AvgPrice(onecarPrice, twocarPrice, threecarPrice, 0, 0, onecarRating, twocarRating, threecarRating, 0, 0)
        Dim landscapeavg As Double = AvgPrice(curbPrice, curbPlusPrice, PremiumPrice, 0, 0, curbRating, curbPlusRating, PremiumRating, 0, 0)

        Dim remainderbudget As Double = Session("myRemainderBudget")
        Session("myRemainderBudget") = remainderbudget - (roofavg + garageavg + landscapeavg)

        Session("Roofavg") = roofavg
        Session("Garageavg") = garageavg
        Session("Landscapeavg") = landscapeavg

        Dim budgetvaluelist As New ArrayList
        budgetvaluelist.Add(Session("Roofavg"))
        budgetvaluelist.Add(Session("Garageavg"))
        budgetvaluelist.Add(Session("Landscapeavg"))
        budgetvaluelist.Add(Session("Flooringavg"))
        budgetvaluelist.Add(Session("Fireplaceavg"))
        budgetvaluelist.Add(Session("Appliancesavg"))
        budgetvaluelist.Add(Session("Countertopsavg"))
        budgetvaluelist.Add(Session("Cabinetsavg"))
        budgetvaluelist.Add(Session("Bathroomsavg"))
        budgetvaluelist.Add(Session("Closetsavg"))
        If Session("myRemainderBudget") > 0 Then
            budgetvaluelist.Add(Session("myRemainderBudget"))
        Else
            budgetvaluelist.Add(0)
        End If
        Session("yvaluespie") = budgetvaluelist


        Response.Redirect("FEInterior.aspx")

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim remainderbudget As Double = Session("myRemainderBudget")
        Dim budget As Double = Session("Budget")

        lblBudget.Text = "$ " & Convert.ToString(Math.Round(remainderbudget, 0)) & " left in your budget"
        Dim percentbudgetused As Double = (budget - remainderbudget) / budget
        Math.Round(percentbudgetused)
        If remainderbudget > 0 Then
            If percentbudgetused <= 0.5 Then
                tblBar.Rows.Item(0).Cells.Item(0).BackColor = Drawing.Color.Green
            ElseIf percentbudgetused > 0.5 And percentbudgetused < 0.8 Then
                tblBar.Rows.Item(0).Cells.Item(0).BackColor = Drawing.Color.Orange
            ElseIf percentbudgetused >= 0.8 Then
                tblBar.Rows.Item(0).Cells.Item(0).BackColor = Drawing.Color.Red
            End If
        Else
            percentbudgetused = 1
            tblBar.Rows.Item(0).Cells.Item(0).BackColor = Drawing.Color.Red
        End If
        tblBar.Rows.Item(0).Cells.Item(0).Width = 200 * percentbudgetused
        lblpercent.Text = Convert.ToString(Math.Round(100 * percentbudgetused)) & " % of budget is spent"
        DrawBudgetCharter()
    End Sub

    Public Function AvgPrice(ByVal p1 As Double, ByVal p2 As Double, ByVal p3 As Double, ByVal p4 As Double, ByVal p5 As Double, ByVal r1 As Integer, ByVal r2 As Integer, ByVal r3 As Integer, ByVal r4 As Integer, ByVal r5 As Integer) As Double
        Dim weightedsum As Double = r1 * p1 + r2 * p2 + r3 * p3 + r4 * p4 + r5 * p5
        Dim ratingsum As Double = r1 + r2 + r3 + r4 + r5
        Dim weightedavg As Double = weightedsum / ratingsum
        Return weightedavg
    End Function

    Private Sub DrawBudgetCharter()
        Dim chtBudget As New Chart
        pnlydynamichart.Controls.Add(chtBudget)
        Dim mycharter As New BudgetAllocationCharter(chtBudget)
        mycharter.Draw()
    End Sub

    Protected Sub btnBack_Click(sender As Object, e As System.EventArgs) Handles btnBack.Click
        Response.Redirect("ChooseFeature.aspx")
    End Sub
End Class
