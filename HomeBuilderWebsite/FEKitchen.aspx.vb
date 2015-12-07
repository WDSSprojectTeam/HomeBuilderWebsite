
Partial Class FEKitchen
    Inherits System.Web.UI.Page

    'Private myOptionList As New List(Of Options)

    Protected Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'myOptionList = Session("myOptions")

        '    'APPLIANCES

        '    If cbxStandardBeige.Checked = True Then
        '        myOptionList.GetName("Standard Beige").Need = True
        '    Else
        '        myOptionList.GetName("Standard Beige").Preference = rltStandardBeige.SelectedValue
        '    End If

        '    If cbxBlack.Checked = True Then
        '        myOptionList.GetName("Black").Need = True
        '    Else
        '        myOptionList.GetName("Black").Preference = rltBlack.SelectedValue
        '    End If

        '    If cbxStainlessSteel.Checked = True Then
        '        myOptionList.GetName("Stainless Steel").Need = True
        '    Else
        '        myOptionList.GetName("Stainless Steel").Preference = rltStainlessSteel.SelectedValue
        '    End If

        '    If cbxProfessional.Checked = True Then
        '        myOptionList.GetName("Professional Grade").Need = True
        '    Else
        '        myOptionList.GetName("Professional Grade").Preference = rltProfessional.SelectedValue
        '    End If

        '    'COUNTERTOPS

        '    If cbxQuartz.Checked = True Then
        '        myOptionListt.GetName("Quartz").Need = True
        '    Else
        '        myOptionList.GetName("Quartz").Preference = rltQuartz.SelectedValue
        '    End If

        '    If cbxGranite.Checked = True Then
        '        myOptionList.GetName("Granite").Need = True
        '    Else
        '        myOptionList.GetName("Granite").Preference = rltGranite.SelectedValue
        '    End If

        '    If cbxLaminate.Checked = True Then
        '        myOptionList.GetName("Laminate").Need = True
        '    Else
        '        myOptionList.GetName("Laminate").Preference = rltLaminate.SelectedValue
        '    End If

        '    If cbxWood.Checked = True Then
        '        myOptionList.GetName("Wood").Need = True
        '    Else
        '        myOptionList.GetName("Wood").Preference = rltWood.SelectedValue
        '    End If

        '    If cbxMarble.Checked = True Then
        '        myOptionList.GetName("Marble").Need = True
        '    Else
        '        myOptionList.GetName("Marble").Preference = rltMarble.SelectedValue
        '    End If

        ''APPLIANCES
        'Dim beigePrice As Double = myOptionList.GetName("Standard Beige").getoptionprice
        'Dim blackPrice As Double = myOptionList.GetName("Black").getoptionprice
        'Dim stainPrice As Double = myOptionList.GetName("Stainless Steel").getoptionprice
        'Dim profPrice As Double = myOptionList.GetName("Professional Grader").getoptionprice

        'Dim beigeRating As Integer = myOptionList.GetName("Standard Beige").Preference
        'Dim blackRating As Integer = myOptionList.GetName("Black").Preference
        'Dim stainRating As Integer = myOptionList.GetName("Stainless Steel").Preference
        'Dim profRating As Double = myOptionList.GetName("Professional Grade").getoptionprice

        ''COUNTERTOPS
        'Dim quartzPrice As Double = myOptionList.GetName("Quartz").getoptionprice
        'Dim granitePrice As Double = myOptionList.GetName("Granite").getoptionprice
        'Dim laminatePrice As Double = myOptionList.GetName("Laminate").getoptionprice
        'Dim woodPrice As Double = myOptionList.GetName("Wood").getoptionprice
        'Dim marblePrice As Double = myOptionList.GetName("Marble").getoptionprice

        'Dim quartzRating As Integer = myOptionList.GetName("Quartz").Preference
        'Dim graniteRating As Integer = myOptionList.GetName("Granite").Preference
        'Dim laminateRating As Integer = myOptionList.GetName("Laminate").Preference
        'Dim woodRating As Integer = myOptionList.GetName("Wood").Preference
        'Dim marbleRating As Integer = myOptionList.GetName("Marble").Preference

        'Dim counteropsavg As Double = AvgPrice(beigePrice, blackPrice, stainPrice, profPrice, 0, beigeRating, blackRating, stainPrice, profRating, 0)
        'Dim appliancesavg As Double = AvgPrice(quartzPrice, granitePrice, laminatePrice, woodPrice, marblePrice, quartzRating, graniteRating, laminateRating, woodRating, marbleRating)

        'Dim remainderbudget As Double = Session("myRemainderBudget")
        'Session("myRemainderBudget") = remainderbudget - (counteropsavg + appliancesavg)

        Response.Redirect("FEBedroom.aspx")
    End Sub

    'APPLIANCES

    Protected Sub cbxStandardBeige_CheckedChanged(sender As Object, e As EventArgs) Handles cbxStandardBeige.CheckedChanged, cbxBlack.CheckedChanged, cbxStainlessSteel.CheckedChanged, cbxProfessional.CheckedChanged
        Page.MaintainScrollPositionOnPostBack = True
        If cbxStandardBeige.Checked = False Then
            pnlStandardBeige.Enabled = True
            pnlBlack.Enabled = True
            pnlStainlessSteel.Enabled = True
            pnlProfessional.Enabled = True
            rltStandardBeige.Enabled = True
            rltBlack.Enabled = True
            rltStainlessSteel.Enabled = True
            rltProfessional.Enabled = True
        ElseIf cbxBlack.Checked = False Then
            pnlStandardBeige.Enabled = True
            pnlBlack.Enabled = True
            pnlStainlessSteel.Enabled = True
            pnlProfessional.Enabled = True
            rltStandardBeige.Enabled = True
            rltBlack.Enabled = True
            rltStainlessSteel.Enabled = True
            rltProfessional.Enabled = True
        ElseIf cbxStainlessSteel.Checked = False Then
            pnlStandardBeige.Enabled = True
            pnlBlack.Enabled = True
            pnlStainlessSteel.Enabled = True
            pnlProfessional.Enabled = True
            rltStandardBeige.Enabled = True
            rltBlack.Enabled = True
            rltStainlessSteel.Enabled = True
            rltProfessional.Enabled = True
        ElseIf cbxProfessional.Checked = False Then
            pnlStandardBeige.Enabled = True
            pnlBlack.Enabled = True
            pnlStainlessSteel.Enabled = True
            pnlProfessional.Enabled = True
            rltStandardBeige.Enabled = True
            rltBlack.Enabled = True
            rltStainlessSteel.Enabled = True
            rltProfessional.Enabled = True
        End If

        If cbxStandardBeige.Checked = True Then
            pnlProfessional.Enabled = False
            pnlBlack.Enabled = False
            pnlStainlessSteel.Enabled = False
            rltStandardBeige.Enabled = False
            rltStandardBeige.ClearSelection()
            rltBlack.ClearSelection()
            rltStainlessSteel.ClearSelection()
            rltProfessional.ClearSelection()
        ElseIf cbxBlack.Checked = True Then
            pnlProfessional.Enabled = False
            pnlStandardBeige.Enabled = False
            pnlStainlessSteel.Enabled = False
            rltBlack.Enabled = False
            rltStandardBeige.ClearSelection()
            rltBlack.ClearSelection()
            rltStainlessSteel.ClearSelection()
            rltProfessional.ClearSelection()
        ElseIf cbxStainlessSteel.Checked = True Then
            pnlProfessional.Enabled = False
            pnlBlack.Enabled = False
            pnlStandardBeige.Enabled = False
            rltStainlessSteel.Enabled = False
            rltStandardBeige.ClearSelection()
            rltBlack.ClearSelection()
            rltStainlessSteel.ClearSelection()
            rltProfessional.ClearSelection()
        ElseIf cbxProfessional.Checked = True Then
            pnlStandardBeige.Enabled = False
            pnlBlack.Enabled = False
            pnlStainlessSteel.Enabled = False
            rltProfessional.Enabled = False
            rltStandardBeige.ClearSelection()
            rltBlack.ClearSelection()
            rltStainlessSteel.ClearSelection()
            rltProfessional.ClearSelection()
        End If
    End Sub

    'COUNTERTOPS

    Protected Sub cbxGranite_CheckedChanged(sender As Object, e As EventArgs) Handles cbxGranite.CheckedChanged, cbxQuartz.CheckedChanged, cbxLaminate.CheckedChanged, cbxMarble.CheckedChanged, cbxWood.CheckedChanged
        Page.MaintainScrollPositionOnPostBack = True
        If cbxQuartz.Checked = False Then
            pnlQuartz.Enabled = True
            PanelGranite.Enabled = True
            PanelLaminate.Enabled = True
            PanelMarble.Enabled = True
            PanelWood.Enabled = True
            rltQuartz.Enabled = True
            rltGranite.Enabled = True
            rltLaminate.Enabled = True
            rltMarble.Enabled = True
            rltWood.Enabled = True
        ElseIf cbxGranite.Checked = False Then
            pnlQuartz.Enabled = True
            PanelGranite.Enabled = True
            PanelLaminate.Enabled = True
            PanelMarble.Enabled = True
            PanelWood.Enabled = True
            rltQuartz.Enabled = True
            rltGranite.Enabled = True
            rltLaminate.Enabled = True
            rltMarble.Enabled = True
            rltWood.Enabled = True
        ElseIf cbxLaminate.Checked = False Then
            pnlQuartz.Enabled = True
            PanelGranite.Enabled = True
            PanelLaminate.Enabled = True
            PanelMarble.Enabled = True
            PanelWood.Enabled = True
            rltQuartz.Enabled = True
            rltGranite.Enabled = True
            rltLaminate.Enabled = True
            rltMarble.Enabled = True
            rltWood.Enabled = True
        ElseIf cbxMarble.Checked = False Then
            pnlQuartz.Enabled = True
            PanelGranite.Enabled = True
            PanelLaminate.Enabled = True
            PanelMarble.Enabled = True
            PanelWood.Enabled = True
            rltQuartz.Enabled = True
            rltGranite.Enabled = True
            rltLaminate.Enabled = True
            rltMarble.Enabled = True
            rltWood.Enabled = True
        ElseIf cbxWood.Checked = False Then
            pnlQuartz.Enabled = True
            PanelGranite.Enabled = True
            PanelLaminate.Enabled = True
            PanelMarble.Enabled = True
            PanelWood.Enabled = True
            rltQuartz.Enabled = True
            rltGranite.Enabled = True
            rltLaminate.Enabled = True
            rltMarble.Enabled = True
            rltWood.Enabled = True
        End If

        If cbxQuartz.Checked = True Then
            PanelGranite.Enabled = False
            PanelLaminate.Enabled = False
            PanelMarble.Enabled = False
            PanelWood.Enabled = False
            rltQuartz.Enabled = False
            rltQuartz.ClearSelection()
            rltGranite.ClearSelection()
            rltLaminate.ClearSelection()
            rltMarble.ClearSelection()
            rltWood.ClearSelection()
        ElseIf cbxGranite.Checked = True Then
            pnlQuartz.Enabled = False
            PanelLaminate.Enabled = False
            PanelMarble.Enabled = False
            PanelWood.Enabled = False
            rltGranite.Enabled = False
            rltQuartz.ClearSelection()
            rltGranite.ClearSelection()
            rltLaminate.ClearSelection()
            rltMarble.ClearSelection()
            rltWood.ClearSelection()
        ElseIf cbxLaminate.Checked = True Then
            pnlQuartz.Enabled = False
            PanelGranite.Enabled = False
            PanelMarble.Enabled = False
            PanelWood.Enabled = False
            rltLaminate.Enabled = False
            rltQuartz.ClearSelection()
            rltGranite.ClearSelection()
            rltLaminate.ClearSelection()
            rltMarble.ClearSelection()
            rltWood.ClearSelection()
        ElseIf cbxMarble.Checked = True Then
            pnlQuartz.Enabled = False
            PanelLaminate.Enabled = False
            PanelGranite.Enabled = False
            PanelWood.Enabled = False
            rltMarble.Enabled = False
            rltQuartz.ClearSelection()
            rltGranite.ClearSelection()
            rltLaminate.ClearSelection()
            rltMarble.ClearSelection()
            rltWood.ClearSelection()
        ElseIf cbxWood.Checked = True Then
            pnlQuartz.Enabled = False
            PanelLaminate.Enabled = False
            PanelMarble.Enabled = False
            PanelGranite.Enabled = False
            rltWood.Enabled = False
            rltQuartz.ClearSelection()
            rltGranite.ClearSelection()
            rltLaminate.ClearSelection()
            rltMarble.ClearSelection()
            rltWood.ClearSelection()
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
    End Sub

    Public Function AvgPrice(ByVal p1 As Double, ByVal p2 As Double, ByVal p3 As Double, ByVal p4 As Double, ByVal p5 As Double, ByVal r1 As Integer, ByVal r2 As Integer, ByVal r3 As Integer, ByVal r4 As Integer, ByVal r5 As Integer) As Double
        Dim weightedsum As Double = r1 * p1 + r2 * p2 + r3 * p3 + r4 * p4 + r5 * p5
        Dim ratingsum As Double = r1 + r2 + r3 + r4 + r5
        Dim weightedavg As Double = weightedsum / ratingsum
        Return weightedavg
    End Function
End Class
