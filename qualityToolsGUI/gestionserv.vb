Public Class gestionserv

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        RichTextBox1.Enabled = True
        RichTextBox2.Enabled = True
        RichTextBox3.Enabled = True
        RichTextBox4.Enabled = True

        Button3.Visible = True
        Button1.Visible = False



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Mapaprocesos.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button1.Visible = True
        Button3.Visible = False

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        RichTextBox1.Enabled = False
        RichTextBox2.Enabled = False
        RichTextBox3.Enabled = False
        RichTextBox4.Enabled = False

    End Sub
End Class