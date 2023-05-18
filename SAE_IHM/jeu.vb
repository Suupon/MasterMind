Public Class jeu


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MsgBox("Temps écoulé")

    End Sub

    Private Sub jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        char_guess.Text = get_caractere_possibles()



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

        For Each textBox As TextBox In Panel_textbox.Controls.OfType(Of TextBox)()
            If textBox.Visible AndAlso String.IsNullOrEmpty(textBox.Text) Then
                MessageBox.Show("Veuillez remplir toutes les TextBox avant de passer au formulaire suivant.")
                Return
            End If
            If textBox.Visible = True AndAlso Not String.IsNullOrEmpty(textBox.Text) Then
                mod_enregistrement.tab2(MAX_NB_CASES) = textBox.Text
            End If
        Next

        For Each tb As TextBox In Panel_textbox.Controls.OfType(Of TextBox)
            For i As Integer = 0 To get_nb_case() - 1
                For j As Integer = 0 To get_nb_case() - 1
                    If tab1(i) = tab2(j) Then
                        tb.ForeColor = Color.Blue
                    Else
                        tb.ForeColor = Color.Black
                    End If
                Next
            Next
        Next

    End Sub
End Class