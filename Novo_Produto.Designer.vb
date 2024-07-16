<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Novo_Produto
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Novo_Produto))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_produto = New System.Windows.Forms.TextBox()
        Me.txt_preco = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.img_prod = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_adicionar = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.btn_retornar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.img_prod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Salmon
        Me.Panel1.Controls.Add(Me.Label129)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(822, 35)
        Me.Panel1.TabIndex = 77
        '
        'Label129
        '
        Me.Label129.AutoSize = True
        Me.Label129.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label129.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label129.Location = New System.Drawing.Point(3, 0)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(224, 36)
        Me.Label129.TabIndex = 84
        Me.Label129.Text = "Adicionar Produto"
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Bahnschrift", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(32, 109)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(108, 35)
        Me.txt_id.TabIndex = 78
        '
        'txt_produto
        '
        Me.txt_produto.Font = New System.Drawing.Font("Bahnschrift", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_produto.Location = New System.Drawing.Point(32, 203)
        Me.txt_produto.Name = "txt_produto"
        Me.txt_produto.Size = New System.Drawing.Size(281, 35)
        Me.txt_produto.TabIndex = 79
        '
        'txt_preco
        '
        Me.txt_preco.Font = New System.Drawing.Font("Bahnschrift", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_preco.Location = New System.Drawing.Point(381, 203)
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.Size = New System.Drawing.Size(146, 35)
        Me.txt_preco.TabIndex = 80
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(29, 76)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(36, 34)
        Me.label1.TabIndex = 81
        Me.label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(29, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 34)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Produto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(375, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 34)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Preço"
        '
        'img_prod
        '
        Me.img_prod.BackgroundImage = CType(resources.GetObject("img_prod.BackgroundImage"), System.Drawing.Image)
        Me.img_prod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.img_prod.Location = New System.Drawing.Point(578, 112)
        Me.img_prod.Name = "img_prod"
        Me.img_prod.Size = New System.Drawing.Size(209, 193)
        Me.img_prod.TabIndex = 84
        Me.img_prod.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(572, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(226, 34)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Imagem do Produto"
        '
        'cmb_categoria
        '
        Me.cmb_categoria.Font = New System.Drawing.Font("Bahnschrift", 13.8!)
        Me.cmb_categoria.FormattingEnabled = True
        Me.cmb_categoria.Items.AddRange(New Object() {"Salgados", "Doces"})
        Me.cmb_categoria.Location = New System.Drawing.Point(171, 108)
        Me.cmb_categoria.Name = "cmb_categoria"
        Me.cmb_categoria.Size = New System.Drawing.Size(356, 36)
        Me.cmb_categoria.TabIndex = 86
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(165, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 34)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Onde Adicionar"
        '
        'btn_adicionar
        '
        Me.btn_adicionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_adicionar.FlatAppearance.BorderSize = 3
        Me.btn_adicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_adicionar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_adicionar.Location = New System.Drawing.Point(393, 280)
        Me.btn_adicionar.Name = "btn_adicionar"
        Me.btn_adicionar.Size = New System.Drawing.Size(134, 53)
        Me.btn_adicionar.TabIndex = 88
        Me.btn_adicionar.Text = "Adicionar"
        Me.btn_adicionar.UseVisualStyleBackColor = True
        '
        'btn_limpar
        '
        Me.btn_limpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_limpar.FlatAppearance.BorderSize = 3
        Me.btn_limpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_limpar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpar.Location = New System.Drawing.Point(213, 280)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(134, 53)
        Me.btn_limpar.TabIndex = 89
        Me.btn_limpar.Text = "Limpar"
        Me.btn_limpar.UseVisualStyleBackColor = True
        '
        'btn_retornar
        '
        Me.btn_retornar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_retornar.FlatAppearance.BorderSize = 3
        Me.btn_retornar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_retornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_retornar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_retornar.Location = New System.Drawing.Point(32, 280)
        Me.btn_retornar.Name = "btn_retornar"
        Me.btn_retornar.Size = New System.Drawing.Size(134, 53)
        Me.btn_retornar.TabIndex = 90
        Me.btn_retornar.Text = "Retornar"
        Me.btn_retornar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Salmon
        Me.Panel2.Location = New System.Drawing.Point(67, 120)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(81, 32)
        Me.Panel2.TabIndex = 91
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Salmon
        Me.Panel3.Location = New System.Drawing.Point(213, 120)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(322, 32)
        Me.Panel3.TabIndex = 92
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Salmon
        Me.Panel4.Location = New System.Drawing.Point(67, 214)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(254, 32)
        Me.Panel4.TabIndex = 93
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Salmon
        Me.Panel5.Location = New System.Drawing.Point(414, 214)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(121, 32)
        Me.Panel5.TabIndex = 94
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Salmon
        Me.Panel6.Location = New System.Drawing.Point(597, 133)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(198, 180)
        Me.Panel6.TabIndex = 95
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 360)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(822, 34)
        Me.Panel7.TabIndex = 96
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(332, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 34)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "R$"
        '
        'Novo_Produto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(822, 394)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.img_prod)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.txt_preco)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.txt_produto)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.cmb_categoria)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_retornar)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.btn_adicionar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Novo_Produto"
        Me.Text = "Novo_Produto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.img_prod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label129 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_produto As TextBox
    Friend WithEvents txt_preco As TextBox
    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents img_prod As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_categoria As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_adicionar As Button
    Friend WithEvents btn_limpar As Button
    Friend WithEvents btn_retornar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label6 As Label
End Class
