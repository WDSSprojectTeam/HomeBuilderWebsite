﻿Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.OleDb
Imports System
Imports System.Web.UI.WebControls.GridView
Imports System.Web.UI.WebControls
Imports System.Collections

Partial Class HomeBuilderWebsite_master_Comparison2
    Inherits System.Web.UI.Page
    Private mydataAccess As New COMPDAL


    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim infolist As New ArrayList
            Dim dt As New DataTable
            Dim dt2 As New DataTable
            infolist = Session("checkedscenarios")
            dt = mydataAccess.getselectedscenarios(infolist)

            For i As Integer = 0 To dt.Rows.Count
                dt2.Columns.Add()
            Next
            For i As Integer = 0 To dt.Columns.Count - 1
                dt2.Rows.Add()
                dt2.Rows(i)(0) = dt.Columns(i).ColumnName
            Next
            For i As Integer = 0 To dt.Columns.Count - 1
                For j As Integer = 0 To dt.Rows.Count - 1
                    dt2.Rows(i)(j + 1) = dt.Rows(j)(i)
                Next
            Next



            DropDownList1.DataSource = infolist
            DropDownList1.DataBind()
            DropDownList1.SelectedIndex = 0

            Dim tipo As String = DropDownList2.SelectedValue
            GridView1.DataSource = dt2
            GridView1.DataBind()
            drawchart1(infolist, tipo)
            populatedetailsview(Convert.ToInt32(DropDownList1.SelectedValue))
        End If

    End Sub



    Private Sub drawchart1(ByVal scenlist As ArrayList, ByVal type As String)
        Dim mycharter As New Comparison2Charter(Chart1)
        mycharter.loaddata(mydataAccess)
        mycharter.draw(scenlist, type)
    End Sub

    Private Sub drawchart2(ByVal scenlist As ArrayList)
        Dim mycharter As New Comparison2Charter2(Chart1)
        mycharter.loaddata(mydataAccess)
        mycharter.draw(scenlist)
    End Sub


    Private Sub dropdownlist1_selectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        populatedetailsview(DropDownList1.SelectedValue)
        Dim stuff As String
        stuff = DropDownList2.SelectedValue
        Session("drop1") = stuff
        dropdownliststuff(stuff)
    End Sub

    Private Sub dropdownlist2_selectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList2.SelectedIndexChanged
        Dim type As String = DropDownList2.SelectedValue
        dropdownliststuff(type)

    End Sub


    Private Sub dropdownliststuff(ByVal tip As String)
        Dim infolist As New ArrayList
        Dim type As String = tip
        infolist = Session("checkedscenarios")
        If type = "Utility" Then
            drawchart2(infolist)
        Else

            drawchart1(infolist, type)
        End If
    End Sub

    Private Sub populatedetailsview(ByVal identity As Integer)
        DetailsView1.DataSource = mydataAccess.getscenariopartdetails(identity)
        DetailsView1.DataBind()
    End Sub

    Protected Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Response.Redirect("Comparison.aspx")
    End Sub

    Protected Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Session("ScenarioID") = Convert.ToInt32(DropDownList1.SelectedValue)
        Response.Redirect("Comparison3.aspx")
    End Sub
End Class
