using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonSamochodowy
{
    public class Samochod
    {
        public string Marka { get; set; }
        public string Kolor { get; set; }
        public int RokProdukcji { get; set; }
        public bool Dostepnosc { get; set; }

        private bool silnikUruchomiony = false;

        public void UruchomSilnik()
        {
            silnikUruchomiony = true;
            Console.WriteLine($"Uruchiony silnik w {Marka}");
        }

        public void Go()
        {
            if (silnikUruchomiony)
            {
                Console.WriteLine($"{Marka} ruszyło");
            }
            else
            {
                Console.WriteLine($"Najpierw uruchom silnik");
            }
        }

        public string ZwrocOferteSprzedaz()
        {
            if (Dostepnosc)
            {
                return $"{Marka} {Kolor} {RokProdukcji}";
            }
            else 
            {
                return $"Brak oferty sprzedaży";
            }
        }
    }
}
