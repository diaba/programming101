Public Class frmIndividual

    Private Sub btnCalculate_Click_1(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblPhoneSubTotal As Double
        Dim dblTax As Double
        Dim dblPhoneTotal As Double
        Dim dblOptions As Double
        Dim dblPackageCharge As Double
        Dim dblTotalMonthly As Double

        Calculate_Cell_Phone_Package_Cost(dblPhoneSubTotal, dblTax, dblPhoneTotal, dblOptions, dblPackageCharge, dblTotalMonthly)
        Display_Cell_Phone_Package_Totals(dblPhoneSubTotal, dblTax, dblPhoneTotal, dblOptions, dblPackageCharge, dblTotalMonthly)

    End Sub

    Private Sub Calculate_Cell_Phone_Package_Cost(ByRef dblPhoneSubTotal As Double, ByRef dblTax As Double, ByRef dblPhoneTotal As Double, ByRef dblOptions As Double, ByRef dblPackageCharge As Double, ByRef dblTotalMonthly As Double)
        dblPhoneSubTotal = Calculate_Phone_Subtotal()
        dblTax = Calculate_Tax(dblPhoneSubTotal)

        ' Explicit Convert the type
        dblPhoneTotal = CDbl(Calculate_Phone_Total(dblPhoneSubTotal, dblTax))
        dblOptions = Calculate_Options()
        dblPackageCharge = Calculate_Package_Charge()
        dblTotalMonthly = Calculate_Total_Monthly(dblOptions, dblPackageCharge)

    End Sub
    Private Function Calculate_Phone_Subtotal() As Double
        Dim dblPhonePrice As Double

        If radModel100.Checked Then
            dblPhonePrice = 29.95
        Else
            If radModel110.Checked Then
                dblPhonePrice = 49.95
            Else
                dblPhonePrice = 99.95
            End If

        End If

        Return dblPhonePrice

    End Function


    Private Function Calculate_Options() As Double
        Dim dblOptionPrice As Double

        If chkEmail.Checked Then
            dblOptionPrice = 25.0
        End If

        If chkText.Checked Then
            dblOptionPrice += 10.0
        End If

        Return dblOptionPrice
    End Function

    Private Function Calculate_Package_Charge() As Double
        Dim dblPackageCharge As Double

        If rad800Minutes.Checked Then
            dblPackageCharge = 45.0
        Else
            If rad1500Minutes.Checked Then
                dblPackageCharge = 65.0
            Else
                dblPackageCharge = 99.0
            End If
        End If

        Return dblPackageCharge

    End Function

    Private Sub Display_Cell_Phone_Package_Totals(ByVal dblPhoneSubTotal As Double, ByVal dblTax As Double, ByVal dblPhoneTotal As Double, ByVal dblOptions As Double, ByVal dblPackageCharge As Double, ByVal dblTotalMonthly As Double)
        lblPhoneSubTotal.Text = dblPhoneSubTotal.ToString("c")
        lbltax.Text = dblTax.ToString("c")
        lblPhoneTotal.Text = dblPhoneTotal.ToString("c")
        lblPackageCharge.Text = dblPackageCharge.ToString("c")
        lblOptions.Text = dblOptions.ToString("c")
        lblTotalMonthly.Text = dblTotalMonthly.ToString("c")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
