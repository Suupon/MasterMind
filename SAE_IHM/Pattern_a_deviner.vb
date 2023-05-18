Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class Pattern_a_deviner
    Private Sub Pattern_a_deviner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        char_guess.Text = get_caractere_possibles()

        For Each textBox As TextBox In Panel_textbox.Controls.OfType(Of TextBox)()
            textBox.MaxLength = 1
            AddHandler textBox.KeyPress, AddressOf RestrictCharacters
        Next
        AfficherTextBox()

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



        For Each textBox As TextBox In Panel_textbox.Controls.OfType(Of TextBox)()
            If textBox.Visible AndAlso String.IsNullOrEmpty(textBox.Text) Then
                MessageBox.Show("Veuillez remplir toutes les TextBox avant de passer au formulaire suivant.")
                Return
            End If
           

        Next

        ReDim tab1(get_nb_case() - 1)

        ' Parcourez les TextBox visibles et stockez les données dans le tableau
        Dim index As Integer = 0
        For Each control As Control In Panel_textbox.Controls
            If TypeOf control Is TextBox AndAlso control.Visible Then
                tab1(index) = DirectCast(control, TextBox).Text
                index += 1
            End If
        Next

        jeu.Show()
        Me.Close()





    End Sub


End Class
