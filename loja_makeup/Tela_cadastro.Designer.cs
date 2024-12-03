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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
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
            // textBox1
            // 
            textBox1.Location = new Point(12, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(29, 139);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(310, 278);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 278);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 345);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 7;
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
            lblcidade.Location = new Point(29, 255);
            lblcidade.Name = "lblcidade";
            lblcidade.Size = new Size(44, 15);
            lblcidade.TabIndex = 11;
            lblcidade.Text = "Cidade";
            // 
            // lblestado
            // 
            lblestado.AutoSize = true;
            lblestado.Location = new Point(26, 317);
            lblestado.Name = "lblestado";
            lblestado.Size = new Size(42, 15);
            lblestado.TabIndex = 12;
            lblestado.Text = "Estado";
            // 
            // lblcpf
            // 
            lblcpf.AutoSize = true;
            lblcpf.Location = new Point(200, 295);
            lblcpf.Name = "lblcpf";
            lblcpf.Size = new Size(26, 15);
            lblcpf.TabIndex = 13;
            lblcpf.Text = "Cpf";
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(518, 57);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(75, 23);
            btnlimpar.TabIndex = 14;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            btneditar.Location = new Point(471, 114);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(75, 23);
            btneditar.TabIndex = 15;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = true;
            // 
            // btninserir
            // 
            btninserir.Location = new Point(491, 164);
            btninserir.Name = "btninserir";
            btninserir.Size = new Size(75, 23);
            btninserir.TabIndex = 16;
            btninserir.Text = "Inserir";
            btninserir.UseVisualStyleBackColor = true;
            // 
            // btnexcluir
            // 
            btnexcluir.Location = new Point(504, 217);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(75, 23);
            btnexcluir.TabIndex = 17;
            btnexcluir.Text = "Excluir";
            btnexcluir.UseVisualStyleBackColor = true;
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
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
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