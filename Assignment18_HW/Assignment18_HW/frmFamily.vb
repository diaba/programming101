Public Class frmFamily
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Close the form
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

        Dim intNumberOfPhone As Integer
        Dim blnValidated As Boolean

        Call Get_ValidInput(intNumberOfPhone, blnValidated)

        If blnValidated = True Then
            ' Calculation
            Call CalculationFamilyCost(intNumberOfPhone, dblPhoneSubTotal, dblTax, dblPhoneTotal, dblOptions, dblPackageChange, dblTotalMonthly)
            ' Displau outputs
            Call DisplayOutputs(dblPhoneSubTotal, dblTax, dblPhoneTotal, dblOptions, dblPackageChange, dblTotalMonthly)
        End If
    End Sub

    Private Sub Get_ValidInput(ByRef dblNumberOfPhone As Double, ByRef blnValid As Boolean)
        Call ValidateNumberOfPhone(dblNumberOfPhone, blnValid)
    End Sub

    Private Sub ValidateNumberOfPhone(ByRef dblNumberOfPhone As Double, ByRef blnValid As Boolean)
        If IsNumeric(txtNumberOfPhones.Text) Then
            dblNumberOfPhone = txtNumberOfPhones.Text
            If dblNumberOfPhone < 2 Then
                MessageBox.Show("Number must be greater than 1")
                txtNumberOfPhones.Focus()
                blnValid = False
            Else
                blnValid = True
            End If
        Else
            MessageBox.Show("Number of Phones Must be Numeric")
            txtNumberOfPhones.Focus()
            blnValid = False
        End If
    End Sub

    Private Sub DisplayOutputs(ByVal dblPhoneSubTotal As Double, ByVal dblTax As Double, ByVal dblPhoneTotal As Double, ByVal dblOptions As Double, ByVal dblPackageChange As Double, ByVal dblTotalMonthly As Double)
        lblPhoneSubTotql.Text = dblPhoneSubTotal.ToString("c")
        lblTax.Text = dblTax.ToString("c")
        lblPhoneTotal.Text = dblPhoneTotal.ToString("c")
        lblOptions.Text = dblOptions.ToString("c")
        lblPackageChange.Text = dblPackageChange.ToString("c")
        lblTotalMonthly.Text = dblTotalMonthly.ToString("c")
    End Sub

    Private Sub CalculationFamilyCost(ByVal intNumberOfPhone As Integer, ByRef dblPhoneSubTotal As Double, ByRef dblTax As Double, ByRef dblPhoneTotal As Double, ByRef dblOptions As Double, ByRef dblPackageChange As Double, ByRef dblTotalMonthly As Double)
        Dim dblPhoneCost As Double
        dblPhoneCost = intNumberOfPhone * CalculatePhoneCost(radModel100, radModel110, radModel200)
        dblPhoneSubTotal = dblPhoneCost
        dblTax = CalculateTax(dblPhoneCost)
        dblPhoneTotal = CalculatePhoneTotal(dblPhoneCost, dblTax)
        dblOptions = CalculateOptionCost(ckbEmail, ckbTextMessaging)
        dblPackageChange = CalculatePackageCost(rad1500Minutes, rad800Minutes, radUnlimitedMinutes)
        dblTotalMonthly = CalculateTotalMontly(dblPhoneTotal, dblOptions, dblPackageChange)
    End Sub
End Class