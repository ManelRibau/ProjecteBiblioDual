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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menu1 = new System.Windows.Forms.MenuStrip();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.préstecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sociToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.llistaDesperaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diesNoHàbilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.llibreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.sociToolStripMenuItem,
            this.llistaDesperaToolStripMenuItem,
            this.diesNoHàbilsToolStripMenuItem,
            this.LoginToolStripMenuItem});
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menu1.Size = new System.Drawing.Size(913, 26);
            this.menu1.TabIndex = 0;
            this.menu1.Text = "menuStrip1";
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
            // LoginToolStripMenuItem
            // 
            this.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
            this.LoginToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.LoginToolStripMenuItem.Text = "Tancar";
            // 
            // llibreToolStripMenuItem
            // 
            this.llibreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.llibreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("llibreToolStripMenuItem.Image")));
            this.llibreToolStripMenuItem.Name = "llibreToolStripMenuItem";
            this.llibreToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.llibreToolStripMenuItem.Text = "Llibre";
            this.llibreToolStripMenuItem.MouseHover += new System.EventHandler(this.llibreToolStripMenuItem_MouseHover);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aToolStripMenuItem.Text = "Afegir";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 573);
            this.Controls.Add(this.menu1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu1;
            this.Name = "Main";
            this.Text = "Biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu1.ResumeLayout(false);
            this.menu1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menu1;
        public System.Windows.Forms.ToolStripMenuItem llibreToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem préstecToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem sociToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem llistaDesperaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem diesNoHàbilsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem LoginToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}

