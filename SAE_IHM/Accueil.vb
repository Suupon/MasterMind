Imports System.IO
Imports System.Text

Public Class Accueil


    Public Sub Accueil_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("voulez vous vraiment nous quitté ou avez vous juste missclick?", "Confirmation de fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            e.Cancel = True
        End If
    End Sub
    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mod_param.load_param()
        mod_fichier_joueurs.load_joueurs()



        Dim nom_joueurs_source As New AutoCompleteStringCollection()
        nom_joueurs_source.AddRange(mod_Liste_Joueurs.get_nom_joueurs.ToArray)
        autocompletion_cb_box_joueurs(cb_box_p1, nom_joueurs_source)
        autocompletion_cb_box_joueurs(cb_box_p2, nom_joueurs_source)

    End Sub



    Private Function pseudo_joueurs_valident(sender As Object, e As EventArgs) As Boolean
        If (cb_box_p1.Text.Equals("")) Then
            MsgBox("saisir un pseudo pour le joueur 1")
            Return False

        End If
        If (cb_box_p2.Text.Equals("")) Then
            MsgBox("saisir un pseudo pour le joueur 2")
            Return False
        End If
        Return Not cb_box_p1.Text.Equals(cb_box_p2.Text)

    End Function
    Sub autocompletion_cb_box_joueurs(cb As ComboBox, nom_joueurs_source As AutoCompleteStringCollection)
        cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cb.AutoCompleteSource = AutoCompleteSource.CustomSource
        cb.AutoCompleteCustomSource = nom_joueurs_source
    End Sub
    Private Sub btn_lancer_jeu_Click(sender As Object, e As EventArgs) Handles btn_lancer_jeu.Click
        Dim pseudo_j1 As String = cb_box_p1.Text
        Dim pseudo_j2 As String = cb_box_p2.Text

        Dim index_j1 As Integer = mod_Liste_Joueurs.get_index_joueur(pseudo_j1)
        Dim index_j2 As Integer = mod_Liste_Joueurs.get_index_joueur(pseudo_j2)

        If (pseudo_joueurs_valident(sender, e)) Then

            If (index_j1 = -1) Then
                set_joueur1(New Joueur(pseudo_j1, 0, Integer.MaxValue, 0, 0, 0))
                mod_Liste_Joueurs.add_joueur(get_joueur1)


            Else
                set_joueur1(New Joueur(mod_Liste_Joueurs.get_joueurs_str(index_j1).Split(";")))
            End If

            If (index_j2 = -1) Then
                set_joueur2(New Joueur(pseudo_j2, 0, Integer.MaxValue, 0, 0, 0))
                mod_Liste_Joueurs.add_joueur(get_joueur2())


            Else
                set_joueur2(New Joueur(mod_Liste_Joueurs.get_joueurs_str(index_j2).Split(";")))

            End If

            get_joueur1().inc_partie_first()
            get_joueur2.inc_partie_second()

            Pattern_a_deviner.Show()
            Me.Hide()
            Return
        End If
    End Sub

    Private Sub btn_param_Click(sender As Object, e As EventArgs) Handles btn_param.Click
        param.Show()
    End Sub

    Private Sub btn_stat_Click(sender As Object, e As EventArgs) Handles btn_stat.Click
        statistique.Show()
    End Sub


End Class
