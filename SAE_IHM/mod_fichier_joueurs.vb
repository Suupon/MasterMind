Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Module mod_fichier_joueurs
    Private file_path_joueurs As String = "..\..\..\lst_joueurs.txt"
    'Public reader_of_joueur As New StreamReader(file_path_joueurs, Encoding.Default)
    'Public writer_of_joueur As New StreamWriter(file_path_joueurs)
    Public all_joueurs_str As String()

    Public Sub load_joueurs()
        all_joueurs_str = File.ReadAllLines(file_path_joueurs)
        Dim joueur_info_unsplit As String
        Dim joueur_info_split As String()

        Dim nom As String
        Dim score As Integer
        Dim best_time As Integer 'en sec
        Dim nb_partie_first As Integer
        Dim nb_partie_segond As Integer
        Dim cumul_temp_deviner_combi As Integer ' en sec

        For i As Integer = 0 To all_joueurs_str.Length - 1
            joueur_info_unsplit = all_joueurs_str(i)
            joueur_info_split = joueur_info_unsplit.Split(";")
            nom = joueur_info_split(0)
            score = CInt(joueur_info_split(1))
            best_time = CInt(joueur_info_split(2))
            nb_partie_first = CInt(joueur_info_split(3))
            nb_partie_segond = CInt(joueur_info_split(4))
            cumul_temp_deviner_combi = CInt(joueur_info_split(5))

            Dim joueur As New Joueur(nom, score, best_time, nb_partie_first, nb_partie_segond, cumul_temp_deviner_combi)
            Accueil.cb_box_p1.Items.Add(nom)
            Accueil.cb_box_p2.Items.Add(nom)

            mod_Liste_Joueurs.add_joueur(joueur)

        Next
    End Sub

    Private Function extract_pseudo_from_line(line As String) As String
        ' "line" represente un joueur au format : nom;score;meilleur_temp;nb_partie_jouer_1er;nb_partie_jouer_2e;
        ' retourne le nom du joueur 
        Return line.Split(";")(0)
    End Function

    Public Sub sauvegarde_joueurs(j1 As Joueur, j2 As Joueur)
        Dim nom_joueur As String
        For i As Integer = 0 To all_joueurs_str.Length
            nom_joueur = all_joueurs_str(i).Split(";")(0)
            If (nom_joueur.Equals(j1.get_nom)) Then
                all_joueurs_str(i) = j1.ToString
            End If
            If (nom_joueur.Equals(j2.get_nom)) Then
                all_joueurs_str(i) = j2.ToString
            End If
        Next

        If (File.Exists(file_path_joueurs)) Then

            File.WriteAllLines(file_path_joueurs, all_joueurs_str, Encoding.UTF8)
        End If
    End Sub
End Module
