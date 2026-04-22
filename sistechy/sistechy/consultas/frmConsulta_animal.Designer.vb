<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsulta_animal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsulta_animal))
        Me.dgvAnimal = New System.Windows.Forms.DataGridView()
        Me.lbBuscarPor = New System.Windows.Forms.Label()
        Me.txtConsultaAnimal = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lbPeso = New System.Windows.Forms.Label()
        Me.lbCod = New System.Windows.Forms.Label()
        Me.lbRaca = New System.Windows.Forms.Label()
        Me.lbSexo = New System.Windows.Forms.Label()
        Me.lbNome = New System.Windows.Forms.Label()
        Me.lbPorte = New System.Windows.Forms.Label()
        Me.lbIdade = New System.Windows.Forms.Label()
        Me.lbEspecie = New System.Windows.Forms.Label()
        Me.lbDataCad = New System.Windows.Forms.Label()
        Me.lbCor = New System.Windows.Forms.Label()
        Me.lbCastracao = New System.Windows.Forms.Label()
        Me.txtCodAnimal = New System.Windows.Forms.TextBox()
        Me.txtNomeAnimal = New System.Windows.Forms.TextBox()
        Me.txtEspecieAnimal = New System.Windows.Forms.TextBox()
        Me.txtRacaAnimal = New System.Windows.Forms.TextBox()
        Me.txtPesoAnimal = New System.Windows.Forms.TextBox()
        Me.txtIdadeAnimal = New System.Windows.Forms.TextBox()
        Me.txtCorAnimal = New System.Windows.Forms.TextBox()
        Me.lbCaminhoImagem = New System.Windows.Forms.Label()
        Me.txtCaminhoImagem = New System.Windows.Forms.TextBox()
        Me.cmbSexoAnimal = New System.Windows.Forms.ComboBox()
        Me.cmbPorteAnimal = New System.Windows.Forms.ComboBox()
        Me.cmbCastracaoAnimal = New System.Windows.Forms.ComboBox()
        Me.btnLoadImage = New System.Windows.Forms.Button()
        Me.MtxtDataCadAnimal = New System.Windows.Forms.MaskedTextBox()
        Me.gpxPesquisa = New System.Windows.Forms.GroupBox()
        Me.MtxtFiltroData = New System.Windows.Forms.MaskedTextBox()
        Me.cmbFiltro = New System.Windows.Forms.ComboBox()
        Me.txtNivelAcesso = New System.Windows.Forms.TextBox()
        Me.gpxAnimal = New System.Windows.Forms.GroupBox()
        Me.pbxAnimal = New System.Windows.Forms.PictureBox()
        Me.pbxBanner = New System.Windows.Forms.PictureBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.dgvAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxPesquisa.SuspendLayout()
        Me.gpxAnimal.SuspendLayout()
        CType(Me.pbxAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.dgvAnimal.Location = New System.Drawing.Point(15, 56)
        Me.dgvAnimal.MultiSelect = False
        Me.dgvAnimal.Name = "dgvAnimal"
        Me.dgvAnimal.ReadOnly = True
        Me.dgvAnimal.RowHeadersVisible = False
        Me.dgvAnimal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvAnimal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAnimal.Size = New System.Drawing.Size(695, 140)
        Me.dgvAnimal.TabIndex = 17
        '
        'lbBuscarPor
        '
        Me.lbBuscarPor.AutoSize = True
        Me.lbBuscarPor.Location = New System.Drawing.Point(15, 25)
        Me.lbBuscarPor.Name = "lbBuscarPor"
        Me.lbBuscarPor.Size = New System.Drawing.Size(61, 13)
        Me.lbBuscarPor.TabIndex = 13
        Me.lbBuscarPor.Text = "Buscar por:"
        '
        'txtConsultaAnimal
        '
        Me.txtConsultaAnimal.Location = New System.Drawing.Point(218, 23)
        Me.txtConsultaAnimal.Name = "txtConsultaAnimal"
        Me.txtConsultaAnimal.Size = New System.Drawing.Size(152, 20)
        Me.txtConsultaAnimal.TabIndex = 1
        Me.txtConsultaAnimal.Visible = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(386, 21)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        Me.btnBuscar.Visible = False
        '
        'lbPeso
        '
        Me.lbPeso.AutoSize = True
        Me.lbPeso.Location = New System.Drawing.Point(178, 121)
        Me.lbPeso.Name = "lbPeso"
        Me.lbPeso.Size = New System.Drawing.Size(31, 13)
        Me.lbPeso.TabIndex = 21
        Me.lbPeso.Text = "Peso"
        '
        'lbCod
        '
        Me.lbCod.AutoSize = True
        Me.lbCod.Location = New System.Drawing.Point(176, 19)
        Me.lbCod.Name = "lbCod"
        Me.lbCod.Size = New System.Drawing.Size(40, 13)
        Me.lbCod.TabIndex = 22
        Me.lbCod.Text = "Código"
        '
        'lbRaca
        '
        Me.lbRaca.AutoSize = True
        Me.lbRaca.Location = New System.Drawing.Point(176, 69)
        Me.lbRaca.Name = "lbRaca"
        Me.lbRaca.Size = New System.Drawing.Size(33, 13)
        Me.lbRaca.TabIndex = 23
        Me.lbRaca.Text = "Raça"
        '
        'lbSexo
        '
        Me.lbSexo.AutoSize = True
        Me.lbSexo.Location = New System.Drawing.Point(373, 69)
        Me.lbSexo.Name = "lbSexo"
        Me.lbSexo.Size = New System.Drawing.Size(31, 13)
        Me.lbSexo.TabIndex = 24
        Me.lbSexo.Text = "Sexo"
        '
        'lbNome
        '
        Me.lbNome.AutoSize = True
        Me.lbNome.Location = New System.Drawing.Point(282, 19)
        Me.lbNome.Name = "lbNome"
        Me.lbNome.Size = New System.Drawing.Size(35, 13)
        Me.lbNome.TabIndex = 25
        Me.lbNome.Text = "Nome"
        '
        'lbPorte
        '
        Me.lbPorte.AutoSize = True
        Me.lbPorte.Location = New System.Drawing.Point(497, 68)
        Me.lbPorte.Name = "lbPorte"
        Me.lbPorte.Size = New System.Drawing.Size(32, 13)
        Me.lbPorte.TabIndex = 26
        Me.lbPorte.Text = "Porte"
        '
        'lbIdade
        '
        Me.lbIdade.AutoSize = True
        Me.lbIdade.Location = New System.Drawing.Point(283, 121)
        Me.lbIdade.Name = "lbIdade"
        Me.lbIdade.Size = New System.Drawing.Size(34, 13)
        Me.lbIdade.TabIndex = 27
        Me.lbIdade.Text = "Idade"
        '
        'lbEspecie
        '
        Me.lbEspecie.AutoSize = True
        Me.lbEspecie.Location = New System.Drawing.Point(529, 19)
        Me.lbEspecie.Name = "lbEspecie"
        Me.lbEspecie.Size = New System.Drawing.Size(45, 13)
        Me.lbEspecie.TabIndex = 28
        Me.lbEspecie.Text = "Espécie"
        '
        'lbDataCad
        '
        Me.lbDataCad.AutoSize = True
        Me.lbDataCad.Location = New System.Drawing.Point(178, 174)
        Me.lbDataCad.Name = "lbDataCad"
        Me.lbDataCad.Size = New System.Drawing.Size(75, 13)
        Me.lbDataCad.TabIndex = 29
        Me.lbDataCad.Text = "Data Cadastro"
        '
        'lbCor
        '
        Me.lbCor.AutoSize = True
        Me.lbCor.Location = New System.Drawing.Point(398, 121)
        Me.lbCor.Name = "lbCor"
        Me.lbCor.Size = New System.Drawing.Size(23, 13)
        Me.lbCor.TabIndex = 30
        Me.lbCor.Text = "Cor"
        '
        'lbCastracao
        '
        Me.lbCastracao.AutoSize = True
        Me.lbCastracao.Location = New System.Drawing.Point(556, 121)
        Me.lbCastracao.Name = "lbCastracao"
        Me.lbCastracao.Size = New System.Drawing.Size(55, 13)
        Me.lbCastracao.TabIndex = 33
        Me.lbCastracao.Text = "Castração"
        '
        'txtCodAnimal
        '
        Me.txtCodAnimal.Enabled = False
        Me.txtCodAnimal.Location = New System.Drawing.Point(179, 35)
        Me.txtCodAnimal.Name = "txtCodAnimal"
        Me.txtCodAnimal.Size = New System.Drawing.Size(84, 20)
        Me.txtCodAnimal.TabIndex = 4
        '
        'txtNomeAnimal
        '
        Me.txtNomeAnimal.Enabled = False
        Me.txtNomeAnimal.Location = New System.Drawing.Point(285, 35)
        Me.txtNomeAnimal.Name = "txtNomeAnimal"
        Me.txtNomeAnimal.Size = New System.Drawing.Size(221, 20)
        Me.txtNomeAnimal.TabIndex = 5
        '
        'txtEspecieAnimal
        '
        Me.txtEspecieAnimal.Enabled = False
        Me.txtEspecieAnimal.Location = New System.Drawing.Point(532, 35)
        Me.txtEspecieAnimal.Name = "txtEspecieAnimal"
        Me.txtEspecieAnimal.Size = New System.Drawing.Size(166, 20)
        Me.txtEspecieAnimal.TabIndex = 6
        '
        'txtRacaAnimal
        '
        Me.txtRacaAnimal.Enabled = False
        Me.txtRacaAnimal.Location = New System.Drawing.Point(179, 85)
        Me.txtRacaAnimal.Name = "txtRacaAnimal"
        Me.txtRacaAnimal.Size = New System.Drawing.Size(167, 20)
        Me.txtRacaAnimal.TabIndex = 7
        '
        'txtPesoAnimal
        '
        Me.txtPesoAnimal.Enabled = False
        Me.txtPesoAnimal.Location = New System.Drawing.Point(179, 137)
        Me.txtPesoAnimal.Name = "txtPesoAnimal"
        Me.txtPesoAnimal.Size = New System.Drawing.Size(84, 20)
        Me.txtPesoAnimal.TabIndex = 10
        '
        'txtIdadeAnimal
        '
        Me.txtIdadeAnimal.Enabled = False
        Me.txtIdadeAnimal.Location = New System.Drawing.Point(286, 137)
        Me.txtIdadeAnimal.Name = "txtIdadeAnimal"
        Me.txtIdadeAnimal.Size = New System.Drawing.Size(84, 20)
        Me.txtIdadeAnimal.TabIndex = 11
        '
        'txtCorAnimal
        '
        Me.txtCorAnimal.Enabled = False
        Me.txtCorAnimal.Location = New System.Drawing.Point(401, 137)
        Me.txtCorAnimal.Name = "txtCorAnimal"
        Me.txtCorAnimal.Size = New System.Drawing.Size(133, 20)
        Me.txtCorAnimal.TabIndex = 12
        '
        'lbCaminhoImagem
        '
        Me.lbCaminhoImagem.AutoSize = True
        Me.lbCaminhoImagem.Location = New System.Drawing.Point(301, 174)
        Me.lbCaminhoImagem.Name = "lbCaminhoImagem"
        Me.lbCaminhoImagem.Size = New System.Drawing.Size(102, 13)
        Me.lbCaminhoImagem.TabIndex = 62
        Me.lbCaminhoImagem.Text = "Caminho da imagem"
        Me.lbCaminhoImagem.Visible = False
        '
        'txtCaminhoImagem
        '
        Me.txtCaminhoImagem.Enabled = False
        Me.txtCaminhoImagem.Location = New System.Drawing.Point(304, 190)
        Me.txtCaminhoImagem.Name = "txtCaminhoImagem"
        Me.txtCaminhoImagem.Size = New System.Drawing.Size(355, 20)
        Me.txtCaminhoImagem.TabIndex = 15
        Me.txtCaminhoImagem.Visible = False
        '
        'cmbSexoAnimal
        '
        Me.cmbSexoAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexoAnimal.Enabled = False
        Me.cmbSexoAnimal.FormattingEnabled = True
        Me.cmbSexoAnimal.Location = New System.Drawing.Point(376, 84)
        Me.cmbSexoAnimal.Name = "cmbSexoAnimal"
        Me.cmbSexoAnimal.Size = New System.Drawing.Size(99, 21)
        Me.cmbSexoAnimal.TabIndex = 8
        '
        'cmbPorteAnimal
        '
        Me.cmbPorteAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPorteAnimal.Enabled = False
        Me.cmbPorteAnimal.FormattingEnabled = True
        Me.cmbPorteAnimal.Location = New System.Drawing.Point(500, 84)
        Me.cmbPorteAnimal.Name = "cmbPorteAnimal"
        Me.cmbPorteAnimal.Size = New System.Drawing.Size(98, 21)
        Me.cmbPorteAnimal.TabIndex = 9
        '
        'cmbCastracaoAnimal
        '
        Me.cmbCastracaoAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCastracaoAnimal.Enabled = False
        Me.cmbCastracaoAnimal.FormattingEnabled = True
        Me.cmbCastracaoAnimal.Location = New System.Drawing.Point(559, 137)
        Me.cmbCastracaoAnimal.Name = "cmbCastracaoAnimal"
        Me.cmbCastracaoAnimal.Size = New System.Drawing.Size(63, 21)
        Me.cmbCastracaoAnimal.TabIndex = 13
        '
        'btnLoadImage
        '
        Me.btnLoadImage.BackColor = System.Drawing.Color.White
        Me.btnLoadImage.Enabled = False
        Me.btnLoadImage.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLoadImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnLoadImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnLoadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadImage.Location = New System.Drawing.Point(15, 216)
        Me.btnLoadImage.Name = "btnLoadImage"
        Me.btnLoadImage.Size = New System.Drawing.Size(147, 23)
        Me.btnLoadImage.TabIndex = 16
        Me.btnLoadImage.Text = "Carregar imagem"
        Me.btnLoadImage.UseVisualStyleBackColor = False
        '
        'MtxtDataCadAnimal
        '
        Me.MtxtDataCadAnimal.Enabled = False
        Me.MtxtDataCadAnimal.Location = New System.Drawing.Point(179, 190)
        Me.MtxtDataCadAnimal.Mask = "00/00/0000"
        Me.MtxtDataCadAnimal.Name = "MtxtDataCadAnimal"
        Me.MtxtDataCadAnimal.Size = New System.Drawing.Size(73, 20)
        Me.MtxtDataCadAnimal.TabIndex = 14
        Me.MtxtDataCadAnimal.ValidatingType = GetType(Date)
        '
        'gpxPesquisa
        '
        Me.gpxPesquisa.Controls.Add(Me.MtxtFiltroData)
        Me.gpxPesquisa.Controls.Add(Me.cmbFiltro)
        Me.gpxPesquisa.Controls.Add(Me.txtNivelAcesso)
        Me.gpxPesquisa.Controls.Add(Me.lbBuscarPor)
        Me.gpxPesquisa.Controls.Add(Me.txtConsultaAnimal)
        Me.gpxPesquisa.Controls.Add(Me.dgvAnimal)
        Me.gpxPesquisa.Controls.Add(Me.btnBuscar)
        Me.gpxPesquisa.Location = New System.Drawing.Point(12, 63)
        Me.gpxPesquisa.Name = "gpxPesquisa"
        Me.gpxPesquisa.Size = New System.Drawing.Size(732, 206)
        Me.gpxPesquisa.TabIndex = 85
        Me.gpxPesquisa.TabStop = False
        Me.gpxPesquisa.Text = "Dados da pesquisa"
        '
        'MtxtFiltroData
        '
        Me.MtxtFiltroData.Location = New System.Drawing.Point(218, 23)
        Me.MtxtFiltroData.Mask = "00/00/0000"
        Me.MtxtFiltroData.Name = "MtxtFiltroData"
        Me.MtxtFiltroData.Size = New System.Drawing.Size(72, 20)
        Me.MtxtFiltroData.TabIndex = 20
        Me.MtxtFiltroData.ValidatingType = GetType(Date)
        Me.MtxtFiltroData.Visible = False
        '
        'cmbFiltro
        '
        Me.cmbFiltro.FormattingEnabled = True
        Me.cmbFiltro.Location = New System.Drawing.Point(82, 22)
        Me.cmbFiltro.Name = "cmbFiltro"
        Me.cmbFiltro.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltro.TabIndex = 19
        '
        'txtNivelAcesso
        '
        Me.txtNivelAcesso.Location = New System.Drawing.Point(610, 30)
        Me.txtNivelAcesso.Name = "txtNivelAcesso"
        Me.txtNivelAcesso.Size = New System.Drawing.Size(100, 20)
        Me.txtNivelAcesso.TabIndex = 18
        Me.txtNivelAcesso.Visible = False
        '
        'gpxAnimal
        '
        Me.gpxAnimal.Controls.Add(Me.pbxAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbPeso)
        Me.gpxAnimal.Controls.Add(Me.MtxtDataCadAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbCod)
        Me.gpxAnimal.Controls.Add(Me.btnLoadImage)
        Me.gpxAnimal.Controls.Add(Me.lbRaca)
        Me.gpxAnimal.Controls.Add(Me.cmbCastracaoAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbSexo)
        Me.gpxAnimal.Controls.Add(Me.cmbPorteAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbNome)
        Me.gpxAnimal.Controls.Add(Me.cmbSexoAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbPorte)
        Me.gpxAnimal.Controls.Add(Me.lbIdade)
        Me.gpxAnimal.Controls.Add(Me.lbEspecie)
        Me.gpxAnimal.Controls.Add(Me.lbDataCad)
        Me.gpxAnimal.Controls.Add(Me.txtCaminhoImagem)
        Me.gpxAnimal.Controls.Add(Me.lbCor)
        Me.gpxAnimal.Controls.Add(Me.lbCaminhoImagem)
        Me.gpxAnimal.Controls.Add(Me.lbCastracao)
        Me.gpxAnimal.Controls.Add(Me.txtCodAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtCorAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtNomeAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtIdadeAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtEspecieAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtPesoAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtRacaAnimal)
        Me.gpxAnimal.Location = New System.Drawing.Point(12, 284)
        Me.gpxAnimal.Name = "gpxAnimal"
        Me.gpxAnimal.Size = New System.Drawing.Size(732, 249)
        Me.gpxAnimal.TabIndex = 3
        Me.gpxAnimal.TabStop = False
        Me.gpxAnimal.Text = "Dados do animal"
        '
        'pbxAnimal
        '
        Me.pbxAnimal.BackColor = System.Drawing.Color.White
        Me.pbxAnimal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxAnimal.Location = New System.Drawing.Point(15, 19)
        Me.pbxAnimal.Name = "pbxAnimal"
        Me.pbxAnimal.Size = New System.Drawing.Size(147, 191)
        Me.pbxAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxAnimal.TabIndex = 34
        Me.pbxAnimal.TabStop = False
        '
        'pbxBanner
        '
        Me.pbxBanner.BackgroundImage = Global.sistechy.My.Resources.Resources.banner_consulta_animal_fw
        Me.pbxBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxBanner.Location = New System.Drawing.Point(-5, -2)
        Me.pbxBanner.Name = "pbxBanner"
        Me.pbxBanner.Size = New System.Drawing.Size(771, 55)
        Me.pbxBanner.TabIndex = 86
        Me.pbxBanner.TabStop = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.White
        Me.btnConfirmar.BackgroundImage = Global.sistechy.My.Resources.Resources.salva_alteracoes_fw
        Me.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Location = New System.Drawing.Point(558, 550)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(170, 50)
        Me.btnConfirmar.TabIndex = 17
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
        Me.btnAtualizar.Location = New System.Drawing.Point(382, 550)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(170, 50)
        Me.btnAtualizar.TabIndex = 18
        Me.btnAtualizar.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.White
        Me.btnExcluir.BackgroundImage = Global.sistechy.My.Resources.Resources.excluir_dados_fw
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Location = New System.Drawing.Point(206, 550)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(170, 50)
        Me.btnExcluir.TabIndex = 19
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
        Me.btnCancelar.Location = New System.Drawing.Point(30, 550)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(170, 50)
        Me.btnCancelar.TabIndex = 20
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'frmConsulta_animal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(762, 629)
        Me.Controls.Add(Me.pbxBanner)
        Me.Controls.Add(Me.gpxAnimal)
        Me.Controls.Add(Me.gpxPesquisa)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmConsulta_animal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxPesquisa.ResumeLayout(False)
        Me.gpxPesquisa.PerformLayout()
        Me.gpxAnimal.ResumeLayout(False)
        Me.gpxAnimal.PerformLayout()
        CType(Me.pbxAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvAnimal As System.Windows.Forms.DataGridView
    Friend WithEvents lbBuscarPor As System.Windows.Forms.Label
    Friend WithEvents txtConsultaAnimal As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lbPeso As System.Windows.Forms.Label
    Friend WithEvents lbCod As System.Windows.Forms.Label
    Friend WithEvents lbRaca As System.Windows.Forms.Label
    Friend WithEvents lbSexo As System.Windows.Forms.Label
    Friend WithEvents lbNome As System.Windows.Forms.Label
    Friend WithEvents lbPorte As System.Windows.Forms.Label
    Friend WithEvents lbIdade As System.Windows.Forms.Label
    Friend WithEvents lbEspecie As System.Windows.Forms.Label
    Friend WithEvents lbDataCad As System.Windows.Forms.Label
    Friend WithEvents lbCor As System.Windows.Forms.Label
    Friend WithEvents lbCastracao As System.Windows.Forms.Label
    Friend WithEvents pbxAnimal As System.Windows.Forms.PictureBox
    Friend WithEvents txtCodAnimal As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeAnimal As System.Windows.Forms.TextBox
    Friend WithEvents txtEspecieAnimal As System.Windows.Forms.TextBox
    Friend WithEvents txtRacaAnimal As System.Windows.Forms.TextBox
    Friend WithEvents txtPesoAnimal As System.Windows.Forms.TextBox
    Friend WithEvents txtIdadeAnimal As System.Windows.Forms.TextBox
    Friend WithEvents txtCorAnimal As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lbCaminhoImagem As System.Windows.Forms.Label
    Friend WithEvents txtCaminhoImagem As System.Windows.Forms.TextBox
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents cmbSexoAnimal As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPorteAnimal As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCastracaoAnimal As System.Windows.Forms.ComboBox
    Friend WithEvents btnLoadImage As System.Windows.Forms.Button
    Friend WithEvents MtxtDataCadAnimal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents gpxPesquisa As System.Windows.Forms.GroupBox
    Friend WithEvents gpxAnimal As System.Windows.Forms.GroupBox
    Friend WithEvents pbxBanner As System.Windows.Forms.PictureBox
    Friend WithEvents txtNivelAcesso As System.Windows.Forms.TextBox
    Friend WithEvents cmbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents MtxtFiltroData As System.Windows.Forms.MaskedTextBox
End Class
