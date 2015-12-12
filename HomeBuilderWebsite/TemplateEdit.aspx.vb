

Imports System.Data

Partial Class TemplateEdit
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        rdb1.Visible = False
        rdb2.Visible = False
        rdb3.Visible = False
        rdb4.Visible = False
        rdb5.Visible = False
        Dim myOptionList As List(Of Options) = Session("OptionSet")
        Dim myChosenOptions As List(Of Integer)
        Dim myTable As DataTable = Session("myTemplate")
        Session("chosenTemplateFeatures") = myChosenOptions
        Dim index As Integer = Session("whichTemplate")
        Dim displayList As New DataTable
        displayList.Columns.Add("Feature")
        displayList.Columns.Add("Name")
        displayList.Columns.Add("Description")
        displayList.Columns.Add("Price")


        For i = 4 To 13

            myChosenOptions.Add(myTable.Rows(index).Item(i))

        Next


        For i = 0 To myOptionList.Count - 1
            For j = 0 To myChosenOptions.Count - 1
                If myOptionList.Item(i).getoptionID = myChosenOptions.Item(j) Then
                    Dim list As New ArrayList
                    displayList.Rows.Add()
                    displayList.Rows(displayList.Rows.Count - 1)("Feature") = myOptionList.Item(i).getFeatureName
                    displayList.Rows(displayList.Rows.Count - 1)("Name") = myOptionList.Item(i).getoptionname
                    displayList.Rows(displayList.Rows.Count - 1)("Description") = myOptionList.Item(i).getoptiondescription
                    displayList.Rows(displayList.Rows.Count - 1)("Price") = myOptionList.Item(i).getoptionprice

                End If
            Next

        Next
        gvwEditTemplate.DataSource = displayList
        gvwEditTemplate.DataBind()
    End Sub
    Protected Sub gvwEditTemplate_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gvwEditTemplate.RowCommand

        Dim rowIndex As Integer = e.CommandArgument
        Dim myOptionList As List(Of Options) = Session("OptionSet")
        Dim myFeatureList As List(Of Feature) = Session("FeatureSet")
        Dim optCount As Integer = 0
        Dim myChosenOptions As List(Of Integer) = Session("chosenTemplateFeatures")

        lblFeatureName.Visible = True
        lblFeatureName.Text = myFeatureList.Item(rowIndex).Name

        For i = 0 To myOptionList.Count - 1
            If myOptionList.Item(i).getFeatureID = rowIndex + 1 Then
                optCount += 1

                If optCount = 1 Then
                    rdb1.Text = myOptionList.Item(i).getoptionname
                    rdb1.Visible = True
                    If myOptionList.Item(i).getoptionID = myChosenOptions.Item(rowIndex) Then
                        rdb1.Checked = True
                    End If

                ElseIf optCount = 2 Then
                    rdb2.Text = myOptionList.Item(i).getoptionname
                    rdb2.Visible = True
                    If myOptionList.Item(i).getoptionID = myChosenOptions.Item(rowIndex) Then
                        rdb2.Checked = True
                    End If

                ElseIf optCount = 3 Then
                    rdb3.Text = myOptionList.Item(i).getoptionname
                    rdb3.Visible = True
                    If myOptionList.Item(i).getoptionID = myChosenOptions.Item(rowIndex) Then
                        rdb3.Checked = True
                    End If

                ElseIf optCount = 4 Then
                    rdb4.Text = myOptionList.Item(i).getoptionname
                    rdb4.Visible = True
                    If myOptionList.Item(i).getoptionID = myChosenOptions.Item(rowIndex) Then
                        rdb4.Checked = True
                    End If

                ElseIf optCount = 5 Then
                    rdb5.Text = myOptionList.Item(i).getoptionname
                    rdb5.Visible = True
                    If myOptionList.Item(i).getoptionID = myChosenOptions.Item(rowIndex) Then
                        rdb5.Checked = True
                    End If
                End If





            End If
        Next




    End Sub

    Protected Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    End Sub
End Class
