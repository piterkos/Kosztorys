using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosztorys
{
    public class Usluga
    {
        public string Czynność { get; set; }
        public string Cena { get; set; }
        public string JednostkaMiary { get; set; }
        public Usluga(string czynność, string cena, string jednostkaMiary)
        {
            this.Czynność = czynność;
            this.Cena = cena;
            this.JednostkaMiary = jednostkaMiary;
        }
    }
}
