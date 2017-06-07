using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Kosztorys
{
    [Serializable]
    class Zamowienie
    {
        public string Klient { get; set; }
        public List<WykonanaUsluga> WykonaneUslugi;

        public Zamowienie(string klient)
        {
            this.Klient = klient;
            WykonaneUslugi = new List<WykonanaUsluga>();
        }

        public void DodajWykonanaUsluge(WykonanaUsluga wykonanaUsluga)
        {
            WykonaneUslugi.Add(wykonanaUsluga);
        }
    }
}
