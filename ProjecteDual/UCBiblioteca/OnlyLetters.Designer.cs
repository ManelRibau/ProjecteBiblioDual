namespace UCBiblioteca
{
    partial class OnlyLetters
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
            this.tbOnlyLetters = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbOnlyLetters
            // 
            this.tbOnlyLetters.Location = new System.Drawing.Point(0, 0);
            this.tbOnlyLetters.Name = "tbOnlyLetters";
            this.tbOnlyLetters.Size = new System.Drawing.Size(152, 20);
            this.tbOnlyLetters.TabIndex = 0;
            this.tbOnlyLetters.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOnlyLetters_KeyPress);
            // 
            // OnlyLetters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbOnlyLetters);
            this.Name = "OnlyLetters";
            this.Size = new System.Drawing.Size(152, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOnlyLetters;
    }
}
