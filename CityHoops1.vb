Option Explicit On
Option Strict On

Imports System.Text.RegularExpressions
Imports System.Windows.Forms
'Name : CityHoops.vb
'Description: Displaying basketball game statistics
'Author: Prince Nlombi
Public Class frmCityHoops1
    Private Sub doBasketball()
        Dim sName As String = ""
        Dim iPointsScored As Integer = 0
        Dim iNumberOfFouls As Integer = 0
        Dim sGender As String = ""
        Dim iHighestPoints As Integer = 0
        Dim iHighestFouls As Integer = 0
        Dim iCounter As Integer = 0
        Dim iGrandPoint As Integer = 0
        Dim iGrandFoul As Integer = 0
        'Integer are for numbers and Strings are for letters'
        'Implementing subroutines'
        Dim bAllFieldsValid As Boolean = True
        sName = CStr(txtName.Text)
        iPointsScored = CInt(txtPointsScored.Text)
        iNumberOfFouls = CInt(txtNumberOfFouls.Text)
        lbxName.Items.Add(sName)
        lbxpointsscored.Items.Add(iPointsScored)
        lbxNumberOfFouls.Items.Add(iNumberOfFouls)
        sGender = CStr(txtGender.Text)
        lbxGender.Items.Add(sGender)
        'Integer are for numbers and Strings are for letters'
    End Sub
    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        Call doBasketball()
        'Inputting basketball information after typed
        If IsNumeric(txtPointsScored.Text) Then
            Debug.Print("value is numeric")
        Else
            Debug.Print("value is not numeric")
        End If
        Dim Pattern As Regex = New Regex("^[a-zA-Z]+$")
        'Validation of letters and numbers'
        If Pattern.IsMatch(txtGender.Text) Then
            MsgBox("value is alphanumeric")
        Else MsgBox("No Numbers in Genders")
        End If
        Dim Patterns As Regex = New Regex("^[0-6]+$")
        'Validation of letters and numbers'
        If Patterns.IsMatch(TxtNumberOfFouls.Text) Then
            MsgBox("value is alphanumeric")
        Else MsgBox("Players can only get 6 fouls per game")
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lbxName.Items.Clear()
        lbxNumberOfFouls.Items.Clear()
        lbxPointsScored.Items.Clear()
        lbxGender.Items.Clear()
        lblGrandFoul.Text = ""
        lblGrandPoint.Text = ""
        lblHighestFouls.Text = ""
        lblHighestPoints.Text = ""
        'Since listbox is not the same function as label, clear functions are different
        Call makeTextBoxesWhite()
    End Sub
    Private Sub makeTextBoxesWhite()
        txtname.BackColor = Color.White
        TxtNumberOfFouls.BackColor = Color.White
        txtPointsScored.BackColor = Color.White
        txtGender.BackColor = Color.White
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If lbxNumberOfFouls.Items.Count > 0 And lbxPointsScored.Items.Count > 0 Then
            Call doCalucations()
        Else MsgBox("error")
            'scores and fouls must be more than 0 to caluculate'
        End If
    End Sub
    Private Sub doCalucations()
        Call getHighestPoints()
        Call getHighestFouls()
        Call getGrandPoint()
        Call getGrandFoul()
        'calculating statistics'
    End Sub
    Private Sub getHighestPoints()
        Dim iHighestPoints As Integer = 0
        Dim iCounter As Integer = 0
        Dim iPointsScored As Integer = 0
        Dim iTempVal As Integer = 0

        iPointsScored = lbxPointsScored.Items.Count
        While iCounter < iPointsScored
            iTempVal = CInt(lbxPointsScored.Items(iCounter))
            If iTempVal > iHighestPoints Then
                iHighestPoints = iTempVal
            End If
            iCounter = iCounter + 1
        End While
        lblHighestPoints.Text = CStr(iHighestPoints)
        'System calulcates which of the points from each player is the highest for each game'
    End Sub
    Private Sub getHighestFouls()
        Dim iHighestFouls As Integer = 0
        Dim iCounter As Integer = 0
        Dim iNumberofFouls As Integer = 0
        Dim iTempVal As Integer = 0

        iNumberofFouls = lbxNumberOfFouls.Items.Count
        While iCounter < iNumberofFouls
            iTempVal = CInt(lbxNumberOfFouls.Items(iCounter))
            If iTempVal > iHighestFouls Then
                iHighestFouls = iTempVal
            End If
            iCounter = iCounter + 1
        End While
        lblHighestFouls.Text = CStr(iHighestFouls)
        'System calulcates which of the fouls from each player is the highest for each game'
    End Sub
    Private Sub getGrandPoint()
        Dim iGrandPoint As Integer = lbxPointsScored.Items.Count
        Dim iEvaluate As Integer = 0
        Dim iCounter As Integer = 0
        Dim iPointsScored As Integer = 0

        iPointsScored = lbxPointsScored.Items.Count

        iGrandPoint = 0
        For iCounter = 0 To (iPointsScored - 1)
            iEvaluate = CInt(lbxPointsScored.Items(iCounter))
            If iEvaluate > 0 Then
                iGrandPoint = iGrandPoint + iEvaluate
            End If
        Next
        lblGrandPoint.Text = CStr(iGrandPoint)
        'System calulcates the total points for the game'
    End Sub
    Private Sub getGrandFoul()
        Dim iGrandFoul As Integer = lbxNumberOfFouls.Items.Count
        Dim iEvaluate As Integer = 0
        Dim iCounter As Integer = 0
        Dim iNumberofFouls As Integer = 0

        iNumberofFouls = lbxNumberOfFouls.Items.Count

        iGrandFoul = 0
        For iCounter = 0 To (iNumberofFouls - 1)
            iEvaluate = CInt(lbxNumberOfFouls.Items(iCounter))
            If iEvaluate > 0 Then
                iGrandFoul = iGrandFoul + iEvaluate
            End If
        Next
        lblGrandFoul.Text = CStr(iGrandFoul)
        'system calculates the total fouls for the game"
    End Sub
End Class
