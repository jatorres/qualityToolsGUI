Public Class recordarContrasena

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("Información actualizada correctamente!", "Información de actualización", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Form1.Show()
        Close()

    End Sub
End Class