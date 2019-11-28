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
    public partial class FormCadastrarFuncionario : Form
    {
        public FormCadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void BtnCadastrarF_Click(object sender, EventArgs e)
        {
            
            Funcionario funcionario = new Funcionario(txbNomeF.Text, txbCPFF.Text, txbRGF.Text, txbGeneroF.Text, txbCelularF.Text, txbEmailF.Text, txbLogradouroF.Text, int.Parse(txbNumeroF.Text), txbComplementoF.Text, txbBairroF.Text);
            ControleFuncionario ff = new ControleFuncionario();
            // fazer controle login e senha. criado um fk para email e pode-se verificar uma so vez
            //outra 'mensagem' string mensagem0 = ff.AdicionarFuncionario(funcionario); //Chama o método que realiza a inserção no banco.

            // colocar verificação de mensagem junto no banco
            ControleLogin controle = new ControleLogin();
            string mensagem = controle.cadastrar(txbEmailF.Text, txbSenhaF.Text, txbConfirmaSenhaF.Text);
            if (controle.tem)// mensagem de sucesso
            {                
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show(controle.mensagem);// mensagem de erro
                
            }

            
            LimpaTextoFuncionario();

            //FormBemVindo BvF = new FormBemVindo();
            //BvF.ShowDialog();
            //PreencherListView();
        }
        public void LimpaTextoFuncionario()
        {
            txbNomeF.Text = "";
            txbCPFF.Text = "";
            txbRGF.Text = "";
            txbGeneroF.Text = "";
            txbCelularF.Text = "";
            txbEmailF.Text = "";
            txbLogradouroF.Text = "";
            txbNumeroF.Text = "";
            txbComplementoF.Text = "";
            txbBairroF.Text = "";
        }
    }
}
