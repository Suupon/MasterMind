<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class param
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_box_nb_essais = New System.Windows.Forms.TextBox()
        Me.lb_timer = New System.Windows.Forms.Label()
        Me.txt_box_timer = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_box_car_possibles = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_box_nb_cases = New System.Windows.Forms.ComboBox()
        Me.ck_use_time = New System.Windows.Forms.CheckBox()
        Me.btn_valide_param = New System.Windows.Forms.Button()
        Me.pnl_param = New System.Windows.Forms.Panel()
        Me.btn_couleur_abs = New System.Windows.Forms.Button()
        Me.btn_couleur_mal_place = New System.Windows.Forms.Button()
        Me.btn_couleur_bon = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.pnl_param.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(80, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 15)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Nombre d'essais"
        '
        'txt_box_nb_essais
        '
        Me.txt_box_nb_essais.Location = New System.Drawing.Point(199, 137)
        Me.txt_box_nb_essais.Name = "txt_box_nb_essais"
        Me.txt_box_nb_essais.Size = New System.Drawing.Size(121, 23)
        Me.txt_box_nb_essais.TabIndex = 20
        '
        'lb_timer
        '
        Me.lb_timer.AutoSize = True
        Me.lb_timer.Location = New System.Drawing.Point(80, 201)
        Me.lb_timer.Name = "lb_timer"
        Me.lb_timer.Size = New System.Drawing.Size(108, 15)
        Me.lb_timer.TabIndex = 19
        Me.lb_timer.Text = "Temps timer en sec"
        '
        'txt_box_timer
        '
        Me.txt_box_timer.Location = New System.Drawing.Point(199, 193)
        Me.txt_box_timer.Name = "txt_box_timer"
        Me.txt_box_timer.Size = New System.Drawing.Size(121, 23)
        Me.txt_box_timer.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(80, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Utilisation timer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Caractères possibles"
        '
        'txt_box_car_possibles
        '
        Me.txt_box_car_possibles.Location = New System.Drawing.Point(199, 101)
        Me.txt_box_car_possibles.Name = "txt_box_car_possibles"
        Me.txt_box_car_possibles.Size = New System.Drawing.Size(121, 23)
        Me.txt_box_car_possibles.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nombres de cases"
        '
        'cb_box_nb_cases
        '
        Me.cb_box_nb_cases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_box_nb_cases.FormattingEnabled = True
        Me.cb_box_nb_cases.Location = New System.Drawing.Point(199, 55)
        Me.cb_box_nb_cases.Name = "cb_box_nb_cases"
        Me.cb_box_nb_cases.Size = New System.Drawing.Size(121, 23)
        Me.cb_box_nb_cases.TabIndex = 13
        '
        'ck_use_time
        '
        Me.ck_use_time.AutoSize = True
        Me.ck_use_time.Checked = True
        Me.ck_use_time.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ck_use_time.Location = New System.Drawing.Point(199, 168)
        Me.ck_use_time.Name = "ck_use_time"
        Me.ck_use_time.Size = New System.Drawing.Size(76, 19)
        Me.ck_use_time.TabIndex = 12
        Me.ck_use_time.Text = "Use timer"
        Me.ck_use_time.UseVisualStyleBackColor = True
        '
        'btn_valide_param
        '
        Me.btn_valide_param.Location = New System.Drawing.Point(625, 375)
        Me.btn_valide_param.Name = "btn_valide_param"
        Me.btn_valide_param.Size = New System.Drawing.Size(75, 23)
        Me.btn_valide_param.TabIndex = 23
        Me.btn_valide_param.Text = "Validé"
        Me.btn_valide_param.UseVisualStyleBackColor = True
        '
        'pnl_param
        '
        Me.pnl_param.Controls.Add(Me.btn_couleur_abs)
        Me.pnl_param.Controls.Add(Me.btn_couleur_mal_place)
        Me.pnl_param.Controls.Add(Me.lb_timer)
        Me.pnl_param.Controls.Add(Me.btn_couleur_bon)
        Me.pnl_param.Controls.Add(Me.cb_box_nb_cases)
        Me.pnl_param.Controls.Add(Me.txt_box_timer)
        Me.pnl_param.Controls.Add(Me.ck_use_time)
        Me.pnl_param.Controls.Add(Me.Label1)
        Me.pnl_param.Controls.Add(Me.Label5)
        Me.pnl_param.Controls.Add(Me.txt_box_car_possibles)
        Me.pnl_param.Controls.Add(Me.txt_box_nb_essais)
        Me.pnl_param.Controls.Add(Me.Label2)
        Me.pnl_param.Controls.Add(Me.Label3)
        Me.pnl_param.Location = New System.Drawing.Point(214, 65)
        Me.pnl_param.Name = "pnl_param"
        Me.pnl_param.Size = New System.Drawing.Size(383, 305)
        Me.pnl_param.TabIndex = 24
        '
        'btn_couleur_abs
        '
        Me.btn_couleur_abs.Location = New System.Drawing.Point(274, 239)
        Me.btn_couleur_abs.Name = "btn_couleur_abs"
        Me.btn_couleur_abs.Size = New System.Drawing.Size(75, 63)
        Me.btn_couleur_abs.TabIndex = 24
        Me.btn_couleur_abs.Text = "Couleur absent"
        Me.btn_couleur_abs.UseVisualStyleBackColor = True
        '
        'btn_couleur_mal_place
        '
        Me.btn_couleur_mal_place.Location = New System.Drawing.Point(174, 239)
        Me.btn_couleur_mal_place.Name = "btn_couleur_mal_place"
        Me.btn_couleur_mal_place.Size = New System.Drawing.Size(75, 63)
        Me.btn_couleur_mal_place.TabIndex = 22
        Me.btn_couleur_mal_place.Text = "Couleur présent et mal placé"
        Me.btn_couleur_mal_place.UseVisualStyleBackColor = True
        '
        'btn_couleur_bon
        '
        Me.btn_couleur_bon.Location = New System.Drawing.Point(76, 239)
        Me.btn_couleur_bon.Name = "btn_couleur_bon"
        Me.btn_couleur_bon.Size = New System.Drawing.Size(75, 63)
        Me.btn_couleur_bon.TabIndex = 23
        Me.btn_couleur_bon.Text = "Couleur Présent et bien placé"
        Me.btn_couleur_bon.UseVisualStyleBackColor = True
        '
        'param
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnl_param)
        Me.Controls.Add(Me.btn_valide_param)
        Me.Name = "param"
        Me.Text = "paramètres"
        Me.pnl_param.ResumeLayout(False)
        Me.pnl_param.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents txt_box_nb_essais As TextBox
    Friend WithEvents lb_timer As Label
    Friend WithEvents txt_box_timer As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_box_car_possibles As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_box_nb_cases As ComboBox
    Friend WithEvents ck_use_time As CheckBox
    Friend WithEvents btn_valide_param As Button
    Friend WithEvents pnl_param As Panel
    Friend WithEvents btn_couleur_abs As Button
    Friend WithEvents btn_couleur_bon As Button
    Friend WithEvents btn_couleur_mal_place As Button
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
