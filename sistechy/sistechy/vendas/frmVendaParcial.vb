Imports System.Data.SqlClient
Imports System.Data
Public Class frmVendaParcial

    Private Sub gerarcodigovenda()

        Conectar()

        Dim codigo As Integer
        comando.CommandText = "SELECT Max(cod_venda) FROM venda"

        If IsDBNull(comando.ExecuteScalar) Then
            codigo = 1
            txtCodVenda.Text = codigo
        Else
            codigo = comando.ExecuteScalar + 1
            txtCodVenda.Text = codigo
        End If

    End Sub

    Private Sub cadastraritemvendabanco()

        Conectar()
        comando.CommandText = ("insert into itemvenda (cod_venda, cod_produto, nome_produto, valor_produto, mes_venda, ano_venda) values (@cod_venda, @cod_produto, @nome_produto, @valor_produto, @mes_venda, @ano_venda)")

        For i As Integer = 0 To dgvProdutos.Rows.Count - 1

            comando.Parameters.Clear()

            comando.Parameters.AddWithValue("@cod_venda",
                dgvProdutos.Rows(i).Cells(0).Value)
            comando.Parameters.AddWithValue("@cod_produto",
                dgvProdutos.Rows(i).Cells(1).Value)
            comando.Parameters.AddWithValue("@nome_produto",
                dgvProdutos.Rows(i).Cells(2).Value)
            comando.Parameters.AddWithValue("@valor_produto",
                dgvProdutos.Rows(i).Cells(3).Value)
            comando.Parameters.AddWithValue("@mes_venda", txtMes.Text)
            comando.Parameters.AddWithValue("@ano_venda", txtAno.Text)

            comando.ExecuteNonQuery()

            If i > dgvProdutos.Rows.Count Then
                Exit For
            End If

        Next

    End Sub

    Private Sub retirarprodutoestoque()

        Conectar()
        comando.CommandText = ("update produto set quantidade_produto =quantidade_produto-1 where cod_produto =@cod_produto")

        For i As Integer = 0 To dgvProdutos.Rows.Count - 1

            comando.Parameters.Clear()

            comando.Parameters.AddWithValue("@cod_produto",
                dgvProdutos.Rows(i).Cells(1).Value)
            
            comando.ExecuteNonQuery()

            If i > dgvProdutos.Rows.Count Then
                Exit For
            End If

        Next

    End Sub

    Dim produtos As New DataTable()
    Dim rowNew As DataRow
    Dim dsProdutos As New DataSet()
    Dim volume As Integer = 0

    Private Sub busca_produto_textbox()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        comando.CommandText = ("SELECT * FROM produto WHERE cod_produto = '" & txtCodProduto.Text & "'")

        Try
            Conectar()
            da.Fill(dt)
            txtNomeProduto.Text = dt.Rows(0)("nome_produto").ToString
            txtValorProduto.Text = dt.Rows(0)("preco_produto").ToString
            txtQuantidade.Text = dt.Rows(0)("quantidade_produto").ToString

            Desconectar()

        Catch ex As Exception
            MessageBox.Show("Nenhum produto encontrado com esse código")
        End Try

    End Sub

    Private Sub frmVendaParcial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        gerarcodigovenda()

        dsProdutos.Tables.Add(produtos)

        dsProdutos.Tables(0).Columns.Add("Código da venda", GetType(Integer))
        dsProdutos.Tables(0).Columns.Add("Código do produto", GetType(Integer))
        dsProdutos.Tables(0).Columns.Add("Nome do produto", GetType(String))
        dsProdutos.Tables(0).Columns.Add("Valor do produto", GetType(String))

        dgvProdutos.DataSource = dsProdutos.Tables(0)

        Me.lbData.Text = frmPrincipal.lbData.Text

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Dim message As Integer

        message = MessageBox.Show("Deseja mesmo cancelar a venda ?", _
                                         "Confirma ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If message = vbYes Then

            Me.Close()
            frmPrincipal.Visible = True

        End If

    End Sub


    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click

        If (txtQuantidade.Text < 1) Then
            MessageBox.Show("Produto em falta no estoque!")
        Else

            volume = volume + 1
            txtQuantidade.Text = txtQuantidade.Text - 1

            txtItens.Text = volume

            rowNew = dsProdutos.Tables(0).NewRow

            rowNew("Código da venda") = txtCodVenda.Text
            rowNew("Código do produto") = txtCodProduto.Text
            rowNew("Nome do produto") = txtNomeProduto.Text
            rowNew("Valor do produto") = txtValorProduto.Text
            dsProdutos.Tables(0).Rows.Add(rowNew)
            dsProdutos.AcceptChanges()

            Dim linha As DataGridViewRow
            Dim valor As Double

            For Each linha In dgvProdutos.Rows
                valor = valor + linha.Cells(3).Value
            Next
            lbSubTotal2.Text = FormatCurrency(valor)
        End If

    End Sub

    Private Sub txtCodProduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodProduto.KeyDown

        If e.KeyCode = Keys.Enter Then
            busca_produto_textbox()
        End If

    End Sub

    Private Sub txtCodProduto_TextChanged(sender As Object, e As EventArgs) Handles txtCodProduto.TextChanged

        txtNomeProduto.Text = Nothing
        txtValorProduto.Text = Nothing

    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click

        dgvProdutos.Rows.Remove(dgvProdutos.CurrentRow)

        volume = volume - 1
        txtQuantidade.Text = txtQuantidade.Text + 1

        txtItens.Text = volume

        Dim linha As DataGridViewRow
        Dim valor As Double

        For Each linha In dgvProdutos.Rows
            valor = valor + linha.Cells(3).Value
        Next
        lbSubTotal2.Text = FormatCurrency(valor)

    End Sub

    Private Sub btnProsseguirVenda_Click(sender As Object, e As EventArgs) Handles btnProsseguirVenda.Click

        Dim message As Integer

        message = MessageBox.Show("Confirma a venda de todos os produtos listados ? ", _
                                         "Confirma ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If message = vbYes Then

            Dim x As String = lbData.Text

            Dim y As String = x.Substring(x.Length - 4, 4)

            txtAno.Text = y

            Dim TestString As String = lbData.Text
            Dim MidWords As String = Mid(TestString, 4, 2)
            txtMes.Text = MidWords

            cadastraritemvendabanco()
            retirarprodutoestoque()

            frmFinalizaVenda.txtCodVenda.Text = Me.txtCodVenda.Text
            frmFinalizaVenda.txtItens.Text = Me.txtItens.Text
            frmFinalizaVenda.txtValorTotal.Text = Me.lbSubTotal2.Text
            Me.Close()
            frmFinalizaVenda.Show()
        End If
    End Sub
End Class