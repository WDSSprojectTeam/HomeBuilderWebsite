Imports System.Data


Partial Class ChooseHomeLayout
    Inherits System.Web.UI.Page

    Private myDataLoader As New DataLoader

    Private Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If (Not IsPostBack) Then

            lblfamily.Visible = False
            lblluxury.Visible = False
            lblstarter.Visible = False

            lbxhometype.SelectedValue = Session("temptype")
            ddlbathroom.SelectedValue = Session("tempbath")
            ddlbedroom.SelectedValue = Session("tempbed")


            PopulateGridView()
            lblnooptions.Visible = False
        End If


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
            gvwalltypes.DataSource = homedetails
            gvwalltypes.DataBind()
            gvwalltypes.Visible = True
            lblnooptions.Visible = False
        Else
            gvwalltypes.Visible = False
            lblnooptions.Visible = True
        End If

    End Sub

    Private Sub gvwalltypes_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gvwalltypes.RowCommand

        If (e.CommandName = "btnDetails") Then
            Dim rowindex As Integer = e.CommandArgument
            Dim homeid As Integer = gvwalltypes.Rows.Item(rowindex).Cells.Item(4).Text
            Session("homeid") = homeid
            Response.Redirect("SeeHomeDetails.aspx")
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

    End Sub

    Private Sub ddlbathroom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlbathroom.SelectedIndexChanged
        gvwalltypes.Visible = False

    End Sub

    Private Sub ddlbedroom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlbedroom.SelectedIndexChanged
        gvwalltypes.Visible = False

    End Sub


    Protected Sub btnallhome_Click(sender As Object, e As EventArgs) Handles btnallhome.Click
        gvwalltypes.DataSource = myDataLoader.GetHomeDetails()
        gvwalltypes.DataBind()
        gvwalltypes.Visible = True
    End Sub
End Class
