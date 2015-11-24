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
        'Dim aOptionList As New List(Of Options)
        Dim myFeatureList As New List(Of Feature)
        myConnection = New OleDbConnection(myConnectionStr)
            myCommand = New OleDbCommand("SELECT tblFeatures.FeatureID, tblFeatures.Feature, tblFeatures.RoomID From tblFeatures", myConnection)

            Try
                myConnection.Open()
                myReader = myCommand.ExecuteReader

                Do While (myReader.Read)
                    Dim featureID As Integer = myReader.Item("UpgradeID")
                    Dim featureName As String = myReader.Item("Feature")
                    Dim roomID As Integer = myReader.Item("RoomID")

                Dim myFeature As New Feature(featureName, featureID, roomID, New List(Of Options))
                myFeatureList.add(myFeature)
                Session("FeatureSet") = myFeatureList
            Loop
        Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                myReader.Close()
                myConnection.Close()

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
                Session("OptionSet") = aOptionList
            Loop


        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally

            Dim myRelevantOptionList As New List(Of Options)
            Dim myFeatureList As New List(Of Feature)
            myFeatureList = Session("FeatureSet")
            For Each feat In myFeatureList
                For Each opt In aOptionList
                    If opt.getoptionfeature = feat.ID Then
                        myRelevantOptionList.Add(opt)
                    End If
                Next
                feat.OptionList = myRelevantOptionList
            Next
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


    Public Function GetHomeDetails(ByVal selectedID As Integer) As DataTable
        Dim myTable As New DataTable
        myConnection = New OleDbConnection(myConnectionStr)
        myCommand = New OleDbCommand("SELECT tblModelHomes.ModelHomeID, tblModelHomes.[# of Bedrooms], tblModelHomes.[# of Bathrooms], " &
                                     "tblModelHomes.[Square Footage], tblModelHomes.Description FROM tblModelHomes " &
                                     "WHERE ModelHomeID=param", myConnection)
        myCommand.Parameters.AddWithValue("param", selectedID)
        myConnection.Open()
        myReader = myCommand.ExecuteReader
        myTable.Load(myReader)
        myReader.Close()
        myConnection.Close()
        Return myTable
    End Function


End Class
