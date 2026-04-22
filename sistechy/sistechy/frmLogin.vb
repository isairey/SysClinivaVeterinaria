Imports System.Data.SqlClient
Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim message_usuario As Integer
        Dim message_senha As Integer
        Dim message_erro As Integer

        If (txtUsuario.Text) Is "" Then
            message_usuario = MessageBox.Show("Digite seu usuário", _
                                              "Usuário nulo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsuario.Focus()
        Else
            If (txtSenha.Text) Is "" Then
                message_senha = MessageBox.Show("Digite sua senha", _
                                              "Senha nula", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtSenha.Focus()
            Else

                Conectar()
                comando.Parameters.Clear()
                comando.CommandText = ("select count(*)from funcionario where login_func =@login_func and senha_func =@senha_func")
                comando.Parameters.AddWithValue("@login_func", txtUsuario.Text)
                comando.Parameters.AddWithValue("@senha_func", txtSenha.Text)
                comando.ExecuteNonQuery()

                Dim sqlReader As SqlDataReader

                sqlReader = comando.ExecuteReader()
                If sqlReader.Read() Then
                    txtCount.Text = sqlReader.GetInt32(0)
                End If
                sqlReader.Close()
                Desconectar()

                If (txtCount.Text) = "0" Then
                    message_erro = MessageBox.Show("Usuário ou senha incorretos", _
                                                  "Login falhou", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                If (txtCount.Text) = "1" Then

                    Conectar()
                    comando.Parameters.Clear()
                    comando.CommandText = ("select (nivel_acesso) from funcionario where login_func =@login_func")
                    comando.Parameters.AddWithValue("@login_func", txtUsuario.Text)
                    comando.ExecuteNonQuery()

                    Dim sqlReader2 As SqlDataReader

                    sqlReader2 = comando.ExecuteReader()
                    If sqlReader2.Read() Then
                        txtNivelAcesso.Text = sqlReader2.GetString(0)
                    End If
                    sqlReader.Close()
                    Desconectar()

                    Me.Hide()
                    frmPrincipal.Show()
                    frmPrincipal.txtUsuario.Text = Me.txtUsuario.Text
                    frmPrincipal.txtNivelAcesso.Text = Me.txtNivelAcesso.Text
                End If
            End If
        End If



    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Dim message_portugues As Integer
        Dim message_english As Integer

        If (lbIdioma.Text = "English") Then

            message_english = MessageBox.Show("Want to quit ?", _
                                              "Confirm ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If message_english = vbYes Then
                Application.Exit()
            End If
        End If

        If (lbIdioma.Text = "Português") Then

            message_portugues = MessageBox.Show("Deseja mesmo sair ?", _
                                              "Confirma ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If message_portugues = vbYes Then
                Application.Exit()
            End If
        End If

    End Sub

    Private Sub cbxMostraSenha_Checked(sender As Object, e As EventArgs) Handles cbxMostraSenha.CheckedChanged

        If cbxMostraSenha.Checked Then
            txtSenha.PasswordChar = Nothing
        Else
            txtSenha.PasswordChar = "*"
        End If

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Conectar()

        comando.CommandText = ("select (idioma) from configuracoes")
        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            lbIdioma.Text = sqlReader.GetString(0)
        End If
        sqlReader.Close()
        Desconectar()

        If (lbIdioma.Text = "English") Then

            Me.Text = "Sign in"

            lbUsuario.Text = "User"
            lbSenha.Text = "Password"
            cbxMostraSenha.Text = "Show Password"
            lbEsqueceuSenha.Text = "Forgot your password ?"
            linklbRecupera.Text = "To recovery"
            btnSair.BackgroundImage = My.Resources.sair_english_fw

        End If

        If (lbIdioma.Text = "Spanish") Then

            Me.Text = "Registrarse"

            lbUsuario.Text = "Usuario"
            lbSenha.Text = "Contraseña"
            cbxMostraSenha.Text = "Mostrar contraseña"
            lbEsqueceuSenha.Text = "¿Olvidaste tu contraseña ?"
            linklbRecupera.Text = "Para la recuperación"
            btnSair.BackgroundImage = My.Resources.sair_spanish_fw

        End If

    End Sub

    Private Sub linklbRecupera_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklbRecupera.LinkClicked
        Me.Hide()
        frmDigitaLogin.Show()
    End Sub
End Class