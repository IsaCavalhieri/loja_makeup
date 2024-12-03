namespace loja_makeup
{
    partial class Tela_cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_cadastro));
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            btncriar = new Button();
            txbnome = new TextBox();
            txbsobrenome = new TextBox();
            txbemail = new TextBox();
            txbcpf = new TextBox();
            txbcidade = new TextBox();
            txbestado = new TextBox();
            lblnome = new Label();
            lblsobrenome = new Label();
            lblemail = new Label();
            lblcidade = new Label();
            lblestado = new Label();
            lblcpf = new Label();
            btnlimpar = new Button();
            btneditar = new Button();
            btninserir = new Button();
            btnexcluir = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.Location = new Point(107, 394);
            listView1.Name = "listView1";
            listView1.Size = new Size(420, 181);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nome";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Sobrenome";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Email";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Cidade";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Estado";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Cpf";
            // 
            // btncriar
            // 
            btncriar.Location = new Point(518, 581);
            btncriar.Name = "btncriar";
            btncriar.Size = new Size(75, 23);
            btncriar.TabIndex = 1;
            btncriar.Text = "criar";
            btncriar.UseVisualStyleBackColor = true;
            btncriar.Click += btncriar_Click;
            // 
            // txbnome
            // 
            txbnome.Location = new Point(12, 39);
            txbnome.Name = "txbnome";
            txbnome.Size = new Size(100, 23);
            txbnome.TabIndex = 2;
            // 
            // txbsobrenome
            // 
            txbsobrenome.Location = new Point(12, 95);
            txbsobrenome.Name = "txbsobrenome";
            txbsobrenome.Size = new Size(100, 23);
            txbsobrenome.TabIndex = 3;
            // 
            // txbemail
            // 
            txbemail.Location = new Point(29, 139);
            txbemail.Name = "txbemail";
            txbemail.Size = new Size(100, 23);
            txbemail.TabIndex = 4;
            // 
            // txbcpf
            // 
            txbcpf.Location = new Point(29, 299);
            txbcpf.Name = "txbcpf";
            txbcpf.Size = new Size(100, 23);
            txbcpf.TabIndex = 5;
            txbcpf.TextChanged += textBox4_TextChanged;
            // 
            // txbcidade
            // 
            txbcidade.Location = new Point(12, 186);
            txbcidade.Name = "txbcidade";
            txbcidade.Size = new Size(100, 23);
            txbcidade.TabIndex = 6;
            // 
            // txbestado
            // 
            txbestado.Location = new Point(12, 239);
            txbestado.Name = "txbestado";
            txbestado.Size = new Size(100, 23);
            txbestado.TabIndex = 7;
            txbestado.TextChanged += textBox6_TextChanged;
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(22, 21);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(40, 15);
            lblnome.TabIndex = 8;
            lblnome.Text = "Nome";
            // 
            // lblsobrenome
            // 
            lblsobrenome.AutoSize = true;
            lblsobrenome.Location = new Point(12, 65);
            lblsobrenome.Name = "lblsobrenome";
            lblsobrenome.Size = new Size(68, 15);
            lblsobrenome.TabIndex = 9;
            lblsobrenome.Text = "Sobrenome";
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Location = new Point(12, 121);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(36, 15);
            lblemail.TabIndex = 10;
            lblemail.Text = "Email";
            // 
            // lblcidade
            // 
            lblcidade.AutoSize = true;
            lblcidade.Location = new Point(12, 168);
            lblcidade.Name = "lblcidade";
            lblcidade.Size = new Size(44, 15);
            lblcidade.TabIndex = 11;
            lblcidade.Text = "Cidade";
            // 
            // lblestado
            // 
            lblestado.AutoSize = true;
            lblestado.Location = new Point(20, 221);
            lblestado.Name = "lblestado";
            lblestado.Size = new Size(42, 15);
            lblestado.TabIndex = 12;
            lblestado.Text = "Estado";
            // 
            // lblcpf
            // 
            lblcpf.AutoSize = true;
            lblcpf.Location = new Point(12, 281);
            lblcpf.Name = "lblcpf";
            lblcpf.Size = new Size(26, 15);
            lblcpf.TabIndex = 13;
            lblcpf.Text = "Cpf";
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(471, 85);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(75, 23);
            btnlimpar.TabIndex = 14;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btneditar
            // 
            btneditar.Location = new Point(471, 114);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(75, 23);
            btneditar.TabIndex = 15;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = true;
            btneditar.Click += btneditar_Click;
            // 
            // btninserir
            // 
            btninserir.Location = new Point(485, 143);
            btninserir.Name = "btninserir";
            btninserir.Size = new Size(75, 23);
            btninserir.TabIndex = 16;
            btninserir.Text = "Inserir";
            btninserir.UseVisualStyleBackColor = true;
            btninserir.Click += btninserir_Click;
            // 
            // btnexcluir
            // 
            btnexcluir.Location = new Point(501, 185);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(75, 23);
            btnexcluir.TabIndex = 17;
            btnexcluir.Text = "Excluir";
            btnexcluir.UseVisualStyleBackColor = true;
            btnexcluir.Click += btnexcluir_Click;
            // 
            // Tela_cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(605, 616);
            Controls.Add(btnexcluir);
            Controls.Add(btninserir);
            Controls.Add(btneditar);
            Controls.Add(btnlimpar);
            Controls.Add(lblcpf);
            Controls.Add(lblestado);
            Controls.Add(lblcidade);
            Controls.Add(lblemail);
            Controls.Add(lblsobrenome);
            Controls.Add(lblnome);
            Controls.Add(txbestado);
            Controls.Add(txbcidade);
            Controls.Add(txbcpf);
            Controls.Add(txbemail);
            Controls.Add(txbsobrenome);
            Controls.Add(txbnome);
            Controls.Add(btncriar);
            Controls.Add(listView1);
            Name = "Tela_cadastro";
            Text = "Tela_cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button btncriar;
        private TextBox txbnome;
        private TextBox txbsobrenome;
        private TextBox txbemail;
        private TextBox txbcpf;
        private TextBox txbcidade;
        private TextBox txbestado;
        private Label lblnome;
        private Label lblsobrenome;
        private Label lblemail;
        private Label lblcidade;
        private Label lblestado;
        private Label lblcpf;
        private Button btnlimpar;
        private Button btneditar;
        private Button btninserir;
        private Button btnexcluir;
    }
}