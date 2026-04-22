<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguracoes))
        Me.lbIdioma = New System.Windows.Forms.Label()
        Me.cmbIdioma = New System.Windows.Forms.ComboBox()
        Me.btnAplicarIdioma = New System.Windows.Forms.Button()
        Me.gpxSistema = New System.Windows.Forms.GroupBox()
        Me.btnConfiguracoesSistema = New System.Windows.Forms.Button()
        Me.btnMeusDados = New System.Windows.Forms.Button()
        Me.gpxMeusDados = New System.Windows.Forms.GroupBox()
        Me.lbAlterarSenha = New System.Windows.Forms.Label()
        Me.RadioNao = New System.Windows.Forms.RadioButton()
        Me.RadioSim = New System.Windows.Forms.RadioButton()
        Me.txtNovaSenha2 = New System.Windows.Forms.TextBox()
        Me.lbRepitaASenha = New System.Windows.Forms.Label()
        Me.txtSenhaAtual2 = New System.Windows.Forms.TextBox()
        Me.txtNovaSenha = New System.Windows.Forms.TextBox()
        Me.txtSenhaAtual = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lbSenhaAtual = New System.Windows.Forms.Label()
        Me.lbNovaSenha = New System.Windows.Forms.Label()
        Me.lbEmail = New System.Windows.Forms.Label()
        Me.lbNome = New System.Windows.Forms.Label()
        Me.btnAplicarDados = New System.Windows.Forms.Button()
        Me.pbxBanner = New System.Windows.Forms.PictureBox()
        Me.btnFecharForm = New System.Windows.Forms.Button()
        Me.gpxSistema.SuspendLayout()
        Me.gpxMeusDados.SuspendLayout()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbIdioma
        '
        Me.lbIdioma.AutoSize = True
        Me.lbIdioma.Location = New System.Drawing.Point(15, 21)
        Me.lbIdioma.Name = "lbIdioma"
        Me.lbIdioma.Size = New System.Drawing.Size(38, 13)
        Me.lbIdioma.TabIndex = 0
        Me.lbIdioma.Text = "Idioma"
        '
        'cmbIdioma
        '
        Me.cmbIdioma.FormattingEnabled = True
        Me.cmbIdioma.Location = New System.Drawing.Point(59, 18)
        Me.cmbIdioma.Name = "cmbIdioma"
        Me.cmbIdioma.Size = New System.Drawing.Size(121, 21)
        Me.cmbIdioma.TabIndex = 1
        '
        'btnAplicarIdioma
        '
        Me.btnAplicarIdioma.Location = New System.Drawing.Point(186, 16)
        Me.btnAplicarIdioma.Name = "btnAplicarIdioma"
        Me.btnAplicarIdioma.Size = New System.Drawing.Size(75, 23)
        Me.btnAplicarIdioma.TabIndex = 2
        Me.btnAplicarIdioma.Text = "Aplicar"
        Me.btnAplicarIdioma.UseVisualStyleBackColor = True
        '
        'gpxSistema
        '
        Me.gpxSistema.Controls.Add(Me.lbIdioma)
        Me.gpxSistema.Controls.Add(Me.cmbIdioma)
        Me.gpxSistema.Controls.Add(Me.btnAplicarIdioma)
        Me.gpxSistema.Location = New System.Drawing.Point(188, 107)
        Me.gpxSistema.Name = "gpxSistema"
        Me.gpxSistema.Size = New System.Drawing.Size(434, 52)
        Me.gpxSistema.TabIndex = 31
        Me.gpxSistema.TabStop = False
        Me.gpxSistema.Visible = False
        '
        'btnConfiguracoesSistema
        '
        Me.btnConfiguracoesSistema.BackColor = System.Drawing.Color.White
        Me.btnConfiguracoesSistema.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnConfiguracoesSistema.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnConfiguracoesSistema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnConfiguracoesSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfiguracoesSistema.Location = New System.Drawing.Point(12, 115)
        Me.btnConfiguracoesSistema.Name = "btnConfiguracoesSistema"
        Me.btnConfiguracoesSistema.Size = New System.Drawing.Size(159, 40)
        Me.btnConfiguracoesSistema.TabIndex = 32
        Me.btnConfiguracoesSistema.Text = "Configurações do sistema"
        Me.btnConfiguracoesSistema.UseVisualStyleBackColor = False
        '
        'btnMeusDados
        '
        Me.btnMeusDados.BackColor = System.Drawing.Color.White
        Me.btnMeusDados.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnMeusDados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnMeusDados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnMeusDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMeusDados.Location = New System.Drawing.Point(12, 161)
        Me.btnMeusDados.Name = "btnMeusDados"
        Me.btnMeusDados.Size = New System.Drawing.Size(159, 40)
        Me.btnMeusDados.TabIndex = 33
        Me.btnMeusDados.Text = "Meus dados"
        Me.btnMeusDados.UseVisualStyleBackColor = False
        '
        'gpxMeusDados
        '
        Me.gpxMeusDados.Controls.Add(Me.lbAlterarSenha)
        Me.gpxMeusDados.Controls.Add(Me.RadioNao)
        Me.gpxMeusDados.Controls.Add(Me.RadioSim)
        Me.gpxMeusDados.Controls.Add(Me.txtNovaSenha2)
        Me.gpxMeusDados.Controls.Add(Me.lbRepitaASenha)
        Me.gpxMeusDados.Controls.Add(Me.txtSenhaAtual2)
        Me.gpxMeusDados.Controls.Add(Me.txtNovaSenha)
        Me.gpxMeusDados.Controls.Add(Me.txtSenhaAtual)
        Me.gpxMeusDados.Controls.Add(Me.txtEmail)
        Me.gpxMeusDados.Controls.Add(Me.txtNome)
        Me.gpxMeusDados.Controls.Add(Me.lbSenhaAtual)
        Me.gpxMeusDados.Controls.Add(Me.lbNovaSenha)
        Me.gpxMeusDados.Controls.Add(Me.lbEmail)
        Me.gpxMeusDados.Controls.Add(Me.lbNome)
        Me.gpxMeusDados.Controls.Add(Me.btnAplicarDados)
        Me.gpxMeusDados.Location = New System.Drawing.Point(188, 107)
        Me.gpxMeusDados.Name = "gpxMeusDados"
        Me.gpxMeusDados.Size = New System.Drawing.Size(434, 222)
        Me.gpxMeusDados.TabIndex = 32
        Me.gpxMeusDados.TabStop = False
        Me.gpxMeusDados.Visible = False
        '
        'lbAlterarSenha
        '
        Me.lbAlterarSenha.AutoSize = True
        Me.lbAlterarSenha.Location = New System.Drawing.Point(15, 89)
        Me.lbAlterarSenha.Name = "lbAlterarSenha"
        Me.lbAlterarSenha.Size = New System.Drawing.Size(133, 13)
        Me.lbAlterarSenha.TabIndex = 15
        Me.lbAlterarSenha.Text = "Deseja alterar sua senha ?"
        '
        'RadioNao
        '
        Me.RadioNao.AutoSize = True
        Me.RadioNao.Location = New System.Drawing.Point(203, 85)
        Me.RadioNao.Name = "RadioNao"
        Me.RadioNao.Size = New System.Drawing.Size(45, 17)
        Me.RadioNao.TabIndex = 14
        Me.RadioNao.TabStop = True
        Me.RadioNao.Text = "Não"
        Me.RadioNao.UseVisualStyleBackColor = True
        '
        'RadioSim
        '
        Me.RadioSim.AutoSize = True
        Me.RadioSim.Location = New System.Drawing.Point(154, 85)
        Me.RadioSim.Name = "RadioSim"
        Me.RadioSim.Size = New System.Drawing.Size(42, 17)
        Me.RadioSim.TabIndex = 13
        Me.RadioSim.TabStop = True
        Me.RadioSim.Text = "Sim"
        Me.RadioSim.UseVisualStyleBackColor = True
        '
        'txtNovaSenha2
        '
        Me.txtNovaSenha2.Location = New System.Drawing.Point(99, 181)
        Me.txtNovaSenha2.Name = "txtNovaSenha2"
        Me.txtNovaSenha2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNovaSenha2.Size = New System.Drawing.Size(101, 20)
        Me.txtNovaSenha2.TabIndex = 12
        Me.txtNovaSenha2.Visible = False
        '
        'lbRepitaASenha
        '
        Me.lbRepitaASenha.AutoSize = True
        Me.lbRepitaASenha.Location = New System.Drawing.Point(14, 184)
        Me.lbRepitaASenha.Name = "lbRepitaASenha"
        Me.lbRepitaASenha.Size = New System.Drawing.Size(79, 13)
        Me.lbRepitaASenha.TabIndex = 11
        Me.lbRepitaASenha.Text = "Repita a senha"
        Me.lbRepitaASenha.Visible = False
        '
        'txtSenhaAtual2
        '
        Me.txtSenhaAtual2.Location = New System.Drawing.Point(203, 116)
        Me.txtSenhaAtual2.Name = "txtSenhaAtual2"
        Me.txtSenhaAtual2.Size = New System.Drawing.Size(100, 20)
        Me.txtSenhaAtual2.TabIndex = 10
        Me.txtSenhaAtual2.Visible = False
        '
        'txtNovaSenha
        '
        Me.txtNovaSenha.Location = New System.Drawing.Point(85, 148)
        Me.txtNovaSenha.Name = "txtNovaSenha"
        Me.txtNovaSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNovaSenha.Size = New System.Drawing.Size(101, 20)
        Me.txtNovaSenha.TabIndex = 9
        Me.txtNovaSenha.Visible = False
        '
        'txtSenhaAtual
        '
        Me.txtSenhaAtual.Location = New System.Drawing.Point(85, 116)
        Me.txtSenhaAtual.Name = "txtSenhaAtual"
        Me.txtSenhaAtual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenhaAtual.Size = New System.Drawing.Size(101, 20)
        Me.txtSenhaAtual.TabIndex = 8
        Me.txtSenhaAtual.Visible = False
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(56, 52)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(363, 20)
        Me.txtEmail.TabIndex = 7
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(56, 18)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(363, 20)
        Me.txtNome.TabIndex = 6
        '
        'lbSenhaAtual
        '
        Me.lbSenhaAtual.AutoSize = True
        Me.lbSenhaAtual.Location = New System.Drawing.Point(15, 119)
        Me.lbSenhaAtual.Name = "lbSenhaAtual"
        Me.lbSenhaAtual.Size = New System.Drawing.Size(64, 13)
        Me.lbSenhaAtual.TabIndex = 5
        Me.lbSenhaAtual.Text = "Senha atual"
        Me.lbSenhaAtual.Visible = False
        '
        'lbNovaSenha
        '
        Me.lbNovaSenha.AutoSize = True
        Me.lbNovaSenha.Location = New System.Drawing.Point(14, 151)
        Me.lbNovaSenha.Name = "lbNovaSenha"
        Me.lbNovaSenha.Size = New System.Drawing.Size(65, 13)
        Me.lbNovaSenha.TabIndex = 4
        Me.lbNovaSenha.Text = "Nova senha"
        Me.lbNovaSenha.Visible = False
        '
        'lbEmail
        '
        Me.lbEmail.AutoSize = True
        Me.lbEmail.Location = New System.Drawing.Point(15, 55)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(32, 13)
        Me.lbEmail.TabIndex = 3
        Me.lbEmail.Text = "Email"
        '
        'lbNome
        '
        Me.lbNome.AutoSize = True
        Me.lbNome.Location = New System.Drawing.Point(15, 21)
        Me.lbNome.Name = "lbNome"
        Me.lbNome.Size = New System.Drawing.Size(35, 13)
        Me.lbNome.TabIndex = 0
        Me.lbNome.Text = "Nome"
        '
        'btnAplicarDados
        '
        Me.btnAplicarDados.Location = New System.Drawing.Point(344, 184)
        Me.btnAplicarDados.Name = "btnAplicarDados"
        Me.btnAplicarDados.Size = New System.Drawing.Size(75, 23)
        Me.btnAplicarDados.TabIndex = 2
        Me.btnAplicarDados.Text = "Aplicar"
        Me.btnAplicarDados.UseVisualStyleBackColor = True
        '
        'pbxBanner
        '
        Me.pbxBanner.BackgroundImage = Global.sistechy.My.Resources.Resources.banner_configuracoes_fw
        Me.pbxBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxBanner.Location = New System.Drawing.Point(0, -2)
        Me.pbxBanner.Name = "pbxBanner"
        Me.pbxBanner.Size = New System.Drawing.Size(638, 55)
        Me.pbxBanner.TabIndex = 34
        Me.pbxBanner.TabStop = False
        '
        'btnFecharForm
        '
        Me.btnFecharForm.BackColor = System.Drawing.Color.White
        Me.btnFecharForm.BackgroundImage = Global.sistechy.My.Resources.Resources.fechar
        Me.btnFecharForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFecharForm.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnFecharForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnFecharForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnFecharForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFecharForm.Location = New System.Drawing.Point(582, 62)
        Me.btnFecharForm.Name = "btnFecharForm"
        Me.btnFecharForm.Size = New System.Drawing.Size(40, 40)
        Me.btnFecharForm.TabIndex = 30
        Me.btnFecharForm.UseVisualStyleBackColor = False
        '
        'frmConfiguracoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(638, 345)
        Me.Controls.Add(Me.pbxBanner)
        Me.Controls.Add(Me.gpxMeusDados)
        Me.Controls.Add(Me.btnMeusDados)
        Me.Controls.Add(Me.btnConfiguracoesSistema)
        Me.Controls.Add(Me.gpxSistema)
        Me.Controls.Add(Me.btnFecharForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConfiguracoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurações"
        Me.gpxSistema.ResumeLayout(False)
        Me.gpxSistema.PerformLayout()
        Me.gpxMeusDados.ResumeLayout(False)
        Me.gpxMeusDados.PerformLayout()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbIdioma As System.Windows.Forms.Label
    Friend WithEvents cmbIdioma As System.Windows.Forms.ComboBox
    Friend WithEvents btnAplicarIdioma As System.Windows.Forms.Button
    Friend WithEvents btnFecharForm As System.Windows.Forms.Button
    Friend WithEvents gpxSistema As System.Windows.Forms.GroupBox
    Friend WithEvents btnConfiguracoesSistema As System.Windows.Forms.Button
    Friend WithEvents btnMeusDados As System.Windows.Forms.Button
    Friend WithEvents gpxMeusDados As System.Windows.Forms.GroupBox
    Friend WithEvents lbNome As System.Windows.Forms.Label
    Friend WithEvents btnAplicarDados As System.Windows.Forms.Button
    Friend WithEvents txtNovaSenha As System.Windows.Forms.TextBox
    Friend WithEvents txtSenhaAtual As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents lbSenhaAtual As System.Windows.Forms.Label
    Friend WithEvents lbNovaSenha As System.Windows.Forms.Label
    Friend WithEvents lbEmail As System.Windows.Forms.Label
    Friend WithEvents txtSenhaAtual2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNovaSenha2 As System.Windows.Forms.TextBox
    Friend WithEvents lbRepitaASenha As System.Windows.Forms.Label
    Friend WithEvents lbAlterarSenha As System.Windows.Forms.Label
    Friend WithEvents RadioNao As System.Windows.Forms.RadioButton
    Friend WithEvents RadioSim As System.Windows.Forms.RadioButton
    Friend WithEvents pbxBanner As System.Windows.Forms.PictureBox
End Class
