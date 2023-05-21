Public Class param
    Private Sub param_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' le 5 ne s'affiche quand on lance le form param
        load_nb_case_items()
        cb_box_nb_cases.Text = mod_param.get_nb_case()
        txt_box_car_possibles.Text = mod_param.get_caractere_possibles
        txt_box_nb_essais.Text = mod_param.get_nb_essais
        btn_couleur_bon.BackColor = mod_param.get_color_bon
        btn_couleur_mal_place.BackColor = mod_param.get_color_mal_place
        btn_couleur_abs.BackColor = mod_param.get_color_abs
        If (mod_param.get_use_time) Then
            ck_use_time.Checked = True
            txt_box_timer.Text = mod_param.get_timer
            lb_timer.Visible = True

        Else
            ck_use_time.Checked = False
            txt_box_timer.Visible = False
            lb_timer.Visible = False

        End If
    End Sub
    Private Sub load_nb_case_items()
        cb_box_nb_cases.Items.Add(mod_param.MIN_NB_CASES & " (min)")

        For i As Integer = 4 To mod_param.MAX_NB_CASES - 1
            cb_box_nb_cases.Items.Add(i & " ")
        Next
        cb_box_nb_cases.Items.Add(mod_param.MAX_NB_CASES & " (max)")

    End Sub
    Private Sub ck_use_time_CheckedChanged(sender As Object, e As EventArgs) Handles ck_use_time.CheckedChanged
        If (ck_use_time.Checked) Then
            txt_box_timer.Visible = True
            lb_timer.Visible = True

            mod_param.set_use_time(True)
            txt_box_timer.Text = mod_param.get_timer

        Else
            txt_box_timer.Visible = False
            lb_timer.Visible = False

            mod_param.set_use_time(False)

        End If
    End Sub



    Private Sub txt_box_nb_essais_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txt_box_nb_essais.KeyPress, txt_box_timer.KeyPress


        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_valide_param_Click(sender As Object, e As EventArgs) Handles btn_valide_param.Click

        For Each c As Control In pnl_param.Controls
            If (c.Text.Equals("")) Then
                MsgBox("veuillez remplir tout les champs :/")
                Return
            End If
        Next
        mod_param.set_caratere_possible(txt_box_car_possibles.Text)
        mod_param.set_nb_case(CInt(cb_box_nb_cases.Text.Substring(0, 2)))
        mod_param.set_nb_essais(CInt(txt_box_nb_essais.Text))
        If (ck_use_time.Checked) Then
            mod_param.set_use_time(True)
            mod_param.set_timer(CInt(txt_box_timer.Text))

        Else
            mod_param.set_use_time(False)
            mod_param.set_timer(-1)
        End If
        Me.Hide()



    End Sub

    Private Sub btn_couleur_bon_Click(sender As Object, e As EventArgs) Handles btn_couleur_bon.Click, btn_couleur_mal_place.Click, btn_couleur_abs.Click
        Dim color As DialogResult
        color = ColorDialog1.ShowDialog()
        If color = Windows.Forms.DialogResult.OK Then
            sender.BackColor = ColorDialog1.Color
            mod_param.set_color_bon(btn_couleur_bon.BackColor)
            mod_param.set_color_mal_place(btn_couleur_mal_place.BackColor)
            mod_param.set_color_abs(btn_couleur_abs.BackColor)
        End If
    End Sub



End Class