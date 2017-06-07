using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kosztorys
{
    public delegate Usluga DodajDoBazy(string nowyWpis);

    public partial class Form1 : Form
    {
        int Id = 1;
        string Pomieszczenie = "Pokój";     //TODO: wprowadzić możliwość wyboru pomieszczeń
        Baza baza;
        Zamowienie zamowienie;
        public Form1()
        {
            //TODO: wprowadzić nazwę klienta podczas tworzenia nowego zlecenia
            InitializeComponent();
            baza = new Baza(); // TODO: usunąć na końcu i wrzuć pod odpowiednie przyciski inicjalizowanie nowej bazy
            zamowienie = new Zamowienie("test klient"); // TODO: przenieść pod odpowiedni przycisk na końcu
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UzupelnijListęUslug();
        }

        private void UzupelnijListęUslug()
        {
            baza = new Baza();
            foreach (var item in baza.Cennik)
            {
                CBox_listaZadań.Items.Add(item.Czynność);
            }
        }

        private void CBox_listaZadań_SelectedIndexChanged(object sender, EventArgs e)
        {
            UzupelnijCeneNaPodstawieWybranejCzynnosci();
        }

        private void UzupelnijCeneNaPodstawieWybranejCzynnosci()
        {
            decimal cenka;
            var cena = baza.Cennik.Where(w => w.Czynność == CBox_listaZadań.Text).ElementAtOrDefault(0).Cena;
            if (decimal.TryParse(cena, out cenka))
                numericUpDown_Cena.Value = cenka;
        }

        private void CBox_listaZadań_KeyDown(object sender, KeyEventArgs e)
        {
            WyswietlaCeneLubDodajUsluge(e);
        }
        /// <summary>
        /// Po naciśnięciu ENTER sprawdza czy wprowadzone zadanie występuje w bazie i albo wyświetla cenę, albo gdy brak to wyświetla nowe okno w celu wprowadzenia nowej usługi
        /// </summary>
        /// <param name="e"></param>
        private void WyswietlaCeneLubDodajUsluge(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (CBox_listaZadań.Items.Contains(CBox_listaZadań.Text)) // jeżeli lista zadań zawiera wprowadzone zadanie to dopasuj cenę
                {
                    var cena = baza.Cennik.Where(w => w.Czynność == CBox_listaZadań.SelectedItem.ToString()).ElementAtOrDefault(0).Cena;
                    numericUpDown_Cena.Value = decimal.Parse(cena);
                }
                else
                {
                    Form_NowaUsługa dodajUsługę = new Form_NowaUsługa(ref baza, CBox_listaZadań.Text);
                    dodajUsługę.ShowDialog();
                    UzupelnijListęUslug();
                    UzupelnijCeneNaPodstawieWybranejCzynnosci();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.DataSource == null)
            //    dataGridView1.DataSource = zamowienie.WykonaneUslugi;
            WykonanaUsluga nowaUsluga = new WykonanaUsluga(
                Id++,
                Pomieszczenie,
                CBox_listaZadań.Text,
                numericUpDown_Dlugosc.Value.ToString(),
                numericUpDown_Szerokosc.Value.ToString(),
                numericUpDown_Wysokosc.Value.ToString(),
                (double)numericUpDown_Ilosc.Value,
                (double)numericUpDown_Cena.Value,
                txtBox_Uwagi.Text);
            zamowienie.DodajWykonanaUsluge(nowaUsluga);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = zamowienie.WykonaneUslugi;
        }

        private void dodajKlientaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Environment.CurrentDirectory + @"\Klienci"))
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\Klienci");
            using (Stream plikWyjsciowy = File.Create(Environment.CurrentDirectory + @"\Klienci\plik.dat"))
            {
                BinaryFormatter formater = new BinaryFormatter();
                formater.Serialize(plikWyjsciowy, zamowienie);
            }
        }

        private void otwórzKlientaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: otwórz klienta wg nazwy
            using (Stream wejscie = File.OpenRead(Environment.CurrentDirectory + @"\Klienci\plik.dat"))
            {
                BinaryFormatter formater = new BinaryFormatter();
                zamowienie = (Zamowienie)formater.Deserialize(wejscie);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = zamowienie.WykonaneUslugi;
        }
    }
}
