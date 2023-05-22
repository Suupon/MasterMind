Module mod_pattern
    Public tab_pattern1() As String
    Public tab_deviner1() As String
    Public timer_count As Integer = mod_param.get_timer() * jeu.Timer1.Interval

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
End Module
