Imports System.Web.UI.DataVisualization.Charting

Partial Class FEKitchen
    Inherits System.Web.UI.Page

    Protected Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim myOptionList As New optionSet(Session("OptionSet"))

        'APPLIANCES

            myOptionList.GetName("Standard Beige").Preference = rltStandardBeige.SelectedValue
            myOptionList.GetName("Black").Preference = rltBlack.SelectedValue
            myOptionList.GetName("Stainless Steel").Preference = rltStainlessSteel.SelectedValue
            myOptionList.GetName("Professional Grade").Preference = rltProfessional.SelectedValue

        'COUNTERTOPS

            myOptionList.GetName("Quartz").Preference = rltQuartz.SelectedValue
            myOptionList.GetName("Laminate").Preference = rltLaminate.SelectedValue
            myOptionList.GetName("Wood").Preference = rltWood.SelectedValue
            myOptionList.GetName("Marble").Preference = rltMarble.SelectedValue

        'CABINETS

            myOptionList.GetName("Formica").Preference = rltFormica.SelectedValue
            myOptionList.GetName("Maple").Preference = rltMaple.SelectedValue
            myOptionList.GetName("Metal").Preference = rltMetal.SelectedValue


        'APPLIANCES
        Dim beigePrice As Double = myOptionList.GetName("Standard Beige").getoptionprice
        Dim blackPrice As Double = myOptionList.GetName("Black").getoptionprice
        Dim stainPrice As Double = myOptionList.GetName("Stainless Steel").getoptionprice
        Dim profPrice As Double = myOptionList.GetName("Professional Grade").getoptionprice

        Dim beigeRating As Integer = myOptionList.GetName("Standard Beige").Preference
        Dim blackRating As Integer = myOptionList.GetName("Black").Preference
        Dim stainRating As Integer = myOptionList.GetName("Stainless Steel").Preference
        Dim profRating As Double = myOptionList.GetName("Professional Grade").getoptionprice

        'COUNTERTOPS
        Dim quartzPrice As Double = myOptionList.GetName("Quartz").getoptionprice
        Dim granitePrice As Double = myOptionList.GetName("Granite").getoptionprice
        Dim laminatePrice As Double = myOptionList.GetName("Laminate").getoptionprice
        Dim woodPrice As Double = myOptionList.GetName("Wood").getoptionprice
        Dim marblePrice As Double = myOptionList.GetName("Marble").getoptionprice

        Dim quartzRating As Integer = myOptionList.GetName("Quartz").Preference
        Dim graniteRating As Integer = myOptionList.GetName("Granite").Preference
        Dim laminateRating As Integer = myOptionList.GetName("Laminate").Preference
        Dim woodRating As Integer = myOptionList.GetName("Wood").Preference
        Dim marbleRating As Integer = myOptionList.GetName("Marble").Preference

        'CABINETS
        Dim formicaPrice As Double = myOptionList.GetName("Formica").getoptionprice
        Dim maplePrice As Double = myOptionList.GetName("Maple").getoptionprice
        Dim metalPrice As Double = myOptionList.GetName("Metal").getoptionprice

        Dim formicaRating As Integer = myOptionList.GetName("Formica").Preference
        Dim mapleRating As Integer = myOptionList.GetName("Maple").Preference
        Dim metalRating As Integer = myOptionList.GetName("Metal").Preference

        Dim counteropsavg As Double = AvgPrice(beigePrice, blackPrice, stainPrice, profPrice, 0, beigeRating, blackRating, stainPrice, profRating, 0)
        Dim appliancesavg As Double = AvgPrice(quartzPrice, granitePrice, laminatePrice, woodPrice, marblePrice, quartzRating, graniteRating, laminateRating, woodRating, marbleRating)
        Dim cabinetsavg As Double = AvgPrice(formicaPrice, maplePrice, metalPrice, 0, 0, formicaRating, mapleRating, metalPrice, 0, 0)

        Dim remainderbudget As Double = Session("myRemainderBudget")
        Session("myRemainderBudget") = remainderbudget - (counteropsavg + appliancesavg + cabinetsavg)

        Session("Appliancesavg") = appliancesavg
        Session("Countertopsavg") = counteropsavg
        Session("Cabinetsavg") = cabinetsavg

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

        Response.Redirect("FEBedroom.aspx")
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
        Response.Redirect("FEInterior.aspx")
    End Sub
End Class
