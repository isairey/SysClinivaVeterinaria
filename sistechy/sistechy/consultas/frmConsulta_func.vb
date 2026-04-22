Public Class frmConsulta_func

    Private Sub limpacamposfuncionario()

        dgvFunc.DataSource = Nothing
        txtCodFunc.Text = Nothing
        txtNomeFunc.Text = Nothing
        MtxtDDDFunc.Text = Nothing
        MtxtTelFunc.Text = Nothing
        MtxtCelFunc.Text = Nothing
        txtEmailFunc.Text = Nothing
        cmbSexoFunc.Text = Nothing
        MtxtDataNascfunc.Text = Nothing
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

    End Sub

    Private Sub bloqueiacampos()

        txtNomeFunc.Enabled = False
        MtxtDDDFunc.Enabled = False
        MtxtTelFunc.Enabled = False
        MtxtCelFunc.Enabled = False
        txtEmailFunc.Enabled = False
        cmbSexoFunc.Enabled = False
        MtxtDataNascfunc.Enabled = False
        MtxtCPFFunc.Enabled = False
        MtxtDataCadFunc.Enabled = False
        txtEndFunc.Enabled = False
        txtNumFunc.Enabled = False
        txtCidadeFunc.Enabled = False
        cmbUFFunc.Enabled = False
        txtBairroFunc.Enabled = False
        MtxtCEPFunc.Enabled = False
        txtCargoFunc.Enabled = False
        txtLoginFunc.Enabled = False

    End Sub

    Private Sub frmConsulta_func_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (frmPrincipal.lbIdioma.Text = "Português") Then

            cmbSexoFunc.Items.Add("Masculino")
            cmbSexoFunc.Items.Add("Feminino")

            cmbFiltro.Items.Add("Código")
            cmbFiltro.Items.Add("Nome")
            cmbFiltro.Items.Add("CPF")
            cmbFiltro.Items.Add("Data de cadastro")

        End If

        If (frmPrincipal.lbIdioma.Text = "English") Then

            Me.Text = "Employee consultation"

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
            lbCargo.Text = "Job title"
            lbLogin.Text = "Login"

            Me.btnBuscar.Text = "Search"

            Me.btnCancelar.BackgroundImage = My.Resources.cancelar_english_fw
            Me.btnExcluir.BackgroundImage = My.Resources.excluir_dados_english_fw
            Me.btnAtualizar.BackgroundImage = My.Resources.atualizar_dados_english_fw
            Me.btnConfirmar.BackgroundImage = My.Resources.salva_alteracoes_english_fw

            Me.pbxBanner.BackgroundImage = My.Resources.banner_consulta_funcionario_english_fw

            cmbSexoFunc.Items.Add("Male")
            cmbSexoFunc.Items.Add("Female")

            cmbFiltro.Items.Add("ID")
            cmbFiltro.Items.Add("Name")
            cmbFiltro.Items.Add("CPF")
            cmbFiltro.Items.Add("Date of registration")

        End If


        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Consulta del empleado"

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
            lbCargo.Text = "Título profesional"
            lbLogin.Text = "Login"

            Me.btnBuscar.Text = "Buscar"

            Me.btnCancelar.BackgroundImage = My.Resources.cancelar_spanish_fw
            Me.btnExcluir.BackgroundImage = My.Resources.excluir_dados_spanish_fw
            Me.btnAtualizar.BackgroundImage = My.Resources.atualizar_dados_spanish_fw
            Me.btnConfirmar.BackgroundImage = My.Resources.salva_alteracoes_spanish_fw

            Me.pbxBanner.BackgroundImage = My.Resources.banner_consulta_funcionario_spanish_fw

            cmbSexoFunc.Items.Add("Masculino")
            cmbSexoFunc.Items.Add("Femenino")

            cmbFiltro.Items.Add("ID")
            cmbFiltro.Items.Add("Nombre")
            cmbFiltro.Items.Add("CPF")
            cmbFiltro.Items.Add("Fecha de registro")

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

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        limpacamposfuncionario()
        Conectar()

        If cmbFiltro.Text = "Código" Or cmbFiltro.Text = "ID" Then
            dgvFunc.DataSource = Consulta_funcionario_codigo(txtConsultaFunc.Text)
        End If

        If cmbFiltro.Text = "Nome" Or cmbFiltro.Text = "Name" Or cmbFiltro.Text = "Nombre" Then
            dgvFunc.DataSource = Consulta_funcionario_nome(txtConsultaFunc.Text)
        End If

        If cmbFiltro.Text = "CPF" Then
            dgvFunc.DataSource = Consulta_funcionario_CPF(mtxtfiltrocpf.Text)
        End If

        If cmbFiltro.Text = "Data de cadastro" Or cmbFiltro.Text = "Date of registration" Or cmbFiltro.Text = "Fecha de registro" Then
            dgvFunc.DataSource = Consulta_funcionario_data(MtxtFiltroData.Text)
        End If

    End Sub

    Private Sub dgvFunc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFunc.CellClick

        Dim i As Integer
        i = dgvFunc.CurrentRow.Index
        Me.txtCodFunc.Text = dgvFunc.Item(0, i).Value
        Me.txtNomeFunc.Text = dgvFunc.Item(1, i).Value
        Me.MtxtDDDFunc.Text = dgvFunc.Item(2, i).Value
        Me.MtxtTelFunc.Text = dgvFunc.Item(3, i).Value
        Me.MtxtCelFunc.Text = dgvFunc.Item(4, i).Value
        Me.txtEmailFunc.Text = dgvFunc.Item(5, i).Value
        Me.cmbSexoFunc.Text = dgvFunc.Item(6, i).Value
        Me.MtxtDataNascfunc.Text = dgvFunc.Item(7, i).Value
        Me.MtxtCPFFunc.Text = dgvFunc.Item(8, i).Value
        Me.MtxtDataCadFunc.Text = dgvFunc.Item(9, i).Value
        Me.txtEndFunc.Text = dgvFunc.Item(10, i).Value
        Me.txtNumFunc.Text = dgvFunc.Item(11, i).Value
        Me.txtCidadeFunc.Text = dgvFunc.Item(12, i).Value
        Me.cmbUFFunc.Text = dgvFunc.Item(13, i).Value
        Me.txtBairroFunc.Text = dgvFunc.Item(14, i).Value
        Me.MtxtCEPFunc.Text = dgvFunc.Item(15, i).Value
        Me.txtCargoFunc.Text = dgvFunc.Item(16, i).Value
        Me.txtLoginFunc.Text = dgvFunc.Item(17, i).Value

    End Sub


    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If Not dgvFunc.DataSource Is Nothing Then

            Dim message_portugues As Integer
            Dim message_english As Integer
            Dim message_spanish As Integer

            If (frmPrincipal.lbIdioma.Text = "Português") Then
                message_portugues = MessageBox.Show("Confirma a exclusão deste funcionário ?", _
                                          "Confirma Exclusão ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If

            If (frmPrincipal.lbIdioma.Text = "English") Then
                message_english = MessageBox.Show("Confirms the exclusion of this employee ?", _
                                          "Really delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If

            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                message_spanish = MessageBox.Show("Confirma la exclusión de este empleado ?", _
                                          "Confirma Exclusión ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If

            If message_portugues = vbYes Or message_english = vbYes Then

                Exclui_funcionario_codigo(txtCodFunc.Text)

                txtConsultaFunc.Text = Nothing
                MtxtFiltroCPF.Text = Nothing
                MtxtFiltroData.Text = Nothing
                dgvFunc.DataSource = Nothing
                txtCodFunc.Text = Nothing
                txtNomeFunc.Text = Nothing
                MtxtDDDFunc.Text = Nothing
                MtxtTelFunc.Text = Nothing
                MtxtCelFunc.Text = Nothing
                txtEmailFunc.Text = Nothing
                cmbSexoFunc.Text = Nothing
                MtxtDataNascfunc.Text = Nothing
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

                bloqueiacampos()

                If (frmPrincipal.lbIdioma.Text = "Português") Then
                    MessageBox.Show("Funcionário excluído com sucesso!")
                End If
                If (frmPrincipal.lbIdioma.Text = "English") Then
                    MessageBox.Show("Employee successfully deleted!")
                End If
                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                    MessageBox.Show("Empleado eliminado correctamente!")
                End If
            End If
        End If
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click

        If txtCodFunc.Text <> Nothing Then

            txtConsultaFunc.Text = Nothing
            MtxtFiltroCPF.Text = Nothing
            MtxtFiltroData.Text = Nothing

            txtNomeFunc.Enabled = True
            MtxtDDDFunc.Enabled = True
            MtxtTelFunc.Enabled = True
            MtxtCelFunc.Enabled = True
            txtEmailFunc.Enabled = True
            cmbSexoFunc.Enabled = True
            MtxtDataNascfunc.Enabled = True
            MtxtCPFFunc.Enabled = True
            MtxtDataCadFunc.Enabled = True
            txtEndFunc.Enabled = True
            txtNumFunc.Enabled = True
            txtCidadeFunc.Enabled = True
            cmbUFFunc.Enabled = True
            txtBairroFunc.Enabled = True
            MtxtCEPFunc.Enabled = True
            txtCargoFunc.Enabled = True
            txtLoginFunc.Enabled = True

        Else
            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("Selecione um funcionário para alterar seus dados!")
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("Select an employee to change their data!")
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("Seleccione un empleado a cambiar sus datos!")
            End If
        End If
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click

        Conectar()

        If txtCodFunc.Text <> Nothing Then

            comando.Parameters.Clear()
            comando.CommandText = "update funcionario set nome_func =@nome_func, ddd_func =@ddd_func, telefone_func =@telefone_func, celular_func =@celular_func, email_func =@email_func, sexo_func =@sexo_func, datanasc_func =@datanasc_func, CPF_func =@CPF_func, datacadastro_func =@datacadastro_func, endereco_func =@endereco_func, numeroendereco_func =@numeroendereco_func, cidade_func =@cidade_func, UF_func =@UF_func, bairro_func =@bairro_func, cep_func =@cep_func, cargo_func =@cargo_func, login_func =@login_func where cod_func = @cod_func"
            comando.Parameters.AddWithValue("@cod_func", txtCodFunc.Text)
            comando.Parameters.AddWithValue("@nome_func", txtNomeFunc.Text)
            comando.Parameters.AddWithValue("@ddd_func", MtxtDDDFunc.Text)
            comando.Parameters.AddWithValue("@telefone_func", MtxtTelFunc.Text)
            comando.Parameters.AddWithValue("@celular_func", MtxtCelFunc.Text)
            comando.Parameters.AddWithValue("@email_func", txtEmailFunc.Text)
            comando.Parameters.AddWithValue("@sexo_func", cmbSexoFunc.Text)
            comando.Parameters.AddWithValue("@datanasc_func", MtxtDataNascfunc.Text)
            comando.Parameters.AddWithValue("@CPF_func", MtxtCPFFunc.Text)
            comando.Parameters.AddWithValue("@datacadastro_func", MtxtDataCadFunc.Text)
            comando.Parameters.AddWithValue("@endereco_func", txtEndFunc.Text)
            comando.Parameters.AddWithValue("@numeroendereco_func", txtNumFunc.Text)
            comando.Parameters.AddWithValue("@cidade_func", txtCidadeFunc.Text)
            comando.Parameters.AddWithValue("@UF_func", cmbUFFunc.Text)
            comando.Parameters.AddWithValue("@bairro_func", txtBairroFunc.Text)
            comando.Parameters.AddWithValue("@cep_func", MtxtCEPFunc.Text)
            comando.Parameters.AddWithValue("@cargo_func", txtCargoFunc.Text)
            comando.Parameters.AddWithValue("@login_func", txtLoginFunc.Text)

            comando.ExecuteNonQuery()
            Desconectar()

            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("Dados do funcionário alterados com sucesso!")
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("Employee data changed successfully!")
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("Los datos de los empleados cambian con éxito!")
            End If

            txtCodFunc.Text = Nothing
            txtNomeFunc.Text = Nothing
            MtxtDDDFunc.Text = Nothing
            MtxtTelFunc.Text = Nothing
            MtxtCelFunc.Text = Nothing
            txtEmailFunc.Text = Nothing
            cmbSexoFunc.Text = Nothing
            MtxtDataNascfunc.Text = Nothing
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
            dgvFunc.DataSource = Nothing
            txtConsultaFunc.Text = Nothing
            MtxtFiltroCPF.Text = Nothing
            MtxtFiltroData.Text = Nothing

            bloqueiacampos()

            limpafiltros()

        Else
            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("Selecione um funcionário para alterar seus dados!")
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("Select an employee to change their data!")
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("Seleccione un empleado a cambiar sus datos!")
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

    Private Sub limpafiltros()

        txtConsultaFunc.Visible = False
        MtxtFiltroData.Visible = False
        MtxtFiltroCPF.Visible = False
        btnBuscar.Visible = False

    End Sub

    Private Sub cmbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltro.SelectedIndexChanged

        limpacamposfuncionario()
        txtConsultaFunc.Text = Nothing
        MtxtFiltroCPF.Text = Nothing
        MtxtFiltroData.Text = Nothing

        If cmbFiltro.Text = "Código" Or cmbFiltro.Text = "ID" Or cmbFiltro.Text = "Nome" Or cmbFiltro.Text = "Name" Or cmbFiltro.Text = "Nombre" Then
            limpafiltros()
            txtConsultaFunc.Visible = True
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