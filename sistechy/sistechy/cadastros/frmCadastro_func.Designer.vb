<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastro_func
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastro_func))
        Me.cmbUFFunc = New System.Windows.Forms.ComboBox()
        Me.txtNumFunc = New System.Windows.Forms.TextBox()
        Me.MtxtDDDFunc = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtCPFFunc = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtCEPFunc = New System.Windows.Forms.MaskedTextBox()
        Me.txtBairroFunc = New System.Windows.Forms.TextBox()
        Me.txtCidadeFunc = New System.Windows.Forms.TextBox()
        Me.lbCEPFunc = New System.Windows.Forms.Label()
        Me.lbCidadeFunc = New System.Windows.Forms.Label()
        Me.lbUFFunc = New System.Windows.Forms.Label()
        Me.lbBairroFunc = New System.Windows.Forms.Label()
        Me.lbNumeroFunc = New System.Windows.Forms.Label()
        Me.lbEnderecoFunc = New System.Windows.Forms.Label()
        Me.cmbSexoFunc = New System.Windows.Forms.ComboBox()
        Me.txtEmailFunc = New System.Windows.Forms.TextBox()
        Me.lbCPFFunc = New System.Windows.Forms.Label()
        Me.lbDataNascFunc = New System.Windows.Forms.Label()
        Me.lbSexoFunc = New System.Windows.Forms.Label()
        Me.lbCelularFunc = New System.Windows.Forms.Label()
        Me.lbTelefoneFunc = New System.Windows.Forms.Label()
        Me.lbEmailFunc = New System.Windows.Forms.Label()
        Me.lbDDDFunc = New System.Windows.Forms.Label()
        Me.lbNomeFunc = New System.Windows.Forms.Label()
        Me.txtNomeFunc = New System.Windows.Forms.TextBox()
        Me.lbDataCadFunc = New System.Windows.Forms.Label()
        Me.lbCargoFunc = New System.Windows.Forms.Label()
        Me.txtCargoFunc = New System.Windows.Forms.TextBox()
        Me.lbLoginFunc = New System.Windows.Forms.Label()
        Me.lbSenhaFunc = New System.Windows.Forms.Label()
        Me.lbRepitaSenhaFunc = New System.Windows.Forms.Label()
        Me.txtLoginFunc = New System.Windows.Forms.TextBox()
        Me.txtSenhaFunc = New System.Windows.Forms.TextBox()
        Me.txtSenhaFunc2 = New System.Windows.Forms.TextBox()
        Me.txtEndFunc = New System.Windows.Forms.TextBox()
        Me.MtxtTelFunc = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtCelFunc = New System.Windows.Forms.MaskedTextBox()
        Me.lbObrigatoriedadeFunc = New System.Windows.Forms.Label()
        Me.MtxtDataCadFunc = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtDataNascFunc = New System.Windows.Forms.MaskedTextBox()
        Me.gpxLogin = New System.Windows.Forms.GroupBox()
        Me.lbNivelAcessoFunc = New System.Windows.Forms.Label()
        Me.cmbNivelAcesso = New System.Windows.Forms.ComboBox()
        Me.gpxFunc = New System.Windows.Forms.GroupBox()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.pbxBanner = New System.Windows.Forms.PictureBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnCadastraFunc = New System.Windows.Forms.Button()
        Me.gpxLogin.SuspendLayout()
        Me.gpxFunc.SuspendLayout()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbUFFunc
        '
        Me.cmbUFFunc.AllowDrop = True
        Me.cmbUFFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUFFunc.FormattingEnabled = True
        Me.cmbUFFunc.Location = New System.Drawing.Point(339, 250)
        Me.cmbUFFunc.MaxDropDownItems = 3
        Me.cmbUFFunc.Name = "cmbUFFunc"
        Me.cmbUFFunc.Size = New System.Drawing.Size(52, 21)
        Me.cmbUFFunc.TabIndex = 13
        '
        'txtNumFunc
        '
        Me.txtNumFunc.Location = New System.Drawing.Point(412, 202)
        Me.txtNumFunc.Name = "txtNumFunc"
        Me.txtNumFunc.Size = New System.Drawing.Size(73, 20)
        Me.txtNumFunc.TabIndex = 11
        '
        'MtxtDDDFunc
        '
        Me.MtxtDDDFunc.Location = New System.Drawing.Point(15, 96)
        Me.MtxtDDDFunc.Mask = "(000)"
        Me.MtxtDDDFunc.Name = "MtxtDDDFunc"
        Me.MtxtDDDFunc.Size = New System.Drawing.Size(31, 20)
        Me.MtxtDDDFunc.TabIndex = 2
        '
        'MtxtCPFFunc
        '
        Me.MtxtCPFFunc.Location = New System.Drawing.Point(295, 149)
        Me.MtxtCPFFunc.Mask = "000.000.000-00"
        Me.MtxtCPFFunc.Name = "MtxtCPFFunc"
        Me.MtxtCPFFunc.Size = New System.Drawing.Size(89, 20)
        Me.MtxtCPFFunc.TabIndex = 8
        '
        'MtxtCEPFunc
        '
        Me.MtxtCEPFunc.Location = New System.Drawing.Point(297, 304)
        Me.MtxtCEPFunc.Mask = "00000-000"
        Me.MtxtCEPFunc.Name = "MtxtCEPFunc"
        Me.MtxtCEPFunc.Size = New System.Drawing.Size(60, 20)
        Me.MtxtCEPFunc.TabIndex = 15
        '
        'txtBairroFunc
        '
        Me.txtBairroFunc.Location = New System.Drawing.Point(12, 304)
        Me.txtBairroFunc.Name = "txtBairroFunc"
        Me.txtBairroFunc.Size = New System.Drawing.Size(249, 20)
        Me.txtBairroFunc.TabIndex = 14
        '
        'txtCidadeFunc
        '
        Me.txtCidadeFunc.Location = New System.Drawing.Point(15, 250)
        Me.txtCidadeFunc.Name = "txtCidadeFunc"
        Me.txtCidadeFunc.Size = New System.Drawing.Size(282, 20)
        Me.txtCidadeFunc.TabIndex = 12
        '
        'lbCEPFunc
        '
        Me.lbCEPFunc.AutoSize = True
        Me.lbCEPFunc.Location = New System.Drawing.Point(292, 287)
        Me.lbCEPFunc.Name = "lbCEPFunc"
        Me.lbCEPFunc.Size = New System.Drawing.Size(28, 13)
        Me.lbCEPFunc.TabIndex = 61
        Me.lbCEPFunc.Text = "CEP"
        '
        'lbCidadeFunc
        '
        Me.lbCidadeFunc.AutoSize = True
        Me.lbCidadeFunc.Location = New System.Drawing.Point(13, 234)
        Me.lbCidadeFunc.Name = "lbCidadeFunc"
        Me.lbCidadeFunc.Size = New System.Drawing.Size(40, 13)
        Me.lbCidadeFunc.TabIndex = 60
        Me.lbCidadeFunc.Text = "Cidade"
        '
        'lbUFFunc
        '
        Me.lbUFFunc.AutoSize = True
        Me.lbUFFunc.Location = New System.Drawing.Point(336, 234)
        Me.lbUFFunc.Name = "lbUFFunc"
        Me.lbUFFunc.Size = New System.Drawing.Size(21, 13)
        Me.lbUFFunc.TabIndex = 59
        Me.lbUFFunc.Text = "UF"
        '
        'lbBairroFunc
        '
        Me.lbBairroFunc.AutoSize = True
        Me.lbBairroFunc.Location = New System.Drawing.Point(12, 287)
        Me.lbBairroFunc.Name = "lbBairroFunc"
        Me.lbBairroFunc.Size = New System.Drawing.Size(34, 13)
        Me.lbBairroFunc.TabIndex = 58
        Me.lbBairroFunc.Text = "Bairro"
        '
        'lbNumeroFunc
        '
        Me.lbNumeroFunc.AutoSize = True
        Me.lbNumeroFunc.Location = New System.Drawing.Point(409, 186)
        Me.lbNumeroFunc.Name = "lbNumeroFunc"
        Me.lbNumeroFunc.Size = New System.Drawing.Size(44, 13)
        Me.lbNumeroFunc.TabIndex = 57
        Me.lbNumeroFunc.Text = "Número"
        '
        'lbEnderecoFunc
        '
        Me.lbEnderecoFunc.AutoSize = True
        Me.lbEnderecoFunc.Location = New System.Drawing.Point(13, 186)
        Me.lbEnderecoFunc.Name = "lbEnderecoFunc"
        Me.lbEnderecoFunc.Size = New System.Drawing.Size(63, 13)
        Me.lbEnderecoFunc.TabIndex = 56
        Me.lbEnderecoFunc.Text = "Endereço(*)"
        '
        'cmbSexoFunc
        '
        Me.cmbSexoFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexoFunc.FormattingEnabled = True
        Me.cmbSexoFunc.Location = New System.Drawing.Point(15, 149)
        Me.cmbSexoFunc.Name = "cmbSexoFunc"
        Me.cmbSexoFunc.Size = New System.Drawing.Size(121, 21)
        Me.cmbSexoFunc.TabIndex = 6
        '
        'txtEmailFunc
        '
        Me.txtEmailFunc.Location = New System.Drawing.Point(254, 96)
        Me.txtEmailFunc.Name = "txtEmailFunc"
        Me.txtEmailFunc.Size = New System.Drawing.Size(351, 20)
        Me.txtEmailFunc.TabIndex = 5
        '
        'lbCPFFunc
        '
        Me.lbCPFFunc.AutoSize = True
        Me.lbCPFFunc.Location = New System.Drawing.Point(292, 133)
        Me.lbCPFFunc.Name = "lbCPFFunc"
        Me.lbCPFFunc.Size = New System.Drawing.Size(37, 13)
        Me.lbCPFFunc.TabIndex = 50
        Me.lbCPFFunc.Text = "CPF(*)"
        '
        'lbDataNascFunc
        '
        Me.lbDataNascFunc.AutoSize = True
        Me.lbDataNascFunc.Location = New System.Drawing.Point(163, 133)
        Me.lbDataNascFunc.Name = "lbDataNascFunc"
        Me.lbDataNascFunc.Size = New System.Drawing.Size(102, 13)
        Me.lbDataNascFunc.TabIndex = 49
        Me.lbDataNascFunc.Text = "Data de nascimento"
        '
        'lbSexoFunc
        '
        Me.lbSexoFunc.AutoSize = True
        Me.lbSexoFunc.Location = New System.Drawing.Point(12, 133)
        Me.lbSexoFunc.Name = "lbSexoFunc"
        Me.lbSexoFunc.Size = New System.Drawing.Size(41, 13)
        Me.lbSexoFunc.TabIndex = 48
        Me.lbSexoFunc.Text = "Sexo(*)"
        '
        'lbCelularFunc
        '
        Me.lbCelularFunc.AutoSize = True
        Me.lbCelularFunc.Location = New System.Drawing.Point(156, 79)
        Me.lbCelularFunc.Name = "lbCelularFunc"
        Me.lbCelularFunc.Size = New System.Drawing.Size(39, 13)
        Me.lbCelularFunc.TabIndex = 47
        Me.lbCelularFunc.Text = "Celular"
        '
        'lbTelefoneFunc
        '
        Me.lbTelefoneFunc.AutoSize = True
        Me.lbTelefoneFunc.Location = New System.Drawing.Point(68, 79)
        Me.lbTelefoneFunc.Name = "lbTelefoneFunc"
        Me.lbTelefoneFunc.Size = New System.Drawing.Size(59, 13)
        Me.lbTelefoneFunc.TabIndex = 46
        Me.lbTelefoneFunc.Text = "Telefone(*)"
        '
        'lbEmailFunc
        '
        Me.lbEmailFunc.AutoSize = True
        Me.lbEmailFunc.Location = New System.Drawing.Point(250, 79)
        Me.lbEmailFunc.Name = "lbEmailFunc"
        Me.lbEmailFunc.Size = New System.Drawing.Size(32, 13)
        Me.lbEmailFunc.TabIndex = 45
        Me.lbEmailFunc.Text = "Email"
        '
        'lbDDDFunc
        '
        Me.lbDDDFunc.AutoSize = True
        Me.lbDDDFunc.Location = New System.Drawing.Point(13, 79)
        Me.lbDDDFunc.Name = "lbDDDFunc"
        Me.lbDDDFunc.Size = New System.Drawing.Size(31, 13)
        Me.lbDDDFunc.TabIndex = 44
        Me.lbDDDFunc.Text = "DDD"
        '
        'lbNomeFunc
        '
        Me.lbNomeFunc.AutoSize = True
        Me.lbNomeFunc.Location = New System.Drawing.Point(12, 21)
        Me.lbNomeFunc.Name = "lbNomeFunc"
        Me.lbNomeFunc.Size = New System.Drawing.Size(45, 13)
        Me.lbNomeFunc.TabIndex = 76
        Me.lbNomeFunc.Text = "Nome(*)"
        '
        'txtNomeFunc
        '
        Me.txtNomeFunc.Location = New System.Drawing.Point(15, 37)
        Me.txtNomeFunc.Name = "txtNomeFunc"
        Me.txtNomeFunc.Size = New System.Drawing.Size(395, 20)
        Me.txtNomeFunc.TabIndex = 1
        '
        'lbDataCadFunc
        '
        Me.lbDataCadFunc.AutoSize = True
        Me.lbDataCadFunc.Location = New System.Drawing.Point(409, 133)
        Me.lbDataCadFunc.Name = "lbDataCadFunc"
        Me.lbDataCadFunc.Size = New System.Drawing.Size(89, 13)
        Me.lbDataCadFunc.TabIndex = 78
        Me.lbDataCadFunc.Text = "Data de cadastro"
        '
        'lbCargoFunc
        '
        Me.lbCargoFunc.AutoSize = True
        Me.lbCargoFunc.Location = New System.Drawing.Point(385, 288)
        Me.lbCargoFunc.Name = "lbCargoFunc"
        Me.lbCargoFunc.Size = New System.Drawing.Size(45, 13)
        Me.lbCargoFunc.TabIndex = 80
        Me.lbCargoFunc.Text = "Cargo(*)"
        '
        'txtCargoFunc
        '
        Me.txtCargoFunc.Location = New System.Drawing.Point(385, 304)
        Me.txtCargoFunc.Name = "txtCargoFunc"
        Me.txtCargoFunc.Size = New System.Drawing.Size(100, 20)
        Me.txtCargoFunc.TabIndex = 16
        '
        'lbLoginFunc
        '
        Me.lbLoginFunc.AutoSize = True
        Me.lbLoginFunc.Location = New System.Drawing.Point(22, 20)
        Me.lbLoginFunc.Name = "lbLoginFunc"
        Me.lbLoginFunc.Size = New System.Drawing.Size(43, 13)
        Me.lbLoginFunc.TabIndex = 82
        Me.lbLoginFunc.Text = "Login(*)"
        '
        'lbSenhaFunc
        '
        Me.lbSenhaFunc.AutoSize = True
        Me.lbSenhaFunc.Location = New System.Drawing.Point(158, 22)
        Me.lbSenhaFunc.Name = "lbSenhaFunc"
        Me.lbSenhaFunc.Size = New System.Drawing.Size(48, 13)
        Me.lbSenhaFunc.TabIndex = 84
        Me.lbSenhaFunc.Text = "Senha(*)"
        '
        'lbRepitaSenhaFunc
        '
        Me.lbRepitaSenhaFunc.AutoSize = True
        Me.lbRepitaSenhaFunc.Location = New System.Drawing.Point(299, 22)
        Me.lbRepitaSenhaFunc.Name = "lbRepitaSenhaFunc"
        Me.lbRepitaSenhaFunc.Size = New System.Drawing.Size(89, 13)
        Me.lbRepitaSenhaFunc.TabIndex = 87
        Me.lbRepitaSenhaFunc.Text = "Repita a senha(*)"
        '
        'txtLoginFunc
        '
        Me.txtLoginFunc.Location = New System.Drawing.Point(20, 38)
        Me.txtLoginFunc.Name = "txtLoginFunc"
        Me.txtLoginFunc.Size = New System.Drawing.Size(100, 20)
        Me.txtLoginFunc.TabIndex = 18
        '
        'txtSenhaFunc
        '
        Me.txtSenhaFunc.Location = New System.Drawing.Point(161, 38)
        Me.txtSenhaFunc.Name = "txtSenhaFunc"
        Me.txtSenhaFunc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenhaFunc.Size = New System.Drawing.Size(100, 20)
        Me.txtSenhaFunc.TabIndex = 19
        '
        'txtSenhaFunc2
        '
        Me.txtSenhaFunc2.Location = New System.Drawing.Point(302, 38)
        Me.txtSenhaFunc2.Name = "txtSenhaFunc2"
        Me.txtSenhaFunc2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenhaFunc2.Size = New System.Drawing.Size(100, 20)
        Me.txtSenhaFunc2.TabIndex = 20
        '
        'txtEndFunc
        '
        Me.txtEndFunc.Location = New System.Drawing.Point(16, 202)
        Me.txtEndFunc.Name = "txtEndFunc"
        Me.txtEndFunc.Size = New System.Drawing.Size(365, 20)
        Me.txtEndFunc.TabIndex = 10
        '
        'MtxtTelFunc
        '
        Me.MtxtTelFunc.Location = New System.Drawing.Point(71, 96)
        Me.MtxtTelFunc.Mask = "0000-0000"
        Me.MtxtTelFunc.Name = "MtxtTelFunc"
        Me.MtxtTelFunc.Size = New System.Drawing.Size(59, 20)
        Me.MtxtTelFunc.TabIndex = 3
        '
        'MtxtCelFunc
        '
        Me.MtxtCelFunc.Location = New System.Drawing.Point(157, 95)
        Me.MtxtCelFunc.Mask = "00000-0000"
        Me.MtxtCelFunc.Name = "MtxtCelFunc"
        Me.MtxtCelFunc.Size = New System.Drawing.Size(65, 20)
        Me.MtxtCelFunc.TabIndex = 4
        '
        'lbObrigatoriedadeFunc
        '
        Me.lbObrigatoriedadeFunc.AutoSize = True
        Me.lbObrigatoriedadeFunc.Location = New System.Drawing.Point(9, 340)
        Me.lbObrigatoriedadeFunc.Name = "lbObrigatoriedadeFunc"
        Me.lbObrigatoriedadeFunc.Size = New System.Drawing.Size(256, 13)
        Me.lbObrigatoriedadeFunc.TabIndex = 93
        Me.lbObrigatoriedadeFunc.Text = "Os campos com (*) são de preenchimento obrigatório"
        '
        'MtxtDataCadFunc
        '
        Me.MtxtDataCadFunc.Location = New System.Drawing.Point(412, 149)
        Me.MtxtDataCadFunc.Mask = "00/00/0000"
        Me.MtxtDataCadFunc.Name = "MtxtDataCadFunc"
        Me.MtxtDataCadFunc.Size = New System.Drawing.Size(73, 20)
        Me.MtxtDataCadFunc.TabIndex = 9
        Me.MtxtDataCadFunc.ValidatingType = GetType(Date)
        '
        'MtxtDataNascFunc
        '
        Me.MtxtDataNascFunc.Location = New System.Drawing.Point(166, 149)
        Me.MtxtDataNascFunc.Mask = "00/00/0000"
        Me.MtxtDataNascFunc.Name = "MtxtDataNascFunc"
        Me.MtxtDataNascFunc.Size = New System.Drawing.Size(73, 20)
        Me.MtxtDataNascFunc.TabIndex = 7
        Me.MtxtDataNascFunc.ValidatingType = GetType(Date)
        '
        'gpxLogin
        '
        Me.gpxLogin.Controls.Add(Me.lbNivelAcessoFunc)
        Me.gpxLogin.Controls.Add(Me.cmbNivelAcesso)
        Me.gpxLogin.Controls.Add(Me.txtLoginFunc)
        Me.gpxLogin.Controls.Add(Me.lbLoginFunc)
        Me.gpxLogin.Controls.Add(Me.lbSenhaFunc)
        Me.gpxLogin.Controls.Add(Me.lbRepitaSenhaFunc)
        Me.gpxLogin.Controls.Add(Me.txtSenhaFunc)
        Me.gpxLogin.Controls.Add(Me.txtSenhaFunc2)
        Me.gpxLogin.Location = New System.Drawing.Point(13, 452)
        Me.gpxLogin.Name = "gpxLogin"
        Me.gpxLogin.Size = New System.Drawing.Size(648, 75)
        Me.gpxLogin.TabIndex = 17
        Me.gpxLogin.TabStop = False
        Me.gpxLogin.Text = "Dados de login"
        '
        'lbNivelAcessoFunc
        '
        Me.lbNivelAcessoFunc.AutoSize = True
        Me.lbNivelAcessoFunc.Location = New System.Drawing.Point(440, 22)
        Me.lbNivelAcessoFunc.Name = "lbNivelAcessoFunc"
        Me.lbNivelAcessoFunc.Size = New System.Drawing.Size(95, 13)
        Me.lbNivelAcessoFunc.TabIndex = 89
        Me.lbNivelAcessoFunc.Text = "Nível de acesso(*)"
        '
        'cmbNivelAcesso
        '
        Me.cmbNivelAcesso.FormattingEnabled = True
        Me.cmbNivelAcesso.Location = New System.Drawing.Point(443, 38)
        Me.cmbNivelAcesso.Name = "cmbNivelAcesso"
        Me.cmbNivelAcesso.Size = New System.Drawing.Size(121, 21)
        Me.cmbNivelAcesso.TabIndex = 88
        '
        'gpxFunc
        '
        Me.gpxFunc.Controls.Add(Me.txtAno)
        Me.gpxFunc.Controls.Add(Me.txtMes)
        Me.gpxFunc.Controls.Add(Me.txtNomeFunc)
        Me.gpxFunc.Controls.Add(Me.lbDDDFunc)
        Me.gpxFunc.Controls.Add(Me.MtxtDataNascFunc)
        Me.gpxFunc.Controls.Add(Me.lbEmailFunc)
        Me.gpxFunc.Controls.Add(Me.MtxtDataCadFunc)
        Me.gpxFunc.Controls.Add(Me.lbTelefoneFunc)
        Me.gpxFunc.Controls.Add(Me.lbObrigatoriedadeFunc)
        Me.gpxFunc.Controls.Add(Me.lbCelularFunc)
        Me.gpxFunc.Controls.Add(Me.MtxtCelFunc)
        Me.gpxFunc.Controls.Add(Me.lbSexoFunc)
        Me.gpxFunc.Controls.Add(Me.MtxtTelFunc)
        Me.gpxFunc.Controls.Add(Me.lbDataNascFunc)
        Me.gpxFunc.Controls.Add(Me.lbCPFFunc)
        Me.gpxFunc.Controls.Add(Me.txtEndFunc)
        Me.gpxFunc.Controls.Add(Me.txtEmailFunc)
        Me.gpxFunc.Controls.Add(Me.txtCargoFunc)
        Me.gpxFunc.Controls.Add(Me.cmbSexoFunc)
        Me.gpxFunc.Controls.Add(Me.lbCargoFunc)
        Me.gpxFunc.Controls.Add(Me.lbEnderecoFunc)
        Me.gpxFunc.Controls.Add(Me.lbDataCadFunc)
        Me.gpxFunc.Controls.Add(Me.lbNumeroFunc)
        Me.gpxFunc.Controls.Add(Me.lbBairroFunc)
        Me.gpxFunc.Controls.Add(Me.lbNomeFunc)
        Me.gpxFunc.Controls.Add(Me.lbUFFunc)
        Me.gpxFunc.Controls.Add(Me.lbCidadeFunc)
        Me.gpxFunc.Controls.Add(Me.cmbUFFunc)
        Me.gpxFunc.Controls.Add(Me.lbCEPFunc)
        Me.gpxFunc.Controls.Add(Me.txtNumFunc)
        Me.gpxFunc.Controls.Add(Me.txtCidadeFunc)
        Me.gpxFunc.Controls.Add(Me.MtxtDDDFunc)
        Me.gpxFunc.Controls.Add(Me.txtBairroFunc)
        Me.gpxFunc.Controls.Add(Me.MtxtCPFFunc)
        Me.gpxFunc.Controls.Add(Me.MtxtCEPFunc)
        Me.gpxFunc.Location = New System.Drawing.Point(13, 69)
        Me.gpxFunc.Name = "gpxFunc"
        Me.gpxFunc.Size = New System.Drawing.Size(648, 367)
        Me.gpxFunc.TabIndex = 95
        Me.gpxFunc.TabStop = False
        Me.gpxFunc.Text = "Dados do funcionário"
        '
        'txtAno
        '
        Me.txtAno.Location = New System.Drawing.Point(505, 63)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(100, 20)
        Me.txtAno.TabIndex = 95
        Me.txtAno.Visible = False
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(505, 37)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(100, 20)
        Me.txtMes.TabIndex = 94
        Me.txtMes.Visible = False
        '
        'pbxBanner
        '
        Me.pbxBanner.BackgroundImage = Global.sistechy.My.Resources.Resources.banner_cadastro_funcionario_fw
        Me.pbxBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxBanner.Location = New System.Drawing.Point(-5, -2)
        Me.pbxBanner.Name = "pbxBanner"
        Me.pbxBanner.Size = New System.Drawing.Size(701, 55)
        Me.pbxBanner.TabIndex = 96
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
        Me.btnCancelar.Location = New System.Drawing.Point(315, 543)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(170, 50)
        Me.btnCancelar.TabIndex = 22
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnCadastraFunc
        '
        Me.btnCadastraFunc.BackColor = System.Drawing.Color.White
        Me.btnCadastraFunc.BackgroundImage = Global.sistechy.My.Resources.Resources.salva_cadastro_fw
        Me.btnCadastraFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCadastraFunc.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCadastraFunc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnCadastraFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCadastraFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastraFunc.Location = New System.Drawing.Point(491, 543)
        Me.btnCadastraFunc.Name = "btnCadastraFunc"
        Me.btnCadastraFunc.Size = New System.Drawing.Size(170, 50)
        Me.btnCadastraFunc.TabIndex = 21
        Me.btnCadastraFunc.UseVisualStyleBackColor = False
        '
        'frmCadastro_func
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(685, 602)
        Me.Controls.Add(Me.pbxBanner)
        Me.Controls.Add(Me.gpxFunc)
        Me.Controls.Add(Me.gpxLogin)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCadastraFunc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCadastro_func"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de funcionário"
        Me.gpxLogin.ResumeLayout(False)
        Me.gpxLogin.PerformLayout()
        Me.gpxFunc.ResumeLayout(False)
        Me.gpxFunc.PerformLayout()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCadastraFunc As System.Windows.Forms.Button
    Friend WithEvents cmbUFFunc As System.Windows.Forms.ComboBox
    Friend WithEvents txtNumFunc As System.Windows.Forms.TextBox
    Friend WithEvents MtxtDDDFunc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtCPFFunc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtCEPFunc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtBairroFunc As System.Windows.Forms.TextBox
    Friend WithEvents txtCidadeFunc As System.Windows.Forms.TextBox
    Friend WithEvents lbCEPFunc As System.Windows.Forms.Label
    Friend WithEvents lbCidadeFunc As System.Windows.Forms.Label
    Friend WithEvents lbUFFunc As System.Windows.Forms.Label
    Friend WithEvents lbBairroFunc As System.Windows.Forms.Label
    Friend WithEvents lbNumeroFunc As System.Windows.Forms.Label
    Friend WithEvents lbEnderecoFunc As System.Windows.Forms.Label
    Friend WithEvents cmbSexoFunc As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmailFunc As System.Windows.Forms.TextBox
    Friend WithEvents lbCPFFunc As System.Windows.Forms.Label
    Friend WithEvents lbDataNascFunc As System.Windows.Forms.Label
    Friend WithEvents lbSexoFunc As System.Windows.Forms.Label
    Friend WithEvents lbCelularFunc As System.Windows.Forms.Label
    Friend WithEvents lbTelefoneFunc As System.Windows.Forms.Label
    Friend WithEvents lbEmailFunc As System.Windows.Forms.Label
    Friend WithEvents lbDDDFunc As System.Windows.Forms.Label
    Friend WithEvents lbNomeFunc As System.Windows.Forms.Label
    Friend WithEvents txtNomeFunc As System.Windows.Forms.TextBox
    Friend WithEvents lbDataCadFunc As System.Windows.Forms.Label
    Friend WithEvents lbCargoFunc As System.Windows.Forms.Label
    Friend WithEvents txtCargoFunc As System.Windows.Forms.TextBox
    Friend WithEvents lbLoginFunc As System.Windows.Forms.Label
    Friend WithEvents lbSenhaFunc As System.Windows.Forms.Label
    Friend WithEvents lbRepitaSenhaFunc As System.Windows.Forms.Label
    Friend WithEvents txtLoginFunc As System.Windows.Forms.TextBox
    Friend WithEvents txtSenhaFunc As System.Windows.Forms.TextBox
    Friend WithEvents txtSenhaFunc2 As System.Windows.Forms.TextBox
    Friend WithEvents txtEndFunc As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents MtxtTelFunc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtCelFunc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbObrigatoriedadeFunc As System.Windows.Forms.Label
    Friend WithEvents MtxtDataCadFunc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtDataNascFunc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents gpxLogin As System.Windows.Forms.GroupBox
    Friend WithEvents gpxFunc As System.Windows.Forms.GroupBox
    Friend WithEvents pbxBanner As System.Windows.Forms.PictureBox
    Friend WithEvents txtAno As System.Windows.Forms.TextBox
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents lbNivelAcessoFunc As System.Windows.Forms.Label
    Friend WithEvents cmbNivelAcesso As System.Windows.Forms.ComboBox
End Class
