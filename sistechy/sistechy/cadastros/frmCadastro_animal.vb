Public Class frmCadastro_animal

    Private Sub limpacamposdono()

        txtCodDono.Text = Nothing
        txtNomeDono.Text = Nothing

    End Sub

    Private Sub frmCadastro_animal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

            Me.Text = "Registration of animal"

            gpxAnimal.Text = "Animal data"
            gpxDono.Text = "Owner data"

            lbNome.Text = "Name(*)"
            lbEspecie.Text = "Species"
            lbRaca.Text = "Race"
            lbSexo.Text = "Sex(*)"
            lbPorte.Text = "Gate"
            lbPeso.Text = "Weight"
            lbIdade.Text = "Age"
            lbCor.Text = "Color"
            lbCastracao.Text = "Castration"
            lbDataCad.Text = "Date of registration"
            lbAviso.Text = "Fields with (*) are mandatory"
            lbRelacioneDono.Text = "Select owner"
            lbDigiteCodigo.Text = "Search by:"
            lbCodDono.Text = "Owner ID"
            lbNomeDono.Text = "Owner name"

            btnLoadImage.Text = "Load image"
            btnBuscarDono.Text = "Search"

            cmbSexoAnimal.Items.Add("Male")
            cmbSexoAnimal.Items.Add("Female")
            cmbPorteAnimal.Items.Add("Small")
            cmbPorteAnimal.Items.Add("Mid")
            cmbPorteAnimal.Items.Add("Large")
            cmbCastracaoAnimal.Items.Add("Yes")
            cmbCastracaoAnimal.Items.Add("No")

            cmbFiltro.Items.Add("ID")
            cmbFiltro.Items.Add("Name")
            cmbFiltro.Items.Add("Date of cadastration")

            Me.pbxBannerAnimal.BackgroundImage = My.Resources.banner_cadastro_animal_english_fw
            Me.btnCancelar.BackgroundImage = My.Resources.cancelar_english_fw
            Me.btnCadastraAnimal.BackgroundImage = My.Resources.salva_cadastro_english_fw

        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Registro de animal"

            gpxAnimal.Text = "Datos del animal"
            gpxDono.Text = "Datos del propietario"

            lbNome.Text = "Nombre(*)"
            lbEspecie.Text = "Especie"
            lbRaca.Text = "Raza"
            lbSexo.Text = "Sexo(*)"
            lbPorte.Text = "Franqueo"
            lbPeso.Text = "Peso"
            lbIdade.Text = "Edad"
            lbCor.Text = "Color"
            lbCastracao.Text = "Castración"
            lbDataCad.Text = "Fecha de registro"
            lbAviso.Text = "Los campos con (*) son obligatorios"
            lbRelacioneDono.Text = "Seleccione el propietario"
            lbDigiteCodigo.Text = "Buscar: "
            lbCodDono.Text = "ID propietario"
            lbNomeDono.Text = "Nombre propietario"

            btnLoadImage.Text = "Cargar la imagen"
            btnBuscarDono.Text = "Buscar"

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

            Me.pbxBannerAnimal.BackgroundImage = My.Resources.banner_cadastro_animal_spanish_fw
            Me.btnCancelar.BackgroundImage = My.Resources.cancelar_spanish_fw
            Me.btnCadastraAnimal.BackgroundImage = My.Resources.salva_cadastro_spanish_fw

        End If

    End Sub

    Private Sub limpafiltros()

        dgvListaDono.DataSource = Nothing
        btnBuscarDono.Visible = False
        txtConsultaDono.Visible = False
        MtxtFiltroData.Visible = False
        txtCodDono.Text = Nothing
        txtNomeDono.Text = Nothing

    End Sub

    Private Sub cmbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltro.SelectedIndexChanged

        limpafiltros()
        txtConsultaDono.Text = Nothing
        txtNomeDono.Text = Nothing

        If cmbFiltro.Text = "Código" Or cmbFiltro.Text = "ID" Or cmbFiltro.Text = "Nome" Or cmbFiltro.Text = "Name" Or cmbFiltro.Text = "Nombre" Then
            limpafiltros()
            txtConsultaDono.Visible = True
        End If

        If cmbFiltro.Text = "Data de cadastro" Or cmbFiltro.Text = "Date of registration" Or cmbFiltro.Text = "Fecha de registro" Then
            limpafiltros()
            MtxtFiltroData.Visible = True
        End If

        btnBuscarDono.Visible = True

    End Sub

    Private Sub btnBuscarDono_Click(sender As Object, e As EventArgs) Handles btnBuscarDono.Click

        limpacamposdono()
        Conectar()

        If cmbFiltro.Text = "Código" Or cmbFiltro.Text = "ID" Then
            dgvListaDono.DataSource = Consulta_cliente_codigo(txtConsultaDono.Text)
        End If

        If cmbFiltro.Text = "Nome" Or cmbFiltro.Text = "Name" Or cmbFiltro.Text = "Nombre" Then
            dgvListaDono.DataSource = Consulta_cliente_nome(txtConsultaDono.Text)
        End If

        If cmbFiltro.Text = "Data de cadastro" Or cmbFiltro.Text = "Date of registration" Or cmbFiltro.Text = "Fecha de registro" Then
            dgvListaDono.DataSource = Consulta_cliente_data(MtxtFiltroData.Text)
        End If

    End Sub

    Private Sub btnLoadImage_Click(sender As Object, e As EventArgs) Handles btnLoadImage.Click

        Dim openfd As New OpenFileDialog

        openfd.Filter = "Imagens (*.jpg;*jpeg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif;*.jpeg"

        If openfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtLocalImagem.Text = openfd.FileName

            pbxAnimal.Image = New System.Drawing.Bitmap(txtLocalImagem.Text)

        End If
    End Sub

    Private Sub dgvListaDono_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaDono.CellClick

        Dim i As Integer
        i = dgvListaDono.CurrentRow.Index
        Me.txtCodDono.Text = dgvListaDono.Item(0, i).Value
        Me.txtNomeDono.Text = dgvListaDono.Item(1, i).Value

    End Sub

    Private Sub btnCadastraAnimal_Click(sender As Object, e As EventArgs) Handles btnCadastraAnimal.Click

        If (txtNomeAnimal.Text) Is "" Then
            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("O campo Nome não pode ficar vazio!")
                txtNomeAnimal.Focus()
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("The name field can not be empty!")
                txtNomeAnimal.Focus()
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("El campo Nombre no puede estar vacío!")
                txtNomeAnimal.Focus()
            End If
        Else
            If (cmbSexoAnimal.Text) Is "" Then
                If (frmPrincipal.lbIdioma.Text = "Português") Then
                    MessageBox.Show("O campo Sexo não pode ficar vazio!")
                    cmbSexoAnimal.Focus()
                End If
                If (frmPrincipal.lbIdioma.Text = "English") Then
                    MessageBox.Show("Sex field can not be empty!")
                    cmbSexoAnimal.Focus()
                End If
                If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                    MessageBox.Show("El campo de género no puede estar vacío!")
                    cmbSexoAnimal.Focus()
                End If
            Else
                If Not (MtxtDataCadAnimal.MaskFull) Then
                    If (frmPrincipal.lbIdioma.Text = "Português") Then
                        MessageBox.Show("O campo Data de Cadastro não pode ficar vazio!")
                        MtxtDataCadAnimal.Focus()
                    End If
                    If (frmPrincipal.lbIdioma.Text = "English") Then
                        MessageBox.Show("The registration date field can not be empty!")
                        MtxtDataCadAnimal.Focus()
                    End If
                    If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                        MessageBox.Show("El campo de fecha de registro no puede estar vacío!")
                        MtxtDataCadAnimal.Focus()
                    End If
                Else
                    If (txtCodDono.Text) Is "" Then
                        If (frmPrincipal.lbIdioma.Text = "Português") Then
                            MessageBox.Show("Selecione o dono do animal!")
                        End If
                        If (frmPrincipal.lbIdioma.Text = "English") Then
                            MessageBox.Show("Select the pet owner!")
                        End If
                        If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                            MessageBox.Show("Seleccione el dueño de la mascota!")
                        End If
                    Else

                        Dim x As String = MtxtDataCadAnimal.Text

                        Dim y As String = x.Substring(x.Length - 4, 4)

                        txtAno.Text = y

                        Dim TestString As String = MtxtDataCadAnimal.Text
                        Dim MidWords As String = Mid(TestString, 4, 2)
                        txtMes.Text = MidWords

                        If (txtNomeAnimal.Text <> "" And cmbSexoAnimal.Text <> "") Then

                            Conectar()
                            Cadastrar_Animal(txtLocalImagem.Text, txtCodDono.Text, txtNomeAnimal.Text, txtEspecieAnimal.Text, txtRacaAnimal.Text, cmbSexoAnimal.Text, cmbPorteAnimal.Text, txtPesoAnimal.Text, txtIdadeAnimal.Text, txtCorAnimal.Text, cmbCastracaoAnimal.Text, MtxtDataCadAnimal.Text, txtMes.Text, txtAno.Text)

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
                            txtLocalImagem.Text = Nothing
                            pbxAnimal.Text = Nothing
                            txtCodDono.Text = Nothing
                            txtNomeDono.Text = Nothing
                            dgvListaDono.DataSource = Nothing
                            pbxAnimal.Image = Nothing
                            txtConsultaDono.Text = Nothing
                            cmbFiltro.Text = Nothing

                            limpafiltros()

                            If (frmPrincipal.lbIdioma.Text = "Português") Then
                                MessageBox.Show("Cadastre um novo animal ou pressione o botão cancelar para realizar outra tarefa")
                            End If
                            If (frmPrincipal.lbIdioma.Text = "English") Then
                                MessageBox.Show("Register a new pet or press the cancel button to perform another task")
                            End If
                            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                                MessageBox.Show("Registrar una nueva mascota o pulse el botón de cancelación para realizar otra tarea")
                            End If
                        End If
                    End If
                End If
            End If
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
End Class