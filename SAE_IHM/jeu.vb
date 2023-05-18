Public Class jeu
    Private Sub Txt_1_TextChanged(sender As Object, e As EventArgs)
        Dim nextcontrol As Control = GetNextControl(sender, True)
        sender.Maxlength = 1
        nextcontrol.Focus()


    End Sub

    Private Sub Txt_1_KeyPress(sender As Object, e As KeyPressEventArgs)

        If InStr("#@%$£", e.KeyChar) = 0 And e.KeyChar <> vbBack Then
            e.Handled = True
        End If

    End Sub
    Private Sub btn_deviner_Click(sender As Object, e As EventArgs) Handles btn_deviner.Click
        Dim cpt As Integer = 0


        If Txt_1.Text = "" Or Txt_2.Text = "" Or Txt_3.Text = "" Or Txt_4.Text = "" Or Txt_5.Text = "" Then
            cpt += 1
            MsgBox("Veuillez remplir toutes les cases")

        End If


        If cpt = 0 Then
            Dim tab() As String = {Txt_1.Text, Txt_2.Text, Txt_3.Text, Txt_4.Text, Txt_5.Text}





        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MsgBox("Temps écoulé")

    End Sub

    Private Sub jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class