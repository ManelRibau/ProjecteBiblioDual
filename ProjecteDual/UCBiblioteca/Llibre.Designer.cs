namespace UCBiblioteca
{
    partial class Llibre
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
            this.Afegir = new System.Windows.Forms.GroupBox();
            this.Genere = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Autor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Titol = new System.Windows.Forms.Label();
            this.ISBN = new System.Windows.Forms.Label();
            this.Option = new System.Windows.Forms.GroupBox();
            this.eliminarLlibre = new System.Windows.Forms.RadioButton();
            this.modificarLlibre = new System.Windows.Forms.RadioButton();
            this.afegirLlibre = new System.Windows.Forms.RadioButton();
            this.Llista = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.isbn1 = new UCBiblioteca.ISBN();
            this.Afegir.SuspendLayout();
            this.Option.SuspendLayout();
            this.Llista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Afegir
            // 
            this.Afegir.Controls.Add(this.isbn1);
            this.Afegir.Controls.Add(this.Genere);
            this.Afegir.Controls.Add(this.label1);
            this.Afegir.Controls.Add(this.comboBox1);
            this.Afegir.Controls.Add(this.Autor);
            this.Afegir.Controls.Add(this.textBox1);
            this.Afegir.Controls.Add(this.Titol);
            this.Afegir.Controls.Add(this.ISBN);
            this.Afegir.Location = new System.Drawing.Point(144, 6);
            this.Afegir.Name = "Afegir";
            this.Afegir.Size = new System.Drawing.Size(239, 274);
            this.Afegir.TabIndex = 1;
            this.Afegir.TabStop = false;
            // 
            // Genere
            // 
            this.Genere.Enabled = false;
            this.Genere.Location = new System.Drawing.Point(60, 118);
            this.Genere.Name = "Genere";
            this.Genere.Size = new System.Drawing.Size(152, 20);
            this.Genere.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Genere";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hola",
            "Adeu",
            "Hol"});
            this.comboBox1.Location = new System.Drawing.Point(60, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // Autor
            // 
            this.Autor.AutoSize = true;
            this.Autor.Location = new System.Drawing.Point(9, 95);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(32, 13);
            this.Autor.TabIndex = 0;
            this.Autor.Text = "Autor";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(60, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Titol
            // 
            this.Titol.AutoSize = true;
            this.Titol.Location = new System.Drawing.Point(14, 67);
            this.Titol.Name = "Titol";
            this.Titol.Size = new System.Drawing.Size(27, 13);
            this.Titol.TabIndex = 2;
            this.Titol.Text = "Titol";
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Location = new System.Drawing.Point(9, 37);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(32, 13);
            this.ISBN.TabIndex = 1;
            this.ISBN.Text = "ISBN";
            // 
            // Option
            // 
            this.Option.Controls.Add(this.eliminarLlibre);
            this.Option.Controls.Add(this.modificarLlibre);
            this.Option.Controls.Add(this.afegirLlibre);
            this.Option.Location = new System.Drawing.Point(3, 3);
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(135, 274);
            this.Option.TabIndex = 2;
            this.Option.TabStop = false;
            // 
            // eliminarLlibre
            // 
            this.eliminarLlibre.AutoSize = true;
            this.eliminarLlibre.Location = new System.Drawing.Point(18, 172);
            this.eliminarLlibre.Name = "eliminarLlibre";
            this.eliminarLlibre.Size = new System.Drawing.Size(89, 17);
            this.eliminarLlibre.TabIndex = 1;
            this.eliminarLlibre.TabStop = true;
            this.eliminarLlibre.Text = "Eliminar Llibre";
            this.eliminarLlibre.UseVisualStyleBackColor = true;
            // 
            // modificarLlibre
            // 
            this.modificarLlibre.AutoSize = true;
            this.modificarLlibre.Location = new System.Drawing.Point(18, 122);
            this.modificarLlibre.Name = "modificarLlibre";
            this.modificarLlibre.Size = new System.Drawing.Size(96, 17);
            this.modificarLlibre.TabIndex = 0;
            this.modificarLlibre.TabStop = true;
            this.modificarLlibre.Text = "Modificar Llibre";
            this.modificarLlibre.UseVisualStyleBackColor = true;
            this.modificarLlibre.CheckedChanged += new System.EventHandler(this.modificarLlibre_CheckedChanged);
            // 
            // afegirLlibre
            // 
            this.afegirLlibre.AutoSize = true;
            this.afegirLlibre.Location = new System.Drawing.Point(18, 70);
            this.afegirLlibre.Name = "afegirLlibre";
            this.afegirLlibre.Size = new System.Drawing.Size(80, 17);
            this.afegirLlibre.TabIndex = 0;
            this.afegirLlibre.TabStop = true;
            this.afegirLlibre.Text = "Afegir Llibre";
            this.afegirLlibre.UseVisualStyleBackColor = true;
            this.afegirLlibre.CheckedChanged += new System.EventHandler(this.afegirLlibre_CheckedChanged);
            // 
            // Llista
            // 
            this.Llista.Controls.Add(this.dataGridView1);
            this.Llista.Location = new System.Drawing.Point(389, 3);
            this.Llista.Name = "Llista";
            this.Llista.Size = new System.Drawing.Size(527, 362);
            this.Llista.TabIndex = 3;
            this.Llista.TabStop = false;
            this.Llista.Text = "Llibres";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(513, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // isbn1
            // 
            this.isbn1.Enabled = false;
            this.isbn1.ISBNText = "";
            this.isbn1.Location = new System.Drawing.Point(60, 37);
            this.isbn1.Name = "isbn1";
            this.isbn1.Size = new System.Drawing.Size(152, 20);
            this.isbn1.TabIndex = 6;
            // 
            // Llibre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.Llista);
            this.Controls.Add(this.Option);
            this.Controls.Add(this.Afegir);
            this.Name = "Llibre";
            this.Size = new System.Drawing.Size(1068, 610);
            this.Afegir.ResumeLayout(false);
            this.Afegir.PerformLayout();
            this.Option.ResumeLayout(false);
            this.Option.PerformLayout();
            this.Llista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox Afegir;
        public System.Windows.Forms.GroupBox Option;
        public System.Windows.Forms.GroupBox Llista;
        public System.Windows.Forms.Label Titol;
        public System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label Autor;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox Genere;
        public System.Windows.Forms.RadioButton modificarLlibre;
        public System.Windows.Forms.RadioButton afegirLlibre;
        public System.Windows.Forms.RadioButton eliminarLlibre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ISBN isbn1;
    }
}
