namespace View
{
    partial class Welcome
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
            this.login1 = new UCBiblioteca.Login();
            this.SuspendLayout();
            // 
            // login1
            // 
            this.login1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login1.Location = new System.Drawing.Point(130, 117);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(262, 210);
            this.login1.TabIndex = 0;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UCBiblioteca.Properties.Resources.sebos_foto_pedro_vilela;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.login1);
            this.DoubleBuffered = true;
            this.Name = "Welcome";
            this.Size = new System.Drawing.Size(1103, 559);
            this.ResumeLayout(false);

        }

        #endregion

        public UCBiblioteca.Login login1;
    }
}
