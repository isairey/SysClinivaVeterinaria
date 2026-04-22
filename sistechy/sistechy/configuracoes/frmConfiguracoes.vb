Imports System.Data.SqlClient
Public Class frmConfiguracoes

    Private Sub frmConfiguracoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = ("select nome_func, email_func from funcionario where login_func =@login_func")
        comando.Parameters.AddWithValue("@login_func", frmPrincipal.txtUsuario.Text)
        Dim sqlReader2 As SqlDataReader

        sqlReader2 = comando.ExecuteReader()
        If sqlReader2.Read() Then
            txtNome.Text = sqlReader2.GetString(0)
            txtEmail.Text = sqlReader2.GetString(1)
        End If
        sqlReader2.Close()

        Desconectar()

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = ("select (senha_func) from funcionario where login_func =@login_func")
        comando.Parameters.AddWithValue("login_func", frmPrincipal.txtUsuario.Text)
        Dim sqlReader3 As SqlDataReader

        sqlReader3 = comando.ExecuteReader()
        If sqlReader3.Read() Then
            txtSenhaAtual2.Text = sqlReader3.GetString(0)
        End If
        sqlReader3.Close()

        Desconectar()

        RadioNao.Checked = True

        cmbIdioma.Items.Add("Português")
        cmbIdioma.Items.Add("English")
        cmbIdioma.Items.Add("Spanish")

        If (frmPrincipal.lbIdioma.Text = "English") Then

            Me.Text = "Settings"

            lbNome.Text = "Name"
            lbAlterarSenha.Text = "Want to change your password?"
            lbSenhaAtual.Text = "Current password"
            lbNovaSenha.Text = "New password"
            lbRepitaASenha.Text = "Repeat password"
            lbIdioma.Text = "Language"

            btnAplicarDados.Text = "Apply"
            btnAplicarIdioma.Text = "Apply"
            btnConfiguracoesSistema.Text = "System settings"
            btnMeusDados.Text = "My data"

            RadioSim.Text = "Yes"
            RadioNao.Text = "No"

            Me.pbxBanner.BackgroundImage = My.Resources.banner_configuracoes_english_fw

        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Ajustes"

            lbNome.Text = "Nombre"
            lbAlterarSenha.Text = "¿Quiere cambiar su contraseña?"
            lbSenhaAtual.Text = "Contraseña actual"
            lbNovaSenha.Text = "Nueva contraseña"
            lbRepitaASenha.Text = "Repita la contraseña"
            lbIdioma.Text = "Idioma"

            btnAplicarDados.Text = "Aplicar"
            btnAplicarIdioma.Text = "Aplicar"
            btnConfiguracoesSistema.Text = "Configuración del sistema"
            btnMeusDados.Text = "Mis datos"

            RadioSim.Text = "Sí"
            RadioNao.Text = "No"

            Me.pbxBanner.BackgroundImage = My.Resources.banner_configuracoes_spanish_fw

        End If

    End Sub

    Private Sub btnAplicarIdioma_Click(sender As Object, e As EventArgs) Handles btnAplicarIdioma.Click

        Dim message_portugues As Integer
        Dim message_english As Integer
        Dim message_spanish As Integer

        Conectar()

        If cmbIdioma.Text <> "" Then

            comando.CommandText = ("update configuracoes set idioma= ('" & cmbIdioma.Text & "')")
            comando.ExecuteNonQuery()
            Desconectar()

            If (cmbIdioma.Text = "Português") Then

                message_portugues = MessageBox.Show("O sistema precisa ser reiniciado para todas as alterações entrarem em vigor. Deseja reiniciar agora ?", _
                                          "Reiniciar ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If

            If (cmbIdioma.Text = "English") Then

                message_english = MessageBox.Show("The system must be restarted for any changes to take effect. Want to restart now?", _
                              "Restart ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If

            If (cmbIdioma.Text = "Spanish") Then

                message_spanish = MessageBox.Show("El sistema debe reiniciarse para que los cambios surtan efecto. ¿Quiere reiniciar ahora?", _
                              "Reanudar ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If

            If message_english = vbYes Or message_portugues = vbYes Or message_spanish = vbYes Then

                Application.Restart()

            End If

        Else
        If (frmPrincipal.lbIdioma.Text = "Português") Then
            MessageBox.Show("Selecione um idioma")
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("Select a language")
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("Seleccione un idioma")
            End If
        End If

    End Sub

    Private Sub btnAplicarDados_Click(sender As Object, e As EventArgs) Handles btnAplicarDados.Click

        If (txtNome.Text) Is "" Then
            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("Preencha seu nome")
                txtNome.Focus()
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("Put your name")
                txtNome.Focus()
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("Llenar tu nombre")
                txtNome.Focus()
            End If
        Else
            If (txtEmail.Text) Is "" Then
                If (frmPrincipal.lbIdioma.Text = "Português") Then
                    MessageBox.Show("Preencha seu email")
                    txtEmail.Focus()
                End If
                If (frmPrincipal.lbIdioma.Text = "English") Then
                    MessageBox.Show("Put your email")
                    txtEmail.Focus()
                End If
                If (frmPrincipal.lbIdioma.Text = "English") Then
                    MessageBox.Show("Llenar tu email")
                    txtEmail.Focus()
                End If
            Else
                If (txtNome.Text <> "" And txtEmail.Text <> "") Then

                    Conectar()

                    comando.Parameters.Clear()
                    comando.CommandText = "update funcionario set nome_func =@nome_func, email_func =@email_func where login_func =@login_func"
                    comando.Parameters.AddWithValue("@login_func", frmPrincipal.txtUsuario.Text)
                    comando.Parameters.AddWithValue("@nome_func", txtNome.Text)
                    comando.Parameters.AddWithValue("@email_func", txtEmail.Text)

                    comando.ExecuteNonQuery()
                    Desconectar()

                    If (RadioNao.Checked) Then
                        If (frmPrincipal.lbIdioma.Text = "Português") Then
                            MessageBox.Show("Dados atualizados!")
                        End If
                        If (frmPrincipal.lbIdioma.Text = "English") Then
                            MessageBox.Show("Updated data!")
                        End If
                        If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                            MessageBox.Show("Datos actualizados!")
                        End If
                    Else
                        If (txtNovaSenha.Text <> "") Then

                            If (txtNovaSenha.Text <> "") And (txtSenhaAtual.Text) Is "" Then
                                If (frmPrincipal.lbIdioma.Text = "Português") Then
                                    MessageBox.Show("Para alterar sua senha você precisa validar a anterior!")
                                    txtSenhaAtual.Focus()
                                End If
                                If (frmPrincipal.lbIdioma.Text = "English") Then
                                    MessageBox.Show("To change your password you need to validate the previous!")
                                    txtSenhaAtual.Focus()
                                End If
                                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                    MessageBox.Show("Para cambiar la contraseña que necesita para validar el anterior!")
                                    txtSenhaAtual.Focus()
                                End If
                            Else
                                If (txtSenhaAtual.Text <> txtSenhaAtual2.Text) Then
                                    If (frmPrincipal.lbIdioma.Text = "Português") Then
                                        MessageBox.Show("Senha atual inválida")
                                        txtSenhaAtual.Focus()
                                    End If
                                    If (frmPrincipal.lbIdioma.Text = "English") Then
                                        MessageBox.Show("Current password invalid")
                                        txtSenhaAtual.Focus()
                                    End If
                                    If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                        MessageBox.Show("Inválida contraseña actual")
                                        txtSenhaAtual.Focus()
                                    End If
                                Else
                                    If (txtNovaSenha.Text <> txtNovaSenha2.Text) Then
                                        If (frmPrincipal.lbIdioma.Text = "Português") Then
                                            MessageBox.Show("As senhas devem ser iguais!")
                                            txtNovaSenha2.Focus()
                                        End If
                                        If (frmPrincipal.lbIdioma.Text = "English") Then
                                            MessageBox.Show("Password must equal!")
                                            txtNovaSenha2.Focus()
                                        End If
                                    Else
                                        Conectar()

                                        comando.Parameters.Clear()
                                        comando.CommandText = "update funcionario set senha_func =@senha_func where login_func =@login_func"
                                        comando.Parameters.AddWithValue("@login_func", frmPrincipal.txtUsuario.Text)
                                        comando.Parameters.AddWithValue("@senha_func", txtNovaSenha.Text)

                                        comando.ExecuteNonQuery()
                                        Desconectar()

                                        If (frmPrincipal.lbIdioma.Text = "Português") Then
                                            MessageBox.Show("Dados e senha atualizados!")
                                        End If
                                        If (frmPrincipal.lbIdioma.Text = "English") Then
                                            MessageBox.Show("Updated data and password!")
                                        End If
                                        If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                            MessageBox.Show("Datos actualizados y contraseña!")
                                        End If

                                        txtSenhaAtual.Text = Nothing
                                        txtSenhaAtual2.Text = Nothing
                                        txtNovaSenha.Text = Nothing
                                        txtNovaSenha2.Text = Nothing

                                        Conectar()

                                        comando.Parameters.Clear()
                                        comando.CommandText = ("select (senha_func) from funcionario where login_func =@login_func")
                                        comando.Parameters.AddWithValue("login_func", frmPrincipal.txtUsuario.Text)
                                        Dim sqlReader As SqlDataReader

                                        sqlReader = comando.ExecuteReader()
                                        If sqlReader.Read() Then
                                            txtSenhaAtual2.Text = sqlReader.GetString(0)
                                        End If
                                        sqlReader.Close()

                                        Desconectar()

                                        RadioNao.Checked = True
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub btnFecharForm_Click(sender As Object, e As EventArgs) Handles btnFecharForm.Click

        Me.Close()
        frmPrincipal.Visible = True

    End Sub

    Private Sub btnConfiguracoesSistema_Click(sender As Object, e As EventArgs) Handles btnConfiguracoesSistema.Click

        gpxMeusDados.Visible = False
        gpxSistema.Visible = True

    End Sub

    Private Sub btnMeusDados_Click(sender As Object, e As EventArgs) Handles btnMeusDados.Click

        gpxSistema.Visible = False
        gpxMeusDados.Visible = True

    End Sub

    Private Sub RadioSim_CheckedChanged(sender As Object, e As EventArgs) Handles RadioSim.CheckedChanged

        lbSenhaAtual.Visible = True
        txtSenhaAtual.Visible = True
        lbNovaSenha.Visible = True
        txtNovaSenha.Visible = True
        lbRepitaASenha.Visible = True
        txtNovaSenha2.Visible = True

    End Sub

    Private Sub RadioNao_CheckedChanged(sender As Object, e As EventArgs) Handles RadioNao.CheckedChanged

        lbSenhaAtual.Visible = False
        txtSenhaAtual.Visible = False
        lbNovaSenha.Visible = False
        txtNovaSenha.Visible = False
        lbRepitaASenha.Visible = False
        txtNovaSenha2.Visible = False

    End Sub
End Class