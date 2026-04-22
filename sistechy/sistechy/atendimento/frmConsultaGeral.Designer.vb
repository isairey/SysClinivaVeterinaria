<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaGeral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaGeral))
        Me.lbDataConsulta = New System.Windows.Forms.Label()
        Me.lbDetalhesConsulta = New System.Windows.Forms.Label()
        Me.txtConsultaVeterinario = New System.Windows.Forms.TextBox()
        Me.lbCodVeterinario = New System.Windows.Forms.Label()
        Me.lbCodAnimal = New System.Windows.Forms.Label()
        Me.txtConsultaAnimal = New System.Windows.Forms.TextBox()
        Me.MtxtDataConsulta = New System.Windows.Forms.MaskedTextBox()
        Me.txtDetalhesConsulta = New System.Windows.Forms.RichTextBox()
        Me.btnBuscaVeterinario = New System.Windows.Forms.Button()
        Me.dgvVeterinario = New System.Windows.Forms.DataGridView()
        Me.gpxVeterinario = New System.Windows.Forms.GroupBox()
        Me.MtxtFiltroDataVeterinario = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtFiltroCPFVeterinario = New System.Windows.Forms.MaskedTextBox()
        Me.cmbFiltroVeterinario = New System.Windows.Forms.ComboBox()
        Me.txtCodVeterinario = New System.Windows.Forms.TextBox()
        Me.lbNomeVeterinario = New System.Windows.Forms.Label()
        Me.lbCodigoVeterinario = New System.Windows.Forms.Label()
        Me.txtNomeVeterinario = New System.Windows.Forms.TextBox()
        Me.gpxAnimal = New System.Windows.Forms.GroupBox()
        Me.MtxtFiltroDataAnimal = New System.Windows.Forms.MaskedTextBox()
        Me.txtCaminhoImagem = New System.Windows.Forms.TextBox()
        Me.cmbFiltroAnimal = New System.Windows.Forms.ComboBox()
        Me.txtCastracaoAnimal = New System.Windows.Forms.TextBox()
        Me.btnBuscaAnimal = New System.Windows.Forms.Button()
        Me.txtPorteAnimal = New System.Windows.Forms.TextBox()
        Me.dgvAnimal = New System.Windows.Forms.DataGridView()
        Me.pbxAnimal = New System.Windows.Forms.PictureBox()
        Me.lbPorteAnimal = New System.Windows.Forms.Label()
        Me.txtNomeAnimal = New System.Windows.Forms.TextBox()
        Me.txtCodAnimal = New System.Windows.Forms.TextBox()
        Me.lbCodigoAnimal = New System.Windows.Forms.Label()
        Me.lbNomeAnimal = New System.Windows.Forms.Label()
        Me.lbCastracaoAnimal = New System.Windows.Forms.Label()
        Me.gpxConsulta = New System.Windows.Forms.GroupBox()
        Me.txtCodConsulta = New System.Windows.Forms.TextBox()
        Me.lbCodConsulta = New System.Windows.Forms.Label()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.pbxBanner = New System.Windows.Forms.PictureBox()
        Me.btnSalvarConsulta = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.dgvVeterinario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxVeterinario.SuspendLayout()
        Me.gpxAnimal.SuspendLayout()
        CType(Me.dgvAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxConsulta.SuspendLayout()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbDataConsulta
        '
        Me.lbDataConsulta.AutoSize = True
        Me.lbDataConsulta.Location = New System.Drawing.Point(21, 24)
        Me.lbDataConsulta.Name = "lbDataConsulta"
        Me.lbDataConsulta.Size = New System.Drawing.Size(88, 13)
        Me.lbDataConsulta.TabIndex = 1
        Me.lbDataConsulta.Text = "Data da consulta"
        '
        'lbDetalhesConsulta
        '
        Me.lbDetalhesConsulta.AutoSize = True
        Me.lbDetalhesConsulta.Location = New System.Drawing.Point(21, 74)
        Me.lbDetalhesConsulta.Name = "lbDetalhesConsulta"
        Me.lbDetalhesConsulta.Size = New System.Drawing.Size(49, 13)
        Me.lbDetalhesConsulta.TabIndex = 3
        Me.lbDetalhesConsulta.Text = "Detalhes"
        '
        'txtConsultaVeterinario
        '
        Me.txtConsultaVeterinario.Location = New System.Drawing.Point(270, 24)
        Me.txtConsultaVeterinario.Name = "txtConsultaVeterinario"
        Me.txtConsultaVeterinario.Size = New System.Drawing.Size(193, 20)
        Me.txtConsultaVeterinario.TabIndex = 1
        Me.txtConsultaVeterinario.Visible = False
        '
        'lbCodVeterinario
        '
        Me.lbCodVeterinario.AutoSize = True
        Me.lbCodVeterinario.Location = New System.Drawing.Point(21, 27)
        Me.lbCodVeterinario.Name = "lbCodVeterinario"
        Me.lbCodVeterinario.Size = New System.Drawing.Size(113, 13)
        Me.lbCodVeterinario.TabIndex = 7
        Me.lbCodVeterinario.Text = "Buscar veterinário por:"
        '
        'lbCodAnimal
        '
        Me.lbCodAnimal.AutoSize = True
        Me.lbCodAnimal.Location = New System.Drawing.Point(18, 26)
        Me.lbCodAnimal.Name = "lbCodAnimal"
        Me.lbCodAnimal.Size = New System.Drawing.Size(94, 13)
        Me.lbCodAnimal.TabIndex = 10
        Me.lbCodAnimal.Text = "Buscar animal por:"
        '
        'txtConsultaAnimal
        '
        Me.txtConsultaAnimal.Location = New System.Drawing.Point(255, 23)
        Me.txtConsultaAnimal.Name = "txtConsultaAnimal"
        Me.txtConsultaAnimal.Size = New System.Drawing.Size(162, 20)
        Me.txtConsultaAnimal.TabIndex = 3
        Me.txtConsultaAnimal.Visible = False
        '
        'MtxtDataConsulta
        '
        Me.MtxtDataConsulta.Location = New System.Drawing.Point(24, 40)
        Me.MtxtDataConsulta.Mask = "00/00/0000"
        Me.MtxtDataConsulta.Name = "MtxtDataConsulta"
        Me.MtxtDataConsulta.Size = New System.Drawing.Size(85, 20)
        Me.MtxtDataConsulta.TabIndex = 5
        Me.MtxtDataConsulta.ValidatingType = GetType(Date)
        '
        'txtDetalhesConsulta
        '
        Me.txtDetalhesConsulta.Location = New System.Drawing.Point(24, 90)
        Me.txtDetalhesConsulta.Name = "txtDetalhesConsulta"
        Me.txtDetalhesConsulta.Size = New System.Drawing.Size(592, 137)
        Me.txtDetalhesConsulta.TabIndex = 6
        Me.txtDetalhesConsulta.Text = ""
        '
        'btnBuscaVeterinario
        '
        Me.btnBuscaVeterinario.BackColor = System.Drawing.Color.White
        Me.btnBuscaVeterinario.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBuscaVeterinario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaVeterinario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaVeterinario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscaVeterinario.Location = New System.Drawing.Point(479, 22)
        Me.btnBuscaVeterinario.Name = "btnBuscaVeterinario"
        Me.btnBuscaVeterinario.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscaVeterinario.TabIndex = 2
        Me.btnBuscaVeterinario.Text = "Buscar"
        Me.btnBuscaVeterinario.UseVisualStyleBackColor = False
        Me.btnBuscaVeterinario.Visible = False
        '
        'dgvVeterinario
        '
        Me.dgvVeterinario.AllowUserToAddRows = False
        Me.dgvVeterinario.AllowUserToDeleteRows = False
        Me.dgvVeterinario.AllowUserToResizeColumns = False
        Me.dgvVeterinario.AllowUserToResizeRows = False
        Me.dgvVeterinario.BackgroundColor = System.Drawing.Color.White
        Me.dgvVeterinario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvVeterinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVeterinario.Location = New System.Drawing.Point(24, 56)
        Me.dgvVeterinario.MultiSelect = False
        Me.dgvVeterinario.Name = "dgvVeterinario"
        Me.dgvVeterinario.ReadOnly = True
        Me.dgvVeterinario.RowHeadersVisible = False
        Me.dgvVeterinario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvVeterinario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVeterinario.Size = New System.Drawing.Size(604, 140)
        Me.dgvVeterinario.TabIndex = 63
        '
        'gpxVeterinario
        '
        Me.gpxVeterinario.Controls.Add(Me.MtxtFiltroDataVeterinario)
        Me.gpxVeterinario.Controls.Add(Me.MtxtFiltroCPFVeterinario)
        Me.gpxVeterinario.Controls.Add(Me.cmbFiltroVeterinario)
        Me.gpxVeterinario.Controls.Add(Me.txtCodVeterinario)
        Me.gpxVeterinario.Controls.Add(Me.lbNomeVeterinario)
        Me.gpxVeterinario.Controls.Add(Me.dgvVeterinario)
        Me.gpxVeterinario.Controls.Add(Me.lbCodigoVeterinario)
        Me.gpxVeterinario.Controls.Add(Me.lbCodVeterinario)
        Me.gpxVeterinario.Controls.Add(Me.txtNomeVeterinario)
        Me.gpxVeterinario.Controls.Add(Me.txtConsultaVeterinario)
        Me.gpxVeterinario.Controls.Add(Me.btnBuscaVeterinario)
        Me.gpxVeterinario.Location = New System.Drawing.Point(20, 70)
        Me.gpxVeterinario.Name = "gpxVeterinario"
        Me.gpxVeterinario.Size = New System.Drawing.Size(650, 250)
        Me.gpxVeterinario.TabIndex = 64
        Me.gpxVeterinario.TabStop = False
        Me.gpxVeterinario.Text = "Dados do veterinário"
        '
        'MtxtFiltroDataVeterinario
        '
        Me.MtxtFiltroDataVeterinario.Location = New System.Drawing.Point(270, 24)
        Me.MtxtFiltroDataVeterinario.Mask = "00/00/0000"
        Me.MtxtFiltroDataVeterinario.Name = "MtxtFiltroDataVeterinario"
        Me.MtxtFiltroDataVeterinario.Size = New System.Drawing.Size(73, 20)
        Me.MtxtFiltroDataVeterinario.TabIndex = 96
        Me.MtxtFiltroDataVeterinario.ValidatingType = GetType(Date)
        Me.MtxtFiltroDataVeterinario.Visible = False
        '
        'MtxtFiltroCPFVeterinario
        '
        Me.MtxtFiltroCPFVeterinario.Location = New System.Drawing.Point(270, 24)
        Me.MtxtFiltroCPFVeterinario.Mask = "000.000.000-00"
        Me.MtxtFiltroCPFVeterinario.Name = "MtxtFiltroCPFVeterinario"
        Me.MtxtFiltroCPFVeterinario.Size = New System.Drawing.Size(87, 20)
        Me.MtxtFiltroCPFVeterinario.TabIndex = 95
        Me.MtxtFiltroCPFVeterinario.Visible = False
        '
        'cmbFiltroVeterinario
        '
        Me.cmbFiltroVeterinario.FormattingEnabled = True
        Me.cmbFiltroVeterinario.Location = New System.Drawing.Point(140, 23)
        Me.cmbFiltroVeterinario.Name = "cmbFiltroVeterinario"
        Me.cmbFiltroVeterinario.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltroVeterinario.TabIndex = 94
        '
        'txtCodVeterinario
        '
        Me.txtCodVeterinario.Enabled = False
        Me.txtCodVeterinario.Location = New System.Drawing.Point(26, 219)
        Me.txtCodVeterinario.Name = "txtCodVeterinario"
        Me.txtCodVeterinario.Size = New System.Drawing.Size(84, 20)
        Me.txtCodVeterinario.TabIndex = 71
        '
        'lbNomeVeterinario
        '
        Me.lbNomeVeterinario.AutoSize = True
        Me.lbNomeVeterinario.Location = New System.Drawing.Point(130, 203)
        Me.lbNomeVeterinario.Name = "lbNomeVeterinario"
        Me.lbNomeVeterinario.Size = New System.Drawing.Size(35, 13)
        Me.lbNomeVeterinario.TabIndex = 79
        Me.lbNomeVeterinario.Text = "Nome"
        '
        'lbCodigoVeterinario
        '
        Me.lbCodigoVeterinario.AutoSize = True
        Me.lbCodigoVeterinario.Location = New System.Drawing.Point(24, 200)
        Me.lbCodigoVeterinario.Name = "lbCodigoVeterinario"
        Me.lbCodigoVeterinario.Size = New System.Drawing.Size(40, 13)
        Me.lbCodigoVeterinario.TabIndex = 93
        Me.lbCodigoVeterinario.Text = "Código"
        '
        'txtNomeVeterinario
        '
        Me.txtNomeVeterinario.Enabled = False
        Me.txtNomeVeterinario.Location = New System.Drawing.Point(133, 219)
        Me.txtNomeVeterinario.Name = "txtNomeVeterinario"
        Me.txtNomeVeterinario.Size = New System.Drawing.Size(354, 20)
        Me.txtNomeVeterinario.TabIndex = 72
        '
        'gpxAnimal
        '
        Me.gpxAnimal.Controls.Add(Me.MtxtFiltroDataAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtCaminhoImagem)
        Me.gpxAnimal.Controls.Add(Me.cmbFiltroAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtCastracaoAnimal)
        Me.gpxAnimal.Controls.Add(Me.btnBuscaAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtPorteAnimal)
        Me.gpxAnimal.Controls.Add(Me.dgvAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbCodAnimal)
        Me.gpxAnimal.Controls.Add(Me.pbxAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbPorteAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtNomeAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtConsultaAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtCodAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbCodigoAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbNomeAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbCastracaoAnimal)
        Me.gpxAnimal.Location = New System.Drawing.Point(20, 339)
        Me.gpxAnimal.Name = "gpxAnimal"
        Me.gpxAnimal.Size = New System.Drawing.Size(650, 382)
        Me.gpxAnimal.TabIndex = 65
        Me.gpxAnimal.TabStop = False
        Me.gpxAnimal.Text = "Dados do animal"
        '
        'MtxtFiltroDataAnimal
        '
        Me.MtxtFiltroDataAnimal.Location = New System.Drawing.Point(255, 23)
        Me.MtxtFiltroDataAnimal.Mask = "00/00/0000"
        Me.MtxtFiltroDataAnimal.Name = "MtxtFiltroDataAnimal"
        Me.MtxtFiltroDataAnimal.Size = New System.Drawing.Size(72, 20)
        Me.MtxtFiltroDataAnimal.TabIndex = 97
        Me.MtxtFiltroDataAnimal.ValidatingType = GetType(Date)
        Me.MtxtFiltroDataAnimal.Visible = False
        '
        'txtCaminhoImagem
        '
        Me.txtCaminhoImagem.Location = New System.Drawing.Point(194, 322)
        Me.txtCaminhoImagem.Name = "txtCaminhoImagem"
        Me.txtCaminhoImagem.Size = New System.Drawing.Size(360, 20)
        Me.txtCaminhoImagem.TabIndex = 95
        Me.txtCaminhoImagem.Visible = False
        '
        'cmbFiltroAnimal
        '
        Me.cmbFiltroAnimal.FormattingEnabled = True
        Me.cmbFiltroAnimal.Location = New System.Drawing.Point(118, 23)
        Me.cmbFiltroAnimal.Name = "cmbFiltroAnimal"
        Me.cmbFiltroAnimal.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltroAnimal.TabIndex = 96
        '
        'txtCastracaoAnimal
        '
        Me.txtCastracaoAnimal.Enabled = False
        Me.txtCastracaoAnimal.Location = New System.Drawing.Point(327, 285)
        Me.txtCastracaoAnimal.Name = "txtCastracaoAnimal"
        Me.txtCastracaoAnimal.Size = New System.Drawing.Size(52, 20)
        Me.txtCastracaoAnimal.TabIndex = 94
        '
        'btnBuscaAnimal
        '
        Me.btnBuscaAnimal.BackColor = System.Drawing.Color.White
        Me.btnBuscaAnimal.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBuscaAnimal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaAnimal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscaAnimal.Location = New System.Drawing.Point(436, 21)
        Me.btnBuscaAnimal.Name = "btnBuscaAnimal"
        Me.btnBuscaAnimal.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscaAnimal.TabIndex = 4
        Me.btnBuscaAnimal.Text = "Buscar"
        Me.btnBuscaAnimal.UseVisualStyleBackColor = False
        Me.btnBuscaAnimal.Visible = False
        '
        'txtPorteAnimal
        '
        Me.txtPorteAnimal.Enabled = False
        Me.txtPorteAnimal.Location = New System.Drawing.Point(194, 285)
        Me.txtPorteAnimal.Name = "txtPorteAnimal"
        Me.txtPorteAnimal.Size = New System.Drawing.Size(100, 20)
        Me.txtPorteAnimal.TabIndex = 93
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
        Me.dgvAnimal.Location = New System.Drawing.Point(21, 56)
        Me.dgvAnimal.MultiSelect = False
        Me.dgvAnimal.Name = "dgvAnimal"
        Me.dgvAnimal.ReadOnly = True
        Me.dgvAnimal.RowHeadersVisible = False
        Me.dgvAnimal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvAnimal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAnimal.Size = New System.Drawing.Size(608, 140)
        Me.dgvAnimal.TabIndex = 64
        '
        'pbxAnimal
        '
        Me.pbxAnimal.BackColor = System.Drawing.Color.White
        Me.pbxAnimal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxAnimal.Location = New System.Drawing.Point(20, 213)
        Me.pbxAnimal.Name = "pbxAnimal"
        Me.pbxAnimal.Size = New System.Drawing.Size(147, 146)
        Me.pbxAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxAnimal.TabIndex = 90
        Me.pbxAnimal.TabStop = False
        '
        'lbPorteAnimal
        '
        Me.lbPorteAnimal.AutoSize = True
        Me.lbPorteAnimal.Location = New System.Drawing.Point(191, 269)
        Me.lbPorteAnimal.Name = "lbPorteAnimal"
        Me.lbPorteAnimal.Size = New System.Drawing.Size(32, 13)
        Me.lbPorteAnimal.TabIndex = 84
        Me.lbPorteAnimal.Text = "Porte"
        '
        'txtNomeAnimal
        '
        Me.txtNomeAnimal.Enabled = False
        Me.txtNomeAnimal.Location = New System.Drawing.Point(300, 230)
        Me.txtNomeAnimal.Name = "txtNomeAnimal"
        Me.txtNomeAnimal.Size = New System.Drawing.Size(221, 20)
        Me.txtNomeAnimal.TabIndex = 67
        '
        'txtCodAnimal
        '
        Me.txtCodAnimal.Enabled = False
        Me.txtCodAnimal.Location = New System.Drawing.Point(194, 230)
        Me.txtCodAnimal.Name = "txtCodAnimal"
        Me.txtCodAnimal.Size = New System.Drawing.Size(84, 20)
        Me.txtCodAnimal.TabIndex = 66
        '
        'lbCodigoAnimal
        '
        Me.lbCodigoAnimal.AutoSize = True
        Me.lbCodigoAnimal.Location = New System.Drawing.Point(191, 214)
        Me.lbCodigoAnimal.Name = "lbCodigoAnimal"
        Me.lbCodigoAnimal.Size = New System.Drawing.Size(40, 13)
        Me.lbCodigoAnimal.TabIndex = 80
        Me.lbCodigoAnimal.Text = "Código"
        '
        'lbNomeAnimal
        '
        Me.lbNomeAnimal.AutoSize = True
        Me.lbNomeAnimal.Location = New System.Drawing.Point(297, 214)
        Me.lbNomeAnimal.Name = "lbNomeAnimal"
        Me.lbNomeAnimal.Size = New System.Drawing.Size(35, 13)
        Me.lbNomeAnimal.TabIndex = 83
        Me.lbNomeAnimal.Text = "Nome"
        '
        'lbCastracaoAnimal
        '
        Me.lbCastracaoAnimal.AutoSize = True
        Me.lbCastracaoAnimal.Location = New System.Drawing.Point(324, 269)
        Me.lbCastracaoAnimal.Name = "lbCastracaoAnimal"
        Me.lbCastracaoAnimal.Size = New System.Drawing.Size(55, 13)
        Me.lbCastracaoAnimal.TabIndex = 89
        Me.lbCastracaoAnimal.Text = "Castração"
        '
        'gpxConsulta
        '
        Me.gpxConsulta.Controls.Add(Me.txtCodConsulta)
        Me.gpxConsulta.Controls.Add(Me.lbCodConsulta)
        Me.gpxConsulta.Controls.Add(Me.txtAno)
        Me.gpxConsulta.Controls.Add(Me.lbDataConsulta)
        Me.gpxConsulta.Controls.Add(Me.txtMes)
        Me.gpxConsulta.Controls.Add(Me.MtxtDataConsulta)
        Me.gpxConsulta.Controls.Add(Me.lbDetalhesConsulta)
        Me.gpxConsulta.Controls.Add(Me.txtDetalhesConsulta)
        Me.gpxConsulta.Location = New System.Drawing.Point(683, 70)
        Me.gpxConsulta.Name = "gpxConsulta"
        Me.gpxConsulta.Size = New System.Drawing.Size(650, 250)
        Me.gpxConsulta.TabIndex = 94
        Me.gpxConsulta.TabStop = False
        Me.gpxConsulta.Text = "Dados da consulta"
        '
        'txtCodConsulta
        '
        Me.txtCodConsulta.Enabled = False
        Me.txtCodConsulta.Location = New System.Drawing.Point(136, 40)
        Me.txtCodConsulta.Name = "txtCodConsulta"
        Me.txtCodConsulta.Size = New System.Drawing.Size(100, 20)
        Me.txtCodConsulta.TabIndex = 99
        '
        'lbCodConsulta
        '
        Me.lbCodConsulta.AutoSize = True
        Me.lbCodConsulta.Location = New System.Drawing.Point(133, 24)
        Me.lbCodConsulta.Name = "lbCodConsulta"
        Me.lbCodConsulta.Size = New System.Drawing.Size(83, 13)
        Me.lbCodConsulta.TabIndex = 98
        Me.lbCodConsulta.Text = "Código consulta"
        '
        'txtAno
        '
        Me.txtAno.Location = New System.Drawing.Point(336, 40)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(100, 20)
        Me.txtAno.TabIndex = 97
        Me.txtAno.Visible = False
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(336, 14)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(100, 20)
        Me.txtMes.TabIndex = 96
        Me.txtMes.Visible = False
        '
        'pbxBanner
        '
        Me.pbxBanner.BackgroundImage = Global.sistechy.My.Resources.Resources.banner_consulta_fw
        Me.pbxBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxBanner.Location = New System.Drawing.Point(-5, -1)
        Me.pbxBanner.Name = "pbxBanner"
        Me.pbxBanner.Size = New System.Drawing.Size(1366, 55)
        Me.pbxBanner.TabIndex = 95
        Me.pbxBanner.TabStop = False
        '
        'btnSalvarConsulta
        '
        Me.btnSalvarConsulta.BackColor = System.Drawing.Color.White
        Me.btnSalvarConsulta.BackgroundImage = Global.sistechy.My.Resources.Resources.salvar_consulta_fw
        Me.btnSalvarConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalvarConsulta.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSalvarConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnSalvarConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnSalvarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvarConsulta.Location = New System.Drawing.Point(1168, 671)
        Me.btnSalvarConsulta.Name = "btnSalvarConsulta"
        Me.btnSalvarConsulta.Size = New System.Drawing.Size(170, 50)
        Me.btnSalvarConsulta.TabIndex = 7
        Me.btnSalvarConsulta.UseVisualStyleBackColor = False
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
        Me.btnCancelar.Location = New System.Drawing.Point(992, 671)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(170, 50)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'frmConsultaGeral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1350, 739)
        Me.Controls.Add(Me.pbxBanner)
        Me.Controls.Add(Me.gpxConsulta)
        Me.Controls.Add(Me.btnSalvarConsulta)
        Me.Controls.Add(Me.gpxAnimal)
        Me.Controls.Add(Me.gpxVeterinario)
        Me.Controls.Add(Me.btnCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmConsultaGeral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta"
        CType(Me.dgvVeterinario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxVeterinario.ResumeLayout(False)
        Me.gpxVeterinario.PerformLayout()
        Me.gpxAnimal.ResumeLayout(False)
        Me.gpxAnimal.PerformLayout()
        CType(Me.dgvAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxConsulta.ResumeLayout(False)
        Me.gpxConsulta.PerformLayout()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbDataConsulta As System.Windows.Forms.Label
    Friend WithEvents lbDetalhesConsulta As System.Windows.Forms.Label
    Friend WithEvents txtConsultaVeterinario As System.Windows.Forms.TextBox
    Friend WithEvents lbCodVeterinario As System.Windows.Forms.Label
    Friend WithEvents lbCodAnimal As System.Windows.Forms.Label
    Friend WithEvents txtConsultaAnimal As System.Windows.Forms.TextBox
    Friend WithEvents MtxtDataConsulta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDetalhesConsulta As System.Windows.Forms.RichTextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnBuscaVeterinario As System.Windows.Forms.Button
    Friend WithEvents dgvVeterinario As System.Windows.Forms.DataGridView
    Friend WithEvents gpxVeterinario As System.Windows.Forms.GroupBox
    Friend WithEvents gpxAnimal As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscaAnimal As System.Windows.Forms.Button
    Friend WithEvents dgvAnimal As System.Windows.Forms.DataGridView
    Friend WithEvents pbxAnimal As System.Windows.Forms.PictureBox
    Friend WithEvents lbCodigoAnimal As System.Windows.Forms.Label
    Friend WithEvents lbNomeAnimal As System.Windows.Forms.Label
    Friend WithEvents lbPorteAnimal As System.Windows.Forms.Label
    Friend WithEvents lbCastracaoAnimal As System.Windows.Forms.Label
    Friend WithEvents txtCodAnimal As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeAnimal As System.Windows.Forms.TextBox
    Friend WithEvents txtCodVeterinario As System.Windows.Forms.TextBox
    Friend WithEvents lbNomeVeterinario As System.Windows.Forms.Label
    Friend WithEvents lbCodigoVeterinario As System.Windows.Forms.Label
    Friend WithEvents txtNomeVeterinario As System.Windows.Forms.TextBox
    Friend WithEvents txtCastracaoAnimal As System.Windows.Forms.TextBox
    Friend WithEvents txtPorteAnimal As System.Windows.Forms.TextBox
    Friend WithEvents btnSalvarConsulta As System.Windows.Forms.Button
    Friend WithEvents txtCaminhoImagem As System.Windows.Forms.TextBox
    Friend WithEvents gpxConsulta As System.Windows.Forms.GroupBox
    Friend WithEvents pbxBanner As System.Windows.Forms.PictureBox
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents txtAno As System.Windows.Forms.TextBox
    Friend WithEvents MtxtFiltroDataAnimal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbFiltroAnimal As System.Windows.Forms.ComboBox
    Friend WithEvents MtxtFiltroDataVeterinario As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtFiltroCPFVeterinario As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbFiltroVeterinario As System.Windows.Forms.ComboBox
    Friend WithEvents txtCodConsulta As System.Windows.Forms.TextBox
    Friend WithEvents lbCodConsulta As System.Windows.Forms.Label
End Class
