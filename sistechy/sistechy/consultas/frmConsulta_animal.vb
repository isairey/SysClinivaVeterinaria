Imports System.Data.SqlClient
Public Class frmConsulta_animal

    Private Sub nivelacesso()

        If frmPrincipal.txtNivelAcesso.Text = "Atendente" Then
            Me.btnExcluir.Enabled = False
        End If

    End Sub

    Private Sub limpacamposanimal()

        dgvAnimal.DataSource = Nothing
        txtCodAnimal.Text = Nothing
        txtNomeAnimal.Text = Nothing
        txtEspecieAnimal.Text = Nothing
        txtRacaAnimal.Text = Nothing
        cmbSexoAnimal.Text = Nothing
        cmbPorteAnimal.Text = Nothing
        txtPesoAnimal.Text = Nothing
        txtIdadeAnimal.Text = Nothing
        txtCorAnimal.Text = Nothing
        cmbCastracaoAnimal.Text = Nothing
        MtxtDataCadAnimal.Text = Nothing
        txtCaminhoImagem.Text = Nothing
        pbxAnimal.Image = Nothing

    End Sub

    Private Sub bloqueiacampos()

        txtNomeAnimal.Enabled = False
        txtEspecieAnimal.Enabled = False
        txtRacaAnimal.Enabled = False
        cmbSexoAnimal.Enabled = False
        cmbPorteAnimal.Enabled = False
        txtPesoAnimal.Enabled = False
        txtIdadeAnimal.Enabled = False
        txtCorAnimal.Enabled = False
        cmbCastracaoAnimal.Enabled = False
        MtxtDataCadAnimal.Enabled = False
        txtCaminhoImagem.Enabled = False
        btnLoadImage.Enabled = False

    End Sub

    Private Sub frmConsulta_animal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (frmPrincipal.lbIdioma.Text = "Português") Then

            cmbSexoAnimal.Items.Add("Macho")
            cmbSexoAnimal.Items.Add("Fêmea")

            cmbPorteAnimal.Items.Add("Pequeno")
            cmbPorteAnimal.Items.Add("Médio")
            cmbPorteAnimal.Items.Add("Grande")

            cmbCastracaoAnimal.Items.Add("Sim")
            cmbCastracaoAnimal.Items.Add("Não")

            cmbFiltro.Items.Add("Código")
            cmbFiltro.Items.Add("Nome")
            cmbFiltro.Items.Add("Data de cadastro")

        End If

        If (frmPrincipal.lbIdioma.Text = "English") Then

            gpxPesquisa.Text = "Survey data"
            gpxAnimal.Text = "Animal data"

            lbBuscarPor.Text = "Search by: "
            lbCod.Text = "ID"
            lbNome.Text = "Name"
            lbEspecie.Text = "Species"
            lbRaca.Text = "Race"
            lbSexo.Text = "Sex"
            lbPorte.Text = "Size"
            lbPeso.Text = "Weight"
            lbIdade.Text = "Age"
            lbCor.Text = "Color"
            lbCastracao.Text = "Castration"
            lbDataCad.Text = "Date of registration"

            btnBuscar.Text = "Search"
            btnLoadImage.Text = "Load image"

            btnCancelar.BackgroundImage = My.Resources.cancelar_english_fw
            btnExcluir.BackgroundImage = My.Resources.excluir_dados_english_fw
            btnAtualizar.BackgroundImage = My.Resources.atualizar_dados_english_fw
            btnConfirmar.BackgroundImage = My.Resources.salva_alteracoes_english_fw

            Me.pbxBanner.BackgroundImage = My.Resources.banner_consulta_animal_english_fw

            cmbSexoAnimal.Items.Add("Male")
            cmbSexoAnimal.Items.Add("Female")

            cmbPorteAnimal.Items.Add("Small")
            cmbPorteAnimal.Items.Add("Mid")
            cmbPorteAnimal.Items.Add("Large")

            cmbCastracaoAnimal.Items.Add("Yes")
            cmbCastracaoAnimal.Items.Add("No")

            cmbFiltro.Items.Add("ID")
            cmbFiltro.Items.Add("Name")
            cmbFiltro.Items.Add("Date of registration")

        End If


        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            gpxPesquisa.Text = "Datos de la encuesta"
            gpxAnimal.Text = "Datos del animal"

            lbBuscarPor.Text = "Buscar por: "
            lbCod.Text = "ID"
            lbNome.Text = "Nombre"
            lbEspecie.Text = "Especies"
            lbRaca.Text = "Raza"
            lbSexo.Text = "Sexo"
            lbPorte.Text = "Tamanõ"
            lbPeso.Text = "Peso"
            lbIdade.Text = "Edad"
            lbCor.Text = "Color"
            lbCastracao.Text = "Castración"
            lbDataCad.Text = "Fecha de registro"

            btnBuscar.Text = "Search"
            btnLoadImage.Text = "Cargar imagen"

            btnCancelar.BackgroundImage = My.Resources.cancelar_spanish_fw
            btnExcluir.BackgroundImage = My.Resources.excluir_dados_spanish_fw
            btnAtualizar.BackgroundImage = My.Resources.atualizar_dados_spanish_fw
            btnConfirmar.BackgroundImage = My.Resources.salva_alteracoes_spanish_fw

            Me.pbxBanner.BackgroundImage = My.Resources.banner_consulta_animal_spanish_fw

            cmbSexoAnimal.Items.Add("Masculino")
            cmbSexoAnimal.Items.Add("Femenino")

            cmbPorteAnimal.Items.Add("Pequeño")
            cmbPorteAnimal.Items.Add("Medio")
            cmbPorteAnimal.Items.Add("Grande")

            cmbCastracaoAnimal.Items.Add("Sí")
            cmbCastracaoAnimal.Items.Add("No")

            cmbFiltro.Items.Add("ID")
            cmbFiltro.Items.Add("Nombre")
            cmbFiltro.Items.Add("Fecha de registro")

        End If

        Me.txtNivelAcesso.Text = frmPrincipal.txtNivelAcesso.Text

        nivelacesso()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        limpacamposanimal()
        Conectar()

        If cmbFiltro.Text = "Código" Or cmbFiltro.Text = "ID" Then
            dgvAnimal.DataSource = Consulta_animal_codigo(txtConsultaAnimal.Text)
        End If

        If cmbFiltro.Text = "Nome" Or cmbFiltro.Text = "Name" Or cmbFiltro.Text = "Nombre" Then
            dgvAnimal.DataSource = Consulta_animal_nome(txtConsultaAnimal.Text)
        End If

        If cmbFiltro.Text = "Data de cadastro" Or cmbFiltro.Text = "Date of registration" Or cmbFiltro.Text = "Fecha de registro" Then
            dgvAnimal.DataSource = Consulta_animal_data(MtxtFiltroData.Text)
        End If

    End Sub

    Private Sub dgvAnimal_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAnimal.CellClick

        Dim i As Integer
        i = dgvAnimal.CurrentRow.Index
        Me.txtCaminhoImagem.Text = dgvAnimal.Item(0, i).Value
        Me.txtCodAnimal.Text = dgvAnimal.Item(1, i).Value
        Me.txtNomeAnimal.Text = dgvAnimal.Item(3, i).Value
        Me.txtEspecieAnimal.Text = dgvAnimal.Item(4, i).Value
        Me.txtRacaAnimal.Text = dgvAnimal.Item(5, i).Value
        Me.cmbSexoAnimal.Text = dgvAnimal.Item(6, i).Value
        Me.cmbPorteAnimal.Text = dgvAnimal.Item(7, i).Value
        Me.txtPesoAnimal.Text = dgvAnimal.Item(8, i).Value
        Me.txtIdadeAnimal.Text = dgvAnimal.Item(9, i).Value
        Me.txtCorAnimal.Text = dgvAnimal.Item(10, i).Value
        Me.cmbCastracaoAnimal.Text = dgvAnimal.Item(11, i).Value
        Me.MtxtDataCadAnimal.Text = dgvAnimal.Item(12, i).Value

        If (txtCaminhoImagem.Text) Is "" Then

        Else
            pbxAnimal.Image = New System.Drawing.Bitmap(txtCaminhoImagem.Text)
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

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If Not dgvAnimal.DataSource Is Nothing Then

            Dim message_portugues As Integer
            Dim message_english As Integer
            Dim message_spanish As Integer

            If (frmPrincipal.lbIdioma.Text = "Português") Then
                message_portugues = MessageBox.Show("Confirma a exclusão deste animal ?", _
                                          "Confirma Exclusão ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If

            If (frmPrincipal.lbIdioma.Text = "English") Then
                message_english = MessageBox.Show("Confirms the exclusion of this animal ?", _
                                          "Really delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If

            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                message_spanish = MessageBox.Show("Confirma la exclusión de este animal ?", _
                                          "Confirma Exclusión ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If

            If message_portugues = vbYes Or message_english = vbYes Or message_spanish = vbYes Then

                Exclui_animal_codigo(txtCodAnimal.Text)

                txtConsultaAnimal.Text = Nothing
                MtxtFiltroData.Text = Nothing
                dgvAnimal.DataSource = Nothing
                txtCodAnimal.Text = Nothing
                txtNomeAnimal.Text = Nothing
                txtEspecieAnimal.Text = Nothing
                txtRacaAnimal.Text = Nothing
                cmbSexoAnimal.Text = Nothing
                cmbPorteAnimal.Text = Nothing
                txtPesoAnimal.Text = Nothing
                txtIdadeAnimal.Text = Nothing
                txtCorAnimal.Text = Nothing
                cmbCastracaoAnimal.Text = Nothing
                MtxtDataCadAnimal.Text = Nothing
                txtCaminhoImagem.Text = Nothing
                pbxAnimal.Image = Nothing

                bloqueiacampos()

                If (frmPrincipal.lbIdioma.Text = "Português") Then
                    MessageBox.Show("Animal excluído com sucesso !")
                End If
                If (frmPrincipal.lbIdioma.Text = "English") Then
                    MessageBox.Show("Animals successfully deleted!")
                End If
                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                    MessageBox.Show("Animales eliminan con éxito!")
                End If

            End If
        End If
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click

        If txtCodAnimal.Text <> Nothing Then

            txtConsultaAnimal.Text = Nothing
            MtxtFiltroData.Text = Nothing
            txtNomeAnimal.Enabled = True
            txtEspecieAnimal.Enabled = True
            txtRacaAnimal.Enabled = True
            cmbSexoAnimal.Enabled = True
            cmbPorteAnimal.Enabled = True
            txtPesoAnimal.Enabled = True
            txtIdadeAnimal.Enabled = True
            txtCorAnimal.Enabled = True
            cmbCastracaoAnimal.Enabled = True
            MtxtDataCadAnimal.Enabled = True
            txtCaminhoImagem.Enabled = True
            btnLoadImage.Enabled = True

        Else
            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("Selecione um animal para alterar seus dados!")
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("Select an animal to change your data!")
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("Seleccione un animal para cambiar sus datos!")
            End If
        End If
    End Sub

    Private Sub btnLoadImage_Click(sender As Object, e As EventArgs) Handles btnLoadImage.Click

        Dim openfd As New OpenFileDialog

        openfd.Filter = "Imagens (*.jpg;*jpeg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif;*.jpeg"

        If openfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtCaminhoImagem.Text = openfd.FileName

            pbxAnimal.Image = New System.Drawing.Bitmap(txtCaminhoImagem.Text)
        End If
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click

        Conectar()

        If txtCodAnimal.Text <> Nothing Then

            comando.Parameters.Clear()
            comando.CommandText = "update animal set foto_animal = @foto_animal, nome_animal= @nome_animal, especie_animal = @especie_animal, raca_animal = @raca_animal, sexo_animal = @sexo_animal, porte_animal = @porte_animal, peso_animal = @peso_animal, idade_animal = @idade_animal, cor_animal = @cor_animal, castracao_animal = @castracao_animal, cadastrodata_animal = @cadastrodata_animal where cod_animal = @cod_animal"
            comando.Parameters.AddWithValue("@cod_animal", txtCodAnimal.Text)
            comando.Parameters.AddWithValue("@foto_animal", txtCaminhoImagem.Text)
            comando.Parameters.AddWithValue("@nome_animal", txtNomeAnimal.Text)
            comando.Parameters.AddWithValue("@especie_animal", txtEspecieAnimal.Text)
            comando.Parameters.AddWithValue("@raca_animal", txtRacaAnimal.Text)
            comando.Parameters.AddWithValue("@sexo_animal", cmbSexoAnimal.Text)
            comando.Parameters.AddWithValue("@porte_animal", cmbPorteAnimal.Text)
            comando.Parameters.AddWithValue("@peso_animal", txtPesoAnimal.Text)
            comando.Parameters.AddWithValue("@idade_animal", txtIdadeAnimal.Text)
            comando.Parameters.AddWithValue("@cor_animal", txtCorAnimal.Text)
            comando.Parameters.AddWithValue("@castracao_animal", cmbCastracaoAnimal.Text)
            comando.Parameters.AddWithValue("@cadastrodata_animal", MtxtDataCadAnimal.Text)

            comando.ExecuteNonQuery()
            Desconectar()

            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("Dados do animal alterados com sucesso !")
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("Animal data changed successfully!")
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("Los datos en animales cambiaron con éxito!")
            End If

            txtNomeAnimal.Text = Nothing
            txtEspecieAnimal.Text = Nothing
            txtRacaAnimal.Text = Nothing
            cmbSexoAnimal.Text = Nothing
            cmbPorteAnimal.Text = Nothing
            txtPesoAnimal.Text = Nothing
            txtIdadeAnimal.Text = Nothing
            txtCorAnimal.Text = Nothing
            cmbCastracaoAnimal.Text = Nothing
            MtxtDataCadAnimal.Text = Nothing
            txtCaminhoImagem.Text = Nothing
            pbxAnimal.Image = Nothing
            txtCodAnimal.Text = Nothing
            dgvAnimal.DataSource = Nothing
            txtConsultaAnimal.Text = Nothing
            MtxtFiltroData.Text = Nothing
            cmbFiltro.Text = Nothing

            bloqueiacampos()

            limpafiltros()

        Else
            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("Selecione um animal para alterar seus dados!")
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("Select an animal to change your data!")
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("Seleccione un animal para cambiar sus datos!")
            End If
        End If
    End Sub

    Private Sub limpafiltros()

        txtConsultaAnimal.Visible = False
        MtxtFiltroData.Visible = False
        btnBuscar.Visible = False

    End Sub

    Private Sub cmbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltro.SelectedIndexChanged

        limpacamposanimal()
        txtConsultaAnimal.Text = Nothing
        MtxtFiltroData.Text = Nothing

        If cmbFiltro.Text = "Código" Or cmbFiltro.Text = "ID" Or cmbFiltro.Text = "Nome" Or cmbFiltro.Text = "Name" Or cmbFiltro.Text = "Nombre" Then
            limpafiltros()
            txtConsultaAnimal.Visible = True
        End If

        If cmbFiltro.Text = "Data de cadastro" Or cmbFiltro.Text = "Date of registration" Or cmbFiltro.Text = "Fecha de registro" Then
            limpafiltros()
            MtxtFiltroData.Visible = True
        End If

        btnBuscar.Visible = True

    End Sub

End Class