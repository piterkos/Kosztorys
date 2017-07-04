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
        Wydruk drukuj;

        string NazwaKlienta;
        public Form1()
        {
            InitializeComponent();
            baza = new Baza(); 
            UzupelnijBazeUslug(CBox_BazaUslug);
        }

        private void btn_Drukuj_Click(object sender, EventArgs e)
        {
            if (zamowienie != null)
            {
                PrintDocument wydruk = new PrintDocument();
                drukuj = new Wydruk(zamowienie);
                wydruk.PrintPage += Wydruk_PrintPage;
                PrintPreviewDialog podglad = new PrintPreviewDialog();
                podglad.Document = wydruk;
                podglad.ShowDialog();
            }
            else
            {
                MessageBox.Show("Brak danych lub nie wybrano klienta. Wybierz lub dodaj klienta.", "Brak danych do drukowania...");
            }
        }
        
        private void Wydruk_PrintPage(object sender, PrintPageEventArgs e)
        {
            drukuj.UtworzWydruk(e);
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

        private void UzupelnijBazeUslug(ComboBox CBox_listaZadan)
        {
            baza = new Baza();
            foreach (var item in baza.Cennik)
            {
                CBox_BazaUslug.Items.Add(item.Czynność);
            }
        }

        private void CBox_BazaUslug_SelectedIndexChanged(object sender, EventArgs e)
        {
            UzupelnijCeneNaPodstawieWybranejCzynnosci();
            UzupelnijJednostkeMiaryNaPodstawieWybranejCzynnosci();
        }

        private void UzupelnijJednostkeMiaryNaPodstawieWybranejCzynnosci()
        {
            var miara = baza.Cennik.Where(w => w.Czynność == CBox_BazaUslug.Text).First().JednostkaMiary;
            lbl_JednostkaMiary.Text = "za " + miara;
            lbl_MiaraPrzyIlosci.Text = miara;
        }

        private void UzupelnijCeneNaPodstawieWybranejCzynnosci()
        {
            try
            {
                decimal cenka;
                var cena = baza.Cennik.Where(w => w.Czynność == CBox_BazaUslug.Text).ElementAtOrDefault(0).Cena;
                if (decimal.TryParse(cena, out cenka))
                    numericUpDown_Cena.Value = cenka;
            }
            catch (Exception)
            {
                lbl_bledy.Text = "Nie mogłem przypisać ceny na podstawie ybranej czynności";
            }
            
        }

        private void CBox_BazaUslug_KeyDown(object sender, KeyEventArgs e)
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
                if (CBox_BazaUslug.Items.Contains(CBox_BazaUslug.Text)) // jeżeli lista zadań zawiera wprowadzone zadanie to dopasuj cenę
                {
                    var cena = baza.Cennik.Where(w => w.Czynność == CBox_BazaUslug.SelectedItem.ToString()).ElementAtOrDefault(0).Cena;
                    numericUpDown_Cena.Value = decimal.Parse(cena);
                    numericUpDown_Ilosc.Select();
                }
                else
                {
                    Form_NowaUsługa dodajUsługę = new Form_NowaUsługa(ref baza, CBox_BazaUslug.Text);
                    dodajUsługę.ShowDialog();
                    UzupelnijBazeUslug(CBox_BazaUslug);
                    UzupelnijCeneNaPodstawieWybranejCzynnosci();
                    numericUpDown_Ilosc.Select();
                }
            }
        }

        private void btn_DodajUsluge_Click(object sender, EventArgs e)
        {
            if (SprawdzCzyWprowadzonoWszystkiePotrzebneDane())
            {
                DodajNowaUsluge();
                OdswiezFormularz();
                Zapisz();
            }
        }

        private void DodajNowaUsluge()
        {
                WykonanaUsluga nowaUsluga = new WykonanaUsluga(
                zamowienie.WykonaneUslugi.Count + 1,
                comboBox_Pomieszczenia.Text,
                CBox_BazaUslug.Text,
                numericUpDown_Dlugosc.Value.ToString(),
                numericUpDown_Szerokosc.Value.ToString(),
                numericUpDown_Wysokosc.Value.ToString(),
                (double)numericUpDown_Ilosc.Value,  // dodać niemożność dodania pomieszczenia którego nie ma w bazie pomieszczeń
                baza.Cennik.Where(w => w.Czynność == CBox_BazaUslug.SelectedItem.ToString()).First().JednostkaMiary,
                (double)numericUpDown_Cena.Value,
                txtBox_Uwagi.Text);

                zamowienie.DodajWykonanaUsluge(nowaUsluga);
                CBox_BazaUslug.Select();
            
        }

        private bool SprawdzCzyWprowadzonoWszystkiePotrzebneDane()
        {
            if (comboBox_Pomieszczenia.Text == "")
            {
                MessageBox.Show("Wprowadź nazwę pomieszczenia.", "Nie wprowadzono nazwy pomieszczenia");
                return false;
            }
            else if ( zamowienie == null)
            {
                MessageBox.Show("Nie wybrano lub nie dodano klienta. Nie można zatem dodać nowej usługi", "Dodaj lub otwórz klienta");
                return false;
            }
            else if (CBox_BazaUslug.Text == "")
            {
                MessageBox.Show("Wprowadź nazwę wykonywanej usługi", "Brak nazwy wykonanej usługi");
                return false;
            }
            else if (numericUpDown_Cena.Value == 0)
            {
                MessageBox.Show("Cena nie może posiadać wartości zerowej", "Cena = 0, takich rzeczy nie może być!");
                return false;
            }
            else if (numericUpDown_Ilosc.Value == 0)
            {
                MessageBox.Show("Ilość nie może być 0", "Podaj prawidłową wartość ilości wykonanej pracy");
                return false;
            }
            else if (zamowienie.Pomieszczenia.Contains(comboBox_Pomieszczenia.Text) == false)
            {
                MessageBox.Show("Najpierw dodaj pomieszczenie do bazy.\n Poprzez wprowadzenie nazwy i naciśnięcie ENTER lub \npoprzez wybór z menu Dodaj pomieszczenia", "Brak pomieszczenia w bazie");
                return false;
            }
            else if (!(baza.Cennik.Any(a=> a.Czynność == CBox_BazaUslug.Text)))
            {
                MessageBox.Show("Najpierw dodaj usługę poprzez wpisanie nazwy nowej usługi, a następnie ENTER\n PS. jeżeli wprowadzona nowa usługa nie występuje w bazie to należy ją najpierw dodać do bazy", "Brak usługi w bazie");
                return false;
            }
            else
                return true;
        }

        private void UstawLadnieDataGrindView(DataGridView dataGridView1)
        {
            //TODO: poustawiać data grind view
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.Columns[0].ToolTipText = "tol tip"; // wyświetla tekst po najechniu na nagłówek tabeli
            // pozmieniaj teksty nagłówków
            dataGridView1.Columns[3].HeaderText = "Dł";
            dataGridView1.Columns[4].HeaderText = "Sze";
            dataGridView1.Columns[5].HeaderText = "Wys";
            dataGridView1.Columns[7].HeaderText = "Miara";
            // poustawiaj preferowane szerokości
            dataGridView1.Columns[0].Width = 27;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 280;
            dataGridView1.Columns[3].Width = 40;
            dataGridView1.Columns[4].Width = 40;
            dataGridView1.Columns[5].Width = 40;
            dataGridView1.Columns[6].Width = 40;
            dataGridView1.Columns[7].Width = 40;
            dataGridView1.Columns[8].Width = 60;
            dataGridView1.Columns[9].Width = 60;
            dataGridView1.Columns[10].Width = 150;

        }
        //TODO: dodać zabezpieczenie jeżeli brak klientów
        //TODO: ustawić stałe szerokości tabeli, bo nie aktualizuje się podczas pracy
        //TODO: kodowanie znaków - nie działa - zrobić
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
                OdswiezFormularz();
            }
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zapisz();
        }

        private void Zapisz()
        {
            if (!Directory.Exists(@"C:\Kosztorys\Klienci"))
            {
                Directory.CreateDirectory(@"C:\Kosztorys\Klienci");
            }
            using (Stream plikWyjsciowy = File.Create(@"C:\Kosztorys\Klienci\" + zamowienie.Klient + ".dat"))
            {
                BinaryFormatter formater = new BinaryFormatter();
                formater.Serialize(plikWyjsciowy, zamowienie);
            }
            OdswiezFormularz();
        }

        private void otwórzKlientaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtworzArchiwalnegoKlienta();
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
                OdswiezFormularz();
                comboBox_Pomieszczenia.Select();
            }
            else
            {
                MessageBox.Show("Nie wybrano klienta do otwarcia!", "Operacja anulowana...");
            }
        }

        private void OdswiezFormularz()
        {
            zamowienie.OdswiezIdUslug();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = zamowienie.WykonaneUslugi;
            textBox_Razem.Text = zamowienie.SumaRazem();
            lbl_bledy.Text = "";
            UzupełnijListePomieszczen(comboBox_Pomieszczenia);
            comboBox_Pomieszczenia.AutoCompleteSource = AutoCompleteSource.ListItems;
            UstawLadnieDataGrindView(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            test();
        } //TODO: do usunięcia

        private void edytujPomieszczeniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtworzOknoEdycjiPomieszczen("");
        }

        private void OtworzOknoEdycjiPomieszczen(string tekstNowePomieszczenie)
        {
            Form_EdycjaPomieszczen oknoEdycjiPomieszczen = new Form_EdycjaPomieszczen(ref zamowienie,tekstNowePomieszczenie);
            oknoEdycjiPomieszczen.Show(this);
            UzupełnijListePomieszczen(comboBox_Pomieszczenia);
        }

        private void test() //TODO: do usunięcia testowa metoda
        {
            //string[] tablica = new string[10];
            //Console.WriteLine(dataGridView1.SelectedRows.GetEnumerator());
            //Console.WriteLine(dataGridView1.SelectedRows.Count);
            //dataGridView1.SelectedRows.CopyTo(tablica,0);
            //Console.WriteLine(tablica[3]);
            //Console.WriteLine(dataGridView1);
            //Console.WriteLine(dataGridView1);

        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zapisz();
            this.Close();
        }

        private void comboBox_Pomieszczenia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WyswietlPomieszczenieLubDodajNowe();
            }
        }
        /// <summary>
        /// Sprawdza czy nazwa pomieszczenia istnieje w bazie.
        /// Gdy brak to otwiera okno w celu dodania do bazy. Gdy jest to przechodzi do wyboru usługi.
        /// </summary>
        /// <param name="e"></param>
        private void WyswietlPomieszczenieLubDodajNowe()
        {
            if (zamowienie != null)
            {
                if (zamowienie.Pomieszczenia.Contains(comboBox_Pomieszczenia.Text))
                {
                    CBox_BazaUslug.Select();
                }
                else
                {
                    OtworzOknoEdycjiPomieszczen(comboBox_Pomieszczenia.Text);
                }
            }
            else if (zamowienie == null)
            {
                comboBox_Pomieszczenia.Text = "Dodaj klienta lub otwórz z archiwum";
                comboBox_Pomieszczenia.SelectAll();
            }
        }
        /// <summary>
        /// Dodaj nową usługę po naciśnięciu ENTER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown_Ilosc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && SprawdzCzyWprowadzonoWszystkiePotrzebneDane())
            {
                DodajNowaUsluge();
                OdswiezFormularz();
                Zapisz();
            }
        }

        private void btn_UsunWgZaznaczenia_Click(object sender, EventArgs e)
        {
            try
            {
                int zaznaczonyWpis = dataGridView1.CurrentCell.RowIndex;
                zamowienie.UsunWgNumeruUslugi(zaznaczonyWpis);
                OdswiezFormularz();
            }
            catch (Exception)
            {
                lbl_bledy.Text = "nie wybrano wpisu";
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lbl_bledy.Text = e.RowIndex.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd cell klik");
            }
            
        }
    }
}
