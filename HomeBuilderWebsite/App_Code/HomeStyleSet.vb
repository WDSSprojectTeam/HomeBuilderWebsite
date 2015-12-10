Imports Microsoft.VisualBasic

Public Class HomeStyleSet

    Private homestyleset As New List(Of HomeLayouts)

    Public Sub Add(ByVal ahome As HomeLayouts)
        homestyleset.Add(ahome)
    End Sub


    Public Function Filterbybedrooms(ByVal bedrooms As Double) As HomeStyleSet

        Dim listofhomes As New HomeStyleSet
        Dim ahome As HomeLayouts
        For Each ahome In homestyleset
            If (ahome.NumberOfBedrooms = bedrooms) Then
                listofhomes.Add(ahome)
            End If
        Next
        Return listofhomes

    End Function

    Public Function Filterbybathrooms(ByVal bathrooms As Double) As HomeStyleSet

        Dim listofhomes As New HomeStyleSet
        Dim ahome As HomeLayouts
        For Each ahome In homestyleset
            If (ahome.NumberOfBedrooms = bathrooms) Then
                listofhomes.Add(ahome)
            End If
        Next
        Return listofhomes

    End Function

    Public Function Filterbystyle(ByVal style As String) As HomeStyleSet

        Dim listofhomes As New HomeStyleSet
        Dim ahome As HomeLayouts
        For Each ahome In homestyleset
            If (ahome.NumberOfBedrooms = style) Then
                listofhomes.Add(ahome)
            End If
        Next
        Return listofhomes

    End Function



End Class
