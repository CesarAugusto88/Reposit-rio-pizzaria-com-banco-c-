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
    public partial class FormEstoque : Form
    {
        public FormEstoque()
        {
            InitializeComponent();
        }

        private void BtnBebidas_Click(object sender, EventArgs e)
        {
            FormEstoqueBebidas EB = new FormEstoqueBebidas();
            EB.ShowDialog();
        }

        private void BtnIngredientes_Click(object sender, EventArgs e)
        {
            FormEstoqueIngredientes EI = new FormEstoqueIngredientes();
            EI.ShowDialog();
        }

        private void BtnLimpeza_Click(object sender, EventArgs e)
        {
            FormEstoqueLimpeza EL = new FormEstoqueLimpeza();
            EL.ShowDialog();
        }
                
    }
}
