<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.TimerRelogio = New System.Windows.Forms.Timer(Me.components)
        Me.lbHora = New System.Windows.Forms.Label()
        Me.lbData = New System.Windows.Forms.Label()
        Me.lbHoje = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnCadastro = New System.Windows.Forms.Button()
        Me.btnConfiguracoes = New System.Windows.Forms.Button()
        Me.btnGraficos = New System.Windows.Forms.Button()
        Me.btnAgenda = New System.Windows.Forms.Button()
        Me.btnEstoque = New System.Windows.Forms.Button()
        Me.btnVenda = New System.Windows.Forms.Button()
        Me.btnAtendimento = New System.Windows.Forms.Button()
        Me.btnConsulta = New System.Windows.Forms.Button()
        Me.lbIdioma = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtNivelAcesso = New System.Windows.Forms.TextBox()
        Me.TimerNivelAcessoEmensagens = New System.Windows.Forms.Timer(Me.components)
        Me.lbBemVindo = New System.Windows.Forms.Label()
        Me.lbNome = New System.Windows.Forms.Label()
        Me.lbCargo = New System.Windows.Forms.Label()
        Me.btnMensagens = New System.Windows.Forms.Button()
        Me.txtCountMensagens = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnMenuMostrar = New System.Windows.Forms.Button()
        Me.btnMenuOcultar = New System.Windows.Forms.Button()
        Me.btnLogoff = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimerRelogio
        '
        Me.TimerRelogio.Enabled = True
        Me.TimerRelogio.Interval = 1000
        '
        'lbHora
        '
        resources.ApplyResources(Me.lbHora, "lbHora")
        Me.lbHora.Name = "lbHora"
        '
        'lbData
        '
        resources.ApplyResources(Me.lbData, "lbData")
        Me.lbData.Name = "lbData"
        '
        'lbHoje
        '
        resources.ApplyResources(Me.lbHoje, "lbHoje")
        Me.lbHoje.Name = "lbHoje"
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.White
        Me.btnSair.BackgroundImage = Global.sistechy.My.Resources.Resources.sair_fw
        resources.ApplyResources(Me.btnSair, "btnSair")
        Me.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnSair.Name = "btnSair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'btnCadastro
        '
        Me.btnCadastro.BackColor = System.Drawing.Color.White
        Me.btnCadastro.BackgroundImage = Global.sistechy.My.Resources.Resources.cadastro_geral
        resources.ApplyResources(Me.btnCadastro, "btnCadastro")
        Me.btnCadastro.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCadastro.Name = "btnCadastro"
        Me.btnCadastro.UseVisualStyleBackColor = False
        '
        'btnConfiguracoes
        '
        Me.btnConfiguracoes.BackColor = System.Drawing.Color.White
        Me.btnConfiguracoes.BackgroundImage = Global.sistechy.My.Resources.Resources.configuracoes_fw
        resources.ApplyResources(Me.btnConfiguracoes, "btnConfiguracoes")
        Me.btnConfiguracoes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnConfiguracoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnConfiguracoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnConfiguracoes.Name = "btnConfiguracoes"
        Me.btnConfiguracoes.UseVisualStyleBackColor = False
        '
        'btnGraficos
        '
        Me.btnGraficos.BackColor = System.Drawing.Color.White
        Me.btnGraficos.BackgroundImage = Global.sistechy.My.Resources.Resources.graficos_geral_fw
        resources.ApplyResources(Me.btnGraficos, "btnGraficos")
        Me.btnGraficos.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGraficos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnGraficos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnGraficos.Name = "btnGraficos"
        Me.btnGraficos.UseVisualStyleBackColor = False
        '
        'btnAgenda
        '
        Me.btnAgenda.BackColor = System.Drawing.Color.White
        Me.btnAgenda.BackgroundImage = Global.sistechy.My.Resources.Resources.agenda_fw
        resources.ApplyResources(Me.btnAgenda, "btnAgenda")
        Me.btnAgenda.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAgenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnAgenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnAgenda.Name = "btnAgenda"
        Me.btnAgenda.UseVisualStyleBackColor = False
        '
        'btnEstoque
        '
        Me.btnEstoque.BackColor = System.Drawing.Color.White
        Me.btnEstoque.BackgroundImage = Global.sistechy.My.Resources.Resources.estoque_geral_fw
        resources.ApplyResources(Me.btnEstoque, "btnEstoque")
        Me.btnEstoque.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEstoque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnEstoque.Name = "btnEstoque"
        Me.btnEstoque.UseVisualStyleBackColor = False
        '
        'btnVenda
        '
        Me.btnVenda.BackColor = System.Drawing.Color.White
        Me.btnVenda.BackgroundImage = Global.sistechy.My.Resources.Resources.venda_geral_fw
        resources.ApplyResources(Me.btnVenda, "btnVenda")
        Me.btnVenda.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnVenda.Name = "btnVenda"
        Me.btnVenda.UseVisualStyleBackColor = False
        '
        'btnAtendimento
        '
        Me.btnAtendimento.BackColor = System.Drawing.Color.White
        Me.btnAtendimento.BackgroundImage = Global.sistechy.My.Resources.Resources.atendimento_geral_fw
        resources.ApplyResources(Me.btnAtendimento, "btnAtendimento")
        Me.btnAtendimento.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAtendimento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnAtendimento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnAtendimento.Name = "btnAtendimento"
        Me.btnAtendimento.UseVisualStyleBackColor = False
        '
        'btnConsulta
        '
        Me.btnConsulta.BackColor = System.Drawing.Color.White
        Me.btnConsulta.BackgroundImage = Global.sistechy.My.Resources.Resources.consultar_geral_fw
        resources.ApplyResources(Me.btnConsulta, "btnConsulta")
        Me.btnConsulta.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.UseVisualStyleBackColor = False
        '
        'lbIdioma
        '
        resources.ApplyResources(Me.lbIdioma, "lbIdioma")
        Me.lbIdioma.Name = "lbIdioma"
        '
        'txtUsuario
        '
        resources.ApplyResources(Me.txtUsuario, "txtUsuario")
        Me.txtUsuario.Name = "txtUsuario"
        '
        'txtNivelAcesso
        '
        resources.ApplyResources(Me.txtNivelAcesso, "txtNivelAcesso")
        Me.txtNivelAcesso.Name = "txtNivelAcesso"
        '
        'TimerNivelAcessoEmensagens
        '
        Me.TimerNivelAcessoEmensagens.Enabled = True
        Me.TimerNivelAcessoEmensagens.Interval = 10
        '
        'lbBemVindo
        '
        resources.ApplyResources(Me.lbBemVindo, "lbBemVindo")
        Me.lbBemVindo.Name = "lbBemVindo"
        '
        'lbNome
        '
        resources.ApplyResources(Me.lbNome, "lbNome")
        Me.lbNome.Name = "lbNome"
        '
        'lbCargo
        '
        resources.ApplyResources(Me.lbCargo, "lbCargo")
        Me.lbCargo.Name = "lbCargo"
        '
        'btnMensagens
        '
        resources.ApplyResources(Me.btnMensagens, "btnMensagens")
        Me.btnMensagens.Name = "btnMensagens"
        Me.btnMensagens.UseVisualStyleBackColor = True
        '
        'txtCountMensagens
        '
        resources.ApplyResources(Me.txtCountMensagens, "txtCountMensagens")
        Me.txtCountMensagens.Name = "txtCountMensagens"
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lbBemVindo)
        Me.GroupBox1.Controls.Add(Me.lbNome)
        Me.GroupBox1.Controls.Add(Me.lbCargo)
        Me.GroupBox1.Controls.Add(Me.lbHoje)
        Me.GroupBox1.Controls.Add(Me.lbHora)
        Me.GroupBox1.Controls.Add(Me.lbData)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'btnMenuMostrar
        '
        resources.ApplyResources(Me.btnMenuMostrar, "btnMenuMostrar")
        Me.btnMenuMostrar.Name = "btnMenuMostrar"
        Me.btnMenuMostrar.UseVisualStyleBackColor = True
        '
        'btnMenuOcultar
        '
        resources.ApplyResources(Me.btnMenuOcultar, "btnMenuOcultar")
        Me.btnMenuOcultar.Name = "btnMenuOcultar"
        Me.btnMenuOcultar.UseVisualStyleBackColor = True
        '
        'btnLogoff
        '
        Me.btnLogoff.BackColor = System.Drawing.Color.White
        Me.btnLogoff.BackgroundImage = Global.sistechy.My.Resources.Resources.logoff_fw
        resources.ApplyResources(Me.btnLogoff, "btnLogoff")
        Me.btnLogoff.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLogoff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnLogoff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnLogoff.Name = "btnLogoff"
        Me.btnLogoff.UseVisualStyleBackColor = False
        '
        'frmPrincipal
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImage = Global.sistechy.My.Resources.Resources.banner_fw
        Me.Controls.Add(Me.btnLogoff)
        Me.Controls.Add(Me.btnMenuOcultar)
        Me.Controls.Add(Me.btnMenuMostrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtCountMensagens)
        Me.Controls.Add(Me.btnMensagens)
        Me.Controls.Add(Me.txtNivelAcesso)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lbIdioma)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnCadastro)
        Me.Controls.Add(Me.btnConfiguracoes)
        Me.Controls.Add(Me.btnGraficos)
        Me.Controls.Add(Me.btnAgenda)
        Me.Controls.Add(Me.btnEstoque)
        Me.Controls.Add(Me.btnVenda)
        Me.Controls.Add(Me.btnAtendimento)
        Me.Controls.Add(Me.btnConsulta)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConsulta As System.Windows.Forms.Button
    Friend WithEvents btnAtendimento As System.Windows.Forms.Button
    Friend WithEvents btnVenda As System.Windows.Forms.Button
    Friend WithEvents btnEstoque As System.Windows.Forms.Button
    Friend WithEvents btnAgenda As System.Windows.Forms.Button
    Friend WithEvents btnGraficos As System.Windows.Forms.Button
    Friend WithEvents btnConfiguracoes As System.Windows.Forms.Button
    Friend WithEvents btnCadastro As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents TimerRelogio As System.Windows.Forms.Timer
    Friend WithEvents lbHora As System.Windows.Forms.Label
    Friend WithEvents lbData As System.Windows.Forms.Label
    Friend WithEvents lbHoje As System.Windows.Forms.Label
    Friend WithEvents lbIdioma As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtNivelAcesso As System.Windows.Forms.TextBox
    Friend WithEvents TimerNivelAcessoEmensagens As System.Windows.Forms.Timer
    Friend WithEvents lbBemVindo As System.Windows.Forms.Label
    Friend WithEvents lbNome As System.Windows.Forms.Label
    Friend WithEvents lbCargo As System.Windows.Forms.Label
    Friend WithEvents btnMensagens As System.Windows.Forms.Button
    Friend WithEvents txtCountMensagens As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnMenuMostrar As System.Windows.Forms.Button
    Friend WithEvents btnMenuOcultar As System.Windows.Forms.Button
    Friend WithEvents btnLogoff As System.Windows.Forms.Button

End Class
