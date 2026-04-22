<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastro_cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastro_cliente))
        Me.lbNomeCli = New System.Windows.Forms.Label()
        Me.lbDDDCli = New System.Windows.Forms.Label()
        Me.lbEmailCli = New System.Windows.Forms.Label()
        Me.lbTelefoneCli = New System.Windows.Forms.Label()
        Me.lbCelularCli = New System.Windows.Forms.Label()
        Me.lbSexoCli = New System.Windows.Forms.Label()
        Me.lbDataNascCli = New System.Windows.Forms.Label()
        Me.lbCPFCli = New System.Windows.Forms.Label()
        Me.lbRGCli = New System.Windows.Forms.Label()
        Me.txtEmailCli = New System.Windows.Forms.TextBox()
        Me.cmbSexoCli = New System.Windows.Forms.ComboBox()
        Me.lbDataCadCli = New System.Windows.Forms.Label()
        Me.lbEnderecoCli = New System.Windows.Forms.Label()
        Me.lbNumeroCli = New System.Windows.Forms.Label()
        Me.lbBairroCli = New System.Windows.Forms.Label()
        Me.lbUFCli = New System.Windows.Forms.Label()
        Me.lbCidadeCli = New System.Windows.Forms.Label()
        Me.lbCEPCli = New System.Windows.Forms.Label()
        Me.txtEndCli = New System.Windows.Forms.TextBox()
        Me.txtCidadeCli = New System.Windows.Forms.TextBox()
        Me.txtBairroCli = New System.Windows.Forms.TextBox()
        Me.txtNomeCli = New System.Windows.Forms.TextBox()
        Me.cmbUFcli = New System.Windows.Forms.ComboBox()
        Me.MtxtDDDCli = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtCPFCli = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtCEPCli = New System.Windows.Forms.MaskedTextBox()
        Me.lbObrigatoriedade = New System.Windows.Forms.Label()
        Me.txtNumCli = New System.Windows.Forms.TextBox()
        Me.txtRGCli = New System.Windows.Forms.TextBox()
        Me.MtxtCelCli = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtTelCli = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtDataNascCli = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtDataCadCli = New System.Windows.Forms.MaskedTextBox()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnCadastraCli = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbNomeCli
        '
        Me.lbNomeCli.AutoSize = True
        Me.lbNomeCli.Location = New System.Drawing.Point(6, 81)
        Me.lbNomeCli.Name = "lbNomeCli"
        Me.lbNomeCli.Size = New System.Drawing.Size(48, 13)
        Me.lbNomeCli.TabIndex = 0
        Me.lbNomeCli.Text = "Nome (*)"
        '
        'lbDDDCli
        '
        Me.lbDDDCli.AutoSize = True
        Me.lbDDDCli.Location = New System.Drawing.Point(10, 140)
        Me.lbDDDCli.Name = "lbDDDCli"
        Me.lbDDDCli.Size = New System.Drawing.Size(44, 13)
        Me.lbDDDCli.TabIndex = 1
        Me.lbDDDCli.Text = "DDD (*)"
        '
        'lbEmailCli
        '
        Me.lbEmailCli.AutoSize = True
        Me.lbEmailCli.Location = New System.Drawing.Point(9, 194)
        Me.lbEmailCli.Name = "lbEmailCli"
        Me.lbEmailCli.Size = New System.Drawing.Size(32, 13)
        Me.lbEmailCli.TabIndex = 2
        Me.lbEmailCli.Text = "Email"
        '
        'lbTelefoneCli
        '
        Me.lbTelefoneCli.AutoSize = True
        Me.lbTelefoneCli.Location = New System.Drawing.Point(74, 140)
        Me.lbTelefoneCli.Name = "lbTelefoneCli"
        Me.lbTelefoneCli.Size = New System.Drawing.Size(62, 13)
        Me.lbTelefoneCli.TabIndex = 3
        Me.lbTelefoneCli.Text = "Telefone (*)"
        '
        'lbCelularCli
        '
        Me.lbCelularCli.AutoSize = True
        Me.lbCelularCli.Location = New System.Drawing.Point(196, 140)
        Me.lbCelularCli.Name = "lbCelularCli"
        Me.lbCelularCli.Size = New System.Drawing.Size(39, 13)
        Me.lbCelularCli.TabIndex = 4
        Me.lbCelularCli.Text = "Celular"
        '
        'lbSexoCli
        '
        Me.lbSexoCli.AutoSize = True
        Me.lbSexoCli.Location = New System.Drawing.Point(396, 194)
        Me.lbSexoCli.Name = "lbSexoCli"
        Me.lbSexoCli.Size = New System.Drawing.Size(44, 13)
        Me.lbSexoCli.TabIndex = 5
        Me.lbSexoCli.Text = "Sexo (*)"
        '
        'lbDataNascCli
        '
        Me.lbDataNascCli.AutoSize = True
        Me.lbDataNascCli.Location = New System.Drawing.Point(9, 246)
        Me.lbDataNascCli.Name = "lbDataNascCli"
        Me.lbDataNascCli.Size = New System.Drawing.Size(102, 13)
        Me.lbDataNascCli.TabIndex = 6
        Me.lbDataNascCli.Text = "Data de nascimento"
        '
        'lbCPFCli
        '
        Me.lbCPFCli.AutoSize = True
        Me.lbCPFCli.Location = New System.Drawing.Point(143, 246)
        Me.lbCPFCli.Name = "lbCPFCli"
        Me.lbCPFCli.Size = New System.Drawing.Size(40, 13)
        Me.lbCPFCli.TabIndex = 7
        Me.lbCPFCli.Text = "CPF (*)"
        '
        'lbRGCli
        '
        Me.lbRGCli.AutoSize = True
        Me.lbRGCli.Location = New System.Drawing.Point(292, 246)
        Me.lbRGCli.Name = "lbRGCli"
        Me.lbRGCli.Size = New System.Drawing.Size(23, 13)
        Me.lbRGCli.TabIndex = 8
        Me.lbRGCli.Text = "RG"
        '
        'txtEmailCli
        '
        Me.txtEmailCli.Location = New System.Drawing.Point(12, 210)
        Me.txtEmailCli.Name = "txtEmailCli"
        Me.txtEmailCli.Size = New System.Drawing.Size(351, 20)
        Me.txtEmailCli.TabIndex = 5
        '
        'cmbSexoCli
        '
        Me.cmbSexoCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexoCli.FormattingEnabled = True
        Me.cmbSexoCli.Location = New System.Drawing.Point(399, 210)
        Me.cmbSexoCli.Name = "cmbSexoCli"
        Me.cmbSexoCli.Size = New System.Drawing.Size(121, 21)
        Me.cmbSexoCli.TabIndex = 6
        '
        'lbDataCadCli
        '
        Me.lbDataCadCli.AutoSize = True
        Me.lbDataCadCli.Location = New System.Drawing.Point(9, 301)
        Me.lbDataCadCli.Name = "lbDataCadCli"
        Me.lbDataCadCli.Size = New System.Drawing.Size(89, 13)
        Me.lbDataCadCli.TabIndex = 19
        Me.lbDataCadCli.Text = "Data de cadastro"
        '
        'lbEnderecoCli
        '
        Me.lbEnderecoCli.AutoSize = True
        Me.lbEnderecoCli.Location = New System.Drawing.Point(152, 301)
        Me.lbEnderecoCli.Name = "lbEnderecoCli"
        Me.lbEnderecoCli.Size = New System.Drawing.Size(66, 13)
        Me.lbEnderecoCli.TabIndex = 20
        Me.lbEnderecoCli.Text = "Endereço (*)"
        '
        'lbNumeroCli
        '
        Me.lbNumeroCli.AutoSize = True
        Me.lbNumeroCli.Location = New System.Drawing.Point(9, 361)
        Me.lbNumeroCli.Name = "lbNumeroCli"
        Me.lbNumeroCli.Size = New System.Drawing.Size(44, 13)
        Me.lbNumeroCli.TabIndex = 21
        Me.lbNumeroCli.Text = "Número"
        '
        'lbBairroCli
        '
        Me.lbBairroCli.AutoSize = True
        Me.lbBairroCli.Location = New System.Drawing.Point(9, 412)
        Me.lbBairroCli.Name = "lbBairroCli"
        Me.lbBairroCli.Size = New System.Drawing.Size(34, 13)
        Me.lbBairroCli.TabIndex = 22
        Me.lbBairroCli.Text = "Bairro"
        '
        'lbUFCli
        '
        Me.lbUFCli.AutoSize = True
        Me.lbUFCli.Location = New System.Drawing.Point(408, 359)
        Me.lbUFCli.Name = "lbUFCli"
        Me.lbUFCli.Size = New System.Drawing.Size(21, 13)
        Me.lbUFCli.TabIndex = 23
        Me.lbUFCli.Text = "UF"
        '
        'lbCidadeCli
        '
        Me.lbCidadeCli.AutoSize = True
        Me.lbCidadeCli.Location = New System.Drawing.Point(108, 360)
        Me.lbCidadeCli.Name = "lbCidadeCli"
        Me.lbCidadeCli.Size = New System.Drawing.Size(40, 13)
        Me.lbCidadeCli.TabIndex = 24
        Me.lbCidadeCli.Text = "Cidade"
        '
        'lbCEPCli
        '
        Me.lbCEPCli.AutoSize = True
        Me.lbCEPCli.Location = New System.Drawing.Point(287, 412)
        Me.lbCEPCli.Name = "lbCEPCli"
        Me.lbCEPCli.Size = New System.Drawing.Size(28, 13)
        Me.lbCEPCli.TabIndex = 25
        Me.lbCEPCli.Text = "CEP"
        '
        'txtEndCli
        '
        Me.txtEndCli.Location = New System.Drawing.Point(155, 318)
        Me.txtEndCli.Name = "txtEndCli"
        Me.txtEndCli.Size = New System.Drawing.Size(365, 20)
        Me.txtEndCli.TabIndex = 11
        '
        'txtCidadeCli
        '
        Me.txtCidadeCli.Location = New System.Drawing.Point(108, 376)
        Me.txtCidadeCli.Name = "txtCidadeCli"
        Me.txtCidadeCli.Size = New System.Drawing.Size(282, 20)
        Me.txtCidadeCli.TabIndex = 13
        '
        'txtBairroCli
        '
        Me.txtBairroCli.Location = New System.Drawing.Point(12, 428)
        Me.txtBairroCli.Name = "txtBairroCli"
        Me.txtBairroCli.Size = New System.Drawing.Size(249, 20)
        Me.txtBairroCli.TabIndex = 15
        '
        'txtNomeCli
        '
        Me.txtNomeCli.Location = New System.Drawing.Point(9, 98)
        Me.txtNomeCli.Name = "txtNomeCli"
        Me.txtNomeCli.Size = New System.Drawing.Size(354, 20)
        Me.txtNomeCli.TabIndex = 1
        '
        'cmbUFcli
        '
        Me.cmbUFcli.AllowDrop = True
        Me.cmbUFcli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUFcli.FormattingEnabled = True
        Me.cmbUFcli.Location = New System.Drawing.Point(409, 376)
        Me.cmbUFcli.MaxDropDownItems = 3
        Me.cmbUFcli.Name = "cmbUFcli"
        Me.cmbUFcli.Size = New System.Drawing.Size(52, 21)
        Me.cmbUFcli.TabIndex = 14
        '
        'MtxtDDDCli
        '
        Me.MtxtDDDCli.Location = New System.Drawing.Point(13, 155)
        Me.MtxtDDDCli.Mask = "(000)"
        Me.MtxtDDDCli.Name = "MtxtDDDCli"
        Me.MtxtDDDCli.Size = New System.Drawing.Size(31, 20)
        Me.MtxtDDDCli.TabIndex = 2
        '
        'MtxtCPFCli
        '
        Me.MtxtCPFCli.Location = New System.Drawing.Point(146, 261)
        Me.MtxtCPFCli.Mask = "000.000.000-00"
        Me.MtxtCPFCli.Name = "MtxtCPFCli"
        Me.MtxtCPFCli.Size = New System.Drawing.Size(89, 20)
        Me.MtxtCPFCli.TabIndex = 8
        '
        'MtxtCEPCli
        '
        Me.MtxtCEPCli.Location = New System.Drawing.Point(290, 428)
        Me.MtxtCEPCli.Mask = "00000-000"
        Me.MtxtCEPCli.Name = "MtxtCEPCli"
        Me.MtxtCEPCli.Size = New System.Drawing.Size(59, 20)
        Me.MtxtCEPCli.TabIndex = 16
        '
        'lbObrigatoriedade
        '
        Me.lbObrigatoriedade.AutoSize = True
        Me.lbObrigatoriedade.Location = New System.Drawing.Point(10, 461)
        Me.lbObrigatoriedade.Name = "lbObrigatoriedade"
        Me.lbObrigatoriedade.Size = New System.Drawing.Size(256, 13)
        Me.lbObrigatoriedade.TabIndex = 58
        Me.lbObrigatoriedade.Text = "Os campos com (*) são de preenchimento obrigatório"
        '
        'txtNumCli
        '
        Me.txtNumCli.Location = New System.Drawing.Point(12, 377)
        Me.txtNumCli.Name = "txtNumCli"
        Me.txtNumCli.Size = New System.Drawing.Size(62, 20)
        Me.txtNumCli.TabIndex = 12
        '
        'txtRGCli
        '
        Me.txtRGCli.Location = New System.Drawing.Point(295, 260)
        Me.txtRGCli.Name = "txtRGCli"
        Me.txtRGCli.Size = New System.Drawing.Size(189, 20)
        Me.txtRGCli.TabIndex = 9
        '
        'MtxtCelCli
        '
        Me.MtxtCelCli.Location = New System.Drawing.Point(199, 156)
        Me.MtxtCelCli.Mask = "00000-0000"
        Me.MtxtCelCli.Name = "MtxtCelCli"
        Me.MtxtCelCli.Size = New System.Drawing.Size(62, 20)
        Me.MtxtCelCli.TabIndex = 4
        '
        'MtxtTelCli
        '
        Me.MtxtTelCli.Location = New System.Drawing.Point(77, 155)
        Me.MtxtTelCli.Mask = "0000-0000"
        Me.MtxtTelCli.Name = "MtxtTelCli"
        Me.MtxtTelCli.Size = New System.Drawing.Size(59, 20)
        Me.MtxtTelCli.TabIndex = 3
        '
        'MtxtDataNascCli
        '
        Me.MtxtDataNascCli.Location = New System.Drawing.Point(9, 262)
        Me.MtxtDataNascCli.Mask = "00/00/0000"
        Me.MtxtDataNascCli.Name = "MtxtDataNascCli"
        Me.MtxtDataNascCli.Size = New System.Drawing.Size(73, 20)
        Me.MtxtDataNascCli.TabIndex = 7
        Me.MtxtDataNascCli.ValidatingType = GetType(Date)
        '
        'MtxtDataCadCli
        '
        Me.MtxtDataCadCli.Location = New System.Drawing.Point(9, 317)
        Me.MtxtDataCadCli.Mask = "00/00/0000"
        Me.MtxtDataCadCli.Name = "MtxtDataCadCli"
        Me.MtxtDataCadCli.Size = New System.Drawing.Size(73, 20)
        Me.MtxtDataCadCli.TabIndex = 10
        Me.MtxtDataCadCli.ValidatingType = GetType(Date)
        '
        'txtAno
        '
        Me.txtAno.Location = New System.Drawing.Point(513, 428)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(100, 20)
        Me.txtAno.TabIndex = 60
        Me.txtAno.Visible = False
        '
        'Label18
        '
        Me.Label18.AllowDrop = True
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(513, 409)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(26, 13)
        Me.Label18.TabIndex = 62
        Me.Label18.Text = "Ano"
        Me.Label18.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(395, 412)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(27, 13)
        Me.Label19.TabIndex = 63
        Me.Label19.Text = "Mês"
        Me.Label19.Visible = False
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(399, 428)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(100, 20)
        Me.txtMes.TabIndex = 64
        Me.txtMes.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.sistechy.My.Resources.Resources.banner_cadastro_cliente_fw
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(664, 55)
        Me.PictureBox1.TabIndex = 59
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
        Me.btnCancelar.Location = New System.Drawing.Point(293, 505)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(170, 50)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnCadastraCli
        '
        Me.btnCadastraCli.BackColor = System.Drawing.Color.White
        Me.btnCadastraCli.BackgroundImage = Global.sistechy.My.Resources.Resources.salva_cadastro_fw
        Me.btnCadastraCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCadastraCli.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCadastraCli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnCadastraCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCadastraCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastraCli.Location = New System.Drawing.Point(469, 505)
        Me.btnCadastraCli.Name = "btnCadastraCli"
        Me.btnCadastraCli.Size = New System.Drawing.Size(170, 50)
        Me.btnCadastraCli.TabIndex = 17
        Me.btnCadastraCli.UseVisualStyleBackColor = False
        '
        'frmCadastro_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(648, 567)
        Me.Controls.Add(Me.txtMes)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtAno)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MtxtDataCadCli)
        Me.Controls.Add(Me.MtxtDataNascCli)
        Me.Controls.Add(Me.MtxtTelCli)
        Me.Controls.Add(Me.MtxtCelCli)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtRGCli)
        Me.Controls.Add(Me.txtNumCli)
        Me.Controls.Add(Me.lbObrigatoriedade)
        Me.Controls.Add(Me.MtxtCEPCli)
        Me.Controls.Add(Me.MtxtCPFCli)
        Me.Controls.Add(Me.MtxtDDDCli)
        Me.Controls.Add(Me.btnCadastraCli)
        Me.Controls.Add(Me.cmbUFcli)
        Me.Controls.Add(Me.txtNomeCli)
        Me.Controls.Add(Me.txtBairroCli)
        Me.Controls.Add(Me.txtCidadeCli)
        Me.Controls.Add(Me.txtEndCli)
        Me.Controls.Add(Me.lbCEPCli)
        Me.Controls.Add(Me.lbCidadeCli)
        Me.Controls.Add(Me.lbUFCli)
        Me.Controls.Add(Me.lbBairroCli)
        Me.Controls.Add(Me.lbNumeroCli)
        Me.Controls.Add(Me.lbEnderecoCli)
        Me.Controls.Add(Me.lbDataCadCli)
        Me.Controls.Add(Me.cmbSexoCli)
        Me.Controls.Add(Me.txtEmailCli)
        Me.Controls.Add(Me.lbRGCli)
        Me.Controls.Add(Me.lbCPFCli)
        Me.Controls.Add(Me.lbDataNascCli)
        Me.Controls.Add(Me.lbSexoCli)
        Me.Controls.Add(Me.lbCelularCli)
        Me.Controls.Add(Me.lbTelefoneCli)
        Me.Controls.Add(Me.lbEmailCli)
        Me.Controls.Add(Me.lbDDDCli)
        Me.Controls.Add(Me.lbNomeCli)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCadastro_cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de cliente"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbNomeCli As System.Windows.Forms.Label
    Friend WithEvents lbDDDCli As System.Windows.Forms.Label
    Friend WithEvents lbEmailCli As System.Windows.Forms.Label
    Friend WithEvents lbTelefoneCli As System.Windows.Forms.Label
    Friend WithEvents lbCelularCli As System.Windows.Forms.Label
    Friend WithEvents lbSexoCli As System.Windows.Forms.Label
    Friend WithEvents lbDataNascCli As System.Windows.Forms.Label
    Friend WithEvents lbCPFCli As System.Windows.Forms.Label
    Friend WithEvents lbRGCli As System.Windows.Forms.Label
    Friend WithEvents txtEmailCli As System.Windows.Forms.TextBox
    Friend WithEvents cmbSexoCli As System.Windows.Forms.ComboBox
    Friend WithEvents lbDataCadCli As System.Windows.Forms.Label
    Friend WithEvents lbEnderecoCli As System.Windows.Forms.Label
    Friend WithEvents lbNumeroCli As System.Windows.Forms.Label
    Friend WithEvents lbBairroCli As System.Windows.Forms.Label
    Friend WithEvents lbUFCli As System.Windows.Forms.Label
    Friend WithEvents lbCidadeCli As System.Windows.Forms.Label
    Friend WithEvents lbCEPCli As System.Windows.Forms.Label
    Friend WithEvents txtEndCli As System.Windows.Forms.TextBox
    Friend WithEvents txtCidadeCli As System.Windows.Forms.TextBox
    Friend WithEvents txtBairroCli As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeCli As System.Windows.Forms.TextBox
    Friend WithEvents cmbUFcli As System.Windows.Forms.ComboBox
    Friend WithEvents btnCadastraCli As System.Windows.Forms.Button
    Friend WithEvents MtxtDDDCli As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtCPFCli As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtCEPCli As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbObrigatoriedade As System.Windows.Forms.Label
    Friend WithEvents txtNumCli As System.Windows.Forms.TextBox
    Friend WithEvents txtRGCli As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents MtxtCelCli As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtTelCli As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtDataNascCli As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtDataCadCli As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtAno As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
End Class
