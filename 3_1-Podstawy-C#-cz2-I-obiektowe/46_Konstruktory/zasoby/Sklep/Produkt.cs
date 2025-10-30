using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    public class Produkt
    {
        public string Nazwa { get; set; }
        public decimal Cena { get; set; }

        public Produkt(string nazwa, decimal cena)
        {
            Nazwa = nazwa;
            Cena = cena;
        }
    }
}
