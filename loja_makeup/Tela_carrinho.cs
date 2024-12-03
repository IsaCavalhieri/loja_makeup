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
    public partial class Tela_carrinho : Form
    {
        public Tela_carrinho()
        {
            InitializeComponent();
        }

        private void Tela_carrinho_Load(object sender, EventArgs e)
        {


        }

        private void btncomprar_Click(object sender, EventArgs e)
        {
            Tela_pagamento tela_pagamento = new Tela_pagamento();
            tela_pagamento.ShowDialog();
        }
    }
}
