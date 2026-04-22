Imports System.Data.SqlClient
Public Class frmCirurgia

    Private Sub gerarcodigocirurgia()

        Conectar()

        Dim codigo As Integer
        comando.CommandText = "SELECT MAX(cod_cirurgia) FROM cirurgia"

        If IsDBNull(comando.ExecuteScalar) Then
            codigo = 1
            txtCodCirurgia.Text = codigo
        Else
            codigo = comando.ExecuteScalar + 1
            txtCodCirurgia.Text = codigo
        End If

    End Sub

    Private Sub frmCirurgia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (frmPrincipal.lbIdioma.Text = "Português") Then

            cmbFiltroAnimal.Items.Add("Código")
            cmbFiltroAnimal.Items.Add("Nome")
            cmbFiltroAnimal.Items.Add("Data de cadastro")

            cmbFiltroCirurgiao.Items.Add("Código")
            cmbFiltroCirurgiao.Items.Add("Nome")
            cmbFiltroCirurgiao.Items.Add("CPF")
            cmbFiltroCirurgiao.Items.Add("Data de cadastro")

            cmbFiltroAnestesista.Items.Add("Código")
            cmbFiltroAnestesista.Items.Add("Nome")
            cmbFiltroAnestesista.Items.Add("CPF")
            cmbFiltroAnestesista.Items.Add("Data de cadastro")

        End If

        If (frmPrincipal.lbIdioma.Text = "English") Then

            Me.Text = "Surgery"

            gpxAnimal.Text = "Animal data"
            lbCodAnimal.Text = "Look for animals:"
            lbCodigoAnimal.Text = "ID"
            lbNomeAnimal.Text = "Name"
            lbPorteAnimal.Text = "Sized"

            gpxCirurgiao.Text = "Surgeon data"
            lbCodCirurgiao.Text = "Look for surgeons:"
            lbCodigoCirurgiao.Text = "ID"
            lbNomeCirurgiao.Text = "Name"

            gpxAnestesista.Text = "Anesthetist data"
            lbCodAnestesista.Text = "Look for anesthetists:"
            lbCodigoAnestesista.Text = "ID"
            lbNomeAnestesista.Text = "Name"

            gpxInfo.Text = "Details of surgery"
            lbCodCirurgia.Text = "Surgery ID"
            lbDataCirurgia.Text = "Date of surgery"
            lbDetalhesCirurgia.Text = "Details"

            btnBuscaAnimal.Text = "Search"
            btnBuscaCirurgiao.Text = "Search"
            btnBuscaAnestesista.Text = "Search"

            pbxBanner.BackgroundImage = My.Resources.banner_cirurgia_english_fw
            btnCancelar.BackgroundImage = My.Resources.cancelar_english_fw
            btnSalvarCirurgia.BackgroundImage = My.Resources.salva_cirurgia_english_fw

            cmbFiltroAnimal.Items.Add("ID")
            cmbFiltroAnimal.Items.Add("Name")
            cmbFiltroAnimal.Items.Add("Date of registration")

            cmbFiltroCirurgiao.Items.Add("ID")
            cmbFiltroCirurgiao.Items.Add("Name")
            cmbFiltroCirurgiao.Items.Add("CPF")
            cmbFiltroCirurgiao.Items.Add("Date of registration")

            cmbFiltroAnestesista.Items.Add("ID")
            cmbFiltroAnestesista.Items.Add("Name")
            cmbFiltroAnestesista.Items.Add("CPF")
            cmbFiltroAnestesista.Items.Add("Date of registration")

        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Cirugía"

            gpxAnimal.Text = "Datos del animal"
            lbCodAnimal.Text = "Buscar animales:"
            lbCodigoAnimal.Text = "ID"
            lbNomeAnimal.Text = "Nombre"
            lbPorteAnimal.Text = "Tamanõ"

            gpxCirurgiao.Text = "Datos del cirujano"
            lbCodCirurgiao.Text = "Busque cirujanos:"
            lbCodigoCirurgiao.Text = "ID"
            lbNomeCirurgiao.Text = "Nombre"

            gpxAnestesista.Text = "Datos del anestesista"
            lbCodAnestesista.Text = "Busque anestesistas:"
            lbCodigoAnestesista.Text = "ID"
            lbNomeAnestesista.Text = "Nombre"

            gpxInfo.Text = "Detalles de la cirugía"
            lbCodCirurgia.Text = "Cirugía ID"
            lbDataCirurgia.Text = "Fecha de la cirugía"
            lbDetalhesCirurgia.Text = "Detalles"

            btnBuscaAnimal.Text = "Buscar"
            btnBuscaCirurgiao.Text = "Buscar"
            btnBuscaAnestesista.Text = "Buscar"

            pbxBanner.BackgroundImage = My.Resources.banner_cirurgia_spanish_fw
            btnCancelar.BackgroundImage = My.Resources.cancelar_spanish_fw
            btnSalvarCirurgia.BackgroundImage = My.Resources.salva_cirurgia_spanish_fw

            cmbFiltroAnimal.Items.Add("ID")
            cmbFiltroAnimal.Items.Add("Nombre")
            cmbFiltroAnimal.Items.Add("Fecha de registro")

            cmbFiltroCirurgiao.Items.Add("ID")
            cmbFiltroCirurgiao.Items.Add("Nombre")
            cmbFiltroCirurgiao.Items.Add("CPF")
            cmbFiltroCirurgiao.Items.Add("Fecha de registro")

            cmbFiltroAnestesista.Items.Add("ID")
            cmbFiltroAnestesista.Items.Add("Nombre")
            cmbFiltroAnestesista.Items.Add("CPF")
            cmbFiltroAnestesista.Items.Add("Fecha de registro")

        End If

        gerarcodigocirurgia()

    End Sub

    Private Sub limpacamposanimal()

        dgvAnimal.DataSource = Nothing
        txtCodAnimal.Text = Nothing
        txtNomeAnimal.Text = Nothing
        txtPorteAnimal.Text = Nothing

    End Sub

    Private Sub limpacamposanestesista()

        dgvAnestesista.DataSource = Nothing
        txtCodAnestesista.Text = Nothing
        txtNomeAnestesista.Text = Nothing

    End Sub

    Private Sub limpacamposcirurgiao()

        dgvCirurgiao.DataSource = Nothing
        txtCodCirurgiao.Text = Nothing
        txtNomeCirurgiao.Text = Nothing

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

    Private Sub dgvAnimal_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAnimal.CellClick

        Dim i As Integer
        i = dgvAnimal.CurrentRow.Index
        Me.txtCodAnimal.Text = dgvAnimal.Item(1, i).Value
        Me.txtNomeAnimal.Text = dgvAnimal.Item(3, i).Value
        Me.txtPorteAnimal.Text = dgvAnimal.Item(7, i).Value

    End Sub

    Private Sub btnBuscaAnestesista_Click(sender As Object, e As EventArgs) Handles btnBuscaAnestesista.Click

        limpacamposanestesista()
        Conectar()

        If cmbFiltroCirurgiao.Text = "Código" Or cmbFiltroCirurgiao.Text = "ID" Then
            dgvAnestesista.DataSource = Consulta_funcionario_codigo(txtBuscaAnestesista.Text)
        End If

        If cmbFiltroCirurgiao.Text = "Nome" Or cmbFiltroCirurgiao.Text = "Name" Or cmbFiltroCirurgiao.Text = "Nombre" Then
            dgvAnestesista.DataSource = Consulta_funcionario_nome(txtBuscaAnestesista.Text)
        End If

        If cmbFiltroCirurgiao.Text = "CPF" Then
            dgvAnestesista.DataSource = Consulta_funcionario_CPF(MtxtFiltroCPFAnestesista.Text)
        End If

        If cmbFiltroCirurgiao.Text = "Data de cadastro" Or cmbFiltroCirurgiao.Text = "Date of registration" Or cmbFiltroCirurgiao.Text = "Fecha de registro" Then
            dgvAnestesista.DataSource = Consulta_funcionario_data(MtxtFiltroDataAnestesista.Text)
        End If

    End Sub

    Private Sub dgvAnestesista_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAnestesista.CellClick

        Dim i As Integer
        i = dgvAnestesista.CurrentRow.Index
        Me.txtCodAnestesista.Text = dgvAnestesista.Item(0, i).Value
        Me.txtNomeAnestesista.Text = dgvAnestesista.Item(1, i).Value

    End Sub

    Private Sub btnBuscaCirurgiao_Click(sender As Object, e As EventArgs) Handles btnBuscaCirurgiao.Click

        limpacamposcirurgiao()

        Conectar()

        If cmbFiltroCirurgiao.Text = "Código" Or cmbFiltroCirurgiao.Text = "ID" Then
            dgvCirurgiao.DataSource = Consulta_funcionario_codigo(txtConsultaCirurgiao.Text)
        End If

        If cmbFiltroCirurgiao.Text = "Nome" Or cmbFiltroCirurgiao.Text = "Name" Or cmbFiltroCirurgiao.Text = "Nombre" Then
            dgvCirurgiao.DataSource = Consulta_funcionario_nome(txtConsultaCirurgiao.Text)
        End If

        If cmbFiltroCirurgiao.Text = "CPF" Then
            dgvCirurgiao.DataSource = Consulta_funcionario_CPF(MtxtFiltroCPFCirurgiao.Text)
        End If

        If cmbFiltroCirurgiao.Text = "Data de cadastro" Or cmbFiltroCirurgiao.Text = "Date of registration" Or cmbFiltroCirurgiao.Text = "Fecha de registro" Then
            dgvCirurgiao.DataSource = Consulta_funcionario_data(MtxtFiltroDataCirurgiao.Text)
        End If

    End Sub

    Private Sub dgvCirurgiao_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCirurgiao.CellClick

        Dim i As Integer
        i = dgvCirurgiao.CurrentRow.Index
        Me.txtCodCirurgiao.Text = dgvCirurgiao.Item(0, i).Value
        Me.txtNomeCirurgiao.Text = dgvCirurgiao.Item(1, i).Value

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


    Private Sub btnSalvarCirurgia_Click(sender As Object, e As EventArgs) Handles btnSalvarCirurgia.Click

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
            If (txtCodAnestesista.Text) Is "" Then
                If (frmPrincipal.lbIdioma.Text = "Português") Then
                    MessageBox.Show("Selecione um anestesista")
                    dgvAnestesista.Focus()
                End If
                If (frmPrincipal.lbIdioma.Text = "English") Then
                    MessageBox.Show("Select an anesthesiologist")
                    dgvAnestesista.Focus()
                End If
                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                    MessageBox.Show("Seleccione un anestesista")
                    dgvAnestesista.Focus()
                End If
            Else
                If (txtCodCirurgiao.Text) Is "" Then
                    If (frmPrincipal.lbIdioma.Text = "Português") Then
                        MessageBox.Show("Selecione um cirurgião")
                        dgvCirurgiao.Focus()
                    End If
                    If (frmPrincipal.lbIdioma.Text = "English") Then
                        MessageBox.Show("Select a surgeon")
                        dgvCirurgiao.Focus()
                    End If
                    If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                        MessageBox.Show("Seleccione un cirujano")
                        dgvCirurgiao.Focus()
                    End If
                Else
                    If Not (MtxtDataCirurgia.MaskFull) Then
                        If (frmPrincipal.lbIdioma.Text = "Português") Then
                            MessageBox.Show("O campo data da cirurgia não pode ficar vazio")
                            MtxtDataCirurgia.Focus()
                        End If
                        If (frmPrincipal.lbIdioma.Text = "English") Then
                            MessageBox.Show("The date field of surgery can not be empty")
                            MtxtDataCirurgia.Focus()
                        End If
                        If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                            MessageBox.Show("El campo de la fecha de la cirugía no puede estar vacío")
                            MtxtDataCirurgia.Focus()
                        End If
                    Else

                        Dim x As String = MtxtDataCirurgia.Text

                        Dim y As String = x.Substring(x.Length - 4, 4)

                        txtAno.Text = y

                        Dim TestString As String = MtxtDataCirurgia.Text
                        Dim MidWords As String = Mid(TestString, 4, 2)
                        txtMes.Text = MidWords

                        If (txtCodAnimal.Text <> "" And txtCodAnestesista.Text <> "" And txtCodCirurgia.Text <> "" And MtxtDataCirurgia.Text <> "") Then

                            Conectar()

                            Dim message_portugues As Integer
                            Dim message_english As Integer
                            Dim message_spanish As Integer

                            If (frmPrincipal.lbIdioma.Text = "Português") Then
                                message_portugues = MessageBox.Show("Confirma que o código dos envolvidos na cirurgia são esses:" + vbCrLf +
                                                          "" + vbCrLf +
                                                          "Código no animal: " & txtCodAnimal.Text & ";" + vbCrLf +
                                                          "Código do anestesista: " & txtCodAnestesista.Text & ";" + vbCrLf +
                                                          "Código do cirurgião: " & txtCodCirurgiao.Text & ";", _
                                                          "Confirma ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            End If

                            If (frmPrincipal.lbIdioma.Text = "English") Then
                                message_portugues = MessageBox.Show("Confirms that the code involved in the surgery are these:" + vbCrLf +
                                                          "" + vbCrLf +
                                                          "Animal ID: " & txtCodAnimal.Text & ";" + vbCrLf +
                                                          "Anesthetist ID: " & txtCodAnestesista.Text & ";" + vbCrLf +
                                                          "Surgeon ID: " & txtCodCirurgiao.Text & ";", _
                                                          "Confirm ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            End If

                            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                message_portugues = MessageBox.Show("Confirma que el código implicado en la operación son los siguientes:" + vbCrLf +
                                                          "" + vbCrLf +
                                                          "Animal ID: " & txtCodAnimal.Text & ";" + vbCrLf +
                                                          "Anestesista ID: " & txtCodAnestesista.Text & ";" + vbCrLf +
                                                          "Cirujano ID: " & txtCodCirurgiao.Text & ";", _
                                                          "Confirma ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            End If

                            If message_portugues = vbYes Or message_english = vbYes Or message_spanish = vbYes Then

                                Cadastrar_Cirurgia(MtxtDataCirurgia.Text, txtCodAnimal.Text, txtCodCirurgiao.Text, txtCodAnestesista.Text, txtDetalhesCirurgia.Text, txtMes.Text, txtAno.Text)

                                txtConsultaAnimal.Text = Nothing
                                MtxtFiltroDataAnimal.Text = Nothing
                                txtConsultaCirurgiao.Text = Nothing
                                MtxtFiltroCPFCirurgiao.Text = Nothing
                                MtxtFiltroDataCirurgiao.Text = Nothing
                                txtBuscaAnestesista.Text = Nothing
                                MtxtFiltroCPFAnestesista.Text = Nothing
                                MtxtFiltroDataAnestesista.Text = Nothing
                                cmbFiltroAnimal.Text = Nothing
                                cmbFiltroCirurgiao.Text = Nothing
                                cmbFiltroAnestesista.Text = Nothing
                                dgvAnimal.DataSource = Nothing
                                txtCodAnimal.Text = Nothing
                                txtNomeAnimal.Text = Nothing
                                txtPorteAnimal.Text = Nothing
                                txtBuscaAnestesista.Text = Nothing
                                dgvAnestesista.DataSource = Nothing
                                txtCodAnestesista.Text = Nothing
                                txtNomeAnestesista.Text = Nothing
                                txtConsultaCirurgiao.Text = Nothing
                                dgvCirurgiao.DataSource = Nothing
                                txtCodCirurgiao.Text = Nothing
                                txtNomeCirurgiao.Text = Nothing
                                MtxtDataCirurgia.Text = Nothing
                                txtDetalhesCirurgia.Text = Nothing

                                gerarcodigocirurgia()

                                If (frmPrincipal.lbIdioma.Text = "Português") Then
                                    MessageBox.Show("Cadastre uma nova cirurgia ou pressione o botão cancelar para realizar outra tarefa")
                                End If
                                If (frmPrincipal.lbIdioma.Text = "English") Then
                                    MessageBox.Show("Register a new surgery or press the cancel button to perform another task")
                                End If
                                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                    MessageBox.Show("Registrar una nueva cirugía o pulse el botón de cancelación para realizar otra tarea")
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If


    End Sub

    Private Sub limpafiltrosanimal()

        txtConsultaAnimal.Visible = False
        MtxtFiltroDataAnimal.Visible = False
        btnBuscaAnimal.Visible = False

    End Sub

    Private Sub cmbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltroAnimal.SelectedIndexChanged

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

    Private Sub limpafiltroscirurgiao()

        txtConsultaCirurgiao.Visible = False
        MtxtFiltroDataCirurgiao.Visible = False
        MtxtFiltroCPFCirurgiao.Visible = False
        btnBuscaCirurgiao.Visible = False

    End Sub

    Private Sub cmbFiltroCirurgiao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltroCirurgiao.SelectedIndexChanged

        limpacamposcirurgiao()
        txtConsultaCirurgiao.Text = Nothing
        MtxtFiltroCPFCirurgiao.Text = Nothing
        MtxtFiltroDataCirurgiao.Text = Nothing
        dgvCirurgiao.DataSource = Nothing

        If cmbFiltroCirurgiao.Text = "Código" Or cmbFiltroCirurgiao.Text = "ID" Or cmbFiltroCirurgiao.Text = "Nome" Or cmbFiltroCirurgiao.Text = "Name" Or cmbFiltroCirurgiao.Text = "Nombre" Then
            limpafiltroscirurgiao()
            txtConsultaCirurgiao.Visible = True
        End If

        If cmbFiltroCirurgiao.Text = "Data de cadastro" Or cmbFiltroCirurgiao.Text = "Date of registration" Or cmbFiltroCirurgiao.Text = "Fecha de registro" Then
            limpafiltroscirurgiao()
            MtxtFiltroDataCirurgiao.Visible = True
        End If

        If cmbFiltroCirurgiao.Text = "CPF" Then
            limpafiltroscirurgiao()
            MtxtFiltroCPFCirurgiao.Visible = True
        End If

        btnBuscaCirurgiao.Visible = True

    End Sub

    Private Sub limpafiltrosanestesista()

        txtBuscaAnestesista.Visible = False
        MtxtFiltroDataAnestesista.Visible = False
        MtxtFiltroCPFAnestesista.Visible = False
        btnBuscaAnestesista.Visible = False

    End Sub

    Private Sub cmbFiltroAnestesista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltroAnestesista.SelectedIndexChanged

        limpacamposanestesista()
        txtBuscaAnestesista.Text = Nothing
        MtxtFiltroCPFAnestesista.Text = Nothing
        MtxtFiltroDataAnestesista.Text = Nothing

        If cmbFiltroAnestesista.Text = "Código" Or cmbFiltroAnestesista.Text = "ID" Or cmbFiltroAnestesista.Text = "Nome" Or cmbFiltroAnestesista.Text = "Name" Or cmbFiltroAnestesista.Text = "Nombre" Then
            limpafiltrosanestesista()
            txtBuscaAnestesista.Visible = True
        End If

        If cmbFiltroAnestesista.Text = "Data de cadastro" Or cmbFiltroAnestesista.Text = "Date of registration" Or cmbFiltroAnestesista.Text = "Fecha de registro" Then
            limpafiltrosanestesista()
            MtxtFiltroDataAnestesista.Visible = True
        End If

        If cmbFiltroAnestesista.Text = "CPF" Then
            limpafiltrosanestesista()
            MtxtFiltroCPFAnestesista.Visible = True
        End If

        btnBuscaAnestesista.Visible = True

    End Sub
End Class