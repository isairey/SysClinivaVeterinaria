<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNovoHorario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNovoHorario))
        Me.lbCodAgendamento = New System.Windows.Forms.Label()
        Me.lbTipoAgendamento = New System.Windows.Forms.Label()
        Me.lbDataAgendamento = New System.Windows.Forms.Label()
        Me.lbStatusAgendamento = New System.Windows.Forms.Label()
        Me.txtCodAgendamento = New System.Windows.Forms.TextBox()
        Me.gpxAnimal = New System.Windows.Forms.GroupBox()
        Me.MtxtFiltroDataAnimal = New System.Windows.Forms.MaskedTextBox()
        Me.cmbFiltroAnimal = New System.Windows.Forms.ComboBox()
        Me.txtConsultaAnimal = New System.Windows.Forms.TextBox()
        Me.txtNomeAnimal = New System.Windows.Forms.TextBox()
        Me.txtCodAnimal = New System.Windows.Forms.TextBox()
        Me.lbNomeAnimal = New System.Windows.Forms.Label()
        Me.lbCodigoAnimal = New System.Windows.Forms.Label()
        Me.dgvAnimal = New System.Windows.Forms.DataGridView()
        Me.btnBuscaAnimal = New System.Windows.Forms.Button()
        Me.lbBuscaAnimal = New System.Windows.Forms.Label()
        Me.gpxCliente = New System.Windows.Forms.GroupBox()
        Me.MtxtFiltroCPFCli = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtFiltroDataCli = New System.Windows.Forms.MaskedTextBox()
        Me.cmbFiltroCli = New System.Windows.Forms.ComboBox()
        Me.txtConsultaCli = New System.Windows.Forms.TextBox()
        Me.txtNomeCli = New System.Windows.Forms.TextBox()
        Me.txtCodCli = New System.Windows.Forms.TextBox()
        Me.lbNomeCli = New System.Windows.Forms.Label()
        Me.lbCodigoCli = New System.Windows.Forms.Label()
        Me.dgvCli = New System.Windows.Forms.DataGridView()
        Me.btnBuscaCli = New System.Windows.Forms.Button()
        Me.lbBuscaCli = New System.Windows.Forms.Label()
        Me.gpxFunc = New System.Windows.Forms.GroupBox()
        Me.MtxtFiltroDataFunc = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtFiltroCPFFunc = New System.Windows.Forms.MaskedTextBox()
        Me.cmbFiltroFunc = New System.Windows.Forms.ComboBox()
        Me.txtConsultaFunc = New System.Windows.Forms.TextBox()
        Me.txtNomeFunc = New System.Windows.Forms.TextBox()
        Me.txtCodFunc = New System.Windows.Forms.TextBox()
        Me.lbNomeFunc = New System.Windows.Forms.Label()
        Me.lbCodigoFunc = New System.Windows.Forms.Label()
        Me.dgvFunc = New System.Windows.Forms.DataGridView()
        Me.btnBuscaFunc = New System.Windows.Forms.Button()
        Me.lbBuscaFunc = New System.Windows.Forms.Label()
        Me.gpxAgendamento = New System.Windows.Forms.GroupBox()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.cmbStatusAgendamento = New System.Windows.Forms.ComboBox()
        Me.cmbTipoAtendimento = New System.Windows.Forms.ComboBox()
        Me.MtxtDataAgendamento = New System.Windows.Forms.MaskedTextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSalvarNovoHorario = New System.Windows.Forms.Button()
        Me.pbxBanner = New System.Windows.Forms.PictureBox()
        Me.gpxAnimal.SuspendLayout()
        CType(Me.dgvAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxCliente.SuspendLayout()
        CType(Me.dgvCli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxFunc.SuspendLayout()
        CType(Me.dgvFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxAgendamento.SuspendLayout()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbCodAgendamento
        '
        Me.lbCodAgendamento.AutoSize = True
        Me.lbCodAgendamento.Location = New System.Drawing.Point(17, 29)
        Me.lbCodAgendamento.Name = "lbCodAgendamento"
        Me.lbCodAgendamento.Size = New System.Drawing.Size(108, 13)
        Me.lbCodAgendamento.TabIndex = 0
        Me.lbCodAgendamento.Text = "Código agendamento"
        '
        'lbTipoAgendamento
        '
        Me.lbTipoAgendamento.AutoSize = True
        Me.lbTipoAgendamento.Location = New System.Drawing.Point(269, 29)
        Me.lbTipoAgendamento.Name = "lbTipoAgendamento"
        Me.lbTipoAgendamento.Size = New System.Drawing.Size(111, 13)
        Me.lbTipoAgendamento.TabIndex = 2
        Me.lbTipoAgendamento.Text = "Tipo de agendamento"
        '
        'lbDataAgendamento
        '
        Me.lbDataAgendamento.AutoSize = True
        Me.lbDataAgendamento.Location = New System.Drawing.Point(150, 29)
        Me.lbDataAgendamento.Name = "lbDataAgendamento"
        Me.lbDataAgendamento.Size = New System.Drawing.Size(98, 13)
        Me.lbDataAgendamento.TabIndex = 4
        Me.lbDataAgendamento.Text = "Data agendamento"
        '
        'lbStatusAgendamento
        '
        Me.lbStatusAgendamento.AutoSize = True
        Me.lbStatusAgendamento.Location = New System.Drawing.Point(17, 80)
        Me.lbStatusAgendamento.Name = "lbStatusAgendamento"
        Me.lbStatusAgendamento.Size = New System.Drawing.Size(105, 13)
        Me.lbStatusAgendamento.TabIndex = 5
        Me.lbStatusAgendamento.Text = "Status agendamento"
        '
        'txtCodAgendamento
        '
        Me.txtCodAgendamento.Enabled = False
        Me.txtCodAgendamento.Location = New System.Drawing.Point(20, 45)
        Me.txtCodAgendamento.Name = "txtCodAgendamento"
        Me.txtCodAgendamento.Size = New System.Drawing.Size(100, 20)
        Me.txtCodAgendamento.TabIndex = 6
        '
        'gpxAnimal
        '
        Me.gpxAnimal.Controls.Add(Me.MtxtFiltroDataAnimal)
        Me.gpxAnimal.Controls.Add(Me.cmbFiltroAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtConsultaAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtNomeAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtCodAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbNomeAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbCodigoAnimal)
        Me.gpxAnimal.Controls.Add(Me.dgvAnimal)
        Me.gpxAnimal.Controls.Add(Me.btnBuscaAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbBuscaAnimal)
        Me.gpxAnimal.Location = New System.Drawing.Point(657, 69)
        Me.gpxAnimal.Name = "gpxAnimal"
        Me.gpxAnimal.Size = New System.Drawing.Size(629, 216)
        Me.gpxAnimal.TabIndex = 7
        Me.gpxAnimal.TabStop = False
        Me.gpxAnimal.Text = "Dados do animal"
        '
        'MtxtFiltroDataAnimal
        '
        Me.MtxtFiltroDataAnimal.Location = New System.Drawing.Point(224, 21)
        Me.MtxtFiltroDataAnimal.Mask = "00/00/0000"
        Me.MtxtFiltroDataAnimal.Name = "MtxtFiltroDataAnimal"
        Me.MtxtFiltroDataAnimal.Size = New System.Drawing.Size(72, 20)
        Me.MtxtFiltroDataAnimal.TabIndex = 23
        Me.MtxtFiltroDataAnimal.ValidatingType = GetType(Date)
        Me.MtxtFiltroDataAnimal.Visible = False
        '
        'cmbFiltroAnimal
        '
        Me.cmbFiltroAnimal.FormattingEnabled = True
        Me.cmbFiltroAnimal.Location = New System.Drawing.Point(88, 20)
        Me.cmbFiltroAnimal.Name = "cmbFiltroAnimal"
        Me.cmbFiltroAnimal.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltroAnimal.TabIndex = 22
        '
        'txtConsultaAnimal
        '
        Me.txtConsultaAnimal.Location = New System.Drawing.Point(224, 21)
        Me.txtConsultaAnimal.Name = "txtConsultaAnimal"
        Me.txtConsultaAnimal.Size = New System.Drawing.Size(152, 20)
        Me.txtConsultaAnimal.TabIndex = 21
        Me.txtConsultaAnimal.Visible = False
        '
        'txtNomeAnimal
        '
        Me.txtNomeAnimal.Enabled = False
        Me.txtNomeAnimal.Location = New System.Drawing.Point(153, 180)
        Me.txtNomeAnimal.Name = "txtNomeAnimal"
        Me.txtNomeAnimal.Size = New System.Drawing.Size(307, 20)
        Me.txtNomeAnimal.TabIndex = 15
        '
        'txtCodAnimal
        '
        Me.txtCodAnimal.Enabled = False
        Me.txtCodAnimal.Location = New System.Drawing.Point(24, 180)
        Me.txtCodAnimal.Name = "txtCodAnimal"
        Me.txtCodAnimal.Size = New System.Drawing.Size(100, 20)
        Me.txtCodAnimal.TabIndex = 14
        '
        'lbNomeAnimal
        '
        Me.lbNomeAnimal.AutoSize = True
        Me.lbNomeAnimal.Location = New System.Drawing.Point(150, 164)
        Me.lbNomeAnimal.Name = "lbNomeAnimal"
        Me.lbNomeAnimal.Size = New System.Drawing.Size(35, 13)
        Me.lbNomeAnimal.TabIndex = 13
        Me.lbNomeAnimal.Text = "Nome"
        '
        'lbCodigoAnimal
        '
        Me.lbCodigoAnimal.AutoSize = True
        Me.lbCodigoAnimal.Location = New System.Drawing.Point(21, 164)
        Me.lbCodigoAnimal.Name = "lbCodigoAnimal"
        Me.lbCodigoAnimal.Size = New System.Drawing.Size(40, 13)
        Me.lbCodigoAnimal.TabIndex = 12
        Me.lbCodigoAnimal.Text = "Código"
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
        Me.dgvAnimal.Location = New System.Drawing.Point(24, 49)
        Me.dgvAnimal.Name = "dgvAnimal"
        Me.dgvAnimal.ReadOnly = True
        Me.dgvAnimal.RowHeadersVisible = False
        Me.dgvAnimal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvAnimal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAnimal.Size = New System.Drawing.Size(583, 109)
        Me.dgvAnimal.TabIndex = 11
        '
        'btnBuscaAnimal
        '
        Me.btnBuscaAnimal.BackColor = System.Drawing.Color.White
        Me.btnBuscaAnimal.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBuscaAnimal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaAnimal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscaAnimal.Location = New System.Drawing.Point(386, 20)
        Me.btnBuscaAnimal.Name = "btnBuscaAnimal"
        Me.btnBuscaAnimal.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscaAnimal.TabIndex = 4
        Me.btnBuscaAnimal.Text = "Buscar"
        Me.btnBuscaAnimal.UseVisualStyleBackColor = False
        Me.btnBuscaAnimal.Visible = False
        '
        'lbBuscaAnimal
        '
        Me.lbBuscaAnimal.AutoSize = True
        Me.lbBuscaAnimal.Location = New System.Drawing.Point(21, 24)
        Me.lbBuscaAnimal.Name = "lbBuscaAnimal"
        Me.lbBuscaAnimal.Size = New System.Drawing.Size(61, 13)
        Me.lbBuscaAnimal.TabIndex = 8
        Me.lbBuscaAnimal.Text = "Buscar por:"
        '
        'gpxCliente
        '
        Me.gpxCliente.Controls.Add(Me.MtxtFiltroCPFCli)
        Me.gpxCliente.Controls.Add(Me.MtxtFiltroDataCli)
        Me.gpxCliente.Controls.Add(Me.cmbFiltroCli)
        Me.gpxCliente.Controls.Add(Me.txtConsultaCli)
        Me.gpxCliente.Controls.Add(Me.txtNomeCli)
        Me.gpxCliente.Controls.Add(Me.txtCodCli)
        Me.gpxCliente.Controls.Add(Me.lbNomeCli)
        Me.gpxCliente.Controls.Add(Me.lbCodigoCli)
        Me.gpxCliente.Controls.Add(Me.dgvCli)
        Me.gpxCliente.Controls.Add(Me.btnBuscaCli)
        Me.gpxCliente.Controls.Add(Me.lbBuscaCli)
        Me.gpxCliente.Location = New System.Drawing.Point(12, 69)
        Me.gpxCliente.Name = "gpxCliente"
        Me.gpxCliente.Size = New System.Drawing.Size(629, 216)
        Me.gpxCliente.TabIndex = 8
        Me.gpxCliente.TabStop = False
        Me.gpxCliente.Text = "Dados do cliente"
        '
        'MtxtFiltroCPFCli
        '
        Me.MtxtFiltroCPFCli.Location = New System.Drawing.Point(223, 21)
        Me.MtxtFiltroCPFCli.Mask = "000.000.000-00"
        Me.MtxtFiltroCPFCli.Name = "MtxtFiltroCPFCli"
        Me.MtxtFiltroCPFCli.Size = New System.Drawing.Size(100, 20)
        Me.MtxtFiltroCPFCli.TabIndex = 30
        Me.MtxtFiltroCPFCli.Visible = False
        '
        'MtxtFiltroDataCli
        '
        Me.MtxtFiltroDataCli.Location = New System.Drawing.Point(223, 21)
        Me.MtxtFiltroDataCli.Mask = "00/00/0000"
        Me.MtxtFiltroDataCli.Name = "MtxtFiltroDataCli"
        Me.MtxtFiltroDataCli.Size = New System.Drawing.Size(72, 20)
        Me.MtxtFiltroDataCli.TabIndex = 29
        Me.MtxtFiltroDataCli.ValidatingType = GetType(Date)
        Me.MtxtFiltroDataCli.Visible = False
        '
        'cmbFiltroCli
        '
        Me.cmbFiltroCli.FormattingEnabled = True
        Me.cmbFiltroCli.Location = New System.Drawing.Point(88, 21)
        Me.cmbFiltroCli.Name = "cmbFiltroCli"
        Me.cmbFiltroCli.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltroCli.TabIndex = 28
        '
        'txtConsultaCli
        '
        Me.txtConsultaCli.Location = New System.Drawing.Point(223, 21)
        Me.txtConsultaCli.Name = "txtConsultaCli"
        Me.txtConsultaCli.Size = New System.Drawing.Size(152, 20)
        Me.txtConsultaCli.TabIndex = 27
        Me.txtConsultaCli.Visible = False
        '
        'txtNomeCli
        '
        Me.txtNomeCli.Enabled = False
        Me.txtNomeCli.Location = New System.Drawing.Point(153, 184)
        Me.txtNomeCli.Name = "txtNomeCli"
        Me.txtNomeCli.Size = New System.Drawing.Size(307, 20)
        Me.txtNomeCli.TabIndex = 7
        '
        'txtCodCli
        '
        Me.txtCodCli.Enabled = False
        Me.txtCodCli.Location = New System.Drawing.Point(24, 184)
        Me.txtCodCli.Name = "txtCodCli"
        Me.txtCodCli.Size = New System.Drawing.Size(100, 20)
        Me.txtCodCli.TabIndex = 6
        '
        'lbNomeCli
        '
        Me.lbNomeCli.AutoSize = True
        Me.lbNomeCli.Location = New System.Drawing.Point(150, 168)
        Me.lbNomeCli.Name = "lbNomeCli"
        Me.lbNomeCli.Size = New System.Drawing.Size(35, 13)
        Me.lbNomeCli.TabIndex = 5
        Me.lbNomeCli.Text = "Nome"
        '
        'lbCodigoCli
        '
        Me.lbCodigoCli.AutoSize = True
        Me.lbCodigoCli.Location = New System.Drawing.Point(21, 168)
        Me.lbCodigoCli.Name = "lbCodigoCli"
        Me.lbCodigoCli.Size = New System.Drawing.Size(40, 13)
        Me.lbCodigoCli.TabIndex = 4
        Me.lbCodigoCli.Text = "Código"
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
        Me.dgvCli.Location = New System.Drawing.Point(24, 49)
        Me.dgvCli.Name = "dgvCli"
        Me.dgvCli.ReadOnly = True
        Me.dgvCli.RowHeadersVisible = False
        Me.dgvCli.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvCli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCli.Size = New System.Drawing.Size(583, 109)
        Me.dgvCli.TabIndex = 3
        '
        'btnBuscaCli
        '
        Me.btnBuscaCli.BackColor = System.Drawing.Color.White
        Me.btnBuscaCli.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBuscaCli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscaCli.Location = New System.Drawing.Point(387, 20)
        Me.btnBuscaCli.Name = "btnBuscaCli"
        Me.btnBuscaCli.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscaCli.TabIndex = 2
        Me.btnBuscaCli.Text = "Buscar"
        Me.btnBuscaCli.UseVisualStyleBackColor = False
        Me.btnBuscaCli.Visible = False
        '
        'lbBuscaCli
        '
        Me.lbBuscaCli.AutoSize = True
        Me.lbBuscaCli.Location = New System.Drawing.Point(21, 26)
        Me.lbBuscaCli.Name = "lbBuscaCli"
        Me.lbBuscaCli.Size = New System.Drawing.Size(61, 13)
        Me.lbBuscaCli.TabIndex = 0
        Me.lbBuscaCli.Text = "Buscar por:"
        '
        'gpxFunc
        '
        Me.gpxFunc.Controls.Add(Me.MtxtFiltroDataFunc)
        Me.gpxFunc.Controls.Add(Me.MtxtFiltroCPFFunc)
        Me.gpxFunc.Controls.Add(Me.cmbFiltroFunc)
        Me.gpxFunc.Controls.Add(Me.txtConsultaFunc)
        Me.gpxFunc.Controls.Add(Me.txtNomeFunc)
        Me.gpxFunc.Controls.Add(Me.txtCodFunc)
        Me.gpxFunc.Controls.Add(Me.lbNomeFunc)
        Me.gpxFunc.Controls.Add(Me.lbCodigoFunc)
        Me.gpxFunc.Controls.Add(Me.dgvFunc)
        Me.gpxFunc.Controls.Add(Me.btnBuscaFunc)
        Me.gpxFunc.Controls.Add(Me.lbBuscaFunc)
        Me.gpxFunc.Location = New System.Drawing.Point(12, 300)
        Me.gpxFunc.Name = "gpxFunc"
        Me.gpxFunc.Size = New System.Drawing.Size(629, 216)
        Me.gpxFunc.TabIndex = 9
        Me.gpxFunc.TabStop = False
        Me.gpxFunc.Text = "Dados do funcionário"
        '
        'MtxtFiltroDataFunc
        '
        Me.MtxtFiltroDataFunc.Location = New System.Drawing.Point(230, 20)
        Me.MtxtFiltroDataFunc.Mask = "00/00/0000"
        Me.MtxtFiltroDataFunc.Name = "MtxtFiltroDataFunc"
        Me.MtxtFiltroDataFunc.Size = New System.Drawing.Size(73, 20)
        Me.MtxtFiltroDataFunc.TabIndex = 31
        Me.MtxtFiltroDataFunc.ValidatingType = GetType(Date)
        Me.MtxtFiltroDataFunc.Visible = False
        '
        'MtxtFiltroCPFFunc
        '
        Me.MtxtFiltroCPFFunc.Location = New System.Drawing.Point(230, 20)
        Me.MtxtFiltroCPFFunc.Mask = "000.000.000-00"
        Me.MtxtFiltroCPFFunc.Name = "MtxtFiltroCPFFunc"
        Me.MtxtFiltroCPFFunc.Size = New System.Drawing.Size(87, 20)
        Me.MtxtFiltroCPFFunc.TabIndex = 30
        Me.MtxtFiltroCPFFunc.Visible = False
        '
        'cmbFiltroFunc
        '
        Me.cmbFiltroFunc.FormattingEnabled = True
        Me.cmbFiltroFunc.Location = New System.Drawing.Point(88, 19)
        Me.cmbFiltroFunc.Name = "cmbFiltroFunc"
        Me.cmbFiltroFunc.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltroFunc.TabIndex = 29
        '
        'txtConsultaFunc
        '
        Me.txtConsultaFunc.Location = New System.Drawing.Point(230, 20)
        Me.txtConsultaFunc.Name = "txtConsultaFunc"
        Me.txtConsultaFunc.Size = New System.Drawing.Size(145, 20)
        Me.txtConsultaFunc.TabIndex = 28
        Me.txtConsultaFunc.Visible = False
        '
        'txtNomeFunc
        '
        Me.txtNomeFunc.Enabled = False
        Me.txtNomeFunc.Location = New System.Drawing.Point(153, 180)
        Me.txtNomeFunc.Name = "txtNomeFunc"
        Me.txtNomeFunc.Size = New System.Drawing.Size(307, 20)
        Me.txtNomeFunc.TabIndex = 15
        '
        'txtCodFunc
        '
        Me.txtCodFunc.Enabled = False
        Me.txtCodFunc.Location = New System.Drawing.Point(24, 180)
        Me.txtCodFunc.Name = "txtCodFunc"
        Me.txtCodFunc.Size = New System.Drawing.Size(100, 20)
        Me.txtCodFunc.TabIndex = 14
        '
        'lbNomeFunc
        '
        Me.lbNomeFunc.AutoSize = True
        Me.lbNomeFunc.Location = New System.Drawing.Point(150, 164)
        Me.lbNomeFunc.Name = "lbNomeFunc"
        Me.lbNomeFunc.Size = New System.Drawing.Size(35, 13)
        Me.lbNomeFunc.TabIndex = 13
        Me.lbNomeFunc.Text = "Nome"
        '
        'lbCodigoFunc
        '
        Me.lbCodigoFunc.AutoSize = True
        Me.lbCodigoFunc.Location = New System.Drawing.Point(21, 164)
        Me.lbCodigoFunc.Name = "lbCodigoFunc"
        Me.lbCodigoFunc.Size = New System.Drawing.Size(40, 13)
        Me.lbCodigoFunc.TabIndex = 12
        Me.lbCodigoFunc.Text = "Código"
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
        Me.dgvFunc.Location = New System.Drawing.Point(24, 49)
        Me.dgvFunc.Name = "dgvFunc"
        Me.dgvFunc.ReadOnly = True
        Me.dgvFunc.RowHeadersVisible = False
        Me.dgvFunc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvFunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFunc.Size = New System.Drawing.Size(583, 109)
        Me.dgvFunc.TabIndex = 11
        '
        'btnBuscaFunc
        '
        Me.btnBuscaFunc.BackColor = System.Drawing.Color.White
        Me.btnBuscaFunc.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBuscaFunc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscaFunc.Location = New System.Drawing.Point(387, 19)
        Me.btnBuscaFunc.Name = "btnBuscaFunc"
        Me.btnBuscaFunc.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscaFunc.TabIndex = 6
        Me.btnBuscaFunc.Text = "Buscar"
        Me.btnBuscaFunc.UseVisualStyleBackColor = False
        Me.btnBuscaFunc.Visible = False
        '
        'lbBuscaFunc
        '
        Me.lbBuscaFunc.AutoSize = True
        Me.lbBuscaFunc.Location = New System.Drawing.Point(21, 22)
        Me.lbBuscaFunc.Name = "lbBuscaFunc"
        Me.lbBuscaFunc.Size = New System.Drawing.Size(61, 13)
        Me.lbBuscaFunc.TabIndex = 8
        Me.lbBuscaFunc.Text = "Buscar por:"
        '
        'gpxAgendamento
        '
        Me.gpxAgendamento.Controls.Add(Me.txtAno)
        Me.gpxAgendamento.Controls.Add(Me.txtMes)
        Me.gpxAgendamento.Controls.Add(Me.cmbStatusAgendamento)
        Me.gpxAgendamento.Controls.Add(Me.cmbTipoAtendimento)
        Me.gpxAgendamento.Controls.Add(Me.MtxtDataAgendamento)
        Me.gpxAgendamento.Controls.Add(Me.lbCodAgendamento)
        Me.gpxAgendamento.Controls.Add(Me.txtCodAgendamento)
        Me.gpxAgendamento.Controls.Add(Me.lbDataAgendamento)
        Me.gpxAgendamento.Controls.Add(Me.lbTipoAgendamento)
        Me.gpxAgendamento.Controls.Add(Me.lbStatusAgendamento)
        Me.gpxAgendamento.Location = New System.Drawing.Point(657, 300)
        Me.gpxAgendamento.Name = "gpxAgendamento"
        Me.gpxAgendamento.Size = New System.Drawing.Size(629, 216)
        Me.gpxAgendamento.TabIndex = 10
        Me.gpxAgendamento.TabStop = False
        Me.gpxAgendamento.Text = "Dados do agendamento"
        '
        'txtAno
        '
        Me.txtAno.Location = New System.Drawing.Point(207, 123)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(100, 20)
        Me.txtAno.TabIndex = 11
        Me.txtAno.Visible = False
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(207, 97)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(100, 20)
        Me.txtMes.TabIndex = 10
        Me.txtMes.Visible = False
        '
        'cmbStatusAgendamento
        '
        Me.cmbStatusAgendamento.FormattingEnabled = True
        Me.cmbStatusAgendamento.Location = New System.Drawing.Point(20, 96)
        Me.cmbStatusAgendamento.Name = "cmbStatusAgendamento"
        Me.cmbStatusAgendamento.Size = New System.Drawing.Size(121, 21)
        Me.cmbStatusAgendamento.TabIndex = 9
        '
        'cmbTipoAtendimento
        '
        Me.cmbTipoAtendimento.FormattingEnabled = True
        Me.cmbTipoAtendimento.Location = New System.Drawing.Point(272, 45)
        Me.cmbTipoAtendimento.Name = "cmbTipoAtendimento"
        Me.cmbTipoAtendimento.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoAtendimento.TabIndex = 8
        '
        'MtxtDataAgendamento
        '
        Me.MtxtDataAgendamento.Location = New System.Drawing.Point(153, 45)
        Me.MtxtDataAgendamento.Mask = "00/00/0000"
        Me.MtxtDataAgendamento.Name = "MtxtDataAgendamento"
        Me.MtxtDataAgendamento.Size = New System.Drawing.Size(77, 20)
        Me.MtxtDataAgendamento.TabIndex = 7
        Me.MtxtDataAgendamento.ValidatingType = GetType(Date)
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
        Me.btnCancelar.Location = New System.Drawing.Point(947, 528)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(170, 50)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnSalvarNovoHorario
        '
        Me.btnSalvarNovoHorario.BackColor = System.Drawing.Color.White
        Me.btnSalvarNovoHorario.BackgroundImage = Global.sistechy.My.Resources.Resources.salvar_novo_horario_fw
        Me.btnSalvarNovoHorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalvarNovoHorario.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSalvarNovoHorario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnSalvarNovoHorario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnSalvarNovoHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvarNovoHorario.Location = New System.Drawing.Point(1123, 528)
        Me.btnSalvarNovoHorario.Name = "btnSalvarNovoHorario"
        Me.btnSalvarNovoHorario.Size = New System.Drawing.Size(170, 50)
        Me.btnSalvarNovoHorario.TabIndex = 10
        Me.btnSalvarNovoHorario.UseVisualStyleBackColor = False
        '
        'pbxBanner
        '
        Me.pbxBanner.BackgroundImage = Global.sistechy.My.Resources.Resources.banner_novo_horario_fw
        Me.pbxBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxBanner.Location = New System.Drawing.Point(-5, -2)
        Me.pbxBanner.Name = "pbxBanner"
        Me.pbxBanner.Size = New System.Drawing.Size(1366, 55)
        Me.pbxBanner.TabIndex = 11
        Me.pbxBanner.TabStop = False
        '
        'frmNovoHorario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1304, 586)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSalvarNovoHorario)
        Me.Controls.Add(Me.pbxBanner)
        Me.Controls.Add(Me.gpxAgendamento)
        Me.Controls.Add(Me.gpxFunc)
        Me.Controls.Add(Me.gpxCliente)
        Me.Controls.Add(Me.gpxAnimal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNovoHorario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Novo horário"
        Me.gpxAnimal.ResumeLayout(False)
        Me.gpxAnimal.PerformLayout()
        CType(Me.dgvAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxCliente.ResumeLayout(False)
        Me.gpxCliente.PerformLayout()
        CType(Me.dgvCli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxFunc.ResumeLayout(False)
        Me.gpxFunc.PerformLayout()
        CType(Me.dgvFunc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxAgendamento.ResumeLayout(False)
        Me.gpxAgendamento.PerformLayout()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbCodAgendamento As System.Windows.Forms.Label
    Friend WithEvents lbTipoAgendamento As System.Windows.Forms.Label
    Friend WithEvents lbDataAgendamento As System.Windows.Forms.Label
    Friend WithEvents lbStatusAgendamento As System.Windows.Forms.Label
    Friend WithEvents txtCodAgendamento As System.Windows.Forms.TextBox
    Friend WithEvents gpxAnimal As System.Windows.Forms.GroupBox
    Friend WithEvents gpxCliente As System.Windows.Forms.GroupBox
    Friend WithEvents gpxFunc As System.Windows.Forms.GroupBox
    Friend WithEvents gpxAgendamento As System.Windows.Forms.GroupBox
    Friend WithEvents pbxBanner As System.Windows.Forms.PictureBox
    Friend WithEvents txtNomeAnimal As System.Windows.Forms.TextBox
    Friend WithEvents txtCodAnimal As System.Windows.Forms.TextBox
    Friend WithEvents lbNomeAnimal As System.Windows.Forms.Label
    Friend WithEvents lbCodigoAnimal As System.Windows.Forms.Label
    Friend WithEvents dgvAnimal As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscaAnimal As System.Windows.Forms.Button
    Friend WithEvents lbBuscaAnimal As System.Windows.Forms.Label
    Friend WithEvents txtNomeCli As System.Windows.Forms.TextBox
    Friend WithEvents txtCodCli As System.Windows.Forms.TextBox
    Friend WithEvents lbNomeCli As System.Windows.Forms.Label
    Friend WithEvents lbCodigoCli As System.Windows.Forms.Label
    Friend WithEvents dgvCli As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscaCli As System.Windows.Forms.Button
    Friend WithEvents lbBuscaCli As System.Windows.Forms.Label
    Friend WithEvents txtNomeFunc As System.Windows.Forms.TextBox
    Friend WithEvents txtCodFunc As System.Windows.Forms.TextBox
    Friend WithEvents lbNomeFunc As System.Windows.Forms.Label
    Friend WithEvents lbCodigoFunc As System.Windows.Forms.Label
    Friend WithEvents dgvFunc As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscaFunc As System.Windows.Forms.Button
    Friend WithEvents lbBuscaFunc As System.Windows.Forms.Label
    Friend WithEvents cmbTipoAtendimento As System.Windows.Forms.ComboBox
    Friend WithEvents MtxtDataAgendamento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbStatusAgendamento As System.Windows.Forms.ComboBox
    Friend WithEvents btnSalvarNovoHorario As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtAno As System.Windows.Forms.TextBox
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents MtxtFiltroCPFCli As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtFiltroDataCli As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbFiltroCli As System.Windows.Forms.ComboBox
    Friend WithEvents txtConsultaCli As System.Windows.Forms.TextBox
    Friend WithEvents MtxtFiltroDataAnimal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbFiltroAnimal As System.Windows.Forms.ComboBox
    Friend WithEvents txtConsultaAnimal As System.Windows.Forms.TextBox
    Friend WithEvents MtxtFiltroDataFunc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtFiltroCPFFunc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbFiltroFunc As System.Windows.Forms.ComboBox
    Friend WithEvents txtConsultaFunc As System.Windows.Forms.TextBox
End Class
