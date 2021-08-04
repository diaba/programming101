Public Class Form1
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtSalePrice.TextChanged

    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Declare Variables
        Dim decOriginalPrice As Decimal
        Dim decPercentOff As Decimal

        Dim decSalePrice As Decimal

        'Get our input
        decOriginalPrice = txtOriginalPrice.Text
        decPercentOff = txtPercentOff.Text

        ' Do Calculations
        decSalePrice = decOriginalPrice * (1 - decPercentOff / 100)

        ' Display outputs
        txtSalePrice.Text = "$" + decSalePrice.ToString
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear Input
        txtOriginalPrice.Text = " "
        txtPercentOff.Text = " "
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exit form
        Me.Close()

    End Sub
End Class
