Public Class Pattern_a_deviner
    Private Sub Pattern_a_deviner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim textbox As TextBox
        Const panelX As Integer = 34
        Dim panel_width As Integer = Panel_textbox.Width
        Const espacement As Integer = 70
        Dim startX As Integer = panelX + (panel_width - get_nb_case() * espacement) \ 2



        For i As Integer = 0 To get_nb_case() - 1

            textbox = New TextBox()
            textbox.Location = New System.Drawing.Point(startX + (i - 1) * espacement, 0)
            textbox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            textbox.Name = "Txt_" & i
            textbox.Width = 70
            textbox.Visible = True
            textbox.MaxLength = 1
            Me.Controls.Add(textbox)
            Me.Panel_textbox.Controls.Add(textbox)


        Next

    End Sub

    Private Sub btn_cacher_Click(sender As Object, e As EventArgs) Handles btn_cacher.Click
        For i As Integer = 0 To get_nb_case() - 1
            Dim textbox As TextBox = Panel_textbox.Controls(i)
            Dim cpt As Integer = 0

            If textbox.Text = "" Then
                MsgBox("Veuillez remplir toute les cases")
                cpt += 1
                Exit For
            End If

            If cpt = 0 Then
                jeu.Show()
                Me.Close()
            End If

        Next
    End Sub

    Private Sub Panel_textbox_Paint(sender As Object, e As PaintEventArgs) Handles Panel_textbox.Paint
        For Each tb As TextBox In Panel_textbox.Controls
            GetNextControl(tb, True).Focus()
        Next

    End Sub

    Private Sub char_guess_Click(sender As Object, e As EventArgs) Handles char_guess.Click
        mod_param.get_caractere_possibles()
    End Sub
End Class
