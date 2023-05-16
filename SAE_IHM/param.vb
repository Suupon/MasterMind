Public Class param
    Private Sub param_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        load_nb_case_items()
        cb_box_nb_cases.Text = mod_param.get_nb_case
        txt_box_car_possibles.Text = mod_param.get_caractere_possibles
        txt_box_nb_essais.Text = mod_param.get_nb_essais
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
        cb_box_nb_cases.Items.Add(mod_param.MIN_NB_CASES & "(min)")
        For i As Integer = 4 To mod_param.MAX_NB_CASES - 1
            cb_box_nb_cases.Items.Add(i)

        Next
        cb_box_nb_cases.Items.Add(mod_param.MAX_NB_CASES & "(max)")

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

    Private Sub cb_box_nb_cases_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_box_nb_cases.SelectedIndexChanged

    End Sub

    Private Sub txt_box_nb_essais_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txt_box_nb_essais.KeyPress, txt_box_timer.KeyPress


        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True ' Annule l'événement de saisie
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
        mod_param.set_nb_case(CInt(cb_box_nb_cases.Text.Substring(0, 1)))
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
End Class