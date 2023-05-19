Module mod_Liste_Joueurs
    Private Joueurs As New List(Of Joueur)

    Public Joueur1 As Joueur
    Public Joueur2 As Joueur
    Sub add_joueur(j As Joueur)
        Joueurs.Add(j)
    End Sub
    Public Function get_joueurs() As List(Of Joueur)
        Return Joueurs 'fonction à supprimé plus tard je la garde pr les tests
    End Function
    Public Function get_nom_joueurs() As List(Of String)
        Dim liste_nom As New List(Of String)
        For Each j As Joueur In Joueurs
            liste_nom.Add(j.get_nom)
        Next
        Return liste_nom
    End Function

    Sub print_joueurs()
        For Each j As Joueur In Joueurs
            Console.WriteLine(j)
        Next
    End Sub
    Public Function joueur_connu(pseudo_joueur As String) As Boolean
        Return get_nom_joueurs.Contains(pseudo_joueur)
    End Function
End Module
