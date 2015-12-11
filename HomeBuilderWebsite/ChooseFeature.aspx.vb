Imports System.Web.UI.DataVisualization.Charting
Imports System.Data

Partial Class ChooseFeature
    Inherits Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim myHome As HomeLayouts = Session("SelectedHome")
        Dim remainderbudget As Double = Session("Budget") - myHome.Price
        Session("myRemainderBudget") = remainderbudget
        Dim budget As Double = Session("Budget")
        lblBudget.Text = "$ " & Convert.ToString(remainderbudget) & " left in your budget"
        Dim percentbudgetused As Double = (budget - remainderbudget) / budget
        Math.Round(percentbudgetused)
        If percentbudgetused <= 0.5 Then
            tblBar.Rows.Item(0).Cells.Item(0).BackColor = Drawing.Color.Green
        ElseIf percentbudgetused > 0.5 And percentbudgetused < 0.8 Then
            tblBar.Rows.Item(0).Cells.Item(0).BackColor = Drawing.Color.Orange
        ElseIf percentbudgetused >= 0.8 Then
            tblBar.Rows.Item(0).Cells.Item(0).BackColor = Drawing.Color.Red
        End If
        tblBar.Rows.Item(0).Cells.Item(0).Width = 200 * percentbudgetused
        lblpercent.Text = Convert.ToString(Math.Round(100 * percentbudgetused)) & " % of your budget is spent"

        Dim budgetitemlist As New ArrayList
        budgetitemlist.Add("Roof")
        budgetitemlist.Add("Garage")
        budgetitemlist.Add("Landscape")
        budgetitemlist.Add("Flooring")
        budgetitemlist.Add("Fireplace")
        budgetitemlist.Add("Appliances")
        budgetitemlist.Add("Countertops")
        budgetitemlist.Add("Cabinets")
        budgetitemlist.Add("Bathrooms")
        budgetitemlist.Add("Closets")
        budgetitemlist.Add("Remaining Budget")
        Session("xvaluespie") = budgetitemlist

        Session("Roofavg") = 0
        Session("Flooringavg") = 0
        Session("Garageavg") = 0
        Session("Landscapeavg") = 0
        Session("Fireplaceavg") = 0
        Session("Appliancesavg") = 0
        Session("Countertopsavg") = 0
        Session("Cabinetsavg") = 0
        Session("Bathroomsavg") = 0
        Session("Closetsavg") = 0

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
        budgetvaluelist.Add(Session("myRemainderBudget"))
        Session("yvaluespie") = budgetvaluelist

    End Sub

    Protected Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim myFeatureList As New FeatureSet(Session("FeatureSet"))

        myFeatureList.GetFeature("Roof_Type").Rating = Convert.ToInt32(ddlRoof.SelectedValue)
        myFeatureList.GetFeature("Floors").Rating = Convert.ToInt32(ddlFloor.SelectedValue)
        myFeatureList.GetFeature("Landscaping").Rating = Convert.ToInt32(ddlLandscaping.SelectedValue)
        myFeatureList.GetFeature("Appliances").Rating = Convert.ToInt32(ddlAppliances.SelectedValue)
        myFeatureList.GetFeature("Garage").Rating = Convert.ToInt32(ddlGarage.SelectedValue)
        myFeatureList.GetFeature("Countertops").Rating = Convert.ToInt32(ddlCountertops.SelectedValue)
        myFeatureList.GetFeature("Cabinets").Rating = Convert.ToInt32(ddlCabinets.SelectedValue)
        myFeatureList.GetFeature("Bath").Rating = Convert.ToInt32(ddlBath.SelectedValue)
        myFeatureList.GetFeature("Closets").Rating = Convert.ToInt32(ddlClosets.SelectedValue)
        myFeatureList.GetFeature("Fireplace").Rating = Convert.ToInt32(ddlFireplace.SelectedValue)

        Response.Redirect("FEOutdoor.aspx")
    End Sub
End Class
