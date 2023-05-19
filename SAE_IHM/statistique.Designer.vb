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
        Me.lst_box_nom = New System.Windows.Forms.ListBox()
        CType(Me.DataGridView_Joueur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_Joueur
        '
        Me.DataGridView_Joueur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Joueur.Location = New System.Drawing.Point(56, 251)
        Me.DataGridView_Joueur.Name = "DataGridView_Joueur"
        Me.DataGridView_Joueur.RowTemplate.Height = 25
        Me.DataGridView_Joueur.Size = New System.Drawing.Size(693, 243)
        Me.DataGridView_Joueur.TabIndex = 0
        '
        'lst_box_nom
        '
        Me.lst_box_nom.FormattingEnabled = True
        Me.lst_box_nom.ItemHeight = 15
        Me.lst_box_nom.Location = New System.Drawing.Point(56, 33)
        Me.lst_box_nom.Name = "lst_box_nom"
        Me.lst_box_nom.Size = New System.Drawing.Size(154, 124)
        Me.lst_box_nom.TabIndex = 1
        '
        'statistique
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 528)
        Me.Controls.Add(Me.lst_box_nom)
        Me.Controls.Add(Me.DataGridView_Joueur)
        Me.Name = "statistique"
        Me.Text = "Form1"
        CType(Me.DataGridView_Joueur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView_Joueur As DataGridView
    Friend WithEvents lst_box_nom As ListBox
End Class
