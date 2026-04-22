<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastro_forne
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastro_forne))
        Me.lbNomeFantasia = New System.Windows.Forms.Label()
        Me.lbTelefoneForne = New System.Windows.Forms.Label()
        Me.lbEmailForne = New System.Windows.Forms.Label()
        Me.lbDDDForne = New System.Windows.Forms.Label()
        Me.lbRazaoSocial = New System.Windows.Forms.Label()
        Me.lbCNPJForne = New System.Windows.Forms.Label()
        Me.txtNomeFantForne = New System.Windows.Forms.TextBox()
        Me.txtRazaoSocialForne = New System.Windows.Forms.TextBox()
        Me.lbEnderecoForne = New System.Windows.Forms.Label()
        Me.lbBairroForne = New System.Windows.Forms.Label()
        Me.lbNumeroForne = New System.Windows.Forms.Label()
        Me.lbCidadeForne = New System.Windows.Forms.Label()
        Me.lbUFForne = New System.Windows.Forms.Label()
        Me.txtEmailForne = New System.Windows.Forms.TextBox()
        Me.txtEndForne = New System.Windows.Forms.TextBox()
        Me.txtBairroForne = New System.Windows.Forms.TextBox()
        Me.txtNumForne = New System.Windows.Forms.TextBox()
        Me.txtCidadeForne = New System.Windows.Forms.TextBox()
        Me.cmbUFForne = New System.Windows.Forms.ComboBox()
        Me.txtCNPJForne = New System.Windows.Forms.TextBox()
        Me.MtxtDDDForne = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtTelForne = New System.Windows.Forms.MaskedTextBox()
        Me.lbObrigatoriedade = New System.Windows.Forms.Label()
        Me.pbxBanner = New System.Windows.Forms.PictureBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnCadastraForne = New System.Windows.Forms.Button()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbNomeFantasia
        '
        Me.lbNomeFantasia.AutoSize = True
        Me.lbNomeFantasia.Location = New System.Drawing.Point(12, 71)
        Me.lbNomeFantasia.Name = "lbNomeFantasia"
        Me.lbNomeFantasia.Size = New System.Drawing.Size(91, 13)
        Me.lbNomeFantasia.TabIndex = 0
        Me.lbNomeFantasia.Text = "Nome Fantasia (*)"
        '
        'lbTelefoneForne
        '
        Me.lbTelefoneForne.AutoSize = True
        Me.lbTelefoneForne.Location = New System.Drawing.Point(73, 179)
        Me.lbTelefoneForne.Name = "lbTelefoneForne"
        Me.lbTelefoneForne.Size = New System.Drawing.Size(62, 13)
        Me.lbTelefoneForne.TabIndex = 1
        Me.lbTelefoneForne.Text = "Telefone (*)"
        '
        'lbEmailForne
        '
        Me.lbEmailForne.AutoSize = True
        Me.lbEmailForne.Location = New System.Drawing.Point(179, 179)
        Me.lbEmailForne.Name = "lbEmailForne"
        Me.lbEmailForne.Size = New System.Drawing.Size(32, 13)
        Me.lbEmailForne.TabIndex = 2
        Me.lbEmailForne.Text = "Email"
        '
        'lbDDDForne
        '
        Me.lbDDDForne.AutoSize = True
        Me.lbDDDForne.Location = New System.Drawing.Point(12, 179)
        Me.lbDDDForne.Name = "lbDDDForne"
        Me.lbDDDForne.Size = New System.Drawing.Size(31, 13)
        Me.lbDDDForne.TabIndex = 3
        Me.lbDDDForne.Text = "DDD"
        '
        'lbRazaoSocial
        '
        Me.lbRazaoSocial.AutoSize = True
        Me.lbRazaoSocial.Location = New System.Drawing.Point(12, 123)
        Me.lbRazaoSocial.Name = "lbRazaoSocial"
        Me.lbRazaoSocial.Size = New System.Drawing.Size(70, 13)
        Me.lbRazaoSocial.TabIndex = 4
        Me.lbRazaoSocial.Text = "Razão Social"
        '
        'lbCNPJForne
        '
        Me.lbCNPJForne.AutoSize = True
        Me.lbCNPJForne.Location = New System.Drawing.Point(469, 123)
        Me.lbCNPJForne.Name = "lbCNPJForne"
        Me.lbCNPJForne.Size = New System.Drawing.Size(47, 13)
        Me.lbCNPJForne.TabIndex = 5
        Me.lbCNPJForne.Text = "CNPJ (*)"
        '
        'txtNomeFantForne
        '
        Me.txtNomeFantForne.Location = New System.Drawing.Point(12, 87)
        Me.txtNomeFantForne.Name = "txtNomeFantForne"
        Me.txtNomeFantForne.Size = New System.Drawing.Size(422, 20)
        Me.txtNomeFantForne.TabIndex = 1
        '
        'txtRazaoSocialForne
        '
        Me.txtRazaoSocialForne.Location = New System.Drawing.Point(12, 139)
        Me.txtRazaoSocialForne.Name = "txtRazaoSocialForne"
        Me.txtRazaoSocialForne.Size = New System.Drawing.Size(422, 20)
        Me.txtRazaoSocialForne.TabIndex = 2
        '
        'lbEnderecoForne
        '
        Me.lbEnderecoForne.AutoSize = True
        Me.lbEnderecoForne.Location = New System.Drawing.Point(9, 234)
        Me.lbEnderecoForne.Name = "lbEnderecoForne"
        Me.lbEnderecoForne.Size = New System.Drawing.Size(53, 13)
        Me.lbEnderecoForne.TabIndex = 8
        Me.lbEnderecoForne.Text = "Endereço"
        '
        'lbBairroForne
        '
        Me.lbBairroForne.AutoSize = True
        Me.lbBairroForne.Location = New System.Drawing.Point(484, 234)
        Me.lbBairroForne.Name = "lbBairroForne"
        Me.lbBairroForne.Size = New System.Drawing.Size(34, 13)
        Me.lbBairroForne.TabIndex = 9
        Me.lbBairroForne.Text = "Bairro"
        '
        'lbNumeroForne
        '
        Me.lbNumeroForne.AutoSize = True
        Me.lbNumeroForne.Location = New System.Drawing.Point(12, 289)
        Me.lbNumeroForne.Name = "lbNumeroForne"
        Me.lbNumeroForne.Size = New System.Drawing.Size(44, 13)
        Me.lbNumeroForne.TabIndex = 10
        Me.lbNumeroForne.Text = "Número"
        '
        'lbCidadeForne
        '
        Me.lbCidadeForne.AutoSize = True
        Me.lbCidadeForne.Location = New System.Drawing.Point(132, 289)
        Me.lbCidadeForne.Name = "lbCidadeForne"
        Me.lbCidadeForne.Size = New System.Drawing.Size(40, 13)
        Me.lbCidadeForne.TabIndex = 11
        Me.lbCidadeForne.Text = "Cidade"
        '
        'lbUFForne
        '
        Me.lbUFForne.AutoSize = True
        Me.lbUFForne.Location = New System.Drawing.Point(413, 288)
        Me.lbUFForne.Name = "lbUFForne"
        Me.lbUFForne.Size = New System.Drawing.Size(21, 13)
        Me.lbUFForne.TabIndex = 12
        Me.lbUFForne.Text = "UF"
        '
        'txtEmailForne
        '
        Me.txtEmailForne.Location = New System.Drawing.Point(182, 196)
        Me.txtEmailForne.Name = "txtEmailForne"
        Me.txtEmailForne.Size = New System.Drawing.Size(379, 20)
        Me.txtEmailForne.TabIndex = 6
        '
        'txtEndForne
        '
        Me.txtEndForne.Location = New System.Drawing.Point(12, 251)
        Me.txtEndForne.Name = "txtEndForne"
        Me.txtEndForne.Size = New System.Drawing.Size(437, 20)
        Me.txtEndForne.TabIndex = 7
        '
        'txtBairroForne
        '
        Me.txtBairroForne.Location = New System.Drawing.Point(487, 251)
        Me.txtBairroForne.Name = "txtBairroForne"
        Me.txtBairroForne.Size = New System.Drawing.Size(198, 20)
        Me.txtBairroForne.TabIndex = 8
        '
        'txtNumForne
        '
        Me.txtNumForne.Location = New System.Drawing.Point(15, 305)
        Me.txtNumForne.Name = "txtNumForne"
        Me.txtNumForne.Size = New System.Drawing.Size(75, 20)
        Me.txtNumForne.TabIndex = 9
        '
        'txtCidadeForne
        '
        Me.txtCidadeForne.Location = New System.Drawing.Point(135, 305)
        Me.txtCidadeForne.Name = "txtCidadeForne"
        Me.txtCidadeForne.Size = New System.Drawing.Size(243, 20)
        Me.txtCidadeForne.TabIndex = 10
        '
        'cmbUFForne
        '
        Me.cmbUFForne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUFForne.FormattingEnabled = True
        Me.cmbUFForne.Location = New System.Drawing.Point(416, 305)
        Me.cmbUFForne.Name = "cmbUFForne"
        Me.cmbUFForne.Size = New System.Drawing.Size(45, 21)
        Me.cmbUFForne.TabIndex = 11
        '
        'txtCNPJForne
        '
        Me.txtCNPJForne.Location = New System.Drawing.Point(472, 140)
        Me.txtCNPJForne.Name = "txtCNPJForne"
        Me.txtCNPJForne.Size = New System.Drawing.Size(138, 20)
        Me.txtCNPJForne.TabIndex = 3
        '
        'MtxtDDDForne
        '
        Me.MtxtDDDForne.Location = New System.Drawing.Point(12, 195)
        Me.MtxtDDDForne.Mask = "(000)"
        Me.MtxtDDDForne.Name = "MtxtDDDForne"
        Me.MtxtDDDForne.Size = New System.Drawing.Size(31, 20)
        Me.MtxtDDDForne.TabIndex = 4
        '
        'MtxtTelForne
        '
        Me.MtxtTelForne.Location = New System.Drawing.Point(76, 195)
        Me.MtxtTelForne.Mask = "0000-0000"
        Me.MtxtTelForne.Name = "MtxtTelForne"
        Me.MtxtTelForne.Size = New System.Drawing.Size(59, 20)
        Me.MtxtTelForne.TabIndex = 5
        '
        'lbObrigatoriedade
        '
        Me.lbObrigatoriedade.AutoSize = True
        Me.lbObrigatoriedade.Location = New System.Drawing.Point(12, 346)
        Me.lbObrigatoriedade.Name = "lbObrigatoriedade"
        Me.lbObrigatoriedade.Size = New System.Drawing.Size(256, 13)
        Me.lbObrigatoriedade.TabIndex = 63
        Me.lbObrigatoriedade.Text = "Os campos com (*) são de preenchimento obrigatório"
        '
        'pbxBanner
        '
        Me.pbxBanner.BackgroundImage = Global.sistechy.My.Resources.Resources.banner_cadastro_fornecedor_fw
        Me.pbxBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxBanner.Location = New System.Drawing.Point(-5, -2)
        Me.pbxBanner.Name = "pbxBanner"
        Me.pbxBanner.Size = New System.Drawing.Size(756, 55)
        Me.pbxBanner.TabIndex = 64
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
        Me.btnCancelar.Location = New System.Drawing.Point(391, 378)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(170, 50)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnCadastraForne
        '
        Me.btnCadastraForne.BackColor = System.Drawing.Color.White
        Me.btnCadastraForne.BackgroundImage = Global.sistechy.My.Resources.Resources.salva_cadastro_fw
        Me.btnCadastraForne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCadastraForne.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCadastraForne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnCadastraForne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCadastraForne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastraForne.Location = New System.Drawing.Point(567, 378)
        Me.btnCadastraForne.Name = "btnCadastraForne"
        Me.btnCadastraForne.Size = New System.Drawing.Size(170, 50)
        Me.btnCadastraForne.TabIndex = 12
        Me.btnCadastraForne.UseVisualStyleBackColor = False
        '
        'frmCadastro_forne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(746, 440)
        Me.Controls.Add(Me.pbxBanner)
        Me.Controls.Add(Me.lbObrigatoriedade)
        Me.Controls.Add(Me.MtxtTelForne)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.MtxtDDDForne)
        Me.Controls.Add(Me.txtCNPJForne)
        Me.Controls.Add(Me.btnCadastraForne)
        Me.Controls.Add(Me.cmbUFForne)
        Me.Controls.Add(Me.txtCidadeForne)
        Me.Controls.Add(Me.txtNumForne)
        Me.Controls.Add(Me.txtBairroForne)
        Me.Controls.Add(Me.txtEndForne)
        Me.Controls.Add(Me.txtEmailForne)
        Me.Controls.Add(Me.lbUFForne)
        Me.Controls.Add(Me.lbCidadeForne)
        Me.Controls.Add(Me.lbNumeroForne)
        Me.Controls.Add(Me.lbBairroForne)
        Me.Controls.Add(Me.lbEnderecoForne)
        Me.Controls.Add(Me.txtRazaoSocialForne)
        Me.Controls.Add(Me.txtNomeFantForne)
        Me.Controls.Add(Me.lbCNPJForne)
        Me.Controls.Add(Me.lbRazaoSocial)
        Me.Controls.Add(Me.lbDDDForne)
        Me.Controls.Add(Me.lbEmailForne)
        Me.Controls.Add(Me.lbTelefoneForne)
        Me.Controls.Add(Me.lbNomeFantasia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCadastro_forne"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de fornecedor"
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbNomeFantasia As System.Windows.Forms.Label
    Friend WithEvents lbTelefoneForne As System.Windows.Forms.Label
    Friend WithEvents lbEmailForne As System.Windows.Forms.Label
    Friend WithEvents lbDDDForne As System.Windows.Forms.Label
    Friend WithEvents lbRazaoSocial As System.Windows.Forms.Label
    Friend WithEvents lbCNPJForne As System.Windows.Forms.Label
    Friend WithEvents txtNomeFantForne As System.Windows.Forms.TextBox
    Friend WithEvents txtRazaoSocialForne As System.Windows.Forms.TextBox
    Friend WithEvents lbEnderecoForne As System.Windows.Forms.Label
    Friend WithEvents lbBairroForne As System.Windows.Forms.Label
    Friend WithEvents lbNumeroForne As System.Windows.Forms.Label
    Friend WithEvents lbCidadeForne As System.Windows.Forms.Label
    Friend WithEvents lbUFForne As System.Windows.Forms.Label
    Friend WithEvents txtEmailForne As System.Windows.Forms.TextBox
    Friend WithEvents txtEndForne As System.Windows.Forms.TextBox
    Friend WithEvents txtBairroForne As System.Windows.Forms.TextBox
    Friend WithEvents txtNumForne As System.Windows.Forms.TextBox
    Friend WithEvents txtCidadeForne As System.Windows.Forms.TextBox
    Friend WithEvents cmbUFForne As System.Windows.Forms.ComboBox
    Friend WithEvents btnCadastraForne As System.Windows.Forms.Button
    Friend WithEvents txtCNPJForne As System.Windows.Forms.TextBox
    Friend WithEvents MtxtDDDForne As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents MtxtTelForne As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbObrigatoriedade As System.Windows.Forms.Label
    Friend WithEvents pbxBanner As System.Windows.Forms.PictureBox
End Class
