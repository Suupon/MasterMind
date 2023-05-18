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
                Dim textBox As TextBox = DirectCast(Panel_textbox.Controls(i), TextBox)
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

End Class