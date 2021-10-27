using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAlternation
{
    public partial class Form_nyito : Form
    {
        public Form_nyito()
        {
            InitializeComponent();
        }

        private void button_Kutya_Click(object sender, EventArgs e)
        {
            Program.form_kutya.ShowDialog();
        }

        private void button_Madar_Click(object sender, EventArgs e)
        {
            Program.form_madar.ShowDialog();
        }
    }
}
