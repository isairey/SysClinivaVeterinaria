Public Class frmCadastro_Fornecedor

    Private Sub frmCadastro_Fornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbUFForne.Items.Add("AC")
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

    Private Sub btnCadastraForne_Click(sender As Object, e As EventArgs) Handles btnCadastraForne.Click

        If (txtNomeFantForne.Text) Is "" Then
            MessageBox.Show("O campo Nome Fantasia não pode ficar vazio")
            txtNomeFantForne.Focus()
        Else

            If Not (MtxtCNPJForne.Text) Is "" Then
                MessageBox.Show("O campo CNPJ não pode ficar vazio")
                MtxtCNPJForne.Focus()
            Else

                If Not (MtxtDDDForne.Text) Is "" Then
                    MessageBox.Show("O campo DDD não pode ficar vazio")
                    MtxtDDDForne.Focus()
                Else

                    If Not (MtxtTelForne.Text) Is "" Then
                        MessageBox.Show("O campo Telefone não pode ficar vazio")
                        MtxtTelForne.Focus()
                    Else
                        If (cmbUFForne.Text) Is "" Then
                            MessageBox.Show("O campo UF não pode ficar vazio")
                            cmbUFForne.Focus()
                        End If
                    End If
                End If
            End If
        End If

        If (txtNomeFantForne.Text <> "" And MtxtCNPJForne.Text <> "" And MtxtTelForne.Text <> "") Then

            Conectar()
            Cadastrar_Fornecedor(txtNomeFantForne.Text, txtRazaoSocialForne.Text, MtxtCNPJForne.Text, MtxtDDDForne.Text, MtxtTelForne.Text, txtEmailForne.Text, txtEndForne.Text, txtBairroForne.Text, txtNumForne.Text, txtCidadeForne.Text, cmbUFForne.Text)
        End If

    End Sub

End Class