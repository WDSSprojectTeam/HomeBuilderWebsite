Imports System.Web.UI.DataVisualization.Charting

Partial Class FEOutdoor
    Inherits System.Web.UI.Page



    Protected Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim myOptionList As New optionSet(Session("OptionSet"))

        'ROOF TYPE

        If cbxAsphaltShingle.Checked = True Then
            myOptionList.GetName("Asphalt Shingle").Need = True
        ElseIf cbxWoodShingle.Checked = True Then
            myOptionList.GetName("Wood Shingle").Need = True
        ElseIf cbxMetalShingle.Checked = True Then
            myOptionList.GetName("Metal Shingle").Need = True
        ElseIf cbxSlateShingle.Checked = True Then
            myOptionList.GetName("Slate Shingle").Need = True
        ElseIf cbxTileShingle.Checked = True Then
            myOptionList.GetName("Tile Shingle").Need = True
        Else
            myOptionList.GetName("Asphalt Shingle").Preference = rltAsphaltShingle.SelectedValue
            myOptionList.GetName("Wood Shingle").Preference = rltWoodShingle.SelectedValue
            myOptionList.GetName("Metal Shingle").Preference = rltMetalShingle.SelectedValue
            myOptionList.GetName("Slate Shingle").Preference = rltSlateShingle.SelectedValue
            myOptionList.GetName("Tile Shingle").Preference = rltTileShingle.SelectedValue
        End If

        'GARAGE

        If cbxOneCar.Checked = True Then
            myOptionList.GetName("One Car").Need = True
        ElseIf cbxTwoCar.Checked = True Then
            myOptionList.GetName("Two Car").Need = True
        ElseIf cbxThreeCar.Checked = True Then
            myOptionList.GetName("Three Car").Need = True
        Else
            myOptionList.GetName("One Car").Preference = rltOneCar.SelectedValue
            myOptionList.GetName("Two Car").Preference = rltTwoCar.SelectedValue
            myOptionList.GetName("Three Car").Preference = rltThreeCar.SelectedValue
        End If

        'Dim myHome As HomeLayouts = Session("SelectedHome")
        'Dim footage As Double = myHome.SquareFeet

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

        Dim roofavg As Double = AvgPrice(asphaltshinglePrice, woodshinglePrice, metalshinglePrice, slateshinglePrice, tileshinglePrice, asphaltshingleRating, woodshingleRating, metalshingleRating, slateshingleRating, tileshingleRating)
        Dim garageavg As Double = AvgPrice(onecarPrice, twocarPrice, threecarPrice, 0, 0, onecarRating, twocarRating, threecarRating, 0, 0)

        'ROOF

        If cbxAsphaltShingle.Checked = True Then
            roofavg = asphaltshinglePrice
        ElseIf cbxWoodShingle.Checked = True Then
            roofavg = woodshinglePrice
        ElseIf cbxMetalShingle.Checked = True Then
            roofavg = metalshinglePrice
        ElseIf cbxSlateShingle.Checked = True Then
            roofavg = slateshinglePrice
        ElseIf cbxTileShingle.Checked = True Then
            roofavg = tileshinglePrice
        End If

        'GARAGE

        If cbxOneCar.Checked = True Then
            garageavg = onecarPrice
        ElseIf cbxTwoCar.Checked = True Then
            garageavg = twocarPrice
        ElseIf cbxThreeCar.Checked = True Then
            garageavg = threecarPrice
        End If

        Dim remainderbudget As Double = Session("myRemainderBudget")
        Session("myRemainderBudget") = remainderbudget - (roofavg + garageavg)

        Session("Roofavg") = roofavg
        Session("Garageavg") = garageavg

        Dim budgetvaluelist As New ArrayList
        budgetvaluelist.Add(Session("Roofavg"))
        budgetvaluelist.Add(Session("Garageavg"))
        budgetvaluelist.Add(Session("Flooringavg"))
        budgetvaluelist.Add(Session("Fireplaceavg"))
        budgetvaluelist.Add(Session("Appliancesavg"))
        budgetvaluelist.Add(Session("Countertopsavg"))
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

    'ROOF

    Protected Sub cbxAsphaltShingle_CheckedChanged(sender As Object, e As EventArgs) Handles cbxAsphaltShingle.CheckedChanged, cbxWoodShingle.CheckedChanged, cbxMetalShingle.CheckedChanged, cbxSlateShingle.CheckedChanged, cbxTileShingle.CheckedChanged
        Page.MaintainScrollPositionOnPostBack = True
        If cbxAsphaltShingle.Checked = False Then
            pnlAsphaltShingle.Enabled = True
            pnlWoodShingle.Enabled = True
            pnlMetalShingle.Enabled = True
            pnlSlateShingle.Enabled = True
            pnlTileShingle.Enabled = True
            rltAsphaltShingle.Enabled = True
            rltWoodShingle.Enabled = True
            rltMetalShingle.Enabled = True
            rltSlateShingle.Enabled = True
            rltTileShingle.Enabled = True
        ElseIf cbxWoodShingle.Checked = False Then
            pnlAsphaltShingle.Enabled = True
            pnlWoodShingle.Enabled = True
            pnlMetalShingle.Enabled = True
            pnlSlateShingle.Enabled = True
            pnlTileShingle.Enabled = True
            rltAsphaltShingle.Enabled = True
            rltWoodShingle.Enabled = True
            rltMetalShingle.Enabled = True
            rltSlateShingle.Enabled = True
            rltTileShingle.Enabled = True
        ElseIf cbxMetalShingle.Checked = False Then
            pnlAsphaltShingle.Enabled = True
            pnlWoodShingle.Enabled = True
            pnlMetalShingle.Enabled = True
            pnlSlateShingle.Enabled = True
            pnlTileShingle.Enabled = True
            rltAsphaltShingle.Enabled = True
            rltWoodShingle.Enabled = True
            rltMetalShingle.Enabled = True
            rltSlateShingle.Enabled = True
            rltTileShingle.Enabled = True
        ElseIf cbxSlateShingle.Checked = False Then
            pnlAsphaltShingle.Enabled = True
            pnlWoodShingle.Enabled = True
            pnlMetalShingle.Enabled = True
            pnlSlateShingle.Enabled = True
            pnlTileShingle.Enabled = True
            rltAsphaltShingle.Enabled = True
            rltWoodShingle.Enabled = True
            rltMetalShingle.Enabled = True
            rltSlateShingle.Enabled = True
            rltTileShingle.Enabled = True
        ElseIf cbxTileShingle.Checked = False Then
            pnlAsphaltShingle.Enabled = True
            pnlWoodShingle.Enabled = True
            pnlMetalShingle.Enabled = True
            pnlSlateShingle.Enabled = True
            pnlTileShingle.Enabled = True
            rltAsphaltShingle.Enabled = True
            rltWoodShingle.Enabled = True
            rltMetalShingle.Enabled = True
            rltSlateShingle.Enabled = True
            rltTileShingle.Enabled = True
        End If

        If cbxAsphaltShingle.Checked = True Then
            pnlWoodShingle.Enabled = False
            pnlMetalShingle.Enabled = False
            pnlSlateShingle.Enabled = False
            pnlTileShingle.Enabled = False
            rltAsphaltShingle.Enabled = False
            rltAsphaltShingle.ClearSelection()
            rltWoodShingle.ClearSelection()
            rltMetalShingle.ClearSelection()
            rltSlateShingle.ClearSelection()
            rltTileShingle.ClearSelection()
        ElseIf cbxWoodShingle.Checked = True Then
            pnlAsphaltShingle.Enabled = False
            pnlSlateShingle.Enabled = False
            pnlMetalShingle.Enabled = False
            pnlTileShingle.Enabled = False
            rltWoodShingle.Enabled = False
            rltAsphaltShingle.ClearSelection()
            rltWoodShingle.ClearSelection()
            rltMetalShingle.ClearSelection()
            rltSlateShingle.ClearSelection()
            rltTileShingle.ClearSelection()
        ElseIf cbxMetalShingle.Checked = True Then
            pnlAsphaltShingle.Enabled = False
            pnlWoodShingle.Enabled = False
            pnlSlateShingle.Enabled = False
            pnlTileShingle.Enabled = False
            rltMetalShingle.Enabled = False
            rltAsphaltShingle.ClearSelection()
            rltWoodShingle.ClearSelection()
            rltMetalShingle.ClearSelection()
            rltSlateShingle.ClearSelection()
            rltTileShingle.ClearSelection()
        ElseIf cbxSlateShingle.Checked = True Then
            pnlAsphaltShingle.Enabled = False
            pnlWoodShingle.Enabled = False
            pnlMetalShingle.Enabled = False
            pnlTileShingle.Enabled = False
            rltSlateShingle.Enabled = False
            rltAsphaltShingle.ClearSelection()
            rltWoodShingle.ClearSelection()
            rltMetalShingle.ClearSelection()
            rltSlateShingle.ClearSelection()
            rltTileShingle.ClearSelection()
        ElseIf cbxTileShingle.Checked = True Then
            pnlTileShingle.Enabled = True
            pnlAsphaltShingle.Enabled = False
            pnlWoodShingle.Enabled = False
            pnlMetalShingle.Enabled = False
            pnlSlateShingle.Enabled = False
            rltTileShingle.Enabled = False
            rltAsphaltShingle.ClearSelection()
            rltWoodShingle.ClearSelection()
            rltMetalShingle.ClearSelection()
            rltSlateShingle.ClearSelection()
            rltTileShingle.ClearSelection()
        End If
    End Sub

    'GARAGE

    Protected Sub cbxOneCar_CheckedChanged(sender As Object, e As EventArgs) Handles cbxOneCar.CheckedChanged, cbxTwoCar.CheckedChanged, cbxThreeCar.CheckedChanged
        Page.MaintainScrollPositionOnPostBack = True
        If cbxOneCar.Checked = False Then
            pnlOneCar.Enabled = True
            pnlTwoCar.Enabled = True
            pnlThreeCar.Enabled = True
            rltOneCar.Enabled = True
            rltTwoCar.Enabled = True
            rltThreeCar.Enabled = True
        ElseIf cbxTwoCar.Checked = False Then
            pnlOneCar.Enabled = True
            pnlTwoCar.Enabled = True
            pnlThreeCar.Enabled = True
            rltOneCar.Enabled = True
            rltTwoCar.Enabled = True
            rltThreeCar.Enabled = True
        ElseIf cbxThreeCar.Checked = False Then
            pnlOneCar.Enabled = True
            pnlTwoCar.Enabled = True
            pnlThreeCar.Enabled = True
            rltOneCar.Enabled = True
            rltTwoCar.Enabled = True
            rltThreeCar.Enabled = True
        End If

        If cbxOneCar.Checked = True Then
            pnlTwoCar.Enabled = False
            pnlThreeCar.Enabled = False
            rltOneCar.Enabled = False
            rltOneCar.ClearSelection()
            rltTwoCar.ClearSelection()
            rltThreeCar.ClearSelection()
        ElseIf cbxTwoCar.Checked = True Then
            pnlOneCar.Enabled = False
            pnlThreeCar.Enabled = False
            rltTwoCar.Enabled = False
            rltOneCar.ClearSelection()
            rltTwoCar.ClearSelection()
            rltThreeCar.ClearSelection()
        ElseIf cbxThreeCar.Checked = True Then
            pnlTwoCar.Enabled = False
            pnlOneCar.Enabled = False
            rltThreeCar.Enabled = False
            rltOneCar.ClearSelection()
            rltTwoCar.ClearSelection()
            rltThreeCar.ClearSelection()
        End If
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim remainderbudget As Double = Session("myRemainderBudget")
        Dim budget As Double = Session("Budget")
        lblBudget.Text = "$ " & Convert.ToString(remainderbudget) & " left in your budget"
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

End Class
