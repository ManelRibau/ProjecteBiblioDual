using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCBiblioteca
{
    public partial class OnlyLetters : UserControl
    {
        public OnlyLetters()
        {
            InitializeComponent();
        }

        private void tbOnlyLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(Keys.Separator))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Només lletres!");
            }
        }

        public string getText() { return tbOnlyLetters.Text; }

        public string OnlyLettersText
        {
            get
            {
                return this.tbOnlyLetters.Text;
            }
            set
            {
                this.tbOnlyLetters.Text = value;
            }
        }
    }
}