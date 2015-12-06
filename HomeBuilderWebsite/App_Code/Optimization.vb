Imports Microsoft.VisualBasic
Imports Microsoft.SolverFoundation.Services
Imports System.Collections.Generic

Public Class Optimization
    Inherits System.Web.UI.Page


    ' inputs
    Private myFeatureList As New List(Of Feature)
    Private myOptionList As New List(Of Options)
    Private myCostList As New List(Of Double)
    Private budget As Double
    Private featureUtility As New List(Of Integer)
    Private optionUtility As New List(Of Integer)
    ' model
    Private myModel As Model
    Private myDecisionList As New List(Of Decision)
    Private myFeatures As New List(Of Integer)
    Private myResultList As New List(Of OptimizationResults)



    Public Sub LoadData()
        myFeatureList = Session("FeatureSet")
        myOptionList = Session("OptionSet")

        For Each aFeature In myFeatureList
            featureUtility.Add(aFeature.Rating)
        Next

        For Each aOption In myOptionList
            optionUtility.Add(aOption.Preference)
        Next

        budget = Session("Budget")
        'MakeUpRatings()
    End Sub

    Public Sub Solve(ByVal Obj As Integer)   ' 1 >>> Max utility, 2 >>> Min Cost, 3 >> Max value
        ' creates a Solver and a Model
        Dim mySolverContext As SolverContext = SolverContext.GetContext

        myModel = mySolverContext.CreateModel
        LoadData()
        ' Decision variables
        AddDecisions()
        ' Constraints
        AddConstraints(Obj)
        ' Objective Function
        AddGoal()
        ' Solve
        mySolverContext.Solve()   ' or specifically    mySolverContext.Solve(New SimplexDirective)
        Results(Obj)
        mySolverContext.ClearModel()

    End Sub

    Public Function GetNumOfOptions(ByVal featureIndex As Integer) As Integer
        Dim Count As Integer = 0
        For j = 0 To myOptionList.Count - 1
            If (myFeatureList.Item(featureIndex).ID = myOptionList.Item(j).getoptionfeature) Then
                Count += 1
            End If
        Next
        Return Count
    End Function

    Public Function NormalCost() As List(Of Double)
        ' First get the list of price form optionlist
        Dim Data As New List(Of Double)
        For i = 0 To myOptionList.Count - 1
            Data.Add(myOptionList.Item(i).getoptionprice)
        Next

        ' get the mean
        Dim mean As Double = Data.Average()

        ' get the sd
        Dim sd As Double = 0
        Dim squares As New List(Of Double)
        Dim squareAvg As Double
        For Each value As Double In Data
            squares.Add(Math.Pow(value - mean, 2))
        Next
        squareAvg = squares.Average()
        sd = Math.Sqrt(squareAvg)

        ' return normalization cost list
        Dim normalList As New List(Of Double)
        For i = 0 To Data.Count - 1
            normalList.Add((Data.Item(i) - mean) / sd)
        Next
        Return normalList
    End Function

    Private Sub AddDecisions()
        Dim i As Integer
        Dim j As Integer
        For i = 0 To myFeatureList.Count - 1
            For j = 0 To myOptionList.Count - 1
                If (myFeatureList.Item(i).getID = myOptionList.Item(j).getoptionfeature) Then
                    Dim myDecision As New Decision(Domain.IntegerRange(0, 1), "X" & i & j)
                    myDecisionList.Add(myDecision)

                    ' adds Xij decision variables to the model
                    myModel.AddDecision(myDecision)
                    myFeatures.Add(i)
                End If
            Next
        Next
    End Sub

    Private Sub AddConstraints(ByVal obji As Integer)
        Dim i As Integer
        Dim j As Integer
        Dim XindexNow As Integer = 0  'Mark the Index we have scanned

        ' Sum(Xij) = 1 
        For i = 0 To myFeatureList.Count - 1
            Dim myChoice As Term = 0
            Dim constraintName As String = myFeatureList.Item(i).Name & "_has_options"
            For j = 0 To myOptionList.Count - 1

                If j + XindexNow > 28 Then
                    Exit For
                End If
                If (myFeatureList.Item(i).getID = myOptionList.Item(j).getoptionfeature) Then
                    Dim optionInfeature As Decision = myDecisionList.Item(j + XindexNow)

                    myChoice += optionInfeature
                End If
            Next

            myModel.AddConstraint(constraintName & obji, myChoice = 1)
            ' refresh the index of Xij
            'XindexNow += GetNumOfOptions(i + 1)
        Next

        'Just make sure clear all
        i = 0
        j = 0
        XindexNow = 0

        ' SumSum(CijXij) <= B

        Dim myFeatureCost As Term = 0
        For i = 0 To myOptionList.Count - 1

            Dim myCost = myOptionList.Item(i).getoptionprice
            '.CalculateTotalPrice
            Dim X As Decision = myDecisionList.Item(i)
            myFeatureCost += myCost * X
        Next
        myModel.AddConstraint("Constraint2" & i & obji, myFeatureCost <= budget * (0.8 + ((obji - 1) * 0.05)))

        'For i = 0 To myFeatureList.Count - 1
        '    Dim myFeatureCost As Term = 0
        '    For j = 0 To myOptionList.Count - 1
        '        Dim myCost As Double = 0
        '        If (myFeatureList.Item(i).getID = myOptionList.Item(j).getoptionfeature) Then
        '            'myCost = NormalCost().Item(j + XindexNow)
        '            myCost = myOptionList.Item(j).CalculateTotalPrice
        '            Dim X As Decision = myDecisionList.Item(j + XindexNow)
        '            myFeatureCost += myCost * X
        '        End If
        '    Next
        '    ' refresh the index of Xij
        '    'XindexNow += GetNumOfOptions(i)
        '    myModel.AddConstraint("Constraint2" & i & obji, myFeatureCost <= budget * (0.8 + ((obji - 1) * 0.05)))
        'Next


    End Sub

    Private Sub AddGoal()
        Dim i As Integer
        Dim j As Integer
        Dim myObj1 As Term = 0
        Dim myObj2 As Term = 0
        Dim myObj3 As Term = 0
        Dim XindexNow As Integer = 0
        ' objectives 1st max sumsum UiUjXij
        'If (OptObj = 1) Then
        For i = 0 To myFeatureList.Count - 1

            For j = 0 To myOptionList.Count - 1
                If (myFeatureList.Item(i).getID = myOptionList.Item(j).getFeatureID) Then
                    myObj1 += featureUtility.Item(i) * optionUtility.Item(j) * myDecisionList.Item(j + XindexNow)
                End If
            Next
            ' refresh the index of Xij
            'XindexNow += GetNumOfOptions(i)
        Next
        myModel.AddGoal("MaximizeUtility", GoalKind.Maximize, myObj1)
        'End If

        ' objectives 2nd min sumsum CijXij
        'If (OptObj = 2) Then
        '    For i = 0 To myFeatureList.Count - 1
        '        For j = 0 To myOptionList.Count - 1
        '            Dim myCost As Double = 0
        '            If (myFeatureList.Item(i).ID = myOptionList.Item(j).getoptionfeature) Then
        '                myCost = NormalCost().Item(j + XindexNow)
        '                Dim X As Decision = myDecisionList.Item(j + XindexNow)
        '                myObj2 += myCost * X
        '            End If
        '        Next
        '        ' refresh the index of Xij
        '        'XindexNow += GetNumOfOptions(i)
        '    Next
        '    myModel.AddGoal("MinimizeCost", GoalKind.Minimize, myObj2)
        'End If


        ' objectives 3th max sumsum UiUjXij/Cij
        'If (OptObj = 3) Then
        '    For i = 0 To myFeatureList.Count - 1
        '        For j = 0 To myOptionList.Count - 1
        '            Dim myCost As Double = 0
        '            If (myFeatureList.Item(i).ID = myOptionList.Item(j).getoptionfeature) Then
        '                myCost = NormalCost().Item(j + XindexNow)
        '                Dim X As Decision = myDecisionList.Item(j + XindexNow)
        '                myObj3 += featureUtility.Item(i) * optionUtility.Item(j) * X / myCost
        '            End If
        '        Next
        '        ' refresh the index of Xij
        '        'XindexNow += GetNumOfOptions(i)
        '    Next
        '    myModel.AddGoal("MaximizeValue", GoalKind.Maximize, myObj3)
        'End If
    End Sub

    Public Sub Results(ByVal obj As Integer)
        If (Session("Results") IsNot Nothing) Then
            myResultList = Session("Results")
        End If
        Dim objName As String
        Dim perc As Integer = 80 + ((obj - 1) * 5)
        objName = perc.ToString & "% of Budget"

        myResultList.Add(New OptimizationResults(objName, myDecisionList))
        Session("Results") = myResultList


    End Sub

    Public Sub MakeUpRatings()
        Dim myFeatures As List(Of Feature) = Session("FeatureSet")
        Dim myOptions As List(Of Options) = Session("OptionSet")
        myFeatures.Item(0).Rating = 3
        myFeatures.Item(1).Rating = 2
        myFeatures.Item(2).Rating = 3
        myFeatures.Item(3).Rating = 3
        myFeatures.Item(4).Rating = 2
        myFeatures.Item(5).Rating = 2
        myFeatures.Item(6).Rating = 1
        myFeatures.Item(7).Rating = 1

        myOptions.Item(0).Preference = 1
        myOptions.Item(1).Preference = 2
        myOptions.Item(2).Preference = 3
        myOptions.Item(3).Preference = 5
        myOptions.Item(4).Preference = 2
        myOptions.Item(5).Preference = 3
        myOptions.Item(6).Preference = 4
        myOptions.Item(7).Preference = 1
        myOptions.Item(8).Preference = 1
        myOptions.Item(9).Preference = 2
        myOptions.Item(10).Preference = 3
        myOptions.Item(11).Preference = 5
        myOptions.Item(12).Preference = 1
        myOptions.Item(13).Preference = 2
        myOptions.Item(14).Preference = 3
        myOptions.Item(15).Preference = 1
        myOptions.Item(16).Preference = 2
        myOptions.Item(17).Preference = 1
        myOptions.Item(18).Preference = 4
        myOptions.Item(19).Preference = 4
        myOptions.Item(20).Preference = 1
        myOptions.Item(21).Preference = 2
        myOptions.Item(22).Preference = 4
        myOptions.Item(23).Preference = 1
        myOptions.Item(24).Preference = 3
        myOptions.Item(25).Preference = 1
        myOptions.Item(26).Preference = 2
        myOptions.Item(27).Preference = 2
    End Sub


End Class
