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
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Panel_textbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'mastermind
        '
        Me.mastermind.AutoSize = True
        Me.mastermind.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.mastermind.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mastermind.Location = New System.Drawing.Point(400, 72)
        Me.mastermind.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.mastermind.Name = "mastermind"
        Me.mastermind.Size = New System.Drawing.Size(96, 17)
        Me.mastermind.TabIndex = 1
        Me.mastermind.Text = "Master Mind"
        '
        'char_guess
        '
        Me.char_guess.AutoSize = True
        Me.char_guess.Location = New System.Drawing.Point(705, 271)
        Me.char_guess.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.char_guess.Name = "char_guess"
        Me.char_guess.Size = New System.Drawing.Size(59, 15)
        Me.char_guess.TabIndex = 16
        Me.char_guess.Text = "# $ £ % @"
        '
        'char_jouable
        '
        Me.char_jouable.AutoSize = True
        Me.char_jouable.Location = New System.Drawing.Point(705, 231)
        Me.char_jouable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.char_jouable.Name = "char_jouable"
        Me.char_jouable.Size = New System.Drawing.Size(111, 15)
        Me.char_jouable.TabIndex = 15
        Me.char_jouable.Text = "Caractères Jouable :"
        '
        'btn_cacher
        '
        Me.btn_cacher.Location = New System.Drawing.Point(705, 168)
        Me.btn_cacher.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_cacher.Name = "btn_cacher"
        Me.btn_cacher.Size = New System.Drawing.Size(85, 27)
        Me.btn_cacher.TabIndex = 10
        Me.btn_cacher.Text = "Cacher"
        Me.btn_cacher.UseVisualStyleBackColor = True
        '
        'Panel_textbox
        '
        Me.Panel_textbox.Controls.Add(Me.TextBox2)
        Me.Panel_textbox.Controls.Add(Me.TextBox5)
        Me.Panel_textbox.Controls.Add(Me.TextBox9)
        Me.Panel_textbox.Controls.Add(Me.TextBox1)
        Me.Panel_textbox.Controls.Add(Me.TextBox3)
        Me.Panel_textbox.Controls.Add(Me.TextBox8)
        Me.Panel_textbox.Controls.Add(Me.TextBox7)
        Me.Panel_textbox.Controls.Add(Me.TextBox4)
        Me.Panel_textbox.Controls.Add(Me.TextBox6)
        Me.Panel_textbox.Location = New System.Drawing.Point(170, 164)
        Me.Panel_textbox.Name = "Panel_textbox"
        Me.Panel_textbox.Size = New System.Drawing.Size(508, 37)
        Me.Panel_textbox.TabIndex = 17
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(68, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(42, 23)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(164, 3)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(42, 23)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(404, 4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(42, 23)
        Me.TextBox8.TabIndex = 7
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(356, 3)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(42, 23)
        Me.TextBox7.TabIndex = 6
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(308, 4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(42, 23)
        Me.TextBox6.TabIndex = 5
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(212, 4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(42, 23)
        Me.TextBox4.TabIndex = 3
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
        Me.Panel_textbox.ResumeLayout(False)
        Me.Panel_textbox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mastermind As Label
    Friend WithEvents char_guess As Label
    Friend WithEvents char_jouable As Label
    Friend WithEvents btn_cacher As Button
    Friend WithEvents Panel_textbox As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
