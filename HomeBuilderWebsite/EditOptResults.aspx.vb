Imports Microsoft.VisualBasic
Imports System.data

Partial Class EditOptResults
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim myResults As List(Of OptimizationResults) = Session("Results")
        Dim check As Integer = Session("Chart")
        Dim myChosenOptions As List(Of Integer) = Session("chosenOptions")
        Dim displayList As New DataTable
        Dim myOptionList As List(Of Options) = Session("optionSet")

        displayList.columns.add("Feature")
        displayList.Columns.Add("Name")
        displayList.Columns.Add("Description")
        displayList.Columns.Add("Price")
        displayList.Columns.Add("Preference")

        For i = 0 To myOptionList.Count - 1
            For j = 0 To myChosenOptions.Count - 1
                If myOptionList.Item(i).getoptionID = myChosenOptions.Item(j) Then
                    Dim list As New ArrayList
                    displayList.Rows.Add()
                    displayList.Rows(displayList.Rows.Count - 1)("Feature") = myOptionList.item(i).getFeatureName
                    displayList.Rows(displayList.Rows.Count - 1)("Name") = myOptionList.item(i).getoptionname
                    displayList.Rows(displayList.Rows.Count - 1)("Description") = myOptionList.Item(i).getoptiondescription
                    displayList.Rows(displayList.Rows.Count - 1)("Price") = myOptionList.Item(i).getoptionprice
                    displayList.Rows(displayList.Rows.Count - 1)("Preference") = myOptionList.Item(i).getFeaturePreference
                    'list.Add(myOptionList.Item(i).getoptionname)
                    'list.Add(myOptionList.Item(i).getoptiondescription)
                    'list.Add(myOptionList.Item(i).getoptionprice)
                    'displayList.Add(list)
                End If
            Next

        Next

        gvwEdit.DataSource = displayList
        gvwEdit.DataBind()
    End Sub

    Protected Sub gvwEdit_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gvwEdit.RowCommand
        Dim check As Integer = Session("Chart")
        Dim rowIndex As Integer = e.CommandArgument    ' which row
        Session("whichFeature") = rowIndex + 1
        Dim myResults As List(Of OptimizationResults) = Session("Results")

        Dim myChosenOptions As List(Of Integer) = Session("chosenOptions")
        Dim optID As Integer = myChosenOptions.Item(rowIndex)
        Dim myOptionSet As List(Of Options) = Session("OptionSet")

        For Each aOption In myOptionSet
            If aOption.getoptionID = optID Then
                Session("whichOption") = aOption
            End If
        Next

        Response.Redirect("EditFeature.aspx")

    End Sub
End Class
