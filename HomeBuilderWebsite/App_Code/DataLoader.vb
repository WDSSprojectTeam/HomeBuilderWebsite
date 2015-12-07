Imports Microsoft.VisualBasic
Imports System.Data
    Imports System.Data.OleDb
    'Imports System.Web.UI.datavisualization.Charting

    Public Class DataLoader
        Inherits System.Web.UI.Page

        Private myConnectionStr As String = ConfigurationManager.ConnectionStrings("ConnectionStr10").ToString
        Private myConnection As OleDbConnection
        Private myCommand As OleDbCommand
    Private myReader As OleDbDataReader

    Public Sub GetData()
        LoadRooms()
        LoadFeatures()
        LoadOptions()
    End Sub

    Public Sub LoadRooms()
            'Dim aOptionList As New List(Of Options)

            myConnection = New OleDbConnection(myConnectionStr)
            myCommand = New OleDbCommand("SELECT tblRooms.RoomID, tblRooms.RoomName FROM tblRooms;", myConnection)

            Try
                myConnection.Open()
                myReader = myCommand.ExecuteReader

                Do While (myReader.Read)
                    Dim roomID As Integer = myReader.Item("RoomID")
                    Dim roomName As String = myReader.Item("RoomName")

                Dim myRoom As New Room(roomName, roomID, New List(Of Feature))

            Loop
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                myReader.Close()
                myConnection.Close()

            End Try


        End Sub


        Public Sub LoadFeatures()
        myConnection = New OleDbConnection(myConnectionStr)
        myCommand = New OleDbCommand("SELECT tblFeatures.FeatureID, tblFeatures.Feature, tblFeatures.RoomID From tblFeatures", myConnection)
        Dim myFeatureList As New List(Of Feature)
        Try
            myConnection.Open()
            myReader = myCommand.ExecuteReader

            Do While (myReader.Read)
                Dim featureID As Integer = myReader.Item("FeatureID")
                Dim featureName As String = myReader.Item("Feature")
                Dim roomID As Integer = myReader.Item("RoomID")

                Dim myFeature As New Feature(featureName, featureID, roomID, New List(Of Options))
                myFeatureList.Add(myFeature)
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            myReader.Close()
            myConnection.Close()
            Session("FeatureSet") = myFeatureList

        End Try


    End Sub

    Public Sub LoadOptions()
        Dim aOptionList As New List(Of Options)

        myConnection = New OleDbConnection(myConnectionStr)
        myCommand = New OleDbCommand("SELECT tblOptions.FeatureID, tblOptions.UpgradeID, tblOptions.UpgradeName, tblOptions.UpgradePrice, tblOptions.Description
        FROM tblOptions GROUP BY tblOptions.FeatureID, tblOptions.UpgradeID, tblOptions.UpgradeName, tblOptions.UpgradePrice, tblOptions.Description", myConnection)

        Try
            myConnection.Open()
            myReader = myCommand.ExecuteReader

            Do While (myReader.Read)
                Dim OptionID As Integer = myReader.Item("UpgradeID")
                Dim OptionName As String = myReader.Item("UpgradeName")
                Dim OptionPrice As Double = myReader.Item("UpgradePrice")
                Dim OptionDescription As String = myReader.Item("Description")
                Dim OptionFeature As Integer = myReader.Item("FeatureID")
                aOptionList.Add(New Options(OptionID, OptionName, OptionPrice, OptionDescription, OptionFeature))

            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Session("OptionSet") = aOptionList
            Dim myFeatureList As New List(Of Feature)
            myFeatureList = Session("FeatureSet")
            For Each feat In myFeatureList
                For Each opt In aOptionList
                    If opt.getoptionfeature = feat.ID Then
                        feat.OptionList.Add(opt)
                    End If
                Next
            Next
            Session("FeatureSet") = myFeatureList
            myReader.Close()
            myConnection.Close()

        End Try


    End Sub

    Public Function GetAllHomesTable() As DataTable
        Dim myTable As New DataTable
        myConnection = New OleDbConnection(myConnectionStr)
        myCommand = New OleDbCommand("SELECT tblModelHomes.ModelHomeID, tblModelHomes.[# of Bedrooms], " &
                                     "tblModelHomes.[# of Bathrooms] FROM tblModelHomes", myConnection)
        myConnection.Open()
        myReader = myCommand.ExecuteReader
        myTable.Load(myReader)
        myReader.Close()
        myConnection.Close()
        Return myTable
    End Function


    Public Function GetHomeDetails(ByVal type As String, ByVal bed As Double, ByVal bath As Double) As DataTable
        Dim myTable As New DataTable
        myConnection = New OleDbConnection(myConnectionStr)
        myCommand = New OleDbCommand("SELECT tblHomeLayouts.Picture, tblHomeLayouts.ID,tblHomeLayouts.HouseName, tblHomeLayouts.Price
FROM tblHomeLayouts WHERE (((tblHomeLayouts.Style)=param1) AND ((tblHomeLayouts.Bedrooms)=param2) AND ((tblHomeLayouts.Bathrooms)=param3));", myConnection)
        myCommand.Parameters.AddWithValue("param1", type)
        myCommand.Parameters.AddWithValue("param2", bed)
        myCommand.Parameters.AddWithValue("param3", bath)
        myConnection.Open()
        myReader = myCommand.ExecuteReader
        myTable.Load(myReader)
        myReader.Close()
        myConnection.Close()
        Return myTable
    End Function

    Public Function GetHomeDetails() As DataTable

        Dim myTable As New DataTable
        myConnection = New OleDbConnection(myConnectionStr)
        myCommand = New OleDbCommand("SELECT tblHomeLayouts.Picture, tblHomeLayouts.ID, tblHomeLayouts.HouseName, tblHomeLayouts.Price, tblHomeLayouts.Bathrooms, tblHomeLayouts.Bedrooms, tblHomeLayouts.Style
FROM tblHomeLayouts;", myConnection)
        myConnection.Open()
        myReader = myCommand.ExecuteReader
        myTable.Load(myReader)
        myReader.Close()
        myConnection.Close()
        Return myTable
    End Function

    Public Function GetHomePicture(ByVal homeid As Integer) As DataTable
        Dim myTable As New DataTable
        myConnection = New OleDbConnection(myConnectionStr)
        myCommand = New OleDbCommand("SELECT tblHomeLayouts.Details FROM tblHomeLayouts WHERE (((tblHomeLayouts.ID)=param));", myConnection)
        myCommand.Parameters.AddWithValue("param", homeid)

        myConnection.Open()
        myReader = myCommand.ExecuteReader
        myTable.Load(myReader)
        myReader.Close()
        myConnection.Close()
        Return myTable
    End Function

    Public Sub LoadHomesLayouts()
        Dim aHomeList As New List(Of HomeLayouts)

        myConnection = New OleDbConnection(myConnectionStr)
        myCommand = New OleDbCommand("SELECT tblHomeLayouts.ID, tblHomeLayouts.HouseName, tblHomeLayouts.Bedrooms, tblHomeLayouts.Bathrooms, tblHomeLayouts.Price, tblHomeLayouts.SquareFeet, tblHomeLayouts.Style
FROM tblHomeLayouts;", myConnection)

        Try
            myConnection.Open()
            myReader = myCommand.ExecuteReader

            Do While (myReader.Read)
                Dim ID As Integer = myReader.Item("ID")
                Dim Name As String = myReader.Item("HouseName")
                Dim Bedroom As Double = myReader.Item("Bedrooms")
                Dim Bathroom As Double = myReader.Item("Bathrooms")
                Dim Price As Double = myReader.Item("Price")
                Dim Squarefeet As Double = myReader.Item("SquareFeet")
                Dim Style As String = myReader.Item("Style")

                aHomeList.Add(New HomeLayouts(ID, Name, Bedroom, Bathroom, Price, Squarefeet, Style))

            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Session("HomeSet") = aHomeList
            myReader.Close()
            myConnection.Close()

        End Try


    End Sub

    Public Function GetHomeObject(ByVal homeid As Integer) As HomeLayouts

        Dim chosenhome As HomeLayouts
        Dim allhomelist As List(Of HomeLayouts)
        allhomelist = Session("HomeSet")

        For Each chosenhome In allhomelist
            If chosenhome.gethomeID = homeid Then
                Return chosenhome
                Exit Function
            End If
        Next

        Return Nothing


    End Function

End Class
