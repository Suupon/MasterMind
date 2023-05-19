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
        Label5 = New Label()
        txt_box_nb_essais = New TextBox()
        lb_timer = New Label()
        txt_box_timer = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        txt_box_car_possibles = New TextBox()
        Label1 = New Label()
        cb_box_nb_cases = New ComboBox()
        ck_use_time = New CheckBox()
        btn_valide_param = New Button()
        pnl_param = New Panel()
        pnl_param.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(91, 187)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 20)
        Label5.TabIndex = 21
        Label5.Text = "Nombre d'essais"
        ' 
        ' txt_box_nb_essais
        ' 
        txt_box_nb_essais.Location = New Point(227, 183)
        txt_box_nb_essais.Margin = New Padding(3, 4, 3, 4)
        txt_box_nb_essais.Name = "txt_box_nb_essais"
        txt_box_nb_essais.Size = New Size(138, 27)
        txt_box_nb_essais.TabIndex = 20
        ' 
        ' lb_timer
        ' 
        lb_timer.AutoSize = True
        lb_timer.Location = New Point(91, 268)
        lb_timer.Name = "lb_timer"
        lb_timer.Size = New Size(136, 20)
        lb_timer.TabIndex = 19
        lb_timer.Text = "Temps timer en sec"
        ' 
        ' txt_box_timer
        ' 
        txt_box_timer.Location = New Point(227, 257)
        txt_box_timer.Margin = New Padding(3, 4, 3, 4)
        txt_box_timer.Name = "txt_box_timer"
        txt_box_timer.Size = New Size(138, 27)
        txt_box_timer.TabIndex = 18
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(91, 224)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 20)
        Label3.TabIndex = 17
        Label3.Text = "Utilisation timer"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(91, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 20)
        Label2.TabIndex = 16
        Label2.Text = "Caractères possibles"
        ' 
        ' txt_box_car_possibles
        ' 
        txt_box_car_possibles.Location = New Point(227, 135)
        txt_box_car_possibles.Margin = New Padding(3, 4, 3, 4)
        txt_box_car_possibles.Name = "txt_box_car_possibles"
        txt_box_car_possibles.Size = New Size(138, 27)
        txt_box_car_possibles.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(91, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 20)
        Label1.TabIndex = 14
        Label1.Text = "Nombres de cases"
        ' 
        ' cb_box_nb_cases
        ' 
        cb_box_nb_cases.DropDownStyle = ComboBoxStyle.DropDownList
        cb_box_nb_cases.FormattingEnabled = True
        cb_box_nb_cases.Location = New Point(227, 73)
        cb_box_nb_cases.Margin = New Padding(3, 4, 3, 4)
        cb_box_nb_cases.Name = "cb_box_nb_cases"
        cb_box_nb_cases.Size = New Size(138, 28)
        cb_box_nb_cases.TabIndex = 13
        ' 
        ' ck_use_time
        ' 
        ck_use_time.AutoSize = True
        ck_use_time.Checked = True
        ck_use_time.CheckState = CheckState.Checked
        ck_use_time.Location = New Point(227, 224)
        ck_use_time.Margin = New Padding(3, 4, 3, 4)
        ck_use_time.Name = "ck_use_time"
        ck_use_time.Size = New Size(94, 24)
        ck_use_time.TabIndex = 12
        ck_use_time.Text = "Use timer"
        ck_use_time.UseVisualStyleBackColor = True
        ' 
        ' btn_valide_param
        ' 
        btn_valide_param.Location = New Point(686, 497)
        btn_valide_param.Margin = New Padding(3, 4, 3, 4)
        btn_valide_param.Name = "btn_valide_param"
        btn_valide_param.Size = New Size(86, 31)
        btn_valide_param.TabIndex = 23
        btn_valide_param.Text = "Validé"
        btn_valide_param.UseVisualStyleBackColor = True
        ' 
        ' pnl_param
        ' 
        pnl_param.Controls.Add(lb_timer)
        pnl_param.Controls.Add(cb_box_nb_cases)
        pnl_param.Controls.Add(txt_box_timer)
        pnl_param.Controls.Add(ck_use_time)
        pnl_param.Controls.Add(Label1)
        pnl_param.Controls.Add(Label5)
        pnl_param.Controls.Add(txt_box_car_possibles)
        pnl_param.Controls.Add(txt_box_nb_essais)
        pnl_param.Controls.Add(Label2)
        pnl_param.Controls.Add(Label3)
        pnl_param.Location = New Point(245, 87)
        pnl_param.Margin = New Padding(3, 4, 3, 4)
        pnl_param.Name = "pnl_param"
        pnl_param.Size = New Size(438, 407)
        pnl_param.TabIndex = 24
        ' 
        ' param
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(pnl_param)
        Controls.Add(btn_valide_param)
        Margin = New Padding(3, 4, 3, 4)
        Name = "param"
        Text = "paramètres"
        pnl_param.ResumeLayout(False)
        pnl_param.PerformLayout()
        ResumeLayout(False)
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
End Class
