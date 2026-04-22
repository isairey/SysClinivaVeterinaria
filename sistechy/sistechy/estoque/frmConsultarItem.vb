Public Class frmConsultarItem

    Private Sub limpacamposproduto()

        dgvProduto.DataSource = Nothing
        txtCaminhoImagem.Text = Nothing
        txtCodProduto.Text = Nothing
        txtCodForne.Text = Nothing
        cmbTipoProduto.Text = Nothing
        txtNomeProduto.Text = Nothing
        txtMarcaProduto.Text = Nothing
        txtQuantidadeAtual.Text = Nothing
        txtQuantidadeMaxima.Text = Nothing
        MtxtDataValidade.Text = Nothing
        txtPreco.Text = Nothing
        txtDescricaoProduto.Text = Nothing
        pbxProduto.Image = Nothing

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Dim message As Integer

        message = MessageBox.Show("Deseja mesmo cancelar a operação ?", _
                                      "Confirma ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If message = vbYes Then

            Me.Close()
            frmPrincipal.Visible = True

        End If

    End Sub

    Private Sub frmConsultarItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (frmPrincipal.lbIdioma.Text = "Português") Then

            cmbTipoProduto.Items.Add("Medicamento")
            cmbTipoProduto.Items.Add("Vacina")
            cmbTipoProduto.Items.Add("Higiene")
            cmbTipoProduto.Items.Add("Brinquedo")
            cmbTipoProduto.Items.Add("Outro")

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

            Me.Text = "See item"

            cmbTipoProduto.Items.Add("Drug")
            cmbTipoProduto.Items.Add("Vaccine")
            cmbTipoProduto.Items.Add("Hygiene")
            cmbTipoProduto.Items.Add("Toy")
            cmbTipoProduto.Items.Add("Other")

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

            gpxPesquisa.Text = "Survey data"
            gpxProduto.Text = "Product Data"

            lbBuscarPor.Text = "Search by: "
            lbCod.Text = "ID"
            lbCodForne.Text = "Vendor ID"
            lbTipo.Text = "Type"
            lbNome.Text = "Name"
            lbMarca.Text = "Mark"
            lbQuantidadeAtual.Text = "Current number"
            lbQuantidadeMaxima.Text = "Maximum amount"
            lbDataValidade.Text = "Expiration date"
            lbPreco.Text = "Price"
            lbDescricao.Text = "Description"

            btnBuscar.Text = "Search"
            btnCarregarImagem.Text = "Load image"

            pbxBanner.BackgroundImage = My.Resources.banner_consultar_item_english_fw

            btnCancelar.BackgroundImage = My.Resources.cancelar_english_fw
            btnExcluir.BackgroundImage = My.Resources.excluir_dados_english_fw
            btnAtualizar.BackgroundImage = My.Resources.atualizar_dados_english_fw
            btnConfirmar.BackgroundImage = My.Resources.salva_alteracoes_english_fw

        End If


        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Ver artículo"

            cmbTipoProduto.Items.Add("Droga")
            cmbTipoProduto.Items.Add("Vacuna")
            cmbTipoProduto.Items.Add("Higiene")
            cmbTipoProduto.Items.Add("Juguete")
            cmbTipoProduto.Items.Add("Otro")

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

            gpxPesquisa.Text = "Datos de la encuesta"
            gpxProduto.Text = "Datos del producto"

            lbBuscarPor.Text = "Buscar por: "
            lbCod.Text = "ID"
            lbCodForne.Text = "ID proveedor"
            lbTipo.Text = "Clase"
            lbNome.Text = "Nombre"
            lbMarca.Text = "Marca"
            lbQuantidadeAtual.Text = "Cantidad"
            lbQuantidadeMaxima.Text = "Cantidad máxima"
            lbDataValidade.Text = "Fecha de expiración"
            lbPreco.Text = "Precio"
            lbDescricao.Text = "Descripción"

            btnBuscar.Text = "Buscar"
            btnCarregarImagem.Text = "Carga de imágenes"

            pbxBanner.BackgroundImage = My.Resources.banner_consultar_item_spanish_fw

            btnCancelar.BackgroundImage = My.Resources.cancelar_spanish_fw
            btnExcluir.BackgroundImage = My.Resources.excluir_dados_spanish_fw
            btnAtualizar.BackgroundImage = My.Resources.atualizar_dados_spanish_fw
            btnConfirmar.BackgroundImage = My.Resources.salva_alteracoes_spanish_fw

        End If


    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

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
        Me.txtCaminhoImagem.Text = dgvProduto.Item(0, i).Value
        Me.txtCodProduto.Text = dgvProduto.Item(1, i).Value
        Me.txtCodForne.Text = dgvProduto.Item(2, i).Value
        Me.cmbTipoProduto.Text = dgvProduto.Item(3, i).Value
        Me.txtNomeProduto.Text = dgvProduto.Item(4, i).Value
        Me.txtMarcaProduto.Text = dgvProduto.Item(5, i).Value
        Me.txtQuantidadeAtual.Text = dgvProduto.Item(6, i).Value
        Me.txtQuantidadeMinima.text = dgvProduto.Item(7, i).Value
        Me.txtQuantidadeMaxima.Text = dgvProduto.Item(8, i).Value
        Me.MtxtDataValidade.Text = dgvProduto.Item(9, i).Value
        Me.txtPreco.Text = dgvProduto.Item(10, i).Value
        Me.txtDescricaoProduto.Text = dgvProduto.Item(11, i).Value

        If (txtCaminhoImagem.Text) Is "" Then

        Else
            pbxProduto.Image = New System.Drawing.Bitmap(txtCaminhoImagem.Text)
        End If

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If Not dgvProduto.DataSource Is Nothing Then

            Dim message_portugues As Integer
            Dim message_english As Integer
            Dim message_spanish As Integer

            If (frmPrincipal.lbIdioma.Text = "Português") Then
                message_portugues = MessageBox.Show("Confirma a exclusão deste produto ?", _
                                          "Confirma Exclusão ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If

            If (frmPrincipal.lbIdioma.Text = "Português") Then
                message_english = MessageBox.Show("Confirms the exclusion of this product ?", _
                                          "Really delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If

            If (frmPrincipal.lbIdioma.Text = "Português") Then
                message_spanish = MessageBox.Show("Confirma la exclusión de este producto ?", _
                                          "Confirms Exclusion ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If

            If message_portugues = vbYes Or message_english = vbYes Or message_spanish = vbYes Then

                Excluir_produto_codigo(txtCodProduto.Text)

                txtBuscaProduto.Text = Nothing
                MtxtFiltroData.Text = Nothing
                cmbFiltroTipoProduto.Text = Nothing
                dgvProduto.DataSource = Nothing
                txtCaminhoImagem.Text = Nothing
                txtCodProduto.Text = Nothing
                txtCodForne.Text = Nothing
                cmbTipoProduto.Text = Nothing
                txtNomeProduto.Text = Nothing
                txtMarcaProduto.Text = Nothing
                txtQuantidadeAtual.Text = Nothing
                txtQuantidadeMaxima.Text = Nothing
                MtxtDataValidade.Text = Nothing
                txtPreco.Text = Nothing
                txtDescricaoProduto.Text = Nothing
                pbxProduto.Image = Nothing

                If (frmPrincipal.lbIdioma.Text = "Português") Then
                    MessageBox.Show("Produto excluído com sucesso!")
                End If
                If (frmPrincipal.lbIdioma.Text = "English") Then
                    MessageBox.Show("Successfully deleted product!")
                End If
                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                    MessageBox.Show("Con éxito borrado producto!")
                End If
            End If
        End If

    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click

        If txtCodProduto.Text <> Nothing Then

            btnExcluir.Enabled = True
            btnConfirmar.Enabled = True
            txtCodForne.Enabled = True
            cmbTipoProduto.Enabled = True
            txtNomeProduto.Enabled = True
            txtMarcaProduto.Enabled = True
            txtQuantidadeAtual.Enabled = True
            txtQuantidadeMaxima.Enabled = True
            MtxtDataValidade.Enabled = True
            txtPreco.Enabled = True
            txtDescricaoProduto.Enabled = True
            btnCarregarImagem.Enabled = True

        Else
            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("Selecione um produto para alterar seus dados!")
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("Select a product to modify your data!")
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("Seleccione un producto para modificar sus datos!")
            End If
        End If

    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click

        If (txtQuantidadeAtual.Text < txtQuantidadeMinima.Text) Then
            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("A quantidade colocada não pode ser menor que a quantidade mínima!")
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("The amount can not be placed under the minimum quantity!")
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("La cantidad no puede ser colocado bajo la cantidad mínima!")
            End If
        Else
            Conectar()

            If txtCodProduto.Text <> Nothing Then

                comando.Parameters.Clear()
                comando.CommandText = "update produto set foto_produto= @foto_produto, cod_fornecedor= @cod_fornecedor, tipo_produto= @tipo_produto, nome_produto= @nome_produto, marca_produto= @marca_produto, quantidade_produto= @quantidade_produto, quantidade_maxima= @quantidade_maxima, data_validade= @data_validade, preco_produto= @preco_produto, descricao_produto= @descricao_produto where cod_produto= @cod_produto"
                comando.Parameters.AddWithValue("@cod_produto", txtCodProduto.Text)
                comando.Parameters.AddWithValue("@foto_produto", txtCaminhoImagem.Text)
                comando.Parameters.AddWithValue("@cod_fornecedor", txtCodForne.Text)
                comando.Parameters.AddWithValue("@tipo_produto", cmbTipoProduto.Text)
                comando.Parameters.AddWithValue("@nome_produto", txtNomeProduto.Text)
                comando.Parameters.AddWithValue("@marca_produto", txtMarcaProduto.Text)
                comando.Parameters.AddWithValue("@quantidade_produto", txtQuantidadeAtual.Text)
                comando.Parameters.AddWithValue("@quantidade_maxima", txtQuantidadeMaxima.Text)
                comando.Parameters.AddWithValue("@data_validade", MtxtDataValidade.Text)
                comando.Parameters.AddWithValue("@preco_produto", txtPreco.Text)
                comando.Parameters.AddWithValue("@descricao_produto", txtDescricaoProduto.Text)

                comando.ExecuteNonQuery()
                Desconectar()

                If (frmPrincipal.lbIdioma.Text = "Português") Then
                    MessageBox.Show("Dados do produto alterados com sucesso!")
                End If
                If (frmPrincipal.lbIdioma.Text = "English") Then
                    MessageBox.Show("Data successfully modified product!")
                End If
                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                    MessageBox.Show("Los datos modificados con éxito producto!")
                End If

                txtBuscaProduto.Text = Nothing
                MtxtFiltroData.Text = Nothing
                cmbFiltroTipoProduto.Text = Nothing
                dgvProduto.DataSource = Nothing
                txtCaminhoImagem.Text = Nothing
                txtCodProduto.Text = Nothing
                txtCodForne.Text = Nothing
                cmbTipoProduto.Text = Nothing
                txtNomeProduto.Text = Nothing
                txtMarcaProduto.Text = Nothing
                txtQuantidadeAtual.Text = Nothing
                txtQuantidadeMaxima.Text = Nothing
                MtxtDataValidade.Text = Nothing
                txtPreco.Text = Nothing
                txtDescricaoProduto.Text = Nothing
                pbxProduto.Image = Nothing

                txtCodForne.Enabled = False
                cmbTipoProduto.Enabled = False
                txtNomeProduto.Enabled = False
                txtMarcaProduto.Enabled = False
                txtQuantidadeAtual.Enabled = False
                txtQuantidadeMaxima.Enabled = False
                MtxtDataValidade.Enabled = False
                txtPreco.Enabled = False
                txtDescricaoProduto.Enabled = False
                btnCarregarImagem.Enabled = False
                cmbFiltro.Text = Nothing

                limpafiltros()

                btnExcluir.Enabled = True
                btnConfirmar.Enabled = True

            Else
                If (frmPrincipal.lbIdioma.Text = "Português") Then
                    MessageBox.Show("Selecione um produto para alterar seus dados!")
                End If
                If (frmPrincipal.lbIdioma.Text = "English") Then
                    MessageBox.Show("Select a product to modify your data!")
                End If
                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                    MessageBox.Show("Seleccione un producto para modificar sus datos!")
                End If
            End If
            End If

    End Sub

    Private Sub btnCarregarImagem_Click(sender As Object, e As EventArgs) Handles btnCarregarImagem.Click

        Dim openfd As New OpenFileDialog

        openfd.Filter = "Imagens (*.jpg;*jpeg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif;*.jpeg"

        If openfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtCaminhoImagem.Text = openfd.FileName

            pbxProduto.Image = New System.Drawing.Bitmap(txtCaminhoImagem.Text)
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