Imports System.Data.SqlClient
Public Class frmVacinacao

    Private Sub cadastrarvacinasbanco()

        Conectar()
        comando.CommandText = ("insert into itemvacinacao (cod_vacinacao, cod_vacina, nome_vacina, mes_vacina, ano_vacina) values (@cod_vacinacao, @cod_vacina, @nome_vacina, @mes_vacina, @ano_vacina)")

        For i As Integer = 0 To dgvItensVacinacao.Rows.Count - 1

            comando.Parameters.Clear()

            comando.Parameters.AddWithValue("@cod_vacinacao",
                dgvItensVacinacao.Rows(i).Cells(0).Value)
            comando.Parameters.AddWithValue("@cod_vacina",
                dgvItensVacinacao.Rows(i).Cells(1).Value)
            comando.Parameters.AddWithValue("@nome_vacina",
                dgvItensVacinacao.Rows(i).Cells(2).Value)
            comando.Parameters.AddWithValue("@mes_vacina", txtMes.Text)
            comando.Parameters.AddWithValue("@ano_vacina", txtAno.Text)

            comando.ExecuteNonQuery()

            If i > dgvItensVacinacao.Rows.Count Then
                Exit For
            End If

        Next

    End Sub

    Private Sub retirarvacinasestoque()

        Conectar()
        comando.CommandText = ("update produto set quantidade_produto =quantidade_produto-1 where cod_produto =@cod_vacina")

        For i As Integer = 0 To dgvItensVacinacao.Rows.Count - 1

            comando.Parameters.Clear()

            comando.Parameters.AddWithValue("@cod_vacina",
                dgvItensVacinacao.Rows(i).Cells(1).Value)

            comando.ExecuteNonQuery()

            If i > dgvItensVacinacao.Rows.Count Then
                Exit For
            End If

        Next

    End Sub

    Private Sub gerarcodigovacinacao()

        Conectar()

        Dim codigo As Integer
        comando.CommandText = "SELECT Max(cod_vacinacao) FROM vacinacao"

        If IsDBNull(comando.ExecuteScalar) Then
            codigo = 1
            txtCodigoVacinacao.Text = codigo
        Else
            codigo = comando.ExecuteScalar + 1
            txtCodigoVacinacao.Text = codigo
        End If

    End Sub

    Dim Vacinas As New DataTable()
    Dim rowNew As DataRow
    Dim dsProdutos As New DataSet()

    Private Sub frmVacinacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        gerarcodigovacinacao()

        dsProdutos.Tables.Add(Vacinas)

        If (frmPrincipal.lbIdioma.Text = "Português") Then

            dsProdutos.Tables(0).Columns.Add("Código da vacinação", GetType(Integer))
            dsProdutos.Tables(0).Columns.Add("Código da vacina", GetType(Integer))
            dsProdutos.Tables(0).Columns.Add("Nome da vacina", GetType(String))

            cmbFiltroFunc.Items.Add("Código")
            cmbFiltroFunc.Items.Add("Nome")
            cmbFiltroFunc.Items.Add("CPF")
            cmbFiltroFunc.Items.Add("Data de cadastro")

            cmbFiltroAnimal.Items.Add("Código")
            cmbFiltroAnimal.Items.Add("Nome")
            cmbFiltroAnimal.Items.Add("Data de cadastro")

            cmbFiltroVacina.Items.Add("Código")
            cmbFiltroVacina.Items.Add("Nome")
            cmbFiltroVacina.Items.Add("Marca")

        End If

        If (frmPrincipal.lbIdioma.Text = "English") Then

            dsProdutos.Tables(0).Columns.Add("Vaccination ID", GetType(Integer))
            dsProdutos.Tables(0).Columns.Add("Vaccine ID", GetType(Integer))
            dsProdutos.Tables(0).Columns.Add("Vaccine name", GetType(String))

            Me.Text = "Vaccination"

            gpxFunc.Text = "Employee data"
            lbCodFunc.Text = "Search employee by: "
            lbCodigoFunc.Text = "ID"
            lbNomeFunc.Text = "Name"

            gpxAnimal.Text = "Animal data"
            lbCodAnimal.Text = "Search animal by: "
            lbCodigoAnimal.Text = "ID"
            lbNomeAnimal.Text = "Name"

            gpxVacinacao.Text = "Vaccination data"
            lbCodVacinacao.Text = "Vaccination ID"
            lbVacina.Text = "Enter ID of vaccine: "
            lbCodigoVacina.Text = "ID"
            lbNomeVacina.Text = "Name"
            lbDataVacinacao.Text = "Vaccination date"

            btnBuscaFunc.Text = "Search"
            btnBuscaAnimal.Text = "Search"
            btnBuscaVacina.Text = "Search"
            btnAdicionar.Text = "Add"
            btnRemover.Text = "Remove"
            btnLimpar.Text = "Clear"

            btnCancelar.BackgroundImage = My.Resources.cancelar_english_fw
            BtnSalvarVacinacao.BackgroundImage = My.Resources.salva_vacinacao_english_fw
            pbxBanner.BackgroundImage = My.Resources.banner_vacinacao_english_fw

            cmbFiltroFunc.Items.Add("ID")
            cmbFiltroFunc.Items.Add("Name")
            cmbFiltroFunc.Items.Add("CPF")
            cmbFiltroFunc.Items.Add("Date of registration")

            cmbFiltroAnimal.Items.Add("ID")
            cmbFiltroAnimal.Items.Add("Name")
            cmbFiltroAnimal.Items.Add("Date of registration")

            cmbFiltroVacina.Items.Add("ID")
            cmbFiltroVacina.Items.Add("Name")
            cmbFiltroVacina.Items.Add("Brand")

        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            dsProdutos.Tables(0).Columns.Add("Código vacunación", GetType(Integer))
            dsProdutos.Tables(0).Columns.Add("Código vacuna", GetType(Integer))
            dsProdutos.Tables(0).Columns.Add("Nombre vacuna", GetType(String))

            Me.Text = "Vacunación"

            gpxFunc.Text = "Datos del empleado"
            lbCodFunc.Text = "Buscar por empleado: "
            lbCodigoFunc.Text = "ID"
            lbNomeFunc.Text = "Nombre"

            gpxAnimal.Text = "Datos del animal"
            lbCodAnimal.Text = "Buscar por animal:"
            lbCodigoAnimal.Text = "ID"
            lbNomeAnimal.Text = "Nombre"

            gpxVacinacao.Text = "Fecha de vacunación"
            lbCodVacinacao.Text = "Código vacunación"
            lbVacina.Text = "Introduzca ID de la vacuna: "
            lbCodigoVacina.Text = "ID"
            lbNomeVacina.Text = "Nombre"
            lbDataVacinacao.Text = "Fecha de vacunación"

            btnBuscaFunc.Text = "Buscar"
            btnBuscaAnimal.Text = "Buscar"
            btnBuscaVacina.Text = "Buscar"
            btnAdicionar.Text = "Añadir"
            btnRemover.Text = "Quitar"
            btnLimpar.Text = "Limpiar"

            btnCancelar.BackgroundImage = My.Resources.cancelar_spanish_fw
            BtnSalvarVacinacao.BackgroundImage = My.Resources.salva_vacinacao_spanish_fw
            pbxBanner.BackgroundImage = My.Resources.banner_vacinacao_spanish_fw

            cmbFiltroFunc.Items.Add("ID")
            cmbFiltroFunc.Items.Add("Nombre")
            cmbFiltroFunc.Items.Add("CPF")
            cmbFiltroFunc.Items.Add("Fecha de registro")

            cmbFiltroAnimal.Items.Add("ID")
            cmbFiltroAnimal.Items.Add("Nombre")
            cmbFiltroAnimal.Items.Add("Fecha de registro")

            cmbFiltroVacina.Items.Add("ID")
            cmbFiltroVacina.Items.Add("Nombre")
            cmbFiltroVacina.Items.Add("Marca")

        End If

        dgvItensVacinacao.DataSource = dsProdutos.Tables(0)
        dgvItensVacinacao.Columns(2).Width = 240

    End Sub

    Private Sub limpacamposanimal()

        txtCodAnimal.Text = Nothing
        txtNomeAnimal.Text = Nothing

    End Sub

    Private Sub limpacamposfuncionario()

        txtCodFunc.Text = Nothing
        txtNomeFunc.Text = Nothing

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

    Private Sub btnBuscaFunc_Click(sender As Object, e As EventArgs) Handles btnBuscaFunc.Click

        limpacamposfuncionario()
        Conectar()

        If cmbFiltroFunc.Text = "Código" Or cmbFiltroFunc.Text = "ID" Then
            dgvFunc.DataSource = Consulta_funcionario_codigo(txtConsultaFunc.Text)
        End If

        If cmbFiltroFunc.Text = "Nome" Or cmbFiltroFunc.Text = "Name" Or cmbFiltroFunc.Text = "Nombre" Then
            dgvFunc.DataSource = Consulta_funcionario_nome(txtConsultaFunc.Text)
        End If

        If cmbFiltroFunc.Text = "CPF" Then
            dgvFunc.DataSource = Consulta_funcionario_CPF(MtxtFiltroCPFFunc.Text)
        End If

        If cmbFiltroFunc.Text = "Data de cadastro" Or cmbFiltroFunc.Text = "Date of registration" Or cmbFiltroFunc.Text = "Fecha de registro" Then
            dgvFunc.DataSource = Consulta_funcionario_data(MtxtFiltroDataFunc.Text)
        End If

    End Sub

    Private Sub dgvFunc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFunc.CellClick

        Dim i As Integer
        i = dgvFunc.CurrentRow.Index
        Me.txtCodFunc.Text = dgvFunc.Item(0, i).Value
        Me.txtNomeFunc.Text = dgvFunc.Item(1, i).Value

    End Sub

    Private Sub btnBuscaAnimal_Click(sender As Object, e As EventArgs) Handles btnBuscaAnimal.Click

        limpacamposanimal()
        Conectar()

        If cmbFiltroAnimal.Text = "Código" Or cmbFiltroAnimal.Text = "ID" Then
            dgvAnimal.DataSource = Consulta_animal_codigo(txtConsultaAnimal.Text)
        End If

        If cmbFiltroAnimal.Text = "Nome" Or cmbFiltroAnimal.Text = "Name" Or cmbFiltroAnimal.Text = "Nombre" Then
            dgvAnimal.DataSource = Consulta_animal_nome(txtConsultaAnimal.Text)
        End If

        If cmbFiltroAnimal.Text = "Data de cadastro" Or cmbFiltroAnimal.Text = "Date of registration" Or cmbFiltroAnimal.Text = "Fecha de registro" Then
            dgvAnimal.DataSource = Consulta_animal_data(MtxtFiltroDataAnimal.Text)
        End If

    End Sub

    Private Sub dgvAnimal_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAnimal.CellClick

        Dim i As Integer
        i = dgvAnimal.CurrentRow.Index
        Me.txtCodAnimal.Text = dgvAnimal.Item(1, i).Value
        Me.txtNomeAnimal.Text = dgvAnimal.Item(3, i).Value

    End Sub

    Private Sub btnBuscaVacina_Click(sender As Object, e As EventArgs) Handles btnBuscaVacina.Click

        Conectar()

        If cmbFiltroVacina.Text = "Código" Or cmbFiltroVacina.Text = "ID" Then
            dgvVacina.DataSource = Consulta_vacina_codigo(txtConsultaVacina.Text)
        End If

        If cmbFiltroVacina.Text = "Nome" Or cmbFiltroVacina.Text = "Name" Or cmbFiltroVacina.Text = "Nombre" Then
            dgvVacina.DataSource = Consulta_vacina_nome(txtConsultaVacina.Text)
        End If

        If cmbFiltroVacina.Text = "Marca" Or cmbFiltroVacina.Text = "Brand" Then
            dgvVacina.DataSource = Consulta_vacina_marca(txtConsultaVacina.Text)
        End If

    End Sub

    Private Sub dgvVacina_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVacina.CellClick

        Dim i As Integer
        i = dgvVacina.CurrentRow.Index
        Me.txtCodVacina.Text = dgvVacina.Item(1, i).Value
        Me.txtNomeVacina.Text = dgvVacina.Item(4, i).Value
        Me.txtQuantidade.Text = dgvVacina.Item(6, i).Value

    End Sub


    Private Sub BtnSalvarVacinacao_Click(sender As Object, e As EventArgs) Handles BtnSalvarVacinacao.Click

        If (txtCodFunc.Text) Is "" Then
            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("Selecione um funcionário")
                dgvFunc.Focus()
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("Select an employee")
                dgvFunc.Focus()
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("Seleccione un empleado")
                dgvFunc.Focus()
            End If
        Else
            If (txtCodAnimal.Text) Is "" Then
                If (frmPrincipal.lbIdioma.Text = "Português") Then
                    MessageBox.Show("Selecione um animal")
                    dgvAnimal.Focus()
                End If
                If (frmPrincipal.lbIdioma.Text = "English") Then
                    MessageBox.Show("Select an animal")
                    dgvAnimal.Focus()
                End If
                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                    MessageBox.Show("Seleccione un animal")
                    dgvAnimal.Focus()
                End If
            Else
                If (dgvItensVacinacao.RowCount = 0) Then
                    If (frmPrincipal.lbIdioma.Text = "Português") Then
                        MessageBox.Show("Adicione a(s) vacina(s) utilizadas")
                        txtConsultaVacina.Focus()
                    End If
                    If (frmPrincipal.lbIdioma.Text = "English") Then
                        MessageBox.Show("Add the vaccine used")
                        txtConsultaVacina.Focus()
                    End If
                    If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                        MessageBox.Show("Añadir la vacuna utilizada")
                        txtConsultaVacina.Focus()
                    End If
                Else
                    If Not (MtxtDataVacina.MaskFull) Then
                        If (frmPrincipal.lbIdioma.Text = "Português") Then
                            MessageBox.Show("O campo Data vacinação não pode ficar vazio")
                            MtxtDataVacina.Focus()
                        End If
                        If (frmPrincipal.lbIdioma.Text = "English") Then
                            MessageBox.Show("Field Data vaccination can not be empty")
                            MtxtDataVacina.Focus()
                        End If
                        If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                            MessageBox.Show("La vacunación de datos de campo no puede estar vacío")
                            MtxtDataVacina.Focus()
                        End If
                    Else

                        Dim x As String = MtxtDataVacina.Text

                        Dim y As String = x.Substring(x.Length - 4, 4)

                        txtAno.Text = y

                        Dim TestString As String = MtxtDataVacina.Text
                        Dim MidWords As String = Mid(TestString, 4, 2)
                        txtMes.Text = MidWords

                        If (txtCodFunc.Text <> "" And txtCodAnimal.Text <> "" And MtxtDataVacina.Text <> "") Then

                            Conectar()
                            Cadastrar_Vacinacao(txtCodAnimal.Text, txtCodFunc.Text, MtxtDataVacina.Text, txtMes.Text, txtAno.Text)
                            cadastrarvacinasbanco()
                            retirarvacinasestoque()

                            gerarcodigovacinacao()

                            txtConsultaFunc.Text = Nothing
                            MtxtFiltroCPFFunc.Text = Nothing
                            MtxtFiltroDataFunc.Text = Nothing
                            cmbFiltroFunc.Text = Nothing
                            txtConsultaAnimal.Text = Nothing
                            MtxtFiltroDataAnimal.Text = Nothing
                            cmbFiltroAnimal.Text = Nothing
                            txtConsultaVacina.Text = Nothing
                            cmbFiltroVacina.Text = Nothing
                            txtCodFunc.Text = Nothing
                            txtNomeFunc.Text = Nothing
                            txtCodAnimal.Text = Nothing
                            txtNomeAnimal.Text = Nothing
                            txtCodVacina.Text = Nothing
                            txtNomeVacina.Text = Nothing
                            txtCodItem.Text = Nothing
                            txtCodVacinacao.Text = Nothing
                            txtNomeVacina.Text = Nothing
                            MtxtDataVacina.Text = Nothing
                            dgvFunc.DataSource = Nothing
                            dgvAnimal.DataSource = Nothing
                            dgvVacina.DataSource = Nothing
                            dsProdutos.Tables(0).Rows.Clear()

                            If (frmPrincipal.lbIdioma.Text = "Português") Then
                                MessageBox.Show("Efetue o cadastro de outra vacinação ou pressione o botão cancelar para realizar outra tarefa")
                            End If
                            If (frmPrincipal.lbIdioma.Text = "English") Then
                                MessageBox.Show("Perform the registration of another vaccination or press the cancel button to perform another task")
                            End If
                            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                MessageBox.Show("Realizar el registro de otra vacunación o pulse el botón de cancelación para realizar otra tarea")
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click

        If (txtCodVacina.Text) Is "" Then
            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("Selecione uma vacina e clique em adicionar")
                dgvVacina.Focus()
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("Select a vaccine and click add")
                dgvVacina.Focus()
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("Seleccione y haga clic en añadir a la vacuna")
                dgvVacina.Focus()
            End If
        Else
            If (txtQuantidade.Text < 1) Then
                If (frmPrincipal.lbIdioma.Text = "Português") Then
                    MessageBox.Show("Vacina em falta no estoque!")
                End If
                If (frmPrincipal.lbIdioma.Text = "English") Then
                    MessageBox.Show("Vaccine shortage in stock!")
                End If
                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                    MessageBox.Show("Escasez de vacunas en stock!")
                End If
            Else
                If (txtCodVacina.Text) <> "" Then

                    txtQuantidade.Text = txtQuantidade.Text - 1
                    rowNew = dsProdutos.Tables(0).NewRow

                    If (frmPrincipal.lbIdioma.Text = "Português") Then
                        rowNew("Código da vacinação") = txtCodigoVacinacao.Text
                        rowNew("Código da vacina") = txtCodVacina.Text
                        rowNew("Nome da vacina") = txtNomeVacina.Text
                        dsProdutos.Tables(0).Rows.Add(rowNew)
                        dsProdutos.AcceptChanges()
                    End If
                    If (frmPrincipal.lbIdioma.Text = "English") Then
                        rowNew("Vaccination ID") = txtCodigoVacinacao.Text
                        rowNew("Vaccine ID") = txtCodVacina.Text
                        rowNew("Vaccine name") = txtNomeVacina.Text
                        dsProdutos.Tables(0).Rows.Add(rowNew)
                        dsProdutos.AcceptChanges()
                    End If

                    If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                        rowNew("Vacunación ID") = txtCodigoVacinacao.Text
                        rowNew("Vacuna ID") = txtCodVacina.Text
                        rowNew("Vacuna nombre") = txtNomeVacina.Text
                        dsProdutos.Tables(0).Rows.Add(rowNew)
                        dsProdutos.AcceptChanges()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click

        If (dgvItensVacinacao.RowCount = 0) Then
            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("Nenhum item listado")
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("None listed item")
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("Ninguno de los puntos enumerados")
            End If
        Else

            txtQuantidade.Text = txtQuantidade.Text + 1
            dgvItensVacinacao.Rows.Remove(dgvItensVacinacao.CurrentRow)

        End If

    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click

        dsProdutos.Tables(0).Rows.Clear()
        txtConsultaVacina.Text = Nothing
        txtCodVacina.Text = Nothing
        txtNomeVacina.Text = Nothing
        txtQuantidade.Text = Nothing
        dgvVacina.DataSource = Nothing

    End Sub

    Private Sub dgvItensVacinacao_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItensVacinacao.CellClick

        Dim i As Integer
        i = dgvItensVacinacao.CurrentRow.Index
        Me.txtCodItem.Text = dgvItensVacinacao.Item(0, i).Value
        Me.txtCodVacinacao.Text = dgvItensVacinacao.Item(1, i).Value

    End Sub

    Private Sub limpafiltrosfunc()

        txtConsultaFunc.Visible = False
        MtxtFiltroDataFunc.Visible = False
        MtxtFiltroCPFFunc.Visible = False
        btnBuscaFunc.Visible = False

    End Sub

    Private Sub cmbFiltroFunc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltroFunc.SelectedIndexChanged

        limpacamposfuncionario()
        txtConsultaFunc.Text = Nothing
        MtxtFiltroCPFFunc.Text = Nothing
        MtxtFiltroDataFunc.Text = Nothing
        dgvFunc.DataSource = Nothing

        If cmbFiltroFunc.Text = "Código" Or cmbFiltroFunc.Text = "ID" Or cmbFiltroFunc.Text = "Nome" Or cmbFiltroFunc.Text = "Name" Or cmbFiltroFunc.Text = "Nombre" Then
            limpafiltrosfunc()
            txtConsultaFunc.Visible = True
        End If

        If cmbFiltroFunc.Text = "Data de cadastro" Or cmbFiltroFunc.Text = "Date of registration" Or cmbFiltroFunc.Text = "Fecha de registro" Then
            limpafiltrosfunc()
            MtxtFiltroDataFunc.Visible = True
        End If

        If cmbFiltroFunc.Text = "CPF" Then
            limpafiltrosfunc()
            MtxtFiltroCPFFunc.Visible = True
        End If

        btnBuscaFunc.Visible = True

    End Sub

    Private Sub limpafiltrosanimal()

        txtConsultaAnimal.Visible = False
        MtxtFiltroDataAnimal.Visible = False
        btnBuscaAnimal.Visible = False

    End Sub

    Private Sub cmbFiltroAnimal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltroAnimal.SelectedIndexChanged

        limpacamposanimal()
        txtConsultaAnimal.Text = Nothing
        MtxtFiltroDataAnimal.Text = Nothing
        dgvAnimal.DataSource = Nothing

        If cmbFiltroAnimal.Text = "Código" Or cmbFiltroAnimal.Text = "ID" Or cmbFiltroAnimal.Text = "Nome" Or cmbFiltroAnimal.Text = "Name" Or cmbFiltroAnimal.Text = "Nombre" Then
            limpafiltrosanimal()
            txtConsultaAnimal.Visible = True
        End If

        If cmbFiltroAnimal.Text = "Data de cadastro" Or cmbFiltroAnimal.Text = "Date of registration" Or cmbFiltroAnimal.Text = "Fecha de registro" Then
            limpafiltrosanimal()
            MtxtFiltroDataAnimal.Visible = True
        End If

        btnBuscaAnimal.Visible = True

    End Sub

    Private Sub limpafiltrosvacina()

        txtConsultaVacina.Visible = False
        btnBuscaVacina.Visible = False

    End Sub

    Private Sub cmbFiltroVacina_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltroVacina.SelectedIndexChanged

        txtConsultaVacina.Text = Nothing

        If cmbFiltroVacina.Text = "Código" Or cmbFiltroVacina.Text = "ID" Or cmbFiltroVacina.Text = "Nome" Or cmbFiltroVacina.Text = "Name" Or cmbFiltroVacina.Text = "Nombre" Or cmbFiltroVacina.Text = "Marca" Or cmbFiltroVacina.Text = "Brand" Then
            limpafiltrosvacina()
            txtConsultaVacina.Visible = True
        End If

        btnBuscaVacina.Visible = True

    End Sub
End Class