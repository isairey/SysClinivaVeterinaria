Imports System.Data.SqlClient
Public Class FrmAlteraHorario

    Private Sub FrmAlteraHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (frmPrincipal.lbIdioma.Text = "Português") Then

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

            Me.Text = "Change time"

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

            lbCodAgendamento.Text = "Scheduling ID"
            lbCodCli.Text = "Client ID"
            lbCodAnimal.Text = "Animal ID"
            lbCodFunc.Text = "Employee ID"
            lbDataAgendamento.Text = "Data scheduling"
            lbStatusAgendamento.Text = "Status scheduling"
            lbTipoAtendimento.Text = "Type of care"

            pbxBanner.BackgroundImage = My.Resources.banner_alterar_horario_english_fw
            btnCancelar.BackgroundImage = My.Resources.cancelar_english_fw
            btnAlterarHorario.BackgroundImage = My.Resources.atualizar_dados_english_fw

        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Cambiar tiempo"

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

            lbCodAgendamento.Text = "ID programación"
            lbCodCli.Text = "ID de cliente"
            lbCodAnimal.Text = "ID de animal"
            lbCodFunc.Text = "ID de empleado"
            lbDataAgendamento.Text = "Fecha de programación"
            lbStatusAgendamento.Text = "Estado de programación"
            lbTipoAtendimento.Text = "Tipo de servicio"

            pbxBanner.BackgroundImage = My.Resources.banner_alterar_horario_spanish_fw
            btnCancelar.BackgroundImage = My.Resources.cancelar_spanish_fw
            btnAlterarHorario.BackgroundImage = My.Resources.atualizar_dados_horario_spanish_fw

        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Dim message_portugues As Integer
        Dim message_english As Integer
        Dim message_spanish As Integer

        If (frmPrincipal.lbIdioma.Text = "Português") Then

            message_portugues = MessageBox.Show("Deseja mesmo cancelar a operação ?", _
                                          "Confirma ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If message_portugues = vbYes Then

                Me.Close()

                cmbTipoAtendimento.Items.Remove("Cirurgia")
                cmbTipoAtendimento.Items.Remove("Consulta")
                cmbTipoAtendimento.Items.Remove("Internação")
                cmbTipoAtendimento.Items.Remove("Vacinação")

                cmbStatusAgendamento.Items.Remove("Marcado")
                cmbStatusAgendamento.Items.Remove("Confirmado")
                cmbStatusAgendamento.Items.Remove("Aguardando")
                cmbStatusAgendamento.Items.Remove("Em atendimento")
                cmbStatusAgendamento.Items.Remove("Atendido")
                cmbStatusAgendamento.Items.Remove("Cancelado")
                cmbStatusAgendamento.Items.Remove("Faltou")

                frmPrincipal.Visible = True

            End If
        End If

        If (frmPrincipal.lbIdioma.Text = "English") Then

            message_english = MessageBox.Show("Want even cancel the operation ?", _
                                          "Confirm ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If message_english = vbYes Then

                Me.Close()

                cmbTipoAtendimento.Items.Remove("Surgery")
                cmbTipoAtendimento.Items.Remove("Consultation")
                cmbTipoAtendimento.Items.Remove("Hospitalization")
                cmbTipoAtendimento.Items.Remove("Vaccination")

                cmbStatusAgendamento.Items.Remove("Marked")
                cmbStatusAgendamento.Items.Remove("Confirmed")
                cmbStatusAgendamento.Items.Remove("Waiting")
                cmbStatusAgendamento.Items.Remove("In progress")
                cmbStatusAgendamento.Items.Remove("Attended")
                cmbStatusAgendamento.Items.Remove("Canceled")
                cmbStatusAgendamento.Items.Remove("Lacked")

                frmPrincipal.Visible = True

            End If
        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                message_spanish = MessageBox.Show("Quieres incluso cancelar la operación ?", _
                                              "Confirma ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If

            If message_spanish = vbYes Then

                Me.Close()

                cmbTipoAtendimento.Items.Remove("Cirugía")
                cmbTipoAtendimento.Items.Remove("Consulta")
                cmbTipoAtendimento.Items.Remove("Hospitalización")
                cmbTipoAtendimento.Items.Remove("Vacunación")

                cmbStatusAgendamento.Items.Remove("Marcado")
                cmbStatusAgendamento.Items.Remove("Confirmado")
                cmbStatusAgendamento.Items.Remove("Espera")
                cmbStatusAgendamento.Items.Remove("En el servicio")
                cmbStatusAgendamento.Items.Remove("Asistido")
                cmbStatusAgendamento.Items.Remove("Cancelado")
                cmbStatusAgendamento.Items.Remove("Perdida")

                frmPrincipal.Visible = True

            End If
        End If

    End Sub

    Private Sub btnAlterarHorario_Click(sender As Object, e As EventArgs) Handles btnAlterarHorario.Click

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "update agenda set cod_cli= @cod_cliente, cod_animal= @cod_animal, cod_func= @cod_func, data_agenda= @data_agenda, tipo_agenda= @tipo_agenda, status_agenda= @status_agenda where cod_agenda= @cod_agendamento"
        comando.Parameters.AddWithValue("@cod_agendamento", txtCodAgendamento.Text)
        comando.Parameters.AddWithValue("@cod_cliente", txtCodCli.Text)
        comando.Parameters.AddWithValue("@cod_animal", txtCodAnimal.Text)
        comando.Parameters.AddWithValue("@cod_func", txtCodFunc.Text)
        comando.Parameters.AddWithValue("@data_agenda", MtxtDataAgendamento.Text)
        comando.Parameters.AddWithValue("@tipo_agenda", cmbTipoAtendimento.Text)
        comando.Parameters.AddWithValue("@status_agenda", cmbStatusAgendamento.Text)


        comando.ExecuteNonQuery()
        Desconectar()

        If (frmPrincipal.lbIdioma.Text = "Português") Then
            MessageBox.Show("Dados da agenda alterados com sucesso!")
        End If

        If (frmPrincipal.lbIdioma.Text = "English") Then
            MessageBox.Show("Schedule data changed successfully!")
        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then
            MessageBox.Show("Calendario datos cambiados con éxito!")
        End If

        txtCodAgendamento.Text = Nothing
        txtCodCli.Text = Nothing
        txtCodAnimal.Text = Nothing
        txtCodFunc.Text = Nothing
        MtxtDataAgendamento.Text = Nothing
        cmbTipoAtendimento.Text = Nothing
        cmbStatusAgendamento.Text = Nothing

        cmbTipoAtendimento.Items.Remove("Cirurgia")
        cmbTipoAtendimento.Items.Remove("Consulta")
        cmbTipoAtendimento.Items.Remove("Internação")
        cmbTipoAtendimento.Items.Remove("Vacinação")

        cmbStatusAgendamento.Items.Remove("Marcado")
        cmbStatusAgendamento.Items.Remove("Confirmado")
        cmbStatusAgendamento.Items.Remove("Aguardando")
        cmbStatusAgendamento.Items.Remove("Em atendimento")
        cmbStatusAgendamento.Items.Remove("Atendido")
        cmbStatusAgendamento.Items.Remove("Cancelado")
        cmbStatusAgendamento.Items.Remove("Faltou")

        cmbTipoAtendimento.Items.Remove("Surgery")
        cmbTipoAtendimento.Items.Remove("Consultation")
        cmbTipoAtendimento.Items.Remove("Hospitalization")
        cmbTipoAtendimento.Items.Remove("Vaccination")

        cmbStatusAgendamento.Items.Remove("Marked")
        cmbStatusAgendamento.Items.Remove("Confirmed")
        cmbStatusAgendamento.Items.Remove("Waiting")
        cmbStatusAgendamento.Items.Remove("In progress")
        cmbStatusAgendamento.Items.Remove("Attended")
        cmbStatusAgendamento.Items.Remove("Canceled")
        cmbStatusAgendamento.Items.Remove("Lacked")

        cmbTipoAtendimento.Items.Remove("Cirugía")
        cmbTipoAtendimento.Items.Remove("Consulta")
        cmbTipoAtendimento.Items.Remove("Hospitalización")
        cmbTipoAtendimento.Items.Remove("Vacunación")

        cmbStatusAgendamento.Items.Remove("Marcado")
        cmbStatusAgendamento.Items.Remove("Confirmado")
        cmbStatusAgendamento.Items.Remove("Espera")
        cmbStatusAgendamento.Items.Remove("En el servicio")
        cmbStatusAgendamento.Items.Remove("Asistido")
        cmbStatusAgendamento.Items.Remove("Cancelado")
        cmbStatusAgendamento.Items.Remove("Perdida")

        Me.Close()
        frmPrincipal.Show()

    End Sub
End Class