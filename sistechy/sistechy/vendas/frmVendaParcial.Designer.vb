<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendaParcial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendaParcial))
        Me.lbItens = New System.Windows.Forms.Label()
        Me.lbCodProduto = New System.Windows.Forms.Label()
        Me.lbValorProduto = New System.Windows.Forms.Label()
        Me.lbNomeProduto = New System.Windows.Forms.Label()
        Me.txtItens = New System.Windows.Forms.TextBox()
        Me.txtCodProduto = New System.Windows.Forms.TextBox()
        Me.txtNomeProduto = New System.Windows.Forms.TextBox()
        Me.txtValorProduto = New System.Windows.Forms.TextBox()
        Me.lbSubTotal = New System.Windows.Forms.Label()
        Me.dgvProdutos = New System.Windows.Forms.DataGridView()
        Me.lbSubTotal2 = New System.Windows.Forms.Label()
        Me.lbItensCompra = New System.Windows.Forms.Label()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.btnProsseguirVenda = New System.Windows.Forms.Button()
        Me.lbCodVenda = New System.Windows.Forms.Label()
        Me.txtCodVenda = New System.Windows.Forms.TextBox()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.lbData = New System.Windows.Forms.Label()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbItens
        '
        Me.lbItens.AutoSize = True
        Me.lbItens.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbItens.Location = New System.Drawing.Point(26, 171)
        Me.lbItens.Name = "lbItens"
        Me.lbItens.Size = New System.Drawing.Size(74, 31)
        Me.lbItens.TabIndex = 0
        Me.lbItens.Text = "Itens"
        '
        'lbCodProduto
        '
        Me.lbCodProduto.AutoSize = True
        Me.lbCodProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodProduto.Location = New System.Drawing.Point(26, 282)
        Me.lbCodProduto.Name = "lbCodProduto"
        Me.lbCodProduto.Size = New System.Drawing.Size(236, 31)
        Me.lbCodProduto.TabIndex = 1
        Me.lbCodProduto.Text = "Código do produto"
        '
        'lbValorProduto
        '
        Me.lbValorProduto.AutoSize = True
        Me.lbValorProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbValorProduto.Location = New System.Drawing.Point(26, 496)
        Me.lbValorProduto.Name = "lbValorProduto"
        Me.lbValorProduto.Size = New System.Drawing.Size(77, 31)
        Me.lbValorProduto.TabIndex = 2
        Me.lbValorProduto.Text = "Valor"
        '
        'lbNomeProduto
        '
        Me.lbNomeProduto.AutoSize = True
        Me.lbNomeProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNomeProduto.Location = New System.Drawing.Point(26, 390)
        Me.lbNomeProduto.Name = "lbNomeProduto"
        Me.lbNomeProduto.Size = New System.Drawing.Size(86, 31)
        Me.lbNomeProduto.TabIndex = 4
        Me.lbNomeProduto.Text = "Nome"
        '
        'txtItens
        '
        Me.txtItens.Enabled = False
        Me.txtItens.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItens.Location = New System.Drawing.Point(32, 205)
        Me.txtItens.Name = "txtItens"
        Me.txtItens.Size = New System.Drawing.Size(249, 38)
        Me.txtItens.TabIndex = 6
        '
        'txtCodProduto
        '
        Me.txtCodProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodProduto.Location = New System.Drawing.Point(32, 316)
        Me.txtCodProduto.Name = "txtCodProduto"
        Me.txtCodProduto.Size = New System.Drawing.Size(249, 38)
        Me.txtCodProduto.TabIndex = 7
        '
        'txtNomeProduto
        '
        Me.txtNomeProduto.Enabled = False
        Me.txtNomeProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeProduto.Location = New System.Drawing.Point(32, 424)
        Me.txtNomeProduto.Name = "txtNomeProduto"
        Me.txtNomeProduto.Size = New System.Drawing.Size(249, 38)
        Me.txtNomeProduto.TabIndex = 8
        '
        'txtValorProduto
        '
        Me.txtValorProduto.Enabled = False
        Me.txtValorProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorProduto.Location = New System.Drawing.Point(32, 530)
        Me.txtValorProduto.Name = "txtValorProduto"
        Me.txtValorProduto.Size = New System.Drawing.Size(249, 38)
        Me.txtValorProduto.TabIndex = 10
        '
        'lbSubTotal
        '
        Me.lbSubTotal.AutoSize = True
        Me.lbSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSubTotal.Location = New System.Drawing.Point(339, 589)
        Me.lbSubTotal.Name = "lbSubTotal"
        Me.lbSubTotal.Size = New System.Drawing.Size(130, 31)
        Me.lbSubTotal.TabIndex = 11
        Me.lbSubTotal.Text = "Sub Total"
        '
        'dgvProdutos
        '
        Me.dgvProdutos.AllowUserToAddRows = False
        Me.dgvProdutos.AllowUserToDeleteRows = False
        Me.dgvProdutos.AllowUserToResizeColumns = False
        Me.dgvProdutos.AllowUserToResizeRows = False
        Me.dgvProdutos.BackgroundColor = System.Drawing.Color.White
        Me.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdutos.Location = New System.Drawing.Point(345, 104)
        Me.dgvProdutos.MultiSelect = False
        Me.dgvProdutos.Name = "dgvProdutos"
        Me.dgvProdutos.ReadOnly = True
        Me.dgvProdutos.RowHeadersVisible = False
        Me.dgvProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProdutos.Size = New System.Drawing.Size(697, 464)
        Me.dgvProdutos.TabIndex = 12
        '
        'lbSubTotal2
        '
        Me.lbSubTotal2.BackColor = System.Drawing.Color.White
        Me.lbSubTotal2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSubTotal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSubTotal2.Location = New System.Drawing.Point(345, 632)
        Me.lbSubTotal2.Name = "lbSubTotal2"
        Me.lbSubTotal2.Size = New System.Drawing.Size(472, 43)
        Me.lbSubTotal2.TabIndex = 13
        Me.lbSubTotal2.Text = "R$ 0,00"
        Me.lbSubTotal2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbItensCompra
        '
        Me.lbItensCompra.AutoSize = True
        Me.lbItensCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbItensCompra.Location = New System.Drawing.Point(339, 70)
        Me.lbItensCompra.Name = "lbItensCompra"
        Me.lbItensCompra.Size = New System.Drawing.Size(208, 31)
        Me.lbItensCompra.TabIndex = 14
        Me.lbItensCompra.Text = "Itens da compra"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackColor = System.Drawing.Color.White
        Me.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionar.Location = New System.Drawing.Point(32, 589)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(120, 44)
        Me.btnAdicionar.TabIndex = 15
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = False
        '
        'btnRemover
        '
        Me.btnRemover.BackColor = System.Drawing.Color.White
        Me.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemover.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemover.Location = New System.Drawing.Point(161, 589)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(120, 44)
        Me.btnRemover.TabIndex = 16
        Me.btnRemover.Text = "Remover"
        Me.btnRemover.UseVisualStyleBackColor = False
        '
        'btnProsseguirVenda
        '
        Me.btnProsseguirVenda.BackColor = System.Drawing.Color.White
        Me.btnProsseguirVenda.BackgroundImage = Global.sistechy.My.Resources.Resources.prosseguir_venda_fw
        Me.btnProsseguirVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProsseguirVenda.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnProsseguirVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnProsseguirVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnProsseguirVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProsseguirVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProsseguirVenda.Location = New System.Drawing.Point(1118, 104)
        Me.btnProsseguirVenda.Name = "btnProsseguirVenda"
        Me.btnProsseguirVenda.Size = New System.Drawing.Size(220, 62)
        Me.btnProsseguirVenda.TabIndex = 17
        Me.btnProsseguirVenda.UseVisualStyleBackColor = False
        '
        'lbCodVenda
        '
        Me.lbCodVenda.AutoSize = True
        Me.lbCodVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodVenda.Location = New System.Drawing.Point(26, 70)
        Me.lbCodVenda.Name = "lbCodVenda"
        Me.lbCodVenda.Size = New System.Drawing.Size(181, 31)
        Me.lbCodVenda.TabIndex = 19
        Me.lbCodVenda.Text = "Código venda"
        '
        'txtCodVenda
        '
        Me.txtCodVenda.Enabled = False
        Me.txtCodVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodVenda.Location = New System.Drawing.Point(32, 104)
        Me.txtCodVenda.Name = "txtCodVenda"
        Me.txtCodVenda.Size = New System.Drawing.Size(249, 38)
        Me.txtCodVenda.TabIndex = 20
        '
        'txtAno
        '
        Me.txtAno.Location = New System.Drawing.Point(7, 52)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(64, 20)
        Me.txtAno.TabIndex = 32
        Me.txtAno.Visible = False
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(7, 26)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(40, 20)
        Me.txtMes.TabIndex = 31
        Me.txtMes.Visible = False
        '
        'lbData
        '
        Me.lbData.AutoSize = True
        Me.lbData.Location = New System.Drawing.Point(34, 9)
        Me.lbData.Name = "lbData"
        Me.lbData.Size = New System.Drawing.Size(30, 13)
        Me.lbData.TabIndex = 30
        Me.lbData.Text = "Data"
        Me.lbData.Visible = False
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(52, 26)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidade.TabIndex = 33
        Me.txtQuantidade.Visible = False
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
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(1118, 172)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(220, 62)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'frmVendaParcial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.txtAno)
        Me.Controls.Add(Me.txtMes)
        Me.Controls.Add(Me.lbData)
        Me.Controls.Add(Me.txtCodVenda)
        Me.Controls.Add(Me.lbCodVenda)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnProsseguirVenda)
        Me.Controls.Add(Me.btnRemover)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.lbItensCompra)
        Me.Controls.Add(Me.lbSubTotal2)
        Me.Controls.Add(Me.dgvProdutos)
        Me.Controls.Add(Me.lbSubTotal)
        Me.Controls.Add(Me.txtValorProduto)
        Me.Controls.Add(Me.txtNomeProduto)
        Me.Controls.Add(Me.txtCodProduto)
        Me.Controls.Add(Me.txtItens)
        Me.Controls.Add(Me.lbNomeProduto)
        Me.Controls.Add(Me.lbValorProduto)
        Me.Controls.Add(Me.lbCodProduto)
        Me.Controls.Add(Me.lbItens)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVendaParcial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venda"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbItens As System.Windows.Forms.Label
    Friend WithEvents lbCodProduto As System.Windows.Forms.Label
    Friend WithEvents lbValorProduto As System.Windows.Forms.Label
    Friend WithEvents lbNomeProduto As System.Windows.Forms.Label
    Friend WithEvents txtItens As System.Windows.Forms.TextBox
    Friend WithEvents txtCodProduto As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeProduto As System.Windows.Forms.TextBox
    Friend WithEvents txtValorProduto As System.Windows.Forms.TextBox
    Friend WithEvents lbSubTotal As System.Windows.Forms.Label
    Friend WithEvents dgvProdutos As System.Windows.Forms.DataGridView
    Friend WithEvents lbSubTotal2 As System.Windows.Forms.Label
    Friend WithEvents lbItensCompra As System.Windows.Forms.Label
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents btnRemover As System.Windows.Forms.Button
    Friend WithEvents btnProsseguirVenda As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lbCodVenda As System.Windows.Forms.Label
    Friend WithEvents txtCodVenda As System.Windows.Forms.TextBox
    Friend WithEvents txtAno As System.Windows.Forms.TextBox
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents lbData As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As System.Windows.Forms.TextBox
End Class
