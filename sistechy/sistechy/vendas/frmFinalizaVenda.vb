Imports System.Data.SqlClient
Public Class frmFinalizaVenda

    Private Sub limpacartoes()

        pbxVisa.Visible = False
        pbxMasterCard.Visible = False
        pbxHiperCard.Visible = False
        pbxDinnersClub.Visible = False
        pbxAura.Visible = False
        pbxAmericanExpress.Visible = False

        RadioVisa.Visible = False
        RadioMasterCard.Visible = False
        RadioHiperCard.Visible = False
        RadioDinnersClub.Visible = False
        RadioAura.Visible = False
        RadioAmericanExpress.Visible = False
        RadioOutro.Visible = False

        lbTroco.Visible = False
        txtTroco.Visible = False

        lbRecebido.Visible = False
        txtRecebido.Visible = False

    End Sub

    Private Sub frmFinalizaVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = ("select (cod_func) from funcionario where login_func =@login_func")
        comando.Parameters.AddWithValue("@login_func", frmPrincipal.txtUsuario.Text)

        Dim sqlReader2 As SqlDataReader

        sqlReader2 = comando.ExecuteReader()
        If sqlReader2.Read() Then
            txtCodFunc.Text = sqlReader2.GetInt32(0)
        End If
        sqlReader2.Close()

        Desconectar()

        cmbFormaPagamento.Items.Add("Dinheiro")
        cmbFormaPagamento.Items.Add("Cartão de crédito")
        cmbFormaPagamento.Items.Add("Cartão de débito")
        cmbFormaPagamento.Items.Add("Cheque")

        pbxVisa.BackgroundImage = My.Resources.cartao_visa
        pbxMasterCard.BackgroundImage = My.Resources.cartao_mastercard
        pbxHiperCard.BackgroundImage = My.Resources.cartao_hipercard
        pbxDinnersClub.BackgroundImage = My.Resources.cartao_dinnersclub
        pbxAura.BackgroundImage = My.Resources.cartao_aura
        pbxAmericanExpress.BackgroundImage = My.Resources.cartao_americanexpress

        Me.lbData.Text = frmPrincipal.lbData.Text

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = ("select (cod_func) from funcionario where login_func =@login_func")
        comando.Parameters.AddWithValue("@login_func", frmPrincipal.txtUsuario.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtCodFunc.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()

        Desconectar()

    End Sub

    Private Sub cmbFormaPagamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFormaPagamento.SelectedIndexChanged

        limpacartoes()

        If cmbFormaPagamento.Text = "Cartão de crédito" Or cmbFormaPagamento.Text = "Cartão de débito" Then

            pbxVisa.Visible = True
            pbxMasterCard.Visible = True
            pbxHiperCard.Visible = True
            pbxDinnersClub.Visible = True
            pbxAura.Visible = True
            pbxAmericanExpress.Visible = True

            RadioVisa.Visible = True
            RadioMasterCard.Visible = True
            RadioHiperCard.Visible = True
            RadioDinnersClub.Visible = True
            RadioAura.Visible = True
            RadioAmericanExpress.Visible = True
            RadioOutro.Visible = True

        End If

        If cmbFormaPagamento.Text = "Dinheiro" Then

            lbTroco.Visible = True
            txtTroco.Visible = True
            lbRecebido.Visible = True
            txtRecebido.Visible = True

        End If

    End Sub

    Private Sub btnFinalizarVenda_Click(sender As Object, e As EventArgs) Handles btnFinalizarVenda.Click

        If (MtxtCPFCli.Text) Is "" Then
            MessageBox.Show("Digite o código do cliente. Se ele não tiver um cadastro digite o número 0!")
            MtxtCPFCli.Focus()
        Else
            If (txtCodFunc.Text) Is "" Then
                MessageBox.Show("Digite o código do funcionário")
                txtCodFunc.Focus()
            Else

                Dim x As String = lbData.Text

                Dim y As String = x.Substring(x.Length - 4, 4)

                txtAno.Text = y

                Dim TestString As String = lbData.Text
                Dim MidWords As String = Mid(TestString, 4, 2)
                txtMes.Text = MidWords

                If (MtxtCPFCli.Text <> "" And txtCodFunc.Text <> "") Then
                    Cadastrar_venda(txtItens.Text, MtxtCPFCli.Text, txtCodFunc.Text, lbData.Text, txtValorTotal.Text, cmbFormaPagamento.Text, txtCartao.Text, txtMes.Text, txtAno.Text)
                End If
            End If
        End If

        Me.Close()
        frmPrincipal.Visible = True

    End Sub

    Private Sub RadioVisa_CheckedChanged(sender As Object, e As EventArgs) Handles RadioVisa.CheckedChanged
        txtCartao.Text = "Visa"
    End Sub

    Private Sub RadioMasterCard_CheckedChanged(sender As Object, e As EventArgs) Handles RadioMasterCard.CheckedChanged
        txtCartao.Text = "MasterCard"
    End Sub

    Private Sub RadioHiperCard_CheckedChanged(sender As Object, e As EventArgs) Handles RadioHiperCard.CheckedChanged
        txtCartao.Text = "HiperCard"
    End Sub

    Private Sub RadioDinnersClub_CheckedChanged(sender As Object, e As EventArgs) Handles RadioDinnersClub.CheckedChanged
        txtCartao.Text = "Dinners Club"
    End Sub

    Private Sub RadioAura_CheckedChanged(sender As Object, e As EventArgs) Handles RadioAura.CheckedChanged
        txtCartao.Text = "Aura"
    End Sub

    Private Sub RadioAmericanExpress_CheckedChanged(sender As Object, e As EventArgs) Handles RadioAmericanExpress.CheckedChanged
        txtCartao.Text = "American Express"
    End Sub

    Private Sub RadioOutro_CheckedChanged(sender As Object, e As EventArgs) Handles RadioOutro.CheckedChanged
        txtCartao.Text = "Outro"
    End Sub

    Private Sub txtRecebido_TextChanged(sender As Object, e As EventArgs) Handles txtRecebido.TextChanged

        If (txtRecebido.Text) Is "" Then
            txtTroco.Text = "0"
        Else

            txtTroco.Text = txtRecebido.Text - txtValorTotal.Text
        End If

    End Sub
End Class