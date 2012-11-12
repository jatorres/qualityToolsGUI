Public Class menuPrincipal

    Private Sub InformacionEmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformacionEmpresaToolStripMenuItem.Click
        informacionBasicaEmpresa.Show()

    End Sub

    Private Sub InformacionAuditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformacionAuditorToolStripMenuItem.Click
        informacionBasicaAuditor.Show()

    End Sub

    Private Sub ToolStripStatusLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        Form1.Close()

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub ProcesosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcesosToolStripMenuItem.Click

    End Sub
End Class