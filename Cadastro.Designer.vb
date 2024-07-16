<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cadastro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cadastro))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ckb_versenhas = New System.Windows.Forms.CheckBox()
        Me.txt_usuario = New System.Windows.Forms.MaskedTextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_confpass = New System.Windows.Forms.MaskedTextBox()
        Me.txt_confemail = New System.Windows.Forms.MaskedTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_pass = New System.Windows.Forms.MaskedTextBox()
        Me.txt_email2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_retornar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_contato = New System.Windows.Forms.MaskedTextBox()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.Button1.FlatAppearance.BorderSize = 4
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(725, 438)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 61)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Cadastrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ckb_versenhas
        '
        Me.ckb_versenhas.AutoSize = True
        Me.ckb_versenhas.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckb_versenhas.Image = CType(resources.GetObject("ckb_versenhas.Image"), System.Drawing.Image)
        Me.ckb_versenhas.Location = New System.Drawing.Point(916, 376)
        Me.ckb_versenhas.Margin = New System.Windows.Forms.Padding(4)
        Me.ckb_versenhas.Name = "ckb_versenhas"
        Me.ckb_versenhas.Size = New System.Drawing.Size(63, 33)
        Me.ckb_versenhas.TabIndex = 59
        Me.ckb_versenhas.Text = "    "
        Me.ckb_versenhas.UseVisualStyleBackColor = True
        '
        'txt_usuario
        '
        Me.txt_usuario.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.Location = New System.Drawing.Point(49, 191)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(860, 32)
        Me.txt_usuario.TabIndex = 45
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(44, 152)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(155, 28)
        Me.Label22.TabIndex = 57
        Me.Label22.Text = "Nome Completo"
        '
        'txt_confpass
        '
        Me.txt_confpass.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_confpass.Location = New System.Drawing.Point(514, 377)
        Me.txt_confpass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_confpass.Name = "txt_confpass"
        Me.txt_confpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_confpass.Size = New System.Drawing.Size(395, 32)
        Me.txt_confpass.TabIndex = 49
        '
        'txt_confemail
        '
        Me.txt_confemail.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_confemail.Location = New System.Drawing.Point(514, 282)
        Me.txt_confemail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_confemail.Name = "txt_confemail"
        Me.txt_confemail.Size = New System.Drawing.Size(395, 32)
        Me.txt_confemail.TabIndex = 47
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(509, 337)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(165, 28)
        Me.Label19.TabIndex = 54
        Me.Label19.Text = "Confirmar Senha"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(509, 243)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(169, 28)
        Me.Label20.TabIndex = 53
        Me.Label20.Text = "Confirmar E-mail"
        '
        'txt_pass
        '
        Me.txt_pass.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.Location = New System.Drawing.Point(49, 377)
        Me.txt_pass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_pass.Size = New System.Drawing.Size(395, 32)
        Me.txt_pass.TabIndex = 48
        '
        'txt_email2
        '
        Me.txt_email2.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email2.Location = New System.Drawing.Point(49, 282)
        Me.txt_email2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_email2.Name = "txt_email2"
        Me.txt_email2.Size = New System.Drawing.Size(395, 32)
        Me.txt_email2.TabIndex = 46
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(44, 337)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 28)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "Senha"
        '
        'btn_retornar
        '
        Me.btn_retornar.BackColor = System.Drawing.Color.Salmon
        Me.btn_retornar.FlatAppearance.BorderSize = 0
        Me.btn_retornar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_retornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_retornar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_retornar.ForeColor = System.Drawing.Color.White
        Me.btn_retornar.Location = New System.Drawing.Point(49, 438)
        Me.btn_retornar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_retornar.Name = "btn_retornar"
        Me.btn_retornar.Size = New System.Drawing.Size(184, 61)
        Me.btn_retornar.TabIndex = 60
        Me.btn_retornar.Text = "Retornar"
        Me.btn_retornar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 243)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 28)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "E-mail"
        '
        'txt_cpf
        '
        Me.txt_cpf.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(49, 100)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_cpf.Mask = "999.999.999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(164, 32)
        Me.txt_cpf.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 28)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "CPF Do Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(508, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 28)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Contato do Cliente"
        '
        'txt_contato
        '
        Me.txt_contato.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contato.Location = New System.Drawing.Point(514, 100)
        Me.txt_contato.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_contato.Mask = "99 99999-9999"
        Me.txt_contato.Name = "txt_contato"
        Me.txt_contato.Size = New System.Drawing.Size(146, 32)
        Me.txt_contato.TabIndex = 72
        '
        'btn_sair
        '
        Me.btn_sair.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btn_sair.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_sair.FlatAppearance.BorderSize = 2
        Me.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sair.Font = New System.Drawing.Font("Bahnschrift SemiBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.Location = New System.Drawing.Point(945, 0)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(46, 35)
        Me.btn_sair.TabIndex = 50
        Me.btn_sair.Text = "X"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Salmon
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btn_sair)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(991, 35)
        Me.Panel1.TabIndex = 75
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(246, 34)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Realize seu cadastro!"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Salmon
        Me.Panel2.Location = New System.Drawing.Point(64, 118)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(157, 19)
        Me.Panel2.TabIndex = 76
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Salmon
        Me.Panel3.Location = New System.Drawing.Point(538, 118)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(129, 19)
        Me.Panel3.TabIndex = 77
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Salmon
        Me.Panel4.Location = New System.Drawing.Point(77, 210)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(837, 19)
        Me.Panel4.TabIndex = 78
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Salmon
        Me.Panel5.Location = New System.Drawing.Point(77, 301)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(374, 19)
        Me.Panel5.TabIndex = 79
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Salmon
        Me.Panel6.Location = New System.Drawing.Point(77, 396)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(374, 19)
        Me.Panel6.TabIndex = 80
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Salmon
        Me.Panel7.Location = New System.Drawing.Point(540, 301)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(374, 19)
        Me.Panel7.TabIndex = 80
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Salmon
        Me.Panel8.Location = New System.Drawing.Point(540, 396)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(374, 19)
        Me.Panel8.TabIndex = 80
        '
        'Cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(991, 526)
        Me.Controls.Add(Me.txt_confpass)
        Me.Controls.Add(Me.txt_confemail)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.txt_email2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.txt_contato)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_retornar)
        Me.Controls.Add(Me.ckb_versenhas)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Cadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO DE CLIENTES"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents ckb_versenhas As CheckBox
    Friend WithEvents txt_usuario As MaskedTextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txt_confpass As MaskedTextBox
    Friend WithEvents txt_confemail As MaskedTextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txt_pass As MaskedTextBox
    Friend WithEvents txt_email2 As MaskedTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_retornar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_contato As MaskedTextBox
    Friend WithEvents btn_sair As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label5 As Label
End Class
