namespace loja_makeup
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnentrar = new Button();
            btncriarconta = new Button();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // btnentrar
            // 
            btnentrar.Location = new Point(210, 349);
            btnentrar.Name = "btnentrar";
            btnentrar.Size = new Size(75, 23);
            btnentrar.TabIndex = 0;
            btnentrar.Text = "Entrar";
            btnentrar.UseVisualStyleBackColor = true;
            btnentrar.Click += btnentrar_Click;
            // 
            // btncriarconta
            // 
            btncriarconta.Location = new Point(210, 403);
            btncriarconta.Name = "btncriarconta";
            btncriarconta.Size = new Size(75, 23);
            btncriarconta.TabIndex = 1;
            btncriarconta.Text = "Criar conta";
            btncriarconta.UseVisualStyleBackColor = true;
            btncriarconta.Click += btncriarconta_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.isa__1_;
            ClientSize = new Size(494, 497);
            Controls.Add(btncriarconta);
            Controls.Add(btnentrar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnentrar;
        private Button btncriarconta;
        private ImageList imageList1;
    }
}
