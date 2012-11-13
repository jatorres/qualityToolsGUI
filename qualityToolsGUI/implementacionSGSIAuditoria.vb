Public Class implementacionSGSIAuditoria

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        establecimientoSGSIAuditoria.MdiParent = menuPrincipal
        establecimientoSGSIAuditoria.Show()
        Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        seguimientoSGSIAuditoria.MdiParent = menuPrincipal
        seguimientoSGSIAuditoria.Show()
        Close()

    End Sub
End Class