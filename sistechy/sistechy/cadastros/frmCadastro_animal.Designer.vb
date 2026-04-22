<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastro_animal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastro_animal))
        Me.pbxAnimal = New System.Windows.Forms.PictureBox()
        Me.btnCadastraAnimal = New System.Windows.Forms.Button()
        Me.lbRelacioneDono = New System.Windows.Forms.Label()
        Me.dgvListaDono = New System.Windows.Forms.DataGridView()
        Me.lbDigiteCodigo = New System.Windows.Forms.Label()
        Me.btnBuscarDono = New System.Windows.Forms.Button()
        Me.btnLoadImage = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lbNomeDono = New System.Windows.Forms.Label()
        Me.lbCodDono = New System.Windows.Forms.Label()
        Me.txtCodDono = New System.Windows.Forms.TextBox()
        Me.txtNomeDono = New System.Windows.Forms.TextBox()
        Me.gpxAnimal = New System.Windows.Forms.GroupBox()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.MtxtDataCadAnimal = New System.Windows.Forms.MaskedTextBox()
        Me.lbAviso = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtLocalImagem = New System.Windows.Forms.TextBox()
        Me.txtEspecieAnimal = New System.Windows.Forms.TextBox()
        Me.cmbCastracaoAnimal = New System.Windows.Forms.ComboBox()
        Me.txtCorAnimal = New System.Windows.Forms.TextBox()
        Me.txtIdadeAnimal = New System.Windows.Forms.TextBox()
        Me.txtPesoAnimal = New System.Windows.Forms.TextBox()
        Me.cmbPorteAnimal = New System.Windows.Forms.ComboBox()
        Me.cmbSexoAnimal = New System.Windows.Forms.ComboBox()
        Me.txtRacaAnimal = New System.Windows.Forms.TextBox()
        Me.lbNome = New System.Windows.Forms.Label()
        Me.txtNomeAnimal = New System.Windows.Forms.TextBox()
        Me.lbDataCad = New System.Windows.Forms.Label()
        Me.lbCastracao = New System.Windows.Forms.Label()
        Me.lbCor = New System.Windows.Forms.Label()
        Me.lbIdade = New System.Windows.Forms.Label()
        Me.lbPeso = New System.Windows.Forms.Label()
        Me.lbSexo = New System.Windows.Forms.Label()
        Me.lbRaca = New System.Windows.Forms.Label()
        Me.lbPorte = New System.Windows.Forms.Label()
        Me.lbEspecie = New System.Windows.Forms.Label()
        Me.gpxDono = New System.Windows.Forms.GroupBox()
        Me.MtxtFiltroData = New System.Windows.Forms.MaskedTextBox()
        Me.cmbFiltro = New System.Windows.Forms.ComboBox()
        Me.txtConsultaDono = New System.Windows.Forms.TextBox()
        Me.pbxBannerAnimal = New System.Windows.Forms.PictureBox()
        CType(Me.pbxAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListaDono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxAnimal.SuspendLayout()
        Me.gpxDono.SuspendLayout()
        CType(Me.pbxBannerAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxAnimal
        '
        Me.pbxAnimal.BackColor = System.Drawing.Color.White
        Me.pbxAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbxAnimal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxAnimal.InitialImage = Nothing
        Me.pbxAnimal.Location = New System.Drawing.Point(23, 39)
        Me.pbxAnimal.Name = "pbxAnimal"
        Me.pbxAnimal.Size = New System.Drawing.Size(150, 194)
        Me.pbxAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxAnimal.TabIndex = 49
        Me.pbxAnimal.TabStop = False
        '
        'btnCadastraAnimal
        '
        Me.btnCadastraAnimal.BackColor = System.Drawing.Color.White
        Me.btnCadastraAnimal.BackgroundImage = Global.sistechy.My.Resources.Resources.salva_cadastro_fw
        Me.btnCadastraAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCadastraAnimal.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCadastraAnimal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnCadastraAnimal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCadastraAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastraAnimal.Location = New System.Drawing.Point(571, 641)
        Me.btnCadastraAnimal.Name = "btnCadastraAnimal"
        Me.btnCadastraAnimal.Size = New System.Drawing.Size(170, 50)
        Me.btnCadastraAnimal.TabIndex = 18
        Me.btnCadastraAnimal.UseVisualStyleBackColor = False
        '
        'lbRelacioneDono
        '
        Me.lbRelacioneDono.AutoSize = True
        Me.lbRelacioneDono.Location = New System.Drawing.Point(21, 26)
        Me.lbRelacioneDono.Name = "lbRelacioneDono"
        Me.lbRelacioneDono.Size = New System.Drawing.Size(91, 13)
        Me.lbRelacioneDono.TabIndex = 75
        Me.lbRelacioneDono.Text = "Relacione o dono"
        '
        'dgvListaDono
        '
        Me.dgvListaDono.AllowUserToAddRows = False
        Me.dgvListaDono.AllowUserToDeleteRows = False
        Me.dgvListaDono.AllowUserToResizeColumns = False
        Me.dgvListaDono.AllowUserToResizeRows = False
        Me.dgvListaDono.BackgroundColor = System.Drawing.Color.White
        Me.dgvListaDono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListaDono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaDono.Location = New System.Drawing.Point(19, 85)
        Me.dgvListaDono.MultiSelect = False
        Me.dgvListaDono.Name = "dgvListaDono"
        Me.dgvListaDono.ReadOnly = True
        Me.dgvListaDono.RowHeadersVisible = False
        Me.dgvListaDono.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvListaDono.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaDono.Size = New System.Drawing.Size(512, 116)
        Me.dgvListaDono.TabIndex = 76
        '
        'lbDigiteCodigo
        '
        Me.lbDigiteCodigo.AutoSize = True
        Me.lbDigiteCodigo.Location = New System.Drawing.Point(22, 56)
        Me.lbDigiteCodigo.Name = "lbDigiteCodigo"
        Me.lbDigiteCodigo.Size = New System.Drawing.Size(61, 13)
        Me.lbDigiteCodigo.TabIndex = 81
        Me.lbDigiteCodigo.Text = "Buscar por:"
        '
        'btnBuscarDono
        '
        Me.btnBuscarDono.BackColor = System.Drawing.Color.White
        Me.btnBuscarDono.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBuscarDono.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscarDono.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscarDono.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarDono.Location = New System.Drawing.Point(389, 53)
        Me.btnBuscarDono.Name = "btnBuscarDono"
        Me.btnBuscarDono.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarDono.TabIndex = 15
        Me.btnBuscarDono.Text = "Buscar"
        Me.btnBuscarDono.UseVisualStyleBackColor = False
        Me.btnBuscarDono.Visible = False
        '
        'btnLoadImage
        '
        Me.btnLoadImage.BackColor = System.Drawing.Color.White
        Me.btnLoadImage.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLoadImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnLoadImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnLoadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadImage.Location = New System.Drawing.Point(23, 239)
        Me.btnLoadImage.Name = "btnLoadImage"
        Me.btnLoadImage.Size = New System.Drawing.Size(150, 23)
        Me.btnLoadImage.TabIndex = 12
        Me.btnLoadImage.Text = "Carregar imagem"
        Me.btnLoadImage.UseVisualStyleBackColor = False
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
        Me.btnCancelar.Location = New System.Drawing.Point(395, 641)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(170, 50)
        Me.btnCancelar.TabIndex = 19
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'lbNomeDono
        '
        Me.lbNomeDono.AutoSize = True
        Me.lbNomeDono.Location = New System.Drawing.Point(138, 213)
        Me.lbNomeDono.Name = "lbNomeDono"
        Me.lbNomeDono.Size = New System.Drawing.Size(77, 13)
        Me.lbNomeDono.TabIndex = 84
        Me.lbNomeDono.Text = "Nome do dono"
        '
        'lbCodDono
        '
        Me.lbCodDono.AutoSize = True
        Me.lbCodDono.Location = New System.Drawing.Point(19, 213)
        Me.lbCodDono.Name = "lbCodDono"
        Me.lbCodDono.Size = New System.Drawing.Size(82, 13)
        Me.lbCodDono.TabIndex = 85
        Me.lbCodDono.Text = "Código do dono"
        '
        'txtCodDono
        '
        Me.txtCodDono.Enabled = False
        Me.txtCodDono.Location = New System.Drawing.Point(21, 229)
        Me.txtCodDono.Name = "txtCodDono"
        Me.txtCodDono.Size = New System.Drawing.Size(88, 20)
        Me.txtCodDono.TabIndex = 16
        '
        'txtNomeDono
        '
        Me.txtNomeDono.Enabled = False
        Me.txtNomeDono.Location = New System.Drawing.Point(141, 229)
        Me.txtNomeDono.Name = "txtNomeDono"
        Me.txtNomeDono.Size = New System.Drawing.Size(308, 20)
        Me.txtNomeDono.TabIndex = 17
        '
        'gpxAnimal
        '
        Me.gpxAnimal.Controls.Add(Me.txtAno)
        Me.gpxAnimal.Controls.Add(Me.txtMes)
        Me.gpxAnimal.Controls.Add(Me.MtxtDataCadAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbAviso)
        Me.gpxAnimal.Controls.Add(Me.Label18)
        Me.gpxAnimal.Controls.Add(Me.txtLocalImagem)
        Me.gpxAnimal.Controls.Add(Me.txtEspecieAnimal)
        Me.gpxAnimal.Controls.Add(Me.cmbCastracaoAnimal)
        Me.gpxAnimal.Controls.Add(Me.btnLoadImage)
        Me.gpxAnimal.Controls.Add(Me.txtCorAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtIdadeAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtPesoAnimal)
        Me.gpxAnimal.Controls.Add(Me.cmbPorteAnimal)
        Me.gpxAnimal.Controls.Add(Me.cmbSexoAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtRacaAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbNome)
        Me.gpxAnimal.Controls.Add(Me.pbxAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtNomeAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbDataCad)
        Me.gpxAnimal.Controls.Add(Me.lbCastracao)
        Me.gpxAnimal.Controls.Add(Me.lbCor)
        Me.gpxAnimal.Controls.Add(Me.lbIdade)
        Me.gpxAnimal.Controls.Add(Me.lbPeso)
        Me.gpxAnimal.Controls.Add(Me.lbSexo)
        Me.gpxAnimal.Controls.Add(Me.lbRaca)
        Me.gpxAnimal.Controls.Add(Me.lbPorte)
        Me.gpxAnimal.Controls.Add(Me.lbEspecie)
        Me.gpxAnimal.Location = New System.Drawing.Point(11, 64)
        Me.gpxAnimal.Name = "gpxAnimal"
        Me.gpxAnimal.Size = New System.Drawing.Size(731, 283)
        Me.gpxAnimal.TabIndex = 91
        Me.gpxAnimal.TabStop = False
        Me.gpxAnimal.Text = "Dados do animal"
        '
        'txtAno
        '
        Me.txtAno.Location = New System.Drawing.Point(600, 65)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(100, 20)
        Me.txtAno.TabIndex = 115
        Me.txtAno.Visible = False
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(600, 39)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(100, 20)
        Me.txtMes.TabIndex = 114
        Me.txtMes.Visible = False
        '
        'MtxtDataCadAnimal
        '
        Me.MtxtDataCadAnimal.Location = New System.Drawing.Point(492, 197)
        Me.MtxtDataCadAnimal.Mask = "00/00/0000"
        Me.MtxtDataCadAnimal.Name = "MtxtDataCadAnimal"
        Me.MtxtDataCadAnimal.Size = New System.Drawing.Size(73, 20)
        Me.MtxtDataCadAnimal.TabIndex = 10
        Me.MtxtDataCadAnimal.ValidatingType = GetType(Date)
        '
        'lbAviso
        '
        Me.lbAviso.AutoSize = True
        Me.lbAviso.Location = New System.Drawing.Point(197, 237)
        Me.lbAviso.Name = "lbAviso"
        Me.lbAviso.Size = New System.Drawing.Size(256, 13)
        Me.lbAviso.TabIndex = 113
        Me.lbAviso.Text = "Os campos com (*) são de preenchimento obrigatório"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(197, 237)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 13)
        Me.Label18.TabIndex = 112
        Me.Label18.Text = "Local da imagem:"
        Me.Label18.Visible = False
        '
        'txtLocalImagem
        '
        Me.txtLocalImagem.Enabled = False
        Me.txtLocalImagem.Location = New System.Drawing.Point(293, 234)
        Me.txtLocalImagem.Name = "txtLocalImagem"
        Me.txtLocalImagem.Size = New System.Drawing.Size(419, 20)
        Me.txtLocalImagem.TabIndex = 11
        Me.txtLocalImagem.Visible = False
        '
        'txtEspecieAnimal
        '
        Me.txtEspecieAnimal.Location = New System.Drawing.Point(200, 92)
        Me.txtEspecieAnimal.Name = "txtEspecieAnimal"
        Me.txtEspecieAnimal.Size = New System.Drawing.Size(121, 20)
        Me.txtEspecieAnimal.TabIndex = 2
        '
        'cmbCastracaoAnimal
        '
        Me.cmbCastracaoAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCastracaoAnimal.FormattingEnabled = True
        Me.cmbCastracaoAnimal.Location = New System.Drawing.Point(356, 198)
        Me.cmbCastracaoAnimal.Name = "cmbCastracaoAnimal"
        Me.cmbCastracaoAnimal.Size = New System.Drawing.Size(100, 21)
        Me.cmbCastracaoAnimal.TabIndex = 9
        '
        'txtCorAnimal
        '
        Me.txtCorAnimal.Location = New System.Drawing.Point(200, 198)
        Me.txtCorAnimal.Name = "txtCorAnimal"
        Me.txtCorAnimal.Size = New System.Drawing.Size(121, 20)
        Me.txtCorAnimal.TabIndex = 8
        '
        'txtIdadeAnimal
        '
        Me.txtIdadeAnimal.Location = New System.Drawing.Point(462, 143)
        Me.txtIdadeAnimal.Name = "txtIdadeAnimal"
        Me.txtIdadeAnimal.Size = New System.Drawing.Size(70, 20)
        Me.txtIdadeAnimal.TabIndex = 7
        '
        'txtPesoAnimal
        '
        Me.txtPesoAnimal.Location = New System.Drawing.Point(343, 143)
        Me.txtPesoAnimal.Name = "txtPesoAnimal"
        Me.txtPesoAnimal.Size = New System.Drawing.Size(82, 20)
        Me.txtPesoAnimal.TabIndex = 6
        '
        'cmbPorteAnimal
        '
        Me.cmbPorteAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPorteAnimal.FormattingEnabled = True
        Me.cmbPorteAnimal.Location = New System.Drawing.Point(200, 143)
        Me.cmbPorteAnimal.Name = "cmbPorteAnimal"
        Me.cmbPorteAnimal.Size = New System.Drawing.Size(106, 21)
        Me.cmbPorteAnimal.TabIndex = 5
        '
        'cmbSexoAnimal
        '
        Me.cmbSexoAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexoAnimal.FormattingEnabled = True
        Me.cmbSexoAnimal.Location = New System.Drawing.Point(492, 91)
        Me.cmbSexoAnimal.Name = "cmbSexoAnimal"
        Me.cmbSexoAnimal.Size = New System.Drawing.Size(99, 21)
        Me.cmbSexoAnimal.TabIndex = 4
        '
        'txtRacaAnimal
        '
        Me.txtRacaAnimal.Location = New System.Drawing.Point(356, 91)
        Me.txtRacaAnimal.Name = "txtRacaAnimal"
        Me.txtRacaAnimal.Size = New System.Drawing.Size(100, 20)
        Me.txtRacaAnimal.TabIndex = 3
        '
        'lbNome
        '
        Me.lbNome.AutoSize = True
        Me.lbNome.Location = New System.Drawing.Point(197, 23)
        Me.lbNome.Name = "lbNome"
        Me.lbNome.Size = New System.Drawing.Size(48, 13)
        Me.lbNome.TabIndex = 111
        Me.lbNome.Text = "Nome (*)"
        '
        'txtNomeAnimal
        '
        Me.txtNomeAnimal.Location = New System.Drawing.Point(200, 39)
        Me.txtNomeAnimal.Name = "txtNomeAnimal"
        Me.txtNomeAnimal.Size = New System.Drawing.Size(354, 20)
        Me.txtNomeAnimal.TabIndex = 1
        '
        'lbDataCad
        '
        Me.lbDataCad.AutoSize = True
        Me.lbDataCad.Location = New System.Drawing.Point(489, 182)
        Me.lbDataCad.Name = "lbDataCad"
        Me.lbDataCad.Size = New System.Drawing.Size(89, 13)
        Me.lbDataCad.TabIndex = 110
        Me.lbDataCad.Text = "Data de cadastro"
        '
        'lbCastracao
        '
        Me.lbCastracao.AutoSize = True
        Me.lbCastracao.Location = New System.Drawing.Point(353, 182)
        Me.lbCastracao.Name = "lbCastracao"
        Me.lbCastracao.Size = New System.Drawing.Size(55, 13)
        Me.lbCastracao.TabIndex = 109
        Me.lbCastracao.Text = "Castração"
        '
        'lbCor
        '
        Me.lbCor.AutoSize = True
        Me.lbCor.Location = New System.Drawing.Point(197, 182)
        Me.lbCor.Name = "lbCor"
        Me.lbCor.Size = New System.Drawing.Size(23, 13)
        Me.lbCor.TabIndex = 108
        Me.lbCor.Text = "Cor"
        '
        'lbIdade
        '
        Me.lbIdade.AutoSize = True
        Me.lbIdade.Location = New System.Drawing.Point(459, 126)
        Me.lbIdade.Name = "lbIdade"
        Me.lbIdade.Size = New System.Drawing.Size(34, 13)
        Me.lbIdade.TabIndex = 107
        Me.lbIdade.Text = "Idade"
        '
        'lbPeso
        '
        Me.lbPeso.AutoSize = True
        Me.lbPeso.Location = New System.Drawing.Point(340, 126)
        Me.lbPeso.Name = "lbPeso"
        Me.lbPeso.Size = New System.Drawing.Size(31, 13)
        Me.lbPeso.TabIndex = 106
        Me.lbPeso.Text = "Peso"
        '
        'lbSexo
        '
        Me.lbSexo.AutoSize = True
        Me.lbSexo.Location = New System.Drawing.Point(489, 75)
        Me.lbSexo.Name = "lbSexo"
        Me.lbSexo.Size = New System.Drawing.Size(44, 13)
        Me.lbSexo.TabIndex = 105
        Me.lbSexo.Text = "Sexo (*)"
        '
        'lbRaca
        '
        Me.lbRaca.AutoSize = True
        Me.lbRaca.Location = New System.Drawing.Point(353, 75)
        Me.lbRaca.Name = "lbRaca"
        Me.lbRaca.Size = New System.Drawing.Size(33, 13)
        Me.lbRaca.TabIndex = 104
        Me.lbRaca.Text = "Raça"
        '
        'lbPorte
        '
        Me.lbPorte.AutoSize = True
        Me.lbPorte.Location = New System.Drawing.Point(197, 126)
        Me.lbPorte.Name = "lbPorte"
        Me.lbPorte.Size = New System.Drawing.Size(32, 13)
        Me.lbPorte.TabIndex = 103
        Me.lbPorte.Text = "Porte"
        '
        'lbEspecie
        '
        Me.lbEspecie.AutoSize = True
        Me.lbEspecie.Location = New System.Drawing.Point(197, 75)
        Me.lbEspecie.Name = "lbEspecie"
        Me.lbEspecie.Size = New System.Drawing.Size(45, 13)
        Me.lbEspecie.TabIndex = 102
        Me.lbEspecie.Text = "Espécie"
        '
        'gpxDono
        '
        Me.gpxDono.Controls.Add(Me.MtxtFiltroData)
        Me.gpxDono.Controls.Add(Me.cmbFiltro)
        Me.gpxDono.Controls.Add(Me.txtConsultaDono)
        Me.gpxDono.Controls.Add(Me.lbRelacioneDono)
        Me.gpxDono.Controls.Add(Me.dgvListaDono)
        Me.gpxDono.Controls.Add(Me.txtNomeDono)
        Me.gpxDono.Controls.Add(Me.txtCodDono)
        Me.gpxDono.Controls.Add(Me.lbDigiteCodigo)
        Me.gpxDono.Controls.Add(Me.lbCodDono)
        Me.gpxDono.Controls.Add(Me.btnBuscarDono)
        Me.gpxDono.Controls.Add(Me.lbNomeDono)
        Me.gpxDono.Location = New System.Drawing.Point(12, 365)
        Me.gpxDono.Name = "gpxDono"
        Me.gpxDono.Size = New System.Drawing.Size(731, 267)
        Me.gpxDono.TabIndex = 13
        Me.gpxDono.TabStop = False
        Me.gpxDono.Text = "Dados do dono"
        '
        'MtxtFiltroData
        '
        Me.MtxtFiltroData.Location = New System.Drawing.Point(225, 54)
        Me.MtxtFiltroData.Mask = "00/00/0000"
        Me.MtxtFiltroData.Name = "MtxtFiltroData"
        Me.MtxtFiltroData.Size = New System.Drawing.Size(72, 20)
        Me.MtxtFiltroData.TabIndex = 88
        Me.MtxtFiltroData.ValidatingType = GetType(Date)
        Me.MtxtFiltroData.Visible = False
        '
        'cmbFiltro
        '
        Me.cmbFiltro.FormattingEnabled = True
        Me.cmbFiltro.Location = New System.Drawing.Point(89, 53)
        Me.cmbFiltro.Name = "cmbFiltro"
        Me.cmbFiltro.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltro.TabIndex = 87
        '
        'txtConsultaDono
        '
        Me.txtConsultaDono.Location = New System.Drawing.Point(225, 54)
        Me.txtConsultaDono.Name = "txtConsultaDono"
        Me.txtConsultaDono.Size = New System.Drawing.Size(152, 20)
        Me.txtConsultaDono.TabIndex = 86
        Me.txtConsultaDono.Visible = False
        '
        'pbxBannerAnimal
        '
        Me.pbxBannerAnimal.BackgroundImage = Global.sistechy.My.Resources.Resources.banner_cadastro_animal_fw
        Me.pbxBannerAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxBannerAnimal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxBannerAnimal.Location = New System.Drawing.Point(-5, -2)
        Me.pbxBannerAnimal.Name = "pbxBannerAnimal"
        Me.pbxBannerAnimal.Size = New System.Drawing.Size(771, 55)
        Me.pbxBannerAnimal.TabIndex = 92
        Me.pbxBannerAnimal.TabStop = False
        '
        'frmCadastro_animal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(755, 702)
        Me.Controls.Add(Me.pbxBannerAnimal)
        Me.Controls.Add(Me.gpxDono)
        Me.Controls.Add(Me.gpxAnimal)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCadastraAnimal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCadastro_animal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de animal"
        CType(Me.pbxAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListaDono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxAnimal.ResumeLayout(False)
        Me.gpxAnimal.PerformLayout()
        Me.gpxDono.ResumeLayout(False)
        Me.gpxDono.PerformLayout()
        CType(Me.pbxBannerAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbxAnimal As System.Windows.Forms.PictureBox
    Friend WithEvents btnCadastraAnimal As System.Windows.Forms.Button
    Friend WithEvents lbRelacioneDono As System.Windows.Forms.Label
    Friend WithEvents dgvListaDono As System.Windows.Forms.DataGridView
    Friend WithEvents lbDigiteCodigo As System.Windows.Forms.Label
    Friend WithEvents btnBuscarDono As System.Windows.Forms.Button
    Friend WithEvents btnLoadImage As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lbNomeDono As System.Windows.Forms.Label
    Friend WithEvents lbCodDono As System.Windows.Forms.Label
    Friend WithEvents txtCodDono As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeDono As System.Windows.Forms.TextBox
    Friend WithEvents gpxAnimal As System.Windows.Forms.GroupBox
    Friend WithEvents MtxtDataCadAnimal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbAviso As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtLocalImagem As System.Windows.Forms.TextBox
    Friend WithEvents txtEspecieAnimal As System.Windows.Forms.TextBox
    Friend WithEvents cmbCastracaoAnimal As System.Windows.Forms.ComboBox
    Friend WithEvents txtCorAnimal As System.Windows.Forms.TextBox
    Friend WithEvents txtIdadeAnimal As System.Windows.Forms.TextBox
    Friend WithEvents txtPesoAnimal As System.Windows.Forms.TextBox
    Friend WithEvents cmbPorteAnimal As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSexoAnimal As System.Windows.Forms.ComboBox
    Friend WithEvents txtRacaAnimal As System.Windows.Forms.TextBox
    Friend WithEvents lbNome As System.Windows.Forms.Label
    Friend WithEvents txtNomeAnimal As System.Windows.Forms.TextBox
    Friend WithEvents lbDataCad As System.Windows.Forms.Label
    Friend WithEvents lbCastracao As System.Windows.Forms.Label
    Friend WithEvents lbCor As System.Windows.Forms.Label
    Friend WithEvents lbIdade As System.Windows.Forms.Label
    Friend WithEvents lbPeso As System.Windows.Forms.Label
    Friend WithEvents lbSexo As System.Windows.Forms.Label
    Friend WithEvents lbRaca As System.Windows.Forms.Label
    Friend WithEvents lbPorte As System.Windows.Forms.Label
    Friend WithEvents lbEspecie As System.Windows.Forms.Label
    Friend WithEvents gpxDono As System.Windows.Forms.GroupBox
    Friend WithEvents pbxBannerAnimal As System.Windows.Forms.PictureBox
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents txtAno As System.Windows.Forms.TextBox
    Friend WithEvents MtxtFiltroData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents txtConsultaDono As System.Windows.Forms.TextBox
End Class
