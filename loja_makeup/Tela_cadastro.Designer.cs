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
            panel2 = new Panel();
            lblemail = new Label();
            lblcidade = new Label();
            lbltelefone = new Label();
            lblnome = new Label();
            lblsobrenome = new Label();
            lblcpf = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1 = new Panel();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            btncriar = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(lbltelefone);
            panel2.Controls.Add(lblemail);
            panel2.Controls.Add(lblcidade);
            panel2.Location = new Point(290, 333);
            panel2.Name = "panel2";
            panel2.Size = new Size(188, 180);
            panel2.TabIndex = 1;
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Location = new Point(3, 19);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(47, 15);
            lblemail.TabIndex = 2;
            lblemail.Text = "EMAIL :";
            // 
            // lblcidade
            // 
            lblcidade.AutoSize = true;
            lblcidade.Location = new Point(3, 73);
            lblcidade.Name = "lblcidade";
            lblcidade.Size = new Size(54, 15);
            lblcidade.TabIndex = 0;
            lblcidade.Text = "CIDADE :";
            lblcidade.Click += label5_Click;
            // 
            // lbltelefone
            // 
            lbltelefone.AutoSize = true;
            lbltelefone.Location = new Point(0, 123);
            lbltelefone.Name = "lbltelefone";
            lbltelefone.Size = new Size(67, 15);
            lbltelefone.TabIndex = 3;
            lbltelefone.Text = "TELEFONE :";
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(5, 19);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(48, 15);
            lblnome.TabIndex = 0;
            lblnome.Text = "NOME :";
            // 
            // lblsobrenome
            // 
            lblsobrenome.AutoSize = true;
            lblsobrenome.Location = new Point(5, 73);
            lblsobrenome.Name = "lblsobrenome";
            lblsobrenome.Size = new Size(83, 15);
            lblsobrenome.TabIndex = 1;
            lblsobrenome.Text = "SOBRENOME :";
            // 
            // lblcpf
            // 
            lblcpf.AutoSize = true;
            lblcpf.Location = new Point(5, 123);
            lblcpf.Name = "lblcpf";
            lblcpf.Size = new Size(34, 15);
            lblcpf.TabIndex = 2;
            lblcpf.Text = "CPF :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(5, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(5, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lblcpf);
            panel1.Controls.Add(lblsobrenome);
            panel1.Controls.Add(lblnome);
            panel1.Location = new Point(12, 333);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 180);
            panel1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 141);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(3, 37);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(3, 91);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(0, 141);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 6;
            // 
            // btncriar
            // 
            btncriar.Location = new Point(403, 519);
            btncriar.Name = "btncriar";
            btncriar.Size = new Size(75, 23);
            btncriar.TabIndex = 2;
            btncriar.Text = "criar";
            btncriar.UseVisualStyleBackColor = true;
            btncriar.Click += btncriar_Click;
            // 
            // Tela_cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.isa__2_;
            ClientSize = new Size(490, 553);
            Controls.Add(btncriar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Tela_cadastro";
            Text = "Tela_cadastro";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label lblcidade;
        private Label lblemail;
        private Label lbltelefone;
        private Label lblnome;
        private Label lblsobrenome;
        private Label lblcpf;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel1;
        private TextBox textBox3;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Button btncriar;
    }
}