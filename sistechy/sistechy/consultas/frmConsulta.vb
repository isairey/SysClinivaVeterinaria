Imports System.Data.SqlClient
Public Class frmConsulta

    Private Sub nivelacesso()
        If (txtNivelAcesso.Text = "Atendente") Then

            btnConsultaFunc.Enabled = False
            btnConsultaForne.Enabled = False

            btnConsultaFunc.BackColor = Color.Silver
            btnConsultaForne.BackColor = Color.Silver
        End If
    End Sub

    Private Sub btnConsultaCliente_Click(sender As Object, e As EventArgs) Handles btnConsultaCliente.Click

        Me.Close()
        frmConsulta_cliente.Show()

    End Sub

    Private Sub btnConsultaAnimal_Click(sender As Object, e As EventArgs) Handles btnConsultaAnimal.Click

        Me.Close()
        frmConsulta_animal.Show()

    End Sub

    Private Sub btnConsultaFunc_Click(sender As Object, e As EventArgs) Handles btnConsultaFunc.Click

        Me.Close()
        frmConsulta_func.Show()

    End Sub

    Private Sub btnConsultaForne_Click(sender As Object, e As EventArgs) Handles btnConsultaForne.Click

        Me.Close()
        frmConsulta_forne.Show()

    End Sub

    Private Sub frmConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.txtNivelAcesso.Text = frmPrincipal.txtNivelAcesso.Text

        If (frmPrincipal.lbIdioma.Text = "English") Then

            Me.Text = "Select a query"

            btnConsultaCliente.BackgroundImage = My.Resources.consultar_cliente_english_fw
            btnConsultaAnimal.BackgroundImage = My.Resources.consultar_animal_english_fw
            btnConsultaFunc.BackgroundImage = My.Resources.consultar_funcionario_english_fw
            btnConsultaForne.BackgroundImage = My.Resources.consultar_fornecedor_english_fw

        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Seleccione una consulta"

            btnConsultaCliente.BackgroundImage = My.Resources.consultar_cliente_spanish_fw
            btnConsultaAnimal.BackgroundImage = My.Resources.consultar_animal_spanish_fw
            btnConsultaFunc.BackgroundImage = My.Resources.consultar_fornecedor_spanish_fw
            btnConsultaForne.BackgroundImage = My.Resources.consultar_fornecedor_spanish_fw

        End If

        nivelacesso()

    End Sub
End Class