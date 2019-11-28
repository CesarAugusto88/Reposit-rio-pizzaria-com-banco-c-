using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Modelo
{
    class Pizza
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Ingrediente1 { get; set; }
        public string Ingrediente2 { get; set; }
        public string Ingrediente3 { get; set; }
        public string Ingrediente4 { get; set; }
        public double Valor { get; set; }


        public Pizza(string nome, string ingrediente1, string ingrediente2, string ingrediente3, string ingrediente4, double valor)
        {
            this.Nome = nome;
            this.Ingrediente1 = ingrediente1;
            this.Ingrediente2 = ingrediente2;
            this.Ingrediente3 = ingrediente3;
            this.Ingrediente4 = ingrediente4;
            this.Valor = valor;
        }
    }
}
