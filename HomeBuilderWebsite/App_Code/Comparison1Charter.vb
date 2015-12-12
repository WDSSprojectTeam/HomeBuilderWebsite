Imports Microsoft.VisualBasic
Imports System.Web.UI.DataVisualization.Charting
Imports System.Collections
Imports System

Public Class Comparison1Charter
    Private mychart As Chart
    Private mydal As COMPDAL

    Public Sub New(ByVal passedChart As Chart)
        mychart = passedChart
    End Sub

    Public Sub loaddata(ByVal datafromdb As COMPDAL)
        mydal = datafromdb
    End Sub

    Public Sub draw(ByVal iden As Integer)
        mychart.Titles.Clear()
        Dim FontColor As New Title("Scenario Cost Breakdown", Docking.Top, New System.Drawing.Font("cambria", 24, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black)
        mychart.Titles.Add(FontColor)
        setchartsize()
        setborderstyle()
        definechartarea()

        loadseriesdata(iden)
        AddLegend()
        mychart.Series(0)("PieLabelStyle") = "Disabled"
    End Sub

    Private Sub setchartsize()
        mychart.Height = 500
        mychart.Width = 500
    End Sub

    Private Sub setborderstyle()
        mychart.BorderlineColor = Drawing.Color.Black
        mychart.BorderlineWidth = 2
        mychart.BorderlineDashStyle = ChartDashStyle.Solid
        mychart.BackColor = Drawing.Color.White

    End Sub

    Public Sub AddLegend()
        mychart.Legends.Clear()
        Dim mylegend As New Legend("Elements Legend")
        mychart.Legends.Add(mylegend)

        mylegend.Title = "Elements"
        mylegend.Docking = Docking.Right
    End Sub

    Private Sub definechartarea()
        Dim charea As New ChartArea
        charea = mychart.ChartAreas.Item(0)
        'charea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash
        charea.AxisX.LabelStyle.Font = New Drawing.Font("Cambria", 12)
        ' charea.AxisX.LabelStyle.Angle = -45
        charea.AxisX.TitleFont = New Drawing.Font("cambria", 18)
        charea.AxisX.Title = "Elements"

        ' charea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash
        ' charea.AxisY.Interval = 1000
        'charea.AxisY.Maximum = 500000
        'charea.AxisY.Minimum = 0
        charea.AxisY.TitleFont = New Drawing.Font("cambria", 18)
        charea.AxisY.Title = "Cost ($)"
    End Sub

    Private Sub loadseriesdata(ByVal identity As Integer)
        mychart.Series.Clear()
        Dim xvalues As ArrayList = mydal.getscenarioparts(identity)
        Dim yvalues As ArrayList = mydal.getscenariocosts(identity)
        addseries(xvalues, yvalues, Drawing.Color.Red)

    End Sub

    Private Sub addseries(ByVal exes As ArrayList, ByVal eyes As ArrayList, ByVal col As Drawing.Color)
        Dim myseries As New Series
        myseries.Points.DataBindXY(exes, eyes)
        myseries.ChartType = SeriesChartType.Pie
        myseries.Color = col
        mychart.Series.Add(myseries)
    End Sub



End Class
