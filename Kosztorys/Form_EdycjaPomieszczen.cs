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
    public partial class Form_EdycjaPomieszczen : Form
    {
        Zamowienie zamowienie;
        public Form_EdycjaPomieszczen(ref Zamowienie zamowienie)
        {
            InitializeComponent();
            this.zamowienie = zamowienie;
            OdswiezListe();
        }

        private void OdswiezListe()
        {
            listBox_EdycjaPomieszczen.Items.Clear();
            foreach (string lokum in zamowienie.Pomieszczenia)
            {
                listBox_EdycjaPomieszczen.Items.Add(lokum);
            }
        }

        private void btn_DodajPomieszczenie_Click(object sender, EventArgs e)
        {
            if (textBox_pomieszczenieDoDodania.Text != "")
            {
                zamowienie.Pomieszczenia.Add(textBox_pomieszczenieDoDodania.Text);
                OdswiezListe();
                textBox_pomieszczenieDoDodania.Clear();
            }
            else
            {
                MessageBox.Show("Wprowadź nazwę pomieszczenia!", "Nie wprowadzono nazwy pomieszczenia");
            }
        }

        private void btn_UsunPomieszczenie_Click(object sender, EventArgs e)
        {
            int indeks = listBox_EdycjaPomieszczen.SelectedIndex;
            zamowienie.Pomieszczenia.RemoveAt(indeks);
            OdswiezListe();
        }
    }
}
