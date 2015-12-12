
Imports System.Data
Imports System.Data.OleDb
Imports System
Imports System.Web.UI.WebControls.GridView
Imports System.Web.UI.WebControls
Imports System.Collections

Partial Class Comparison3
    Inherits System.Web.UI.Page
    Private mydataAccess As New COMPDAL


    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        populatedetailsview(Session("ScenarioID"))
    End Sub

    Private Sub populatedetailsview(ByVal identity As Integer)
        DetailsView1.DataSource = mydataAccess.getscenariopartdetails(identity)
        DetailsView1.DataBind()
    End Sub
End Class
