Public Class Joueur
    Private nom_joueur As String
    Private score_joueur As Integer
    Private best_time_joueur As Integer 'en sec
    Private nb_partie_first_joueur As Integer
    Private nb_partie_segond_joueur As Integer
    Private cumul_temp_deviner_combi_joueur As Integer ' en sec

    Sub New(nom As String, score As Integer, best_time As Integer, nb_partie_first As Integer, nb_partie_segond As Integer, cumul_temp_deviner_combi As Integer)
        nom_joueur = nom
        best_time_joueur = best_time
        nb_partie_first_joueur = nb_partie_first
        nb_partie_segond_joueur = nb_partie_segond
        cumul_temp_deviner_combi_joueur = cumul_temp_deviner_combi

    End Sub
    Public Function get_nom() As String
        Return nom_joueur
    End Function
    Public Function get_score() As Integer
        Return score_joueur
    End Function

    Public Overrides Function ToString() As String
        Return "nom : " & nom_joueur & " Score : " & " " & score_joueur
    End Function
End Class
