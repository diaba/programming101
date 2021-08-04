Module modPlan

    ' Tax
    Const dblTax As Double = 0.06

    ' Packages plan cost
    Dim dbl800MinutesPerMonth As Double = 45.0
    Dim dbl1500MinutesPerMonth As Double = 65.0
    Dim dblUnlimitedMinutesPerMonth As Double = 99.0

    ' Options cost
    Dim dblEmail As Double = 25.0
    Dim dblUnlimitedTexting As Double = 10.0

    ' Phone modeles cost
    Dim dblModel100 As Double = 29.95
    Dim dblModel110 As Double = 49.95
    Dim dblModel200 As Double = 99.95
    Public Function CalculateTotalMontly(ByVal PhoneTotal As Double, ByVal OptionCost As Double, ByVal PackageCost As Double) As Double
        Return PhoneTotal + OptionCost + PackageCost
    End Function

    Public Function CalculatePhoneTotal(ByVal PhoneSubTotal As Double, ByVal Tax As Double) As Double
        Return PhoneSubTotal + Tax
    End Function

    Public Function CalculateTax(ByVal PhoneCost As Double) As Double
        Return dblTax * PhoneCost
    End Function

    Public Function CalculatePhoneCost(ByVal radModel100 As RadioButton, ByVal radModel110 As RadioButton, ByVal radModel200 As RadioButton) As Double
        Dim PhoneCost As Double
        If radModel100.Checked = True Then
            PhoneCost = dblModel100
        ElseIf radModel110.Checked = True Then
            PhoneCost = dblModel110
        ElseIf radModel200.Checked = True Then
            PhoneCost = dblModel200
        End If
        Return PhoneCost
    End Function

    Public Function CalculatePackageCost(ByVal rad1500Minutes As RadioButton, ByVal rad800Minutes As RadioButton, ByVal radUnlimitedMinutes As RadioButton) As Double
        Dim PackageCost As Double
        If rad1500Minutes.Checked = True Then
            PackageCost = dbl1500MinutesPerMonth
        ElseIf rad800Minutes.Checked = True Then
            PackageCost = dbl800MinutesPerMonth
        ElseIf radUnlimitedMinutes.Checked = True Then
            PackageCost = dblUnlimitedMinutesPerMonth
        End If
        Return PackageCost
    End Function

    Public Function CalculateOptionCost(ByVal ckbEmail As CheckBox, ByVal ckbTextMessaging As CheckBox) As Double
        Dim OptionCost As Double
        If ckbEmail.Checked = True Then
            OptionCost = dblEmail
            If ckbTextMessaging.Checked = True Then
                OptionCost += dblUnlimitedTexting
            End If
        ElseIf ckbTextMessaging.Checked = True Then
            OptionCost = dblUnlimitedTexting
        End If
        Return OptionCost
    End Function

End Module
