using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    class Conexao
    {
        SqlConnection con = new SqlConnection();

        //Construtor da classe utilizado para definição da string de conexão com o banco escolhido.
        public Conexao()
        {
            // Adiciona o banco especifico 'Banco_Pizzaria'            
            con.ConnectionString = @"Data Source=" + Environment.MachineName.ToString() +@"\SQLEXPRESS; Initial Catalog=Projeto_Pizzaria; Integrated Security=True";
        }
        //Conectar ao banco de dados
        public SqlConnection Conectar()
        {
            //Verifica se o estado da conexão é igual a fechado, então posso abrir.
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //Desconectar do banco de dados
        public void Desconectar()
        {
            //Verifica se o estado da conexão é aberto, então fecho.
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
