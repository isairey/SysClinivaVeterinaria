Public Class frmConsultarVendas

    Private Sub limpafiltros()

        lbCod.Visible = False
        lbData.Visible = False
        lbDataInicial.Visible = False
        lbDataFinal.Visible = False

        MtxtFiltroData.Visible = False
        MtxtFiltroEntreData1.Visible = False
        MtxtFiltroEntreData2.Visible = False

    End Sub

    Private Sub frmConsultarVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbTiposFiltro.Items.Add("Todas")
        cmbTiposFiltro.Items.Add("Data")
        cmbTiposFiltro.Items.Add("Entre duas datas")

    End Sub

    Private Sub cmbTiposFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTiposFiltro.SelectedIndexChanged

        If (cmbTiposFiltro.Text = "Todas") Then

            limpafiltros()

        End If

        If (cmbTiposFiltro.Text = "Data") Then

            limpafiltros()
            lbDataInicial.Visible = True
            MtxtFiltroData.Visible = True

        End If

        If (cmbTiposFiltro.Text = "Entre duas datas") Then

            limpafiltros()
            lbDataInicial.Visible = True
            lbDataFinal.Visible = True
            MtxtFiltroEntreData1.Visible = True
            MtxtFiltroEntreData2.Visible = True

        End If

    End Sub

    Private Sub btFiltrar_Click(sender As Object, e As EventArgs) Handles btFiltrar.Click

        If (cmbTiposFiltro.Text = "Todas") Then

            Conectar()

            dgvVendas.DataSource = Filtro_venda_todos()

        End If

        If (cmbTiposFiltro.Text = "Data") Then

            If Not (MtxtFiltroData.MaskFull) Then
                MessageBox.Show("Informe uma data válida")
                MtxtFiltroData.Focus()
            End If

            Conectar()

            dgvVendas.DataSource = Filtro_venda_data(MtxtFiltroData.Text)

        End If


        If (cmbTiposFiltro.Text = "Entre duas datas") Then

            If Not (MtxtFiltroEntreData1.MaskFull And MtxtFiltroEntreData2.MaskFull) Then
                MessageBox.Show("Informe duas datas válidas")
            End If

            Conectar()

            dgvVendas.DataSource = Filtro_venda_entre_datas(MtxtFiltroEntreData1.Text, MtxtFiltroEntreData2.Text)

        End If

    End Sub

    Private Sub btnDetalhes_Click(sender As Object, e As EventArgs) Handles btnDetalhes.Click

        If (dgvVendas.DataSource Is Nothing) Then
            MessageBox.Show("Selecione uma venda")
        Else

            Dim i As Integer
            i = dgvVendas.CurrentRow.Index
            frmDetalhesVenda.txtCodVenda.Text = dgvVendas.Item(0, i).Value
            frmDetalhesVenda.txtItens.Text = dgvVendas.Item(1, i).Value
            frmDetalhesVenda.MtxtCPFCli.Text = dgvVendas.Item(2, i).Value
            frmDetalhesVenda.txtCodFunc.Text = dgvVendas.Item(3, i).Value
            frmDetalhesVenda.MtxtDataVenda.Text = dgvVendas.Item(4, i).Value
            frmDetalhesVenda.txtValorTotal.Text = dgvVendas.Item(5, i).Value
            frmDetalhesVenda.txtFormaPagamento.Text = dgvVendas.Item(6, i).Value
            frmDetalhesVenda.txtCartaoUtilizado.Text = dgvVendas.Item(7, i).Value

            Me.Hide()
            frmDetalhesVenda.Show()

        End If

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
End Class