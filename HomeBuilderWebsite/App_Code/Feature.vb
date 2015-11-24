Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Collections

Public Class Feature

    Inherits System.Web.UI.Page

    Private myOptionList As New List(Of Options)
    Private FeatureName As String
    Private FeatureID As Integer
    Private PreferenceRating As Integer
    Private RoomID As Integer

    Public Sub New(ByVal name As String, ByVal ID As Integer, ByVal roomidd As Integer, ByVal list As List(Of Options))

        FeatureName = name
        FeatureID = ID
        myOptionList = list
        PreferenceRating = 3
        RoomID = roomidd

    End Sub



    ReadOnly Property Name As String
        Get
            Return FeatureName
        End Get
    End Property

    ReadOnly Property getID As String
        Get
            Return FeatureID
        End Get
    End Property

    Property Rating As Integer
        Get
            Return PreferenceRating
        End Get

        Set(passedRating As Integer)
            PreferenceRating = passedRating
        End Set
    End Property

    Property OptionList As List(Of Options)
        Get
            Return myOptionList
        End Get

        Set(passedList As List(Of Options))
            myOptionList = passedList
        End Set
    End Property

    Public Function getfeature(ByVal featureid As Integer)
        Throw New NotImplementedException

        Dim myfeaturelist As List(Of Feature)
        myfeaturelist = Session("FeatureSet")
        For Each feature In myfeaturelist

        Next

    End Function


    Public Sub Addtofeaturelist(ByVal anoption As Options)
        OptionList.Add(anoption)
    End Sub

    Public Function Getfeaturelist() As ArrayList

        Dim allfeatures As New ArrayList
        Dim anoption As Options
        For Each anoption In OptionList
            If (Not allfeatures.Contains(anoption.getoptionfeature)) Then
                allfeatures.Add(anoption.getoptionfeature)
            End If
        Next
        Return allfeatures

    End Function

    Public Function GetName(ByVal name As String) As Options
        Dim myOption As Options
        For Each myOption In myOptionList
            If myOption.getoptionname = name Then
                Return myOption
            End If
        Next
        Return Nothing
    End Function
End Class
