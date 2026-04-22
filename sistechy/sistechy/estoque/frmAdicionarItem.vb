Public Class frmAdicionarItem

    Private Sub frmAdicionarItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (frmPrincipal.lbIdioma.Text = "Português") Then

            cmbTipoProduto.Items.Add("Medicamento")
            cmbTipoProduto.Items.Add("Vacina")
            cmbTipoProduto.Items.Add("Higiene")
            cmbTipoProduto.Items.Add("Brinquedo")
            cmbTipoProduto.Items.Add("Outro")

        End If

        If (frmPrincipal.lbIdioma.Text = "English") Then

            Me.Text = "New item"

            cmbTipoProduto.Items.Add("Drug")
            cmbTipoProduto.Items.Add("Vaccine")
            cmbTipoProduto.Items.Add("Hygiene")
            cmbTipoProduto.Items.Add("Toy")
            cmbTipoProduto.Items.Add("Other")

            gpxProduto.Text = "Product Information"

            lbCodForne.Text = "Vendor code"
            lbTipoProduto.Text = "Product type"
            lbNome.Text = "Name"
            lbMarca.Text = "Mark"
            lbQuantidade.Text = "Amount"
            lbQuantidadeMinima.Text = "Minimum amount"
            lbQuantidadeMaxima.Text = "Maximum amount"
            lbDataValidade.Text = "Expiration date"
            lbPreco.Text = "Price"
            lbDescricao.Text = "Description"

            btnCarregarImagem.Text = "Load image"

            btnCancelar.BackgroundImage = My.Resources.cancelar_english_fw
            btnAdicionarProduto.BackgroundImage = My.Resources.salva_cadastro_english_fw

            pbxBanner.BackgroundImage = My.Resources.banner_adicionar_item_english_fw

        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Nuevo elemento"

            cmbTipoProduto.Items.Add("Droga")
            cmbTipoProduto.Items.Add("Vacuna")
            cmbTipoProduto.Items.Add("Higiene")
            cmbTipoProduto.Items.Add("Juguete")
            cmbTipoProduto.Items.Add("Otro")

            gpxProduto.Text = "Información de producto"

            lbCodForne.Text = "Código de proveedor"
            lbTipoProduto.Text = "Tipo de producto"
            lbNome.Text = "Nombre"
            lbMarca.Text = "Marca"
            lbQuantidade.Text = "Cantidad"
            lbQuantidadeMinima.Text = "Cantidad mínima"
            lbQuantidadeMaxima.Text = "Cantidad máxima"
            lbDataValidade.Text = "Fecha de expiración"
            lbPreco.Text = "Precio"
            lbDescricao.Text = "Description"

            btnCarregarImagem.Text = "Carga de imágenes"

            btnCancelar.BackgroundImage = My.Resources.cancelar_spanish_fw
            btnAdicionarProduto.BackgroundImage = My.Resources.salva_cadastro_spanish_fw

            pbxBanner.BackgroundImage = My.Resources.banner_adicionar_item_spanish_fw

        End If

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

    Private Sub btnCarregarImagem_Click(sender As Object, e As EventArgs) Handles btnCarregarImagem.Click

        Dim openfd As New OpenFileDialog

        openfd.Filter = "Imagens (*.jpg;*.jpeg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif;*.jpeg"

        If openfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtLocalImagem.Text = openfd.FileName

            pbxproduto.Image = New System.Drawing.Bitmap(txtLocalImagem.Text)
        End If

    End Sub

    Private Sub btnCadastraAnimal_Click(sender As Object, e As EventArgs) Handles btnAdicionarProduto.Click

        If (cmbTipoProduto.Text) Is "" Then
            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("O campo Tipo de produto não pode ficar vazio")
                cmbTipoProduto.Focus()
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("The product type field can not be empty")
                cmbTipoProduto.Focus()
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("El campo de tipo de producto no puede estar vacío")
                cmbTipoProduto.Focus()
            End If
        Else
            If (txtNomeProduto.Text) Is "" Then
                If (frmPrincipal.lbIdioma.Text = "Português") Then
                    MessageBox.Show("O campo Nome não pode ficar vazio")
                    txtNomeProduto.Focus()
                End If
                If (frmPrincipal.lbIdioma.Text = "English") Then
                    MessageBox.Show("The Name field can not be empty")
                    txtNomeProduto.Focus()
                End If
                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                    MessageBox.Show("El campo nombre no puede estar vacío")
                    txtNomeProduto.Focus()
                End If
            Else
                If (txtQuantidadeMaxima.Text) Is "" Then
                    If (frmPrincipal.lbIdioma.Text = "Português") Then
                        MessageBox.Show("O campo Quantidade máxima não pode ficar vazio")
                        txtQuantidadeMaxima.Focus()
                    End If
                    If (frmPrincipal.lbIdioma.Text = "English") Then
                        MessageBox.Show("The maximum quantity field can not be empty")
                        txtQuantidadeMaxima.Focus()
                    End If
                    If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                        MessageBox.Show("El campo de cantidad máxima no puede estar vacío")
                        txtQuantidadeMaxima.Focus()
                    End If
                Else
                    If Not (MtxtDataValidade.MaskFull) Then
                        If (frmPrincipal.lbIdioma.Text = "Português") Then
                            MessageBox.Show("O campo Data validade não pode ficar vazio")
                            MtxtDataValidade.Focus()
                        End If
                        If (frmPrincipal.lbIdioma.Text = "English") Then
                            MessageBox.Show("Field Data validity can not be empty")
                            MtxtDataValidade.Focus()
                        End If
                        If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                            MessageBox.Show("Validez de datos de campo no puede estar vacío")
                            MtxtDataValidade.Focus()
                        End If
                    Else

                        If (cmbTipoProduto.Text <> "" And txtNomeProduto.Text <> "" And txtQuantidadeMaxima.Text <> "") Then

                            Conectar()
                            Cadastrar_Produto(txtLocalImagem.Text, txtCodForne.Text, cmbTipoProduto.Text, txtNomeProduto.Text, txtMarcaProduto.Text, txtQuantidadeProduto.Text, txtQuantidadeMinima.Text, txtQuantidadeMaxima.Text, MtxtDataValidade.Text, txtPrecoProduto.Text, txtDescricao.Text)

                            txtLocalImagem.Text = Nothing
                            txtCodForne.Text = Nothing
                            cmbTipoProduto.Text = Nothing
                            txtNomeProduto.Text = Nothing
                            txtMarcaProduto.Text = Nothing
                            txtQuantidadeProduto.Text = Nothing
                            txtQuantidadeMinima.Text = Nothing
                            txtQuantidadeMaxima.Text = Nothing
                            MtxtDataValidade.Text = Nothing
                            txtPrecoProduto.Text = Nothing
                            txtDescricao.Text = Nothing
                            pbxProduto.Image = Nothing

                            If (frmPrincipal.lbIdioma.Text = "Português") Then
                                MessageBox.Show("Cadastre um novo produto ou pressione o botão cancelar para realizar outra tarefa")
                            End If
                            If (frmPrincipal.lbIdioma.Text = "English") Then
                                MessageBox.Show("Register a new product or press the cancel button to perform another task")
                            End If
                            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                MessageBox.Show("Registrar un producto nuevo o pulse el botón de cancelación para realizar otra tarea")
                            End If
                            txtPrecoProduto.Text = "R$"
                        End If
                    End If
                End If
            End If
        End If

    End Sub
End Class