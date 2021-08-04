Public Class frmPhoneNavigation
    Private Sub btnIndividualPlan_Click(sender As Object, e As EventArgs) Handles btnIndividualPlan.Click
        Dim frmIndividual As New frmIndividual

        frmIndividual.ShowDialog()

    End Sub

    Private Sub btnFamilyPlan_Click(sender As Object, e As EventArgs) Handles btnFamilyPlan.Click
        Dim frmFamily As New frmFamily

        frmFamily.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub
End Class