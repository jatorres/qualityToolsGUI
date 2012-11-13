Public Class Nuevo_Proceso

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Nuevo_Proceso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        RichTextBox1.Enabled = False
    End Sub
End Class