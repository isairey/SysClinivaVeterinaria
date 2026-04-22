Public Class frmEntradaEstoque

    Private Sub frmEntradaEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (frmPrincipal.lbIdioma.Text = "English") Then

            Me.Text = "Input stock"

            btnAdicionarItem.BackgroundImage = My.Resources.adicionar_item_english_fw
            btnReabastecerItem.BackgroundImage = My.Resources.reabastecer_item_english_fw
            btnConsultarItem.BackgroundImage = My.Resources.consultar_itens_english_fw
            btnConsultaTodosItens.BackgroundImage = My.Resources.consultar_todos_itens_english_fw

        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Entrada de valores"

            btnAdicionarItem.BackgroundImage = My.Resources.adicionar_item_spanish_fw
            btnReabastecerItem.BackgroundImage = My.Resources.reabastecer_item_spanish_fw
            btnConsultarItem.BackgroundImage = My.Resources.consultar_itens_spanish_fw
            btnConsultaTodosItens.BackgroundImage = My.Resources.consultar_todos_itens_spanish_fw

        End If

    End Sub

    Private Sub btnAdicionarItem_Click(sender As Object, e As EventArgs) Handles btnAdicionarItem.Click

        Me.Close()
        frmAdicionarItem.Show()

    End Sub

    Private Sub btnReabastecerItem_Click(sender As Object, e As EventArgs) Handles btnReabastecerItem.Click

        Me.Close()
        frmReabastecerItem.Show()

    End Sub

    Private Sub btnConsultarItem_Click(sender As Object, e As EventArgs) Handles btnConsultarItem.Click

        Me.Close()
        frmConsultarItem.Show()

    End Sub

    Private Sub btnConsultaTodosItens_Click(sender As Object, e As EventArgs) Handles btnConsultaTodosItens.Click

        Me.Close()
        frmConsultarTodosItens.Show()

    End Sub
End Class