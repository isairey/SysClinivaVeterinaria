Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient
Public Class frmGraficos

    Private Sub geraclientejaneiro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM cliente where mes_cli = '01' and ano_cli =@ano_cli"
        comando.Parameters.AddWithValue("@ano_cli", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJaneiro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraclientefevereiro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM cliente where mes_cli = '02' and ano_cli =@ano_cli"
        comando.Parameters.AddWithValue("@ano_cli", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtFevereiro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraclientemarco()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM cliente where mes_cli = '03' and ano_cli =@ano_cli"
        comando.Parameters.AddWithValue("@ano_cli", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtMarco.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraclienteabril()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM cliente where mes_cli = '04' and ano_cli =@ano_cli"
        comando.Parameters.AddWithValue("@ano_cli", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtAbril.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraclientemaio()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM cliente where mes_cli = '05' and ano_cli =@ano_cli"
        comando.Parameters.AddWithValue("@ano_cli", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtMaio.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraclientejunho()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM cliente where mes_cli = '06' and ano_cli =@ano_cli"
        comando.Parameters.AddWithValue("@ano_cli", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJunho.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraclientejulho()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM cliente where mes_cli = '07' and ano_cli =@ano_cli"
        comando.Parameters.AddWithValue("@ano_cli", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJulho.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraclienteagosto()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM cliente where mes_cli = '08' and ano_cli =@ano_cli"
        comando.Parameters.AddWithValue("@ano_cli", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtAgosto.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraclientesetembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM cliente where mes_cli = '09' and ano_cli =@ano_cli"
        comando.Parameters.AddWithValue("@ano_cli", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtSetembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraclienteoutubro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM cliente where mes_cli = '10' and ano_cli =@ano_cli"
        comando.Parameters.AddWithValue("@ano_cli", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtOutubro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraclientenovembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM cliente where mes_cli = '11' and ano_cli =@ano_cli"
        comando.Parameters.AddWithValue("@ano_cli", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtNovembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraclientedezembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM cliente where mes_cli = '12' and ano_cli =@ano_cli"
        comando.Parameters.AddWithValue("@ano_cli", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtDezembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraanimaljaneiro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM animal where mes_animal = '01' and ano_animal =@ano_animal"
        comando.Parameters.AddWithValue("@ano_animal", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJaneiro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraanimalfevereiro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM animal where mes_animal = '02' and ano_animal =@ano_animal"
        comando.Parameters.AddWithValue("@ano_animal", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtFevereiro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraanimalmarco()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM animal where mes_animal = '03' and ano_animal =@ano_animal"
        comando.Parameters.AddWithValue("@ano_animal", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtMarco.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraanimalabril()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM animal where mes_animal = '04' and ano_animal =@ano_animal"
        comando.Parameters.AddWithValue("@ano_animal", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtAbril.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraanimalmaio()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM animal where mes_animal = '05' and ano_animal =@ano_animal"
        comando.Parameters.AddWithValue("@ano_animal", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtMaio.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraanimaljunho()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM animal where mes_animal = '06' and ano_animal =@ano_animal"
        comando.Parameters.AddWithValue("@ano_animal", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJunho.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraanimaljulho()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM animal where mes_animal = '07' and ano_animal =@ano_animal"
        comando.Parameters.AddWithValue("@ano_animal", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJulho.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraanimalagosto()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM animal where mes_animal = '08' and ano_animal =@ano_animal"
        comando.Parameters.AddWithValue("@ano_animal", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtAgosto.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraanimalsetembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM animal where mes_animal = '09' and ano_animal =@ano_animal"
        comando.Parameters.AddWithValue("@ano_animal", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtSetembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraanimaloutubro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM animal where mes_animal = '10' and ano_animal =@ano_animal"
        comando.Parameters.AddWithValue("@ano_animal", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtOutubro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraanimalnovembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM animal where mes_animal = '11' and ano_animal =@ano_animal"
        comando.Parameters.AddWithValue("@ano_animal", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtNovembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraanimaldezembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM animal where mes_animal = '12' and ano_animal =@ano_animal"
        comando.Parameters.AddWithValue("@ano_animal", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtDezembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerafuncionariojaneiro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM funcionario where mes_func = '01' and ano_func =@ano_func"
        comando.Parameters.AddWithValue("@ano_func", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJaneiro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerafuncionariofevereiro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM funcionario where mes_func = '02' and ano_func =@ano_func"
        comando.Parameters.AddWithValue("@ano_func", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtFevereiro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerafuncionariomarco()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM funcionario where mes_func = '03' and ano_func =@ano_func"
        comando.Parameters.AddWithValue("@ano_func", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtMarco.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerafuncionarioabril()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM funcionario where mes_func = '04' and ano_func =@ano_func"
        comando.Parameters.AddWithValue("@ano_func", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtAbril.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerafuncionariomaio()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM funcionario where mes_func = '05' and ano_func =@ano_func"
        comando.Parameters.AddWithValue("@ano_func", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtMaio.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerafuncionariojunho()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM funcionario where mes_func = '06' and ano_func =@ano_func"
        comando.Parameters.AddWithValue("@ano_func", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJunho.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerafuncionariojulho()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM funcionario where mes_func = '07' and ano_func =@ano_func"
        comando.Parameters.AddWithValue("@ano_func", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJulho.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerafuncionarioagosto()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM funcionario where mes_func = '08' and ano_func =@ano_func"
        comando.Parameters.AddWithValue("@ano_func", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtAgosto.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerafuncionariosetembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM funcionario where mes_func = '09' and ano_func =@ano_func"
        comando.Parameters.AddWithValue("@ano_func", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtSetembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerafuncionariooutubro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM funcionario where mes_func = '10' and ano_func =@ano_func"
        comando.Parameters.AddWithValue("@ano_func", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtOutubro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerafuncionarionovembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM funcionario where mes_func = '11' and ano_func =@ano_func"
        comando.Parameters.AddWithValue("@ano_func", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtNovembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerafuncionariodezembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM funcionario where mes_func = '12' and ano_func =@ano_func"
        comando.Parameters.AddWithValue("@ano_func", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtDezembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraconsultajaneiro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM consulta where mes_consulta = '01' and ano_consulta =@ano_consulta"
        comando.Parameters.AddWithValue("@ano_consulta", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJaneiro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraconsultafevereiro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM consulta where mes_consulta = '02' and ano_consulta =@ano_consulta"
        comando.Parameters.AddWithValue("@ano_consulta", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtFevereiro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraconsultamarco()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM consulta where mes_consulta = '03' and ano_consulta =@ano_consulta"
        comando.Parameters.AddWithValue("@ano_consulta", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtMarco.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraconsultaabril()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM consulta where mes_consulta = '04' and ano_consulta =@ano_consulta"
        comando.Parameters.AddWithValue("@ano_consulta", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtAbril.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraconsultamaio()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM consulta where mes_consulta = '05' and ano_consulta =@ano_consulta"
        comando.Parameters.AddWithValue("@ano_consulta", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtMaio.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraconsultajunho()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM consulta where mes_consulta = '06' and ano_consulta =@ano_consulta"
        comando.Parameters.AddWithValue("@ano_consulta", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJunho.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraconsultajulho()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM consulta where mes_consulta = '07' and ano_consulta =@ano_consulta"
        comando.Parameters.AddWithValue("@ano_consulta", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJulho.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraconsultaagosto()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM consulta where mes_consulta = '08' and ano_consulta =@ano_consulta"
        comando.Parameters.AddWithValue("@ano_consulta", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtAgosto.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraconsultasetembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM consulta where mes_consulta = '09' and ano_consulta =@ano_consulta"
        comando.Parameters.AddWithValue("@ano_consulta", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtSetembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraconsultaoutubro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM consulta where mes_consulta = '10' and ano_consulta =@ano_consulta"
        comando.Parameters.AddWithValue("@ano_consulta", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtOutubro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraconsultanovembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM consulta where mes_consulta = '11' and ano_consulta =@ano_consulta"
        comando.Parameters.AddWithValue("@ano_consulta", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtNovembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraconsultadezembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM consulta where mes_consulta = '12' and ano_consulta =@ano_consulta"
        comando.Parameters.AddWithValue("@ano_consulta", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtDezembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravacinacaojaneiro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM vacinacao where mes_vacinacao = '01' and ano_vacinacao =@ano_vacinacao"
        comando.Parameters.AddWithValue("@ano_vacinacao", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJaneiro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravacinacaofevereiro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM vacinacao where mes_vacinacao = '02' and ano_vacinacao =@ano_vacinacao"
        comando.Parameters.AddWithValue("@ano_vacinacao", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtFevereiro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravacinacaomarco()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM vacinacao where mes_vacinacao = '03' and ano_vacinacao =@ano_vacinacao"
        comando.Parameters.AddWithValue("@ano_vacinacao", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtMarco.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravacinacaoabril()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM vacinacao where mes_vacinacao = '04' and ano_vacinacao =@ano_vacinacao"
        comando.Parameters.AddWithValue("@ano_vacinacao", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtAbril.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravacinacaomaio()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM vacinacao where mes_vacinacao = '05' and ano_vacinacao =@ano_vacinacao"
        comando.Parameters.AddWithValue("@ano_vacinacao", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtMaio.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravacinacaojunho()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM vacinacao where mes_vacinacao = '06' and ano_vacinacao =@ano_vacinacao"
        comando.Parameters.AddWithValue("@ano_vacinacao", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJunho.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravacinacaojulho()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM vacinacao where mes_vacinacao = '07' and ano_vacinacao =@ano_vacinacao"
        comando.Parameters.AddWithValue("@ano_vacinacao", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJulho.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravacinacaoagosto()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM vacinacao where mes_vacinacao = '08' and ano_vacinacao =@ano_vacinacao"
        comando.Parameters.AddWithValue("@ano_vacinacao", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtAgosto.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravacinacaosetembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM vacinacao where mes_vacinacao = '09' and ano_vacinacao =@ano_vacinacao"
        comando.Parameters.AddWithValue("@ano_vacinacao", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtSetembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravacinacaooutubro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM vacinacao where mes_vacinacao = '10' and ano_vacinacao =@ano_vacinacao"
        comando.Parameters.AddWithValue("@ano_vacinacao", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtOutubro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravacinacaonovembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM vacinacao where mes_vacinacao = '11' and ano_vacinacao =@ano_vacinacao"
        comando.Parameters.AddWithValue("@ano_vacinacao", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtNovembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravacinacaodezembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM vacinacao where mes_vacinacao = '12' and ano_vacinacao =@ano_vacinacao"
        comando.Parameters.AddWithValue("@ano_vacinacao", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtDezembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geracirurgiajaneiro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM cirurgia where mes_cirurgia = '01' and ano_cirurgia =@ano_cirurgia"
        comando.Parameters.AddWithValue("@ano_cirurgia", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJaneiro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geracirurgiafevereiro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM cirurgia where mes_cirurgia = '02' and ano_cirurgia =@ano_cirurgia"
        comando.Parameters.AddWithValue("@ano_cirurgia", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtFevereiro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geracirurgiamarco()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM cirurgia where mes_cirurgia = '03' and ano_cirurgia =@ano_cirurgia"
        comando.Parameters.AddWithValue("@ano_cirurgia", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtMarco.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geracirurgiaabril()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM cirurgia where mes_cirurgia = '04' and ano_cirurgia =@ano_cirurgia"
        comando.Parameters.AddWithValue("@ano_cirurgia", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtAbril.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geracirurgiamaio()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM cirurgia where mes_cirurgia = '05' and ano_cirurgia =@ano_cirurgia"
        comando.Parameters.AddWithValue("@ano_cirurgia", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtMaio.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geracirurgiajunho()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM cirurgia where mes_cirurgia = '06' and ano_cirurgia =@ano_cirurgia"
        comando.Parameters.AddWithValue("@ano_cirurgia", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJunho.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geracirurgiajulho()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM cirurgia where mes_cirurgia = '07' and ano_cirurgia =@ano_cirurgia"
        comando.Parameters.AddWithValue("@ano_cirurgia", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJulho.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geracirurgiaagosto()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM cirurgia where mes_cirurgia = '08' and ano_cirurgia =@ano_cirurgia"
        comando.Parameters.AddWithValue("@ano_cirurgia", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtAgosto.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geracirurgiasetembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM cirurgia where mes_cirurgia = '09' and ano_cirurgia =@ano_cirurgia"
        comando.Parameters.AddWithValue("@ano_cirurgia", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtSetembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geracirurgiaoutubro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM cirurgia where mes_cirurgia = '10' and ano_cirurgia =@ano_cirurgia"
        comando.Parameters.AddWithValue("@ano_cirurgia", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtOutubro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geracirurgianovembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM cirurgia where mes_cirurgia = '11' and ano_cirurgia =@ano_cirurgia"
        comando.Parameters.AddWithValue("@ano_cirurgia", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtNovembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geracirurgiadezembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM cirurgia where mes_cirurgia = '12' and ano_cirurgia =@ano_cirurgia"
        comando.Parameters.AddWithValue("@ano_cirurgia", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtDezembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerainternacaojaneiro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM internacao where mes_internacao = '01' and ano_internacao =@ano_internacao"
        comando.Parameters.AddWithValue("@ano_internacao", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJaneiro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerainternacaofevereiro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM internacao where mes_internacao = '02' and ano_internacao =@ano_internacao"
        comando.Parameters.AddWithValue("@ano_internacao", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtFevereiro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerainternacaomarco()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM internacao where mes_internacao = '03' and ano_internacao =@ano_internacao"
        comando.Parameters.AddWithValue("@ano_internacao", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtMarco.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerainternacaoabril()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM internacao where mes_internacao = '04' and ano_internacao =@ano_internacao"
        comando.Parameters.AddWithValue("@ano_internacao", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtAbril.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerainternacaomaio()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM internacao where mes_internacao = '05' and ano_internacao =@ano_internacao"
        comando.Parameters.AddWithValue("@ano_internacao", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtMaio.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerainternacaojunho()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM internacao where mes_internacao = '06' and ano_internacao =@ano_internacao"
        comando.Parameters.AddWithValue("@ano_internacao", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJunho.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerainternacaojulho()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM internacao where mes_internacao = '07' and ano_internacao =@ano_internacao"
        comando.Parameters.AddWithValue("@ano_internacao", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJulho.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerainternacaoagosto()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM internacao where mes_internacao = '08' and ano_internacao =@ano_internacao"
        comando.Parameters.AddWithValue("@ano_internacao", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtAgosto.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerainternacaosetembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM internacao where mes_internacao = '09' and ano_internacao =@ano_internacao"
        comando.Parameters.AddWithValue("@ano_internacao", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtSetembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerainternacaooutubro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM internacao where mes_internacao = '10' and ano_internacao =@ano_internacao"
        comando.Parameters.AddWithValue("@ano_internacao", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtOutubro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerainternacaonovembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM internacao where mes_internacao = '11' and ano_internacao =@ano_internacao"
        comando.Parameters.AddWithValue("@ano_internacao", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtNovembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerainternacaodezembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM internacao where mes_internacao = '12' and ano_internacao =@ano_internacao"
        comando.Parameters.AddWithValue("@ano_internacao", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtDezembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerahorariosmarcadosjaneiro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM agenda where mes_agenda = '01' and ano_agenda =@ano_agenda"
        comando.Parameters.AddWithValue("@ano_agenda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJaneiro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerahorariosmarcadosfevereiro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM agenda where mes_agenda = '02' and ano_agenda =@ano_agenda"
        comando.Parameters.AddWithValue("@ano_agenda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtFevereiro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerahorariosmarcadosmarco()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM agenda where mes_agenda = '03' and ano_agenda =@ano_agenda"
        comando.Parameters.AddWithValue("@ano_agenda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtMarco.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerahorariosmarcadosabril()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM agenda where mes_agenda = '04' and ano_agenda =@ano_agenda"
        comando.Parameters.AddWithValue("@ano_agenda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtAbril.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerahorariosmarcadosmaio()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM agenda where mes_agenda = '05' and ano_agenda =@ano_agenda"
        comando.Parameters.AddWithValue("@ano_agenda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtMaio.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerahorariosmarcadosjunho()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM agenda where mes_agenda = '06' and ano_agenda =@ano_agenda"
        comando.Parameters.AddWithValue("@ano_agenda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJunho.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerahorariosmarcadosjulho()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM agenda where mes_agenda = '07' and ano_agenda =@ano_agenda"
        comando.Parameters.AddWithValue("@ano_agenda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJulho.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerahorariosmarcadosagosto()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM agenda where mes_agenda = '08' and ano_agenda =@ano_agenda"
        comando.Parameters.AddWithValue("@ano_agenda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtAgosto.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerahorariosmarcadossetembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM agenda where mes_agenda = '09' and ano_agenda =@ano_agenda"
        comando.Parameters.AddWithValue("@ano_agenda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtSetembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerahorariosmarcadosoutubro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM agenda where mes_agenda = '10' and ano_agenda =@ano_agenda"
        comando.Parameters.AddWithValue("@ano_agenda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtOutubro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerahorariosmarcadosnovembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM agenda where mes_agenda = '11' and ano_agenda =@ano_agenda"
        comando.Parameters.AddWithValue("@ano_agenda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtNovembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub gerahorariosmarcadosdezembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM agenda where mes_agenda = '12' and ano_agenda =@ano_agenda"
        comando.Parameters.AddWithValue("@ano_agenda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtDezembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravendasjaneiro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM venda where mes_venda = '01' and ano_venda =@ano_venda"
        comando.Parameters.AddWithValue("@ano_venda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJaneiro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravendasfevereiro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM venda where mes_venda = '02' and ano_venda =@ano_venda"
        comando.Parameters.AddWithValue("@ano_venda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtFevereiro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravendasmarco()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM venda where mes_venda = '03' and ano_venda =@ano_venda"
        comando.Parameters.AddWithValue("@ano_venda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtMarco.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravendasabril()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM venda where mes_venda = '04' and ano_venda =@ano_venda"
        comando.Parameters.AddWithValue("@ano_venda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtAbril.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravendasmaio()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM venda where mes_venda = '05' and ano_venda =@ano_venda"
        comando.Parameters.AddWithValue("@ano_venda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtMaio.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravendasjunho()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM venda where mes_venda = '06' and ano_venda =@ano_venda"
        comando.Parameters.AddWithValue("@ano_venda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJunho.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravendasjulho()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM venda where mes_venda = '07' and ano_venda =@ano_venda"
        comando.Parameters.AddWithValue("@ano_venda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJulho.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravendasagosto()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM venda where mes_venda = '08' and ano_venda =@ano_venda"
        comando.Parameters.AddWithValue("@ano_venda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtAgosto.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravendassetembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM venda where mes_venda = '09' and ano_venda =@ano_venda"
        comando.Parameters.AddWithValue("@ano_venda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtSetembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravendasoutubro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM venda where mes_venda = '10' and ano_venda =@ano_venda"
        comando.Parameters.AddWithValue("@ano_venda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtOutubro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravendasnovembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM venda where mes_venda = '11' and ano_venda =@ano_venda"
        comando.Parameters.AddWithValue("@ano_venda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtNovembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravendasdezembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM venda where mes_venda = '12' and ano_venda =@ano_venda"
        comando.Parameters.AddWithValue("@ano_venda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtDezembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravacinasusadasjaneiro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM itemvacinacao where mes_vacina = '01' and ano_vacina =@ano_vacina"
        comando.Parameters.AddWithValue("@ano_vacina", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJaneiro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravacinasusadasfevereiro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM itemvacinacao where mes_vacina = '02' and ano_vacina =@ano_vacina"
        comando.Parameters.AddWithValue("@ano_vacina", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtFevereiro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravacinasusadasmarco()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM itemvacinacao where mes_vacina = '03' and ano_vacina =@ano_vacina"
        comando.Parameters.AddWithValue("@ano_vacina", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtMarco.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravacinasusadasabril()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM itemvacinacao where mes_vacina = '04' and ano_vacina =@ano_vacina"
        comando.Parameters.AddWithValue("@ano_vacina", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtAbril.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravacinasusadasmaio()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM itemvacinacao where mes_vacina = '05' and ano_vacina =@ano_vacina"
        comando.Parameters.AddWithValue("@ano_vacina", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtMaio.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravacinasusadasjunho()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM itemvacinacao where mes_vacina = '06' and ano_vacina =@ano_vacina"
        comando.Parameters.AddWithValue("@ano_vacina", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJunho.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravacinasusadasjulho()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM itemvacinacao where mes_vacina = '07' and ano_vacina =@ano_vacina"
        comando.Parameters.AddWithValue("@ano_vacina", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJulho.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravacinasusadasagosto()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM itemvacinacao where mes_vacina = '08' and ano_vacina =@ano_vacina"
        comando.Parameters.AddWithValue("@ano_vacina", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtAgosto.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravacinasusadassetembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM itemvacinacao where mes_vacina = '09' and ano_vacina =@ano_vacina"
        comando.Parameters.AddWithValue("@ano_vacina", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtSetembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravacinasusadasoutubro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM itemvacinacao where mes_vacina = '10' and ano_vacina =@ano_vacina"
        comando.Parameters.AddWithValue("@ano_vacina", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtOutubro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravacinasusadasnovembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM itemvacinacao where mes_vacina = '11' and ano_vacina =@ano_vacina"
        comando.Parameters.AddWithValue("@ano_vacina", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtNovembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geravacinasusadasdezembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM itemvacinacao where mes_vacina = '12' and ano_vacina =@ano_vacina"
        comando.Parameters.AddWithValue("@ano_vacina", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtDezembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraprodutosvendidosjaneiro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM itemvenda where mes_venda = '01' and ano_venda =@ano_venda"
        comando.Parameters.AddWithValue("@ano_venda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJaneiro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraprodutosvendidosfevereiro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM itemvenda where mes_venda = '02' and ano_venda =@ano_venda"
        comando.Parameters.AddWithValue("@ano_venda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtFevereiro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraprodutosvendidosmarco()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM itemvenda where mes_venda = '03' and ano_venda =@ano_venda"
        comando.Parameters.AddWithValue("@ano_venda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtMarco.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraprodutosvendidosabril()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM itemvenda where mes_venda = '04' and ano_venda =@ano_venda"
        comando.Parameters.AddWithValue("@ano_venda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtAbril.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraprodutosvendidosmaio()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM itemvenda where mes_venda = '05' and ano_venda =@ano_venda"
        comando.Parameters.AddWithValue("@ano_venda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtMaio.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraprodutosvendidosjunho()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM itemvenda where mes_venda = '06' and ano_venda =@ano_venda"
        comando.Parameters.AddWithValue("@ano_venda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJunho.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraprodutosvendidosjulho()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM itemvenda where mes_venda = '07' and ano_venda =@ano_venda"
        comando.Parameters.AddWithValue("@ano_venda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtJulho.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraprodutosvendidosagosto()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM itemvenda where mes_venda = '08' and ano_venda =@ano_venda"
        comando.Parameters.AddWithValue("@ano_venda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtAgosto.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraprodutosvendidossetembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM itemvenda where mes_venda = '09' and ano_venda =@ano_venda"
        comando.Parameters.AddWithValue("@ano_venda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtSetembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraprodutosvendidosoutubro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM itemvenda where mes_venda = '10' and ano_venda =@ano_venda"
        comando.Parameters.AddWithValue("@ano_venda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtOutubro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraprodutosvendidosnovembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM itemvenda where mes_venda = '11' and ano_venda =@ano_venda"
        comando.Parameters.AddWithValue("@ano_venda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtNovembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub geraprodutosvendidosdezembro()

        Dim dt As New DataTable
        Dim da As New System.Data.SqlClient.SqlDataAdapter(comando)

        Conectar()

        comando.Parameters.Clear()
        comando.CommandText = "SELECT count(*) FROM itemvenda where mes_venda = '12' and ano_venda =@ano_venda"
        comando.Parameters.AddWithValue("@ano_venda", txtAno.Text)

        Dim sqlReader As SqlDataReader

        sqlReader = comando.ExecuteReader()
        If sqlReader.Read() Then
            txtDezembro.Text = sqlReader.GetInt32(0)
        End If
        sqlReader.Close()
        Desconectar()

    End Sub

    Private Sub limpacmbtipografico()

        cmbTipoGrafico.Items.Clear()
        cmbDesignGrafico.Items.Clear()

    End Sub


    Private Sub cmbFonteGrafico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFonteGrafico.SelectedIndexChanged

        limpacmbtipografico()
        cmbTipoGrafico.Text = Nothing
        txtAno.Text = Nothing
        cmbDesignGrafico.Text = Nothing

        lbTipoGrafico.Visible = True
        cmbTipoGrafico.Visible = True

        If cmbFonteGrafico.Text = "Cliente" Or cmbFonteGrafico.Text = "Animal" Or cmbFonteGrafico.Text = "Funcionário" Then

            limpacmbtipografico()

            cmbTipoGrafico.Items.Add("Cadastros em um ano")

            cmbDesignGrafico.Items.Add("Bar")
            cmbDesignGrafico.Items.Add("Bubble")
            cmbDesignGrafico.Items.Add("Column")
            cmbDesignGrafico.Items.Add("Pie")
            cmbDesignGrafico.Items.Add("Pyramid")
            cmbDesignGrafico.Items.Add("RangeBar")
            cmbDesignGrafico.Items.Add("RangeColumn")

        End If

        If cmbFonteGrafico.Text = "Consulta" Then

            limpacmbtipografico()

            cmbTipoGrafico.Items.Add("Consultas em um ano")

            cmbDesignGrafico.Items.Add("Bar")
            cmbDesignGrafico.Items.Add("Bubble")
            cmbDesignGrafico.Items.Add("Column")
            cmbDesignGrafico.Items.Add("Pie")
            cmbDesignGrafico.Items.Add("Pyramid")
            cmbDesignGrafico.Items.Add("RangeBar")
            cmbDesignGrafico.Items.Add("RangeColumn")

        End If

        If cmbFonteGrafico.Text = "Vacinação" Then

            limpacmbtipografico()

            cmbTipoGrafico.Items.Add("Vacinações em um ano")

            cmbDesignGrafico.Items.Add("Bar")
            cmbDesignGrafico.Items.Add("Bubble")
            cmbDesignGrafico.Items.Add("Column")
            cmbDesignGrafico.Items.Add("Pie")
            cmbDesignGrafico.Items.Add("Pyramid")
            cmbDesignGrafico.Items.Add("RangeBar")
            cmbDesignGrafico.Items.Add("RangeColumn")

        End If

        If cmbFonteGrafico.Text = "Cirurgia" Then

            limpacmbtipografico()

            cmbTipoGrafico.Items.Add("Cirurgias em um ano")

            cmbDesignGrafico.Items.Add("Bar")
            cmbDesignGrafico.Items.Add("Bubble")
            cmbDesignGrafico.Items.Add("Column")
            cmbDesignGrafico.Items.Add("Pie")
            cmbDesignGrafico.Items.Add("Pyramid")
            cmbDesignGrafico.Items.Add("RangeBar")
            cmbDesignGrafico.Items.Add("RangeColumn")

        End If

        If cmbFonteGrafico.Text = "Internação" Then

            limpacmbtipografico()

            cmbTipoGrafico.Items.Add("Internações em um ano")

            cmbDesignGrafico.Items.Add("Bar")
            cmbDesignGrafico.Items.Add("Bubble")
            cmbDesignGrafico.Items.Add("Column")
            cmbDesignGrafico.Items.Add("Pie")
            cmbDesignGrafico.Items.Add("Pyramid")
            cmbDesignGrafico.Items.Add("RangeBar")
            cmbDesignGrafico.Items.Add("RangeColumn")

        End If

        If cmbFonteGrafico.Text = "Horários marcados" Then

            limpacmbtipografico()

            cmbTipoGrafico.Items.Add("Horários marcados em um ano")

            cmbDesignGrafico.Items.Add("Bar")
            cmbDesignGrafico.Items.Add("Bubble")
            cmbDesignGrafico.Items.Add("Column")
            cmbDesignGrafico.Items.Add("Pie")
            cmbDesignGrafico.Items.Add("Pyramid")
            cmbDesignGrafico.Items.Add("RangeBar")
            cmbDesignGrafico.Items.Add("RangeColumn")

        End If

        If cmbFonteGrafico.Text = "Vendas" Then

            limpacmbtipografico()

            cmbTipoGrafico.Items.Add("Vendas em um ano")

            cmbDesignGrafico.Items.Add("Bar")
            cmbDesignGrafico.Items.Add("Bubble")
            cmbDesignGrafico.Items.Add("Column")
            cmbDesignGrafico.Items.Add("Pie")
            cmbDesignGrafico.Items.Add("Pyramid")
            cmbDesignGrafico.Items.Add("RangeBar")
            cmbDesignGrafico.Items.Add("RangeColumn")

        End If

        If cmbFonteGrafico.Text = "Vacinas usadas" Then

            limpacmbtipografico()

            cmbTipoGrafico.Items.Add("Vacinas usadas em um ano")

            cmbDesignGrafico.Items.Add("Bar")
            cmbDesignGrafico.Items.Add("Bubble")
            cmbDesignGrafico.Items.Add("Column")
            cmbDesignGrafico.Items.Add("Pie")
            cmbDesignGrafico.Items.Add("Pyramid")
            cmbDesignGrafico.Items.Add("RangeBar")
            cmbDesignGrafico.Items.Add("RangeColumn")

        End If

        If cmbFonteGrafico.Text = "Produtos vendidos" Then

            limpacmbtipografico()

            cmbTipoGrafico.Items.Add("Produtos vendidos em um ano")

            cmbDesignGrafico.Items.Add("Bar")
            cmbDesignGrafico.Items.Add("Bubble")
            cmbDesignGrafico.Items.Add("Column")
            cmbDesignGrafico.Items.Add("Pie")
            cmbDesignGrafico.Items.Add("Pyramid")
            cmbDesignGrafico.Items.Add("RangeBar")
            cmbDesignGrafico.Items.Add("RangeColumn")

        End If

    End Sub

    Private Sub cmbTipoGrafico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoGrafico.SelectedIndexChanged

        If cmbTipoGrafico.Text = "Cadastros em um ano" Or cmbTipoGrafico.Text = "Consultas em um ano" Or cmbTipoGrafico.Text = "Vacinações em um ano" Or cmbTipoGrafico.Text = "Cirurgias em um ano" Or cmbTipoGrafico.Text = "Internações em um ano" Or cmbTipoGrafico.Text = "Horários marcados em um ano" Or cmbTipoGrafico.Text = "Vendas em um ano" Or cmbTipoGrafico.Text = "Vacinas usadas em um ano" Or cmbTipoGrafico.Text = "Produtos vendidos em um ano" Then

            limpafiltros()

            lbAno.Visible = True
            txtAno.Visible = True

        End If

    End Sub


    Private Sub txtAno_TextChanged(sender As Object, e As EventArgs) Handles txtAno.TextChanged
        lbDesignGrafico.Visible = True
        cmbDesignGrafico.Visible = True
    End Sub

    Private Sub limpafiltros()

        lbAno.Visible = False
        txtAno.Visible = False

    End Sub

    Private Sub frmGraficos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (frmPrincipal.lbIdioma.Text = "Português") Then

            cmbFonteGrafico.Items.Add("Cliente")
            cmbFonteGrafico.Items.Add("Animal")
            cmbFonteGrafico.Items.Add("Funcionário")
            cmbFonteGrafico.Items.Add("Consulta")
            cmbFonteGrafico.Items.Add("Vacinação")
            cmbFonteGrafico.Items.Add("Cirurgia")
            cmbFonteGrafico.Items.Add("Internação")
            cmbFonteGrafico.Items.Add("Horários marcados")
            cmbFonteGrafico.Items.Add("Vendas")
            cmbFonteGrafico.Items.Add("Vacinas usadas")
            cmbFonteGrafico.Items.Add("Produtos vendidos")

        End If

        If (frmPrincipal.lbIdioma.Text = "English") Then

            Me.Text = "Graphics"

            lbFonteGrafico.Text = "Graphic source"
            lbTipoGrafico.Text = "Chart type"
            lbAno.Text = "Year"
            lbDesignGrafico.Text = "Graphic design"

            btnGeraGrafico.Text = "Generate"
            btnSalvarGrafico.BackgroundImage = My.Resources.salvar_grafico_english_fw

            cmbFonteGrafico.Items.Add("Customer")
            cmbFonteGrafico.Items.Add("Animal")
            cmbFonteGrafico.Items.Add("Employee")
            cmbFonteGrafico.Items.Add("Consultation")
            cmbFonteGrafico.Items.Add("Vaccination")
            cmbFonteGrafico.Items.Add("Surgery")
            cmbFonteGrafico.Items.Add("Hospitalization")
            cmbFonteGrafico.Items.Add("Scheduled times")
            cmbFonteGrafico.Items.Add("Sales")
            cmbFonteGrafico.Items.Add("Used vaccines")
            cmbFonteGrafico.Items.Add("Popular products")

        End If

        If (frmPrincipal.lbIdioma.Text = "Spanish") Then

            Me.Text = "Gráficos"

            lbFonteGrafico.Text = "Fuente gráfico"
            lbTipoGrafico.Text = "Tipo de gráfico"
            lbAno.Text = "Año"
            lbDesignGrafico.Text = "Diseño gráfico"

            btnGeraGrafico.Text = "Generar"
            btnSalvarGrafico.BackgroundImage = My.Resources.salvar_grafico_spanish_fw

            cmbFonteGrafico.Items.Add("Cliente")
            cmbFonteGrafico.Items.Add("Animal")
            cmbFonteGrafico.Items.Add("Empleado")
            cmbFonteGrafico.Items.Add("Consulta")
            cmbFonteGrafico.Items.Add("Vacunación")
            cmbFonteGrafico.Items.Add("Cirugía")
            cmbFonteGrafico.Items.Add("Hospitalización")
            cmbFonteGrafico.Items.Add("Horarios")
            cmbFonteGrafico.Items.Add("Venta")
            cmbFonteGrafico.Items.Add("Vacunas usadas")
            cmbFonteGrafico.Items.Add("Productos populares")

        End If

        lbTipoGrafico.Visible = False
        cmbTipoGrafico.Visible = False
        lbAno.Visible = False
        txtAno.Visible = False
        lbDesignGrafico.Visible = False
        cmbDesignGrafico.Visible = False

        ChartGrafico.ChartAreas(0).AxisX.LineWidth = 0
        ChartGrafico.ChartAreas(0).AxisY.LineWidth = 0
        ChartGrafico.ChartAreas(0).AxisX.MajorGrid.Enabled = True
        ChartGrafico.ChartAreas(0).AxisY.MajorGrid.Enabled = True
        ChartGrafico.ChartAreas(0).AxisX.MajorTickMark.Enabled = True
        ChartGrafico.ChartAreas(0).AxisY.MajorTickMark.Enabled = True
        ChartGrafico.ChartAreas(0).AxisY.MajorTickMark.Interval = 1
        ChartGrafico.ChartAreas(0).AxisX.MajorTickMark.Interval = 1
        ChartGrafico.ChartAreas(0).AxisX.LabelStyle.Interval = 1
        Me.Refresh()

    End Sub

    Private Sub btnGeraGrafico_Click(sender As Object, e As EventArgs) Handles btnGeraGrafico.Click

        ChartGrafico.Images.Clear()
        ChartGrafico.Titles.Clear()
        'LIMPA OS GRAFICOS ANTES DE GERAR OUTRO

        If cmbDesignGrafico.Text = Nothing Then
            MessageBox.Show("Selecione um design para o gráfico")
        Else

            If cmbFonteGrafico.Text = "Cliente" And cmbTipoGrafico.Text = "Cadastros em um ano" Then

                geraclientejaneiro()
                geraclientefevereiro()
                geraclientemarco()
                geraclienteabril()
                geraclientemaio()
                geraclientejunho()
                geraclientejulho()
                geraclienteagosto()
                geraclientesetembro()
                geraclienteoutubro()
                geraclientenovembro()
                geraclientedezembro()

                Dim ymeses() As Double = {txtJaneiro.Text, txtFevereiro.Text, txtMarco.Text, txtAbril.Text, txtMaio.Text, txtJunho.Text, txtJulho.Text, txtAgosto.Text, txtSetembro.Text, txtOutubro.Text, txtNovembro.Text, txtDezembro.Text}
                Dim xtexto() As String = {"Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez"}

                If cmbDesignGrafico.Text = "Bar" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bar
                        .Titles.Add("Cadastros de cliente no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cadastros"
                        .Palette = ChartColorPalette.Grayscale
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                        .AlignDataPointsByAxisLabel()
                    End With
                End If

                If cmbDesignGrafico.Text = "Bubble" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bubble
                        .Titles.Add("Cadastros de cliente no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cadastros"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Column" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
                        .Titles.Add("Cadastros de cliente no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cadastros"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Pie" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
                        .Titles.Add("Cadastros de cliente no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cadastros"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Pyramid" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pyramid
                        .Titles.Add("Cadastros de cliente no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cadastros"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "RangeBar" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.RangeBar
                        .Titles.Add("Cadastros de cliente no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cadastros"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "RangeColumn" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.RangeColumn
                        .Titles.Add("Cadastros de cliente no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cadastros"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If
            End If

            If cmbFonteGrafico.Text = "Animal" And cmbTipoGrafico.Text = "Cadastros em um ano" Then

                geraanimaljaneiro()
                geraanimalfevereiro()
                geraanimalmarco()
                geraanimalabril()
                geraanimalmaio()
                geraanimaljunho()
                geraanimaljulho()
                geraanimalagosto()
                geraanimalsetembro()
                geraanimaloutubro()
                geraanimalnovembro()
                geraanimaldezembro()

                Dim ymeses() As Double = {txtJaneiro.Text, txtFevereiro.Text, txtMarco.Text, txtAbril.Text, txtMaio.Text, txtJunho.Text, txtJulho.Text, txtAgosto.Text, txtSetembro.Text, txtOutubro.Text, txtNovembro.Text, txtDezembro.Text}
                Dim xtexto() As String = {"Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez"}

                If cmbDesignGrafico.Text = "Bar" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bar
                        .Titles.Add("Cadastros de animal no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cadastros"
                        .Palette = ChartColorPalette.Grayscale
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                        .AlignDataPointsByAxisLabel()
                    End With
                End If

                If cmbDesignGrafico.Text = "Bubble" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bubble
                        .Titles.Add("Cadastros de animal no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cadastros"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Column" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
                        .Titles.Add("Cadastros de animal no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cadastros"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Pie" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
                        .Titles.Add("Cadastros de animal no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cadastros"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Pyramid" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pyramid
                        .Titles.Add("Cadastros de animal no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cadastros"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "RangeBar" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.RangeBar
                        .Titles.Add("Cadastros de animal no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cadastros"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "RangeColumn" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.RangeColumn
                        .Titles.Add("Cadastros de animal no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cadastros"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If
            End If

            If cmbFonteGrafico.Text = "Funcionário" And cmbTipoGrafico.Text = "Cadastros em um ano" Then

                gerafuncionariojaneiro()
                gerafuncionariofevereiro()
                gerafuncionariomarco()
                gerafuncionarioabril()
                gerafuncionariomaio()
                gerafuncionariojunho()
                gerafuncionariojulho()
                gerafuncionarioagosto()
                gerafuncionariosetembro()
                gerafuncionariooutubro()
                gerafuncionarionovembro()
                gerafuncionariodezembro()

                Dim ymeses() As Double = {txtJaneiro.Text, txtFevereiro.Text, txtMarco.Text, txtAbril.Text, txtMaio.Text, txtJunho.Text, txtJulho.Text, txtAgosto.Text, txtSetembro.Text, txtOutubro.Text, txtNovembro.Text, txtDezembro.Text}
                Dim xtexto() As String = {"Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez"}

                If cmbDesignGrafico.Text = "Bar" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bar
                        .Titles.Add("Cadastros de funcionário no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cadastros"
                        .Palette = ChartColorPalette.Grayscale
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                        .AlignDataPointsByAxisLabel()
                    End With
                End If

                If cmbDesignGrafico.Text = "Bubble" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bubble
                        .Titles.Add("Cadastros de funcionário no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cadastros"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Column" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
                        .Titles.Add("Cadastros de funcionário no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cadastros"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Pie" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
                        .Titles.Add("Cadastros de funcionário no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cadastros"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Pyramid" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pyramid
                        .Titles.Add("Cadastros de funcionário no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cadastros"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "RangeBar" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.RangeBar
                        .Titles.Add("Cadastros de funcionário no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cadastros"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "RangeColumn" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.RangeColumn
                        .Titles.Add("Cadastros de funcionário no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cadastros"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If
            End If

            If cmbFonteGrafico.Text = "Consulta" And cmbTipoGrafico.Text = "Consultas em um ano" Then

                geraconsultajaneiro()
                geraconsultafevereiro()
                geraconsultamarco()
                geraconsultaabril()
                geraconsultamaio()
                geraconsultajunho()
                geraconsultajulho()
                geraconsultaagosto()
                geraconsultasetembro()
                geraconsultaoutubro()
                geraconsultanovembro()
                geraconsultadezembro()

                Dim ymeses() As Double = {txtJaneiro.Text, txtFevereiro.Text, txtMarco.Text, txtAbril.Text, txtMaio.Text, txtJunho.Text, txtJulho.Text, txtAgosto.Text, txtSetembro.Text, txtOutubro.Text, txtNovembro.Text, txtDezembro.Text}
                Dim xtexto() As String = {"Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez"}

                If cmbDesignGrafico.Text = "Bar" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bar
                        .Titles.Add("Consultas realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Consultas"
                        .Palette = ChartColorPalette.Grayscale
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                        .AlignDataPointsByAxisLabel()
                    End With
                End If

                If cmbDesignGrafico.Text = "Bubble" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bubble
                        .Titles.Add("Consultas realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Consultas"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Column" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
                        .Titles.Add("Consultas realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Consultas"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Pie" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
                        .Titles.Add("Consultas realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Consultas"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Pyramid" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pyramid
                        .Titles.Add("Consultas realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Consultas"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "RangeBar" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.RangeBar
                        .Titles.Add("Consultas realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Consultas"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "RangeColumn" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.RangeColumn
                        .Titles.Add("Consultas realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Consultas"
                        .Palette = DataVisualization.Charting.ChartColorPalette.Fire
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If
            End If

            If cmbFonteGrafico.Text = "Vacinação" And cmbTipoGrafico.Text = "Vacinações em um ano" Then

                geravacinacaojaneiro()
                geravacinacaofevereiro()
                geravacinacaomarco()
                geravacinacaoabril()
                geravacinacaomaio()
                geravacinacaojunho()
                geravacinacaojulho()
                geravacinacaoagosto()
                geravacinacaosetembro()
                geravacinacaooutubro()
                geravacinacaonovembro()
                geravacinacaodezembro()

                Dim ymeses() As Double = {txtJaneiro.Text, txtFevereiro.Text, txtMarco.Text, txtAbril.Text, txtMaio.Text, txtJunho.Text, txtJulho.Text, txtAgosto.Text, txtSetembro.Text, txtOutubro.Text, txtNovembro.Text, txtDezembro.Text}
                Dim xtexto() As String = {"Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez"}

                If cmbDesignGrafico.Text = "Bar" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bar
                        .Titles.Add("Vacinações realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Vacinações"
                        .Palette = ChartColorPalette.Grayscale
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                        .AlignDataPointsByAxisLabel()
                    End With
                End If

                If cmbDesignGrafico.Text = "Bubble" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bubble
                        .Titles.Add("Vacinações realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Vacinações"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Column" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
                        .Titles.Add("Vacinações realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Vacinações"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Pie" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
                        .Titles.Add("Vacinações realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Vacinações"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Pyramid" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pyramid
                        .Titles.Add("Vacinas realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Vacinações"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "RangeBar" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.RangeBar
                        .Titles.Add("Vacinas realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Vacinações"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "RangeColumn" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.RangeColumn
                        .Titles.Add("Vacinações realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Vacinações"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If
            End If

            If cmbFonteGrafico.Text = "Cirurgia" And cmbTipoGrafico.Text = "Cirurgias em um ano" Then

                geracirurgiajaneiro()
                geracirurgiafevereiro()
                geracirurgiamarco()
                geracirurgiaabril()
                geracirurgiamaio()
                geracirurgiajunho()
                geracirurgiajulho()
                geracirurgiaagosto()
                geracirurgiasetembro()
                geracirurgiaoutubro()
                geracirurgianovembro()
                geracirurgiadezembro()

                Dim ymeses() As Double = {txtJaneiro.Text, txtFevereiro.Text, txtMarco.Text, txtAbril.Text, txtMaio.Text, txtJunho.Text, txtJulho.Text, txtAgosto.Text, txtSetembro.Text, txtOutubro.Text, txtNovembro.Text, txtDezembro.Text}
                Dim xtexto() As String = {"Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez"}

                If cmbDesignGrafico.Text = "Bar" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bar
                        .Titles.Add("Cirurgias realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cirurgias"
                        .Palette = ChartColorPalette.Grayscale
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                        .AlignDataPointsByAxisLabel()
                    End With
                End If

                If cmbDesignGrafico.Text = "Bubble" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bubble
                        .Titles.Add("Cirurgias realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cirurgias"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Column" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
                        .Titles.Add("Cirurgias realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cirurgias"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Pie" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
                        .Titles.Add("Cirurgias realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cirurgias"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Pyramid" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pyramid
                        .Titles.Add("Cirurgias realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cirurgias"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "RangeBar" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.RangeBar
                        .Titles.Add("Cirurgias realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cirurgias"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "RangeColumn" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.RangeColumn
                        .Titles.Add("Cirurgias realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Cirurgias"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If
            End If

            If cmbFonteGrafico.Text = "Internação" And cmbTipoGrafico.Text = "Internações em um ano" Then

                gerainternacaojaneiro()
                gerainternacaofevereiro()
                gerainternacaomarco()
                gerainternacaoabril()
                gerainternacaomaio()
                gerainternacaojunho()
                gerainternacaojulho()
                gerainternacaoagosto()
                gerainternacaosetembro()
                gerainternacaooutubro()
                gerainternacaonovembro()
                gerainternacaodezembro()

                Dim ymeses() As Double = {txtJaneiro.Text, txtFevereiro.Text, txtMarco.Text, txtAbril.Text, txtMaio.Text, txtJunho.Text, txtJulho.Text, txtAgosto.Text, txtSetembro.Text, txtOutubro.Text, txtNovembro.Text, txtDezembro.Text}
                Dim xtexto() As String = {"Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez"}

                If cmbDesignGrafico.Text = "Bar" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bar
                        .Titles.Add("Internações realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Internações"
                        .Palette = ChartColorPalette.Grayscale
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                        .AlignDataPointsByAxisLabel()
                    End With
                End If

                If cmbDesignGrafico.Text = "Bubble" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bubble
                        .Titles.Add("Internações realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Internações"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Column" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
                        .Titles.Add("Internações realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Internações"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Pie" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
                        .Titles.Add("Internações realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Internações"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Pyramid" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pyramid
                        .Titles.Add("Internações realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Internações"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "RangeBar" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.RangeBar
                        .Titles.Add("Internações realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Internações"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "RangeColumn" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.RangeColumn
                        .Titles.Add("Internações realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Internações"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If
            End If

            If cmbFonteGrafico.Text = "Horários marcados" And cmbTipoGrafico.Text = "Horários marcados em um ano" Then

                gerahorariosmarcadosjaneiro()
                gerahorariosmarcadosfevereiro()
                gerahorariosmarcadosmarco()
                gerahorariosmarcadosabril()
                gerahorariosmarcadosmaio()
                gerahorariosmarcadosjunho()
                gerahorariosmarcadosjulho()
                gerahorariosmarcadosagosto()
                gerahorariosmarcadossetembro()
                gerahorariosmarcadosoutubro()
                gerahorariosmarcadosnovembro()
                gerahorariosmarcadosdezembro()

                Dim ymeses() As Double = {txtJaneiro.Text, txtFevereiro.Text, txtMarco.Text, txtAbril.Text, txtMaio.Text, txtJunho.Text, txtJulho.Text, txtAgosto.Text, txtSetembro.Text, txtOutubro.Text, txtNovembro.Text, txtDezembro.Text}
                Dim xtexto() As String = {"Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez"}

                If cmbDesignGrafico.Text = "Bar" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bar
                        .Titles.Add("Horários marcados no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Horários marcados"
                        .Palette = ChartColorPalette.Grayscale
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                        .AlignDataPointsByAxisLabel()
                    End With
                End If

                If cmbDesignGrafico.Text = "Bubble" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bubble
                        .Titles.Add("Horários marcados no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Horários marcados"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Column" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
                        .Titles.Add("Horários marcados no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Horários marcados"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Pie" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
                        .Titles.Add("Horários marcados no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Horários marcados"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Pyramid" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pyramid
                        .Titles.Add("Horários marcados no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Horários marcados"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "RangeBar" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.RangeBar
                        .Titles.Add("Horários marcados no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Horários marcados"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "RangeColumn" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.RangeColumn
                        .Titles.Add("Horários marcados no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Horários marcados"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If
            End If

            If cmbFonteGrafico.Text = "Vendas" And cmbTipoGrafico.Text = "Vendas em um ano" Then

                geravendasjaneiro()
                geravendasfevereiro()
                geravendasmarco()
                geravendasabril()
                geravendasmaio()
                geravendasjunho()
                geravendasjulho()
                geravendasagosto()
                geravendassetembro()
                geravendasoutubro()
                geravendasnovembro()
                geravendasdezembro()

                Dim ymeses() As Double = {txtJaneiro.Text, txtFevereiro.Text, txtMarco.Text, txtAbril.Text, txtMaio.Text, txtJunho.Text, txtJulho.Text, txtAgosto.Text, txtSetembro.Text, txtOutubro.Text, txtNovembro.Text, txtDezembro.Text}
                Dim xtexto() As String = {"Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez"}

                If cmbDesignGrafico.Text = "Bar" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bar
                        .Titles.Add("Vendas realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Vendas"
                        .Palette = ChartColorPalette.Grayscale
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                        .AlignDataPointsByAxisLabel()
                    End With
                End If

                If cmbDesignGrafico.Text = "Bubble" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bubble
                        .Titles.Add("Vendas realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Vendas"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Column" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
                        .Titles.Add("Vendas realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Vendas"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Pie" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
                        .Titles.Add("Vendas realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Vendas"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Pyramid" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pyramid
                        .Titles.Add("Vendas realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Vendas"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "RangeBar" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.RangeBar
                        .Titles.Add("Vendas realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Vendas"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "RangeColumn" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.RangeColumn
                        .Titles.Add("Vendas realizadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Vendas"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If
            End If

            If cmbFonteGrafico.Text = "Vacinas usadas" And cmbTipoGrafico.Text = "Vacinas usadas em um ano" Then

                geravacinasusadasjaneiro()
                geravacinasusadasfevereiro()
                geravacinasusadasmarco()
                geravacinasusadasabril()
                geravacinasusadasmaio()
                geravacinasusadasjunho()
                geravacinasusadasjulho()
                geravacinasusadasagosto()
                geravacinasusadassetembro()
                geravacinasusadasoutubro()
                geravacinasusadasnovembro()
                geravacinasusadasdezembro()

                Dim ymeses() As Double = {txtJaneiro.Text, txtFevereiro.Text, txtMarco.Text, txtAbril.Text, txtMaio.Text, txtJunho.Text, txtJulho.Text, txtAgosto.Text, txtSetembro.Text, txtOutubro.Text, txtNovembro.Text, txtDezembro.Text}
                Dim xtexto() As String = {"Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez"}

                If cmbDesignGrafico.Text = "Bar" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bar
                        .Titles.Add("Vacinas usadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Vacinas usadas"
                        .Palette = ChartColorPalette.Grayscale
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                        .AlignDataPointsByAxisLabel()
                    End With
                End If

                If cmbDesignGrafico.Text = "Bubble" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bubble
                        .Titles.Add("Vacinas usadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Vacinas usadas"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Column" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
                        .Titles.Add("Vacinas usadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Vacinas usadas"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Pie" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
                        .Titles.Add("Vacinas usadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Vacinas usadas"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Pyramid" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pyramid
                        .Titles.Add("Vacinas usadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Vacinas usadas"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "RangeBar" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.RangeBar
                        .Titles.Add("Vacinas usadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Vacinas usadas"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "RangeColumn" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.RangeColumn
                        .Titles.Add("Vacinas usadas no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Vacinas usadas"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If
            End If

            If cmbFonteGrafico.Text = "Produtos vendidos" And cmbTipoGrafico.Text = "Produtos vendidos em um ano" Then

                geraprodutosvendidosjaneiro()
                geraprodutosvendidosfevereiro()
                geraprodutosvendidosmarco()
                geraprodutosvendidosabril()
                geraprodutosvendidosmaio()
                geraprodutosvendidosjunho()
                geraprodutosvendidosjulho()
                geraprodutosvendidosagosto()
                geraprodutosvendidossetembro()
                geraprodutosvendidosoutubro()
                geraprodutosvendidosnovembro()
                geraprodutosvendidosdezembro()

                Dim ymeses() As Double = {txtJaneiro.Text, txtFevereiro.Text, txtMarco.Text, txtAbril.Text, txtMaio.Text, txtJunho.Text, txtJulho.Text, txtAgosto.Text, txtSetembro.Text, txtOutubro.Text, txtNovembro.Text, txtDezembro.Text}
                Dim xtexto() As String = {"Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez"}

                If cmbDesignGrafico.Text = "Bar" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bar
                        .Titles.Add("Produtos vendidos no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Produtos vendidos"
                        .Palette = ChartColorPalette.Grayscale
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                        .AlignDataPointsByAxisLabel()
                    End With
                End If

                If cmbDesignGrafico.Text = "Bubble" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bubble
                        .Titles.Add("Produtos vendidos no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Produtos vendidos"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Column" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
                        .Titles.Add("Produtos vendidos no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Produtos vendidos"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Pie" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
                        .Titles.Add("Produtos vendidos no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Produtos vendidos"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "Pyramid" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pyramid
                        .Titles.Add("Produtos vendidos no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Produtos vendidos"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "RangeBar" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.RangeBar
                        .Titles.Add("Produtos vendidos no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Produtos vendidos"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If

                If cmbDesignGrafico.Text = "RangeColumn" Then
                    With ChartGrafico
                        .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.RangeColumn
                        .Titles.Add("Produtos vendidos no decorrer de um ano")
                        .ChartAreas(0).Area3DStyle.Enable3D = True
                        .ChartAreas(0).Area3DStyle.Inclination = 10
                        .ChartAreas(0).Area3DStyle.Rotation = 20
                        .ChartAreas(0).Area3DStyle.Perspective = 10
                        .ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Realistic
                        .ChartAreas(0).AxisX.Title = "Meses"
                        .ChartAreas(0).AxisY.Title = "Produtos vendidos"
                        .Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
                        .Series(0).Points.DataBindXY(xtexto, ymeses)
                        .Series(0).IsValueShownAsLabel = True
                    End With
                End If
            End If
        End If

    End Sub

    Private Sub btnSalvarGrafico_Click(sender As Object, e As EventArgs) Handles btnSalvarGrafico.Click

        Dim local As String
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = ".jpg|*.jpg|.bitmap|*.bmp|.gif|*.gif"
        saveFileDialog1.Title = "Escolha onde salvar o gráfico"
        saveFileDialog1.ShowDialog()
        If saveFileDialog1.FileName <> "" Then
            local = saveFileDialog1.FileName
            ChartGrafico.SaveImage(local, System.Drawing.Imaging.ImageFormat.Jpeg)
            MessageBox.Show("Gráfico salvo com sucesso!")
        End If

    End Sub

    Private Sub btnFecharForm_Click(sender As Object, e As EventArgs) Handles btnFecharForm.Click

        Me.Close()
        frmPrincipal.Visible = True

    End Sub
End Class