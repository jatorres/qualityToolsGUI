Public Class politicasdeseg

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        rh.MdiParent = menuPrincipal
        rh.Show()
        Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        segufisient.MdiParent = menuPrincipal
        segufisient.Show()
        Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        contracc.MdiParent = menuPrincipal
        contracc.Show()
        Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        gestioncomunic.MdiParent = menuPrincipal
        gestioncomunic.Show()
        Close()

    End Sub
End Class