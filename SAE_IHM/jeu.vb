Imports Microsoft.VisualBasic.Devices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class jeu

    Private Sub jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If get_use_time() = False Then
            Timer1.Enabled = False
            Label_timer.Visible = False
            Label_temps.Visible = False
        End If

        Present_et_Bien_Place.ForeColor = mod_param.get_color_bon()
        Present.ForeColor = mod_param.get_color_mal_place()
        Absent.ForeColor = mod_param.get_color_abs()

        Timer1.Start()
        Label_timer.Text = mod_param.get_timer()
        Compteur.Text = mod_param.get_nb_essais()
        char_guess.Text = mod_param.get_caractere_possibles()
        AfficherTextBox()

        For Each textBox As TextBox In Panel_textbox.Controls.OfType(Of TextBox)()
            textBox.MaxLength = 1
            AddHandler textBox.KeyPress, AddressOf RestrictCharacters
        Next

    End Sub
    Private Sub AfficherTextBox()

        Dim nbTextBox As Integer = get_nb_case()

        For i As Integer = 0 To Panel_textbox.Controls.Count - 1

            If TypeOf Panel_textbox.Controls(i) Is TextBox Then
                Dim textBox As TextBox = Panel_textbox.Controls(i)

                If i < nbTextBox Then
                    textBox.Visible = True
                Else
                    textBox.Visible = False
                End If
            End If
        Next

    End Sub
    Private Sub RestrictCharacters(sender As Object, e As KeyPressEventArgs)

        Dim allowedChars As String = mod_param.get_caractere_possibles


        If Not allowedChars.Contains(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            Me.SelectNextControl(DirectCast(sender, Control), True, True, True, True)

        End If
    End Sub

    Private Sub btn_deviner_Click(sender As Object, e As EventArgs) Handles btn_deviner.Click
        ReDim tab_deviner1(get_nb_case() - 1)
        Dim compteur_essai As Integer = Compteur.Text
        Dim index As Integer = 0
        Dim cpt_green As Integer = get_nb_case()
        Dim cpt_msgbox As Integer = 0

        For Each textBox As TextBox In Panel_textbox.Controls.OfType(Of TextBox)()
            If textBox.Visible AndAlso String.IsNullOrEmpty(textBox.Text) Then
                MessageBox.Show("Veuillez remplir toutes les TextBox avant de passer au formulaire suivant.")
                Return
            End If

            If textBox.Visible Then
                tab_deviner1(index) = textBox.Text
                index += 1
            End If
        Next



        For i As Integer = 0 To mod_pattern.tab_pattern1.Length - 1

            If mod_pattern.tab_pattern1(i) = mod_pattern.tab_deviner1(i) Then
                Panel_textbox.Controls(i).BackColor = get_color_bon()

                RichTextBox_deviner.ForeColor = Panel_textbox.Controls(i).BackColor
                cpt_green -= 1
            End If
            If Panel_textbox.Controls(i).BackColor <> Color.Green And Panel_textbox.Controls(i).BackColor <> Color.Blue Then
                Panel_textbox.Controls(i).BackColor = get_color_abs()
            End If
        Next


        For i As Integer = mod_pattern.tab_pattern1.Length - 1 To 0 Step -1

            For j As Integer = 0 To mod_pattern.tab_pattern1.Length - 1

                If mod_pattern.tab_deviner1(j) = mod_pattern.tab_pattern1(i) And Panel_textbox.Controls(j).BackColor <> Color.Green Then

                    Panel_textbox.Controls(j).BackColor = get_color_mal_place()

                End If

            Next
        Next


        For i As Integer = 0 To mod_pattern.tab_pattern1.Length - 1


            RichTextBox_deviner.AppendText(Panel_textbox.Controls(i).Text)
            RichTextBox_deviner.Select(RichTextBox_deviner.TextLength - 1, 1)
            RichTextBox_deviner.SelectionColor = Panel_textbox.Controls(i).BackColor

        Next
        RichTextBox_deviner.AppendText(vbCrLf)


        If compteur_essai > 0 Then
            compteur_essai -= 1
            Compteur.Text = compteur_essai
        End If

        If compteur_essai = 0 Or timer_count = 0 Then
            Timer1.Stop()
            Compteur.Text = 0
            Label_timer.Visible = False
            MessageBox.Show("Vous avez a perdu :/", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information)

            mod_Liste_Joueurs.Joueur1.inc_score()
            mod_Liste_Joueurs.Joueur2.inc_cumul_temp(mod_Liste_Joueurs.Joueur2.get_tmp_temp_deviner())

            Btn_revanche.Visible = True
            btn_deviner.Enabled = False
            Return
        End If




        If cpt_green = 0 Then
            Timer1.Stop()
            MessageBox.Show("Vous avez gagné !!!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Btn_revanche.Visible = True
            mod_Liste_Joueurs.Joueur2.inc_score()
            mod_Liste_Joueurs.Joueur2.inc_cumul_temp(mod_Liste_Joueurs.Joueur2.get_tmp_temp_deviner())

            If (mod_Liste_Joueurs.Joueur2.get_best_time_joueur > mod_Liste_Joueurs.Joueur2.get_tmp_temp_deviner()) Then

                mod_Liste_Joueurs.Joueur2.set_best_time(mod_Liste_Joueurs.Joueur2.get_tmp_temp_deviner())
            End If
            btn_deviner.Enabled = False
            Return
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timer_count -= Timer1.Interval
        Label_timer.Text = CStr(timer_count / Timer1.Interval)
        Joueur2.inc_tmp_temp_devine()


    End Sub

    Private Sub Btn_revanche_Click(sender As Object, e As EventArgs) Handles Btn_revanche.Click
        Accueil.Show()
        Accueil.cb_box_p1.Text = mod_Liste_Joueurs.Joueur2.get_nom_joueur
        Accueil.cb_box_p2.Text = mod_Liste_Joueurs.Joueur1.get_nom_joueur
        sauvegarde_joueurs(mod_Liste_Joueurs.Joueur1, mod_Liste_Joueurs.Joueur2)

        Me.Close()
    End Sub



End Class