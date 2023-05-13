Public Class Pattern_a_deviner

    Private Sub Txt_TextChanged(sender As Object, e As EventArgs) Handles Txt_1.TextChanged, Txt_2.TextChanged, Txt_3.TextChanged, Txt_4.TextChanged, Txt_5.TextChanged
        Dim nextcontrol As Control = GetNextControl(sender, True)
        sender.MaxLength = 1
        nextcontrol.Focus()


    End Sub

    Private Sub Txt_1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_1.KeyPress, Txt_2.KeyPress, Txt_3.KeyPress, Txt_4.KeyPress, Txt_5.KeyPress

        If InStr("#@%$£", e.KeyChar) = 0 And e.KeyChar <> vbBack Then
            e.Handled = True

        End If

    End Sub

    Private Sub btn_cacher_Click(sender As Object, e As EventArgs) Handles btn_cacher.Click
        Dim cpt As Integer = 0


        If Txt_1.Text = "" Or Txt_2.Text = "" Or Txt_3.Text = "" Or Txt_4.Text = "" Or Txt_5.Text = "" Then
            cpt += 1
        End If


        If cpt = 0 Then
            Dim tab() As String = {Txt_1.Text, Txt_2.Text, Txt_3.Text, Txt_4.Text, Txt_5.Text}
            jeu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub mastermind_Click(sender As Object, e As EventArgs) Handles mastermind.Click

    End Sub
End Class
