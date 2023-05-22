Imports Microsoft.VisualBasic.Devices
Imports System.Threading
Imports System.Timers

Module mod_pattern
    Public tab_pattern1() As String
    Public tab_deviner1() As String
    Public timer_count As Integer = mod_param.get_timer() * jeu.Timer1.Interval
    Public fermer As Boolean = True

    Public Sub couleur_richtextbox()

        For i As Integer = 0 To mod_pattern.tab_pattern1.Length - 1


            jeu.RichTextBox_deviner.AppendText(jeu.Panel_textbox.Controls(i).Text)
            jeu.RichTextBox_deviner.Select(jeu.RichTextBox_deviner.TextLength - 1, 1)
            jeu.RichTextBox_deviner.SelectionColor = jeu.Panel_textbox.Controls(i).BackColor

        Next
        jeu.RichTextBox_deviner.AppendText(vbCrLf)


    End Sub

    Public Sub verif_couleur_bleu()

        For i As Integer = mod_pattern.tab_pattern1.Length - 1 To 0 Step -1

            For j As Integer = 0 To mod_pattern.tab_pattern1.Length - 1

                If mod_pattern.tab_deviner1(j) = mod_pattern.tab_pattern1(i) And jeu.Panel_textbox.Controls(j).BackColor <> Color.Green Then

                    jeu.Panel_textbox.Controls(j).BackColor = get_color_mal_place()

                End If

            Next
        Next


    End Sub


    Public Sub perdu()

        jeu.Timer1.Stop()
        jeu.Compteur.Text = 0
        jeu.Label_timer.Visible = False
        MessageBox.Show("Vous avez a perdu :/", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information)

        mod_Liste_Joueurs.Joueur1.inc_score()
        mod_Liste_Joueurs.Joueur2.inc_cumul_temp(mod_Liste_Joueurs.Joueur2.get_tmp_temp_deviner())

        jeu.Btn_revanche.Visible = True
        jeu.btn_deviner.Enabled = False
        Return
    End Sub
    Public Sub Gagner()
        jeu.Timer1.Stop()
        MessageBox.Show("Vous avez gagné !!!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        jeu.Btn_revanche.Visible = True
        mod_Liste_Joueurs.Joueur2.inc_score()
        mod_Liste_Joueurs.Joueur2.inc_cumul_temp(mod_Liste_Joueurs.Joueur2.get_tmp_temp_deviner())

        If (mod_Liste_Joueurs.Joueur2.get_best_time_joueur > mod_Liste_Joueurs.Joueur2.get_tmp_temp_deviner()) Then

            mod_Liste_Joueurs.Joueur2.set_best_time(mod_Liste_Joueurs.Joueur2.get_tmp_temp_deviner())
        End If
        jeu.btn_deviner.Enabled = False
        Return
    End Sub
End Module
