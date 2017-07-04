using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kosztorys
{
    public partial class Form_NowaUsługa : Form
    {
        Baza zamowienie;
        public Form_NowaUsługa(ref Baza zm, string nazwaUsługi)
        {
            InitializeComponent();
            txtBox_usługa.Text = nazwaUsługi;
            zamowienie = zm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajUsluge();
        }

        private void DodajUsluge()
        {
            if (decimal.TryParse(txtBox_Cena.Text, out decimal tempint) && txtBox_usługa.Text != "" && txtBox_usługa.Text != "")
            {
                zamowienie.DodajDoBazy(txtBox_usługa.Text, txtBox_Cena.Text, txtBox_Jednostka.Text);
                Close();
            }

            else
                MessageBox.Show("Nie podano wszystkich argumentów lub cena nie jest wartością liczbową.");
        }

        private void txtBox_Cena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBox_Jednostka.Select();
            }
        }

        private void txtBox_Jednostka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DodajUsluge();
            }
        }
    }
}
