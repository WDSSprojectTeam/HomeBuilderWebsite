Imports Microsoft.VisualBasic
Imports System.Web.UI.DataVisualization.Charting

Partial Class FEBedroom
    Inherits System.Web.UI.Page

    Protected Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim myOptionList As New optionSet(Session("OptionSet"))

        'BATH

        If cbxBathShower.Checked = True Then
            myOptionList.GetName("Bath/Shower Combination").Need = True
        ElseIf cbxWalkinShower.Checked = True Then
            myOptionList.GetName("Walk-in-shower").Need = True
        ElseIf cbxRainfall.Checked = True Then
            myOptionList.GetName("Luxury rainfall shower").Need = True
        Else
            myOptionList.GetName("Bath/Shower Combination").Preference = rltBathShower.SelectedValue
            myOptionList.GetName("Walk-in-shower").Preference = rltWalkinShower.SelectedValue
            myOptionList.GetName("Luxury rainfall shower").Preference = rltRainfall.SelectedValue
        End If

        'CLOSET

        If cbxWardrobe.Checked = True Then
            myOptionList.GetName("Wardrobe Closet").Need = True
        ElseIf cbxWalkinCloset.Checked = True Then
            myOptionList.GetName("Walk-in Closet").Need = True
        Else
            myOptionList.GetName("Wardrobe Closet").Preference = rltWardrobe.SelectedValue
            myOptionList.GetName("Walk-in Closet").Preference = rltWalkinCloset.SelectedValue
        End If

        'BATH
        Dim bathPrice As Double = myOptionList.GetName("Bath/Shower Combination").getoptionprice
        Dim showerPrice As Double = myOptionList.GetName("Walk-in-shower").getoptionprice
        Dim luxryPrice As Double = myOptionList.GetName("Luxury rainfall shower").getoptionprice

        Dim bathRating As Integer = myOptionList.GetName("Bath/Shower Combination").Preference
        Dim showerRating As Integer = myOptionList.GetName("Walk-in-shower").Preference
        Dim luxryRating As Integer = myOptionList.GetName("Luxury rainfall shower").Preference

        'CLOSET
        Dim wardrobePrice As Double = myOptionList.GetName("Wardrobe Closet").getoptionprice
        Dim walkPrice As Double = myOptionList.GetName("Walk-in Closet").getoptionprice

        Dim wardrobeRating As Integer = myOptionList.GetName("Wardrobe Closet").Preference
        Dim walkRating As Integer = myOptionList.GetName("Walk-in Closet").Preference

        Dim bathavg As Double = AvgPrice(bathPrice, showerPrice, luxryPrice, 0, 0, bathRating, showerRating, luxryRating, 0, 0)
        Dim closetavg As Double = AvgPrice(wardrobePrice, walkPrice, 0, 0, 0, wardrobeRating, walkRating, 0, 0, 0)

        'BATH

        If cbxBathShower.Checked = True Then
            bathavg = bathPrice
        ElseIf cbxWalkinShower.Checked = True Then
            bathavg = showerPrice
        ElseIf cbxRainfall.Checked = True Then
            bathavg = luxryPrice
        End If

        'CLOSET

        If cbxWardrobe.Checked = True Then
            closetavg = wardrobePrice
        ElseIf cbxWalkinCloset.Checked = True Then
            closetavg = walkPrice
        End If

        Dim remainderbudget As Double = Session("myRemainderBudget")
        Session("myRemainderBudget") = remainderbudget - (bathavg + closetavg)

        Session("Bathroomsavg") = bathavg
        Session("Closetsavg") = closetavg

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

        Dim myFeatureList As New List(Of Feature)
        myFeatureList = Session("FeatureSet")

        Dim OptionList As New List(Of Options)
        OptionList = Session("OptionSet")
        Session("Results") = Nothing
        For i = 1 To 9
            Dim opt As New Optimization
            opt.Solve(i)
        Next

        Response.Redirect("~\OptimizationResultsPage.aspx")
    End Sub

    'BATH

    Protected Sub cbxBathShower_CheckedChanged(sender As Object, e As EventArgs) Handles cbxBathShower.CheckedChanged, cbxWalkinShower.CheckedChanged, cbxRainfall.CheckedChanged
        If cbxBathShower.Checked = False Then
            pnlBathShower.Enabled = True
            pnlWalkinShower.Enabled = True
            pnlRainfall.Enabled = True
            rltBathShower.Enabled = True
            rltWalkinShower.Enabled = True
            rltRainfall.Enabled = True
        ElseIf cbxWalkinShower.Checked = False Then
            pnlBathShower.Enabled = True
            pnlWalkinShower.Enabled = True
            pnlRainfall.Enabled = True
            rltBathShower.Enabled = True
            rltWalkinShower.Enabled = True
            rltRainfall.Enabled = True
        ElseIf cbxRainfall.Checked = False Then
            pnlBathShower.Enabled = True
            pnlWalkinShower.Enabled = True
            pnlRainfall.Enabled = True
            rltBathShower.Enabled = True
            rltWalkinShower.Enabled = True
            rltRainfall.Enabled = True
        End If

        If cbxBathShower.Checked = True Then
            pnlWalkinShower.Enabled = False
            pnlRainfall.Enabled = False
            rltBathShower.Enabled = False
            rltBathShower.ClearSelection()
            rltWalkinShower.ClearSelection()
            rltRainfall.ClearSelection()
        ElseIf cbxWalkinShower.Checked = True Then
            pnlBathShower.Enabled = False
            pnlRainfall.Enabled = False
            rltWalkinShower.Enabled = False
            rltBathShower.ClearSelection()
            rltWalkinShower.ClearSelection()
            rltRainfall.ClearSelection()
        ElseIf cbxRainfall.Checked = True Then
            pnlWalkinShower.Enabled = False
            pnlBathShower.Enabled = False
            rltRainfall.Enabled = False
            rltBathShower.ClearSelection()
            rltWalkinShower.ClearSelection()
            rltRainfall.ClearSelection()
        End If
    End Sub

    'CLOSETS

    Protected Sub cbxWardrobe_CheckedChanged(sender As Object, e As EventArgs) Handles cbxWardrobe.CheckedChanged, cbxWalkinCloset.CheckedChanged
        If cbxWardrobe.Checked = False Then
            pnlWardrobe.Enabled = True
            pnlWalkinCloset.Enabled = True
            rltWardrobe.Enabled = True
            rltWalkinCloset.Enabled = True
        ElseIf cbxWalkinCloset.Checked = False Then
            pnlWardrobe.Enabled = True
            pnlWalkinCloset.Enabled = True
            rltWardrobe.Enabled = True
            rltWalkinCloset.Enabled = True
        End If

        If cbxWardrobe.Checked = True Then
            pnlWalkinCloset.Enabled = False
            rltWardrobe.Enabled = False
            rltWardrobe.ClearSelection()
            rltWalkinCloset.ClearSelection()
        ElseIf cbxWalkinCloset.Checked = True Then
            pnlWardrobe.Enabled = False
            rltWalkinCloset.Enabled = False
            rltWardrobe.ClearSelection()
            rltWalkinCloset.ClearSelection()
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
