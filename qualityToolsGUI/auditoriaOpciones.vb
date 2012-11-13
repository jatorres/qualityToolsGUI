Public Class auditoriaOpciones

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("Tenga en cuenta que: La organización debe establecer, implementar, operar, hacer seguimiento, revisar, mantener y mejorar un SGSI documentado, en el contexto de las actividades" &
                        "globales del negocio de la organización y de los riesgos que enfrenta.", "Información relevante", MessageBoxButtons.OK, MessageBoxIcon.Information)

        establecimientoSGSIAuditoria.MdiParent = menuPrincipal
        establecimientoSGSIAuditoria.Show()
        Close()

    End Sub
End Class