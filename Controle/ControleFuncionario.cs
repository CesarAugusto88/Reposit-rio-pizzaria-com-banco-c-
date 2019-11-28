using Pizzaria.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Controle
{
    
    
    //Esta classe é responsável por verificações e validações de dados referentes ao Funcionário.
    class ControleFuncionario
    {
        
        //Método onde podem ser realizadas validações acerca das informações informadas para o Funcionário a ser inserido no banco.
        public string AdicionarFuncionario(Funcionario funcionario)
        {
            FuncionarioDAO func = new FuncionarioDAO();
            string mensagem = func.Adicionar(funcionario);
            return mensagem;
        }

       
        //Método intermediário utilizado para retornar informações dos funcionários que estão salvos no banco.
        public SqlDataReader RetornarFuncionarios()
        {
            FuncionarioDAO func = new FuncionarioDAO();
            return func.RetornarFucionarios();
        }

        public SqlDataReader RetornarFuncionario(int indice)
        {
            FuncionarioDAO func = new FuncionarioDAO();
            return func.RetornarFuncionario(indice);
        }
    }
}
