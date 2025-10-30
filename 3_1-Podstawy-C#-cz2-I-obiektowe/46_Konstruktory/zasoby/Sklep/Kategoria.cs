using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    public class Kategoria
    {
        public string Nazwa { get; set; }
        public List<Produkt> Produkty { get; set; } = new List<Produkt>();
        public Kategoria(string nazwa)
        {
            Nazwa = nazwa;
        }

        public Produkt DodajProdukt(string nazwa, decimal cena)
        {
            Produkt produkt = new Produkt(nazwa, cena);
            Produkty.Add(produkt);
            return produkt;
        }

        public Produkt ZnajdzProdukt(string nazwa)
        {
            return Produkty.FirstOrDefault(p => p.Nazwa == nazwa);
        }

        public void UsunProdukt(string nazwa)
        {
            Produkt produkt = ZnajdzProdukt(nazwa);
            if (produkt != null)
            {
                Produkty.Remove(produkt);
            }
        }

        public void WyswietlProdukty()
        {
            Console.WriteLine($"Kategoria: {Nazwa}");
            foreach (var produkt in Produkty)
            {
                Console.WriteLine($"- {produkt.Nazwa}: {produkt.Cena} PLN");
            }
        }
    }
}
