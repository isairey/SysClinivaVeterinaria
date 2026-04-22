Imports System.Data.SqlClient
Public Class frmInternacao

    Private Sub gerarcodigointernacao()

        Conectar()

        Dim codigo As Integer
        comando.CommandText = "SELECT Max(cod_internacao) FROM internacao"

        If IsDBNull(comando.ExecuteScalar) Then
            codigo = 1
            txtCodInternacao.Text = codigo
        Else
            codigo = comando.ExecuteScalar + 1
            txtCodInternacao.Text = codigo
        End If

    End Sub

    Private Sub limpacamposanimal()

        dgvAnimal.DataSource = Nothing
        txtCodAnimal.Text = Nothing
        txtNomeAnimal.Text = Nothing
        txtPorteAnimal.Text = Nothing

    End Sub

    Private Sub limpacamposleito()

        dgvLeito.DataSource = Nothing
        txtNumLeito.Text = Nothing
        txtPorteLeito.Text = Nothing
        txtStatusLeito.Text = Nothing

    End Sub

    Private Sub dgvAnimal_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAnimal.CellClick

        Dim i As Integer
        i = dgvAnimal.CurrentRow.Index
        Me.txtCodAnimal.Text = dgvAnimal.Item(1, i).Value
        Me.txtNomeAnimal.Text = dgvAnimal.Item(3, i).Value
        Me.txtPorteAnimal.Text = dgvAnimal.Item(7, i).Value

    End Sub

    Private Sub frmInternacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (frmPrincipal.lbIdioma.Text = "Português") Then

            cmbFiltroAnimal.Items.Add("Código")
            cmbFiltroAnimal.Items.Add("Nome")
            cmbFiltroAnimal.Items.Add("Data de cadastro")

        End If

        If (frmPrincipal.lbIdioma.Text = "English") Then

            Me.Text = "Internation"

            gpxAnimal.Text = "Animal data"
            lbCodAnimal.Text = "Search animal by: "
            lbCodigoAnimal.Text = "ID"
            lbNomeAnimal.Text = "Name"
            lbPorteAnimal.Text = "Sized"

            gpxInternacao.Text = "Hospitalization data"
            lbCodInternacao.Text = "Hospitalization ID"
            lbDataInternacao.Text = "Date of Hospitalization"
            lbCodLeito.Text = "Enter the ID of bed: "
            lbDetalhes.Text = "Details"
            lbNumeroLeito.Text = "Bed number"
            lbPorteLeito.Text = "Sized"
            lbEmUso.Text = "In use"

            btnBuscaAnimal.Text = "Search"
            btnBuscaLeito.Text = "Search"

            pbxBanner.BackgroundImage = My.Resources.banner_internacao_english_fw
            btnCancelar.BackgroundImage = My.Resources.cancelar_english_fw
            BtnSalvarInternacao.BackgroundImage = My.Resources.salva_internacao_english_fw

            cmbFiltroAnimal.Items.Add("ID")
            cmbFiltroAnimal.Items.Add("Name")
            cmbFiltroAnimal.Items.Add("Date of registration")

        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Hospitalización"

            gpxAnimal.Text = "Datos del animal"
            lbCodAnimal.Text = "Buscar animales:"
            lbCodigoAnimal.Text = "ID"
            lbNomeAnimal.Text = "Nombre"
            lbPorteAnimal.Text = "Tamanõ"

            gpxInternacao.Text = "Datos del Hospitalización"
            lbCodInternacao.Text = "Hospitalización ID"
            lbDataInternacao.Text = "Fecha de Hospitalización"
            lbCodLeito.Text = "Introduzca el ID de la cama: "
            lbDetalhes.Text = "Detalles"
            lbNumeroLeito.Text = "Número de cama"
            lbPorteLeito.Text = "Tamanõ"
            lbEmUso.Text = "En uso"

            btnBuscaAnimal.Text = "Buscar"
            btnBuscaLeito.Text = "Buscar"

            pbxBanner.BackgroundImage = My.Resources.banner_internacao_spanish_fw
            btnCancelar.BackgroundImage = My.Resources.cancelar_spanish_fw
            BtnSalvarInternacao.BackgroundImage = My.Resources.salva_internacao_spanish_fw

            cmbFiltroAnimal.Items.Add("ID")
            cmbFiltroAnimal.Items.Add("Nombre")
            cmbFiltroAnimal.Items.Add("Fecha de registro")

        End If

        gerarcodigointernacao()

    End Sub

    Private Sub btnBuscaAnimal_Click(sender As Object, e As EventArgs) Handles btnBuscaAnimal.Click

        limpacamposanimal()
        Conectar()

        If cmbFiltroAnimal.Text = "Código" Or cmbFiltroAnimal.Text = "ID" Then
            dgvAnimal.DataSource = Consulta_animal_codigo(txtConsultaAnimal.Text)
        End If

        If cmbFiltroAnimal.Text = "Nome" Or cmbFiltroAnimal.Text = "Name" Or cmbFiltroAnimal.Text = "Nombre" Then
            dgvAnimal.DataSource = Consulta_animal_nome(txtConsultaAnimal.Text)
        End If

        If cmbFiltroAnimal.Text = "Data de cadastro" Or cmbFiltroAnimal.Text = "Date of registration" Or cmbFiltroAnimal.Text = "Fecha de registro" Then
            dgvAnimal.DataSource = Consulta_animal_data(MtxtFiltroDataAnimal.Text)
        End If

    End Sub

    Private Sub btnBuscaLeito_Click(sender As Object, e As EventArgs) Handles btnBuscaLeito.Click

        limpacamposleito()
        Conectar()
        dgvLeito.DataSource = Consulta_leito(txtBuscaLeito.Text)

    End Sub

    Private Sub dgvLeito_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLeito.CellClick

        Dim i As Integer
        i = dgvLeito.CurrentRow.Index
        Me.txtNumLeito.Text = dgvLeito.Item(0, i).Value
        Me.txtPorteLeito.Text = dgvLeito.Item(1, i).Value
        Me.txtStatusLeito.Text = dgvLeito.Item(2, i).Value

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

    Private Sub BtnSalvarVacinacao_Click(sender As Object, e As EventArgs) Handles BtnSalvarInternacao.Click

        If (txtCodAnimal.Text) Is "" Then
            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("Selecione um animal")
                dgvAnimal.Focus()
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("Select an animal")
                dgvAnimal.Focus()
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("Seleccione un animal")
                dgvAnimal.Focus()
            End If
        Else
            If (txtNumLeito.Text) Is "" Then
                If (frmPrincipal.lbIdioma.Text = "Português") Then
                    MessageBox.Show("Selecione um leito")
                    dgvLeito.Focus()
                End If
                If (frmPrincipal.lbIdioma.Text = "English") Then
                    MessageBox.Show("Select an bed")
                    dgvLeito.Focus()
                End If
                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                    MessageBox.Show("Seleccione una cama")
                    dgvLeito.Focus()
                End If
            Else
                If (txtStatusLeito.Text = "sim" Or txtStatusLeito.Text = "yes") Then
                    If (frmPrincipal.lbIdioma.Text = "Português") Then
                        MessageBox.Show("O leito " & txtNumLeito.Text & " já esta em uso, por favor selecione outro")
                        txtBuscaLeito.Focus()
                    End If
                    If (frmPrincipal.lbIdioma.Text = "English") Then
                        MessageBox.Show("The bed " & txtNumLeito.Text & " is already in use, please choose another")
                        txtBuscaLeito.Focus()
                    End If
                    If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                        MessageBox.Show("La cama " & txtNumLeito.Text & "ya está en uso, por favor elija otro")
                        txtBuscaLeito.Focus()
                    End If
                Else
                    If (txtPorteLeito.Text <> txtPorteAnimal.Text) Then
                        If (frmPrincipal.lbIdioma.Text = "Português") Then
                            MessageBox.Show("O leito selecionado não corresponde ao porte do animal")
                            txtBuscaLeito.Focus()
                        End If
                        If (frmPrincipal.lbIdioma.Text = "English") Then
                            MessageBox.Show("The selected bed does not match the size of the animal")
                            txtBuscaLeito.Focus()
                        End If
                        If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                            MessageBox.Show("La cama seleccionado no coincide con el tamaño de los animales")
                            txtBuscaLeito.Focus()
                        End If
                    Else
                        If Not (MtxtDataInternacao.MaskFull) Then
                            If (frmPrincipal.lbIdioma.Text = "Português") Then
                                MessageBox.Show("O campo Data internação não pode ficar vazio")
                                MtxtDataInternacao.Focus()
                            End If
                            If (frmPrincipal.lbIdioma.Text = "English") Then
                                MessageBox.Show("Field Data admission can not be empty")
                                MtxtDataInternacao.Focus()
                            End If
                            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                MessageBox.Show("Ingreso de datos de campo no puede estar vacío")
                                MtxtDataInternacao.Focus()
                            End If
                        Else

                            Dim x As String = MtxtDataInternacao.Text

                            Dim y As String = x.Substring(x.Length - 4, 4)

                            txtAno.Text = y

                            Dim TestString As String = MtxtDataInternacao.Text
                            Dim MidWords As String = Mid(TestString, 4, 2)
                            txtMes.Text = MidWords

                            If (txtCodAnimal.Text <> "" And txtNumLeito.Text <> "" And MtxtDataInternacao.Text <> "") Then

                                Dim message_portugues As Integer
                                Dim message_english As Integer
                                Dim message_spanish As Integer

                                If (frmPrincipal.lbIdioma.Text = "Português") Then
                                    message_portugues = MessageBox.Show("Confirma a ocupação do leito: " & txtNumLeito.Text & " ?", _
                                                                          "Confirma ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                End If
                                If (frmPrincipal.lbIdioma.Text = "English") Then
                                    message_english = MessageBox.Show("Confirms the bed occupancy: " & txtNumLeito.Text & " ?", _
                                                                          "Confirm ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                End If
                                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                    message_spanish = MessageBox.Show("Confirma la ocupación de camas: " & txtNumLeito.Text & " ?", _
                                                                          "Confirma ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                End If

                                If message_portugues = vbYes Or message_english = vbYes Or message_spanish = vbYes And txtNumLeito.Text <> "" Then

                                    Conectar()

                                    comando.CommandText = "update leito set status_leito='sim' where cod_leito= @cod_leito"
                                    comando.Parameters.AddWithValue("@cod_leito", txtNumLeito.Text)

                                    comando.ExecuteNonQuery()
                                    Desconectar()
                                End If

                                Cadastrar_Internacao(txtCodAnimal.Text, MtxtDataInternacao.Text, txtNumLeito.Text, txtDetalhesInternacao.Text, txtMes.Text, txtAno.Text)

                                txtConsultaAnimal.Text = Nothing
                                MtxtFiltroDataAnimal.Text = Nothing
                                cmbFiltroAnimal.Text = Nothing
                                dgvAnimal.DataSource = Nothing
                                txtCodAnimal.Text = Nothing
                                txtNomeAnimal.Text = Nothing
                                txtPorteAnimal.Text = Nothing
                                txtBuscaLeito.Text = Nothing
                                dgvLeito.DataSource = Nothing
                                txtNumLeito.Text = Nothing
                                txtPorteLeito.Text = Nothing
                                txtStatusLeito.Text = Nothing
                                MtxtDataInternacao.Text = Nothing
                                txtDetalhesInternacao.Text = Nothing

                                If (frmPrincipal.lbIdioma.Text = "Português") Then
                                    MessageBox.Show("Efetue o cadastro de outra iternação ou pressione o botão cancelar para realizar outra tarefa")
                                End If
                                If (frmPrincipal.lbIdioma.Text = "English") Then
                                    MessageBox.Show("Perform the registration of another iternação or press the cancel button to perform another task")
                                End If
                                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                    MessageBox.Show("Realize el registro de otro iternação o pulse el botón de cancelación para realizar otra tarea")
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub limpafiltros()

        txtConsultaAnimal.Visible = False
        MtxtFiltroDataAnimal.Visible = False
        btnBuscaAnimal.Visible = False

    End Sub

    Private Sub cmbFiltroAnimal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltroAnimal.SelectedIndexChanged

        limpacamposanimal()
        txtConsultaAnimal.Text = Nothing
        MtxtFiltroDataAnimal.Text = Nothing

        If cmbFiltroAnimal.Text = "Código" Or cmbFiltroAnimal.Text = "ID" Or cmbFiltroAnimal.Text = "Nome" Or cmbFiltroAnimal.Text = "Name" Or cmbFiltroAnimal.Text = "Nombre" Then
            limpafiltros()
            txtConsultaAnimal.Visible = True
        End If

        If cmbFiltroAnimal.Text = "Data de cadastro" Or cmbFiltroAnimal.Text = "Date of registration" Or cmbFiltroAnimal.Text = "Fecha de registro" Then
            limpafiltros()
            MtxtFiltroDataAnimal.Visible = True
        End If

        btnBuscaAnimal.Visible = True

    End Sub
End Class
