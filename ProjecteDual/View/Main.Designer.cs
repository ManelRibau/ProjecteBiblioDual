namespace View
{
    partial class Main
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
            this.menu1 = new System.Windows.Forms.MenuStrip();
            this.llibreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.préstecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sancióToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sociToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.llistaDesperaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diesNoHàbilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcome1 = new View.Welcome();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu1
            // 
            this.menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.llibreToolStripMenuItem,
            this.autorToolStripMenuItem,
            this.cToolStripMenuItem,
            this.préstecToolStripMenuItem,
            this.sancióToolStripMenuItem,
            this.sociToolStripMenuItem,
            this.llistaDesperaToolStripMenuItem,
            this.diesNoHàbilsToolStripMenuItem});
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(742, 24);
            this.menu1.TabIndex = 0;
            this.menu1.Text = "menuStrip1";
            // 
            // llibreToolStripMenuItem
            // 
            this.llibreToolStripMenuItem.Name = "llibreToolStripMenuItem";
            this.llibreToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.llibreToolStripMenuItem.Text = "Llibre";
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.autorToolStripMenuItem.Text = "Autor";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.cToolStripMenuItem.Text = "Còpia";
            // 
            // préstecToolStripMenuItem
            // 
            this.préstecToolStripMenuItem.Name = "préstecToolStripMenuItem";
            this.préstecToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.préstecToolStripMenuItem.Text = "Préstec";
            // 
            // sancióToolStripMenuItem
            // 
            this.sancióToolStripMenuItem.Name = "sancióToolStripMenuItem";
            this.sancióToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sancióToolStripMenuItem.Text = "Sanció";
            // 
            // sociToolStripMenuItem
            // 
            this.sociToolStripMenuItem.Name = "sociToolStripMenuItem";
            this.sociToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.sociToolStripMenuItem.Text = "Soci";
            // 
            // llistaDesperaToolStripMenuItem
            // 
            this.llistaDesperaToolStripMenuItem.Name = "llistaDesperaToolStripMenuItem";
            this.llistaDesperaToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.llistaDesperaToolStripMenuItem.Text = "Llista d\'espera";
            // 
            // diesNoHàbilsToolStripMenuItem
            // 
            this.diesNoHàbilsToolStripMenuItem.Name = "diesNoHàbilsToolStripMenuItem";
            this.diesNoHàbilsToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.diesNoHàbilsToolStripMenuItem.Text = "Dies no hàbils";
            // 
            // welcome1
            // 
            this.welcome1.Location = new System.Drawing.Point(12, 27);
            this.welcome1.Name = "welcome1";
            this.welcome1.Size = new System.Drawing.Size(718, 280);
            this.welcome1.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 314);
            this.Controls.Add(this.welcome1);
            this.Controls.Add(this.menu1);
            this.MainMenuStrip = this.menu1;
            this.Name = "Main";
            this.Text = "Form1";
            this.menu1.ResumeLayout(false);
            this.menu1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu1;
        private System.Windows.Forms.ToolStripMenuItem llibreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem préstecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sancióToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sociToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem llistaDesperaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diesNoHàbilsToolStripMenuItem;
        private Welcome welcome1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

