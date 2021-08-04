Imports System.Diagnostics.Eventing.Reader
'                                                 Assignment 15
Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Declaration of Variables
        Dim strFirstName As String
        Dim strLastName As String

        Dim intDays As Integer

        Dim dblSubtotal As Double
        Dim dblTax As Double
        Dim dblTotal As Double

        txtDays.BackColor = Color.White
        txtDays.BackColor = Color.White
        txtFirstName.BackColor = Color.White
        txtLastName.BackColor = Color.White
        cboState.BackColor = Color.White


        'check boolean and only proceed if true
        If ValidationInput(strFirstName, strLastName, intDays) = True Then
            ' SubTotal
            dblSubtotal = CalculateSubTotal(intDays)
            'Calculate tax
            dblTax = CalculateTax(dblSubtotal)
            ' Total
            dblTotal = calculateTotal(dblSubtotal, dblTax)
            '  Call procedure to Display
            Display(dblSubtotal, dblTax, dblTotal)
        End If

    End Sub
    Private Function calculateTotal(ByVal dblSubTotal As Double, ByVal dblTax As Double)
        Return dblTax + dblSubTotal
    End Function

    Private Function CalculateTax(ByVal dblSubTotal As Double) As Double

        If cboState.SelectedItem = "Florida" Then
            Return 0
        Else
            Return dblSubTotal * 0.1
        End If

    End Function

    Private Function CalculateSubTotal(ByVal intDays As Integer) As Double
        'Variable
        Dim dblSubTotal As Double

        '  call basic subtotal
        dblSubTotal = CalculateBasicSubTotal(intDays)

        '  call calculate AAA or AARP discount cost
        dblSubTotal = calculateDiscountAAA(dblSubTotal)

        '  call calculate discount based on days to rent
        dblSubTotal = calculateDiscountRentDays(intDays, dblSubTotal)

        'if repeating customer, discount based on sub total costs
        dblSubTotal = CalculateRepeatingCustomer(dblSubTotal)

        Return dblSubTotal

    End Function

    Private Function CalculateRepeatingCustomer(ByRef dblSubTotal) As Double

        If chkRepeating.Checked Then
            If dblSubTotal > 300 Then
                dblSubTotal = dblSubTotal - 30
            Else
                If dblSubTotal > 200 Then
                    dblSubTotal = dblSubTotal - 20
                Else
                    If dblSubTotal > 50 Then
                        dblSubTotal = dblSubTotal - 5
                    End If
                End If
            End If
        End If

        Return dblSubTotal
    End Function

    Private Function calculateDiscountRentDays(ByVal intDays As Integer, ByRef dblSubTotal As Double) As Double

        If intDays > 30 Then
            dblSubTotal = dblSubTotal * 0.9
        Else
            If intDays > 14 Then
                dblSubTotal = dblSubTotal * 0.95
            End If
        End If
        Return dblSubTotal
    End Function

    Private Function calculateDiscountAAA(ByRef dblSubTotal) As Double

        'applying either AAA or AARP discount
        If radAAA.Checked Then
            dblSubTotal = dblSubTotal * 0.975
        Else
            If radAARP.Checked Then
                dblSubTotal = dblSubTotal * 0.975
            End If
        End If
        Return dblSubTotal
    End Function
    Private Function CalculateBasicSubTotal(ByVal intDays As Integer) As Object
        'Variable declarations
        Dim dblSubTotal As Double

        If radOff.Checked Then
            dblSubTotal = (50 * intDays)
        Else
            If radPeak.Checked Then
                dblSubTotal = (150 * intDays)
            Else
                dblSubTotal = (100 * intDays)
            End If
        End If
        Return dblSubTotal
    End Function

    Private Sub Display(ByVal dblSubtotal As Double, ByVal dblTax As Double, ByVal dblTotal As Double)
        lblSubtotal.Text = dblSubtotal.ToString("c")
        lblTax.Text = dblTax.ToString("c")
        lblTotal.Text = dblTotal.ToString("c")
    End Sub

    'Create main validation procedure
    Private Function ValidationInput(ByRef strFirtName As Object, ByRef strLastName As String, ByRef intDays As Integer) As Boolean
        Dim valid As Boolean

        If ValidateFirstName(strFirtName) = True Then
            If ValidateLasttName(strLastName) = True Then
                If ValidateState() = True Then
                    If ValidateintDays(intDays) = True Then
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

    Private Function ValidateState() As Boolean
        If cboState.SelectedItem = "" Then
            cboState.BackColor = Color.Yellow
            MessageBox.Show("Please Select a state")
            Return False
        Else
            Return True

        End If
    End Function

    'Create Last Name
    Private Function ValidateLasttName(ByRef strLastName As String) As Boolean
        Dim valid As Boolean

        '  check Last name 
        If txtLastName.Text = String.Empty Then
            txtLastName.BackColor = Color.Yellow
            MessageBox.Show("Last Name is Required")
            txtLastName.Focus()
            valid = False
        Else
            strLastName = txtLastName.Text
            txtLastName.BackColor = Color.White
            valid = True
        End If
        Return valid
    End Function

    'Create First Name
    Private Function ValidateFirstName(ByRef strFirstname As String) As Boolean
        Dim Valid As Boolean
        '  check First name 
        If txtFirstName.Text = String.Empty Then
            txtFirstName.BackColor = Color.Yellow
            MessageBox.Show("First Name is Required")
            txtFirstName.Focus()
            Valid = False
        Else
            strFirstname = txtFirstName.Text
            txtFirstName.BackColor = Color.White
            Valid = True
        End If
        Return Valid
    End Function

    'Create rental days
    Private Function ValidateintDays(ByRef intDays As Integer) As Boolean
        Dim Valid As Boolean
        '  check Rental days 
        If IsNumeric(txtDays.Text) Then
            intDays = txtDays.Text
            If (intDays > 0) And (intDays < 60) Then
                txtDays.BackColor = Color.White
                Valid = True
            Else
                MessageBox.Show("Day must be between 1 and 59 Days")
                txtDays.Focus()
                txtDays.BackColor = Color.Yellow
                Valid = False
            End If
        Else
            MessageBox.Show("Day is Required and Must Be Numeric")
            txtDays.BackColor = Color.Yellow
            txtDays.Focus()
            Valid = False
        End If
        Return Valid

    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear all the labels and textboxes and set radioboxes on default
        txtFirstName.Clear()
        txtLastName.Clear()
        txtDays.Clear()
        cboState.ResetText()
        radStandard.Checked = True
        radAAA.Checked = False
        radAARP.Checked = False
        chkRepeating.Checked = False
        lblSubtotal.ResetText()
        lblTax.ResetText()
        lblTotal.ResetText()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close the program
        Close()
    End Sub

End Class
