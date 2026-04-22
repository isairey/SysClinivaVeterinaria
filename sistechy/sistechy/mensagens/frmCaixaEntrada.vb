Public Class frmCaixaEntrada

    Private Sub frmCaixaEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (frmPrincipal.lbIdioma.Text = "English") Then

            Me.Text = "Messages"

            Me.pbxBanner.BackgroundImage = My.Resources.banner_caixa_entrada_english_fw
            Me.btnNovaMensagem.BackgroundImage = My.Resources.nova_mensagem_english_fw
            Me.btnCancelar.BackgroundImage = My.Resources.cancelar_english_fw

            Me.btnNaoLidas.Text = "Unread"
            Me.btnLidas.Text = "Read"
            Me.btnEnviadas.Text = "Sent"

        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Mensajes"

            Me.pbxBanner.BackgroundImage = My.Resources.banner_caixa_entrada_spanish_fw
            Me.btnNovaMensagem.BackgroundImage = My.Resources.nova_mensagem_spanish_fw
            Me.btnCancelar.BackgroundImage = My.Resources.cancelar_spanish_fw

            Me.btnNaoLidas.Text = "No leído"
            Me.btnLidas.Text = "Leer"
            Me.btnEnviadas.Text = "Enviado"

        End If

        dgvMensagens.DataSource = Consulta_mensagens_nao_lidas(txtUsuario.Text)

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Dim message_portugues As Integer
        Dim message_english As Integer
        Dim message_spanish As Integer

        If (frmPrincipal.lbIdioma.Text = "Português") Then
            message_portugues = MessageBox.Show("Deseja mesmo cancelar a operação ?", _
                                          "Confirma ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End If

        If (frmPrincipal.lbIdioma.Text = "English") Then
            message_english = MessageBox.Show("Want even cancel the operation ?", _
                                          "Confirm ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then
            message_english = MessageBox.Show("Quieres incluso cancelar la operación ?", _
                                          "Confirma ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End If

        If message_english = vbYes Or message_portugues = vbYes Or message_spanish = vbYes Then

            Me.Close()
            frmPrincipal.Visible = True

        End If

    End Sub

    Private Sub dgvMensagens_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMensagens.CellClick

        Dim i As Integer
        i = dgvMensagens.CurrentRow.Index
        frmCorpoMensagem.txtIdMensagem.Text = dgvMensagens.Item(0, i).Value
        frmCorpoMensagem.txtRemetente.Text = dgvMensagens.Item(1, i).Value
        frmCorpoMensagem.txtDestinatario.Text = dgvMensagens.Item(2, i).Value
        frmCorpoMensagem.txtMensagem.Text = dgvMensagens.Item(3, i).Value

        If (txtFiltroMensagem.Text = "Enviadas") Then
            frmCorpoMensagem.btnResponder.Enabled = False
        End If

        Me.Hide()
        frmCorpoMensagem.Show()

    End Sub

    Private Sub btnNovaMensagem_Click(sender As Object, e As EventArgs) Handles btnNovaMensagem.Click

        Me.Close()
        frmNovaMensagem.Show()

    End Sub

    Private Sub btnNaoLidas_Click(sender As Object, e As EventArgs) Handles btnNaoLidas.Click

        dgvMensagens.DataSource = Consulta_mensagens_nao_lidas(txtUsuario.Text)

    End Sub

    Private Sub btnLidas_Click(sender As Object, e As EventArgs) Handles btnLidas.Click

        dgvMensagens.DataSource = Consulta_mensagens_lidas(txtUsuario.Text)

    End Sub

    Private Sub btnEnviadas_Click(sender As Object, e As EventArgs) Handles btnEnviadas.Click

        dgvMensagens.DataSource = Consulta_mensagens_enviadas(txtUsuario.Text)
        txtFiltroMensagem.Text = "Enviadas"

    End Sub
End Class