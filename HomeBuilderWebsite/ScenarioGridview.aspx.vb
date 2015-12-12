
Imports System.Data

Partial Class ScenarioGridview
    Inherits System.Web.UI.Page


    Private myDataLoader As New DataLoader

    Private Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If (Not IsPostBack) Then
            Dim index As Integer = 0
            Dim DAL As New DataLoader
            DAL.LoadHomesLayouts()
            DAL.LoadOptions()
            DAL.LoadFeatures()
            Dim myTable As DataTable = DAL.GetTemplateDetails()
            Session("myTable") = myTable
            Dim homeID As Integer = myTable.Rows(index).Item(1)
            Dim homeList As List(Of HomeLayouts) = Session("homeSet")

            Dim myOptionList As List(Of Options) = Session("OptionSet")

            Dim displayList As New DataTable
            displayList.Columns.Add("TempID")
            displayList.Columns.Add("TempName")
            displayList.Columns.Add("Picture")

            displayList.Columns.Add("KeyArea")
            displayList.Columns.Add("Bedrooms")
            displayList.Columns.Add("Bathrooms")
            displayList.Columns.Add("Price")
            'displayList.Columns.Add("SquareFeet")
            'displayList.Columns.Add("Roof_Type")
            'displayList.Columns.Add("Appliances")
            'displayList.Columns.Add("Garage")
            'displayList.Columns.Add("Countertops")
            'displayList.Columns.Add("Bath")
            'displayList.Columns.Add("Closets")
            'displayList.Columns.Add("Fireplace")
            'displayList.Columns.Add("Landscaping")
            'displayList.Columns.Add("Details")
            'displayList.Columns.Add("HomeID")

            For index = 0 To myTable.Rows.Count - 1

                homeID = myTable.Rows(index).Item(1)
                Dim myHome As HomeLayouts = homeList.Item(homeID - 1)
                Session("SelectedHome") = myHome
                Dim price As Double = 0
                For i = 4 To 13
                    For Each aOption In myOptionList
                        If aOption.getoptionID = myTable.Rows(index).Item(i) Then
                            price += aOption.getoptionprice
                        End If
                    Next
                Next
                displayList.Rows.Add()
                displayList.Rows(displayList.Rows.Count - 1)("TempID") = myTable.Rows(index).Item(0)
                displayList.Rows(displayList.Rows.Count - 1)("TempName") = myTable.Rows(index).Item(3)
                displayList.Rows(displayList.Rows.Count - 1)("Picture") = myTable.Rows(index).Item(14)
                displayList.Rows(displayList.Rows.Count - 1)("KeyArea") = myTable.Rows(index).Item(2)
                displayList.Rows(displayList.Rows.Count - 1)("Bedrooms") = myHome.NumberOfBedrooms
                displayList.Rows(displayList.Rows.Count - 1)("Bathrooms") = myHome.NumberOfBathrooms
                displayList.Rows(displayList.Rows.Count - 1)("Price") = price + myHome.Price
            Next
            gvwalltypes.DataSource = displayList
            gvwalltypes.DataBind()


            '    lblnoinitialoptions.Visible = False

            '    firstload()

            '    lblfamily.Visible = False
            '    lblluxury.Visible = False
            '    lblstarter.Visible = False

            '    lbxhometype.SelectedValue = Session("temptype")
            '    ddlbathroom.SelectedValue = Session("tempbath")
            '    ddlbedroom.SelectedValue = Session("tempbed")

            '    If Session("numberofloads") <> 1 Then
            '        PopulateGridView()

        End If


        '    lblnooptions.Visible = False
        'End If


    End Sub

    'Protected Sub firstload()

    '    Session("numberofloads") += 1
    '    If Session("numberofloads") = 1 Then

    '        Dim type As String = Session("homestyleselected")
    '        Dim budget As Double = Session("Budget")

    '        Session("temptype") = Session("homestyleselected")
    '        Session("tempbath") = "All"
    '        Session("tempbed") = "All"

    '        Dim filteredhome As New DataTable
    '        filteredhome = myDataLoader.GetHomeDetails(type, budget)

    '        If filteredhome.Rows.Count <> 0 Then
    '            gvwalltypes.DataSource = filteredhome
    '            gvwalltypes.DataBind()
    '            gvwalltypes.Visible = True
    '        Else
    '            lblnoinitialoptions.Visible = True
    '        End If

    '    End If
    '    myDataLoader.LoadHomesLayouts()
    'End Sub

    'Protected Sub btnSeeHomeOptions_Click(sender As Object, e As EventArgs) Handles btnSeeHomeOptions.Click
    '    PopulateGridView()
    'End Sub

    'Protected Sub PopulateGridView()
    '    Dim type As String = lbxhometype.SelectedValue
    '    Dim bed As Double = ddlbedroom.SelectedValue
    '    Dim bath As Double = ddlbathroom.SelectedValue

    '    Session("temptype") = type
    '    Session("tempbath") = bath
    '    Session("tempbed") = bed

    '    Dim homedetails As New DataTable

    '    If bed = 0 And bath <> 0 Then
    '        homedetails = myDataLoader.GetHomeDetailsAllBed(type, bath)
    '    ElseIf bed <> 0 And bath = 0 Then
    '        homedetails = myDataLoader.GetHomeDetailsAllBath(type, bed)
    '    ElseIf bed = 0 And bath = 0 Then
    '        homedetails = myDataLoader.GetHomeDetailsAllBedAllBath(type)
    '    Else
    '        homedetails = myDataLoader.GetHomeDetails(type, bed, bath)
    '    End If


    '    If homedetails.Rows.Count <> 0 Then
    '        'gvwfiltered.DataSource = homedetails
    '        'gvwfiltered.DataBind()
    '        gvwfiltered.Visible = False
    '        gvwalltypes.DataSource = homedetails
    '        gvwalltypes.DataBind()
    '        gvwalltypes.Visible = True
    '        lblnooptions.Visible = False
    '    Else
    '        gvwalltypes.Visible = False
    '        gvwfiltered.Visible = False
    '        lblnooptions.Visible = True
    '    End If


    'End Sub

    Private Sub gvwalltypes_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gvwalltypes.RowCommand

        Dim rowindex As Integer = e.CommandArgument
        Dim tempid As Integer = gvwalltypes.Rows.Item(rowindex).Cells.Item(2).Text
        Session("tempid") = tempid

        If (e.CommandName = "btnDetails") Then

            Response.Redirect("~\Detialsoftemplate.aspx")
        Else

            Response.Redirect("~\ChooseFeature.aspx")
        End If




    End Sub

    'Private Sub gvwfiltered_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gvwfiltered.RowCommand
    '    Dim rowindex As Integer = e.CommandArgument
    '    Dim homeid As Integer = gvwalltypes.Rows.Item(rowindex).Cells.Item(2).Text
    '    Session("homeid") = homeid

    '    If (e.CommandName = "btnDetails") Then
    '        Response.Redirect("~\SeeHomeDetails.aspx")
    '    Else
    '        Response.Redirect("~\ChooseFeature.aspx")
    '    End If


    'End Sub

    'Private Sub lbxhometype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxhometype.SelectedIndexChanged

    '    If lbxhometype.SelectedValue = "Family" Then
    '        lblfamily.Visible = True
    '        lblluxury.Visible = False
    '        lblstarter.Visible = False
    '    ElseIf lbxhometype.SelectedValue = "Starter Home"
    '        lblfamily.Visible = False
    '        lblluxury.Visible = False
    '        lblstarter.Visible = True
    '    ElseIf lbxhometype.SelectedValue = "Luxury"
    '        lblfamily.Visible = False
    '        lblluxury.Visible = True
    '        lblstarter.Visible = False
    '    Else
    '        lblfamily.Visible = False
    '        lblluxury.Visible = False
    '        lblstarter.Visible = False
    '    End If

    '    gvwalltypes.Visible = False
    '    gvwfiltered.Visible = False
    '    lblnooptions.Visible = False

    'End Sub

    'Private Sub ddlbathroom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlbathroom.SelectedIndexChanged
    '    gvwalltypes.Visible = False

    'End Sub

    'Private Sub ddlbedroom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlbedroom.SelectedIndexChanged
    '    gvwalltypes.Visible = False

    'End Sub


    'Protected Sub btnallhome_Click(sender As Object, e As EventArgs) Handles btnallhome.Click
    '    Session("numberofloads") = 0
    '    gvwalltypes.DataSource = myDataLoader.GetHomeDetails()
    '    gvwalltypes.DataBind()
    '    gvwalltypes.Visible = True

    '    lbxhometype.SelectedValue = "Family"
    '    ddlbathroom.SelectedValue = 1
    '    ddlbedroom.SelectedValue = 1

    'End Sub
End Class
