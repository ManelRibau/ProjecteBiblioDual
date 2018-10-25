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
        //Login log = new Login();
        Label error1 = new Label();
        string Admin = "Manel";
        
        public void init()
        {
            initListeners();
            llib.Location = ubi;
            aut.Location = ubi;
            //log.Location = new Point(45, 46);
            //m1.Controls.Add(log);
            Application.Run(m1);
        }

        private void initListeners()
        {
            m1.llibreToolStripMenuItem.Click += afegirLlibre;
            m1.autorToolStripMenuItem.Click += afegirAutor;
            m1.LoginToolStripMenuItem.Click += tancarAplicacio;
            m1.welcome1.login1.Conect.Click += verificar;
           
        }

        private void verificar(object sender, EventArgs e)
        {
            if (m1.welcome1.login1.textBox1.Text.Equals(Admin))
            {
                m1.Controls.Remove(m1.welcome1);
            } else
            {
                error1.Size = new Size(400,150);
                error1.Location = new Point(m1.welcome1.login1.Location.X+10, m1.welcome1.login1.Location.Y+115);
                error1.Text = "Error: El nom d'usuari introduit no existeix";
                error1.ForeColor = Color.Red;
                m1.welcome1.Controls.Add(error1);
            }
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
