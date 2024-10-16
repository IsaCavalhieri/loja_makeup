namespace loja_makeup
{
    partial class Tela_entrar
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
            lblusuario = new Label();
            txbUser = new TextBox();
            lblsenha = new Label();
            txbPass = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Location = new Point(227, 330);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(62, 15);
            lblusuario.TabIndex = 0;
            lblusuario.Text = "USUÁRIO :";
            lblusuario.Click += label1_Click;
            // 
            // txbUser
            // 
            txbUser.Location = new Point(213, 348);
            txbUser.Name = "txbUser";
            txbUser.Size = new Size(100, 23);
            txbUser.TabIndex = 1;
            // 
            // lblsenha
            // 
            lblsenha.AutoSize = true;
            lblsenha.Location = new Point(227, 386);
            lblsenha.Name = "lblsenha";
            lblsenha.Size = new Size(51, 15);
            lblsenha.TabIndex = 2;
            lblsenha.Text = "SENHA :";
            lblsenha.Click += label2_Click;
            // 
            // txbPass
            // 
            txbPass.Location = new Point(213, 404);
            txbPass.Name = "txbPass";
            txbPass.Size = new Size(100, 23);
            txbPass.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(394, 426);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Tela_entrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.isa__2_;
            ClientSize = new Size(510, 468);
            Controls.Add(button1);
            Controls.Add(txbPass);
            Controls.Add(lblsenha);
            Controls.Add(txbUser);
            Controls.Add(lblusuario);
            Name = "Tela_entrar";
            Text = "Tela_entrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblusuario;
        private TextBox txbUser;
        private Label lblsenha;
        private TextBox txbPass;
        private Button button1;
    }
}