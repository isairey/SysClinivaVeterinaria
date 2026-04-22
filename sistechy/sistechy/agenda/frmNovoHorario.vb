Imports System.Data.SqlClient
Public Class frmNovoHorario

    Private Sub limpacamposcliente()

        txtCodCli.Text = Nothing
        txtNomeCli.Text = Nothing

    End Sub

    Private Sub limpacamposanimal()

        txtCodAnimal.Text = Nothing
        txtNomeAnimal.Text = Nothing

    End Sub

    Private Sub limpacamposfuncionario()

        txtCodFunc.Text = Nothing
        txtNomeFunc.Text = Nothing

    End Sub

    Private Sub limpafiltroscliente()

        txtConsultaCli.Visible = False
        MtxtFiltroDataCli.Visible = False
        MtxtFiltroCPFCli.Visible = False
        btnBuscaCli.Visible = False

    End Sub

    Private Sub limpafiltrosanimal()

        txtConsultaAnimal.Visible = False
        MtxtFiltroDataAnimal.Visible = False
        btnBuscaAnimal.Visible = False

    End Sub

    Private Sub limpafiltrosfuncionario()

        txtConsultaFunc.Visible = False
        MtxtFiltroDataFunc.Visible = False
        MtxtFiltroCPFFunc.Visible = False
        btnBuscaFunc.Visible = False

    End Sub

    Private Sub gerarcodigoagendamento()

        Conectar()

        Dim codigo As Integer
        comando.CommandText = "SELECT Max(cod_agenda) FROM agenda"

        If IsDBNull(comando.ExecuteScalar) Then
            codigo = 1
            txtCodAgendamento.Text = codigo
        Else
            codigo = comando.ExecuteScalar + 1
            txtCodAgendamento.Text = codigo
        End If

    End Sub

    Private Sub frmNovoHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (frmPrincipal.lbIdioma.Text = "Português") Then

            cmbFiltroCli.Items.Add("Código")
            cmbFiltroCli.Items.Add("Nome")
            cmbFiltroCli.Items.Add("CPF")
            cmbFiltroCli.Items.Add("Data de cadastro")

            cmbFiltroAnimal.Items.Add("Código")
            cmbFiltroAnimal.Items.Add("Nome")
            cmbFiltroAnimal.Items.Add("Data de cadastro")

            cmbFiltroFunc.Items.Add("Código")
            cmbFiltroFunc.Items.Add("Nome")
            cmbFiltroFunc.Items.Add("CPF")
            cmbFiltroFunc.Items.Add("Data de cadastro")

            cmbTipoAtendimento.Items.Add("Cirurgia")
            cmbTipoAtendimento.Items.Add("Consulta")
            cmbTipoAtendimento.Items.Add("Internação")
            cmbTipoAtendimento.Items.Add("Vacinação")

            cmbStatusAgendamento.Items.Add("Marcado")
            cmbStatusAgendamento.Items.Add("Confirmado")
            cmbStatusAgendamento.Items.Add("Aguardando")
            cmbStatusAgendamento.Items.Add("Em atendimento")
            cmbStatusAgendamento.Items.Add("Atendido")
            cmbStatusAgendamento.Items.Add("Cancelado")
            cmbStatusAgendamento.Items.Add("Faltou")

        End If

        If (frmPrincipal.lbIdioma.Text = "English") Then

            Me.Text = "New time"

            cmbFiltroCli.Items.Add("ID")
            cmbFiltroCli.Items.Add("Name")
            cmbFiltroCli.Items.Add("CPF")
            cmbFiltroCli.Items.Add("Date of registration")

            cmbFiltroAnimal.Items.Add("ID")
            cmbFiltroAnimal.Items.Add("Name")
            cmbFiltroAnimal.Items.Add("Date of registration")

            cmbFiltroFunc.Items.Add("ID")
            cmbFiltroFunc.Items.Add("Name")
            cmbFiltroFunc.Items.Add("CPF")
            cmbFiltroFunc.Items.Add("Date of registration")

            cmbTipoAtendimento.Items.Add("Surgery")
            cmbTipoAtendimento.Items.Add("Consultation")
            cmbTipoAtendimento.Items.Add("Hospitalization")
            cmbTipoAtendimento.Items.Add("Vaccination")

            cmbStatusAgendamento.Items.Add("Marked")
            cmbStatusAgendamento.Items.Add("Confirmed")
            cmbStatusAgendamento.Items.Add("Waiting")
            cmbStatusAgendamento.Items.Add("In progress")
            cmbStatusAgendamento.Items.Add("Attended")
            cmbStatusAgendamento.Items.Add("Canceled")
            cmbStatusAgendamento.Items.Add("Lacked")

            gpxCliente.Text = "Customer data"
            gpxAnimal.Text = "Animal data"
            gpxFunc.Text = "Employee data"
            gpxAgendamento.Text = "Data scheduling"
            lbBuscaCli.Text = "Client ID:"
            lbCodigoCli.Text = "ID"
            lbNomeCli.Text = "Name"
            lbBuscaAnimal.Text = "Animal ID:"
            lbCodigoAnimal.Text = "ID"
            lbNomeAnimal.Text = "Name"
            lbBuscaFunc.Text = "Employee ID:"
            lbCodigoFunc.Text = "ID"
            lbNomeFunc.Text = "Name"
            lbCodAgendamento.Text = "Scheduling code"
            lbDataAgendamento.Text = "Date scheduling"
            lbTipoAgendamento.Text = "Type of scheduling"
            lbStatusAgendamento.Text = "Scheduling status"
            btnBuscaCli.Text = "Search"
            btnBuscaAnimal.Text = "Search"
            btnBuscaFunc.Text = "Search"

            pbxBanner.BackgroundImage = My.Resources.banner_novo_horario_english_fw
            btnCancelar.BackgroundImage = My.Resources.cancelar_english_fw
            btnSalvarNovoHorario.BackgroundImage = My.Resources.salvar_novo_horario_english_fw

        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Nuevo tiempo"

            cmbFiltroCli.Items.Add("ID")
            cmbFiltroCli.Items.Add("Nombre")
            cmbFiltroCli.Items.Add("CPF")
            cmbFiltroCli.Items.Add("Fecha de registro")

            cmbFiltroAnimal.Items.Add("ID")
            cmbFiltroAnimal.Items.Add("Nombre")
            cmbFiltroAnimal.Items.Add("Fecha de registro")

            cmbFiltroFunc.Items.Add("ID")
            cmbFiltroFunc.Items.Add("Nombre")
            cmbFiltroFunc.Items.Add("CPF")
            cmbFiltroFunc.Items.Add("Fecha de registro")

            cmbTipoAtendimento.Items.Add("Cirugía")
            cmbTipoAtendimento.Items.Add("Consulta")
            cmbTipoAtendimento.Items.Add("Hospitalización")
            cmbTipoAtendimento.Items.Add("Vacunación")

            cmbStatusAgendamento.Items.Add("Marcado")
            cmbStatusAgendamento.Items.Add("Confirmado")
            cmbStatusAgendamento.Items.Add("Espera")
            cmbStatusAgendamento.Items.Add("En el servicio")
            cmbStatusAgendamento.Items.Add("Asistido")
            cmbStatusAgendamento.Items.Add("Cancelado")
            cmbStatusAgendamento.Items.Add("Perdida")

            gpxCliente.Text = "Datos del cliente"
            gpxAnimal.Text = "Datos del animal"
            gpxFunc.Text = "Datos del empleado"
            gpxAgendamento.Text = "Programación de datos"
            lbBuscaCli.Text = "ID de cliente:"
            lbCodigoCli.Text = "ID"
            lbNomeCli.Text = "Nombre"
            lbBuscaAnimal.Text = "ID de animal:"
            lbCodigoAnimal.Text = "ID"
            lbNomeAnimal.Text = "Nombre"
            lbBuscaFunc.Text = "ID de empleado:"
            lbCodigoFunc.Text = "ID"
            lbNomeFunc.Text = "Nombre"
            lbCodAgendamento.Text = "ID programación"
            lbDataAgendamento.Text = "Programación de datos"
            lbTipoAgendamento.Text = "Tipo de programación"
            lbStatusAgendamento.Text = "Estado de programación"
            btnBuscaCli.Text = "Buscar"
            btnBuscaAnimal.Text = "Buscar"
            btnBuscaFunc.Text = "Buscar"

            pbxBanner.BackgroundImage = My.Resources.banner_novo_horario_spanish_fw
            btnCancelar.BackgroundImage = My.Resources.cancelar_spanish_fw
            btnSalvarNovoHorario.BackgroundImage = My.Resources.salvar_novo_horario_spanish_fw

        End If

        gerarcodigoagendamento()

    End Sub

    Private Sub btnBuscaCli_Click(sender As Object, e As EventArgs) Handles btnBuscaCli.Click

        limpacamposcliente()
        Conectar()

        If cmbFiltroCli.Text = "Código" Or cmbFiltroCli.Text = "ID" Then
            dgvCli.DataSource = Consulta_cliente_codigo(txtConsultaCli.Text)
        End If

        If cmbFiltroCli.Text = "Nome" Or cmbFiltroCli.Text = "Name" Or cmbFiltroCli.Text = "Nombre" Then
            dgvCli.DataSource = Consulta_cliente_nome(txtConsultaCli.Text)
        End If

        If cmbFiltroCli.Text = "CPF" Then
            dgvCli.DataSource = Consulta_cliente_CPF(MtxtFiltroCPFCli.Text)
        End If

        If cmbFiltroCli.Text = "Data de cadastro" Or cmbFiltroCli.Text = "Date of registration" Or cmbFiltroCli.Text = "Fecha de registro" Then
            dgvCli.DataSource = Consulta_cliente_data(MtxtFiltroDataCli.Text)
        End If

    End Sub

    Private Sub dgvCli_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCli.CellClick

        Dim i As Integer
        i = dgvCli.CurrentRow.Index
        Me.txtCodCli.Text = dgvCli.Item(0, i).Value
        Me.txtNomeCli.Text = dgvCli.Item(1, i).Value

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

    Private Sub btnCadastraCli_Click(sender As Object, e As EventArgs) Handles btnSalvarNovoHorario.Click

        If (txtCodCli.Text) Is "" Then
            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("Selecione um cliente")
                dgvCli.Focus()
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("Select a client")
                dgvCli.Focus()
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("Seleccione el cliente")
                dgvCli.Focus()
            End If
        Else
            If (txtCodAnimal.Text) Is "" Then
                If (frmPrincipal.lbIdioma.Text = "Português") Then
                    MessageBox.Show("Selecione um animal")
                    dgvAnimal.Focus()
                End If
                If (frmPrincipal.lbIdioma.Text = "English") Then
                    MessageBox.Show("Select a animal")
                    dgvAnimal.Focus()
                End If
                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                    MessageBox.Show("Seleccione el animal")
                    dgvAnimal.Focus()
                End If
            Else
                If (txtCodFunc.Text) Is "" Then
                    If (frmPrincipal.lbIdioma.Text = "Português") Then
                        MessageBox.Show("Selecione um funcionário")
                        dgvFunc.Focus()
                    End If
                    If (frmPrincipal.lbIdioma.Text = "English") Then
                        MessageBox.Show("Select a employee")
                        dgvFunc.Focus()
                    End If
                    If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                        MessageBox.Show("Seleccione el empleado")
                        dgvFunc.Focus()
                    End If
                Else
                    If Not (MtxtDataAgendamento.MaskFull) Then
                        If (frmPrincipal.lbIdioma.Text = "Português") Then
                            MessageBox.Show("O campo data do agendamento não pode ficar vazio")
                            MtxtDataAgendamento.Focus()
                        End If
                        If (frmPrincipal.lbIdioma.Text = "English") Then
                            MessageBox.Show("The data field of the schedule can not be empty")
                            MtxtDataAgendamento.Focus()
                        End If
                        If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                            MessageBox.Show("El campo de datos de la agenda no puede estar vacío")
                            MtxtDataAgendamento.Focus()
                        End If
                    Else
                        If (cmbTipoAtendimento.Text) Is "" Then
                            If (frmPrincipal.lbIdioma.Text = "Português") Then
                                MessageBox.Show("O campo Tipo de atendimento não pode ficar vazio")
                                cmbTipoAtendimento.Focus()
                            End If
                            If (frmPrincipal.lbIdioma.Text = "English") Then
                                MessageBox.Show("The type of service field can not be empty")
                                cmbTipoAtendimento.Focus()
                            End If
                            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                MessageBox.Show("El tipo de servicio de campo no puede estar vacío")
                                cmbTipoAtendimento.Focus()
                            End If
                        Else
                            If (cmbStatusAgendamento.Text) Is "" Then
                                If (frmPrincipal.lbIdioma.Text = "Português") Then
                                    MessageBox.Show("O campo Status do agendamento não pode ficar vazio")
                                    cmbStatusAgendamento.Focus()
                                End If
                                If (frmPrincipal.lbIdioma.Text = "English") Then
                                    MessageBox.Show("The Status field of the schedule can not be empty")
                                    cmbStatusAgendamento.Focus()
                                End If
                                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                    MessageBox.Show("El campo Estado de la programación no puede estar vacío")
                                    cmbStatusAgendamento.Focus()
                                End If
                            Else

                                Dim x As String = MtxtDataAgendamento.Text

                                Dim y As String = x.Substring(x.Length - 4, 4)

                                txtAno.Text = y

                                Dim TestString As String = MtxtDataAgendamento.Text
                                Dim MidWords As String = Mid(TestString, 4, 2)
                                txtMes.Text = MidWords

                                If (txtCodCli.Text <> "" And txtCodAnimal.Text <> "" And txtCodFunc.Text <> "" And MtxtDataAgendamento.Text <> "" And cmbTipoAtendimento.Text <> "" And cmbStatusAgendamento.Text <> "") Then

                                    Cadastrar_Horario_Agenda(txtCodCli.Text, txtCodAnimal.Text, txtCodFunc.Text, MtxtDataAgendamento.Text, cmbTipoAtendimento.Text, cmbStatusAgendamento.Text, txtMes.Text, txtAno.Text)

                                    gerarcodigoagendamento()

                                    limpafiltroscliente()
                                    limpafiltrosanimal()
                                    limpafiltrosfuncionario()

                                    cmbFiltroCli.Text = Nothing
                                    cmbFiltroAnimal.Text = Nothing
                                    cmbFiltroFunc.Text = Nothing

                                    dgvCli.DataSource = Nothing
                                    limpacamposcliente()

                                    dgvAnimal.DataSource = Nothing
                                    limpacamposanimal()

                                    dgvFunc.DataSource = Nothing
                                    limpacamposfuncionario()

                                    MtxtDataAgendamento.Text = Nothing
                                    cmbTipoAtendimento.Text = Nothing
                                    cmbStatusAgendamento.Text = Nothing

                                    btnBuscaCli.Visible = False
                                    btnBuscaAnimal.Visible = False
                                    btnBuscaFunc.Visible = False

                                    If (frmPrincipal.lbIdioma.Text = "Português") Then
                                        MessageBox.Show("Efetue outro cadastro na agenda ou pressione o botão cancelar para realizar outra tarefa")
                                    End If
                                    If (frmPrincipal.lbIdioma.Text = "English") Then
                                        MessageBox.Show("Make another record in the schedule or press the cancel button to perform another task")
                                    End If
                                    If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                        MessageBox.Show("Hacer otro récord en el horario o pulse el botón de cancelación para realizar otra tarea")
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub cmbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltroCli.SelectedIndexChanged

        limpacamposcliente()

        txtConsultaCli.Text = Nothing
        MtxtFiltroCPFCli.Text = Nothing
        MtxtFiltroDataCli.Text = Nothing

        If cmbFiltroCli.Text = "Código" Or cmbFiltroCli.Text = "ID" Or cmbFiltroCli.Text = "Nome" Or cmbFiltroCli.Text = "Name" Or cmbFiltroCli.Text = "Nombre" Then
            limpafiltroscliente()
            txtConsultaCli.Visible = True
        End If

        If cmbFiltroCli.Text = "Data de cadastro" Or cmbFiltroCli.Text = "Date of registration" Or cmbFiltroCli.Text = "Fecha de registro" Then
            limpafiltroscliente()
            MtxtFiltroDataCli.Visible = True
        End If

        If cmbFiltroCli.Text = "CPF" Then
            limpafiltroscliente()
            MtxtFiltroCPFCli.Visible = True
        End If

        btnBuscaCli.Visible = True

    End Sub

    Private Sub cmbFiltroAnimal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltroAnimal.SelectedIndexChanged

        limpacamposanimal()

        txtConsultaAnimal.Text = Nothing
        MtxtFiltroDataCli.Text = Nothing

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

    Private Sub cmbFiltroFunc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltroFunc.SelectedIndexChanged

        limpacamposfuncionario()
        txtConsultaFunc.Text = Nothing
        MtxtFiltroCPFFunc.Text = Nothing
        MtxtFiltroDataCli.Text = Nothing

        If cmbFiltroFunc.Text = "Código" Or cmbFiltroFunc.Text = "ID" Or cmbFiltroFunc.Text = "Nome" Or cmbFiltroFunc.Text = "Name" Or cmbFiltroFunc.Text = "Nombre" Then
            limpafiltrosfuncionario()
            txtConsultaFunc.Visible = True
        End If

        If cmbFiltroFunc.Text = "Data de cadastro" Or cmbFiltroFunc.Text = "Date of registration" Or cmbFiltroFunc.Text = "Fecha de registro" Then
            limpafiltrosfuncionario()
            MtxtFiltroDataFunc.Visible = True
        End If

        If cmbFiltroFunc.Text = "CPF" Then
            limpafiltrosfuncionario()
            MtxtFiltroCPFFunc.Visible = True
        End If

        btnBuscaFunc.Visible = True

    End Sub
End Class