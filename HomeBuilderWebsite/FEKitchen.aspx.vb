
Partial Class FEKitchen
    Inherits System.Web.UI.Page
    'Private myFeatureList As New List(Of Options)

    Protected Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim outdoor As Integer = Session("myoutdoor")
        Dim kitchen As Integer = 0
        Dim bedroom As Integer = Session("mybedroom")
        Dim interior As Integer = Session("myinterior")
        Session("mykitchen") = kitchen

        'myFeatureList = Session(myFeatures)

        '    'APPLIANCES

        '    If cbxStandardBeige.Checked = True Then
        '        myFeatureList.GetName("Standard Beige").Need = True
        '    Else
        '        myFeatureList.GetName("Standard Beige").Preference = rltStandardBeige.SelectedValue
        '    End If

        '    If cbxBlack.Checked = True Then
        '        myFeatureList.GetName("Black").Need = True
        '    Else
        '        myFeatureList.GetName("Black").Preference = rltBlack.SelectedValue
        '    End If

        '    If cbxStainlessSteel.Checked = True Then
        '        myFeatureList.GetName("Stainless Steel").Need = True
        '    Else
        '        myFeatureList.GetName("Stainless Steel").Preference = rltStainlessSteel.SelectedValue
        '    End If

        '    If cbxProfessional.Checked = True Then
        '        myFeatureList.GetName("Professional Grade").Need = True
        '    Else
        '        myFeatureList.GetName("Professional Grade").Preference = rltProfessional.SelectedValue
        '    End If

        '    'COUNTERTOPS

        '    If cbxQuartz.Checked = True Then
        '        myFeatureList.GetName("Quartz").Need = True
        '    Else
        '        myFeatureList.GetName("Quartz").Preference = rltQuartz.SelectedValue
        '    End If

        '    If cbxGranite.Checked = True Then
        '        myFeatureList.GetName("Granite").Need = True
        '    Else
        '        myFeatureList.GetName("Granite").Preference = rltGranite.SelectedValue
        '    End If

        '    If cbxLaminate.Checked = True Then
        '        myFeatureList.GetName("Laminate").Need = True
        '    Else
        '        myFeatureList.GetName("Laminate").Preference = rltLaminate.SelectedValue
        '    End If

        '    If cbxWood.Checked = True Then
        '        myFeatureList.GetName("Wood").Need = True
        '    Else
        '        myFeatureList.GetName("Wood").Preference = rltWood.SelectedValue
        '    End If

        '    If cbxMarble.Checked = True Then
        '        myFeatureList.GetName("Marble").Need = True
        '    Else
        '        myFeatureList.GetName("Marble").Preference = rltMarble.SelectedValue
        '    End If

        If (outdoor > kitchen) And (outdoor > bedroom) And (outdoor > interior) Then
            Response.Redirect("FEOutdoor.aspx")
        ElseIf (kitchen > outdoor) And (kitchen > bedroom) And (kitchen > interior) Then
            Response.Redirect("FEKitchen.aspx")
        ElseIf (bedroom > outdoor) And (bedroom > kitchen) And (bedroom > interior) Then
            Response.Redirect("FEBedroom.aspx")
        ElseIf (interior > outdoor) And (interior > bedroom) And (interior > kitchen) Then
            Response.Redirect("FEInterior.aspx")
        End If
    End Sub
End Class
