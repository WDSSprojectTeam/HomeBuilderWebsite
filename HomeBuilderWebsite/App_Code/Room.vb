Imports Microsoft.VisualBasic

Public Class Room
    Private RoomList As New List(Of Feature)
    Private RoomName As String
    Private RoomID As Integer

    Public Sub New(ByVal name As String, ByVal ID As Integer, ByVal list As List(Of Feature))

        RoomName = name
        RoomID = ID
        RoomList = list

    End Sub

    Public Sub Addtoroomlist(ByVal afeature As Feature)
        RoomList.Add(afeature)
    End Sub
End Class
