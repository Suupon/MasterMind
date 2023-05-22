Imports System.IO

Module mod_param
    Public file_path_param = "..\..\..\param.txt"
    Private param_str As String() = File.ReadAllLines(file_path_param)
    'Public param_str = File.ReadAllLines(file_path_param)
    Public Const MAX_NB_CASES = 10
    Public Const MIN_NB_CASES = 3
    Private nb_case As Integer
    Private caractere_possibles As String
    Private use_time As Boolean
    Private timer As Integer
    Private nb_essais As Integer

    Private color_bon As Color
    Private color_mal_place As Color
    Private color_abs As Color

    Private file_path_joueur As String
    Public Sub load_param()
        Dim param_str As String() = File.ReadAllLines(file_path_param)
        nb_case = CInt(param_str(0).Split("=")(1))
        caractere_possibles = param_str(1).Split("=")(1)
        use_time = CBool(param_str(2).Split("=")(1))
        timer = CInt(param_str(3).Split("=")(1))
        nb_essais = CInt(param_str(4).Split("=")(1))

        color_bon = Color.FromName(param_str(5).Split("=")(1))
        color_mal_place = Color.FromName(param_str(6).Split("=")(1))
        color_abs = Color.FromName(param_str(7).Split("=")(1))

        file_path_joueur = param_str(8).Split("=")(1)
    End Sub
    Public Function get_param_str() As String()
        Return param_str
    End Function

    Public Function get_nb_case() As Integer
        Return nb_case
    End Function
    Public Function get_caractere_possibles() As String
        Return caractere_possibles
    End Function
    Public Function get_use_time() As Integer
        Return use_time
    End Function
    Public Function get_timer() As Integer
        Return timer
    End Function
    Public Function get_nb_essais() As Integer
        Return nb_essais
    End Function

    Public Function get_color_bon() As Color
        Return color_bon
    End Function
    Public Function get_color_mal_place() As Color
        Return color_mal_place
    End Function
    Public Function get_color_abs() As Color
        Return color_abs
    End Function

    Public Function get_file_path_joueur() As String
        Return file_path_joueur
    End Function

    Public Sub set_nb_case(x As Integer)
        nb_case = x
    End Sub

    Public Sub set_caratere_possible(s As String)
        caractere_possibles = s
    End Sub
    Public Sub set_use_time(b As Boolean)
        use_time = b
    End Sub
    Public Sub set_timer(x As Integer)
        timer = x
    End Sub
    Public Sub set_nb_essais(x As Integer)
        nb_essais = x
    End Sub

    Public Sub set_color_bon(c As Color)
        color_bon = c
    End Sub
    Public Sub set_color_mal_place(c As Color)
        color_mal_place = c
    End Sub
    Public Sub set_color_abs(c As Color)
        color_abs = c
    End Sub

    Public Sub set_file_path_joueur(file_path As String)
        file_path_joueur = file_path
    End Sub

End Module
