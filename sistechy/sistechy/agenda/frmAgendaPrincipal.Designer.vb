<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgendaPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgendaPrincipal))
        Me.dgvAgenda = New System.Windows.Forms.DataGridView()
        Me.lbFiltrarPor = New System.Windows.Forms.Label()
        Me.lbDataInicial = New System.Windows.Forms.Label()
        Me.lbDataFinal = New System.Windows.Forms.Label()
        Me.lbData = New System.Windows.Forms.Label()
        Me.cmbTiposFiltro = New System.Windows.Forms.ComboBox()
        Me.MtxtFiltroEntreData1 = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtFiltroEntreData2 = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtFiltroData = New System.Windows.Forms.MaskedTextBox()
        Me.txtFiltroCod = New System.Windows.Forms.TextBox()
        Me.lbCod = New System.Windows.Forms.Label()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.lbTipoAtendimento = New System.Windows.Forms.Label()
        Me.cmbTipoAtendimento = New System.Windows.Forms.ComboBox()
        Me.CalendarioAgenda = New System.Windows.Forms.MonthCalendar()
        Me.txtDataCalendario = New System.Windows.Forms.TextBox()
        Me.lbDataSelecionada = New System.Windows.Forms.Label()
        Me.cmbFiltroStatus = New System.Windows.Forms.ComboBox()
        Me.txtCodAgendamento = New System.Windows.Forms.TextBox()
        Me.pbxBanner = New System.Windows.Forms.PictureBox()
        Me.btnAlterarDados = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnMarcarNovoHorario = New System.Windows.Forms.Button()
        CType(Me.dgvAgenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAgenda
        '
        Me.dgvAgenda.AllowUserToAddRows = False
        Me.dgvAgenda.AllowUserToDeleteRows = False
        Me.dgvAgenda.AllowUserToResizeColumns = False
        Me.dgvAgenda.AllowUserToResizeRows = False
        Me.dgvAgenda.BackgroundColor = System.Drawing.Color.White
        Me.dgvAgenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAgenda.Location = New System.Drawing.Point(12, 143)
        Me.dgvAgenda.MultiSelect = False
        Me.dgvAgenda.Name = "dgvAgenda"
        Me.dgvAgenda.ReadOnly = True
        Me.dgvAgenda.RowHeadersVisible = False
        Me.dgvAgenda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAgenda.Size = New System.Drawing.Size(672, 414)
        Me.dgvAgenda.TabIndex = 5
        '
        'lbFiltrarPor
        '
        Me.lbFiltrarPor.AutoSize = True
        Me.lbFiltrarPor.Location = New System.Drawing.Point(12, 85)
        Me.lbFiltrarPor.Name = "lbFiltrarPor"
        Me.lbFiltrarPor.Size = New System.Drawing.Size(53, 13)
        Me.lbFiltrarPor.TabIndex = 1
        Me.lbFiltrarPor.Text = "Filtrar por:"
        '
        'lbDataInicial
        '
        Me.lbDataInicial.AutoSize = True
        Me.lbDataInicial.Location = New System.Drawing.Point(234, 67)
        Me.lbDataInicial.Name = "lbDataInicial"
        Me.lbDataInicial.Size = New System.Drawing.Size(59, 13)
        Me.lbDataInicial.TabIndex = 2
        Me.lbDataInicial.Text = "Data inicial"
        Me.lbDataInicial.Visible = False
        '
        'lbDataFinal
        '
        Me.lbDataFinal.AutoSize = True
        Me.lbDataFinal.Location = New System.Drawing.Point(349, 67)
        Me.lbDataFinal.Name = "lbDataFinal"
        Me.lbDataFinal.Size = New System.Drawing.Size(52, 13)
        Me.lbDataFinal.TabIndex = 3
        Me.lbDataFinal.Text = "Data final"
        Me.lbDataFinal.Visible = False
        '
        'lbData
        '
        Me.lbData.AutoSize = True
        Me.lbData.Location = New System.Drawing.Point(234, 67)
        Me.lbData.Name = "lbData"
        Me.lbData.Size = New System.Drawing.Size(30, 13)
        Me.lbData.TabIndex = 4
        Me.lbData.Text = "Data"
        Me.lbData.Visible = False
        '
        'cmbTiposFiltro
        '
        Me.cmbTiposFiltro.FormattingEnabled = True
        Me.cmbTiposFiltro.Location = New System.Drawing.Point(71, 82)
        Me.cmbTiposFiltro.Name = "cmbTiposFiltro"
        Me.cmbTiposFiltro.Size = New System.Drawing.Size(143, 21)
        Me.cmbTiposFiltro.TabIndex = 1
        '
        'MtxtFiltroEntreData1
        '
        Me.MtxtFiltroEntreData1.Location = New System.Drawing.Point(237, 83)
        Me.MtxtFiltroEntreData1.Mask = "00/00/0000"
        Me.MtxtFiltroEntreData1.Name = "MtxtFiltroEntreData1"
        Me.MtxtFiltroEntreData1.Size = New System.Drawing.Size(79, 20)
        Me.MtxtFiltroEntreData1.TabIndex = 2
        Me.MtxtFiltroEntreData1.ValidatingType = GetType(Date)
        Me.MtxtFiltroEntreData1.Visible = False
        '
        'MtxtFiltroEntreData2
        '
        Me.MtxtFiltroEntreData2.Location = New System.Drawing.Point(352, 83)
        Me.MtxtFiltroEntreData2.Mask = "00/00/0000"
        Me.MtxtFiltroEntreData2.Name = "MtxtFiltroEntreData2"
        Me.MtxtFiltroEntreData2.Size = New System.Drawing.Size(80, 20)
        Me.MtxtFiltroEntreData2.TabIndex = 3
        Me.MtxtFiltroEntreData2.ValidatingType = GetType(Date)
        Me.MtxtFiltroEntreData2.Visible = False
        '
        'MtxtFiltroData
        '
        Me.MtxtFiltroData.Location = New System.Drawing.Point(237, 83)
        Me.MtxtFiltroData.Mask = "00/00/0000"
        Me.MtxtFiltroData.Name = "MtxtFiltroData"
        Me.MtxtFiltroData.Size = New System.Drawing.Size(79, 20)
        Me.MtxtFiltroData.TabIndex = 2
        Me.MtxtFiltroData.ValidatingType = GetType(Date)
        Me.MtxtFiltroData.Visible = False
        '
        'txtFiltroCod
        '
        Me.txtFiltroCod.Location = New System.Drawing.Point(237, 83)
        Me.txtFiltroCod.Name = "txtFiltroCod"
        Me.txtFiltroCod.Size = New System.Drawing.Size(100, 20)
        Me.txtFiltroCod.TabIndex = 2
        Me.txtFiltroCod.Visible = False
        '
        'lbCod
        '
        Me.lbCod.AutoSize = True
        Me.lbCod.Location = New System.Drawing.Point(234, 67)
        Me.lbCod.Name = "lbCod"
        Me.lbCod.Size = New System.Drawing.Size(40, 13)
        Me.lbCod.TabIndex = 12
        Me.lbCod.Text = "Código"
        Me.lbCod.Visible = False
        '
        'lbStatus
        '
        Me.lbStatus.AutoSize = True
        Me.lbStatus.Location = New System.Drawing.Point(234, 67)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(37, 13)
        Me.lbStatus.TabIndex = 13
        Me.lbStatus.Text = "Status"
        Me.lbStatus.Visible = False
        '
        'btnFiltrar
        '
        Me.btnFiltrar.BackColor = System.Drawing.Color.White
        Me.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltrar.Location = New System.Drawing.Point(71, 109)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltrar.TabIndex = 4
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = False
        '
        'lbTipoAtendimento
        '
        Me.lbTipoAtendimento.AutoSize = True
        Me.lbTipoAtendimento.Location = New System.Drawing.Point(234, 67)
        Me.lbTipoAtendimento.Name = "lbTipoAtendimento"
        Me.lbTipoAtendimento.Size = New System.Drawing.Size(104, 13)
        Me.lbTipoAtendimento.TabIndex = 15
        Me.lbTipoAtendimento.Text = "Tipo de atendimento"
        Me.lbTipoAtendimento.Visible = False
        '
        'cmbTipoAtendimento
        '
        Me.cmbTipoAtendimento.FormattingEnabled = True
        Me.cmbTipoAtendimento.Location = New System.Drawing.Point(237, 83)
        Me.cmbTipoAtendimento.Name = "cmbTipoAtendimento"
        Me.cmbTipoAtendimento.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoAtendimento.TabIndex = 2
        Me.cmbTipoAtendimento.Visible = False
        '
        'CalendarioAgenda
        '
        Me.CalendarioAgenda.Location = New System.Drawing.Point(702, 143)
        Me.CalendarioAgenda.Name = "CalendarioAgenda"
        Me.CalendarioAgenda.TabIndex = 6
        '
        'txtDataCalendario
        '
        Me.txtDataCalendario.Location = New System.Drawing.Point(702, 328)
        Me.txtDataCalendario.Name = "txtDataCalendario"
        Me.txtDataCalendario.Size = New System.Drawing.Size(100, 20)
        Me.txtDataCalendario.TabIndex = 18
        Me.txtDataCalendario.Visible = False
        '
        'lbDataSelecionada
        '
        Me.lbDataSelecionada.AutoSize = True
        Me.lbDataSelecionada.Location = New System.Drawing.Point(699, 312)
        Me.lbDataSelecionada.Name = "lbDataSelecionada"
        Me.lbDataSelecionada.Size = New System.Drawing.Size(90, 13)
        Me.lbDataSelecionada.TabIndex = 19
        Me.lbDataSelecionada.Text = "Data selecionada"
        Me.lbDataSelecionada.Visible = False
        '
        'cmbFiltroStatus
        '
        Me.cmbFiltroStatus.FormattingEnabled = True
        Me.cmbFiltroStatus.Location = New System.Drawing.Point(237, 83)
        Me.cmbFiltroStatus.Name = "cmbFiltroStatus"
        Me.cmbFiltroStatus.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltroStatus.TabIndex = 2
        Me.cmbFiltroStatus.Visible = False
        '
        'txtCodAgendamento
        '
        Me.txtCodAgendamento.Location = New System.Drawing.Point(237, 83)
        Me.txtCodAgendamento.Name = "txtCodAgendamento"
        Me.txtCodAgendamento.Size = New System.Drawing.Size(100, 20)
        Me.txtCodAgendamento.TabIndex = 25
        Me.txtCodAgendamento.Visible = False
        '
        'pbxBanner
        '
        Me.pbxBanner.BackgroundImage = CType(resources.GetObject("pbxBanner.BackgroundImage"), System.Drawing.Image)
        Me.pbxBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxBanner.Location = New System.Drawing.Point(-5, -2)
        Me.pbxBanner.Name = "pbxBanner"
        Me.pbxBanner.Size = New System.Drawing.Size(963, 55)
        Me.pbxBanner.TabIndex = 24
        Me.pbxBanner.TabStop = False
        '
        'btnAlterarDados
        '
        Me.btnAlterarDados.BackColor = System.Drawing.Color.White
        Me.btnAlterarDados.BackgroundImage = Global.sistechy.My.Resources.Resources.atualizar_dados_horario_fw
        Me.btnAlterarDados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAlterarDados.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAlterarDados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnAlterarDados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnAlterarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlterarDados.Location = New System.Drawing.Point(702, 449)
        Me.btnAlterarDados.Name = "btnAlterarDados"
        Me.btnAlterarDados.Size = New System.Drawing.Size(227, 50)
        Me.btnAlterarDados.TabIndex = 8
        Me.btnAlterarDados.UseVisualStyleBackColor = False
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
        Me.btnCancelar.Location = New System.Drawing.Point(702, 505)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(227, 50)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnMarcarNovoHorario
        '
        Me.btnMarcarNovoHorario.BackColor = System.Drawing.Color.White
        Me.btnMarcarNovoHorario.BackgroundImage = Global.sistechy.My.Resources.Resources.salvar_novo_horario_fw
        Me.btnMarcarNovoHorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMarcarNovoHorario.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnMarcarNovoHorario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnMarcarNovoHorario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnMarcarNovoHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMarcarNovoHorario.Location = New System.Drawing.Point(702, 393)
        Me.btnMarcarNovoHorario.Name = "btnMarcarNovoHorario"
        Me.btnMarcarNovoHorario.Size = New System.Drawing.Size(227, 50)
        Me.btnMarcarNovoHorario.TabIndex = 7
        Me.btnMarcarNovoHorario.UseVisualStyleBackColor = False
        '
        'frmAgendaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(947, 569)
        Me.Controls.Add(Me.txtCodAgendamento)
        Me.Controls.Add(Me.pbxBanner)
        Me.Controls.Add(Me.btnAlterarDados)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnMarcarNovoHorario)
        Me.Controls.Add(Me.cmbFiltroStatus)
        Me.Controls.Add(Me.lbDataSelecionada)
        Me.Controls.Add(Me.txtDataCalendario)
        Me.Controls.Add(Me.CalendarioAgenda)
        Me.Controls.Add(Me.cmbTipoAtendimento)
        Me.Controls.Add(Me.lbTipoAtendimento)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.lbStatus)
        Me.Controls.Add(Me.lbCod)
        Me.Controls.Add(Me.txtFiltroCod)
        Me.Controls.Add(Me.MtxtFiltroData)
        Me.Controls.Add(Me.MtxtFiltroEntreData2)
        Me.Controls.Add(Me.MtxtFiltroEntreData1)
        Me.Controls.Add(Me.cmbTiposFiltro)
        Me.Controls.Add(Me.lbData)
        Me.Controls.Add(Me.lbDataFinal)
        Me.Controls.Add(Me.lbDataInicial)
        Me.Controls.Add(Me.lbFiltrarPor)
        Me.Controls.Add(Me.dgvAgenda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgendaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda"
        CType(Me.dgvAgenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvAgenda As System.Windows.Forms.DataGridView
    Friend WithEvents lbFiltrarPor As System.Windows.Forms.Label
    Friend WithEvents lbDataInicial As System.Windows.Forms.Label
    Friend WithEvents lbDataFinal As System.Windows.Forms.Label
    Friend WithEvents lbData As System.Windows.Forms.Label
    Friend WithEvents cmbTiposFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents MtxtFiltroEntreData1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtFiltroEntreData2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtFiltroData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtFiltroCod As System.Windows.Forms.TextBox
    Friend WithEvents lbCod As System.Windows.Forms.Label
    Friend WithEvents lbStatus As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents lbTipoAtendimento As System.Windows.Forms.Label
    Friend WithEvents cmbTipoAtendimento As System.Windows.Forms.ComboBox
    Friend WithEvents CalendarioAgenda As System.Windows.Forms.MonthCalendar
    Friend WithEvents txtDataCalendario As System.Windows.Forms.TextBox
    Friend WithEvents lbDataSelecionada As System.Windows.Forms.Label
    Friend WithEvents cmbFiltroStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnMarcarNovoHorario As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAlterarDados As System.Windows.Forms.Button
    Friend WithEvents pbxBanner As System.Windows.Forms.PictureBox
    Friend WithEvents txtCodAgendamento As System.Windows.Forms.TextBox
End Class
