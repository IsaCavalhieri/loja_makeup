using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loja_makeup
{
    public partial class Tela_cadastro : Form
    {
        public Tela_cadastro()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncriar_Click(object sender, EventArgs e)
        {
            Tela_principal tela_cadastro = new Tela_principal();
            tela_cadastro.ShowDialog();
        }
    }
}
