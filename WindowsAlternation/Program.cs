using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAlternation
{
    static class Program
    {
        static public Form_nyito form_nyito = null;
        public static Form_Kutya form_kutya = null;
        public static Form_Madar form_madar = null;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form_nyito = new Form_nyito();
            form_kutya = new Form_Kutya();
            form_madar = new Form_Madar();
            Application.Run(form_nyito);
        }
    }
}
