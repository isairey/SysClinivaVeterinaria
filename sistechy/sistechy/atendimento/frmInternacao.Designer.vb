<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInternacao
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInternacao))
        Me.lbCodInternacao = New System.Windows.Forms.Label()
        Me.lbCodAnimal = New System.Windows.Forms.Label()
        Me.lbNumeroLeito = New System.Windows.Forms.Label()
        Me.lbDataInternacao = New System.Windows.Forms.Label()
        Me.lbDetalhes = New System.Windows.Forms.Label()
        Me.dgvAnimal = New System.Windows.Forms.DataGridView()
        Me.txtConsultaAnimal = New System.Windows.Forms.TextBox()
        Me.btnBuscaAnimal = New System.Windows.Forms.Button()
        Me.txtCodInternacao = New System.Windows.Forms.TextBox()
        Me.txtNomeAnimal = New System.Windows.Forms.TextBox()
        Me.txtCodAnimal = New System.Windows.Forms.TextBox()
        Me.lbNomeAnimal = New System.Windows.Forms.Label()
        Me.lbCodigoAnimal = New System.Windows.Forms.Label()
        Me.gpxAnimal = New System.Windows.Forms.GroupBox()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.MtxtFiltroDataAnimal = New System.Windows.Forms.MaskedTextBox()
        Me.txtPorteAnimal = New System.Windows.Forms.TextBox()
        Me.cmbFiltroAnimal = New System.Windows.Forms.ComboBox()
        Me.lbPorteAnimal = New System.Windows.Forms.Label()
        Me.gpxInternacao = New System.Windows.Forms.GroupBox()
        Me.txtStatusLeito = New System.Windows.Forms.TextBox()
        Me.lbEmUso = New System.Windows.Forms.Label()
        Me.txtDetalhesInternacao = New System.Windows.Forms.RichTextBox()
        Me.MtxtDataInternacao = New System.Windows.Forms.MaskedTextBox()
        Me.txtNumLeito = New System.Windows.Forms.TextBox()
        Me.txtPorteLeito = New System.Windows.Forms.TextBox()
        Me.lbPorteLeito = New System.Windows.Forms.Label()
        Me.dgvLeito = New System.Windows.Forms.DataGridView()
        Me.btnBuscaLeito = New System.Windows.Forms.Button()
        Me.txtBuscaLeito = New System.Windows.Forms.TextBox()
        Me.lbCodLeito = New System.Windows.Forms.Label()
        Me.pbxBanner = New System.Windows.Forms.PictureBox()
        Me.BtnSalvarInternacao = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.dgvAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxAnimal.SuspendLayout()
        Me.gpxInternacao.SuspendLayout()
        CType(Me.dgvLeito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbCodInternacao
        '
        Me.lbCodInternacao.AutoSize = True
        Me.lbCodInternacao.Location = New System.Drawing.Point(17, 29)
        Me.lbCodInternacao.Name = "lbCodInternacao"
        Me.lbCodInternacao.Size = New System.Drawing.Size(93, 13)
        Me.lbCodInternacao.TabIndex = 0
        Me.lbCodInternacao.Text = "Código internação"
        '
        'lbCodAnimal
        '
        Me.lbCodAnimal.AutoSize = True
        Me.lbCodAnimal.Location = New System.Drawing.Point(16, 34)
        Me.lbCodAnimal.Name = "lbCodAnimal"
        Me.lbCodAnimal.Size = New System.Drawing.Size(94, 13)
        Me.lbCodAnimal.TabIndex = 1
        Me.lbCodAnimal.Text = "Buscar animal por:"
        '
        'lbNumeroLeito
        '
        Me.lbNumeroLeito.AutoSize = True
        Me.lbNumeroLeito.Location = New System.Drawing.Point(17, 257)
        Me.lbNumeroLeito.Name = "lbNumeroLeito"
        Me.lbNumeroLeito.Size = New System.Drawing.Size(81, 13)
        Me.lbNumeroLeito.TabIndex = 2
        Me.lbNumeroLeito.Text = "Número do leito"
        '
        'lbDataInternacao
        '
        Me.lbDataInternacao.AutoSize = True
        Me.lbDataInternacao.Location = New System.Drawing.Point(410, 29)
        Me.lbDataInternacao.Name = "lbDataInternacao"
        Me.lbDataInternacao.Size = New System.Drawing.Size(98, 13)
        Me.lbDataInternacao.TabIndex = 3
        Me.lbDataInternacao.Text = "Data da internação"
        '
        'lbDetalhes
        '
        Me.lbDetalhes.AutoSize = True
        Me.lbDetalhes.Location = New System.Drawing.Point(410, 86)
        Me.lbDetalhes.Name = "lbDetalhes"
        Me.lbDetalhes.Size = New System.Drawing.Size(49, 13)
        Me.lbDetalhes.TabIndex = 4
        Me.lbDetalhes.Text = "Detalhes"
        '
        'dgvAnimal
        '
        Me.dgvAnimal.AllowUserToAddRows = False
        Me.dgvAnimal.AllowUserToDeleteRows = False
        Me.dgvAnimal.AllowUserToResizeColumns = False
        Me.dgvAnimal.AllowUserToResizeRows = False
        Me.dgvAnimal.BackgroundColor = System.Drawing.Color.White
        Me.dgvAnimal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAnimal.Location = New System.Drawing.Point(19, 62)
        Me.dgvAnimal.MultiSelect = False
        Me.dgvAnimal.Name = "dgvAnimal"
        Me.dgvAnimal.ReadOnly = True
        Me.dgvAnimal.RowHeadersVisible = False
        Me.dgvAnimal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvAnimal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAnimal.Size = New System.Drawing.Size(738, 140)
        Me.dgvAnimal.TabIndex = 66
        '
        'txtConsultaAnimal
        '
        Me.txtConsultaAnimal.Location = New System.Drawing.Point(253, 31)
        Me.txtConsultaAnimal.Name = "txtConsultaAnimal"
        Me.txtConsultaAnimal.Size = New System.Drawing.Size(188, 20)
        Me.txtConsultaAnimal.TabIndex = 1
        Me.txtConsultaAnimal.Visible = False
        '
        'btnBuscaAnimal
        '
        Me.btnBuscaAnimal.BackColor = System.Drawing.Color.White
        Me.btnBuscaAnimal.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBuscaAnimal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaAnimal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscaAnimal.Location = New System.Drawing.Point(459, 30)
        Me.btnBuscaAnimal.Name = "btnBuscaAnimal"
        Me.btnBuscaAnimal.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscaAnimal.TabIndex = 2
        Me.btnBuscaAnimal.Text = "Buscar"
        Me.btnBuscaAnimal.UseVisualStyleBackColor = False
        Me.btnBuscaAnimal.Visible = False
        '
        'txtCodInternacao
        '
        Me.txtCodInternacao.Enabled = False
        Me.txtCodInternacao.Location = New System.Drawing.Point(20, 45)
        Me.txtCodInternacao.Name = "txtCodInternacao"
        Me.txtCodInternacao.Size = New System.Drawing.Size(100, 20)
        Me.txtCodInternacao.TabIndex = 69
        '
        'txtNomeAnimal
        '
        Me.txtNomeAnimal.Enabled = False
        Me.txtNomeAnimal.Location = New System.Drawing.Point(151, 227)
        Me.txtNomeAnimal.Name = "txtNomeAnimal"
        Me.txtNomeAnimal.Size = New System.Drawing.Size(256, 20)
        Me.txtNomeAnimal.TabIndex = 75
        '
        'txtCodAnimal
        '
        Me.txtCodAnimal.Enabled = False
        Me.txtCodAnimal.Location = New System.Drawing.Point(19, 227)
        Me.txtCodAnimal.Name = "txtCodAnimal"
        Me.txtCodAnimal.Size = New System.Drawing.Size(100, 20)
        Me.txtCodAnimal.TabIndex = 74
        '
        'lbNomeAnimal
        '
        Me.lbNomeAnimal.AutoSize = True
        Me.lbNomeAnimal.Location = New System.Drawing.Point(148, 211)
        Me.lbNomeAnimal.Name = "lbNomeAnimal"
        Me.lbNomeAnimal.Size = New System.Drawing.Size(35, 13)
        Me.lbNomeAnimal.TabIndex = 73
        Me.lbNomeAnimal.Text = "Nome"
        '
        'lbCodigoAnimal
        '
        Me.lbCodigoAnimal.AutoSize = True
        Me.lbCodigoAnimal.Location = New System.Drawing.Point(17, 211)
        Me.lbCodigoAnimal.Name = "lbCodigoAnimal"
        Me.lbCodigoAnimal.Size = New System.Drawing.Size(40, 13)
        Me.lbCodigoAnimal.TabIndex = 72
        Me.lbCodigoAnimal.Text = "Código"
        '
        'gpxAnimal
        '
        Me.gpxAnimal.Controls.Add(Me.txtAno)
        Me.gpxAnimal.Controls.Add(Me.txtMes)
        Me.gpxAnimal.Controls.Add(Me.MtxtFiltroDataAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtPorteAnimal)
        Me.gpxAnimal.Controls.Add(Me.cmbFiltroAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbPorteAnimal)
        Me.gpxAnimal.Controls.Add(Me.dgvAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtNomeAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbCodAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtCodAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtConsultaAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbNomeAnimal)
        Me.gpxAnimal.Controls.Add(Me.btnBuscaAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbCodigoAnimal)
        Me.gpxAnimal.Location = New System.Drawing.Point(15, 70)
        Me.gpxAnimal.Name = "gpxAnimal"
        Me.gpxAnimal.Size = New System.Drawing.Size(774, 261)
        Me.gpxAnimal.TabIndex = 76
        Me.gpxAnimal.TabStop = False
        Me.gpxAnimal.Text = "Dados do animal"
        '
        'txtAno
        '
        Me.txtAno.Location = New System.Drawing.Point(657, 22)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(100, 20)
        Me.txtAno.TabIndex = 83
        Me.txtAno.Visible = False
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(551, 22)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(100, 20)
        Me.txtMes.TabIndex = 82
        Me.txtMes.Visible = False
        '
        'MtxtFiltroDataAnimal
        '
        Me.MtxtFiltroDataAnimal.Location = New System.Drawing.Point(253, 31)
        Me.MtxtFiltroDataAnimal.Mask = "00/00/0000"
        Me.MtxtFiltroDataAnimal.Name = "MtxtFiltroDataAnimal"
        Me.MtxtFiltroDataAnimal.Size = New System.Drawing.Size(72, 20)
        Me.MtxtFiltroDataAnimal.TabIndex = 85
        Me.MtxtFiltroDataAnimal.ValidatingType = GetType(Date)
        Me.MtxtFiltroDataAnimal.Visible = False
        '
        'txtPorteAnimal
        '
        Me.txtPorteAnimal.Enabled = False
        Me.txtPorteAnimal.Location = New System.Drawing.Point(437, 227)
        Me.txtPorteAnimal.Name = "txtPorteAnimal"
        Me.txtPorteAnimal.Size = New System.Drawing.Size(101, 20)
        Me.txtPorteAnimal.TabIndex = 77
        '
        'cmbFiltroAnimal
        '
        Me.cmbFiltroAnimal.FormattingEnabled = True
        Me.cmbFiltroAnimal.Location = New System.Drawing.Point(116, 31)
        Me.cmbFiltroAnimal.Name = "cmbFiltroAnimal"
        Me.cmbFiltroAnimal.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltroAnimal.TabIndex = 84
        '
        'lbPorteAnimal
        '
        Me.lbPorteAnimal.AutoSize = True
        Me.lbPorteAnimal.Location = New System.Drawing.Point(434, 211)
        Me.lbPorteAnimal.Name = "lbPorteAnimal"
        Me.lbPorteAnimal.Size = New System.Drawing.Size(32, 13)
        Me.lbPorteAnimal.TabIndex = 76
        Me.lbPorteAnimal.Text = "Porte"
        '
        'gpxInternacao
        '
        Me.gpxInternacao.Controls.Add(Me.txtStatusLeito)
        Me.gpxInternacao.Controls.Add(Me.lbEmUso)
        Me.gpxInternacao.Controls.Add(Me.txtDetalhesInternacao)
        Me.gpxInternacao.Controls.Add(Me.MtxtDataInternacao)
        Me.gpxInternacao.Controls.Add(Me.txtNumLeito)
        Me.gpxInternacao.Controls.Add(Me.txtPorteLeito)
        Me.gpxInternacao.Controls.Add(Me.lbPorteLeito)
        Me.gpxInternacao.Controls.Add(Me.dgvLeito)
        Me.gpxInternacao.Controls.Add(Me.btnBuscaLeito)
        Me.gpxInternacao.Controls.Add(Me.txtBuscaLeito)
        Me.gpxInternacao.Controls.Add(Me.lbCodLeito)
        Me.gpxInternacao.Controls.Add(Me.txtCodInternacao)
        Me.gpxInternacao.Controls.Add(Me.lbCodInternacao)
        Me.gpxInternacao.Controls.Add(Me.lbNumeroLeito)
        Me.gpxInternacao.Controls.Add(Me.lbDataInternacao)
        Me.gpxInternacao.Controls.Add(Me.lbDetalhes)
        Me.gpxInternacao.Location = New System.Drawing.Point(15, 343)
        Me.gpxInternacao.Name = "gpxInternacao"
        Me.gpxInternacao.Size = New System.Drawing.Size(774, 305)
        Me.gpxInternacao.TabIndex = 77
        Me.gpxInternacao.TabStop = False
        Me.gpxInternacao.Text = "Dados da internação"
        '
        'txtStatusLeito
        '
        Me.txtStatusLeito.Enabled = False
        Me.txtStatusLeito.Location = New System.Drawing.Point(290, 272)
        Me.txtStatusLeito.Name = "txtStatusLeito"
        Me.txtStatusLeito.Size = New System.Drawing.Size(100, 20)
        Me.txtStatusLeito.TabIndex = 80
        '
        'lbEmUso
        '
        Me.lbEmUso.AutoSize = True
        Me.lbEmUso.Location = New System.Drawing.Point(287, 256)
        Me.lbEmUso.Name = "lbEmUso"
        Me.lbEmUso.Size = New System.Drawing.Size(42, 13)
        Me.lbEmUso.TabIndex = 79
        Me.lbEmUso.Text = "Em uso"
        '
        'txtDetalhesInternacao
        '
        Me.txtDetalhesInternacao.Location = New System.Drawing.Point(413, 106)
        Me.txtDetalhesInternacao.Name = "txtDetalhesInternacao"
        Me.txtDetalhesInternacao.Size = New System.Drawing.Size(334, 140)
        Me.txtDetalhesInternacao.TabIndex = 6
        Me.txtDetalhesInternacao.Text = ""
        '
        'MtxtDataInternacao
        '
        Me.MtxtDataInternacao.Location = New System.Drawing.Point(413, 45)
        Me.MtxtDataInternacao.Mask = "00/00/0000"
        Me.MtxtDataInternacao.Name = "MtxtDataInternacao"
        Me.MtxtDataInternacao.Size = New System.Drawing.Size(85, 20)
        Me.MtxtDataInternacao.TabIndex = 3
        Me.MtxtDataInternacao.ValidatingType = GetType(Date)
        '
        'txtNumLeito
        '
        Me.txtNumLeito.Enabled = False
        Me.txtNumLeito.Location = New System.Drawing.Point(20, 273)
        Me.txtNumLeito.Name = "txtNumLeito"
        Me.txtNumLeito.Size = New System.Drawing.Size(100, 20)
        Me.txtNumLeito.TabIndex = 76
        '
        'txtPorteLeito
        '
        Me.txtPorteLeito.Enabled = False
        Me.txtPorteLeito.Location = New System.Drawing.Point(146, 273)
        Me.txtPorteLeito.Name = "txtPorteLeito"
        Me.txtPorteLeito.Size = New System.Drawing.Size(117, 20)
        Me.txtPorteLeito.TabIndex = 75
        '
        'lbPorteLeito
        '
        Me.lbPorteLeito.AutoSize = True
        Me.lbPorteLeito.Location = New System.Drawing.Point(143, 257)
        Me.lbPorteLeito.Name = "lbPorteLeito"
        Me.lbPorteLeito.Size = New System.Drawing.Size(32, 13)
        Me.lbPorteLeito.TabIndex = 74
        Me.lbPorteLeito.Text = "Porte"
        '
        'dgvLeito
        '
        Me.dgvLeito.AllowUserToAddRows = False
        Me.dgvLeito.AllowUserToDeleteRows = False
        Me.dgvLeito.AllowUserToResizeColumns = False
        Me.dgvLeito.AllowUserToResizeRows = False
        Me.dgvLeito.BackgroundColor = System.Drawing.Color.White
        Me.dgvLeito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvLeito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLeito.Location = New System.Drawing.Point(20, 106)
        Me.dgvLeito.MultiSelect = False
        Me.dgvLeito.Name = "dgvLeito"
        Me.dgvLeito.ReadOnly = True
        Me.dgvLeito.RowHeadersVisible = False
        Me.dgvLeito.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvLeito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLeito.Size = New System.Drawing.Size(343, 140)
        Me.dgvLeito.TabIndex = 73
        '
        'btnBuscaLeito
        '
        Me.btnBuscaLeito.BackColor = System.Drawing.Color.White
        Me.btnBuscaLeito.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBuscaLeito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaLeito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaLeito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscaLeito.Location = New System.Drawing.Point(288, 77)
        Me.btnBuscaLeito.Name = "btnBuscaLeito"
        Me.btnBuscaLeito.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscaLeito.TabIndex = 5
        Me.btnBuscaLeito.Text = "Buscar"
        Me.btnBuscaLeito.UseVisualStyleBackColor = False
        '
        'txtBuscaLeito
        '
        Me.txtBuscaLeito.Location = New System.Drawing.Point(141, 79)
        Me.txtBuscaLeito.Name = "txtBuscaLeito"
        Me.txtBuscaLeito.Size = New System.Drawing.Size(132, 20)
        Me.txtBuscaLeito.TabIndex = 4
        '
        'lbCodLeito
        '
        Me.lbCodLeito.AutoSize = True
        Me.lbCodLeito.Location = New System.Drawing.Point(17, 82)
        Me.lbCodLeito.Name = "lbCodLeito"
        Me.lbCodLeito.Size = New System.Drawing.Size(118, 13)
        Me.lbCodLeito.TabIndex = 70
        Me.lbCodLeito.Text = "Digite o código do leito:"
        '
        'pbxBanner
        '
        Me.pbxBanner.BackgroundImage = Global.sistechy.My.Resources.Resources.banner_internacao_fw
        Me.pbxBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxBanner.Location = New System.Drawing.Point(-5, -1)
        Me.pbxBanner.Name = "pbxBanner"
        Me.pbxBanner.Size = New System.Drawing.Size(821, 55)
        Me.pbxBanner.TabIndex = 80
        Me.pbxBanner.TabStop = False
        '
        'BtnSalvarInternacao
        '
        Me.BtnSalvarInternacao.BackColor = System.Drawing.Color.White
        Me.BtnSalvarInternacao.BackgroundImage = Global.sistechy.My.Resources.Resources.salva_vacinacao_fw
        Me.BtnSalvarInternacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalvarInternacao.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnSalvarInternacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.BtnSalvarInternacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.BtnSalvarInternacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvarInternacao.Location = New System.Drawing.Point(619, 659)
        Me.BtnSalvarInternacao.Name = "BtnSalvarInternacao"
        Me.BtnSalvarInternacao.Size = New System.Drawing.Size(170, 50)
        Me.BtnSalvarInternacao.TabIndex = 7
        Me.BtnSalvarInternacao.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.BackgroundImage = Global.sistechy.My.Resources.Resources.cancelar_fw
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(443, 659)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(170, 50)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'frmInternacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(802, 721)
        Me.Controls.Add(Me.pbxBanner)
        Me.Controls.Add(Me.BtnSalvarInternacao)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.gpxInternacao)
        Me.Controls.Add(Me.gpxAnimal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmInternacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Internação"
        CType(Me.dgvAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxAnimal.ResumeLayout(False)
        Me.gpxAnimal.PerformLayout()
        Me.gpxInternacao.ResumeLayout(False)
        Me.gpxInternacao.PerformLayout()
        CType(Me.dgvLeito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbCodInternacao As System.Windows.Forms.Label
    Friend WithEvents lbCodAnimal As System.Windows.Forms.Label
    Friend WithEvents lbNumeroLeito As System.Windows.Forms.Label
    Friend WithEvents lbDataInternacao As System.Windows.Forms.Label
    Friend WithEvents lbDetalhes As System.Windows.Forms.Label
    Friend WithEvents dgvAnimal As System.Windows.Forms.DataGridView
    Friend WithEvents txtConsultaAnimal As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscaAnimal As System.Windows.Forms.Button
    Friend WithEvents txtCodInternacao As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeAnimal As System.Windows.Forms.TextBox
    Friend WithEvents txtCodAnimal As System.Windows.Forms.TextBox
    Friend WithEvents lbNomeAnimal As System.Windows.Forms.Label
    Friend WithEvents lbCodigoAnimal As System.Windows.Forms.Label
    Friend WithEvents gpxAnimal As System.Windows.Forms.GroupBox
    Friend WithEvents gpxInternacao As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumLeito As System.Windows.Forms.TextBox
    Friend WithEvents txtPorteLeito As System.Windows.Forms.TextBox
    Friend WithEvents lbPorteLeito As System.Windows.Forms.Label
    Friend WithEvents dgvLeito As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscaLeito As System.Windows.Forms.Button
    Friend WithEvents txtBuscaLeito As System.Windows.Forms.TextBox
    Friend WithEvents lbCodLeito As System.Windows.Forms.Label
    Friend WithEvents txtDetalhesInternacao As System.Windows.Forms.RichTextBox
    Friend WithEvents MtxtDataInternacao As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnSalvarInternacao As System.Windows.Forms.Button
    Friend WithEvents txtPorteAnimal As System.Windows.Forms.TextBox
    Friend WithEvents lbPorteAnimal As System.Windows.Forms.Label
    Friend WithEvents txtStatusLeito As System.Windows.Forms.TextBox
    Friend WithEvents lbEmUso As System.Windows.Forms.Label
    Friend WithEvents pbxBanner As System.Windows.Forms.PictureBox
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents txtAno As System.Windows.Forms.TextBox
    Friend WithEvents MtxtFiltroDataAnimal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbFiltroAnimal As System.Windows.Forms.ComboBox
End Class
