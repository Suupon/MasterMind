Imports Microsoft.VisualBasic.Devices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class jeu

    Private Sub jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If get_use_time() = False Then
            Timer1.Enabled = False
            Label_timer.Visible = False
            Label_temps.Visible = False
        End If

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

        Next

        For Each control As Control In Panel_textbox.Controls
            If TypeOf control Is TextBox AndAlso control.Visible Then
                tab_deviner1(index) = DirectCast(control, TextBox).Text
                index += 1
            End If
        Next

        For i As Integer = 0 To mod_enregistrement.tab_pattern1.Length - 1

            If mod_enregistrement.tab_pattern1(i) = mod_enregistrement.tab_deviner1(i) Then
                Panel_textbox.Controls(i).BackColor = Color.Green
                RichTextBox_deviner.AppendText(Panel_textbox.Controls(i).Text)
                RichTextBox_deviner.ForeColor = Panel_textbox.Controls(i).BackColor
                cpt_green -= 1

            End If

        Next


        For i As Integer = mod_enregistrement.tab_pattern1.Length - 1 To 0 Step -1

            For j As Integer = 0 To mod_enregistrement.tab_pattern1.Length - 1

                If mod_enregistrement.tab_deviner1(j) = mod_enregistrement.tab_pattern1(i) And Panel_textbox.Controls(j).BackColor <> Color.Green Then

                    Panel_textbox.Controls(j).BackColor = Color.Blue
                    RichTextBox_deviner.AppendText(Panel_textbox.Controls(i).Text)
                    RichTextBox_deviner.ForeColor = Panel_textbox.Controls(i).BackColor
                End If


            Next

        Next

        For i As Integer = 0 To mod_enregistrement.tab_pattern1.Length - 1

            If Panel_textbox.Controls(i).BackColor <> Color.Green And Panel_textbox.Controls(i).BackColor <> Color.Blue Then
                Panel_textbox.Controls(i).BackColor = Color.Red
                RichTextBox_deviner.AppendText(Panel_textbox.Controls(i).Text)
                RichTextBox_deviner.ForeColor = Panel_textbox.Controls(i).BackColor
            End If
        Next

        For Each tb As TextBox In Panel_textbox.Controls.OfType(Of TextBox)
        Next

        If compteur_essai > 0 Then
            compteur_essai -= 1
            Compteur.Text = compteur_essai
        End If

        If compteur_essai = 0 Then
            Timer1.Stop()
            Compteur.Text = 0
            MessageBox.Show("Vous avez perdu!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Btn_bye.Visible = True

        End If

        If cpt_green = 0 Then
            Timer1.Stop()
            MessageBox.Show("Vous avez terminé le jeu !!!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Btn_bye.Visible = True

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timer_count -= Timer1.Interval
        Label_timer.Text = CStr(timer_count / Timer1.Interval)


        If timer_count = 0 Then
            Timer1.Stop()
            Label_timer.Visible = False
            MessageBox.Show("Temps écoulé", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Btn_bye.Visible = True

        End If

    End Sub

    Private Sub Btn_bye_Click(sender As Object, e As EventArgs) Handles Btn_bye.Click
        Accueil.Show()
        Me.Close()
    End Sub


End Class