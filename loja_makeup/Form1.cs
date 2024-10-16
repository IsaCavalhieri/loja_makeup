namespace loja_makeup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            Tela_entrar form1 = new Tela_entrar();
            form1.ShowDialog();

        }

        private void btncriarconta_Click(object sender, EventArgs e)
        {
            Tela_cadastro form1 = new Tela_cadastro();
            form1.ShowDialog();
        }
    }
}
