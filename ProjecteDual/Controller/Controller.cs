using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace Controller
{
    public class Controller
    {
        Main m1 = new Main();
        public void init()
        {
            Application.Run(m1);
        }
    }
}
