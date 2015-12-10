Imports System.Web.UI.DataVisualization.Charting
Partial Class FEInterior
    Inherits System.Web.UI.Page



    Protected Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim myOptionList As New optionSet(Session("OptionSet"))

        'FLOORING

        If cbxCarpet.Checked = True Then
            myOptionList.GetName("Carpet").Need = True
        Else
            myOptionList.GetName("Carpet").Preference = rltCarpet.SelectedValue
        End If

        If cbxTile.Checked = True Then
            myOptionList.GetName("Tile").Need = True
        Else
            myOptionList.GetName("Tile").Preference = rltTile.SelectedValue
        End If

        If cbxHardwood.Checked = True Then
            myOptionList.GetName("Hardwood").Need = True
        Else
            myOptionList.GetName("Hardwood").Preference = rltHardwood.SelectedValue
        End If

        'FIREPLACE

        If cbxBrick.Checked = True Then
            myOptionList.GetName("Brick Fireplace").Need = True
        Else
            myOptionList.GetName("Brick Fireplace").Preference = rltBrick.SelectedValue
        End If

        If cbxManufactured.Checked = True Then
            myOptionList.GetName("Manufactured Stone Fireplace").Need = True
        Else
            myOptionList.GetName("Manufactured Stone Fireplace").Preference = rltManufactured.SelectedValue
        End If

        If cbxNatural.Checked = True Then
            myOptionList.GetName("Natural Stone Fireplace").Need = True
        Else
            myOptionList.GetName("Natural Stone Fireplace").Preference = rltNatural.SelectedValue
        End If

        'Dim myHome As HomeLayouts = Session("SelectedHome")


        'FLOOR
        Dim carpetPrice As Double = myOptionList.GetName("Carpet").getoptionprice
        Dim tilePrice As Double = myOptionList.GetName("Tile").getoptionprice
        Dim hardwoodPrice As Double = myOptionList.GetName("Hardwood").getoptionprice

        Dim carpetRating As Integer = myOptionList.GetName("Carpet").Preference
        Dim tileRating As Integer = myOptionList.GetName("Tile").Preference
        Dim hardwoodRating As Integer = myOptionList.GetName("Hardwood").Preference

        'FIREPLACE
        Dim brickPrice As Double = myOptionList.GetName("Brick Fireplace").getoptionprice
        Dim manPrice As Double = myOptionList.GetName("Manufactured Stone Fireplace").getoptionprice
        Dim natPrice As Double = myOptionList.GetName("Natural Stone Fireplace").getoptionprice

        Dim brickRating As Integer = myOptionList.GetName("Brick Fireplace").Preference
        Dim manRating As Integer = myOptionList.GetName("Manufactured Stone Fireplace").Preference
        Dim natRating As Integer = myOptionList.GetName("Natural Stone Fireplace").Preference

        Dim flooravg As Double = AvgPrice(carpetPrice, tilePrice, hardwoodPrice, 0, 0, carpetRating, tileRating, hardwoodRating, 0, 0)
        Dim fireplaceavg As Double = AvgPrice(brickPrice, manPrice, natPrice, 0, 0, brickRating, manRating, natRating, 0, 0)

        Dim remainderbudget As Double = Session("myRemainderBudget")
        Session("myRemainderBudget") = remainderbudget - (flooravg + fireplaceavg)

        Session("Flooringavg") = flooravg
        Session("Fireplaceavg") = fireplaceavg

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



        Response.Redirect("FEKitchen.aspx")
    End Sub

    'FLOORS

    Protected Sub cbxCarpet_CheckedChanged(sender As Object, e As EventArgs) Handles cbxCarpet.CheckedChanged, cbxTile.CheckedChanged, cbxHardwood.CheckedChanged
        If cbxCarpet.Checked = False Then
            pnlCarpet.Enabled = True
            pnlTile.Enabled = True
            pnlHardwood.Enabled = True
            rltCarpet.Enabled = True
            rltTile.Enabled = True
            rltHardwood.Enabled = True
        ElseIf cbxTile.Checked = False Then
            pnlCarpet.Enabled = True
            pnlTile.Enabled = True
            pnlHardwood.Enabled = True
            rltCarpet.Enabled = True
            rltTile.Enabled = True
            rltHardwood.Enabled = True
        ElseIf cbxHardwood.Checked = False Then
            pnlCarpet.Enabled = True
            pnlTile.Enabled = True
            pnlHardwood.Enabled = True
            rltCarpet.Enabled = True
            rltTile.Enabled = True
            rltHardwood.Enabled = True
        End If

        If cbxCarpet.Checked = True Then
            pnlTile.Enabled = False
            pnlHardwood.Enabled = False
            rltCarpet.Enabled = False
            rltCarpet.ClearSelection()
            rltTile.ClearSelection()
            rltHardwood.ClearSelection()
        ElseIf cbxTile.Checked = True Then
            pnlCarpet.Enabled = False
            pnlHardwood.Enabled = False
            rltTile.Enabled = False
            rltCarpet.ClearSelection()
            rltTile.ClearSelection()
            rltHardwood.ClearSelection()
        ElseIf cbxHardwood.Checked = True Then
            pnlCarpet.Enabled = False
            pnlTile.Enabled = False
            rltHardwood.Enabled = False
            rltCarpet.ClearSelection()
            rltTile.ClearSelection()
            rltHardwood.ClearSelection()
        End If
    End Sub

    'FIREPLACE

    Protected Sub cbxBrick_CheckedChanged(sender As Object, e As EventArgs) Handles cbxBrick.CheckedChanged, cbxManufactured.CheckedChanged, cbxNatural.CheckedChanged
        If cbxBrick.Checked = False Then
            pnlBrick.Enabled = True
            pnlManufactured.Enabled = True
            pnlNatural.Enabled = True
            rltBrick.Enabled = True
            rltManufactured.Enabled = True
            rltNatural.Enabled = True
        ElseIf cbxManufactured.Checked = False Then
            pnlBrick.Enabled = True
            pnlManufactured.Enabled = True
            pnlNatural.Enabled = True
            rltBrick.Enabled = True
            rltManufactured.Enabled = True
            rltNatural.Enabled = True
        ElseIf cbxNatural.Checked = False Then
            pnlBrick.Enabled = True
            pnlManufactured.Enabled = True
            pnlNatural.Enabled = True
            rltBrick.Enabled = True
            rltManufactured.Enabled = True
            rltNatural.Enabled = True
        End If

        If cbxBrick.Checked = True Then
            pnlManufactured.Enabled = False
            pnlNatural.Enabled = False
            rltBrick.Enabled = False
            rltBrick.ClearSelection()
            rltManufactured.ClearSelection()
            rltNatural.ClearSelection()
        ElseIf cbxManufactured.Checked = True Then
            pnlBrick.Enabled = False
            pnlNatural.Enabled = False
            rltManufactured.Enabled = False
            rltBrick.ClearSelection()
            rltManufactured.ClearSelection()
            rltNatural.ClearSelection()
        ElseIf cbxNatural.Checked = True Then
            pnlManufactured.Enabled = False
            pnlBrick.Enabled = False
            rltNatural.Enabled = False
            rltBrick.ClearSelection()
            rltManufactured.ClearSelection()
            rltNatural.ClearSelection()
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
