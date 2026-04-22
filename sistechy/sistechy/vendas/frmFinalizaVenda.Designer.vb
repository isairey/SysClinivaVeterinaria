<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinalizaVenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinalizaVenda))
        Me.lbCodVenda = New System.Windows.Forms.Label()
        Me.lbItens = New System.Windows.Forms.Label()
        Me.lbCodCli = New System.Windows.Forms.Label()
        Me.lbValorTotal = New System.Windows.Forms.Label()
        Me.lbFormaPagamento = New System.Windows.Forms.Label()
        Me.txtItens = New System.Windows.Forms.TextBox()
        Me.txtCodVenda = New System.Windows.Forms.TextBox()
        Me.txtValorTotal = New System.Windows.Forms.TextBox()
        Me.cmbFormaPagamento = New System.Windows.Forms.ComboBox()
        Me.pbxVisa = New System.Windows.Forms.PictureBox()
        Me.pbxAura = New System.Windows.Forms.PictureBox()
        Me.pbxDinnersClub = New System.Windows.Forms.PictureBox()
        Me.pbxHiperCard = New System.Windows.Forms.PictureBox()
        Me.pbxMasterCard = New System.Windows.Forms.PictureBox()
        Me.pbxAmericanExpress = New System.Windows.Forms.PictureBox()
        Me.RadioVisa = New System.Windows.Forms.RadioButton()
        Me.RadioMasterCard = New System.Windows.Forms.RadioButton()
        Me.RadioHiperCard = New System.Windows.Forms.RadioButton()
        Me.RadioDinnersClub = New System.Windows.Forms.RadioButton()
        Me.RadioAmericanExpress = New System.Windows.Forms.RadioButton()
        Me.RadioAura = New System.Windows.Forms.RadioButton()
        Me.btnFinalizarVenda = New System.Windows.Forms.Button()
        Me.RadioOutro = New System.Windows.Forms.RadioButton()
        Me.lbData = New System.Windows.Forms.Label()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.txtCartao = New System.Windows.Forms.TextBox()
        Me.MtxtCPFCli = New System.Windows.Forms.MaskedTextBox()
        Me.txtCodFunc = New System.Windows.Forms.TextBox()
        Me.lbTroco = New System.Windows.Forms.Label()
        Me.txtTroco = New System.Windows.Forms.TextBox()
        Me.txtRecebido = New System.Windows.Forms.TextBox()
        Me.lbRecebido = New System.Windows.Forms.Label()
        CType(Me.pbxVisa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDinnersClub, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxHiperCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMasterCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAmericanExpress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbCodVenda
        '
        Me.lbCodVenda.AutoSize = True
        Me.lbCodVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodVenda.Location = New System.Drawing.Point(417, 218)
        Me.lbCodVenda.Name = "lbCodVenda"
        Me.lbCodVenda.Size = New System.Drawing.Size(218, 31)
        Me.lbCodVenda.TabIndex = 0
        Me.lbCodVenda.Text = "Código da venda"
        Me.lbCodVenda.Visible = False
        '
        'lbItens
        '
        Me.lbItens.AutoSize = True
        Me.lbItens.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbItens.Location = New System.Drawing.Point(6, 104)
        Me.lbItens.Name = "lbItens"
        Me.lbItens.Size = New System.Drawing.Size(74, 31)
        Me.lbItens.TabIndex = 1
        Me.lbItens.Text = "Itens"
        '
        'lbCodCli
        '
        Me.lbCodCli.AutoSize = True
        Me.lbCodCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodCli.Location = New System.Drawing.Point(6, 11)
        Me.lbCodCli.Name = "lbCodCli"
        Me.lbCodCli.Size = New System.Drawing.Size(179, 31)
        Me.lbCodCli.TabIndex = 2
        Me.lbCodCli.Text = "Cliente (CPF)"
        '
        'lbValorTotal
        '
        Me.lbValorTotal.AutoSize = True
        Me.lbValorTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbValorTotal.Location = New System.Drawing.Point(6, 199)
        Me.lbValorTotal.Name = "lbValorTotal"
        Me.lbValorTotal.Size = New System.Drawing.Size(75, 31)
        Me.lbValorTotal.TabIndex = 4
        Me.lbValorTotal.Text = "Total"
        '
        'lbFormaPagamento
        '
        Me.lbFormaPagamento.AutoSize = True
        Me.lbFormaPagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFormaPagamento.Location = New System.Drawing.Point(277, 11)
        Me.lbFormaPagamento.Name = "lbFormaPagamento"
        Me.lbFormaPagamento.Size = New System.Drawing.Size(271, 31)
        Me.lbFormaPagamento.TabIndex = 5
        Me.lbFormaPagamento.Text = "Forma de pagamento"
        '
        'txtItens
        '
        Me.txtItens.Enabled = False
        Me.txtItens.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItens.Location = New System.Drawing.Point(12, 138)
        Me.txtItens.Name = "txtItens"
        Me.txtItens.Size = New System.Drawing.Size(212, 38)
        Me.txtItens.TabIndex = 6
        '
        'txtCodVenda
        '
        Me.txtCodVenda.Enabled = False
        Me.txtCodVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodVenda.Location = New System.Drawing.Point(423, 252)
        Me.txtCodVenda.Name = "txtCodVenda"
        Me.txtCodVenda.Size = New System.Drawing.Size(212, 38)
        Me.txtCodVenda.TabIndex = 7
        Me.txtCodVenda.Visible = False
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Enabled = False
        Me.txtValorTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotal.Location = New System.Drawing.Point(12, 233)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(212, 38)
        Me.txtValorTotal.TabIndex = 10
        '
        'cmbFormaPagamento
        '
        Me.cmbFormaPagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFormaPagamento.FormattingEnabled = True
        Me.cmbFormaPagamento.Location = New System.Drawing.Point(283, 45)
        Me.cmbFormaPagamento.Name = "cmbFormaPagamento"
        Me.cmbFormaPagamento.Size = New System.Drawing.Size(352, 39)
        Me.cmbFormaPagamento.TabIndex = 11
        '
        'pbxVisa
        '
        Me.pbxVisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxVisa.Location = New System.Drawing.Point(302, 90)
        Me.pbxVisa.Name = "pbxVisa"
        Me.pbxVisa.Size = New System.Drawing.Size(88, 50)
        Me.pbxVisa.TabIndex = 12
        Me.pbxVisa.TabStop = False
        Me.pbxVisa.Visible = False
        '
        'pbxAura
        '
        Me.pbxAura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxAura.Location = New System.Drawing.Point(416, 158)
        Me.pbxAura.Name = "pbxAura"
        Me.pbxAura.Size = New System.Drawing.Size(88, 50)
        Me.pbxAura.TabIndex = 13
        Me.pbxAura.TabStop = False
        Me.pbxAura.Visible = False
        '
        'pbxDinnersClub
        '
        Me.pbxDinnersClub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxDinnersClub.Location = New System.Drawing.Point(302, 158)
        Me.pbxDinnersClub.Name = "pbxDinnersClub"
        Me.pbxDinnersClub.Size = New System.Drawing.Size(88, 50)
        Me.pbxDinnersClub.TabIndex = 14
        Me.pbxDinnersClub.TabStop = False
        Me.pbxDinnersClub.Visible = False
        '
        'pbxHiperCard
        '
        Me.pbxHiperCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxHiperCard.Location = New System.Drawing.Point(530, 90)
        Me.pbxHiperCard.Name = "pbxHiperCard"
        Me.pbxHiperCard.Size = New System.Drawing.Size(88, 50)
        Me.pbxHiperCard.TabIndex = 15
        Me.pbxHiperCard.TabStop = False
        Me.pbxHiperCard.Visible = False
        '
        'pbxMasterCard
        '
        Me.pbxMasterCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxMasterCard.Location = New System.Drawing.Point(416, 90)
        Me.pbxMasterCard.Name = "pbxMasterCard"
        Me.pbxMasterCard.Size = New System.Drawing.Size(88, 50)
        Me.pbxMasterCard.TabIndex = 16
        Me.pbxMasterCard.TabStop = False
        Me.pbxMasterCard.Visible = False
        '
        'pbxAmericanExpress
        '
        Me.pbxAmericanExpress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxAmericanExpress.Location = New System.Drawing.Point(530, 158)
        Me.pbxAmericanExpress.Name = "pbxAmericanExpress"
        Me.pbxAmericanExpress.Size = New System.Drawing.Size(88, 50)
        Me.pbxAmericanExpress.TabIndex = 17
        Me.pbxAmericanExpress.TabStop = False
        Me.pbxAmericanExpress.Visible = False
        '
        'RadioVisa
        '
        Me.RadioVisa.AutoSize = True
        Me.RadioVisa.Location = New System.Drawing.Point(282, 90)
        Me.RadioVisa.Name = "RadioVisa"
        Me.RadioVisa.Size = New System.Drawing.Size(14, 13)
        Me.RadioVisa.TabIndex = 18
        Me.RadioVisa.TabStop = True
        Me.RadioVisa.UseVisualStyleBackColor = True
        Me.RadioVisa.Visible = False
        '
        'RadioMasterCard
        '
        Me.RadioMasterCard.AutoSize = True
        Me.RadioMasterCard.Location = New System.Drawing.Point(396, 90)
        Me.RadioMasterCard.Name = "RadioMasterCard"
        Me.RadioMasterCard.Size = New System.Drawing.Size(14, 13)
        Me.RadioMasterCard.TabIndex = 19
        Me.RadioMasterCard.TabStop = True
        Me.RadioMasterCard.UseVisualStyleBackColor = True
        Me.RadioMasterCard.Visible = False
        '
        'RadioHiperCard
        '
        Me.RadioHiperCard.AutoSize = True
        Me.RadioHiperCard.Location = New System.Drawing.Point(510, 90)
        Me.RadioHiperCard.Name = "RadioHiperCard"
        Me.RadioHiperCard.Size = New System.Drawing.Size(14, 13)
        Me.RadioHiperCard.TabIndex = 20
        Me.RadioHiperCard.TabStop = True
        Me.RadioHiperCard.UseVisualStyleBackColor = True
        Me.RadioHiperCard.Visible = False
        '
        'RadioDinnersClub
        '
        Me.RadioDinnersClub.AutoSize = True
        Me.RadioDinnersClub.Location = New System.Drawing.Point(282, 158)
        Me.RadioDinnersClub.Name = "RadioDinnersClub"
        Me.RadioDinnersClub.Size = New System.Drawing.Size(14, 13)
        Me.RadioDinnersClub.TabIndex = 21
        Me.RadioDinnersClub.TabStop = True
        Me.RadioDinnersClub.UseVisualStyleBackColor = True
        Me.RadioDinnersClub.Visible = False
        '
        'RadioAmericanExpress
        '
        Me.RadioAmericanExpress.AutoSize = True
        Me.RadioAmericanExpress.Location = New System.Drawing.Point(510, 154)
        Me.RadioAmericanExpress.Name = "RadioAmericanExpress"
        Me.RadioAmericanExpress.Size = New System.Drawing.Size(14, 13)
        Me.RadioAmericanExpress.TabIndex = 22
        Me.RadioAmericanExpress.TabStop = True
        Me.RadioAmericanExpress.UseVisualStyleBackColor = True
        Me.RadioAmericanExpress.Visible = False
        '
        'RadioAura
        '
        Me.RadioAura.AutoSize = True
        Me.RadioAura.Location = New System.Drawing.Point(396, 156)
        Me.RadioAura.Name = "RadioAura"
        Me.RadioAura.Size = New System.Drawing.Size(14, 13)
        Me.RadioAura.TabIndex = 23
        Me.RadioAura.TabStop = True
        Me.RadioAura.UseVisualStyleBackColor = True
        Me.RadioAura.Visible = False
        '
        'btnFinalizarVenda
        '
        Me.btnFinalizarVenda.BackColor = System.Drawing.Color.White
        Me.btnFinalizarVenda.BackgroundImage = Global.sistechy.My.Resources.Resources.finalizar_venda_fw
        Me.btnFinalizarVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFinalizarVenda.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnFinalizarVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnFinalizarVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnFinalizarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizarVenda.Location = New System.Drawing.Point(466, 321)
        Me.btnFinalizarVenda.Name = "btnFinalizarVenda"
        Me.btnFinalizarVenda.Size = New System.Drawing.Size(169, 44)
        Me.btnFinalizarVenda.TabIndex = 24
        Me.btnFinalizarVenda.UseVisualStyleBackColor = False
        '
        'RadioOutro
        '
        Me.RadioOutro.AutoSize = True
        Me.RadioOutro.Location = New System.Drawing.Point(282, 215)
        Me.RadioOutro.Name = "RadioOutro"
        Me.RadioOutro.Size = New System.Drawing.Size(51, 17)
        Me.RadioOutro.TabIndex = 26
        Me.RadioOutro.TabStop = True
        Me.RadioOutro.Text = "Outro"
        Me.RadioOutro.UseVisualStyleBackColor = True
        Me.RadioOutro.Visible = False
        '
        'lbData
        '
        Me.lbData.AutoSize = True
        Me.lbData.Location = New System.Drawing.Point(518, 11)
        Me.lbData.Name = "lbData"
        Me.lbData.Size = New System.Drawing.Size(30, 13)
        Me.lbData.TabIndex = 27
        Me.lbData.Text = "Data"
        Me.lbData.Visible = False
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(614, 12)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(40, 20)
        Me.txtMes.TabIndex = 28
        Me.txtMes.Visible = False
        '
        'txtAno
        '
        Me.txtAno.Location = New System.Drawing.Point(590, 11)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(64, 20)
        Me.txtAno.TabIndex = 29
        Me.txtAno.Visible = False
        '
        'txtCartao
        '
        Me.txtCartao.Location = New System.Drawing.Point(554, 11)
        Me.txtCartao.Name = "txtCartao"
        Me.txtCartao.Size = New System.Drawing.Size(100, 20)
        Me.txtCartao.TabIndex = 30
        Me.txtCartao.Visible = False
        '
        'MtxtCPFCli
        '
        Me.MtxtCPFCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MtxtCPFCli.Location = New System.Drawing.Point(12, 45)
        Me.MtxtCPFCli.Mask = "000.000.000-00"
        Me.MtxtCPFCli.Name = "MtxtCPFCli"
        Me.MtxtCPFCli.Size = New System.Drawing.Size(212, 38)
        Me.MtxtCPFCli.TabIndex = 31
        '
        'txtCodFunc
        '
        Me.txtCodFunc.Location = New System.Drawing.Point(554, 12)
        Me.txtCodFunc.Name = "txtCodFunc"
        Me.txtCodFunc.Size = New System.Drawing.Size(100, 20)
        Me.txtCodFunc.TabIndex = 32
        Me.txtCodFunc.Visible = False
        '
        'lbTroco
        '
        Me.lbTroco.AutoSize = True
        Me.lbTroco.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTroco.Location = New System.Drawing.Point(6, 294)
        Me.lbTroco.Name = "lbTroco"
        Me.lbTroco.Size = New System.Drawing.Size(144, 31)
        Me.lbTroco.TabIndex = 33
        Me.lbTroco.Text = "Troco (R$)"
        Me.lbTroco.Visible = False
        '
        'txtTroco
        '
        Me.txtTroco.Enabled = False
        Me.txtTroco.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTroco.Location = New System.Drawing.Point(12, 327)
        Me.txtTroco.Name = "txtTroco"
        Me.txtTroco.Size = New System.Drawing.Size(212, 38)
        Me.txtTroco.TabIndex = 34
        Me.txtTroco.Visible = False
        '
        'txtRecebido
        '
        Me.txtRecebido.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecebido.Location = New System.Drawing.Point(282, 140)
        Me.txtRecebido.Name = "txtRecebido"
        Me.txtRecebido.Size = New System.Drawing.Size(212, 38)
        Me.txtRecebido.TabIndex = 36
        Me.txtRecebido.Visible = False
        '
        'lbRecebido
        '
        Me.lbRecebido.AutoSize = True
        Me.lbRecebido.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRecebido.Location = New System.Drawing.Point(276, 107)
        Me.lbRecebido.Name = "lbRecebido"
        Me.lbRecebido.Size = New System.Drawing.Size(189, 31)
        Me.lbRecebido.TabIndex = 35
        Me.lbRecebido.Text = "Recebido (R$)"
        Me.lbRecebido.Visible = False
        '
        'frmFinalizaVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(666, 384)
        Me.Controls.Add(Me.txtRecebido)
        Me.Controls.Add(Me.lbRecebido)
        Me.Controls.Add(Me.txtTroco)
        Me.Controls.Add(Me.lbTroco)
        Me.Controls.Add(Me.txtCodFunc)
        Me.Controls.Add(Me.MtxtCPFCli)
        Me.Controls.Add(Me.txtCartao)
        Me.Controls.Add(Me.txtAno)
        Me.Controls.Add(Me.txtMes)
        Me.Controls.Add(Me.lbData)
        Me.Controls.Add(Me.RadioOutro)
        Me.Controls.Add(Me.btnFinalizarVenda)
        Me.Controls.Add(Me.RadioAura)
        Me.Controls.Add(Me.RadioAmericanExpress)
        Me.Controls.Add(Me.RadioDinnersClub)
        Me.Controls.Add(Me.RadioHiperCard)
        Me.Controls.Add(Me.RadioMasterCard)
        Me.Controls.Add(Me.RadioVisa)
        Me.Controls.Add(Me.pbxAmericanExpress)
        Me.Controls.Add(Me.pbxMasterCard)
        Me.Controls.Add(Me.pbxHiperCard)
        Me.Controls.Add(Me.pbxDinnersClub)
        Me.Controls.Add(Me.pbxAura)
        Me.Controls.Add(Me.pbxVisa)
        Me.Controls.Add(Me.cmbFormaPagamento)
        Me.Controls.Add(Me.txtValorTotal)
        Me.Controls.Add(Me.txtCodVenda)
        Me.Controls.Add(Me.txtItens)
        Me.Controls.Add(Me.lbFormaPagamento)
        Me.Controls.Add(Me.lbValorTotal)
        Me.Controls.Add(Me.lbCodCli)
        Me.Controls.Add(Me.lbItens)
        Me.Controls.Add(Me.lbCodVenda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFinalizaVenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finaliza venda"
        CType(Me.pbxVisa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDinnersClub, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxHiperCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMasterCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAmericanExpress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbCodVenda As System.Windows.Forms.Label
    Friend WithEvents lbItens As System.Windows.Forms.Label
    Friend WithEvents lbCodCli As System.Windows.Forms.Label
    Friend WithEvents lbValorTotal As System.Windows.Forms.Label
    Friend WithEvents lbFormaPagamento As System.Windows.Forms.Label
    Friend WithEvents txtItens As System.Windows.Forms.TextBox
    Friend WithEvents txtCodVenda As System.Windows.Forms.TextBox
    Friend WithEvents txtValorTotal As System.Windows.Forms.TextBox
    Friend WithEvents cmbFormaPagamento As System.Windows.Forms.ComboBox
    Friend WithEvents pbxVisa As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAura As System.Windows.Forms.PictureBox
    Friend WithEvents pbxDinnersClub As System.Windows.Forms.PictureBox
    Friend WithEvents pbxHiperCard As System.Windows.Forms.PictureBox
    Friend WithEvents pbxMasterCard As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAmericanExpress As System.Windows.Forms.PictureBox
    Friend WithEvents RadioVisa As System.Windows.Forms.RadioButton
    Friend WithEvents RadioMasterCard As System.Windows.Forms.RadioButton
    Friend WithEvents RadioHiperCard As System.Windows.Forms.RadioButton
    Friend WithEvents RadioDinnersClub As System.Windows.Forms.RadioButton
    Friend WithEvents RadioAmericanExpress As System.Windows.Forms.RadioButton
    Friend WithEvents RadioAura As System.Windows.Forms.RadioButton
    Friend WithEvents btnFinalizarVenda As System.Windows.Forms.Button
    Friend WithEvents RadioOutro As System.Windows.Forms.RadioButton
    Friend WithEvents lbData As System.Windows.Forms.Label
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents txtAno As System.Windows.Forms.TextBox
    Friend WithEvents txtCartao As System.Windows.Forms.TextBox
    Friend WithEvents MtxtCPFCli As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCodFunc As System.Windows.Forms.TextBox
    Friend WithEvents lbTroco As System.Windows.Forms.Label
    Friend WithEvents txtTroco As System.Windows.Forms.TextBox
    Friend WithEvents txtRecebido As System.Windows.Forms.TextBox
    Friend WithEvents lbRecebido As System.Windows.Forms.Label
End Class
