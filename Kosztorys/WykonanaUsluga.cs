using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosztorys
{
    [Serializable]
    class WykonanaUsluga
    {
        public int ID { get; set; }
        public string Pomieszczenie { get; set; }
        public string Opis { get; set; }
        public string Długosc { get; set; }
        public string Szerokosc { get; set; }
        public string Wysokosc { get; set; }
        public double Ilosc { get; set; }
        public double Stawka { get; set; }
        public double Razem { get; set; }
        public string Uwagi { get; set; }

        public WykonanaUsluga(int id, string pomieszczenie, string opis, string dlugosc, string szerokosc, string wysokosc, double ilosc, double stawka, string uwagi )
        {
            this.ID = id;
            this.Pomieszczenie = pomieszczenie;
            this.Opis = opis;
            this.Długosc = dlugosc;
            this.Szerokosc = szerokosc;
            this.Wysokosc = wysokosc;
            this.Ilosc = ilosc;
            this.Stawka = stawka;
            this.Razem = ilosc * stawka;
            this.Uwagi = uwagi;
        }
    }
}
