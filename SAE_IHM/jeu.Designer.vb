<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class jeu
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
        components = New ComponentModel.Container()
        char_guess = New Label()
        char_jouable = New Label()
        btn_deviner = New Button()
        mastermind = New Label()
        Code_Couleur = New Label()
        Absent = New Label()
        Present = New Label()
        Present_et_Bien_Place = New Label()
        Btn_bye = New Button()
        Timer1 = New Timer(components)
        Panel_textbox = New Panel()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        textbox10 = New TextBox()
        Compteur = New Label()
        Label_e_restant = New Label()
        Label_temps = New Label()
        Label_timer = New Label()
        RichTextBox_deviner = New RichTextBox()
        Panel_textbox.SuspendLayout()
        SuspendLayout()
        ' 
        ' char_guess
        ' 
        char_guess.AutoSize = True
        char_guess.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        char_guess.Location = New Point(683, 516)
        char_guess.Margin = New Padding(5, 0, 5, 0)
        char_guess.Name = "char_guess"
        char_guess.Size = New Size(79, 20)
        char_guess.TabIndex = 25
        char_guess.Text = "# $ £ % @"
        ' 
        ' char_jouable
        ' 
        char_jouable.AutoSize = True
        char_jouable.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        char_jouable.Location = New Point(683, 481)
        char_jouable.Margin = New Padding(5, 0, 5, 0)
        char_jouable.Name = "char_jouable"
        char_jouable.Size = New Size(148, 20)
        char_jouable.TabIndex = 24
        char_jouable.Text = "Caractères Jouable :"
        ' 
        ' btn_deviner
        ' 
        btn_deviner.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_deviner.Location = New Point(683, 243)
        btn_deviner.Margin = New Padding(5, 4, 5, 4)
        btn_deviner.Name = "btn_deviner"
        btn_deviner.Size = New Size(97, 36)
        btn_deviner.TabIndex = 10
        btn_deviner.Text = "Deviner"
        btn_deviner.UseVisualStyleBackColor = True
        ' 
        ' mastermind
        ' 
        mastermind.AutoSize = True
        mastermind.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point)
        mastermind.ForeColor = SystemColors.ActiveCaptionText
        mastermind.Location = New Point(353, 163)
        mastermind.Margin = New Padding(6, 0, 6, 0)
        mastermind.Name = "mastermind"
        mastermind.Size = New Size(113, 20)
        mastermind.TabIndex = 17
        mastermind.Text = "Master Mind"
        ' 
        ' Code_Couleur
        ' 
        Code_Couleur.AutoSize = True
        Code_Couleur.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Code_Couleur.Location = New Point(683, 320)
        Code_Couleur.Margin = New Padding(5, 0, 5, 0)
        Code_Couleur.Name = "Code_Couleur"
        Code_Couleur.Size = New Size(102, 20)
        Code_Couleur.TabIndex = 27
        Code_Couleur.Text = "Code Couleur"
        ' 
        ' Absent
        ' 
        Absent.AutoSize = True
        Absent.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Absent.Location = New Point(683, 351)
        Absent.Margin = New Padding(5, 0, 5, 0)
        Absent.Name = "Absent"
        Absent.Size = New Size(55, 20)
        Absent.TabIndex = 28
        Absent.Text = "Absent"
        ' 
        ' Present
        ' 
        Present.AutoSize = True
        Present.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Present.ForeColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Present.Location = New Point(683, 384)
        Present.Margin = New Padding(5, 0, 5, 0)
        Present.Name = "Present"
        Present.Size = New Size(57, 20)
        Present.TabIndex = 29
        Present.Text = "Présent"
        ' 
        ' Present_et_Bien_Place
        ' 
        Present_et_Bien_Place.AutoSize = True
        Present_et_Bien_Place.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Present_et_Bien_Place.ForeColor = Color.Lime
        Present_et_Bien_Place.Location = New Point(685, 420)
        Present_et_Bien_Place.Margin = New Padding(5, 0, 5, 0)
        Present_et_Bien_Place.Name = "Present_et_Bien_Place"
        Present_et_Bien_Place.Size = New Size(155, 20)
        Present_et_Bien_Place.TabIndex = 30
        Present_et_Bien_Place.Text = "Présent et Bien Placé"
        ' 
        ' Btn_bye
        ' 
        Btn_bye.Location = New Point(742, 888)
        Btn_bye.Margin = New Padding(3, 4, 3, 4)
        Btn_bye.Name = "Btn_bye"
        Btn_bye.Size = New Size(86, 31)
        Btn_bye.TabIndex = 31
        Btn_bye.Text = "Bye"
        Btn_bye.UseVisualStyleBackColor = True
        Btn_bye.Visible = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' Panel_textbox
        ' 
        Panel_textbox.Controls.Add(TextBox1)
        Panel_textbox.Controls.Add(TextBox2)
        Panel_textbox.Controls.Add(TextBox3)
        Panel_textbox.Controls.Add(TextBox4)
        Panel_textbox.Controls.Add(TextBox5)
        Panel_textbox.Controls.Add(TextBox6)
        Panel_textbox.Controls.Add(TextBox7)
        Panel_textbox.Controls.Add(TextBox8)
        Panel_textbox.Controls.Add(TextBox9)
        Panel_textbox.Controls.Add(textbox10)
        Panel_textbox.Location = New Point(97, 243)
        Panel_textbox.Margin = New Padding(3, 4, 3, 4)
        Panel_textbox.Name = "Panel_textbox"
        Panel_textbox.Size = New Size(557, 49)
        Panel_textbox.TabIndex = 34
        Panel_textbox.TabStop = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(27, 5)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(45, 27)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(80, 5)
        TextBox2.Margin = New Padding(3, 4, 3, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(45, 27)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(133, 5)
        TextBox3.Margin = New Padding(3, 4, 3, 4)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(45, 27)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(185, 5)
        TextBox4.Margin = New Padding(3, 4, 3, 4)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(45, 27)
        TextBox4.TabIndex = 3
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(238, 5)
        TextBox5.Margin = New Padding(3, 4, 3, 4)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(45, 27)
        TextBox5.TabIndex = 4
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(290, 5)
        TextBox6.Margin = New Padding(3, 4, 3, 4)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(45, 27)
        TextBox6.TabIndex = 5
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(343, 5)
        TextBox7.Margin = New Padding(3, 4, 3, 4)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(45, 27)
        TextBox7.TabIndex = 6
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(395, 5)
        TextBox8.Margin = New Padding(3, 4, 3, 4)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(45, 27)
        TextBox8.TabIndex = 7
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(448, 5)
        TextBox9.Margin = New Padding(3, 4, 3, 4)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(45, 27)
        TextBox9.TabIndex = 8
        ' 
        ' textbox10
        ' 
        textbox10.Location = New Point(501, 5)
        textbox10.Margin = New Padding(3, 4, 3, 4)
        textbox10.Name = "textbox10"
        textbox10.Size = New Size(45, 27)
        textbox10.TabIndex = 9
        ' 
        ' Compteur
        ' 
        Compteur.AutoSize = True
        Compteur.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Compteur.Location = New Point(205, 12)
        Compteur.Name = "Compteur"
        Compteur.Size = New Size(87, 23)
        Compteur.TabIndex = 36
        Compteur.Text = "Compteur"
        ' 
        ' Label_e_restant
        ' 
        Label_e_restant.AutoSize = True
        Label_e_restant.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label_e_restant.Location = New Point(14, 12)
        Label_e_restant.Name = "Label_e_restant"
        Label_e_restant.Size = New Size(200, 23)
        Label_e_restant.TabIndex = 37
        Label_e_restant.Text = "Nombre d'essai restant : "
        ' 
        ' Label_temps
        ' 
        Label_temps.AutoSize = True
        Label_temps.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label_temps.Location = New Point(14, 52)
        Label_temps.Name = "Label_temps"
        Label_temps.Size = New Size(130, 23)
        Label_temps.TabIndex = 38
        Label_temps.Text = "Temps restant : "
        ' 
        ' Label_timer
        ' 
        Label_timer.AutoSize = True
        Label_timer.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label_timer.Location = New Point(142, 52)
        Label_timer.Name = "Label_timer"
        Label_timer.Size = New Size(53, 23)
        Label_timer.TabIndex = 39
        Label_timer.Text = "Timer"
        ' 
        ' RichTextBox_deviner
        ' 
        RichTextBox_deviner.Location = New Point(321, 380)
        RichTextBox_deviner.Margin = New Padding(3, 4, 3, 4)
        RichTextBox_deviner.Name = "RichTextBox_deviner"
        RichTextBox_deviner.ReadOnly = True
        RichTextBox_deviner.Size = New Size(217, 212)
        RichTextBox_deviner.TabIndex = 40
        RichTextBox_deviner.Text = ""
        ' 
        ' jeu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(903, 1047)
        Controls.Add(RichTextBox_deviner)
        Controls.Add(Label_timer)
        Controls.Add(Label_temps)
        Controls.Add(Label_e_restant)
        Controls.Add(Compteur)
        Controls.Add(Panel_textbox)
        Controls.Add(Btn_bye)
        Controls.Add(Present_et_Bien_Place)
        Controls.Add(Present)
        Controls.Add(Absent)
        Controls.Add(Code_Couleur)
        Controls.Add(char_guess)
        Controls.Add(char_jouable)
        Controls.Add(btn_deviner)
        Controls.Add(mastermind)
        Margin = New Padding(3, 4, 3, 4)
        Name = "jeu"
        Text = "jeu"
        Panel_textbox.ResumeLayout(False)
        Panel_textbox.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents char_guess As Label
    Friend WithEvents char_jouable As Label
    Friend WithEvents btn_deviner As Button
    Friend WithEvents mastermind As Label
    Friend WithEvents Code_Couleur As Label
    Friend WithEvents Absent As Label
    Friend WithEvents Present As Label
    Friend WithEvents Present_et_Bien_Place As Label
    Friend WithEvents Btn_bye As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel_textbox As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents textbox10 As TextBox
    Friend WithEvents Compteur As Label
    Friend WithEvents Label_e_restant As Label
    Friend WithEvents Label_temps As Label
    Friend WithEvents Label_timer As Label
    Friend WithEvents RichTextBox_deviner As RichTextBox
End Class
