namespace UCBiblioteca
{
    partial class Autor
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
            this.Option = new System.Windows.Forms.GroupBox();
            this.eliminarAutor = new System.Windows.Forms.RadioButton();
            this.modificarAutor = new System.Windows.Forms.RadioButton();
            this.afegirAutor = new System.Windows.Forms.RadioButton();
            this.Llista = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Afegir = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Titol = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.onlyLetters2 = new UCBiblioteca.OnlyLetters();
            this.onlyLetters1 = new UCBiblioteca.OnlyLetters();
            this.isbn1 = new UCBiblioteca.ISBN();
            this.Option.SuspendLayout();
            this.Llista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Afegir.SuspendLayout();
            this.SuspendLayout();
            // 
            // Option
            // 
            this.Option.Controls.Add(this.eliminarAutor);
            this.Option.Controls.Add(this.modificarAutor);
            this.Option.Controls.Add(this.afegirAutor);
            this.Option.Location = new System.Drawing.Point(3, 3);
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(135, 274);
            this.Option.TabIndex = 3;
            this.Option.TabStop = false;
            // 
            // eliminarAutor
            // 
            this.eliminarAutor.AutoSize = true;
            this.eliminarAutor.Location = new System.Drawing.Point(18, 172);
            this.eliminarAutor.Name = "eliminarAutor";
            this.eliminarAutor.Size = new System.Drawing.Size(89, 17);
            this.eliminarAutor.TabIndex = 1;
            this.eliminarAutor.TabStop = true;
            this.eliminarAutor.Text = "Eliminar Autor";
            this.eliminarAutor.UseVisualStyleBackColor = true;
            // 
            // modificarAutor
            // 
            this.modificarAutor.AutoSize = true;
            this.modificarAutor.Location = new System.Drawing.Point(18, 122);
            this.modificarAutor.Name = "modificarAutor";
            this.modificarAutor.Size = new System.Drawing.Size(96, 17);
            this.modificarAutor.TabIndex = 0;
            this.modificarAutor.TabStop = true;
            this.modificarAutor.Text = "Modificar Autor";
            this.modificarAutor.UseVisualStyleBackColor = true;
            this.modificarAutor.CheckedChanged += new System.EventHandler(this.modificarAutor_CheckedChanged);
            // 
            // afegirAutor
            // 
            this.afegirAutor.AutoSize = true;
            this.afegirAutor.Location = new System.Drawing.Point(18, 70);
            this.afegirAutor.Name = "afegirAutor";
            this.afegirAutor.Size = new System.Drawing.Size(80, 17);
            this.afegirAutor.TabIndex = 0;
            this.afegirAutor.TabStop = true;
            this.afegirAutor.Text = "Afegir Autor";
            this.afegirAutor.UseVisualStyleBackColor = true;
            this.afegirAutor.CheckedChanged += new System.EventHandler(this.afegirAutor_CheckedChanged);
            // 
            // Llista
            // 
            this.Llista.Controls.Add(this.dataGridView1);
            this.Llista.Location = new System.Drawing.Point(389, 3);
            this.Llista.Name = "Llista";
            this.Llista.Size = new System.Drawing.Size(527, 362);
            this.Llista.TabIndex = 4;
            this.Llista.TabStop = false;
            this.Llista.Text = "Autor";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(513, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // Afegir
            // 
            this.Afegir.Controls.Add(this.onlyLetters2);
            this.Afegir.Controls.Add(this.onlyLetters1);
            this.Afegir.Controls.Add(this.isbn1);
            this.Afegir.Controls.Add(this.label2);
            this.Afegir.Controls.Add(this.Titol);
            this.Afegir.Controls.Add(this.Id);
            this.Afegir.Location = new System.Drawing.Point(144, 6);
            this.Afegir.Name = "Afegir";
            this.Afegir.Size = new System.Drawing.Size(239, 274);
            this.Afegir.TabIndex = 5;
            this.Afegir.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cognom";
            // 
            // Titol
            // 
            this.Titol.AutoSize = true;
            this.Titol.Location = new System.Drawing.Point(23, 74);
            this.Titol.Name = "Titol";
            this.Titol.Size = new System.Drawing.Size(29, 13);
            this.Titol.TabIndex = 2;
            this.Titol.Text = "Nom";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(34, 44);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(18, 13);
            this.Id.TabIndex = 1;
            this.Id.Text = "ID";
            // 
            // onlyLetters2
            // 
            this.onlyLetters2.Enabled = false;
            this.onlyLetters2.Location = new System.Drawing.Point(60, 93);
            this.onlyLetters2.Name = "onlyLetters2";
            this.onlyLetters2.OnlyLettersText = "";
            this.onlyLetters2.Size = new System.Drawing.Size(152, 20);
            this.onlyLetters2.TabIndex = 8;
            // 
            // onlyLetters1
            // 
            this.onlyLetters1.Enabled = false;
            this.onlyLetters1.Location = new System.Drawing.Point(60, 67);
            this.onlyLetters1.Name = "onlyLetters1";
            this.onlyLetters1.OnlyLettersText = "";
            this.onlyLetters1.Size = new System.Drawing.Size(152, 20);
            this.onlyLetters1.TabIndex = 7;
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
            // Autor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Afegir);
            this.Controls.Add(this.Llista);
            this.Controls.Add(this.Option);
            this.Name = "Autor";
            this.Size = new System.Drawing.Size(1103, 559);
            this.Option.ResumeLayout(false);
            this.Option.PerformLayout();
            this.Llista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Afegir.ResumeLayout(false);
            this.Afegir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox Option;
        public System.Windows.Forms.RadioButton eliminarAutor;
        public System.Windows.Forms.RadioButton modificarAutor;
        public System.Windows.Forms.RadioButton afegirAutor;
        public System.Windows.Forms.GroupBox Llista;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.GroupBox Afegir;
        private ISBN isbn1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label Titol;
        public System.Windows.Forms.Label Id;
        private OnlyLetters onlyLetters2;
        private OnlyLetters onlyLetters1;
    }
}
