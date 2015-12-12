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

    Protected Sub btnNewEntry_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Page.ClientScript.RegisterStartupScript(Me.GetType(), "OpenWindow", "window.open('Help.aspx','_newtab');", True)
    End Sub


    '    Public Function GetAllHomesTable() As Object
    '        Throw New NotImplementedException()
    '    End Function

    '    Private myReader As OleDbDataReader

    '    Private Sub LoadFeatures()

    '        myConnection = New OleDbConnection(myConnectionStr)
    '        myCommand = New OleDbCommand("SELECT tblFeatures.FeatureID, tblFeatures.Feature, tblFeatures.RoomID From tblFeatures", myConnection)
    '        Dim myFeatureList As New List(Of Feature)
    '        Try
    '            myConnection.Open()
    '            myReader = myCommand.ExecuteReader

    '            Do While (myReader.Read)
    '                Dim featureID As Integer = myReader.Item("FeatureID")
    '                Dim featureName As String = myReader.Item("Feature")
    '                Dim roomID As Integer = myReader.Item("RoomID")


    'Protected Sub btnEditTemplate_Click(sender As Object, e As EventArgs) Handles btnEditTemplate.Click
    '    Response.Redirect("~\ScenarioInfo.aspx")
    'End Sub



    Protected Sub btnLoadScenario_Click(sender As Object, e As EventArgs) Handles btnLoadScenario.Click
        Response.Redirect("~\Comparison.aspx")
    End Sub
End Class