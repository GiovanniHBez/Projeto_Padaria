<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DisplayClandario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DisplayClandario))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_beneficios = New System.Windows.Forms.Button()
        Me.lbl_meseano = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_hoje = New System.Windows.Forms.Button()
        Me.btn_prox = New System.Windows.Forms.Button()
        Me.btn_anterior = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fl_dias = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_encerrar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Salmon
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btn_sair)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1114, 35)
        Me.Panel1.TabIndex = 76
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(235, 34)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Realize sua reserva!"
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
        Me.btn_sair.Location = New System.Drawing.Point(1068, 0)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(46, 35)
        Me.btn_sair.TabIndex = 50
        Me.btn_sair.Text = "X"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.btn_beneficios)
        Me.Panel3.Controls.Add(Me.lbl_meseano)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 35)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1114, 73)
        Me.Panel3.TabIndex = 89
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Bahnschrift Light Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(686, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(123, 24)
        Me.Label15.TabIndex = 97
        Me.Label15.Text = "para reservantes"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(605, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 24)
        Me.Label14.TabIndex = 95
        Me.Label14.Text = "exclusivos"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Bahnschrift Light Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(541, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 24)
        Me.Label13.TabIndex = 96
        Me.Label13.Text = "Produtos"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Bahnschrift Light Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(539, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 24)
        Me.Label12.TabIndex = 95
        Me.Label12.Text = "Confira aqui!"
        '
        'btn_beneficios
        '
        Me.btn_beneficios.BackgroundImage = CType(resources.GetObject("btn_beneficios.BackgroundImage"), System.Drawing.Image)
        Me.btn_beneficios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_beneficios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_beneficios.FlatAppearance.BorderSize = 3
        Me.btn_beneficios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_beneficios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_beneficios.Location = New System.Drawing.Point(461, 7)
        Me.btn_beneficios.Name = "btn_beneficios"
        Me.btn_beneficios.Size = New System.Drawing.Size(72, 60)
        Me.btn_beneficios.TabIndex = 95
        Me.btn_beneficios.UseVisualStyleBackColor = True
        '
        'lbl_meseano
        '
        Me.lbl_meseano.AutoSize = True
        Me.lbl_meseano.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_meseano.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_meseano.Location = New System.Drawing.Point(3, 14)
        Me.lbl_meseano.Name = "lbl_meseano"
        Me.lbl_meseano.Size = New System.Drawing.Size(246, 52)
        Me.lbl_meseano.TabIndex = 91
        Me.lbl_meseano.Text = "Janeiro, 2023"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btn_hoje)
        Me.Panel4.Controls.Add(Me.btn_prox)
        Me.Panel4.Controls.Add(Me.btn_anterior)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(845, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(269, 73)
        Me.Panel4.TabIndex = 90
        '
        'btn_hoje
        '
        Me.btn_hoje.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btn_hoje.FlatAppearance.BorderSize = 0
        Me.btn_hoje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon
        Me.btn_hoje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_hoje.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hoje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_hoje.Location = New System.Drawing.Point(84, 8)
        Me.btn_hoje.Name = "btn_hoje"
        Me.btn_hoje.Size = New System.Drawing.Size(92, 62)
        Me.btn_hoje.TabIndex = 92
        Me.btn_hoje.Text = "Hoje"
        Me.btn_hoje.UseVisualStyleBackColor = False
        '
        'btn_prox
        '
        Me.btn_prox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btn_prox.FlatAppearance.BorderSize = 0
        Me.btn_prox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon
        Me.btn_prox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_prox.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_prox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_prox.Location = New System.Drawing.Point(182, 8)
        Me.btn_prox.Name = "btn_prox"
        Me.btn_prox.Size = New System.Drawing.Size(75, 62)
        Me.btn_prox.TabIndex = 91
        Me.btn_prox.Text = ">"
        Me.btn_prox.UseVisualStyleBackColor = False
        '
        'btn_anterior
        '
        Me.btn_anterior.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btn_anterior.FlatAppearance.BorderSize = 0
        Me.btn_anterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon
        Me.btn_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_anterior.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_anterior.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_anterior.Location = New System.Drawing.Point(3, 8)
        Me.btn_anterior.Name = "btn_anterior"
        Me.btn_anterior.Size = New System.Drawing.Size(75, 62)
        Me.btn_anterior.TabIndex = 90
        Me.btn_anterior.Text = "<"
        Me.btn_anterior.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift Light Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(829, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(273, 24)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "estão as mesas e horários indisponíveis"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(759, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 24)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "vermelho"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift Light Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(727, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 24)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "*Em"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 108)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1114, 47)
        Me.Panel5.TabIndex = 90
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Salmon
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(957, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 40)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "Sábado"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(798, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 40)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Sexta"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Salmon
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(639, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 40)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "Quinta"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(480, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 40)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Quarta"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Salmon
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(321, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 40)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Terça"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(162, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 40)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Segunda"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Salmon
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 40)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Domingo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fl_dias
        '
        Me.fl_dias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fl_dias.Location = New System.Drawing.Point(0, 155)
        Me.fl_dias.Name = "fl_dias"
        Me.fl_dias.Size = New System.Drawing.Size(1114, 612)
        Me.fl_dias.TabIndex = 91
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_encerrar)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 767)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1114, 45)
        Me.Panel2.TabIndex = 88
        '
        'btn_encerrar
        '
        Me.btn_encerrar.FlatAppearance.BorderSize = 0
        Me.btn_encerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_encerrar.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_encerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btn_encerrar.Image = CType(resources.GetObject("btn_encerrar.Image"), System.Drawing.Image)
        Me.btn_encerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_encerrar.Location = New System.Drawing.Point(0, 2)
        Me.btn_encerrar.Name = "btn_encerrar"
        Me.btn_encerrar.Size = New System.Drawing.Size(222, 40)
        Me.btn_encerrar.TabIndex = 92
        Me.btn_encerrar.Text = "Menu Principal"
        Me.btn_encerrar.UseVisualStyleBackColor = True
        '
        'DisplayClandario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1114, 812)
        Me.Controls.Add(Me.fl_dias)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DisplayClandario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DisplayClandario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_sair As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl_meseano As Label
    Friend WithEvents btn_anterior As Button
    Friend WithEvents btn_prox As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents fl_dias As FlowLayoutPanel
    Friend WithEvents btn_hoje As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_encerrar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_beneficios As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
End Class
