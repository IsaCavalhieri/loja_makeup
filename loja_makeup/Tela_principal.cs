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
    public partial class Tela_principal : Form
    {
        public Tela_principal()
        {
            InitializeComponent();
        }

        private void btnoutrosprodutos_Click(object sender, EventArgs e)
        {
            Tela_produtos tela_principal = new Tela_produtos();
            tela_principal.ShowDialog();
        }
    }
}
