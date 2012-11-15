Public Class seguimientoSGSIAuditoria

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        implementacionSGSIAuditoria.MdiParent = menuPrincipal
        implementacionSGSIAuditoria.Show()
        Close()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        mantenimientoSGSIAuditoria.MdiParent = menuPrincipal
        mantenimientoSGSIAuditoria.Show()
        Close()

    End Sub
End Class