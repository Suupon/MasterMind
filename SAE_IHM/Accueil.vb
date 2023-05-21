Imports System.IO
Imports System.Text

Public Class Accueil
    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim lst_joueurs_connus As String() = IO.File.ReadAllLines("E:\VBA\IHM_SAE\IHM_SAE\lst_joueurs.txt")

        mod_fichier_joueurs.load_joueurs()
        mod_param.load_param()


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
                mod_Liste_Joueurs.Joueur1 = New Joueur(pseudo_j1, 0, Integer.MaxValue, 0, 0, 0)
                mod_Liste_Joueurs.add_joueur(mod_Liste_Joueurs.Joueur1)


            Else
                mod_Liste_Joueurs.Joueur1 = New Joueur(mod_fichier_joueurs.all_joueurs_str(index_j1).Split(";"))
            End If

            If (index_j2 = -1) Then
                mod_Liste_Joueurs.Joueur2 = New Joueur(pseudo_j2, 0, Integer.MaxValue, 0, 0, 0)
                mod_Liste_Joueurs.add_joueur(mod_Liste_Joueurs.Joueur2)


            Else
                mod_Liste_Joueurs.Joueur2 = New Joueur(mod_fichier_joueurs.all_joueurs_str(index_j2).Split(";"))

            End If

            mod_Liste_Joueurs.Joueur1.inc_partie_first()
            mod_Liste_Joueurs.Joueur2.inc_partie_second()
            Me.Hide()
            Pattern_a_deviner.Show()
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
