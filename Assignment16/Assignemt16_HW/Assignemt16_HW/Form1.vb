Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    'Habsatou War - Assignment 16
    'Air line reimbursement Form

    ' Per Diem
    ' Management
    Dim dblManagementAireFarePerDiem As Double = 500.0
    Dim dblManagementLodgePerDiem As Double = 125.0
    Dim dblManagementFoodPerDiem As Double = 75.0

    ' Non Management 
    Dim dblNonManagementAireFarePerDiem As Double = 400.0
    Dim dblNonManagementLodgePerDiem As Double = 100.0
    Dim dblNonManagementFoodPerDiem As Double = 50.0
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Inputs declarations
        Dim intDays As Integer
        Dim dblAirTravelCost As Double
        Dim dblTotalLodgingCost As Double
        Dim dblTotalFoodCost As Double

        Dim dblTotalTravelCost As Double
        Dim dblReimbursementAmount As Double
        Dim dblEmployeeResponsible As Double


        ' set back color to white in case there were error put it yellow
        txtAirTravelCost.BackColor = Color.White
        txtDays.BackColor = Color.White
        txtFoodCost.BackColor = Color.White
        txtLodgingCost.BackColor = Color.White

        If ValidInput(intDays, dblAirTravelCost, dblTotalLodgingCost, dblTotalFoodCost) = True Then
            'Calculate Total travel cost
            dblTotalTravelCost = TotalTravelCost(dblAirTravelCost, dblTotalLodgingCost, dblTotalFoodCost)

            'Calulate Amount Reimbursed by company
            dblReimbursementAmount = ReimbursementAmount(intDays)

            'Total Employee responsible Amount
            dblEmployeeResponsible = dblTotalTravelCost - dblReimbursementAmount
            If dblEmployeeResponsible < 0 Then
                dblEmployeeResponsible = 0
            End If

            'Display
            lblTotalTravelCost.Text = dblTotalTravelCost.ToString("c")
            lblReimbursementbyCompany.Text = dblReimbursementAmount.ToString("c")
            lblEmployeeResponsible.Text = dblEmployeeResponsible.ToString("c")   '
        End If
    End Sub

    Private Function ReimbursementAmount(ByVal intDays As Integer) As Double
        If radManagment.Checked = True Then
            Return (dblManagementFoodPerDiem + dblManagementLodgePerDiem) * intDays + dblManagementAireFarePerDiem
        ElseIf radNonManagement.Checked = True Then
            Return (dblNonManagementFoodPerDiem + dblNonManagementLodgePerDiem) * intDays + dblNonManagementAireFarePerDiem
        End If
    End Function

    Private Function TotalTravelCost(ByVal dblAirTravelCost As Double, ByVal dblTotalLodgingCost As Double, ByVal dblTotalFoodCost As Double) As Double
        Return dblAirTravelCost + dblTotalFoodCost + dblTotalLodgingCost
    End Function

    Private Function ValidInput(ByRef intDays As Integer, ByRef dblAirTravelCost As Double, ByRef dblLodgingCost As Double, ByRef dblFoodCost As Double) As Boolean
        Dim valid As Boolean
        If ValidDays(intDays) = True Then
            If validAirTravelCost(dblAirTravelCost) = True Then
                If ValidLodgingCost(dblLodgingCost) = True Then
                    If ValidFoodCost(dblFoodCost) = True Then
                        valid = True
                    End If
                Else
                    valid = False
                End If
            Else
                valid = False
            End If
        Else
            valid = False
        End If
        Return valid
    End Function

    Private Function ValidFoodCost(ByRef dblFoodCost As Double) As Boolean
        If IsNumeric(txtFoodCost.Text) = True Then
            dblFoodCost = txtFoodCost.Text
            Return True
        Else
            txtFoodCost.BackColor = Color.Yellow
            txtFoodCost.Focus()
            MessageBox.Show("Enter only number")
            Return False
        End If
    End Function

    Private Function ValidLodgingCost(ByRef dblLodgingCost As Double) As Boolean
        If IsNumeric(txtLodgingCost.Text) = True Then
            dblLodgingCost = txtLodgingCost.Text
            Return True
        Else
            txtLodgingCost.BackColor = Color.Yellow
            txtLodgingCost.Focus()
            MessageBox.Show("Enter only number")
            Return False
        End If
    End Function

    Private Function ValidAirTravelCost(ByRef dblAirTravelCost As Double) As Boolean
        If IsNumeric(txtAirTravelCost.Text) = True Then
            dblAirTravelCost = txtAirTravelCost.Text
            Return True
        Else
            txtAirTravelCost.BackColor = Color.Yellow
            txtAirTravelCost.Focus()
            MessageBox.Show("Enter number only")
            Return False
        End If
    End Function

    Private Function ValidDays(ByRef intDays As Integer) As Boolean
        If IsNumeric(txtDays.Text) = True Then
            intDays = txtDays.Text
            Return True
        Else
            txtDays.BackColor = Color.Yellow
            txtDays.Focus()
            MessageBox.Show("Please enter only number")
            Return False
        End If
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all inputs and outputs set by default the status
        txtAirTravelCost.ResetText()
        txtDays.ResetText()
        txtFoodCost.ResetText()
        txtLodgingCost.ResetText()

        lblEmployeeResponsible.ResetText()
        lblReimbursementbyCompany.ResetText()
        lblTotalTravelCost.ResetText()

        radNonManagement.Checked = True
    End Sub


End Class
