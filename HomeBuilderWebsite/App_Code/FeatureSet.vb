Imports System.Collections.Generic
Imports System.Web.UI
Imports Microsoft.VisualBasic

Public Class FeatureSet
    Inherits Page
    Private myFeatureList As List(Of Feature)

    Public Sub New()

    End Sub

    Public Sub New(ByVal featureList As List(Of Feature))

        myFeatureList = featureList

    End Sub


    Public Function GetFeature(ByVal Fname As String) As Feature
        Dim myFeature As Feature
        Dim myFeatureList As List(Of Feature)
        myFeatureList = Session("FeatureSet")
        For Each myFeature In myFeatureList
            If myFeature.Name = Fname Then
                Return myFeature
            End If
        Next
        Return Nothing
    End Function
End Class
