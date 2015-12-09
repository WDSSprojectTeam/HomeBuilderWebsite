
Partial Class EditFeature
    Inherits System.Web.UI.Page

End Class


'    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
'        Dim myFeature As Integer = Session("whichFeature")
'        Dim myOption As Options = Session("whichOption")
'        Dim myFeatureSet As List(Of Feature) = Session("FeatureSet")
'        Dim myOptionList As List(Of Options) = Session("OptionSet")
'        Dim myChosenOptions As List(Of Integer) = Session("chosenOptions")
'        Dim panelCount As Integer = 0
'        For Each aFeature In myFeatureSet
'            If aFeature.getID = myFeature Then
'                lblFeatureName.Text = aFeature.Name
'            End If
'        Next


'        For i = 0 To myOptionList.Count - 1
'            If myOptionList.Item(i).getFeatureID = myFeature Then
'                panelCount = panelCount + 1

'                If panelCount = 1 Then
'                    rdb1.Visible = True
'                    rdb1.Text = myOptionList.Item(i).getoptionname
'                    If myOptionList.Item(i).getoptionname = myOption.getoptionname Then
'                        rdb1.Checked = True
'                    End If

'                ElseIf panelCount = 2 Then
'                    rdb2.Visible = True
'                    rdb2.Text = myOptionList.Item(i).getoptionname
'                    If myOptionList.Item(i).getoptionname = myOption.getoptionname Then
'                        rdb2.Checked = True
'                    End If

'                ElseIf panelCount = 3 Then
'                    rdb3.Visible = True
'                    rdb3.Text = myOptionList.Item(i).getoptionname
'                    If myOptionList.Item(i).getoptionname = myOption.getoptionname Then
'                        rdb3.Checked = True
'                    End If

'                ElseIf panelCount = 4 Then
'                    rdb4.Visible = True
'                    rdb4.Text = myOptionList.Item(i).getoptionname
'                    If myOptionList.Item(i).getoptionname = myOption.getoptionname Then
'                        rdb4.Checked = True
'                    End If

'                ElseIf panelCount = 5 Then
'                    rdb5.Visible = True
'                    rdb5.Text = myOptionList.Item(i).getoptionname
'                    If myOptionList.Item(i).getoptionname = myOption.getoptionname Then
'                        rdb5.Checked = True
'                    End If


'                End If

'            End If
'        Next

'    End Sub

'    Protected Sub rdb1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb1.CheckedChanged, rdb2.CheckedChanged, rdb3.CheckedChanged, rdb4.CheckedChanged, rdb4.CheckedChanged
'        Dim check As String

'        'If rdb1.Checked = True Then
'        '    rdb1.Checked = False

'        'ElseIf rdb2.Checked = True
'        '    rdb2.Checked = False


'        'ElseIf rdb3.Checked = True
'        '    rdb3.Checked = False

'        'ElseIf rdb4.Checked = True
'        '    rdb4.Checked = False

'        'ElseIf rdb5.Checked = True
'        '    rdb5.Checked = False

'        'End If


'    End Sub

'    Private Sub ChangeChoice(ByVal checkText As String)
'        Dim myOptionList As List(Of Options) = Session("OptionSet")
'        Dim myChosenOptions As List(Of Integer) = Session("chosenOptions")
'        Dim myFeature As Integer = Session("whichFeature")
'        Dim myOption As Options

'        For i = 0 To myOptionList.Count - 1
'            If myOptionList.Item(i).getoptionname = checkText Then
'                myChosenOptions.Item(myFeature - 1) = myOptionList.Item(i).getoptionID
'                myOption = myOptionList.Item(i)
'            End If
'        Next
'        Session("whichOption") = myOption

'    End Sub

'    Protected Sub bntBack_Click(sender As Object, e As EventArgs) Handles bntBack.Click
'        Dim myFeature As Integer = Session("whichFeature")
'        Dim myOption As Options = Session("whichOption")
'        Dim myFeatureSet As List(Of Feature) = Session("FeatureSet")
'        Dim myOptionList As List(Of Options) = Session("OptionSet")
'        Dim myChosenOptions As List(Of Integer) = Session("chosenOptions")
'        Dim index As Int16

'        For i = 0 To myOptionList.Count - 1
'            If myOption.getoptionID = myOptionList.Item(i).getoptionID Then
'                index = i
'            End If
'        Next


'        Dim check As String

'        If rdb1.Checked = True And rdb1.Text IsNot myOptionList.Item(index).getoptionname Then
'            check = rdb1.Text

'        ElseIf rdb2.Checked = True And rdb2.Text IsNot myOptionList.Item(index).getoptionname
'            check = rdb2.Text


'        ElseIf rdb3.Checked = True And rdb3.Text IsNot myOptionList.Item(index).getoptionname
'            check = rdb3.Text

'        ElseIf rdb4.Checked = True And rdb4.Text IsNot myOptionList.Item(index).getoptionname
'            check = rdb1.Text

'        ElseIf rdb5.Checked = True And rdb5.Text IsNot myOptionList.Item(index).getoptionname
'            check = rdb5.Text

'        Else
'            check = myOptionList.Item(index).getoptionname
'        End If

'        ChangeChoice(check)
'        Response.Redirect("EditOptResults.aspx")
'    End Sub
'End Class
