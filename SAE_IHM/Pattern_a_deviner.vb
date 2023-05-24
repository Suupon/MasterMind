Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class Pattern_a_deviner

    Private Sub Pattern_a_deviner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        char_guess.Text = get_caractere_possibles()

        For Each textBox As TextBox In Panel_textbox.Controls.OfType(Of TextBox)()
            textBox.MaxLength = 1
            AddHandler textBox.KeyPress, AddressOf RestrictCharacters
        Next
        AfficherTextBox()
        set_fermer_pattern(True)



    End Sub



    Public Sub Pattern_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing

        If get_fermer_pattern() = True Then
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



    Private Sub btn_cacher_Click(sender As Object, e As EventArgs) Handles btn_cacher.Click

        redim_tab_pattern1(get_nb_case() - 1)

        For Each textBox As TextBox In Panel_textbox.Controls.OfType(Of TextBox)()
            If textBox.Visible AndAlso String.IsNullOrEmpty(textBox.Text) Then
                MessageBox.Show("Veuillez remplir toutes les cases pour passer à la suite.")
                Return
            End If


        Next
        ' Parcourez les TextBox visibles et stockez les données dans le tableau
        Dim index As Integer = 0
        For Each control As Control In Panel_textbox.Controls
            If TypeOf control Is TextBox AndAlso control.Visible Then
                set_tab_pattern1(index, DirectCast(control, TextBox).Text)
                index += 1
            End If
        Next

        jeu.Show()
        set_fermer_pattern(False)
        Me.Close()

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub


End Class
