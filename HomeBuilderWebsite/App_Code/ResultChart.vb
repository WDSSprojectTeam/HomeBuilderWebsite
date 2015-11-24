
Imports System.Web.UI.Datavisualization.Charting


Public Class ResultChart
    Inherits Page

    Private mychart As Chart
    Private myOptResults As New List(Of OptimizationResults)
    Private myFeatureList As List(Of Feature) = Session("FeatureSet")
    Private xlist, ylist As New ArrayList

    Public Sub New(ByVal chartstodraw As Chart)
        mychart = chartstodraw
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
        mychart.Height = 300
        mychart.Width = 500
    End Sub

    Private Sub SetBorderStyle()
        mychart.BorderlineColor = Drawing.Color.Black
        mychart.BorderlineWidth = 2
        mychart.BorderlineDashStyle = ChartDashStyle.Solid
        mychart.BackColor = Drawing.Color.Beige
    End Sub

    Private Sub DefineChartArea()
        Dim chArea As New ChartArea
        mychart.ChartAreas.Add(chArea)
        ' x-axis
        chArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash
        chArea.AxisX.LabelStyle.Font = New Drawing.Font("Arial", 12)
        chArea.AxisX.LabelStyle.Angle = -45
        chArea.AxisX.TitleFont = New Drawing.Font("Courier New", 12)
        chArea.AxisX.Title = "House Options"
        ' y-axis
        chArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash
        chArea.AxisY.Interval = 1
        chArea.AxisY.Maximum = 10
        chArea.AxisY.Minimum = 0
        chArea.AxisY.TitleFont = New Drawing.Font("Courier New", 12)
        chArea.AxisY.Title = "Percent of Budget Spent in each Area"
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
        mySeries.ChartType = SeriesChartType.Line
        mySeries.Color = Drawing.Color.Blue
        mySeries.PostBackValue = "#SERIESNAME,#VALX"
        mychart.Series.Add(mySeries)
    End Sub

    Private Sub LoadSeriesData(ByVal aopt As OptimizationResults)
        mychart.Series.Clear()
        Dim xValue As String = aopt.getOptName
        Dim yValue As Double = aopt.getTotalUtility
        xlist.Add(xValue)
        ylist.Add(yValue)
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
