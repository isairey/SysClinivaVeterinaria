<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultarItem))
        Me.gpxPesquisa = New System.Windows.Forms.GroupBox()
        Me.MtxtFiltroData = New System.Windows.Forms.MaskedTextBox()
        Me.cmbFiltroTipoProduto = New System.Windows.Forms.ComboBox()
        Me.cmbFiltro = New System.Windows.Forms.ComboBox()
        Me.dgvProduto = New System.Windows.Forms.DataGridView()
        Me.txtBuscaProduto = New System.Windows.Forms.TextBox()
        Me.lbBuscarPor = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.pbxBanner = New System.Windows.Forms.PictureBox()
        Me.gpxProduto = New System.Windows.Forms.GroupBox()
        Me.txtQuantidadeMinima = New System.Windows.Forms.TextBox()
        Me.txtCaminhoImagem = New System.Windows.Forms.TextBox()
        Me.MtxtDataValidade = New System.Windows.Forms.MaskedTextBox()
        Me.txtDescricaoProduto = New System.Windows.Forms.RichTextBox()
        Me.txtPreco = New System.Windows.Forms.TextBox()
        Me.txtQuantidadeMaxima = New System.Windows.Forms.TextBox()
        Me.txtQuantidadeAtual = New System.Windows.Forms.TextBox()
        Me.txtMarcaProduto = New System.Windows.Forms.TextBox()
        Me.txtNomeProduto = New System.Windows.Forms.TextBox()
        Me.cmbTipoProduto = New System.Windows.Forms.ComboBox()
        Me.txtCodForne = New System.Windows.Forms.TextBox()
        Me.txtCodProduto = New System.Windows.Forms.TextBox()
        Me.lbDescricao = New System.Windows.Forms.Label()
        Me.lbMarca = New System.Windows.Forms.Label()
        Me.lbNome = New System.Windows.Forms.Label()
        Me.lbQuantidadeMaxima = New System.Windows.Forms.Label()
        Me.lbQuantidadeAtual = New System.Windows.Forms.Label()
        Me.lbDataValidade = New System.Windows.Forms.Label()
        Me.lbPreco = New System.Windows.Forms.Label()
        Me.lbTipo = New System.Windows.Forms.Label()
        Me.lbCodForne = New System.Windows.Forms.Label()
        Me.btnCarregarImagem = New System.Windows.Forms.Button()
        Me.pbxProduto = New System.Windows.Forms.PictureBox()
        Me.lbCod = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gpxPesquisa.SuspendLayout()
        CType(Me.dgvProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxProduto.SuspendLayout()
        CType(Me.pbxProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpxPesquisa
        '
        Me.gpxPesquisa.Controls.Add(Me.MtxtFiltroData)
        Me.gpxPesquisa.Controls.Add(Me.cmbFiltroTipoProduto)
        Me.gpxPesquisa.Controls.Add(Me.cmbFiltro)
        Me.gpxPesquisa.Controls.Add(Me.dgvProduto)
        Me.gpxPesquisa.Controls.Add(Me.txtBuscaProduto)
        Me.gpxPesquisa.Controls.Add(Me.lbBuscarPor)
        Me.gpxPesquisa.Controls.Add(Me.btnBuscar)
        Me.gpxPesquisa.Location = New System.Drawing.Point(12, 59)
        Me.gpxPesquisa.Name = "gpxPesquisa"
        Me.gpxPesquisa.Size = New System.Drawing.Size(752, 206)
        Me.gpxPesquisa.TabIndex = 0
        Me.gpxPesquisa.TabStop = False
        Me.gpxPesquisa.Text = "Dados da pesquisa"
        '
        'MtxtFiltroData
        '
        Me.MtxtFiltroData.Location = New System.Drawing.Point(223, 23)
        Me.MtxtFiltroData.Mask = "00/00/0000"
        Me.MtxtFiltroData.Name = "MtxtFiltroData"
        Me.MtxtFiltroData.Size = New System.Drawing.Size(77, 20)
        Me.MtxtFiltroData.TabIndex = 27
        Me.MtxtFiltroData.ValidatingType = GetType(Date)
        Me.MtxtFiltroData.Visible = False
        '
        'cmbFiltroTipoProduto
        '
        Me.cmbFiltroTipoProduto.FormattingEnabled = True
        Me.cmbFiltroTipoProduto.Location = New System.Drawing.Point(223, 23)
        Me.cmbFiltroTipoProduto.Name = "cmbFiltroTipoProduto"
        Me.cmbFiltroTipoProduto.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltroTipoProduto.TabIndex = 26
        Me.cmbFiltroTipoProduto.Visible = False
        '
        'cmbFiltro
        '
        Me.cmbFiltro.FormattingEnabled = True
        Me.cmbFiltro.Location = New System.Drawing.Point(85, 23)
        Me.cmbFiltro.Name = "cmbFiltro"
        Me.cmbFiltro.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltro.TabIndex = 25
        '
        'dgvProduto
        '
        Me.dgvProduto.AllowUserToAddRows = False
        Me.dgvProduto.AllowUserToDeleteRows = False
        Me.dgvProduto.AllowUserToResizeColumns = False
        Me.dgvProduto.AllowUserToResizeRows = False
        Me.dgvProduto.BackgroundColor = System.Drawing.Color.White
        Me.dgvProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduto.Location = New System.Drawing.Point(19, 53)
        Me.dgvProduto.MultiSelect = False
        Me.dgvProduto.Name = "dgvProduto"
        Me.dgvProduto.ReadOnly = True
        Me.dgvProduto.RowHeadersVisible = False
        Me.dgvProduto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduto.Size = New System.Drawing.Size(711, 140)
        Me.dgvProduto.TabIndex = 21
        '
        'txtBuscaProduto
        '
        Me.txtBuscaProduto.Location = New System.Drawing.Point(223, 23)
        Me.txtBuscaProduto.Name = "txtBuscaProduto"
        Me.txtBuscaProduto.Size = New System.Drawing.Size(188, 20)
        Me.txtBuscaProduto.TabIndex = 1
        Me.txtBuscaProduto.Visible = False
        '
        'lbBuscarPor
        '
        Me.lbBuscarPor.AutoSize = True
        Me.lbBuscarPor.Location = New System.Drawing.Point(18, 26)
        Me.lbBuscarPor.Name = "lbBuscarPor"
        Me.lbBuscarPor.Size = New System.Drawing.Size(61, 13)
        Me.lbBuscarPor.TabIndex = 20
        Me.lbBuscarPor.Text = "Buscar por:"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(417, 21)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 12
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        Me.btnBuscar.Visible = False
        '
        'pbxBanner
        '
        Me.pbxBanner.BackgroundImage = Global.sistechy.My.Resources.Resources.banner_consultar_item_fw
        Me.pbxBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxBanner.Location = New System.Drawing.Point(-5, -2)
        Me.pbxBanner.Name = "pbxBanner"
        Me.pbxBanner.Size = New System.Drawing.Size(792, 55)
        Me.pbxBanner.TabIndex = 70
        Me.pbxBanner.TabStop = False
        '
        'gpxProduto
        '
        Me.gpxProduto.Controls.Add(Me.txtQuantidadeMinima)
        Me.gpxProduto.Controls.Add(Me.txtCaminhoImagem)
        Me.gpxProduto.Controls.Add(Me.MtxtDataValidade)
        Me.gpxProduto.Controls.Add(Me.txtDescricaoProduto)
        Me.gpxProduto.Controls.Add(Me.txtPreco)
        Me.gpxProduto.Controls.Add(Me.txtQuantidadeMaxima)
        Me.gpxProduto.Controls.Add(Me.txtQuantidadeAtual)
        Me.gpxProduto.Controls.Add(Me.txtMarcaProduto)
        Me.gpxProduto.Controls.Add(Me.txtNomeProduto)
        Me.gpxProduto.Controls.Add(Me.cmbTipoProduto)
        Me.gpxProduto.Controls.Add(Me.txtCodForne)
        Me.gpxProduto.Controls.Add(Me.txtCodProduto)
        Me.gpxProduto.Controls.Add(Me.lbDescricao)
        Me.gpxProduto.Controls.Add(Me.lbMarca)
        Me.gpxProduto.Controls.Add(Me.lbNome)
        Me.gpxProduto.Controls.Add(Me.lbQuantidadeMaxima)
        Me.gpxProduto.Controls.Add(Me.lbQuantidadeAtual)
        Me.gpxProduto.Controls.Add(Me.lbDataValidade)
        Me.gpxProduto.Controls.Add(Me.lbPreco)
        Me.gpxProduto.Controls.Add(Me.lbTipo)
        Me.gpxProduto.Controls.Add(Me.lbCodForne)
        Me.gpxProduto.Controls.Add(Me.btnCarregarImagem)
        Me.gpxProduto.Controls.Add(Me.pbxProduto)
        Me.gpxProduto.Controls.Add(Me.lbCod)
        Me.gpxProduto.Location = New System.Drawing.Point(12, 280)
        Me.gpxProduto.Name = "gpxProduto"
        Me.gpxProduto.Size = New System.Drawing.Size(752, 279)
        Me.gpxProduto.TabIndex = 3
        Me.gpxProduto.TabStop = False
        Me.gpxProduto.Text = "Dados do produto"
        '
        'txtQuantidadeMinima
        '
        Me.txtQuantidadeMinima.Location = New System.Drawing.Point(582, 19)
        Me.txtQuantidadeMinima.Name = "txtQuantidadeMinima"
        Me.txtQuantidadeMinima.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidadeMinima.TabIndex = 47
        Me.txtQuantidadeMinima.Visible = False
        '
        'txtCaminhoImagem
        '
        Me.txtCaminhoImagem.Location = New System.Drawing.Point(582, 46)
        Me.txtCaminhoImagem.Name = "txtCaminhoImagem"
        Me.txtCaminhoImagem.Size = New System.Drawing.Size(100, 20)
        Me.txtCaminhoImagem.TabIndex = 46
        Me.txtCaminhoImagem.Visible = False
        '
        'MtxtDataValidade
        '
        Me.MtxtDataValidade.Enabled = False
        Me.MtxtDataValidade.Location = New System.Drawing.Point(444, 145)
        Me.MtxtDataValidade.Mask = "00/00/0000"
        Me.MtxtDataValidade.Name = "MtxtDataValidade"
        Me.MtxtDataValidade.Size = New System.Drawing.Size(81, 20)
        Me.MtxtDataValidade.TabIndex = 11
        Me.MtxtDataValidade.ValidatingType = GetType(Date)
        '
        'txtDescricaoProduto
        '
        Me.txtDescricaoProduto.Enabled = False
        Me.txtDescricaoProduto.Location = New System.Drawing.Point(190, 194)
        Me.txtDescricaoProduto.Name = "txtDescricaoProduto"
        Me.txtDescricaoProduto.Size = New System.Drawing.Size(541, 67)
        Me.txtDescricaoProduto.TabIndex = 13
        Me.txtDescricaoProduto.Text = ""
        '
        'txtPreco
        '
        Me.txtPreco.Enabled = False
        Me.txtPreco.Location = New System.Drawing.Point(564, 145)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Size = New System.Drawing.Size(93, 20)
        Me.txtPreco.TabIndex = 12
        '
        'txtQuantidadeMaxima
        '
        Me.txtQuantidadeMaxima.Enabled = False
        Me.txtQuantidadeMaxima.Location = New System.Drawing.Point(314, 145)
        Me.txtQuantidadeMaxima.Name = "txtQuantidadeMaxima"
        Me.txtQuantidadeMaxima.Size = New System.Drawing.Size(93, 20)
        Me.txtQuantidadeMaxima.TabIndex = 10
        '
        'txtQuantidadeAtual
        '
        Me.txtQuantidadeAtual.Enabled = False
        Me.txtQuantidadeAtual.Location = New System.Drawing.Point(190, 145)
        Me.txtQuantidadeAtual.Name = "txtQuantidadeAtual"
        Me.txtQuantidadeAtual.Size = New System.Drawing.Size(93, 20)
        Me.txtQuantidadeAtual.TabIndex = 9
        '
        'txtMarcaProduto
        '
        Me.txtMarcaProduto.Enabled = False
        Me.txtMarcaProduto.Location = New System.Drawing.Point(472, 96)
        Me.txtMarcaProduto.Name = "txtMarcaProduto"
        Me.txtMarcaProduto.Size = New System.Drawing.Size(243, 20)
        Me.txtMarcaProduto.TabIndex = 8
        '
        'txtNomeProduto
        '
        Me.txtNomeProduto.Enabled = False
        Me.txtNomeProduto.Location = New System.Drawing.Point(190, 96)
        Me.txtNomeProduto.Name = "txtNomeProduto"
        Me.txtNomeProduto.Size = New System.Drawing.Size(251, 20)
        Me.txtNomeProduto.TabIndex = 7
        '
        'cmbTipoProduto
        '
        Me.cmbTipoProduto.Enabled = False
        Me.cmbTipoProduto.FormattingEnabled = True
        Me.cmbTipoProduto.Location = New System.Drawing.Point(434, 46)
        Me.cmbTipoProduto.Name = "cmbTipoProduto"
        Me.cmbTipoProduto.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoProduto.TabIndex = 6
        '
        'txtCodForne
        '
        Me.txtCodForne.Enabled = False
        Me.txtCodForne.Location = New System.Drawing.Point(314, 46)
        Me.txtCodForne.Name = "txtCodForne"
        Me.txtCodForne.Size = New System.Drawing.Size(93, 20)
        Me.txtCodForne.TabIndex = 5
        '
        'txtCodProduto
        '
        Me.txtCodProduto.Enabled = False
        Me.txtCodProduto.Location = New System.Drawing.Point(190, 46)
        Me.txtCodProduto.Name = "txtCodProduto"
        Me.txtCodProduto.Size = New System.Drawing.Size(93, 20)
        Me.txtCodProduto.TabIndex = 4
        '
        'lbDescricao
        '
        Me.lbDescricao.AutoSize = True
        Me.lbDescricao.Location = New System.Drawing.Point(187, 178)
        Me.lbDescricao.Name = "lbDescricao"
        Me.lbDescricao.Size = New System.Drawing.Size(55, 13)
        Me.lbDescricao.TabIndex = 34
        Me.lbDescricao.Text = "Descrição"
        '
        'lbMarca
        '
        Me.lbMarca.AutoSize = True
        Me.lbMarca.Location = New System.Drawing.Point(469, 80)
        Me.lbMarca.Name = "lbMarca"
        Me.lbMarca.Size = New System.Drawing.Size(37, 13)
        Me.lbMarca.TabIndex = 33
        Me.lbMarca.Text = "Marca"
        '
        'lbNome
        '
        Me.lbNome.AutoSize = True
        Me.lbNome.Location = New System.Drawing.Point(187, 80)
        Me.lbNome.Name = "lbNome"
        Me.lbNome.Size = New System.Drawing.Size(35, 13)
        Me.lbNome.TabIndex = 32
        Me.lbNome.Text = "Nome"
        '
        'lbQuantidadeMaxima
        '
        Me.lbQuantidadeMaxima.AutoSize = True
        Me.lbQuantidadeMaxima.Location = New System.Drawing.Point(311, 129)
        Me.lbQuantidadeMaxima.Name = "lbQuantidadeMaxima"
        Me.lbQuantidadeMaxima.Size = New System.Drawing.Size(100, 13)
        Me.lbQuantidadeMaxima.TabIndex = 31
        Me.lbQuantidadeMaxima.Text = "Quantidade máxima"
        '
        'lbQuantidadeAtual
        '
        Me.lbQuantidadeAtual.AutoSize = True
        Me.lbQuantidadeAtual.Location = New System.Drawing.Point(187, 129)
        Me.lbQuantidadeAtual.Name = "lbQuantidadeAtual"
        Me.lbQuantidadeAtual.Size = New System.Drawing.Size(88, 13)
        Me.lbQuantidadeAtual.TabIndex = 30
        Me.lbQuantidadeAtual.Text = "Quantidade atual"
        '
        'lbDataValidade
        '
        Me.lbDataValidade.AutoSize = True
        Me.lbDataValidade.Location = New System.Drawing.Point(441, 129)
        Me.lbDataValidade.Name = "lbDataValidade"
        Me.lbDataValidade.Size = New System.Drawing.Size(73, 13)
        Me.lbDataValidade.TabIndex = 29
        Me.lbDataValidade.Text = "Data validade"
        '
        'lbPreco
        '
        Me.lbPreco.AutoSize = True
        Me.lbPreco.Location = New System.Drawing.Point(561, 129)
        Me.lbPreco.Name = "lbPreco"
        Me.lbPreco.Size = New System.Drawing.Size(35, 13)
        Me.lbPreco.TabIndex = 28
        Me.lbPreco.Text = "Preço"
        '
        'lbTipo
        '
        Me.lbTipo.AutoSize = True
        Me.lbTipo.Location = New System.Drawing.Point(431, 30)
        Me.lbTipo.Name = "lbTipo"
        Me.lbTipo.Size = New System.Drawing.Size(28, 13)
        Me.lbTipo.TabIndex = 27
        Me.lbTipo.Text = "Tipo"
        '
        'lbCodForne
        '
        Me.lbCodForne.AutoSize = True
        Me.lbCodForne.Location = New System.Drawing.Point(311, 30)
        Me.lbCodForne.Name = "lbCodForne"
        Me.lbCodForne.Size = New System.Drawing.Size(94, 13)
        Me.lbCodForne.TabIndex = 26
        Me.lbCodForne.Text = "Cógido fornecedor"
        '
        'btnCarregarImagem
        '
        Me.btnCarregarImagem.BackColor = System.Drawing.Color.White
        Me.btnCarregarImagem.Enabled = False
        Me.btnCarregarImagem.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCarregarImagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnCarregarImagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCarregarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCarregarImagem.Location = New System.Drawing.Point(21, 221)
        Me.btnCarregarImagem.Name = "btnCarregarImagem"
        Me.btnCarregarImagem.Size = New System.Drawing.Size(149, 23)
        Me.btnCarregarImagem.TabIndex = 14
        Me.btnCarregarImagem.Text = "Carregar imagem"
        Me.btnCarregarImagem.UseVisualStyleBackColor = False
        '
        'pbxProduto
        '
        Me.pbxProduto.BackColor = System.Drawing.Color.White
        Me.pbxProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxProduto.Location = New System.Drawing.Point(21, 30)
        Me.pbxProduto.Name = "pbxProduto"
        Me.pbxProduto.Size = New System.Drawing.Size(149, 185)
        Me.pbxProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxProduto.TabIndex = 24
        Me.pbxProduto.TabStop = False
        '
        'lbCod
        '
        Me.lbCod.AutoSize = True
        Me.lbCod.Location = New System.Drawing.Point(187, 30)
        Me.lbCod.Name = "lbCod"
        Me.lbCod.Size = New System.Drawing.Size(40, 13)
        Me.lbCod.TabIndex = 0
        Me.lbCod.Text = "Código"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.White
        Me.btnConfirmar.BackgroundImage = Global.sistechy.My.Resources.Resources.salva_alteracoes_fw
        Me.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConfirmar.Enabled = False
        Me.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Location = New System.Drawing.Point(571, 569)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(170, 50)
        Me.btnConfirmar.TabIndex = 18
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'btnAtualizar
        '
        Me.btnAtualizar.BackColor = System.Drawing.Color.White
        Me.btnAtualizar.BackgroundImage = Global.sistechy.My.Resources.Resources.atualizar_dados_fw
        Me.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtualizar.Location = New System.Drawing.Point(395, 569)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(170, 50)
        Me.btnAtualizar.TabIndex = 17
        Me.btnAtualizar.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.White
        Me.btnExcluir.BackgroundImage = Global.sistechy.My.Resources.Resources.excluir_dados_fw
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExcluir.Enabled = False
        Me.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Location = New System.Drawing.Point(219, 569)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(170, 50)
        Me.btnExcluir.TabIndex = 16
        Me.btnExcluir.UseVisualStyleBackColor = False
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
        Me.btnCancelar.Location = New System.Drawing.Point(43, 569)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(170, 50)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'frmConsultarItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(776, 631)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.gpxProduto)
        Me.Controls.Add(Me.pbxBanner)
        Me.Controls.Add(Me.gpxPesquisa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsultarItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar item"
        Me.gpxPesquisa.ResumeLayout(False)
        Me.gpxPesquisa.PerformLayout()
        CType(Me.dgvProduto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxProduto.ResumeLayout(False)
        Me.gpxProduto.PerformLayout()
        CType(Me.pbxProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpxPesquisa As System.Windows.Forms.GroupBox
    Friend WithEvents pbxBanner As System.Windows.Forms.PictureBox
    Friend WithEvents dgvProduto As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscaProduto As System.Windows.Forms.TextBox
    Friend WithEvents lbBuscarPor As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents gpxProduto As System.Windows.Forms.GroupBox
    Friend WithEvents lbCod As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoProduto As System.Windows.Forms.RichTextBox
    Friend WithEvents txtPreco As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantidadeMaxima As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantidadeAtual As System.Windows.Forms.TextBox
    Friend WithEvents txtMarcaProduto As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeProduto As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipoProduto As System.Windows.Forms.ComboBox
    Friend WithEvents txtCodForne As System.Windows.Forms.TextBox
    Friend WithEvents txtCodProduto As System.Windows.Forms.TextBox
    Friend WithEvents lbDescricao As System.Windows.Forms.Label
    Friend WithEvents lbMarca As System.Windows.Forms.Label
    Friend WithEvents lbNome As System.Windows.Forms.Label
    Friend WithEvents lbQuantidadeMaxima As System.Windows.Forms.Label
    Friend WithEvents lbQuantidadeAtual As System.Windows.Forms.Label
    Friend WithEvents lbDataValidade As System.Windows.Forms.Label
    Friend WithEvents lbPreco As System.Windows.Forms.Label
    Friend WithEvents lbTipo As System.Windows.Forms.Label
    Friend WithEvents lbCodForne As System.Windows.Forms.Label
    Friend WithEvents btnCarregarImagem As System.Windows.Forms.Button
    Friend WithEvents pbxProduto As System.Windows.Forms.PictureBox
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents MtxtDataValidade As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCaminhoImagem As System.Windows.Forms.TextBox
    Friend WithEvents cmbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFiltroTipoProduto As System.Windows.Forms.ComboBox
    Friend WithEvents MtxtFiltroData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtQuantidadeMinima As System.Windows.Forms.TextBox
End Class
