<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalhesVenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalhesVenda))
        Me.lbCPFCli = New System.Windows.Forms.Label()
        Me.lbCod = New System.Windows.Forms.Label()
        Me.lbItens = New System.Windows.Forms.Label()
        Me.lbDataVenda = New System.Windows.Forms.Label()
        Me.lbValorTotal = New System.Windows.Forms.Label()
        Me.lbCartaoUtilizado = New System.Windows.Forms.Label()
        Me.lbFormaPagamento = New System.Windows.Forms.Label()
        Me.lbCodFunc = New System.Windows.Forms.Label()
        Me.dgvProdutos = New System.Windows.Forms.DataGridView()
        Me.lbProdutosComprados = New System.Windows.Forms.Label()
        Me.txtCodVenda = New System.Windows.Forms.TextBox()
        Me.txtFormaPagamento = New System.Windows.Forms.TextBox()
        Me.txtValorTotal = New System.Windows.Forms.TextBox()
        Me.txtCodFunc = New System.Windows.Forms.TextBox()
        Me.txtItens = New System.Windows.Forms.TextBox()
        Me.txtCartaoUtilizado = New System.Windows.Forms.TextBox()
        Me.MtxtDataVenda = New System.Windows.Forms.MaskedTextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MtxtCPFCli = New System.Windows.Forms.MaskedTextBox()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbCPFCli
        '
        Me.lbCPFCli.AutoSize = True
        Me.lbCPFCli.Location = New System.Drawing.Point(267, 64)
        Me.lbCPFCli.Name = "lbCPFCli"
        Me.lbCPFCli.Size = New System.Drawing.Size(76, 13)
        Me.lbCPFCli.TabIndex = 0
        Me.lbCPFCli.Text = "CPF do cliente"
        '
        'lbCod
        '
        Me.lbCod.AutoSize = True
        Me.lbCod.Location = New System.Drawing.Point(12, 64)
        Me.lbCod.Name = "lbCod"
        Me.lbCod.Size = New System.Drawing.Size(40, 13)
        Me.lbCod.TabIndex = 1
        Me.lbCod.Text = "Código"
        '
        'lbItens
        '
        Me.lbItens.AutoSize = True
        Me.lbItens.Location = New System.Drawing.Point(139, 64)
        Me.lbItens.Name = "lbItens"
        Me.lbItens.Size = New System.Drawing.Size(30, 13)
        Me.lbItens.TabIndex = 2
        Me.lbItens.Text = "Itens"
        '
        'lbDataVenda
        '
        Me.lbDataVenda.AutoSize = True
        Me.lbDataVenda.Location = New System.Drawing.Point(12, 118)
        Me.lbDataVenda.Name = "lbDataVenda"
        Me.lbDataVenda.Size = New System.Drawing.Size(78, 13)
        Me.lbDataVenda.TabIndex = 3
        Me.lbDataVenda.Text = "Data da venda"
        '
        'lbValorTotal
        '
        Me.lbValorTotal.AutoSize = True
        Me.lbValorTotal.Location = New System.Drawing.Point(115, 118)
        Me.lbValorTotal.Name = "lbValorTotal"
        Me.lbValorTotal.Size = New System.Drawing.Size(54, 13)
        Me.lbValorTotal.TabIndex = 4
        Me.lbValorTotal.Text = "Valor total"
        '
        'lbCartaoUtilizado
        '
        Me.lbCartaoUtilizado.AutoSize = True
        Me.lbCartaoUtilizado.Location = New System.Drawing.Point(382, 118)
        Me.lbCartaoUtilizado.Name = "lbCartaoUtilizado"
        Me.lbCartaoUtilizado.Size = New System.Drawing.Size(79, 13)
        Me.lbCartaoUtilizado.TabIndex = 5
        Me.lbCartaoUtilizado.Text = "Cartão utilizado"
        Me.lbCartaoUtilizado.Visible = False
        '
        'lbFormaPagamento
        '
        Me.lbFormaPagamento.AutoSize = True
        Me.lbFormaPagamento.Location = New System.Drawing.Point(248, 118)
        Me.lbFormaPagamento.Name = "lbFormaPagamento"
        Me.lbFormaPagamento.Size = New System.Drawing.Size(107, 13)
        Me.lbFormaPagamento.TabIndex = 7
        Me.lbFormaPagamento.Text = "Forma de pagamento"
        '
        'lbCodFunc
        '
        Me.lbCodFunc.AutoSize = True
        Me.lbCodFunc.Location = New System.Drawing.Point(393, 64)
        Me.lbCodFunc.Name = "lbCodFunc"
        Me.lbCodFunc.Size = New System.Drawing.Size(110, 13)
        Me.lbCodFunc.TabIndex = 8
        Me.lbCodFunc.Text = "Código do funcionário"
        '
        'dgvProdutos
        '
        Me.dgvProdutos.AllowUserToAddRows = False
        Me.dgvProdutos.AllowUserToDeleteRows = False
        Me.dgvProdutos.AllowUserToResizeColumns = False
        Me.dgvProdutos.AllowUserToResizeRows = False
        Me.dgvProdutos.BackgroundColor = System.Drawing.Color.White
        Me.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvProdutos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdutos.Location = New System.Drawing.Point(15, 204)
        Me.dgvProdutos.MultiSelect = False
        Me.dgvProdutos.Name = "dgvProdutos"
        Me.dgvProdutos.ReadOnly = True
        Me.dgvProdutos.RowHeadersVisible = False
        Me.dgvProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProdutos.Size = New System.Drawing.Size(341, 368)
        Me.dgvProdutos.TabIndex = 40
        '
        'lbProdutosComprados
        '
        Me.lbProdutosComprados.AutoSize = True
        Me.lbProdutosComprados.Location = New System.Drawing.Point(12, 188)
        Me.lbProdutosComprados.Name = "lbProdutosComprados"
        Me.lbProdutosComprados.Size = New System.Drawing.Size(107, 13)
        Me.lbProdutosComprados.TabIndex = 41
        Me.lbProdutosComprados.Text = "Produtos comprados:"
        '
        'txtCodVenda
        '
        Me.txtCodVenda.Enabled = False
        Me.txtCodVenda.Location = New System.Drawing.Point(15, 80)
        Me.txtCodVenda.Name = "txtCodVenda"
        Me.txtCodVenda.Size = New System.Drawing.Size(100, 20)
        Me.txtCodVenda.TabIndex = 42
        '
        'txtFormaPagamento
        '
        Me.txtFormaPagamento.Enabled = False
        Me.txtFormaPagamento.Location = New System.Drawing.Point(251, 134)
        Me.txtFormaPagamento.Name = "txtFormaPagamento"
        Me.txtFormaPagamento.Size = New System.Drawing.Size(100, 20)
        Me.txtFormaPagamento.TabIndex = 43
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Enabled = False
        Me.txtValorTotal.Location = New System.Drawing.Point(118, 134)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtValorTotal.TabIndex = 44
        '
        'txtCodFunc
        '
        Me.txtCodFunc.Enabled = False
        Me.txtCodFunc.Location = New System.Drawing.Point(396, 80)
        Me.txtCodFunc.Name = "txtCodFunc"
        Me.txtCodFunc.Size = New System.Drawing.Size(100, 20)
        Me.txtCodFunc.TabIndex = 45
        '
        'txtItens
        '
        Me.txtItens.Enabled = False
        Me.txtItens.Location = New System.Drawing.Point(142, 80)
        Me.txtItens.Name = "txtItens"
        Me.txtItens.Size = New System.Drawing.Size(100, 20)
        Me.txtItens.TabIndex = 47
        '
        'txtCartaoUtilizado
        '
        Me.txtCartaoUtilizado.Enabled = False
        Me.txtCartaoUtilizado.Location = New System.Drawing.Point(385, 134)
        Me.txtCartaoUtilizado.Name = "txtCartaoUtilizado"
        Me.txtCartaoUtilizado.Size = New System.Drawing.Size(100, 20)
        Me.txtCartaoUtilizado.TabIndex = 48
        Me.txtCartaoUtilizado.Visible = False
        '
        'MtxtDataVenda
        '
        Me.MtxtDataVenda.Enabled = False
        Me.MtxtDataVenda.Location = New System.Drawing.Point(16, 134)
        Me.MtxtDataVenda.Mask = "00/00/0000"
        Me.MtxtDataVenda.Name = "MtxtDataVenda"
        Me.MtxtDataVenda.Size = New System.Drawing.Size(74, 20)
        Me.MtxtDataVenda.TabIndex = 49
        Me.MtxtDataVenda.ValidatingType = GetType(Date)
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.White
        Me.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Location = New System.Drawing.Point(431, 527)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(83, 45)
        Me.btnOk.TabIndex = 50
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.sistechy.My.Resources.Resources.banner_detalhes_venda_fw
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(542, 55)
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'MtxtCPFCli
        '
        Me.MtxtCPFCli.Enabled = False
        Me.MtxtCPFCli.Location = New System.Drawing.Point(270, 80)
        Me.MtxtCPFCli.Mask = "000.000.000-00"
        Me.MtxtCPFCli.Name = "MtxtCPFCli"
        Me.MtxtCPFCli.Size = New System.Drawing.Size(100, 20)
        Me.MtxtCPFCli.TabIndex = 52
        '
        'frmDetalhesVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(526, 584)
        Me.Controls.Add(Me.MtxtCPFCli)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.MtxtDataVenda)
        Me.Controls.Add(Me.txtCartaoUtilizado)
        Me.Controls.Add(Me.txtItens)
        Me.Controls.Add(Me.txtCodFunc)
        Me.Controls.Add(Me.txtValorTotal)
        Me.Controls.Add(Me.txtFormaPagamento)
        Me.Controls.Add(Me.txtCodVenda)
        Me.Controls.Add(Me.lbProdutosComprados)
        Me.Controls.Add(Me.dgvProdutos)
        Me.Controls.Add(Me.lbCodFunc)
        Me.Controls.Add(Me.lbFormaPagamento)
        Me.Controls.Add(Me.lbCartaoUtilizado)
        Me.Controls.Add(Me.lbValorTotal)
        Me.Controls.Add(Me.lbDataVenda)
        Me.Controls.Add(Me.lbItens)
        Me.Controls.Add(Me.lbCod)
        Me.Controls.Add(Me.lbCPFCli)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDetalhesVenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalhes da venda"
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbCPFCli As System.Windows.Forms.Label
    Friend WithEvents lbCod As System.Windows.Forms.Label
    Friend WithEvents lbItens As System.Windows.Forms.Label
    Friend WithEvents lbDataVenda As System.Windows.Forms.Label
    Friend WithEvents lbValorTotal As System.Windows.Forms.Label
    Friend WithEvents lbCartaoUtilizado As System.Windows.Forms.Label
    Friend WithEvents lbFormaPagamento As System.Windows.Forms.Label
    Friend WithEvents lbCodFunc As System.Windows.Forms.Label
    Friend WithEvents dgvProdutos As System.Windows.Forms.DataGridView
    Friend WithEvents lbProdutosComprados As System.Windows.Forms.Label
    Friend WithEvents txtCodVenda As System.Windows.Forms.TextBox
    Friend WithEvents txtFormaPagamento As System.Windows.Forms.TextBox
    Friend WithEvents txtValorTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtCodFunc As System.Windows.Forms.TextBox
    Friend WithEvents txtItens As System.Windows.Forms.TextBox
    Friend WithEvents txtCartaoUtilizado As System.Windows.Forms.TextBox
    Friend WithEvents MtxtDataVenda As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MtxtCPFCli As System.Windows.Forms.MaskedTextBox
End Class
