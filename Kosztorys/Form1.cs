using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        Baza baza;
        Zamowienie zamowienie;
        string NazwaKlienta;
        public Form1()
        {
            InitializeComponent();
            baza = new Baza(); // TODO: usunąć na końcu i wrzuć pod odpowiednie przyciski inicjalizowanie nowej bazy
            UzupelnijListęUslug(CBox_listaZadań);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDocument wydruk = new PrintDocument();
            wydruk.PrintPage += Wydruk_PrintPage;
            PrintPreviewDialog podglad = new PrintPreviewDialog();
            podglad.Document = wydruk;
            podglad.ShowDialog();
        }

        private void Wydruk_PrintPage(object sender, PrintPageEventArgs e)
        {
            Wydruk wydruk = new Wydruk(e.Graphics, zamowienie);
            wydruk.UtworzWydruk();
        }

        private void UzupełnijListePomieszczen(ComboBox listaNaPomieszczenia)
        {
            listaNaPomieszczenia.Items.Clear();
            if (zamowienie != null)
            {
                foreach (string lokal in zamowienie.Pomieszczenia)
                {
                    listaNaPomieszczenia.Items.Add(lokal);
                }
            }
        }

        private void UzupelnijListęUslug(ComboBox CBox_listaZadan)
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
                    UzupelnijListęUslug(CBox_listaZadań);
                    UzupelnijCeneNaPodstawieWybranejCzynnosci();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WykonanaUsluga nowaUsluga = new WykonanaUsluga(
                comboBox_Pomieszczenia.Text,
                CBox_listaZadań.Text,
                numericUpDown_Dlugosc.Value.ToString(),
                numericUpDown_Szerokosc.Value.ToString(),
                numericUpDown_Wysokosc.Value.ToString(),
                (double)numericUpDown_Ilosc.Value,
                (double)numericUpDown_Cena.Value,
                txtBox_Uwagi.Text);
            zamowienie.DodajWykonanaUsluge(nowaUsluga);
            OdswiezDataGrindView();
            UstawLadnieDataGrindView(dataGridView1);
            textBox_Razem.Text = zamowienie.SumaRazem();
        }

        private void UstawLadnieDataGrindView(DataGridView dataGridView1)
        {
            //TODO: poustawiać data grind view
        }

        private void dodajKlientaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajNowegoKlienta();
        }

        private void DodajNowegoKlienta()
        {
            Form_NowyKlient oknoNowyKlient = new Form_NowyKlient();
            if(oknoNowyKlient.ShowDialog(this) == DialogResult.Cancel)
            {
                MessageBox.Show("Aby kontynuować należy wprowadzić nazwę klienta.", "Nie wprowadzono nazwy klienta!");
            }
            else
            {
                zamowienie = new Zamowienie(oknoNowyKlient.NazwaKlienta);
                lbl_Klient.Text = zamowienie.Klient;
                this.NazwaKlienta = zamowienie.Klient;
            }
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zapisz();
        }

        private void Zapisz()
        {
            if (!Directory.Exists(Environment.CurrentDirectory + @"\Klienci"))
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\Klienci");
            }
            using (Stream plikWyjsciowy = File.Create(Environment.CurrentDirectory + @"\Klienci\" +NazwaKlienta + ".dat"))
            {
                BinaryFormatter formater = new BinaryFormatter();
                formater.Serialize(plikWyjsciowy, zamowienie);
            }
        }

        private void otwórzKlientaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtworzArchiwalnegoKlienta();
            textBox_Razem.Text = zamowienie.SumaRazem();
        }

        private void OtworzArchiwalnegoKlienta()
        {
            Form_wyborKlientaDoOdtworzenia okno_KlientDoOdtworzenia = new Form_wyborKlientaDoOdtworzenia();
            okno_KlientDoOdtworzenia.ShowDialog();
            if (okno_KlientDoOdtworzenia.DialogResult != DialogResult.Cancel) // jeżeli wynik działania nie jest równy cancel to ustaw wybranego klienta
            {
                string sciezkaDoPliku = okno_KlientDoOdtworzenia.ZwrocSciezkeDoPlikuKlienta(); // pobiera wybranego klienta, a dokładnie ścięzkę do pliku serializacji
                lbl_Klient.Text = okno_KlientDoOdtworzenia.NazwaKlienta; // ustaw nazwę klienta
                //TODO: otwórz klienta wg nazwy
                using (Stream wejscie = File.OpenRead(sciezkaDoPliku))
                {
                    BinaryFormatter formater = new BinaryFormatter();
                    zamowienie = (Zamowienie)formater.Deserialize(wejscie);
                }
                OdswiezDataGrindView();
            }
            else
            {
                MessageBox.Show("Nie wybrano klienta do otwarcia!", "Operacja anulowana...");
            }
        }

        private void OdswiezDataGrindView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = zamowienie.WykonaneUslugi;
        }

        //TODO: do usunięcia
        private void button3_Click(object sender, EventArgs e)
        {
            test();
        }

        private void edytujPomieszczeniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_EdycjaPomieszczen oknoEdycjiPomieszczen = new Form_EdycjaPomieszczen(ref zamowienie);
            oknoEdycjiPomieszczen.Show(this);
            UzupełnijListePomieszczen(comboBox_Pomieszczenia);
            
        }

        private void comboBox_Pomieszczenia_Click(object sender, EventArgs e)
        {
            UzupełnijListePomieszczen(comboBox_Pomieszczenia);
        }
        private void test() //TODO: do usunięcia testowa metoda
        {
            string[] tablica = new string[10];
            Console.WriteLine(dataGridView1.SelectedRows.GetEnumerator());
            Console.WriteLine(dataGridView1.SelectedRows.Count);
            dataGridView1.SelectedRows.CopyTo(tablica,0);
            Console.WriteLine(tablica[3]);
            Console.WriteLine(dataGridView1);
            Console.WriteLine(dataGridView1);

        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zapisz();
            this.Close();
        }
    }
}
