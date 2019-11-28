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
    public partial class FormFazerPedido : Form
    {
        public FormFazerPedido()
        {
            InitializeComponent();
        }

        public static implicit operator FormFazerPedido(FormCadastrarCliente v)
        {
            throw new NotImplementedException();
        }
    }
}
