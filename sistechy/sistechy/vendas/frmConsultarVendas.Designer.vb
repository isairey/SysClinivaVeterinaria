<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarVendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultarVendas))
        Me.lbFiltrarPor = New System.Windows.Forms.Label()
        Me.lbCod = New System.Windows.Forms.Label()
        Me.MtxtFiltroData = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtFiltroEntreData2 = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtFiltroEntreData1 = New System.Windows.Forms.MaskedTextBox()
        Me.cmbTiposFiltro = New System.Windows.Forms.ComboBox()
        Me.lbData = New System.Windows.Forms.Label()
        Me.lbDataFinal = New System.Windows.Forms.Label()
        Me.lbDataInicial = New System.Windows.Forms.Label()
        Me.btFiltrar = New System.Windows.Forms.Button()
        Me.dgvVendas = New System.Windows.Forms.DataGridView()
        Me.pbxBanner = New System.Windows.Forms.PictureBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnDetalhes = New System.Windows.Forms.Button()
        CType(Me.dgvVendas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbFiltrarPor
        '
        Me.lbFiltrarPor.AutoSize = True
        Me.lbFiltrarPor.Location = New System.Drawing.Point(12, 81)
        Me.lbFiltrarPor.Name = "lbFiltrarPor"
        Me.lbFiltrarPor.Size = New System.Drawing.Size(53, 13)
        Me.lbFiltrarPor.TabIndex = 0
        Me.lbFiltrarPor.Text = "Filtrar por:"
        '
        'lbCod
        '
        Me.lbCod.AutoSize = True
        Me.lbCod.Location = New System.Drawing.Point(234, 63)
        Me.lbCod.Name = "lbCod"
        Me.lbCod.Size = New System.Drawing.Size(40, 13)
        Me.lbCod.TabIndex = 36
        Me.lbCod.Text = "Código"
        Me.lbCod.Visible = False
        '
        'MtxtFiltroData
        '
        Me.MtxtFiltroData.Location = New System.Drawing.Point(237, 79)
        Me.MtxtFiltroData.Mask = "00/00/0000"
        Me.MtxtFiltroData.Name = "MtxtFiltroData"
        Me.MtxtFiltroData.Size = New System.Drawing.Size(79, 20)
        Me.MtxtFiltroData.TabIndex = 30
        Me.MtxtFiltroData.ValidatingType = GetType(Date)
        Me.MtxtFiltroData.Visible = False
        '
        'MtxtFiltroEntreData2
        '
        Me.MtxtFiltroEntreData2.Location = New System.Drawing.Point(352, 79)
        Me.MtxtFiltroEntreData2.Mask = "00/00/0000"
        Me.MtxtFiltroEntreData2.Name = "MtxtFiltroEntreData2"
        Me.MtxtFiltroEntreData2.Size = New System.Drawing.Size(80, 20)
        Me.MtxtFiltroEntreData2.TabIndex = 33
        Me.MtxtFiltroEntreData2.ValidatingType = GetType(Date)
        Me.MtxtFiltroEntreData2.Visible = False
        '
        'MtxtFiltroEntreData1
        '
        Me.MtxtFiltroEntreData1.Location = New System.Drawing.Point(237, 79)
        Me.MtxtFiltroEntreData1.Mask = "00/00/0000"
        Me.MtxtFiltroEntreData1.Name = "MtxtFiltroEntreData1"
        Me.MtxtFiltroEntreData1.Size = New System.Drawing.Size(79, 20)
        Me.MtxtFiltroEntreData1.TabIndex = 31
        Me.MtxtFiltroEntreData1.ValidatingType = GetType(Date)
        Me.MtxtFiltroEntreData1.Visible = False
        '
        'cmbTiposFiltro
        '
        Me.cmbTiposFiltro.FormattingEnabled = True
        Me.cmbTiposFiltro.Location = New System.Drawing.Point(71, 78)
        Me.cmbTiposFiltro.Name = "cmbTiposFiltro"
        Me.cmbTiposFiltro.Size = New System.Drawing.Size(143, 21)
        Me.cmbTiposFiltro.TabIndex = 26
        '
        'lbData
        '
        Me.lbData.AutoSize = True
        Me.lbData.Location = New System.Drawing.Point(234, 63)
        Me.lbData.Name = "lbData"
        Me.lbData.Size = New System.Drawing.Size(30, 13)
        Me.lbData.TabIndex = 35
        Me.lbData.Text = "Data"
        Me.lbData.Visible = False
        '
        'lbDataFinal
        '
        Me.lbDataFinal.AutoSize = True
        Me.lbDataFinal.Location = New System.Drawing.Point(349, 63)
        Me.lbDataFinal.Name = "lbDataFinal"
        Me.lbDataFinal.Size = New System.Drawing.Size(52, 13)
        Me.lbDataFinal.TabIndex = 34
        Me.lbDataFinal.Text = "Data final"
        Me.lbDataFinal.Visible = False
        '
        'lbDataInicial
        '
        Me.lbDataInicial.AutoSize = True
        Me.lbDataInicial.Location = New System.Drawing.Point(234, 63)
        Me.lbDataInicial.Name = "lbDataInicial"
        Me.lbDataInicial.Size = New System.Drawing.Size(59, 13)
        Me.lbDataInicial.TabIndex = 32
        Me.lbDataInicial.Text = "Data inicial"
        Me.lbDataInicial.Visible = False
        '
        'btFiltrar
        '
        Me.btFiltrar.BackColor = System.Drawing.Color.White
        Me.btFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFiltrar.Location = New System.Drawing.Point(71, 105)
        Me.btFiltrar.Name = "btFiltrar"
        Me.btFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.btFiltrar.TabIndex = 38
        Me.btFiltrar.Text = "Filtrar"
        Me.btFiltrar.UseVisualStyleBackColor = False
        '
        'dgvVendas
        '
        Me.dgvVendas.AllowUserToAddRows = False
        Me.dgvVendas.AllowUserToDeleteRows = False
        Me.dgvVendas.AllowUserToResizeColumns = False
        Me.dgvVendas.AllowUserToResizeRows = False
        Me.dgvVendas.BackgroundColor = System.Drawing.Color.White
        Me.dgvVendas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVendas.Location = New System.Drawing.Point(12, 147)
        Me.dgvVendas.MultiSelect = False
        Me.dgvVendas.Name = "dgvVendas"
        Me.dgvVendas.ReadOnly = True
        Me.dgvVendas.RowHeadersVisible = False
        Me.dgvVendas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVendas.Size = New System.Drawing.Size(672, 464)
        Me.dgvVendas.TabIndex = 39
        '
        'pbxBanner
        '
        Me.pbxBanner.BackgroundImage = Global.sistechy.My.Resources.Resources.banner_vendas_fw
        Me.pbxBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxBanner.Location = New System.Drawing.Point(-5, -2)
        Me.pbxBanner.Name = "pbxBanner"
        Me.pbxBanner.Size = New System.Drawing.Size(954, 55)
        Me.pbxBanner.TabIndex = 52
        Me.pbxBanner.TabStop = False
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
        Me.btnCancelar.Location = New System.Drawing.Point(699, 203)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(227, 50)
        Me.btnCancelar.TabIndex = 41
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnDetalhes
        '
        Me.btnDetalhes.BackColor = System.Drawing.Color.White
        Me.btnDetalhes.BackgroundImage = Global.sistechy.My.Resources.Resources.detalhes_venda_fw
        Me.btnDetalhes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDetalhes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDetalhes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnDetalhes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnDetalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetalhes.Location = New System.Drawing.Point(699, 147)
        Me.btnDetalhes.Name = "btnDetalhes"
        Me.btnDetalhes.Size = New System.Drawing.Size(227, 50)
        Me.btnDetalhes.TabIndex = 40
        Me.btnDetalhes.UseVisualStyleBackColor = False
        '
        'frmConsultarVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(938, 623)
        Me.Controls.Add(Me.pbxBanner)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnDetalhes)
        Me.Controls.Add(Me.dgvVendas)
        Me.Controls.Add(Me.btFiltrar)
        Me.Controls.Add(Me.lbCod)
        Me.Controls.Add(Me.MtxtFiltroData)
        Me.Controls.Add(Me.MtxtFiltroEntreData2)
        Me.Controls.Add(Me.MtxtFiltroEntreData1)
        Me.Controls.Add(Me.cmbTiposFiltro)
        Me.Controls.Add(Me.lbData)
        Me.Controls.Add(Me.lbDataFinal)
        Me.Controls.Add(Me.lbDataInicial)
        Me.Controls.Add(Me.lbFiltrarPor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsultarVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar vendas"
        CType(Me.dgvVendas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbFiltrarPor As System.Windows.Forms.Label
    Friend WithEvents lbCod As System.Windows.Forms.Label
    Friend WithEvents MtxtFiltroData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtFiltroEntreData2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtFiltroEntreData1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbTiposFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents lbData As System.Windows.Forms.Label
    Friend WithEvents lbDataFinal As System.Windows.Forms.Label
    Friend WithEvents lbDataInicial As System.Windows.Forms.Label
    Friend WithEvents btFiltrar As System.Windows.Forms.Button
    Friend WithEvents dgvVendas As System.Windows.Forms.DataGridView
    Friend WithEvents btnDetalhes As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents pbxBanner As System.Windows.Forms.PictureBox
End Class
