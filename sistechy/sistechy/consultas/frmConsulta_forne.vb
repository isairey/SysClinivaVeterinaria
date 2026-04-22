Public Class frmConsulta_forne

    Private Sub limpacamposfornecedor()

        dgvForne.DataSource = Nothing
        txtCodForne.Text = Nothing
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

    End Sub

    Private Sub bloqueiacampos()

        txtCodForne.Enabled = False
        txtNomeFantForne.Enabled = False
        txtRazaoSocialForne.Enabled = False
        txtCNPJForne.Enabled = False
        MtxtDDDForne.Enabled = False
        MtxtTelForne.Enabled = False
        txtEmailForne.Enabled = False
        txtEndForne.Enabled = False
        txtBairroForne.Enabled = False
        txtNumForne.Enabled = False
        txtCidadeForne.Enabled = False
        cmbUFForne.Enabled = False

    End Sub

    Private Sub frmConsulta_forne_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (frmPrincipal.lbIdioma.Text = "Português") Then

            cmbFiltro.Items.Add("Código")
            cmbFiltro.Items.Add("Nome fantasia")
            cmbFiltro.Items.Add("CNPJ")

        End If

        If (frmPrincipal.lbIdioma.Text = "English") Then

            Me.Text = "Consult supplier"

            lbBuscarPor.Text = "Search by: "
            lbCod.Text = "ID"
            lbNomeFantasia.Text = "Fancy name"
            lbRazaoSocial.Text = "Corporate name"
            lbTelefone.Text = "Phone"
            lbEndereco.Text = "Adress"
            lbBairro.Text = "Neighborhood"
            lbNumero.Text = "Number"
            lbCidade.Text = "City"

            Me.btnBuscar.Text = "Search"

            Me.btnCancelar.BackgroundImage = My.Resources.cancelar_english_fw
            Me.btnExcluir.BackgroundImage = My.Resources.excluir_dados_english_fw
            Me.btnAtualizar.BackgroundImage = My.Resources.atualizar_dados_english_fw
            Me.btnConfirmar.BackgroundImage = My.Resources.salva_alteracoes_english_fw

            Me.pbxBanner.BackgroundImage = My.Resources.banner_consulta_fornecedor_english_fw

            cmbFiltro.Items.Add("ID")
            cmbFiltro.Items.Add("Fancy name")
            cmbFiltro.Items.Add("CNPJ")

        End If


        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Consultar con proveedor"

            lbBuscarPor.Text = "Buscar por: "
            lbCod.Text = "ID"
            lbNomeFantasia.Text = "Nombre de Fantasía"
            lbRazaoSocial.Text = "Nombre social"
            lbTelefone.Text = "Teléfono"
            lbEndereco.Text = "Dirección"
            lbBairro.Text = "Barrio"
            lbNumero.Text = "Número"
            lbCidade.Text = "Ciudad"

            Me.btnBuscar.Text = "Buscar"

            Me.btnCancelar.BackgroundImage = My.Resources.cancelar_spanish_fw
            Me.btnExcluir.BackgroundImage = My.Resources.excluir_dados_spanish_fw
            Me.btnAtualizar.BackgroundImage = My.Resources.atualizar_dados_spanish_fw
            Me.btnConfirmar.BackgroundImage = My.Resources.salva_alteracoes_spanish_fw

            Me.pbxBanner.BackgroundImage = My.Resources.banner_consulta_fornecedor_spanish_fw

            cmbFiltro.Items.Add("ID")
            cmbFiltro.Items.Add("Nombre de Fantasía")
            cmbFiltro.Items.Add("CNPJ")

        End If

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


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        limpacamposfornecedor()
        Conectar()

        If cmbFiltro.Text = "Código" Then
            dgvForne.DataSource = Consulta_fornecedor_codigo(txtConsultaForne.Text)
        End If

        If cmbFiltro.Text = "Nome fantasia" Or cmbFiltro.Text = "Nombre de Fantasía" Then
            dgvForne.DataSource = Consulta_fornecedor_nome(txtConsultaForne.Text)
        End If

        If cmbFiltro.Text = "CNPJ" Then
            dgvForne.DataSource = Consulta_fornecedor_CNPJ(txtConsultaForne.Text)
        End If

    End Sub

    Private Sub dgvForne_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvForne.CellClick

        Dim i As Integer
        i = dgvForne.CurrentRow.Index
        Me.txtCodForne.Text = dgvForne.Item(0, i).Value
        Me.txtNomeFantForne.Text = dgvForne.Item(2, i).Value
        Me.txtRazaoSocialForne.Text = dgvForne.Item(3, i).Value
        Me.txtCNPJForne.Text = dgvForne.Item(4, i).Value
        Me.MtxtDDDForne.Text = dgvForne.Item(5, i).Value
        Me.MtxtTelForne.Text = dgvForne.Item(6, i).Value
        Me.txtEmailForne.Text = dgvForne.Item(7, i).Value
        Me.txtEndForne.Text = dgvForne.Item(8, i).Value
        Me.txtBairroForne.Text = dgvForne.Item(9, i).Value
        Me.txtNumForne.Text = dgvForne.Item(10, i).Value
        Me.txtCidadeForne.Text = dgvForne.Item(11, i).Value
        Me.cmbUFForne.Text = dgvForne.Item(12, i).Value

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

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If Not dgvForne.DataSource Is Nothing Then

            Dim message_portugues As Integer
            Dim message_english As Integer
            Dim message_spanish As Integer

            If (frmPrincipal.lbIdioma.Text = "Português") Then
                message_portugues = MessageBox.Show("Confirma a exclusão deste fornecedor ?", _
                                          "Confirma Exclusão ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                message_portugues = MessageBox.Show("Confirms the exclusion of this supplier ?", _
                                          "Really delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                message_portugues = MessageBox.Show("Confirma la exclusión de este proveedor ?", _
                                          "Confirma Exclusión ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If

            If message_portugues = vbYes Or message_english = vbYes Or message_spanish = vbYes Then

                Exclui_fornecedor_codigo(txtCodForne.Text)

                txtConsultaForne.Text = Nothing
                dgvForne.DataSource = Nothing
                txtCodForne.Text = Nothing
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

                bloqueiacampos()

                If (frmPrincipal.lbIdioma.Text = "Português") Then
                    MessageBox.Show("Fornecedor excluído com sucesso!")
                End If
                If (frmPrincipal.lbIdioma.Text = "English") Then
                    MessageBox.Show("Supplier deleted successfully!")
                End If
                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                    MessageBox.Show("Proveedor eliminado correctamente!")
                End If
            End If
        End If
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click

        If txtCodForne.Text <> Nothing Then

            txtConsultaForne.Text = Nothing
            txtNomeFantForne.Enabled = True
            txtRazaoSocialForne.Enabled = True
            txtCNPJForne.Enabled = True
            MtxtDDDForne.Enabled = True
            MtxtTelForne.Enabled = True
            txtEmailForne.Enabled = True
            txtEndForne.Enabled = True
            txtBairroForne.Enabled = True
            txtNumForne.Enabled = True
            txtCidadeForne.Enabled = True
            cmbUFForne.Enabled = True

        Else
            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("Selecione um fornecedor para alterar seus dados!")
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("Select a vendor to change your data!")
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("Seleccione un proveedor para cambiar sus datos!")
            End If
        End If
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click

        Conectar()

        If txtCodForne.Text <> Nothing Then

            comando.Parameters.Clear()
            comando.CommandText = "update fornecedor set nomefantasia_forne =@nomefantasia_forne, razaosocial_forne =@razaosocial_forne, CNPJ_forne =@CNPJ_forne, ddd_forne =@ddd_forne, telefone_forne =@telefone_forne, email_forne =@email_forne, endereco_forne =@endereco_forne, bairro_forne =@bairro_forne, numeroendereco_forne =@numeroendereco_forne, cidade_forne =@cidade_forne, UF_forne = @UF_forne where cod_forne = @cod_forne"
            comando.Parameters.AddWithValue("@cod_forne", txtCodForne.Text)
            comando.Parameters.AddWithValue("@nomefantasia_forne", txtNomeFantForne.Text)
            comando.Parameters.AddWithValue("@razaosocial_forne", txtRazaoSocialForne.Text)
            comando.Parameters.AddWithValue("@CNPJ_forne", txtCNPJForne.Text)
            comando.Parameters.AddWithValue("@ddd_forne", MtxtDDDForne.Text)
            comando.Parameters.AddWithValue("@telefone_forne", MtxtTelForne.Text)
            comando.Parameters.AddWithValue("@email_forne", txtEmailForne.Text)
            comando.Parameters.AddWithValue("@endereco_forne", txtEndForne.Text)
            comando.Parameters.AddWithValue("@bairro_forne", txtBairroForne.Text)
            comando.Parameters.AddWithValue("@numeroendereco_forne", txtNumForne.Text)
            comando.Parameters.AddWithValue("@cidade_forne", txtCidadeForne.Text)
            comando.Parameters.AddWithValue("@UF_forne", cmbUFForne.Text)


            comando.ExecuteNonQuery()
            Desconectar()

            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("Dados do fornecedor alterados com sucesso!")
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("Supplier data changed successfully!")
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("Proveedor de datos cambian con éxito!")
            End If

            txtCodForne.Text = Nothing
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
            dgvForne.DataSource = Nothing
            txtConsultaForne.Text = Nothing
            cmbFiltro.Text = Nothing

            bloqueiacampos()

            limpafiltros()

        Else
            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("Selecione um fornecedor para alterar seus dados!")
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("Select a vendor to change your data!")
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("Seleccione un proveedor para cambiar sus datos!")
            End If
        End If

    End Sub

    Private Sub limpafiltros()

        txtConsultaForne.Visible = False
        btnBuscar.Visible = False

    End Sub

    Private Sub cmbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltro.SelectedIndexChanged

        limpacamposfornecedor()
        txtConsultaForne.Text = Nothing

        If cmbFiltro.Text = "Código" Or cmbFiltro.Text = "Nome fantasia" Or cmbFiltro.Text = "Fancy name" Or cmbFiltro.Text = "CNPJ" Then

            limpafiltros()
            txtConsultaForne.Visible = True

        End If

        btnBuscar.Visible = True

    End Sub
End Class