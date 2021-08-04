Public Class frmIndividual


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' close the form
        Close()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Declaration of variables

        Dim dblPhoneSubTotal As Double
        Dim dblTax As Double
        Dim dblPhoneTotal As Double
        Dim dblOptions As Double
        Dim dblPackageChange As Double
        Dim dblTotalMonthly As Double

        ' Calculation
        Call CalculationIndividualCost(dblPhoneSubTotal, dblTax, dblPhoneTotal, dblOptions, dblPackageChange, dblTotalMonthly)
        ' Displau outputs
        Call DisplayOutputs(dblPhoneSubTotal, dblTax, dblPhoneTotal, dblOptions, dblPackageChange, dblTotalMonthly)


    End Sub

    Private Sub CalculationIndividualCost(ByRef dblPhoneSubTotal As Double, ByRef dblTax As Double, ByRef dblPhoneTotal As Double, ByRef dblOptions As Double, ByRef dblPackageChange As Double, ByRef dblTotalMonthly As Double)
        Dim dblPhoneCost As Double

        dblPhoneCost = CalculatePhoneCost(radModel100, radModel110, radModel200)
        dblPhoneSubTotal = dblPhoneCost
        dblTax = CalculateTax(dblPhoneCost)
        dblPhoneTotal = CalculatePhoneTotal(dblPhoneCost, dblTax)
        dblOptions = CalculateOptionCost(ckbEmail, ckbTextMessaging)
        dblPackageChange = CalculatePackageCost(rad1500Minutes, rad800Minutes, radUnlimitedMinutes)
        dblTotalMonthly = CalculateTotalMontly(dblPhoneTotal, dblOptions, dblPackageChange)

    End Sub



    Private Sub DisplayOutputs(ByVal dblPhoneSubTotal As Double, ByVal dblTax As Double, ByVal dblPhoneTotal As Double, ByVal dblOptions As Double, ByVal dblPackageChange As Double, ByVal dblTotalMonthly As Double)
        lblPhoneSubTotal.Text = dblPhoneSubTotal.ToString("c")
        lblTax.Text = dblTax.ToString("c")
        lblPhoneTotal.Text = dblPhoneTotal.ToString("c")
        lblOptions.Text = dblOptions.ToString("c")
        lblPackageChange.Text = dblPackageChange.ToString("c")
        lblTotalMonthly.Text = dblTotalMonthly.ToString("c")
    End Sub
End Class