﻿using System;
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
    public partial class Tela_produtos : Form
    {
        public Tela_produtos()
        {
            InitializeComponent();
        }

        private void Tela_produtos_Load(object sender, EventArgs e)
        {

        }

        private void btnvercarrinho_Click(object sender, EventArgs e)
        {
            Tela_carrinho tela_carrinho = new Tela_carrinho();
            tela_carrinho.ShowDialog();
        }
    }
}
