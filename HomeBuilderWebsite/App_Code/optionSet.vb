Imports System.Collections.Generic
Imports System.Web.UI
Imports Microsoft.VisualBasic

Public Class optionSet
    Inherits Page
    Private myOptionList As List(Of Options)

    Public Sub New(ByVal optionList As List(Of Options))

        myOptionList = optionList

    End Sub

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
