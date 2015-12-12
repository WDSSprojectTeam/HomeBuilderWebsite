
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
            Session("myTemplate") = myTable

            Dim myOptionList As List(Of Options) = Session("OptionSet")

            Dim displayList As New DataTable
            displayList.Columns.Add("TempID")
            displayList.Columns.Add("TempName")
            displayList.Columns.Add("Picture")
            displayList.Columns.Add("KeyArea")
            displayList.Columns.Add("Bedrooms")
            displayList.Columns.Add("Bathrooms")
            displayList.Columns.Add("Price")


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
        End If

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

    Protected Sub btnallhome_Click(sender As Object, e As EventArgs) Handles btnallhome.Click
        Session("numberofloads") = 0

        Dim index As Integer = 0
        Dim myTable As DataTable = myDataLoader.GetTemplateDetails()

        Dim homeID As Integer = myTable.Rows(index).Item(1)
        Dim keyfeature As String = myTable.Rows(index).Item(2)

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


        For index = 0 To myTable.Rows.Count - 1
            keyfeature = myTable.Rows(index).Item(2)
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

            Dim keyar As String = Session("keyareaselected")
            Dim bud As Double = Session("Budget")


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





        gvwalltypes.Visible = True

        lbxhometype.SelectedValue = "Exterior"
        lblnoinitialoptions.Visible = False
        lblnooptions.Visible = False
    End Sub

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
        Session("whichTemplate") = rowindex
        Dim tempid As Integer = gvwalltypes.Rows.Item(rowindex).Cells.Item(2).Text
        Session("tempid") = tempid

        If (e.CommandName = "btnDetails") Then

            Response.Redirect("~\Detialsoftemplate.aspx")
        Else

            Response.Redirect("~\TemplateEdit.aspx")
        End If




    End Sub


    Private Sub lbxhometype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxhometype.SelectedIndexChanged

        If lbxhometype.SelectedValue = "Exterior" Then
            lblexterior.Visible = True
            lblinterior.Visible = False
            lblkitchen.Visible = False
            lblbedrooms.Visible = False
        ElseIf lbxhometype.SelectedValue = "Interior"
            lblexterior.Visible = False
            lblinterior.Visible = True
            lblkitchen.Visible = False
            lblbedrooms.Visible = False
        ElseIf lbxhometype.SelectedValue = "Bedroom"
            lblexterior.Visible = False
            lblinterior.Visible = False
            lblkitchen.Visible = False
            lblbedrooms.Visible = True
        Else
            lblexterior.Visible = False
            lblinterior.Visible = False
            lblkitchen.Visible = True
            lblbedrooms.Visible = False
        End If

        gvwalltypes.Visible = False
        lblnooptions.Visible = False
        lblnoinitialoptions.Visible = False

    End Sub


    Protected Sub btnSeeHomeOptions_Click(sender As Object, e As EventArgs) Handles btnSeeHomeOptions.Click

        Session("numberofloads") = 0

        Dim index As Integer = 0
        Dim myTable As DataTable = myDataLoader.GetTemplateDetails()

        Dim homeID As Integer = myTable.Rows(index).Item(1)
        Dim keyfeature As String = myTable.Rows(index).Item(2)

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


        For index = 0 To myTable.Rows.Count - 1
            keyfeature = myTable.Rows(index).Item(2)
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

            Dim keyar As String = Session("keyareaselected")
            Dim bud As Double = Session("Budget")


            If keyfeature = keyar Then
                displayList.Rows.Add()
                displayList.Rows(displayList.Rows.Count - 1)("TempID") = myTable.Rows(index).Item(0)
                displayList.Rows(displayList.Rows.Count - 1)("TempName") = myTable.Rows(index).Item(3)
                displayList.Rows(displayList.Rows.Count - 1)("Picture") = myTable.Rows(index).Item(14)
                displayList.Rows(displayList.Rows.Count - 1)("KeyArea") = myTable.Rows(index).Item(2)
                displayList.Rows(displayList.Rows.Count - 1)("Bedrooms") = myHome.NumberOfBedrooms
                displayList.Rows(displayList.Rows.Count - 1)("Bathrooms") = myHome.NumberOfBathrooms
                displayList.Rows(displayList.Rows.Count - 1)("Price") = price + myHome.Price
            End If


        Next
        gvwalltypes.DataSource = displayList
        gvwalltypes.DataBind()





        gvwalltypes.Visible = True

        lbxhometype.SelectedValue = Session("keyareaselected")
        lblnoinitialoptions.Visible = False
        lblnooptions.Visible = False
    End Sub
End Class
