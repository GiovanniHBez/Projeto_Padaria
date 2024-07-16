<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Principal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_adm = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_encerrar = New System.Windows.Forms.Button()
        Me.btn_reservas = New System.Windows.Forms.Button()
        Me.btn_produtos = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Salmon
        Me.Panel1.Controls.Add(Me.btn_adm)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.btn_reservas)
        Me.Panel1.Controls.Add(Me.btn_produtos)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(296, 544)
        Me.Panel1.TabIndex = 0
        '
        'btn_adm
        '
        Me.btn_adm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btn_adm.FlatAppearance.BorderSize = 2
        Me.btn_adm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_adm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_adm.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_adm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btn_adm.Image = CType(resources.GetObject("btn_adm.Image"), System.Drawing.Image)
        Me.btn_adm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_adm.Location = New System.Drawing.Point(27, 392)
        Me.btn_adm.Name = "btn_adm"
        Me.btn_adm.Size = New System.Drawing.Size(250, 56)
        Me.btn_adm.TabIndex = 80
        Me.btn_adm.Text = "Admin"
        Me.btn_adm.UseVisualStyleBackColor = True
        Me.btn_adm.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(13, 61)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(100, 5)
        Me.Panel3.TabIndex = 77
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btn_encerrar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 485)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(296, 59)
        Me.Panel4.TabIndex = 77
        '
        'btn_encerrar
        '
        Me.btn_encerrar.FlatAppearance.BorderSize = 0
        Me.btn_encerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_encerrar.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_encerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btn_encerrar.Image = CType(resources.GetObject("btn_encerrar.Image"), System.Drawing.Image)
        Me.btn_encerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_encerrar.Location = New System.Drawing.Point(27, 0)
        Me.btn_encerrar.Name = "btn_encerrar"
        Me.btn_encerrar.Size = New System.Drawing.Size(240, 56)
        Me.btn_encerrar.TabIndex = 80
        Me.btn_encerrar.Text = "Encerrar Sessão"
        Me.btn_encerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_encerrar.UseVisualStyleBackColor = True
        '
        'btn_reservas
        '
        Me.btn_reservas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btn_reservas.FlatAppearance.BorderSize = 2
        Me.btn_reservas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_reservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reservas.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reservas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btn_reservas.Image = CType(resources.GetObject("btn_reservas.Image"), System.Drawing.Image)
        Me.btn_reservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reservas.Location = New System.Drawing.Point(27, 330)
        Me.btn_reservas.Name = "btn_reservas"
        Me.btn_reservas.Size = New System.Drawing.Size(250, 56)
        Me.btn_reservas.TabIndex = 79
        Me.btn_reservas.Text = "Reservas"
        Me.btn_reservas.UseVisualStyleBackColor = True
        '
        'btn_produtos
        '
        Me.btn_produtos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btn_produtos.FlatAppearance.BorderSize = 2
        Me.btn_produtos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_produtos.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_produtos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btn_produtos.Image = CType(resources.GetObject("btn_produtos.Image"), System.Drawing.Image)
        Me.btn_produtos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_produtos.Location = New System.Drawing.Point(27, 268)
        Me.btn_produtos.Name = "btn_produtos"
        Me.btn_produtos.Size = New System.Drawing.Size(250, 56)
        Me.btn_produtos.TabIndex = 77
        Me.btn_produtos.Text = "Nossos Produtos"
        Me.btn_produtos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_produtos.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(108, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 52)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Principal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 52)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Menu"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(27, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 205)
        Me.PictureBox1.TabIndex = 77
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Salmon
        Me.Panel2.Controls.Add(Me.btn_sair)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(296, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(791, 35)
        Me.Panel2.TabIndex = 76
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
        Me.btn_sair.Location = New System.Drawing.Point(745, 0)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(46, 35)
        Me.btn_sair.TabIndex = 50
        Me.btn_sair.Text = "X"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(296, 35)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(791, 509)
        Me.Panel5.TabIndex = 77
        '
        'Menu_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1087, 544)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Menu_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btn_encerrar As Button
    Friend WithEvents btn_reservas As Button
    Friend WithEvents btn_produtos As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_sair As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_adm As Button
End Class
