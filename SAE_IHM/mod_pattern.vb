Imports Microsoft.VisualBasic.Devices
Imports System.Security.Cryptography.Pkcs
Imports System.Threading
Imports System.Timers

Module mod_pattern
    Private tab_pattern1() As String
    Private tab_deviner1() As String
    Private timer_count As Integer
    Private fermer_pattern As Boolean
    Private fermer_jeu As Boolean


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

        get_joueur1.inc_score()
        get_joueur2.inc_cumul_temp(get_joueur2.get_tmp_temp_deviner())

        jeu.Btn_revanche.Visible = True
        jeu.btn_deviner.Enabled = False
        Return
    End Sub
    Public Sub Gagner()
        jeu.Timer1.Stop()
        MessageBox.Show("Vous avez gagné !!!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        jeu.Btn_revanche.Visible = True
        get_joueur2.inc_score()
        get_joueur2.inc_cumul_temp(get_joueur2.get_tmp_temp_deviner())

        If (get_joueur2.get_best_time_joueur > get_joueur2.get_tmp_temp_deviner()) Then

            get_joueur2.set_best_time(get_joueur2.get_tmp_temp_deviner())
        End If
        jeu.btn_deviner.Enabled = False
        Return
    End Sub





    Public Function get_timer_count() As Integer

        Return timer_count

    End Function
    Public Sub set_timer_count(timer As Integer)
        timer_count = timer
    End Sub



    Public Function get_fermer_pattern() As Boolean

        Return fermer_pattern

    End Function


    Public Sub set_fermer_pattern(fermer As Boolean)
        fermer_pattern = fermer
    End Sub


    Public Function get_fermer_jeu() As Boolean

        Return fermer_jeu

    End Function


    Public Sub set_fermer_jeu(fermer As Boolean)
        fermer_jeu = fermer
    End Sub
    Public Function getval_tab_pattern1(indice As Integer) As String
        Return tab_pattern1(indice)
    End Function

    Public Function getlength_tab_pattern1() As Integer
        Return tab_pattern1.Length
    End Function

    Public Sub redim_tab_pattern1(nb As Integer)
        ReDim tab_pattern1(nb)
    End Sub
    Public Sub set_tab_pattern1(indice As Integer, val As String)
        tab_pattern1(indice) = val
    End Sub


    Public Function getval_tab_deviner(indice As Integer) As String
        Return tab_deviner1(indice)
    End Function

    Public Function getlength_tab_deviner() As Integer
        Return tab_deviner1.Length
    End Function

    Public Sub redim_tab_deviner(nb As Integer)
        ReDim tab_deviner1(nb)
    End Sub
    Public Sub set_tab_deviner(indice As Integer, val As String)
        tab_deviner1(indice) = val
    End Sub
End Module
