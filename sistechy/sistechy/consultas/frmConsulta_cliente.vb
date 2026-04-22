Imports System.Data.SqlClient

Public Class frmConsulta_cliente

    Private Sub limpacamposcliente()

        dgvCli.DataSource = Nothing
        txtCodCli.Text = Nothing
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
        cmbUFCli.Text = Nothing
        txtBairroCli.Text = Nothing
        MtxtCEPCli.Text = Nothing

    End Sub

    Private Sub bloqueiacampos()

        txtCodCli.Enabled = False
        txtNomeCli.Enabled = False
        MtxtDDDCli.Enabled = False
        MtxtTelCli.Enabled = False
        MtxtCelCli.Enabled = False
        txtEmailCli.Enabled = False
        cmbSexoCli.Enabled = False
        MtxtDataNascCli.Enabled = False
        MtxtCPFCli.Enabled = False
        txtRGCli.Enabled = False
        MtxtDataCadCli.Enabled = False
        txtEndCli.Enabled = False
        txtNumCli.Enabled = False
        txtCidadeCli.Enabled = False
        cmbUFCli.Enabled = False
        txtBairroCli.Enabled = False
        MtxtCEPCli.Enabled = False

    End Sub

    Private Sub frmConsulta_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (frmPrincipal.lbIdioma.Text = "Português") Then

            cmbSexoCli.Items.Add("Masculino")
            cmbSexoCli.Items.Add("Feminino")

            cmbFiltro.Items.Add("Código")
            cmbFiltro.Items.Add("Nome")
            cmbFiltro.Items.Add("CPF")
            cmbFiltro.Items.Add("Data de cadastro")

        End If

        If (frmPrincipal.lbIdioma.Text = "English") Then

            Me.Text = "Client query"

            gpxPesquisa.Text = "Survey data"
            gpxCliente.Text = "Client data"

            lbBuscarPor.Text = "Search by: "
            lbCod.Text = "ID"
            lbNome.Text = "Name"
            lbTelefone.Text = "Phone"
            lbCelular.Text = "Cellphone"
            lbSexo.Text = "Sex"
            lbDataNasc.Text = "Date of birth"
            lbDataCad.Text = "Date of registration"
            lbEndereco.Text = "Adress"
            lbNumero.Text = "Number"
            lbCidade.Text = "City"
            lbBairro.Text = "Neighborhood"

            Me.btnBuscar.Text = "Search"

            Me.btnCancelar.BackgroundImage = My.Resources.cancelar_english_fw
            Me.btnExcluir.BackgroundImage = My.Resources.excluir_dados_english_fw
            Me.btnAtualizar.BackgroundImage = My.Resources.atualizar_dados_english_fw
            Me.btnConfirmar.BackgroundImage = My.Resources.salva_alteracoes_english_fw

            Me.pbxBanner.BackgroundImage = My.Resources.banner_consulta_cliente_english_fw

            cmbSexoCli.Items.Add("Male")
            cmbSexoCli.Items.Add("Female")

            cmbFiltro.Items.Add("ID")
            cmbFiltro.Items.Add("Name")
            cmbFiltro.Items.Add("CPF")
            cmbFiltro.Items.Add("Date of registration")

        End If


        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Consulta de cliente"

            gpxPesquisa.Text = "Datos de la encuesta"
            gpxCliente.Text = "Datos de cliente"

            lbBuscarPor.Text = "Buscar por: "
            lbCod.Text = "ID"
            lbNome.Text = "Nombre"
            lbTelefone.Text = "Teléfono"
            lbCelular.Text = "Teléfono celular"
            lbSexo.Text = "Sexo"
            lbDataNasc.Text = "Fecha de nacimiento"
            lbDataCad.Text = "Fecha de registro"
            lbEndereco.Text = "Dirección"
            lbNumero.Text = "Número"
            lbCidade.Text = "Ciudad"
            lbBairro.Text = "Barrio"

            Me.btnBuscar.Text = "Buscar"

            Me.btnCancelar.BackgroundImage = My.Resources.cancelar_spanish_fw
            Me.btnExcluir.BackgroundImage = My.Resources.excluir_dados_spanish_fw
            Me.btnAtualizar.BackgroundImage = My.Resources.atualizar_dados_spanish_fw
            Me.btnConfirmar.BackgroundImage = My.Resources.salva_alteracoes_spanish_fw

            Me.pbxBanner.BackgroundImage = My.Resources.banner_consulta_cliente_spanish_fw

            cmbSexoCli.Items.Add("Masculino")
            cmbSexoCli.Items.Add("Femenino")

            cmbFiltro.Items.Add("ID")
            cmbFiltro.Items.Add("Nombre")
            cmbFiltro.Items.Add("CPF")
            cmbFiltro.Items.Add("Fecha de registro")

        End If

        cmbUFCli.Items.Add("AC")
        cmbufcli.Items.Add("AL")
        cmbufcli.Items.Add("AM")
        cmbufcli.Items.Add("AP")
        cmbufcli.Items.Add("BA")
        cmbufcli.Items.Add("CE")
        cmbufcli.Items.Add("DF")
        cmbufcli.Items.Add("ES")
        cmbufcli.Items.Add("GO")
        cmbufcli.Items.Add("MA")
        cmbufcli.Items.Add("MG")
        cmbufcli.Items.Add("MS")
        cmbufcli.Items.Add("MT")
        cmbufcli.Items.Add("PA")
        cmbufcli.Items.Add("PB")
        cmbufcli.Items.Add("PE")
        cmbufcli.Items.Add("PI")
        cmbufcli.Items.Add("PR")
        cmbufcli.Items.Add("RJ")
        cmbufcli.Items.Add("RN")
        cmbufcli.Items.Add("RS")
        cmbufcli.Items.Add("RO")
        cmbufcli.Items.Add("RR")
        cmbufcli.Items.Add("SC")
        cmbufcli.Items.Add("SE")
        cmbufcli.Items.Add("SP")
        cmbUFCli.Items.Add("TO")

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        limpacamposcliente()
        Conectar()

        If cmbFiltro.Text = "Código" Or cmbFiltro.Text = "ID" Then
            dgvCli.DataSource = Consulta_cliente_codigo(txtConsultaCli.Text)
        End If

        If cmbFiltro.Text = "Nome" Or cmbFiltro.Text = "Name" Or cmbFiltro.Text = "Nombre" Then
            dgvCli.DataSource = Consulta_cliente_nome(txtConsultaCli.Text)
        End If

        If cmbFiltro.Text = "CPF" Then
            dgvCli.DataSource = Consulta_cliente_CPF(MtxtFiltroCPF.Text)
        End If

        If cmbFiltro.Text = "Data de cadastro" Or cmbFiltro.Text = "Date of registration" Or cmbFiltro.Text = "Fecha de registro" Then
            dgvCli.DataSource = Consulta_cliente_data(MtxtFiltroData.Text)
        End If

    End Sub

    Private Sub dgvCli_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCli.CellClick

        Dim i As Integer
        i = dgvCli.CurrentRow.Index
        Me.txtCodCli.Text = dgvCli.Item(0, i).Value
        Me.txtNomeCli.Text = dgvCli.Item(1, i).Value
        Me.MtxtDDDCli.Text = dgvCli.Item(2, i).Value
        Me.MtxtTelCli.Text = dgvCli.Item(3, i).Value
        Me.MtxtCelCli.Text = dgvCli.Item(4, i).Value
        Me.txtEmailCli.Text = dgvCli.Item(5, i).Value
        Me.cmbSexoCli.Text = dgvCli.Item(6, i).Value
        Me.MtxtDataNascCli.Text = dgvCli.Item(7, i).Value
        Me.MtxtCPFCli.Text = dgvCli.Item(8, i).Value
        Me.txtRGCli.Text = dgvCli.Item(9, i).Value
        Me.mtxtDataCadCli.Text = dgvCli.Item(10, i).Value
        Me.txtEndCli.Text = dgvCli.Item(11, i).Value
        Me.txtNumCli.Text = dgvCli.Item(12, i).Value
        Me.txtCidadeCli.Text = dgvCli.Item(13, i).Value
        Me.cmbUFCli.Text = dgvCli.Item(14, i).Value
        Me.txtBairroCli.Text = dgvCli.Item(15, i).Value
        Me.MtxtCEPCli.Text = dgvCli.Item(16, i).Value

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

        If Not dgvCli.DataSource Is Nothing Then

            Dim message_portugues As Integer
            Dim message_english As Integer
            Dim message_spanish As Integer

            If (frmPrincipal.lbIdioma.Text = "Português") Then
                message_portugues = MessageBox.Show("Confirma a exclusão deste cliente ?", _
                                          "Confirma Exclusão ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If

            If (frmPrincipal.lbIdioma.Text = "English") Then
                message_english = MessageBox.Show("Confirms the exclusion of this client ?", _
                                          "Really delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If

            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                message_spanish = MessageBox.Show("Confirma la exclusión de este cliente ?", _
                                          "Confirma Exclusión ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If

            If message_portugues = vbYes Or message_english = vbYes Or message_spanish = vbYes Then

                Exclui_cliente_codigo(txtCodCli.Text)

                txtConsultaCli.Text = Nothing
                MtxtFiltroCPF.Text = Nothing
                MtxtFiltroData.Text = Nothing
                dgvCli.DataSource = Nothing
                txtCodCli.Text = Nothing
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
                cmbUFCli.Text = Nothing
                txtBairroCli.Text = Nothing
                MtxtCEPCli.Text = Nothing

                bloqueiacampos()

                If (frmPrincipal.lbIdioma.Text = "Português") Then
                    MessageBox.Show("Cliente excluído com sucesso!")
                End If
                If (frmPrincipal.lbIdioma.Text = "English") Then
                    MessageBox.Show("Client successfully deleted!")
                End If
                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                    MessageBox.Show("Cliente eliminado correctamente!")
                End If
            End If
        End If
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click

        If txtCodCli.Text <> Nothing Then

            txtConsultaCli.Text = Nothing
            MtxtFiltroCPF.Text = Nothing
            MtxtFiltroData.Text = Nothing
            txtNomeCli.Enabled = True
            MtxtDDDCli.Enabled = True
            MtxtTelCli.Enabled = True
            MtxtCelCli.Enabled = True
            txtEmailCli.Enabled = True
            cmbSexoCli.Enabled = True
            MtxtDataNascCli.Enabled = True
            MtxtCPFCli.Enabled = True
            txtRGCli.Enabled = True
            MtxtDataCadCli.Enabled = True
            txtEndCli.Enabled = True
            txtNumCli.Enabled = True
            txtCidadeCli.Enabled = True
            cmbUFCli.Enabled = True
            txtBairroCli.Enabled = True
            MtxtCEPCli.Enabled = True

        Else
            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("Selecione um cliente para alterar seus dados!")
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("Select a client to change their data!")
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("Seleccione un cliente para cambiar sus datos!")
            End If
        End If

    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click

        Conectar()

        If txtCodCli.Text <> Nothing Then

            comando.Parameters.Clear()
            comando.CommandText = "update cliente set nome_cli= @nome_cli, ddd_cli= @ddd_cli, telefone_cli = @telefone_cli, celular_cli = @celular_cli, email_cli = @email_cli, sexo_cli = @sexo_cli, datanasc_cli = @datanasc_cli, CPF_cli = @CPF_cli, RG_cli = @RG_cli, cadastrodata_cli = @cadastrodata_cli, endereco_cli = @endereco_cli, numeroendereco_cli = @numeroendereco_cli, cidade_cli = @cidade_cli, UF_cli = @UF_cli, bairro_cli = @bairro_cli, cep_cli = @cep_cli where cod_cli= @cod_cli"
            comando.Parameters.AddWithValue("@cod_cli", txtCodCli.Text)
            comando.Parameters.AddWithValue("@nome_cli", txtNomeCli.Text)
            comando.Parameters.AddWithValue("@ddd_cli", MtxtDDDCli.Text)
            comando.Parameters.AddWithValue("@telefone_cli", MtxtTelCli.Text)
            comando.Parameters.AddWithValue("@celular_cli", MtxtCelCli.Text)
            comando.Parameters.AddWithValue("@email_cli", txtEmailCli.Text)
            comando.Parameters.AddWithValue("@sexo_cli", cmbSexoCli.Text)
            comando.Parameters.AddWithValue("@datanasc_cli", MtxtDataNascCli.Text)
            comando.Parameters.AddWithValue("@CPF_cli", MtxtCPFCli.Text)
            comando.Parameters.AddWithValue("@RG_cli", txtRGCli.Text)
            comando.Parameters.AddWithValue("@cadastrodata_cli", MtxtDataCadCli.Text)
            comando.Parameters.AddWithValue("@endereco_cli", txtEndCli.Text)
            comando.Parameters.AddWithValue("@numeroendereco_cli", txtNumCli.Text)
            comando.Parameters.AddWithValue("@cidade_cli", txtCidadeCli.Text)
            comando.Parameters.AddWithValue("@UF_cli", cmbUFCli.Text)
            comando.Parameters.AddWithValue("@bairro_cli", txtBairroCli.Text)
            comando.Parameters.AddWithValue("@cep_cli", MtxtCEPCli.Text)

            comando.ExecuteNonQuery()
            Desconectar()

            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("Dados do cliente alterados com sucess!")
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("Data from the client changed successfully!")
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("Los datos del cliente cambian con éxito!")
            End If

            txtCodCli.Text = Nothing
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
            cmbUFCli.Text = Nothing
            txtBairroCli.Text = Nothing
            MtxtCEPCli.Text = Nothing
            dgvCli.DataSource = Nothing
            txtConsultaCli.Text = Nothing
            MtxtFiltroData.Text = Nothing
            MtxtFiltroCPF.Text = Nothing
            cmbFiltro.Text = Nothing

            bloqueiacampos()

            limpafiltros()

        Else
            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("Selecione um cliente para alterar seus dados!")
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("Select a client to change their data!")
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("Seleccione un cliente para cambiar sus datos!")
            End If
        End If


    End Sub

    Private Sub limpafiltros()

        txtConsultaCli.Visible = False
        MtxtFiltroData.Visible = False
        MtxtFiltroCPF.Visible = False
        btnBuscar.Visible = False

    End Sub

    Private Sub cmbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltro.SelectedIndexChanged

        limpacamposcliente()

        txtConsultaCli.Text = Nothing
        MtxtFiltroCPF.Text = Nothing
        MtxtFiltroData.Text = Nothing

        If cmbFiltro.Text = "Código" Or cmbFiltro.Text = "ID" Or cmbFiltro.Text = "Nome" Or cmbFiltro.Text = "Name" Or cmbFiltro.Text = "Nombre" Then
            limpafiltros()
            txtConsultaCli.Visible = True
        End If

        If cmbFiltro.Text = "Data de cadastro" Or cmbFiltro.Text = "Date of registration" Or cmbFiltro.Text = "Fecha de registro" Then
            limpafiltros()
            MtxtFiltroData.Visible = True
        End If

        If cmbFiltro.Text = "CPF" Then
            limpafiltros()
            MtxtFiltroCPF.Visible = True
        End If

        btnBuscar.Visible = True

    End Sub
End Class