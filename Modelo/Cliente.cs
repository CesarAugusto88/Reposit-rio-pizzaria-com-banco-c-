using Pizzaria.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    //Classe que define informações sobre um cliente.
    // retirado classe Endereco que atributo de cliente recebia e incluso
    class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Celular { get; set; }
        public string Genero { get; set; }        
        public string Email { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        //public Endereco End { get; set; }


        public Cliente(string nome, string cpf, string rg, string celular, string genero, string email, string logradouro, int numero, string complemento, string bairro)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.RG = rg;            
            this.Celular = celular;
            this.Genero = genero;
            this.Email = email;
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.Complemento = complemento;
            this.Bairro = bairro;
            //this.End = End;
        }

    }
}
