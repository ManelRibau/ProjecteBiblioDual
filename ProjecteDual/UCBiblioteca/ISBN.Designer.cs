namespace UCBiblioteca
{
    partial class ISBN
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
            this.tbOnlyNumbers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbOnlyNumbers
            // 
            this.tbOnlyNumbers.Location = new System.Drawing.Point(0, 0);
            this.tbOnlyNumbers.Name = "tbOnlyNumbers";
            this.tbOnlyNumbers.Size = new System.Drawing.Size(152, 20);
            this.tbOnlyNumbers.TabIndex = 0;
            this.tbOnlyNumbers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOnlyNumbers_KeyPress);
            // 
            // ISBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbOnlyNumbers);
            this.Name = "ISBN";
            this.Size = new System.Drawing.Size(152, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbOnlyNumbers;
    }
}
