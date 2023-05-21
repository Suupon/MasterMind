Imports System.Runtime.CompilerServices

Public Class Joueur
    Private nom_joueur As String
    Private score_joueur As Integer
    Private best_time_joueur As Integer 'en sec
    Private nb_partie_first_joueur As Integer
    Private nb_partie_second_joueur As Integer
    Private cumul_temp_deviner_combi_joueur As Integer ' en sec

    Sub New(nom As String, score As Integer, best_time As Integer, nb_partie_first As Integer, nb_partie_second As Integer, cumul_temp_deviner_combi As Integer)
        nom_joueur = nom
        score_joueur = score
        best_time_joueur = best_time
        nb_partie_first_joueur = nb_partie_first
        nb_partie_second_joueur = nb_partie_second
        cumul_temp_deviner_combi_joueur = cumul_temp_deviner_combi

    End Sub



    Public Function get_nom_joueur() As String
        Return nom_joueur
    End Function
    Public Function get_score_joueur() As Integer
        Return score_joueur
    End Function
    Public Function get_best_time_joueur() As Integer
        Return best_time_joueur
    End Function
    Public Function get_nb_partie_first_joueur() As Integer
        Return nb_partie_first_joueur
    End Function
    Public Function get_nb_partie_second_joueur() As Integer
        Return nb_partie_second_joueur
    End Function
    Public Function get_cumul_temp_joueur() As Integer
        Return cumul_temp_deviner_combi_joueur
    End Function
    Public Overrides Function ToString() As String
        Return "nom : " & nom_joueur & " Score : " & " " & score_joueur
    End Function
End Class
