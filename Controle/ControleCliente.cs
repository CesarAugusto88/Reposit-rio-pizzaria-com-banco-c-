using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    //Esta classe é responsável por verificações e validações de dados referentes ao Cliente.
    class ControleCliente
    {
        //Método onde podem ser realizadas validações acerca das informações informadas para o Cliente a ser inserido no banco.
        public string AdicionarCliente(Cliente cliente)
        {
            ClienteDAO cli = new ClienteDAO();
            string mensagem = cli.Adicionar(cliente);
            return mensagem;
        }

        //Método intermediário utilizado para retornar informações dos clientes que estão salvos no banco.
        public SqlDataReader RetornarClientes()
        {
            ClienteDAO cli = new ClienteDAO();
            return cli.RetornarClientes();
        }

        public SqlDataReader RetornarCliente(int indice)
        {
            ClienteDAO cli = new ClienteDAO();
            return cli.RetornarCliente(indice);
        }
    }
}

