using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kosztorys
{
    public partial class Form_wyborKlientaDoOdtworzenia : Form
    {
        List<string> listaPlikow;
        public string NazwaKlienta { get; private set; }

        public Form_wyborKlientaDoOdtworzenia()
        {
            InitializeComponent();
            PobierzListePlikow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox_KlienciArchiwum.SelectedItem != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Wybierz klienta lub zamknij okno naciskając [X]", "Nie wybrano klienta");
        }

        public string ZwrocSciezkeDoPlikuKlienta()
        {
            if(listBox_KlienciArchiwum.SelectedItem != null)
            {
                this.DialogResult = DialogResult.OK;
                NazwaKlienta = Path.GetFileNameWithoutExtension(listaPlikow[listBox_KlienciArchiwum.SelectedIndex]);
                return listaPlikow[listBox_KlienciArchiwum.SelectedIndex];
            }
            return "Nie zdefiniowano klienta";
        }

        private void PobierzListePlikow()
        {
            listaPlikow = new List<string>();
            if(!Directory.Exists(@"C:\Kosztorys\Klienci"))
                Directory.CreateDirectory(@"C:\Kosztorys\Klienci");
            listaPlikow = Directory.GetFiles(@"C:\Kosztorys\Klienci\").ToList();
            foreach (string plik in listaPlikow)
            {
                string nazwaPliku = Path.GetFileNameWithoutExtension(plik);
                listBox_KlienciArchiwum.Items.Add(nazwaPliku);
            }
        }

        private void listBox_KlienciArchiwum_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_KlienciArchiwum.SelectedItem != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Wybierz klienta lub zamknij okno naciskając [X]", "Nie wybrano klienta");
        }
    }
}
