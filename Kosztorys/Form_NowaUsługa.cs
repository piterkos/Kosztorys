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
            decimal tempint;
            if(decimal.TryParse(txtBox_Cena.Text, out tempint) && txtBox_usługa.Text != "" && txtBox_usługa.Text != "")
            {
                zamowienie.DodajDoBazy(txtBox_usługa.Text, txtBox_Cena.Text, txtBox_Jednostka.Text);
                this.Close();
            }
                
            else
                MessageBox.Show("Nie podano wszystkich argumentów lub cena nie jest wartością liczbową.");
        }
    }
}
