﻿Public Class reporteAuditoria

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("Reporte descargado exitosamente!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MessageBox.Show("Reporte descargado exitosamente!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Close()
    End Sub
End Class