<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accueil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.background_accueil = New System.Windows.Forms.PictureBox()
        Me.btn_stat = New System.Windows.Forms.Button()
        Me.btn_param = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_lancer_jeu = New System.Windows.Forms.Button()
        Me.cb_box_p2 = New System.Windows.Forms.ComboBox()
        Me.cb_box_p1 = New System.Windows.Forms.ComboBox()
        CType(Me.background_accueil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'background_accueil
        '
        Me.background_accueil.Location = New System.Drawing.Point(0, 2)
        Me.background_accueil.Name = "background_accueil"
        Me.background_accueil.Size = New System.Drawing.Size(801, 448)
        Me.background_accueil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.background_accueil.TabIndex = 15
        Me.background_accueil.TabStop = False
        '
        'btn_stat
        '
        Me.btn_stat.Location = New System.Drawing.Point(679, 297)
        Me.btn_stat.Name = "btn_stat"
        Me.btn_stat.Size = New System.Drawing.Size(75, 23)
        Me.btn_stat.TabIndex = 22
        Me.btn_stat.Text = "Statistique"
        Me.btn_stat.UseVisualStyleBackColor = True
        '
        'btn_param
        '
        Me.btn_param.Location = New System.Drawing.Point(679, 347)
        Me.btn_param.Name = "btn_param"
        Me.btn_param.Size = New System.Drawing.Size(75, 23)
        Me.btn_param.TabIndex = 21
        Me.btn_param.Text = "Paramètres"
        Me.btn_param.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(526, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "PLAYER 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(526, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "PLAYER 1"
        '
        'btn_lancer_jeu
        '
        Me.btn_lancer_jeu.AccessibleName = ""
        Me.btn_lancer_jeu.Location = New System.Drawing.Point(491, 310)
        Me.btn_lancer_jeu.Name = "btn_lancer_jeu"
        Me.btn_lancer_jeu.Size = New System.Drawing.Size(121, 34)
        Me.btn_lancer_jeu.TabIndex = 18
        Me.btn_lancer_jeu.Text = "C'est parti !" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_lancer_jeu.UseVisualStyleBackColor = True
        '
        'cb_box_p2
        '
        Me.cb_box_p2.FormattingEnabled = True
        Me.cb_box_p2.Location = New System.Drawing.Point(491, 217)
        Me.cb_box_p2.Name = "cb_box_p2"
        Me.cb_box_p2.Size = New System.Drawing.Size(121, 23)
        Me.cb_box_p2.TabIndex = 17
        '
        'cb_box_p1
        '
        Me.cb_box_p1.BackColor = System.Drawing.SystemColors.Window
        Me.cb_box_p1.FormattingEnabled = True
        Me.cb_box_p1.Location = New System.Drawing.Point(491, 125)
        Me.cb_box_p1.Name = "cb_box_p1"
        Me.cb_box_p1.Size = New System.Drawing.Size(121, 23)
        Me.cb_box_p1.TabIndex = 16
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_stat)
        Me.Controls.Add(Me.btn_param)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_lancer_jeu)
        Me.Controls.Add(Me.cb_box_p2)
        Me.Controls.Add(Me.cb_box_p1)
        Me.Controls.Add(Me.background_accueil)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Accueil"
        CType(Me.background_accueil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents background_accueil As PictureBox
    Friend WithEvents btn_stat As Button
    Friend WithEvents btn_param As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_lancer_jeu As Button
    Friend WithEvents cb_box_p2 As ComboBox
    Friend WithEvents cb_box_p1 As ComboBox
End Class
