<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCirurgia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCirurgia))
        Me.gpxAnimal = New System.Windows.Forms.GroupBox()
        Me.MtxtFiltroDataAnimal = New System.Windows.Forms.MaskedTextBox()
        Me.cmbFiltroAnimal = New System.Windows.Forms.ComboBox()
        Me.dgvAnimal = New System.Windows.Forms.DataGridView()
        Me.lbCodAnimal = New System.Windows.Forms.Label()
        Me.lbCodigoAnimal = New System.Windows.Forms.Label()
        Me.txtConsultaAnimal = New System.Windows.Forms.TextBox()
        Me.btnBuscaAnimal = New System.Windows.Forms.Button()
        Me.lbNomeAnimal = New System.Windows.Forms.Label()
        Me.lbPorteAnimal = New System.Windows.Forms.Label()
        Me.txtPorteAnimal = New System.Windows.Forms.TextBox()
        Me.txtCodAnimal = New System.Windows.Forms.TextBox()
        Me.txtNomeAnimal = New System.Windows.Forms.TextBox()
        Me.gpxAnestesista = New System.Windows.Forms.GroupBox()
        Me.MtxtFiltroDataAnestesista = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtFiltroCPFAnestesista = New System.Windows.Forms.MaskedTextBox()
        Me.cmbFiltroAnestesista = New System.Windows.Forms.ComboBox()
        Me.dgvAnestesista = New System.Windows.Forms.DataGridView()
        Me.lbNomeAnestesista = New System.Windows.Forms.Label()
        Me.btnBuscaAnestesista = New System.Windows.Forms.Button()
        Me.lbCodigoAnestesista = New System.Windows.Forms.Label()
        Me.lbCodAnestesista = New System.Windows.Forms.Label()
        Me.txtCodAnestesista = New System.Windows.Forms.TextBox()
        Me.txtNomeAnestesista = New System.Windows.Forms.TextBox()
        Me.txtBuscaAnestesista = New System.Windows.Forms.TextBox()
        Me.gpxCirurgiao = New System.Windows.Forms.GroupBox()
        Me.MtxtFiltroDataCirurgiao = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtFiltroCPFCirurgiao = New System.Windows.Forms.MaskedTextBox()
        Me.cmbFiltroCirurgiao = New System.Windows.Forms.ComboBox()
        Me.dgvCirurgiao = New System.Windows.Forms.DataGridView()
        Me.btnBuscaCirurgiao = New System.Windows.Forms.Button()
        Me.lbCodigoCirurgiao = New System.Windows.Forms.Label()
        Me.txtNomeCirurgiao = New System.Windows.Forms.TextBox()
        Me.txtConsultaCirurgiao = New System.Windows.Forms.TextBox()
        Me.lbNomeCirurgiao = New System.Windows.Forms.Label()
        Me.txtCodCirurgiao = New System.Windows.Forms.TextBox()
        Me.lbCodCirurgiao = New System.Windows.Forms.Label()
        Me.gpxInfo = New System.Windows.Forms.GroupBox()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.txtDetalhesCirurgia = New System.Windows.Forms.RichTextBox()
        Me.MtxtDataCirurgia = New System.Windows.Forms.MaskedTextBox()
        Me.txtCodCirurgia = New System.Windows.Forms.TextBox()
        Me.lbCodCirurgia = New System.Windows.Forms.Label()
        Me.lbDataCirurgia = New System.Windows.Forms.Label()
        Me.lbDetalhesCirurgia = New System.Windows.Forms.Label()
        Me.pbxBanner = New System.Windows.Forms.PictureBox()
        Me.btnSalvarCirurgia = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gpxAnimal.SuspendLayout()
        CType(Me.dgvAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxAnestesista.SuspendLayout()
        CType(Me.dgvAnestesista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxCirurgiao.SuspendLayout()
        CType(Me.dgvCirurgiao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxInfo.SuspendLayout()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpxAnimal
        '
        Me.gpxAnimal.Controls.Add(Me.MtxtFiltroDataAnimal)
        Me.gpxAnimal.Controls.Add(Me.cmbFiltroAnimal)
        Me.gpxAnimal.Controls.Add(Me.dgvAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbCodAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbCodigoAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtConsultaAnimal)
        Me.gpxAnimal.Controls.Add(Me.btnBuscaAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbNomeAnimal)
        Me.gpxAnimal.Controls.Add(Me.lbPorteAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtPorteAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtCodAnimal)
        Me.gpxAnimal.Controls.Add(Me.txtNomeAnimal)
        Me.gpxAnimal.Location = New System.Drawing.Point(12, 65)
        Me.gpxAnimal.Name = "gpxAnimal"
        Me.gpxAnimal.Size = New System.Drawing.Size(542, 252)
        Me.gpxAnimal.TabIndex = 8
        Me.gpxAnimal.TabStop = False
        Me.gpxAnimal.Text = "Dados do animal"
        '
        'MtxtFiltroDataAnimal
        '
        Me.MtxtFiltroDataAnimal.Location = New System.Drawing.Point(253, 20)
        Me.MtxtFiltroDataAnimal.Mask = "00/00/0000"
        Me.MtxtFiltroDataAnimal.Name = "MtxtFiltroDataAnimal"
        Me.MtxtFiltroDataAnimal.Size = New System.Drawing.Size(72, 20)
        Me.MtxtFiltroDataAnimal.TabIndex = 77
        Me.MtxtFiltroDataAnimal.ValidatingType = GetType(Date)
        Me.MtxtFiltroDataAnimal.Visible = False
        '
        'cmbFiltroAnimal
        '
        Me.cmbFiltroAnimal.FormattingEnabled = True
        Me.cmbFiltroAnimal.Location = New System.Drawing.Point(112, 19)
        Me.cmbFiltroAnimal.Name = "cmbFiltroAnimal"
        Me.cmbFiltroAnimal.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltroAnimal.TabIndex = 76
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
        Me.dgvAnimal.Location = New System.Drawing.Point(12, 55)
        Me.dgvAnimal.MultiSelect = False
        Me.dgvAnimal.Name = "dgvAnimal"
        Me.dgvAnimal.ReadOnly = True
        Me.dgvAnimal.RowHeadersVisible = False
        Me.dgvAnimal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvAnimal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAnimal.Size = New System.Drawing.Size(518, 140)
        Me.dgvAnimal.TabIndex = 68
        '
        'lbCodAnimal
        '
        Me.lbCodAnimal.AutoSize = True
        Me.lbCodAnimal.Location = New System.Drawing.Point(9, 24)
        Me.lbCodAnimal.Name = "lbCodAnimal"
        Me.lbCodAnimal.Size = New System.Drawing.Size(94, 13)
        Me.lbCodAnimal.TabIndex = 1
        Me.lbCodAnimal.Text = "Buscar animal por:"
        '
        'lbCodigoAnimal
        '
        Me.lbCodigoAnimal.AutoSize = True
        Me.lbCodigoAnimal.Location = New System.Drawing.Point(13, 197)
        Me.lbCodigoAnimal.Name = "lbCodigoAnimal"
        Me.lbCodigoAnimal.Size = New System.Drawing.Size(40, 13)
        Me.lbCodigoAnimal.TabIndex = 70
        Me.lbCodigoAnimal.Text = "Código"
        '
        'txtConsultaAnimal
        '
        Me.txtConsultaAnimal.Location = New System.Drawing.Point(253, 20)
        Me.txtConsultaAnimal.Name = "txtConsultaAnimal"
        Me.txtConsultaAnimal.Size = New System.Drawing.Size(116, 20)
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
        Me.btnBuscaAnimal.Location = New System.Drawing.Point(383, 19)
        Me.btnBuscaAnimal.Name = "btnBuscaAnimal"
        Me.btnBuscaAnimal.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscaAnimal.TabIndex = 2
        Me.btnBuscaAnimal.Text = "Buscar"
        Me.btnBuscaAnimal.UseVisualStyleBackColor = False
        Me.btnBuscaAnimal.Visible = False
        '
        'lbNomeAnimal
        '
        Me.lbNomeAnimal.AutoSize = True
        Me.lbNomeAnimal.Location = New System.Drawing.Point(141, 201)
        Me.lbNomeAnimal.Name = "lbNomeAnimal"
        Me.lbNomeAnimal.Size = New System.Drawing.Size(35, 13)
        Me.lbNomeAnimal.TabIndex = 71
        Me.lbNomeAnimal.Text = "Nome"
        '
        'lbPorteAnimal
        '
        Me.lbPorteAnimal.AutoSize = True
        Me.lbPorteAnimal.Location = New System.Drawing.Point(355, 201)
        Me.lbPorteAnimal.Name = "lbPorteAnimal"
        Me.lbPorteAnimal.Size = New System.Drawing.Size(32, 13)
        Me.lbPorteAnimal.TabIndex = 72
        Me.lbPorteAnimal.Text = "Porte"
        '
        'txtPorteAnimal
        '
        Me.txtPorteAnimal.Enabled = False
        Me.txtPorteAnimal.Location = New System.Drawing.Point(358, 217)
        Me.txtPorteAnimal.Name = "txtPorteAnimal"
        Me.txtPorteAnimal.Size = New System.Drawing.Size(100, 20)
        Me.txtPorteAnimal.TabIndex = 73
        '
        'txtCodAnimal
        '
        Me.txtCodAnimal.Enabled = False
        Me.txtCodAnimal.Location = New System.Drawing.Point(12, 217)
        Me.txtCodAnimal.Name = "txtCodAnimal"
        Me.txtCodAnimal.Size = New System.Drawing.Size(100, 20)
        Me.txtCodAnimal.TabIndex = 74
        '
        'txtNomeAnimal
        '
        Me.txtNomeAnimal.Enabled = False
        Me.txtNomeAnimal.Location = New System.Drawing.Point(144, 217)
        Me.txtNomeAnimal.Name = "txtNomeAnimal"
        Me.txtNomeAnimal.Size = New System.Drawing.Size(186, 20)
        Me.txtNomeAnimal.TabIndex = 75
        '
        'gpxAnestesista
        '
        Me.gpxAnestesista.Controls.Add(Me.MtxtFiltroDataAnestesista)
        Me.gpxAnestesista.Controls.Add(Me.MtxtFiltroCPFAnestesista)
        Me.gpxAnestesista.Controls.Add(Me.cmbFiltroAnestesista)
        Me.gpxAnestesista.Controls.Add(Me.dgvAnestesista)
        Me.gpxAnestesista.Controls.Add(Me.lbNomeAnestesista)
        Me.gpxAnestesista.Controls.Add(Me.btnBuscaAnestesista)
        Me.gpxAnestesista.Controls.Add(Me.lbCodigoAnestesista)
        Me.gpxAnestesista.Controls.Add(Me.lbCodAnestesista)
        Me.gpxAnestesista.Controls.Add(Me.txtCodAnestesista)
        Me.gpxAnestesista.Controls.Add(Me.txtNomeAnestesista)
        Me.gpxAnestesista.Controls.Add(Me.txtBuscaAnestesista)
        Me.gpxAnestesista.Location = New System.Drawing.Point(12, 336)
        Me.gpxAnestesista.Name = "gpxAnestesista"
        Me.gpxAnestesista.Size = New System.Drawing.Size(542, 253)
        Me.gpxAnestesista.TabIndex = 80
        Me.gpxAnestesista.TabStop = False
        Me.gpxAnestesista.Text = "Dados do anestesista"
        '
        'MtxtFiltroDataAnestesista
        '
        Me.MtxtFiltroDataAnestesista.Location = New System.Drawing.Point(268, 24)
        Me.MtxtFiltroDataAnestesista.Mask = "00/00/0000"
        Me.MtxtFiltroDataAnestesista.Name = "MtxtFiltroDataAnestesista"
        Me.MtxtFiltroDataAnestesista.Size = New System.Drawing.Size(73, 20)
        Me.MtxtFiltroDataAnestesista.TabIndex = 89
        Me.MtxtFiltroDataAnestesista.ValidatingType = GetType(Date)
        Me.MtxtFiltroDataAnestesista.Visible = False
        '
        'MtxtFiltroCPFAnestesista
        '
        Me.MtxtFiltroCPFAnestesista.Location = New System.Drawing.Point(268, 24)
        Me.MtxtFiltroCPFAnestesista.Mask = "000.000.000-00"
        Me.MtxtFiltroCPFAnestesista.Name = "MtxtFiltroCPFAnestesista"
        Me.MtxtFiltroCPFAnestesista.Size = New System.Drawing.Size(87, 20)
        Me.MtxtFiltroCPFAnestesista.TabIndex = 88
        Me.MtxtFiltroCPFAnestesista.Visible = False
        '
        'cmbFiltroAnestesista
        '
        Me.cmbFiltroAnestesista.FormattingEnabled = True
        Me.cmbFiltroAnestesista.Location = New System.Drawing.Point(134, 23)
        Me.cmbFiltroAnestesista.Name = "cmbFiltroAnestesista"
        Me.cmbFiltroAnestesista.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltroAnestesista.TabIndex = 87
        '
        'dgvAnestesista
        '
        Me.dgvAnestesista.AllowUserToAddRows = False
        Me.dgvAnestesista.AllowUserToDeleteRows = False
        Me.dgvAnestesista.AllowUserToResizeColumns = False
        Me.dgvAnestesista.AllowUserToResizeRows = False
        Me.dgvAnestesista.BackgroundColor = System.Drawing.Color.White
        Me.dgvAnestesista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvAnestesista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAnestesista.Location = New System.Drawing.Point(12, 52)
        Me.dgvAnestesista.MultiSelect = False
        Me.dgvAnestesista.Name = "dgvAnestesista"
        Me.dgvAnestesista.ReadOnly = True
        Me.dgvAnestesista.RowHeadersVisible = False
        Me.dgvAnestesista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvAnestesista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAnestesista.Size = New System.Drawing.Size(518, 140)
        Me.dgvAnestesista.TabIndex = 67
        '
        'lbNomeAnestesista
        '
        Me.lbNomeAnestesista.AutoSize = True
        Me.lbNomeAnestesista.Location = New System.Drawing.Point(145, 198)
        Me.lbNomeAnestesista.Name = "lbNomeAnestesista"
        Me.lbNomeAnestesista.Size = New System.Drawing.Size(35, 13)
        Me.lbNomeAnestesista.TabIndex = 77
        Me.lbNomeAnestesista.Text = "Nome"
        '
        'btnBuscaAnestesista
        '
        Me.btnBuscaAnestesista.BackColor = System.Drawing.Color.White
        Me.btnBuscaAnestesista.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBuscaAnestesista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaAnestesista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaAnestesista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscaAnestesista.Location = New System.Drawing.Point(404, 22)
        Me.btnBuscaAnestesista.Name = "btnBuscaAnestesista"
        Me.btnBuscaAnestesista.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscaAnestesista.TabIndex = 6
        Me.btnBuscaAnestesista.Text = "Buscar"
        Me.btnBuscaAnestesista.UseVisualStyleBackColor = False
        Me.btnBuscaAnestesista.Visible = False
        '
        'lbCodigoAnestesista
        '
        Me.lbCodigoAnestesista.AutoSize = True
        Me.lbCodigoAnestesista.Location = New System.Drawing.Point(13, 198)
        Me.lbCodigoAnestesista.Name = "lbCodigoAnestesista"
        Me.lbCodigoAnestesista.Size = New System.Drawing.Size(40, 13)
        Me.lbCodigoAnestesista.TabIndex = 76
        Me.lbCodigoAnestesista.Text = "Código"
        '
        'lbCodAnestesista
        '
        Me.lbCodAnestesista.AutoSize = True
        Me.lbCodAnestesista.Location = New System.Drawing.Point(11, 27)
        Me.lbCodAnestesista.Name = "lbCodAnestesista"
        Me.lbCodAnestesista.Size = New System.Drawing.Size(117, 13)
        Me.lbCodAnestesista.TabIndex = 2
        Me.lbCodAnestesista.Text = "Buscar anestesista por:"
        '
        'txtCodAnestesista
        '
        Me.txtCodAnestesista.Enabled = False
        Me.txtCodAnestesista.Location = New System.Drawing.Point(16, 218)
        Me.txtCodAnestesista.Name = "txtCodAnestesista"
        Me.txtCodAnestesista.Size = New System.Drawing.Size(100, 20)
        Me.txtCodAnestesista.TabIndex = 78
        '
        'txtNomeAnestesista
        '
        Me.txtNomeAnestesista.Enabled = False
        Me.txtNomeAnestesista.Location = New System.Drawing.Point(148, 218)
        Me.txtNomeAnestesista.Name = "txtNomeAnestesista"
        Me.txtNomeAnestesista.Size = New System.Drawing.Size(253, 20)
        Me.txtNomeAnestesista.TabIndex = 79
        '
        'txtBuscaAnestesista
        '
        Me.txtBuscaAnestesista.Location = New System.Drawing.Point(268, 24)
        Me.txtBuscaAnestesista.Name = "txtBuscaAnestesista"
        Me.txtBuscaAnestesista.Size = New System.Drawing.Size(119, 20)
        Me.txtBuscaAnestesista.TabIndex = 5
        Me.txtBuscaAnestesista.Visible = False
        '
        'gpxCirurgiao
        '
        Me.gpxCirurgiao.Controls.Add(Me.MtxtFiltroDataCirurgiao)
        Me.gpxCirurgiao.Controls.Add(Me.MtxtFiltroCPFCirurgiao)
        Me.gpxCirurgiao.Controls.Add(Me.cmbFiltroCirurgiao)
        Me.gpxCirurgiao.Controls.Add(Me.dgvCirurgiao)
        Me.gpxCirurgiao.Controls.Add(Me.btnBuscaCirurgiao)
        Me.gpxCirurgiao.Controls.Add(Me.lbCodigoCirurgiao)
        Me.gpxCirurgiao.Controls.Add(Me.txtNomeCirurgiao)
        Me.gpxCirurgiao.Controls.Add(Me.txtConsultaCirurgiao)
        Me.gpxCirurgiao.Controls.Add(Me.lbNomeCirurgiao)
        Me.gpxCirurgiao.Controls.Add(Me.txtCodCirurgiao)
        Me.gpxCirurgiao.Controls.Add(Me.lbCodCirurgiao)
        Me.gpxCirurgiao.Location = New System.Drawing.Point(572, 65)
        Me.gpxCirurgiao.Name = "gpxCirurgiao"
        Me.gpxCirurgiao.Size = New System.Drawing.Size(556, 252)
        Me.gpxCirurgiao.TabIndex = 84
        Me.gpxCirurgiao.TabStop = False
        Me.gpxCirurgiao.Text = "Dados do cirurgião"
        '
        'MtxtFiltroDataCirurgiao
        '
        Me.MtxtFiltroDataCirurgiao.Location = New System.Drawing.Point(259, 22)
        Me.MtxtFiltroDataCirurgiao.Mask = "00/00/0000"
        Me.MtxtFiltroDataCirurgiao.Name = "MtxtFiltroDataCirurgiao"
        Me.MtxtFiltroDataCirurgiao.Size = New System.Drawing.Size(73, 20)
        Me.MtxtFiltroDataCirurgiao.TabIndex = 86
        Me.MtxtFiltroDataCirurgiao.ValidatingType = GetType(Date)
        Me.MtxtFiltroDataCirurgiao.Visible = False
        '
        'MtxtFiltroCPFCirurgiao
        '
        Me.MtxtFiltroCPFCirurgiao.Location = New System.Drawing.Point(259, 22)
        Me.MtxtFiltroCPFCirurgiao.Mask = "000.000.000-00"
        Me.MtxtFiltroCPFCirurgiao.Name = "MtxtFiltroCPFCirurgiao"
        Me.MtxtFiltroCPFCirurgiao.Size = New System.Drawing.Size(87, 20)
        Me.MtxtFiltroCPFCirurgiao.TabIndex = 85
        Me.MtxtFiltroCPFCirurgiao.Visible = False
        '
        'cmbFiltroCirurgiao
        '
        Me.cmbFiltroCirurgiao.FormattingEnabled = True
        Me.cmbFiltroCirurgiao.Location = New System.Drawing.Point(128, 21)
        Me.cmbFiltroCirurgiao.Name = "cmbFiltroCirurgiao"
        Me.cmbFiltroCirurgiao.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltroCirurgiao.TabIndex = 84
        '
        'dgvCirurgiao
        '
        Me.dgvCirurgiao.AllowUserToAddRows = False
        Me.dgvCirurgiao.AllowUserToDeleteRows = False
        Me.dgvCirurgiao.AllowUserToResizeColumns = False
        Me.dgvCirurgiao.AllowUserToResizeRows = False
        Me.dgvCirurgiao.BackgroundColor = System.Drawing.Color.White
        Me.dgvCirurgiao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvCirurgiao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCirurgiao.Location = New System.Drawing.Point(20, 55)
        Me.dgvCirurgiao.MultiSelect = False
        Me.dgvCirurgiao.Name = "dgvCirurgiao"
        Me.dgvCirurgiao.ReadOnly = True
        Me.dgvCirurgiao.RowHeadersVisible = False
        Me.dgvCirurgiao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvCirurgiao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCirurgiao.Size = New System.Drawing.Size(518, 140)
        Me.dgvCirurgiao.TabIndex = 69
        '
        'btnBuscaCirurgiao
        '
        Me.btnBuscaCirurgiao.BackColor = System.Drawing.Color.White
        Me.btnBuscaCirurgiao.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBuscaCirurgiao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaCirurgiao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaCirurgiao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscaCirurgiao.Location = New System.Drawing.Point(393, 20)
        Me.btnBuscaCirurgiao.Name = "btnBuscaCirurgiao"
        Me.btnBuscaCirurgiao.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscaCirurgiao.TabIndex = 4
        Me.btnBuscaCirurgiao.Text = "Buscar"
        Me.btnBuscaCirurgiao.UseVisualStyleBackColor = False
        Me.btnBuscaCirurgiao.Visible = False
        '
        'lbCodigoCirurgiao
        '
        Me.lbCodigoCirurgiao.AutoSize = True
        Me.lbCodigoCirurgiao.Location = New System.Drawing.Point(18, 201)
        Me.lbCodigoCirurgiao.Name = "lbCodigoCirurgiao"
        Me.lbCodigoCirurgiao.Size = New System.Drawing.Size(40, 13)
        Me.lbCodigoCirurgiao.TabIndex = 80
        Me.lbCodigoCirurgiao.Text = "Código"
        '
        'txtNomeCirurgiao
        '
        Me.txtNomeCirurgiao.Enabled = False
        Me.txtNomeCirurgiao.Location = New System.Drawing.Point(153, 217)
        Me.txtNomeCirurgiao.Name = "txtNomeCirurgiao"
        Me.txtNomeCirurgiao.Size = New System.Drawing.Size(253, 20)
        Me.txtNomeCirurgiao.TabIndex = 83
        '
        'txtConsultaCirurgiao
        '
        Me.txtConsultaCirurgiao.Location = New System.Drawing.Point(259, 22)
        Me.txtConsultaCirurgiao.Name = "txtConsultaCirurgiao"
        Me.txtConsultaCirurgiao.Size = New System.Drawing.Size(119, 20)
        Me.txtConsultaCirurgiao.TabIndex = 3
        Me.txtConsultaCirurgiao.Visible = False
        '
        'lbNomeCirurgiao
        '
        Me.lbNomeCirurgiao.AutoSize = True
        Me.lbNomeCirurgiao.Location = New System.Drawing.Point(150, 201)
        Me.lbNomeCirurgiao.Name = "lbNomeCirurgiao"
        Me.lbNomeCirurgiao.Size = New System.Drawing.Size(35, 13)
        Me.lbNomeCirurgiao.TabIndex = 81
        Me.lbNomeCirurgiao.Text = "Nome"
        '
        'txtCodCirurgiao
        '
        Me.txtCodCirurgiao.Enabled = False
        Me.txtCodCirurgiao.Location = New System.Drawing.Point(21, 217)
        Me.txtCodCirurgiao.Name = "txtCodCirurgiao"
        Me.txtCodCirurgiao.Size = New System.Drawing.Size(100, 20)
        Me.txtCodCirurgiao.TabIndex = 82
        '
        'lbCodCirurgiao
        '
        Me.lbCodCirurgiao.AutoSize = True
        Me.lbCodCirurgiao.Location = New System.Drawing.Point(18, 25)
        Me.lbCodCirurgiao.Name = "lbCodCirurgiao"
        Me.lbCodCirurgiao.Size = New System.Drawing.Size(104, 13)
        Me.lbCodCirurgiao.TabIndex = 3
        Me.lbCodCirurgiao.Text = "Buscar cirurgião por:"
        '
        'gpxInfo
        '
        Me.gpxInfo.Controls.Add(Me.txtAno)
        Me.gpxInfo.Controls.Add(Me.txtMes)
        Me.gpxInfo.Controls.Add(Me.txtDetalhesCirurgia)
        Me.gpxInfo.Controls.Add(Me.MtxtDataCirurgia)
        Me.gpxInfo.Controls.Add(Me.txtCodCirurgia)
        Me.gpxInfo.Controls.Add(Me.lbCodCirurgia)
        Me.gpxInfo.Controls.Add(Me.lbDataCirurgia)
        Me.gpxInfo.Controls.Add(Me.lbDetalhesCirurgia)
        Me.gpxInfo.Location = New System.Drawing.Point(572, 336)
        Me.gpxInfo.Name = "gpxInfo"
        Me.gpxInfo.Size = New System.Drawing.Size(556, 253)
        Me.gpxInfo.TabIndex = 7
        Me.gpxInfo.TabStop = False
        Me.gpxInfo.Text = "Informações da cirurgia"
        '
        'txtAno
        '
        Me.txtAno.Location = New System.Drawing.Point(257, 68)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(100, 20)
        Me.txtAno.TabIndex = 10
        Me.txtAno.Visible = False
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(257, 43)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(100, 20)
        Me.txtMes.TabIndex = 9
        Me.txtMes.Visible = False
        '
        'txtDetalhesCirurgia
        '
        Me.txtDetalhesCirurgia.Location = New System.Drawing.Point(21, 94)
        Me.txtDetalhesCirurgia.Name = "txtDetalhesCirurgia"
        Me.txtDetalhesCirurgia.Size = New System.Drawing.Size(518, 128)
        Me.txtDetalhesCirurgia.TabIndex = 8
        Me.txtDetalhesCirurgia.Text = ""
        '
        'MtxtDataCirurgia
        '
        Me.MtxtDataCirurgia.Location = New System.Drawing.Point(153, 43)
        Me.MtxtDataCirurgia.Mask = "00/00/0000"
        Me.MtxtDataCirurgia.Name = "MtxtDataCirurgia"
        Me.MtxtDataCirurgia.Size = New System.Drawing.Size(74, 20)
        Me.MtxtDataCirurgia.TabIndex = 7
        Me.MtxtDataCirurgia.ValidatingType = GetType(Date)
        '
        'txtCodCirurgia
        '
        Me.txtCodCirurgia.Enabled = False
        Me.txtCodCirurgia.Location = New System.Drawing.Point(21, 43)
        Me.txtCodCirurgia.Name = "txtCodCirurgia"
        Me.txtCodCirurgia.Size = New System.Drawing.Size(100, 20)
        Me.txtCodCirurgia.TabIndex = 6
        '
        'lbCodCirurgia
        '
        Me.lbCodCirurgia.AutoSize = True
        Me.lbCodCirurgia.Location = New System.Drawing.Point(18, 27)
        Me.lbCodCirurgia.Name = "lbCodCirurgia"
        Me.lbCodCirurgia.Size = New System.Drawing.Size(77, 13)
        Me.lbCodCirurgia.TabIndex = 0
        Me.lbCodCirurgia.Text = "Código cirurgia"
        '
        'lbDataCirurgia
        '
        Me.lbDataCirurgia.AutoSize = True
        Me.lbDataCirurgia.Location = New System.Drawing.Point(150, 27)
        Me.lbDataCirurgia.Name = "lbDataCirurgia"
        Me.lbDataCirurgia.Size = New System.Drawing.Size(67, 13)
        Me.lbDataCirurgia.TabIndex = 4
        Me.lbDataCirurgia.Text = "Data cirurgia"
        '
        'lbDetalhesCirurgia
        '
        Me.lbDetalhesCirurgia.AutoSize = True
        Me.lbDetalhesCirurgia.Location = New System.Drawing.Point(18, 78)
        Me.lbDetalhesCirurgia.Name = "lbDetalhesCirurgia"
        Me.lbDetalhesCirurgia.Size = New System.Drawing.Size(49, 13)
        Me.lbDetalhesCirurgia.TabIndex = 5
        Me.lbDetalhesCirurgia.Text = "Detalhes"
        '
        'pbxBanner
        '
        Me.pbxBanner.BackgroundImage = Global.sistechy.My.Resources.Resources.banner_cirurgia_fw
        Me.pbxBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxBanner.Location = New System.Drawing.Point(-5, -2)
        Me.pbxBanner.Name = "pbxBanner"
        Me.pbxBanner.Size = New System.Drawing.Size(1154, 55)
        Me.pbxBanner.TabIndex = 87
        Me.pbxBanner.TabStop = False
        '
        'btnSalvarCirurgia
        '
        Me.btnSalvarCirurgia.BackColor = System.Drawing.Color.White
        Me.btnSalvarCirurgia.BackgroundImage = Global.sistechy.My.Resources.Resources.salva_vacinacao_fw
        Me.btnSalvarCirurgia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalvarCirurgia.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSalvarCirurgia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnSalvarCirurgia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnSalvarCirurgia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvarCirurgia.Location = New System.Drawing.Point(956, 595)
        Me.btnSalvarCirurgia.Name = "btnSalvarCirurgia"
        Me.btnSalvarCirurgia.Size = New System.Drawing.Size(170, 50)
        Me.btnSalvarCirurgia.TabIndex = 9
        Me.btnSalvarCirurgia.UseVisualStyleBackColor = False
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
        Me.btnCancelar.Location = New System.Drawing.Point(780, 595)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(170, 50)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'frmCirurgia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1138, 656)
        Me.Controls.Add(Me.pbxBanner)
        Me.Controls.Add(Me.btnSalvarCirurgia)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.gpxAnimal)
        Me.Controls.Add(Me.gpxCirurgiao)
        Me.Controls.Add(Me.gpxInfo)
        Me.Controls.Add(Me.gpxAnestesista)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCirurgia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cirurgia"
        Me.gpxAnimal.ResumeLayout(False)
        Me.gpxAnimal.PerformLayout()
        CType(Me.dgvAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxAnestesista.ResumeLayout(False)
        Me.gpxAnestesista.PerformLayout()
        CType(Me.dgvAnestesista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxCirurgiao.ResumeLayout(False)
        Me.gpxCirurgiao.PerformLayout()
        CType(Me.dgvCirurgiao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxInfo.ResumeLayout(False)
        Me.gpxInfo.PerformLayout()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpxAnimal As System.Windows.Forms.GroupBox
    Friend WithEvents dgvAnimal As System.Windows.Forms.DataGridView
    Friend WithEvents lbCodAnimal As System.Windows.Forms.Label
    Friend WithEvents lbCodigoAnimal As System.Windows.Forms.Label
    Friend WithEvents txtConsultaAnimal As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscaAnimal As System.Windows.Forms.Button
    Friend WithEvents lbNomeAnimal As System.Windows.Forms.Label
    Friend WithEvents lbPorteAnimal As System.Windows.Forms.Label
    Friend WithEvents txtPorteAnimal As System.Windows.Forms.TextBox
    Friend WithEvents txtCodAnimal As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeAnimal As System.Windows.Forms.TextBox
    Friend WithEvents gpxAnestesista As System.Windows.Forms.GroupBox
    Friend WithEvents dgvAnestesista As System.Windows.Forms.DataGridView
    Friend WithEvents lbNomeAnestesista As System.Windows.Forms.Label
    Friend WithEvents btnBuscaAnestesista As System.Windows.Forms.Button
    Friend WithEvents lbCodigoAnestesista As System.Windows.Forms.Label
    Friend WithEvents lbCodAnestesista As System.Windows.Forms.Label
    Friend WithEvents txtCodAnestesista As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeAnestesista As System.Windows.Forms.TextBox
    Friend WithEvents txtBuscaAnestesista As System.Windows.Forms.TextBox
    Friend WithEvents gpxCirurgiao As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCirurgiao As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscaCirurgiao As System.Windows.Forms.Button
    Friend WithEvents lbCodigoCirurgiao As System.Windows.Forms.Label
    Friend WithEvents txtNomeCirurgiao As System.Windows.Forms.TextBox
    Friend WithEvents txtConsultaCirurgiao As System.Windows.Forms.TextBox
    Friend WithEvents lbNomeCirurgiao As System.Windows.Forms.Label
    Friend WithEvents txtCodCirurgiao As System.Windows.Forms.TextBox
    Friend WithEvents lbCodCirurgiao As System.Windows.Forms.Label
    Friend WithEvents gpxInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtDetalhesCirurgia As System.Windows.Forms.RichTextBox
    Friend WithEvents MtxtDataCirurgia As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCodCirurgia As System.Windows.Forms.TextBox
    Friend WithEvents lbCodCirurgia As System.Windows.Forms.Label
    Friend WithEvents lbDataCirurgia As System.Windows.Forms.Label
    Friend WithEvents lbDetalhesCirurgia As System.Windows.Forms.Label
    Friend WithEvents btnSalvarCirurgia As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents pbxBanner As System.Windows.Forms.PictureBox
    Friend WithEvents txtAno As System.Windows.Forms.TextBox
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents MtxtFiltroDataAnimal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbFiltroAnimal As System.Windows.Forms.ComboBox
    Friend WithEvents MtxtFiltroDataCirurgiao As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtFiltroCPFCirurgiao As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbFiltroCirurgiao As System.Windows.Forms.ComboBox
    Friend WithEvents MtxtFiltroDataAnestesista As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtFiltroCPFAnestesista As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbFiltroAnestesista As System.Windows.Forms.ComboBox
End Class
