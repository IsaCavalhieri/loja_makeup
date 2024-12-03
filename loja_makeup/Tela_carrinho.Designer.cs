namespace loja_makeup
{
    partial class Tela_carrinho
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
            btncomprar = new Button();
            SuspendLayout();
            // 
            // btncomprar
            // 
            btncomprar.Location = new Point(372, 377);
            btncomprar.Name = "btncomprar";
            btncomprar.Size = new Size(75, 23);
            btncomprar.TabIndex = 0;
            btncomprar.Text = "comprar";
            btncomprar.UseVisualStyleBackColor = true;
            btncomprar.Click += btncomprar_Click;
            // 
            // Tela_carrinho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.isa__1_1;
            ClientSize = new Size(487, 450);
            Controls.Add(btncomprar);
            Name = "Tela_carrinho";
            Text = "Tela_carrinho";
            Load += Tela_carrinho_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btncomprar;
    }
}