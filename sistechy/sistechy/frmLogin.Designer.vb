<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.lbSenha = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.lbEsqueceuSenha = New System.Windows.Forms.Label()
        Me.linklbRecupera = New System.Windows.Forms.LinkLabel()
        Me.cbxMostraSenha = New System.Windows.Forms.CheckBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lbIdioma = New System.Windows.Forms.Label()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.txtNivelAcesso = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsuario.Location = New System.Drawing.Point(195, 15)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(60, 18)
        Me.lbUsuario.TabIndex = 0
        Me.lbUsuario.Text = "Usuário"
        '
        'lbSenha
        '
        Me.lbSenha.AutoSize = True
        Me.lbSenha.BackColor = System.Drawing.Color.Transparent
        Me.lbSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSenha.Location = New System.Drawing.Point(195, 85)
        Me.lbSenha.Name = "lbSenha"
        Me.lbSenha.Size = New System.Drawing.Size(50, 18)
        Me.lbSenha.TabIndex = 1
        Me.lbSenha.Text = "Senha"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(198, 36)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(254, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(198, 106)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(254, 20)
        Me.txtSenha.TabIndex = 2
        '
        'lbEsqueceuSenha
        '
        Me.lbEsqueceuSenha.AutoSize = True
        Me.lbEsqueceuSenha.BackColor = System.Drawing.Color.Transparent
        Me.lbEsqueceuSenha.Location = New System.Drawing.Point(195, 172)
        Me.lbEsqueceuSenha.Name = "lbEsqueceuSenha"
        Me.lbEsqueceuSenha.Size = New System.Drawing.Size(116, 13)
        Me.lbEsqueceuSenha.TabIndex = 6
        Me.lbEsqueceuSenha.Text = "Esqueceu sua senha ?"
        '
        'linklbRecupera
        '
        Me.linklbRecupera.AutoSize = True
        Me.linklbRecupera.BackColor = System.Drawing.Color.Transparent
        Me.linklbRecupera.Location = New System.Drawing.Point(315, 172)
        Me.linklbRecupera.Name = "linklbRecupera"
        Me.linklbRecupera.Size = New System.Drawing.Size(63, 13)
        Me.linklbRecupera.TabIndex = 7
        Me.linklbRecupera.TabStop = True
        Me.linklbRecupera.Text = "Recupere-a"
        '
        'cbxMostraSenha
        '
        Me.cbxMostraSenha.AutoSize = True
        Me.cbxMostraSenha.BackColor = System.Drawing.Color.Transparent
        Me.cbxMostraSenha.Location = New System.Drawing.Point(198, 132)
        Me.cbxMostraSenha.Name = "cbxMostraSenha"
        Me.cbxMostraSenha.Size = New System.Drawing.Size(93, 17)
        Me.cbxMostraSenha.TabIndex = 8
        Me.cbxMostraSenha.Text = "Mostrar senha"
        Me.cbxMostraSenha.UseVisualStyleBackColor = False
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.White
        Me.btnSair.BackgroundImage = Global.sistechy.My.Resources.Resources.sair_fw
        Me.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Location = New System.Drawing.Point(375, 202)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(77, 56)
        Me.btnSair.TabIndex = 4
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.White
        Me.btnLogin.BackgroundImage = Global.sistechy.My.Resources.Resources.login_fw
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Location = New System.Drawing.Point(198, 202)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(158, 56)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lbIdioma
        '
        Me.lbIdioma.AutoSize = True
        Me.lbIdioma.Location = New System.Drawing.Point(297, 13)
        Me.lbIdioma.Name = "lbIdioma"
        Me.lbIdioma.Size = New System.Drawing.Size(38, 13)
        Me.lbIdioma.TabIndex = 9
        Me.lbIdioma.Text = "Idioma"
        Me.lbIdioma.Visible = False
        '
        'txtCount
        '
        Me.txtCount.Location = New System.Drawing.Point(352, 10)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(100, 20)
        Me.txtCount.TabIndex = 10
        Me.txtCount.Visible = False
        '
        'txtNivelAcesso
        '
        Me.txtNivelAcesso.Location = New System.Drawing.Point(352, 10)
        Me.txtNivelAcesso.Name = "txtNivelAcesso"
        Me.txtNivelAcesso.Size = New System.Drawing.Size(100, 20)
        Me.txtNivelAcesso.TabIndex = 11
        Me.txtNivelAcesso.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.sistechy.My.Resources.Resources.logo_fw
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(12, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 189)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.sistechy.My.Resources.Resources.fundo_splash
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(476, 270)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtNivelAcesso)
        Me.Controls.Add(Me.txtCount)
        Me.Controls.Add(Me.lbIdioma)
        Me.Controls.Add(Me.cbxMostraSenha)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.linklbRecupera)
        Me.Controls.Add(Me.lbEsqueceuSenha)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lbSenha)
        Me.Controls.Add(Me.lbUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Efetue o login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbUsuario As System.Windows.Forms.Label
    Friend WithEvents lbSenha As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lbEsqueceuSenha As System.Windows.Forms.Label
    Friend WithEvents linklbRecupera As System.Windows.Forms.LinkLabel
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents cbxMostraSenha As System.Windows.Forms.CheckBox
    Friend WithEvents lbIdioma As System.Windows.Forms.Label
    Friend WithEvents txtCount As System.Windows.Forms.TextBox
    Friend WithEvents txtNivelAcesso As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
