<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReabastecerItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReabastecerItem))
        Me.gpxProdutos = New System.Windows.Forms.GroupBox()
        Me.MtxtFiltroData = New System.Windows.Forms.MaskedTextBox()
        Me.cmbFiltroTipoProduto = New System.Windows.Forms.ComboBox()
        Me.cmbFiltro = New System.Windows.Forms.ComboBox()
        Me.txtQuantidadeMaxima = New System.Windows.Forms.TextBox()
        Me.lbQuantidadeMaxima = New System.Windows.Forms.Label()
        Me.txtQuantidadeProduto = New System.Windows.Forms.TextBox()
        Me.lbQuantidade = New System.Windows.Forms.Label()
        Me.MtxtDataValidade = New System.Windows.Forms.MaskedTextBox()
        Me.txtNomeProduto = New System.Windows.Forms.TextBox()
        Me.txtTipoProduto = New System.Windows.Forms.TextBox()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.lbDataValidade = New System.Windows.Forms.Label()
        Me.lbNome = New System.Windows.Forms.Label()
        Me.lbTipoProduto = New System.Windows.Forms.Label()
        Me.lbCod = New System.Windows.Forms.Label()
        Me.dgvProduto = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscaProduto = New System.Windows.Forms.TextBox()
        Me.lbBuscarPor = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.gpxProdutos.SuspendLayout()
        CType(Me.dgvProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpxProdutos
        '
        Me.gpxProdutos.Controls.Add(Me.MtxtFiltroData)
        Me.gpxProdutos.Controls.Add(Me.cmbFiltroTipoProduto)
        Me.gpxProdutos.Controls.Add(Me.cmbFiltro)
        Me.gpxProdutos.Controls.Add(Me.txtQuantidadeMaxima)
        Me.gpxProdutos.Controls.Add(Me.lbQuantidadeMaxima)
        Me.gpxProdutos.Controls.Add(Me.txtQuantidadeProduto)
        Me.gpxProdutos.Controls.Add(Me.lbQuantidade)
        Me.gpxProdutos.Controls.Add(Me.MtxtDataValidade)
        Me.gpxProdutos.Controls.Add(Me.txtNomeProduto)
        Me.gpxProdutos.Controls.Add(Me.txtTipoProduto)
        Me.gpxProdutos.Controls.Add(Me.txtCod)
        Me.gpxProdutos.Controls.Add(Me.lbDataValidade)
        Me.gpxProdutos.Controls.Add(Me.lbNome)
        Me.gpxProdutos.Controls.Add(Me.lbTipoProduto)
        Me.gpxProdutos.Controls.Add(Me.lbCod)
        Me.gpxProdutos.Controls.Add(Me.dgvProduto)
        Me.gpxProdutos.Controls.Add(Me.btnBuscar)
        Me.gpxProdutos.Controls.Add(Me.txtBuscaProduto)
        Me.gpxProdutos.Controls.Add(Me.lbBuscarPor)
        Me.gpxProdutos.Location = New System.Drawing.Point(17, 61)
        Me.gpxProdutos.Name = "gpxProdutos"
        Me.gpxProdutos.Size = New System.Drawing.Size(737, 312)
        Me.gpxProdutos.TabIndex = 1
        Me.gpxProdutos.TabStop = False
        Me.gpxProdutos.Text = "Dados do produto"
        '
        'MtxtFiltroData
        '
        Me.MtxtFiltroData.Location = New System.Drawing.Point(223, 21)
        Me.MtxtFiltroData.Mask = "00/00/0000"
        Me.MtxtFiltroData.Name = "MtxtFiltroData"
        Me.MtxtFiltroData.Size = New System.Drawing.Size(77, 20)
        Me.MtxtFiltroData.TabIndex = 32
        Me.MtxtFiltroData.ValidatingType = GetType(Date)
        Me.MtxtFiltroData.Visible = False
        '
        'cmbFiltroTipoProduto
        '
        Me.cmbFiltroTipoProduto.FormattingEnabled = True
        Me.cmbFiltroTipoProduto.Location = New System.Drawing.Point(223, 21)
        Me.cmbFiltroTipoProduto.Name = "cmbFiltroTipoProduto"
        Me.cmbFiltroTipoProduto.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltroTipoProduto.TabIndex = 31
        Me.cmbFiltroTipoProduto.Visible = False
        '
        'cmbFiltro
        '
        Me.cmbFiltro.FormattingEnabled = True
        Me.cmbFiltro.Location = New System.Drawing.Point(83, 21)
        Me.cmbFiltro.Name = "cmbFiltro"
        Me.cmbFiltro.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltro.TabIndex = 30
        '
        'txtQuantidadeMaxima
        '
        Me.txtQuantidadeMaxima.Enabled = False
        Me.txtQuantidadeMaxima.Location = New System.Drawing.Point(170, 266)
        Me.txtQuantidadeMaxima.Name = "txtQuantidadeMaxima"
        Me.txtQuantidadeMaxima.Size = New System.Drawing.Size(113, 20)
        Me.txtQuantidadeMaxima.TabIndex = 8
        '
        'lbQuantidadeMaxima
        '
        Me.lbQuantidadeMaxima.AutoSize = True
        Me.lbQuantidadeMaxima.Location = New System.Drawing.Point(167, 251)
        Me.lbQuantidadeMaxima.Name = "lbQuantidadeMaxima"
        Me.lbQuantidadeMaxima.Size = New System.Drawing.Size(100, 13)
        Me.lbQuantidadeMaxima.TabIndex = 29
        Me.lbQuantidadeMaxima.Text = "Quantidade máxima"
        '
        'txtQuantidadeProduto
        '
        Me.txtQuantidadeProduto.Location = New System.Drawing.Point(24, 266)
        Me.txtQuantidadeProduto.Name = "txtQuantidadeProduto"
        Me.txtQuantidadeProduto.Size = New System.Drawing.Size(113, 20)
        Me.txtQuantidadeProduto.TabIndex = 7
        '
        'lbQuantidade
        '
        Me.lbQuantidade.AutoSize = True
        Me.lbQuantidade.Location = New System.Drawing.Point(21, 250)
        Me.lbQuantidade.Name = "lbQuantidade"
        Me.lbQuantidade.Size = New System.Drawing.Size(62, 13)
        Me.lbQuantidade.TabIndex = 27
        Me.lbQuantidade.Text = "Quantidade"
        '
        'MtxtDataValidade
        '
        Me.MtxtDataValidade.Enabled = False
        Me.MtxtDataValidade.Location = New System.Drawing.Point(585, 217)
        Me.MtxtDataValidade.Mask = "00/00/0000"
        Me.MtxtDataValidade.Name = "MtxtDataValidade"
        Me.MtxtDataValidade.Size = New System.Drawing.Size(85, 20)
        Me.MtxtDataValidade.TabIndex = 6
        Me.MtxtDataValidade.ValidatingType = GetType(Date)
        '
        'txtNomeProduto
        '
        Me.txtNomeProduto.Enabled = False
        Me.txtNomeProduto.Location = New System.Drawing.Point(291, 217)
        Me.txtNomeProduto.Name = "txtNomeProduto"
        Me.txtNomeProduto.Size = New System.Drawing.Size(258, 20)
        Me.txtNomeProduto.TabIndex = 5
        '
        'txtTipoProduto
        '
        Me.txtTipoProduto.Enabled = False
        Me.txtTipoProduto.Location = New System.Drawing.Point(157, 217)
        Me.txtTipoProduto.Name = "txtTipoProduto"
        Me.txtTipoProduto.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoProduto.TabIndex = 4
        '
        'txtCod
        '
        Me.txtCod.Enabled = False
        Me.txtCod.Location = New System.Drawing.Point(24, 217)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(100, 20)
        Me.txtCod.TabIndex = 3
        '
        'lbDataValidade
        '
        Me.lbDataValidade.AutoSize = True
        Me.lbDataValidade.Location = New System.Drawing.Point(582, 201)
        Me.lbDataValidade.Name = "lbDataValidade"
        Me.lbDataValidade.Size = New System.Drawing.Size(88, 13)
        Me.lbDataValidade.TabIndex = 22
        Me.lbDataValidade.Text = "Data de validade"
        '
        'lbNome
        '
        Me.lbNome.AutoSize = True
        Me.lbNome.Location = New System.Drawing.Point(288, 201)
        Me.lbNome.Name = "lbNome"
        Me.lbNome.Size = New System.Drawing.Size(35, 13)
        Me.lbNome.TabIndex = 21
        Me.lbNome.Text = "Nome"
        '
        'lbTipoProduto
        '
        Me.lbTipoProduto.AutoSize = True
        Me.lbTipoProduto.Location = New System.Drawing.Point(154, 201)
        Me.lbTipoProduto.Name = "lbTipoProduto"
        Me.lbTipoProduto.Size = New System.Drawing.Size(82, 13)
        Me.lbTipoProduto.TabIndex = 20
        Me.lbTipoProduto.Text = "Tipo de produto"
        '
        'lbCod
        '
        Me.lbCod.AutoSize = True
        Me.lbCod.Location = New System.Drawing.Point(21, 201)
        Me.lbCod.Name = "lbCod"
        Me.lbCod.Size = New System.Drawing.Size(40, 13)
        Me.lbCod.TabIndex = 19
        Me.lbCod.Text = "Código"
        '
        'dgvProduto
        '
        Me.dgvProduto.AllowUserToAddRows = False
        Me.dgvProduto.AllowUserToDeleteRows = False
        Me.dgvProduto.AllowUserToResizeColumns = False
        Me.dgvProduto.AllowUserToResizeRows = False
        Me.dgvProduto.BackgroundColor = System.Drawing.Color.White
        Me.dgvProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduto.Location = New System.Drawing.Point(19, 52)
        Me.dgvProduto.MultiSelect = False
        Me.dgvProduto.Name = "dgvProduto"
        Me.dgvProduto.ReadOnly = True
        Me.dgvProduto.RowHeadersVisible = False
        Me.dgvProduto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduto.Size = New System.Drawing.Size(695, 140)
        Me.dgvProduto.TabIndex = 18
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(410, 19)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        Me.btnBuscar.Visible = False
        '
        'txtBuscaProduto
        '
        Me.txtBuscaProduto.Location = New System.Drawing.Point(223, 22)
        Me.txtBuscaProduto.Name = "txtBuscaProduto"
        Me.txtBuscaProduto.Size = New System.Drawing.Size(168, 20)
        Me.txtBuscaProduto.TabIndex = 1
        Me.txtBuscaProduto.Visible = False
        '
        'lbBuscarPor
        '
        Me.lbBuscarPor.AutoSize = True
        Me.lbBuscarPor.Location = New System.Drawing.Point(16, 26)
        Me.lbBuscarPor.Name = "lbBuscarPor"
        Me.lbBuscarPor.Size = New System.Drawing.Size(61, 13)
        Me.lbBuscarPor.TabIndex = 0
        Me.lbBuscarPor.Text = "Buscar por:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.sistechy.My.Resources.Resources.banner_resbastecer_item_fw
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(790, 55)
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
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
        Me.btnCancelar.Location = New System.Drawing.Point(407, 384)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(170, 50)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.UseVisualStyleBackColor = False
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
        Me.btnConfirmar.Location = New System.Drawing.Point(583, 384)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(170, 50)
        Me.btnConfirmar.TabIndex = 9
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'frmReabastecerItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(771, 448)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.gpxProdutos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReabastecerItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reabastecer item"
        Me.gpxProdutos.ResumeLayout(False)
        Me.gpxProdutos.PerformLayout()
        CType(Me.dgvProduto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpxProdutos As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtBuscaProduto As System.Windows.Forms.TextBox
    Friend WithEvents lbBuscarPor As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeProduto As System.Windows.Forms.TextBox
    Friend WithEvents lbQuantidade As System.Windows.Forms.Label
    Friend WithEvents MtxtDataValidade As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtNomeProduto As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoProduto As System.Windows.Forms.TextBox
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents lbDataValidade As System.Windows.Forms.Label
    Friend WithEvents lbNome As System.Windows.Forms.Label
    Friend WithEvents lbTipoProduto As System.Windows.Forms.Label
    Friend WithEvents lbCod As System.Windows.Forms.Label
    Friend WithEvents dgvProduto As System.Windows.Forms.DataGridView
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtQuantidadeMaxima As System.Windows.Forms.TextBox
    Friend WithEvents lbQuantidadeMaxima As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents MtxtFiltroData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbFiltroTipoProduto As System.Windows.Forms.ComboBox
End Class
