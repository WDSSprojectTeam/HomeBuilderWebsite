Imports Microsoft.VisualBasic
Imports System.Web.UI.DataVisualization.Charting



Public Class TempPieChart
    Inherits System.Web.UI.Page
    Private myChart As Chart
    Private myChosenOptions As List(Of Integer) = Session("chosenTemplateFeatures")
    Dim myOptionList As List(Of Options) = Session("optionSet")

    Public Sub New(ByVal ChartDrawing As Chart)
        myChart = ChartDrawing
    End Sub


    Public Sub Draw()

        myChart.Titles.Clear()
        myChart.Titles.Add("Budget Allocation by Option")

        SetChartSize()
        SetBorderStyle()
        DefineChartArea()
        AddLegend()
        CheckBoxtoData()

    End Sub


    Private Sub CheckBoxtoData()
        myChart.Series.Clear()
        Dim xvalues As New ArrayList
        Dim yvalues As New ArrayList

        For Each aOption In myOptionList
            For Each chosenOption In myChosenOptions
                If aOption.getoptionID = chosenOption Then
                    xvalues.Add(aOption.getoptionname)
                    yvalues.Add(aOption.getoptionprice)
                End If
            Next
        Next


        AddSeries(xvalues, yvalues, Drawing.Color.Blue)

        myChart.Series(0)("PieLabelStyle") = "Disabled"

    End Sub


    Private Sub AddSeries(ByVal x As ArrayList, ByVal y As ArrayList, ByVal color As Drawing.Color)

        Dim myseries As New Series

        ' myseries.Name = Legend
        ' myseries.LegendText = Legend
        myseries.Points.DataBindXY(x, y)
        myseries.ChartType = SeriesChartType.Pie
        myseries.Color = color

        myChart.Series.Add(myseries)


    End Sub

    Public Sub SetChartSize()
        myChart.Height = 500
        myChart.Width = 700
    End Sub

    Public Sub SetBorderStyle()

        myChart.BorderlineColor = Drawing.Color.Black
        myChart.BorderlineWidth = 2
        myChart.BorderlineDashStyle = ChartDashStyle.Solid
        myChart.BackColor = Drawing.Color.White

    End Sub

    Public Sub DefineChartArea()
        Dim charea As New ChartArea

        myChart.ChartAreas.Add(charea)

        charea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash
        charea.AxisX.LabelStyle.Font = New Drawing.Font("Cambria", 12)
        charea.AxisX.LabelStyle.Angle = -45
        charea.AxisX.TitleFont = New Drawing.Font("Cambria", 12)
        charea.AxisX.Title = "Options"

        charea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash
        charea.AxisY.Interval = 1000
        charea.AxisY.Maximum = 500000
        charea.AxisY.Minimum = 0
        charea.AxisY.TitleFont = New Drawing.Font("Cambria", 12)
        charea.AxisY.Title = "Dollars Allocation"



    End Sub

    Public Sub AddLegend()
        myChart.Legends.Clear()
        Dim mylegend As New Legend("Options Legend")
        myChart.Legends.Add(mylegend)

        mylegend.Title = "Options"
        mylegend.Docking = Docking.Right
    End Sub




End Class
