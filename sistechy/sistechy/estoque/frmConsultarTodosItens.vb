Public Class frmConsultarTodosItens

    Private Sub frmConsultarTodosItens_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (frmPrincipal.lbIdioma.Text = "English") Then

            Me.Text = "Consulting all items"

            pbxBanner.BackgroundImage = My.Resources.banner_consultar_todos_itens_english_fw

            btnMedicamento.Text = "Drug"
            btnVacina.Text = "Vaccine"
            btnHigiene.Text = "Hygiene"
            btnBrinquedos.Text = "Toy"
            btnOutros.Text = "Others"

            lbCritico.Text = "Critical stock"
            lbModerado.Text = "Stock moderate"
            lbBom.Text = "Good stock"

        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Consultoría todos los artículos"

            pbxBanner.BackgroundImage = My.Resources.banner_consultar_todos_itens_spanish_fw

            btnMedicamento.Text = "Droga"
            btnVacina.Text = "Vacuna"
            btnHigiene.Text = "Higiene"
            btnBrinquedos.Text = "Juguete"
            btnOutros.Text = "Otro"

            lbCritico.Text = "Inventario crítico"
            lbModerado.Text = "Inventario moderada"
            lbBom.Text = "Inventario buen"

        End If

        pbxCritico.BackColor = System.Drawing.Color.FromArgb(245, 116, 115)
        pbxModerado.BackColor = System.Drawing.Color.FromArgb(253, 253, 93)
        pbxSobrando.BackColor = System.Drawing.Color.FromArgb(98, 253, 93)

    End Sub

    Private Sub formatagrid()

        Dim quantidade As Integer

        For i As Integer = 0 To dgvProdutos.Rows.Count - 1

            quantidade = (dgvProdutos.Rows(i).Cells(3).Value)

            If (quantidade <= 5) Then

                dgvProdutos.Rows(i).DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 116, 115)

            End If

            If (quantidade > 5 And quantidade < 20) Then

                dgvProdutos.Rows(i).DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(253, 253, 93)

            End If

            If (quantidade >= 20) Then

                dgvProdutos.Rows(i).DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(98, 253, 93)

            End If

            If i > dgvProdutos.Rows.Count Then
                Exit For
            End If

        Next

    End Sub

    Private Sub btnMedicamento_Click(sender As Object, e As EventArgs) Handles btnMedicamento.Click

        dgvProdutos.DataSource = Consulta_estoque("Medicamento")

        formatagrid()

    End Sub

    Private Sub btnVacina_Click(sender As Object, e As EventArgs) Handles btnVacina.Click

        dgvProdutos.DataSource = Consulta_estoque("Vacina")

        formatagrid()

    End Sub

    Private Sub btnHigiene_Click(sender As Object, e As EventArgs) Handles btnHigiene.Click

        dgvProdutos.DataSource = Consulta_estoque("Higiene")

        formatagrid()

    End Sub

    Private Sub btnBrinquedos_Click(sender As Object, e As EventArgs) Handles btnBrinquedos.Click

        dgvProdutos.DataSource = Consulta_estoque("Brinquedo")

        formatagrid()

    End Sub

    Private Sub btnOutros_Click(sender As Object, e As EventArgs) Handles btnOutros.Click

        dgvProdutos.DataSource = Consulta_estoque("Outro")

        formatagrid()

    End Sub

    Private Sub btnFecharForm_Click(sender As Object, e As EventArgs) Handles btnFecharForm.Click

        Me.Close()
        frmPrincipal.Visible = True

    End Sub
End Class