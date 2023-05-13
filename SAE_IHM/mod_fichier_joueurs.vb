Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Module mod_fichier_joueurs
    Private file_path_joueurs As String = "E:\....\..\lst_joueurs.txt"
    Public reader_of_joueur As New StreamReader(file_path_joueurs, Encoding.Default)
    Public writer_of_joueur As New StreamWriter(file_path_joueurs)


    Public Sub add_joueur_to_file(j As Joueur)
        'ajoute un joueur dans le fichier au format :nom;score;meilleur_temp;nb_partie_jouer_1er;nb_partie_jouer_2e;
        'si le joueur existe deja j est alors le joueur connu mis a jour
        reader_of_joueur.BaseStream.Seek(0, SeekOrigin.Begin)

        Dim line As String
        Dim name_player_from_file As String

        While Not reader_of_joueur.EndOfStream
            line = reader_of_joueur.ReadLine
            name_player_from_file = extract_pseudo_from_line(line)
            If (name_player_from_file.Equals(j.get_nom)) Then
                ' reecrire dans le fichier 
            End If
        End While
    End Sub
    Private Function extract_pseudo_from_line(line As String) As String
        ' "line" represente un joueur au format : nom;score;meilleur_temp;nb_partie_jouer_1er;nb_partie_jouer_2e;
        ' retourne le nom du joueur 
        Return line.Split(";")(0)
    End Function
End Module
