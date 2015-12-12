Imports Microsoft.VisualBasic

Imports System.Web.UI.DataVisualization.Charting
Imports System.Collections
Imports System


Public Class Comparison2Charter2
    Private mychart As Chart
    Private mydal As COMPDAL
    Private xlist, ylist, identitty As New ArrayList

    Public Sub loaddata(ByVal datafromdb As COMPDAL)
        mydal = datafromdb
    End Sub

    Public Sub New(ByVal passedChart As Chart)
        mychart = passedChart
    End Sub



    Public Sub draw(ByVal scenarios As ArrayList)
        mychart.Titles.Clear()
        mychart.Series.Clear()
        Dim FontColor As New Title("Scenario Comparison", Docking.Top, New System.Drawing.Font("cambria", 24, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black)
        mychart.Titles.Add(FontColor)
        setchartsize()
        SetBorderStyle()
        DefineChartArea()

        For i = 1 To scenarios.Count

            LoadSeriesData(i)
        Next

        AddSeries(xlist, ylist, identitty)
    End Sub

    Private Sub setchartsize()
        mychart.Height = 400
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

        chArea = mychart.ChartAreas.Item(0)
        ' x-axis
        chArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash
        chArea.AxisX.LabelStyle.Font = New Drawing.Font("Arial", 18)
        'chArea.AxisX.LabelStyle.Angle = -45
        chArea.AxisX.TitleFont = New Drawing.Font("Courier New", 18)
        chArea.AxisX.Title = "Scenario Cost ($)"
        ' y-axis
        chArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash
        '  chArea.AxisY.Interval = 10
        '  chArea.AxisY.Maximum = 80
        ' chArea.AxisY.Minimum = 0
        chArea.AxisY.TitleFont = New Drawing.Font("Courier New", 14)
        chArea.AxisY.Title = "Percent of Maximum Utility (%)"


    End Sub

    Private Sub AddSeries(ByVal x As ArrayList, ByVal y As ArrayList, ByVal idtit As ArrayList)
        Dim mySeries As New Series
        mySeries.Points.DataBindXY(x, y)
        mySeries.ChartType = SeriesChartType.Point
        mySeries.Color = Drawing.Color.Blue
        For i = 0 To idtit.Count - 1
            mySeries.Points.Item(i).Label = idtit.Item(i)
            mySeries.Points.Item(i).MarkerStyle = MarkerStyle.Circle
            mySeries.Points.Item(i).MarkerSize = 15
        Next

        mychart.Series.Add(mySeries)

    End Sub

    Private Sub LoadSeriesData(ByVal ident As Integer)
        mychart.Series.Clear()

        Dim xValue As Double = mydal.gettotalcost(ident)
        Dim yValue As Double = mydal.getutility(ident)
        xlist.Add(xValue)
        ylist.Add(yValue)
        identitty.Add(ident)



    End Sub



End Class
