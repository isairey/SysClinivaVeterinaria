<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsulta_cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsulta_cliente))
        Me.dgvCli = New System.Windows.Forms.DataGridView()
        Me.txtConsultaCli = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lbCod = New System.Windows.Forms.Label()
        Me.lbDDD = New System.Windows.Forms.Label()
        Me.lbTelefone = New System.Windows.Forms.Label()
        Me.lbNome = New System.Windows.Forms.Label()
        Me.lbCelular = New System.Windows.Forms.Label()
        Me.lbEmail = New System.Windows.Forms.Label()
        Me.lbDataNasc = New System.Windows.Forms.Label()
        Me.lbSexo = New System.Windows.Forms.Label()
        Me.lbCPF = New System.Windows.Forms.Label()
        Me.lbEndereco = New System.Windows.Forms.Label()
        Me.lbBairro = New System.Windows.Forms.Label()
        Me.lbUF = New System.Windows.Forms.Label()
        Me.lbCidade = New System.Windows.Forms.Label()
        Me.lbDataCad = New System.Windows.Forms.Label()
        Me.lbNumero = New System.Windows.Forms.Label()
        Me.lbRG = New System.Windows.Forms.Label()
        Me.lbCEP = New System.Windows.Forms.Label()
        Me.txtCodCli = New System.Windows.Forms.TextBox()
        Me.txtNomeCli = New System.Windows.Forms.TextBox()
        Me.MtxtDDDCli = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmailCli = New System.Windows.Forms.TextBox()
        Me.MtxtCPFCli = New System.Windows.Forms.MaskedTextBox()
        Me.txtRGCli = New System.Windows.Forms.TextBox()
        Me.txtEndCli = New System.Windows.Forms.TextBox()
        Me.txtNumCli = New System.Windows.Forms.TextBox()
        Me.txtCidadeCli = New System.Windows.Forms.TextBox()
        Me.txtBairroCli = New System.Windows.Forms.TextBox()
        Me.MtxtCEPCli = New System.Windows.Forms.MaskedTextBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.cmbSexoCli = New System.Windows.Forms.ComboBox()
        Me.cmbUFCli = New System.Windows.Forms.ComboBox()
        Me.MtxtDataNascCli = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtTelCli = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtCelCli = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtDataCadCli = New System.Windows.Forms.MaskedTextBox()
        Me.gpxPesquisa = New System.Windows.Forms.GroupBox()
        Me.MtxtFiltroCPF = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtFiltroData = New System.Windows.Forms.MaskedTextBox()
        Me.cmbFiltro = New System.Windows.Forms.ComboBox()
        Me.lbBuscarPor = New System.Windows.Forms.Label()
        Me.gpxCliente = New System.Windows.Forms.GroupBox()
        Me.pbxBanner = New System.Windows.Forms.PictureBox()
        CType(Me.dgvCli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxPesquisa.SuspendLayout()
        Me.gpxCliente.SuspendLayout()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCli
        '
        Me.dgvCli.AllowUserToAddRows = False
        Me.dgvCli.AllowUserToDeleteRows = False
        Me.dgvCli.AllowUserToResizeColumns = False
        Me.dgvCli.AllowUserToResizeRows = False
        Me.dgvCli.BackgroundColor = System.Drawing.Color.White
        Me.dgvCli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCli.Location = New System.Drawing.Point(20, 60)
        Me.dgvCli.MultiSelect = False
        Me.dgvCli.Name = "dgvCli"
        Me.dgvCli.ReadOnly = True
        Me.dgvCli.RowHeadersVisible = False
        Me.dgvCli.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvCli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCli.Size = New System.Drawing.Size(695, 140)
        Me.dgvCli.TabIndex = 17
        '
        'txtConsultaCli
        '
        Me.txtConsultaCli.Location = New System.Drawing.Point(220, 25)
        Me.txtConsultaCli.Name = "txtConsultaCli"
        Me.txtConsultaCli.Size = New System.Drawing.Size(152, 20)
        Me.txtConsultaCli.TabIndex = 1
        Me.txtConsultaCli.Visible = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(390, 23)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        Me.btnBuscar.Visible = False
        '
        'lbCod
        '
        Me.lbCod.AutoSize = True
        Me.lbCod.Location = New System.Drawing.Point(16, 22)
        Me.lbCod.Name = "lbCod"
        Me.lbCod.Size = New System.Drawing.Size(40, 13)
        Me.lbCod.TabIndex = 20
        Me.lbCod.Text = "Código"
        '
        'lbDDD
        '
        Me.lbDDD.AutoSize = True
        Me.lbDDD.Location = New System.Drawing.Point(509, 22)
        Me.lbDDD.Name = "lbDDD"
        Me.lbDDD.Size = New System.Drawing.Size(31, 13)
        Me.lbDDD.TabIndex = 21
        Me.lbDDD.Text = "DDD"
        '
        'lbTelefone
        '
        Me.lbTelefone.AutoSize = True
        Me.lbTelefone.Location = New System.Drawing.Point(584, 22)
        Me.lbTelefone.Name = "lbTelefone"
        Me.lbTelefone.Size = New System.Drawing.Size(49, 13)
        Me.lbTelefone.TabIndex = 22
        Me.lbTelefone.Text = "Telefone"
        '
        'lbNome
        '
        Me.lbNome.AutoSize = True
        Me.lbNome.Location = New System.Drawing.Point(126, 22)
        Me.lbNome.Name = "lbNome"
        Me.lbNome.Size = New System.Drawing.Size(35, 13)
        Me.lbNome.TabIndex = 23
        Me.lbNome.Text = "Nome"
        '
        'lbCelular
        '
        Me.lbCelular.AutoSize = True
        Me.lbCelular.Location = New System.Drawing.Point(17, 74)
        Me.lbCelular.Name = "lbCelular"
        Me.lbCelular.Size = New System.Drawing.Size(39, 13)
        Me.lbCelular.TabIndex = 24
        Me.lbCelular.Text = "Celular"
        '
        'lbEmail
        '
        Me.lbEmail.AutoSize = True
        Me.lbEmail.Location = New System.Drawing.Point(126, 74)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(32, 13)
        Me.lbEmail.TabIndex = 25
        Me.lbEmail.Text = "Email"
        '
        'lbDataNasc
        '
        Me.lbDataNasc.AutoSize = True
        Me.lbDataNasc.Location = New System.Drawing.Point(17, 125)
        Me.lbDataNasc.Name = "lbDataNasc"
        Me.lbDataNasc.Size = New System.Drawing.Size(89, 13)
        Me.lbDataNasc.TabIndex = 26
        Me.lbDataNasc.Text = "Data Nascimento"
        '
        'lbSexo
        '
        Me.lbSexo.AutoSize = True
        Me.lbSexo.Location = New System.Drawing.Point(509, 74)
        Me.lbSexo.Name = "lbSexo"
        Me.lbSexo.Size = New System.Drawing.Size(31, 13)
        Me.lbSexo.TabIndex = 27
        Me.lbSexo.Text = "Sexo"
        '
        'lbCPF
        '
        Me.lbCPF.AutoSize = True
        Me.lbCPF.Location = New System.Drawing.Point(151, 125)
        Me.lbCPF.Name = "lbCPF"
        Me.lbCPF.Size = New System.Drawing.Size(27, 13)
        Me.lbCPF.TabIndex = 28
        Me.lbCPF.Text = "CPF"
        '
        'lbEndereco
        '
        Me.lbEndereco.AutoSize = True
        Me.lbEndereco.Location = New System.Drawing.Point(17, 176)
        Me.lbEndereco.Name = "lbEndereco"
        Me.lbEndereco.Size = New System.Drawing.Size(53, 13)
        Me.lbEndereco.TabIndex = 29
        Me.lbEndereco.Text = "Endereço"
        '
        'lbBairro
        '
        Me.lbBairro.AutoSize = True
        Me.lbBairro.Location = New System.Drawing.Point(421, 232)
        Me.lbBairro.Name = "lbBairro"
        Me.lbBairro.Size = New System.Drawing.Size(34, 13)
        Me.lbBairro.TabIndex = 30
        Me.lbBairro.Text = "Bairro"
        '
        'lbUF
        '
        Me.lbUF.AutoSize = True
        Me.lbUF.Location = New System.Drawing.Point(328, 233)
        Me.lbUF.Name = "lbUF"
        Me.lbUF.Size = New System.Drawing.Size(21, 13)
        Me.lbUF.TabIndex = 31
        Me.lbUF.Text = "UF"
        '
        'lbCidade
        '
        Me.lbCidade.AutoSize = True
        Me.lbCidade.Location = New System.Drawing.Point(17, 233)
        Me.lbCidade.Name = "lbCidade"
        Me.lbCidade.Size = New System.Drawing.Size(40, 13)
        Me.lbCidade.TabIndex = 32
        Me.lbCidade.Text = "Cidade"
        '
        'lbDataCad
        '
        Me.lbDataCad.AutoSize = True
        Me.lbDataCad.Location = New System.Drawing.Point(509, 125)
        Me.lbDataCad.Name = "lbDataCad"
        Me.lbDataCad.Size = New System.Drawing.Size(75, 13)
        Me.lbDataCad.TabIndex = 33
        Me.lbDataCad.Text = "Data Cadastro"
        '
        'lbNumero
        '
        Me.lbNumero.AutoSize = True
        Me.lbNumero.Location = New System.Drawing.Point(421, 180)
        Me.lbNumero.Name = "lbNumero"
        Me.lbNumero.Size = New System.Drawing.Size(44, 13)
        Me.lbNumero.TabIndex = 34
        Me.lbNumero.Text = "Número"
        '
        'lbRG
        '
        Me.lbRG.AutoSize = True
        Me.lbRG.Location = New System.Drawing.Point(288, 125)
        Me.lbRG.Name = "lbRG"
        Me.lbRG.Size = New System.Drawing.Size(23, 13)
        Me.lbRG.TabIndex = 35
        Me.lbRG.Text = "RG"
        '
        'lbCEP
        '
        Me.lbCEP.AutoSize = True
        Me.lbCEP.Location = New System.Drawing.Point(17, 279)
        Me.lbCEP.Name = "lbCEP"
        Me.lbCEP.Size = New System.Drawing.Size(28, 13)
        Me.lbCEP.TabIndex = 36
        Me.lbCEP.Text = "CEP"
        '
        'txtCodCli
        '
        Me.txtCodCli.Enabled = False
        Me.txtCodCli.Location = New System.Drawing.Point(19, 38)
        Me.txtCodCli.Name = "txtCodCli"
        Me.txtCodCli.Size = New System.Drawing.Size(84, 20)
        Me.txtCodCli.TabIndex = 4
        '
        'txtNomeCli
        '
        Me.txtNomeCli.Enabled = False
        Me.txtNomeCli.Location = New System.Drawing.Point(129, 38)
        Me.txtNomeCli.Name = "txtNomeCli"
        Me.txtNomeCli.Size = New System.Drawing.Size(354, 20)
        Me.txtNomeCli.TabIndex = 5
        '
        'MtxtDDDCli
        '
        Me.MtxtDDDCli.Enabled = False
        Me.MtxtDDDCli.Location = New System.Drawing.Point(512, 38)
        Me.MtxtDDDCli.Mask = "(000)"
        Me.MtxtDDDCli.Name = "MtxtDDDCli"
        Me.MtxtDDDCli.Size = New System.Drawing.Size(33, 20)
        Me.MtxtDDDCli.TabIndex = 6
        '
        'txtEmailCli
        '
        Me.txtEmailCli.Enabled = False
        Me.txtEmailCli.Location = New System.Drawing.Point(129, 90)
        Me.txtEmailCli.Name = "txtEmailCli"
        Me.txtEmailCli.Size = New System.Drawing.Size(351, 20)
        Me.txtEmailCli.TabIndex = 9
        '
        'MtxtCPFCli
        '
        Me.MtxtCPFCli.Enabled = False
        Me.MtxtCPFCli.Location = New System.Drawing.Point(154, 141)
        Me.MtxtCPFCli.Mask = "000.000.000-00"
        Me.MtxtCPFCli.Name = "MtxtCPFCli"
        Me.MtxtCPFCli.Size = New System.Drawing.Size(100, 20)
        Me.MtxtCPFCli.TabIndex = 12
        '
        'txtRGCli
        '
        Me.txtRGCli.Enabled = False
        Me.txtRGCli.Location = New System.Drawing.Point(291, 141)
        Me.txtRGCli.Name = "txtRGCli"
        Me.txtRGCli.Size = New System.Drawing.Size(189, 20)
        Me.txtRGCli.TabIndex = 13
        '
        'txtEndCli
        '
        Me.txtEndCli.Enabled = False
        Me.txtEndCli.Location = New System.Drawing.Point(19, 196)
        Me.txtEndCli.Name = "txtEndCli"
        Me.txtEndCli.Size = New System.Drawing.Size(365, 20)
        Me.txtEndCli.TabIndex = 15
        '
        'txtNumCli
        '
        Me.txtNumCli.Enabled = False
        Me.txtNumCli.Location = New System.Drawing.Point(424, 196)
        Me.txtNumCli.Name = "txtNumCli"
        Me.txtNumCli.Size = New System.Drawing.Size(62, 20)
        Me.txtNumCli.TabIndex = 16
        '
        'txtCidadeCli
        '
        Me.txtCidadeCli.Enabled = False
        Me.txtCidadeCli.Location = New System.Drawing.Point(19, 249)
        Me.txtCidadeCli.Name = "txtCidadeCli"
        Me.txtCidadeCli.Size = New System.Drawing.Size(282, 20)
        Me.txtCidadeCli.TabIndex = 17
        '
        'txtBairroCli
        '
        Me.txtBairroCli.Enabled = False
        Me.txtBairroCli.Location = New System.Drawing.Point(424, 248)
        Me.txtBairroCli.Name = "txtBairroCli"
        Me.txtBairroCli.Size = New System.Drawing.Size(249, 20)
        Me.txtBairroCli.TabIndex = 19
        '
        'MtxtCEPCli
        '
        Me.MtxtCEPCli.Enabled = False
        Me.MtxtCEPCli.Location = New System.Drawing.Point(19, 293)
        Me.MtxtCEPCli.Mask = "00000-000"
        Me.MtxtCEPCli.Name = "MtxtCEPCli"
        Me.MtxtCEPCli.Size = New System.Drawing.Size(60, 20)
        Me.MtxtCEPCli.TabIndex = 20
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
        Me.btnConfirmar.Location = New System.Drawing.Point(558, 628)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(170, 50)
        Me.btnConfirmar.TabIndex = 21
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
        Me.btnAtualizar.Location = New System.Drawing.Point(382, 628)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(170, 50)
        Me.btnAtualizar.TabIndex = 22
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
        Me.btnExcluir.Location = New System.Drawing.Point(206, 628)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(170, 50)
        Me.btnExcluir.TabIndex = 23
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
        Me.btnCancelar.Location = New System.Drawing.Point(30, 628)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(170, 50)
        Me.btnCancelar.TabIndex = 24
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'cmbSexoCli
        '
        Me.cmbSexoCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexoCli.Enabled = False
        Me.cmbSexoCli.FormattingEnabled = True
        Me.cmbSexoCli.Location = New System.Drawing.Point(512, 89)
        Me.cmbSexoCli.Name = "cmbSexoCli"
        Me.cmbSexoCli.Size = New System.Drawing.Size(100, 21)
        Me.cmbSexoCli.TabIndex = 10
        '
        'cmbUFCli
        '
        Me.cmbUFCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUFCli.Enabled = False
        Me.cmbUFCli.FormattingEnabled = True
        Me.cmbUFCli.Location = New System.Drawing.Point(331, 247)
        Me.cmbUFCli.Name = "cmbUFCli"
        Me.cmbUFCli.Size = New System.Drawing.Size(53, 21)
        Me.cmbUFCli.TabIndex = 18
        '
        'MtxtDataNascCli
        '
        Me.MtxtDataNascCli.Enabled = False
        Me.MtxtDataNascCli.Location = New System.Drawing.Point(20, 141)
        Me.MtxtDataNascCli.Mask = "00/00/0000"
        Me.MtxtDataNascCli.Name = "MtxtDataNascCli"
        Me.MtxtDataNascCli.Size = New System.Drawing.Size(73, 20)
        Me.MtxtDataNascCli.TabIndex = 11
        Me.MtxtDataNascCli.ValidatingType = GetType(Date)
        '
        'MtxtTelCli
        '
        Me.MtxtTelCli.Enabled = False
        Me.MtxtTelCli.Location = New System.Drawing.Point(587, 38)
        Me.MtxtTelCli.Mask = "0000-0000"
        Me.MtxtTelCli.Name = "MtxtTelCli"
        Me.MtxtTelCli.Size = New System.Drawing.Size(57, 20)
        Me.MtxtTelCli.TabIndex = 7
        '
        'MtxtCelCli
        '
        Me.MtxtCelCli.Enabled = False
        Me.MtxtCelCli.Location = New System.Drawing.Point(19, 90)
        Me.MtxtCelCli.Mask = "0000-0000"
        Me.MtxtCelCli.Name = "MtxtCelCli"
        Me.MtxtCelCli.Size = New System.Drawing.Size(60, 20)
        Me.MtxtCelCli.TabIndex = 8
        '
        'MtxtDataCadCli
        '
        Me.MtxtDataCadCli.Enabled = False
        Me.MtxtDataCadCli.Location = New System.Drawing.Point(512, 141)
        Me.MtxtDataCadCli.Mask = "00/00/0000"
        Me.MtxtDataCadCli.Name = "MtxtDataCadCli"
        Me.MtxtDataCadCli.Size = New System.Drawing.Size(73, 20)
        Me.MtxtDataCadCli.TabIndex = 14
        Me.MtxtDataCadCli.ValidatingType = GetType(Date)
        '
        'gpxPesquisa
        '
        Me.gpxPesquisa.Controls.Add(Me.MtxtFiltroCPF)
        Me.gpxPesquisa.Controls.Add(Me.MtxtFiltroData)
        Me.gpxPesquisa.Controls.Add(Me.cmbFiltro)
        Me.gpxPesquisa.Controls.Add(Me.lbBuscarPor)
        Me.gpxPesquisa.Controls.Add(Me.dgvCli)
        Me.gpxPesquisa.Controls.Add(Me.txtConsultaCli)
        Me.gpxPesquisa.Controls.Add(Me.btnBuscar)
        Me.gpxPesquisa.Location = New System.Drawing.Point(15, 61)
        Me.gpxPesquisa.Name = "gpxPesquisa"
        Me.gpxPesquisa.Size = New System.Drawing.Size(734, 211)
        Me.gpxPesquisa.TabIndex = 72
        Me.gpxPesquisa.TabStop = False
        Me.gpxPesquisa.Text = "Dados da pesquisa"
        '
        'MtxtFiltroCPF
        '
        Me.MtxtFiltroCPF.Location = New System.Drawing.Point(220, 25)
        Me.MtxtFiltroCPF.Mask = "000.000.000-00"
        Me.MtxtFiltroCPF.Name = "MtxtFiltroCPF"
        Me.MtxtFiltroCPF.Size = New System.Drawing.Size(100, 20)
        Me.MtxtFiltroCPF.TabIndex = 26
        Me.MtxtFiltroCPF.Visible = False
        '
        'MtxtFiltroData
        '
        Me.MtxtFiltroData.Location = New System.Drawing.Point(220, 25)
        Me.MtxtFiltroData.Mask = "00/00/0000"
        Me.MtxtFiltroData.Name = "MtxtFiltroData"
        Me.MtxtFiltroData.Size = New System.Drawing.Size(72, 20)
        Me.MtxtFiltroData.TabIndex = 25
        Me.MtxtFiltroData.ValidatingType = GetType(Date)
        Me.MtxtFiltroData.Visible = False
        '
        'cmbFiltro
        '
        Me.cmbFiltro.FormattingEnabled = True
        Me.cmbFiltro.Location = New System.Drawing.Point(85, 25)
        Me.cmbFiltro.Name = "cmbFiltro"
        Me.cmbFiltro.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltro.TabIndex = 24
        '
        'lbBuscarPor
        '
        Me.lbBuscarPor.AutoSize = True
        Me.lbBuscarPor.Location = New System.Drawing.Point(18, 30)
        Me.lbBuscarPor.Name = "lbBuscarPor"
        Me.lbBuscarPor.Size = New System.Drawing.Size(61, 13)
        Me.lbBuscarPor.TabIndex = 23
        Me.lbBuscarPor.Text = "Buscar por:"
        '
        'gpxCliente
        '
        Me.gpxCliente.Controls.Add(Me.txtCodCli)
        Me.gpxCliente.Controls.Add(Me.lbCod)
        Me.gpxCliente.Controls.Add(Me.MtxtDataCadCli)
        Me.gpxCliente.Controls.Add(Me.lbDDD)
        Me.gpxCliente.Controls.Add(Me.MtxtCelCli)
        Me.gpxCliente.Controls.Add(Me.lbTelefone)
        Me.gpxCliente.Controls.Add(Me.MtxtTelCli)
        Me.gpxCliente.Controls.Add(Me.lbNome)
        Me.gpxCliente.Controls.Add(Me.MtxtDataNascCli)
        Me.gpxCliente.Controls.Add(Me.lbCelular)
        Me.gpxCliente.Controls.Add(Me.cmbUFCli)
        Me.gpxCliente.Controls.Add(Me.lbEmail)
        Me.gpxCliente.Controls.Add(Me.cmbSexoCli)
        Me.gpxCliente.Controls.Add(Me.lbDataNasc)
        Me.gpxCliente.Controls.Add(Me.lbSexo)
        Me.gpxCliente.Controls.Add(Me.lbCPF)
        Me.gpxCliente.Controls.Add(Me.lbEndereco)
        Me.gpxCliente.Controls.Add(Me.lbBairro)
        Me.gpxCliente.Controls.Add(Me.MtxtCEPCli)
        Me.gpxCliente.Controls.Add(Me.lbUF)
        Me.gpxCliente.Controls.Add(Me.txtBairroCli)
        Me.gpxCliente.Controls.Add(Me.lbCidade)
        Me.gpxCliente.Controls.Add(Me.txtCidadeCli)
        Me.gpxCliente.Controls.Add(Me.lbDataCad)
        Me.gpxCliente.Controls.Add(Me.txtNumCli)
        Me.gpxCliente.Controls.Add(Me.lbNumero)
        Me.gpxCliente.Controls.Add(Me.txtEndCli)
        Me.gpxCliente.Controls.Add(Me.lbRG)
        Me.gpxCliente.Controls.Add(Me.txtRGCli)
        Me.gpxCliente.Controls.Add(Me.lbCEP)
        Me.gpxCliente.Controls.Add(Me.MtxtCPFCli)
        Me.gpxCliente.Controls.Add(Me.txtNomeCli)
        Me.gpxCliente.Controls.Add(Me.txtEmailCli)
        Me.gpxCliente.Controls.Add(Me.MtxtDDDCli)
        Me.gpxCliente.Location = New System.Drawing.Point(15, 290)
        Me.gpxCliente.Name = "gpxCliente"
        Me.gpxCliente.Size = New System.Drawing.Size(734, 330)
        Me.gpxCliente.TabIndex = 3
        Me.gpxCliente.TabStop = False
        Me.gpxCliente.Text = "Dados do cliente"
        '
        'pbxBanner
        '
        Me.pbxBanner.BackgroundImage = Global.sistechy.My.Resources.Resources.banner_consulta_cliente_fw
        Me.pbxBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxBanner.Location = New System.Drawing.Point(-5, -2)
        Me.pbxBanner.Name = "pbxBanner"
        Me.pbxBanner.Size = New System.Drawing.Size(769, 55)
        Me.pbxBanner.TabIndex = 73
        Me.pbxBanner.TabStop = False
        '
        'frmConsulta_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(758, 690)
        Me.Controls.Add(Me.pbxBanner)
        Me.Controls.Add(Me.gpxCliente)
        Me.Controls.Add(Me.gpxPesquisa)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmConsulta_cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de cliente"
        CType(Me.dgvCli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxPesquisa.ResumeLayout(False)
        Me.gpxPesquisa.PerformLayout()
        Me.gpxCliente.ResumeLayout(False)
        Me.gpxCliente.PerformLayout()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvCli As System.Windows.Forms.DataGridView
    Friend WithEvents txtConsultaCli As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lbCod As System.Windows.Forms.Label
    Friend WithEvents lbDDD As System.Windows.Forms.Label
    Friend WithEvents lbTelefone As System.Windows.Forms.Label
    Friend WithEvents lbNome As System.Windows.Forms.Label
    Friend WithEvents lbCelular As System.Windows.Forms.Label
    Friend WithEvents lbEmail As System.Windows.Forms.Label
    Friend WithEvents lbDataNasc As System.Windows.Forms.Label
    Friend WithEvents lbSexo As System.Windows.Forms.Label
    Friend WithEvents lbCPF As System.Windows.Forms.Label
    Friend WithEvents lbEndereco As System.Windows.Forms.Label
    Friend WithEvents lbBairro As System.Windows.Forms.Label
    Friend WithEvents lbUF As System.Windows.Forms.Label
    Friend WithEvents lbCidade As System.Windows.Forms.Label
    Friend WithEvents lbDataCad As System.Windows.Forms.Label
    Friend WithEvents lbNumero As System.Windows.Forms.Label
    Friend WithEvents lbRG As System.Windows.Forms.Label
    Friend WithEvents lbCEP As System.Windows.Forms.Label
    Friend WithEvents txtCodCli As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeCli As System.Windows.Forms.TextBox
    Friend WithEvents MtxtDDDCli As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEmailCli As System.Windows.Forms.TextBox
    Friend WithEvents MtxtCPFCli As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtRGCli As System.Windows.Forms.TextBox
    Friend WithEvents txtEndCli As System.Windows.Forms.TextBox
    Friend WithEvents txtNumCli As System.Windows.Forms.TextBox
    Friend WithEvents txtCidadeCli As System.Windows.Forms.TextBox
    Friend WithEvents txtBairroCli As System.Windows.Forms.TextBox
    Friend WithEvents MtxtCEPCli As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents cmbSexoCli As System.Windows.Forms.ComboBox
    Friend WithEvents cmbUFCli As System.Windows.Forms.ComboBox
    Friend WithEvents MtxtDataNascCli As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtTelCli As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtCelCli As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtDataCadCli As System.Windows.Forms.MaskedTextBox
    Friend WithEvents gpxPesquisa As System.Windows.Forms.GroupBox
    Friend WithEvents gpxCliente As System.Windows.Forms.GroupBox
    Friend WithEvents pbxBanner As System.Windows.Forms.PictureBox
    Friend WithEvents MtxtFiltroData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents lbBuscarPor As System.Windows.Forms.Label
    Friend WithEvents MtxtFiltroCPF As System.Windows.Forms.MaskedTextBox
End Class
