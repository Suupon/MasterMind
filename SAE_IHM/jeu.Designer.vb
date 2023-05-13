<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jeu
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
        Me.components = New System.ComponentModel.Container()
        Me.char_guess = New System.Windows.Forms.Label()
        Me.char_jouable = New System.Windows.Forms.Label()
        Me.btn_deviner = New System.Windows.Forms.Button()
        Me.mastermind = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Code_Couleur = New System.Windows.Forms.Label()
        Me.Absent = New System.Windows.Forms.Label()
        Me.Present = New System.Windows.Forms.Label()
        Me.Present_et_Bien_Place = New System.Windows.Forms.Label()
        Me.Btn_bye = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_textbox = New System.Windows.Forms.Panel()
        Me.Txt_10 = New System.Windows.Forms.TextBox()
        Me.Txt_9 = New System.Windows.Forms.TextBox()
        Me.Txt_8 = New System.Windows.Forms.TextBox()
        Me.Txt_7 = New System.Windows.Forms.TextBox()
        Me.Txt_6 = New System.Windows.Forms.TextBox()
        Me.Txt_1 = New System.Windows.Forms.TextBox()
        Me.Txt_2 = New System.Windows.Forms.TextBox()
        Me.Txt_3 = New System.Windows.Forms.TextBox()
        Me.Txt_4 = New System.Windows.Forms.TextBox()
        Me.Txt_5 = New System.Windows.Forms.TextBox()
        Me.Panel_textbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'char_guess
        '
        Me.char_guess.AutoSize = True
        Me.char_guess.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.char_guess.Location = New System.Drawing.Point(599, 324)
        Me.char_guess.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.char_guess.Name = "char_guess"
        Me.char_guess.Size = New System.Drawing.Size(61, 15)
        Me.char_guess.TabIndex = 25
        Me.char_guess.Text = "# $ £ % @"
        '
        'char_jouable
        '
        Me.char_jouable.AutoSize = True
        Me.char_jouable.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.char_jouable.Location = New System.Drawing.Point(599, 298)
        Me.char_jouable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.char_jouable.Name = "char_jouable"
        Me.char_jouable.Size = New System.Drawing.Size(117, 15)
        Me.char_jouable.TabIndex = 24
        Me.char_jouable.Text = "Caractères Jouable :"
        '
        'btn_deviner
        '
        Me.btn_deviner.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_deviner.Location = New System.Drawing.Point(599, 119)
        Me.btn_deviner.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_deviner.Name = "btn_deviner"
        Me.btn_deviner.Size = New System.Drawing.Size(85, 27)
        Me.btn_deviner.TabIndex = 23
        Me.btn_deviner.Text = "Deviner"
        Me.btn_deviner.UseVisualStyleBackColor = True
        '
        'mastermind
        '
        Me.mastermind.AutoSize = True
        Me.mastermind.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.mastermind.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mastermind.Location = New System.Drawing.Point(310, 59)
        Me.mastermind.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.mastermind.Name = "mastermind"
        Me.mastermind.Size = New System.Drawing.Size(96, 17)
        Me.mastermind.TabIndex = 17
        Me.mastermind.Text = "Master Mind"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(259, 251)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(197, 438)
        Me.ListView1.TabIndex = 26
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Code_Couleur
        '
        Me.Code_Couleur.AutoSize = True
        Me.Code_Couleur.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Code_Couleur.Location = New System.Drawing.Point(599, 177)
        Me.Code_Couleur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Code_Couleur.Name = "Code_Couleur"
        Me.Code_Couleur.Size = New System.Drawing.Size(81, 15)
        Me.Code_Couleur.TabIndex = 27
        Me.Code_Couleur.Text = "Code Couleur"
        '
        'Absent
        '
        Me.Absent.AutoSize = True
        Me.Absent.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Absent.Location = New System.Drawing.Point(599, 200)
        Me.Absent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Absent.Name = "Absent"
        Me.Absent.Size = New System.Drawing.Size(44, 15)
        Me.Absent.TabIndex = 28
        Me.Absent.Text = "Absent"
        '
        'Present
        '
        Me.Present.AutoSize = True
        Me.Present.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Present.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Present.Location = New System.Drawing.Point(599, 225)
        Me.Present.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Present.Name = "Present"
        Me.Present.Size = New System.Drawing.Size(111, 15)
        Me.Present.TabIndex = 29
        Me.Present.Text = "Caractères Jouable :"
        '
        'Present_et_Bien_Place
        '
        Me.Present_et_Bien_Place.AutoSize = True
        Me.Present_et_Bien_Place.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Present_et_Bien_Place.ForeColor = System.Drawing.Color.Lime
        Me.Present_et_Bien_Place.Location = New System.Drawing.Point(599, 250)
        Me.Present_et_Bien_Place.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Present_et_Bien_Place.Name = "Present_et_Bien_Place"
        Me.Present_et_Bien_Place.Size = New System.Drawing.Size(125, 15)
        Me.Present_et_Bien_Place.TabIndex = 30
        Me.Present_et_Bien_Place.Text = "Présent et Bien Placé"
        '
        'Btn_bye
        '
        Me.Btn_bye.Location = New System.Drawing.Point(649, 666)
        Me.Btn_bye.Name = "Btn_bye"
        Me.Btn_bye.Size = New System.Drawing.Size(75, 23)
        Me.Btn_bye.TabIndex = 31
        Me.Btn_bye.Text = "Bye"
        Me.Btn_bye.UseVisualStyleBackColor = True
        Me.Btn_bye.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 90000
        '
        'Panel_textbox
        '
        Me.Panel_textbox.Controls.Add(Me.Txt_10)
        Me.Panel_textbox.Controls.Add(Me.Txt_9)
        Me.Panel_textbox.Controls.Add(Me.Txt_8)
        Me.Panel_textbox.Controls.Add(Me.Txt_7)
        Me.Panel_textbox.Controls.Add(Me.Txt_6)
        Me.Panel_textbox.Controls.Add(Me.Txt_1)
        Me.Panel_textbox.Controls.Add(Me.Txt_2)
        Me.Panel_textbox.Controls.Add(Me.Txt_3)
        Me.Panel_textbox.Controls.Add(Me.Txt_4)
        Me.Panel_textbox.Controls.Add(Me.Txt_5)
        Me.Panel_textbox.Location = New System.Drawing.Point(137, 92)
        Me.Panel_textbox.Name = "Panel_textbox"
        Me.Panel_textbox.Size = New System.Drawing.Size(429, 149)
        Me.Panel_textbox.TabIndex = 32
        '
        'Txt_10
        '
        Me.Txt_10.Location = New System.Drawing.Point(302, 77)
        Me.Txt_10.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_10.Name = "Txt_10"
        Me.Txt_10.Size = New System.Drawing.Size(58, 23)
        Me.Txt_10.TabIndex = 18
        Me.Txt_10.Visible = False
        '
        'Txt_9
        '
        Me.Txt_9.Location = New System.Drawing.Point(236, 77)
        Me.Txt_9.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_9.Name = "Txt_9"
        Me.Txt_9.Size = New System.Drawing.Size(58, 23)
        Me.Txt_9.TabIndex = 17
        Me.Txt_9.Visible = False
        '
        'Txt_8
        '
        Me.Txt_8.Location = New System.Drawing.Point(170, 77)
        Me.Txt_8.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_8.Name = "Txt_8"
        Me.Txt_8.Size = New System.Drawing.Size(58, 23)
        Me.Txt_8.TabIndex = 16
        Me.Txt_8.Visible = False
        '
        'Txt_7
        '
        Me.Txt_7.Location = New System.Drawing.Point(104, 77)
        Me.Txt_7.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_7.Name = "Txt_7"
        Me.Txt_7.Size = New System.Drawing.Size(58, 23)
        Me.Txt_7.TabIndex = 15
        Me.Txt_7.Visible = False
        '
        'Txt_6
        '
        Me.Txt_6.Location = New System.Drawing.Point(38, 77)
        Me.Txt_6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_6.Name = "Txt_6"
        Me.Txt_6.Size = New System.Drawing.Size(58, 23)
        Me.Txt_6.TabIndex = 14
        Me.Txt_6.Visible = False
        '
        'Txt_1
        '
        Me.Txt_1.Location = New System.Drawing.Point(38, 31)
        Me.Txt_1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_1.Name = "Txt_1"
        Me.Txt_1.Size = New System.Drawing.Size(58, 23)
        Me.Txt_1.TabIndex = 9
        '
        'Txt_2
        '
        Me.Txt_2.Location = New System.Drawing.Point(104, 31)
        Me.Txt_2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_2.Name = "Txt_2"
        Me.Txt_2.Size = New System.Drawing.Size(58, 23)
        Me.Txt_2.TabIndex = 10
        '
        'Txt_3
        '
        Me.Txt_3.Location = New System.Drawing.Point(170, 31)
        Me.Txt_3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_3.Name = "Txt_3"
        Me.Txt_3.Size = New System.Drawing.Size(58, 23)
        Me.Txt_3.TabIndex = 11
        '
        'Txt_4
        '
        Me.Txt_4.Location = New System.Drawing.Point(236, 31)
        Me.Txt_4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_4.Name = "Txt_4"
        Me.Txt_4.Size = New System.Drawing.Size(58, 23)
        Me.Txt_4.TabIndex = 12
        '
        'Txt_5
        '
        Me.Txt_5.Location = New System.Drawing.Point(302, 31)
        Me.Txt_5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_5.Name = "Txt_5"
        Me.Txt_5.Size = New System.Drawing.Size(58, 23)
        Me.Txt_5.TabIndex = 13
        '
        'jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 785)
        Me.Controls.Add(Me.Panel_textbox)
        Me.Controls.Add(Me.Btn_bye)
        Me.Controls.Add(Me.Present_et_Bien_Place)
        Me.Controls.Add(Me.Present)
        Me.Controls.Add(Me.Absent)
        Me.Controls.Add(Me.Code_Couleur)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.char_guess)
        Me.Controls.Add(Me.char_jouable)
        Me.Controls.Add(Me.btn_deviner)
        Me.Controls.Add(Me.mastermind)
        Me.Name = "jeu"
        Me.Text = "jeu"
        Me.Panel_textbox.ResumeLayout(False)
        Me.Panel_textbox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents char_guess As Label
    Friend WithEvents char_jouable As Label
    Friend WithEvents btn_deviner As Button
    Friend WithEvents mastermind As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Code_Couleur As Label
    Friend WithEvents Absent As Label
    Friend WithEvents Present As Label
    Friend WithEvents Present_et_Bien_Place As Label
    Friend WithEvents Btn_bye As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel_textbox As Panel
    Friend WithEvents Txt_10 As TextBox
    Friend WithEvents Txt_9 As TextBox
    Friend WithEvents Txt_8 As TextBox
    Friend WithEvents Txt_7 As TextBox
    Friend WithEvents Txt_6 As TextBox
    Friend WithEvents Txt_1 As TextBox
    Friend WithEvents Txt_2 As TextBox
    Friend WithEvents Txt_3 As TextBox
    Friend WithEvents Txt_4 As TextBox
    Friend WithEvents Txt_5 As TextBox
End Class
