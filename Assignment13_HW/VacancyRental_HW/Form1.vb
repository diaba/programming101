Public Class Form1
    '*********************************************************************************
    '       Habsatou War
    '       Programming 1
    '       Assignment 13 Vacation Rental
    '       Update with new logic and debug test cases using all paths (Include)
    '*********************************************************************************   
    ' Cost af the season per day
    Dim dblOffSeasonCost As Double = 50
    Dim dblPeakSeasonCost As Double = 150
    Dim dblStandardSeasonCost As Double = 100

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Variables
        Dim dblSeasonCost As Double
        Dim strFirstName As String
        Dim strLastName As String
        Dim strPhone As String
        Dim strEmail As String
        Dim intRentalDay As Integer

        Dim dblDiscount As Double
        Dim dblSubTotal As Double
        Dim dblTax As Double
        Dim dblTotal As Double

        'Inputs
        'Get the season option
        If radOffSeason.Checked Then                                'Off season selected                  ****** 1
            dblSeasonCost = dblOffSeasonCost
        ElseIf radPeakSeaon.Checked Then                            'Peak season selected                 ****** 2
            dblSeasonCost = dblPeakSeasonCost
        ElseIf radStandard.Checked Then                             'Standard selected                    ****** 3
            dblSeasonCost = dblStandardSeasonCost
        End If

        If txtFirstName.Text = "" Then                                                                   ' ***** 4
            MessageBox.Show("Please enter First Name")             'Validate First Name
            txtFirstName.Focus()
            Exit Sub
        ElseIf txtLastName.Text = "" Then                                                                ' ***** 5
            MessageBox.Show("Please enter Last Name")              'Validate Last Name
            txtLastName.Focus()
            Exit Sub
        ElseIf txtEmail.Text = "" Then                               'Empty Email                         ****** 6
            MessageBox.Show("Please enter Email")                   'Validate Email
            txtEmail.Focus()
            Exit Sub
        ElseIf txtPhone.Text = "" Then                              'Empty phone                          ****** 7
            MessageBox.Show("Please enter Phone")                   'Validate Phone
            txtPhone.Focus()
            Exit Sub
        End If                                                                                            '**** 8
        'Validation of rental days
        If IsNumeric(txtRentalDays.Text) Then                       'days is numeric                     ****** 9
            intRentalDay = txtRentalDays.Text
            If intRentalDay < 1 Or intRentalDay > 59 Then            '59<days<1                          ****** 10
                MessageBox.Show("Please rental is greater than 0 and less than 60")
                txtRentalDays.Focus()
                Exit Sub
            End If                                                                                      '**** 11
        Else                                                          '0<days<60 or empty              ****** 12
            MessageBox.Show("Please enter rental days")
            txtRentalDays.Focus()
            Exit Sub
        End If
        'Validate  State
        If cmbState.SelectedIndex > -1 Then                           'state selected                ******* 13
            If cmbState.SelectedItem.ToString() = "Florida" Then      'florida selected              ******* 14
                dblTax = 0
            Else                                                      'other state selected          ******* 15
                dblTax = intRentalDay * dblSeasonCost * 0.1
            End If
        Else                                                          'state not selected           ******** 16
            MessageBox.Show("Select state")
            Exit Sub
        End If

        'Validate discount program 
        If cmbDiscount.SelectedIndex > -1 Then                         'Program discount selected     ****** 17
            If cmbDiscount.SelectedItem.ToString() = "None" Then       'No discount program selected  ****** 18
                dblDiscount = 0                                      'no discount
            Else                                                       'with a discount program selected *** 19
                dblDiscount = intRentalDay * dblSeasonCost * 0.025                      'Discount 2.5%
            End If
        Else                                                           'Nothing selected              ****** 20
            MessageBox.Show("Please Program")
            Exit Sub
        End If

        'Calculations
        If intRentalDay > 30 Then                                     'day>30                       ******* 21
            dblDiscount = dblDiscount + dblSeasonCost * 0.1 * intRentalDay
        ElseIf intRentalDay > 14 Then                                 'days>14                      ******* 22
            dblDiscount = dblDiscount + dblSeasonCost * 0.05 * intRentalDay
        End If                                                                                     '******* 23                                                                                

        dblSubTotal = dblSeasonCost * intRentalDay            'subtotal                     
        dblTotal = dblSubTotal + dblTax - dblDiscount
        If dblTotal > 300 Then                                        'discount final > 300        '******* 24
            dblTotal = dblTotal - 30
        ElseIf dblTotal > 200 Then                                    'discount final > 200        '******* 25
            dblTotal = dblTotal - 20
        ElseIf dblTotal > 50 Then                                     'discount final > 50         '******* 26
            dblTotal = dblTotal - 5
        End If                                                        'other                        ******* 27
        'Display
        lblSubTotal.Text = FormatCurrency(dblSubTotal)
        lblTax.Text = FormatCurrency(dblTax)
        lblTotal.Text = FormatCurrency(dblTotal)
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Clear all inputs and outputs
        radStandard.Checked = True
        txtFirstName.ResetText()          'first name
        txtLastName.ResetText()           'Last Name
        txtEmail.ResetText()              'Email
        txtPhone.ResetText()              'Phone
        txtRentalDays.ResetText()         'days
        cmbDiscount.ResetText()           'discount program
        cmbState.ResetText()              'state

        txtFirstName.Focus()
        lblSubTotal.ResetText()
        lblTax.ResetText()
        lblTotal.ResetText()
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDiscount.Items.Clear()                                     'Discount program populate
        cmbDiscount.Items.Add("AAA")
        cmbDiscount.Items.Add("AARP")
        cmbDiscount.Items.Add("None")

        cmbState.Items.Clear()
        cmbState.Items.Add("Alabama")                                 'State populate
        cmbState.Items.Add("Arizona")
        cmbState.Items.Add("California")
        cmbState.Items.Add("Florida")
        cmbState.Items.Add("Kentucky")
        cmbState.Items.Add("Ohio")
    End Sub


    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class

'************************************************************ Test cases **************************************************************************
'   TC1: Validations                                         Expected result                             Actual result 
'------------------------------------------------------------------------------------------------------------------------------------------
' FirstName: Habsatou                                           Sub total :                                    SubTotal : 
' LastName:  war                                                Tax  :                                         Tax : 
' Email  :  hwar@gmail.com                                      Total :                                        Total :  
' phone :    85963065988                                               
' state : ky None
' season : Standard
'------------------------------------------------------------------------------------------------------------------------------------------
' empty firstnane   Path : 3,4                               Please enter firstname                             Please  enter firstname
' empty last nane   Path : 3,5                               Please enter lastname                              Please  enter lastname
' empty email       Path : 3,6                               Please enter email                                 Please  enter email
' empty phone       Path : 3,7                               Please enter phone                                 Please  enter phone
' empty rental days & = 0 Path : 3,8,11                      Please enter rental days                           Please  enter rental days
' rental days = 0 & 61 Path : 3,8,10,12                      rental days greater than 0 and less than 60        greater than 0 , less than 60
' no state selected  Path : 3,8,9,11,16                      Please select state                                Please  select state 
' no program selected   Path : 3,8,9,11,13,15,20             Please select program                              Please select program
'************************************************************ Test cases **************************************************************************
'   TC2                                                     Expected result                             Actual result 
'------------------------------------------------------------------------------------------------------------------------------------------
' FirstName: Habsatou                                        Sub total : 150                                SubTotal : 150
' LastName:   War                                            Tax  : 0                                        Tax :  0
' Email  : hwar@gmai.com                                     Total : 141.25                                  Total :  141.25
' phone : 8591231234                                                         
' state : Florida
' days :  3
' program : AAA
' season : Off Season
'------------------------------------------------------------------------------------------------------------------------------------------
'Path : 1,8,9,12,13,15,17,21,24
'************************************************************ Test cases **************************************************************************
'   TC3                                                     Expected result                             Actual result 
'------------------------------------------------------------------------------------------------------------------------------------------
' FirstName: Habsatou                                        Sub total : 50                                SubTotal : 50
' LastName:   War                                            Tax  : 0                                      Tax : 0
' Email  : hwar@gmai.com                                     Total : 48.75                                 Total : 48.75
' phone : 8591231234                                                         
' state : Kentucky
' days : 1
' program : Florida
' season : Off Season
'------------------------------------------------------------------------------------------------------------------------------------------
' Path : 1,8,9,11,14,17,19,23,27
'************************************************************ Test cases **************************************************************************
'   TC4                                                     Expected result                             Actual result 
'------------------------------------------------------------------------------------------------------------------------------------------
' FirstName: Habsatou                                        Sub total : 3750                                SubTotal : 3750
' LastName:   War                                            Tax  : 375                                      Tax : 375
' Email  : hwar@gmai.com                                     Total : 3907.5                                  Total : 3907
' phone : 8591231234                                                         
' state : Kentucky
' days : 25
' program : None
' season : Peak Season
'------------------------------------------------------------------------------------------------------------------------------------------
' Path : 2,8,11,13,15,18,22,24
'************************************************************ Test cases **************************************************************************
'   TC5                                                     Expected result                             Actual result 
'------------------------------------------------------------------------------------------------------------------------------------------
' FirstName: Habsatou                                        Sub total : 150                                SubTotal : 150
' LastName:   War                                            Tax  : 15                                      Tax : 15
' Email  : hwar@gmai.com                                     Total : 160                                    Total : 160
' phone : 8591231234                                                         
' state : Kentucky
' days : 3
' program : None
' season : Off Season
'------------------------------------------------------------------------------------------------------------------------------------------
' Path : 1,8,9,11,15,17,18,23,26
'************************************************************ Test cases **************************************************************************
'   TC6                                                     Expected result                             Actual result 
'------------------------------------------------------------------------------------------------------------------------------------------
' FirstName: Habsatou                                        Sub total : 250                                SubTotal : 250
' LastName:   War                                            Tax  : 0                                       Tax : 0
' Email  : hwar@gmai.com                                     Total : 223.75                                 Total : 223.75
' phone : 8591231234                                                         
' state : Florida
' days : 5
' program : AARP
' season : Off Season
'------------------------------------------------------------------------------------------------------------------------------------------
' Path : 1,8,9,11,13,14,17,19,23,25