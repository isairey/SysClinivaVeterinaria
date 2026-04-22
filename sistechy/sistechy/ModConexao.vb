Imports System.Data.SqlClient
Imports System.Data
Module ModConexao

    Public conecta As New SqlConnection
    Public comando As New SqlCommand

    Public Function Conectar()
        conecta.Close()
        conecta.ConnectionString = ("Integrated Security=SSPI;Persist Security Info=False; Initial Catalog=DB_sistechy")
        conecta.Open()
        comando.Connection = conecta
        Return True
    End Function

    Public Function Desconectar()
        conecta.Close()
        Return True
    End Function

    Public Sub testeconexao()

        Try
            Conectar()

        Catch ex As Exception

            If (frmPrincipal.lbIdioma.Text = "Português") Then
                MsgBox("Erro na Conexão com o banco de dados")
            End If

            If (frmPrincipal.lbIdioma.Text = "English") Then
                MsgBox("Error connecting to the database")
            End If

            If (frmPrincipal.lbIdioma.Text = "Spanish") Then
                MsgBox("Error al conectar con la base de datos")
            End If

            Desconectar()

        End Try

    End Sub

    Public Function Cadastrar_Cliente(ByVal v_nome_cli As String, ByVal v_ddd_cli As String, ByVal v_telefone_cli As String, ByVal v_celular_cli As String, ByVal v_email_cli As String, ByVal v_sexo_cli As String, ByVal v_datanasc_cli As String, ByVal v_CPF_cli As String, ByVal v_RG_cli As String, ByVal v_cadastrodata_cli As String, ByVal v_endereco_cli As String, ByVal v_numeroendereco_cli As String, ByVal v_cidade_cli As String, ByVal v_UF_cli As String, ByVal v_bairro_cli As String, ByVal v_cep_cli As String, ByVal v_mes_cli As String, ByVal v_ano_cli As String)

        Conectar()

        comando.CommandText = ("insert into cliente(nome_cli , ddd_cli, telefone_cli, celular_cli, email_cli, sexo_cli, datanasc_cli, CPF_cli, RG_cli, cadastrodata_cli, endereco_cli, numeroendereco_cli, cidade_cli, UF_cli, bairro_cli, cep_cli, mes_cli, ano_cli) values ( '" & v_nome_cli & "','" & v_ddd_cli & "','" & v_telefone_cli & "','" & v_celular_cli & "','" & v_email_cli & "','" & v_sexo_cli & "','" & v_datanasc_cli & "','" & v_CPF_cli & "','" & v_RG_cli & "','" & v_cadastrodata_cli & "','" & v_endereco_cli & "','" & v_numeroendereco_cli & "','" & v_cidade_cli & "','" & v_UF_cli & "','" & v_bairro_cli & "','" & v_cep_cli & "', '" & v_mes_cli & "', '" & v_ano_cli & "')")
        comando.ExecuteNonQuery()
        Desconectar()

        Return MsgBox("Cliente cadastrado com sucesso")

    End Function

    Public Function Cadastrar_Animal(ByVal v_foto_animal As String, ByVal v_cod_cli As String, ByVal v_nome_animal As String, ByVal v_especie_animal As String, ByVal v_raca_animal As String, ByVal v_sexo_animal As String, ByVal v_porte_animal As String, ByVal v_peso_animal As String, ByVal v_idade_animal As String, ByVal v_cor_animal As String, ByVal v_castracao_animal As String, ByVal v_cadastrodata_animal As String, ByVal v_mes_animal As String, ByVal v_ano_animal As String)

        Conectar()
        comando.CommandText = ("insert into animal(foto_animal, cod_cli, nome_animal, especie_animal, raca_animal, sexo_animal, porte_animal, peso_animal, idade_animal, cor_animal, castracao_animal, cadastrodata_animal, mes_animal, ano_animal) values ( '" & v_foto_animal & "', '" & v_cod_cli & "', '" & v_nome_animal & "', '" & v_especie_animal & "', '" & v_raca_animal & "', '" & v_sexo_animal & "', '" & v_porte_animal & "', '" & v_peso_animal & "', '" & v_idade_animal & "', '" & v_cor_animal & "', '" & v_castracao_animal & "', '" & v_cadastrodata_animal & "', '" & v_mes_animal & "', '" & v_ano_animal & "')")
        comando.ExecuteNonQuery()
        Desconectar()

        Return MsgBox("Animal cadastrado com sucesso")

    End Function

    Public Function Cadastrar_Funcionario(ByVal v_nome_func As String, ByVal v_ddd_func As String, ByVal v_telefone_func As String, ByVal v_celular_func As String, ByVal v_email_func As String, ByVal v_sexo_func As String, ByVal v_datanasc_func As String, ByVal v_CPF_func As String, ByVal v_datacadastro_func As String, ByVal v_endereco_func As String, ByVal v_numeroendereco_func As String, ByVal v_cidade_func As String, ByVal v_UF_func As String, ByVal v_bairro_func As String, ByVal v_cep_func As String, ByVal v_cargo_func As String, ByVal v_login_func As String, ByVal v_senha_func As String, ByVal v_nivel_acesso As String, ByVal v_mes_func As String, ByVal v_ano_func As String)

        Conectar()

        comando.CommandText = ("insert into funcionario(nome_func, ddd_func, telefone_func, celular_func, email_func, sexo_func, datanasc_func, CPF_func, datacadastro_func, endereco_func, numeroendereco_func, cidade_func, UF_func, bairro_func, cep_func, cargo_func, login_func, senha_func, nivel_acesso, mes_func, ano_func) values ( '" & v_nome_func & "', '" & v_ddd_func & "', '" & v_telefone_func & "', '" & v_celular_func & "', '" & v_email_func & "', '" & v_sexo_func & "', '" & v_datanasc_func & "', '" & v_CPF_func & "', '" & v_datacadastro_func & "', '" & v_endereco_func & "', '" & v_numeroendereco_func & "', '" & v_cidade_func & "', '" & v_UF_func & "', '" & v_bairro_func & "', '" & v_cep_func & "', '" & v_cargo_func & "', '" & v_login_func & "', '" & v_senha_func & "', '" & v_nivel_acesso & "', '" & v_mes_func & "', '" & v_ano_func & "')")
        comando.ExecuteNonQuery()
        Desconectar()

        Return MsgBox("Funcionário cadastrado com sucesso")

    End Function

    Public Function Cadastrar_Fornecedor(ByVal v_nomefatasia_forne As String, v_razaosocial_forne As String, ByVal v_CPNJ_forne As String, ByVal v_ddd_forne As String, ByVal v_telefone_forne As String, ByVal v_email_forne As String, ByVal v_endereco_forne As String, ByVal v_bairro_forne As String, ByVal v_numeroendereco_forne As String, ByVal v_cidade_forne As String, ByVal v_UF_Forne As String)

        Conectar()
        comando.CommandText = ("insert into fornecedor(nomefantasia_forne, razaosocial_forne, CNPJ_forne, ddd_forne, telefone_forne, email_forne, endereco_forne, bairro_forne, numeroendereco_forne, cidade_forne, UF_forne) values ('" & v_nomefatasia_forne & "', '" & v_razaosocial_forne & "', '" & v_CPNJ_forne & "', '" & v_ddd_forne & "', '" & v_telefone_forne & "', '" & v_email_forne & "', '" & v_endereco_forne & "','" & v_bairro_forne & "', '" & v_numeroendereco_forne & "', '" & v_cidade_forne & "', '" & v_UF_Forne & "')")
        comando.ExecuteNonQuery()
        Desconectar()

        Return MsgBox("Fornecedor cadastrado com sucesso")

    End Function

    Public Function Consulta_cliente_codigo(ByVal v_cod_cli As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select cod_cli as 'Código', nome_cli as 'Nome', ddd_cli as 'DDD', telefone_cli as 'Telefone', celular_cli as 'Celular', email_cli as 'Email', sexo_cli as 'Sexo', datanasc_cli as 'Data de nascimento', CPF_cli as 'CPF', RG_cli as 'RG', cadastrodata_cli as 'Data de cadastro', endereco_cli as 'Endereço', numeroendereco_cli as 'Número', cidade_cli as 'Cidade', UF_cli as 'UF', bairro_cli as 'Bairro', cep_cli as 'CEP' from cliente where cod_cli = '" & v_cod_cli & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Consulta_cliente_nome(ByVal v_nome_cli As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select cod_cli as 'Código', nome_cli as 'Nome', ddd_cli as 'DDD', telefone_cli as 'Telefone', celular_cli as 'Celular', email_cli as 'Email', sexo_cli as 'Sexo', datanasc_cli as 'Data de nascimento', CPF_cli as 'CPF', RG_cli as 'RG', cadastrodata_cli as 'Data de cadastro', endereco_cli as 'Endereço', numeroendereco_cli as 'Número', cidade_cli as 'Cidade', UF_cli as 'UF', bairro_cli as 'Bairro', cep_cli as 'CEP' from cliente where nome_cli = '" & v_nome_cli & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Consulta_cliente_data(ByVal v_data_cli As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select cod_cli as 'Código', nome_cli as 'Nome', ddd_cli as 'DDD', telefone_cli as 'Telefone', celular_cli as 'Celular', email_cli as 'Email', sexo_cli as 'Sexo', datanasc_cli as 'Data de nascimento', CPF_cli as 'CPF', RG_cli as 'RG', cadastrodata_cli as 'Data de cadastro', endereco_cli as 'Endereço', numeroendereco_cli as 'Número', cidade_cli as 'Cidade', UF_cli as 'UF', bairro_cli as 'Bairro', cep_cli as 'CEP' from cliente where cadastrodata_cli = '" & v_data_cli & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Consulta_cliente_CPF(ByVal v_CPF_cli As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select cod_cli as 'Código', nome_cli as 'Nome', ddd_cli as 'DDD', telefone_cli as 'Telefone', celular_cli as 'Celular', email_cli as 'Email', sexo_cli as 'Sexo', datanasc_cli as 'Data de nascimento', CPF_cli as 'CPF', RG_cli as 'RG', cadastrodata_cli as 'Data de cadastro', endereco_cli as 'Endereço', numeroendereco_cli as 'Número', cidade_cli as 'Cidade', UF_cli as 'UF', bairro_cli as 'Bairro', cep_cli as 'CEP' from cliente where CPF_cli = '" & v_CPF_cli & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function


    Public Function Consulta_animal_codigo(ByVal v_cod_animal As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select foto_animal as 'Foto', cod_animal as 'Código', cod_cli as 'Código dono', nome_animal as 'Nome', especie_animal as 'Espécie', raca_animal as 'Raça', sexo_animal as 'Sexo', porte_animal as 'Porte', peso_animal as 'Peso', idade_animal as 'Idade', cor_animal as 'Cor', castracao_animal as 'Castrado', cadastrodata_animal as 'Data de cadastro' from animal where cod_animal = '" & v_cod_animal & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Consulta_animal_nome(ByVal v_nome_animal As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select foto_animal as 'Foto', cod_animal as 'Código', cod_cli as 'Código dono', nome_animal as 'Nome', especie_animal as 'Espécie', raca_animal as 'Raça', sexo_animal as 'Sexo', porte_animal as 'Porte', peso_animal as 'Peso', idade_animal as 'Idade', cor_animal as 'Cor', castracao_animal as 'Castrado', cadastrodata_animal as 'Data de cadastro' from animal where nome_animal = '" & v_nome_animal & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Consulta_animal_data(ByVal v_data_animal As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select foto_animal as 'Foto', cod_animal as 'Código', cod_cli as 'Código dono', nome_animal as 'Nome', especie_animal as 'Espécie', raca_animal as 'Raça', sexo_animal as 'Sexo', porte_animal as 'Porte', peso_animal as 'Peso', idade_animal as 'Idade', cor_animal as 'Cor', castracao_animal as 'Castrado', cadastrodata_animal as 'Data de cadastro' from animal where cadastrodata_animal = '" & v_data_animal & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Consulta_funcionario_codigo(ByVal v_cod_func As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select cod_func as 'Código', nome_func as 'Nome', ddd_func as 'DDD', telefone_func as 'Telefone', celular_func as 'Celular', email_func as 'Email', sexo_func as 'Sexo', datanasc_func as 'Data de nascimento', CPF_func as 'CPF', datacadastro_func as 'Data de cadastro', endereco_func as 'Endereço', numeroendereco_func as 'Número', cidade_func as 'Cidade', UF_func as 'UF', bairro_func as 'Bairro', cep_func as 'CEP', cargo_func as 'Cargo', login_func as 'Login' from funcionario where cod_func = '" & v_cod_func & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Consulta_funcionario_nome(ByVal v_nome_func As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select cod_func as 'Código', nome_func as 'Nome', ddd_func as 'DDD', telefone_func as 'Telefone', celular_func as 'Celular', email_func as 'Email', sexo_func as 'Sexo', datanasc_func as 'Data de nascimento', CPF_func as 'CPF', datacadastro_func as 'Data de cadastro', endereco_func as 'Endereço', numeroendereco_func as 'Número', cidade_func as 'Cidade', UF_func as 'UF', bairro_func as 'Bairro', cep_func as 'CEP', cargo_func as 'Cargo', login_func as 'Login' from funcionario where nome_func = '" & v_nome_func & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Consulta_funcionario_data(ByVal v_data_func As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select cod_func as 'Código', nome_func as 'Nome', ddd_func as 'DDD', telefone_func as 'Telefone', celular_func as 'Celular', email_func as 'Email', sexo_func as 'Sexo', datanasc_func as 'Data de nascimento', CPF_func as 'CPF', datacadastro_func as 'Data de cadastro', endereco_func as 'Endereço', numeroendereco_func as 'Número', cidade_func as 'Cidade', UF_func as 'UF', bairro_func as 'Bairro', cep_func as 'CEP', cargo_func as 'Cargo', login_func as 'Login' from funcionario where datacadastro_func = '" & v_data_func & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Consulta_funcionario_CPF(ByVal v_CPF_func As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select cod_func as 'Código', nome_func as 'Nome', ddd_func as 'DDD', telefone_func as 'Telefone', celular_func as 'Celular', email_func as 'Email', sexo_func as 'Sexo', datanasc_func as 'Data de nascimento', CPF_func as 'CPF', datacadastro_func as 'Data de cadastro', endereco_func as 'Endereço', numeroendereco_func as 'Número', cidade_func as 'Cidade', UF_func as 'UF', bairro_func as 'Bairro', cep_func as 'CEP', cargo_func as 'Cargo', login_func as 'Login' from funcionario where CPF_func = '" & v_CPF_func & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Consulta_fornecedor_codigo(ByVal v_cod_forne As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select cod_forne as 'Código', cod_produto as 'Código do produto', nomefantasia_forne as 'Nome fantasia', razaosocial_forne as 'Razão social', CNPJ_forne as 'CNPJ', ddd_forne as 'DDD', telefone_forne as 'Telefone', email_forne as 'Email', endereco_forne as 'Endereço', bairro_forne as 'Bairro', numeroendereco_forne as 'Número', cidade_forne as 'Cidade', UF_forne as 'UF' from fornecedor where cod_forne = '" & v_cod_forne & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Consulta_fornecedor_nome(ByVal v_nome_forne As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select cod_forne as 'Código', cod_produto as 'Código do produto', nomefantasia_forne as 'Nome fantasia', razaosocial_forne as 'Razão social', CNPJ_forne as 'CNPJ', ddd_forne as 'DDD', telefone_forne as 'Telefone', email_forne as 'Email', endereco_forne as 'Endereço', bairro_forne as 'Bairro', numeroendereco_forne as 'Número', cidade_forne as 'Cidade', UF_forne as 'UF' from fornecedor where nomefantasia_forne = '" & v_nome_forne & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Consulta_fornecedor_CNPJ(ByVal v_CNPJ_forne As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select cod_forne as 'Código', cod_produto as 'Código do produto', nomefantasia_forne as 'Nome fantasia', razaosocial_forne as 'Razão social', CNPJ_forne as 'CNPJ', ddd_forne as 'DDD', telefone_forne as 'Telefone', email_forne as 'Email', endereco_forne as 'Endereço', bairro_forne as 'Bairro', numeroendereco_forne as 'Número', cidade_forne as 'Cidade', UF_forne as 'UF' from fornecedor where CNPJ_forne = '" & v_CNPJ_forne & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Exclui_cliente_codigo(ByVal v_cod_cli As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable


        Conectar()

        comando.CommandText = ("delete from cliente where cod_cli = '" & v_cod_cli & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Exclui_animal_codigo(ByVal v_cod_animal As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable


        Conectar()

        comando.CommandText = ("delete from animal where cod_animal = '" & v_cod_animal & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Exclui_fornecedor_codigo(ByVal v_cod_forne As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable


        Conectar()

        comando.CommandText = ("delete from fornecedor where cod_forne = '" & v_cod_forne & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Exclui_funcionario_codigo(ByVal v_cod_func As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable


        Conectar()

        comando.CommandText = ("delete from funcionario where cod_func = '" & v_cod_func & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Cadastrar_Consulta(ByVal v_cod_animal As String, ByVal v_cod_func As String, ByVal v_data_consulta As String, ByVal v_detalhes_consulta As String, ByVal v_mes_consulta As String, ByVal v_ano_consulta As String)

        Conectar()
        comando.CommandText = ("insert into consulta(cod_animal, cod_func, data_consulta, detalhes_consulta, mes_consulta, ano_consulta) values ('" & v_cod_animal & "', '" & v_cod_func & "', '" & v_data_consulta & "', '" & v_detalhes_consulta & "', '" & v_mes_consulta & "', '" & v_ano_consulta & "')")
        comando.ExecuteNonQuery()
        Desconectar()

        Return MsgBox("Consulta cadastrada com sucesso")

    End Function

    Public Function Cadastrar_Produto(ByVal v_foto_produto As String, ByVal v_cod_fornecedor As String, ByVal v_tipo_produto As String, ByVal v_nome_produto As String, ByVal v_marca_produto As String, ByVal v_quantidade_produto As String, ByVal v_quantidade_minima As String, ByVal v_quantidade_maxima As String, ByVal v_data_validade As String, ByVal v_preco_produto As String, ByVal v_descricao_produto As String)

        Conectar()
        comando.CommandText = ("insert into produto(foto_produto, cod_fornecedor, tipo_produto, nome_produto, marca_produto, quantidade_produto, quantidade_minima, quantidade_maxima, data_validade, preco_produto, descricao_produto) values ( '" & v_foto_produto & "', '" & v_cod_fornecedor & "', '" & v_tipo_produto & "', '" & v_nome_produto & "', '" & v_marca_produto & "', '" & v_quantidade_produto & "', '" & v_quantidade_minima & "', '" & v_quantidade_maxima & "', '" & v_data_validade & "', '" & v_preco_produto & "', '" & v_descricao_produto & "')")
        comando.ExecuteNonQuery()
        Desconectar()

        Return MsgBox("Produto cadastrado com sucesso")

    End Function

    Public Function Consulta_produto_codigo(ByVal v_data_produto As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select foto_produto as 'Foto', cod_produto as 'Código', cod_fornecedor as 'Código do fornecedor', tipo_produto as 'Tipo', nome_produto as 'Nome', marca_produto as 'Marca', quantidade_produto as 'Quantidade', quantidade_minima as 'Quantidade mínima', quantidade_maxima as 'Quantidade máxima', data_validade as 'Data de validade', preco_produto as 'Preço', descricao_produto as 'Descrição' from produto where cod_produto = '" & v_data_produto & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Consulta_produto_tipo(ByVal v_tipo_produto As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select foto_produto as 'Foto', cod_produto as 'Código', cod_fornecedor as 'Código do fornecedor', tipo_produto as 'Tipo', nome_produto as 'Nome', marca_produto as 'Marca', quantidade_produto as 'Quantidade', quantidade_minima as 'Quantidade mínima', quantidade_maxima as 'Quantidade máxima', data_validade as 'Data de validade', preco_produto as 'Preço', descricao_produto as 'Descrição' from produto where tipo_produto = '" & v_tipo_produto & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Consulta_produto_nome(ByVal v_nome_produto As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select foto_produto as 'Foto', cod_produto as 'Código', cod_fornecedor as 'Código do fornecedor', tipo_produto as 'Tipo', nome_produto as 'Nome', marca_produto as 'Marca', quantidade_produto as 'Quantidade', quantidade_minima as 'Quantidade mínima', quantidade_maxima as 'Quantidade máxima', data_validade as 'Data de validade', preco_produto as 'Preço', descricao_produto as 'Descrição' from produto where nome_produto = '" & v_nome_produto & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Consulta_produto_marca(ByVal v_marca_produto As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select foto_produto as 'Foto', cod_produto as 'Código', cod_fornecedor as 'Código do fornecedor', tipo_produto as 'Tipo', nome_produto as 'Nome', marca_produto as 'Marca', quantidade_produto as 'Quantidade', quantidade_minima as 'Quantidade mínima', quantidade_maxima as 'Quantidade máxima', data_validade as 'Data de validade', preco_produto as 'Preço', descricao_produto as 'Descrição' from produto where marca_produto = '" & v_marca_produto & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Consulta_produto_data(ByVal v_data_produto As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select foto_produto as 'Foto', cod_produto as 'Código', cod_fornecedor as 'Código do fornecedor', tipo_produto as 'Tipo', nome_produto as 'Nome', marca_produto as 'Marca', quantidade_produto as 'Quantidade', quantidade_minima as 'Quantidade mínima', quantidade_maxima as 'Quantidade máxima', data_validade as 'Data de validade', preco_produto as 'Preço', descricao_produto as 'Descrição' from produto where data_validade = '" & v_data_produto & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Consulta_vacina_codigo(ByVal v_cod_vacina As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select foto_produto as 'Foto', cod_produto as 'Código', cod_fornecedor as 'Código do fornecedor', tipo_produto as 'Tipo', nome_produto as 'Nome', marca_produto as 'Marca', quantidade_produto as 'Quantidade', quantidade_minima as 'Quantidade mínima', quantidade_maxima as 'Quantidade máxima', data_validade as 'Data de validade', preco_produto as 'Preço', descricao_produto as 'Descrição' from produto where cod_produto = '" & v_cod_vacina & "' and tipo_produto = 'vacina'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Consulta_vacina_nome(ByVal v_nome_vacina As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select foto_produto as 'Foto', cod_produto as 'Código', cod_fornecedor as 'Código do fornecedor', tipo_produto as 'Tipo', nome_produto as 'Nome', marca_produto as 'Marca', quantidade_produto as 'Quantidade', quantidade_minima as 'Quantidade mínima', quantidade_maxima as 'Quantidade máxima', data_validade as 'Data de validade', preco_produto as 'Preço', descricao_produto as 'Descrição' from produto where nome_produto = '" & v_nome_vacina & "' and tipo_produto = 'vacina'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Consulta_vacina_marca(ByVal v_marca_vacina As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select foto_produto as 'Foto', cod_produto as 'Código', cod_fornecedor as 'Código do fornecedor', tipo_produto as 'Tipo', nome_produto as 'Nome', marca_produto as 'Marca', quantidade_produto as 'Quantidade', quantidade_minima as 'Quantidade mínima', quantidade_maxima as 'Quantidade máxima', data_validade as 'Data de validade', preco_produto as 'Preço', descricao_produto as 'Descrição' from produto where marca_produto = '" & v_marca_vacina & "' and tipo_produto = 'vacina'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Cadastrar_Vacinacao(ByVal v_cod_animal As String, ByVal v_cod_func As String, v_data_vacinacao As String, ByVal v_mes_vacinacao As String, ByVal v_ano_vacinacao As String)

        Conectar()
        comando.CommandText = ("insert into vacinacao(cod_animal, cod_func, data_vacinacao, mes_vacinacao, ano_vacinacao) values ('" & v_cod_animal & "', '" & v_cod_func & "', '" & v_data_vacinacao & "', '" & v_mes_vacinacao & "', '" & v_ano_vacinacao & "')")
        comando.ExecuteNonQuery()
        Desconectar()

        Return MsgBox("Vacinação cadastrada com sucesso")

    End Function

    Public Function Consulta_itemvacinacao(ByVal v_cod_vacinacao As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select cod_itemvacinacao as 'Código', cod_vacinacao as 'Código da vacinação', cod_vacina as 'Código da vacina', nome_vacina as 'Nome da vacina' from itemvacinacao where cod_vacinacao = '" & v_cod_vacinacao & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Cadastrar_leito(ByVal v_porte_leito As String, ByVal v_status_leito As String)

        Conectar()

        comando.CommandText = ("insert into leito(porte_leito, status_leito) values ( '" & v_porte_leito & "', '" & v_status_leito & "')")
        comando.ExecuteNonQuery()
        Desconectar()

        If (frmPrincipal.lbIdioma.Text = "Português") Then
            MessageBox.Show("Leito cadastrado com sucesso")
        End If

        If (frmPrincipal.lbIdioma.Text = "English") Then
            MessageBox.Show("Successfully registered bed")
        End If

    End Function

    Public Function Cadastrar_Internacao(ByVal v_cod_animal As String, ByVal v_data_internacao As String, ByVal v_numero_leito As String, ByVal v_detalhes_internacao As String, ByVal v_mes_internacao As String, ByVal v_ano_internacao As String)

        Conectar()
        comando.CommandText = ("insert into internacao(cod_animal, data_internacao, numeroleito_internacao, detalhes_internacao, mes_internacao, ano_internacao) values ('" & v_cod_animal & "', '" & v_data_internacao & "', '" & v_numero_leito & "', '" & v_detalhes_internacao & "', '" & v_mes_internacao & "', '" & v_ano_internacao & "')")
        comando.ExecuteNonQuery()
        Desconectar()

        Return MsgBox("Internação cadastrada com sucesso")

    End Function

    Public Function Consulta_leito(ByVal v_cod_leito As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select cod_leito as 'Código', porte_leito as 'Porte do leito', status_leito as 'Em uso' from leito where cod_leito = '" & v_cod_leito & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Cadastrar_Cirurgia(ByVal v_data_cirurgia As String, ByVal v_cod_animal As String, v_cod_cirurgiao As String, ByVal v_cod_anestesista As String, ByVal v_detalhes_cirurgia As String, ByVal v_mes_cirurgia As String, ByVal v_ano_cirurgia As String)

        Conectar()
        comando.CommandText = ("insert into cirurgia(data_cirurgia, cod_animal, cod_cirurgiao, cod_anestesista, detalhes_cirurgia, mes_cirurgia, ano_cirurgia) values ('" & v_data_cirurgia & "', '" & v_cod_animal & "', '" & v_cod_cirurgiao & "', '" & v_cod_anestesista & "', '" & v_detalhes_cirurgia & "', '" & v_mes_cirurgia & "', '" & v_ano_cirurgia & "')")
        comando.ExecuteNonQuery()
        Desconectar()

        If (frmPrincipal.lbIdioma.Text = "Português") Then
            Return MsgBox("Cirurgia cadastrada com sucesso")
        End If
        If (frmPrincipal.lbIdioma.Text = "English") Then
            Return MsgBox("Surgery successfully registered")
        End If

    End Function

    Public Function Excluir_produto_codigo(ByVal v_cod_produto As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("delete from produto where cod_produto = '" & v_cod_produto & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Filtro_Agenda_todos()

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select cod_agenda as 'Código agendamento', cod_cli as 'Código do cliente', cod_animal as 'Código do animal', cod_func as 'Código do funcionário', data_agenda as 'Data agendamento', tipo_agenda as 'Tipo agendamento', status_agenda as 'Status agendamento' from agenda")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Filtro_Agenda_data(ByVal v_cod_data As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select cod_agenda as 'Código agendamento', cod_cli as 'Código do cliente', cod_animal as 'Código do animal', cod_func as 'Código do funcionário', data_agenda as 'Data agendamento', tipo_agenda as 'Tipo agendamento', status_agenda as 'Status agendamento' from agenda where data_agenda = '" & v_cod_data & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Filtro_Agenda_entre_datas(ByVal v_cod_data_inicial As String, ByVal v_cod_data_final As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select cod_agenda as 'Código agendamento', cod_cli as 'Código do cliente', cod_animal as 'Código do animal', cod_func as 'Código do funcionário', data_agenda as 'Data agendamento', tipo_agenda as 'Tipo agendamento', status_agenda as 'Status agendamento' from agenda where data_agenda between '" & v_cod_data_inicial & "' and '" & v_cod_data_final & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Filtro_Agenda_codigo_cliente(ByVal v_cod_cliente As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select cod_agenda as 'Código agendamento', cod_cli as 'Código do cliente', cod_animal as 'Código do animal', cod_func as 'Código do funcionário', data_agenda as 'Data agendamento', tipo_agenda as 'Tipo agendamento', status_agenda as 'Status agendamento' from agenda where cod_cliente = '" & v_cod_cliente & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Filtro_Agenda_codigo_funcionario(ByVal v_cod_func As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select cod_agenda as 'Código agendamento', cod_cli as 'Código do cliente', cod_animal as 'Código do animal', cod_func as 'Código do funcionário', data_agenda as 'Data agendamento', tipo_agenda as 'Tipo agendamento', status_agenda as 'Status agendamento' from agenda where cod_func = '" & v_cod_func & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Filtro_Agenda_codigo_animal(ByVal v_cod_animal As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select cod_agenda as 'Código agendamento', cod_cli as 'Código do cliente', cod_animal as 'Código do animal', cod_func as 'Código do funcionário', data_agenda as 'Data agendamento', tipo_agenda as 'Tipo agendamento', status_agenda as 'Status agendamento' from agenda where cod_animal = '" & v_cod_animal & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Filtro_Agenda_tipo_atendimento(ByVal v_tipo_atendimento As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select cod_agenda as 'Código agendamento', cod_cli as 'Código do cliente', cod_animal as 'Código do animal', cod_func as 'Código do funcionário', data_agenda as 'Data agendamento', tipo_agenda as 'Tipo agendamento', status_agenda as 'Status agendamento' from agenda where tipo_agenda = '" & v_tipo_atendimento & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Filtro_Agenda_status(ByVal v_status As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select cod_agenda as 'Código agendamento', cod_cli as 'Código do cliente', cod_animal as 'Código do animal', cod_func as 'Código do funcionário', data_agenda as 'Data agendamento', tipo_agenda as 'Tipo agendamento', status_agenda as 'Status agendamento' from agenda where status_agenda = '" & v_status & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Cadastrar_Horario_Agenda(ByVal v_cod_cliente As String, ByVal v_cod_animal As String, v_cod_func As String, ByVal v_data_agenda As String, ByVal v_tipo_agenda As String, ByVal v_status_agenda As String, ByVal v_mes_agenda As String, ByVal v_ano_agenda As String)

        Conectar()
        comando.CommandText = ("insert into agenda(cod_cli, cod_animal, cod_func, data_agenda, tipo_agenda, status_agenda, mes_agenda, ano_agenda) values ('" & v_cod_cliente & "', '" & v_cod_animal & "', '" & v_cod_func & "', '" & v_data_agenda & "', '" & v_tipo_agenda & "' ,'" & v_status_agenda & "', '" & v_mes_agenda & "', '" & v_ano_agenda & "')")
        comando.ExecuteNonQuery()
        Desconectar()

        If (frmPrincipal.lbIdioma.Text = "Português") Then
            Return MsgBox("Horário cadastrado na agenda com sucesso")
        End If
        If (frmPrincipal.lbIdioma.Text = "English") Then
            Return MsgBox("Time schedule successfully registered")
        End If
    End Function

    Public Function Consulta_mensagens_nao_lidas(ByVal v_usuario As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()
        comando.CommandText = ("select id_mensagem as 'Código', remetente as 'Remetente', destinatario as 'Destinatário', texto as 'Mensagem', status_mensagem as 'Status' from mensagens where destinatario = '" & v_usuario & "' and status_mensagem= 'não lida'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Consulta_mensagens_lidas(ByVal v_usuario As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()
        comando.CommandText = ("select id_mensagem as 'Código', remetente as 'Remetente', destinatario as 'Destinatário', texto as 'Mensagem', status_mensagem as 'Status' from mensagens where destinatario = '" & v_usuario & "' and status_mensagem= 'lida'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Consulta_mensagens_enviadas(ByVal v_usuario As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()
        comando.CommandText = ("select id_mensagem as 'Código', remetente as 'Remetente', destinatario as 'Destinatário', texto as 'Mensagem', status_mensagem as 'Status' from mensagens where remetente = '" & v_usuario & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Enviar_nova_mensagem(ByVal v_remetente As String, ByVal v_destinatario As String, ByVal v_texto As String, ByVal v_status_mensagem As String)

        Conectar()
        comando.CommandText = ("insert into mensagens (remetente, destinatario, texto, status_mensagem) values ('" & v_remetente & "', '" & v_destinatario & "', '" & v_texto & "', '" & v_status_mensagem & "')")
        comando.ExecuteNonQuery()
        Desconectar()

        Return MsgBox("Mensagem enviada")
    End Function

    Public Function Cadastrar_venda(ByVal v_itens As String, ByVal v_cpf_cli As String, ByVal v_cod_func As String, ByVal v_data_venda As String, ByVal v_valor_total As String, ByVal v_forma_pagamento As String, ByVal v_cartao As String, ByVal v_mes_venda As String, ByVal v_ano_venda As String)

        Conectar()
        comando.CommandText = ("insert into venda (itens, cpf_cli, cod_func, data_venda, valor_total, forma_pagamento, cartao, mes_venda, ano_venda) values ('" & v_itens & "', '" & v_cpf_cli & "', '" & v_cod_func & "', '" & v_data_venda & "', '" & v_valor_total & "', '" & v_forma_pagamento & "', '" & v_cartao & "', '" & v_mes_venda & "', '" & v_ano_venda & "')")
        comando.ExecuteNonQuery()
        Desconectar()

        Return MsgBox("Venda finalizada")
    End Function

    Public Function Filtro_venda_todos()

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select cod_venda as 'Código', itens as 'Itens', cpf_cli as 'CPF do cliente', cod_func as 'Código do funcionário', data_venda as 'Data da venda', valor_total as 'Valor total', forma_pagamento as 'Forma de pagamento', cartao as 'Cartão utilizado' from venda")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Filtro_venda_data(ByVal v_data_venda As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select cod_venda as 'Código', itens as 'Itens', cpf_cli as 'CPF do cliente', cod_func as 'Código do funcionário', data_venda as 'Data da venda', valor_total as 'Valor total', forma_pagamento as 'Forma de pagamento', cartao as 'Cartão utilizado' from venda where data_venda = '" & v_data_venda & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Filtro_venda_entre_datas(ByVal v_data_inicial As String, ByVal v_data_final As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select cod_venda as 'Código', itens as 'Itens', cpf_cli as 'CPF do cliente', cod_func as 'Código do funcionário', data_venda as 'Data da venda', valor_total as 'Valor total', forma_pagamento as 'Forma de pagamento', cartao as 'Cartão utilizado' from venda where data_venda between '" & v_data_inicial & "' and '" & v_data_final & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Consulta_itemvenda(ByVal v_cod_venda As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select cod_produto as 'Código do produto', nome_produto as 'Nome do produto', valor_produto as 'Valor' from itemvenda where cod_venda = '" & v_cod_venda & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

    Public Function Consulta_estoque(ByVal v_tipo_produto As String)

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Conectar()

        comando.CommandText = ("select cod_produto as 'Código do produto', tipo_produto as 'Tipo do produto', nome_produto as 'Nome do produto', quantidade_produto as 'Quantidade do produto', data_validade as 'Data de validade', preco_produto as 'Preço do produto' from produto where tipo_produto = '" & v_tipo_produto & "'")
        da.SelectCommand = comando
        da.Fill(dt)


        Desconectar()
        Return dt

    End Function

End Module
