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
        Me.cb_box_p1 = New System.Windows.Forms.ComboBox()
        Me.cb_box_p2 = New System.Windows.Forms.ComboBox()
        Me.btn_lancer_jeu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_param = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cb_box_p1
        '
        Me.cb_box_p1.BackColor = System.Drawing.SystemColors.Window
        Me.cb_box_p1.FormattingEnabled = True
        Me.cb_box_p1.Location = New System.Drawing.Point(338, 118)
        Me.cb_box_p1.Name = "cb_box_p1"
        Me.cb_box_p1.Size = New System.Drawing.Size(121, 23)
        Me.cb_box_p1.TabIndex = 0
        '
        'cb_box_p2
        '
        Me.cb_box_p2.FormattingEnabled = True
        Me.cb_box_p2.Location = New System.Drawing.Point(338, 223)
        Me.cb_box_p2.Name = "cb_box_p2"
        Me.cb_box_p2.Size = New System.Drawing.Size(121, 23)
        Me.cb_box_p2.TabIndex = 1
        '
        'btn_lancer_jeu
        '
        Me.btn_lancer_jeu.Location = New System.Drawing.Point(345, 315)
        Me.btn_lancer_jeu.Name = "btn_lancer_jeu"
        Me.btn_lancer_jeu.Size = New System.Drawing.Size(114, 34)
        Me.btn_lancer_jeu.TabIndex = 2
        Me.btn_lancer_jeu.Text = "C'est partie !" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_lancer_jeu.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(367, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PLAYER 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(367, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PLAYER 2"
        '
        'btn_param
        '
        Me.btn_param.Location = New System.Drawing.Point(567, 343)
        Me.btn_param.Name = "btn_param"
        Me.btn_param.Size = New System.Drawing.Size(75, 23)
        Me.btn_param.TabIndex = 5
        Me.btn_param.Text = "Paramètres"
        Me.btn_param.UseVisualStyleBackColor = True
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_param)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_lancer_jeu)
        Me.Controls.Add(Me.cb_box_p2)
        Me.Controls.Add(Me.cb_box_p1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Accueil"
        Me.Text = "Accueil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb_box_p1 As ComboBox
    Friend WithEvents cb_box_p2 As ComboBox
    Friend WithEvents btn_lancer_jeu As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_param As Button
End Class
