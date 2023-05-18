Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class Pattern_a_deviner
    Private Sub Pattern_a_deviner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        char_guess.Text = get_caractere_possibles()
        For Each textBox As TextBox In Panel_textbox.Controls.OfType(Of TextBox)()
            textBox.MaxLength = 1
            AddHandler textBox.KeyPress, AddressOf RestrictCharacters
        Next

        For i As Integer = 0 To Panel_textbox.Controls.Count - 1

            While i < get_nb_case() - 1
                Panel_textbox.Controls(i).Visible = True
            End While

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

        For i As Integer = 0 To Panel_textbox.Controls.Count - 1
            If Panel_textbox.Controls(i).Visible = True Then
                mod_enregistrement.tab(i) = Panel_textbox.Controls(i).Text
            End If
        Next

        For Each textBox As TextBox In Panel_textbox.Controls.OfType(Of TextBox)()
            If textBox.Visible AndAlso String.IsNullOrEmpty(textBox.Text) Then
                MessageBox.Show("Veuillez remplir toutes les TextBox avant de passer au formulaire suivant.")
                Return
            End If

        Next


        jeu.Show()
        Me.Close()

    End Sub


End Class
