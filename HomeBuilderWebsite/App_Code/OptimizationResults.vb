
Imports Microsoft.SolverFoundation.Services

Public Class OptimizationResults
    Inherits Page

    Private myChoiceList As New List(Of Decision)
    Private myOptionList As New List(Of Options)
    Private myFeatureList As New List(Of Feature)
    Private myFeatures As New List(Of Integer)
    Private optName As String

    Public Sub New(ByVal name As String, ByVal choices As List(Of Decision))
        optName = name
        myChoiceList = choices
        myOptionList = Session("OptionSet")
        myFeatureList = Session("FeatureSet")
        For i = 0 To myOptionList.Count - 1
            myFeatures.Add(myOptionList.Item(i).getFeatureID)
        Next

    End Sub

    Public Function featureCost(ByVal featureID As Integer) As Integer
        Dim c As Integer = 0
        For i = 0 To myChoiceList.Count - 1
            If myChoiceList.Item(i).ToDouble = 1 And myFeatures(i) = featureID Then
                c = myOptionList.Item(i).getoptionprice
            End If
        Next

        Return c
    End Function

    Public Function getTotalUtility() As Double
        Dim utility As Double = 0
        Dim featUtility As Integer = 0
        For i = 0 To myChoiceList.Count - 1
            For Each aFeature In myFeatureList
                If myOptionList.Item(i).getFeatureID = aFeature.getID Then
                    featUtility = aFeature.Rating
                End If
            Next
            utility += myChoiceList.Item(i).ToDouble * myOptionList.Item(i).Preference * featUtility
        Next

        Return utility
    End Function

    Public Function getOption(ByVal index As Integer) As Options
        Return myOptionList.Item(index)
    End Function

    Public Function getOptName() As String
        Return optName
    End Function

    Public Function getOptionList() As ArrayList
        Dim list As New ArrayList
        For Each aOption In myOptionList
            list.Add(aOption.getoptionname)
        Next
        Return list
    End Function

    Public Function getSelectedOptions() As ArrayList
        Dim List As New ArrayList
        For i = 0 To myOptionList.Count - 1
            If myChoiceList.Item(i).ToDouble = 1 Then
                List.Add(myOptionList.Item(i))
            End If
        Next

        Return List
    End Function

    Public Function getChoices() As ArrayList
        Dim list As New ArrayList
        For Each aChoice In myChoiceList
            list.Add(aChoice.ToDouble)
        Next
        Return list
    End Function



End Class
