using Pizzaria.Controle;
using Pizzaria.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria.Visao
{
    public partial class FormCadastrarPizza : Form
    {
        public FormCadastrarPizza()
        {
            InitializeComponent();
        }
        private void BtnCadastrarPizza_Click(object sender, EventArgs e)
        {


            Pizza pizza = new Pizza(txbNomePizza.Text, txbIngrediente1.Text, txbIngrediente2.Text, txbIngrediente3.Text, txbIngrediente4.Text, double.Parse(txbValorPizza.Text));
            ControlePizza piz = new ControlePizza();
            string mensagem = piz.AdicionarPizza(pizza); //Chama o método que realiza a inserção no banco.

            MessageBox.Show(mensagem);
            LimpaTextoPizza();


            //FormBemVindo BvC = new FormBemVindo();
            //BvC.ShowDialog();
            //PreencherListView();
        }
        public void LimpaTextoPizza()
        {
            txbNomePizza.Text = "";
            txbIngrediente1.Text = "";
            txbIngrediente2.Text = "";
            txbIngrediente3.Text = "";
            txbIngrediente4.Text = "";
            txbValorPizza.Text = "";


        }


    }
}
