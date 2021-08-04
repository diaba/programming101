Module modCellPhone

    Public blnBob As Boolean
    Public Function Calculate_Tax(ByVal dblPhoneSubTotal As Double) As Double
        Return dblPhoneSubTotal * 0.06
    End Function

    Public Function Calculate_Phone_Total(ByVal dblPhoneSubTotal As Double, ByVal dblTax As Double) As Double
        Return dblPhoneSubTotal + dblTax
    End Function

    Public Function Calculate_Total_Monthly(ByVal dblOptions As Double, ByVal dblPackageCharge As Double) As Double
        Return dblOptions + dblPackageCharge
    End Function
End Module
