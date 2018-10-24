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
    public partial class ISBN : UserControl
    {
        public ISBN()
        {
            InitializeComponent();
        }

        private void tbOnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Només números!");
            }
        }

        public string getText() { return tbOnlyNumbers.Text; }

        public string ISBNText
        {
            get
            {
                return this.tbOnlyNumbers.Text;
            }
            set
            {
                this.tbOnlyNumbers.Text = value;
            }
        }
    }
}
