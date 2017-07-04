using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Kosztorys
{
    [Serializable]
    public class Zamowienie
    {
        public string Klient { get; set; }
        public List<WykonanaUsluga> WykonaneUslugi;
        public List<string> Pomieszczenia;

        public Zamowienie(string klient)
        {
            this.Klient = klient;
            WykonaneUslugi = new List<WykonanaUsluga>();
            Pomieszczenia = new List<string>();
            DodajPodstawowePomieszczenia();
        }

        public void DodajWykonanaUsluge(WykonanaUsluga wykonanaUsluga)
        {
            WykonaneUslugi.Add(wykonanaUsluga);
            OdswiezIdUslug();
        }
        public void DodajPomieszczenie(string pomieszczenie)
        {
            Pomieszczenia.Add(pomieszczenie);
        }
        private void DodajPodstawowePomieszczenia()
        {
            //TODO: ustalić listę podstawowych pomieszczeń w pliku
            Pomieszczenia.Add("Pokój");
            Pomieszczenia.Add("Sypialnia");
            Pomieszczenia.Add("Mały pokój");
            Pomieszczenia.Add("Kuchnia");
            Pomieszczenia.Add("WC");
            Pomieszczenia.Add("Korytarz");
            Pomieszczenia.Add("Przedpokój");
            Pomieszczenia.Add("Antresola");
        }
        public string SumaRazem()
        {
            var suma = WykonaneUslugi.Sum(s => s.Razem);
            return suma.ToString() + " zł";
        }
        public void OdswiezIdUslug()
        {
            for (int i = 0; i < WykonaneUslugi.Count; i++)
            {
                WykonaneUslugi[i].Id = i + 1;
            }
        }
        public void UsunWgNumeruUslugi(int nrUslugiDoUsuniecia)
        {
            WykonaneUslugi.RemoveAt(nrUslugiDoUsuniecia);
            OdswiezIdUslug();
        }
    }
}
