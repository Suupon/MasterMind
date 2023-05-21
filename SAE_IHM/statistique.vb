Imports System.Data.DataTable
Public Class statistique


    Private Sub statistique_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim choix_trie As String() = {"Nom (Alphabétique)", "meilleur score", "meilleur temp"}
        cb_box_choix_trie.Items.AddRange(choix_trie)

        load_DataGridView_joueur()

    End Sub

    Private Sub load_DataGridView_joueur()
        Dim table As New DataTable("Table")
        table.Columns.Add("Nom", Type.GetType("System.String"))
        table.Columns.Add("Meilleur Score", Type.GetType("System.Int32"))
        table.Columns.Add("Meilleur Temps", Type.GetType("System.Int32"))
        table.Columns.Add("Nombre de partie 1er joueur", Type.GetType("System.Int32"))
        table.Columns.Add("Nombre de partie 2e joueur", Type.GetType("System.Int32"))
        table.Columns.Add("Total Temp")
        Dim nom As String
        Dim meilleur_score As Integer
        Dim meilleur_temps As Integer
        Dim nb_partie_1er_joueur As Integer
        Dim nb_partie_2e_joueur As Integer
        Dim total_temp As Integer
        Dim joueurs_attributs As String()
        For Each joueur_str As String In mod_fichier_joueurs.all_joueurs_str
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

    Private Sub cb_box_choix_trie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_box_choix_trie.SelectedIndexChanged

        If (cb_box_choix_trie.SelectedIndex = 0 Or cb_box_choix_trie.SelectedIndex = 2) Then
            DataGridView_Joueur.Sort(DataGridView_Joueur.Columns(cb_box_choix_trie.SelectedIndex), System.ComponentModel.ListSortDirection.Ascending)
        Else
            DataGridView_Joueur.Sort(DataGridView_Joueur.Columns(cb_box_choix_trie.SelectedIndex), System.ComponentModel.ListSortDirection.Descending)

        End If


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txt_box_nom_joueur_TextChanged(sender As Object, e As EventArgs) Handles txt_box_nom_joueur.TextChanged
        DataGridView_Joueur.ClearSelection()
        Dim searchText As String = txt_box_nom_joueur.Text.Trim()

        For Each row As DataGridViewRow In DataGridView_Joueur.Rows
            Dim cell As DataGridViewCell = row.Cells(0) ' Accéder à la première colonne (indice 0)

            If cell.Value IsNot Nothing AndAlso cell.Value.ToString().StartsWith(txt_box_nom_joueur.Text, StringComparison.OrdinalIgnoreCase) Then
                ' La valeur de la cellule correspond au critère de recherche
                ' Faites quelque chose avec la ligne correspondante, par exemple, la sélectionner ou effectuer une action spécifique.
                row.Selected = True
                ' Autres actions...
                DataGridView_Joueur.FirstDisplayedScrollingRowIndex = row.Index
                Exit For ' Sortir de la boucle si une correspondance est trouvée dans la première colonne
            End If
        Next


    End Sub


End Class