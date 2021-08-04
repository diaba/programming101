Public Class frmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close app
        Close()
    End Sub

    Private Sub btnEarth_Click(sender As Object, e As EventArgs) Handles btnEarth.Click
        ' Create a new instance of Earth
        Dim Earth As New frmEarth

        ' Show earth  
        Earth.ShowDialog()

    End Sub

    Private Sub btnMars_Click(sender As Object, e As EventArgs) Handles btnMars.Click
        ' Create a new instance of Mars
        Dim Mars As New frmMars

        ' Show earth  
        Mars.ShowDialog()
    End Sub

    Private Sub btnMercury_Click(sender As Object, e As EventArgs) Handles btnMercury.Click
        ' Create a new instance of Mercury
        Dim Mercury As New frmMercury

        ' Show Mercury  
        Mercury.ShowDialog()
    End Sub


    Private Sub EarthToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        'close
        Close()

    End Sub

    Private Sub JupiterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JupiterToolStripMenuItem.Click
        ' Create a new instance of Jupiter
        Dim Jupiter As New frmJupiter

        ' Show Jupiter  
        Jupiter.ShowDialog()
    End Sub

    Private Sub MarsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarsToolStripMenuItem.Click
        ' Create a new instance of Mars
        Dim Mars As New frmMars

        ' Show earth  
        Mars.ShowDialog()
    End Sub

    Private Sub MercuryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MercuryToolStripMenuItem.Click
        ' Create a new instance of Mercury
        Dim Mercury As New frmMercury

        ' Show Mercury  
        Mercury.ShowDialog()
    End Sub

    Private Sub btnJupiter_Click(sender As Object, e As EventArgs) Handles btnJupiter.Click
        ' Create a new instance of Jupiter
        Dim Jupiter As New frmJupiter

        ' Show Jupiter  
        Jupiter.ShowDialog()
    End Sub

    Private Sub EarthToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EarthToolStripMenuItem2.Click
        ' Create a new instance of Earth
        Dim Earth As New frmEarth

        ' Show earth  
        Earth.ShowDialog()
    End Sub
End Class
