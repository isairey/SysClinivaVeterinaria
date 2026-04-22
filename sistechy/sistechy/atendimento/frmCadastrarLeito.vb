Imports System.Data.SqlClient
Public Class frmCadastrarLeito

    Private Sub gerarcodigovacinacao()

        Conectar()

        Dim codigo As Integer
        comando.CommandText = "select max(cod_leito) from leito"

        If IsDBNull(comando.ExecuteScalar) Then
            codigo = 1
            txtCodLeito.Text = codigo
        Else
            codigo = comando.ExecuteScalar + 1
            txtCodLeito.Text = codigo
        End If

    End Sub

    Private Sub frmCadastrarLeito_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (frmPrincipal.lbIdioma.Text = "Português") Then

            cmbPorteLeito.Items.Add("Pequeno")
            cmbPorteLeito.Items.Add("Médio")
            cmbPorteLeito.Items.Add("Grande")

            txtStatusLeito.Text = "não"

        End If

        If (frmPrincipal.lbIdioma.Text = "English") Then

            Me.Text = "Post a new bed"

            lbCodigoLeito.Text = "Code Bed"
            lbPorteLeito.Text = "Sized Bed"
            lbEmUso.Text = "In use"

            cmbPorteLeito.Items.Add("Small")
            cmbPorteLeito.Items.Add("Mid")
            cmbPorteLeito.Items.Add("Large")

            txtStatusLeito.Text = "no"

            btnCancelar.BackgroundImage = My.Resources.cancelar_english_fw
            btnCadastrarLeito.BackgroundImage = My.Resources.salva_cadastro_english_fw
            pbxBanner.BackgroundImage = My.Resources.banner_cadastrar_leito_english_fw

        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Publica una cama nueva"

            lbCodigoLeito.Text = "Código de cama"
            lbPorteLeito.Text = "Tamaño cama"
            lbEmUso.Text = "En uso"

            cmbPorteLeito.Items.Add("Pequeño")
            cmbPorteLeito.Items.Add("Medio")
            cmbPorteLeito.Items.Add("Grande")

            txtStatusLeito.Text = "No"

            btnCancelar.BackgroundImage = My.Resources.cancelar_spanish_fw
            btnCadastrarLeito.BackgroundImage = My.Resources.salva_cadastro_spanish_fw
            pbxBanner.BackgroundImage = My.Resources.banner_alterar_horario_spanish_fw

        End If

        gerarcodigovacinacao()

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

    Private Sub btnCadastrarLeito_Click(sender As Object, e As EventArgs) Handles btnCadastrarLeito.Click

        If (cmbPorteLeito.Text) Is "" Then

            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("O porte do leito não pode ficar vazio")
                txtCodLeito.Focus()
            End If
            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("The size of the bed can not be empty")
                cmbPorteLeito.Focus()
            End If
            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("El tamaño de la cama no puede estar vacío")
                cmbPorteLeito.Focus()
            End If

        End If

        If (cmbPorteLeito.Text <> "") Then

            Conectar()

            Cadastrar_leito(cmbPorteLeito.Text, txtStatusLeito.Text)

            gerarcodigovacinacao()

            cmbPorteLeito.Text = Nothing


            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MessageBox.Show("Cadastre um novo leito ou pressione o botão cancelar para sair", _
                                                  "", MessageBoxButtons.OK, MessageBoxIcon.Question)
            End If

            If (frmPrincipal.lbIdioma.Text = "English") Then
                MessageBox.Show("Register a new bed or press the cancel button to exit", _
                                                  "", MessageBoxButtons.OK, MessageBoxIcon.Question)
            End If

            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MessageBox.Show("Registrar una cama nueva o pulse el botón cancelar para salir", _
                                                  "", MessageBoxButtons.OK, MessageBoxIcon.Question)
            End If
        End If

    End Sub
End Class