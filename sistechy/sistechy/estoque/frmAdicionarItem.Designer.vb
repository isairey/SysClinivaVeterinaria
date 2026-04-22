<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdicionarItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdicionarItem))
        Me.lbCodForne = New System.Windows.Forms.Label()
        Me.lbDescricao = New System.Windows.Forms.Label()
        Me.lbTipoProduto = New System.Windows.Forms.Label()
        Me.lbMarca = New System.Windows.Forms.Label()
        Me.lbNome = New System.Windows.Forms.Label()
        Me.lbQuantidade = New System.Windows.Forms.Label()
        Me.lbQuantidadeMinima = New System.Windows.Forms.Label()
        Me.lbQuantidadeMaxima = New System.Windows.Forms.Label()
        Me.lbDataValidade = New System.Windows.Forms.Label()
        Me.lbPreco = New System.Windows.Forms.Label()
        Me.gpxProduto = New System.Windows.Forms.GroupBox()
        Me.btnCarregarImagem = New System.Windows.Forms.Button()
        Me.cmbTipoProduto = New System.Windows.Forms.ComboBox()
        Me.MtxtDataValidade = New System.Windows.Forms.MaskedTextBox()
        Me.txtPrecoProduto = New System.Windows.Forms.TextBox()
        Me.txtQuantidadeMinima = New System.Windows.Forms.TextBox()
        Me.txtNomeProduto = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.RichTextBox()
        Me.txtQuantidadeMaxima = New System.Windows.Forms.TextBox()
        Me.txtQuantidadeProduto = New System.Windows.Forms.TextBox()
        Me.txtMarcaProduto = New System.Windows.Forms.TextBox()
        Me.txtCodForne = New System.Windows.Forms.TextBox()
        Me.pbxProduto = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtLocalImagem = New System.Windows.Forms.TextBox()
        Me.btnAdicionarProduto = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.pbxBanner = New System.Windows.Forms.PictureBox()
        Me.gpxProduto.SuspendLayout()
        CType(Me.pbxProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbCodForne
        '
        Me.lbCodForne.AutoSize = True
        Me.lbCodForne.Location = New System.Drawing.Point(195, 28)
        Me.lbCodForne.Name = "lbCodForne"
        Me.lbCodForne.Size = New System.Drawing.Size(109, 13)
        Me.lbCodForne.TabIndex = 0
        Me.lbCodForne.Text = "Código do fornecedor"
        '
        'lbDescricao
        '
        Me.lbDescricao.AutoSize = True
        Me.lbDescricao.Location = New System.Drawing.Point(195, 177)
        Me.lbDescricao.Name = "lbDescricao"
        Me.lbDescricao.Size = New System.Drawing.Size(55, 13)
        Me.lbDescricao.TabIndex = 1
        Me.lbDescricao.Text = "Descrição"
        '
        'lbTipoProduto
        '
        Me.lbTipoProduto.AutoSize = True
        Me.lbTipoProduto.Location = New System.Drawing.Point(347, 28)
        Me.lbTipoProduto.Name = "lbTipoProduto"
        Me.lbTipoProduto.Size = New System.Drawing.Size(82, 13)
        Me.lbTipoProduto.TabIndex = 2
        Me.lbTipoProduto.Text = "Tipo de produto"
        '
        'lbMarca
        '
        Me.lbMarca.AutoSize = True
        Me.lbMarca.Location = New System.Drawing.Point(195, 80)
        Me.lbMarca.Name = "lbMarca"
        Me.lbMarca.Size = New System.Drawing.Size(37, 13)
        Me.lbMarca.TabIndex = 3
        Me.lbMarca.Text = "Marca"
        '
        'lbNome
        '
        Me.lbNome.AutoSize = True
        Me.lbNome.Location = New System.Drawing.Point(483, 28)
        Me.lbNome.Name = "lbNome"
        Me.lbNome.Size = New System.Drawing.Size(35, 13)
        Me.lbNome.TabIndex = 4
        Me.lbNome.Text = "Nome"
        '
        'lbQuantidade
        '
        Me.lbQuantidade.AutoSize = True
        Me.lbQuantidade.Location = New System.Drawing.Point(366, 80)
        Me.lbQuantidade.Name = "lbQuantidade"
        Me.lbQuantidade.Size = New System.Drawing.Size(62, 13)
        Me.lbQuantidade.TabIndex = 5
        Me.lbQuantidade.Text = "Quantidade"
        '
        'lbQuantidadeMinima
        '
        Me.lbQuantidadeMinima.AutoSize = True
        Me.lbQuantidadeMinima.Location = New System.Drawing.Point(504, 80)
        Me.lbQuantidadeMinima.Name = "lbQuantidadeMinima"
        Me.lbQuantidadeMinima.Size = New System.Drawing.Size(99, 13)
        Me.lbQuantidadeMinima.TabIndex = 6
        Me.lbQuantidadeMinima.Text = "Quantidade mínima"
        '
        'lbQuantidadeMaxima
        '
        Me.lbQuantidadeMaxima.AutoSize = True
        Me.lbQuantidadeMaxima.Location = New System.Drawing.Point(636, 80)
        Me.lbQuantidadeMaxima.Name = "lbQuantidadeMaxima"
        Me.lbQuantidadeMaxima.Size = New System.Drawing.Size(100, 13)
        Me.lbQuantidadeMaxima.TabIndex = 7
        Me.lbQuantidadeMaxima.Text = "Quantidade máxima"
        '
        'lbDataValidade
        '
        Me.lbDataValidade.AutoSize = True
        Me.lbDataValidade.Location = New System.Drawing.Point(195, 128)
        Me.lbDataValidade.Name = "lbDataValidade"
        Me.lbDataValidade.Size = New System.Drawing.Size(88, 13)
        Me.lbDataValidade.TabIndex = 8
        Me.lbDataValidade.Text = "Data de validade"
        '
        'lbPreco
        '
        Me.lbPreco.AutoSize = True
        Me.lbPreco.Location = New System.Drawing.Point(317, 128)
        Me.lbPreco.Name = "lbPreco"
        Me.lbPreco.Size = New System.Drawing.Size(35, 13)
        Me.lbPreco.TabIndex = 9
        Me.lbPreco.Text = "Preço"
        '
        'gpxProduto
        '
        Me.gpxProduto.Controls.Add(Me.btnCarregarImagem)
        Me.gpxProduto.Controls.Add(Me.cmbTipoProduto)
        Me.gpxProduto.Controls.Add(Me.MtxtDataValidade)
        Me.gpxProduto.Controls.Add(Me.txtPrecoProduto)
        Me.gpxProduto.Controls.Add(Me.txtQuantidadeMinima)
        Me.gpxProduto.Controls.Add(Me.txtNomeProduto)
        Me.gpxProduto.Controls.Add(Me.txtDescricao)
        Me.gpxProduto.Controls.Add(Me.txtQuantidadeMaxima)
        Me.gpxProduto.Controls.Add(Me.txtQuantidadeProduto)
        Me.gpxProduto.Controls.Add(Me.txtMarcaProduto)
        Me.gpxProduto.Controls.Add(Me.txtCodForne)
        Me.gpxProduto.Controls.Add(Me.pbxProduto)
        Me.gpxProduto.Controls.Add(Me.lbCodForne)
        Me.gpxProduto.Controls.Add(Me.lbDescricao)
        Me.gpxProduto.Controls.Add(Me.lbPreco)
        Me.gpxProduto.Controls.Add(Me.lbTipoProduto)
        Me.gpxProduto.Controls.Add(Me.lbDataValidade)
        Me.gpxProduto.Controls.Add(Me.lbMarca)
        Me.gpxProduto.Controls.Add(Me.lbQuantidadeMaxima)
        Me.gpxProduto.Controls.Add(Me.lbNome)
        Me.gpxProduto.Controls.Add(Me.lbQuantidadeMinima)
        Me.gpxProduto.Controls.Add(Me.lbQuantidade)
        Me.gpxProduto.Location = New System.Drawing.Point(14, 59)
        Me.gpxProduto.Name = "gpxProduto"
        Me.gpxProduto.Size = New System.Drawing.Size(829, 268)
        Me.gpxProduto.TabIndex = 12
        Me.gpxProduto.TabStop = False
        Me.gpxProduto.Text = "Informações do produto"
        '
        'btnCarregarImagem
        '
        Me.btnCarregarImagem.BackColor = System.Drawing.Color.White
        Me.btnCarregarImagem.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCarregarImagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnCarregarImagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCarregarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCarregarImagem.Location = New System.Drawing.Point(17, 219)
        Me.btnCarregarImagem.Name = "btnCarregarImagem"
        Me.btnCarregarImagem.Size = New System.Drawing.Size(149, 23)
        Me.btnCarregarImagem.TabIndex = 11
        Me.btnCarregarImagem.Text = "Carregar imagem"
        Me.btnCarregarImagem.UseVisualStyleBackColor = False
        '
        'cmbTipoProduto
        '
        Me.cmbTipoProduto.FormattingEnabled = True
        Me.cmbTipoProduto.Location = New System.Drawing.Point(350, 44)
        Me.cmbTipoProduto.Name = "cmbTipoProduto"
        Me.cmbTipoProduto.Size = New System.Drawing.Size(106, 21)
        Me.cmbTipoProduto.TabIndex = 2
        '
        'MtxtDataValidade
        '
        Me.MtxtDataValidade.Location = New System.Drawing.Point(198, 144)
        Me.MtxtDataValidade.Mask = "00/00/0000"
        Me.MtxtDataValidade.Name = "MtxtDataValidade"
        Me.MtxtDataValidade.Size = New System.Drawing.Size(73, 20)
        Me.MtxtDataValidade.TabIndex = 8
        '
        'txtPrecoProduto
        '
        Me.txtPrecoProduto.Location = New System.Drawing.Point(320, 144)
        Me.txtPrecoProduto.Name = "txtPrecoProduto"
        Me.txtPrecoProduto.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecoProduto.TabIndex = 9
        Me.txtPrecoProduto.Text = "R$ "
        '
        'txtQuantidadeMinima
        '
        Me.txtQuantidadeMinima.Location = New System.Drawing.Point(507, 96)
        Me.txtQuantidadeMinima.Name = "txtQuantidadeMinima"
        Me.txtQuantidadeMinima.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidadeMinima.TabIndex = 6
        '
        'txtNomeProduto
        '
        Me.txtNomeProduto.Location = New System.Drawing.Point(486, 44)
        Me.txtNomeProduto.Name = "txtNomeProduto"
        Me.txtNomeProduto.Size = New System.Drawing.Size(317, 20)
        Me.txtNomeProduto.TabIndex = 3
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(198, 193)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(605, 57)
        Me.txtDescricao.TabIndex = 10
        Me.txtDescricao.Text = ""
        '
        'txtQuantidadeMaxima
        '
        Me.txtQuantidadeMaxima.Location = New System.Drawing.Point(639, 96)
        Me.txtQuantidadeMaxima.Name = "txtQuantidadeMaxima"
        Me.txtQuantidadeMaxima.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidadeMaxima.TabIndex = 7
        '
        'txtQuantidadeProduto
        '
        Me.txtQuantidadeProduto.Location = New System.Drawing.Point(369, 96)
        Me.txtQuantidadeProduto.Name = "txtQuantidadeProduto"
        Me.txtQuantidadeProduto.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidadeProduto.TabIndex = 5
        '
        'txtMarcaProduto
        '
        Me.txtMarcaProduto.Location = New System.Drawing.Point(198, 96)
        Me.txtMarcaProduto.Name = "txtMarcaProduto"
        Me.txtMarcaProduto.Size = New System.Drawing.Size(134, 20)
        Me.txtMarcaProduto.TabIndex = 4
        '
        'txtCodForne
        '
        Me.txtCodForne.Location = New System.Drawing.Point(198, 44)
        Me.txtCodForne.Name = "txtCodForne"
        Me.txtCodForne.Size = New System.Drawing.Size(117, 20)
        Me.txtCodForne.TabIndex = 1
        '
        'pbxProduto
        '
        Me.pbxProduto.BackColor = System.Drawing.Color.White
        Me.pbxProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxProduto.Location = New System.Drawing.Point(17, 28)
        Me.pbxProduto.Name = "pbxProduto"
        Me.pbxProduto.Size = New System.Drawing.Size(149, 185)
        Me.pbxProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxProduto.TabIndex = 10
        Me.pbxProduto.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(252, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Local da imagem"
        Me.Label12.Visible = False
        '
        'txtLocalImagem
        '
        Me.txtLocalImagem.Location = New System.Drawing.Point(255, 73)
        Me.txtLocalImagem.Name = "txtLocalImagem"
        Me.txtLocalImagem.Size = New System.Drawing.Size(588, 20)
        Me.txtLocalImagem.TabIndex = 25
        Me.txtLocalImagem.Visible = False
        '
        'btnAdicionarProduto
        '
        Me.btnAdicionarProduto.BackColor = System.Drawing.Color.White
        Me.btnAdicionarProduto.BackgroundImage = Global.sistechy.My.Resources.Resources.salva_cadastro_fw
        Me.btnAdicionarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdicionarProduto.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAdicionarProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnAdicionarProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionarProduto.Location = New System.Drawing.Point(673, 338)
        Me.btnAdicionarProduto.Name = "btnAdicionarProduto"
        Me.btnAdicionarProduto.Size = New System.Drawing.Size(170, 50)
        Me.btnAdicionarProduto.TabIndex = 12
        Me.btnAdicionarProduto.UseVisualStyleBackColor = False
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
        Me.btnCancelar.Location = New System.Drawing.Point(497, 338)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(170, 50)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'pbxBanner
        '
        Me.pbxBanner.BackgroundImage = Global.sistechy.My.Resources.Resources.banner_adicionar_item_fw
        Me.pbxBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxBanner.Location = New System.Drawing.Point(-5, -2)
        Me.pbxBanner.Name = "pbxBanner"
        Me.pbxBanner.Size = New System.Drawing.Size(871, 55)
        Me.pbxBanner.TabIndex = 69
        Me.pbxBanner.TabStop = False
        '
        'frmAdicionarItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(855, 402)
        Me.Controls.Add(Me.pbxBanner)
        Me.Controls.Add(Me.txtLocalImagem)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAdicionarProduto)
        Me.Controls.Add(Me.gpxProduto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdicionarItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Novo item"
        Me.gpxProduto.ResumeLayout(False)
        Me.gpxProduto.PerformLayout()
        CType(Me.pbxProduto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbCodForne As System.Windows.Forms.Label
    Friend WithEvents lbDescricao As System.Windows.Forms.Label
    Friend WithEvents lbTipoProduto As System.Windows.Forms.Label
    Friend WithEvents lbMarca As System.Windows.Forms.Label
    Friend WithEvents lbNome As System.Windows.Forms.Label
    Friend WithEvents lbQuantidade As System.Windows.Forms.Label
    Friend WithEvents lbQuantidadeMinima As System.Windows.Forms.Label
    Friend WithEvents lbQuantidadeMaxima As System.Windows.Forms.Label
    Friend WithEvents lbDataValidade As System.Windows.Forms.Label
    Friend WithEvents lbPreco As System.Windows.Forms.Label
    Friend WithEvents pbxProduto As System.Windows.Forms.PictureBox
    Friend WithEvents gpxProduto As System.Windows.Forms.GroupBox
    Friend WithEvents txtPrecoProduto As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantidadeMinima As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeProduto As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantidadeMaxima As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantidadeProduto As System.Windows.Forms.TextBox
    Friend WithEvents txtMarcaProduto As System.Windows.Forms.TextBox
    Friend WithEvents txtCodForne As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipoProduto As System.Windows.Forms.ComboBox
    Friend WithEvents MtxtDataValidade As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDescricao As System.Windows.Forms.RichTextBox
    Friend WithEvents btnCarregarImagem As System.Windows.Forms.Button
    Friend WithEvents txtLocalImagem As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnAdicionarProduto As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents pbxBanner As System.Windows.Forms.PictureBox
End Class
