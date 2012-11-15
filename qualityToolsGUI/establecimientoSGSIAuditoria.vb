Public Class establecimientoSGSIAuditoria

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        implementacionSGSIAuditoria.MdiParent = menuPrincipal
        implementacionSGSIAuditoria.Show()
        Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        auditoriaOpciones.MdiParent = menuPrincipal
        auditoriaOpciones.Show()
        Close()

    End Sub
End Class