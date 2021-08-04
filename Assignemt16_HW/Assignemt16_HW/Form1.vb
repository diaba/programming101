Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    'Habsatou War - Assignment 16
    'Air line reimbursement Form
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Inputs declarations
        Dim intDays As Integer
        Dim dblAirTravelCost As Double
        Dim dblLodgingCost As Double
        Dim dblFoodCost As Double

        Dim dblTotalTravelCost As Double
        Dim dblReimbursementAmount As Double
        Dim dblEmployeeResponsible As Double

        Dim dblExtra As Double
        Dim dblTotalLodgingCost As Double
        Dim dblTotalFoodCost As Double

        ' set back color to white in case there were error put it yellow
        txtAirTravelCost.BackColor = Color.White
        txtDays.BackColor = Color.White
        txtFoodCost.BackColor = Color.White
        txtLodgingCost.BackColor = Color.White

        If ValidInput(intDays, dblAirTravelCost, dblLodgingCost, dblFoodCost) = True Then
            'Calculate Total travel cost
            dblTotalTravelCost = TravelCost(intDays, dblAirTravelCost)

            'Calculate Total Lodging cost
            dblTotalLodgingCost = TotalLodging(intDays, dblAirTravelCost, dblExtra, dblLodgingCost)

            'Calculate Total Food cost
            dblTotalFoodCost = TotalFoodCost(intDays, dblTotalTravelCost, dblExtra, dblFoodCost)

            'Calulate Amount Reimbursed by company
            dblReimbursementAmount = dblTotalLodgingCost + dblTotalFoodCost

            'Extra :Employee has to pay when no reimbursement allowed
            'Total Employee responsible Amount
            dblEmployeeResponsible = dblTotalTravelCost - dblReimbursementAmount + dblExtra

            'Display
            lblTotalTravelCost.Text = dblTotalTravelCost.ToString("c")
            lblReimbursementbyCompany.Text = dblReimbursementAmount.ToString("c")
            lblEmployeeResponsible.Text = dblEmployeeResponsible.ToString("c")   '
        End If
    End Sub


    Private Function TotalFoodCost(ByVal intday As Integer, ByVal amount As Double, ByRef extra As Double, ByVal dblFood As Double) As Double
        Dim foodcost As Double

        If radManagment.Checked = True Then
            foodcost = 75.0 * intday
        Else
            foodcost = 50.0 * intday
        End If
        If amount >= 400 Then
            Return foodcost
        Else
            extra = extra + dblFood
            Return 0
        End If

    End Function

    Private Function TotalLodging(ByVal intday As Integer, ByVal amount As Double, ByRef extra As Double, ByVal dblLodging As Double) As Double
        Dim lodgingcost As Double

        If radManagment.Checked = True Then
            lodgingcost = 125.0 * intday
        Else
            lodgingcost = 100.0 * intday
        End If
        If amount >= 400 Then
            Return lodgingcost
        Else
            extra = extra + dblLodging
            Return 0
        End If

    End Function

    Private Function TravelCost(ByVal intDays As Integer, ByVal dblAirTravelCost As Double) As Double
        Return intDays * dblAirTravelCost
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
