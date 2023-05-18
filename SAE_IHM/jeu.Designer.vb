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
        Me.components = New System.ComponentModel.Container()
        Me.char_guess = New System.Windows.Forms.Label()
        Me.char_jouable = New System.Windows.Forms.Label()
        Me.btn_deviner = New System.Windows.Forms.Button()
        Me.mastermind = New System.Windows.Forms.Label()
        Me.Code_Couleur = New System.Windows.Forms.Label()
        Me.Absent = New System.Windows.Forms.Label()
        Me.Present = New System.Windows.Forms.Label()
        Me.Present_et_Bien_Place = New System.Windows.Forms.Label()
        Me.Btn_bye = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_textbox = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
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
        Me.Panel_textbox.Controls.Add(Me.TextBox2)
        Me.Panel_textbox.Controls.Add(Me.TextBox5)
        Me.Panel_textbox.Controls.Add(Me.TextBox9)
        Me.Panel_textbox.Controls.Add(Me.TextBox7)
        Me.Panel_textbox.Controls.Add(Me.TextBox1)
        Me.Panel_textbox.Controls.Add(Me.TextBox3)
        Me.Panel_textbox.Controls.Add(Me.TextBox6)
        Me.Panel_textbox.Controls.Add(Me.TextBox8)
        Me.Panel_textbox.Controls.Add(Me.TextBox4)
        Me.Panel_textbox.Location = New System.Drawing.Point(84, 119)
        Me.Panel_textbox.Name = "Panel_textbox"
        Me.Panel_textbox.Size = New System.Drawing.Size(508, 37)
        Me.Panel_textbox.TabIndex = 32
        Me.Panel_textbox.TabStop = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(116, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(42, 23)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(260, 4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(42, 23)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(452, 4)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(42, 23)
        Me.TextBox9.TabIndex = 8
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(356, 4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(42, 23)
        Me.TextBox7.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(68, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(42, 23)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(164, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(42, 23)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(308, 4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(42, 23)
        Me.TextBox6.TabIndex = 5
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(404, 4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(42, 23)
        Me.TextBox8.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(212, 4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(42, 23)
        Me.TextBox4.TabIndex = 3
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(266, 222)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(198, 464)
        Me.RichTextBox1.TabIndex = 33
        Me.RichTextBox1.Text = ""
        '
        'jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 785)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Panel_textbox)
        Me.Controls.Add(Me.Btn_bye)
        Me.Controls.Add(Me.Present_et_Bien_Place)
        Me.Controls.Add(Me.Present)
        Me.Controls.Add(Me.Absent)
        Me.Controls.Add(Me.Code_Couleur)
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
    Friend WithEvents Code_Couleur As Label
    Friend WithEvents Absent As Label
    Friend WithEvents Present As Label
    Friend WithEvents Present_et_Bien_Place As Label
    Friend WithEvents Btn_bye As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel_textbox As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
