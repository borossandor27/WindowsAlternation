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
    public partial class Form_Kutya : Form
    {
        public Form_Kutya()
        {
            InitializeComponent();
        }

        private void button_Kutya_hozzaad_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Nev.Text))
            {
                MessageBox.Show("Nem adott meg nevet!");
                return;
            }
            else if(String.IsNullOrEmpty(textBox_szorzet.Text))
            {
                MessageBox.Show("Nem adta meg a szőrzetet");
                return;
            }
            else if (DateTime.Compare(DateTime.Now,dateTimePicker_Szuletett.Value)!= 1)
            {
                MessageBox.Show("Rossz dátum!");
                return;
            }
            else
            {
                Kutya uj = new Kutya(textBox_Nev.Text, dateTimePicker_Szuletett.Value, textBox_szorzet.Text);
                Program.form_nyito.listBox_Allat.Items.Add(uj);
            }
        }
    }
}
