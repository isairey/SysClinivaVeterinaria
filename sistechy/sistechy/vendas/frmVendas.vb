Public Class frmVendas

    Private Sub btnRealizarVenda_Click(sender As Object, e As EventArgs) Handles btnRealizarVenda.Click

        Me.Close()
        frmVendaParcial.Show()

    End Sub

    Private Sub btnConsultarVendas_Click(sender As Object, e As EventArgs) Handles btnConsultarVendas.Click

        Me.Close()
        frmConsultarVendas.Show()

    End Sub
End Class