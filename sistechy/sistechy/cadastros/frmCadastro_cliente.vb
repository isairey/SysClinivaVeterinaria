Public Class frmCadastro_cliente


    Private Sub frmCadastro_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (frmPrincipal.lbIdioma.Text = "Português") Then

            cmbSexoCli.Items.Add("Masculino")
            cmbSexoCli.Items.Add("Feminino")

        End If

        If (frmPrincipal.lbIdioma.Text = "English") Then

            Me.Text = "Records of customer"

            lbNomeCli.Text = "Name(*)"
            lbTelefoneCli.Text = "Phone(*)"
            lbCelularCli.Text = "Cellphone"
            lbSexoCli.Text = "Sex(*)"
            lbDataNascCli.Text = "Date of birth"
            lbDataCadCli.Text = "Date of registration"
            lbEnderecoCli.Text = "Adress(*)"
            lbNumeroCli.Text = "Number"
            lbCidadeCli.Text = "City"
            lbBairroCli.Text = "Neighborhood"
            lbObrigatoriedade.Text = "Fields with (*) are mandatory"

            cmbSexoCli.Items.Add("Male")
            cmbSexoCli.Items.Add("Female")

            Me.btnCancelar.BackgroundImage = My.Resources.cancelar_english_fw
            Me.btnCadastraCli.BackgroundImage = My.Resources.salva_cadastro_english_fw

        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Registro del cliente"

            lbNomeCli.Text = "Nombre"
            lbTelefoneCli.Text = "Teléfono"
            lbCelularCli.Text = "Teléfono celular"
            lbSexoCli.Text = "Sexo"
            lbDataNascCli.Text = "Fecha de nacimiento"
            lbDataCadCli.Text = "Fecha de registro"
            lbEnderecoCli.Text = "Dirección"
            lbNumeroCli.Text = "Número"
            lbCidadeCli.Text = "Ciudad"
            lbBairroCli.Text = "Barrio"
            lbObrigatoriedade.Text = "Los campos con (*) son obligatorios"

            cmbSexoCli.Items.Add("Masculino")
            cmbSexoCli.Items.Add("Femenino")

            Me.btnCancelar.BackgroundImage = My.Resources.cancelar_spanish_fw
            Me.btnCadastraCli.BackgroundImage = My.Resources.salva_cadastro_spanish_fw

        End If

        cmbUFcli.Items.Add("AC")
        cmbUFcli.Items.Add("AL")
        cmbUFcli.Items.Add("AM")
        cmbUFcli.Items.Add("AP")
        cmbUFcli.Items.Add("BA")
        cmbUFcli.Items.Add("CE")
        cmbUFcli.Items.Add("DF")
        cmbUFcli.Items.Add("ES")
        cmbUFcli.Items.Add("GO")
        cmbUFcli.Items.Add("MA")
        cmbUFcli.Items.Add("MG")
        cmbUFcli.Items.Add("MS")
        cmbUFcli.Items.Add("MT")
        cmbUFcli.Items.Add("PA")
        cmbUFcli.Items.Add("PB")
        cmbUFcli.Items.Add("PE")
        cmbUFcli.Items.Add("PI")
        cmbUFcli.Items.Add("PR")
        cmbUFcli.Items.Add("RJ")
        cmbUFcli.Items.Add("RN")
        cmbUFcli.Items.Add("RS")
        cmbUFcli.Items.Add("RO")
        cmbUFcli.Items.Add("RR")
        cmbUFcli.Items.Add("SC")
        cmbUFcli.Items.Add("SE")
        cmbUFcli.Items.Add("SP")
        cmbUFcli.Items.Add("TO")

    End Sub

    Private Sub btnCadastraCli_Click(sender As Object, e As EventArgs) Handles btnCadastraCli.Click

        If (txtNomeCli.Text) Is "" Then
            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("O campo Nome não pode ficar vazio")
                txtNomeCli.Focus()
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("The Name field can not be empty")
                txtNomeCli.Focus()
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("El campo Nombre no puede estar vacío")
                txtNomeCli.Focus()
            End If
        Else
            If Not (MtxtDDDCli.MaskFull) Then
                If (frmPrincipal.lbIdioma.Text = "Português") Then
                    MessageBox.Show("O campo DDD não pode ficar vazio")
                    MtxtDDDCli.Focus()
                End If
                If (frmPrincipal.lbIdioma.Text = "English") Then
                    MessageBox.Show("The DDD field can not be empty")
                    MtxtDDDCli.Focus()
                End If
                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                    MessageBox.Show("El campo DDD no puede estar vacío")
                    MtxtDDDCli.Focus()
                End If
            Else
                If Not (MtxtTelCli.MaskFull) Then
                    If (frmPrincipal.lbIdioma.Text = "Português") Then
                        MessageBox.Show("O campo Telefone não pode ficar vazio")
                        MtxtTelCli.Focus()
                    End If
                    If (frmPrincipal.lbIdioma.Text = "English") Then
                        MessageBox.Show("The Phone field can not be empty")
                        MtxtTelCli.Focus()
                    End If
                    If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                        MessageBox.Show("El campo teléfono no puede estar vacío")
                        MtxtTelCli.Focus()
                    End If
                Else
                    If (cmbSexoCli.Text) Is "" Then
                        If (frmPrincipal.lbIdioma.Text = "Português") Then
                            MessageBox.Show("O campo Sexo não pode ficar vazio")
                            cmbSexoCli.Focus()
                        End If
                        If (frmPrincipal.lbIdioma.Text = "English") Then
                            MessageBox.Show("The sex field can not be empty")
                            cmbSexoCli.Focus()
                        End If
                        If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                            MessageBox.Show("El campo del sexo no puede estar vacío")
                            cmbSexoCli.Focus()
                        End If
                    Else
                        If Not (MtxtCPFCli.MaskFull) Then
                            If (frmPrincipal.lbIdioma.Text = "Português") Then
                                MessageBox.Show("O campo CPF não pode ficar vazio")
                                MtxtCPFCli.Focus()
                            End If
                            If (frmPrincipal.lbIdioma.Text = "English") Then
                                MessageBox.Show("The CPF field can not be empty")
                                MtxtCPFCli.Focus()
                            End If
                            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                MessageBox.Show("El campo del CPF no puede estar vacío")
                                MtxtCPFCli.Focus()
                            End If
                        Else
                            If Not (MtxtDataCadCli.MaskFull) Then
                                If (frmPrincipal.lbIdioma.Text = "Português") Then
                                    MessageBox.Show("O campo Data de Cadastro não pode ficar vazio")
                                    MtxtDataCadCli.Focus()
                                End If
                                If (frmPrincipal.lbIdioma.Text = "English") Then
                                    MessageBox.Show("The Registration Date field can not be empty")
                                    MtxtDataCadCli.Focus()
                                End If
                                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                    MessageBox.Show("El campo Fecha de Registro no puede estar vacío")
                                    MtxtDataCadCli.Focus()
                                End If
                            Else
                                If (txtEndCli.Text) Is "" Then
                                    If (frmPrincipal.lbIdioma.Text = "Português") Then
                                        MessageBox.Show("O campo Endereço não pode ficar vazio")
                                        txtEndCli.Focus()
                                    End If
                                    If (frmPrincipal.lbIdioma.Text = "English") Then
                                        MessageBox.Show("The address field can not be empty")
                                        txtEndCli.Focus()
                                    End If
                                    If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                        MessageBox.Show("El campo de dirección no puede estar vacío")
                                        txtEndCli.Focus()
                                    End If
                                Else

                                    Dim x As String = MtxtDataCadCli.Text

                                    Dim y As String = x.Substring(x.Length - 4, 4)

                                    txtAno.Text = y

                                    Dim TestString As String = MtxtDataCadCli.Text
                                    Dim MidWords As String = Mid(TestString, 4, 2)
                                    txtMes.Text = MidWords


                                    If (txtNomeCli.Text <> "" And MtxtDDDCli.Text <> "" And MtxtTelCli.Text <> "" And cmbSexoCli.Text <> "" And MtxtCPFCli.Text <> "" And txtEndCli.Text <> "") Then

                                        Conectar()
                                        Cadastrar_Cliente(txtNomeCli.Text, MtxtDDDCli.Text, MtxtTelCli.Text, MtxtCelCli.Text, txtEmailCli.Text, cmbSexoCli.Text, MtxtDataNascCli.Text, MtxtCPFCli.Text, txtRGCli.Text, MtxtDataCadCli.Text, txtEndCli.Text, txtNumCli.Text, txtCidadeCli.Text, cmbUFcli.Text, txtBairroCli.Text, MtxtCEPCli.Text, txtMes.Text, txtAno.Text)

                                        txtNomeCli.Text = Nothing
                                        MtxtDDDCli.Text = Nothing
                                        MtxtTelCli.Text = Nothing
                                        MtxtCelCli.Text = Nothing
                                        txtEmailCli.Text = Nothing
                                        cmbSexoCli.Text = Nothing
                                        MtxtDataNascCli.Text = Nothing
                                        MtxtCPFCli.Text = Nothing
                                        txtRGCli.Text = Nothing
                                        MtxtDataCadCli.Text = Nothing
                                        txtEndCli.Text = Nothing
                                        txtNumCli.Text = Nothing
                                        txtCidadeCli.Text = Nothing
                                        cmbUFcli.Text = Nothing
                                        txtBairroCli.Text = Nothing
                                        MtxtCPFCli.Text = Nothing
                                        MtxtCEPCli.Text = Nothing

                                        If (frmPrincipal.lbIdioma.Text = "Português") Then
                                            MessageBox.Show("Cadastre um novo cliente ou pressione o botão cancelar para realizar outra tarefa")
                                        End If
                                        If (frmPrincipal.lbIdioma.Text = "English") Then
                                            MessageBox.Show("Register a new account or press the cancel button to perform another task")
                                        End If
                                        If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                            MessageBox.Show("Registrar una cuenta nueva o pulse el botón de cancelación para realizar otra tarea")
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