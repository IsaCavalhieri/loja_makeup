﻿namespace loja_makeup
{
    partial class Tela_produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_produtos));
            btnvercarrinho = new Button();
            SuspendLayout();
            // 
            // btnvercarrinho
            // 
            btnvercarrinho.Location = new Point(352, 406);
            btnvercarrinho.Name = "btnvercarrinho";
            btnvercarrinho.Size = new Size(91, 23);
            btnvercarrinho.TabIndex = 0;
            btnvercarrinho.Text = "ver carrinho";
            btnvercarrinho.UseVisualStyleBackColor = true;
            btnvercarrinho.Click += btnvercarrinho_Click;
            // 
            // Tela_produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(482, 476);
            Controls.Add(btnvercarrinho);
            Name = "Tela_produtos";
            Text = "Tela_produtos";
            Load += Tela_produtos_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnvercarrinho;
    }
}