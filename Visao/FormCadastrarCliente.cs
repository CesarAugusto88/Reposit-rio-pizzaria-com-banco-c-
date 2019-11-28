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
    public partial class FormCadastrarCliente : Form
    {
        public FormCadastrarCliente()
        {
            InitializeComponent();
        }

        private void BtnCadastrarC_Click(object sender, EventArgs e)
        {
            
            Cliente cliente = new Cliente(txbNomeC.Text, txbCPFC.Text, txbRGC.Text, txbGeneroC.Text, txbCelularC.Text, txbEmailC.Text, txbLogradouroC.Text, int.Parse(txbNumeroC.Text), txbComplementoC.Text, txbBairroC.Text);
            ControleCliente cc = new ControleCliente();
            string mensagem = cc.AdicionarCliente(cliente); //Chama o método que realiza a inserção no banco.

            MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //MessageBox.Show(mensagem);
            LimpaTextoCliente();
            

            //FormBemVindo BvC = new FormBemVindo();
            //BvC.ShowDialog();
            //PreencherListView();
        }
        public void LimpaTextoCliente()
        {
            txbNomeC.Text = "";
            txbCPFC.Text = "";
            txbRGC.Text = "";
            txbGeneroC.Text = "";
            txbCelularC.Text = "";
            txbEmailC.Text = "";
            txbLogradouroC.Text = "";
            txbNumeroC.Text = "";
            txbComplementoC.Text = "";
            txbBairroC.Text = "";
        }
    }
}
