<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVacinacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVacinacao))
        Me.MtxtDataVacina = New System.Windows.Forms.MaskedTextBox()
        Me.txtConsultaAnimal = New System.Windows.Forms.TextBox()
        Me.lbCodAnimal = New System.Windows.Forms.Label()
        Me.lbCodFunc = New System.Windows.Forms.Label()
        Me.txtConsultaFunc = New System.Windows.Forms.TextBox()
        Me.lbVacina = New System.Windows.Forms.Label()
        Me.txtConsultaVacina = New System.Windows.Forms.TextBox()
        Me.dgvFunc = New System.Windows.Forms.DataGridView()
        Me.dgvAnimal = New System.Windows.Forms.DataGridView()
        Me.btnBuscaFunc = New System.Windows.Forms.Button()
        Me.btnBuscaAnimal = New System.Windows.Forms.Button()
        Me.btnBuscaVacina = New System.Windows.Forms.Button()
        Me.lbDataVacinacao = New System.Windows.Forms.Label()
        Me.BtnSalvarVacinacao = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gpxVacinacao = New System.Windows.Forms.GroupBox()
        Me.cmbFiltroVacina = New System.Windows.Forms.ComboBox()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.txtCodVacinacao = New System.Windows.Forms.TextBox()
        Me.txtCodItem = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.dgvItensVacinacao = New System.Windows.Forms.DataGridView()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.lbNomeVacina = New System.Windows.Forms.Label()
        Me.lbCodigoVacina = New System.Windows.Forms.Label()
        Me.txtCodVacina = New System.Windows.Forms.TextBox()
        Me.txtNomeVacina = New System.Windows.Forms.TextBox()
        Me.txtCodigoVacinacao = New System.Windows.Forms.TextBox()
        Me.lbCodVacinacao = New System.Windows.Forms.Label()
        Me.dgvVacina = New System.Windows.Forms.DataGridView()
        Me.gpxFunc = New System.Windows.Forms.GroupBox()
        Me.MtxtFiltroDataFunc = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtFiltroCPFFunc = New System.Windows.Forms.MaskedTextBox()
        Me.cmbFiltroFunc = New System.Windows.Forms.ComboBox()
        Me.txtNomeFunc = New System.Windows.Forms.TextBox()
        Me.txtCodFunc = New System.Windows.Forms.TextBox()
        Me.lbNomeFunc = New System.Windows.Forms.Label()
        Me.lbCodigoFunc = New System.Windows.Forms.Label()
        Me.gpxAnimal = New System.Windows.Forms.GroupBox()
        Me.MtxtFiltroDataAnimal = New System.Windows.Forms.MaskedTextBox()
        Me.cmbFiltroAnimal = New System.Windows.Forms.ComboBox()
        Me.txtNomeAnimal = New System.Windows.Forms.TextBox()
        Me.txtCodAnimal = New System.Windows.Forms.TextBox()
        Me.lbNomeAnimal = New System.Windows.Forms.Label()
        Me.lbCodigoAnimal = New System.Windows.Forms.Label()
        Me.pbxBanner = New System.Windows.Forms.PictureBox()
        CType(Me.dgvFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxVacinacao.SuspendLayout()
        CType(Me.dgvItensVacinacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVacina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxFunc.SuspendLayout()
        Me.gpxAnimal.SuspendLayout()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MtxtDataVacina
        '
        Me.MtxtDataVacina.Location = New System.Drawing.Point(633, 42)
        Me.MtxtDataVacina.Mask = "00/00/0000"
        Me.MtxtDataVacina.Name = "MtxtDataVacina"
        Me.MtxtDataVacina.Size = New System.Drawing.Size(85, 20)
        Me.MtxtDataVacina.TabIndex = 10
        Me.MtxtDataVacina.ValidatingType = GetType(Date)
        '
        'txtConsultaAnimal
        '
        Me.txtConsultaAnimal.Location = New System.Drawing.Point(249, 27)
        Me.txtConsultaAnimal.Name = "txtConsultaAnimal"
        Me.txtConsultaAnimal.Size = New System.Drawing.Size(143, 20)
        Me.txtConsultaAnimal.TabIndex = 4
        Me.txtConsultaAnimal.Visible = False
        '
        'lbCodAnimal
        '
        Me.lbCodAnimal.AutoSize = True
        Me.lbCodAnimal.Location = New System.Drawing.Point(13, 31)
        Me.lbCodAnimal.Name = "lbCodAnimal"
        Me.lbCodAnimal.Size = New System.Drawing.Size(94, 13)
        Me.lbCodAnimal.TabIndex = 24
        Me.lbCodAnimal.Text = "Buscar animal por:"
        '
        'lbCodFunc
        '
        Me.lbCodFunc.AutoSize = True
        Me.lbCodFunc.Location = New System.Drawing.Point(17, 31)
        Me.lbCodFunc.Name = "lbCodFunc"
        Me.lbCodFunc.Size = New System.Drawing.Size(116, 13)
        Me.lbCodFunc.TabIndex = 21
        Me.lbCodFunc.Text = "Buscar funcionário por:"
        '
        'txtConsultaFunc
        '
        Me.txtConsultaFunc.Location = New System.Drawing.Point(276, 26)
        Me.txtConsultaFunc.Name = "txtConsultaFunc"
        Me.txtConsultaFunc.Size = New System.Drawing.Size(161, 20)
        Me.txtConsultaFunc.TabIndex = 1
        Me.txtConsultaFunc.Visible = False
        '
        'lbVacina
        '
        Me.lbVacina.AutoSize = True
        Me.lbVacina.Location = New System.Drawing.Point(17, 75)
        Me.lbVacina.Name = "lbVacina"
        Me.lbVacina.Size = New System.Drawing.Size(96, 13)
        Me.lbVacina.TabIndex = 33
        Me.lbVacina.Text = "Buscar vacina por:"
        '
        'txtConsultaVacina
        '
        Me.txtConsultaVacina.Location = New System.Drawing.Point(252, 72)
        Me.txtConsultaVacina.Name = "txtConsultaVacina"
        Me.txtConsultaVacina.Size = New System.Drawing.Size(169, 20)
        Me.txtConsultaVacina.TabIndex = 7
        Me.txtConsultaVacina.Visible = False
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
        Me.dgvFunc.Location = New System.Drawing.Point(19, 55)
        Me.dgvFunc.MultiSelect = False
        Me.dgvFunc.Name = "dgvFunc"
        Me.dgvFunc.ReadOnly = True
        Me.dgvFunc.RowHeadersVisible = False
        Me.dgvFunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFunc.Size = New System.Drawing.Size(611, 113)
        Me.dgvFunc.TabIndex = 64
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
        Me.dgvAnimal.Location = New System.Drawing.Point(16, 55)
        Me.dgvAnimal.MultiSelect = False
        Me.dgvAnimal.Name = "dgvAnimal"
        Me.dgvAnimal.ReadOnly = True
        Me.dgvAnimal.RowHeadersVisible = False
        Me.dgvAnimal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAnimal.Size = New System.Drawing.Size(611, 113)
        Me.dgvAnimal.TabIndex = 65
        '
        'btnBuscaFunc
        '
        Me.btnBuscaFunc.BackColor = System.Drawing.Color.White
        Me.btnBuscaFunc.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBuscaFunc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscaFunc.Location = New System.Drawing.Point(449, 25)
        Me.btnBuscaFunc.Name = "btnBuscaFunc"
        Me.btnBuscaFunc.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscaFunc.TabIndex = 2
        Me.btnBuscaFunc.Text = "Buscar"
        Me.btnBuscaFunc.UseVisualStyleBackColor = False
        Me.btnBuscaFunc.Visible = False
        '
        'btnBuscaAnimal
        '
        Me.btnBuscaAnimal.BackColor = System.Drawing.Color.White
        Me.btnBuscaAnimal.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBuscaAnimal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaAnimal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscaAnimal.Location = New System.Drawing.Point(407, 25)
        Me.btnBuscaAnimal.Name = "btnBuscaAnimal"
        Me.btnBuscaAnimal.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscaAnimal.TabIndex = 5
        Me.btnBuscaAnimal.Text = "Buscar"
        Me.btnBuscaAnimal.UseVisualStyleBackColor = False
        Me.btnBuscaAnimal.Visible = False
        '
        'btnBuscaVacina
        '
        Me.btnBuscaVacina.BackColor = System.Drawing.Color.White
        Me.btnBuscaVacina.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBuscaVacina.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaVacina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaVacina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscaVacina.Location = New System.Drawing.Point(436, 70)
        Me.btnBuscaVacina.Name = "btnBuscaVacina"
        Me.btnBuscaVacina.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscaVacina.TabIndex = 8
        Me.btnBuscaVacina.Text = "Buscar"
        Me.btnBuscaVacina.UseVisualStyleBackColor = False
        Me.btnBuscaVacina.Visible = False
        '
        'lbDataVacinacao
        '
        Me.lbDataVacinacao.AutoSize = True
        Me.lbDataVacinacao.Location = New System.Drawing.Point(630, 26)
        Me.lbDataVacinacao.Name = "lbDataVacinacao"
        Me.lbDataVacinacao.Size = New System.Drawing.Size(83, 13)
        Me.lbDataVacinacao.TabIndex = 72
        Me.lbDataVacinacao.Text = "Data vacinação"
        '
        'BtnSalvarVacinacao
        '
        Me.BtnSalvarVacinacao.BackColor = System.Drawing.Color.White
        Me.BtnSalvarVacinacao.BackgroundImage = Global.sistechy.My.Resources.Resources.salva_vacinacao_fw
        Me.BtnSalvarVacinacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalvarVacinacao.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnSalvarVacinacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.BtnSalvarVacinacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.BtnSalvarVacinacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvarVacinacao.Location = New System.Drawing.Point(1156, 591)
        Me.BtnSalvarVacinacao.Name = "BtnSalvarVacinacao"
        Me.BtnSalvarVacinacao.Size = New System.Drawing.Size(170, 50)
        Me.BtnSalvarVacinacao.TabIndex = 13
        Me.BtnSalvarVacinacao.UseVisualStyleBackColor = False
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
        Me.btnCancelar.Location = New System.Drawing.Point(980, 591)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(170, 50)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'gpxVacinacao
        '
        Me.gpxVacinacao.Controls.Add(Me.cmbFiltroVacina)
        Me.gpxVacinacao.Controls.Add(Me.txtQuantidade)
        Me.gpxVacinacao.Controls.Add(Me.txtAno)
        Me.gpxVacinacao.Controls.Add(Me.txtMes)
        Me.gpxVacinacao.Controls.Add(Me.txtCodVacinacao)
        Me.gpxVacinacao.Controls.Add(Me.txtCodItem)
        Me.gpxVacinacao.Controls.Add(Me.Label13)
        Me.gpxVacinacao.Controls.Add(Me.Label2)
        Me.gpxVacinacao.Controls.Add(Me.btnRemover)
        Me.gpxVacinacao.Controls.Add(Me.btnLimpar)
        Me.gpxVacinacao.Controls.Add(Me.dgvItensVacinacao)
        Me.gpxVacinacao.Controls.Add(Me.btnAdicionar)
        Me.gpxVacinacao.Controls.Add(Me.lbNomeVacina)
        Me.gpxVacinacao.Controls.Add(Me.lbCodigoVacina)
        Me.gpxVacinacao.Controls.Add(Me.txtCodVacina)
        Me.gpxVacinacao.Controls.Add(Me.txtNomeVacina)
        Me.gpxVacinacao.Controls.Add(Me.txtCodigoVacinacao)
        Me.gpxVacinacao.Controls.Add(Me.lbCodVacinacao)
        Me.gpxVacinacao.Controls.Add(Me.dgvVacina)
        Me.gpxVacinacao.Controls.Add(Me.lbVacina)
        Me.gpxVacinacao.Controls.Add(Me.txtConsultaVacina)
        Me.gpxVacinacao.Controls.Add(Me.lbDataVacinacao)
        Me.gpxVacinacao.Controls.Add(Me.btnBuscaVacina)
        Me.gpxVacinacao.Controls.Add(Me.MtxtDataVacina)
        Me.gpxVacinacao.Location = New System.Drawing.Point(20, 310)
        Me.gpxVacinacao.Name = "gpxVacinacao"
        Me.gpxVacinacao.Size = New System.Drawing.Size(1306, 267)
        Me.gpxVacinacao.TabIndex = 6
        Me.gpxVacinacao.TabStop = False
        Me.gpxVacinacao.Text = "Dados da vacinação"
        '
        'cmbFiltroVacina
        '
        Me.cmbFiltroVacina.FormattingEnabled = True
        Me.cmbFiltroVacina.Location = New System.Drawing.Point(119, 71)
        Me.cmbFiltroVacina.Name = "cmbFiltroVacina"
        Me.cmbFiltroVacina.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltroVacina.TabIndex = 104
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(249, 34)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidade.TabIndex = 103
        Me.txtQuantidade.Visible = False
        '
        'txtAno
        '
        Me.txtAno.Location = New System.Drawing.Point(1082, 184)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(100, 20)
        Me.txtAno.TabIndex = 102
        Me.txtAno.Visible = False
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(1082, 158)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(100, 20)
        Me.txtMes.TabIndex = 101
        Me.txtMes.Visible = False
        '
        'txtCodVacinacao
        '
        Me.txtCodVacinacao.Enabled = False
        Me.txtCodVacinacao.Location = New System.Drawing.Point(860, 38)
        Me.txtCodVacinacao.Name = "txtCodVacinacao"
        Me.txtCodVacinacao.Size = New System.Drawing.Size(93, 20)
        Me.txtCodVacinacao.TabIndex = 100
        Me.txtCodVacinacao.Visible = False
        '
        'txtCodItem
        '
        Me.txtCodItem.Enabled = False
        Me.txtCodItem.Location = New System.Drawing.Point(741, 38)
        Me.txtCodItem.Name = "txtCodItem"
        Me.txtCodItem.Size = New System.Drawing.Size(93, 20)
        Me.txtCodItem.TabIndex = 99
        Me.txtCodItem.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(857, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 13)
        Me.Label13.TabIndex = 96
        Me.Label13.Text = "Código vacinação"
        Me.Label13.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(738, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Código item"
        Me.Label2.Visible = False
        '
        'btnRemover
        '
        Me.btnRemover.BackColor = System.Drawing.Color.White
        Me.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemover.Location = New System.Drawing.Point(1082, 72)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(75, 23)
        Me.btnRemover.TabIndex = 11
        Me.btnRemover.Text = "Remover"
        Me.btnRemover.UseVisualStyleBackColor = False
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.Color.White
        Me.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpar.Location = New System.Drawing.Point(1082, 101)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpar.TabIndex = 12
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'dgvItensVacinacao
        '
        Me.dgvItensVacinacao.AllowUserToAddRows = False
        Me.dgvItensVacinacao.AllowUserToDeleteRows = False
        Me.dgvItensVacinacao.AllowUserToResizeColumns = False
        Me.dgvItensVacinacao.AllowUserToResizeRows = False
        Me.dgvItensVacinacao.BackgroundColor = System.Drawing.Color.White
        Me.dgvItensVacinacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvItensVacinacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItensVacinacao.Location = New System.Drawing.Point(633, 72)
        Me.dgvItensVacinacao.MultiSelect = False
        Me.dgvItensVacinacao.Name = "dgvItensVacinacao"
        Me.dgvItensVacinacao.ReadOnly = True
        Me.dgvItensVacinacao.RowHeadersVisible = False
        Me.dgvItensVacinacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItensVacinacao.Size = New System.Drawing.Size(443, 181)
        Me.dgvItensVacinacao.TabIndex = 92
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackColor = System.Drawing.Color.White
        Me.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionar.Location = New System.Drawing.Point(456, 230)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(125, 23)
        Me.btnAdicionar.TabIndex = 9
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = False
        '
        'lbNomeVacina
        '
        Me.lbNomeVacina.AutoSize = True
        Me.lbNomeVacina.Location = New System.Drawing.Point(154, 216)
        Me.lbNomeVacina.Name = "lbNomeVacina"
        Me.lbNomeVacina.Size = New System.Drawing.Size(35, 13)
        Me.lbNomeVacina.TabIndex = 89
        Me.lbNomeVacina.Text = "Nome"
        '
        'lbCodigoVacina
        '
        Me.lbCodigoVacina.AutoSize = True
        Me.lbCodigoVacina.Location = New System.Drawing.Point(20, 216)
        Me.lbCodigoVacina.Name = "lbCodigoVacina"
        Me.lbCodigoVacina.Size = New System.Drawing.Size(40, 13)
        Me.lbCodigoVacina.TabIndex = 88
        Me.lbCodigoVacina.Text = "Código"
        '
        'txtCodVacina
        '
        Me.txtCodVacina.Enabled = False
        Me.txtCodVacina.Location = New System.Drawing.Point(21, 232)
        Me.txtCodVacina.Name = "txtCodVacina"
        Me.txtCodVacina.Size = New System.Drawing.Size(100, 20)
        Me.txtCodVacina.TabIndex = 87
        '
        'txtNomeVacina
        '
        Me.txtNomeVacina.Enabled = False
        Me.txtNomeVacina.Location = New System.Drawing.Point(157, 232)
        Me.txtNomeVacina.Name = "txtNomeVacina"
        Me.txtNomeVacina.Size = New System.Drawing.Size(283, 20)
        Me.txtNomeVacina.TabIndex = 86
        '
        'txtCodigoVacinacao
        '
        Me.txtCodigoVacinacao.Enabled = False
        Me.txtCodigoVacinacao.Location = New System.Drawing.Point(131, 34)
        Me.txtCodigoVacinacao.Name = "txtCodigoVacinacao"
        Me.txtCodigoVacinacao.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoVacinacao.TabIndex = 83
        '
        'lbCodVacinacao
        '
        Me.lbCodVacinacao.AutoSize = True
        Me.lbCodVacinacao.Location = New System.Drawing.Point(17, 37)
        Me.lbCodVacinacao.Name = "lbCodVacinacao"
        Me.lbCodVacinacao.Size = New System.Drawing.Size(108, 13)
        Me.lbCodVacinacao.TabIndex = 82
        Me.lbCodVacinacao.Text = "Código da vacinação"
        '
        'dgvVacina
        '
        Me.dgvVacina.AllowUserToAddRows = False
        Me.dgvVacina.AllowUserToDeleteRows = False
        Me.dgvVacina.AllowUserToResizeColumns = False
        Me.dgvVacina.AllowUserToResizeRows = False
        Me.dgvVacina.BackgroundColor = System.Drawing.Color.White
        Me.dgvVacina.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvVacina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVacina.Location = New System.Drawing.Point(19, 101)
        Me.dgvVacina.MultiSelect = False
        Me.dgvVacina.Name = "dgvVacina"
        Me.dgvVacina.ReadOnly = True
        Me.dgvVacina.RowHeadersVisible = False
        Me.dgvVacina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVacina.Size = New System.Drawing.Size(559, 108)
        Me.dgvVacina.TabIndex = 78
        '
        'gpxFunc
        '
        Me.gpxFunc.Controls.Add(Me.MtxtFiltroDataFunc)
        Me.gpxFunc.Controls.Add(Me.MtxtFiltroCPFFunc)
        Me.gpxFunc.Controls.Add(Me.cmbFiltroFunc)
        Me.gpxFunc.Controls.Add(Me.txtNomeFunc)
        Me.gpxFunc.Controls.Add(Me.txtCodFunc)
        Me.gpxFunc.Controls.Add(Me.lbNomeFunc)
        Me.gpxFunc.Controls.Add(Me.lbCodigoFunc)
        Me.gpxFunc.Controls.Add(Me.dgvFunc)
        Me.gpxFunc.Controls.Add(Me.txtConsultaFunc)
        Me.gpxFunc.Controls.Add(Me.lbCodFunc)
        Me.gpxFunc.Controls.Add(Me.btnBuscaFunc)
        Me.gpxFunc.Location = New System.Drawing.Point(20, 75)
        Me.gpxFunc.Name = "gpxFunc"
        Me.gpxFunc.Size = New System.Drawing.Size(650, 229)
        Me.gpxFunc.TabIndex = 0
        Me.gpxFunc.TabStop = False
        Me.gpxFunc.Text = "Dados do funcionário"
        '
        'MtxtFiltroDataFunc
        '
        Me.MtxtFiltroDataFunc.Location = New System.Drawing.Point(276, 26)
        Me.MtxtFiltroDataFunc.Mask = "00/00/0000"
        Me.MtxtFiltroDataFunc.Name = "MtxtFiltroDataFunc"
        Me.MtxtFiltroDataFunc.Size = New System.Drawing.Size(73, 20)
        Me.MtxtFiltroDataFunc.TabIndex = 73
        Me.MtxtFiltroDataFunc.ValidatingType = GetType(Date)
        Me.MtxtFiltroDataFunc.Visible = False
        '
        'MtxtFiltroCPFFunc
        '
        Me.MtxtFiltroCPFFunc.Location = New System.Drawing.Point(276, 26)
        Me.MtxtFiltroCPFFunc.Mask = "000.000.000-00"
        Me.MtxtFiltroCPFFunc.Name = "MtxtFiltroCPFFunc"
        Me.MtxtFiltroCPFFunc.Size = New System.Drawing.Size(87, 20)
        Me.MtxtFiltroCPFFunc.TabIndex = 72
        Me.MtxtFiltroCPFFunc.Visible = False
        '
        'cmbFiltroFunc
        '
        Me.cmbFiltroFunc.FormattingEnabled = True
        Me.cmbFiltroFunc.Location = New System.Drawing.Point(139, 25)
        Me.cmbFiltroFunc.Name = "cmbFiltroFunc"
        Me.cmbFiltroFunc.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltroFunc.TabIndex = 71
        '
        'txtNomeFunc
        '
        Me.txtNomeFunc.Enabled = False
        Me.txtNomeFunc.Location = New System.Drawing.Point(153, 191)
        Me.txtNomeFunc.Name = "txtNomeFunc"
        Me.txtNomeFunc.Size = New System.Drawing.Size(298, 20)
        Me.txtNomeFunc.TabIndex = 70
        '
        'txtCodFunc
        '
        Me.txtCodFunc.Enabled = False
        Me.txtCodFunc.Location = New System.Drawing.Point(21, 191)
        Me.txtCodFunc.Name = "txtCodFunc"
        Me.txtCodFunc.Size = New System.Drawing.Size(100, 20)
        Me.txtCodFunc.TabIndex = 69
        '
        'lbNomeFunc
        '
        Me.lbNomeFunc.AutoSize = True
        Me.lbNomeFunc.Location = New System.Drawing.Point(150, 175)
        Me.lbNomeFunc.Name = "lbNomeFunc"
        Me.lbNomeFunc.Size = New System.Drawing.Size(35, 13)
        Me.lbNomeFunc.TabIndex = 68
        Me.lbNomeFunc.Text = "Nome"
        '
        'lbCodigoFunc
        '
        Me.lbCodigoFunc.AutoSize = True
        Me.lbCodigoFunc.Location = New System.Drawing.Point(20, 175)
        Me.lbCodigoFunc.Name = "lbCodigoFunc"
        Me.lbCodigoFunc.Size = New System.Drawing.Size(40, 13)
        Me.lbCodigoFunc.TabIndex = 67
        Me.lbCodigoFunc.Text = "Código"
        '
        'gpxAnimal
        '
        Me.gpxAnimal.Controls.Add(Me.MtxtFiltroDataAnimal)
        Me.gpxAnimal.Controls.Add(Me.cmbFiltroAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtNomeAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtCodAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbNomeAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbCodigoAnimal)
        Me.gpxAnimal.Controls.Add(Me.dgvAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbCodAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtConsultaAnimal)
        Me.gpxAnimal.Controls.Add(Me.btnBuscaAnimal)
        Me.gpxAnimal.Location = New System.Drawing.Point(683, 75)
        Me.gpxAnimal.Name = "gpxAnimal"
        Me.gpxAnimal.Size = New System.Drawing.Size(643, 229)
        Me.gpxAnimal.TabIndex = 3
        Me.gpxAnimal.TabStop = False
        Me.gpxAnimal.Text = "Dados do animal"
        '
        'MtxtFiltroDataAnimal
        '
        Me.MtxtFiltroDataAnimal.Location = New System.Drawing.Point(249, 27)
        Me.MtxtFiltroDataAnimal.Mask = "00/00/0000"
        Me.MtxtFiltroDataAnimal.Name = "MtxtFiltroDataAnimal"
        Me.MtxtFiltroDataAnimal.Size = New System.Drawing.Size(72, 20)
        Me.MtxtFiltroDataAnimal.TabIndex = 73
        Me.MtxtFiltroDataAnimal.ValidatingType = GetType(Date)
        Me.MtxtFiltroDataAnimal.Visible = False
        '
        'cmbFiltroAnimal
        '
        Me.cmbFiltroAnimal.FormattingEnabled = True
        Me.cmbFiltroAnimal.Location = New System.Drawing.Point(113, 27)
        Me.cmbFiltroAnimal.Name = "cmbFiltroAnimal"
        Me.cmbFiltroAnimal.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltroAnimal.TabIndex = 72
        '
        'txtNomeAnimal
        '
        Me.txtNomeAnimal.Enabled = False
        Me.txtNomeAnimal.Location = New System.Drawing.Point(148, 191)
        Me.txtNomeAnimal.Name = "txtNomeAnimal"
        Me.txtNomeAnimal.Size = New System.Drawing.Size(298, 20)
        Me.txtNomeAnimal.TabIndex = 71
        '
        'txtCodAnimal
        '
        Me.txtCodAnimal.Enabled = False
        Me.txtCodAnimal.Location = New System.Drawing.Point(16, 191)
        Me.txtCodAnimal.Name = "txtCodAnimal"
        Me.txtCodAnimal.Size = New System.Drawing.Size(100, 20)
        Me.txtCodAnimal.TabIndex = 70
        '
        'lbNomeAnimal
        '
        Me.lbNomeAnimal.AutoSize = True
        Me.lbNomeAnimal.Location = New System.Drawing.Point(145, 175)
        Me.lbNomeAnimal.Name = "lbNomeAnimal"
        Me.lbNomeAnimal.Size = New System.Drawing.Size(35, 13)
        Me.lbNomeAnimal.TabIndex = 69
        Me.lbNomeAnimal.Text = "Nome"
        '
        'lbCodigoAnimal
        '
        Me.lbCodigoAnimal.AutoSize = True
        Me.lbCodigoAnimal.Location = New System.Drawing.Point(13, 175)
        Me.lbCodigoAnimal.Name = "lbCodigoAnimal"
        Me.lbCodigoAnimal.Size = New System.Drawing.Size(40, 13)
        Me.lbCodigoAnimal.TabIndex = 68
        Me.lbCodigoAnimal.Text = "Código"
        '
        'pbxBanner
        '
        Me.pbxBanner.BackgroundImage = Global.sistechy.My.Resources.Resources.banner_vacinacao_fw
        Me.pbxBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxBanner.Location = New System.Drawing.Point(-5, -1)
        Me.pbxBanner.Name = "pbxBanner"
        Me.pbxBanner.Size = New System.Drawing.Size(1366, 55)
        Me.pbxBanner.TabIndex = 78
        Me.pbxBanner.TabStop = False
        '
        'frmVacinacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1340, 656)
        Me.Controls.Add(Me.pbxBanner)
        Me.Controls.Add(Me.gpxAnimal)
        Me.Controls.Add(Me.gpxFunc)
        Me.Controls.Add(Me.gpxVacinacao)
        Me.Controls.Add(Me.BtnSalvarVacinacao)
        Me.Controls.Add(Me.btnCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmVacinacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vacinação"
        CType(Me.dgvFunc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxVacinacao.ResumeLayout(False)
        Me.gpxVacinacao.PerformLayout()
        CType(Me.dgvItensVacinacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVacina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxFunc.ResumeLayout(False)
        Me.gpxFunc.PerformLayout()
        Me.gpxAnimal.ResumeLayout(False)
        Me.gpxAnimal.PerformLayout()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MtxtDataVacina As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtConsultaAnimal As System.Windows.Forms.TextBox
    Friend WithEvents lbCodAnimal As System.Windows.Forms.Label
    Friend WithEvents lbCodFunc As System.Windows.Forms.Label
    Friend WithEvents txtConsultaFunc As System.Windows.Forms.TextBox
    Friend WithEvents lbVacina As System.Windows.Forms.Label
    Friend WithEvents txtConsultaVacina As System.Windows.Forms.TextBox
    Friend WithEvents dgvFunc As System.Windows.Forms.DataGridView
    Friend WithEvents dgvAnimal As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscaFunc As System.Windows.Forms.Button
    Friend WithEvents btnBuscaAnimal As System.Windows.Forms.Button
    Friend WithEvents btnBuscaVacina As System.Windows.Forms.Button
    Friend WithEvents lbDataVacinacao As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnSalvarVacinacao As System.Windows.Forms.Button
    Friend WithEvents gpxVacinacao As System.Windows.Forms.GroupBox
    Friend WithEvents gpxFunc As System.Windows.Forms.GroupBox
    Friend WithEvents gpxAnimal As System.Windows.Forms.GroupBox
    Friend WithEvents txtNomeFunc As System.Windows.Forms.TextBox
    Friend WithEvents txtCodFunc As System.Windows.Forms.TextBox
    Friend WithEvents lbNomeFunc As System.Windows.Forms.Label
    Friend WithEvents lbCodigoFunc As System.Windows.Forms.Label
    Friend WithEvents lbNomeAnimal As System.Windows.Forms.Label
    Friend WithEvents lbCodigoAnimal As System.Windows.Forms.Label
    Friend WithEvents txtNomeAnimal As System.Windows.Forms.TextBox
    Friend WithEvents txtCodAnimal As System.Windows.Forms.TextBox
    Friend WithEvents dgvVacina As System.Windows.Forms.DataGridView
    Friend WithEvents txtCodigoVacinacao As System.Windows.Forms.TextBox
    Friend WithEvents lbCodVacinacao As System.Windows.Forms.Label
    Friend WithEvents lbNomeVacina As System.Windows.Forms.Label
    Friend WithEvents lbCodigoVacina As System.Windows.Forms.Label
    Friend WithEvents txtCodVacina As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeVacina As System.Windows.Forms.TextBox
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents btnRemover As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodVacinacao As System.Windows.Forms.TextBox
    Friend WithEvents txtCodItem As System.Windows.Forms.TextBox
    Friend WithEvents pbxBanner As System.Windows.Forms.PictureBox
    Friend WithEvents dgvItensVacinacao As System.Windows.Forms.DataGridView
    Friend WithEvents txtAno As System.Windows.Forms.TextBox
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents MtxtFiltroDataFunc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtFiltroCPFFunc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbFiltroFunc As System.Windows.Forms.ComboBox
    Friend WithEvents MtxtFiltroDataAnimal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbFiltroAnimal As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFiltroVacina As System.Windows.Forms.ComboBox
End Class
