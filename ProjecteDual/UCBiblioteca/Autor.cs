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
    public partial class Autor : UserControl
    {
        public Autor()
        {
            InitializeComponent();
        }

        private void afegirAutor_CheckedChanged(object sender, EventArgs e)
        {
            if (afegirAutor.Checked == true)
            {
                foreach (Control ctr in Afegir.Controls)
                {
                    if (ctr is TextBox || ctr is UserControl)
                    {
                        ctr.Enabled = true;
                        ctr.Text = null;
                        onlyLetters1.OnlyLettersText = "";
                        onlyLetters2.OnlyLettersText = "";
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

        private void modificarAutor_CheckedChanged(object sender, EventArgs e)
        {

            if (modificarAutor.Checked == true)
            {
                foreach (Control ctr in Afegir.Controls)
                {
                    if (ctr is TextBox ||  ctr is UserControl)
                    {
                        ctr.Enabled = true;
                        ctr.Text = null;
                        onlyLetters1.OnlyLettersText = "";
                        onlyLetters2.OnlyLettersText = "";
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
