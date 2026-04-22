Imports System.Data.SqlClient
Public Class frmAtendimento

    Private Sub btnConsultaGeral_Click(sender As Object, e As EventArgs) Handles btnConsultaGeral.Click

        Me.Close()
        frmConsultaGeral.Show()

    End Sub

    Private Sub btnVacinacao_Click(sender As Object, e As EventArgs) Handles btnVacinacao.Click

        Me.Close()
        frmVacinacao.Show()

    End Sub

    Private Sub btnInternacao_Click(sender As Object, e As EventArgs) Handles btnInternacao.Click

        Me.Close()
        frmInternacaoOpcoes.Show()

    End Sub

    Private Sub btnCirurgia_Click(sender As Object, e As EventArgs) Handles btnCirurgia.Click

        Me.Close()
        frmCirurgia.Show()

    End Sub

    Private Sub frmAtendimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (frmPrincipal.lbIdioma.Text = "English") Then

            Me.Text = "Select a call"

            btnConsultaGeral.BackgroundImage = My.Resources.consulta_geral_english_fw
            btnVacinacao.BackgroundImage = My.Resources.vacinacao_english_fw
            btnInternacao.BackgroundImage = My.Resources.internacao_english_fw
            btnCirurgia.BackgroundImage = My.Resources.cirurgia_english_fw

        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Seleccione un servicio"

            btnConsultaGeral.BackgroundImage = My.Resources.consulta_geral_spanish_fw
            btnVacinacao.BackgroundImage = My.Resources.vacinacao_spanish_fw
            btnInternacao.BackgroundImage = My.Resources.internacao_spanish_fw
            btnCirurgia.BackgroundImage = My.Resources.cirurgia_spanish_fw

        End If

    End Sub
End Class