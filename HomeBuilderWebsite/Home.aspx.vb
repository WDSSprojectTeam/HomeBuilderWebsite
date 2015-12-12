Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.OleDb

Public Class Home
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim mydataloader As New DataLoader
        mydataloader.GetData()
    End Sub


    Protected Sub btnBuildHome_Click(sender As Object, e As EventArgs) Handles btnBuildHome.Click
        Response.Redirect("~\Directions.aspx")
    End Sub

    Protected Sub btnEditTemplate_Click(sender As Object, e As EventArgs) Handles btnEditTemplate.Click
        Response.Redirect("~\ScenarioInfo.aspx")
    End Sub



    Protected Sub btnLoadScenario_Click(sender As Object, e As EventArgs) Handles btnLoadScenario.Click
        Response.Redirect("~\Comparison.aspx")
    End Sub
End Class