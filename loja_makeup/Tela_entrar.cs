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
    public partial class Tela_entrar : Form
    {
        public Tela_entrar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txbUser.Text == "Isadora Cavalhieri" && txbPass.Text == "13579")
            {
                txbUser.Text = String.Empty;
                txbPass.Text = String.Empty;
                txbUser.Focus();
                Tela_principal tela_entrar = new Tela_principal();
                this.Visible = false;
                tela_entrar.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha incorretos",
                    "ERRO NO LOGIN",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }
    }
}
