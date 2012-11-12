Public Class controlDocumentosSGSIAuditoria
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mantenimientoSGSIAuditoria.Show()
        Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MessageBox.Show("Ha culminado el proceso de auditoria exitosamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        puntuacionRecomendSGSIAuditoria.Show()
        Close()

    End Sub
End Class