using Pizzaria.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Controle
{
    //Esta classe é responsável por verificações e validações de dados referentes a Pizza.
    class ControlePizza
    {
        //Método onde podem ser realizadas validações acerca das informações informadas para o Cliente a ser inserido no banco.
        public string AdicionarPizza(Pizza pizza)
        {
            PizzaDAO pizz = new PizzaDAO();
            string mensagem = pizz.Adicionar(pizza);
            return mensagem;
        }

        //Método intermediário utilizado para retornar informações dos clientes que estão salvos no banco.
        public SqlDataReader RetornarPizzas()
        {
            PizzaDAO pizz = new PizzaDAO();
            return pizz.RetornarPizzas();
        }

        public SqlDataReader RetornarPizza(int indice)
        {
            PizzaDAO pizz = new PizzaDAO();
            return pizz.RetornarPizza(indice);
        }
    }
}
