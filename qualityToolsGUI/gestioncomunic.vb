Public Class gestioncomunic

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        politicasdeseg.MdiParent = menuPrincipal
        politicasdeseg.Show()
        Close()

    End Sub
End Class