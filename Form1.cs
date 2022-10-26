using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1CUCC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bekuldes_gomb_Click(object sender, EventArgs e)
        {
 
            if (numericUpDown1_azonosito.Value == 0 || string.IsNullOrEmpty(textBox1_nev.Text) || nyelvek.SelectedIndex == -1|| Datum.Value> DateTime.Today)
            {

                MessageBox.Show("Figyelmetlen!", "Az adatok nem lettek be lett küdve!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                
            else
            {
                MessageBox.Show("Köszi!", "Az adatok be lett küdve!", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
        }
    }
}
