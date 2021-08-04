Public Class Form1

    '*****************************************************************************************************************************************************
    '  Habsatou War                   
    '  Assignment 8                    ------------
    ' This program calculates the cost of its software package license based on purchase or yearly lease and an optional service.
    '******************************************************************************************************************************************************
    ' Constant declarations
    Const dblPurchasePrice As Double = 25000
    Const dblLeasePrice As Double = 5000
    Const dblSupportPrice As Double = 3800
    Const dblTrainingPrice As Double = 2200
    Const dblBackupServerPrice As Double = 550

    Dim dblOngoingYearsCost As Double
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Variables
        Dim dblFirstYearCost As Double

        Dim dblSoftwarePrice As Double
        Dim dblOptionsPrice As Double

        'Calculations
        ' Check out Software
        If optPurchase.Checked = True Then
            dblSoftwarePrice = dblPurchasePrice
        ElseIf optLease.Checked = True Then
            dblSoftwarePrice = dblLeasePrice
        End If
        ' Determine Options
        If chkSupport.Checked = True Then
            dblOptionsPrice = dblSupportPrice
        End If
        If chkTraining.Checked = True Then
            dblOptionsPrice += dblTrainingPrice
        End If
        If chkBackupServer.Checked = True Then
            dblOptionsPrice += dblBackupServerPrice
        End If
        'Calculating 
        dblFirstYearCost = dblSoftwarePrice + dblOptionsPrice
        dblOngoingYearsCost += dblFirstYearCost
        'Display outputs
        If lblFirstYear.Text = "" Then
            lblFirstYear.Text = FormatCurrency(dblFirstYearCost)
            lblOngoingPrice.Text = FormatCurrency(dblOngoingYearsCost)
        End If
        lblOngoingPrice.Text = FormatCurrency(dblOngoingYearsCost)
    End Sub
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'reset selections
        optLease.Checked = True
        chkBackupServer.Checked = False
        chkSupport.Checked = False
        chkTraining.Checked = False
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Exit the application
        Me.Close()

    End Sub


End Class
