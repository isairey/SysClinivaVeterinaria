Imports System.Data.SqlClient
Public Class frmCadastro

    Private Sub nivelacesso()
        If (txtNivelAcesso.Text = "Atendente") Then
            btnCadastroFunc.Enabled = False
            btnCadastroForne.Enabled = False

            btnCadastroFunc.BackColor = Color.Silver
            btnCadastroForne.BackColor = Color.Silver
        End If
    End Sub

    Private Sub btnCadastroCliente_Click(sender As Object, e As EventArgs) Handles btnCadastroCliente.Click

        Me.Close()
        frmCadastro_cliente.Show()

    End Sub

    Private Sub btnCadastroFunc_Click(sender As Object, e As EventArgs) Handles btnCadastroFunc.Click

        Me.Close()
        frmCadastro_func.Show()

    End Sub

    Private Sub btnCadastroAnimal_Click(sender As Object, e As EventArgs) Handles btnCadastroAnimal.Click

        Me.Close()
        frmCadastro_animal.Show()

    End Sub

    Private Sub btnCadastroForne_Click(sender As Object, e As EventArgs) Handles btnCadastroForne.Click

        Me.Close()
        frmCadastro_forne.Show()

    End Sub

    Private Sub frmCadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.txtNivelAcesso.Text = frmPrincipal.txtNivelAcesso.Text

        If (frmPrincipal.lbIdioma.Text = "English") Then

            Me.Text = "Perform a registry"

            btnCadastroCliente.BackgroundImage = My.Resources.cadastro_cliente_english_fw
            btnCadastroAnimal.BackgroundImage = My.Resources.cadastro_animal_english_fw
            btnCadastroFunc.BackgroundImage = My.Resources.cadastro_funcionario_english_fw
            btnCadastroForne.BackgroundImage = My.Resources.cadastro_fornecedor_english_fw

        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Realizar un registro"

            btnCadastroCliente.BackgroundImage = My.Resources.cadastro_cliente_spanish_fw
            btnCadastroAnimal.BackgroundImage = My.Resources.cadastro_animal_spanish_fw
            btnCadastroFunc.BackgroundImage = My.Resources.cadastro_funcionario_spanish_fw
            btnCadastroForne.BackgroundImage = My.Resources.cadastro_fornecedor_spanish_fw

        End If

        nivelacesso()

    End Sub
End Class