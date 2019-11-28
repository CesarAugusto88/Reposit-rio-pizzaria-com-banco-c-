using Pizzaria.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Controle
{
    public class ControleLogin
    {
        // Controle Login e Senha. Vai comunicar com a classe LoginDAOComandos
        // vai retornar um atributo boleano tem
        public bool tem;
        // Atributo menssagem para retornar mensagem se deu certo as senhas com banco
        // mensage vazia para não conter lixo de memória
        public string mensagem = "";
        // parâmetros com informação que vieram do formulário (txbLogin...)
        public bool acessar(string login, string senha)
        {
            LoginDAOComandos loginDAO = new LoginDAOComandos();
            // envia informações para verificar e 'tem' recebe
            tem = loginDAO.verificarlogin(login, senha);
            // verifica com o método se mensagem !não vazia
            // ! loginDAO.mensagem.Equals("") não funciona
            if (loginDAO.mensagem != "")
            {
                // vai receber a mensagem string da outra classe loginDAO para enviar o erro 
                this.mensagem = loginDAO.mensagem;
            }
            // se continuar vazia porque não deu nenhum erro
            return tem;
        }
        // Segundo método para cadastrar
        public string cadastrar(string email, string senha, string confirmasenha)
        {
            // vai acessar o método na classe LoginDAO
            LoginDAOComandos loginDAO = new LoginDAOComandos();
            this.mensagem = loginDAO.cadastrar(email, senha, confirmasenha);
            if (loginDAO.tem)// a mensagem esta ok
            {
                this.tem = true;

            }

            return mensagem;
        }
    }
}
