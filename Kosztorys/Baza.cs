using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kosztorys
{
    public class Baza
    {
        public List<Usluga> Cennik;
        string ścięzkaDoBazy = @"D:\OneDrive\Dokumenty\Visual Studio 2017\Projects\Kosztorys\Baza prac wykończeniowych.txt";

        public Baza()
        {
            StwórzBazę();
        }
        private void StwórzBazę()
        {
            Cennik = new List<Usluga>();
            OdczytajPlikBazy();
        }

        private void OdczytajPlikBazy()
        {
            if (File.Exists(ścięzkaDoBazy))
            {
                using (StreamReader sr = new StreamReader(ścięzkaDoBazy,Encoding.Default))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] tablicaBazy = new string[3];
                        tablicaBazy = sr.ReadLine().Split(';');
                        Cennik.Add(new Usluga(tablicaBazy[0], tablicaBazy[1], tablicaBazy[2]));
                    }
                }
            }
            else
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Title = "Wskaż plik z bazą!";
                openFile.ShowDialog();
                ścięzkaDoBazy = openFile.FileName;
                using (StreamReader sr = new StreamReader(ścięzkaDoBazy))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] tablicaBazy = new string[3];
                        tablicaBazy = sr.ReadLine().Split(';');
                        Cennik.Add(new Usluga(tablicaBazy[0], tablicaBazy[1], tablicaBazy[2]));
                    }
                }
            }
        }

        public void DodajDoBazy(string czynność, string cena, string jednostkaMiary)
        {
            if (File.Exists(ścięzkaDoBazy))
            {
                using (StreamWriter sw = File.AppendText(ścięzkaDoBazy))
                {
                    sw.WriteLine(czynność + ";" + cena + ";" + jednostkaMiary);
                }
            }
            else
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Title = "Wskaż plik z bazą!";
                openFile.ShowDialog();
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    ścięzkaDoBazy = openFile.FileName;
                    using (StreamWriter sw = File.AppendText(ścięzkaDoBazy))
                    {
                        sw.WriteLine(czynność + ";" + cena + ";" + jednostkaMiary);
                    }
                }
            }
            
        }
    }
}
