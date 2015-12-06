Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.OleDb

Public Class HomeLayouts

    Inherits System.Web.UI.Page


    Private houseID As Integer
    Private Name As String
    Private Bedroom As Double
    Private Bathroom As Double
    Private Price As Double
    Private Squarefeet As Double
    Private Style As String

    Public Sub New(ByVal homeid As Integer, ByVal homename As String, ByVal homebedroom As Double, ByVal homebathroom As Double, ByVal homeprice As Double, ByVal homesqft As Double, ByVal homestyle As String)

        houseID = homeid
        Name = homename
        Bedroom = homebedroom
        Bathroom = homebathroom
        Price = homeprice
        Squarefeet = homesqft
        Style = homestyle

    End Sub

    Public Function GetHomeObject(ByVal homeid As Integer) As HomeLayouts

        Dim chosenhome As HomeLayouts
        Dim allhomelist As List(Of HomeLayouts)
        allhomelist = Session("HomeSet")

        For Each chosenhome In allhomelist
            If houseID = homeid Then
                Return chosenhome
                Exit Function
            End If
        Next

        Return Nothing


    End Function



    Public ReadOnly Property gethomeID As Integer
        Get
            Return houseID
        End Get
    End Property


End Class
