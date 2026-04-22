Imports System.Data.SqlClient
Public Class frmInternacaoOpcoes

    Private Sub frmInternacaoOpcoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (frmPrincipal.lbIdioma.Text = "English") Then

            Me.Text = "Select an option"
            btnCadastrarNovoLeito.BackgroundImage = My.Resources.cadastrar_novo_leito_english_fw
            btnInternarAnimal.BackgroundImage = My.Resources.internar_animal_english_fw

        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Seleccione una opción"
            btnCadastrarNovoLeito.BackgroundImage = My.Resources.cadastrar_novo_leito_spanish_fw
            btnInternarAnimal.BackgroundImage = My.Resources.internar_animal_spanish_fw

        End If

    End Sub

    Private Sub btnInternarAnimal_Click(sender As Object, e As EventArgs) Handles btnInternarAnimal.Click

        Me.Close()
        frmInternacao.Show()

    End Sub

    Private Sub btnCadastrarNovoLeito_Click(sender As Object, e As EventArgs) Handles btnCadastrarNovoLeito.Click

        Me.Hide()
        frmCadastrarLeito.Show()

    End Sub

End Class