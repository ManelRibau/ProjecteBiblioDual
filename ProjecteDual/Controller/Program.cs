using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    class Program
    {
        static void Main()
        {

            Application.EnableVisualStyles();
            Controller controller = new Controller();
            controller.init();
        }
    }
}
