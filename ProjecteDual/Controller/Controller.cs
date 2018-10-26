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
        Welcome welcome1 = new Welcome();
        Cancel c1 = new Cancel();
        UCBiblioteca.Menu m = new UCBiblioteca.Menu();
        //Login log = new Login();
        Label error1 = new Label();
        string Admin = "Manel";
        
        public void init()
        {
            welcome1.Location = ubi;
            initListeners();
            llib.Location = ubi;
            aut.Location = ubi;
            m.Location = ubi;
            c1.Location = new Point(21, 479);
            m1.Controls.Add(welcome1);
            //log.Location = new Point(45, 46);
            //m1.Controls.Add(log);
            Application.Run(m1);
            
        }

        private void initListeners()
        {
            m.button1.Click += afegirLlibre;
            m.button7.Click += afegirAutor;
            m1.LoginToolStripMenuItem.Click += tancarAplicacio;
            welcome1.login1.Conect.Click += verificar;
            
           
        }

        private void verificar(object sender, EventArgs e)
        {
            if (welcome1.login1.textBox1.Text.Equals(Admin))
            {
                m1.Controls.Remove(welcome1);
                m1.Controls.Add(m);
            } else
            {
                error1.Size = new Size(400,150);
                error1.Location = new Point(welcome1.login1.Location.X+10, welcome1.login1.Location.Y+115);
                error1.Text = "Error: El nom d'usuari introduit no existeix";
                error1.ForeColor = Color.Red;
                welcome1.Controls.Add(error1);
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
            m1.Controls.Add(c1);
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
