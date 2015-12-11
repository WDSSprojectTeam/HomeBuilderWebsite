
Imports System.Web.UI.Datavisualization.Charting


Public Class ResultChart
    Inherits Page

    Private mychart As Chart
    Private myOptResults As New List(Of OptimizationResults)
    Private myFeatureList As List(Of Feature) = Session("FeatureSet")
    Private xlist, ylist As New ArrayList
    Private index As Integer

    Public Sub New(ByVal chartstodraw As Chart, ByVal i As Integer)
        mychart = chartstodraw
        index = i
    End Sub

    Public Sub LoadData(ByVal optResults As List(Of OptimizationResults))
        myOptResults = optResults
    End Sub

    Public Sub DrawOptResults()

        mychart.Titles.Clear()
        mychart.Titles.Add("Compare Budget Options")
        SetChartSize()
            SetBorderStyle()
        DefineChartArea()
        'AddLegend()

        For i = 0 To myOptResults.Count - 1
            LoadSeriesData(myOptResults.Item(i))
        Next

        AddSeries(xlist, ylist)

    End Sub

    Private Sub SetChartSize()
        mychart.Height = 500
        mychart.Width = 700
    End Sub

    Private Sub SetBorderStyle()
        mychart.BorderlineColor = Drawing.Color.Black
        mychart.BorderlineWidth = 2
        mychart.BorderlineDashStyle = ChartDashStyle.Solid
        mychart.BackColor = Drawing.Color.Beige
    End Sub

    Private Sub DefineChartArea()
        Dim chArea As New ChartArea
        Dim myHome As HomeLayouts = Session("SelectedHome")
        chArea = mychart.ChartAreas.Item(0)
        ' x-axis
        chArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash
        chArea.AxisX.Interval = 10000
        chArea.AxisX.Maximum = Math.Round(myOptResults.Item(8).getTotalCost / 10000, 0) * 10000 + 10000 + myHome.Price
        chArea.AxisX.Minimum = Math.Round(myOptResults.Item(0).getTotalCost / 10000, 0) * 10000 - 10000 + myHome.Price
        chArea.AxisX.LabelStyle.Font = New Drawing.Font("Arial", 12)
        chArea.AxisX.LabelStyle.Angle = -45
        chArea.AxisX.TitleFont = New Drawing.Font("Courier New", 12)
        chArea.AxisX.Title = "House Option Cost"
        ' y-axis
        chArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash
        chArea.AxisY.Interval = 5

        If (myOptResults.Item(8).getTotalUtility / myOptResults.Item(8).getMaxUtility) > 1 Then
            chArea.AxisY.Maximum = 100
        Else
            chArea.AxisY.Maximum = Math.Round(myOptResults.Item(8).getTotalUtility / myOptResults.Item(8).getMaxUtility, 1) * 100 + 10
        End If

        chArea.AxisY.Minimum = Math.Round(myOptResults.Item(0).getTotalUtility / myOptResults.Item(0).getMaxUtility, 1) * 100 - 10
        chArea.AxisY.TitleFont = New Drawing.Font("Courier New", 12)
        chArea.AxisY.Title = "Percent of Maximum Utility"


    End Sub

    'Private Sub AddLegend()
    '    myChart.Legends.Clear()
    '    Dim myLegend As New Legend("Credit Legend")
    '    myChart.Legends.Add(myLegend)
    '    myLegend.Title = "Credit Hours"
    '    myLegend.Docking = Docking.Right
    'End Sub

    Private Sub AddSeries(ByVal x As ArrayList, ByVal y As ArrayList)
        Dim mySeries As New Series
        mySeries.Points.DataBindXY(x, y)
        mySeries.ChartType = SeriesChartType.Point
        mySeries.Color = Drawing.Color.Blue
        For i = 0 To 7
            mySeries.Points.Item(i).MarkerSize = 10
            mySeries.Points.Item(i).MarkerImage = "~/Images/kirli.JPG"
            'mySeries.Points.Item(i).MarkerStyle = MarkerStyle.Circle
        Next

        If index <> 10000 Then
            mySeries.Points.Item(index).Color = Drawing.Color.Orange
        End If

        mySeries.PostBackValue = "#SERIESNAME,#VALX"
        mychart.Series.Add(mySeries)
    End Sub

    Private Sub LoadSeriesData(ByVal aopt As OptimizationResults)
        mychart.Series.Clear()
        Dim myHome As HomeLayouts = Session("SelectedHome")
        Dim xValue As Double = aopt.getTotalCost + myHome.Price
        Dim yValue As Double = aopt.getTotalUtility / aopt.getMaxUtility * 100
        xlist.Add(xValue)
        ylist.Add(yValue)
        Session("OptBudgets") = xlist
        'Dim sum As Integer
        'Dim budget As Integer
        'budget = Session("Budget")
        'Dim xValues As ArrayList = aopt.getOptionList
        'xValues.Add("Remaining")


        'Dim yValues As New ArrayList
        'For i = 0 To myFeatureList.Count - 1
        '    yValues.Add(aopt.featureCost(i) / budget)
        '    sum += aopt.featureCost(i)
        'Next
        'yValues.Add(1 - sum / budget)
        'AddSeries(xValues, yValues)



    End Sub


End Class
