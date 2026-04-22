Public Class frmReabastecerItem

    Private Sub limpacamposproduto()

        dgvProduto.DataSource = Nothing
        txtCod.Text = Nothing
        txtTipoProduto.Text = Nothing
        txtNomeProduto.Text = Nothing
        MtxtDataValidade.Text = Nothing
        txtQuantidadeProduto.Text = Nothing
        txtQuantidadeMaxima.Text = Nothing

    End Sub

    Private Sub frmReabastecerItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (frmPrincipal.lbIdioma.Text = "Português") Then

            cmbFiltro.Items.Add("Código")
            cmbFiltro.Items.Add("Tipo")
            cmbFiltro.Items.Add("Nome")
            cmbFiltro.Items.Add("Marca")
            cmbFiltro.Items.Add("Data de validade")

            cmbFiltroTipoProduto.Items.Add("Medicamento")
            cmbFiltroTipoProduto.Items.Add("Vacina")
            cmbFiltroTipoProduto.Items.Add("Higiene")
            cmbFiltroTipoProduto.Items.Add("Brinquedo")
            cmbFiltroTipoProduto.Items.Add("Outro")

        End If


        If (frmPrincipal.lbIdioma.Text = "English") Then

            Me.Text = "Replenish item"

            cmbFiltro.Items.Add("ID")
            cmbFiltro.Items.Add("Type")
            cmbFiltro.Items.Add("Name")
            cmbFiltro.Items.Add("Mark")
            cmbFiltro.Items.Add("Expiration date")

            cmbFiltroTipoProduto.Items.Add("Drug")
            cmbFiltroTipoProduto.Items.Add("Vaccine")
            cmbFiltroTipoProduto.Items.Add("Hygiene")
            cmbFiltroTipoProduto.Items.Add("Toy")
            cmbFiltroTipoProduto.Items.Add("Other")

            gpxProdutos.Text = "Product Data"

            lbBuscarPor.Text = "Search by: "
            lbCod.Text = "ID"
            lbTipoProduto.Text = "Type"
            lbNome.Text = "Name"
            lbDataValidade.Text = "Expiration date"
            lbQuantidade.Text = "Amount"
            lbQuantidadeMaxima.Text = "Maximum amount"

            btnBuscar.Text = "Search"

            btnCancelar.BackgroundImage = My.Resources.cancelar_english_fw
            btnConfirmar.BackgroundImage = My.Resources.salva_alteracoes_english_fw

        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Reponer artículo"

            cmbFiltro.Items.Add("ID")
            cmbFiltro.Items.Add("Clase")
            cmbFiltro.Items.Add("Nombre")
            cmbFiltro.Items.Add("Marca")
            cmbFiltro.Items.Add("Fecha de expiración")

            cmbFiltroTipoProduto.Items.Add("Droga")
            cmbFiltroTipoProduto.Items.Add("Vacuna")
            cmbFiltroTipoProduto.Items.Add("Higiene")
            cmbFiltroTipoProduto.Items.Add("Juguete")
            cmbFiltroTipoProduto.Items.Add("Otro")

            gpxProdutos.Text = "Datos del producto"

            lbBuscarPor.Text = "Buscar por: "
            lbCod.Text = "ID"
            lbTipoProduto.Text = "Clase"
            lbNome.Text = "Nombre"
            lbDataValidade.Text = "Fecha de expiración"
            lbQuantidade.Text = "Cantidad"
            lbQuantidadeMaxima.Text = "Cantidad máxima"

            btnCancelar.BackgroundImage = My.Resources.cancelar_spanish_fw
            btnConfirmar.BackgroundImage = My.Resources.salva_alteracoes_spanish_fw

        End If

    End Sub

    Private Sub btnBuscaProduto_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        limpacamposproduto()
        Conectar()

        If cmbFiltro.Text = "Código" Or cmbFiltro.Text = "ID" Then
            dgvProduto.DataSource = Consulta_produto_codigo(txtBuscaProduto.Text)
        End If

        If cmbFiltro.Text = "Tipo" Or cmbFiltro.Text = "Type" Or cmbFiltro.Text = "Clase" Then
            dgvProduto.DataSource = Consulta_produto_tipo(cmbFiltroTipoProduto.Text)
        End If

        If cmbFiltro.Text = "Nome" Or cmbFiltro.Text = "Name" Or cmbFiltro.Text = "Nombre" Then
            dgvProduto.DataSource = Consulta_produto_nome(txtBuscaProduto.Text)
        End If

        If cmbFiltro.Text = "Marca" Or cmbFiltro.Text = "Mark" Then
            dgvProduto.DataSource = Consulta_produto_marca(txtBuscaProduto.Text)
        End If

        If cmbFiltro.Text = "Data de validade" Or cmbFiltro.Text = "Expiration date" Or cmbFiltro.Text = "Fecha de expiración" Then
            dgvProduto.DataSource = Consulta_produto_data(MtxtFiltroData.Text)
        End If

    End Sub

    Private Sub dgvProduto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduto.CellClick

        Dim i As Integer
        i = dgvProduto.CurrentRow.Index
        Me.txtCod.Text = dgvProduto.Item(1, i).Value
        Me.txtTipoProduto.Text = dgvProduto.Item(3, i).Value
        Me.txtNomeProduto.Text = dgvProduto.Item(4, i).Value
        Me.MtxtDataValidade.Text = dgvProduto.Item(9, i).Value
        Me.txtQuantidadeProduto.Text = dgvProduto.Item(6, i).Value
        Me.txtQuantidadeMaxima.Text = dgvProduto.Item(8, i).Value

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

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click

        Conectar()

        Dim quantidadeproduto As Integer
        Dim quantidademaxima As Integer

        quantidadeproduto = txtQuantidadeProduto.Text
        quantidademaxima = txtQuantidadeMaxima.Text

        If quantidadeproduto > quantidademaxima Then
            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("A quantidade do produto não pode ser maior que a quantidade máxima declarada")
                txtQuantidadeProduto.Focus()
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("The amount of the product can not be greater than the maximum quantity stated")
                txtQuantidadeProduto.Focus()
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("La cantidad del producto no puede ser superior a la cantidad máxima indicada")
                txtQuantidadeProduto.Focus()
            End If
        Else

            If txtCod.Text <> Nothing Then

                Dim message_portugues As Integer
                Dim message_english As Integer
                Dim message_spanish As Integer

                If (frmPrincipal.lbIdioma.Text = "Português") Then
                    message_portugues = MessageBox.Show("Confirma a alteração de quantidade deste produto ?", _
                                              "Confirma ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                End If

                If (frmPrincipal.lbIdioma.Text = "English") Then
                    message_portugues = MessageBox.Show("Confirms the change of amount of this product ?", _
                                              "Confirm ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                End If

                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                    message_portugues = MessageBox.Show("Confirma el cambio de cantidad de este producto ?", _
                                              "Confirma ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                End If

                If message_portugues = vbYes Or message_english = vbYes Or message_spanish = vbYes Then

                    Conectar()

                    comando.Parameters.Clear()
                    comando.CommandText = "update produto set quantidade_produto = @quantidade_produto where cod_produto = @cod_produto"
                    comando.Parameters.AddWithValue("@cod_produto", txtCod.Text)
                    comando.Parameters.AddWithValue("@quantidade_produto", txtQuantidadeProduto.Text)

                    comando.ExecuteNonQuery()
                    Desconectar()

                    If (frmPrincipal.lbIdioma.Text = "Português") Then
                        MessageBox.Show("Quantidade do produto alterado com sucesso!")
                    End If
                    If (frmPrincipal.lbIdioma.Text = "English") Then
                        MessageBox.Show("Quantity successfully changed product!")
                    End If
                    If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                        MessageBox.Show("Cantidad cambiado correctamente producto!")
                    End If

                    dgvProduto.DataSource = Nothing
                    txtCod.Text = Nothing
                    txtTipoProduto.Text = Nothing
                    txtNomeProduto.Text = Nothing
                    MtxtDataValidade.Text = Nothing
                    txtQuantidadeProduto.Text = Nothing
                    txtQuantidadeMaxima.Text = Nothing
                    txtBuscaProduto.Text = Nothing
                    txtBuscaProduto.Text = Nothing
                    MtxtFiltroData.Text = Nothing
                    cmbFiltroTipoProduto.Text = Nothing

                    limpafiltros()

                    If (frmPrincipal.lbIdioma.Text = "Português") Then
                        MessageBox.Show("Reabasteça outro produto ou pressione o botão cancelar para retornar a tela principal!")
                    End If
                    If (frmPrincipal.lbIdioma.Text = "English") Then
                        MessageBox.Show("Refill other product or press the cancel button to return to the main screen!")
                    End If
                    If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                        MessageBox.Show("Vuelva a llenar otro producto o pulse el botón Cancelar para volver a la pantalla principal!")
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub limpafiltros()

        txtBuscaProduto.Visible = False
        MtxtFiltroData.Visible = False
        cmbFiltroTipoProduto.Visible = False
        btnBuscar.Visible = False

    End Sub

    Private Sub cmbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltro.SelectedIndexChanged

        limpacamposproduto()
        txtBuscaProduto.Text = Nothing
        cmbFiltroTipoProduto.Text = Nothing
        MtxtFiltroData.Text = Nothing

        If cmbFiltro.Text = "Código" Or cmbFiltro.Text = "ID" Or cmbFiltro.Text = "Nome" Or cmbFiltro.Text = "Name" Or cmbFiltro.Text = "Nombre" Or cmbFiltro.Text = "Marca" Or cmbFiltro.Text = "Mark" Then
            limpafiltros()
            txtBuscaProduto.Visible = True
        End If

        If cmbFiltro.Text = "Tipo" Or cmbFiltro.Text = "Type" Or cmbFiltro.Text = "Clase" Then
            limpafiltros()
            cmbFiltroTipoProduto.Visible = True
        End If

        If cmbFiltro.Text = "Data de validade" Or cmbFiltro.Text = "Expiration date" Or cmbFiltro.Text = "Fecha de expiración" Then
            limpafiltros()
            MtxtFiltroData.Visible = True
        End If

        btnBuscar.Visible = True

    End Sub
End Class