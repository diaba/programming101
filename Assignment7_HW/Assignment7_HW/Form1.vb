
Public Class BilPhone
    '****************************************************************************************************************************************
    '
    '        Habsatou War      
    '      Assignment 7    
    'This program calculates the monthly bill for customers for a startup company that offers 3 monhtly plans and 2 optional features.
    '
    '****************************************************************************************************************************************
    Const dbl800Minutes As Double = 19.99
    Const dbl1500Minutes As Double = 29.99
    Const dblUnlimitedTalk As Double = 39.99
    Const dblSimsong As Double = 29.99
    Const dblIpound As Double = 39.99
    Const dblCustomerPhone As Double = 0
    Const dblUnlimitedText As Double = 10
    Const dblVideoChat As Double = 15
    Const dblTaxRate As Double = 0.075
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Variables
        Dim dblPlan As Double
        Dim dblPhones As Double
        Dim dblOptions As Double
        Dim dblSubTotal As Double
        Dim dblTotal As Double
        Dim dblTax As Double
        ' Calculating
        ' Calculate plan options
        If opt800.Checked = True Then          ' 800 minnutes for $19.99
            dblPlan = dbl800Minutes
        ElseIf opt1500.Checked = True Then      ' 1500 minutes for $29.99
            dblPlan = dbl1500Minutes
        ElseIf optUnlimitedTalk.Checked = True Then ' Unlimited talk for $39.99
            dblPlan = dblUnlimitedTalk
        End If
        ' Calculate Phone 
        If optSimsong.Checked = True Then     'Simsong AG for $29.99
            dblPhones = dblSimsong
        ElseIf optIpound.Checked = True Then    'Ipound Xv for $39.99
            dblPhones = dblIpound
        ElseIf optCustomerPhone.Checked Then    'Customer brings his own phone 
            dblPhones = dblCustomerPhone
        End If
        ' calculating options
        If chkUnlimitedText.Checked = True Then   'Unlimited text for $10
            dblOptions = dblUnlimitedText
            If chkVideoChat.Checked = True Then   'Video chat for $15
                dblOptions += dblVideoChat
            End If
        Else
            If chkVideoChat.Checked = True Then
                dblOptions += dblVideoChat
            End If
        End If
            'Calculations
            ' Monthly Subtotal
            dblSubTotal = dblPlan + dblPhones + dblOptions
        ' Tax
        dblTax = dblSubTotal * dblTaxRate
        ' Monthly Total
        dblTotal = dblSubTotal + dblTax
        'Display Outputs
        lblMonthlSubTotal.Text = FormatCurrency(dblSubTotal)
        lblTax.Text = FormatCurrency(dblTax)
        lblMonthlyTotal.Text = FormatCurrency(dblTotal)
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the application
        Me.Close()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Reset application
        lblMonthlSubTotal.ResetText()
        lblTax.ResetText()
        lblMonthlyTotal.ResetText()
        opt800.Checked = True             ' 800 minutes is the plan by default 
        optCustomerPhone.Checked = True   ' customer brings his own phone by default
    End Sub


End Class
