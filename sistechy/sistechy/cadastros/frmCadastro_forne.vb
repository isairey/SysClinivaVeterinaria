Public Class frmCadastro_forne

    Private Sub frmCadastro_forne_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (frmPrincipal.lbIdioma.Text = "English") Then

            Me.Text = "Vendor registration"

            lbNomeFantasia.Text = "Fancy name(*)"
            lbRazaoSocial.Text = "Corporate name"
            lbTelefoneForne.Text = "Phone(*)"
            lbEnderecoForne.Text = "Adress"
            lbBairroForne.Text = "Neighborhood"
            lbNumeroForne.Text = "Number"
            lbCidadeForne.Text = "City"
            lbObrigatoriedade.Text = "Fields with (*) are mandatory"

            Me.pbxBanner.BackgroundImage = My.Resources.banner_cadastro_fornecedor_english_fw
            Me.btnCancelar.BackgroundImage = My.Resources.cancelar_english_fw
            Me.btnCadastraForne.BackgroundImage = My.Resources.salva_cadastro_english_fw

        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Registro de proveedores"

            lbNomeFantasia.Text = "Nombre Fantasía(*)"
            lbRazaoSocial.Text = "Nombre social"
            lbTelefoneForne.Text = "Teléfono(*)"
            lbEnderecoForne.Text = "Dirección"
            lbBairroForne.Text = "Barrio"
            lbNumeroForne.Text = "Número"
            lbCidadeForne.Text = "Ciudad"
            lbObrigatoriedade.Text = "Los campos con (*) son obligatorios"

            Me.pbxBanner.BackgroundImage = My.Resources.banner_cadastro_fornecedor_spanish_fw
            Me.btnCancelar.BackgroundImage = My.Resources.cancelar_spanish_fw
            Me.btnCadastraForne.BackgroundImage = My.Resources.salva_cadastro_spanish_fw

        End If

        cmbUFforne.Items.Add("AC")
        cmbUFForne.Items.Add("AL")
        cmbUFForne.Items.Add("AM")
        cmbUFForne.Items.Add("AP")
        cmbUFForne.Items.Add("BA")
        cmbUFForne.Items.Add("CE")
        cmbUFForne.Items.Add("DF")
        cmbUFForne.Items.Add("ES")
        cmbUFForne.Items.Add("GO")
        cmbUFForne.Items.Add("MA")
        cmbUFForne.Items.Add("MG")
        cmbUFForne.Items.Add("MS")
        cmbUFForne.Items.Add("MT")
        cmbUFForne.Items.Add("PA")
        cmbUFForne.Items.Add("PB")
        cmbUFForne.Items.Add("PE")
        cmbUFForne.Items.Add("PI")
        cmbUFForne.Items.Add("PR")
        cmbUFForne.Items.Add("RJ")
        cmbUFForne.Items.Add("RN")
        cmbUFForne.Items.Add("RS")
        cmbUFForne.Items.Add("RO")
        cmbUFForne.Items.Add("RR")
        cmbUFForne.Items.Add("SC")
        cmbUFForne.Items.Add("SE")
        cmbUFForne.Items.Add("SP")
        cmbUFForne.Items.Add("TO")

    End Sub

    Private Sub btnCadastraCli_Click(sender As Object, e As EventArgs) Handles btnCadastraForne.Click

        If (txtNomeFantForne.Text) Is "" Then
            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("O campo Nome Fantasia não pode ficar vazio")
                txtNomeFantForne.Focus()
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("The Fantasy Name field can not be empty")
                txtNomeFantForne.Focus()
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("El campo de la fantasía Nombre no puede estar vacío")
                txtNomeFantForne.Focus()
            End If
        Else
            If (txtCNPJForne.Text) Is "" Then
                If (frmPrincipal.lbIdioma.Text = "Português") Then
                    MessageBox.Show("O campo CNPJ não pode ficar vazio")
                    txtCNPJForne.Focus()
                End If
                If (frmPrincipal.lbIdioma.Text = "English") Then
                    MessageBox.Show("The CNPJ field can not be empty")
                    txtCNPJForne.Focus()
                End If
                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                    MessageBox.Show("El campo CNPJ no puede estar vacío")
                    txtCNPJForne.Focus()
                End If
            Else
                If Not (MtxtDDDForne.MaskFull) Then
                    If (frmPrincipal.lbIdioma.Text = "Português") Then
                        MessageBox.Show("O campo DDD não pode ficar vazio")
                        MtxtDDDForne.Focus()
                    End If
                    If (frmPrincipal.lbIdioma.Text = "English") Then
                        MessageBox.Show("The DDD field can not be empty")
                        MtxtDDDForne.Focus()
                    End If
                    If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                        MessageBox.Show("El campo DDD no puede estar vacío")
                        MtxtDDDForne.Focus()
                    End If
                Else
                    If Not (MtxtTelForne.MaskFull) Then
                        If (frmPrincipal.lbIdioma.Text = "Português") Then
                            MessageBox.Show("O campo Telefone não pode ficar vazio")
                            MtxtTelForne.Focus()
                        End If
                        If (frmPrincipal.lbIdioma.Text = "English") Then
                            MessageBox.Show("The Phone field can not be empty")
                            MtxtTelForne.Focus()
                        End If
                        If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                            MessageBox.Show("El campo teléfono no puede estar vacío")
                            MtxtTelForne.Focus()
                        End If
                    Else


                        If (txtNomeFantForne.Text <> "" And txtCNPJForne.Text <> "" And MtxtDDDForne.Text <> "" And MtxtTelForne.Text <> "") Then

                            Conectar()
                            Cadastrar_Fornecedor(txtNomeFantForne.Text, txtRazaoSocialForne.Text, txtCNPJForne.Text, MtxtDDDForne.Text, MtxtTelForne.Text, txtEmailForne.Text, txtEndForne.Text, txtBairroForne.Text, txtNumForne.Text, txtCidadeForne.Text, cmbUFForne.Text)

                            txtNomeFantForne.Text = Nothing
                            txtRazaoSocialForne.Text = Nothing
                            txtCNPJForne.Text = Nothing
                            MtxtDDDForne.Text = Nothing
                            MtxtTelForne.Text = Nothing
                            txtEmailForne.Text = Nothing
                            txtEndForne.Text = Nothing
                            txtBairroForne.Text = Nothing
                            txtNumForne.Text = Nothing
                            txtCidadeForne.Text = Nothing
                            cmbUFForne.Text = Nothing

                            If (frmPrincipal.lbIdioma.Text = "Português") Then
                                MessageBox.Show("Cadastre um novo fornecedor ou pressione o botão cancelar para realizar outra tarefa")
                            End If
                            If (frmPrincipal.lbIdioma.Text = "English") Then
                                MessageBox.Show("Register a new supplier or press the cancel button to perform another task")
                            End If
                            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                MessageBox.Show("Registrar un nuevo proveedor o pulse el botón de cancelación para realizar otra tarea")
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