Public Class Mapaprocesos

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        direcciongeneral.MdiParent = menuPrincipal
        direcciongeneral.Show()
        Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        direccioncomercial.MdiParent = menuPrincipal
        direccioncomercial.Show()
        Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        gestiondiseñoaplic.MdiParent = menuPrincipal
        gestiondiseñoaplic.Show()
        Close()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        segureddato.MdiParent = menuPrincipal
        segureddato.Show()
        Close()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        gestionserv.MdiParent = menuPrincipal
        gestionserv.Show()
        Close()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        dptofinanciero.MdiParent = menuPrincipal
        dptofinanciero.Show()
        Close()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        gestiondiseñoaplic.MdiParent = menuPrincipal
        gestiondiseñoaplic.Show()
        Close()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        direcciongeneral.MdiParent = menuPrincipal
        direcciongeneral.Show()
        Close()
    End Sub
End Class