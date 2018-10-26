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
    public partial class Llibre : UserControl
    {
        public Llibre()
        {
            InitializeComponent();
        }

        private void cancelar(object sender, EventArgs e)
        {
            
        }

        private void afegirLlibre_CheckedChanged(object sender, EventArgs e)
        {
            if (afegirLlibre.Checked == true)
            {
                foreach(Control ctr in Afegir.Controls)
                {
                    if (ctr is TextBox || ctr is ComboBox || ctr is ISBN)
                    {
                        ctr.Enabled = true;
                        ctr.Text = null;
                        isbn1.ISBNText = "";
                    }
                } 
            } else
            {
                foreach (Control ctr in Afegir.Controls)
                {
                    ctr.Enabled = false;
                }
            }
        }

        private void modificarLlibre_CheckedChanged(object sender, EventArgs e)
        {
            if (modificarLlibre.Checked == true)
            {
                foreach (Control ctr in Afegir.Controls)
                {
                    if (ctr is TextBox || ctr is ComboBox || ctr is ISBN)
                    {
                        ctr.Enabled = true;
                        ctr.Text = null;
                        isbn1.ISBNText = "";
                    }
                }
            }
            else
            {
                foreach (Control ctr in Afegir.Controls)
                {
                    ctr.Enabled = false;
                }
            }

        }
    }
}
