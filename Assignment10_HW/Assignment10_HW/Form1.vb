Public Class Form1
    'Declaring class variable
    Dim intRunningTotal As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '************************************************************************
        '   Habsatou War
        '   Assignment 10
        '   Programming 1
        '   Based on assignment 6 add validation to the inputs : required,
        '   must be numeric, must be greater than 0
        '************************************************************************
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Exit the application
        Me.Close()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumber1.ResetText()
        txtNumber2.ResetText()
        txtNumber3.ResetText()
        lblSum1.ResetText()
        lblSum2.ResetText()
        lblSum3.ResetText()
        txtNumber1.Focus()
    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declaring variables
        Dim intNumber1 As Integer
        Dim intNumber2 As Integer
        Dim intNumber3 As Integer

        Dim intSum1 As Integer              '        sum of Number1 And number2
        Dim intSum2 As Integer              '        sum of Number1 And number3
        Dim intSum3 As Integer              '        sum of Number2 And number3
        Dim intTotal As Integer             'sum of Number1,Number2 and number3



        'Get Input
        'Validate Inputs
        'Number 1
        If IsNumeric(txtNumber1.Text) Then
            intNumber1 = txtNumber1.Text
            If intNumber1 < 1 Then
                MessageBox.Show("Number1 should be greater than 0")
                txtNumber1.Focus()
                Exit Sub
            End If
        Else
        MessageBox.Show("Please enter a number for number 1")
            txtNumber1.Focus()
            Exit Sub
        End If
        'Number 2
        If IsNumeric(txtNumber2.Text) Then
            intNumber2 = txtNumber2.Text
            If intNumber2 < 1 Then
                MessageBox.Show("Number2 should be greater than 0")
                txtNumber2.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Please enter a number for number 2")
            txtNumber2.Focus()
            Exit Sub
        End If
        'Number 3
        If IsNumeric(txtNumber3.Text) Then
            intNumber3 = txtNumber3.Text
            If intNumber3 < 1 Then
                MessageBox.Show("Number3 should be greater than 0")
                txtNumber3.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Please enter a number for number 3")
            txtNumber3.Focus()
            Exit Sub
        End If

        'Calculations

        intSum1 = intNumber1 + intNumber2
        intSum2 = intNumber1 + intNumber3
        intSum3 = intNumber2 + intNumber3
        intTotal = intNumber1 + intNumber2 + intNumber3
        intRunningTotal += intTotal

        'Display outputs
        lblSum1.Text = intSum1
        lblSum2.Text = intSum2
        lblSum3.Text = intSum3
        lblRunningTotal.Text = intRunningTotal
    End Sub
End Class
