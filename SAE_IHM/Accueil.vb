Imports System.IO
Imports System.Text

Public Class Accueil
    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim lst_joueurs_connus As String() = IO.File.ReadAllLines("E:\VBA\IHM_SAE\IHM_SAE\lst_joueurs.txt")
        Dim file_path_joueurs As String = "E:\VBA\IHM_SAE\IHM_SAE\lst_joueurs.txt"
        'cb_box_p1.Items.AddRange(lst_joueurs_connus)
        'cb_box_p2.Items.AddRange(lst_joueurs_connus)
        'charger_joueurs(mod_fichier_joueurs.reader_of_joueur)
        charger_joueurs(file_path_joueurs)

        Dim nom_joueurs_source As New AutoCompleteStringCollection()
        nom_joueurs_source.AddRange(mod_Liste_Joueurs.get_nom_joueurs.ToArray)
        cb_box_p1.AutoCompleteMode = AutoCompleteMode.Suggest
        cb_box_p1.AutoCompleteSource = AutoCompleteSource.CustomSource
        cb_box_p1.AutoCompleteCustomSource = nom_joueurs_source


        mod_Liste_Joueurs.print_joueurs()



    End Sub

    Private Sub cb_box_p1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_box_p1.SelectedIndexChanged
        MsgBox(cb_box_p1.Text)
    End Sub
    Private Sub charger_joueurs(file_path_joueurs As String)
        Dim joueur_info_unsplit As String
        Dim joueur_info_split As String()
        Dim reader As New StreamReader(file_path_joueurs, Encoding.Default)

        Dim nom As String
        Dim score As Integer
        Dim best_time As Integer 'en sec
        Dim nb_partie_first As Integer
        Dim nb_partie_segond As Integer
        Dim cumul_temp_deviner_combi As Integer ' en sec

        joueur_info_unsplit = reader.ReadLine()
        joueur_info_split = joueur_info_unsplit.Split(";")

        While (Not joueur_info_unsplit.Equals(""))

            nom = joueur_info_split(0)
            score = CInt(joueur_info_split(1))
            best_time = CInt(joueur_info_split(2))
            nb_partie_first = CInt(joueur_info_split(3))
            nb_partie_segond = CInt(joueur_info_split(4))
            cumul_temp_deviner_combi = CInt(joueur_info_split(5))

            Dim joueur As New Joueur(nom, score, best_time, nb_partie_first, nb_partie_segond, cumul_temp_deviner_combi)
            cb_box_p1.Items.Add(nom)
            cb_box_p2.Items.Add(nom)
            mod_Liste_Joueurs.add_joueur(joueur)
            joueur_info_unsplit = reader.ReadLine()
            joueur_info_split = joueur_info_unsplit.Split(";")
        End While
        reader.Close()
    End Sub
    Private Function pseudo_joueurs_different(sender As Object, e As EventArgs) As Boolean
        Return Not cb_box_p1.Text.Equals(cb_box_p2.Text)
    End Function

    Private Sub btn_lancer_jeu_Click(sender As Object, e As EventArgs) Handles btn_lancer_jeu.Click

        If (pseudo_joueurs_different(sender, e)) Then
            MsgBox("lancer jeu")

            If (Not mod_Liste_Joueurs.joueur_connu(cb_box_p1.Text)) Then
                MsgBox("p1 inconu")
                mod_Liste_Joueurs.add_joueur(New Joueur(cb_box_p1.Text, -1, -1, 0, 0, 0))
            End If

            If (Not mod_Liste_Joueurs.joueur_connu(cb_box_p2.Text)) Then
                MsgBox("p2 inconu")
                mod_Liste_Joueurs.add_joueur(New Joueur(cb_box_p1.Text, -1, -1, 0, 0, 0))
            End If

            Return
        End If
        MsgBox("pas content")
    End Sub
End Class
