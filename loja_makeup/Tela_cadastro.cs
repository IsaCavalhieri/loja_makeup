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

        private void btncriar_Click(object sender, EventArgs e)
        {
            Tela_principal tela_principal = new Tela_principal();
            tela_principal.ShowDialog();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txbnome.Clear();
            txbsobrenome.Clear();
            txbcidade.Clear();
            txbestado.Clear();
            txbemail.Clear();
            txbcpf.Clear();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btninserir_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Corretor cadastrado!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txbnome.Clear();
            txbsobrenome.Clear();
            txbcidade.Clear();
            txbestado.Clear();
            txbemail.Clear();
            txbcpf.Clear();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Corretor atualizado!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txbnome.Clear();
            txbsobrenome.Clear();
            txbcidade.Clear();
            txbestado.Clear();
            txbemail.Clear();
            txbcpf.Clear();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza" +
            " que deseja excluir?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            txbnome.Clear();
            txbsobrenome.Clear();
            txbcidade.Clear();
            txbestado.Clear();
            txbemail.Clear();
            txbcpf.Clear();
        }
    }
}








