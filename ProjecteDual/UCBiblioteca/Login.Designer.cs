namespace UCBiblioteca
{
    partial class Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usuari = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Conect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuari
            // 
            this.usuari.AutoSize = true;
            this.usuari.Location = new System.Drawing.Point(11, 15);
            this.usuari.Name = "usuari";
            this.usuari.Size = new System.Drawing.Size(70, 13);
            this.usuari.TabIndex = 0;
            this.usuari.Text = "Nom d\'Usuari";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Conect
            // 
            this.Conect.Location = new System.Drawing.Point(14, 63);
            this.Conect.Name = "Conect";
            this.Conect.Size = new System.Drawing.Size(218, 35);
            this.Conect.TabIndex = 2;
            this.Conect.Text = "Conectar";
            this.Conect.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Conect);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.usuari);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(243, 115);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label usuari;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button Conect;
    }
}
