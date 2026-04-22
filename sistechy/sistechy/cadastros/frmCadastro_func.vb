Public Class frmCadastro_func


    Private Sub frmCadastro_func_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (frmPrincipal.lbIdioma.Text = "Português") Then

            cmbSexoFunc.Items.Add("Masculino")
            cmbSexoFunc.Items.Add("Feminino")

            cmbNivelAcesso.Items.Add("Administrador")
            cmbNivelAcesso.Items.Add("Gerente")
            cmbNivelAcesso.Items.Add("Veterinário")
            cmbNivelAcesso.Items.Add("Atendente")

        End If

        If (frmPrincipal.lbIdioma.Text = "English") Then

            Me.Text = "Records of employee"

            Me.gpxFunc.Text = "Employee data"
            Me.gpxLogin.Text = "Login data"

            lbNomeFunc.Text = "Name(*)"
            lbTelefoneFunc.Text = "Phone(*)"
            lbCelularFunc.Text = "Cellphone"
            lbSexoFunc.Text = "Sex(*)"
            lbDataNascFunc.Text = "Date of birth"
            lbDataCadFunc.Text = "Date of registration"
            lbEnderecoFunc.Text = "Adress(*)"
            lbNumeroFunc.Text = "Number"
            lbCidadeFunc.Text = "City"
            lbBairroFunc.Text = "Neighborhood"
            lbCargoFunc.Text = "Job title(*)"
            lbSenhaFunc.Text = "Password(*)"
            lbRepitaSenhaFunc.Text = "Repeat password(*)"
            lbNivelAcessoFunc.Text = "Access level(*)"

            cmbSexoFunc.Items.Add("Male")
            cmbSexoFunc.Items.Add("Female")

            cmbNivelAcesso.Items.Add("Administrator")
            cmbNivelAcesso.Items.Add("Manager")
            cmbNivelAcesso.Items.Add("Veterinarian")
            cmbNivelAcesso.Items.Add("Attendant")

            Me.pbxBanner.BackgroundImage = My.Resources.banner_cadastro_funcionario_english_fw
            Me.btnCancelar.BackgroundImage = My.Resources.cancelar_english_fw
            Me.btnCadastraFunc.BackgroundImage = My.Resources.salva_cadastro_english_fw

        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Registro del empleado"

            Me.gpxFunc.Text = "Datos del empleado"
            Me.gpxLogin.Text = "Datos del login"

            lbNomeFunc.Text = "Nombre(*)"
            lbTelefoneFunc.Text = "Teléfono(*)"
            lbCelularFunc.Text = "Teléfono celular"
            lbSexoFunc.Text = "Sexo(*)"
            lbDataNascFunc.Text = "Fecha de nacimiento"
            lbDataCadFunc.Text = "Fecha de registro"
            lbEnderecoFunc.Text = "Dirección(*)"
            lbNumeroFunc.Text = "Número"
            lbCidadeFunc.Text = "Ciudad"
            lbBairroFunc.Text = "Barrio"
            lbCargoFunc.Text = "Título profesional(*)"
            lbSenhaFunc.Text = "Contraseña(*)"
            lbRepitaSenhaFunc.Text = "Repita la contraseña(*)"
            lbNivelAcessoFunc.Text = "Nivel de acceso(*)"

            cmbSexoFunc.Items.Add("Masculino")
            cmbSexoFunc.Items.Add("Femenino")

            cmbNivelAcesso.Items.Add("Administrador")
            cmbNivelAcesso.Items.Add("Gerente")
            cmbNivelAcesso.Items.Add("Veterinario")
            cmbNivelAcesso.Items.Add("Asistente")

            Me.pbxBanner.BackgroundImage = My.Resources.banner_cadastro_funcionario_spanish_fw
            Me.btnCancelar.BackgroundImage = My.Resources.cancelar_spanish_fw
            Me.btnCadastraFunc.BackgroundImage = My.Resources.salva_cadastro_spanish_fw

        End If

        cmbUFFunc.Items.Add("AC")
        cmbUFFunc.Items.Add("AL")
        cmbUFFunc.Items.Add("AM")
        cmbUFFunc.Items.Add("AP")
        cmbUFFunc.Items.Add("BA")
        cmbUFFunc.Items.Add("CE")
        cmbUFFunc.Items.Add("DF")
        cmbUFFunc.Items.Add("ES")
        cmbUFFunc.Items.Add("GO")
        cmbUFFunc.Items.Add("MA")
        cmbUFFunc.Items.Add("MG")
        cmbUFFunc.Items.Add("MS")
        cmbUFFunc.Items.Add("MT")
        cmbUFFunc.Items.Add("PA")
        cmbUFFunc.Items.Add("PB")
        cmbUFFunc.Items.Add("PE")
        cmbUFFunc.Items.Add("PI")
        cmbUFFunc.Items.Add("PR")
        cmbUFFunc.Items.Add("RJ")
        cmbUFFunc.Items.Add("RN")
        cmbUFFunc.Items.Add("RS")
        cmbUFFunc.Items.Add("RO")
        cmbUFFunc.Items.Add("RR")
        cmbUFFunc.Items.Add("SC")
        cmbUFFunc.Items.Add("SE")
        cmbUFFunc.Items.Add("SP")
        cmbUFFunc.Items.Add("TO")

    End Sub

    Private Sub btnCadastraFunc_Click(sender As Object, e As EventArgs) Handles btnCadastraFunc.Click

        If (txtNomeFunc.Text) Is "" Then
            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("O campo Nome não pode ficar vazio")
                txtNomeFunc.Focus()
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("The Name field can not be empty")
                txtNomeFunc.Focus()
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("El campo Nombre no puede estar vacío")
                txtNomeFunc.Focus()
            End If
        Else

            If Not (MtxtDDDFunc.MaskFull) Then
                If (frmPrincipal.lbIdioma.Text = "Português") Then
                    MessageBox.Show("O campo DDD não pode ficar vazio")
                    MtxtDDDFunc.Focus()
                End If
                If (frmPrincipal.lbIdioma.Text = "English") Then
                    MessageBox.Show("The DDD field can not be empty")
                    MtxtDDDFunc.Focus()
                End If
                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                    MessageBox.Show("El campo DDD no puede estar vacío")
                    MtxtDDDFunc.Focus()
                End If
            Else
                If Not (MtxtTelFunc.MaskFull) Then
                    If (frmPrincipal.lbIdioma.Text = "Português") Then
                        MessageBox.Show("O campo Telefone não pode ficar vazio")
                        MtxtTelFunc.Focus()
                    End If
                    If (frmPrincipal.lbIdioma.Text = "English") Then
                        MessageBox.Show("The Phone field can not be empty")
                        MtxtTelFunc.Focus()
                    End If
                    If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                        MessageBox.Show("El campo teléfono no puede estar vacío")
                        MtxtTelFunc.Focus()
                    End If
                Else
                    If (cmbSexoFunc.Text) Is "" Then
                        If (frmPrincipal.lbIdioma.Text = "Português") Then
                            MessageBox.Show("O campo Sexo não pode ficar vazio")
                            cmbSexoFunc.Focus()
                        End If
                        If (frmPrincipal.lbIdioma.Text = "English") Then
                            MessageBox.Show("The Gender field can not be empty")
                            cmbSexoFunc.Focus()
                        End If
                        If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                            MessageBox.Show("El campo de género no puede estar vacío")
                            cmbSexoFunc.Focus()
                        End If
                    Else

                        If Not (MtxtCPFFunc.MaskFull) Then
                            If (frmPrincipal.lbIdioma.Text = "Português") Then
                                MessageBox.Show("O campo CPF não pode ficar vazio")
                                MtxtCPFFunc.Focus()
                            End If
                            If (frmPrincipal.lbIdioma.Text = "English") Then
                                MessageBox.Show("The CPF field can not be empty")
                                MtxtCPFFunc.Focus()
                            End If
                            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                MessageBox.Show("El campo CPF no puede estar vacío")
                                MtxtCPFFunc.Focus()
                            End If
                        Else
                            If Not (MtxtDataCadFunc.MaskFull) Then
                                If (frmPrincipal.lbIdioma.Text = "Português") Then
                                    MessageBox.Show("O campo Data de Cadastro não pode ficar vazio")
                                    MtxtDataCadFunc.Focus()
                                End If
                                If (frmPrincipal.lbIdioma.Text = "English") Then
                                    MessageBox.Show("The Registration Date field can not be empty")
                                    MtxtDataCadFunc.Focus()
                                End If
                                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                    MessageBox.Show("El campo Fecha de Registro no puede estar vacío")
                                    MtxtDataCadFunc.Focus()
                                End If
                            Else
                                If (txtEndFunc.Text) Is "" Then
                                    If (frmPrincipal.lbIdioma.Text = "Português") Then
                                        MessageBox.Show("O campo Endereço não pode ficar vazio")
                                        txtEndFunc.Focus()
                                    End If
                                    If (frmPrincipal.lbIdioma.Text = "English") Then
                                        MessageBox.Show("The address field can not be empty")
                                        txtEndFunc.Focus()
                                    End If
                                    If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                        MessageBox.Show("El campo de dirección no puede estar vacío")
                                        txtEndFunc.Focus()
                                    End If
                                Else
                                    If (txtCargoFunc.Text) Is "" Then
                                        If (frmPrincipal.lbIdioma.Text = "Português") Then
                                            MessageBox.Show("O campo Cargo não pode ficar vazio")
                                            txtCargoFunc.Focus()
                                        End If
                                        If (frmPrincipal.lbIdioma.Text = "English") Then
                                            MessageBox.Show("The Title field can not be empty")
                                            txtCargoFunc.Focus()
                                        End If
                                        If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                            MessageBox.Show("El campo de título no puede estar vacío")
                                            txtCargoFunc.Focus()
                                        End If
                                    Else

                                        If (txtLoginFunc.Text) Is "" Then
                                            If (frmPrincipal.lbIdioma.Text = "Português") Then
                                                MessageBox.Show("O campo Login não pode ficar vazio")
                                                txtLoginFunc.Focus()
                                            End If
                                            If (frmPrincipal.lbIdioma.Text = "English") Then
                                                MessageBox.Show("The Login field can not be empty")
                                                txtLoginFunc.Focus()
                                            End If
                                            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                                MessageBox.Show("El campo de login no puede estar vacío")
                                                txtLoginFunc.Focus()
                                            End If
                                        Else
                                            If (txtSenhaFunc.Text) Is "" Then
                                                If (frmPrincipal.lbIdioma.Text = "Português") Then
                                                    MessageBox.Show("O campo Senha não pode ficar vazio")
                                                    txtSenhaFunc.Focus()
                                                End If
                                                If (frmPrincipal.lbIdioma.Text = "English") Then
                                                    MessageBox.Show("The Password field can not be empty")
                                                    txtSenhaFunc.Focus()
                                                End If
                                                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                                    MessageBox.Show("El campo de contraseña no puede estar vacío")
                                                    txtSenhaFunc.Focus()
                                                End If
                                            Else
                                                If (txtSenhaFunc.Text <> txtSenhaFunc2.Text) Then
                                                    If (frmPrincipal.lbIdioma.Text = "Português") Then
                                                        MessageBox.Show("As Senhas devem ser iguais")
                                                        txtSenhaFunc2.Focus()
                                                    End If
                                                    If (frmPrincipal.lbIdioma.Text = "English") Then
                                                        MessageBox.Show("Passwords must be equal")
                                                        txtSenhaFunc2.Focus()
                                                    End If
                                                    If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                                        MessageBox.Show("Las contraseñas deben ser iguales")
                                                        txtSenhaFunc2.Focus()
                                                    End If
                                                Else
                                                    If (cmbNivelAcesso.Text) Is "" Then
                                                        If (frmPrincipal.lbIdioma.Text = "Português") Then
                                                            MessageBox.Show("O nível de acesso deve ser selecionado")
                                                            cmbNivelAcesso.Focus()
                                                        End If
                                                        If (frmPrincipal.lbIdioma.Text = "English") Then
                                                            MessageBox.Show("The access level must be selected")
                                                            cmbNivelAcesso.Focus()
                                                        End If
                                                        If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                                            MessageBox.Show("El nivel de acceso se debe seleccionar")
                                                            cmbNivelAcesso.Focus()
                                                        End If
                                                    Else

                                                        Dim x As String = MtxtDataCadFunc.Text

                                                        Dim y As String = x.Substring(x.Length - 4, 4)

                                                        txtAno.Text = y

                                                        Dim TestString As String = MtxtDataCadFunc.Text
                                                        Dim MidWords As String = Mid(TestString, 4, 2)
                                                        txtMes.Text = MidWords

                                                        If (txtNomeFunc.Text <> "" And MtxtDDDFunc.Text <> "" And cmbSexoFunc.Text <> "" And MtxtCPFFunc.Text <> "" And txtEndFunc.Text <> "" And txtCargoFunc.Text <> "" And txtLoginFunc.Text <> "" And txtSenhaFunc.Text <> "" And txtSenhaFunc2.Text <> "" And txtSenhaFunc.Text = txtSenhaFunc2.Text) Then

                                                            Conectar()
                                                            Cadastrar_Funcionario(txtNomeFunc.Text, MtxtDDDFunc.Text, MtxtTelFunc.Text, MtxtCelFunc.Text, txtEmailFunc.Text, cmbSexoFunc.Text, MtxtDataNascFunc.Text, MtxtCPFFunc.Text, MtxtDataCadFunc.Text, txtEndFunc.Text, txtNumFunc.Text, txtCidadeFunc.Text, cmbUFFunc.Text, txtBairroFunc.Text, MtxtCEPFunc.Text, txtCargoFunc.Text, txtLoginFunc.Text, txtSenhaFunc.Text, cmbNivelAcesso.Text, txtMes.Text, txtAno.Text)

                                                            txtNomeFunc.Text = Nothing
                                                            MtxtDDDFunc.Text = Nothing
                                                            MtxtTelFunc.Text = Nothing
                                                            MtxtCelFunc.Text = Nothing
                                                            txtEmailFunc.Text = Nothing
                                                            cmbSexoFunc.Text = Nothing
                                                            MtxtDataNascFunc.Text = Nothing
                                                            MtxtCPFFunc.Text = Nothing
                                                            MtxtDataCadFunc.Text = Nothing
                                                            txtEndFunc.Text = Nothing
                                                            txtNumFunc.Text = Nothing
                                                            txtCidadeFunc.Text = Nothing
                                                            cmbUFFunc.Text = Nothing
                                                            txtBairroFunc.Text = Nothing
                                                            MtxtCEPFunc.Text = Nothing
                                                            txtCargoFunc.Text = Nothing
                                                            txtLoginFunc.Text = Nothing
                                                            txtSenhaFunc.Text = Nothing
                                                            txtSenhaFunc2.Text = Nothing
                                                            cmbNivelAcesso.Text = Nothing

                                                            If (frmPrincipal.lbIdioma.Text = "Português") Then
                                                                MessageBox.Show("Cadastre um novo funcionário ou pressione o botão cancelar para realizar outra tarefa")
                                                            End If
                                                            If (frmPrincipal.lbIdioma.Text = "English") Then
                                                                MessageBox.Show("Register a new employee or press the cancel button to perform another task")
                                                            End If
                                                            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                                                MessageBox.Show("Registrar un nuevo empleado o pulse el botón de cancelación para realizar otra tarea")
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                    End If
                End If
            End If

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
End Class