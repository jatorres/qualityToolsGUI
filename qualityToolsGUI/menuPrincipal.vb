Public Class menuPrincipal

    Private Sub InformacionEmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformacionEmpresaToolStripMenuItem.Click
        Dim activeChild As Form = Me.ActiveMdiChild
        If Not activeChild Is Nothing Then
            activeChild.Close()
        End If

        informacionBasicaEmpresa.MdiParent = Me
        informacionBasicaEmpresa.Show()

    End Sub

    Private Sub InformacionAuditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformacionAuditorToolStripMenuItem.Click
        Dim activeChild As Form = Me.ActiveMdiChild
        If Not activeChild Is Nothing Then
            activeChild.Close()
        End If

        informacionBasicaAuditor.MdiParent = Me
        informacionBasicaAuditor.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        Form1.Close()

    End Sub

    Private Sub ProcesosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcesosToolStripMenuItem.Click
        Dim activeChild As Form = Me.ActiveMdiChild
        If Not activeChild Is Nothing Then
            activeChild.Close()
        End If

        Mapaprocesos.MdiParent = Me
        Mapaprocesos.Show()

    End Sub

    Private Sub RealizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RealizarToolStripMenuItem.Click
        Dim activeChild As Form = Me.ActiveMdiChild
        If Not activeChild Is Nothing Then
            activeChild.Close()
        End If

        auditoriaOpciones.MdiParent = Me
        auditoriaOpciones.Show()
    End Sub

    Private Sub TiposDeProcesosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiposDeProcesosToolStripMenuItem.Click
        Dim activeChild As Form = Me.ActiveMdiChild
        If Not activeChild Is Nothing Then
            activeChild.Close()
        End If

        Nuevo_Proceso.MdiParent = Me
        Nuevo_Proceso.Show()

    End Sub

    Private Sub DiagramasCasosDeUsoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiagramasCasosDeUsoToolStripMenuItem.Click

    End Sub

    Private Sub menuPrincipal_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        MessageBox.Show("Software para Finac S.A.S.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub RecomendacionesParaDocumentarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecomendacionesParaDocumentarToolStripMenuItem.Click
        Dim activeChild As Form = Me.ActiveMdiChild
        If Not activeChild Is Nothing Then
            activeChild.Close()
        End If

        reporteAuditoria.MdiParent = Me
        reporteAuditoria.Show()
    End Sub
End Class