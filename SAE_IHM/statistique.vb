Imports System.Data.DataTable
Public Class statistique
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Joueur.CellContentClick

    End Sub

    Private Sub statistique_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim table As New DataTable("Table")
        table.Columns.Add("Nom")
        table.Columns.Add("Meilleur Score")
        table.Columns.Add("Meilleur Temps")
        table.Columns.Add("Nombre de partie 1er joueur")
        table.Columns.Add("Nombre de partie 2e joueur")
        table.Columns.Add("Total Temp")
        table.Rows.Add("JOJO", "3", "2", "43", "23", "26")
        Dim nom As String
        Dim meilleur_score As Integer
        Dim meilleur_temps As Integer
        Dim nb_partie_1er_joueur As Integer
        Dim nb_partie_2e_joueur As Integer
        Dim total_temp As Integer
        Dim joueurs_attributs As String()
        For Each joueur_str As String In mod_fichier_joueurs.all_joueurs_str
            Console.WriteLine(joueur_str)
            joueurs_attributs = joueur_str.Split(";")
            nom = joueurs_attributs(0)
            meilleur_score = CInt(joueurs_attributs(1))
            meilleur_temps = CInt(joueurs_attributs(2))
            nb_partie_1er_joueur = CInt(joueurs_attributs(3))
            nb_partie_2e_joueur = CInt(joueurs_attributs(4))
            total_temp = CInt(joueurs_attributs(5))
            table.Rows.Add(nom, meilleur_score, meilleur_temps, nb_partie_1er_joueur, nb_partie_2e_joueur, total_temp)
        Next
        DataGridView_Joueur.DataSource = table

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_box_nom.SelectedIndexChanged

    End Sub
End Class