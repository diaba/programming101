Public Class DisplayZipCode
    Private Sub DisplayZipCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnHarrison_Click(sender As Object, e As EventArgs) Handles btnHarrison.Click
        lblHarrisson.Visible = True
    End Sub

    Private Sub btnNorwood_Click(sender As Object, e As EventArgs) Handles btnNorwood.Click
        lblNorwood.Visible = True
    End Sub

    Private Sub btnErlanger_Click(sender As Object, e As EventArgs) Handles btnErlanger.Click
        lblErlanger.Visible = True
    End Sub

    Private Sub btnFlorence_Click(sender As Object, e As EventArgs) Handles btnFlorence.Click
        lblFlorence.Visible = True
    End Sub

    Private Sub btnLowrenceburg_Click(sender As Object, e As EventArgs) Handles btnLowrenceburg.Click
        lblLowrenceburg.Visible = True
    End Sub

    Private Sub btnRising_Click(sender As Object, e As EventArgs) Handles btnRising.Click
        lblRising.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
