Public Class Form1


    Private Sub btnFamilyPlan_Click(sender As Object, e As EventArgs) Handles btnFamilyPlan.Click
        ' Create new instance of FamilyPlan
        Dim FamilyPlan As New frmFamily

        ' Show FamilyPlan
        FamilyPlan.ShowDialog()
    End Sub

    Private Sub btnIndividualPlan_Click(sender As Object, e As EventArgs) Handles btnIndividualPlan.Click
        ' Create new instance of IndividualPlan
        Dim IndividualPlan As New frmIndividual

        ' Show Individual Plan
        IndividualPlan.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form
        Close()

    End Sub
End Class
