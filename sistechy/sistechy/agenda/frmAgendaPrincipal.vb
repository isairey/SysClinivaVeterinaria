Imports System.Data.SqlClient
Public Class frmAgendaPrincipal

    Private Sub limpafiltros()

        lbCod.Visible = False
        lbData.Visible = False
        lbDataInicial.Visible = False
        lbDataFinal.Visible = False
        lbStatus.Visible = False
        lbTipoAtendimento.Visible = False

        txtFiltroCod.Visible = False
        MtxtFiltroData.Visible = False
        MtxtFiltroEntreData1.Visible = False
        MtxtFiltroEntreData2.Visible = False
        cmbFiltroStatus.Visible = False
        cmbTipoAtendimento.Visible = False

    End Sub

    Private Sub frmAgendaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (frmPrincipal.lbIdioma.Text = "Português") Then

            cmbTiposFiltro.Items.Add("Todos")
            cmbTiposFiltro.Items.Add("Data")
            cmbTiposFiltro.Items.Add("Entre duas datas")
            cmbTiposFiltro.Items.Add("Código de cliente")
            cmbTiposFiltro.Items.Add("Código de funcionário")
            cmbTiposFiltro.Items.Add("Código de animal")
            cmbTiposFiltro.Items.Add("Tipo de atendimento")
            cmbTiposFiltro.Items.Add("Status")

            cmbTipoAtendimento.Items.Add("Cirurgia")
            cmbTipoAtendimento.Items.Add("Consulta")
            cmbTipoAtendimento.Items.Add("Internação")
            cmbTipoAtendimento.Items.Add("Vacinação")

            cmbFiltroStatus.Items.Add("Marcado")
            cmbFiltroStatus.Items.Add("Confirmado")
            cmbFiltroStatus.Items.Add("Aguardando")
            cmbFiltroStatus.Items.Add("Em atendimento")
            cmbFiltroStatus.Items.Add("Atendido")
            cmbFiltroStatus.Items.Add("Cancelado")
            cmbFiltroStatus.Items.Add("Faltou")

        End If

        If (frmPrincipal.lbIdioma.Text = "English") Then

            Me.Text = "Agenda"

            cmbTiposFiltro.Items.Add("All")
            cmbTiposFiltro.Items.Add("Date")
            cmbTiposFiltro.Items.Add("Between two dates")
            cmbTiposFiltro.Items.Add("Client ID")
            cmbTiposFiltro.Items.Add("Employee ID")
            cmbTiposFiltro.Items.Add("Animal ID")
            cmbTiposFiltro.Items.Add("Type of care")
            cmbTiposFiltro.Items.Add("Status")

            cmbTipoAtendimento.Items.Add("Surgery")
            cmbTipoAtendimento.Items.Add("Consultation")
            cmbTipoAtendimento.Items.Add("Hospitalization")
            cmbTipoAtendimento.Items.Add("Vaccination")

            cmbFiltroStatus.Items.Add("Marked")
            cmbFiltroStatus.Items.Add("Confirmed")
            cmbFiltroStatus.Items.Add("Waiting")
            cmbFiltroStatus.Items.Add("In progress")
            cmbFiltroStatus.Items.Add("Attended")
            cmbFiltroStatus.Items.Add("Canceled")
            cmbFiltroStatus.Items.Add("Lacked")

            btnFiltrar.Text = "Filter"

            lbFiltrarPor.Text = "Filter by:"
            lbData.Text = "Date"
            lbDataInicial.Text = "Start date"
            lbDataFinal.Text = "End date"
            lbCod.Text = "ID"
            lbTipoAtendimento.Text = "Type of care"
            lbStatus.Text = "Status"

            pbxBanner.BackgroundImage = My.Resources.banner_agenda_english_fw
            btnMarcarNovoHorario.BackgroundImage = My.Resources.marcar_novo_horario_english_fw
            btnAlterarDados.BackgroundImage = My.Resources.atualizar_dados_horario_english_fw
            btnCancelar.BackgroundImage = My.Resources.cancelar_english_fw

        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Oden del día"

            cmbTiposFiltro.Items.Add("Todos")
            cmbTiposFiltro.Items.Add("Fecha")
            cmbTiposFiltro.Items.Add("Entre dos fechas")
            cmbTiposFiltro.Items.Add("ID de cliente")
            cmbTiposFiltro.Items.Add("ID de empleado")
            cmbTiposFiltro.Items.Add("ID de animal")
            cmbTiposFiltro.Items.Add("Tipo de servicio")
            cmbTiposFiltro.Items.Add("Estado")

            cmbTipoAtendimento.Items.Add("Cirugía")
            cmbTipoAtendimento.Items.Add("Consulta")
            cmbTipoAtendimento.Items.Add("Hospitalización")
            cmbTipoAtendimento.Items.Add("Vacunación")

            cmbFiltroStatus.Items.Add("Marcado")
            cmbFiltroStatus.Items.Add("Confirmado")
            cmbFiltroStatus.Items.Add("Espera")
            cmbFiltroStatus.Items.Add("En el servicio")
            cmbFiltroStatus.Items.Add("Asistido")
            cmbFiltroStatus.Items.Add("Cancelado")
            cmbFiltroStatus.Items.Add("Perdida")

            btnFiltrar.Text = "Filtro"

            lbFiltrarPor.Text = "Filtrar por:"
            lbData.Text = "Fecha"
            lbDataInicial.Text = "Fecha de inicio"
            lbDataFinal.Text = "Fecha de finalización"
            lbCod.Text = "ID"
            lbTipoAtendimento.Text = "Tipo de servicio"
            lbStatus.Text = "Estado"

            pbxBanner.BackgroundImage = My.Resources.banner_agenda_spanish_fw
            btnMarcarNovoHorario.BackgroundImage = My.Resources.marcar_novo_horario_spanish_fw
            btnAlterarDados.BackgroundImage = My.Resources.atualizar_dados_horario_spanish_fw
            btnCancelar.BackgroundImage = My.Resources.cancelar_spanish_fw

        End If

    End Sub

    Private Sub cmbTiposFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTiposFiltro.SelectedIndexChanged

        If (cmbTiposFiltro.Text = "Todos") Or (cmbTiposFiltro.Text = "All") Then

            limpafiltros()

        End If

        If (cmbTiposFiltro.Text = "Data") Or (cmbTiposFiltro.Text = "Date") Or (cmbTiposFiltro.Text = "Fecha") Then

            limpafiltros()

            lbData.Visible = True
            MtxtFiltroData.Visible = True
        End If

        If (cmbTiposFiltro.Text = "Entre duas datas") Or (cmbTiposFiltro.Text = "Between two dates") Or (cmbTiposFiltro.Text = "Entre dos fechas") Then

            limpafiltros()

            lbDataInicial.Visible = True
            lbDataFinal.Visible = True
            MtxtFiltroEntreData1.Visible = True
            MtxtFiltroEntreData2.Visible = True
        End If

        If (cmbTiposFiltro.Text = "Código de cliente") Or (cmbTiposFiltro.Text = "Client ID") Or (cmbTiposFiltro.Text = "ID de cliente") Then

            limpafiltros()

            lbCod.Visible = True
            txtFiltroCod.Visible = True

        End If

        If (cmbTiposFiltro.Text = "Código de funcionário") Or (cmbTiposFiltro.Text = "Employee ID") Or (cmbTiposFiltro.Text = "ID de empleado") Then

            limpafiltros()

            lbCod.Visible = True
            txtFiltroCod.Visible = True

        End If

        If (cmbTiposFiltro.Text = "Código de animal") Or (cmbTiposFiltro.Text = "Animal ID") Or (cmbTiposFiltro.Text = "ID de animal") Then

            limpafiltros()

            lbCod.Visible = True
            txtFiltroCod.Visible = True

        End If

        If (cmbTiposFiltro.Text = "Tipo de atendimento") Or (cmbTiposFiltro.Text = "Type of care") Or (cmbTiposFiltro.Text = "Tipo de servicio") Then

            limpafiltros()

            lbTipoAtendimento.Visible = True
            cmbTipoAtendimento.Visible = True

        End If

        If (cmbTiposFiltro.Text = "Status") Or (cmbTiposFiltro.Text = "Estado") Then

            limpafiltros()

            lbStatus.Visible = True
            cmbFiltroStatus.Visible = True

        End If

    End Sub

    Private Sub btFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        If (cmbTiposFiltro.Text = "Todos") Or (cmbTiposFiltro.Text = "All") Then

            Conectar()

            dgvAgenda.DataSource = Filtro_Agenda_todos()

        End If

        If (cmbTiposFiltro.Text = "Data") Or (cmbTiposFiltro.Text = "Date") Or (cmbTiposFiltro.Text = "Fecha") Then

            If Not (MtxtFiltroData.MaskFull) Then
                If (frmPrincipal.lbIdioma.Text = "Português") Then
                    MessageBox.Show("Informe uma data válida")
                    MtxtFiltroData.Focus()
                End If
                If (frmPrincipal.lbIdioma.Text = "English") Then
                    MessageBox.Show("Enter a valid date")
                    MtxtFiltroData.Focus()
                End If
                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                    MessageBox.Show("Introduzca una fecha válida")
                    MtxtFiltroData.Focus()
                End If
            Else

                Conectar()

                Dim sr As New SelectionRange()
                sr.Start = Date.Parse(Me.MtxtFiltroData.Text)
                Me.CalendarioAgenda.SelectionRange = sr

                dgvAgenda.DataSource = Filtro_Agenda_data(MtxtFiltroData.Text)

            End If
        End If

        If (cmbTiposFiltro.Text = "Entre duas datas") Or (cmbTiposFiltro.Text = "Between two dates") Or (cmbTiposFiltro.Text = "Entre dos fechas") Then

            If Not (MtxtFiltroEntreData1.MaskFull And MtxtFiltroEntreData2.MaskFull) Then
                If (frmPrincipal.lbIdioma.Text = "Português") Then
                    MessageBox.Show("Informe duas datas válidas")
                End If
                If (frmPrincipal.lbIdioma.Text = "English") Then
                    MessageBox.Show("Enter two valid dates")
                End If
                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                    MessageBox.Show("Dígale a dos fechas válidas")
                End If
            Else

                Conectar()

                Dim sr As New SelectionRange()
                sr.Start = DateTime.Parse(Me.MtxtFiltroEntreData1.Text)
                sr.End = DateTime.Parse(Me.MtxtFiltroEntreData2.Text)
                Me.CalendarioAgenda.SelectionRange = sr

                dgvAgenda.DataSource = Filtro_Agenda_entre_datas(MtxtFiltroEntreData1.Text, MtxtFiltroEntreData2.Text)

            End If
        End If

        If (cmbTiposFiltro.Text = "Código de cliente") Or (cmbTiposFiltro.Text = "Client ID") Or (cmbTiposFiltro.Text = "ID de Cliente") Then

            If (txtFiltroCod.Text) Is "" Then
                If (frmPrincipal.lbIdioma.Text = "Português") Then
                    MessageBox.Show("Informe o código do cliente")
                End If
                If (frmPrincipal.lbIdioma.Text = "English") Then
                    MessageBox.Show("Inform the client ID")
                End If
                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                    MessageBox.Show("Informar al código de cliente")
                End If
            Else

                Conectar()

                dgvAgenda.DataSource = Filtro_Agenda_codigo_cliente(txtFiltroCod.Text)

            End If
        End If

        If (cmbTiposFiltro.Text = "Código de funcionário") Or (cmbTiposFiltro.Text = "Employee ID") Or (cmbTiposFiltro.Text = "ID de empleado") Then

            If (txtFiltroCod.Text) Is "" Then
                If (frmPrincipal.lbIdioma.Text = "Português") Then
                    MessageBox.Show("Informe o código do funcionário")
                End If
                If (frmPrincipal.lbIdioma.Text = "English") Then
                    MessageBox.Show("Inform the Employee ID")
                End If
                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                    MessageBox.Show("Introduzca el código oficial")
                End If
            Else

                Conectar()

                dgvAgenda.DataSource = Filtro_Agenda_codigo_funcionario(txtFiltroCod.Text)

            End If
        End If

        If (cmbTiposFiltro.Text = "Código de animal") Or (cmbTiposFiltro.Text = "Animal ID") Or (cmbTiposFiltro.Text = "ID de animal") Then

            If (txtFiltroCod.Text) Is "" Then
                If (frmPrincipal.lbIdioma.Text = "Português") Then
                    MessageBox.Show("Informe o código do animal")
                End If
                If (frmPrincipal.lbIdioma.Text = "English") Then
                    MessageBox.Show("Inform the animal ID")
                End If
                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                    MessageBox.Show("Introduzca el código del animal")
                End If
            Else

                Conectar()

                dgvAgenda.DataSource = Filtro_Agenda_codigo_animal(txtFiltroCod.Text)

            End If
        End If

        If (cmbTiposFiltro.Text = "Tipo de atendimento") Or (cmbTiposFiltro.Text = "Type of care") Or (cmbTiposFiltro.Text = "Tipo de servicio") Then

            If (cmbTipoAtendimento.Text) Is "" Then
                If (frmPrincipal.lbIdioma.Text = "Português") Then
                    MessageBox.Show("Selecione o tipo de atendimento")
                End If
                If (frmPrincipal.lbIdioma.Text = "English") Then
                    MessageBox.Show("Select the type of care")
                End If
                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                    MessageBox.Show("Seleccione el tipo de atención")
                End If
            Else

                Conectar()

                dgvAgenda.DataSource = Filtro_Agenda_tipo_atendimento(cmbTipoAtendimento.Text)

            End If
        End If

        If (cmbTiposFiltro.Text = "Status") Or (cmbTiposFiltro.Text = "Estado") Then

            If (cmbFiltroStatus.Text) Is "" Then
                If (frmPrincipal.lbIdioma.Text = "Português") Then
                    MessageBox.Show("Selecione o status")
                End If
                If (frmPrincipal.lbIdioma.Text = "English") Then
                    MessageBox.Show("Select the status")
                End If
                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                    MessageBox.Show("Seleccione el estado")
                End If
            Else

                Conectar()

                dgvAgenda.DataSource = Filtro_Agenda_status(cmbFiltroStatus.Text)

            End If
        End If

    End Sub

    Private Sub CalendarioAgenda_DateChanged(sender As Object, e As DateRangeEventArgs) Handles CalendarioAgenda.DateChanged

        txtDataCalendario.Text = CalendarioAgenda.SelectionStart

        Conectar()

        dgvAgenda.DataSource = Filtro_Agenda_data(txtDataCalendario.Text)

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

    Private Sub btnMarcarNovoHorario_Click(sender As Object, e As EventArgs) Handles btnMarcarNovoHorario.Click

        Me.Close()
        frmNovoHorario.Show()

    End Sub

    Private Sub btnAlterarDados_Click(sender As Object, e As EventArgs) Handles btnAlterarDados.Click

        If (txtCodAgendamento.Text) Is "" Then
            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("Selecione um horário na agenda para alterá-lo")
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("Select a time on the agenda to change it")
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("Seleccione un tiempo en la agenda para cambiarlo")
            End If
        Else

            Me.Close()
            FrmAlteraHorario.ShowDialog()

        End If

    End Sub

    Private Sub dgvAgenda_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAgenda.CellClick

        Dim i As Integer
        i = dgvAgenda.CurrentRow.Index
        FrmAlteraHorario.txtCodAgendamento.Text = dgvAgenda.Item(0, i).Value
        Me.txtCodAgendamento.Text = dgvAgenda.Item(0, i).Value
        FrmAlteraHorario.txtCodCli.Text = dgvAgenda.Item(1, i).Value
        FrmAlteraHorario.txtCodAnimal.Text = dgvAgenda.Item(2, i).Value
        FrmAlteraHorario.txtCodFunc.Text = dgvAgenda.Item(3, i).Value
        FrmAlteraHorario.MtxtDataAgendamento.Text = dgvAgenda.Item(4, i).Value
        FrmAlteraHorario.cmbTipoAtendimento.Text = dgvAgenda.Item(5, i).Value
        FrmAlteraHorario.cmbStatusAgendamento.Text = dgvAgenda.Item(6, i).Value

    End Sub

End Class