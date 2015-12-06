Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Web.UI

Public Class Options
    Inherits Page
    Private ID As Integer
    Private Name As String
    Private Price As Double
    Private Description As String
    Private FeatureID As Integer
    Private PreferenceRating As Integer
    Private myNeed As Boolean

    Public Sub New(ByVal optid As Integer, ByVal optname As String, ByVal optprice As Double, ByVal optdescription As String, ByVal optfeature As String)

        ID = optid
        Name = optname
        Price = optprice
        Description = optdescription
        FeatureID = optfeature
        PreferenceRating = 3
        myNeed = False

    End Sub

    Public ReadOnly Property getoptionID As Integer
        Get
            Return ID
        End Get
    End Property

    Public ReadOnly Property getFeatureID As Integer
        Get
            Return FeatureID
        End Get
    End Property

    Public ReadOnly Property getoptionname As String
        Get
            Return Name
        End Get
    End Property

    Public ReadOnly Property getoptionprice As Double
        Get
            Dim myPrice As Double = Price
            Dim myHomeList As New List(Of HomeLayouts)


            'If (ID = 21 Or ID = ) Then
            Return myPrice
        End Get
    End Property

    Public Function CalculateTotalPrice(ByVal squarefeet As Double) As Double
        Dim totalprice As Double

        'will add something here once we decide how we categorize homes

        Return totalprice
    End Function

    Public ReadOnly Property getoptiondescription As String
        Get
            Return Description
        End Get
    End Property

    Public ReadOnly Property getoptionfeature As String
        Get
            Return FeatureID
        End Get
    End Property

    Public Property Preference As Integer
        Get
            Return PreferenceRating
        End Get

        Set(passedRating As Integer)
            PreferenceRating = passedRating
        End Set
    End Property

    Public Property Need As Boolean
        Get
            Return myNeed
        End Get

        Set(aneed As Boolean)
            myNeed = aneed
        End Set
    End Property

    Public Function getFeatureName() As String
        Dim name As String = ""
        Dim myFeatureList As List(Of Feature) = Session("FeatureSet")
        For Each aFeature In myFeatureList
            If FeatureID = aFeature.getID Then
                name = aFeature.Name
            End If
        Next

        Return name
    End Function





End Class
