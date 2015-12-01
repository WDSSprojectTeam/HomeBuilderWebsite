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
        mychart.Titles.Add("Scenario Cost Breakdown")
        setchartsize()
        setborderstyle()
        definechartarea()
        loadseriesdata(iden)
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

    Private Sub definechartarea()
        Dim charea As New ChartArea
        mychart.ChartAreas.Add(charea)
        charea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash
        charea.AxisX.LabelStyle.Font = New Drawing.Font("Cambria", 12)
        charea.AxisX.LabelStyle.Angle = -45
        charea.AxisX.TitleFont = New Drawing.Font("cambria", 12)
        charea.AxisX.Title = "Elements"

        charea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash
        charea.AxisY.Interval = 1000
        charea.AxisY.Maximum = 500000
        charea.AxisY.Minimum = 0
        charea.AxisY.TitleFont = New Drawing.Font("cambria", 12)
        charea.AxisY.Title = "Cost"
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
