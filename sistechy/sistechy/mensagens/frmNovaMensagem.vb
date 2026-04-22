Public Class frmNovaMensagem

    Private Sub frmNovaMensagem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (frmPrincipal.lbIdioma.Text = "English") Then

            Me.Text = "New message"

            lbRemetente.Text = "Sender"
            lbDestinatario.Text = "Addressee"
            lbMensagem.Text = "Message"

            btnEnviar.Text = "Send"

            pbxBanner.BackgroundImage = My.Resources.banner_nova_mensagem_english_fw

        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Nuevo mensaje"

            lbRemetente.Text = "Envía"
            lbDestinatario.Text = "Destinatario"
            lbMensagem.Text = "Mensaje"

            btnEnviar.Text = "Enviar"

            pbxBanner.BackgroundImage = My.Resources.banner_nova_mensagem_spanish_fw

        End If

        Me.txtRemetente.Text = frmPrincipal.txtUsuario.Text
        txtStatusMensagem.Text = "não lida"

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)

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
            frmCaixaEntrada.dgvMensagens.DataSource = (Consulta_mensagens_nao_lidas(frmCaixaEntrada.txtUsuario.Text))
            frmCaixaEntrada.Show()

        End If

    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click

        Enviar_nova_mensagem(txtRemetente.Text, txtDestinatario.Text, txtMensagem.Text, txtStatusMensagem.Text)

        Me.Close()
        frmCaixaEntrada.Show()

    End Sub

    Private Sub btnFecharForm_Click(sender As Object, e As EventArgs) Handles btnFecharForm.Click

        Me.Close()
        frmCaixaEntrada.Visible = True

    End Sub
End Class