Public Class frmCorpoMensagem

    Private Sub frmCorpoMensagem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (frmPrincipal.lbIdioma.Text = "English") Then

            Me.Text = "Message"

            lbRemetente.Text = "Sender"
            lbDestinatario.Text = "Addressee"
            lbMensagem.Text = "Message"

            btnApagar.Text = "Delete"
            btnResponder.Text = "Reply"

            pbxBanner.BackgroundImage = My.Resources.banner_corpo_mensagem_english_fw

        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Mensaje"

            lbRemetente.Text = "Envía"
            lbDestinatario.Text = "Destinatario"
            lbMensagem.Text = "Mensaje"

            btnApagar.Text = "Borrar"
            btnResponder.Text = "Responder"

            pbxBanner.BackgroundImage = My.Resources.banner_corpo_mensagem_spanish_fw

        End If

        Conectar()
        comando.CommandText = ("update mensagens set status_mensagem = 'lida' where id_mensagem =@id_mensagem")
        comando.Parameters.AddWithValue("@id_mensagem", txtIdMensagem.Text)
        comando.ExecuteNonQuery()
        Desconectar()



    End Sub

  
    Private Sub btnResponder_Click(sender As Object, e As EventArgs) Handles btnResponder.Click

        frmNovaMensagem.txtRemetente.Text = Me.txtDestinatario.Text
        frmNovaMensagem.txtDestinatario.Text = Me.txtRemetente.Text
        Me.Close()
        frmNovaMensagem.Show()

    End Sub

    Private Sub btnApagar_Click(sender As Object, e As EventArgs) Handles btnApagar.Click

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

        frmCaixaEntrada.dgvMensagens.DataSource = (Consulta_mensagens_nao_lidas(frmCaixaEntrada.txtUsuario.Text))
        frmCaixaEntrada.Show()

    End Sub

    Private Sub btnFecharForm_Click(sender As Object, e As EventArgs) Handles btnFecharForm.Click

        Me.Close()
        frmCaixaEntrada.Show()

    End Sub
End Class