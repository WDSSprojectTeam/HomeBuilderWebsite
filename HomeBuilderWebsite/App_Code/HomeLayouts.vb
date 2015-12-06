Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.OleDb

Public Class HomeLayouts

    Inherits System.Web.UI.Page


    Private houseID As Integer
    Private myName As String
    Private myBedroom As Double
    Private myBathroom As Double
    Private myPrice As Double
    Private mySquarefeet As Double
    Private myStyle As String

    Public Sub New()
    End Sub

    Public Sub New(ByVal homeid As Integer, ByVal homename As String, ByVal homebedroom As Double, ByVal homebathroom As Double, ByVal homeprice As Double, ByVal homesqft As Double, ByVal homestyle As String)

        houseID = homeid
        myName = homename
        myBedroom = homebedroom
        myBathroom = homebathroom
        myPrice = homeprice
        mySquarefeet = homesqft
        myStyle = homestyle

    End Sub

    Public ReadOnly Property gethomeID As Integer
        Get
            Return houseID
        End Get
    End Property

    Public ReadOnly Property Name
        Get
            Return myName
        End Get
    End Property

    Public ReadOnly Property NumberOfBedrooms
        Get
            Return myBedroom
        End Get
    End Property

    Public ReadOnly Property NumberOfBathrooms
        Get
            Return myBathroom
        End Get
    End Property

    Public ReadOnly Property Price
        Get
            Return myPrice
        End Get
    End Property

    Public ReadOnly Property SquareFeet
        Get
            Return mySquarefeet
        End Get
    End Property

    Public ReadOnly Property Style
        Get
            Return myStyle
        End Get
    End Property







End Class
