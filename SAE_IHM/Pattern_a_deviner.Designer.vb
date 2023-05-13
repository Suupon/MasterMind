<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pattern_a_deviner
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
        Me.mastermind = New System.Windows.Forms.Label()
        Me.char_guess = New System.Windows.Forms.Label()
        Me.char_jouable = New System.Windows.Forms.Label()
        Me.btn_cacher = New System.Windows.Forms.Button()
        Me.Txt_5 = New System.Windows.Forms.TextBox()
        Me.Txt_4 = New System.Windows.Forms.TextBox()
        Me.Txt_3 = New System.Windows.Forms.TextBox()
        Me.Txt_2 = New System.Windows.Forms.TextBox()
        Me.Txt_1 = New System.Windows.Forms.TextBox()
        Me.Panel_textbox = New System.Windows.Forms.Panel()
        Me.Txt_6 = New System.Windows.Forms.TextBox()
        Me.Txt_7 = New System.Windows.Forms.TextBox()
        Me.Txt_8 = New System.Windows.Forms.TextBox()
        Me.Txt_9 = New System.Windows.Forms.TextBox()
        Me.Txt_10 = New System.Windows.Forms.TextBox()
        Me.Panel_textbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'mastermind
        '
        Me.mastermind.AutoSize = True
        Me.mastermind.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.mastermind.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mastermind.Location = New System.Drawing.Point(364, 111)
        Me.mastermind.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.mastermind.Name = "mastermind"
        Me.mastermind.Size = New System.Drawing.Size(96, 17)
        Me.mastermind.TabIndex = 1
        Me.mastermind.Text = "Master Mind"
        '
        'char_guess
        '
        Me.char_guess.AutoSize = True
        Me.char_guess.Location = New System.Drawing.Point(673, 295)
        Me.char_guess.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.char_guess.Name = "char_guess"
        Me.char_guess.Size = New System.Drawing.Size(59, 15)
        Me.char_guess.TabIndex = 16
        Me.char_guess.Text = "# $ £ % @"
        '
        'char_jouable
        '
        Me.char_jouable.AutoSize = True
        Me.char_jouable.Location = New System.Drawing.Point(673, 258)
        Me.char_jouable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.char_jouable.Name = "char_jouable"
        Me.char_jouable.Size = New System.Drawing.Size(111, 15)
        Me.char_jouable.TabIndex = 15
        Me.char_jouable.Text = "Caractères Jouable :"
        '
        'btn_cacher
        '
        Me.btn_cacher.Location = New System.Drawing.Point(673, 200)
        Me.btn_cacher.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_cacher.Name = "btn_cacher"
        Me.btn_cacher.Size = New System.Drawing.Size(85, 27)
        Me.btn_cacher.TabIndex = 14
        Me.btn_cacher.Text = "Cacher"
        Me.btn_cacher.UseVisualStyleBackColor = True
        '
        'Txt_5
        '
        Me.Txt_5.Location = New System.Drawing.Point(302, 31)
        Me.Txt_5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_5.Name = "Txt_5"
        Me.Txt_5.Size = New System.Drawing.Size(58, 23)
        Me.Txt_5.TabIndex = 13
        '
        'Txt_4
        '
        Me.Txt_4.Location = New System.Drawing.Point(236, 31)
        Me.Txt_4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_4.Name = "Txt_4"
        Me.Txt_4.Size = New System.Drawing.Size(58, 23)
        Me.Txt_4.TabIndex = 12
        '
        'Txt_3
        '
        Me.Txt_3.Location = New System.Drawing.Point(170, 31)
        Me.Txt_3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_3.Name = "Txt_3"
        Me.Txt_3.Size = New System.Drawing.Size(58, 23)
        Me.Txt_3.TabIndex = 11
        '
        'Txt_2
        '
        Me.Txt_2.Location = New System.Drawing.Point(104, 31)
        Me.Txt_2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_2.Name = "Txt_2"
        Me.Txt_2.Size = New System.Drawing.Size(58, 23)
        Me.Txt_2.TabIndex = 10
        '
        'Txt_1
        '
        Me.Txt_1.Location = New System.Drawing.Point(38, 31)
        Me.Txt_1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_1.Name = "Txt_1"
        Me.Txt_1.Size = New System.Drawing.Size(58, 23)
        Me.Txt_1.TabIndex = 9
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
        Me.Panel_textbox.Location = New System.Drawing.Point(216, 173)
        Me.Panel_textbox.Name = "Panel_textbox"
        Me.Panel_textbox.Size = New System.Drawing.Size(429, 149)
        Me.Panel_textbox.TabIndex = 17
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
        'Txt_7
        '
        Me.Txt_7.Location = New System.Drawing.Point(104, 77)
        Me.Txt_7.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_7.Name = "Txt_7"
        Me.Txt_7.Size = New System.Drawing.Size(58, 23)
        Me.Txt_7.TabIndex = 15
        Me.Txt_7.Visible = False
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
        'Txt_9
        '
        Me.Txt_9.Location = New System.Drawing.Point(236, 77)
        Me.Txt_9.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_9.Name = "Txt_9"
        Me.Txt_9.Size = New System.Drawing.Size(58, 23)
        Me.Txt_9.TabIndex = 17
        Me.Txt_9.Visible = False
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
    Friend WithEvents Txt_5 As TextBox
    Friend WithEvents Txt_4 As TextBox
    Friend WithEvents Txt_3 As TextBox
    Friend WithEvents Txt_2 As TextBox
    Friend WithEvents Txt_1 As TextBox
    Friend WithEvents Panel_textbox As Panel
    Friend WithEvents Txt_10 As TextBox
    Friend WithEvents Txt_9 As TextBox
    Friend WithEvents Txt_8 As TextBox
    Friend WithEvents Txt_7 As TextBox
    Friend WithEvents Txt_6 As TextBox
End Class
