Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data
Imports System.Collections
Imports System

Public Class COMPDAL
    Private myConnectionStr As String = ConfigurationManager.ConnectionStrings("ConnectionStr10").ToString
    Private myConnection As OleDbConnection
    Private myCommand As OleDbCommand
    Private myReader As OleDbDataReader

    Public Function GetComparisonByCost(ByVal totalcost As Double) As DataTable
        Dim mytable As New DataTable
        myConnection = New OleDbConnection(myConnectionStr)
        myCommand = New OleDbCommand("SELECT tblScenarios.ScenarioID, tblScenarios.HomeStyle, tblScenarios.Pool, tblScenarios.TotalCost, tblScenarios.DefiningFeature " &
                                     "FROM tblScenarios WHERE ((tblScenarios.TotalCost)=@param)", myConnection)
        myCommand.Parameters.AddWithValue("@param", totalcost)
        myConnection.Open()
        myReader = myCommand.ExecuteReader
        mytable.Load(myReader)
        myReader.Close()
        myConnection.Close()
        Return mytable
    End Function

    Public Function getscenariocosts(ByVal scenID As Integer) As ArrayList
        Dim mylist As New ArrayList
        myConnection = New OleDbConnection(myConnectionStr)
        'I will add more select topics once the tblscenarios table is completed
        myCommand = New OleDbCommand("SELECT tblScenarios.floorcost, tblScenarios.appliancescost " &
                                     "FROM tblScenarios WHERE ((tblScenarios.ScenarioID)=@param)", myConnection)
        myCommand.Parameters.AddWithValue("@param", scenID)
        myConnection.Open()
        myReader = myCommand.ExecuteReader

        Do While (myReader.Read)
            mylist.Add(myReader.Item("floorcost"))
            mylist.Add(myReader.Item("appliancescost"))

        Loop

        myReader.Close()
        myConnection.Close()
        Return mylist
    End Function

    'Friend Function GetScenarioCostsList(identity As Integer) As ArrayList
    'Throw New NotImplementedException()
    'End Function

    ' Public Function GetScenarioPartsList(identity As Integer) As ArrayList
    'Dim myPartsList As New ArrayList
    'Dim myPartsDataTable As New DataTable

    '   myPartsDataTable = getscenarioparts(identity)

    'For i = 0 To myPartsDataTable.Rows.Count - 1
    '       myPartsList.Add(myPartsDataTable.Rows(i)(1))
    'Next

    ' End Function

    Public Function getscenarioparts(ByVal scenID As Integer) As ArrayList
        Dim mylist As New ArrayList
        myConnection = New OleDbConnection(myConnectionStr)
        'I will add more select topics once the tblscenarios table is completed
        myCommand = New OleDbCommand("SELECT tblscenarios.floorstyle, tblscenarios.appliances " &
            "FROM tblScenarios WHERE ((tblScenarios.ScenarioID)=param)", myConnection)
        myCommand.Parameters.AddWithValue("param", scenID)
        myConnection.Open()
        myReader = myCommand.ExecuteReader

        Do While (myReader.Read)
            mylist.Add(myReader.Item("floorstyle"))
            mylist.Add(myReader.Item("appliances"))

        Loop
        myReader.Close()
        myConnection.Close()

        Return mylist
    End Function

    Public Function getselectedscenarios(ByVal list As ArrayList) As DataTable
        Dim mytable As New DataTable
        Dim myrow As DataRow
        mytable.Columns.Add(New DataColumn("ScenarioID"))
        mytable.Columns.Add(New DataColumn("HomeStyle"))
        mytable.Columns.Add(New DataColumn("Pool"))
        mytable.Columns.Add(New DataColumn("TotalCost"))
        mytable.Columns.Add(New DataColumn("DefiningFeature"))
        Dim it As Integer
        myConnection = New OleDbConnection(myConnectionStr)
        myCommand = New OleDbCommand("SELECT tblScenarios.ScenarioID, tblScenarios.HomeStyle, tblScenarios.Pool, tblScenarios.TotalCost, tblScenarios.DefiningFeature " &
                                     "FROM tblScenarios", myConnection)
        myConnection.Open()
        myReader = myCommand.ExecuteReader
        Do While (myReader.Read)
            For i = 0 To list.Count - 1
                If Convert.ToInt32((myReader.Item("ScenarioID"))) = list.Item(i) Then
                    myrow = mytable.NewRow
                    myrow(0) = myReader.Item("ScenarioID")
                    myrow(1) = myReader.Item("HomeStyle")
                    myrow(2) = myReader.Item("Pool")
                    myrow(3) = myReader.Item("TotalCost")
                    myrow(4) = myReader.Item("DefiningFeature")
                    mytable.Rows.Add(myrow)
                End If
            Next
        Loop
        Return mytable
    End Function



End Class
