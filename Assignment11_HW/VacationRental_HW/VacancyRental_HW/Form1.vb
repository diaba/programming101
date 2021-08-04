Public Class Form1
    '*********************************************************************************
    '       Habsatou War
    '       Programming 1
    '       Assignment Vacancy Rental
    '       Condo rental application based on season option and days of rental
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
        If radOffSeason.Checked Then
            dblSeasonCost = dblOffSeasonCost
        ElseIf radPeakSeaon.Checked Then
            dblSeasonCost = dblPeakSeasonCost
        ElseIf radStandard.Checked Then
            dblSeasonCost = dblStandardSeasonCost
        End If

        If txtFirstName.Text = "" Then
            MessageBox.Show("Please enter First Name")            'Validate First Name
            txtFirstName.Focus()
            Exit Sub
        ElseIf txtLastName.Text = "" Then
            MessageBox.Show("Please enter Last Name")              'Validate Last Name
            txtLastName.Focus()
            Exit Sub
        ElseIf txtEmail.Text = "" Then
            MessageBox.Show("Please enter Email")                   'Validate Email
            txtEmail.Focus()
            Exit Sub
        ElseIf txtPhone.Text = "" Then
            MessageBox.Show("Please enter Phone")                   'Validate Phone
            txtPhone.Focus()
            Exit Sub
        End If
        'Validation of rental days
        If IsNumeric(txtRentalDays.Text) Then
            intRentalDay = txtRentalDays.Text
            If intRentalDay < 1 Or intRentalDay > 59 Then
                MessageBox.Show("Please rental is greater than 0 and less than 60")
                txtRentalDays.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Please enter rental days")
            txtRentalDays.Focus()
            Exit Sub
        End If
        'Calculations
        If intRentalDay > 30 Then
            dblDiscount = dblSeasonCost * 0.1 * intRentalDay
        ElseIf intRentalDay > 14 Then
            dblDiscount = dblSeasonCost * 0.05 * intRentalDay
        End If
        dblSubTotal = dblSeasonCost * intRentalDay
        dblTax = dblSubTotal * 0.1
        dblTotal = dblSubTotal + dblTax - dblDiscount
        'Display
        lblSubTotal.Text = FormatCurrency(dblSubTotal)
        lblTax.Text = FormatCurrency(dblTax)
        lblTotal.Text = FormatCurrency(dblTotal)
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Clear all inputs and outputs
        radStandard.Checked = True
        txtFirstName.ResetText()
        txtLastName.ResetText()
        txtEmail.ResetText()
        txtPhone.ResetText()
        txtRentalDays.ResetText()

        txtFirstName.Focus()
        lblSubTotal.ResetText()
        lblTax.ResetText()
        lblTotal.ResetText()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exit application
        Me.Close()

    End Sub
End Class
