Imports System.Data.SqlClient
Public Class frmPrincipal

    Private Sub nivelacesso()
        If (txtNivelAcesso.Text = "Administrador") Then
        End If

        If (txtNivelAcesso.Text = "Gerente") Then
            btnConsulta.Enabled = False
            btnAtendimento.Enabled = False
            btnVenda.Enabled = False
            btnEstoque.Enabled = False
            btnAgenda.Enabled = False

            btnConsulta.BackColor = Color.Silver
            btnAtendimento.BackColor = Color.Silver
            btnVenda.BackColor = Color.Silver
            btnEstoque.BackColor = Color.Silver
            btnAgenda.BackColor = Color.Silver
        End If

        If (txtNivelAcesso.Text = "Veterinário") Then
            btnCadastro.Enabled = False
            btnConsulta.Enabled = False
            btnVenda.Enabled = False
            btnEstoque.Enabled = False
            btnGraficos.Enabled = False

            btnCadastro.BackColor = Color.Silver
            btnConsulta.BackColor = Color.Silver
            btnVenda.BackColor = Color.Silver
            btnEstoque.BackColor = Color.Silver
            btnGraficos.BackColor = Color.Silver
        End If

        If (txtNivelAcesso.Text = "Atendente") Then
            btnAtendimento.Enabled = False
            btnGraficos.Enabled = False

            btnAtendimento.BackColor = Color.Silver
            btnGraficos.BackColor = Color.Silver
        End If

    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Conectar()

        comando.CommandText = ("select (idioma) from configuracoes")
        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            lbIdioma.Text = sqlReader.GetString(0)
        End If
        sqlReader.Close()

        Desconectar()

        If lbIdioma.Text = "Português" Then

            btnCadastro.BackgroundImage = My.Resources.cadastro_geral
            btnConsulta.BackgroundImage = My.Resources.consultar_geral_fw
            btnAtendimento.BackgroundImage = My.Resources.atendimento_geral_fw
            btnVenda.BackgroundImage = My.Resources.venda_geral_fw
            btnEstoque.BackgroundImage = My.Resources.estoque_geral_fw
            btnAgenda.BackgroundImage = My.Resources.agenda_fw
            btnGraficos.BackgroundImage = My.Resources.graficos_geral_fw
            btnConfiguracoes.BackgroundImage = My.Resources.configuracoes_fw
            btnSair.BackgroundImage = My.Resources.sair_fw
            btnLogoff.BackgroundImage = My.Resources.logoff_fw

        End If

        If lbIdioma.Text = "English" Then

            Me.Text = "Casa"

            lbBemVindo.Text = "Welcome"
            lbCargo.Text = "Office"
            lbHoje.Text = "Today"

            btnCadastro.BackgroundImage = My.Resources.cadastro_geral_english_fw
            btnConsulta.BackgroundImage = My.Resources.consultar_geral_english_fw
            btnAtendimento.BackgroundImage = My.Resources.atendimento_geral_english_fw
            btnVenda.BackgroundImage = My.Resources.venda_geral_english_fw
            btnEstoque.BackgroundImage = My.Resources.estoque_geral_english_fw
            btnAgenda.BackgroundImage = My.Resources.agenda_english_fw
            btnGraficos.BackgroundImage = My.Resources.graficos_geral_english_fw
            btnConfiguracoes.BackgroundImage = My.Resources.configuracoes_english_fw
            btnSair.BackgroundImage = My.Resources.sair_english_fw
            btnLogoff.BackgroundImage = My.Resources.logoff_fw

        End If

        If lbIdioma.Text = "Spanish" Then

            Me.Text = "Home"

            lbBemVindo.Text = "Welcome"
            lbCargo.Text = "Office"
            lbHoje.Text = "Today"

            btnCadastro.BackgroundImage = My.Resources.cadastro_geral_spanish_fw
            btnConsulta.BackgroundImage = My.Resources.consultar_geral_spanish_fw
            btnAtendimento.BackgroundImage = My.Resources.atendimento_geral_spanish_fw
            btnVenda.BackgroundImage = My.Resources.venda_geral_spanish_fw
            btnEstoque.BackgroundImage = My.Resources.estoque_geral_spanish_fw
            btnAgenda.BackgroundImage = My.Resources.agenda_spanish_fw
            btnGraficos.BackgroundImage = My.Resources.graficos_geral_fw
            btnConfiguracoes.BackgroundImage = My.Resources.configuracoes_spanish_fw
            btnSair.BackgroundImage = My.Resources.sair_spanish_fw
            btnLogoff.BackgroundImage = My.Resources.logoff_fw

        End If


        testeconexao()

    End Sub

    Private Sub btnCadastro_Click(sender As Object, e As EventArgs) Handles btnCadastro.Click

        Me.Hide()
        frmCadastro.Show()

    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click

        Me.Hide()
        frmConsulta.Show()

    End Sub

    Private Sub btnAtendimento_Click(sender As Object, e As EventArgs) Handles btnAtendimento.Click

        Me.Hide()
        frmAtendimento.Show()

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Dim message_portugues As Integer
        Dim message_english As Integer
        Dim message_spanish As Integer

        If (lbIdioma.Text = "Português") Then

            message_portugues = MessageBox.Show("Deseja mesmo sair ?", _
                                          "Sair ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        End If

        If (lbIdioma.Text = "English") Then

            message_english = MessageBox.Show("Want to quit ?", _
                                          "Quit ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        End If

        If (lbIdioma.Text = "Spanish") Then

            message_english = MessageBox.Show("¿Quieres dejar ?", _
                                          "Dejar ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        End If

        If message_portugues = vbYes Or message_english = vbYes Or message_spanish = vbYes Then

            Application.Exit()

        End If

    End Sub

    Private Sub btnEstoque_Click(sender As Object, e As EventArgs) Handles btnEstoque.Click

        Me.Hide()
        frmEntradaEstoque.Show()

    End Sub

    Private Sub TimerRelogio_Tick(sender As Object, e As EventArgs) Handles TimerRelogio.Tick

        If (lbIdioma.Text = "Português") Then
            lbHora.Text = TimeString
            lbData.Text = CDate(Now).ToString("dd/MM/yyyy")
        End If

        If (lbIdioma.Text = "English") Then
            lbHora.Text = TimeString
            lbData.Text = CDate(Now).ToString("MM/dd/yyyy")
        End If

    End Sub

    Private Sub TimerNivelAcessoEmensagens_Tick(sender As Object, e As EventArgs) Handles TimerNivelAcessoEmensagens.Tick

        nivelacesso()

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = ("select (nome_func) from funcionario where login_func =@login_func")
        comando.Parameters.AddWithValue("@login_func", txtUsuario.Text)

        Dim sqlReader2 As SqlDataReader

        sqlReader2 = comando.ExecuteReader()
        If sqlReader2.Read() Then
            lbNome.Text = sqlReader2.GetString(0)
        End If
        sqlReader2.Close()

        Desconectar()

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = ("select (cargo_func) from funcionario where login_func =@login_func")
        comando.Parameters.AddWithValue("@login_func", txtUsuario.Text)

        Dim sqlReader3 As SqlDataReader

        sqlReader3 = comando.ExecuteReader()
        If sqlReader3.Read() Then
            lbCargo.Text = sqlReader3.GetString(0)
        End If
        sqlReader3.Close()

        Desconectar()

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = ("select count(*) from mensagens where destinatario =@nome_destinatario and status_mensagem ='não lida'")
        comando.Parameters.AddWithValue("@nome_destinatario", txtUsuario.Text)

        Dim sqlReader4 As SqlDataReader

        sqlReader4 = comando.ExecuteReader()
        If sqlReader4.Read() Then
            txtCountMensagens.Text = sqlReader4.GetInt32(0)
            btnMensagens.Text = "(" + txtCountMensagens.Text + ")" + "    mensagens não lidas"
        End If
        sqlReader4.Close()

        Desconectar()

        frmCaixaEntrada.txtUsuario.Text = Me.txtUsuario.Text
    End Sub

    Private Sub btnAgenda_Click(sender As Object, e As EventArgs) Handles btnAgenda.Click

        Me.Hide()
        frmAgendaPrincipal.Show()

    End Sub

    Private Sub btnEstatisticas_Click(sender As Object, e As EventArgs) Handles btnGraficos.Click

        Me.Hide()
        frmGraficos.Show()

    End Sub

    Private Sub btnConfiguracoes_Click(sender As Object, e As EventArgs) Handles btnConfiguracoes.Click

        Me.Hide()
        frmConfiguracoes.Show()

    End Sub

    Private Sub frmPrincipal_Move(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Move

        Me.Location = New System.Drawing.Point(0, 0)

    End Sub

    Private Sub btnVenda_Click(sender As Object, e As EventArgs) Handles btnVenda.Click

        Me.Hide()
        frmVendas.Show()

    End Sub

    Private Sub btnMensagens_Click(sender As Object, e As EventArgs) Handles btnMensagens.Click

        Me.Hide()
        frmCaixaEntrada.Show()

    End Sub

    Private Sub btnMenuMostrar_Click(sender As Object, e As EventArgs) Handles btnMenuMostrar.Click

        btnMenuMostrar.Visible = False
        GroupBox1.Visible = True
        btnMenuOcultar.Visible = True

    End Sub

    Private Sub btnMenuOcultar_Click(sender As Object, e As EventArgs) Handles btnMenuOcultar.Click

        btnMenuOcultar.Visible = False
        GroupBox1.Visible = False
        btnMenuMostrar.Visible = True

    End Sub

    Private Sub btnLogoff_Click(sender As Object, e As EventArgs) Handles btnLogoff.Click
        Me.Close()
        frmLogin.txtUsuario.Text = Nothing
        frmLogin.txtSenha.Text = Nothing
        frmLogin.Show()
    End Sub
End Class
