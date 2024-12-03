namespace loja_makeup
{
    partial class Tela_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_principal));
            btnoutrosprodutos = new Button();
            SuspendLayout();
            // 
            // btnoutrosprodutos
            // 
            btnoutrosprodutos.Location = new Point(378, 438);
            btnoutrosprodutos.Name = "btnoutrosprodutos";
            btnoutrosprodutos.Size = new Size(88, 23);
            btnoutrosprodutos.TabIndex = 0;
            btnoutrosprodutos.Text = "ver produtos";
            btnoutrosprodutos.UseVisualStyleBackColor = true;
            btnoutrosprodutos.Click += btnoutrosprodutos_Click;
            // 
            // Tela_principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(488, 482);
            Controls.Add(btnoutrosprodutos);
            Name = "Tela_principal";
            Text = "Tela_principal";
            Load += Tela_principal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnoutrosprodutos;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}