
Partial Class FEOutdoor
    Inherits System.Web.UI.Page
    'Private myFeatureList As New List(Of Options)

    Protected Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim outdoor As Integer = 0
        Dim kitchen As Integer = Session("mykitchen")
        Dim bedroom As Integer = Session("mybedroom")
        Dim interior As Integer = Session("myinterior")
        Session("myoutdoor") = outdoor

        'myFeatureList = Session(myFeatures)

        '    'ROOF TYPE

        '    If cbxAsphaltShingle.Checked = True Then
        '        myFeatureList.GetName("Asphalt Shingle").Need = True
        '    Else
        '        myFeatureList.GetName("Asphalt Shingle").Preference = rltAsphaltShingle.SelectedValue
        '    End If

        '    If cbxWoodShingle.Checked = True Then
        '        myFeatureList.GetName("Wood Shingle").Need = True
        '    Else
        '        myFeatureList.GetName("Wood Shingle").Preference = rltWoodShingle.SelectedValue
        '    End If

        '    If cbxMetalShingle.Checked = True Then
        '        myFeatureList.GetName("Metal Shingle").Need = True
        '    Else
        '        myFeatureList.GetName("Metal Shingle").Preference = rltMetalShingle.SelectedValue
        '    End If

        '    If cbxSlateShingle.Checked = True Then
        '        myFeatureList.GetName("Slate Shingle").Need = True
        '    Else
        '        myFeatureList.GetName("Slate Shingle").Preference = rltSlateShingle.SelectedValue
        '    End If

        '    'GARAGE

        '    If cbxOneCar.Checked = True Then
        '        myFeatureList.GetName("One Car").Need = True
        '    Else
        '        myFeatureList.GetName("One Car").Preference = rltOneCar.SelectedValue
        '    End If

        '    If cbxTwoCar.Checked = True Then
        '        myFeatureList.GetName("Two Car").Need = True
        '    Else
        '        myFeatureList.GetName("Two Car").Preference = rltTwoCar.SelectedValue
        '    End If

        '    If cbxThreeCar.Checked = True Then
        '        myFeatureList.GetName("Three Car").Need = True
        '    Else
        '        myFeatureList.GetName("Three Car").Preference = rltThreeCar.SelectedValue
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
