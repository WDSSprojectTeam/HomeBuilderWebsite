Imports Microsoft.VisualBasic
Imports System.Web.UI.DataVisualization.Charting
Imports System.Collections
Imports System

Public Class Comparison2Charter
    Private mychart As Chart
    Private mydal As COMPDAL

    Public Sub loaddata(ByVal datafromdb As COMPDAL)
        mydal = datafromdb
    End Sub

    Public Sub New(ByVal passedChart As Chart)
        mychart = passedChart
    End Sub


    Public Sub draw(ByVal scenarios As ArrayList, type As String)
        mychart.Titles.Clear()
        mychart.Series.Clear()
        Dim FontColor As New Title(type, Docking.Top, New System.Drawing.Font("cambria", 24, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black)
        mychart.Titles.Add(FontColor)

        setchartsize()
        setborderstyle()
        definechartarea()
        loadseriesdata(scenarios, type)


    End Sub

    Private Sub setchartsize()
        mychart.Height = 400
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
        charea = mychart.ChartAreas.Item(0)
        'charea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash
        ' charea.AxisX.LabelStyle.Font = New Drawing.Font("Cambria", 12)
        ' charea.AxisX.LabelStyle.Angle = -45

        charea.AxisX.TitleFont = New Drawing.Font("cambria", 18)
        charea.AxisX.Title = "Scenarios"
        '
        'charea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash
        'charea.AxisY.Interval = 1000
        '  charea.AxisY.Maximum = 500000
        '  charea.AxisY.Minimum = 0
        charea.AxisY.TitleFont = New Drawing.Font("cambria", 18)
        charea.AxisY.Title = "Cost"
    End Sub

    Private Sub loadseriesdata(ByVal identity As ArrayList, ByVal type As String)
        If type = "House" Then
            Dim holder As New ArrayList
            Dim xvalues As ArrayList = identity
            For i = 0 To identity.Count - 1
                holder.Add(mydal.gethousenamecost(mydal.gethousename(identity.Item(i))))
            Next
            Dim yvalues As ArrayList = holder
            addseries(xvalues, yvalues, Drawing.Color.Blue)
        ElseIf type = "FloorCost"
            Dim holder As New ArrayList
            Dim xvalues As ArrayList = identity
            For i = 0 To identity.Count - 1
                holder.Add(mydal.getfloorcost(identity.Item(i)))
            Next
            Dim yvalues As ArrayList = holder
            addseries(xvalues, yvalues, Drawing.Color.Blue)
        ElseIf type = "RoofCost"
            Dim holder As New ArrayList
            Dim xvalues As ArrayList = identity
            For i = 0 To identity.Count - 1
                holder.Add(mydal.getroofcost(identity.Item(i)))
            Next
            Dim yvalues As ArrayList = holder
            addseries(xvalues, yvalues, Drawing.Color.Blue)
        Else
            Dim holder As New ArrayList
            Dim xvalues As ArrayList = identity
            For i = 0 To identity.Count - 1
                holder.Add(mydal.getoptionstuff(type, identity.Item(i)))
            Next
            Dim yvalues As ArrayList = holder
            addseries(xvalues, yvalues, Drawing.Color.Blue)
        End If
    End Sub

    Private Sub addseries(ByVal exes As ArrayList, ByVal eyes As ArrayList, ByVal col As Drawing.Color)
        Dim myseries As New Series
        myseries.Points.DataBindXY(exes, eyes)
        myseries.ChartType = SeriesChartType.Column
        myseries.Color = col
        mychart.Series.Add(myseries)
    End Sub


End Class
