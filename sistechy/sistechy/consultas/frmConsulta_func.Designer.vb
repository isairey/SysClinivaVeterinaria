<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsulta_func
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsulta_func))
        Me.dgvFunc = New System.Windows.Forms.DataGridView()
        Me.lbBuscarPor = New System.Windows.Forms.Label()
        Me.txtConsultaFunc = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lbTelefone = New System.Windows.Forms.Label()
        Me.lbNome = New System.Windows.Forms.Label()
        Me.lbDDD = New System.Windows.Forms.Label()
        Me.lbCelular = New System.Windows.Forms.Label()
        Me.lbDataCad = New System.Windows.Forms.Label()
        Me.lbEmail = New System.Windows.Forms.Label()
        Me.lbDataNasc = New System.Windows.Forms.Label()
        Me.lbCPF = New System.Windows.Forms.Label()
        Me.lbEndereco = New System.Windows.Forms.Label()
        Me.lbSexo = New System.Windows.Forms.Label()
        Me.lbCod = New System.Windows.Forms.Label()
        Me.lbCidade = New System.Windows.Forms.Label()
        Me.lbUF = New System.Windows.Forms.Label()
        Me.lbNumero = New System.Windows.Forms.Label()
        Me.lbCEP = New System.Windows.Forms.Label()
        Me.lbCargo = New System.Windows.Forms.Label()
        Me.lbBairro = New System.Windows.Forms.Label()
        Me.lbLogin = New System.Windows.Forms.Label()
        Me.txtCodFunc = New System.Windows.Forms.TextBox()
        Me.txtNomeFunc = New System.Windows.Forms.TextBox()
        Me.MtxtDDDFunc = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmailFunc = New System.Windows.Forms.TextBox()
        Me.MtxtCPFFunc = New System.Windows.Forms.MaskedTextBox()
        Me.txtEndFunc = New System.Windows.Forms.TextBox()
        Me.txtNumFunc = New System.Windows.Forms.TextBox()
        Me.txtCidadeFunc = New System.Windows.Forms.TextBox()
        Me.txtBairroFunc = New System.Windows.Forms.TextBox()
        Me.MtxtCEPFunc = New System.Windows.Forms.MaskedTextBox()
        Me.txtCargoFunc = New System.Windows.Forms.TextBox()
        Me.txtLoginFunc = New System.Windows.Forms.TextBox()
        Me.cmbUFFunc = New System.Windows.Forms.ComboBox()
        Me.cmbSexoFunc = New System.Windows.Forms.ComboBox()
        Me.gpxPesquisa = New System.Windows.Forms.GroupBox()
        Me.MtxtFiltroData = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtFiltroCPF = New System.Windows.Forms.MaskedTextBox()
        Me.cmbFiltro = New System.Windows.Forms.ComboBox()
        Me.gpxDadosFunc = New System.Windows.Forms.GroupBox()
        Me.MtxtDataCadFunc = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtDataNascfunc = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtCelFunc = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtTelFunc = New System.Windows.Forms.MaskedTextBox()
        Me.pbxBanner = New System.Windows.Forms.PictureBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.dgvFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxPesquisa.SuspendLayout()
        Me.gpxDadosFunc.SuspendLayout()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvFunc
        '
        Me.dgvFunc.AllowUserToAddRows = False
        Me.dgvFunc.AllowUserToDeleteRows = False
        Me.dgvFunc.AllowUserToResizeColumns = False
        Me.dgvFunc.AllowUserToResizeRows = False
        Me.dgvFunc.BackgroundColor = System.Drawing.Color.White
        Me.dgvFunc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFunc.Location = New System.Drawing.Point(18, 60)
        Me.dgvFunc.MultiSelect = False
        Me.dgvFunc.Name = "dgvFunc"
        Me.dgvFunc.ReadOnly = True
        Me.dgvFunc.RowHeadersVisible = False
        Me.dgvFunc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvFunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFunc.Size = New System.Drawing.Size(695, 140)
        Me.dgvFunc.TabIndex = 3
        '
        'lbBuscarPor
        '
        Me.lbBuscarPor.AutoSize = True
        Me.lbBuscarPor.Location = New System.Drawing.Point(18, 26)
        Me.lbBuscarPor.Name = "lbBuscarPor"
        Me.lbBuscarPor.Size = New System.Drawing.Size(61, 13)
        Me.lbBuscarPor.TabIndex = 7
        Me.lbBuscarPor.Text = "Buscar por:"
        '
        'txtConsultaFunc
        '
        Me.txtConsultaFunc.Location = New System.Drawing.Point(227, 24)
        Me.txtConsultaFunc.Name = "txtConsultaFunc"
        Me.txtConsultaFunc.Size = New System.Drawing.Size(266, 20)
        Me.txtConsultaFunc.TabIndex = 1
        Me.txtConsultaFunc.Visible = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(508, 22)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        Me.btnBuscar.Visible = False
        '
        'lbTelefone
        '
        Me.lbTelefone.AutoSize = True
        Me.lbTelefone.Location = New System.Drawing.Point(580, 18)
        Me.lbTelefone.Name = "lbTelefone"
        Me.lbTelefone.Size = New System.Drawing.Size(49, 13)
        Me.lbTelefone.TabIndex = 14
        Me.lbTelefone.Text = "Telefone"
        '
        'lbNome
        '
        Me.lbNome.AutoSize = True
        Me.lbNome.Location = New System.Drawing.Point(124, 18)
        Me.lbNome.Name = "lbNome"
        Me.lbNome.Size = New System.Drawing.Size(35, 13)
        Me.lbNome.TabIndex = 15
        Me.lbNome.Text = "Nome"
        '
        'lbDDD
        '
        Me.lbDDD.AutoSize = True
        Me.lbDDD.Location = New System.Drawing.Point(507, 18)
        Me.lbDDD.Name = "lbDDD"
        Me.lbDDD.Size = New System.Drawing.Size(31, 13)
        Me.lbDDD.TabIndex = 16
        Me.lbDDD.Text = "DDD"
        '
        'lbCelular
        '
        Me.lbCelular.AutoSize = True
        Me.lbCelular.Location = New System.Drawing.Point(15, 68)
        Me.lbCelular.Name = "lbCelular"
        Me.lbCelular.Size = New System.Drawing.Size(39, 13)
        Me.lbCelular.TabIndex = 17
        Me.lbCelular.Text = "Celular"
        '
        'lbDataCad
        '
        Me.lbDataCad.AutoSize = True
        Me.lbDataCad.Location = New System.Drawing.Point(268, 119)
        Me.lbDataCad.Name = "lbDataCad"
        Me.lbDataCad.Size = New System.Drawing.Size(75, 13)
        Me.lbDataCad.TabIndex = 18
        Me.lbDataCad.Text = "Data Cadastro"
        '
        'lbEmail
        '
        Me.lbEmail.AutoSize = True
        Me.lbEmail.Location = New System.Drawing.Point(124, 68)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(32, 13)
        Me.lbEmail.TabIndex = 19
        Me.lbEmail.Text = "Email"
        '
        'lbDataNasc
        '
        Me.lbDataNasc.AutoSize = True
        Me.lbDataNasc.Location = New System.Drawing.Point(15, 119)
        Me.lbDataNasc.Name = "lbDataNasc"
        Me.lbDataNasc.Size = New System.Drawing.Size(89, 13)
        Me.lbDataNasc.TabIndex = 20
        Me.lbDataNasc.Text = "Data Nascimento"
        '
        'lbCPF
        '
        Me.lbCPF.AutoSize = True
        Me.lbCPF.Location = New System.Drawing.Point(146, 119)
        Me.lbCPF.Name = "lbCPF"
        Me.lbCPF.Size = New System.Drawing.Size(27, 13)
        Me.lbCPF.TabIndex = 21
        Me.lbCPF.Text = "CPF"
        '
        'lbEndereco
        '
        Me.lbEndereco.AutoSize = True
        Me.lbEndereco.Location = New System.Drawing.Point(398, 119)
        Me.lbEndereco.Name = "lbEndereco"
        Me.lbEndereco.Size = New System.Drawing.Size(53, 13)
        Me.lbEndereco.TabIndex = 22
        Me.lbEndereco.Text = "Endereço"
        '
        'lbSexo
        '
        Me.lbSexo.AutoSize = True
        Me.lbSexo.Location = New System.Drawing.Point(507, 68)
        Me.lbSexo.Name = "lbSexo"
        Me.lbSexo.Size = New System.Drawing.Size(31, 13)
        Me.lbSexo.TabIndex = 23
        Me.lbSexo.Text = "Sexo"
        '
        'lbCod
        '
        Me.lbCod.AutoSize = True
        Me.lbCod.Location = New System.Drawing.Point(14, 18)
        Me.lbCod.Name = "lbCod"
        Me.lbCod.Size = New System.Drawing.Size(40, 13)
        Me.lbCod.TabIndex = 24
        Me.lbCod.Text = "Código"
        '
        'lbCidade
        '
        Me.lbCidade.AutoSize = True
        Me.lbCidade.Location = New System.Drawing.Point(104, 170)
        Me.lbCidade.Name = "lbCidade"
        Me.lbCidade.Size = New System.Drawing.Size(40, 13)
        Me.lbCidade.TabIndex = 25
        Me.lbCidade.Text = "Cidade"
        '
        'lbUF
        '
        Me.lbUF.AutoSize = True
        Me.lbUF.Location = New System.Drawing.Point(413, 170)
        Me.lbUF.Name = "lbUF"
        Me.lbUF.Size = New System.Drawing.Size(21, 13)
        Me.lbUF.TabIndex = 26
        Me.lbUF.Text = "UF"
        '
        'lbNumero
        '
        Me.lbNumero.AutoSize = True
        Me.lbNumero.Location = New System.Drawing.Point(15, 170)
        Me.lbNumero.Name = "lbNumero"
        Me.lbNumero.Size = New System.Drawing.Size(44, 13)
        Me.lbNumero.TabIndex = 27
        Me.lbNumero.Text = "Número"
        '
        'lbCEP
        '
        Me.lbCEP.AutoSize = True
        Me.lbCEP.Location = New System.Drawing.Point(297, 217)
        Me.lbCEP.Name = "lbCEP"
        Me.lbCEP.Size = New System.Drawing.Size(28, 13)
        Me.lbCEP.TabIndex = 28
        Me.lbCEP.Text = "CEP"
        '
        'lbCargo
        '
        Me.lbCargo.AutoSize = True
        Me.lbCargo.Location = New System.Drawing.Point(399, 217)
        Me.lbCargo.Name = "lbCargo"
        Me.lbCargo.Size = New System.Drawing.Size(35, 13)
        Me.lbCargo.TabIndex = 29
        Me.lbCargo.Text = "Cargo"
        '
        'lbBairro
        '
        Me.lbBairro.AutoSize = True
        Me.lbBairro.Location = New System.Drawing.Point(15, 217)
        Me.lbBairro.Name = "lbBairro"
        Me.lbBairro.Size = New System.Drawing.Size(34, 13)
        Me.lbBairro.TabIndex = 30
        Me.lbBairro.Text = "Bairro"
        '
        'lbLogin
        '
        Me.lbLogin.AutoSize = True
        Me.lbLogin.Location = New System.Drawing.Point(565, 217)
        Me.lbLogin.Name = "lbLogin"
        Me.lbLogin.Size = New System.Drawing.Size(33, 13)
        Me.lbLogin.TabIndex = 31
        Me.lbLogin.Text = "Login"
        '
        'txtCodFunc
        '
        Me.txtCodFunc.Enabled = False
        Me.txtCodFunc.Location = New System.Drawing.Point(17, 34)
        Me.txtCodFunc.Name = "txtCodFunc"
        Me.txtCodFunc.Size = New System.Drawing.Size(84, 20)
        Me.txtCodFunc.TabIndex = 4
        '
        'txtNomeFunc
        '
        Me.txtNomeFunc.Enabled = False
        Me.txtNomeFunc.Location = New System.Drawing.Point(127, 34)
        Me.txtNomeFunc.Name = "txtNomeFunc"
        Me.txtNomeFunc.Size = New System.Drawing.Size(354, 20)
        Me.txtNomeFunc.TabIndex = 5
        '
        'MtxtDDDFunc
        '
        Me.MtxtDDDFunc.Enabled = False
        Me.MtxtDDDFunc.Location = New System.Drawing.Point(510, 34)
        Me.MtxtDDDFunc.Mask = "(000)"
        Me.MtxtDDDFunc.Name = "MtxtDDDFunc"
        Me.MtxtDDDFunc.Size = New System.Drawing.Size(31, 20)
        Me.MtxtDDDFunc.TabIndex = 6
        '
        'txtEmailFunc
        '
        Me.txtEmailFunc.Enabled = False
        Me.txtEmailFunc.Location = New System.Drawing.Point(127, 84)
        Me.txtEmailFunc.Name = "txtEmailFunc"
        Me.txtEmailFunc.Size = New System.Drawing.Size(351, 20)
        Me.txtEmailFunc.TabIndex = 9
        '
        'MtxtCPFFunc
        '
        Me.MtxtCPFFunc.Enabled = False
        Me.MtxtCPFFunc.Location = New System.Drawing.Point(149, 135)
        Me.MtxtCPFFunc.Mask = "000.000.000-00"
        Me.MtxtCPFFunc.Name = "MtxtCPFFunc"
        Me.MtxtCPFFunc.Size = New System.Drawing.Size(94, 20)
        Me.MtxtCPFFunc.TabIndex = 12
        '
        'txtEndFunc
        '
        Me.txtEndFunc.Enabled = False
        Me.txtEndFunc.Location = New System.Drawing.Point(401, 135)
        Me.txtEndFunc.Name = "txtEndFunc"
        Me.txtEndFunc.Size = New System.Drawing.Size(300, 20)
        Me.txtEndFunc.TabIndex = 14
        '
        'txtNumFunc
        '
        Me.txtNumFunc.Enabled = False
        Me.txtNumFunc.Location = New System.Drawing.Point(18, 187)
        Me.txtNumFunc.Name = "txtNumFunc"
        Me.txtNumFunc.Size = New System.Drawing.Size(62, 20)
        Me.txtNumFunc.TabIndex = 15
        '
        'txtCidadeFunc
        '
        Me.txtCidadeFunc.Enabled = False
        Me.txtCidadeFunc.Location = New System.Drawing.Point(107, 187)
        Me.txtCidadeFunc.Name = "txtCidadeFunc"
        Me.txtCidadeFunc.Size = New System.Drawing.Size(282, 20)
        Me.txtCidadeFunc.TabIndex = 16
        '
        'txtBairroFunc
        '
        Me.txtBairroFunc.Enabled = False
        Me.txtBairroFunc.Location = New System.Drawing.Point(18, 233)
        Me.txtBairroFunc.Name = "txtBairroFunc"
        Me.txtBairroFunc.Size = New System.Drawing.Size(249, 20)
        Me.txtBairroFunc.TabIndex = 18
        '
        'MtxtCEPFunc
        '
        Me.MtxtCEPFunc.Enabled = False
        Me.MtxtCEPFunc.Location = New System.Drawing.Point(300, 233)
        Me.MtxtCEPFunc.Mask = "00000-000"
        Me.MtxtCEPFunc.Name = "MtxtCEPFunc"
        Me.MtxtCEPFunc.Size = New System.Drawing.Size(71, 20)
        Me.MtxtCEPFunc.TabIndex = 19
        '
        'txtCargoFunc
        '
        Me.txtCargoFunc.Enabled = False
        Me.txtCargoFunc.Location = New System.Drawing.Point(401, 233)
        Me.txtCargoFunc.Name = "txtCargoFunc"
        Me.txtCargoFunc.Size = New System.Drawing.Size(139, 20)
        Me.txtCargoFunc.TabIndex = 20
        '
        'txtLoginFunc
        '
        Me.txtLoginFunc.Enabled = False
        Me.txtLoginFunc.Location = New System.Drawing.Point(568, 233)
        Me.txtLoginFunc.Name = "txtLoginFunc"
        Me.txtLoginFunc.Size = New System.Drawing.Size(133, 20)
        Me.txtLoginFunc.TabIndex = 21
        '
        'cmbUFFunc
        '
        Me.cmbUFFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUFFunc.Enabled = False
        Me.cmbUFFunc.FormattingEnabled = True
        Me.cmbUFFunc.Location = New System.Drawing.Point(416, 187)
        Me.cmbUFFunc.Name = "cmbUFFunc"
        Me.cmbUFFunc.Size = New System.Drawing.Size(46, 21)
        Me.cmbUFFunc.TabIndex = 62
        '
        'cmbSexoFunc
        '
        Me.cmbSexoFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexoFunc.Enabled = False
        Me.cmbSexoFunc.FormattingEnabled = True
        Me.cmbSexoFunc.Location = New System.Drawing.Point(508, 84)
        Me.cmbSexoFunc.Name = "cmbSexoFunc"
        Me.cmbSexoFunc.Size = New System.Drawing.Size(113, 21)
        Me.cmbSexoFunc.TabIndex = 66
        '
        'gpxPesquisa
        '
        Me.gpxPesquisa.Controls.Add(Me.MtxtFiltroData)
        Me.gpxPesquisa.Controls.Add(Me.MtxtFiltroCPF)
        Me.gpxPesquisa.Controls.Add(Me.cmbFiltro)
        Me.gpxPesquisa.Controls.Add(Me.lbBuscarPor)
        Me.gpxPesquisa.Controls.Add(Me.txtConsultaFunc)
        Me.gpxPesquisa.Controls.Add(Me.dgvFunc)
        Me.gpxPesquisa.Controls.Add(Me.btnBuscar)
        Me.gpxPesquisa.Location = New System.Drawing.Point(12, 62)
        Me.gpxPesquisa.Name = "gpxPesquisa"
        Me.gpxPesquisa.Size = New System.Drawing.Size(734, 208)
        Me.gpxPesquisa.TabIndex = 67
        Me.gpxPesquisa.TabStop = False
        Me.gpxPesquisa.Text = "Dados da pesquisa"
        '
        'MtxtFiltroData
        '
        Me.MtxtFiltroData.Location = New System.Drawing.Point(227, 24)
        Me.MtxtFiltroData.Mask = "00/00/0000"
        Me.MtxtFiltroData.Name = "MtxtFiltroData"
        Me.MtxtFiltroData.Size = New System.Drawing.Size(73, 20)
        Me.MtxtFiltroData.TabIndex = 27
        Me.MtxtFiltroData.ValidatingType = GetType(Date)
        Me.MtxtFiltroData.Visible = False
        '
        'MtxtFiltroCPF
        '
        Me.MtxtFiltroCPF.Location = New System.Drawing.Point(227, 24)
        Me.MtxtFiltroCPF.Mask = "000.000.000-00"
        Me.MtxtFiltroCPF.Name = "MtxtFiltroCPF"
        Me.MtxtFiltroCPF.Size = New System.Drawing.Size(87, 20)
        Me.MtxtFiltroCPF.TabIndex = 26
        Me.MtxtFiltroCPF.Visible = False
        '
        'cmbFiltro
        '
        Me.cmbFiltro.FormattingEnabled = True
        Me.cmbFiltro.Location = New System.Drawing.Point(85, 23)
        Me.cmbFiltro.Name = "cmbFiltro"
        Me.cmbFiltro.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltro.TabIndex = 25
        '
        'gpxDadosFunc
        '
        Me.gpxDadosFunc.Controls.Add(Me.MtxtDataCadFunc)
        Me.gpxDadosFunc.Controls.Add(Me.MtxtDataNascfunc)
        Me.gpxDadosFunc.Controls.Add(Me.MtxtCelFunc)
        Me.gpxDadosFunc.Controls.Add(Me.MtxtTelFunc)
        Me.gpxDadosFunc.Controls.Add(Me.txtCodFunc)
        Me.gpxDadosFunc.Controls.Add(Me.lbTelefone)
        Me.gpxDadosFunc.Controls.Add(Me.cmbSexoFunc)
        Me.gpxDadosFunc.Controls.Add(Me.lbNome)
        Me.gpxDadosFunc.Controls.Add(Me.lbDDD)
        Me.gpxDadosFunc.Controls.Add(Me.lbCelular)
        Me.gpxDadosFunc.Controls.Add(Me.lbDataCad)
        Me.gpxDadosFunc.Controls.Add(Me.cmbUFFunc)
        Me.gpxDadosFunc.Controls.Add(Me.lbEmail)
        Me.gpxDadosFunc.Controls.Add(Me.lbDataNasc)
        Me.gpxDadosFunc.Controls.Add(Me.txtLoginFunc)
        Me.gpxDadosFunc.Controls.Add(Me.lbCPF)
        Me.gpxDadosFunc.Controls.Add(Me.txtCargoFunc)
        Me.gpxDadosFunc.Controls.Add(Me.lbEndereco)
        Me.gpxDadosFunc.Controls.Add(Me.MtxtCEPFunc)
        Me.gpxDadosFunc.Controls.Add(Me.lbSexo)
        Me.gpxDadosFunc.Controls.Add(Me.txtBairroFunc)
        Me.gpxDadosFunc.Controls.Add(Me.lbCod)
        Me.gpxDadosFunc.Controls.Add(Me.txtCidadeFunc)
        Me.gpxDadosFunc.Controls.Add(Me.lbCidade)
        Me.gpxDadosFunc.Controls.Add(Me.txtNumFunc)
        Me.gpxDadosFunc.Controls.Add(Me.lbUF)
        Me.gpxDadosFunc.Controls.Add(Me.txtEndFunc)
        Me.gpxDadosFunc.Controls.Add(Me.lbNumero)
        Me.gpxDadosFunc.Controls.Add(Me.lbCEP)
        Me.gpxDadosFunc.Controls.Add(Me.MtxtCPFFunc)
        Me.gpxDadosFunc.Controls.Add(Me.lbCargo)
        Me.gpxDadosFunc.Controls.Add(Me.lbBairro)
        Me.gpxDadosFunc.Controls.Add(Me.txtEmailFunc)
        Me.gpxDadosFunc.Controls.Add(Me.lbLogin)
        Me.gpxDadosFunc.Controls.Add(Me.txtNomeFunc)
        Me.gpxDadosFunc.Controls.Add(Me.MtxtDDDFunc)
        Me.gpxDadosFunc.Location = New System.Drawing.Point(12, 287)
        Me.gpxDadosFunc.Name = "gpxDadosFunc"
        Me.gpxDadosFunc.Size = New System.Drawing.Size(734, 270)
        Me.gpxDadosFunc.TabIndex = 3
        Me.gpxDadosFunc.TabStop = False
        Me.gpxDadosFunc.Text = "Dados do funcionário"
        '
        'MtxtDataCadFunc
        '
        Me.MtxtDataCadFunc.Enabled = False
        Me.MtxtDataCadFunc.Location = New System.Drawing.Point(271, 135)
        Me.MtxtDataCadFunc.Mask = "00/00/0000"
        Me.MtxtDataCadFunc.Name = "MtxtDataCadFunc"
        Me.MtxtDataCadFunc.Size = New System.Drawing.Size(73, 20)
        Me.MtxtDataCadFunc.TabIndex = 70
        Me.MtxtDataCadFunc.ValidatingType = GetType(Date)
        '
        'MtxtDataNascfunc
        '
        Me.MtxtDataNascfunc.Enabled = False
        Me.MtxtDataNascfunc.Location = New System.Drawing.Point(17, 135)
        Me.MtxtDataNascfunc.Mask = "00/00/0000"
        Me.MtxtDataNascfunc.Name = "MtxtDataNascfunc"
        Me.MtxtDataNascfunc.Size = New System.Drawing.Size(73, 20)
        Me.MtxtDataNascfunc.TabIndex = 69
        Me.MtxtDataNascfunc.ValidatingType = GetType(Date)
        '
        'MtxtCelFunc
        '
        Me.MtxtCelFunc.Enabled = False
        Me.MtxtCelFunc.Location = New System.Drawing.Point(17, 85)
        Me.MtxtCelFunc.Mask = "00000-0000"
        Me.MtxtCelFunc.Name = "MtxtCelFunc"
        Me.MtxtCelFunc.Size = New System.Drawing.Size(63, 20)
        Me.MtxtCelFunc.TabIndex = 68
        '
        'MtxtTelFunc
        '
        Me.MtxtTelFunc.Enabled = False
        Me.MtxtTelFunc.Location = New System.Drawing.Point(583, 34)
        Me.MtxtTelFunc.Mask = "0000-0000"
        Me.MtxtTelFunc.Name = "MtxtTelFunc"
        Me.MtxtTelFunc.Size = New System.Drawing.Size(57, 20)
        Me.MtxtTelFunc.TabIndex = 67
        '
        'pbxBanner
        '
        Me.pbxBanner.BackgroundImage = Global.sistechy.My.Resources.Resources.banner_consulta_funcionario_fw
        Me.pbxBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxBanner.Location = New System.Drawing.Point(-5, -2)
        Me.pbxBanner.Name = "pbxBanner"
        Me.pbxBanner.Size = New System.Drawing.Size(776, 55)
        Me.pbxBanner.TabIndex = 68
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
        Me.btnConfirmar.Location = New System.Drawing.Point(562, 569)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(170, 50)
        Me.btnConfirmar.TabIndex = 22
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
        Me.btnAtualizar.Location = New System.Drawing.Point(386, 569)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(170, 50)
        Me.btnAtualizar.TabIndex = 23
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
        Me.btnExcluir.Location = New System.Drawing.Point(209, 569)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(170, 50)
        Me.btnExcluir.TabIndex = 24
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
        Me.btnCancelar.Location = New System.Drawing.Point(33, 569)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(170, 50)
        Me.btnCancelar.TabIndex = 25
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'frmConsulta_func
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(760, 625)
        Me.Controls.Add(Me.pbxBanner)
        Me.Controls.Add(Me.gpxDadosFunc)
        Me.Controls.Add(Me.gpxPesquisa)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmConsulta_func"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de funcionário"
        CType(Me.dgvFunc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxPesquisa.ResumeLayout(False)
        Me.gpxPesquisa.PerformLayout()
        Me.gpxDadosFunc.ResumeLayout(False)
        Me.gpxDadosFunc.PerformLayout()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvFunc As System.Windows.Forms.DataGridView
    Friend WithEvents lbBuscarPor As System.Windows.Forms.Label
    Friend WithEvents txtConsultaFunc As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lbTelefone As System.Windows.Forms.Label
    Friend WithEvents lbNome As System.Windows.Forms.Label
    Friend WithEvents lbDDD As System.Windows.Forms.Label
    Friend WithEvents lbCelular As System.Windows.Forms.Label
    Friend WithEvents lbDataCad As System.Windows.Forms.Label
    Friend WithEvents lbEmail As System.Windows.Forms.Label
    Friend WithEvents lbDataNasc As System.Windows.Forms.Label
    Friend WithEvents lbCPF As System.Windows.Forms.Label
    Friend WithEvents lbEndereco As System.Windows.Forms.Label
    Friend WithEvents lbSexo As System.Windows.Forms.Label
    Friend WithEvents lbCod As System.Windows.Forms.Label
    Friend WithEvents lbCidade As System.Windows.Forms.Label
    Friend WithEvents lbUF As System.Windows.Forms.Label
    Friend WithEvents lbNumero As System.Windows.Forms.Label
    Friend WithEvents lbCEP As System.Windows.Forms.Label
    Friend WithEvents lbCargo As System.Windows.Forms.Label
    Friend WithEvents lbBairro As System.Windows.Forms.Label
    Friend WithEvents lbLogin As System.Windows.Forms.Label
    Friend WithEvents txtCodFunc As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeFunc As System.Windows.Forms.TextBox
    Friend WithEvents MtxtDDDFunc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEmailFunc As System.Windows.Forms.TextBox
    Friend WithEvents MtxtCPFFunc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEndFunc As System.Windows.Forms.TextBox
    Friend WithEvents txtNumFunc As System.Windows.Forms.TextBox
    Friend WithEvents txtCidadeFunc As System.Windows.Forms.TextBox
    Friend WithEvents txtBairroFunc As System.Windows.Forms.TextBox
    Friend WithEvents MtxtCEPFunc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCargoFunc As System.Windows.Forms.TextBox
    Friend WithEvents txtLoginFunc As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents cmbUFFunc As System.Windows.Forms.ComboBox
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents cmbSexoFunc As System.Windows.Forms.ComboBox
    Friend WithEvents gpxPesquisa As System.Windows.Forms.GroupBox
    Friend WithEvents gpxDadosFunc As System.Windows.Forms.GroupBox
    Friend WithEvents MtxtDataCadFunc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtDataNascfunc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtCelFunc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtTelFunc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents pbxBanner As System.Windows.Forms.PictureBox
    Friend WithEvents cmbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents MtxtFiltroData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtFiltroCPF As System.Windows.Forms.MaskedTextBox
End Class
