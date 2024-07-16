<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calendario
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp_data = New System.Windows.Forms.DateTimePicker()
        Me.txt_nome = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_area = New System.Windows.Forms.ComboBox()
        Me.cmb_mesa = New System.Windows.Forms.ComboBox()
        Me.btn_reservar = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.cmb_hora = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lkl_vermesas = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Salmon
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(641, 35)
        Me.Panel1.TabIndex = 76
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(214, 34)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Realize a Reserva!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(45, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 28)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Data Desejada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(45, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 28)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(45, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 28)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Área da Padaria"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(45, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 28)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Mesa Desejada"
        '
        'dtp_data
        '
        Me.dtp_data.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_data.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_data.Location = New System.Drawing.Point(217, 63)
        Me.dtp_data.Name = "dtp_data"
        Me.dtp_data.Size = New System.Drawing.Size(187, 32)
        Me.dtp_data.TabIndex = 81
        Me.dtp_data.Value = New Date(2023, 6, 13, 0, 0, 0, 0)
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_nome.Location = New System.Drawing.Point(217, 184)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(187, 32)
        Me.txt_nome.TabIndex = 82
        '
        'cmb_area
        '
        Me.cmb_area.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmb_area.FormattingEnabled = True
        Me.cmb_area.Location = New System.Drawing.Point(217, 247)
        Me.cmb_area.Name = "cmb_area"
        Me.cmb_area.Size = New System.Drawing.Size(187, 32)
        Me.cmb_area.TabIndex = 83
        '
        'cmb_mesa
        '
        Me.cmb_mesa.DropDownHeight = 80
        Me.cmb_mesa.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmb_mesa.FormattingEnabled = True
        Me.cmb_mesa.IntegralHeight = False
        Me.cmb_mesa.Location = New System.Drawing.Point(217, 308)
        Me.cmb_mesa.Name = "cmb_mesa"
        Me.cmb_mesa.Size = New System.Drawing.Size(187, 32)
        Me.cmb_mesa.TabIndex = 84
        '
        'btn_reservar
        '
        Me.btn_reservar.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btn_reservar.FlatAppearance.BorderSize = 3
        Me.btn_reservar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btn_reservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reservar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reservar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_reservar.Location = New System.Drawing.Point(458, 63)
        Me.btn_reservar.Name = "btn_reservar"
        Me.btn_reservar.Size = New System.Drawing.Size(136, 54)
        Me.btn_reservar.TabIndex = 85
        Me.btn_reservar.Text = "Reservar"
        Me.btn_reservar.UseVisualStyleBackColor = True
        '
        'btn_limpar
        '
        Me.btn_limpar.FlatAppearance.BorderColor = System.Drawing.Color.Cyan
        Me.btn_limpar.FlatAppearance.BorderSize = 3
        Me.btn_limpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_limpar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_limpar.Location = New System.Drawing.Point(458, 143)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(136, 54)
        Me.btn_limpar.TabIndex = 86
        Me.btn_limpar.Text = "Limpar"
        Me.btn_limpar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 404)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(641, 45)
        Me.Panel2.TabIndex = 87
        '
        'btn_fechar
        '
        Me.btn_fechar.BackColor = System.Drawing.Color.Salmon
        Me.btn_fechar.FlatAppearance.BorderSize = 0
        Me.btn_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fechar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fechar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btn_fechar.Location = New System.Drawing.Point(458, 221)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(136, 54)
        Me.btn_fechar.TabIndex = 88
        Me.btn_fechar.Text = "Fechar"
        Me.btn_fechar.UseVisualStyleBackColor = False
        '
        'cmb_hora
        '
        Me.cmb_hora.DropDownHeight = 80
        Me.cmb_hora.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmb_hora.FormattingEnabled = True
        Me.cmb_hora.IntegralHeight = False
        Me.cmb_hora.Location = New System.Drawing.Point(217, 124)
        Me.cmb_hora.Name = "cmb_hora"
        Me.cmb_hora.Size = New System.Drawing.Size(187, 32)
        Me.cmb_hora.TabIndex = 90
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(45, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 28)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Horário"
        '
        'lkl_vermesas
        '
        Me.lkl_vermesas.AutoSize = True
        Me.lkl_vermesas.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.lkl_vermesas.Location = New System.Drawing.Point(45, 364)
        Me.lkl_vermesas.Name = "lkl_vermesas"
        Me.lkl_vermesas.Size = New System.Drawing.Size(284, 28)
        Me.lkl_vermesas.TabIndex = 91
        Me.lkl_vermesas.TabStop = True
        Me.lkl_vermesas.Text = "Visualizar Posições das Mesas"
        '
        'Calendario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(641, 449)
        Me.Controls.Add(Me.lkl_vermesas)
        Me.Controls.Add(Me.cmb_hora)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.btn_reservar)
        Me.Controls.Add(Me.cmb_mesa)
        Me.Controls.Add(Me.cmb_area)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.dtp_data)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Calendario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calendario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtp_data As DateTimePicker
    Friend WithEvents txt_nome As MaskedTextBox
    Friend WithEvents cmb_area As ComboBox
    Friend WithEvents cmb_mesa As ComboBox
    Friend WithEvents btn_reservar As Button
    Friend WithEvents btn_limpar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_fechar As Button
    Friend WithEvents cmb_hora As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lkl_vermesas As LinkLabel
End Class
