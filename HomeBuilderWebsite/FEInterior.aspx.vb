
Partial Class FEInterior
    Inherits System.Web.UI.Page
    'Private myFeatureList As New List(Of Options)

    Protected Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim outdoor As Integer = Session("myoutdoor")
        Dim kitchen As Integer = Session("mykitchen")
        Dim bedroom As Integer = Session("mybedroom")
        Dim interior As Integer = 0
        Session("myinterior") = interior

        'myFeatureList = Session(myFeatures)

        'FLOORING

        '    If cbxCarpet.Checked = True Then
        '        myFeatureList.GetName("Carpet").Need = True
        '    Else
        '        myFeatureList.GetName("Carpet").Preference = rltCarpet.SelectedValue
        '    End If

        '    If cbxTile.Checked = True Then
        '        myFeatureList.GetName("Tile").Need = True
        '    Else
        '        myFeatureList.GetName("Tile").Preference = rltTile.SelectedValue
        '    End If

        '    If cbxHardwood.Checked = True Then
        '        myFeatureList.GetName("Hardwood").Need = True
        '    Else
        '        myFeatureList.GetName("Hardwood").Preference = rltHardwood.SelectedValue
        '    End If

        '    If cbxTileShingle.Checked = True Then
        '        myFeatureList.GetName("Tile Shingle").Need = True
        '    Else
        '        myFeatureList.GetName("Tile Shingle").Preference = rltTileShingle.SelectedValue
        '    End If

        '    'FIREPLACE

        '    If cbxBrick.Checked = True Then
        '        myFeatureList.GetName("Brick Fireplace").Need = True
        '    Else
        '        myFeatureList.GetName("Brick Fireplace").Preference = rltBrick.SelectedValue
        '    End If

        '    If cbxManufactured.Checked = True Then
        '        myFeatureList.GetName("Manufactured Stone Fireplace").Need = True
        '    Else
        '        myFeatureList.GetName("Manufactured Stone Fireplace").Preference = rltManufactured.SelectedValue
        '    End If

        '    If cbxNatural.Checked = True Then
        '        myFeatureList.GetName("Natural Stone Fireplace").Need = True
        '    Else
        '        myFeatureList.GetName("Natural Stone Fireplace").Preference = rltNatural.SelectedValue
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
