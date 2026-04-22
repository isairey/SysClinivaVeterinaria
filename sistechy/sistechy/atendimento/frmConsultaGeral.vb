Imports System.Data.SqlClient
Public Class frmConsultaGeral

    Private Sub gerarcodigoconsulta()

        Conectar()

        Dim codigo As Integer
        comando.CommandText = "SELECT MAX(cod_consulta) FROM consulta"

        If IsDBNull(comando.ExecuteScalar) Then
            codigo = 1
            txtCodConsulta.Text = codigo
        Else
            codigo = comando.ExecuteScalar + 1
            txtCodConsulta.Text = codigo
        End If

    End Sub

    Private Sub frmConsultaGeral_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (frmPrincipal.lbIdioma.Text = "Português") Then

            cmbFiltroAnimal.Items.Add("Código")
            cmbFiltroAnimal.Items.Add("Nome")
            cmbFiltroAnimal.Items.Add("Data de cadastro")

            cmbFiltroVeterinario.Items.Add("Código")
            cmbFiltroVeterinario.Items.Add("Nome")
            cmbFiltroVeterinario.Items.Add("CPF")
            cmbFiltroVeterinario.Items.Add("Data de cadastro")

        End If

        If (frmPrincipal.lbIdioma.Text = "English") Then

            Me.Text = "Consultation"

            gpxVeterinario.Text = "Vet data"
            lbCodVeterinario.Text = "Search vet by: "
            lbCodigoVeterinario.Text = "ID"
            lbNomeVeterinario.Text = "Name"

            gpxAnimal.Text = "Animal data"
            lbCodAnimal.Text = "Search animal by: "
            lbCodigoAnimal.Text = "ID"
            lbNomeAnimal.Text = "Name"
            lbPorteAnimal.Text = "Sized"
            lbCastracaoAnimal.Text = "Castration"

            gpxConsulta.Text = "Details of consultation"
            lbDataConsulta.Text = "Date of consultation"
            lbDetalhesConsulta.Text = "Details"

            btnBuscaVeterinario.Text = "Search"
            btnBuscaAnimal.Text = "Search"

            pbxBanner.BackgroundImage = My.Resources.banner_consulta_english_fw
            btnCancelar.BackgroundImage = My.Resources.cancelar_english_fw
            btnSalvarConsulta.BackgroundImage = My.Resources.salvar_consulta_english_fw

            cmbFiltroAnimal.Items.Add("ID")
            cmbFiltroAnimal.Items.Add("Name")
            cmbFiltroAnimal.Items.Add("Date of registration")

            cmbFiltroVeterinario.Items.Add("ID")
            cmbFiltroVeterinario.Items.Add("Name")
            cmbFiltroVeterinario.Items.Add("CPF")
            cmbFiltroVeterinario.Items.Add("Date of registration")

        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Consulta"

            gpxVeterinario.Text = "Datos del veterinario"
            lbCodVeterinario.Text = "Buscar animales: "
            lbCodigoVeterinario.Text = "ID"
            lbNomeVeterinario.Text = "Nombre"

            gpxAnimal.Text = "Datos animal"
            lbCodAnimal.Text = "Buscar veterinario por:"
            lbCodigoAnimal.Text = "ID"
            lbNomeAnimal.Text = "Nombre"
            lbPorteAnimal.Text = "Tamanõ"
            lbCastracaoAnimal.Text = "Castración"

            gpxConsulta.Text = "Los detalles de la consulta"
            lbDataConsulta.Text = "Fecha del consulta"
            lbDetalhesConsulta.Text = "Detalles"

            btnBuscaVeterinario.Text = "Buscar"
            btnBuscaAnimal.Text = "Buscar"

            pbxBanner.BackgroundImage = My.Resources.banner_consulta_spanish_fw
            btnCancelar.BackgroundImage = My.Resources.cancelar_spanish_fw
            btnSalvarConsulta.BackgroundImage = My.Resources.salvar_consulta_spanish_fw

            cmbFiltroAnimal.Items.Add("ID")
            cmbFiltroAnimal.Items.Add("Nombre")
            cmbFiltroAnimal.Items.Add("Fecha de registro")

            cmbFiltroVeterinario.Items.Add("ID")
            cmbFiltroVeterinario.Items.Add("Nombre")
            cmbFiltroVeterinario.Items.Add("CPF")
            cmbFiltroVeterinario.Items.Add("Fecha de registro")

        End If

        gerarcodigoconsulta()

    End Sub

    Private Sub limpacamposfunc()

        dgvVeterinario.DataSource = Nothing
        txtCodVeterinario.Text = Nothing
        txtNomeVeterinario.Text = Nothing

    End Sub

    Private Sub limpacamposanimal()

        dgvAnimal.DataSource = Nothing
        txtCodAnimal.Text = Nothing
        txtNomeAnimal.Text = Nothing
        txtPorteAnimal.Text = Nothing
        txtCastracaoAnimal.Text = Nothing
        txtCaminhoImagem.Text = Nothing
        pbxAnimal.Image = Nothing

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

    Private Sub btnBuscarFunc_Click(sender As Object, e As EventArgs) Handles btnBuscaVeterinario.Click

        limpacamposfunc()
        Conectar()

        If cmbFiltroVeterinario.Text = "Código" Or cmbFiltroVeterinario.Text = "ID" Then
            dgvVeterinario.DataSource = Consulta_funcionario_codigo(txtConsultaVeterinario.Text)
        End If

        If cmbFiltroVeterinario.Text = "Nome" Or cmbFiltroVeterinario.Text = "Name" Or cmbFiltroVeterinario.Text = "Nombre" Then
            dgvVeterinario.DataSource = Consulta_funcionario_nome(txtConsultaVeterinario.Text)
        End If

        If cmbFiltroVeterinario.Text = "CPF" Then
            dgvVeterinario.DataSource = Consulta_funcionario_CPF(MtxtFiltroCPFVeterinario.Text)
        End If

        If cmbFiltroVeterinario.Text = "Data de cadastro" Or cmbFiltroVeterinario.Text = "Date of registration" Or cmbFiltroVeterinario.Text = "Fecha de registro" Then
            dgvVeterinario.DataSource = Consulta_funcionario_data(MtxtFiltroDataVeterinario.Text)
        End If

    End Sub

    Private Sub dgvFunc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVeterinario.CellClick

        Dim i As Integer
        i = dgvVeterinario.CurrentRow.Index
        Me.txtCodVeterinario.Text = dgvVeterinario.Item(0, i).Value
        Me.txtNomeVeterinario.Text = dgvVeterinario.Item(1, i).Value

    End Sub

    Private Sub btnBuscarAnimal_Click(sender As Object, e As EventArgs) Handles btnBuscaAnimal.Click

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

    Private Sub dgvAnimal_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAnimal.CellClick

        Dim i As Integer
        i = dgvAnimal.CurrentRow.Index
        Me.txtCaminhoImagem.Text = dgvAnimal.Item(0, i).Value
        Me.txtCodAnimal.Text = dgvAnimal.Item(1, i).Value
        Me.txtNomeAnimal.Text = dgvAnimal.Item(3, i).Value
        Me.txtPorteAnimal.Text = dgvAnimal.Item(7, i).Value
        Me.txtCastracaoAnimal.Text = dgvAnimal.Item(11, i).Value

        If txtCaminhoImagem.Text <> "" Then
            pbxAnimal.Image = New System.Drawing.Bitmap(txtCaminhoImagem.Text)
        End If

    End Sub

    Private Sub btnSalvarConsulta_Click(sender As Object, e As EventArgs) Handles btnSalvarConsulta.Click

        If txtCodVeterinario.Text = Nothing Then
            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("Selecione um veterinário")
                dgvVeterinario.Focus()
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("Select an vet")
                dgvVeterinario.Focus()
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("Seleccione un veterinario")
                dgvVeterinario.Focus()
            End If
        Else
            If txtCodAnimal.Text = Nothing Then
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
                If Not (MtxtDataConsulta.MaskFull) Then
                    If (frmPrincipal.lbIdioma.Text = "Português") Then
                        MessageBox.Show("O campo data da consulta não pode ficar vazio")
                        MtxtDataConsulta.Focus()
                    End If
                    If (frmPrincipal.lbIdioma.Text = "English") Then
                        MessageBox.Show("The date field of the query can not be empty")
                        MtxtDataConsulta.Focus()
                    End If
                    If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                        MessageBox.Show("El campo de la fecha de la consulta no puede estar vacío")
                        MtxtDataConsulta.Focus()
                    End If
                Else

                    Dim x As String = MtxtDataConsulta.Text

                    Dim y As String = x.Substring(x.Length - 4, 4)

                    txtAno.Text = y

                    Dim TestString As String = MtxtDataConsulta.Text
                    Dim MidWords As String = Mid(TestString, 4, 2)
                    txtMes.Text = MidWords

                    If (txtCodAnimal.Text <> "" And txtCodVeterinario.Text <> "" And MtxtDataConsulta.Text <> "") Then

                        Conectar()
                        Cadastrar_Consulta(txtCodAnimal.Text, txtCodVeterinario.Text, MtxtDataConsulta.Text, txtDetalhesConsulta.Text, txtMes.Text, txtAno.Text)

                        txtConsultaAnimal.Text = Nothing
                        MtxtFiltroDataAnimal.Text = Nothing
                        txtConsultaVeterinario.Text = Nothing
                        MtxtFiltroCPFVeterinario.Text = Nothing
                        MtxtFiltroDataVeterinario.Text = Nothing
                        dgvVeterinario.DataSource = Nothing
                        txtCodVeterinario.Text = Nothing
                        txtNomeVeterinario.Text = Nothing
                        dgvAnimal.DataSource = Nothing
                        txtCodAnimal.Text = Nothing
                        txtNomeAnimal.Text = Nothing
                        txtPorteAnimal.Text = Nothing
                        txtCastracaoAnimal.Text = Nothing
                        txtCaminhoImagem.Text = Nothing
                        MtxtDataConsulta.Text = Nothing
                        pbxAnimal.Image = Nothing
                        txtDetalhesConsulta.Text = Nothing

                        If (frmPrincipal.lbIdioma.Text = "Português") Then
                            MessageBox.Show("Cadastre uma nova consulta ou pressione o botão cancelar para realizar outra tarefa")
                        End If
                        If (frmPrincipal.lbIdioma.Text = "English") Then
                            MessageBox.Show("Register a new query or press the cancel button to perform another task")
                        End If
                        If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                            MessageBox.Show("Registrar una nueva consulta o pulse el botón de cancelación para realizar otra tarea")
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub frmConsultaGeral_Move(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Move

        Me.Location = New System.Drawing.Point(0, 0)

    End Sub

    Private Sub limpafiltrosanimal()

        txtConsultaAnimal.Visible = False
        MtxtFiltroDataAnimal.Visible = False
        btnBuscaAnimal.Visible = False

    End Sub

    Private Sub cmbFiltroAnimal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltroAnimal.SelectedIndexChanged

        limpacamposanimal()
        txtConsultaAnimal.Text = Nothing
        MtxtFiltroDataAnimal.Text = Nothing
        dgvAnimal.DataSource = Nothing

        If cmbFiltroAnimal.Text = "Código" Or cmbFiltroAnimal.Text = "ID" Or cmbFiltroAnimal.Text = "Nome" Or cmbFiltroAnimal.Text = "Name" Or cmbFiltroAnimal.Text = "Nombre" Then
            limpafiltrosanimal()
            txtConsultaAnimal.Visible = True
        End If

        If cmbFiltroAnimal.Text = "Data de cadastro" Or cmbFiltroAnimal.Text = "Date of registration" Or cmbFiltroAnimal.Text = "Fecha de registro" Then
            limpafiltrosanimal()
            MtxtFiltroDataAnimal.Visible = True
        End If

        btnBuscaAnimal.Visible = True

    End Sub

    Private Sub limpafiltrosveterinario()

        txtConsultaVeterinario.Visible = False
        MtxtFiltroDataVeterinario.Visible = False
        MtxtFiltroCPFVeterinario.Visible = False
        btnBuscaVeterinario.Visible = False

    End Sub

    Private Sub cmbFiltroVeterinario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltroVeterinario.SelectedIndexChanged

        txtConsultaVeterinario.Text = Nothing
        MtxtFiltroCPFVeterinario.Text = Nothing
        MtxtFiltroDataVeterinario.Text = Nothing
        dgvVeterinario.DataSource = Nothing

        If cmbFiltroVeterinario.Text = "Código" Or cmbFiltroVeterinario.Text = "ID" Or cmbFiltroVeterinario.Text = "Nome" Or cmbFiltroVeterinario.Text = "Name" Or cmbFiltroVeterinario.Text = "Nombre" Then
            limpafiltrosveterinario()
            txtConsultaVeterinario.Visible = True
        End If

        If cmbFiltroVeterinario.Text = "Data de cadastro" Or cmbFiltroVeterinario.Text = "Date of registration" Or cmbFiltroVeterinario.Text = "Fecha de registro" Then
            limpafiltrosveterinario()
            MtxtFiltroDataVeterinario.Visible = True
        End If

        If cmbFiltroVeterinario.Text = "CPF" Then
            limpafiltrosveterinario()
            MtxtFiltroCPFVeterinario.Visible = True
        End If

        btnBuscaVeterinario.Visible = True

    End Sub
End Class