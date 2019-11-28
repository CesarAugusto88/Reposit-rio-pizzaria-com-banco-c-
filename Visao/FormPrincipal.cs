using Pizzaria.Controle;
using Pizzaria.Visao;
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


namespace Pizzaria
{
    public partial class Form1 : Form
    {
        /*
       
        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            ControleCliente cc = new ControleCliente();
            string mensagem = cc.AdicionarCliente(cliente); //Chama o método que realiza a inserção no banco.

            MessageBox.Show(mensagem);
            PreencherListView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PreencherListView();
        }

        public void PreencherListView()
        {
            listView1.Items.Clear();

            SqlDataReader dr; //Objeto para armazenar o retorno do banco. 
            ControleCliente cc = new ControleCliente();
            dr = cc.RetornarClientes(); //Chama o método responsável pela realização da consulta. 

            if(dr != null) //Verifico 
            {
                while (dr.Read())
                {
                    ListViewItem lv = new ListViewItem(dr.GetInt32(0).ToString());
                    lv.SubItems.Add(dr.GetString(1));//Nome
                    lv.SubItems.Add(dr.GetString(2));//CPF
                    lv.SubItems.Add(dr.GetString(3));//RG
                    lv.SubItems.Add(dr.GetString(4));//Email
                    listView1.Items.Add(lv); //Adiciona a linha criada à listview.
                }
            }
        } */
        public Form1()
        {
            InitializeComponent();
            btnAbrirCaixa.Visible = false;
            btnCadastrarCliente.Visible = false;
            btnCadastratroFunc.Visible = false;
            btnCadastrarPizza.Visible = false;
            btnFazerPedido.Visible = false;
            btnFecharCaixa.Visible = false;
            btnEstoque.Visible = false;
        }

        private void BtnCadastroCliente_Click(object sender, EventArgs e)
        {
            FormCadastrarCliente Cliente = new FormCadastrarCliente();
            Cliente.ShowDialog();

        }

        private void BtnCadastrarPizza_Click(object sender, EventArgs e)
        {
            FormCadastrarPizza Pizza = new FormCadastrarPizza();
            Pizza.ShowDialog();

        }

        private void BtnFazerPedido_Click(object sender, EventArgs e)
        {
            FormFazerPedido Pedido = new FormFazerPedido();
            Pedido.ShowDialog();

        }

        private void BtnCadastratroFunc_Click(object sender, EventArgs e)
        {
            FormCadastrarFuncionario Func = new FormCadastrarFuncionario();
            Func.ShowDialog();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {// fazer igual form cadastrar cliente ok. No cabeçalho tem q ter todas as pastas (.controle, .modelo, .visao)
            
            //ver os txb do funcionario em FormCadastrarFuncionario.Designer.cs

            //Funcionario funcionario = new Funcionario(txb...);
            ControleFuncionario ff = new ControleFuncionario();
            //string mensagem = ff.AdicionarFuncionario(funcionario); //Chama o método que realiza a inserção no banco.
      
            //MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ControleLogin controle = new ControleLogin();
            controle.acessar(txbLogin.Text, txbSenha.Text);
            // loginDAO.mensagem.Equals("") não funciona
            if (controle.mensagem == "")
            {
                // verifica se na classe controle se verdadeiro
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormBemVindo WC = new FormBemVindo();
                    WC.ShowDialog();
                    btnAbrirCaixa.Visible = true;                    
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login e senha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
            
        }

        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            FormEstoque ET = new FormEstoque();
            ET.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
