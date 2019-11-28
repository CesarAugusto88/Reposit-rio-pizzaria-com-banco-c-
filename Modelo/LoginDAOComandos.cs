using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Modelo
{
    class LoginDAOComandos
    {
        // vai retornar verdadeiro ou falso bool
        public bool tem = false; // a principio falso
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        // guardar a informação variavel dr
        SqlDataReader dr;
        public bool verificarlogin(string login, string senha)
        {
            // comandos sql para verificar se tem no banco
            // procura no banco de dados esse login e senha
            // email e senha que está na tabela do banco
            cmd.CommandText = "select * from LoginSenha where Email = @login and Senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.Conectar();
                // pega a informação
                dr = cmd.ExecuteReader();                
                if (dr.HasRows)// verifica se foi encontrado
                {
                    tem = true;
                }
                con.Desconectar();
                dr.Close();

            }
            catch (SqlException)
            {

                this.mensagem = "Erro com o Banco de Dados!";
            }
            return tem;
        }
        // segundo método referente a classe ControleFuncionario de cadastro
        public string cadastrar(string email, string senha, string confirmarsenha)
        {
            tem = false;
            // comandos para inserir e retorna mensagem se deu certo ou não
            if (senha == confirmarsenha)
            {
                cmd.CommandText = "insert into LoginSenha values (@e,@s);";
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);
                try
                {
                    // o que pode dar erro
                    cmd.Connection = con.Conectar();
                    // como estamos inserindo coloca executenonquery
                    cmd.ExecuteNonQuery();
                    // desconectar
                    con.Desconectar();
                    this.mensagem = "Cadastrado com Sucesso!";
                    tem = true;
                }
                catch (SqlException)
                {
                    // Se houver uma excessão de SQL mostra uma mensagem de erro
                    this.mensagem = "Erro com Banco de Dados";
                    
                }
            }else
            {
                this.mensagem = "Senhas não corespondem!";
            }

            return mensagem;

        }
    }
}
