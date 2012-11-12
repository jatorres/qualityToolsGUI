Public Class menuPrincipal

    Private Sub InformacionEmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformacionEmpresaToolStripMenuItem.Click
        informacionBasicaEmpresa.Show()
        Close()
    End Sub

    Private Sub InformacionAuditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformacionAuditorToolStripMenuItem.Click
        informacionBasicaAuditor.Show()
        Close()
    End Sub

    Private Sub ToolStripStatusLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub
End Class