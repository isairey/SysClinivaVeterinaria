Public Class frmDetalhesVenda

    Private Sub frmDetalhesVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (txtFormaPagamento.Text = "Cartão de crédito") Or (txtFormaPagamento.Text = "Cartão de débito") Then
            lbCartaoUtilizado.Visible = True
            txtCartaoUtilizado.Visible = True
        End If

        dgvProdutos.DataSource = Consulta_itemvenda(txtCodVenda.Text)

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        Me.Close()
        frmConsultarVendas.Visible = True

    End Sub
End Class