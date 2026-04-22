<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsulta_forne
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsulta_forne))
        Me.txtConsultaForne = New System.Windows.Forms.TextBox()
        Me.lbBuscarPor = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtNomeFantForne = New System.Windows.Forms.TextBox()
        Me.txtEmailForne = New System.Windows.Forms.TextBox()
        Me.txtRazaoSocialForne = New System.Windows.Forms.TextBox()
        Me.MtxtDDDForne = New System.Windows.Forms.MaskedTextBox()
        Me.txtCNPJForne = New System.Windows.Forms.TextBox()
        Me.txtEndForne = New System.Windows.Forms.TextBox()
        Me.txtCodForne = New System.Windows.Forms.TextBox()
        Me.lbCNPJ = New System.Windows.Forms.Label()
        Me.lbCod = New System.Windows.Forms.Label()
        Me.lbEmail = New System.Windows.Forms.Label()
        Me.lbDDD = New System.Windows.Forms.Label()
        Me.lbTelefone = New System.Windows.Forms.Label()
        Me.lbRazaoSocial = New System.Windows.Forms.Label()
        Me.lbEndereco = New System.Windows.Forms.Label()
        Me.lbBairro = New System.Windows.Forms.Label()
        Me.txtBairroForne = New System.Windows.Forms.TextBox()
        Me.lbNumero = New System.Windows.Forms.Label()
        Me.lbCidade = New System.Windows.Forms.Label()
        Me.lbUF = New System.Windows.Forms.Label()
        Me.txtNumForne = New System.Windows.Forms.TextBox()
        Me.txtCidadeForne = New System.Windows.Forms.TextBox()
        Me.cmbUFForne = New System.Windows.Forms.ComboBox()
        Me.gpxPesquisa = New System.Windows.Forms.GroupBox()
        Me.cmbFiltro = New System.Windows.Forms.ComboBox()
        Me.dgvForne = New System.Windows.Forms.DataGridView()
        Me.gpxFornecedor = New System.Windows.Forms.GroupBox()
        Me.MtxtTelForne = New System.Windows.Forms.MaskedTextBox()
        Me.lbNomeFantasia = New System.Windows.Forms.Label()
        Me.pbxBanner = New System.Windows.Forms.PictureBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gpxPesquisa.SuspendLayout()
        CType(Me.dgvForne, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxFornecedor.SuspendLayout()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtConsultaForne
        '
        Me.txtConsultaForne.Location = New System.Drawing.Point(219, 24)
        Me.txtConsultaForne.Name = "txtConsultaForne"
        Me.txtConsultaForne.Size = New System.Drawing.Size(266, 20)
        Me.txtConsultaForne.TabIndex = 1
        Me.txtConsultaForne.Visible = False
        '
        'lbBuscarPor
        '
        Me.lbBuscarPor.AutoSize = True
        Me.lbBuscarPor.Location = New System.Drawing.Point(15, 26)
        Me.lbBuscarPor.Name = "lbBuscarPor"
        Me.lbBuscarPor.Size = New System.Drawing.Size(61, 13)
        Me.lbBuscarPor.TabIndex = 1
        Me.lbBuscarPor.Text = "Buscar por:"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(506, 22)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        Me.btnBuscar.Visible = False
        '
        'txtNomeFantForne
        '
        Me.txtNomeFantForne.Enabled = False
        Me.txtNomeFantForne.Location = New System.Drawing.Point(159, 40)
        Me.txtNomeFantForne.Name = "txtNomeFantForne"
        Me.txtNomeFantForne.Size = New System.Drawing.Size(422, 20)
        Me.txtNomeFantForne.TabIndex = 5
        '
        'txtEmailForne
        '
        Me.txtEmailForne.Enabled = False
        Me.txtEmailForne.Location = New System.Drawing.Point(233, 149)
        Me.txtEmailForne.Name = "txtEmailForne"
        Me.txtEmailForne.Size = New System.Drawing.Size(379, 20)
        Me.txtEmailForne.TabIndex = 10
        '
        'txtRazaoSocialForne
        '
        Me.txtRazaoSocialForne.Enabled = False
        Me.txtRazaoSocialForne.Location = New System.Drawing.Point(26, 96)
        Me.txtRazaoSocialForne.Name = "txtRazaoSocialForne"
        Me.txtRazaoSocialForne.Size = New System.Drawing.Size(422, 20)
        Me.txtRazaoSocialForne.TabIndex = 6
        '
        'MtxtDDDForne
        '
        Me.MtxtDDDForne.Enabled = False
        Me.MtxtDDDForne.Location = New System.Drawing.Point(26, 149)
        Me.MtxtDDDForne.Mask = "(000)"
        Me.MtxtDDDForne.Name = "MtxtDDDForne"
        Me.MtxtDDDForne.Size = New System.Drawing.Size(31, 20)
        Me.MtxtDDDForne.TabIndex = 8
        '
        'txtCNPJForne
        '
        Me.txtCNPJForne.Enabled = False
        Me.txtCNPJForne.Location = New System.Drawing.Point(484, 96)
        Me.txtCNPJForne.Name = "txtCNPJForne"
        Me.txtCNPJForne.Size = New System.Drawing.Size(138, 20)
        Me.txtCNPJForne.TabIndex = 7
        '
        'txtEndForne
        '
        Me.txtEndForne.Enabled = False
        Me.txtEndForne.Location = New System.Drawing.Point(23, 200)
        Me.txtEndForne.Name = "txtEndForne"
        Me.txtEndForne.Size = New System.Drawing.Size(437, 20)
        Me.txtEndForne.TabIndex = 11
        '
        'txtCodForne
        '
        Me.txtCodForne.Enabled = False
        Me.txtCodForne.Location = New System.Drawing.Point(26, 40)
        Me.txtCodForne.Name = "txtCodForne"
        Me.txtCodForne.Size = New System.Drawing.Size(82, 20)
        Me.txtCodForne.TabIndex = 4
        '
        'lbCNPJ
        '
        Me.lbCNPJ.AutoSize = True
        Me.lbCNPJ.Location = New System.Drawing.Point(481, 78)
        Me.lbCNPJ.Name = "lbCNPJ"
        Me.lbCNPJ.Size = New System.Drawing.Size(34, 13)
        Me.lbCNPJ.TabIndex = 18
        Me.lbCNPJ.Text = "CNPJ"
        '
        'lbCod
        '
        Me.lbCod.AutoSize = True
        Me.lbCod.Location = New System.Drawing.Point(23, 24)
        Me.lbCod.Name = "lbCod"
        Me.lbCod.Size = New System.Drawing.Size(40, 13)
        Me.lbCod.TabIndex = 19
        Me.lbCod.Text = "Código"
        '
        'lbEmail
        '
        Me.lbEmail.AutoSize = True
        Me.lbEmail.Location = New System.Drawing.Point(230, 133)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(32, 13)
        Me.lbEmail.TabIndex = 20
        Me.lbEmail.Text = "Email"
        '
        'lbDDD
        '
        Me.lbDDD.AutoSize = True
        Me.lbDDD.Location = New System.Drawing.Point(23, 133)
        Me.lbDDD.Name = "lbDDD"
        Me.lbDDD.Size = New System.Drawing.Size(31, 13)
        Me.lbDDD.TabIndex = 21
        Me.lbDDD.Text = "DDD"
        '
        'lbTelefone
        '
        Me.lbTelefone.AutoSize = True
        Me.lbTelefone.Location = New System.Drawing.Point(107, 133)
        Me.lbTelefone.Name = "lbTelefone"
        Me.lbTelefone.Size = New System.Drawing.Size(49, 13)
        Me.lbTelefone.TabIndex = 22
        Me.lbTelefone.Text = "Telefone"
        '
        'lbRazaoSocial
        '
        Me.lbRazaoSocial.AutoSize = True
        Me.lbRazaoSocial.Location = New System.Drawing.Point(23, 78)
        Me.lbRazaoSocial.Name = "lbRazaoSocial"
        Me.lbRazaoSocial.Size = New System.Drawing.Size(70, 13)
        Me.lbRazaoSocial.TabIndex = 23
        Me.lbRazaoSocial.Text = "Razão Social"
        '
        'lbEndereco
        '
        Me.lbEndereco.AutoSize = True
        Me.lbEndereco.Location = New System.Drawing.Point(23, 184)
        Me.lbEndereco.Name = "lbEndereco"
        Me.lbEndereco.Size = New System.Drawing.Size(53, 13)
        Me.lbEndereco.TabIndex = 24
        Me.lbEndereco.Text = "Endereço"
        '
        'lbBairro
        '
        Me.lbBairro.AutoSize = True
        Me.lbBairro.Location = New System.Drawing.Point(494, 184)
        Me.lbBairro.Name = "lbBairro"
        Me.lbBairro.Size = New System.Drawing.Size(34, 13)
        Me.lbBairro.TabIndex = 25
        Me.lbBairro.Text = "Bairro"
        '
        'txtBairroForne
        '
        Me.txtBairroForne.Enabled = False
        Me.txtBairroForne.Location = New System.Drawing.Point(497, 200)
        Me.txtBairroForne.Name = "txtBairroForne"
        Me.txtBairroForne.Size = New System.Drawing.Size(198, 20)
        Me.txtBairroForne.TabIndex = 12
        '
        'lbNumero
        '
        Me.lbNumero.AutoSize = True
        Me.lbNumero.Location = New System.Drawing.Point(23, 235)
        Me.lbNumero.Name = "lbNumero"
        Me.lbNumero.Size = New System.Drawing.Size(44, 13)
        Me.lbNumero.TabIndex = 27
        Me.lbNumero.Text = "Número"
        '
        'lbCidade
        '
        Me.lbCidade.AutoSize = True
        Me.lbCidade.Location = New System.Drawing.Point(127, 235)
        Me.lbCidade.Name = "lbCidade"
        Me.lbCidade.Size = New System.Drawing.Size(40, 13)
        Me.lbCidade.TabIndex = 28
        Me.lbCidade.Text = "Cidade"
        '
        'lbUF
        '
        Me.lbUF.AutoSize = True
        Me.lbUF.Location = New System.Drawing.Point(401, 235)
        Me.lbUF.Name = "lbUF"
        Me.lbUF.Size = New System.Drawing.Size(21, 13)
        Me.lbUF.TabIndex = 29
        Me.lbUF.Text = "UF"
        '
        'txtNumForne
        '
        Me.txtNumForne.Enabled = False
        Me.txtNumForne.Location = New System.Drawing.Point(23, 251)
        Me.txtNumForne.Name = "txtNumForne"
        Me.txtNumForne.Size = New System.Drawing.Size(75, 20)
        Me.txtNumForne.TabIndex = 13
        '
        'txtCidadeForne
        '
        Me.txtCidadeForne.Enabled = False
        Me.txtCidadeForne.Location = New System.Drawing.Point(130, 251)
        Me.txtCidadeForne.Name = "txtCidadeForne"
        Me.txtCidadeForne.Size = New System.Drawing.Size(243, 20)
        Me.txtCidadeForne.TabIndex = 14
        '
        'cmbUFForne
        '
        Me.cmbUFForne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUFForne.Enabled = False
        Me.cmbUFForne.FormattingEnabled = True
        Me.cmbUFForne.Location = New System.Drawing.Point(404, 250)
        Me.cmbUFForne.Name = "cmbUFForne"
        Me.cmbUFForne.Size = New System.Drawing.Size(44, 21)
        Me.cmbUFForne.TabIndex = 15
        '
        'gpxPesquisa
        '
        Me.gpxPesquisa.Controls.Add(Me.cmbFiltro)
        Me.gpxPesquisa.Controls.Add(Me.dgvForne)
        Me.gpxPesquisa.Controls.Add(Me.txtConsultaForne)
        Me.gpxPesquisa.Controls.Add(Me.lbBuscarPor)
        Me.gpxPesquisa.Controls.Add(Me.btnBuscar)
        Me.gpxPesquisa.Location = New System.Drawing.Point(16, 62)
        Me.gpxPesquisa.Name = "gpxPesquisa"
        Me.gpxPesquisa.Size = New System.Drawing.Size(730, 218)
        Me.gpxPesquisa.TabIndex = 68
        Me.gpxPesquisa.TabStop = False
        Me.gpxPesquisa.Text = "Dados da pesquisa"
        '
        'cmbFiltro
        '
        Me.cmbFiltro.FormattingEnabled = True
        Me.cmbFiltro.Location = New System.Drawing.Point(82, 23)
        Me.cmbFiltro.Name = "cmbFiltro"
        Me.cmbFiltro.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltro.TabIndex = 25
        '
        'dgvForne
        '
        Me.dgvForne.AllowUserToAddRows = False
        Me.dgvForne.AllowUserToDeleteRows = False
        Me.dgvForne.AllowUserToResizeColumns = False
        Me.dgvForne.AllowUserToResizeRows = False
        Me.dgvForne.BackgroundColor = System.Drawing.Color.White
        Me.dgvForne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvForne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvForne.Location = New System.Drawing.Point(17, 57)
        Me.dgvForne.MultiSelect = False
        Me.dgvForne.Name = "dgvForne"
        Me.dgvForne.ReadOnly = True
        Me.dgvForne.RowHeadersVisible = False
        Me.dgvForne.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvForne.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvForne.Size = New System.Drawing.Size(695, 140)
        Me.dgvForne.TabIndex = 5
        '
        'gpxFornecedor
        '
        Me.gpxFornecedor.Controls.Add(Me.MtxtTelForne)
        Me.gpxFornecedor.Controls.Add(Me.txtNumForne)
        Me.gpxFornecedor.Controls.Add(Me.txtCodForne)
        Me.gpxFornecedor.Controls.Add(Me.lbNumero)
        Me.gpxFornecedor.Controls.Add(Me.txtNomeFantForne)
        Me.gpxFornecedor.Controls.Add(Me.lbCod)
        Me.gpxFornecedor.Controls.Add(Me.lbEmail)
        Me.gpxFornecedor.Controls.Add(Me.lbNomeFantasia)
        Me.gpxFornecedor.Controls.Add(Me.lbCidade)
        Me.gpxFornecedor.Controls.Add(Me.txtBairroForne)
        Me.gpxFornecedor.Controls.Add(Me.lbCNPJ)
        Me.gpxFornecedor.Controls.Add(Me.txtEmailForne)
        Me.gpxFornecedor.Controls.Add(Me.lbDDD)
        Me.gpxFornecedor.Controls.Add(Me.lbUF)
        Me.gpxFornecedor.Controls.Add(Me.txtRazaoSocialForne)
        Me.gpxFornecedor.Controls.Add(Me.lbBairro)
        Me.gpxFornecedor.Controls.Add(Me.lbTelefone)
        Me.gpxFornecedor.Controls.Add(Me.cmbUFForne)
        Me.gpxFornecedor.Controls.Add(Me.txtEndForne)
        Me.gpxFornecedor.Controls.Add(Me.lbEndereco)
        Me.gpxFornecedor.Controls.Add(Me.MtxtDDDForne)
        Me.gpxFornecedor.Controls.Add(Me.lbRazaoSocial)
        Me.gpxFornecedor.Controls.Add(Me.txtCidadeForne)
        Me.gpxFornecedor.Controls.Add(Me.txtCNPJForne)
        Me.gpxFornecedor.Location = New System.Drawing.Point(16, 303)
        Me.gpxFornecedor.Name = "gpxFornecedor"
        Me.gpxFornecedor.Size = New System.Drawing.Size(730, 306)
        Me.gpxFornecedor.TabIndex = 3
        Me.gpxFornecedor.TabStop = False
        Me.gpxFornecedor.Text = "Dados do fornecedor"
        '
        'MtxtTelForne
        '
        Me.MtxtTelForne.Enabled = False
        Me.MtxtTelForne.Location = New System.Drawing.Point(110, 149)
        Me.MtxtTelForne.Mask = "0000-0000"
        Me.MtxtTelForne.Name = "MtxtTelForne"
        Me.MtxtTelForne.Size = New System.Drawing.Size(57, 20)
        Me.MtxtTelForne.TabIndex = 9
        '
        'lbNomeFantasia
        '
        Me.lbNomeFantasia.AutoSize = True
        Me.lbNomeFantasia.Location = New System.Drawing.Point(156, 24)
        Me.lbNomeFantasia.Name = "lbNomeFantasia"
        Me.lbNomeFantasia.Size = New System.Drawing.Size(78, 13)
        Me.lbNomeFantasia.TabIndex = 17
        Me.lbNomeFantasia.Text = "Nome Fantasia"
        '
        'pbxBanner
        '
        Me.pbxBanner.BackgroundImage = Global.sistechy.My.Resources.Resources.banner_consulta_fornecedor_fw
        Me.pbxBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxBanner.Location = New System.Drawing.Point(-5, -2)
        Me.pbxBanner.Name = "pbxBanner"
        Me.pbxBanner.Size = New System.Drawing.Size(776, 55)
        Me.pbxBanner.TabIndex = 69
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
        Me.btnConfirmar.Location = New System.Drawing.Point(561, 620)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(170, 50)
        Me.btnConfirmar.TabIndex = 16
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
        Me.btnAtualizar.Location = New System.Drawing.Point(385, 620)
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
        Me.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Location = New System.Drawing.Point(209, 620)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(170, 50)
        Me.btnExcluir.TabIndex = 18
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
        Me.btnCancelar.Location = New System.Drawing.Point(33, 620)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(170, 50)
        Me.btnCancelar.TabIndex = 19
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'frmConsulta_forne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(758, 681)
        Me.Controls.Add(Me.pbxBanner)
        Me.Controls.Add(Me.gpxFornecedor)
        Me.Controls.Add(Me.gpxPesquisa)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmConsulta_forne"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de fornecedor"
        Me.gpxPesquisa.ResumeLayout(False)
        Me.gpxPesquisa.PerformLayout()
        CType(Me.dgvForne, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxFornecedor.ResumeLayout(False)
        Me.gpxFornecedor.PerformLayout()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtConsultaForne As System.Windows.Forms.TextBox
    Friend WithEvents lbBuscarPor As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtNomeFantForne As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailForne As System.Windows.Forms.TextBox
    Friend WithEvents txtRazaoSocialForne As System.Windows.Forms.TextBox
    Friend WithEvents MtxtDDDForne As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCNPJForne As System.Windows.Forms.TextBox
    Friend WithEvents txtEndForne As System.Windows.Forms.TextBox
    Friend WithEvents txtCodForne As System.Windows.Forms.TextBox
    Friend WithEvents lbCNPJ As System.Windows.Forms.Label
    Friend WithEvents lbCod As System.Windows.Forms.Label
    Friend WithEvents lbEmail As System.Windows.Forms.Label
    Friend WithEvents lbDDD As System.Windows.Forms.Label
    Friend WithEvents lbTelefone As System.Windows.Forms.Label
    Friend WithEvents lbRazaoSocial As System.Windows.Forms.Label
    Friend WithEvents lbEndereco As System.Windows.Forms.Label
    Friend WithEvents lbBairro As System.Windows.Forms.Label
    Friend WithEvents txtBairroForne As System.Windows.Forms.TextBox
    Friend WithEvents lbNumero As System.Windows.Forms.Label
    Friend WithEvents lbCidade As System.Windows.Forms.Label
    Friend WithEvents lbUF As System.Windows.Forms.Label
    Friend WithEvents txtNumForne As System.Windows.Forms.TextBox
    Friend WithEvents txtCidadeForne As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents cmbUFForne As System.Windows.Forms.ComboBox
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents gpxPesquisa As System.Windows.Forms.GroupBox
    Friend WithEvents dgvForne As System.Windows.Forms.DataGridView
    Friend WithEvents gpxFornecedor As System.Windows.Forms.GroupBox
    Friend WithEvents MtxtTelForne As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbNomeFantasia As System.Windows.Forms.Label
    Friend WithEvents pbxBanner As System.Windows.Forms.PictureBox
    Friend WithEvents cmbFiltro As System.Windows.Forms.ComboBox
End Class
