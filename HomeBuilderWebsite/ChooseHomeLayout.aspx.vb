﻿Imports System.Data


Partial Class ChooseHomeLayout
    Inherits System.Web.UI.Page

    Private myDataLoader As New DataLoader

    Private Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If (Not IsPostBack) Then

            firstload()

            lblfamily.Visible = False
            lblluxury.Visible = False
            lblstarter.Visible = False

            lbxhometype.SelectedValue = Session("temptype")
            ddlbathroom.SelectedValue = Session("tempbath")
            ddlbedroom.SelectedValue = Session("tempbed")

            If Session("numberofloads") <> 1 Then
                PopulateGridView()

            End If


            lblnooptions.Visible = False
        End If


    End Sub

    Protected Sub firstload()

        Session("numberofloads") += 1
        If Session("numberofloads") = 1 Then
            Session("temptype") = "Family"
            Session("tempbath") = 1
            Session("tempbed") = 1
            gvwalltypes.DataSource = myDataLoader.GetHomeDetails()
            gvwalltypes.DataBind()
            gvwalltypes.Visible = True
        End If
        myDataLoader.LoadHomesLayouts()
    End Sub

    Protected Sub btnSeeHomeOptions_Click(sender As Object, e As EventArgs) Handles btnSeeHomeOptions.Click
        PopulateGridView()
    End Sub

    Protected Sub PopulateGridView()
        Dim type As String = lbxhometype.SelectedValue
        Dim bed As Double = ddlbedroom.SelectedValue
        Dim bath As Double = ddlbathroom.SelectedValue

        Session("temptype") = type
        Session("tempbath") = bath
        Session("tempbed") = bed

        Dim homedetails As New DataTable
        homedetails = myDataLoader.GetHomeDetails(type, bed, bath)

        If homedetails.Rows.Count <> 0 Then
            gvwfiltered.DataSource = homedetails
            gvwfiltered.DataBind()
            gvwfiltered.Visible = True
            gvwalltypes.Visible = False
            lblnooptions.Visible = False
        Else
            gvwalltypes.Visible = False
            gvwfiltered.Visible = False
            lblnooptions.Visible = True
        End If


    End Sub

    Private Sub gvwalltypes_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gvwalltypes.RowCommand

        Dim rowindex As Integer = e.CommandArgument
        Dim homeid As Integer = gvwalltypes.Rows.Item(rowindex).Cells.Item(2).Text
        'Dim aDataLoader As DataLoader
        Session("homeid") = homeid
        Dim myHome As New HomeLayouts

        If (e.CommandName = "btnDetails") Then
            Response.Redirect("~\SeeHomeDetails.aspx")
        Else
            myHome = myDataLoader.GetHomeObject(homeid)

            Session("SelectedHome") = myHome


            Response.Redirect("~\ChooseFeature.aspx")
        End If




    End Sub

    Private Sub gvwfiltered_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gvwfiltered.RowCommand
        Dim rowindex As Integer = e.CommandArgument
        Dim homeid As Integer = gvwalltypes.Rows.Item(rowindex).Cells.Item(2).Text
        Session("homeid") = homeid

        If (e.CommandName = "btnDetails") Then
            Response.Redirect("~\SeeHomeDetails.aspx")
        Else
            Response.Redirect("~\ChooseFeature.aspx")
        End If


    End Sub

    Private Sub lbxhometype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxhometype.SelectedIndexChanged

        If lbxhometype.SelectedValue = "Family" Then
            lblfamily.Visible = True
            lblluxury.Visible = False
            lblstarter.Visible = False
        ElseIf lbxhometype.SelectedValue = "Starter Home"
            lblfamily.Visible = False
            lblluxury.Visible = False
            lblstarter.Visible = True
        Else
            lblfamily.Visible = False
            lblluxury.Visible = True
            lblstarter.Visible = False

        End If

        gvwalltypes.Visible = False
        gvwfiltered.Visible = False
        lblnooptions.Visible = False

    End Sub

    Private Sub ddlbathroom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlbathroom.SelectedIndexChanged
        gvwalltypes.Visible = False

    End Sub

    Private Sub ddlbedroom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlbedroom.SelectedIndexChanged
        gvwalltypes.Visible = False

    End Sub


    Protected Sub btnallhome_Click(sender As Object, e As EventArgs) Handles btnallhome.Click
        Session("numberofloads") = 0
        gvwalltypes.DataSource = myDataLoader.GetHomeDetails()
        gvwalltypes.DataBind()
        gvwalltypes.Visible = True

        lbxhometype.SelectedValue = "Family"
        ddlbathroom.SelectedValue = 1
        ddlbedroom.SelectedValue = 1

    End Sub




    'Private Sub lnkchoosehome_Click(sender As Object, e As EventArgs) Handles lnkchoosehome.Click
    '    Dim selectedcourseID As Integer = 1

    '    Dim homelist As List(Of HomeLayouts) = Session("HomeSet")

    '    If gvwalltypes.Visible = True Then
    '        selectedcourseID = gvwalltypes.SelectedRow.Cells.Item(2).Text
    '    ElseIf gvwfiltered.Visible = True
    '        selectedcourseID = gvwfiltered.SelectedRow.Cells.Item(2).Text
    '    End If

    '    For i = 0 To homelist.Count - 1

    '        Session("SelectedHome") = homelist.Item(selectedcourseID - 1)

    '    Next


        Response.Redirect("~\ChooseFeature.aspx")
    End Sub
End Class
