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
            this.Option = new System.Windows.Forms.GroupBox();
            this.Llista = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LbAfegir = new System.Windows.Forms.Label();
            this.LbModificar = new System.Windows.Forms.Label();
            this.LbEliminar = new System.Windows.Forms.Label();
            this.EliminarLlibre = new System.Windows.Forms.Button();
            this.afegirLlibre = new System.Windows.Forms.Button();
            this.ModificarLlibre = new System.Windows.Forms.Button();
            this.Option.SuspendLayout();
            this.Llista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Option
            // 
            this.Option.BackColor = System.Drawing.Color.SteelBlue;
            this.Option.Controls.Add(this.LbModificar);
            this.Option.Controls.Add(this.LbEliminar);
            this.Option.Controls.Add(this.EliminarLlibre);
            this.Option.Controls.Add(this.LbAfegir);
            this.Option.Controls.Add(this.afegirLlibre);
            this.Option.Controls.Add(this.ModificarLlibre);
            this.Option.Location = new System.Drawing.Point(14, 15);
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(179, 274);
            this.Option.TabIndex = 2;
            this.Option.TabStop = false;
            // 
            // Llista
            // 
            this.Llista.Controls.Add(this.dataGridView1);
            this.Llista.Location = new System.Drawing.Point(622, 6);
            this.Llista.Name = "Llista";
            this.Llista.Size = new System.Drawing.Size(442, 462);
            this.Llista.TabIndex = 3;
            this.Llista.TabStop = false;
            this.Llista.Text = "Llibres";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(429, 439);
            this.dataGridView1.TabIndex = 0;
            // 
            // LbAfegir
            // 
            this.LbAfegir.AutoSize = true;
            this.LbAfegir.Location = new System.Drawing.Point(79, 49);
            this.LbAfegir.Name = "LbAfegir";
            this.LbAfegir.Size = new System.Drawing.Size(58, 13);
            this.LbAfegir.TabIndex = 4;
            this.LbAfegir.Text = "Afegir llibre";
            // 
            // LbModificar
            // 
            this.LbModificar.AutoSize = true;
            this.LbModificar.Location = new System.Drawing.Point(79, 131);
            this.LbModificar.Name = "LbModificar";
            this.LbModificar.Size = new System.Drawing.Size(74, 13);
            this.LbModificar.TabIndex = 5;
            this.LbModificar.Text = "Modificar llibre";
            // 
            // LbEliminar
            // 
            this.LbEliminar.AutoSize = true;
            this.LbEliminar.Location = new System.Drawing.Point(79, 215);
            this.LbEliminar.Name = "LbEliminar";
            this.LbEliminar.Size = new System.Drawing.Size(67, 13);
            this.LbEliminar.TabIndex = 7;
            this.LbEliminar.Text = "Eliminar llibre";
            // 
            // EliminarLlibre
            // 
            this.EliminarLlibre.BackgroundImage = global::UCBiblioteca.Properties.Resources.delete;
            this.EliminarLlibre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EliminarLlibre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EliminarLlibre.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.EliminarLlibre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarLlibre.Location = new System.Drawing.Point(27, 198);
            this.EliminarLlibre.Name = "EliminarLlibre";
            this.EliminarLlibre.Size = new System.Drawing.Size(46, 46);
            this.EliminarLlibre.TabIndex = 6;
            this.EliminarLlibre.UseVisualStyleBackColor = true;
            // 
            // afegirLlibre
            // 
            this.afegirLlibre.BackgroundImage = global::UCBiblioteca.Properties.Resources.plus;
            this.afegirLlibre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.afegirLlibre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.afegirLlibre.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.afegirLlibre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afegirLlibre.Location = new System.Drawing.Point(27, 32);
            this.afegirLlibre.Name = "afegirLlibre";
            this.afegirLlibre.Size = new System.Drawing.Size(46, 46);
            this.afegirLlibre.TabIndex = 4;
            this.afegirLlibre.UseVisualStyleBackColor = true;
            // 
            // ModificarLlibre
            // 
            this.ModificarLlibre.BackgroundImage = global::UCBiblioteca.Properties.Resources.more;
            this.ModificarLlibre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ModificarLlibre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModificarLlibre.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.ModificarLlibre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModificarLlibre.Location = new System.Drawing.Point(27, 114);
            this.ModificarLlibre.Name = "ModificarLlibre";
            this.ModificarLlibre.Size = new System.Drawing.Size(46, 46);
            this.ModificarLlibre.TabIndex = 5;
            this.ModificarLlibre.UseVisualStyleBackColor = true;
            // 
            // Llibre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.Llista);
            this.Controls.Add(this.Option);
            this.Name = "Llibre";
            this.Size = new System.Drawing.Size(1103, 510);
            this.Option.ResumeLayout(false);
            this.Option.PerformLayout();
            this.Llista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox Option;
        public System.Windows.Forms.GroupBox Llista;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EliminarLlibre;
        private System.Windows.Forms.Button afegirLlibre;
        private System.Windows.Forms.Button ModificarLlibre;
        private System.Windows.Forms.Label LbModificar;
        private System.Windows.Forms.Label LbEliminar;
        private System.Windows.Forms.Label LbAfegir;
    }
}
