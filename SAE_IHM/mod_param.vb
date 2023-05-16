Imports System.IO

Module mod_param
    Private file_path_param = "..\..\..\param.txt"
    'Public param_str = File.ReadAllLines(file_path_param)
    Public Const MAX_NB_CASES = 10
    Public Const MIN_NB_CASES = 3
    Private nb_case As Integer
    Private caractere_possibles As String
    Private use_time As Boolean
    Private timer As Integer
    Private nb_essais As Integer

    Public Sub load_param()
        Dim param_str As String() = File.ReadAllLines(file_path_param)
        nb_case = CInt(param_str(0).Split("=")(1))
        caractere_possibles = param_str(1).Split("=")(1)
        use_time = CBool(param_str(2).Split("=")(1))
        timer = CInt(param_str(3).Split("=")(1))
        nb_essais = CInt(param_str(4).Split("=")(1))
    End Sub
    Public Sub print_param()
        Console.WriteLine(nb_case)
        Console.WriteLine(caractere_possibles)
        Console.WriteLine(use_time)
        Console.WriteLine(timer)
        Console.WriteLine(nb_essais)

    End Sub

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

End Module
