
Partial Class FEBedroom
    Inherits System.Web.UI.Page
    'Private myFeatureList As New List(Of Options)

    Protected Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim outdoor As Integer = Session("myoutdoor")
        Dim kitchen As Integer = Session("mykitchen")
        Dim bedroom As Integer = 0
        Dim interior As Integer = Session("myinterior")
        Session("mybedroom") = bedroom

        'myFeatureList = Session(myFeatures)

        '    'BATH

        '    If cbxBathShower.Checked = True Then
        '        myFeatureList.GetName("Bath/BathShower Combination").Need = True
        '    Else
        '        myFeatureList.GetName("Bath/BathShower Combination").Preference = rltBathShower.SelectedValue
        '    End If

        '    If cbxWalkinShower.Checked = True Then
        '        myFeatureList.GetName("Walk-in-Shower").Need = True
        '    Else
        '        myFeatureList.GetName("Walk-in-Shower").Preference = rltWalkinShower.SelectedValue
        '    End If

        '    If cbxRainfall.Checked = True Then
        '        myFeatureList.GetName("Luxury rainfall shower").Need = True
        '    Else
        '        myFeatureList.GetName("Luxury rainfall shower").Preference = rltRainfall.SelectedValue
        '    End If

        '    'CLOSET

        '    If cbxWardrobe.Checked = True Then
        '        myFeatureList.GetName("Wardrobe Closet").Need = True
        '    Else
        '        myFeatureList.GetName("Wardrobe Closet").Preference = rltWardrobe.SelectedValue
        '    End If

        '    If cbxWalkinCloset.Checked = True Then
        '        myFeatureList.GetName("Walk-in Closet").Need = True
        '    Else
        '        myFeatureList.GetName("Walk-in Closet").Preference = rltWalkinCloset.SelectedValue
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
