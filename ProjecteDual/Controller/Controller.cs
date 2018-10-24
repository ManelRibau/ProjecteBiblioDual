using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCBiblioteca;
using View;

namespace Controller
{
    public class Controller
    {
        Main m1 = new Main();
        Point ubi = new Point(14, 27);
        Llibre llib = new Llibre();
        Autor aut = new Autor();
        
        public void init()
        {
            initListeners();
            llib.Location = ubi;
            aut.Location = ubi;
            Application.Run(m1);
        }

        private void initListeners()
        {
            m1.llibreToolStripMenuItem.Click += afegirLlibre;
            m1.autorToolStripMenuItem.Click += afegirAutor;
            m1.tancarToolStripMenuItem.Click += tancarAplicacio;
        }

        private void afegirAutor(object sender, EventArgs e)
        {
            DisposeControl();
            m1.Controls.Add(aut);
        }

        private void tancarAplicacio(object sender, EventArgs e)
        {
            m1.Close();
        }

        private void afegirLlibre(object sender, EventArgs e)
        {
            DisposeControl();
            m1.Controls.Add(llib);
        }
        public void DisposeControl()
        {
            foreach (Control ctr in m1.Controls)
            {
                if (ctr is UserControl)
                {
                    m1.Controls.Remove(ctr);
                }
            }
        }
    }
}
