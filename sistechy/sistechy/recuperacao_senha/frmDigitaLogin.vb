Imports System.Net.Mail
Imports System.Data.SqlClient
Public Class frmDigitaLogin

    Dim message As New MailMessage
    Dim smtp As New SmtpClient

    Private Sub btnProsseguir_Click(sender As Object, e As EventArgs) Handles btnProsseguir.Click

        If txtLogin.Text Is "" Then
            MessageBox.Show("Digite o seu login")
            txtLogin.Focus()
        Else

            Dim senha As String = ""
            Dim geranovasenha As New Random

            senha = geranovasenha.Next(1, 99999).ToString("00000")
            txtNovaSenha.Text = senha

            Try
                Conectar()

                comando.Parameters.Clear()
                comando.CommandText = ("select (email_func) from funcionario where login_func =@login_func")
                comando.Parameters.AddWithValue("@login_func", txtLogin.Text)
                comando.ExecuteNonQuery()

                Dim sqlReader As SqlDataReader

                sqlReader = comando.ExecuteReader()
                If sqlReader.Read() Then
                    txtEmail.Text = sqlReader.GetString(0)
                End If
                sqlReader.Close()
                Desconectar()

                message.From = New MailAddress("sistechptcc@gmail.com", "Sistechy Corp.")
                message.To.Add(txtEmail.Text)
                message.Body = "Olá, você solicitou uma nova senha para ter acesso ao sistema World Pet." + Environment.NewLine + "Ela encontra-se logo abaixo, estamos gratos em poder ajudar!" + Environment.NewLine + Environment.NewLine + "Nova senha:" & txtNovaSenha.Text + Environment.NewLine + Environment.NewLine + "Atenciosamente," + Environment.NewLine + "Sistechy" + Environment.NewLine + "João Henrique - Programador"
                message.Subject = "Recuperação de senha"
                message.Priority = MailPriority.Normal

                smtp.EnableSsl = True
                smtp.Port = "587"
                smtp.Host = "smtp.gmail.com"
                smtp.Credentials = New Net.NetworkCredential("sistechptcc@gmail.com", "Sistech10")
                smtp.Send(message)
                MsgBox("Email enviado")

                Conectar()
                comando.Parameters.Clear()
                comando.CommandText = "update funcionario set senha_func =@senha_func where login_func =@login_func"
                comando.Parameters.AddWithValue("@login_func", txtLogin.Text)
                comando.Parameters.AddWithValue("@senha_func", txtNovaSenha.Text)
                comando.ExecuteNonQuery()
                Desconectar()

                frmRecuperaSenha.lbEmail.Text = Me.txtEmail.Text
                Me.Close()
                frmRecuperaSenha.Show()

            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro no envio do email!")
            End Try

        End If

    End Sub

    Private Sub btnFecharForm_Click(sender As Object, e As EventArgs) Handles btnFecharForm.Click

        Me.Close()
        frmLogin.Visible = True

    End Sub

End Class