Imports Microsoft.VisualBasic.Devices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class jeu
    Private image_its_fine As Image = Image.FromFile("..\..\..\img\its_fine.png")
    Private image_PP As Image = Image.FromFile("..\..\..\img\pp.png")
    Private image_PP_thinking As Image = Image.FromFile("..\..\..\img\pp_thinking.png")
    Private Sub jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Recenter_panel()
        its_fine_picture.Visible = False
        its_fine_picture.Image = image_its_fine
        pp_thinking_img.Image = image_PP_thinking
        If get_use_time() = False Then
            Timer1.Enabled = False
            Label_timer.Visible = False
            Label_temps.Visible = False
        End If

        Present_et_Bien_Place.ForeColor = mod_param.get_color_bon()
        Present.ForeColor = mod_param.get_color_mal_place()
        Absent.ForeColor = mod_param.get_color_abs()

        set_timer_count(get_timer() * Timer1.Interval)



        Label_timer.Text = mod_param.get_timer()

        Compteur.Text = mod_param.get_nb_essais()
        char_guess.Text = mod_param.get_caractere_possibles()
        AfficherTextBox()
        Timer1.Start()

        For Each textBox As TextBox In Panel_textbox.Controls.OfType(Of TextBox)()
            textBox.MaxLength = 1
            AddHandler textBox.KeyPress, AddressOf RestrictCharacters
        Next

        set_fermer_jeu(True)

    End Sub

    Public Sub Jeu_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing

        If get_fermer_jeu() = True Then
            ' Vérifier si l'utilisateur souhaite vraiment fermer le formulaire
            Dim result As DialogResult = MessageBox.Show("Voulez-vous vraiment nous quitté ou avez vous juste missclick?", "Confirmation de fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Si l'utilisateur clique sur "Non", annuler la fermeture du formulaire
            If result = DialogResult.No Then
                e.Cancel = True
            Else
                Accueil.Show()


            End If

        End If
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
        Dim compteur_essai As Integer = Compteur.Text
        Dim index As Integer = 0
        Dim cpt_green As Integer = 0
        Dim cpt_msgbox As Integer = 0
        redim_tab_deviner(get_nb_case() - 1)

        For Each textBox As TextBox In Panel_textbox.Controls.OfType(Of TextBox)()
            If textBox.Visible AndAlso String.IsNullOrEmpty(textBox.Text) Then
                MessageBox.Show("Veuillez remplir toutes les cases.")
                Return
            End If

            If textBox.Visible Then
                set_tab_deviner(index, textBox.Text)
                index += 1
            End If
        Next

        For i As Integer = 0 To getlength_tab_pattern1() - 1

            If getval_tab_pattern1(i) = getval_tab_deviner(i) Then
                Panel_textbox.Controls(i).BackColor = get_color_bon()

                RichTextBox_deviner.ForeColor = Panel_textbox.Controls(i).BackColor
                cpt_green += 1
            End If
            If Panel_textbox.Controls(i).BackColor <> Color.Green And Panel_textbox.Controls(i).BackColor <> Color.Blue Then
                Panel_textbox.Controls(i).BackColor = get_color_abs()
            End If
        Next

        mod_pattern.verif_couleur_bleu()
        mod_pattern.couleur_richtextbox()


        'Quand le joueur gagne' 
        If cpt_green = get_nb_case() Then
            mod_pattern.Gagner()
        End If

        If compteur_essai = 3 Then
            afficher_its_fine()
        End If
        If compteur_essai = 1 And cpt_green <> get_nb_case() Then
            afficher_PP()
            mod_pattern.perdu()

        End If



        If compteur_essai > 0 Then
            compteur_essai -= 1
            Compteur.Text = compteur_essai
        End If



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        set_timer_count(get_timer_count() - Timer1.Interval)
        Label_timer.Text = CStr(get_timer_count() / Timer1.Interval)
        get_joueur2().inc_tmp_temps_devine()

        If get_timer_count() = 0 Then
            mod_pattern.perdu()
            afficher_PP()

        End If



    End Sub

    Private Sub Btn_revanche_Click(sender As Object, e As EventArgs) Handles Btn_revanche.Click

        Accueil.Show()
        Accueil.cb_box_p1.Text = get_joueur2.get_nom_joueur
        Accueil.cb_box_p2.Text = get_joueur1.get_nom_joueur
        sauvegarde_joueurs(get_joueur1, get_joueur2)

        set_fermer_jeu(False)
        Me.Close()
    End Sub

    Private Sub Recenter_panel()
        Dim master_mind_x_location As Integer = Me.label_mastermind.Location.X

        Panel_textbox.Width = mod_param.get_nb_case * (TextBox1.Width + 10)
        Dim x As Integer = (master_mind_x_location - Panel_textbox.Width / 2) + TextBox1.Width
        Panel_textbox.Location = New System.Drawing.Point(x, 182)

    End Sub

    Private Sub afficher_its_fine()
        its_fine_picture.Visible = True
        lb_pov.Text = "POV Joueur 2 quand il lui reste 2 essais:"
    End Sub
    Private Sub afficher_PP()
        its_fine_picture.Visible = True
        its_fine_picture.Image = image_PP
        lb_pov.Text = "Ce gros nul de Joueur 2 a perdu :/"

    End Sub
End Class