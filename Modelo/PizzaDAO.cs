using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Modelo
{
    class PizzaDAO
    {
        public string Mensagem { get; private set; }
        SqlCommand cmd = new SqlCommand(); //Cria objeto para definição e execução de comando SQL.
        Conexao con = new Conexao(); //Cria objeto que estabelecerá a conexão com o banco.
        //Armazena o retorno de uma consulta feita no banco.
        SqlDataReader dr;

        public string Adicionar(Pizza pizza)
        {
            Mensagem = String.Empty;
            //Comando SQL
            cmd.CommandText = "insert into Pizza values (@nome, @ingrediente1, @ingrediente2, @ingrediente3, @ingrediente4, @valor)";
            cmd.Parameters.AddWithValue("nome", pizza.Nome);
            cmd.Parameters.AddWithValue("ingrediente1", pizza.Ingrediente1);
            cmd.Parameters.AddWithValue("ingrediente2", pizza.Ingrediente2);
            cmd.Parameters.AddWithValue("ingrediente3", pizza.Ingrediente3);
            cmd.Parameters.AddWithValue("ingrediente4", pizza.Ingrediente4);
            cmd.Parameters.AddWithValue("valor", pizza.Valor);


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
            cmd.CommandText = "SELECT MAX(Id) FROM Pizza";
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
                    cmd.Parameters.AddWithValue("valor", dr.GetInt32(0));
                } */

                dr.Close();
                //conectar com banco
                try
                {
                    //Receber o endereço de onde vou me conectar.
                    cmd.Connection = con.Conectar();
                    //Executar comando.
                    cmd.ExecuteNonQuery();
                    //Exibe mensagem;
                    Mensagem = "Pizza cadastrada com sucesso!!!";
                }
                catch (SqlException ex)
                {
                    //Captura a mensagem de erro gerada.
                    Mensagem = ex.Message;
                }
            }
            return Mensagem;
        }

        public SqlDataReader RetornarPizzas()
        {
            //Comandos SQL para verificar se existe o usuário no banco.
            cmd.CommandText = "select * from Pizza";
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

        public SqlDataReader RetornarPizza(int indice)
        {
            //Comandos SQL para verificar se existe o usuário no banco.
            cmd.CommandText = "select * from Pizza where Id = @id";
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
