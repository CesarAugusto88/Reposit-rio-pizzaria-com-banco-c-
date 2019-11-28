using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzaria.Controle;

namespace Pizzaria.Modelo
{
    class FuncionarioDAO
    {
        public string Mensagem { get; private set; }
        SqlCommand cmd = new SqlCommand(); //Cria objeto para definição e execução de comando SQL.
        Conexao con = new Conexao(); //Cria objeto que estabelecerá a conexão com o banco.
        //Armazena o retorno de uma consulta feita no banco.
        SqlDataReader dr;

        public string Adicionar(Funcionario funcionario)
        {
            Mensagem = String.Empty;
            //Comando SQL
            cmd.CommandText = "insert into Funcionario values (@nome, @cpf, @rg, @celular, @genero, @email, @logradouro, @numero, @complemento, @bairro)";
            cmd.Parameters.AddWithValue("nome", funcionario.Nome);
            cmd.Parameters.AddWithValue("cpf", funcionario.CPF);
            cmd.Parameters.AddWithValue("rg", funcionario.RG);
            cmd.Parameters.AddWithValue("celular", funcionario.Celular);
            cmd.Parameters.AddWithValue("genero", funcionario.Genero);            
            cmd.Parameters.AddWithValue("email", funcionario.Email);
            cmd.Parameters.AddWithValue("logradouro", funcionario.Logradouro);
            cmd.Parameters.AddWithValue("numero", funcionario.Numero);
            cmd.Parameters.AddWithValue("complemento", funcionario.Complemento);
            cmd.Parameters.AddWithValue("bairro", funcionario.Bairro);
            // colocar insert table LoginSenha aqui...? 
            // para receber so uma mensagem

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();
            }
            catch (SqlException ex)
            {
                Mensagem = ex.Message;
            }
            //Seleciona o maior Id de endereço (Endereco?), ou seja, o último adicionado.
            cmd.CommandText = "SELECT MAX(Id) FROM Funcionario";
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                Mensagem = ex.Message;
            }

            if (Mensagem == String.Empty)
            {
                // Colocado junto sem endereço no começo
                //dr.Read();
                /*
                cmd.CommandText = "insert into Cliente values (@nome, @cpf, @rg, @celular, @genero, @email, @endereco)";
                cmd.Parameters.AddWithValue("nome", cliente.Nome);
                cmd.Parameters.AddWithValue("cpf", cliente.CPF);
                cmd.Parameters.AddWithValue("rg", cliente.RG);
                cmd.Parameters.AddWithValue("celular", cliente.Celular);
                cmd.Parameters.AddWithValue("genero", cliente.Genero);
                cmd.Parameters.AddWithValue("email", cliente.Email);


                while (dr.Read()) // tira essa função???
                {
                    // endereco
                    cmd.Parameters.AddWithValue("endereco", dr.GetInt32(0));
                }*/

                dr.Close();
                //conectar com banco
                try
                {
                    //Receber o endereço de onde vou me conectar.
                    cmd.Connection = con.Conectar();
                    //Executar comando.
                    cmd.ExecuteNonQuery();
                    //Exibe mensagem;
                    Mensagem = "Funcionario cadastrado com sucesso!!!";
                }
                catch (SqlException ex)
                {
                    //Captura a mensagem de erro gerada.
                    Mensagem = ex.Message;
                }
            }
            return Mensagem;
        }

        internal SqlDataReader RetornarFucionarios()
        {
            throw new NotImplementedException();
        }

        public SqlDataReader RetornarFubcionarios()
        {
            //Comandos SQL para verificar se existe o usuário no banco.
            cmd.CommandText = "select * from Funcionario";
            //Parametros que serão substituídos no CommandText.

            try
            {
                cmd.Connection = con.Conectar(); //Tenta estabelecer a conexão com o banco de dados. 
                dr = cmd.ExecuteReader(); //Realiza a execução do SQL e obtém o retorno do banco em forma de objeto SQLDataReader.
                //Verifica se existe algum retorno na consulta do banco.
                if (dr.HasRows)
                {
                    return dr;
                }
            }
            catch (SqlException ex)
            {
                //Não é a mensagem mais apropriada!
                Console.WriteLine(ex.Message);
            }
            con.Desconectar();
            return null;
        }

        public SqlDataReader RetornarFuncionario(int indice)
        {
            //Comandos SQL para verificar se existe o usuário no banco.
            cmd.CommandText = "select * from Funcionario where Id = @id";
            cmd.Parameters.AddWithValue("id", indice);

            try
            {
                cmd.Connection = con.Conectar(); //Tenta estabelecer a conexão com o banco de dados. 
                dr = cmd.ExecuteReader(); //Realiza a execução do SQL e obtém o retorno do banco em forma de objeto SQLDataReader.
                //Verifica se existe algum retorno na consulta do banco.
                if (dr.HasRows)
                {
                    return dr;
                }
            }
            catch (SqlException ex)
            {
                //Não é a mensagem mais apropriada!
                Console.WriteLine(ex.Message);
            }
            con.Desconectar();
            return null;
        }
    }
}
