Imports System.Data
Imports Microsoft.VisualBasic
Imports System.Web.UI.DataVisualization.Charting


Partial Class HomeBuilderWebsite_master_Comparison
    Inherits System.Web.UI.Page
    Private mydataAccess As New COMPDAL




    Private Sub homebuilderwebsite_master_Comparison_load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            DropDownList1.SelectedIndex = 0
            Dim totcost As Double = DropDownList1.SelectedValue
            fillgridview(totcost)

            Dim indexID As Integer = Convert.ToInt32(GridView1.SelectedRow.Cells.Item(2).text)
            DrawPieChart(indexID)
        End If
    End Sub

    Private Sub fillgridview(ByVal totalcost As Double)
        GridView1.DataSource = mydataAccess.GetComparisonByCost(totalcost)
        GridView1.DataBind()

    End Sub

    Sub Gridview1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim row As GridViewRow = GridView1.SelectedRow
        Dim indexID As Integer = Convert.ToInt32(GridView1.SelectedRow.Cells.Item(2).Text)
        DrawPieChart(indexID)
    End Sub


    Private Sub DrawPieChart(ByVal ind As Integer)
        Dim mycharter As New Comparison1Charter(Chart1)
        mycharter.loaddata(mydataAccess)
        mycharter.draw(ind)
    End Sub

    Private Sub dropdownlist1_selectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Dim totalcost As Double = DropDownList1.SelectedValue
        fillgridview(totalcost)
    End Sub




    Protected Sub Button1_Click1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gvr As GridViewRow
        Dim i As Integer
        Dim info As New ArrayList
        For Each gvr In GridView1.Rows
            If (CType(gvr.Cells(1).FindControl("CheckBox"), CheckBox)).Checked = True Then
                i = Convert.ToInt32(gvr.Cells.Item(2).Text)
                info.Add(i)
            End If
        Next
        Session("checkedscenarios") = info



        Response.Redirect("~\Comparison2.aspx")
    End Sub
End Class
