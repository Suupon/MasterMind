<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class statistique
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView_Joueur = New System.Windows.Forms.DataGridView()
        Me.cb_box_choix_trie = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_box_nom_joueur = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView_Joueur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_Joueur
        '
        Me.DataGridView_Joueur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Joueur.Location = New System.Drawing.Point(73, 126)
        Me.DataGridView_Joueur.Name = "DataGridView_Joueur"
        Me.DataGridView_Joueur.ReadOnly = True
        Me.DataGridView_Joueur.RowTemplate.Height = 25
        Me.DataGridView_Joueur.Size = New System.Drawing.Size(658, 371)
        Me.DataGridView_Joueur.TabIndex = 0
        '
        'cb_box_choix_trie
        '
        Me.cb_box_choix_trie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_box_choix_trie.FormattingEnabled = True
        Me.cb_box_choix_trie.Location = New System.Drawing.Point(73, 75)
        Me.cb_box_choix_trie.Name = "cb_box_choix_trie"
        Me.cb_box_choix_trie.Size = New System.Drawing.Size(182, 23)
        Me.cb_box_choix_trie.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Trié par : "
        '
        'txt_box_nom_joueur
        '
        Me.txt_box_nom_joueur.Location = New System.Drawing.Point(423, 75)
        Me.txt_box_nom_joueur.Name = "txt_box_nom_joueur"
        Me.txt_box_nom_joueur.Size = New System.Drawing.Size(160, 23)
        Me.txt_box_nom_joueur.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(423, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "nom du joueur :"
        '
        'statistique
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 528)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_box_nom_joueur)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_box_choix_trie)
        Me.Controls.Add(Me.DataGridView_Joueur)
        Me.Name = "statistique"
        Me.Text = "Statistique"
        CType(Me.DataGridView_Joueur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView_Joueur As DataGridView
    Friend WithEvents cb_box_choix_trie As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_box_nom_joueur As TextBox
    Friend WithEvents Label2 As Label
End Class
