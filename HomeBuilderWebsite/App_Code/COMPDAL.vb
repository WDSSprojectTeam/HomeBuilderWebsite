Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data
Imports System.Collections
Imports System
Imports System.Configuration

Public Class COMPDAL
    Private myConnectionStr As String = ConfigurationManager.ConnectionStrings("ConnectionStr10").ToString
    Private myConnection As OleDbConnection
    Private myCommand As OleDbCommand
    Private myReader As OleDbDataReader

    Public Function GetComparisonByCost(ByVal totalcost As Double) As DataTable
        Dim mytable As New DataTable
        Dim myrow As DataRow
        mytable.Columns.Add(New DataColumn("ScenarioID"))
        mytable.Columns.Add(New DataColumn("HouseName"))
        mytable.Columns.Add(New DataColumn("Budget"))
        mytable.Columns.Add(New DataColumn("ScenarioName"))
        mytable.Columns.Add(New DataColumn("TotalCost"))
        myConnection = New OleDbConnection(myConnectionStr)
        myCommand = New OleDbCommand("SELECT tblScenarios.ScenarioID, tblScenarios.HouseName, tblScenarios.Budget, tblScenarios.ScenarioName, tblScenarios.TotalCost " &
                                     "FROM tblScenarios", myConnection)

        myConnection.Open()
        myReader = myCommand.ExecuteReader
        Do While (myReader.Read)
            Dim cost As Double = myReader.Item("TotalCost")
            If cost <= totalcost Then
                myrow = mytable.NewRow
                myrow(0) = myReader.Item("ScenarioID")
                myrow(1) = myReader.Item("HouseName")
                myrow(2) = myReader.Item("Budget")
                myrow(3) = myReader.Item("ScenarioName")
                myrow(4) = myReader.Item("TotalCost")
                mytable.Rows.Add(myrow)
            End If
        Loop
        mytable.Load(myReader)
        myReader.Close()
        myConnection.Close()

        Return mytable
    End Function

    Public Function getscenariocosts(ByVal scenID As Integer) As ArrayList
        Dim mylist As New ArrayList
        Dim housename As String
        Dim floors As Double
        Dim rooftype As Double
        Dim appliances As Integer
        Dim garage As Integer
        Dim countertops As Integer
        Dim bath As Integer
        Dim closets As Integer
        Dim fireplace As Integer
        Dim holdingcost As Double = 0
        myConnection = New OleDbConnection(myConnectionStr)
        'I will add more select topics once the tblscenarios table is completed
        myCommand = New OleDbCommand("SELECT tblscenarios.HouseName, tblscenarios.Floorcost, tblscenarios.RoofCost, tblscenarios.Appliances, tblscenarios.Garage, tblscenarios.Countertops, tblscenarios.Bath, tblscenarios.Closets, tblscenarios.Fireplace " &
            "FROM tblScenarios WHERE ((tblScenarios.ScenarioID)=@param)", myConnection)
        myCommand.Parameters.AddWithValue("param", scenID)
        myConnection.Open()
        myReader = myCommand.ExecuteReader

        Do While (myReader.Read)
            housename = myReader.Item("HouseName")
            floors = myReader.Item("Floorcost")
            rooftype = myReader.Item("RoofCost")
            appliances = myReader.Item("Appliances")
            garage = myReader.Item("Garage")
            countertops = myReader.Item("Countertops")
            bath = myReader.Item("Bath")
            closets = myReader.Item("Closets")
            fireplace = myReader.Item("Fireplace")
        Loop
        myReader.Close()
        myConnection.Close()

        mylist.Add(gethousenamecost(housename))
        mylist.Add(floors)
        mylist.Add(rooftype)
        mylist.Add(getoptioncost(appliances))
        mylist.Add(getoptioncost(garage))
        holdingcost = 50 * getoptioncost(countertops)
        mylist.Add(holdingcost)
        holdingcost = getoptioncost(bath) * gethousenamebathrooms(housename)
        mylist.Add(holdingcost)
        holdingcost = getoptioncost(closets) * gethousenamebedrooms(housename)
        mylist.Add(holdingcost)
        mylist.Add(getoptioncost(fireplace))

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
        Dim housename As String
        Dim floors As Integer
        Dim rooftype As Integer
        Dim appliances As Integer
        Dim garage As Integer
        Dim countertops As Integer
        Dim bath As Integer
        Dim closets As Integer
        Dim fireplace As Integer
        myConnection = New OleDbConnection(myConnectionStr)
        'I will add more select topics once the tblscenarios table is completed
        myCommand = New OleDbCommand("SELECT tblscenarios.HouseName, tblscenarios.Floors, tblscenarios.Roof_Type, tblscenarios.Appliances, tblscenarios.Garage, tblscenarios.Countertops, tblscenarios.Bath, tblscenarios.Closets, tblscenarios.Fireplace " &
            "FROM tblScenarios WHERE ((tblScenarios.ScenarioID)=@param)", myConnection)
        myCommand.Parameters.AddWithValue("param", scenID)
        myConnection.Open()
        myReader = myCommand.ExecuteReader

        Do While (myReader.Read)
            housename = myReader.Item("HouseName")
            floors = myReader.Item("Floors")
            rooftype = myReader.Item("Roof_Type")
            appliances = myReader.Item("Appliances")
            garage = myReader.Item("Garage")
            countertops = myReader.Item("Countertops")
            bath = myReader.Item("Bath")
            closets = myReader.Item("Closets")
            fireplace = myReader.Item("Fireplace")
        Loop
        myReader.Close()
        myConnection.Close()

        mylist.Add(housename)
        mylist.Add(getoptionname(floors))
        mylist.Add(getoptionname(rooftype))
        mylist.Add(getoptionname(appliances))
        mylist.Add(getoptionname(garage))
        mylist.Add(getoptionname(countertops))
        mylist.Add(getoptionname(bath))
        mylist.Add(getoptionname(closets))
        mylist.Add(getoptionname(fireplace))

        Return mylist
    End Function

    Public Function getscenariopartdetails(ByVal scenID As Integer) As DataTable
        Dim mytable As New DataTable
        Dim housename As String
        Dim floors As Integer
        Dim rooftype As Integer
        Dim appliances As Integer
        Dim garage As Integer
        Dim countertops As Integer
        Dim bath As Integer
        Dim closets As Integer
        Dim fireplace As Integer

        mytable.Columns.Add(New DataColumn("House Name"))
        mytable.Columns.Add(New DataColumn("Floor Type"))
        mytable.Columns.Add(New DataColumn("Roof Type"))
        mytable.Columns.Add(New DataColumn("Appliances"))
        mytable.Columns.Add(New DataColumn("Garage"))
        mytable.Columns.Add(New DataColumn("Countertops"))
        mytable.Columns.Add(New DataColumn("Bath Type"))
        mytable.Columns.Add(New DataColumn("Closet Type"))
        mytable.Columns.Add(New DataColumn("Fireplace"))


        myConnection = New OleDbConnection(myConnectionStr)
        'I will add more select topics once the tblscenarios table is completed
        myCommand = New OleDbCommand("SELECT tblscenarios.HouseName, tblscenarios.Floors, tblscenarios.Roof_Type, tblscenarios.Appliances, tblscenarios.Garage, tblscenarios.Countertops, tblscenarios.Bath, tblscenarios.Closets, tblscenarios.Fireplace " &
            "FROM tblScenarios WHERE ((tblScenarios.ScenarioID)=@param)", myConnection)
        myCommand.Parameters.AddWithValue("param", scenID)
        myConnection.Open()
        myReader = myCommand.ExecuteReader

        Do While (myReader.Read)
            housename = myReader.Item("HouseName")
            floors = myReader.Item("Floors")
            rooftype = myReader.Item("Roof_Type")
            appliances = myReader.Item("Appliances")
            garage = myReader.Item("Garage")
            countertops = myReader.Item("Countertops")
            bath = myReader.Item("Bath")
            closets = myReader.Item("Closets")
            fireplace = myReader.Item("Fireplace")
        Loop
        myReader.Close()
        myConnection.Close()
        Dim myrow As DataRow
        myrow = mytable.NewRow


        myrow(0) = housename
        myrow(1) = (getoptionname(floors))
        myrow(2) = (getoptionname(rooftype))
        myrow(3) = (getoptionname(appliances))
        myrow(4) = (getoptionname(garage))
        myrow(5) = (getoptionname(countertops))
        myrow(6) = (getoptionname(bath))
        myrow(7) = (getoptionname(closets))
        myrow(8) = (getoptionname(fireplace))
        mytable.Rows.Add(myrow)
        Return mytable
    End Function

    Public Function gethousenamecost(ByVal name As String) As Double
        Dim cost As Double
        myConnection = New OleDbConnection(myConnectionStr)
        myCommand = New OleDbCommand("SELECT tblHomeLayouts.price " &
                                     "FROM tblHomeLayouts WHERE ((tblHomeLayouts.HouseName)=@param)", myConnection)
        myCommand.Parameters.AddWithValue("param", name)
        myConnection.Open()
        cost = myCommand.ExecuteScalar
        myConnection.Close()
        Return cost
    End Function

    Public Function gethousenamebedrooms(ByVal name As String) As Integer
        Dim bed As Integer
        myConnection = New OleDbConnection(myConnectionStr)
        myCommand = New OleDbCommand("SELECT tblHomeLayouts.Bedrooms " &
                                     "FROM tblHomeLayouts WHERE ((tblHomeLayouts.HouseName)=@param)", myConnection)
        myCommand.Parameters.AddWithValue("param", name)
        myConnection.Open()
        bed = myCommand.ExecuteScalar
        myConnection.Close()
        Return bed
    End Function


    Public Function gethousenamebathrooms(ByVal name As String) As Integer
        Dim bath As Integer
        myConnection = New OleDbConnection(myConnectionStr)
        myCommand = New OleDbCommand("SELECT tblHomeLayouts.Bathrooms " &
                                     "FROM tblHomeLayouts WHERE ((tblHomeLayouts.HouseName)=@param)", myConnection)
        myCommand.Parameters.AddWithValue("param", name)
        myConnection.Open()
        bath = myCommand.ExecuteScalar
        myConnection.Close()
        Return bath
    End Function

    Public Function getoptionname(ByVal ID As Integer) As String
        Dim optionname As String
        myConnection = New OleDbConnection(myConnectionStr)
        myCommand = New OleDbCommand("SELECT tblOptions.UpgradeName " &
                                     "FROM tblOptions WHERE ((tblOptions.UpgradeID)=@param)", myConnection)
        myCommand.Parameters.AddWithValue("param", ID)
        myConnection.Open()
        optionname = myCommand.ExecuteScalar
        myConnection.Close()

        Return optionname
    End Function

    Public Function gettotalcost(ByVal ID As Integer) As Double
        Dim cost As Double
        myConnection = New OleDbConnection(myConnectionStr)
        myCommand = New OleDbCommand("SELECT tblScenarios.TotalCost " &
                                     "FROM tblScenarios WHERE((tblScenarios.ScenarioID)=@param)", myConnection)
        myCommand.Parameters.AddWithValue("param", ID)
        myConnection.Open()
        cost = myCommand.ExecuteScalar
        myConnection.Close()

        Return cost
    End Function

    Public Function getutility(ByVal ID As Integer) As Double
        Dim util As Double
        myConnection = New OleDbConnection(myConnectionStr)
        myCommand = New OleDbCommand("SELECT tblScenarios.Utility " &
                                     "FROM tblScenarios WHERE ((tblScenarios.ScenarioID)=@param)", myConnection)
        myCommand.Parameters.AddWithValue("param", ID)
        myConnection.Open()
        util = myCommand.ExecuteScalar
        myConnection.Close()

        Return util
    End Function

    Public Function gethousename(ByVal ID As Integer) As String
        Dim hous As String
        myConnection = New OleDbConnection(myConnectionStr)
        myCommand = New OleDbCommand("SELECT tblScenarios.HouseName " &
                                     "FROM tblScenarios WHERE ((tblScenarios.ScenarioID)=@param)", myConnection)
        myCommand.Parameters.AddWithValue("param", ID)
        myConnection.Open()
        hous = myCommand.ExecuteScalar
        myConnection.Close()

        Return hous
    End Function

    Public Function getfloorcost(ByVal ID As Integer) As Double
        Dim cost As Double
        myConnection = New OleDbConnection(myConnectionStr)
        myCommand = New OleDbCommand("SELECT tblScenarios.FloorCost " &
                                     "FROM tblScenarios WHERE ((tblScenarios.ScenarioID)=@param)", myConnection)
        myCommand.Parameters.AddWithValue("param", ID)
        myConnection.Open()
        cost = myCommand.ExecuteScalar
        myConnection.Close()

        Return cost
    End Function

    Public Function getroofcost(ByVal ID As Integer) As Double
        Dim cost As Double
        myConnection = New OleDbConnection(myConnectionStr)
        myCommand = New OleDbCommand("SELECT tblScenarios.RoofCost " &
                                     "FROM tblScenarios WHERE ((tblScenarios.ScenarioID)=@param)", myConnection)
        myCommand.Parameters.AddWithValue("param", ID)
        myConnection.Open()
        cost = myCommand.ExecuteScalar
        myConnection.Close()

        Return cost
    End Function

    Public Function getoptionstuff(ByVal name As String, ByVal id As Integer) As Double
        Dim cost As Double
        myConnection = New OleDbConnection(myConnectionStr)
        myCommand = New OleDbCommand("SELECT tblScenarios.Appliances, tblScenarios.Garage, tblScenarios.Countertops, tblScenarios.Bath, tblScenarios.Closets, tblScenarios.Fireplace " &
                                     "FROM tblScenarios WHERE ((tblScenarios.ScenarioID)=@param)", myConnection)
        myCommand.Parameters.AddWithValue("param", id)
        If name = "Appliances" Then
            myConnection.Open()
            myReader = myCommand.ExecuteReader
            Do While (myReader.Read)
                Dim opt As Integer = myReader.Item("Appliances")
                cost = getoptioncost(opt)
            Loop
        ElseIf name = "Garage"
            myConnection.Open()
            myReader = myCommand.ExecuteReader
            Do While (myReader.Read)
                Dim opt As Integer = myReader.Item("Garage")
                cost = getoptioncost(opt)
            Loop
        ElseIf name = "Countertops"
            myConnection.Open()
            myReader = myCommand.ExecuteReader
            Do While (myReader.Read)
                Dim opt As Integer = myReader.Item("Countertops")
                cost = getoptioncost(opt)
            Loop
        ElseIf name = "Bath"
            myConnection.Open()
            myReader = myCommand.ExecuteReader
            Do While (myReader.Read)
                Dim opt As Integer = myReader.Item("Bath")
                cost = getoptioncost(opt)
            Loop
        ElseIf name = "Closets"
            myConnection.Open()
            myReader = myCommand.ExecuteReader
            Do While (myReader.Read)
                Dim opt As Integer = myReader.Item("Closets")
                cost = getoptioncost(opt)
            Loop
        ElseIf name = "Fireplace"
            myConnection.Open()
            myReader = myCommand.ExecuteReader
            Do While (myReader.Read)
                Dim opt As Integer = myReader.Item("Fireplace")
                cost = getoptioncost(opt)
            Loop
        End If

        myConnection.Close()
        Return cost
    End Function

    Public Function getoptioncost(ByVal ID As Integer) As Double
        Dim price As Double
        myConnection = New OleDbConnection(myConnectionStr)
        myCommand = New OleDbCommand("SELECT tblOptions.Upgradeprice " &
                                     "FROM tblOptions WHERE ((tblOptions.UpgradeID)=@param)", myConnection)
        myCommand.Parameters.AddWithValue("param", ID)
        myConnection.Open()
        price = myCommand.ExecuteScalar
        myConnection.Close()

        Return price
    End Function



    Public Function getselectedscenarios(ByVal list As ArrayList) As DataTable
        Dim mytable As New DataTable
        Dim myrow As DataRow
        mytable.Columns.Add(New DataColumn("ScenarioID"))
        mytable.Columns.Add(New DataColumn("HouseName"))
        mytable.Columns.Add(New DataColumn("Budget"))
        mytable.Columns.Add(New DataColumn("ScenarioName"))
        mytable.Columns.Add(New DataColumn("TotalCost"))

        myConnection = New OleDbConnection(myConnectionStr)
        myCommand = New OleDbCommand("SELECT tblScenarios.ScenarioID, tblScenarios.HouseName, tblScenarios.Budget, tblScenarios.ScenarioName, tblScenarios.TotalCost " &
                                     "FROM tblScenarios", myConnection)
        myConnection.Open()
        myReader = myCommand.ExecuteReader
        Do While (myReader.Read)
            For i = 0 To list.Count - 1
                If Convert.ToInt32((myReader.Item("ScenarioID"))) = list.Item(i) Then
                    myrow = mytable.NewRow
                    myrow(0) = myReader.Item("ScenarioID")
                    myrow(1) = myReader.Item("HouseName")
                    myrow(2) = myReader.Item("Budget")
                    myrow(3) = myReader.Item("ScenarioName")
                    myrow(4) = myReader.Item("TotalCost")
                    mytable.Rows.Add(myrow)
                End If
            Next
        Loop
        Return mytable
    End Function



End Class
