<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pattern_a_deviner
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.mastermind = New System.Windows.Forms.Label()
        Me.char_guess = New System.Windows.Forms.Label()
        Me.char_jouable = New System.Windows.Forms.Label()
        Me.btn_cacher = New System.Windows.Forms.Button()
        Me.Panel_textbox = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'mastermind
        '
        Me.mastermind.AutoSize = True
        Me.mastermind.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.mastermind.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mastermind.Location = New System.Drawing.Point(351, 78)
        Me.mastermind.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.mastermind.Name = "mastermind"
        Me.mastermind.Size = New System.Drawing.Size(96, 17)
        Me.mastermind.TabIndex = 1
        Me.mastermind.Text = "Master Mind"
        '
        'char_guess
        '
        Me.char_guess.AutoSize = True
        Me.char_guess.Location = New System.Drawing.Point(798, 292)
        Me.char_guess.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.char_guess.Name = "char_guess"
        Me.char_guess.Size = New System.Drawing.Size(59, 15)
        Me.char_guess.TabIndex = 16
        Me.char_guess.Text = "# $ £ % @"
        '
        'char_jouable
        '
        Me.char_jouable.AutoSize = True
        Me.char_jouable.Location = New System.Drawing.Point(798, 255)
        Me.char_jouable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.char_jouable.Name = "char_jouable"
        Me.char_jouable.Size = New System.Drawing.Size(111, 15)
        Me.char_jouable.TabIndex = 15
        Me.char_jouable.Text = "Caractères Jouable :"
        '
        'btn_cacher
        '
        Me.btn_cacher.Location = New System.Drawing.Point(798, 195)
        Me.btn_cacher.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_cacher.Name = "btn_cacher"
        Me.btn_cacher.Size = New System.Drawing.Size(85, 27)
        Me.btn_cacher.TabIndex = 14
        Me.btn_cacher.Text = "Cacher"
        Me.btn_cacher.UseVisualStyleBackColor = True
        '
        'Panel_textbox
        '
        Me.Panel_textbox.Location = New System.Drawing.Point(34, 165)
        Me.Panel_textbox.Name = "Panel_textbox"
        Me.Panel_textbox.Size = New System.Drawing.Size(757, 78)
        Me.Panel_textbox.TabIndex = 17
        '
        'Pattern_a_deviner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 519)
        Me.Controls.Add(Me.Panel_textbox)
        Me.Controls.Add(Me.char_guess)
        Me.Controls.Add(Me.char_jouable)
        Me.Controls.Add(Me.btn_cacher)
        Me.Controls.Add(Me.mastermind)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Pattern_a_deviner"
        Me.Text = "Pattern à deviner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mastermind As Label
    Friend WithEvents char_guess As Label
    Friend WithEvents char_jouable As Label
    Friend WithEvents btn_cacher As Button
    Friend WithEvents Panel_textbox As Panel
End Class
